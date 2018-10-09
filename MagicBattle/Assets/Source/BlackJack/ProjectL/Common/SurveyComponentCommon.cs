using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004AA RID: 1194
	[HotFix]
	public class SurveyComponentCommon : IComponentBase
	{
		// Token: 0x060048C4 RID: 18628 RVA: 0x0016953C File Offset: 0x0016773C
		public SurveyComponentCommon()
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

		// Token: 0x060048C5 RID: 18629 RVA: 0x001695B0 File Offset: 0x001677B0
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "Survey";
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00169624 File Offset: 0x00167824
		public virtual void Init()
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
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x00169684 File Offset: 0x00167884
		public virtual void PostInit()
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
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x0016971C File Offset: 0x0016791C
		public virtual void DeInit()
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
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x0016977C File Offset: 0x0016797C
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.FlushSurvey();
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x001697F4 File Offset: 0x001679F4
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x00169874 File Offset: 0x00167A74
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x001698E4 File Offset: 0x00167AE4
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x060048CD RID: 18637 RVA: 0x00169944 File Offset: 0x00167B44
		// (set) Token: 0x060048CE RID: 18638 RVA: 0x001699B8 File Offset: 0x00167BB8
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x00169A30 File Offset: 0x00167C30
		protected void FlushSurvey()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushSurvey_hotfix != null)
			{
				this.m_FlushSurvey_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.GetCurrentSurveyStatus() != SurveyStatus.Expired && this.GetSurveyStatus(this.m_survey.GetCurrentSurvey()) == SurveyStatus.Expired)
			{
				this.SetCurrentSurvey(null);
			}
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x00169ABC File Offset: 0x00167CBC
		protected SurveyStatus GetSurveyStatus(Survey survey)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSurveyStatusSurvey_hotfix != null)
			{
				return (SurveyStatus)this.m_GetSurveyStatusSurvey_hotfix.call(new object[]
				{
					this,
					survey
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (survey == null)
			{
				return SurveyStatus.Expired;
			}
			DateTime now = DateTime.Now;
			if (now >= survey.EndTime)
			{
				return SurveyStatus.Expired;
			}
			if (now < survey.StartTime)
			{
				return SurveyStatus.Locking;
			}
			if (survey.Status != SurveyStatus.Locking)
			{
				return survey.Status;
			}
			return SurveyStatus.UnOpen;
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00169B80 File Offset: 0x00167D80
		public void SetSurveyStatus(SurveyStatus status)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSurveyStatusSurveyStatus_hotfix != null)
			{
				this.m_SetSurveyStatusSurveyStatus_hotfix.call(new object[]
				{
					this,
					status
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_survey.SetSurveyStatus(status);
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x00169BFC File Offset: 0x00167DFC
		public void SetCurrentSurvey(Survey survey)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCurrentSurveySurvey_hotfix != null)
			{
				this.m_SetCurrentSurveySurvey_hotfix.call(new object[]
				{
					this,
					survey
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_survey.SetCurrentSurvey(survey);
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x00169C78 File Offset: 0x00167E78
		public SurveyStatus GetCurrentSurveyStatus()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCurrentSurveyStatus_hotfix != null)
			{
				return (SurveyStatus)this.m_GetCurrentSurveyStatus_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_survey.GetCurrentSurveyStatus();
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x00169CF0 File Offset: 0x00167EF0
		public int CanGainSurveyReward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGainSurveyReward_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGainSurveyReward_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Survey currentSurvey = this.m_survey.GetCurrentSurvey();
			if (currentSurvey == null)
			{
				return -2501;
			}
			if (currentSurvey.Status == SurveyStatus.Finished)
			{
				return -2500;
			}
			if (currentSurvey.Status == SurveyStatus.Open)
			{
				if (this.m_bag.IsBagFullByCurrentSize())
				{
					return -500;
				}
				if (this.m_basicInfo.GetLevel() < this.m_configDataLoader.ConfigableConstId_WriteSurveyPlayerLevel)
				{
					return -2504;
				}
				return 0;
			}
			else
			{
				if (currentSurvey.Status == SurveyStatus.UnOpen)
				{
					return -2502;
				}
				return -2501;
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x060048D5 RID: 18645 RVA: 0x00169DE4 File Offset: 0x00167FE4
		// (set) Token: 0x060048D6 RID: 18646 RVA: 0x00169E04 File Offset: 0x00168004
		[DoNotToLua]
		public SurveyComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SurveyComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x00169E10 File Offset: 0x00168010
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_FlushSurvey_hotfix = (luaObj.RawGet("FlushSurvey") as LuaFunction);
					this.m_GetSurveyStatusSurvey_hotfix = (luaObj.RawGet("GetSurveyStatus") as LuaFunction);
					this.m_SetSurveyStatusSurveyStatus_hotfix = (luaObj.RawGet("SetSurveyStatus") as LuaFunction);
					this.m_SetCurrentSurveySurvey_hotfix = (luaObj.RawGet("SetCurrentSurvey") as LuaFunction);
					this.m_GetCurrentSurveyStatus_hotfix = (luaObj.RawGet("GetCurrentSurveyStatus") as LuaFunction);
					this.m_CanGainSurveyReward_hotfix = (luaObj.RawGet("CanGainSurveyReward") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x0016A06C File Offset: 0x0016826C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SurveyComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400370A RID: 14090
		protected BagComponentCommon m_bag;

		// Token: 0x0400370B RID: 14091
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x0400370C RID: 14092
		protected DataSectionSurvey m_survey = new DataSectionSurvey();

		// Token: 0x0400370D RID: 14093
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x0400370E RID: 14094
		[DoNotToLua]
		private SurveyComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x0400370F RID: 14095
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003710 RID: 14096
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003711 RID: 14097
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003712 RID: 14098
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003713 RID: 14099
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003714 RID: 14100
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003715 RID: 14101
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003716 RID: 14102
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003717 RID: 14103
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003718 RID: 14104
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003719 RID: 14105
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x0400371A RID: 14106
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x0400371B RID: 14107
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x0400371C RID: 14108
		private LuaFunction m_FlushSurvey_hotfix;

		// Token: 0x0400371D RID: 14109
		private LuaFunction m_GetSurveyStatusSurvey_hotfix;

		// Token: 0x0400371E RID: 14110
		private LuaFunction m_SetSurveyStatusSurveyStatus_hotfix;

		// Token: 0x0400371F RID: 14111
		private LuaFunction m_SetCurrentSurveySurvey_hotfix;

		// Token: 0x04003720 RID: 14112
		private LuaFunction m_GetCurrentSurveyStatus_hotfix;

		// Token: 0x04003721 RID: 14113
		private LuaFunction m_CanGainSurveyReward_hotfix;

		// Token: 0x020004AB RID: 1195
		public class LuaExportHelper
		{
			// Token: 0x060048D9 RID: 18649 RVA: 0x0016A0D4 File Offset: 0x001682D4
			public LuaExportHelper(SurveyComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001221 RID: 4641
			// (get) Token: 0x060048DA RID: 18650 RVA: 0x0016A0E4 File Offset: 0x001682E4
			// (set) Token: 0x060048DB RID: 18651 RVA: 0x0016A0F4 File Offset: 0x001682F4
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x17001222 RID: 4642
			// (get) Token: 0x060048DC RID: 18652 RVA: 0x0016A104 File Offset: 0x00168304
			// (set) Token: 0x060048DD RID: 18653 RVA: 0x0016A114 File Offset: 0x00168314
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x17001223 RID: 4643
			// (get) Token: 0x060048DE RID: 18654 RVA: 0x0016A124 File Offset: 0x00168324
			// (set) Token: 0x060048DF RID: 18655 RVA: 0x0016A134 File Offset: 0x00168334
			public DataSectionSurvey m_survey
			{
				get
				{
					return this.m_owner.m_survey;
				}
				set
				{
					this.m_owner.m_survey = value;
				}
			}

			// Token: 0x17001224 RID: 4644
			// (get) Token: 0x060048E0 RID: 18656 RVA: 0x0016A144 File Offset: 0x00168344
			// (set) Token: 0x060048E1 RID: 18657 RVA: 0x0016A154 File Offset: 0x00168354
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x060048E2 RID: 18658 RVA: 0x0016A164 File Offset: 0x00168364
			public void FlushSurvey()
			{
				this.m_owner.FlushSurvey();
			}

			// Token: 0x060048E3 RID: 18659 RVA: 0x0016A174 File Offset: 0x00168374
			public SurveyStatus GetSurveyStatus(Survey survey)
			{
				return this.m_owner.GetSurveyStatus(survey);
			}

			// Token: 0x04003722 RID: 14114
			private SurveyComponentCommon m_owner;
		}
	}
}
