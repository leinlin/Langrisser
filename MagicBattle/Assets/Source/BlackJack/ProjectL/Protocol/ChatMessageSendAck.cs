using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000620 RID: 1568
	[ProtoContract(Name = "ChatMessageSendAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatMessageSendAck : IExtensible
	{
		// Token: 0x0600564E RID: 22094 RVA: 0x00194B50 File Offset: 0x00192D50
		public ChatMessageSendAck()
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

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x0600564F RID: 22095 RVA: 0x00194BB8 File Offset: 0x00192DB8
		// (set) Token: 0x06005650 RID: 22096 RVA: 0x00194BC0 File Offset: 0x00192DC0
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

		// Token: 0x06005651 RID: 22097 RVA: 0x00194BCC File Offset: 0x00192DCC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x00194BDC File Offset: 0x00192DDC
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

		// Token: 0x06005653 RID: 22099 RVA: 0x00194CA8 File Offset: 0x00192EA8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatMessageSendAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040DB RID: 16603
		private int _Result;

		// Token: 0x040040DC RID: 16604
		private IExtension extensionObject;

		// Token: 0x040040DD RID: 16605
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040DE RID: 16606
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040DF RID: 16607
		private LuaFunction m_ctor_hotfix;
	}
}
