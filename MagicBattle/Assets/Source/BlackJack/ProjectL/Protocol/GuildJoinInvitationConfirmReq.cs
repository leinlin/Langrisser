using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000761 RID: 1889
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildJoinInvitationConfirmReq")]
	[Serializable]
	public class GuildJoinInvitationConfirmReq : IExtensible
	{
		// Token: 0x06006283 RID: 25219 RVA: 0x001BB2A0 File Offset: 0x001B94A0
		public GuildJoinInvitationConfirmReq()
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

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06006284 RID: 25220 RVA: 0x001BB308 File Offset: 0x001B9508
		// (set) Token: 0x06006285 RID: 25221 RVA: 0x001BB310 File Offset: 0x001B9510
		[ProtoMember(1, IsRequired = true, Name = "GuildId", DataFormat = DataFormat.Default)]
		public string GuildId
		{
			get
			{
				return this._GuildId;
			}
			set
			{
				this._GuildId = value;
			}
		}

		// Token: 0x06006286 RID: 25222 RVA: 0x001BB31C File Offset: 0x001B951C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006287 RID: 25223 RVA: 0x001BB32C File Offset: 0x001B952C
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

		// Token: 0x06006288 RID: 25224 RVA: 0x001BB3F8 File Offset: 0x001B95F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinInvitationConfirmReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049CC RID: 18892
		private string _GuildId;

		// Token: 0x040049CD RID: 18893
		private IExtension extensionObject;

		// Token: 0x040049CE RID: 18894
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049CF RID: 18895
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049D0 RID: 18896
		private LuaFunction m_ctor_hotfix;
	}
}
