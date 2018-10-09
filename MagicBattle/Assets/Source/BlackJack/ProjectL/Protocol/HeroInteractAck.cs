using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007C6 RID: 1990
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroInteractAck")]
	[Serializable]
	public class HeroInteractAck : IExtensible
	{
		// Token: 0x060065C4 RID: 26052 RVA: 0x001C6D04 File Offset: 0x001C4F04
		public HeroInteractAck()
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

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x060065C5 RID: 26053 RVA: 0x001C6D6C File Offset: 0x001C4F6C
		// (set) Token: 0x060065C6 RID: 26054 RVA: 0x001C6D74 File Offset: 0x001C4F74
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x060065C7 RID: 26055 RVA: 0x001C6D80 File Offset: 0x001C4F80
		// (set) Token: 0x060065C8 RID: 26056 RVA: 0x001C6D88 File Offset: 0x001C4F88
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x060065C9 RID: 26057 RVA: 0x001C6D94 File Offset: 0x001C4F94
		// (set) Token: 0x060065CA RID: 26058 RVA: 0x001C6D9C File Offset: 0x001C4F9C
		[ProtoMember(3, IsRequired = true, Name = "AddFavorabilityExp", DataFormat = DataFormat.TwosComplement)]
		public int AddFavorabilityExp
		{
			get
			{
				return this._AddFavorabilityExp;
			}
			set
			{
				this._AddFavorabilityExp = value;
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x060065CB RID: 26059 RVA: 0x001C6DA8 File Offset: 0x001C4FA8
		// (set) Token: 0x060065CC RID: 26060 RVA: 0x001C6DB0 File Offset: 0x001C4FB0
		[ProtoMember(4, IsRequired = true, Name = "HeroInteractResult", DataFormat = DataFormat.TwosComplement)]
		public int HeroInteractResult
		{
			get
			{
				return this._HeroInteractResult;
			}
			set
			{
				this._HeroInteractResult = value;
			}
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x060065CD RID: 26061 RVA: 0x001C6DBC File Offset: 0x001C4FBC
		// (set) Token: 0x060065CE RID: 26062 RVA: 0x001C6DC4 File Offset: 0x001C4FC4
		[DefaultValue(null)]
		[ProtoMember(5, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x001C6DD0 File Offset: 0x001C4FD0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x001C6DE0 File Offset: 0x001C4FE0
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

		// Token: 0x060065D1 RID: 26065 RVA: 0x001C6EAC File Offset: 0x001C50AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroInteractAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C40 RID: 19520
		private int _Result;

		// Token: 0x04004C41 RID: 19521
		private int _HeroId;

		// Token: 0x04004C42 RID: 19522
		private int _AddFavorabilityExp;

		// Token: 0x04004C43 RID: 19523
		private int _HeroInteractResult;

		// Token: 0x04004C44 RID: 19524
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004C45 RID: 19525
		private IExtension extensionObject;

		// Token: 0x04004C46 RID: 19526
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C47 RID: 19527
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C48 RID: 19528
		private LuaFunction m_ctor_hotfix;
	}
}
