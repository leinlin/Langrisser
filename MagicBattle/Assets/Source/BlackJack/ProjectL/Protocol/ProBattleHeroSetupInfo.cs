using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000686 RID: 1670
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProBattleHeroSetupInfo")]
	[Serializable]
	public class ProBattleHeroSetupInfo : IExtensible
	{
		// Token: 0x06005B01 RID: 23297 RVA: 0x001A179C File Offset: 0x0019F99C
		public ProBattleHeroSetupInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x06005B02 RID: 23298 RVA: 0x001A1804 File Offset: 0x0019FA04
		// (set) Token: 0x06005B03 RID: 23299 RVA: 0x001A180C File Offset: 0x0019FA0C
		[ProtoMember(1, IsRequired = true, Name = "PlayerIndex", DataFormat = DataFormat.TwosComplement)]
		public int PlayerIndex
		{
			get
			{
				return this._PlayerIndex;
			}
			set
			{
				this._PlayerIndex = value;
			}
		}

		// Token: 0x170016F3 RID: 5875
		// (get) Token: 0x06005B04 RID: 23300 RVA: 0x001A1818 File Offset: 0x0019FA18
		// (set) Token: 0x06005B05 RID: 23301 RVA: 0x001A1820 File Offset: 0x0019FA20
		[ProtoMember(2, IsRequired = true, Name = "Position", DataFormat = DataFormat.TwosComplement)]
		public int Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				this._Position = value;
			}
		}

		// Token: 0x170016F4 RID: 5876
		// (get) Token: 0x06005B06 RID: 23302 RVA: 0x001A182C File Offset: 0x0019FA2C
		// (set) Token: 0x06005B07 RID: 23303 RVA: 0x001A1834 File Offset: 0x0019FA34
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "Hero", DataFormat = DataFormat.Default)]
		public ProBattleHero Hero
		{
			get
			{
				return this._Hero;
			}
			set
			{
				this._Hero = value;
			}
		}

		// Token: 0x170016F5 RID: 5877
		// (get) Token: 0x06005B08 RID: 23304 RVA: 0x001A1840 File Offset: 0x0019FA40
		// (set) Token: 0x06005B09 RID: 23305 RVA: 0x001A1848 File Offset: 0x0019FA48
		[ProtoMember(4, IsRequired = true, Name = "Flag", DataFormat = DataFormat.TwosComplement)]
		public int Flag
		{
			get
			{
				return this._Flag;
			}
			set
			{
				this._Flag = value;
			}
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x001A1854 File Offset: 0x0019FA54
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B0B RID: 23307 RVA: 0x001A1864 File Offset: 0x0019FA64
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06005B0C RID: 23308 RVA: 0x001A1930 File Offset: 0x0019FB30
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBattleHeroSetupInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004420 RID: 17440
		private int _PlayerIndex;

		// Token: 0x04004421 RID: 17441
		private int _Position;

		// Token: 0x04004422 RID: 17442
		private ProBattleHero _Hero;

		// Token: 0x04004423 RID: 17443
		private int _Flag;

		// Token: 0x04004424 RID: 17444
		private IExtension extensionObject;

		// Token: 0x04004425 RID: 17445
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004426 RID: 17446
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004427 RID: 17447
		private LuaFunction m_ctor_hotfix;
	}
}
