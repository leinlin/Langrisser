using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000824 RID: 2084
	[ProtoContract(Name = "OpenSurveyReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class OpenSurveyReq : IExtensible
	{
		// Token: 0x060068FB RID: 26875 RVA: 0x001D9084 File Offset: 0x001D7284
		public OpenSurveyReq()
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

		// Token: 0x060068FC RID: 26876 RVA: 0x001D90EC File Offset: 0x001D72EC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x001D90FC File Offset: 0x001D72FC
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

		// Token: 0x060068FE RID: 26878 RVA: 0x001D91C8 File Offset: 0x001D73C8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OpenSurveyReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050E3 RID: 20707
		private IExtension extensionObject;

		// Token: 0x040050E4 RID: 20708
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050E5 RID: 20709
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050E6 RID: 20710
		private LuaFunction m_ctor_hotfix;
	}
}
