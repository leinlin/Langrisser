using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006FF RID: 1791
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FlushConfigNtf")]
	[Serializable]
	public class FlushConfigNtf : IExtensible
	{
		// Token: 0x06005F43 RID: 24387 RVA: 0x001AFBD0 File Offset: 0x001ADDD0
		public FlushConfigNtf()
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

		// Token: 0x06005F44 RID: 24388 RVA: 0x001AFC38 File Offset: 0x001ADE38
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x001AFC48 File Offset: 0x001ADE48
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

		// Token: 0x06005F46 RID: 24390 RVA: 0x001AFD14 File Offset: 0x001ADF14
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FlushConfigNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004750 RID: 18256
		private IExtension extensionObject;

		// Token: 0x04004751 RID: 18257
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004752 RID: 18258
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004753 RID: 18259
		private LuaFunction m_ctor_hotfix;
	}
}
