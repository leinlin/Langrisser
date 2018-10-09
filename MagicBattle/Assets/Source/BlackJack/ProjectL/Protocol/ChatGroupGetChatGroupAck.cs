using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200060F RID: 1551
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatGroupGetChatGroupAck")]
	[Serializable]
	public class ChatGroupGetChatGroupAck : IExtensible
	{
		// Token: 0x060055C7 RID: 21959 RVA: 0x00192C14 File Offset: 0x00190E14
		public ChatGroupGetChatGroupAck()
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

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x060055C8 RID: 21960 RVA: 0x00192C88 File Offset: 0x00190E88
		// (set) Token: 0x060055C9 RID: 21961 RVA: 0x00192C90 File Offset: 0x00190E90
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x060055CA RID: 21962 RVA: 0x00192C9C File Offset: 0x00190E9C
		[ProtoMember(2, Name = "ChatGroup", DataFormat = DataFormat.Default)]
		public List<ProChatGroupCompactInfo> ChatGroup
		{
			get
			{
				return this._ChatGroup;
			}
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x00192CA4 File Offset: 0x00190EA4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x00192CB4 File Offset: 0x00190EB4
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

		// Token: 0x060055CD RID: 21965 RVA: 0x00192D80 File Offset: 0x00190F80
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupGetChatGroupAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004074 RID: 16500
		private int _Result;

		// Token: 0x04004075 RID: 16501
		private readonly List<ProChatGroupCompactInfo> _ChatGroup = new List<ProChatGroupCompactInfo>();

		// Token: 0x04004076 RID: 16502
		private IExtension extensionObject;

		// Token: 0x04004077 RID: 16503
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004078 RID: 16504
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004079 RID: 16505
		private LuaFunction m_ctor_hotfix;
	}
}
