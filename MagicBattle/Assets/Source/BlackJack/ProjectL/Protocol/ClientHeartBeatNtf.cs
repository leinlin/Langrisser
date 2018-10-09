using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200068E RID: 1678
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ClientHeartBeatNtf")]
	[Serializable]
	public class ClientHeartBeatNtf : IExtensible
	{
		// Token: 0x06005B45 RID: 23365 RVA: 0x001A268C File Offset: 0x001A088C
		public ClientHeartBeatNtf()
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

		// Token: 0x06005B46 RID: 23366 RVA: 0x001A26F4 File Offset: 0x001A08F4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x001A2704 File Offset: 0x001A0904
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

		// Token: 0x06005B48 RID: 23368 RVA: 0x001A27D0 File Offset: 0x001A09D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientHeartBeatNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004454 RID: 17492
		private IExtension extensionObject;

		// Token: 0x04004455 RID: 17493
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004456 RID: 17494
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004457 RID: 17495
		private LuaFunction m_ctor_hotfix;
	}
}
