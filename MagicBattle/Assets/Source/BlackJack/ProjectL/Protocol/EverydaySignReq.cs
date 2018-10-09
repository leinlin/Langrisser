using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006F1 RID: 1777
	[ProtoContract(Name = "EverydaySignReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class EverydaySignReq : IExtensible
	{
		// Token: 0x06005EEA RID: 24298 RVA: 0x001AE300 File Offset: 0x001AC500
		public EverydaySignReq()
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

		// Token: 0x06005EEB RID: 24299 RVA: 0x001AE368 File Offset: 0x001AC568
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x001AE378 File Offset: 0x001AC578
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

		// Token: 0x06005EED RID: 24301 RVA: 0x001AE444 File Offset: 0x001AC644
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EverydaySignReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004706 RID: 18182
		private IExtension extensionObject;

		// Token: 0x04004707 RID: 18183
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004708 RID: 18184
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004709 RID: 18185
		private LuaFunction m_ctor_hotfix;
	}
}
