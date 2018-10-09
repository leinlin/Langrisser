using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000618 RID: 1560
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatGroupInviteToChatGroupReq")]
	[Serializable]
	public class ChatGroupInviteToChatGroupReq : IExtensible
	{
		// Token: 0x06005609 RID: 22025 RVA: 0x00193C60 File Offset: 0x00191E60
		public ChatGroupInviteToChatGroupReq()
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

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x0600560A RID: 22026 RVA: 0x00193CD4 File Offset: 0x00191ED4
		[ProtoMember(1, Name = "TargetUserIds", DataFormat = DataFormat.Default)]
		public List<string> TargetUserIds
		{
			get
			{
				return this._TargetUserIds;
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x0600560B RID: 22027 RVA: 0x00193CDC File Offset: 0x00191EDC
		// (set) Token: 0x0600560C RID: 22028 RVA: 0x00193CE4 File Offset: 0x00191EE4
		[ProtoMember(2, IsRequired = true, Name = "ChatGroupId", DataFormat = DataFormat.Default)]
		public string ChatGroupId
		{
			get
			{
				return this._ChatGroupId;
			}
			set
			{
				this._ChatGroupId = value;
			}
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x00193CF0 File Offset: 0x00191EF0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x00193D00 File Offset: 0x00191F00
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

		// Token: 0x0600560F RID: 22031 RVA: 0x00193DCC File Offset: 0x00191FCC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupInviteToChatGroupReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040A8 RID: 16552
		private readonly List<string> _TargetUserIds = new List<string>();

		// Token: 0x040040A9 RID: 16553
		private string _ChatGroupId;

		// Token: 0x040040AA RID: 16554
		private IExtension extensionObject;

		// Token: 0x040040AB RID: 16555
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040AC RID: 16556
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040AD RID: 16557
		private LuaFunction m_ctor_hotfix;
	}
}
