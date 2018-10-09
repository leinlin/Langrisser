using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006C2 RID: 1730
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FriendInviteDeclineReq")]
	[Serializable]
	public class FriendInviteDeclineReq : IExtensible
	{
		// Token: 0x06005D69 RID: 23913 RVA: 0x001A8C2C File Offset: 0x001A6E2C
		public FriendInviteDeclineReq()
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

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06005D6A RID: 23914 RVA: 0x001A8CA0 File Offset: 0x001A6EA0
		[ProtoMember(1, Name = "InviterUserIds", DataFormat = DataFormat.Default)]
		public List<string> InviterUserIds
		{
			get
			{
				return this._InviterUserIds;
			}
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x001A8CA8 File Offset: 0x001A6EA8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x001A8CB8 File Offset: 0x001A6EB8
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

		// Token: 0x06005D6D RID: 23917 RVA: 0x001A8D84 File Offset: 0x001A6F84
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendInviteDeclineReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045E2 RID: 17890
		private readonly List<string> _InviterUserIds = new List<string>();

		// Token: 0x040045E3 RID: 17891
		private IExtension extensionObject;

		// Token: 0x040045E4 RID: 17892
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045E5 RID: 17893
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045E6 RID: 17894
		private LuaFunction m_ctor_hotfix;
	}
}
