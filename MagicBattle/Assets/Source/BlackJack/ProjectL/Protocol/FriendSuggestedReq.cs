using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006CF RID: 1743
	[ProtoContract(Name = "FriendSuggestedReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FriendSuggestedReq : IExtensible
	{
		// Token: 0x06005DC5 RID: 24005 RVA: 0x001AA3A0 File Offset: 0x001A85A0
		public FriendSuggestedReq()
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

		// Token: 0x06005DC6 RID: 24006 RVA: 0x001AA408 File Offset: 0x001A8608
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x001AA418 File Offset: 0x001A8618
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

		// Token: 0x06005DC8 RID: 24008 RVA: 0x001AA4E4 File Offset: 0x001A86E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FriendSuggestedReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400462C RID: 17964
		private IExtension extensionObject;

		// Token: 0x0400462D RID: 17965
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400462E RID: 17966
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400462F RID: 17967
		private LuaFunction m_ctor_hotfix;
	}
}
