using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000826 RID: 2086
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GetSurveyRewardReq")]
	[Serializable]
	public class GetSurveyRewardReq : IExtensible
	{
		// Token: 0x06006905 RID: 26885 RVA: 0x001D93F0 File Offset: 0x001D75F0
		public GetSurveyRewardReq()
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

		// Token: 0x06006906 RID: 26886 RVA: 0x001D9458 File Offset: 0x001D7658
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x001D9468 File Offset: 0x001D7668
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

		// Token: 0x06006908 RID: 26888 RVA: 0x001D9534 File Offset: 0x001D7734
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GetSurveyRewardReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050EC RID: 20716
		private IExtension extensionObject;

		// Token: 0x040050ED RID: 20717
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050EE RID: 20718
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050EF RID: 20719
		private LuaFunction m_ctor_hotfix;
	}
}
