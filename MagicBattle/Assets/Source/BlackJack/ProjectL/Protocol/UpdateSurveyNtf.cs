using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000823 RID: 2083
	[ProtoContract(Name = "UpdateSurveyNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class UpdateSurveyNtf : IExtensible
	{
		// Token: 0x060068F5 RID: 26869 RVA: 0x001D8EC4 File Offset: 0x001D70C4
		public UpdateSurveyNtf()
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

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x060068F6 RID: 26870 RVA: 0x001D8F2C File Offset: 0x001D712C
		// (set) Token: 0x060068F7 RID: 26871 RVA: 0x001D8F34 File Offset: 0x001D7134
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

		// Token: 0x060068F8 RID: 26872 RVA: 0x001D8F40 File Offset: 0x001D7140
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060068F9 RID: 26873 RVA: 0x001D8F50 File Offset: 0x001D7150
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

		// Token: 0x060068FA RID: 26874 RVA: 0x001D901C File Offset: 0x001D721C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UpdateSurveyNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050DE RID: 20702
		private ProSurvey _Survey;

		// Token: 0x040050DF RID: 20703
		private IExtension extensionObject;

		// Token: 0x040050E0 RID: 20704
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050E1 RID: 20705
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050E2 RID: 20706
		private LuaFunction m_ctor_hotfix;
	}
}
