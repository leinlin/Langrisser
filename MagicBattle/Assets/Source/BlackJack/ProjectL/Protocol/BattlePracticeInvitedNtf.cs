using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006E3 RID: 1763
	[ProtoContract(Name = "BattlePracticeInvitedNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattlePracticeInvitedNtf : IExtensible
	{
		// Token: 0x06005E4C RID: 24140 RVA: 0x001AC760 File Offset: 0x001AA960
		public BattlePracticeInvitedNtf()
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

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06005E4D RID: 24141 RVA: 0x001AC7C8 File Offset: 0x001AA9C8
		// (set) Token: 0x06005E4E RID: 24142 RVA: 0x001AC7D0 File Offset: 0x001AA9D0
		[ProtoMember(1, IsRequired = true, Name = "Inviter", DataFormat = DataFormat.Default)]
		public ProUserSummary Inviter
		{
			get
			{
				return this._Inviter;
			}
			set
			{
				this._Inviter = value;
			}
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x001AC7DC File Offset: 0x001AA9DC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x001AC7EC File Offset: 0x001AA9EC
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

		// Token: 0x06005E51 RID: 24145 RVA: 0x001AC8B8 File Offset: 0x001AAAB8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePracticeInvitedNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004699 RID: 18073
		private ProUserSummary _Inviter;

		// Token: 0x0400469A RID: 18074
		private IExtension extensionObject;

		// Token: 0x0400469B RID: 18075
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400469C RID: 18076
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400469D RID: 18077
		private LuaFunction m_ctor_hotfix;
	}
}
