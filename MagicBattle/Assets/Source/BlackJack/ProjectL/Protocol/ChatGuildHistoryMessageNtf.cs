using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000629 RID: 1577
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatGuildHistoryMessageNtf")]
	[Serializable]
	public class ChatGuildHistoryMessageNtf : IExtensible
	{
		// Token: 0x0600569A RID: 22170 RVA: 0x00195C14 File Offset: 0x00193E14
		public ChatGuildHistoryMessageNtf()
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

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x0600569B RID: 22171 RVA: 0x00195C88 File Offset: 0x00193E88
		[ProtoMember(2, Name = "MsgList", DataFormat = DataFormat.Default)]
		public List<ChatMessageNtf> MsgList
		{
			get
			{
				return this._MsgList;
			}
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x00195C90 File Offset: 0x00193E90
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x00195CA0 File Offset: 0x00193EA0
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

		// Token: 0x0600569E RID: 22174 RVA: 0x00195D6C File Offset: 0x00193F6C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGuildHistoryMessageNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004114 RID: 16660
		private readonly List<ChatMessageNtf> _MsgList = new List<ChatMessageNtf>();

		// Token: 0x04004115 RID: 16661
		private IExtension extensionObject;

		// Token: 0x04004116 RID: 16662
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004117 RID: 16663
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004118 RID: 16664
		private LuaFunction m_ctor_hotfix;
	}
}
