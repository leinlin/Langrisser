using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000652 RID: 1618
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProBattleProcessing")]
	[Serializable]
	public class ProBattleProcessing : IExtensible
	{
		// Token: 0x06005855 RID: 22613 RVA: 0x0019AC7C File Offset: 0x00198E7C
		public ProBattleProcessing()
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

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x06005856 RID: 22614 RVA: 0x0019ACF0 File Offset: 0x00198EF0
		// (set) Token: 0x06005857 RID: 22615 RVA: 0x0019ACF8 File Offset: 0x00198EF8
		[ProtoMember(1, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public int Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				this._Type = value;
			}
		}

		// Token: 0x170015F1 RID: 5617
		// (get) Token: 0x06005858 RID: 22616 RVA: 0x0019AD04 File Offset: 0x00198F04
		// (set) Token: 0x06005859 RID: 22617 RVA: 0x0019AD0C File Offset: 0x00198F0C
		[ProtoMember(2, IsRequired = true, Name = "TypeId", DataFormat = DataFormat.TwosComplement)]
		public int TypeId
		{
			get
			{
				return this._TypeId;
			}
			set
			{
				this._TypeId = value;
			}
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x0600585A RID: 22618 RVA: 0x0019AD18 File Offset: 0x00198F18
		// (set) Token: 0x0600585B RID: 22619 RVA: 0x0019AD20 File Offset: 0x00198F20
		[ProtoMember(3, IsRequired = true, Name = "RandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int RandomSeed
		{
			get
			{
				return this._RandomSeed;
			}
			set
			{
				this._RandomSeed = value;
			}
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x0600585C RID: 22620 RVA: 0x0019AD2C File Offset: 0x00198F2C
		// (set) Token: 0x0600585D RID: 22621 RVA: 0x0019AD34 File Offset: 0x00198F34
		[ProtoMember(4, IsRequired = true, Name = "ArmyRandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int ArmyRandomSeed
		{
			get
			{
				return this._ArmyRandomSeed;
			}
			set
			{
				this._ArmyRandomSeed = value;
			}
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x0600585E RID: 22622 RVA: 0x0019AD40 File Offset: 0x00198F40
		[ProtoMember(5, Name = "Params", DataFormat = DataFormat.TwosComplement)]
		public List<int> Params
		{
			get
			{
				return this._Params;
			}
		}

		// Token: 0x0600585F RID: 22623 RVA: 0x0019AD48 File Offset: 0x00198F48
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x0019AD58 File Offset: 0x00198F58
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

		// Token: 0x06005861 RID: 22625 RVA: 0x0019AE24 File Offset: 0x00199024
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBattleProcessing));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400424E RID: 16974
		private int _Type;

		// Token: 0x0400424F RID: 16975
		private int _TypeId;

		// Token: 0x04004250 RID: 16976
		private int _RandomSeed;

		// Token: 0x04004251 RID: 16977
		private int _ArmyRandomSeed;

		// Token: 0x04004252 RID: 16978
		private readonly List<int> _Params = new List<int>();

		// Token: 0x04004253 RID: 16979
		private IExtension extensionObject;

		// Token: 0x04004254 RID: 16980
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004255 RID: 16981
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004256 RID: 16982
		private LuaFunction m_ctor_hotfix;
	}
}
