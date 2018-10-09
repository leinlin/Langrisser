using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200060E RID: 1550
	[ProtoContract(Name = "ChatGroupGetChatGroupReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatGroupGetChatGroupReq : IExtensible
	{
		// Token: 0x060055C3 RID: 21955 RVA: 0x00192A68 File Offset: 0x00190C68
		public ChatGroupGetChatGroupReq()
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

		// Token: 0x060055C4 RID: 21956 RVA: 0x00192AD0 File Offset: 0x00190CD0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x00192AE0 File Offset: 0x00190CE0
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

		// Token: 0x060055C6 RID: 21958 RVA: 0x00192BAC File Offset: 0x00190DAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupGetChatGroupReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004070 RID: 16496
		private IExtension extensionObject;

		// Token: 0x04004071 RID: 16497
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004072 RID: 16498
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004073 RID: 16499
		private LuaFunction m_ctor_hotfix;
	}
}
