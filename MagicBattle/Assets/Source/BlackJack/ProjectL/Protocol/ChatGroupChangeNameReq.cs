using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200061C RID: 1564
	[ProtoContract(Name = "ChatGroupChangeNameReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatGroupChangeNameReq : IExtensible
	{
		// Token: 0x06005628 RID: 22056 RVA: 0x001943B0 File Offset: 0x001925B0
		public ChatGroupChangeNameReq()
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

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06005629 RID: 22057 RVA: 0x00194418 File Offset: 0x00192618
		// (set) Token: 0x0600562A RID: 22058 RVA: 0x00194420 File Offset: 0x00192620
		[ProtoMember(1, IsRequired = true, Name = "NewName", DataFormat = DataFormat.Default)]
		public string NewName
		{
			get
			{
				return this._NewName;
			}
			set
			{
				this._NewName = value;
			}
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x0600562B RID: 22059 RVA: 0x0019442C File Offset: 0x0019262C
		// (set) Token: 0x0600562C RID: 22060 RVA: 0x00194434 File Offset: 0x00192634
		[ProtoMember(2, IsRequired = true, Name = "ChatGroupId", DataFormat = DataFormat.Default)]
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

		// Token: 0x0600562D RID: 22061 RVA: 0x00194440 File Offset: 0x00192640
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x00194450 File Offset: 0x00192650
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

		// Token: 0x0600562F RID: 22063 RVA: 0x0019451C File Offset: 0x0019271C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupChangeNameReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040C0 RID: 16576
		private string _NewName;

		// Token: 0x040040C1 RID: 16577
		private string _ChatGroupId;

		// Token: 0x040040C2 RID: 16578
		private IExtension extensionObject;

		// Token: 0x040040C3 RID: 16579
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040C4 RID: 16580
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040C5 RID: 16581
		private LuaFunction m_ctor_hotfix;
	}
}
