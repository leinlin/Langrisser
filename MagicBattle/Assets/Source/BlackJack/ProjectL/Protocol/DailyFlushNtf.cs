using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000712 RID: 1810
	[ProtoContract(Name = "DailyFlushNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DailyFlushNtf : IExtensible
	{
		// Token: 0x06005FCC RID: 24524 RVA: 0x001B1E00 File Offset: 0x001B0000
		public DailyFlushNtf()
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

		// Token: 0x06005FCD RID: 24525 RVA: 0x001B1E68 File Offset: 0x001B0068
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x001B1E78 File Offset: 0x001B0078
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

		// Token: 0x06005FCF RID: 24527 RVA: 0x001B1F44 File Offset: 0x001B0144
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DailyFlushNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047BB RID: 18363
		private IExtension extensionObject;

		// Token: 0x040047BC RID: 18364
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047BD RID: 18365
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047BE RID: 18366
		private LuaFunction m_ctor_hotfix;
	}
}
