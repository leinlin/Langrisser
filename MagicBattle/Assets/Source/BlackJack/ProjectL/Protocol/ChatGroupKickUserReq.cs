using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000616 RID: 1558
	[ProtoContract(Name = "ChatGroupKickUserReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatGroupKickUserReq : IExtensible
	{
		// Token: 0x060055FB RID: 22011 RVA: 0x001938CC File Offset: 0x00191ACC
		public ChatGroupKickUserReq()
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

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x060055FC RID: 22012 RVA: 0x00193934 File Offset: 0x00191B34
		// (set) Token: 0x060055FD RID: 22013 RVA: 0x0019393C File Offset: 0x00191B3C
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

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x060055FE RID: 22014 RVA: 0x00193948 File Offset: 0x00191B48
		// (set) Token: 0x060055FF RID: 22015 RVA: 0x00193950 File Offset: 0x00191B50
		[ProtoMember(2, IsRequired = true, Name = "TargetUserId", DataFormat = DataFormat.Default)]
		public string TargetUserId
		{
			get
			{
				return this._TargetUserId;
			}
			set
			{
				this._TargetUserId = value;
			}
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x0019395C File Offset: 0x00191B5C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x0019396C File Offset: 0x00191B6C
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

		// Token: 0x06005602 RID: 22018 RVA: 0x00193A38 File Offset: 0x00191C38
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupKickUserReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400409D RID: 16541
		private string _ChatGroupId;

		// Token: 0x0400409E RID: 16542
		private string _TargetUserId;

		// Token: 0x0400409F RID: 16543
		private IExtension extensionObject;

		// Token: 0x040040A0 RID: 16544
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040A1 RID: 16545
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040A2 RID: 16546
		private LuaFunction m_ctor_hotfix;
	}
}
