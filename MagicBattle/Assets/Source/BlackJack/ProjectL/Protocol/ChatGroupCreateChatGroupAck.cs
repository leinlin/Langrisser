using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000613 RID: 1555
	[ProtoContract(Name = "ChatGroupCreateChatGroupAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatGroupCreateChatGroupAck : IExtensible
	{
		// Token: 0x060055E3 RID: 21987 RVA: 0x00193350 File Offset: 0x00191550
		public ChatGroupCreateChatGroupAck()
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

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x060055E4 RID: 21988 RVA: 0x001933B8 File Offset: 0x001915B8
		// (set) Token: 0x060055E5 RID: 21989 RVA: 0x001933C0 File Offset: 0x001915C0
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

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x060055E6 RID: 21990 RVA: 0x001933CC File Offset: 0x001915CC
		// (set) Token: 0x060055E7 RID: 21991 RVA: 0x001933D4 File Offset: 0x001915D4
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

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x060055E8 RID: 21992 RVA: 0x001933E0 File Offset: 0x001915E0
		// (set) Token: 0x060055E9 RID: 21993 RVA: 0x001933E8 File Offset: 0x001915E8
		[ProtoMember(3, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public ChatGroupCreateChatGroupReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x060055EA RID: 21994 RVA: 0x001933F4 File Offset: 0x001915F4
		// (set) Token: 0x060055EB RID: 21995 RVA: 0x001933FC File Offset: 0x001915FC
		[ProtoMember(4, IsRequired = true, Name = "ChatGroup", DataFormat = DataFormat.Default)]
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

		// Token: 0x060055EC RID: 21996 RVA: 0x00193408 File Offset: 0x00191608
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x00193418 File Offset: 0x00191618
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

		// Token: 0x060055EE RID: 21998 RVA: 0x001934E4 File Offset: 0x001916E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupCreateChatGroupAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400408B RID: 16523
		private int _Result;

		// Token: 0x0400408C RID: 16524
		private ProChatUserInfo _FailedUser;

		// Token: 0x0400408D RID: 16525
		private ChatGroupCreateChatGroupReq _Req;

		// Token: 0x0400408E RID: 16526
		private ProChatGroupInfo _ChatGroup;

		// Token: 0x0400408F RID: 16527
		private IExtension extensionObject;

		// Token: 0x04004090 RID: 16528
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004091 RID: 16529
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004092 RID: 16530
		private LuaFunction m_ctor_hotfix;
	}
}
