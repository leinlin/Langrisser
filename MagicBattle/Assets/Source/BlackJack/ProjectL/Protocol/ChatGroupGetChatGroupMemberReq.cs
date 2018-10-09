using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000610 RID: 1552
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatGroupGetChatGroupMemberReq")]
	[Serializable]
	public class ChatGroupGetChatGroupMemberReq : IExtensible
	{
		// Token: 0x060055CE RID: 21966 RVA: 0x00192DE8 File Offset: 0x00190FE8
		public ChatGroupGetChatGroupMemberReq()
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

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x060055CF RID: 21967 RVA: 0x00192E50 File Offset: 0x00191050
		// (set) Token: 0x060055D0 RID: 21968 RVA: 0x00192E58 File Offset: 0x00191058
		[ProtoMember(1, IsRequired = true, Name = "ChatGroupId", DataFormat = DataFormat.Default)]
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

		// Token: 0x060055D1 RID: 21969 RVA: 0x00192E64 File Offset: 0x00191064
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x00192E74 File Offset: 0x00191074
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

		// Token: 0x060055D3 RID: 21971 RVA: 0x00192F40 File Offset: 0x00191140
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupGetChatGroupMemberReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400407A RID: 16506
		private string _ChatGroupId;

		// Token: 0x0400407B RID: 16507
		private IExtension extensionObject;

		// Token: 0x0400407C RID: 16508
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400407D RID: 16509
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400407E RID: 16510
		private LuaFunction m_ctor_hotfix;
	}
}
