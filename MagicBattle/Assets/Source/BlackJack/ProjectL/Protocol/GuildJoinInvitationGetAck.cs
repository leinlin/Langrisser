using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000768 RID: 1896
	[ProtoContract(Name = "GuildJoinInvitationGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildJoinInvitationGetAck : IExtensible
	{
		// Token: 0x060062B1 RID: 25265 RVA: 0x001BBF08 File Offset: 0x001BA108
		public GuildJoinInvitationGetAck()
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

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x060062B2 RID: 25266 RVA: 0x001BBF7C File Offset: 0x001BA17C
		// (set) Token: 0x060062B3 RID: 25267 RVA: 0x001BBF84 File Offset: 0x001BA184
		[DefaultValue(0)]
		[ProtoMember(1, IsRequired = false, Name = "Result", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x060062B4 RID: 25268 RVA: 0x001BBF90 File Offset: 0x001BA190
		[ProtoMember(2, Name = "Invitations", DataFormat = DataFormat.Default)]
		public List<ProGuildJoinInvitation> Invitations
		{
			get
			{
				return this._Invitations;
			}
		}

		// Token: 0x060062B5 RID: 25269 RVA: 0x001BBF98 File Offset: 0x001BA198
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x001BBFA8 File Offset: 0x001BA1A8
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

		// Token: 0x060062B7 RID: 25271 RVA: 0x001BC074 File Offset: 0x001BA274
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinInvitationGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049F1 RID: 18929
		private int _Result;

		// Token: 0x040049F2 RID: 18930
		private readonly List<ProGuildJoinInvitation> _Invitations = new List<ProGuildJoinInvitation>();

		// Token: 0x040049F3 RID: 18931
		private IExtension extensionObject;

		// Token: 0x040049F4 RID: 18932
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049F5 RID: 18933
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049F6 RID: 18934
		private LuaFunction m_ctor_hotfix;
	}
}
