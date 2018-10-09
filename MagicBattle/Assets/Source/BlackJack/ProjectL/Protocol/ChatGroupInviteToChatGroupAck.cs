using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000619 RID: 1561
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatGroupInviteToChatGroupAck")]
	[Serializable]
	public class ChatGroupInviteToChatGroupAck : IExtensible
	{
		// Token: 0x06005610 RID: 22032 RVA: 0x00193E34 File Offset: 0x00192034
		public ChatGroupInviteToChatGroupAck()
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

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06005611 RID: 22033 RVA: 0x00193E9C File Offset: 0x0019209C
		// (set) Token: 0x06005612 RID: 22034 RVA: 0x00193EA4 File Offset: 0x001920A4
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

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06005613 RID: 22035 RVA: 0x00193EB0 File Offset: 0x001920B0
		// (set) Token: 0x06005614 RID: 22036 RVA: 0x00193EB8 File Offset: 0x001920B8
		[ProtoMember(2, IsRequired = true, Name = "FailedUser", DataFormat = DataFormat.Default)]
		public ProChatUserInfo FailedUser
		{
			get
			{
				return this._FailedUser;
			}
			set
			{
				this._FailedUser = value;
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06005615 RID: 22037 RVA: 0x00193EC4 File Offset: 0x001920C4
		// (set) Token: 0x06005616 RID: 22038 RVA: 0x00193ECC File Offset: 0x001920CC
		[ProtoMember(3, IsRequired = true, Name = "ChatGroup", DataFormat = DataFormat.Default)]
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

		// Token: 0x06005617 RID: 22039 RVA: 0x00193ED8 File Offset: 0x001920D8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x00193EE8 File Offset: 0x001920E8
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

		// Token: 0x06005619 RID: 22041 RVA: 0x00193FB4 File Offset: 0x001921B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupInviteToChatGroupAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040AE RID: 16558
		private int _Result;

		// Token: 0x040040AF RID: 16559
		private ProChatUserInfo _FailedUser;

		// Token: 0x040040B0 RID: 16560
		private ProChatGroupInfo _ChatGroup;

		// Token: 0x040040B1 RID: 16561
		private IExtension extensionObject;

		// Token: 0x040040B2 RID: 16562
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040B3 RID: 16563
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040B4 RID: 16564
		private LuaFunction m_ctor_hotfix;
	}
}
