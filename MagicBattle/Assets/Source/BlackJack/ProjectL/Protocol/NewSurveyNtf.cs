using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000822 RID: 2082
	[ProtoContract(Name = "NewSurveyNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class NewSurveyNtf : IExtensible
	{
		// Token: 0x060068EF RID: 26863 RVA: 0x001D8D04 File Offset: 0x001D6F04
		public NewSurveyNtf()
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

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x060068F0 RID: 26864 RVA: 0x001D8D6C File Offset: 0x001D6F6C
		// (set) Token: 0x060068F1 RID: 26865 RVA: 0x001D8D74 File Offset: 0x001D6F74
		[ProtoMember(1, IsRequired = true, Name = "Survey", DataFormat = DataFormat.Default)]
		public ProSurvey Survey
		{
			get
			{
				return this._Survey;
			}
			set
			{
				this._Survey = value;
			}
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x001D8D80 File Offset: 0x001D6F80
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x001D8D90 File Offset: 0x001D6F90
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

		// Token: 0x060068F4 RID: 26868 RVA: 0x001D8E5C File Offset: 0x001D705C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NewSurveyNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050D9 RID: 20697
		private ProSurvey _Survey;

		// Token: 0x040050DA RID: 20698
		private IExtension extensionObject;

		// Token: 0x040050DB RID: 20699
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050DC RID: 20700
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050DD RID: 20701
		private LuaFunction m_ctor_hotfix;
	}
}
