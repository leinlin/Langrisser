using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000611 RID: 1553
	[ProtoContract(Name = "ChatGroupGetChatGroupMemberAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatGroupGetChatGroupMemberAck : IExtensible
	{
		// Token: 0x060055D4 RID: 21972 RVA: 0x00192FA8 File Offset: 0x001911A8
		public ChatGroupGetChatGroupMemberAck()
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

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x060055D5 RID: 21973 RVA: 0x00193010 File Offset: 0x00191210
		// (set) Token: 0x060055D6 RID: 21974 RVA: 0x00193018 File Offset: 0x00191218
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

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x060055D7 RID: 21975 RVA: 0x00193024 File Offset: 0x00191224
		// (set) Token: 0x060055D8 RID: 21976 RVA: 0x0019302C File Offset: 0x0019122C
		[ProtoMember(2, IsRequired = true, Name = "ChatGroup", DataFormat = DataFormat.Default)]
		public ProChatGroupInfo ChatGroup
		{
			get
			{
				return this._ChatGroup;
			}
			set
			{
				this._ChatGroup = value;
			}
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x00193038 File Offset: 0x00191238
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00193048 File Offset: 0x00191248
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

		// Token: 0x060055DB RID: 21979 RVA: 0x00193114 File Offset: 0x00191314
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupGetChatGroupMemberAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400407F RID: 16511
		private int _Result;

		// Token: 0x04004080 RID: 16512
		private ProChatGroupInfo _ChatGroup;

		// Token: 0x04004081 RID: 16513
		private IExtension extensionObject;

		// Token: 0x04004082 RID: 16514
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004083 RID: 16515
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004084 RID: 16516
		private LuaFunction m_ctor_hotfix;
	}
}
