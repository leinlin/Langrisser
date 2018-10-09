using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000811 RID: 2065
	[ProtoContract(Name = "RealTimePVPGetInfoReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RealTimePVPGetInfoReq : IExtensible
	{
		// Token: 0x0600684B RID: 26699 RVA: 0x001D6C80 File Offset: 0x001D4E80
		public RealTimePVPGetInfoReq()
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

		// Token: 0x0600684C RID: 26700 RVA: 0x001D6CE8 File Offset: 0x001D4EE8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x001D6CF8 File Offset: 0x001D4EF8
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

		// Token: 0x0600684E RID: 26702 RVA: 0x001D6DC4 File Offset: 0x001D4FC4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPGetInfoReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005060 RID: 20576
		private IExtension extensionObject;

		// Token: 0x04005061 RID: 20577
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005062 RID: 20578
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005063 RID: 20579
		private LuaFunction m_ctor_hotfix;
	}
}
