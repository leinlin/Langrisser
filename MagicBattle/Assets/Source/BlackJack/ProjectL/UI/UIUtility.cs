using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using PD.SDK;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FDC RID: 4060
	[HotFix]
	public class UIUtility
	{
		// Token: 0x06014562 RID: 83298 RVA: 0x0052B080 File Offset: 0x00529280
		public UIUtility()
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

		// Token: 0x06014563 RID: 83299 RVA: 0x0052B0E8 File Offset: 0x005292E8
		private static string Translate(string srcStr)
		{
			if (UIUtility.m_translateTable == null || UIUtility.m_translateTable.Count == 0)
			{
				return srcStr;
			}
			string result;
			if (!UIUtility.m_translateTable.TryGetValue(srcStr, out result))
			{
				return srcStr;
			}
			return result;
		}

		// Token: 0x06014564 RID: 83300 RVA: 0x0052B128 File Offset: 0x00529328
		public static void LoadTranslateTable()
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (configDataLoader == null)
			{
				return;
			}
			UIUtility.m_translateTable.Clear();
			foreach (KeyValuePair<int, ConfigDataTranslate> keyValuePair in configDataLoader.GetAllConfigDataTranslate())
			{
				UIUtility.m_translateTable.Add(keyValuePair.Value.Chinese, keyValuePair.Value.TargetLanguage);
			}
			if (UIUtility.m_translateTable.Count == 0)
			{
				return;
			}
			if (UIUtility.<>f__mg$cache0 == null)
			{
				UIUtility.<>f__mg$cache0 = new Func<string, string>(UIUtility.Translate);
			}
			UITextLocalizationHelper.m_translateFunc = UIUtility.<>f__mg$cache0;
		}

		// Token: 0x06014565 RID: 83301 RVA: 0x0052B1F0 File Offset: 0x005293F0
		public static Vector2 WorldToLocalPosition(Vector3 p, Camera worldCam, RectTransform rt, Camera uiCam)
		{
			return UIUtility.ScreenToLocalPosition(worldCam.WorldToScreenPoint(p), rt, uiCam);
		}

		// Token: 0x06014566 RID: 83302 RVA: 0x0052B208 File Offset: 0x00529408
		public static Vector2 ScreenToLocalPosition(Vector2 p, RectTransform rt, Camera uiCam)
		{
			Vector2 zero = Vector2.zero;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(rt, p, uiCam, out zero);
			return zero;
		}

		// Token: 0x06014567 RID: 83303 RVA: 0x0052B228 File Offset: 0x00529428
		public static string AddColorTag(string txt, Color c)
		{
			return string.Format("<color=#{0}>{1}</color>", ColorUtility.ToHtmlStringRGBA(c), txt);
		}

		// Token: 0x06014568 RID: 83304 RVA: 0x0052B23C File Offset: 0x0052943C
		public static void ActivateLayer(UIControllerBase controller, bool a)
		{
			if (controller == null)
			{
				return;
			}
			controller.gameObject.SetActive(a);
		}

		// Token: 0x06014569 RID: 83305 RVA: 0x0052B258 File Offset: 0x00529458
		public static bool IsLayerActive(UIControllerBase controller)
		{
			return !(controller == null) && controller.gameObject.activeSelf;
		}

		// Token: 0x0601456A RID: 83306 RVA: 0x0052B274 File Offset: 0x00529474
		public static void ClickButton(UIControllerBase controller, string buttonName)
		{
			if (controller == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(buttonName))
			{
				return;
			}
			Button button = Utility.FindChildComponent<Button>(controller.gameObject, buttonName, true);
			if (button != null)
			{
				button.onClick.Invoke();
			}
			else
			{
				global::Debug.LogError("ClickButton: Button " + buttonName + " not found.");
			}
		}

		// Token: 0x0601456B RID: 83307 RVA: 0x0052B2DC File Offset: 0x005294DC
		public static void ClickToggle(UIControllerBase controller, string toggleName)
		{
			if (controller == null)
			{
				return;
			}
			Toggle toggle = Utility.FindChildComponent<Toggle>(controller.gameObject, toggleName, true);
			if (toggle != null)
			{
				toggle.isOn = true;
			}
			else
			{
				global::Debug.LogError("Toggle " + toggleName + " not found.");
			}
		}

		// Token: 0x0601456C RID: 83308 RVA: 0x0052B334 File Offset: 0x00529534
		public static string TimeSpanToString(TimeSpan timeSpan)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string value = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Day);
			string value2 = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Hour);
			string value3 = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Minute);
			StringBuilder stringBuilder = new StringBuilder();
			if (timeSpan.Days > 0)
			{
				stringBuilder.Append(timeSpan.Days.ToString());
				stringBuilder.Append(value);
				stringBuilder.Append(timeSpan.Hours.ToString());
				stringBuilder.Append(value2);
			}
			else if (timeSpan.Hours > 0)
			{
				stringBuilder.Append(timeSpan.Hours.ToString());
				stringBuilder.Append(value2);
				stringBuilder.Append(timeSpan.Minutes.ToString());
				stringBuilder.Append(value3);
			}
			else
			{
				if (timeSpan.Minutes < 1)
				{
					stringBuilder.Append("1");
				}
				else
				{
					stringBuilder.Append(timeSpan.Minutes.ToString());
				}
				stringBuilder.Append(value3);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0601456D RID: 83309 RVA: 0x0052B48C File Offset: 0x0052968C
		public static string TimeSpanToString2(TimeSpan timeSpan)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string value = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Day);
			string value2 = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Hour);
			string value3 = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Common_LessThan);
			StringBuilder stringBuilder = new StringBuilder();
			if (timeSpan.Days > 0)
			{
				stringBuilder.Append(timeSpan.Days.ToString());
				stringBuilder.Append(value);
			}
			else if (timeSpan.Hours > 0)
			{
				stringBuilder.Append(timeSpan.Hours.ToString());
				stringBuilder.Append(value2);
			}
			else if (timeSpan.Minutes > 0 || timeSpan.Seconds > 0)
			{
				stringBuilder.Append(value3);
				stringBuilder.Append("1");
				stringBuilder.Append(value2);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0601456E RID: 83310 RVA: 0x0052B588 File Offset: 0x00529788
		public static string DateTimeToString(DateTime dateTime)
		{
			return dateTime.ToString("yyyy/MM/dd");
		}

		// Token: 0x0601456F RID: 83311 RVA: 0x0052B598 File Offset: 0x00529798
		public static void SetDailyRewardCount(Text text, int restCount, int allCount)
		{
			if (restCount == 0)
			{
				text.text = UIUtility.AddColorTag(restCount.ToString(), new Color32(220, 10, 10, byte.MaxValue)) + "/" + allCount;
			}
			else
			{
				text.text = restCount + "/" + allCount;
			}
		}

		// Token: 0x06014570 RID: 83312 RVA: 0x0052B60C File Offset: 0x0052980C
		public static void ResetTween(GameObject go)
		{
			TweenMain[] componentsInChildren = go.GetComponentsInChildren<TweenMain>();
			foreach (TweenMain tweenMain in componentsInChildren)
			{
				tweenMain.Play();
				tweenMain.enabled = false;
				tweenMain.ResetToBeginning();
			}
		}

		// Token: 0x06014571 RID: 83313 RVA: 0x0052B650 File Offset: 0x00529850
		public static void ReplayTween(GameObject go, Action onFinished = null)
		{
			if (go == null)
			{
				return;
			}
			TweenMain[] componentsInChildren = go.GetComponentsInChildren<TweenMain>();
			UIUtility.RemoveTweenFinished(componentsInChildren);
			foreach (TweenMain tweenMain in componentsInChildren)
			{
				tweenMain.ResetToBeginning();
			}
			bool flag = false;
			if (onFinished != null)
			{
				flag = UIUtility.SetTweenFinished(componentsInChildren, onFinished);
			}
			foreach (TweenMain tweenMain2 in componentsInChildren)
			{
				tweenMain2.Play();
			}
			if (!flag && onFinished != null)
			{
				onFinished();
			}
		}

		// Token: 0x06014572 RID: 83314 RVA: 0x0052B6E8 File Offset: 0x005298E8
		public static void ReversePlayTween(GameObject go, Action onFinished = null)
		{
			if (go == null)
			{
				return;
			}
			TweenMain[] componentsInChildren = go.GetComponentsInChildren<TweenMain>();
			bool flag = false;
			if (onFinished != null)
			{
				flag = UIUtility.SetTweenFinished(componentsInChildren, onFinished);
			}
			else
			{
				UIUtility.RemoveTweenFinished(componentsInChildren);
			}
			foreach (TweenMain tweenMain in componentsInChildren)
			{
				tweenMain.PlayReverse();
			}
			if (!flag && onFinished != null)
			{
				onFinished();
			}
		}

		// Token: 0x06014573 RID: 83315 RVA: 0x0052B75C File Offset: 0x0052995C
		private static bool SetTweenFinished(TweenMain[] tweens, Action onFinished)
		{
			if (tweens == null || onFinished == null)
			{
				return false;
			}
			float num = -1f;
			TweenMain tweenMax = null;
			foreach (TweenMain tweenMain in tweens)
			{
				if (tweenMain.style != TweenMain.Style.Loop && tweenMain.style != TweenMain.Style.PingPong)
				{
					float num2 = tweenMain.delay + tweenMain.duration;
					if (num2 > num)
					{
						num = num2;
						tweenMax = tweenMain;
					}
				}
			}
			if (tweenMax != null)
			{
				tweenMax.OnFinished.RemoveAllListeners();
				tweenMax.OnFinished.AddListener(delegate()
				{
					tweenMax.OnFinished.RemoveAllListeners();
					onFinished();
				});
				return true;
			}
			return false;
		}

		// Token: 0x06014574 RID: 83316 RVA: 0x0052B834 File Offset: 0x00529A34
		private static void RemoveTweenFinished(TweenMain[] tweens)
		{
			if (tweens == null)
			{
				return;
			}
			foreach (TweenMain tweenMain in tweens)
			{
				tweenMain.OnFinished.RemoveAllListeners();
			}
		}

		// Token: 0x06014575 RID: 83317 RVA: 0x0052B870 File Offset: 0x00529A70
		public static void SetTweenIgnoreTimeScale(GameObject go, bool ignore)
		{
			TweenMain[] componentsInChildren = go.GetComponentsInChildren<TweenMain>();
			foreach (TweenMain tweenMain in componentsInChildren)
			{
				tweenMain.ignoreTimeScale = ignore;
			}
		}

		// Token: 0x06014576 RID: 83318 RVA: 0x0052B8A8 File Offset: 0x00529AA8
		public static void SetUIStateOpen(CommonUIStateController ctrl, string stateName, Action onEnd = null, bool disableInput = false, bool allowToRefreshSameState = true)
		{
			if (disableInput && CommonUIController.Instance != null)
			{
				Utility.SetUIStateOpen(ctrl, stateName, onEnd, new Action<bool>(CommonUIController.Instance.EnableInput), allowToRefreshSameState);
			}
			else
			{
				Utility.SetUIStateOpen(ctrl, stateName, onEnd, null, allowToRefreshSameState);
			}
		}

		// Token: 0x06014577 RID: 83319 RVA: 0x0052B8F8 File Offset: 0x00529AF8
		public static void SetUIStateClose(CommonUIStateController ctrl, string stateName, Action onEnd = null, bool disableInput = false, bool allowToRefreshSameState = true)
		{
			if (disableInput && CommonUIController.Instance != null)
			{
				Utility.SetUIStateClose(ctrl, stateName, onEnd, new Action<bool>(CommonUIController.Instance.EnableInput), true);
			}
			else
			{
				Utility.SetUIStateClose(ctrl, stateName, onEnd, null, allowToRefreshSameState);
			}
		}

		// Token: 0x06014578 RID: 83320 RVA: 0x0052B944 File Offset: 0x00529B44
		public static void SetUIStateOpenAndClose(CommonUIStateController ctrl, string openStateName, string closeStateName, Action onEnd = null, bool disableInput = false)
		{
			if (ctrl == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(openStateName) || string.IsNullOrEmpty(closeStateName))
			{
				return;
			}
			if (disableInput && CommonUIController.Instance != null)
			{
				CommonUIController.Instance.EnableInput(false);
			}
			ctrl.gameObject.SetActive(true);
			ctrl.SetActionForUIStateFinshed(openStateName, delegate
			{
				ctrl.SetActionForUIStateFinshed(closeStateName, delegate
				{
					ctrl.gameObject.SetActive(false);
					if (disableInput && CommonUIController.Instance != null)
					{
						CommonUIController.Instance.EnableInput(true);
					}
					if (onEnd != null)
					{
						onEnd();
					}
				});
				ctrl.SetToUIState(closeStateName, false, true);
			});
			ctrl.SetToUIState(openStateName, false, true);
		}

		// Token: 0x06014579 RID: 83321 RVA: 0x0052BA00 File Offset: 0x00529C00
		public static void SetUIState(CommonUIStateController ctrl, string stateName, Action onEnd = null, bool disableInput = false, bool allowToRefreshSameState = true)
		{
			if (ctrl == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(stateName))
			{
				return;
			}
			if (disableInput && CommonUIController.Instance != null)
			{
				CommonUIController.Instance.EnableInput(false);
			}
			ctrl.gameObject.SetActive(true);
			ctrl.SetActionForUIStateFinshed(stateName, delegate
			{
				if (disableInput && CommonUIController.Instance != null)
				{
					CommonUIController.Instance.EnableInput(true);
				}
				if (onEnd != null)
				{
					onEnd();
				}
			});
			ctrl.SetToUIState(stateName, false, allowToRefreshSameState);
		}

		// Token: 0x0601457A RID: 83322 RVA: 0x0052BA8C File Offset: 0x00529C8C
		public static string GetUIStateCurrentStateName(CommonUIStateController ctrl)
		{
			if (ctrl == null)
			{
				return string.Empty;
			}
			UIStateDesc currentUIState = ctrl.GetCurrentUIState();
			if (currentUIState != null)
			{
				return currentUIState.StateName;
			}
			return string.Empty;
		}

		// Token: 0x0601457B RID: 83323 RVA: 0x0052BAC4 File Offset: 0x00529CC4
		public static void PlayAnimation(GameObject go, string name)
		{
			if (go == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(name))
			{
				return;
			}
			Animator component = go.GetComponent<Animator>();
			if (component != null)
			{
				component.Play(name, -1, 0f);
			}
		}

		// Token: 0x0601457C RID: 83324 RVA: 0x0052BB0C File Offset: 0x00529D0C
		public static void ShowGameObjectChildrenByColor(GameObject obj, int num)
		{
			if (obj == null)
			{
				return;
			}
			int childCount = obj.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				GameObject gameObject = obj.transform.GetChild(i).gameObject;
				if (i < num)
				{
					gameObject.GetComponent<Image>().color = Color.white;
				}
				else
				{
					gameObject.GetComponent<Image>().color = Color.gray;
				}
			}
		}

		// Token: 0x0601457D RID: 83325 RVA: 0x0052BB84 File Offset: 0x00529D84
		public static void SetGameObjectChildrenActiveCount(GameObject obj, int num)
		{
			if (obj == null)
			{
				return;
			}
			int childCount = obj.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				GameObject gameObject = obj.transform.GetChild(i).gameObject;
				gameObject.SetActive(i < num);
			}
		}

		// Token: 0x0601457E RID: 83326 RVA: 0x0052BBD8 File Offset: 0x00529DD8
		public static void ReverseShowGameObjectChildrenByActive(GameObject obj, int num)
		{
			if (obj == null)
			{
				return;
			}
			int childCount = obj.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				GameObject gameObject = obj.transform.GetChild(i).gameObject;
				gameObject.SetActive(i >= childCount - num);
			}
		}

		// Token: 0x0601457F RID: 83327 RVA: 0x0052BC34 File Offset: 0x00529E34
		public static string GetHeroItemFrameNameByRank(int rank)
		{
			string result = null;
			switch (rank)
			{
			case 1:
				result = "UI/HeadFrame_ABS/Card_Thumbnail_04.png";
				break;
			case 2:
				result = "UI/HeadFrame_ABS/Card_Thumbnail_03.png";
				break;
			case 3:
				result = "UI/HeadFrame_ABS/Card_Thumbnail_02.png";
				break;
			case 4:
				result = "UI/HeadFrame_ABS/Card_Thumbnail_01.png";
				break;
			}
			return result;
		}

		// Token: 0x06014580 RID: 83328 RVA: 0x0052BC94 File Offset: 0x00529E94
		public static string GetGoodsFrameNameByRank(int rank)
		{
			switch (rank)
			{
			case 1:
				return "UI/Common_New_ABS/Border_Icon_Copper.png";
			case 2:
				return "UI/Common_New_ABS/Border_Icon_Silver.png";
			case 3:
				return "UI/Common_New_ABS/Border_Icon_Gold.png";
			case 4:
				return "UI/Common_New_ABS/Border_Icon_Colour.png";
			case 5:
				return "UI/Common_New_ABS/Border_Icon_Colour.png";
			default:
				return "UI/Common_New_ABS/Border_Icon_Copper.png";
			}
		}

		// Token: 0x06014581 RID: 83329 RVA: 0x0052BCE8 File Offset: 0x00529EE8
		public static string GetPropertyRatingImageName(char rating)
		{
			switch (rating)
			{
			case 'A':
				return "UI/Common_New_ABS/Font/Font_A.png";
			case 'B':
				return "UI/Common_New_ABS/Font/Font_B.png";
			case 'C':
				return "UI/Common_New_ABS/Font/Font_C.png";
			case 'D':
				return "UI/Common_New_ABS/Font/Font_D.png";
			case 'E':
				return "UI/Common_New_ABS/Font/Font_E.png";
			default:
				if (rating != 'S')
				{
					return null;
				}
				return "UI/Common_New_ABS/Font/Font_S.png";
			}
		}

		// Token: 0x06014582 RID: 83330 RVA: 0x0052BD44 File Offset: 0x00529F44
		public static string GetGoodsName(GoodsType goodsType, int goodsId)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string result = string.Empty;
			switch (goodsType)
			{
			case GoodsType.GoodsType_Gold:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_Gold);
				break;
			case GoodsType.GoodsType_Crystal:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_Crystal);
				break;
			case GoodsType.GoodsType_Energy:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_Energy);
				break;
			case GoodsType.GoodsType_Hero:
			{
				ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(goodsId);
				if (configDataHeroInfo != null)
				{
					result = configDataHeroInfo.Name;
				}
				break;
			}
			case GoodsType.GoodsType_JobMaterial:
			{
				ConfigDataJobMaterialInfo configDataJobMaterialInfo = configDataLoader.GetConfigDataJobMaterialInfo(goodsId);
				if (configDataJobMaterialInfo != null)
				{
					result = configDataJobMaterialInfo.Name;
				}
				break;
			}
			case GoodsType.GoodsType_Item:
			{
				ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(goodsId);
				if (configDataItemInfo != null)
				{
					result = configDataItemInfo.Name;
				}
				break;
			}
			case GoodsType.GoodsType_Equipment:
			{
				ConfigDataEquipmentInfo configDataEquipmentInfo = configDataLoader.GetConfigDataEquipmentInfo(goodsId);
				if (configDataEquipmentInfo != null)
				{
					result = configDataEquipmentInfo.Name;
				}
				break;
			}
			case GoodsType.GoodsType_ArenaTicket:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_ArenaTicket);
				break;
			case GoodsType.GoodsType_ArenaHonour:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_ArenaHonour);
				break;
			case GoodsType.GoodsType_PlayerExp:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_PlayerExp);
				break;
			case GoodsType.GoodsType_FriendshipPoints:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_FriendshipPoints);
				break;
			case GoodsType.GoodsType_EnchantStone:
			{
				ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = configDataLoader.GetConfigDataEnchantStoneInfo(goodsId);
				if (configDataEnchantStoneInfo != null)
				{
					result = configDataEnchantStoneInfo.Name;
				}
				break;
			}
			case GoodsType.GoodsType_MonthCard:
			{
				ConfigDataMonthCardInfo configDataMonthCardInfo = configDataLoader.GetConfigDataMonthCardInfo(goodsId);
				if (configDataMonthCardInfo != null)
				{
					result = configDataMonthCardInfo.Name;
				}
				break;
			}
			case GoodsType.GoodsType_HeadFrame:
			{
				ConfigDataHeadFrameInfo configDataHeadFrameInfo = configDataLoader.GetConfigDataHeadFrameInfo(goodsId);
				if (configDataHeadFrameInfo != null)
				{
					result = configDataHeadFrameInfo.Name;
				}
				break;
			}
			case GoodsType.GoodsType_HeroSkin:
			{
				ConfigDataHeroSkinInfo configDataHeroSkinInfo = configDataLoader.GetConfigDataHeroSkinInfo(goodsId);
				if (configDataHeroSkinInfo != null)
				{
					result = configDataHeroSkinInfo.Name;
				}
				break;
			}
			case GoodsType.GoodsType_SoldierSkin:
			{
				ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = configDataLoader.GetConfigDataSoldierSkinInfo(goodsId);
				if (configDataSoldierSkinInfo != null)
				{
					result = configDataSoldierSkinInfo.Name;
				}
				break;
			}
			case GoodsType.GoodsType_SkinTicket:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_SkinTicket);
				break;
			case GoodsType.GoodsType_MemoryEssence:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_MemoryEssence);
				break;
			case GoodsType.GoodsType_MithralStone:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_MithralStone);
				break;
			case GoodsType.GoodsType_BrillianceMithralStone:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_BrillianceMithralStone);
				break;
			case GoodsType.GoodsType_GuildMedal:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Resource_GuildMedal);
				break;
			}
			return result;
		}

		// Token: 0x06014583 RID: 83331 RVA: 0x0052BF9C File Offset: 0x0052A19C
		public static int GetGoodsRank(GoodsType goodsType, int goodsId)
		{
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			int result = 0;
			switch (goodsType)
			{
			case GoodsType.GoodsType_Gold:
				result = clientConfigDataLoader.ConfigableConstId_GoldRank;
				break;
			case GoodsType.GoodsType_Crystal:
				result = clientConfigDataLoader.ConfigableConstId_CrystalRank;
				break;
			case GoodsType.GoodsType_Energy:
				result = clientConfigDataLoader.ConfigableConstId_EnergyRank;
				break;
			case GoodsType.GoodsType_Hero:
			{
				ConfigDataHeroInfo configDataHeroInfo = clientConfigDataLoader.GetConfigDataHeroInfo(goodsId);
				if (configDataHeroInfo != null)
				{
					result = configDataHeroInfo.GetRank(configDataHeroInfo.Star);
				}
				break;
			}
			case GoodsType.GoodsType_JobMaterial:
			{
				ConfigDataJobMaterialInfo configDataJobMaterialInfo = clientConfigDataLoader.GetConfigDataJobMaterialInfo(goodsId);
				if (configDataJobMaterialInfo != null)
				{
					result = configDataJobMaterialInfo.Rank;
				}
				break;
			}
			case GoodsType.GoodsType_Item:
			{
				ConfigDataItemInfo configDataItemInfo = clientConfigDataLoader.GetConfigDataItemInfo(goodsId);
				if (configDataItemInfo != null)
				{
					if (configDataItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_HeroFragment)
					{
						result = 0;
					}
					else
					{
						result = configDataItemInfo.Rank;
					}
				}
				break;
			}
			case GoodsType.GoodsType_Equipment:
			{
				ConfigDataEquipmentInfo configDataEquipmentInfo = clientConfigDataLoader.GetConfigDataEquipmentInfo(goodsId);
				if (configDataEquipmentInfo != null)
				{
					result = configDataEquipmentInfo.Rank;
				}
				break;
			}
			case GoodsType.GoodsType_ArenaTicket:
				result = clientConfigDataLoader.ConfigableConstId_ArenaTicketRank;
				break;
			case GoodsType.GoodsType_ArenaHonour:
				result = clientConfigDataLoader.ConfigableConstId_ArenaHonourRank;
				break;
			case GoodsType.GoodsType_PlayerExp:
				result = clientConfigDataLoader.ConfigableConstId_PlayerExpRank;
				break;
			case GoodsType.GoodsType_FriendshipPoints:
				result = clientConfigDataLoader.ConfigableConstId_FriendshipPointsRank;
				break;
			case GoodsType.GoodsType_EnchantStone:
			{
				ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = clientConfigDataLoader.GetConfigDataEnchantStoneInfo(goodsId);
				if (configDataEnchantStoneInfo != null)
				{
					result = configDataEnchantStoneInfo.Rank;
				}
				break;
			}
			case GoodsType.GoodsType_MonthCard:
				result = clientConfigDataLoader.ConfigableConstId_PrivilegeItemRank;
				break;
			case GoodsType.GoodsType_HeadFrame:
			{
				ConfigDataHeadFrameInfo configDataHeadFrameInfo = clientConfigDataLoader.GetConfigDataHeadFrameInfo(goodsId);
				if (configDataHeadFrameInfo != null)
				{
					result = configDataHeadFrameInfo.Rank;
				}
				break;
			}
			case GoodsType.GoodsType_SkinTicket:
				result = clientConfigDataLoader.ConfigableConstId_SkinTicketRank;
				break;
			case GoodsType.GoodsType_MemoryEssence:
				result = clientConfigDataLoader.ConfigableConstId_MemoryEssence;
				break;
			case GoodsType.GoodsType_MithralStone:
				result = clientConfigDataLoader.ConfigableConstId_MithralStoneRank;
				break;
			case GoodsType.GoodsType_BrillianceMithralStone:
				result = clientConfigDataLoader.ConfigableConstId_BrillianceMithralStoneRank;
				break;
			case GoodsType.GoodsType_GuildMedal:
				result = clientConfigDataLoader.ConfigableConstId_GuildMedalRank;
				break;
			}
			return result;
		}

		// Token: 0x06014584 RID: 83332 RVA: 0x0052C184 File Offset: 0x0052A384
		public static string GetGoodsIconName(GoodsType goodsType, int goodsId)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string result = string.Empty;
			switch (goodsType)
			{
			case GoodsType.GoodsType_Gold:
				result = "UI/Icon/Item_ABS/Item_Gold.png";
				break;
			case GoodsType.GoodsType_Crystal:
				result = "UI/Icon/Item_ABS/Item_MagicCrystal.png";
				break;
			case GoodsType.GoodsType_Energy:
				result = "UI/Icon/Item_ABS/Item_Bread.png";
				break;
			case GoodsType.GoodsType_Hero:
			{
				ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(goodsId);
				if (configDataHeroInfo != null)
				{
					ConfigDataCharImageInfo charImageInfo = configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star);
					if (charImageInfo != null)
					{
						result = AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0");
					}
				}
				break;
			}
			case GoodsType.GoodsType_JobMaterial:
			{
				ConfigDataJobMaterialInfo configDataJobMaterialInfo = configDataLoader.GetConfigDataJobMaterialInfo(goodsId);
				if (configDataJobMaterialInfo != null)
				{
					result = configDataJobMaterialInfo.Icon;
				}
				break;
			}
			case GoodsType.GoodsType_Item:
			{
				ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(goodsId);
				if (configDataItemInfo != null)
				{
					result = configDataItemInfo.Icon;
				}
				break;
			}
			case GoodsType.GoodsType_Equipment:
			{
				ConfigDataEquipmentInfo configDataEquipmentInfo = configDataLoader.GetConfigDataEquipmentInfo(goodsId);
				if (configDataEquipmentInfo != null)
				{
					result = configDataEquipmentInfo.Icon;
				}
				break;
			}
			case GoodsType.GoodsType_ArenaTicket:
				result = "UI/Icon/Item_ABS/Item_PVPTicket.png";
				break;
			case GoodsType.GoodsType_ArenaHonour:
				result = "UI/Icon/Item_ABS/Item_PvpCoin.png";
				break;
			case GoodsType.GoodsType_PlayerExp:
				result = "UI/Icon/Item_ABS/Item_PlayerExp.png";
				break;
			case GoodsType.GoodsType_FriendshipPoints:
				result = "UI/Common_New_ABS/Icon/Icon_Friendship_1.png";
				break;
			case GoodsType.GoodsType_EnchantStone:
			{
				ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = configDataLoader.GetConfigDataEnchantStoneInfo(goodsId);
				if (configDataEnchantStoneInfo != null)
				{
					result = configDataEnchantStoneInfo.Icon;
				}
				break;
			}
			case GoodsType.GoodsType_MonthCard:
			{
				ConfigDataMonthCardInfo configDataMonthCardInfo = configDataLoader.GetConfigDataMonthCardInfo(goodsId);
				if (configDataMonthCardInfo != null)
				{
					result = configDataMonthCardInfo.Icon;
				}
				break;
			}
			case GoodsType.GoodsType_HeadFrame:
			{
				ConfigDataHeadFrameInfo configDataHeadFrameInfo = configDataLoader.GetConfigDataHeadFrameInfo(goodsId);
				if (configDataHeadFrameInfo != null)
				{
					result = configDataHeadFrameInfo.Icon;
				}
				break;
			}
			case GoodsType.GoodsType_HeroSkin:
			{
				ConfigDataHeroSkinInfo configDataHeroSkinInfo = configDataLoader.GetConfigDataHeroSkinInfo(goodsId);
				if (configDataHeroSkinInfo != null)
				{
					result = configDataHeroSkinInfo.Icon;
				}
				break;
			}
			case GoodsType.GoodsType_SoldierSkin:
			{
				ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = configDataLoader.GetConfigDataSoldierSkinInfo(goodsId);
				if (configDataSoldierSkinInfo != null)
				{
					result = configDataSoldierSkinInfo.Icon;
				}
				break;
			}
			case GoodsType.GoodsType_SkinTicket:
				result = "UI/Icon/Item_ABS/Item_ETicket-God.png";
				break;
			case GoodsType.GoodsType_MemoryEssence:
				result = "UI/Icon/Item_ABS/Item_MemoryEssence.png";
				break;
			case GoodsType.GoodsType_MithralStone:
				result = "UI/Icon/Item_ABS/Icon_DragonScale_01.png";
				break;
			case GoodsType.GoodsType_BrillianceMithralStone:
				result = "UI/Icon/Item_ABS/Icon_DragonScale_02.png";
				break;
			case GoodsType.GoodsType_GuildMedal:
				result = "UI/Common_New_ABS/Icon/Icon_GuildCoin.png";
				break;
			}
			return result;
		}

		// Token: 0x06014585 RID: 83333 RVA: 0x0052C3B8 File Offset: 0x0052A5B8
		public static string GetGoodsIconMaterialName(GoodsType goodsType, int goodsId)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (goodsType != GoodsType.GoodsType_Item)
			{
				if (goodsType == GoodsType.GoodsType_HeroSkin)
				{
					return "UI/Icon/HeroSkin_ABS/Material/HeroSkinIcon.mat";
				}
				if (goodsType == GoodsType.GoodsType_SoldierSkin)
				{
					return "UI/Icon/SoldierSkin_ABS/Material/SoldierSkinIcon.mat";
				}
			}
			else
			{
				ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(goodsId);
				if (configDataItemInfo != null)
				{
					if (configDataItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_HeroFragment)
					{
						return "UI/Icon/Piece_ABS/Material/PieceIcon.mat";
					}
					if (configDataItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_Goblin)
					{
						return "UI/Icon/Card_ABS/Material/CardIcon.mat";
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x06014586 RID: 83334 RVA: 0x0052C43C File Offset: 0x0052A63C
		public static string GetGoodsFrameName(GoodsType goodsType, int goodsId)
		{
			if (UIUtility.IsGoodsHeroFragment(goodsType, goodsId))
			{
				return string.Empty;
			}
			if (UIUtility.IsGoodsGoblin(goodsType, goodsId))
			{
				return string.Empty;
			}
			if (goodsType == GoodsType.GoodsType_HeroSkin || goodsType == GoodsType.GoodsType_SoldierSkin)
			{
				return string.Empty;
			}
			int goodsRank = UIUtility.GetGoodsRank(goodsType, goodsId);
			return UIUtility.GetGoodsFrameNameByRank(goodsRank);
		}

		// Token: 0x06014587 RID: 83335 RVA: 0x0052C494 File Offset: 0x0052A694
		public static bool IsGoodsHeroFragment(GoodsType goodsType, int goodsId)
		{
			if (goodsType == GoodsType.GoodsType_Item)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(goodsId);
				if (configDataItemInfo != null && configDataItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_HeroFragment)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06014588 RID: 83336 RVA: 0x0052C4D8 File Offset: 0x0052A6D8
		public static bool IsGoodsGoblin(GoodsType goodsType, int goodsId)
		{
			if (goodsType == GoodsType.GoodsType_Item)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(goodsId);
				if (configDataItemInfo != null && configDataItemInfo.DisplayType == ItemDisplayType.ItemDisplayType_Goblin)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06014589 RID: 83337 RVA: 0x0052C51C File Offset: 0x0052A71C
		public static string GetGoodsDesc(GoodsType goodsType, int goodsId = 0)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string result = string.Empty;
			switch (goodsType)
			{
			case GoodsType.GoodsType_Gold:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_Gold);
				break;
			case GoodsType.GoodsType_Crystal:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_Crystal);
				break;
			case GoodsType.GoodsType_Energy:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_Energy);
				break;
			case GoodsType.GoodsType_Hero:
			{
				ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(goodsId);
				if (configDataHeroInfo != null)
				{
					result = configDataHeroInfo.Desc;
				}
				break;
			}
			case GoodsType.GoodsType_JobMaterial:
			{
				ConfigDataJobMaterialInfo configDataJobMaterialInfo = configDataLoader.GetConfigDataJobMaterialInfo(goodsId);
				if (configDataJobMaterialInfo != null)
				{
					result = configDataJobMaterialInfo.Desc;
				}
				break;
			}
			case GoodsType.GoodsType_Item:
			{
				ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(goodsId);
				if (configDataItemInfo != null)
				{
					result = configDataItemInfo.Desc;
				}
				break;
			}
			case GoodsType.GoodsType_Equipment:
			{
				ConfigDataEquipmentInfo configDataEquipmentInfo = configDataLoader.GetConfigDataEquipmentInfo(goodsId);
				if (configDataEquipmentInfo != null)
				{
					result = configDataEquipmentInfo.Desc;
				}
				break;
			}
			case GoodsType.GoodsType_ArenaTicket:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_ArenaTicket);
				break;
			case GoodsType.GoodsType_ArenaHonour:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_ArenaHonour);
				break;
			case GoodsType.GoodsType_PlayerExp:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_PlayerExp);
				break;
			case GoodsType.GoodsType_FriendshipPoints:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_FriendshipPoints);
				break;
			case GoodsType.GoodsType_EnchantStone:
			{
				ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = configDataLoader.GetConfigDataEnchantStoneInfo(goodsId);
				if (configDataEnchantStoneInfo != null)
				{
					result = configDataEnchantStoneInfo.Desc;
				}
				break;
			}
			case GoodsType.GoodsType_MonthCard:
			{
				ConfigDataMonthCardInfo configDataMonthCardInfo = configDataLoader.GetConfigDataMonthCardInfo(goodsId);
				if (configDataMonthCardInfo != null)
				{
					result = configDataMonthCardInfo.Desc;
				}
				break;
			}
			case GoodsType.GoodsType_HeadFrame:
			{
				ConfigDataHeadFrameInfo configDataHeadFrameInfo = configDataLoader.GetConfigDataHeadFrameInfo(goodsId);
				if (configDataHeadFrameInfo != null)
				{
					result = configDataHeadFrameInfo.Desc;
				}
				break;
			}
			case GoodsType.GoodsType_SkinTicket:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_SkinTicket);
				break;
			case GoodsType.GoodsType_MemoryEssence:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_MemoryEssence);
				break;
			case GoodsType.GoodsType_MithralStone:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_MithralStone);
				break;
			case GoodsType.GoodsType_BrillianceMithralStone:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_BrillianceMithralStone);
				break;
			case GoodsType.GoodsType_GuildMedal:
				result = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_ItemDesc_GuildMedal);
				break;
			}
			return result;
		}

		// Token: 0x0601458A RID: 83338 RVA: 0x0052C73C File Offset: 0x0052A93C
		public static string GetGuildTitleText(GuildTitle title)
		{
			StringTableId id = (StringTableId)0;
			switch (title)
			{
			case GuildTitle.Normal:
				id = StringTableId.StringTableId_Guild_TitleNormal;
				break;
			case GuildTitle.Elite:
				id = StringTableId.StringTableId_Guild_TitleElite;
				break;
			case GuildTitle.VP:
				id = StringTableId.StringTableId_Guild_TitleVP;
				break;
			case GuildTitle.President:
				id = StringTableId.StringTableId_Guild_TitlePresident;
				break;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			return configDataLoader.UtilityGetStringByStringTable(id);
		}

		// Token: 0x0601458B RID: 83339 RVA: 0x0052C7B4 File Offset: 0x0052A9B4
		public static bool IsRankSSR(int rank)
		{
			return rank == 4 || rank == 5;
		}

		// Token: 0x0601458C RID: 83340 RVA: 0x0052C7C4 File Offset: 0x0052A9C4
		public static int GetBagItemAlchemyGold(BagItemBase bagItem)
		{
			if (bagItem == null)
			{
				return 0;
			}
			switch (bagItem.GoodsTypeId)
			{
			case GoodsType.GoodsType_JobMaterial:
				return bagItem.JobMaterialInfo.AlchemyGold;
			case GoodsType.GoodsType_Item:
				return bagItem.ItemInfo.AlchemyGold;
			case GoodsType.GoodsType_Equipment:
				return bagItem.EquipmentInfo.AlchemyGold;
			case GoodsType.GoodsType_EnchantStone:
				return bagItem.EnchantStoneInfo.AlchemyGold;
			}
			return 0;
		}

		// Token: 0x0601458D RID: 83341 RVA: 0x0052C87C File Offset: 0x0052AA7C
		public static int GetBagItemDropID(BagItemBase bagItem)
		{
			if (bagItem == null)
			{
				return 0;
			}
			switch (bagItem.GoodsTypeId)
			{
			case GoodsType.GoodsType_JobMaterial:
				return bagItem.JobMaterialInfo.RandomDropRewardID;
			case GoodsType.GoodsType_Item:
				return bagItem.ItemInfo.RandomDropRewardID;
			case GoodsType.GoodsType_Equipment:
				return bagItem.EquipmentInfo.RandomDropRewardID;
			case GoodsType.GoodsType_EnchantStone:
				return bagItem.EnchantStoneInfo.RandomDropRewardID;
			}
			return 0;
		}

		// Token: 0x0601458E RID: 83342 RVA: 0x0052C934 File Offset: 0x0052AB34
		public static int GetBagItemDropDisplayCount(BagItemBase bagItem)
		{
			if (bagItem == null)
			{
				return 0;
			}
			switch (bagItem.GoodsTypeId)
			{
			case GoodsType.GoodsType_Gold:
			case GoodsType.GoodsType_Crystal:
			case GoodsType.GoodsType_Energy:
			case GoodsType.GoodsType_Hero:
			case GoodsType.GoodsType_ArenaTicket:
			case GoodsType.GoodsType_ArenaHonour:
			case GoodsType.GoodsType_PlayerExp:
			case GoodsType.GoodsType_FriendshipPoints:
			case GoodsType.GoodsType_MonthCard:
			case GoodsType.GoodsType_MemoryEssence:
			case GoodsType.GoodsType_MithralStone:
			case GoodsType.GoodsType_BrillianceMithralStone:
				return 0;
			case GoodsType.GoodsType_JobMaterial:
				return bagItem.JobMaterialInfo.DisplayRewardCount;
			case GoodsType.GoodsType_Item:
				return bagItem.ItemInfo.DisplayRewardCount;
			case GoodsType.GoodsType_Equipment:
				return bagItem.EquipmentInfo.DisplayRewardCount;
			case GoodsType.GoodsType_EnchantStone:
				return bagItem.EnchantStoneInfo.DisplayRewardCount;
			}
			return 0;
		}

		// Token: 0x0601458F RID: 83343 RVA: 0x0052C9E8 File Offset: 0x0052ABE8
		public static bool GoodTypeHaveID(GoodsType goodsType)
		{
			return goodsType == GoodsType.GoodsType_Item || goodsType == GoodsType.GoodsType_JobMaterial || goodsType == GoodsType.GoodsType_Equipment || goodsType == GoodsType.GoodsType_EnchantStone || goodsType == GoodsType.GoodsType_Hero;
		}

		// Token: 0x06014590 RID: 83344 RVA: 0x0052CA1C File Offset: 0x0052AC1C
		public static void AppendRandomDropRewardGoodsToList(int dropId, List<Goods> goods)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			RandomDropRewardArea randomDropRewardArea;
			if (configDataLoader.RandomDropData.Areas.TryGetValue(dropId, out randomDropRewardArea))
			{
				foreach (RandomDropRewardGroup randomDropRewardGroup in randomDropRewardArea.groups)
				{
					using (Dictionary<int, WeightGoods>.ValueCollection.Enumerator enumerator2 = randomDropRewardGroup.DropRewards.Values.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							WeightGoods dropReward = enumerator2.Current;
							if (dropReward.ItemType != GoodsType.GoodsType_None)
							{
								if (goods.FindIndex((Goods x) => x.GoodsType == dropReward.ItemType && x.Id == dropReward.ItemId) < 0)
								{
									goods.Add(new Goods
									{
										GoodsType = dropReward.ItemType,
										Id = dropReward.ItemId,
										Count = 0
									});
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06014591 RID: 83345 RVA: 0x0052CB64 File Offset: 0x0052AD64
		public static int GetGoodsCount(GoodsType goodsType, int goodsId = 0)
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			switch (goodsType)
			{
			case GoodsType.GoodsType_Gold:
				return projectLPlayerContext.GetGold();
			case GoodsType.GoodsType_Crystal:
				return projectLPlayerContext.GetCrystal();
			case GoodsType.GoodsType_Energy:
				return projectLPlayerContext.GetEnergy();
			case GoodsType.GoodsType_Hero:
				return (projectLPlayerContext.GetHero(goodsId) == null) ? 0 : 1;
			case GoodsType.GoodsType_JobMaterial:
			case GoodsType.GoodsType_Item:
			case GoodsType.GoodsType_EnchantStone:
				return projectLPlayerContext.GetBagItemCountByType(goodsType, goodsId);
			case GoodsType.GoodsType_Equipment:
				return 1;
			case GoodsType.GoodsType_ArenaTicket:
				return projectLPlayerContext.GetArenaTicketCount();
			case GoodsType.GoodsType_ArenaHonour:
				return projectLPlayerContext.GetArenaHonour();
			case GoodsType.GoodsType_PlayerExp:
				return projectLPlayerContext.GetPlayerExp();
			case GoodsType.GoodsType_FriendshipPoints:
				return projectLPlayerContext.GetFriendShipPoints();
			case GoodsType.GoodsType_SkinTicket:
				return projectLPlayerContext.GetSkinTicket();
			case GoodsType.GoodsType_MemoryEssence:
				return projectLPlayerContext.GetMemoryEssence();
			case GoodsType.GoodsType_MithralStone:
				return projectLPlayerContext.GetMithralStone();
			case GoodsType.GoodsType_BrillianceMithralStone:
				return projectLPlayerContext.GetBrillianceMithralStone();
			}
			return 0;
		}

		// Token: 0x06014592 RID: 83346 RVA: 0x0052CC58 File Offset: 0x0052AE58
		public static int GetCurrencyCount(GoodsType currencyType)
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int result = -1;
			switch (currencyType)
			{
			case GoodsType.GoodsType_MemoryEssence:
				result = projectLPlayerContext.GetMemoryEssence();
				break;
			case GoodsType.GoodsType_MithralStone:
				result = projectLPlayerContext.GetMithralStone();
				break;
			case GoodsType.GoodsType_BrillianceMithralStone:
				result = projectLPlayerContext.GetBrillianceMithralStone();
				break;
			case GoodsType.GoodsType_GuildMedal:
				result = projectLPlayerContext.GetGuildMedal();
				break;
			default:
				if (currencyType != GoodsType.GoodsType_Gold)
				{
					if (currencyType != GoodsType.GoodsType_Crystal)
					{
						switch (currencyType)
						{
						case GoodsType.GoodsType_ArenaHonour:
							return projectLPlayerContext.GetArenaHonour();
						case GoodsType.GoodsType_FriendshipPoints:
							return projectLPlayerContext.GetFriendShipPoints();
						}
						global::Debug.LogError("Invalid currency type:" + currencyType);
					}
					else
					{
						result = projectLPlayerContext.GetCrystal();
					}
				}
				else
				{
					result = projectLPlayerContext.GetGold();
				}
				break;
			}
			return result;
		}

		// Token: 0x06014593 RID: 83347 RVA: 0x0052CD38 File Offset: 0x0052AF38
		public static string GetPlayerHeadIconImageName(int headIconId)
		{
			ConfigDataCharImageInfo playerHeadIconCharImageInfo = UIUtility.GetPlayerHeadIconCharImageInfo(headIconId);
			if (playerHeadIconCharImageInfo != null)
			{
				return AssetUtility.MakeSpriteAssetName(playerHeadIconCharImageInfo.CardHeadImage, "_0");
			}
			return string.Empty;
		}

		// Token: 0x06014594 RID: 83348 RVA: 0x0052CD68 File Offset: 0x0052AF68
		public static string GetPlayerSmallHeadIconImageName(int headIconId)
		{
			ConfigDataCharImageInfo playerHeadIconCharImageInfo = UIUtility.GetPlayerHeadIconCharImageInfo(headIconId);
			if (playerHeadIconCharImageInfo != null)
			{
				return playerHeadIconCharImageInfo.SmallHeadImage;
			}
			return string.Empty;
		}

		// Token: 0x06014595 RID: 83349 RVA: 0x0052CD90 File Offset: 0x0052AF90
		public static string GetPlayerRoundHeadIconImageName(int headIconId)
		{
			ConfigDataCharImageInfo playerHeadIconCharImageInfo = UIUtility.GetPlayerHeadIconCharImageInfo(headIconId);
			if (playerHeadIconCharImageInfo != null)
			{
				return playerHeadIconCharImageInfo.RoundHeadImage;
			}
			return string.Empty;
		}

		// Token: 0x06014596 RID: 83350 RVA: 0x0052CDB8 File Offset: 0x0052AFB8
		private static ConfigDataCharImageInfo GetPlayerHeadIconCharImageInfo(int headIconId)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(headIconId);
			if (configDataHeroInfo != null)
			{
				return configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star);
			}
			return null;
		}

		// Token: 0x06014597 RID: 83351 RVA: 0x0052CDF4 File Offset: 0x0052AFF4
		public static string GetPlayerHeadFrameImageName(int headFrameId)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataHeadFrameInfo configDataHeadFrameInfo = configDataLoader.GetConfigDataHeadFrameInfo(headFrameId);
			if (configDataHeadFrameInfo != null)
			{
				return configDataHeadFrameInfo.ResourcePath;
			}
			return string.Empty;
		}

		// Token: 0x06014598 RID: 83352 RVA: 0x0052CE2C File Offset: 0x0052B02C
		public static GameObject SetPlayerHeadFrame(Transform parent, int headFrameId, bool ingoreDefaultHeadFame = true, string uiState = "Normal")
		{
			if (ingoreDefaultHeadFame)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				if (configDataLoader != null && headFrameId == configDataLoader.ConfigableConstId_DefaultHeadFrameId)
				{
					GameObjectUtility.DestroyChildren(parent.gameObject);
					return null;
				}
			}
			if (parent == null)
			{
				return null;
			}
			GameObjectUtility.DestroyChildren(parent.gameObject);
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(UIUtility.GetPlayerHeadFrameImageName(headFrameId));
			if (asset == null)
			{
				return null;
			}
			GameObject gameObject = GameObjectUtility.CloneGameObject(asset, parent);
			CommonUIStateController componentInChildren = gameObject.GetComponentInChildren<CommonUIStateController>();
			if (componentInChildren != null)
			{
				componentInChildren.SetToUIState(uiState, false, true);
			}
			return gameObject;
		}

		// Token: 0x06014599 RID: 83353 RVA: 0x0052CECC File Offset: 0x0052B0CC
		public static string GetBattlePlayerTagImageName(int playerIndex)
		{
			if (playerIndex == 0)
			{
				return "UI/Common_New_ABS/Font/Word_1P.png";
			}
			if (playerIndex == 1)
			{
				return "UI/Common_New_ABS/Font/Word_2P.png";
			}
			if (playerIndex == 2)
			{
				return "UI/Common_New_ABS/Font/Word_3P.png";
			}
			return string.Empty;
		}

		// Token: 0x0601459A RID: 83354 RVA: 0x0052CEFC File Offset: 0x0052B0FC
		public static string GetSoldierCurSkillDesc(ConfigDataSoldierInfo soldierInfo)
		{
			int num = 0;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			BattleUtility.GetTrainingTechSoldierSkillInfos(configDataLoader, projectLPlayerContext.GetTrainingGroundAvailableTechs(), soldierInfo, out num);
			if (num != 0)
			{
				num--;
			}
			if (soldierInfo.m_skillInfos.Length > num)
			{
				return soldierInfo.m_skillInfos[num].Desc;
			}
			return null;
		}

		// Token: 0x0601459B RID: 83355 RVA: 0x0052CF64 File Offset: 0x0052B164
		public static int GetSkillIdFromEquipment(ConfigDataEquipmentInfo equipmentInfo, int equipmentLevel, ref string skillLv)
		{
			if (equipmentInfo.SkillIds.Count == 0)
			{
				return 0;
			}
			List<int> skillLevels = equipmentInfo.SkillLevels;
			int i;
			for (i = 0; i < skillLevels.Count; i++)
			{
				if (equipmentLevel < skillLevels[i])
				{
					break;
				}
			}
			if (i == 0)
			{
				skillLv = null;
				return equipmentInfo.SkillIds[i];
			}
			if (i >= skillLevels.Count)
			{
				i = skillLevels.Count - 1;
			}
			else
			{
				i--;
			}
			if (equipmentInfo.SkillLevels.Count != 0)
			{
				if (equipmentLevel >= skillLevels[skillLevels.Count - 1])
				{
					skillLv = "Max";
				}
				else
				{
					skillLv = (i + 1).ToString();
				}
			}
			else
			{
				skillLv = "Max";
			}
			return equipmentInfo.SkillIds[i];
		}

		// Token: 0x0601459C RID: 83356 RVA: 0x0052D044 File Offset: 0x0052B244
		public static string GetRankImage(int rank)
		{
			switch (rank)
			{
			case 1:
				return "UI/Common_New_ABS/Font/Rank_N.png";
			case 2:
				return "UI/Common_New_ABS/Font/Rank_R.png";
			case 3:
				return "UI/Common_New_ABS/Font/Rank_SR.png";
			case 4:
			case 5:
				return "UI/Common_New_ABS/Font/Rank_SSR.png";
			default:
				return null;
			}
		}

		// Token: 0x0601459D RID: 83357 RVA: 0x0052D080 File Offset: 0x0052B280
		public static string GetSoldierRankImage(int rank)
		{
			if (rank == 1)
			{
				return "UI/Common_New_ABS/Font/Word_1.png";
			}
			if (rank == 2)
			{
				return "UI/Common_New_ABS/Font/Word_2.png";
			}
			if (rank != 3)
			{
				return null;
			}
			return "UI/Common_New_ABS/Font/Word_3.png";
		}

		// Token: 0x0601459E RID: 83358 RVA: 0x0052D0B0 File Offset: 0x0052B2B0
		public static string GetHeroCharAssetPath(Hero hero)
		{
			ConfigDataCharImageSkinResourceInfo heroCharImageSkinResourceInfo = hero.GetHeroCharImageSkinResourceInfo();
			if (heroCharImageSkinResourceInfo != null)
			{
				return heroCharImageSkinResourceInfo.SpineAssetPath;
			}
			ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
			if (charImageInfo != null)
			{
				return charImageInfo.Spine;
			}
			return string.Empty;
		}

		// Token: 0x0601459F RID: 83359 RVA: 0x0052D0F8 File Offset: 0x0052B2F8
		public static string GetHeroModelAssetPath(Hero hero)
		{
			HeroJob activeJob = hero.GetActiveJob();
			ConfigDataModelSkinResourceInfo modelSkinResourceInfo = activeJob.GetModelSkinResourceInfo();
			if (modelSkinResourceInfo != null)
			{
				return modelSkinResourceInfo.Model;
			}
			return activeJob.JobConnectionInfo.Model;
		}

		// Token: 0x060145A0 RID: 83360 RVA: 0x0052D12C File Offset: 0x0052B32C
		public static string GetSoldierModelAssetPath(Hero hero, int soldierId)
		{
			ConfigDataModelSkinResourceInfo soldierModelSkinResourceInfo = hero.GetSoldierModelSkinResourceInfo(soldierId);
			if (soldierModelSkinResourceInfo != null)
			{
				return soldierModelSkinResourceInfo.Model;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataSoldierInfo configDataSoldierInfo = configDataLoader.GetConfigDataSoldierInfo(soldierId);
			if (configDataSoldierInfo != null)
			{
				return configDataSoldierInfo.Model;
			}
			return string.Empty;
		}

		// Token: 0x060145A1 RID: 83361 RVA: 0x0052D178 File Offset: 0x0052B378
		public static string GetHeroModelAssetPath(BattleHero hero)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataModelSkinResourceInfo heroModelSkinResourceInfo = BattleUtility.GetHeroModelSkinResourceInfo(configDataLoader, hero.ModelSkinId, hero.ActiveHeroJobRelatedId);
			if (heroModelSkinResourceInfo != null)
			{
				return heroModelSkinResourceInfo.Model;
			}
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = configDataLoader.GetConfigDataJobConnectionInfo(hero.ActiveHeroJobRelatedId);
			if (configDataJobConnectionInfo != null)
			{
				return configDataJobConnectionInfo.Model;
			}
			return string.Empty;
		}

		// Token: 0x060145A2 RID: 83362 RVA: 0x0052D1D4 File Offset: 0x0052B3D4
		public static string GetSelectedSoldierModelAssetPath(BattleHero hero, int team = 0)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataModelSkinResourceInfo soldierModelSkinResourceInfo = BattleUtility.GetSoldierModelSkinResourceInfo(configDataLoader, hero.SelectedSoldierSkinId, hero.SelectedSoldierId);
			if (soldierModelSkinResourceInfo != null)
			{
				return soldierModelSkinResourceInfo.Model;
			}
			if (hero.SelectedSoldierInfo != null)
			{
				return (team != 0) ? hero.SelectedSoldierInfo.Model2 : hero.SelectedSoldierInfo.Model;
			}
			return string.Empty;
		}

		// Token: 0x060145A3 RID: 83363 RVA: 0x0052D244 File Offset: 0x0052B444
		public static string GetMemberOnlineText(bool isOnline, DateTime logountTime)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (isOnline)
			{
				return configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Online);
			}
			string format = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_DaysAgo);
			string format2 = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_HoursAgo);
			string format3 = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_MinutesAgo);
			string result = string.Empty;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TimeSpan timeSpan = projectLPlayerContext.GetServerTime() - logountTime;
			if (timeSpan.TotalDays > 30.0)
			{
				result = string.Format(format, 30);
			}
			else if (timeSpan.TotalDays > 1.0)
			{
				result = string.Format(format, timeSpan.Days);
			}
			else if (timeSpan.TotalHours > 1.0)
			{
				result = string.Format(format2, timeSpan.Hours);
			}
			else if (timeSpan.TotalHours < 1.0)
			{
				int num = (timeSpan.Minutes >= 1) ? timeSpan.Minutes : 1;
				result = string.Format(format3, num);
			}
			return result;
		}

		// Token: 0x060145A4 RID: 83364 RVA: 0x0052D388 File Offset: 0x0052B588
		public static string GetSepAlphaTextureName(string colorTextureName)
		{
			string directoryName = Path.GetDirectoryName(colorTextureName);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(colorTextureName);
			string extension = Path.GetExtension(colorTextureName);
			return string.Format("{0}/{1}_a{2}", directoryName, fileNameWithoutExtension, extension);
		}

		// Token: 0x060145A5 RID: 83365 RVA: 0x0052D3B8 File Offset: 0x0052B5B8
		public static string GetGameFunctionOpenMessage(GameFunctionType gameFunctionType)
		{
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			foreach (KeyValuePair<int, ConfigDataGameFunctionOpenInfo> keyValuePair in configDataLoader.GetAllConfigDataGameFunctionOpenInfo())
			{
				if (keyValuePair.Value.GameFunctionType == gameFunctionType)
				{
					return keyValuePair.Value.Message;
				}
			}
			return string.Empty;
		}

		// Token: 0x060145A6 RID: 83366 RVA: 0x0052D448 File Offset: 0x0052B648
		public static string GetLeaderboardRankingImageName(int ranking)
		{
			if (ranking == 1)
			{
				return "UI/Common_New_ABS/Icon/Icon_One.png";
			}
			if (ranking == 2)
			{
				return "UI/Common_New_ABS/Icon/Icon_Two.png";
			}
			if (ranking == 3)
			{
				return "UI/Common_New_ABS/Icon/Icon_Three.png";
			}
			return string.Empty;
		}

		// Token: 0x060145A7 RID: 83367 RVA: 0x0052D478 File Offset: 0x0052B678
		public static string GetDescText(string format, List<string> args)
		{
			if (args != null && args.Count > 0)
			{
				object[] array = new object[args.Count];
				for (int i = 0; i < args.Count; i++)
				{
					array[i] = args[i];
				}
				return string.Format(format, array);
			}
			return format;
		}

		// Token: 0x060145A8 RID: 83368 RVA: 0x0052D4D0 File Offset: 0x0052B6D0
		public static bool MarginAdjustHorizontal(RectTransform rt)
		{
			if (rt == null)
			{
				return false;
			}
			if (!LocalConfig.Instance.Data.TestMarginFix)
			{
				ConfigDataDeviceSetting configDataDeviceSetting = SystemUtility.GetConfigDataDeviceSetting();
				if (configDataDeviceSetting == null)
				{
					return false;
				}
				if (!configDataDeviceSetting.MarginFixHorizontal)
				{
					return false;
				}
			}
			rt.offsetMin = new Vector2(88f, rt.offsetMin.y);
			rt.offsetMax = new Vector2(-88f, rt.offsetMax.y);
			return true;
		}

		// Token: 0x060145A9 RID: 83369 RVA: 0x0052D55C File Offset: 0x0052B75C
		public static bool MarginAdjustVertical(RectTransform rt)
		{
			if (rt == null)
			{
				return false;
			}
			if (!LocalConfig.Instance.Data.TestMarginFix)
			{
				ConfigDataDeviceSetting configDataDeviceSetting = SystemUtility.GetConfigDataDeviceSetting();
				if (configDataDeviceSetting == null)
				{
					return false;
				}
				if (!configDataDeviceSetting.MarginFixVertical)
				{
					return false;
				}
			}
			rt.offsetMin = new Vector2(rt.offsetMin.y, 40f);
			return true;
		}

		// Token: 0x060145AA RID: 83370 RVA: 0x0052D5CC File Offset: 0x0052B7CC
		public static void SetLongFrame()
		{
			UIUtility.s_longFrameCountdown = 2;
			if (UIUtility.s_defaultMaximumDeltaTime == 0f)
			{
				UIUtility.s_defaultMaximumDeltaTime = Time.maximumDeltaTime;
			}
			Time.maximumDeltaTime = 0.0333333351f;
		}

		// Token: 0x060145AB RID: 83371 RVA: 0x0052D5F8 File Offset: 0x0052B7F8
		public static void CheckLongFrame()
		{
			if (UIUtility.s_longFrameCountdown > 0)
			{
				UIUtility.s_longFrameCountdown--;
				if (UIUtility.s_longFrameCountdown == 0)
				{
					Time.maximumDeltaTime = UIUtility.s_defaultMaximumDeltaTime;
				}
			}
		}

		// Token: 0x060145AC RID: 83372 RVA: 0x0052D628 File Offset: 0x0052B828
		public static IEnumerator TweenHorizontalScrollRecPosition(ScrollRect scrollRect, float from, float to, float duration)
		{
			float lastTime = Time.time;
			float scale = 0f;
			while (scale < 1f)
			{
				scale = (Time.time - lastTime) / duration;
				scale = Mathf.Clamp01(scale);
				float normalizePos = Mathf.Lerp(from, to, scale);
				scrollRect.horizontalNormalizedPosition = normalizePos;
				yield return 0;
			}
			yield break;
		}

		// Token: 0x060145AD RID: 83373 RVA: 0x0052D658 File Offset: 0x0052B858
		public static PDSDKGoodType GetGiftItemPdsdkGoodType(int firstPrice, int normalPrice, bool isfristBuy, bool IsAppleSubscribe)
		{
			PDSDKGoodType result = (!isfristBuy || firstPrice == normalPrice) ? PDSDKGoodType.Normal : PDSDKGoodType.FirstCharge;
			if (UIUtility.IsIosSubscribe(IsAppleSubscribe))
			{
				result = PDSDKGoodType.IosSubscribe;
			}
			return result;
		}

		// Token: 0x060145AE RID: 83374 RVA: 0x0052D688 File Offset: 0x0052B888
		public static int GetInputFieldCharacterLimit(int limit)
		{
			if (limit <= 0)
			{
				return 0;
			}
			if (Application.platform == RuntimePlatform.IPhonePlayer)
			{
				return limit + 4;
			}
			return limit;
		}

		// Token: 0x060145AF RID: 83375 RVA: 0x0052D6A4 File Offset: 0x0052B8A4
		public static UITaskBase FindUITaskWithType(Type taskType)
		{
			if (taskType == null)
			{
				return null;
			}
			return UIManager.Instance.FindUITaskWithName(taskType.Name);
		}

		// Token: 0x060145B0 RID: 83376 RVA: 0x0052D6C0 File Offset: 0x0052B8C0
		public static T FindUITaskWithType<T>() where T : class
		{
			return UIManager.Instance.FindUITaskWithName(typeof(T).Name) as T;
		}

		// Token: 0x060145B1 RID: 83377 RVA: 0x0052D6EC File Offset: 0x0052B8EC
		public static bool IsUITaskRunning(Type type)
		{
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(type);
			return uitaskBase != null && uitaskBase.State == Task.TaskState.Running;
		}

		// Token: 0x060145B2 RID: 83378 RVA: 0x0052D714 File Offset: 0x0052B914
		public static void SetDefaultPixelDragThreshold(int t)
		{
			UIUtility.s_DefaultPixelDragThreshold = t;
		}

		// Token: 0x060145B3 RID: 83379 RVA: 0x0052D71C File Offset: 0x0052B91C
		public static int GetDefaultPixelDragThreshold()
		{
			return UIUtility.s_DefaultPixelDragThreshold;
		}

		// Token: 0x060145B4 RID: 83380 RVA: 0x0052D724 File Offset: 0x0052B924
		public static bool IsIosSubscribe(bool isSubscribe)
		{
			return isSubscribe && (Application.platform == RuntimePlatform.IPhonePlayer || PDSDK.IsIosLoginWindowsPlayer);
		}

		// Token: 0x060145B5 RID: 83381 RVA: 0x0052D744 File Offset: 0x0052B944
		public static bool IsYYBChannel()
		{
			return PDSDK.Instance.getChannelID() == PDSDK.Instance.PDYingYongBaoChannelID;
		}

		// Token: 0x060145B6 RID: 83382 RVA: 0x0052D760 File Offset: 0x0052B960
		public static bool IsZiLongChannel()
		{
			return PDSDK.Instance.getChannelID() == PDSDK.Instance.PDAndroidChannelID || PDSDK.Instance.getChannelID() == PDSDK.Instance.IOSChannelID;
		}

		// Token: 0x060145B7 RID: 83383 RVA: 0x0052D79C File Offset: 0x0052B99C
		public static bool IsOppoChannel()
		{
			return PDSDK.Instance.getChannelID() == PDSDK.Instance.PDOppoChannelID;
		}

		// Token: 0x060145B8 RID: 83384 RVA: 0x0052D7B8 File Offset: 0x0052B9B8
		public static string GetUIPrefabPath<T>() where T : class
		{
			string result = string.Empty;
			Type typeFromHandle = typeof(T);
			object[] customAttributes = typeFromHandle.GetCustomAttributes(typeof(ControllerDescriptionAttribute), true);
			if (customAttributes.Length > 0)
			{
				ControllerDescriptionAttribute controllerDescriptionAttribute = customAttributes[0] as ControllerDescriptionAttribute;
				result = controllerDescriptionAttribute.prefabPath;
			}
			return result;
		}

		// Token: 0x060145B9 RID: 83385 RVA: 0x0052D804 File Offset: 0x0052BA04
		public static T CreateSubUI<T>(Transform parent) where T : class
		{
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(UIUtility.GetUIPrefabPath<T>());
			GameObject go = GameObjectUtility.CloneGameObject(asset, parent);
			return GameObjectUtility.AddControllerToGameObject<T>(go);
		}

		// Token: 0x060145BA RID: 83386 RVA: 0x0052D834 File Offset: 0x0052BA34
		public static void Share(int sharePlatform, int heroId = 0, int archiveId = 0)
		{
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_CanNotShareOnWindows, 3f, null, true);
		}

		// Token: 0x060145BB RID: 83387 RVA: 0x0052D84C File Offset: 0x0052BA4C
		public static void LocalizedString(GameObject goRoot)
		{
			UITextLocalizationHelper[] componentsInChildren = goRoot.GetComponentsInChildren<UITextLocalizationHelper>(true);
			foreach (UITextLocalizationHelper uitextLocalizationHelper in componentsInChildren)
			{
				uitextLocalizationHelper.LoadLocatizedString();
			}
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x060145BC RID: 83388 RVA: 0x0052D884 File Offset: 0x0052BA84
		// (set) Token: 0x060145BD RID: 83389 RVA: 0x0052D8A4 File Offset: 0x0052BAA4
		[DoNotToLua]
		public UIUtility.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UIUtility.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060145BF RID: 83391 RVA: 0x0052D910 File Offset: 0x0052BB10
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060145C0 RID: 83392 RVA: 0x0052D9DC File Offset: 0x0052BBDC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UIUtility));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B375 RID: 45941
		public const float PointerLongDownTime = 0.5f;

		// Token: 0x0400B376 RID: 45942
		public const float PointerClickTorrent = 0.02f;

		// Token: 0x0400B377 RID: 45943
		public const float PointerDragTorrent = 0.01f;

		// Token: 0x0400B378 RID: 45944
		private static Dictionary<string, string> m_translateTable = new Dictionary<string, string>();

		// Token: 0x0400B379 RID: 45945
		private const float MarginFixX = 88f;

		// Token: 0x0400B37A RID: 45946
		private const float MarginFixY = 40f;

		// Token: 0x0400B37B RID: 45947
		private static int s_DefaultPixelDragThreshold = 10;

		// Token: 0x0400B37C RID: 45948
		private static int s_longFrameCountdown = 0;

		// Token: 0x0400B37D RID: 45949
		private static float s_defaultMaximumDeltaTime = 0f;

		// Token: 0x0400B37E RID: 45950
		public static Color MyGreenColor = new Color(0.03529412f, 0.58431375f, 0.05882353f);

		// Token: 0x0400B37F RID: 45951
		public static Color MyGrayColor = new Color(0.5882353f, 0.5882353f, 0.5882353f);

		// Token: 0x0400B380 RID: 45952
		public const float MAX_DEBUG_REPORT_TIME = 10f;

		// Token: 0x0400B381 RID: 45953
		public const string STR_UPDATE_REPORT_DESC = "UploadLogByTouches";

		// Token: 0x0400B382 RID: 45954
		[DoNotToLua]
		private UIUtility.LuaExportHelper luaExportHelper;

		// Token: 0x0400B383 RID: 45955
		[CompilerGenerated]
		private static Func<string, string> <>f__mg$cache0;

		// Token: 0x0400B384 RID: 45956
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B385 RID: 45957
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B386 RID: 45958
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000FDD RID: 4061
		public class LuaExportHelper
		{
			// Token: 0x060145C1 RID: 83393 RVA: 0x0052DA44 File Offset: 0x0052BC44
			public LuaExportHelper(UIUtility owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17003C63 RID: 15459
			// (get) Token: 0x060145C2 RID: 83394 RVA: 0x0052DA54 File Offset: 0x0052BC54
			// (set) Token: 0x060145C3 RID: 83395 RVA: 0x0052DA5C File Offset: 0x0052BC5C
			public static Dictionary<string, string> m_translateTable
			{
				get
				{
					return UIUtility.m_translateTable;
				}
				set
				{
					UIUtility.m_translateTable = value;
				}
			}

			// Token: 0x17003C64 RID: 15460
			// (get) Token: 0x060145C4 RID: 83396 RVA: 0x0052DA64 File Offset: 0x0052BC64
			public static float MarginFixX
			{
				get
				{
					return 88f;
				}
			}

			// Token: 0x17003C65 RID: 15461
			// (get) Token: 0x060145C5 RID: 83397 RVA: 0x0052DA6C File Offset: 0x0052BC6C
			public static float MarginFixY
			{
				get
				{
					return 40f;
				}
			}

			// Token: 0x17003C66 RID: 15462
			// (get) Token: 0x060145C6 RID: 83398 RVA: 0x0052DA74 File Offset: 0x0052BC74
			// (set) Token: 0x060145C7 RID: 83399 RVA: 0x0052DA7C File Offset: 0x0052BC7C
			public static int s_DefaultPixelDragThreshold
			{
				get
				{
					return UIUtility.s_DefaultPixelDragThreshold;
				}
				set
				{
					UIUtility.s_DefaultPixelDragThreshold = value;
				}
			}

			// Token: 0x17003C67 RID: 15463
			// (get) Token: 0x060145C8 RID: 83400 RVA: 0x0052DA84 File Offset: 0x0052BC84
			// (set) Token: 0x060145C9 RID: 83401 RVA: 0x0052DA8C File Offset: 0x0052BC8C
			public static int s_longFrameCountdown
			{
				get
				{
					return UIUtility.s_longFrameCountdown;
				}
				set
				{
					UIUtility.s_longFrameCountdown = value;
				}
			}

			// Token: 0x17003C68 RID: 15464
			// (get) Token: 0x060145CA RID: 83402 RVA: 0x0052DA94 File Offset: 0x0052BC94
			// (set) Token: 0x060145CB RID: 83403 RVA: 0x0052DA9C File Offset: 0x0052BC9C
			public static float s_defaultMaximumDeltaTime
			{
				get
				{
					return UIUtility.s_defaultMaximumDeltaTime;
				}
				set
				{
					UIUtility.s_defaultMaximumDeltaTime = value;
				}
			}

			// Token: 0x060145CC RID: 83404 RVA: 0x0052DAA4 File Offset: 0x0052BCA4
			public static string Translate(string srcStr)
			{
				return UIUtility.Translate(srcStr);
			}

			// Token: 0x060145CD RID: 83405 RVA: 0x0052DAAC File Offset: 0x0052BCAC
			public static bool SetTweenFinished(TweenMain[] tweens, Action onFinished)
			{
				return UIUtility.SetTweenFinished(tweens, onFinished);
			}

			// Token: 0x060145CE RID: 83406 RVA: 0x0052DAB8 File Offset: 0x0052BCB8
			public static void RemoveTweenFinished(TweenMain[] tweens)
			{
				UIUtility.RemoveTweenFinished(tweens);
			}

			// Token: 0x060145CF RID: 83407 RVA: 0x0052DAC0 File Offset: 0x0052BCC0
			public static ConfigDataCharImageInfo GetPlayerHeadIconCharImageInfo(int headIconId)
			{
				return UIUtility.GetPlayerHeadIconCharImageInfo(headIconId);
			}

			// Token: 0x0400B387 RID: 45959
			private UIUtility m_owner;
		}
	}
}
