using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006BF RID: 1727
	[ProtoContract(Name = "FriendInviteAcceptReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendInviteAcceptReq : IExtensible
	{
		// Token: 0x06005D53 RID: 23891 RVA: 0x001A86B0 File Offset: 0x001A68B0
		public FriendInviteAcceptReq()
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

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06005D54 RID: 23892 RVA: 0x001A8724 File Offset: 0x001A6924
		[ProtoMember(2, Name = "InviterUserIds", DataFormat = DataFormat.Default)]
		public List<string> InviterUserIds
		{
			get
			{
				return this._InviterUserIds;
			}
		}

		// Token: 0x06005D55 RID: 23893 RVA: 0x001A872C File Offset: 0x001A692C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005D56 RID: 23894 RVA: 0x001A873C File Offset: 0x001A693C
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

		// Token: 0x06005D57 RID: 23895 RVA: 0x001A8808 File Offset: 0x001A6A08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendInviteAcceptReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040045D0 RID: 17872
		private readonly List<string> _InviterUserIds = new List<string>();

		// Token: 0x040045D1 RID: 17873
		private IExtension extensionObject;

		// Token: 0x040045D2 RID: 17874
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040045D3 RID: 17875
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040045D4 RID: 17876
		private LuaFunction m_ctor_hotfix;
	}
}
