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
	// Token: 0x020009B1 RID: 2481
	[HotFix]
	public class IntegralGoodsUIController : UIControllerBase
	{
		// Token: 0x0600900C RID: 36876 RVA: 0x0029E16C File Offset: 0x0029C36C
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnItemClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600900D RID: 36877 RVA: 0x0029E1FC File Offset: 0x0029C3FC
		public void InitIntegralGoodsInfo(ConfigDataNoviceRewardInfo reward, int slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitIntegralGoodsInfoConfigDataNoviceRewardInfoInt32_hotfix != null)
			{
				this.m_InitIntegralGoodsInfoConfigDataNoviceRewardInfoInt32_hotfix.call(new object[]
				{
					this,
					reward,
					slot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.NoviceReward = reward;
			this.Slot = slot;
			this.SetIntegralGoodsState();
			this.SetIntegralGoodsInfo();
		}

		// Token: 0x0600900E RID: 36878 RVA: 0x0029E298 File Offset: 0x0029C498
		private void SetIntegralGoodsState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIntegralGoodsState_hotfix != null)
			{
				this.m_SetIntegralGoodsState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanClaimNoviceReward(this.Slot);
			if (num == 0)
			{
				this.m_integralGoodsState = IntegralGoodsUIController.IntegralGoodsState.CanGet;
				this.m_stateCtrl.SetToUIState("CanGet", false, true);
			}
			else if (num == -4601)
			{
				this.m_integralGoodsState = IntegralGoodsUIController.IntegralGoodsState.Got;
				this.m_stateCtrl.SetToUIState("Got", false, true);
			}
			else
			{
				this.m_integralGoodsState = IntegralGoodsUIController.IntegralGoodsState.Normal;
				this.m_stateCtrl.SetToUIState("Normal", false, true);
			}
		}

		// Token: 0x0600900F RID: 36879 RVA: 0x0029E37C File Offset: 0x0029C57C
		private void SetIntegralGoodsInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIntegralGoodsInfo_hotfix != null)
			{
				this.m_SetIntegralGoodsInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_integralText.text = this.NoviceReward.NovicePoints.ToString();
			if (this.NoviceReward.Reward.Count == 0)
			{
				return;
			}
			Goods goods = this.NoviceReward.Reward[0];
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
			this.m_iconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(goods.GoodsType, goods.Id));
			this.m_countValueText.text = goods.Count.ToString();
			bool flag = UIUtility.IsGoodsHeroFragment(goods.GoodsType, goods.Id);
			if (flag)
			{
				this.m_iconImage.transform.localScale = Vector3.one;
				this.m_bgImage.gameObject.SetActive(false);
				this.m_ssrEffect.SetActive(false);
				this.m_crystalEffect.SetActive(false);
			}
			else
			{
				this.m_bgImage.gameObject.SetActive(true);
				this.m_bgImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameName(goods.GoodsType, goods.Id));
				this.m_ssrEffect.SetActive(UIUtility.IsRankSSR(UIUtility.GetGoodsRank(goods.GoodsType, goods.Id)));
				this.m_crystalEffect.SetActive(goods.GoodsType == GoodsType.GoodsType_Crystal);
			}
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x0029E55C File Offset: 0x0029C75C
		private void OnItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemClick_hotfix != null)
			{
				this.m_OnItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (this.m_integralGoodsState)
			{
			case IntegralGoodsUIController.IntegralGoodsState.Normal:
				if (this.NoviceReward != null)
				{
					if (this.NoviceReward.Reward.Count == 0)
					{
						return;
					}
					Goods goods = this.NoviceReward.Reward[0];
					RewardGoodsDescUITask.StartUITask(this, goods.GoodsType, goods.Id, 0, null, true);
				}
				break;
			case IntegralGoodsUIController.IntegralGoodsState.CanGet:
				if (this.EventOnIntegralGoodsClick != null)
				{
					this.EventOnIntegralGoodsClick(this);
				}
				break;
			}
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x0029E650 File Offset: 0x0029C850
		public void PlayGotChangeEffect(Action OnStateFinish)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayGotChangeEffectAction_hotfix != null)
			{
				this.m_PlayGotChangeEffectAction_hotfix.call(new object[]
				{
					this,
					OnStateFinish2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnStateFinish = OnStateFinish2;
			if (OnStateFinish != null)
			{
				this.m_stateCtrl.SetActionForUIStateFinshed("GotChange", delegate
				{
					OnStateFinish();
				});
			}
			this.m_stateCtrl.SetToUIState("GotChange", false, true);
			this.m_integralGoodsState = IntegralGoodsUIController.IntegralGoodsState.Got;
		}

		// Token: 0x14000192 RID: 402
		// (add) Token: 0x06009012 RID: 36882 RVA: 0x0029E710 File Offset: 0x0029C910
		// (remove) Token: 0x06009013 RID: 36883 RVA: 0x0029E7AC File Offset: 0x0029C9AC
		public event Action<IntegralGoodsUIController> EventOnIntegralGoodsClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnIntegralGoodsClickAction`1_hotfix != null)
				{
					this.m_add_EventOnIntegralGoodsClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<IntegralGoodsUIController> action = this.EventOnIntegralGoodsClick;
				Action<IntegralGoodsUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<IntegralGoodsUIController>>(ref this.EventOnIntegralGoodsClick, (Action<IntegralGoodsUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnIntegralGoodsClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnIntegralGoodsClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<IntegralGoodsUIController> action = this.EventOnIntegralGoodsClick;
				Action<IntegralGoodsUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<IntegralGoodsUIController>>(ref this.EventOnIntegralGoodsClick, (Action<IntegralGoodsUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06009015 RID: 36885 RVA: 0x0029E8C0 File Offset: 0x0029CAC0
		// (set) Token: 0x06009014 RID: 36884 RVA: 0x0029E848 File Offset: 0x0029CA48
		public int Slot
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Slot_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Slot_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Slot>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_SlotInt32_hotfix != null)
				{
					this.m_set_SlotInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Slot>k__BackingField = value;
			}
		}

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x06009017 RID: 36887 RVA: 0x0029E9AC File Offset: 0x0029CBAC
		// (set) Token: 0x06009016 RID: 36886 RVA: 0x0029E934 File Offset: 0x0029CB34
		public ConfigDataNoviceRewardInfo NoviceReward
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_NoviceReward_hotfix != null)
				{
					return (ConfigDataNoviceRewardInfo)this.m_get_NoviceReward_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<NoviceReward>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_NoviceRewardConfigDataNoviceRewardInfo_hotfix != null)
				{
					this.m_set_NoviceRewardConfigDataNoviceRewardInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<NoviceReward>k__BackingField = value;
			}
		}

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x06009018 RID: 36888 RVA: 0x0029EA20 File Offset: 0x0029CC20
		// (set) Token: 0x06009019 RID: 36889 RVA: 0x0029EA40 File Offset: 0x0029CC40
		[DoNotToLua]
		public new IntegralGoodsUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new IntegralGoodsUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x0029EA4C File Offset: 0x0029CC4C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600901B RID: 36891 RVA: 0x0029EA58 File Offset: 0x0029CC58
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x0029EA60 File Offset: 0x0029CC60
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600901D RID: 36893 RVA: 0x0029EA68 File Offset: 0x0029CC68
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x0029EA7C File Offset: 0x0029CC7C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600901F RID: 36895 RVA: 0x0029EA84 File Offset: 0x0029CC84
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009020 RID: 36896 RVA: 0x0029EA90 File Offset: 0x0029CC90
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009021 RID: 36897 RVA: 0x0029EA9C File Offset: 0x0029CC9C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x0029EAA8 File Offset: 0x0029CCA8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x0029EAB4 File Offset: 0x0029CCB4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009024 RID: 36900 RVA: 0x0029EAC0 File Offset: 0x0029CCC0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009025 RID: 36901 RVA: 0x0029EACC File Offset: 0x0029CCCC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009026 RID: 36902 RVA: 0x0029EAD8 File Offset: 0x0029CCD8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009027 RID: 36903 RVA: 0x0029EAE4 File Offset: 0x0029CCE4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009028 RID: 36904 RVA: 0x0029EAF0 File Offset: 0x0029CCF0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x0029EAF8 File Offset: 0x0029CCF8
		private void __callDele_EventOnIntegralGoodsClick(IntegralGoodsUIController obj)
		{
			Action<IntegralGoodsUIController> eventOnIntegralGoodsClick = this.EventOnIntegralGoodsClick;
			if (eventOnIntegralGoodsClick != null)
			{
				eventOnIntegralGoodsClick(obj);
			}
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x0029EB1C File Offset: 0x0029CD1C
		private void __clearDele_EventOnIntegralGoodsClick(IntegralGoodsUIController obj)
		{
			this.EventOnIntegralGoodsClick = null;
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x0029EB28 File Offset: 0x0029CD28
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
					this.m_InitIntegralGoodsInfoConfigDataNoviceRewardInfoInt32_hotfix = (luaObj.RawGet("InitIntegralGoodsInfo") as LuaFunction);
					this.m_SetIntegralGoodsState_hotfix = (luaObj.RawGet("SetIntegralGoodsState") as LuaFunction);
					this.m_SetIntegralGoodsInfo_hotfix = (luaObj.RawGet("SetIntegralGoodsInfo") as LuaFunction);
					this.m_OnItemClick_hotfix = (luaObj.RawGet("OnItemClick") as LuaFunction);
					this.m_PlayGotChangeEffectAction_hotfix = (luaObj.RawGet("PlayGotChangeEffect") as LuaFunction);
					this.m_add_EventOnIntegralGoodsClickAction`1_hotfix = (luaObj.RawGet("add_EventOnIntegralGoodsClick") as LuaFunction);
					this.m_remove_EventOnIntegralGoodsClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnIntegralGoodsClick") as LuaFunction);
					this.m_set_SlotInt32_hotfix = (luaObj.RawGet("set_Slot") as LuaFunction);
					this.m_get_Slot_hotfix = (luaObj.RawGet("get_Slot") as LuaFunction);
					this.m_set_NoviceRewardConfigDataNoviceRewardInfo_hotfix = (luaObj.RawGet("set_NoviceReward") as LuaFunction);
					this.m_get_NoviceReward_hotfix = (luaObj.RawGet("get_NoviceReward") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x0029ED08 File Offset: 0x0029CF08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(IntegralGoodsUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006578 RID: 25976
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04006579 RID: 25977
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400657A RID: 25978
		[AutoBind("./BGImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_bgImage;

		// Token: 0x0400657B RID: 25979
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x0400657C RID: 25980
		[AutoBind("./IconImage/U_crystal", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_crystalEffect;

		// Token: 0x0400657D RID: 25981
		[AutoBind("./SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_ssrEffect;

		// Token: 0x0400657E RID: 25982
		[AutoBind("./CountValue", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_countValueText;

		// Token: 0x0400657F RID: 25983
		[AutoBind("./IntegralGroup/IntegralText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_integralText;

		// Token: 0x04006580 RID: 25984
		private IntegralGoodsUIController.IntegralGoodsState m_integralGoodsState;

		// Token: 0x04006583 RID: 25987
		[DoNotToLua]
		private IntegralGoodsUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006584 RID: 25988
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006585 RID: 25989
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006586 RID: 25990
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006587 RID: 25991
		private LuaFunction m_InitIntegralGoodsInfoConfigDataNoviceRewardInfoInt32_hotfix;

		// Token: 0x04006588 RID: 25992
		private LuaFunction m_SetIntegralGoodsState_hotfix;

		// Token: 0x04006589 RID: 25993
		private LuaFunction m_SetIntegralGoodsInfo_hotfix;

		// Token: 0x0400658A RID: 25994
		private LuaFunction m_OnItemClick_hotfix;

		// Token: 0x0400658B RID: 25995
		private LuaFunction m_PlayGotChangeEffectAction_hotfix;

		// Token: 0x0400658C RID: 25996
		private LuaFunction m_add_EventOnIntegralGoodsClickAction;

		// Token: 0x0400658D RID: 25997
		private LuaFunction m_remove_EventOnIntegralGoodsClickAction;

		// Token: 0x0400658E RID: 25998
		private LuaFunction m_set_SlotInt32_hotfix;

		// Token: 0x0400658F RID: 25999
		private LuaFunction m_get_Slot_hotfix;

		// Token: 0x04006590 RID: 26000
		private LuaFunction m_set_NoviceRewardConfigDataNoviceRewardInfo_hotfix;

		// Token: 0x04006591 RID: 26001
		private LuaFunction m_get_NoviceReward_hotfix;

		// Token: 0x020009B2 RID: 2482
		public enum IntegralGoodsState
		{
			// Token: 0x04006593 RID: 26003
			Normal,
			// Token: 0x04006594 RID: 26004
			CanGet,
			// Token: 0x04006595 RID: 26005
			Got
		}

		// Token: 0x020009B3 RID: 2483
		public new class LuaExportHelper
		{
			// Token: 0x0600902D RID: 36909 RVA: 0x0029ED70 File Offset: 0x0029CF70
			public LuaExportHelper(IntegralGoodsUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600902E RID: 36910 RVA: 0x0029ED80 File Offset: 0x0029CF80
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600902F RID: 36911 RVA: 0x0029ED90 File Offset: 0x0029CF90
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009030 RID: 36912 RVA: 0x0029EDA0 File Offset: 0x0029CFA0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06009031 RID: 36913 RVA: 0x0029EDB0 File Offset: 0x0029CFB0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06009032 RID: 36914 RVA: 0x0029EDC8 File Offset: 0x0029CFC8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009033 RID: 36915 RVA: 0x0029EDD8 File Offset: 0x0029CFD8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009034 RID: 36916 RVA: 0x0029EDE8 File Offset: 0x0029CFE8
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009035 RID: 36917 RVA: 0x0029EDF8 File Offset: 0x0029CFF8
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009036 RID: 36918 RVA: 0x0029EE08 File Offset: 0x0029D008
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009037 RID: 36919 RVA: 0x0029EE18 File Offset: 0x0029D018
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009038 RID: 36920 RVA: 0x0029EE28 File Offset: 0x0029D028
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009039 RID: 36921 RVA: 0x0029EE38 File Offset: 0x0029D038
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600903A RID: 36922 RVA: 0x0029EE48 File Offset: 0x0029D048
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600903B RID: 36923 RVA: 0x0029EE58 File Offset: 0x0029D058
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600903C RID: 36924 RVA: 0x0029EE68 File Offset: 0x0029D068
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600903D RID: 36925 RVA: 0x0029EE78 File Offset: 0x0029D078
			public void __callDele_EventOnIntegralGoodsClick(IntegralGoodsUIController obj)
			{
				this.m_owner.__callDele_EventOnIntegralGoodsClick(obj);
			}

			// Token: 0x0600903E RID: 36926 RVA: 0x0029EE88 File Offset: 0x0029D088
			public void __clearDele_EventOnIntegralGoodsClick(IntegralGoodsUIController obj)
			{
				this.m_owner.__clearDele_EventOnIntegralGoodsClick(obj);
			}

			// Token: 0x17001E07 RID: 7687
			// (get) Token: 0x0600903F RID: 36927 RVA: 0x0029EE98 File Offset: 0x0029D098
			// (set) Token: 0x06009040 RID: 36928 RVA: 0x0029EEA8 File Offset: 0x0029D0A8
			public CommonUIStateController m_stateCtrl
			{
				get
				{
					return this.m_owner.m_stateCtrl;
				}
				set
				{
					this.m_owner.m_stateCtrl = value;
				}
			}

			// Token: 0x17001E08 RID: 7688
			// (get) Token: 0x06009041 RID: 36929 RVA: 0x0029EEB8 File Offset: 0x0029D0B8
			// (set) Token: 0x06009042 RID: 36930 RVA: 0x0029EEC8 File Offset: 0x0029D0C8
			public Button m_button
			{
				get
				{
					return this.m_owner.m_button;
				}
				set
				{
					this.m_owner.m_button = value;
				}
			}

			// Token: 0x17001E09 RID: 7689
			// (get) Token: 0x06009043 RID: 36931 RVA: 0x0029EED8 File Offset: 0x0029D0D8
			// (set) Token: 0x06009044 RID: 36932 RVA: 0x0029EEE8 File Offset: 0x0029D0E8
			public Image m_bgImage
			{
				get
				{
					return this.m_owner.m_bgImage;
				}
				set
				{
					this.m_owner.m_bgImage = value;
				}
			}

			// Token: 0x17001E0A RID: 7690
			// (get) Token: 0x06009045 RID: 36933 RVA: 0x0029EEF8 File Offset: 0x0029D0F8
			// (set) Token: 0x06009046 RID: 36934 RVA: 0x0029EF08 File Offset: 0x0029D108
			public Image m_iconImage
			{
				get
				{
					return this.m_owner.m_iconImage;
				}
				set
				{
					this.m_owner.m_iconImage = value;
				}
			}

			// Token: 0x17001E0B RID: 7691
			// (get) Token: 0x06009047 RID: 36935 RVA: 0x0029EF18 File Offset: 0x0029D118
			// (set) Token: 0x06009048 RID: 36936 RVA: 0x0029EF28 File Offset: 0x0029D128
			public GameObject m_crystalEffect
			{
				get
				{
					return this.m_owner.m_crystalEffect;
				}
				set
				{
					this.m_owner.m_crystalEffect = value;
				}
			}

			// Token: 0x17001E0C RID: 7692
			// (get) Token: 0x06009049 RID: 36937 RVA: 0x0029EF38 File Offset: 0x0029D138
			// (set) Token: 0x0600904A RID: 36938 RVA: 0x0029EF48 File Offset: 0x0029D148
			public GameObject m_ssrEffect
			{
				get
				{
					return this.m_owner.m_ssrEffect;
				}
				set
				{
					this.m_owner.m_ssrEffect = value;
				}
			}

			// Token: 0x17001E0D RID: 7693
			// (get) Token: 0x0600904B RID: 36939 RVA: 0x0029EF58 File Offset: 0x0029D158
			// (set) Token: 0x0600904C RID: 36940 RVA: 0x0029EF68 File Offset: 0x0029D168
			public Text m_countValueText
			{
				get
				{
					return this.m_owner.m_countValueText;
				}
				set
				{
					this.m_owner.m_countValueText = value;
				}
			}

			// Token: 0x17001E0E RID: 7694
			// (get) Token: 0x0600904D RID: 36941 RVA: 0x0029EF78 File Offset: 0x0029D178
			// (set) Token: 0x0600904E RID: 36942 RVA: 0x0029EF88 File Offset: 0x0029D188
			public Text m_integralText
			{
				get
				{
					return this.m_owner.m_integralText;
				}
				set
				{
					this.m_owner.m_integralText = value;
				}
			}

			// Token: 0x17001E0F RID: 7695
			// (get) Token: 0x0600904F RID: 36943 RVA: 0x0029EF98 File Offset: 0x0029D198
			// (set) Token: 0x06009050 RID: 36944 RVA: 0x0029EFA8 File Offset: 0x0029D1A8
			public IntegralGoodsUIController.IntegralGoodsState m_integralGoodsState
			{
				get
				{
					return this.m_owner.m_integralGoodsState;
				}
				set
				{
					this.m_owner.m_integralGoodsState = value;
				}
			}

			// Token: 0x17001E10 RID: 7696
			// (set) Token: 0x06009051 RID: 36945 RVA: 0x0029EFB8 File Offset: 0x0029D1B8
			public int Slot
			{
				set
				{
					this.m_owner.Slot = value;
				}
			}

			// Token: 0x17001E11 RID: 7697
			// (set) Token: 0x06009052 RID: 36946 RVA: 0x0029EFC8 File Offset: 0x0029D1C8
			public ConfigDataNoviceRewardInfo NoviceReward
			{
				set
				{
					this.m_owner.NoviceReward = value;
				}
			}

			// Token: 0x06009053 RID: 36947 RVA: 0x0029EFD8 File Offset: 0x0029D1D8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06009054 RID: 36948 RVA: 0x0029EFE8 File Offset: 0x0029D1E8
			public void SetIntegralGoodsState()
			{
				this.m_owner.SetIntegralGoodsState();
			}

			// Token: 0x06009055 RID: 36949 RVA: 0x0029EFF8 File Offset: 0x0029D1F8
			public void SetIntegralGoodsInfo()
			{
				this.m_owner.SetIntegralGoodsInfo();
			}

			// Token: 0x06009056 RID: 36950 RVA: 0x0029F008 File Offset: 0x0029D208
			public void OnItemClick()
			{
				this.m_owner.OnItemClick();
			}

			// Token: 0x04006596 RID: 26006
			private IntegralGoodsUIController m_owner;
		}
	}
}
