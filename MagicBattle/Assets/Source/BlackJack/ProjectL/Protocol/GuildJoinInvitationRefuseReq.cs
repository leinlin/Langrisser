using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000763 RID: 1891
	[ProtoContract(Name = "GuildJoinInvitationRefuseReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildJoinInvitationRefuseReq : IExtensible
	{
		// Token: 0x06006295 RID: 25237 RVA: 0x001BB65C File Offset: 0x001B985C
		public GuildJoinInvitationRefuseReq()
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

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06006296 RID: 25238 RVA: 0x001BB6C4 File Offset: 0x001B98C4
		// (set) Token: 0x06006297 RID: 25239 RVA: 0x001BB6CC File Offset: 0x001B98CC
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

		// Token: 0x06006298 RID: 25240 RVA: 0x001BB6D8 File Offset: 0x001B98D8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x001BB6E8 File Offset: 0x001B98E8
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

		// Token: 0x0600629A RID: 25242 RVA: 0x001BB7B4 File Offset: 0x001B99B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinInvitationRefuseReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049D9 RID: 18905
		private string _GuildId;

		// Token: 0x040049DA RID: 18906
		private IExtension extensionObject;

		// Token: 0x040049DB RID: 18907
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049DC RID: 18908
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049DD RID: 18909
		private LuaFunction m_ctor_hotfix;
	}
}
