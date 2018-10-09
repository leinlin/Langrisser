using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000845 RID: 2117
	[ProtoContract(Name = "TeamRoomInviteNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomInviteNtf : IExtensible
	{
		// Token: 0x060069E3 RID: 27107 RVA: 0x001DCBC0 File Offset: 0x001DADC0
		public TeamRoomInviteNtf()
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

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x060069E4 RID: 27108 RVA: 0x001DCC28 File Offset: 0x001DAE28
		// (set) Token: 0x060069E5 RID: 27109 RVA: 0x001DCC30 File Offset: 0x001DAE30
		[ProtoMember(1, IsRequired = true, Name = "InviteInfo", DataFormat = DataFormat.Default)]
		public ProTeamRoomInviteInfo InviteInfo
		{
			get
			{
				return this._InviteInfo;
			}
			set
			{
				this._InviteInfo = value;
			}
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x001DCC3C File Offset: 0x001DAE3C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x001DCC4C File Offset: 0x001DAE4C
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

		// Token: 0x060069E8 RID: 27112 RVA: 0x001DCD18 File Offset: 0x001DAF18
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomInviteNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400519B RID: 20891
		private ProTeamRoomInviteInfo _InviteInfo;

		// Token: 0x0400519C RID: 20892
		private IExtension extensionObject;

		// Token: 0x0400519D RID: 20893
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400519E RID: 20894
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400519F RID: 20895
		private LuaFunction m_ctor_hotfix;
	}
}
