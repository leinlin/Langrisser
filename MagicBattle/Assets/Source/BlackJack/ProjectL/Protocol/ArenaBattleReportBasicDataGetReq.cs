using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005C7 RID: 1479
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaBattleReportBasicDataGetReq")]
	[Serializable]
	public class ArenaBattleReportBasicDataGetReq : IExtensible
	{
		// Token: 0x0600535A RID: 21338 RVA: 0x0018A580 File Offset: 0x00188780
		public ArenaBattleReportBasicDataGetReq()
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

		// Token: 0x0600535B RID: 21339 RVA: 0x0018A5E8 File Offset: 0x001887E8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x0018A5F8 File Offset: 0x001887F8
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

		// Token: 0x0600535D RID: 21341 RVA: 0x0018A6C4 File Offset: 0x001888C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaBattleReportBasicDataGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E9E RID: 16030
		private IExtension extensionObject;

		// Token: 0x04003E9F RID: 16031
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EA0 RID: 16032
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EA1 RID: 16033
		private LuaFunction m_ctor_hotfix;
	}
}
