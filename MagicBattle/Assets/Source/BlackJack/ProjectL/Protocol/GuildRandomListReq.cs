using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200076B RID: 1899
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildRandomListReq")]
	[Serializable]
	public class GuildRandomListReq : IExtensible
	{
		// Token: 0x060062C7 RID: 25287 RVA: 0x001BC498 File Offset: 0x001BA698
		public GuildRandomListReq()
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

		// Token: 0x060062C8 RID: 25288 RVA: 0x001BC500 File Offset: 0x001BA700
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x001BC510 File Offset: 0x001BA710
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

		// Token: 0x060062CA RID: 25290 RVA: 0x001BC5DC File Offset: 0x001BA7DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildRandomListReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A03 RID: 18947
		private IExtension extensionObject;

		// Token: 0x04004A04 RID: 18948
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A05 RID: 18949
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A06 RID: 18950
		private LuaFunction m_ctor_hotfix;
	}
}
