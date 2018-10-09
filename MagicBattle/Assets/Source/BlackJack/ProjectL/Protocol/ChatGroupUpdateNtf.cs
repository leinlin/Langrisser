using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200061E RID: 1566
	[ProtoContract(Name = "ChatGroupUpdateNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatGroupUpdateNtf : IExtensible
	{
		// Token: 0x06005636 RID: 22070 RVA: 0x00194744 File Offset: 0x00192944
		public ChatGroupUpdateNtf()
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

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06005637 RID: 22071 RVA: 0x001947AC File Offset: 0x001929AC
		// (set) Token: 0x06005638 RID: 22072 RVA: 0x001947B4 File Offset: 0x001929B4
		[ProtoMember(1, IsRequired = true, Name = "ChatGroup", DataFormat = DataFormat.Default)]
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

		// Token: 0x06005639 RID: 22073 RVA: 0x001947C0 File Offset: 0x001929C0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600563A RID: 22074 RVA: 0x001947D0 File Offset: 0x001929D0
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

		// Token: 0x0600563B RID: 22075 RVA: 0x0019489C File Offset: 0x00192A9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupUpdateNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040CB RID: 16587
		private ProChatGroupInfo _ChatGroup;

		// Token: 0x040040CC RID: 16588
		private IExtension extensionObject;

		// Token: 0x040040CD RID: 16589
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040CE RID: 16590
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040CF RID: 16591
		private LuaFunction m_ctor_hotfix;
	}
}
