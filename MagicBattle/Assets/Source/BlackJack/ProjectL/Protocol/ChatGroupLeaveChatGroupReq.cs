using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000614 RID: 1556
	[ProtoContract(Name = "ChatGroupLeaveChatGroupReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatGroupLeaveChatGroupReq : IExtensible
	{
		// Token: 0x060055EF RID: 21999 RVA: 0x0019354C File Offset: 0x0019174C
		public ChatGroupLeaveChatGroupReq()
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

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x060055F0 RID: 22000 RVA: 0x001935B4 File Offset: 0x001917B4
		// (set) Token: 0x060055F1 RID: 22001 RVA: 0x001935BC File Offset: 0x001917BC
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

		// Token: 0x060055F2 RID: 22002 RVA: 0x001935C8 File Offset: 0x001917C8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x001935D8 File Offset: 0x001917D8
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

		// Token: 0x060055F4 RID: 22004 RVA: 0x001936A4 File Offset: 0x001918A4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupLeaveChatGroupReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004093 RID: 16531
		private string _ChatGroupId;

		// Token: 0x04004094 RID: 16532
		private IExtension extensionObject;

		// Token: 0x04004095 RID: 16533
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004096 RID: 16534
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004097 RID: 16535
		private LuaFunction m_ctor_hotfix;
	}
}
