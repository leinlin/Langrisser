using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000612 RID: 1554
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatGroupCreateChatGroupReq")]
	[Serializable]
	public class ChatGroupCreateChatGroupReq : IExtensible
	{
		// Token: 0x060055DC RID: 21980 RVA: 0x0019317C File Offset: 0x0019137C
		public ChatGroupCreateChatGroupReq()
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

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x060055DD RID: 21981 RVA: 0x001931F0 File Offset: 0x001913F0
		// (set) Token: 0x060055DE RID: 21982 RVA: 0x001931F8 File Offset: 0x001913F8
		[ProtoMember(1, IsRequired = true, Name = "GroupName", DataFormat = DataFormat.Default)]
		public string GroupName
		{
			get
			{
				return this._GroupName;
			}
			set
			{
				this._GroupName = value;
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x060055DF RID: 21983 RVA: 0x00193204 File Offset: 0x00191404
		[ProtoMember(2, Name = "TargetUserIds", DataFormat = DataFormat.Default)]
		public List<string> TargetUserIds
		{
			get
			{
				return this._TargetUserIds;
			}
		}

		// Token: 0x060055E0 RID: 21984 RVA: 0x0019320C File Offset: 0x0019140C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060055E1 RID: 21985 RVA: 0x0019321C File Offset: 0x0019141C
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

		// Token: 0x060055E2 RID: 21986 RVA: 0x001932E8 File Offset: 0x001914E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupCreateChatGroupReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004085 RID: 16517
		private string _GroupName;

		// Token: 0x04004086 RID: 16518
		private readonly List<string> _TargetUserIds = new List<string>();

		// Token: 0x04004087 RID: 16519
		private IExtension extensionObject;

		// Token: 0x04004088 RID: 16520
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004089 RID: 16521
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400408A RID: 16522
		private LuaFunction m_ctor_hotfix;
	}
}
