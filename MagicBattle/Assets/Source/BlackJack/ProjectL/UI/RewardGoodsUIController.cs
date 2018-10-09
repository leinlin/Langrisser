using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BF9 RID: 3065
	[HotFix]
	public class RewardGoodsUIController : UIControllerBase
	{
		// Token: 0x0600D65A RID: 54874 RVA: 0x003A64D4 File Offset: 0x003A46D4
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
			this.m_nameText = Utility.FindChildComponent<Text>(base.gameObject, "NameText", false);
			this.m_countText = Utility.FindChildComponent<Text>(base.gameObject, "CountText", false);
			this.m_crystalEffectGameObject = Utility.FindChildGameObject(this.m_iconImage.gameObject, "U_crystal", false);
			this.m_ssrEffectGameObject = Utility.FindChildGameObject(base.gameObject, "SSREffect", false);
			this.m_ssrPieceEffectGameObject = Utility.FindChildGameObject(base.gameObject, "SSRPieceEffect", false);
			this.m_haveGetGroupRoot = Utility.FindChildGameObject(base.gameObject, "GotGroup", false);
			this.m_button.onClick.AddListener(new UnityAction(this.OnClick));
		}

		// Token: 0x0600D65B RID: 54875 RVA: 0x003A65E8 File Offset: 0x003A47E8
		public void SetReward(Goods r, int alignType = 0, bool isNeedAutoClose = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRewardGoodsInt32Boolean_hotfix != null)
			{
				this.m_SetRewardGoodsInt32Boolean_hotfix.call(new object[]
				{
					this,
					r,
					alignType,
					isNeedAutoClose
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_goodsType = r.GoodsType;
			this.m_goodsId = r.Id;
			this.m_goodsCount = r.Count;
			this.m_alignType = alignType;
			RewardGoodsUIController.m_isNeedAutoClose = isNeedAutoClose;
			this.m_iconImage.gameObject.SetActive(true);
			this.m_iconImage.transform.localScale = Vector3.one;
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(this.m_goodsType, this.m_goodsId));
			this.m_iconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(this.m_goodsType, this.m_goodsId));
			bool flag = UIUtility.IsGoodsHeroFragment(this.m_goodsType, this.m_goodsId);
			bool flag2 = UIUtility.IsGoodsGoblin(this.m_goodsType, this.m_goodsId);
			if (flag)
			{
				this.m_iconImage.transform.localScale = Vector3.one;
			}
			else if (flag2)
			{
				this.m_iconImage.transform.localScale = Vector3.one;
			}
			else if (this.m_goodsType == GoodsType.GoodsType_HeroSkin || this.m_goodsType == GoodsType.GoodsType_SoldierSkin)
			{
				this.m_iconImage.transform.localScale = Vector3.one;
			}
			else
			{
				this.m_iconImage.transform.localScale = Vector3.one * 0.7f;
			}
			int goodsRank = UIUtility.GetGoodsRank(this.m_goodsType, this.m_goodsId);
			if (this.m_crystalEffectGameObject != null)
			{
				this.m_crystalEffectGameObject.SetActive(this.m_goodsType == GoodsType.GoodsType_Crystal);
			}
			string goodsFrameName = UIUtility.GetGoodsFrameName(this.m_goodsType, this.m_goodsId);
			if (!string.IsNullOrEmpty(goodsFrameName))
			{
				this.m_frameImage.gameObject.SetActive(true);
				this.m_frameImage.sprite = AssetUtility.Instance.GetSprite(goodsFrameName);
				if (this.m_ssrEffectGameObject != null)
				{
					this.m_ssrEffectGameObject.SetActive(UIUtility.IsRankSSR(goodsRank));
				}
				if (this.m_ssrPieceEffectGameObject != null)
				{
					this.m_ssrPieceEffectGameObject.SetActive(false);
				}
			}
			else
			{
				this.m_frameImage.gameObject.SetActive(false);
				if (this.m_ssrEffectGameObject != null)
				{
					this.m_ssrEffectGameObject.SetActive(false);
				}
				if (this.m_ssrPieceEffectGameObject != null)
				{
					this.m_ssrPieceEffectGameObject.SetActive(flag && UIUtility.IsRankSSR(goodsRank));
				}
			}
			if (this.m_countText != null)
			{
				this.m_countText.text = r.Count.ToString();
			}
			if (this.m_nameText != null)
			{
				this.m_nameText.text = UIUtility.GetGoodsName(this.m_goodsType, this.m_goodsId);
			}
			if (this.m_haveGetGroupRoot != null)
			{
				this.m_haveGetGroupRoot.SetActive(false);
			}
		}

		// Token: 0x0600D65C RID: 54876 RVA: 0x003A6968 File Offset: 0x003A4B68
		public void ShowCount(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowCountBoolean_hotfix != null)
			{
				this.m_ShowCountBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_countText != null)
			{
				if (this.m_goodsCount <= 1)
				{
					this.m_countText.gameObject.SetActive(false);
				}
				else
				{
					this.m_countText.gameObject.SetActive(show);
				}
			}
		}

		// Token: 0x0600D65D RID: 54877 RVA: 0x003A6A1C File Offset: 0x003A4C1C
		public void ShowTag(string tagName, bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTagStringBoolean_hotfix != null)
			{
				this.m_ShowTagStringBoolean_hotfix.call(new object[]
				{
					this,
					tagName,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Transform transform = base.transform.Find(tagName);
			if (transform != null)
			{
				transform.gameObject.SetActive(show);
			}
		}

		// Token: 0x0600D65E RID: 54878 RVA: 0x003A6AC4 File Offset: 0x003A4CC4
		public void ShowHaveGot(bool isGot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowHaveGotBoolean_hotfix != null)
			{
				this.m_ShowHaveGotBoolean_hotfix.call(new object[]
				{
					this,
					isGot
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_haveGetGroupRoot != null)
			{
				this.m_haveGetGroupRoot.SetActive(isGot);
			}
		}

		// Token: 0x0600D65F RID: 54879 RVA: 0x003A6B54 File Offset: 0x003A4D54
		public static RewardGoodsUIController CreateRewardGoods(Goods g, Transform parent, GameObject prefab, bool showCount = true, int alignType = 0)
		{
			if (prefab == null)
			{
				return null;
			}
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(prefab, parent, false);
			RewardGoodsUIController rewardGoodsUIController = GameObjectUtility.AddControllerToGameObject<RewardGoodsUIController>(go);
			rewardGoodsUIController.SetReward(g, alignType, true);
			rewardGoodsUIController.ShowCount(showCount);
			return rewardGoodsUIController;
		}

		// Token: 0x0600D660 RID: 54880 RVA: 0x003A6B94 File Offset: 0x003A4D94
		public static void CreateRewardGoodsList(List<Goods> goods, Transform parent, GameObject prefab, List<RewardGoodsUIController> ctrlList = null, bool showCount = true, int alignType = 0, bool isNeedAutoClose = true)
		{
			if (prefab == null)
			{
				return;
			}
			RewardGoodsUIController.m_isNeedAutoClose = isNeedAutoClose;
			prefab.SetActive(true);
			foreach (Goods g in goods)
			{
				RewardGoodsUIController rewardGoodsUIController = RewardGoodsUIController.CreateRewardGoods(g, parent, prefab, showCount, alignType);
				if (rewardGoodsUIController != null && ctrlList != null)
				{
					ctrlList.Add(rewardGoodsUIController);
				}
			}
		}

		// Token: 0x0600D661 RID: 54881 RVA: 0x003A6C28 File Offset: 0x003A4E28
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_goodsType == GoodsType.GoodsType_HeroSkin)
			{
				UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(HeroSkinChangeUITask));
				if (uitaskBase == null)
				{
					HeroSkinChangeUITask.StartUITask("ShowOneSkin", this.m_goodsId, null, null);
				}
				else if (uitaskBase.State != Task.TaskState.Running)
				{
					HeroSkinChangeUITask.StartUITask("ShowOneSkin", this.m_goodsId, null, null);
				}
			}
			else if (this.m_goodsType == GoodsType.GoodsType_SoldierSkin)
			{
				UITaskBase uitaskBase2 = UIUtility.FindUITaskWithType(typeof(StoreSoldierSkinDetailUITask));
				if (uitaskBase2 == null)
				{
					StoreSoldierSkinDetailUITask.StartSoldierSkinDetailPanel(this.m_goodsId, StoreSoldierSkinDetailUITask.StartTaskFromType.StartTaskFromGift, null);
				}
				else if (uitaskBase2.State != Task.TaskState.Running)
				{
					StoreSoldierSkinDetailUITask.StartSoldierSkinDetailPanel(this.m_goodsId, StoreSoldierSkinDetailUITask.StartTaskFromType.StartTaskFromGift, null);
				}
			}
			else if (this.m_goodsType == GoodsType.GoodsType_MonthCard)
			{
				MonthCardInfoUITask.StartUITask(this.m_goodsId, null);
			}
			else
			{
				GoodsType goodsType = this.m_goodsType;
				int goodsId = this.m_goodsId;
				int alignType = this.m_alignType;
				bool isNeedAutoClose = RewardGoodsUIController.m_isNeedAutoClose;
				RewardGoodsDescUITask.StartUITask(this, goodsType, goodsId, alignType, null, isNeedAutoClose);
			}
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x0600D662 RID: 54882 RVA: 0x003A6D8C File Offset: 0x003A4F8C
		// (set) Token: 0x0600D663 RID: 54883 RVA: 0x003A6DAC File Offset: 0x003A4FAC
		[DoNotToLua]
		public new RewardGoodsUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RewardGoodsUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D664 RID: 54884 RVA: 0x003A6DB8 File Offset: 0x003A4FB8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D665 RID: 54885 RVA: 0x003A6DC4 File Offset: 0x003A4FC4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D666 RID: 54886 RVA: 0x003A6DCC File Offset: 0x003A4FCC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D667 RID: 54887 RVA: 0x003A6DD4 File Offset: 0x003A4FD4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D668 RID: 54888 RVA: 0x003A6DE8 File Offset: 0x003A4FE8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D669 RID: 54889 RVA: 0x003A6DF0 File Offset: 0x003A4FF0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D66A RID: 54890 RVA: 0x003A6DFC File Offset: 0x003A4FFC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D66B RID: 54891 RVA: 0x003A6E08 File Offset: 0x003A5008
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D66C RID: 54892 RVA: 0x003A6E14 File Offset: 0x003A5014
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D66D RID: 54893 RVA: 0x003A6E20 File Offset: 0x003A5020
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D66E RID: 54894 RVA: 0x003A6E2C File Offset: 0x003A502C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D66F RID: 54895 RVA: 0x003A6E38 File Offset: 0x003A5038
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D670 RID: 54896 RVA: 0x003A6E44 File Offset: 0x003A5044
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D671 RID: 54897 RVA: 0x003A6E50 File Offset: 0x003A5050
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D672 RID: 54898 RVA: 0x003A6E5C File Offset: 0x003A505C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D674 RID: 54900 RVA: 0x003A6E6C File Offset: 0x003A506C
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
					this.m_SetRewardGoodsInt32Boolean_hotfix = (luaObj.RawGet("SetReward") as LuaFunction);
					this.m_ShowCountBoolean_hotfix = (luaObj.RawGet("ShowCount") as LuaFunction);
					this.m_ShowTagStringBoolean_hotfix = (luaObj.RawGet("ShowTag") as LuaFunction);
					this.m_ShowHaveGotBoolean_hotfix = (luaObj.RawGet("ShowHaveGot") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D675 RID: 54901 RVA: 0x003A6FB4 File Offset: 0x003A51B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RewardGoodsUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008416 RID: 33814
		private GoodsType m_goodsType;

		// Token: 0x04008417 RID: 33815
		private int m_goodsId;

		// Token: 0x04008418 RID: 33816
		private int m_goodsCount;

		// Token: 0x04008419 RID: 33817
		private int m_alignType;

		// Token: 0x0400841A RID: 33818
		private static bool m_isNeedAutoClose = true;

		// Token: 0x0400841B RID: 33819
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400841C RID: 33820
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x0400841D RID: 33821
		[AutoBind("./FrameImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_frameImage;

		// Token: 0x0400841E RID: 33822
		private GameObject m_haveGetGroupRoot;

		// Token: 0x0400841F RID: 33823
		private Text m_nameText;

		// Token: 0x04008420 RID: 33824
		private Text m_countText;

		// Token: 0x04008421 RID: 33825
		private GameObject m_crystalEffectGameObject;

		// Token: 0x04008422 RID: 33826
		private GameObject m_ssrEffectGameObject;

		// Token: 0x04008423 RID: 33827
		private GameObject m_ssrPieceEffectGameObject;

		// Token: 0x04008424 RID: 33828
		[DoNotToLua]
		private RewardGoodsUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008425 RID: 33829
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008426 RID: 33830
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008427 RID: 33831
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04008428 RID: 33832
		private LuaFunction m_SetRewardGoodsInt32Boolean_hotfix;

		// Token: 0x04008429 RID: 33833
		private LuaFunction m_ShowCountBoolean_hotfix;

		// Token: 0x0400842A RID: 33834
		private LuaFunction m_ShowTagStringBoolean_hotfix;

		// Token: 0x0400842B RID: 33835
		private LuaFunction m_ShowHaveGotBoolean_hotfix;

		// Token: 0x0400842C RID: 33836
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x02000BFA RID: 3066
		public new class LuaExportHelper
		{
			// Token: 0x0600D676 RID: 54902 RVA: 0x003A701C File Offset: 0x003A521C
			public LuaExportHelper(RewardGoodsUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D677 RID: 54903 RVA: 0x003A702C File Offset: 0x003A522C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D678 RID: 54904 RVA: 0x003A703C File Offset: 0x003A523C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D679 RID: 54905 RVA: 0x003A704C File Offset: 0x003A524C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D67A RID: 54906 RVA: 0x003A705C File Offset: 0x003A525C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D67B RID: 54907 RVA: 0x003A7074 File Offset: 0x003A5274
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D67C RID: 54908 RVA: 0x003A7084 File Offset: 0x003A5284
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D67D RID: 54909 RVA: 0x003A7094 File Offset: 0x003A5294
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D67E RID: 54910 RVA: 0x003A70A4 File Offset: 0x003A52A4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D67F RID: 54911 RVA: 0x003A70B4 File Offset: 0x003A52B4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D680 RID: 54912 RVA: 0x003A70C4 File Offset: 0x003A52C4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D681 RID: 54913 RVA: 0x003A70D4 File Offset: 0x003A52D4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D682 RID: 54914 RVA: 0x003A70E4 File Offset: 0x003A52E4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D683 RID: 54915 RVA: 0x003A70F4 File Offset: 0x003A52F4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D684 RID: 54916 RVA: 0x003A7104 File Offset: 0x003A5304
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D685 RID: 54917 RVA: 0x003A7114 File Offset: 0x003A5314
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170029CF RID: 10703
			// (get) Token: 0x0600D686 RID: 54918 RVA: 0x003A7124 File Offset: 0x003A5324
			// (set) Token: 0x0600D687 RID: 54919 RVA: 0x003A7134 File Offset: 0x003A5334
			public GoodsType m_goodsType
			{
				get
				{
					return this.m_owner.m_goodsType;
				}
				set
				{
					this.m_owner.m_goodsType = value;
				}
			}

			// Token: 0x170029D0 RID: 10704
			// (get) Token: 0x0600D688 RID: 54920 RVA: 0x003A7144 File Offset: 0x003A5344
			// (set) Token: 0x0600D689 RID: 54921 RVA: 0x003A7154 File Offset: 0x003A5354
			public int m_goodsId
			{
				get
				{
					return this.m_owner.m_goodsId;
				}
				set
				{
					this.m_owner.m_goodsId = value;
				}
			}

			// Token: 0x170029D1 RID: 10705
			// (get) Token: 0x0600D68A RID: 54922 RVA: 0x003A7164 File Offset: 0x003A5364
			// (set) Token: 0x0600D68B RID: 54923 RVA: 0x003A7174 File Offset: 0x003A5374
			public int m_goodsCount
			{
				get
				{
					return this.m_owner.m_goodsCount;
				}
				set
				{
					this.m_owner.m_goodsCount = value;
				}
			}

			// Token: 0x170029D2 RID: 10706
			// (get) Token: 0x0600D68C RID: 54924 RVA: 0x003A7184 File Offset: 0x003A5384
			// (set) Token: 0x0600D68D RID: 54925 RVA: 0x003A7194 File Offset: 0x003A5394
			public int m_alignType
			{
				get
				{
					return this.m_owner.m_alignType;
				}
				set
				{
					this.m_owner.m_alignType = value;
				}
			}

			// Token: 0x170029D3 RID: 10707
			// (get) Token: 0x0600D68E RID: 54926 RVA: 0x003A71A4 File Offset: 0x003A53A4
			// (set) Token: 0x0600D68F RID: 54927 RVA: 0x003A71AC File Offset: 0x003A53AC
			public static bool m_isNeedAutoClose
			{
				get
				{
					return RewardGoodsUIController.m_isNeedAutoClose;
				}
				set
				{
					RewardGoodsUIController.m_isNeedAutoClose = value;
				}
			}

			// Token: 0x170029D4 RID: 10708
			// (get) Token: 0x0600D690 RID: 54928 RVA: 0x003A71B4 File Offset: 0x003A53B4
			// (set) Token: 0x0600D691 RID: 54929 RVA: 0x003A71C4 File Offset: 0x003A53C4
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

			// Token: 0x170029D5 RID: 10709
			// (get) Token: 0x0600D692 RID: 54930 RVA: 0x003A71D4 File Offset: 0x003A53D4
			// (set) Token: 0x0600D693 RID: 54931 RVA: 0x003A71E4 File Offset: 0x003A53E4
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

			// Token: 0x170029D6 RID: 10710
			// (get) Token: 0x0600D694 RID: 54932 RVA: 0x003A71F4 File Offset: 0x003A53F4
			// (set) Token: 0x0600D695 RID: 54933 RVA: 0x003A7204 File Offset: 0x003A5404
			public Image m_frameImage
			{
				get
				{
					return this.m_owner.m_frameImage;
				}
				set
				{
					this.m_owner.m_frameImage = value;
				}
			}

			// Token: 0x170029D7 RID: 10711
			// (get) Token: 0x0600D696 RID: 54934 RVA: 0x003A7214 File Offset: 0x003A5414
			// (set) Token: 0x0600D697 RID: 54935 RVA: 0x003A7224 File Offset: 0x003A5424
			public GameObject m_haveGetGroupRoot
			{
				get
				{
					return this.m_owner.m_haveGetGroupRoot;
				}
				set
				{
					this.m_owner.m_haveGetGroupRoot = value;
				}
			}

			// Token: 0x170029D8 RID: 10712
			// (get) Token: 0x0600D698 RID: 54936 RVA: 0x003A7234 File Offset: 0x003A5434
			// (set) Token: 0x0600D699 RID: 54937 RVA: 0x003A7244 File Offset: 0x003A5444
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x170029D9 RID: 10713
			// (get) Token: 0x0600D69A RID: 54938 RVA: 0x003A7254 File Offset: 0x003A5454
			// (set) Token: 0x0600D69B RID: 54939 RVA: 0x003A7264 File Offset: 0x003A5464
			public Text m_countText
			{
				get
				{
					return this.m_owner.m_countText;
				}
				set
				{
					this.m_owner.m_countText = value;
				}
			}

			// Token: 0x170029DA RID: 10714
			// (get) Token: 0x0600D69C RID: 54940 RVA: 0x003A7274 File Offset: 0x003A5474
			// (set) Token: 0x0600D69D RID: 54941 RVA: 0x003A7284 File Offset: 0x003A5484
			public GameObject m_crystalEffectGameObject
			{
				get
				{
					return this.m_owner.m_crystalEffectGameObject;
				}
				set
				{
					this.m_owner.m_crystalEffectGameObject = value;
				}
			}

			// Token: 0x170029DB RID: 10715
			// (get) Token: 0x0600D69E RID: 54942 RVA: 0x003A7294 File Offset: 0x003A5494
			// (set) Token: 0x0600D69F RID: 54943 RVA: 0x003A72A4 File Offset: 0x003A54A4
			public GameObject m_ssrEffectGameObject
			{
				get
				{
					return this.m_owner.m_ssrEffectGameObject;
				}
				set
				{
					this.m_owner.m_ssrEffectGameObject = value;
				}
			}

			// Token: 0x170029DC RID: 10716
			// (get) Token: 0x0600D6A0 RID: 54944 RVA: 0x003A72B4 File Offset: 0x003A54B4
			// (set) Token: 0x0600D6A1 RID: 54945 RVA: 0x003A72C4 File Offset: 0x003A54C4
			public GameObject m_ssrPieceEffectGameObject
			{
				get
				{
					return this.m_owner.m_ssrPieceEffectGameObject;
				}
				set
				{
					this.m_owner.m_ssrPieceEffectGameObject = value;
				}
			}

			// Token: 0x0600D6A2 RID: 54946 RVA: 0x003A72D4 File Offset: 0x003A54D4
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D6A3 RID: 54947 RVA: 0x003A72E4 File Offset: 0x003A54E4
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0400842D RID: 33837
			private RewardGoodsUIController m_owner;
		}
	}
}
