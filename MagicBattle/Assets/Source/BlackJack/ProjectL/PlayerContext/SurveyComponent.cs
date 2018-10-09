using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008E5 RID: 2277
	[HotFix]
	public class SurveyComponent : SurveyComponentCommon
	{
		// Token: 0x0600770B RID: 30475 RVA: 0x0020871C File Offset: 0x0020691C
		public SurveyComponent()
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

		// Token: 0x0600770C RID: 30476 RVA: 0x00208784 File Offset: 0x00206984
		public override void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x00208800 File Offset: 0x00206A00
		public override void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.PostInit();
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x00208868 File Offset: 0x00206A68
		public override void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.DeInit();
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x002088D0 File Offset: 0x00206AD0
		public void DeSerialize(DSSurveyNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSSurveyNtf_hotfix != null)
			{
				this.m_DeSerializeDSSurveyNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_survey.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			this.m_survey.InitCurrentSurvey(Survey.ToSurvey(msg.Survey));
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x00208970 File Offset: 0x00206B70
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_survey.ClientVersion;
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06007711 RID: 30481 RVA: 0x002089E8 File Offset: 0x00206BE8
		// (set) Token: 0x06007712 RID: 30482 RVA: 0x00208A08 File Offset: 0x00206C08
		[DoNotToLua]
		public new SurveyComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SurveyComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x00208A14 File Offset: 0x00206C14
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007714 RID: 30484 RVA: 0x00208A1C File Offset: 0x00206C1C
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x00208A24 File Offset: 0x00206C24
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x00208A2C File Offset: 0x00206C2C
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x00208A34 File Offset: 0x00206C34
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x00208A40 File Offset: 0x00206C40
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x00208A48 File Offset: 0x00206C48
		private void __callBase_FlushSurvey()
		{
			base.FlushSurvey();
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x00208A50 File Offset: 0x00206C50
		private SurveyStatus __callBase_GetSurveyStatus(Survey survey)
		{
			return base.GetSurveyStatus(survey);
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x00208A5C File Offset: 0x00206C5C
		private void __callBase_SetSurveyStatus(SurveyStatus status)
		{
			base.SetSurveyStatus(status);
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x00208A68 File Offset: 0x00206C68
		private void __callBase_SetCurrentSurvey(Survey survey)
		{
			base.SetCurrentSurvey(survey);
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x00208A74 File Offset: 0x00206C74
		private SurveyStatus __callBase_GetCurrentSurveyStatus()
		{
			return base.GetCurrentSurveyStatus();
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x00208A7C File Offset: 0x00206C7C
		private int __callBase_CanGainSurveyReward()
		{
			return base.CanGainSurveyReward();
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x00208A84 File Offset: 0x00206C84
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_DeSerializeDSSurveyNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x00208BCC File Offset: 0x00206DCC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SurveyComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400563C RID: 22076
		[DoNotToLua]
		private SurveyComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400563D RID: 22077
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400563E RID: 22078
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400563F RID: 22079
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005640 RID: 22080
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005641 RID: 22081
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005642 RID: 22082
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005643 RID: 22083
		private LuaFunction m_DeSerializeDSSurveyNtf_hotfix;

		// Token: 0x04005644 RID: 22084
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x020008E6 RID: 2278
		public new class LuaExportHelper
		{
			// Token: 0x06007721 RID: 30497 RVA: 0x00208C34 File Offset: 0x00206E34
			public LuaExportHelper(SurveyComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007722 RID: 30498 RVA: 0x00208C44 File Offset: 0x00206E44
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007723 RID: 30499 RVA: 0x00208C54 File Offset: 0x00206E54
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007724 RID: 30500 RVA: 0x00208C64 File Offset: 0x00206E64
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06007725 RID: 30501 RVA: 0x00208C74 File Offset: 0x00206E74
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007726 RID: 30502 RVA: 0x00208C84 File Offset: 0x00206E84
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06007727 RID: 30503 RVA: 0x00208C94 File Offset: 0x00206E94
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06007728 RID: 30504 RVA: 0x00208CA4 File Offset: 0x00206EA4
			public void __callBase_FlushSurvey()
			{
				this.m_owner.__callBase_FlushSurvey();
			}

			// Token: 0x06007729 RID: 30505 RVA: 0x00208CB4 File Offset: 0x00206EB4
			public SurveyStatus __callBase_GetSurveyStatus(Survey survey)
			{
				return this.m_owner.__callBase_GetSurveyStatus(survey);
			}

			// Token: 0x0600772A RID: 30506 RVA: 0x00208CC4 File Offset: 0x00206EC4
			public void __callBase_SetSurveyStatus(SurveyStatus status)
			{
				this.m_owner.__callBase_SetSurveyStatus(status);
			}

			// Token: 0x0600772B RID: 30507 RVA: 0x00208CD4 File Offset: 0x00206ED4
			public void __callBase_SetCurrentSurvey(Survey survey)
			{
				this.m_owner.__callBase_SetCurrentSurvey(survey);
			}

			// Token: 0x0600772C RID: 30508 RVA: 0x00208CE4 File Offset: 0x00206EE4
			public SurveyStatus __callBase_GetCurrentSurveyStatus()
			{
				return this.m_owner.__callBase_GetCurrentSurveyStatus();
			}

			// Token: 0x0600772D RID: 30509 RVA: 0x00208CF4 File Offset: 0x00206EF4
			public int __callBase_CanGainSurveyReward()
			{
				return this.m_owner.__callBase_CanGainSurveyReward();
			}

			// Token: 0x04005645 RID: 22085
			private SurveyComponent m_owner;
		}
	}
}
