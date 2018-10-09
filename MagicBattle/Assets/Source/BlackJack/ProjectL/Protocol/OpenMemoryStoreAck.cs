using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000715 RID: 1813
	[ProtoContract(Name = "OpenMemoryStoreAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class OpenMemoryStoreAck : IExtensible
	{
		// Token: 0x06005FDA RID: 24538 RVA: 0x001B2318 File Offset: 0x001B0518
		public OpenMemoryStoreAck()
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

		// Token: 0x06005FDB RID: 24539 RVA: 0x001B2380 File Offset: 0x001B0580
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x001B2390 File Offset: 0x001B0590
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

		// Token: 0x06005FDD RID: 24541 RVA: 0x001B245C File Offset: 0x001B065C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OpenMemoryStoreAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047C8 RID: 18376
		private IExtension extensionObject;

		// Token: 0x040047C9 RID: 18377
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047CA RID: 18378
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047CB RID: 18379
		private LuaFunction m_ctor_hotfix;
	}
}
