using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006DF RID: 1759
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattlePracticeAcceptReq")]
	[Serializable]
	public class BattlePracticeAcceptReq : IExtensible
	{
		// Token: 0x06005E32 RID: 24114 RVA: 0x001AC04C File Offset: 0x001AA24C
		public BattlePracticeAcceptReq()
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

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06005E33 RID: 24115 RVA: 0x001AC0B4 File Offset: 0x001AA2B4
		// (set) Token: 0x06005E34 RID: 24116 RVA: 0x001AC0BC File Offset: 0x001AA2BC
		[ProtoMember(1, IsRequired = true, Name = "TargetUserId", DataFormat = DataFormat.Default)]
		public string TargetUserId
		{
			get
			{
				return this._TargetUserId;
			}
			set
			{
				this._TargetUserId = value;
			}
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x001AC0C8 File Offset: 0x001AA2C8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x001AC0D8 File Offset: 0x001AA2D8
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

		// Token: 0x06005E37 RID: 24119 RVA: 0x001AC1A4 File Offset: 0x001AA3A4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePracticeAcceptReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004684 RID: 18052
		private string _TargetUserId;

		// Token: 0x04004685 RID: 18053
		private IExtension extensionObject;

		// Token: 0x04004686 RID: 18054
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004687 RID: 18055
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004688 RID: 18056
		private LuaFunction m_ctor_hotfix;
	}
}
