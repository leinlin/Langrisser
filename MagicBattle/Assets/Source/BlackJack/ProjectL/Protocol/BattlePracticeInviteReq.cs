using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006DD RID: 1757
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattlePracticeInviteReq")]
	[Serializable]
	public class BattlePracticeInviteReq : IExtensible
	{
		// Token: 0x06005E26 RID: 24102 RVA: 0x001ABCCC File Offset: 0x001A9ECC
		public BattlePracticeInviteReq()
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

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06005E27 RID: 24103 RVA: 0x001ABD34 File Offset: 0x001A9F34
		// (set) Token: 0x06005E28 RID: 24104 RVA: 0x001ABD3C File Offset: 0x001A9F3C
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

		// Token: 0x06005E29 RID: 24105 RVA: 0x001ABD48 File Offset: 0x001A9F48
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x001ABD58 File Offset: 0x001A9F58
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

		// Token: 0x06005E2B RID: 24107 RVA: 0x001ABE24 File Offset: 0x001AA024
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePracticeInviteReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400467A RID: 18042
		private string _TargetUserId;

		// Token: 0x0400467B RID: 18043
		private IExtension extensionObject;

		// Token: 0x0400467C RID: 18044
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400467D RID: 18045
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400467E RID: 18046
		private LuaFunction m_ctor_hotfix;
	}
}
