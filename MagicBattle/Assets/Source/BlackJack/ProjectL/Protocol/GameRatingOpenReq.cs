using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000702 RID: 1794
	[ProtoContract(Name = "GameRatingOpenReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GameRatingOpenReq : IExtensible
	{
		// Token: 0x06005F5B RID: 24411 RVA: 0x001B014C File Offset: 0x001AE34C
		public GameRatingOpenReq()
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

		// Token: 0x06005F5C RID: 24412 RVA: 0x001B01B4 File Offset: 0x001AE3B4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x001B01C4 File Offset: 0x001AE3C4
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

		// Token: 0x06005F5E RID: 24414 RVA: 0x001B0290 File Offset: 0x001AE490
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GameRatingOpenReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004762 RID: 18274
		private IExtension extensionObject;

		// Token: 0x04004763 RID: 18275
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004764 RID: 18276
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004765 RID: 18277
		private LuaFunction m_ctor_hotfix;
	}
}
