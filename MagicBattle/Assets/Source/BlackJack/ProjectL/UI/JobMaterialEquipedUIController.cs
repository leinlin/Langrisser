using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DA7 RID: 3495
	[HotFix]
	public class JobMaterialEquipedUIController : UIControllerBase
	{
		// Token: 0x0601086B RID: 67691 RVA: 0x0044C6B0 File Offset: 0x0044A8B0
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			base.gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnJobMaterialClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x0601086C RID: 67692 RVA: 0x0044C744 File Offset: 0x0044A944
		public void InitJobMaterial(Goods jobMaterialGood)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitJobMaterialGoods_hotfix != null)
			{
				this.m_InitJobMaterialGoods_hotfix.call(new object[]
				{
					this,
					jobMaterialGood
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.JobMaterialInfo = configDataLoader.GetConfigDataJobMaterialInfo(jobMaterialGood.Id);
			this.m_iconImg.sprite = AssetUtility.Instance.GetSprite(this.JobMaterialInfo.Icon);
			this.m_bgImg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameName(jobMaterialGood.GoodsType, jobMaterialGood.Id));
			this.NeedCount = jobMaterialGood.Count;
			this.HaveCount = projectLPlayerContext.GetBagItemCountByType(jobMaterialGood.GoodsType, jobMaterialGood.Id);
			this.m_needCountText.text = this.NeedCount.ToString();
			this.m_haveCountText.text = this.HaveCount.ToString();
			CommonUIStateController component = base.gameObject.GetComponent<CommonUIStateController>();
			if (this.NeedCount > this.HaveCount)
			{
				component.SetToUIState("TextRed", false, true);
			}
			else
			{
				component.SetToUIState("TextWhite", false, true);
			}
		}

		// Token: 0x0601086D RID: 67693 RVA: 0x0044C8D0 File Offset: 0x0044AAD0
		private void OnJobMaterialClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnJobMaterialClick_hotfix != null)
			{
				this.m_OnJobMaterialClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnJobMaterialClick != null)
			{
				this.EventOnJobMaterialClick(this);
			}
		}

		// Token: 0x1400037F RID: 895
		// (add) Token: 0x0601086E RID: 67694 RVA: 0x0044C948 File Offset: 0x0044AB48
		// (remove) Token: 0x0601086F RID: 67695 RVA: 0x0044C9E4 File Offset: 0x0044ABE4
		public event Action<JobMaterialEquipedUIController> EventOnJobMaterialClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnJobMaterialClickAction`1_hotfix != null)
				{
					this.m_add_EventOnJobMaterialClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<JobMaterialEquipedUIController> action = this.EventOnJobMaterialClick;
				Action<JobMaterialEquipedUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<JobMaterialEquipedUIController>>(ref this.EventOnJobMaterialClick, (Action<JobMaterialEquipedUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnJobMaterialClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnJobMaterialClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<JobMaterialEquipedUIController> action = this.EventOnJobMaterialClick;
				Action<JobMaterialEquipedUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<JobMaterialEquipedUIController>>(ref this.EventOnJobMaterialClick, (Action<JobMaterialEquipedUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x06010871 RID: 67697 RVA: 0x0044CAF8 File Offset: 0x0044ACF8
		// (set) Token: 0x06010870 RID: 67696 RVA: 0x0044CA80 File Offset: 0x0044AC80
		public int NeedCount
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_NeedCount_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_NeedCount_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<NeedCount>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_NeedCountInt32_hotfix != null)
				{
					this.m_set_NeedCountInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<NeedCount>k__BackingField = value;
			}
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x06010873 RID: 67699 RVA: 0x0044CBE4 File Offset: 0x0044ADE4
		// (set) Token: 0x06010872 RID: 67698 RVA: 0x0044CB6C File Offset: 0x0044AD6C
		public int HaveCount
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HaveCount_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HaveCount_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<HaveCount>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HaveCountInt32_hotfix != null)
				{
					this.m_set_HaveCountInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<HaveCount>k__BackingField = value;
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x06010875 RID: 67701 RVA: 0x0044CCD0 File Offset: 0x0044AED0
		// (set) Token: 0x06010874 RID: 67700 RVA: 0x0044CC58 File Offset: 0x0044AE58
		public ConfigDataJobMaterialInfo JobMaterialInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_JobMaterialInfo_hotfix != null)
				{
					return (ConfigDataJobMaterialInfo)this.m_get_JobMaterialInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<JobMaterialInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_JobMaterialInfoConfigDataJobMaterialInfo_hotfix != null)
				{
					this.m_set_JobMaterialInfoConfigDataJobMaterialInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<JobMaterialInfo>k__BackingField = value;
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x06010876 RID: 67702 RVA: 0x0044CD44 File Offset: 0x0044AF44
		// (set) Token: 0x06010877 RID: 67703 RVA: 0x0044CD64 File Offset: 0x0044AF64
		[DoNotToLua]
		public new JobMaterialEquipedUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new JobMaterialEquipedUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010878 RID: 67704 RVA: 0x0044CD70 File Offset: 0x0044AF70
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010879 RID: 67705 RVA: 0x0044CD7C File Offset: 0x0044AF7C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601087A RID: 67706 RVA: 0x0044CD84 File Offset: 0x0044AF84
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601087B RID: 67707 RVA: 0x0044CD8C File Offset: 0x0044AF8C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601087C RID: 67708 RVA: 0x0044CDA0 File Offset: 0x0044AFA0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601087D RID: 67709 RVA: 0x0044CDA8 File Offset: 0x0044AFA8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601087E RID: 67710 RVA: 0x0044CDB4 File Offset: 0x0044AFB4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601087F RID: 67711 RVA: 0x0044CDC0 File Offset: 0x0044AFC0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010880 RID: 67712 RVA: 0x0044CDCC File Offset: 0x0044AFCC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010881 RID: 67713 RVA: 0x0044CDD8 File Offset: 0x0044AFD8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010882 RID: 67714 RVA: 0x0044CDE4 File Offset: 0x0044AFE4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010883 RID: 67715 RVA: 0x0044CDF0 File Offset: 0x0044AFF0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010884 RID: 67716 RVA: 0x0044CDFC File Offset: 0x0044AFFC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010885 RID: 67717 RVA: 0x0044CE08 File Offset: 0x0044B008
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010886 RID: 67718 RVA: 0x0044CE14 File Offset: 0x0044B014
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010887 RID: 67719 RVA: 0x0044CE1C File Offset: 0x0044B01C
		private void __callDele_EventOnJobMaterialClick(JobMaterialEquipedUIController obj)
		{
			Action<JobMaterialEquipedUIController> eventOnJobMaterialClick = this.EventOnJobMaterialClick;
			if (eventOnJobMaterialClick != null)
			{
				eventOnJobMaterialClick(obj);
			}
		}

		// Token: 0x06010888 RID: 67720 RVA: 0x0044CE40 File Offset: 0x0044B040
		private void __clearDele_EventOnJobMaterialClick(JobMaterialEquipedUIController obj)
		{
			this.EventOnJobMaterialClick = null;
		}

		// Token: 0x06010889 RID: 67721 RVA: 0x0044CE4C File Offset: 0x0044B04C
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_InitJobMaterialGoods_hotfix = (luaObj.RawGet("InitJobMaterial") as LuaFunction);
					this.m_OnJobMaterialClick_hotfix = (luaObj.RawGet("OnJobMaterialClick") as LuaFunction);
					this.m_add_EventOnJobMaterialClickAction`1_hotfix = (luaObj.RawGet("add_EventOnJobMaterialClick") as LuaFunction);
					this.m_remove_EventOnJobMaterialClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnJobMaterialClick") as LuaFunction);
					this.m_set_NeedCountInt32_hotfix = (luaObj.RawGet("set_NeedCount") as LuaFunction);
					this.m_get_NeedCount_hotfix = (luaObj.RawGet("get_NeedCount") as LuaFunction);
					this.m_set_HaveCountInt32_hotfix = (luaObj.RawGet("set_HaveCount") as LuaFunction);
					this.m_get_HaveCount_hotfix = (luaObj.RawGet("get_HaveCount") as LuaFunction);
					this.m_set_JobMaterialInfoConfigDataJobMaterialInfo_hotfix = (luaObj.RawGet("set_JobMaterialInfo") as LuaFunction);
					this.m_get_JobMaterialInfo_hotfix = (luaObj.RawGet("get_JobMaterialInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601088A RID: 67722 RVA: 0x0044D014 File Offset: 0x0044B214
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(JobMaterialEquipedUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400992D RID: 39213
		[AutoBind("./ImageButton", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImg;

		// Token: 0x0400992E RID: 39214
		[AutoBind("./BgImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_bgImg;

		// Token: 0x0400992F RID: 39215
		[AutoBind("./ValueGroup/NeedCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_needCountText;

		// Token: 0x04009930 RID: 39216
		[AutoBind("./ValueGroup/HaveCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_haveCountText;

		// Token: 0x04009934 RID: 39220
		[DoNotToLua]
		private JobMaterialEquipedUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009935 RID: 39221
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009936 RID: 39222
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009937 RID: 39223
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009938 RID: 39224
		private LuaFunction m_InitJobMaterialGoods_hotfix;

		// Token: 0x04009939 RID: 39225
		private LuaFunction m_OnJobMaterialClick_hotfix;

		// Token: 0x0400993A RID: 39226
		private LuaFunction m_add_EventOnJobMaterialClickAction;

		// Token: 0x0400993B RID: 39227
		private LuaFunction m_remove_EventOnJobMaterialClickAction;

		// Token: 0x0400993C RID: 39228
		private LuaFunction m_set_NeedCountInt32_hotfix;

		// Token: 0x0400993D RID: 39229
		private LuaFunction m_get_NeedCount_hotfix;

		// Token: 0x0400993E RID: 39230
		private LuaFunction m_set_HaveCountInt32_hotfix;

		// Token: 0x0400993F RID: 39231
		private LuaFunction m_get_HaveCount_hotfix;

		// Token: 0x04009940 RID: 39232
		private LuaFunction m_set_JobMaterialInfoConfigDataJobMaterialInfo_hotfix;

		// Token: 0x04009941 RID: 39233
		private LuaFunction m_get_JobMaterialInfo_hotfix;

		// Token: 0x02000DA8 RID: 3496
		public new class LuaExportHelper
		{
			// Token: 0x0601088B RID: 67723 RVA: 0x0044D07C File Offset: 0x0044B27C
			public LuaExportHelper(JobMaterialEquipedUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601088C RID: 67724 RVA: 0x0044D08C File Offset: 0x0044B28C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0601088D RID: 67725 RVA: 0x0044D09C File Offset: 0x0044B29C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0601088E RID: 67726 RVA: 0x0044D0AC File Offset: 0x0044B2AC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0601088F RID: 67727 RVA: 0x0044D0BC File Offset: 0x0044B2BC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010890 RID: 67728 RVA: 0x0044D0D4 File Offset: 0x0044B2D4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010891 RID: 67729 RVA: 0x0044D0E4 File Offset: 0x0044B2E4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010892 RID: 67730 RVA: 0x0044D0F4 File Offset: 0x0044B2F4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010893 RID: 67731 RVA: 0x0044D104 File Offset: 0x0044B304
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010894 RID: 67732 RVA: 0x0044D114 File Offset: 0x0044B314
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010895 RID: 67733 RVA: 0x0044D124 File Offset: 0x0044B324
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010896 RID: 67734 RVA: 0x0044D134 File Offset: 0x0044B334
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010897 RID: 67735 RVA: 0x0044D144 File Offset: 0x0044B344
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010898 RID: 67736 RVA: 0x0044D154 File Offset: 0x0044B354
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010899 RID: 67737 RVA: 0x0044D164 File Offset: 0x0044B364
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601089A RID: 67738 RVA: 0x0044D174 File Offset: 0x0044B374
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601089B RID: 67739 RVA: 0x0044D184 File Offset: 0x0044B384
			public void __callDele_EventOnJobMaterialClick(JobMaterialEquipedUIController obj)
			{
				this.m_owner.__callDele_EventOnJobMaterialClick(obj);
			}

			// Token: 0x0601089C RID: 67740 RVA: 0x0044D194 File Offset: 0x0044B394
			public void __clearDele_EventOnJobMaterialClick(JobMaterialEquipedUIController obj)
			{
				this.m_owner.__clearDele_EventOnJobMaterialClick(obj);
			}

			// Token: 0x17003323 RID: 13091
			// (get) Token: 0x0601089D RID: 67741 RVA: 0x0044D1A4 File Offset: 0x0044B3A4
			// (set) Token: 0x0601089E RID: 67742 RVA: 0x0044D1B4 File Offset: 0x0044B3B4
			public Image m_iconImg
			{
				get
				{
					return this.m_owner.m_iconImg;
				}
				set
				{
					this.m_owner.m_iconImg = value;
				}
			}

			// Token: 0x17003324 RID: 13092
			// (get) Token: 0x0601089F RID: 67743 RVA: 0x0044D1C4 File Offset: 0x0044B3C4
			// (set) Token: 0x060108A0 RID: 67744 RVA: 0x0044D1D4 File Offset: 0x0044B3D4
			public Image m_bgImg
			{
				get
				{
					return this.m_owner.m_bgImg;
				}
				set
				{
					this.m_owner.m_bgImg = value;
				}
			}

			// Token: 0x17003325 RID: 13093
			// (get) Token: 0x060108A1 RID: 67745 RVA: 0x0044D1E4 File Offset: 0x0044B3E4
			// (set) Token: 0x060108A2 RID: 67746 RVA: 0x0044D1F4 File Offset: 0x0044B3F4
			public Text m_needCountText
			{
				get
				{
					return this.m_owner.m_needCountText;
				}
				set
				{
					this.m_owner.m_needCountText = value;
				}
			}

			// Token: 0x17003326 RID: 13094
			// (get) Token: 0x060108A3 RID: 67747 RVA: 0x0044D204 File Offset: 0x0044B404
			// (set) Token: 0x060108A4 RID: 67748 RVA: 0x0044D214 File Offset: 0x0044B414
			public Text m_haveCountText
			{
				get
				{
					return this.m_owner.m_haveCountText;
				}
				set
				{
					this.m_owner.m_haveCountText = value;
				}
			}

			// Token: 0x17003327 RID: 13095
			// (set) Token: 0x060108A5 RID: 67749 RVA: 0x0044D224 File Offset: 0x0044B424
			public int NeedCount
			{
				set
				{
					this.m_owner.NeedCount = value;
				}
			}

			// Token: 0x17003328 RID: 13096
			// (set) Token: 0x060108A6 RID: 67750 RVA: 0x0044D234 File Offset: 0x0044B434
			public int HaveCount
			{
				set
				{
					this.m_owner.HaveCount = value;
				}
			}

			// Token: 0x17003329 RID: 13097
			// (set) Token: 0x060108A7 RID: 67751 RVA: 0x0044D244 File Offset: 0x0044B444
			public ConfigDataJobMaterialInfo JobMaterialInfo
			{
				set
				{
					this.m_owner.JobMaterialInfo = value;
				}
			}

			// Token: 0x060108A8 RID: 67752 RVA: 0x0044D254 File Offset: 0x0044B454
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060108A9 RID: 67753 RVA: 0x0044D264 File Offset: 0x0044B464
			public void OnJobMaterialClick()
			{
				this.m_owner.OnJobMaterialClick();
			}

			// Token: 0x04009942 RID: 39234
			private JobMaterialEquipedUIController m_owner;
		}
	}
}
