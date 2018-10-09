using System;
using System.Collections;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BF4 RID: 3060
	[HotFix]
	public class RewardGoodsDescUIController : UIControllerBase
	{
		// Token: 0x0600D591 RID: 54673 RVA: 0x003A3C68 File Offset: 0x003A1E68
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
		}

		// Token: 0x0600D592 RID: 54674 RVA: 0x003A3CD0 File Offset: 0x003A1ED0
		private void InitRewardGoodsDescInfo(GoodsType goodsType, int goodsId, bool isNeedAutoClose)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitRewardGoodsDescInfoGoodsTypeInt32Boolean_hotfix != null)
			{
				this.m_InitRewardGoodsDescInfoGoodsTypeInt32Boolean_hotfix.call(new object[]
				{
					this,
					goodsType,
					goodsId,
					isNeedAutoClose
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_goodsType = goodsType;
			this.m_goodsId = goodsId;
			GameObject gameObject = Utility.FindChildGameObject(base.gameObject, "Item", true);
			GameObject gameObject2 = Utility.FindChildGameObject(base.gameObject, "Hero", true);
			Text text = null;
			GameObject gameObject3 = null;
			Text text2;
			Text text3;
			Image image;
			GameObject gameObject4;
			if (this.m_goodsType != GoodsType.GoodsType_Hero)
			{
				gameObject.SetActive(true);
				gameObject2.SetActive(false);
				text2 = Utility.FindChildComponent<Text>(gameObject, "BG/ItemInfoGroup/NameText", true);
				text = Utility.FindChildComponent<Text>(gameObject, "BG/ItemInfoGroup/Count/CountText", true);
				gameObject3 = Utility.FindChildGameObject(gameObject, "BG/ItemInfoGroup/Count", true);
				text3 = Utility.FindChildComponent<Text>(gameObject, "BG/BGImage/FrameImage/BottomImage2/Desc/Text", true);
				image = Utility.FindChildComponent<Image>(gameObject, "BG/ItemInfoGroup/IconImage", true);
				gameObject4 = Utility.FindChildGameObject(gameObject, "BG/BGImage", true);
				GameObject gameObject5 = Utility.FindChildGameObject(image.gameObject, "U_crystal", true);
				if (gameObject5 != null)
				{
					gameObject5.SetActive(this.m_goodsType == GoodsType.GoodsType_Crystal);
				}
				GameObject gameObject6 = Utility.FindChildGameObject(gameObject, "BG/ItemInfoGroup/SSRPieceEffect", true);
				if (gameObject6 != null)
				{
					gameObject6.SetActive(UIUtility.IsGoodsHeroFragment(this.m_goodsType, this.m_goodsId) && UIUtility.IsRankSSR(UIUtility.GetGoodsRank(this.m_goodsType, this.m_goodsId)));
				}
			}
			else
			{
				gameObject.SetActive(false);
				gameObject2.SetActive(true);
				text2 = Utility.FindChildComponent<Text>(gameObject2, "NameText", true);
				text3 = Utility.FindChildComponent<Text>(gameObject2, "DescText", true);
				image = Utility.FindChildComponent<Image>(gameObject2, "IconImage", true);
				gameObject4 = Utility.FindChildGameObject(gameObject2, "BG/BGImage", true);
			}
			if (gameObject4 != null)
			{
				PointDescComponent pointDescComponent = base.gameObject.GetComponent<PointDescComponent>();
				if (pointDescComponent == null)
				{
					pointDescComponent = GameObjectUtility.AddControllerToGameObject<PointDescComponent>(base.gameObject);
					PointDescComponent pointDescComponent2 = pointDescComponent;
					GameObject gameObject7 = base.gameObject;
					GameObject gameObject8 = gameObject4;
					pointDescComponent2.SetGameObject(gameObject7, isNeedAutoClose, null, gameObject8);
					pointDescComponent.EventOnClose += delegate()
					{
						this.ClosePanel();
					};
				}
				else
				{
					PointDescComponent pointDescComponent3 = pointDescComponent;
					GameObject gameObject8 = base.gameObject;
					GameObject gameObject7 = gameObject4;
					pointDescComponent3.SetGameObject(gameObject8, isNeedAutoClose, null, gameObject7);
				}
				this.m_backgroundTransform = (gameObject4.transform as RectTransform);
			}
			if (text2 != null)
			{
				text2.text = UIUtility.GetGoodsName(this.m_goodsType, this.m_goodsId);
			}
			if (text3 != null)
			{
				text3.text = UIUtility.GetGoodsDesc(this.m_goodsType, this.m_goodsId);
			}
			if (image != null)
			{
				image.gameObject.SetActive(true);
				image.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(this.m_goodsType, this.m_goodsId));
				image.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(this.m_goodsType, this.m_goodsId));
			}
			if (gameObject3 != null)
			{
				bool flag = this.m_goodsType != GoodsType.GoodsType_Crystal && this.m_goodsType != GoodsType.GoodsType_Energy && this.m_goodsType != GoodsType.GoodsType_Gold && this.m_goodsType != GoodsType.GoodsType_PlayerExp && this.m_goodsType != GoodsType.GoodsType_MemoryEssence && this.m_goodsType != GoodsType.GoodsType_ArenaHonour && this.m_goodsType != GoodsType.GoodsType_MithralStone && this.m_goodsType != GoodsType.GoodsType_BrillianceMithralStone && this.m_goodsType != GoodsType.GoodsType_FriendshipPoints;
				if (this.m_goodsType == GoodsType.GoodsType_Item)
				{
					IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
					ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(goodsId);
					if (configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_RandomBox || configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox)
					{
						flag = false;
					}
					else if (configDataItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_Goblin || configDataItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_UnchartedScore)
					{
						flag = false;
					}
				}
				if (flag)
				{
					gameObject3.SetActive(true);
					CommonUIStateController component = gameObject3.GetComponent<CommonUIStateController>();
					if (this.m_goodsType == GoodsType.GoodsType_Equipment)
					{
						component.SetToUIState("EquipInfo", false, true);
						this.SetEquipmentPropInfo(this.m_goodsId);
					}
					else
					{
						component.SetToUIState("Count", false, true);
						if (text != null)
						{
							text.text = UIUtility.GetGoodsCount(this.m_goodsType, this.m_goodsId).ToString();
						}
					}
				}
				else
				{
					gameObject3.SetActive(false);
				}
			}
		}

		// Token: 0x0600D593 RID: 54675 RVA: 0x003A4194 File Offset: 0x003A2394
		private void SetEquipmentPropInfo(int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentPropInfoInt32_hotfix != null)
			{
				this.m_SetEquipmentPropInfoInt32_hotfix.call(new object[]
				{
					this,
					goodsId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataEquipmentInfo configDataEquipmentInfo = configDataLoader.GetConfigDataEquipmentInfo(goodsId);
			GameObject gameObject = Utility.FindChildGameObject(base.gameObject, "Item/BG/ItemInfoGroup/Count/EquipInfoGroup", true);
			this.HPGo = Utility.FindChildGameObject(gameObject, "HP", true);
			this.ATGo = Utility.FindChildGameObject(gameObject, "AT", true);
			this.DFGo = Utility.FindChildGameObject(gameObject, "DF", true);
			this.MagicGo = Utility.FindChildGameObject(gameObject, "Magic", true);
			this.MagicDFGo = Utility.FindChildGameObject(gameObject, "MagicDF", true);
			this.DEXGo = Utility.FindChildGameObject(gameObject, "DEX", true);
			this.HPText = Utility.FindChildComponent<Text>(gameObject, "HP/Value", true);
			this.ATText = Utility.FindChildComponent<Text>(gameObject, "AT/Value", true);
			this.DFText = Utility.FindChildComponent<Text>(gameObject, "DF/Value", true);
			this.MagicText = Utility.FindChildComponent<Text>(gameObject, "Magic/Value", true);
			this.MagicDFText = Utility.FindChildComponent<Text>(gameObject, "MagicDF/Value", true);
			this.DEXText = Utility.FindChildComponent<Text>(gameObject, "DEX/Value", true);
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				gameObject.transform.GetChild(i).gameObject.SetActive(false);
			}
			this.SetPropItems(configDataEquipmentInfo.Property1_ID, configDataEquipmentInfo.Property1_Value);
			this.SetPropItems(configDataEquipmentInfo.Property2_ID, configDataEquipmentInfo.Property2_Value);
		}

		// Token: 0x0600D594 RID: 54676 RVA: 0x003A4360 File Offset: 0x003A2560
		private void SetPropItems(PropertyModifyType type, int value)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPropItemsPropertyModifyTypeInt32_hotfix != null)
			{
				this.m_SetPropItemsPropertyModifyTypeInt32_hotfix.call(new object[]
				{
					this,
					type,
					value
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (type)
			{
			case PropertyModifyType.PropertyModifyType_Hero1_HPAdd:
				this.HPGo.SetActive(true);
				this.HPText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_ATAdd:
				this.ATGo.SetActive(true);
				this.ATText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DFAdd:
				this.DFGo.SetActive(true);
				this.DFText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicAdd:
				this.MagicGo.SetActive(true);
				this.MagicText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_MagicDFAdd:
				this.MagicDFGo.SetActive(true);
				this.MagicDFText.text = value.ToString();
				break;
			case PropertyModifyType.PropertyModifyType_Hero1_DEXAdd:
				this.DEXGo.SetActive(true);
				this.DEXText.text = value.ToString();
				break;
			}
		}

		// Token: 0x0600D595 RID: 54677 RVA: 0x003A44FC File Offset: 0x003A26FC
		public RectTransform GetBackgroundTransform()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBackgroundTransform_hotfix != null)
			{
				return (RectTransform)this.m_GetBackgroundTransform_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_backgroundTransform;
		}

		// Token: 0x0600D596 RID: 54678 RVA: 0x003A4570 File Offset: 0x003A2770
		public void ShowRewardGoodsDesc(PrefabControllerBase ctrl, GoodsType goodsType, int goodsId, int alignType = 0, GameObject gameObjectForPosCalc = null, bool isNeedAutoClose = true)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowRewardGoodsDescPrefabControllerBaseGoodsTypeInt32Int32GameObjectBoolean_hotfix != null)
			{
				this.m_ShowRewardGoodsDescPrefabControllerBaseGoodsTypeInt32Int32GameObjectBoolean_hotfix.call(new object[]
				{
					this,
					ctrl,
					goodsType,
					goodsId,
					alignType,
					gameObjectForPosCalc,
					isNeedAutoClose
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			PrefabControllerCreater.CreateAllControllers(base.gameObject);
			RewardGoodsDescUIController component = base.gameObject.GetComponent<RewardGoodsDescUIController>();
			component.InitRewardGoodsDescInfo(goodsType, goodsId, isNeedAutoClose);
			if (gameObjectForPosCalc == null)
			{
				gameObjectForPosCalc = ctrl.gameObject;
			}
			component.gameObject.SetActive(true);
			component.StartCoroutine(RewardGoodsDescUIController.Co_ShowRewardGoodsDesc(component, gameObjectForPosCalc, alignType));
		}

		// Token: 0x0600D597 RID: 54679 RVA: 0x003A4690 File Offset: 0x003A2890
		private static IEnumerator Co_ShowRewardGoodsDesc(RewardGoodsDescUIController descCtrl, GameObject gameObjectForPosCalc, int alignType)
		{
			descCtrl.gameObject.transform.position = new Vector3(0f, 100f, 0f);
			yield return null;
			descCtrl.ShowPanel();
			Vector3 p = gameObjectForPosCalc.transform.position;
			descCtrl.gameObject.transform.position = p;
			RectTransform rt = descCtrl.gameObject.transform as RectTransform;
			if (rt != null)
			{
				if (alignType == 0)
				{
					float num = gameObjectForPosCalc.GetComponent<RectTransform>().rect.height * 0.5f;
					float x = 0f;
					if (rt.anchoredPosition.x < 0f && rt.anchoredPosition.x - descCtrl.GetBackgroundTransform().rect.width * 0.5f < -960f)
					{
						x = -960f - (rt.anchoredPosition.x - descCtrl.GetBackgroundTransform().rect.width * 0.5f);
					}
					else if (rt.anchoredPosition.x > 0f && rt.anchoredPosition.x + descCtrl.GetBackgroundTransform().rect.width * 0.5f > 960f)
					{
						x = 960f - (rt.anchoredPosition.x + descCtrl.GetBackgroundTransform().rect.width * 0.5f);
					}
					float y;
					if (p.y > 0f)
					{
						y = -num - 170f;
					}
					else
					{
						y = num + descCtrl.GetBackgroundTransform().rect.height - 160f;
					}
					rt.anchoredPosition = rt.anchoredPosition + new Vector2(x, 0f) + new Vector2(0f, y);
				}
				else
				{
					float num2 = 280f + gameObjectForPosCalc.GetComponent<RectTransform>().rect.width * 0.5f;
					if (p.x > 0.5f)
					{
						num2 = -num2;
					}
					float y2 = 0f;
					if (rt.anchoredPosition.y < 0f && rt.anchoredPosition.y - descCtrl.GetBackgroundTransform().rect.height * 0.5f < -500f)
					{
						y2 = -500f - (rt.anchoredPosition.y - descCtrl.GetBackgroundTransform().rect.height * 0.5f);
					}
					else if (rt.anchoredPosition.y > 0f && rt.anchoredPosition.y + descCtrl.GetBackgroundTransform().rect.height * 0.5f > 500f)
					{
						y2 = 500f - (rt.anchoredPosition.y + descCtrl.GetBackgroundTransform().rect.height * 0.5f);
					}
					rt.anchoredPosition = rt.anchoredPosition + new Vector2(num2, 0f) + new Vector2(0f, y2);
				}
			}
			yield break;
		}

		// Token: 0x0600D598 RID: 54680 RVA: 0x003A46BC File Offset: 0x003A28BC
		public void ShowPanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPanel_hotfix != null)
			{
				this.m_ShowPanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			this.m_uiStateController.SetToUIState("Show", false, true);
		}

		// Token: 0x0600D599 RID: 54681 RVA: 0x003A473C File Offset: 0x003A293C
		private void ClosePanel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClosePanel_hotfix != null)
			{
				this.m_ClosePanel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(false);
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
		}

		// Token: 0x140002A8 RID: 680
		// (add) Token: 0x0600D59A RID: 54682 RVA: 0x003A47C0 File Offset: 0x003A29C0
		// (remove) Token: 0x0600D59B RID: 54683 RVA: 0x003A485C File Offset: 0x003A2A5C
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x0600D59C RID: 54684 RVA: 0x003A48F8 File Offset: 0x003A2AF8
		// (set) Token: 0x0600D59D RID: 54685 RVA: 0x003A4918 File Offset: 0x003A2B18
		[DoNotToLua]
		public new RewardGoodsDescUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RewardGoodsDescUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D59E RID: 54686 RVA: 0x003A4924 File Offset: 0x003A2B24
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600D59F RID: 54687 RVA: 0x003A4930 File Offset: 0x003A2B30
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600D5A0 RID: 54688 RVA: 0x003A4938 File Offset: 0x003A2B38
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600D5A1 RID: 54689 RVA: 0x003A4940 File Offset: 0x003A2B40
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600D5A2 RID: 54690 RVA: 0x003A4954 File Offset: 0x003A2B54
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600D5A3 RID: 54691 RVA: 0x003A495C File Offset: 0x003A2B5C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600D5A4 RID: 54692 RVA: 0x003A4968 File Offset: 0x003A2B68
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600D5A5 RID: 54693 RVA: 0x003A4974 File Offset: 0x003A2B74
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600D5A6 RID: 54694 RVA: 0x003A4980 File Offset: 0x003A2B80
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600D5A7 RID: 54695 RVA: 0x003A498C File Offset: 0x003A2B8C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600D5A8 RID: 54696 RVA: 0x003A4998 File Offset: 0x003A2B98
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600D5A9 RID: 54697 RVA: 0x003A49A4 File Offset: 0x003A2BA4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600D5AA RID: 54698 RVA: 0x003A49B0 File Offset: 0x003A2BB0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600D5AB RID: 54699 RVA: 0x003A49BC File Offset: 0x003A2BBC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600D5AC RID: 54700 RVA: 0x003A49C8 File Offset: 0x003A2BC8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600D5AD RID: 54701 RVA: 0x003A49D0 File Offset: 0x003A2BD0
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600D5AE RID: 54702 RVA: 0x003A49F0 File Offset: 0x003A2BF0
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600D5B0 RID: 54704 RVA: 0x003A4A04 File Offset: 0x003A2C04
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
					this.m_InitRewardGoodsDescInfoGoodsTypeInt32Boolean_hotfix = (luaObj.RawGet("InitRewardGoodsDescInfo") as LuaFunction);
					this.m_SetEquipmentPropInfoInt32_hotfix = (luaObj.RawGet("SetEquipmentPropInfo") as LuaFunction);
					this.m_SetPropItemsPropertyModifyTypeInt32_hotfix = (luaObj.RawGet("SetPropItems") as LuaFunction);
					this.m_GetBackgroundTransform_hotfix = (luaObj.RawGet("GetBackgroundTransform") as LuaFunction);
					this.m_ShowRewardGoodsDescPrefabControllerBaseGoodsTypeInt32Int32GameObjectBoolean_hotfix = (luaObj.RawGet("ShowRewardGoodsDesc") as LuaFunction);
					this.m_ShowPanel_hotfix = (luaObj.RawGet("ShowPanel") as LuaFunction);
					this.m_ClosePanel_hotfix = (luaObj.RawGet("ClosePanel") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D5B1 RID: 54705 RVA: 0x003A4BB0 File Offset: 0x003A2DB0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RewardGoodsDescUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040083CE RID: 33742
		private GoodsType m_goodsType;

		// Token: 0x040083CF RID: 33743
		private int m_goodsId;

		// Token: 0x040083D0 RID: 33744
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x040083D1 RID: 33745
		private GameObject HPGo;

		// Token: 0x040083D2 RID: 33746
		private GameObject ATGo;

		// Token: 0x040083D3 RID: 33747
		private GameObject DFGo;

		// Token: 0x040083D4 RID: 33748
		private GameObject MagicGo;

		// Token: 0x040083D5 RID: 33749
		private GameObject MagicDFGo;

		// Token: 0x040083D6 RID: 33750
		private GameObject DEXGo;

		// Token: 0x040083D7 RID: 33751
		private Text HPText;

		// Token: 0x040083D8 RID: 33752
		private Text ATText;

		// Token: 0x040083D9 RID: 33753
		private Text DFText;

		// Token: 0x040083DA RID: 33754
		private Text MagicText;

		// Token: 0x040083DB RID: 33755
		private Text MagicDFText;

		// Token: 0x040083DC RID: 33756
		private Text DEXText;

		// Token: 0x040083DD RID: 33757
		private RectTransform m_backgroundTransform;

		// Token: 0x040083DE RID: 33758
		[DoNotToLua]
		private RewardGoodsDescUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040083DF RID: 33759
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040083E0 RID: 33760
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040083E1 RID: 33761
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040083E2 RID: 33762
		private LuaFunction m_InitRewardGoodsDescInfoGoodsTypeInt32Boolean_hotfix;

		// Token: 0x040083E3 RID: 33763
		private LuaFunction m_SetEquipmentPropInfoInt32_hotfix;

		// Token: 0x040083E4 RID: 33764
		private LuaFunction m_SetPropItemsPropertyModifyTypeInt32_hotfix;

		// Token: 0x040083E5 RID: 33765
		private LuaFunction m_GetBackgroundTransform_hotfix;

		// Token: 0x040083E6 RID: 33766
		private LuaFunction m_ShowRewardGoodsDescPrefabControllerBaseGoodsTypeInt32Int32GameObjectBoolean_hotfix;

		// Token: 0x040083E7 RID: 33767
		private LuaFunction m_ShowPanel_hotfix;

		// Token: 0x040083E8 RID: 33768
		private LuaFunction m_ClosePanel_hotfix;

		// Token: 0x040083E9 RID: 33769
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x040083EA RID: 33770
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x02000BF5 RID: 3061
		public new class LuaExportHelper
		{
			// Token: 0x0600D5B2 RID: 54706 RVA: 0x003A4C18 File Offset: 0x003A2E18
			public LuaExportHelper(RewardGoodsDescUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600D5B3 RID: 54707 RVA: 0x003A4C28 File Offset: 0x003A2E28
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600D5B4 RID: 54708 RVA: 0x003A4C38 File Offset: 0x003A2E38
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600D5B5 RID: 54709 RVA: 0x003A4C48 File Offset: 0x003A2E48
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600D5B6 RID: 54710 RVA: 0x003A4C58 File Offset: 0x003A2E58
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600D5B7 RID: 54711 RVA: 0x003A4C70 File Offset: 0x003A2E70
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600D5B8 RID: 54712 RVA: 0x003A4C80 File Offset: 0x003A2E80
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600D5B9 RID: 54713 RVA: 0x003A4C90 File Offset: 0x003A2E90
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600D5BA RID: 54714 RVA: 0x003A4CA0 File Offset: 0x003A2EA0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600D5BB RID: 54715 RVA: 0x003A4CB0 File Offset: 0x003A2EB0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600D5BC RID: 54716 RVA: 0x003A4CC0 File Offset: 0x003A2EC0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600D5BD RID: 54717 RVA: 0x003A4CD0 File Offset: 0x003A2ED0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600D5BE RID: 54718 RVA: 0x003A4CE0 File Offset: 0x003A2EE0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600D5BF RID: 54719 RVA: 0x003A4CF0 File Offset: 0x003A2EF0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600D5C0 RID: 54720 RVA: 0x003A4D00 File Offset: 0x003A2F00
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600D5C1 RID: 54721 RVA: 0x003A4D10 File Offset: 0x003A2F10
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600D5C2 RID: 54722 RVA: 0x003A4D20 File Offset: 0x003A2F20
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600D5C3 RID: 54723 RVA: 0x003A4D30 File Offset: 0x003A2F30
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x170029A8 RID: 10664
			// (get) Token: 0x0600D5C4 RID: 54724 RVA: 0x003A4D40 File Offset: 0x003A2F40
			// (set) Token: 0x0600D5C5 RID: 54725 RVA: 0x003A4D50 File Offset: 0x003A2F50
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

			// Token: 0x170029A9 RID: 10665
			// (get) Token: 0x0600D5C6 RID: 54726 RVA: 0x003A4D60 File Offset: 0x003A2F60
			// (set) Token: 0x0600D5C7 RID: 54727 RVA: 0x003A4D70 File Offset: 0x003A2F70
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

			// Token: 0x170029AA RID: 10666
			// (get) Token: 0x0600D5C8 RID: 54728 RVA: 0x003A4D80 File Offset: 0x003A2F80
			// (set) Token: 0x0600D5C9 RID: 54729 RVA: 0x003A4D90 File Offset: 0x003A2F90
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x170029AB RID: 10667
			// (get) Token: 0x0600D5CA RID: 54730 RVA: 0x003A4DA0 File Offset: 0x003A2FA0
			// (set) Token: 0x0600D5CB RID: 54731 RVA: 0x003A4DB0 File Offset: 0x003A2FB0
			public GameObject HPGo
			{
				get
				{
					return this.m_owner.HPGo;
				}
				set
				{
					this.m_owner.HPGo = value;
				}
			}

			// Token: 0x170029AC RID: 10668
			// (get) Token: 0x0600D5CC RID: 54732 RVA: 0x003A4DC0 File Offset: 0x003A2FC0
			// (set) Token: 0x0600D5CD RID: 54733 RVA: 0x003A4DD0 File Offset: 0x003A2FD0
			public GameObject ATGo
			{
				get
				{
					return this.m_owner.ATGo;
				}
				set
				{
					this.m_owner.ATGo = value;
				}
			}

			// Token: 0x170029AD RID: 10669
			// (get) Token: 0x0600D5CE RID: 54734 RVA: 0x003A4DE0 File Offset: 0x003A2FE0
			// (set) Token: 0x0600D5CF RID: 54735 RVA: 0x003A4DF0 File Offset: 0x003A2FF0
			public GameObject DFGo
			{
				get
				{
					return this.m_owner.DFGo;
				}
				set
				{
					this.m_owner.DFGo = value;
				}
			}

			// Token: 0x170029AE RID: 10670
			// (get) Token: 0x0600D5D0 RID: 54736 RVA: 0x003A4E00 File Offset: 0x003A3000
			// (set) Token: 0x0600D5D1 RID: 54737 RVA: 0x003A4E10 File Offset: 0x003A3010
			public GameObject MagicGo
			{
				get
				{
					return this.m_owner.MagicGo;
				}
				set
				{
					this.m_owner.MagicGo = value;
				}
			}

			// Token: 0x170029AF RID: 10671
			// (get) Token: 0x0600D5D2 RID: 54738 RVA: 0x003A4E20 File Offset: 0x003A3020
			// (set) Token: 0x0600D5D3 RID: 54739 RVA: 0x003A4E30 File Offset: 0x003A3030
			public GameObject MagicDFGo
			{
				get
				{
					return this.m_owner.MagicDFGo;
				}
				set
				{
					this.m_owner.MagicDFGo = value;
				}
			}

			// Token: 0x170029B0 RID: 10672
			// (get) Token: 0x0600D5D4 RID: 54740 RVA: 0x003A4E40 File Offset: 0x003A3040
			// (set) Token: 0x0600D5D5 RID: 54741 RVA: 0x003A4E50 File Offset: 0x003A3050
			public GameObject DEXGo
			{
				get
				{
					return this.m_owner.DEXGo;
				}
				set
				{
					this.m_owner.DEXGo = value;
				}
			}

			// Token: 0x170029B1 RID: 10673
			// (get) Token: 0x0600D5D6 RID: 54742 RVA: 0x003A4E60 File Offset: 0x003A3060
			// (set) Token: 0x0600D5D7 RID: 54743 RVA: 0x003A4E70 File Offset: 0x003A3070
			public Text HPText
			{
				get
				{
					return this.m_owner.HPText;
				}
				set
				{
					this.m_owner.HPText = value;
				}
			}

			// Token: 0x170029B2 RID: 10674
			// (get) Token: 0x0600D5D8 RID: 54744 RVA: 0x003A4E80 File Offset: 0x003A3080
			// (set) Token: 0x0600D5D9 RID: 54745 RVA: 0x003A4E90 File Offset: 0x003A3090
			public Text ATText
			{
				get
				{
					return this.m_owner.ATText;
				}
				set
				{
					this.m_owner.ATText = value;
				}
			}

			// Token: 0x170029B3 RID: 10675
			// (get) Token: 0x0600D5DA RID: 54746 RVA: 0x003A4EA0 File Offset: 0x003A30A0
			// (set) Token: 0x0600D5DB RID: 54747 RVA: 0x003A4EB0 File Offset: 0x003A30B0
			public Text DFText
			{
				get
				{
					return this.m_owner.DFText;
				}
				set
				{
					this.m_owner.DFText = value;
				}
			}

			// Token: 0x170029B4 RID: 10676
			// (get) Token: 0x0600D5DC RID: 54748 RVA: 0x003A4EC0 File Offset: 0x003A30C0
			// (set) Token: 0x0600D5DD RID: 54749 RVA: 0x003A4ED0 File Offset: 0x003A30D0
			public Text MagicText
			{
				get
				{
					return this.m_owner.MagicText;
				}
				set
				{
					this.m_owner.MagicText = value;
				}
			}

			// Token: 0x170029B5 RID: 10677
			// (get) Token: 0x0600D5DE RID: 54750 RVA: 0x003A4EE0 File Offset: 0x003A30E0
			// (set) Token: 0x0600D5DF RID: 54751 RVA: 0x003A4EF0 File Offset: 0x003A30F0
			public Text MagicDFText
			{
				get
				{
					return this.m_owner.MagicDFText;
				}
				set
				{
					this.m_owner.MagicDFText = value;
				}
			}

			// Token: 0x170029B6 RID: 10678
			// (get) Token: 0x0600D5E0 RID: 54752 RVA: 0x003A4F00 File Offset: 0x003A3100
			// (set) Token: 0x0600D5E1 RID: 54753 RVA: 0x003A4F10 File Offset: 0x003A3110
			public Text DEXText
			{
				get
				{
					return this.m_owner.DEXText;
				}
				set
				{
					this.m_owner.DEXText = value;
				}
			}

			// Token: 0x170029B7 RID: 10679
			// (get) Token: 0x0600D5E2 RID: 54754 RVA: 0x003A4F20 File Offset: 0x003A3120
			// (set) Token: 0x0600D5E3 RID: 54755 RVA: 0x003A4F30 File Offset: 0x003A3130
			public RectTransform m_backgroundTransform
			{
				get
				{
					return this.m_owner.m_backgroundTransform;
				}
				set
				{
					this.m_owner.m_backgroundTransform = value;
				}
			}

			// Token: 0x0600D5E4 RID: 54756 RVA: 0x003A4F40 File Offset: 0x003A3140
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600D5E5 RID: 54757 RVA: 0x003A4F50 File Offset: 0x003A3150
			public void InitRewardGoodsDescInfo(GoodsType goodsType, int goodsId, bool isNeedAutoClose)
			{
				this.m_owner.InitRewardGoodsDescInfo(goodsType, goodsId, isNeedAutoClose);
			}

			// Token: 0x0600D5E6 RID: 54758 RVA: 0x003A4F60 File Offset: 0x003A3160
			public void SetEquipmentPropInfo(int goodsId)
			{
				this.m_owner.SetEquipmentPropInfo(goodsId);
			}

			// Token: 0x0600D5E7 RID: 54759 RVA: 0x003A4F70 File Offset: 0x003A3170
			public void SetPropItems(PropertyModifyType type, int value)
			{
				this.m_owner.SetPropItems(type, value);
			}

			// Token: 0x0600D5E8 RID: 54760 RVA: 0x003A4F80 File Offset: 0x003A3180
			public static IEnumerator Co_ShowRewardGoodsDesc(RewardGoodsDescUIController descCtrl, GameObject gameObjectForPosCalc, int alignType)
			{
				return RewardGoodsDescUIController.Co_ShowRewardGoodsDesc(descCtrl, gameObjectForPosCalc, alignType);
			}

			// Token: 0x0600D5E9 RID: 54761 RVA: 0x003A4F8C File Offset: 0x003A318C
			public void ClosePanel()
			{
				this.m_owner.ClosePanel();
			}

			// Token: 0x040083EB RID: 33771
			private RewardGoodsDescUIController m_owner;
		}
	}
}
