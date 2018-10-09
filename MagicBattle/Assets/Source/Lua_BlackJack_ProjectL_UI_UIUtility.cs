using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015C3 RID: 5571
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UIUtility : LuaObject
{
	// Token: 0x06021E50 RID: 138832 RVA: 0x00B88668 File Offset: 0x00B86868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UIUtility o = new UIUtility();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E51 RID: 138833 RVA: 0x00B886B0 File Offset: 0x00B868B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadTranslateTable_s(IntPtr l)
	{
		int result;
		try
		{
			UIUtility.LoadTranslateTable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E52 RID: 138834 RVA: 0x00B886F0 File Offset: 0x00B868F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WorldToLocalPosition_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 p;
			LuaObject.checkType(l, 1, out p);
			Camera worldCam;
			LuaObject.checkType<Camera>(l, 2, out worldCam);
			RectTransform rt;
			LuaObject.checkType<RectTransform>(l, 3, out rt);
			Camera uiCam;
			LuaObject.checkType<Camera>(l, 4, out uiCam);
			Vector2 o = UIUtility.WorldToLocalPosition(p, worldCam, rt, uiCam);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E53 RID: 138835 RVA: 0x00B8876C File Offset: 0x00B8696C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScreenToLocalPosition_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 p;
			LuaObject.checkType(l, 1, out p);
			RectTransform rt;
			LuaObject.checkType<RectTransform>(l, 2, out rt);
			Camera uiCam;
			LuaObject.checkType<Camera>(l, 3, out uiCam);
			Vector2 o = UIUtility.ScreenToLocalPosition(p, rt, uiCam);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E54 RID: 138836 RVA: 0x00B887DC File Offset: 0x00B869DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddColorTag_s(IntPtr l)
	{
		int result;
		try
		{
			string txt;
			LuaObject.checkType(l, 1, out txt);
			Color c;
			LuaObject.checkType(l, 2, out c);
			string s = UIUtility.AddColorTag(txt, c);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E55 RID: 138837 RVA: 0x00B8883C File Offset: 0x00B86A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivateLayer_s(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase controller;
			LuaObject.checkType<UIControllerBase>(l, 1, out controller);
			bool a;
			LuaObject.checkType(l, 2, out a);
			UIUtility.ActivateLayer(controller, a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E56 RID: 138838 RVA: 0x00B88894 File Offset: 0x00B86A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLayerActive_s(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase controller;
			LuaObject.checkType<UIControllerBase>(l, 1, out controller);
			bool b = UIUtility.IsLayerActive(controller);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E57 RID: 138839 RVA: 0x00B888E8 File Offset: 0x00B86AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClickButton_s(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase controller;
			LuaObject.checkType<UIControllerBase>(l, 1, out controller);
			string buttonName;
			LuaObject.checkType(l, 2, out buttonName);
			UIUtility.ClickButton(controller, buttonName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E58 RID: 138840 RVA: 0x00B88940 File Offset: 0x00B86B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClickToggle_s(IntPtr l)
	{
		int result;
		try
		{
			UIControllerBase controller;
			LuaObject.checkType<UIControllerBase>(l, 1, out controller);
			string toggleName;
			LuaObject.checkType(l, 2, out toggleName);
			UIUtility.ClickToggle(controller, toggleName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E59 RID: 138841 RVA: 0x00B88998 File Offset: 0x00B86B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TimeSpanToString_s(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			string s = UIUtility.TimeSpanToString(timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E5A RID: 138842 RVA: 0x00B889EC File Offset: 0x00B86BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TimeSpanToString2_s(IntPtr l)
	{
		int result;
		try
		{
			TimeSpan timeSpan;
			LuaObject.checkValueType<TimeSpan>(l, 1, out timeSpan);
			string s = UIUtility.TimeSpanToString2(timeSpan);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E5B RID: 138843 RVA: 0x00B88A40 File Offset: 0x00B86C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DateTimeToString_s(IntPtr l)
	{
		int result;
		try
		{
			DateTime dateTime;
			LuaObject.checkValueType<DateTime>(l, 1, out dateTime);
			string s = UIUtility.DateTimeToString(dateTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E5C RID: 138844 RVA: 0x00B88A94 File Offset: 0x00B86C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDailyRewardCount_s(IntPtr l)
	{
		int result;
		try
		{
			Text text;
			LuaObject.checkType<Text>(l, 1, out text);
			int restCount;
			LuaObject.checkType(l, 2, out restCount);
			int allCount;
			LuaObject.checkType(l, 3, out allCount);
			UIUtility.SetDailyRewardCount(text, restCount, allCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E5D RID: 138845 RVA: 0x00B88AF8 File Offset: 0x00B86CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetTween_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			UIUtility.ResetTween(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E5E RID: 138846 RVA: 0x00B88B44 File Offset: 0x00B86D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReplayTween_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 2, out onFinished);
			UIUtility.ReplayTween(go, onFinished);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E5F RID: 138847 RVA: 0x00B88B9C File Offset: 0x00B86D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReversePlayTween_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 2, out onFinished);
			UIUtility.ReversePlayTween(go, onFinished);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E60 RID: 138848 RVA: 0x00B88BF4 File Offset: 0x00B86DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTweenIgnoreTimeScale_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			bool ignore;
			LuaObject.checkType(l, 2, out ignore);
			UIUtility.SetTweenIgnoreTimeScale(go, ignore);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E61 RID: 138849 RVA: 0x00B88C4C File Offset: 0x00B86E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateOpen_s(IntPtr l)
	{
		int result;
		try
		{
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 1, out ctrl);
			string stateName;
			LuaObject.checkType(l, 2, out stateName);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			bool disableInput;
			LuaObject.checkType(l, 4, out disableInput);
			bool allowToRefreshSameState;
			LuaObject.checkType(l, 5, out allowToRefreshSameState);
			UIUtility.SetUIStateOpen(ctrl, stateName, onEnd, disableInput, allowToRefreshSameState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E62 RID: 138850 RVA: 0x00B88CC8 File Offset: 0x00B86EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateClose_s(IntPtr l)
	{
		int result;
		try
		{
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 1, out ctrl);
			string stateName;
			LuaObject.checkType(l, 2, out stateName);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			bool disableInput;
			LuaObject.checkType(l, 4, out disableInput);
			bool allowToRefreshSameState;
			LuaObject.checkType(l, 5, out allowToRefreshSameState);
			UIUtility.SetUIStateClose(ctrl, stateName, onEnd, disableInput, allowToRefreshSameState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E63 RID: 138851 RVA: 0x00B88D44 File Offset: 0x00B86F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateOpenAndClose_s(IntPtr l)
	{
		int result;
		try
		{
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 1, out ctrl);
			string openStateName;
			LuaObject.checkType(l, 2, out openStateName);
			string closeStateName;
			LuaObject.checkType(l, 3, out closeStateName);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			bool disableInput;
			LuaObject.checkType(l, 5, out disableInput);
			UIUtility.SetUIStateOpenAndClose(ctrl, openStateName, closeStateName, onEnd, disableInput);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E64 RID: 138852 RVA: 0x00B88DC0 File Offset: 0x00B86FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIState_s(IntPtr l)
	{
		int result;
		try
		{
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 1, out ctrl);
			string stateName;
			LuaObject.checkType(l, 2, out stateName);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			bool disableInput;
			LuaObject.checkType(l, 4, out disableInput);
			bool allowToRefreshSameState;
			LuaObject.checkType(l, 5, out allowToRefreshSameState);
			UIUtility.SetUIState(ctrl, stateName, onEnd, disableInput, allowToRefreshSameState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E65 RID: 138853 RVA: 0x00B88E3C File Offset: 0x00B8703C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUIStateCurrentStateName_s(IntPtr l)
	{
		int result;
		try
		{
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 1, out ctrl);
			string uistateCurrentStateName = UIUtility.GetUIStateCurrentStateName(ctrl);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uistateCurrentStateName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E66 RID: 138854 RVA: 0x00B88E90 File Offset: 0x00B87090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			string name;
			LuaObject.checkType(l, 2, out name);
			UIUtility.PlayAnimation(go, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E67 RID: 138855 RVA: 0x00B88EE8 File Offset: 0x00B870E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowGameObjectChildrenByColor_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 1, out obj);
			int num;
			LuaObject.checkType(l, 2, out num);
			UIUtility.ShowGameObjectChildrenByColor(obj, num);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E68 RID: 138856 RVA: 0x00B88F40 File Offset: 0x00B87140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGameObjectChildrenActiveCount_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 1, out obj);
			int num;
			LuaObject.checkType(l, 2, out num);
			UIUtility.SetGameObjectChildrenActiveCount(obj, num);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E69 RID: 138857 RVA: 0x00B88F98 File Offset: 0x00B87198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReverseShowGameObjectChildrenByActive_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 1, out obj);
			int num;
			LuaObject.checkType(l, 2, out num);
			UIUtility.ReverseShowGameObjectChildrenByActive(obj, num);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E6A RID: 138858 RVA: 0x00B88FF0 File Offset: 0x00B871F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroItemFrameNameByRank_s(IntPtr l)
	{
		int result;
		try
		{
			int rank;
			LuaObject.checkType(l, 1, out rank);
			string heroItemFrameNameByRank = UIUtility.GetHeroItemFrameNameByRank(rank);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemFrameNameByRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E6B RID: 138859 RVA: 0x00B89044 File Offset: 0x00B87244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsFrameNameByRank_s(IntPtr l)
	{
		int result;
		try
		{
			int rank;
			LuaObject.checkType(l, 1, out rank);
			string goodsFrameNameByRank = UIUtility.GetGoodsFrameNameByRank(rank);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsFrameNameByRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E6C RID: 138860 RVA: 0x00B89098 File Offset: 0x00B87298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPropertyRatingImageName_s(IntPtr l)
	{
		int result;
		try
		{
			char rating;
			LuaObject.checkType(l, 1, out rating);
			string propertyRatingImageName = UIUtility.GetPropertyRatingImageName(rating);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, propertyRatingImageName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E6D RID: 138861 RVA: 0x00B890EC File Offset: 0x00B872EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsName_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string goodsName = UIUtility.GetGoodsName(goodsType, goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E6E RID: 138862 RVA: 0x00B8914C File Offset: 0x00B8734C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsRank_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int goodsRank = UIUtility.GetGoodsRank(goodsType, goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E6F RID: 138863 RVA: 0x00B891AC File Offset: 0x00B873AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsIconName_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string goodsIconName = UIUtility.GetGoodsIconName(goodsType, goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsIconName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E70 RID: 138864 RVA: 0x00B8920C File Offset: 0x00B8740C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsIconMaterialName_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string goodsIconMaterialName = UIUtility.GetGoodsIconMaterialName(goodsType, goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsIconMaterialName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E71 RID: 138865 RVA: 0x00B8926C File Offset: 0x00B8746C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsFrameName_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string goodsFrameName = UIUtility.GetGoodsFrameName(goodsType, goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsFrameName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E72 RID: 138866 RVA: 0x00B892CC File Offset: 0x00B874CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGoodsHeroFragment_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			bool b = UIUtility.IsGoodsHeroFragment(goodsType, goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E73 RID: 138867 RVA: 0x00B8932C File Offset: 0x00B8752C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGoodsGoblin_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			bool b = UIUtility.IsGoodsGoblin(goodsType, goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E74 RID: 138868 RVA: 0x00B8938C File Offset: 0x00B8758C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsDesc_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string goodsDesc = UIUtility.GetGoodsDesc(goodsType, goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E75 RID: 138869 RVA: 0x00B893EC File Offset: 0x00B875EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGuildTitleText_s(IntPtr l)
	{
		int result;
		try
		{
			GuildTitle title;
			LuaObject.checkEnum<GuildTitle>(l, 1, out title);
			string guildTitleText = UIUtility.GetGuildTitleText(title);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E76 RID: 138870 RVA: 0x00B89440 File Offset: 0x00B87640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRankSSR_s(IntPtr l)
	{
		int result;
		try
		{
			int rank;
			LuaObject.checkType(l, 1, out rank);
			bool b = UIUtility.IsRankSSR(rank);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E77 RID: 138871 RVA: 0x00B89494 File Offset: 0x00B87694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBagItemAlchemyGold_s(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 1, out bagItem);
			int bagItemAlchemyGold = UIUtility.GetBagItemAlchemyGold(bagItem);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemAlchemyGold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E78 RID: 138872 RVA: 0x00B894E8 File Offset: 0x00B876E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBagItemDropID_s(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 1, out bagItem);
			int bagItemDropID = UIUtility.GetBagItemDropID(bagItem);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemDropID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E79 RID: 138873 RVA: 0x00B8953C File Offset: 0x00B8773C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBagItemDropDisplayCount_s(IntPtr l)
	{
		int result;
		try
		{
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 1, out bagItem);
			int bagItemDropDisplayCount = UIUtility.GetBagItemDropDisplayCount(bagItem);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemDropDisplayCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E7A RID: 138874 RVA: 0x00B89590 File Offset: 0x00B87790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GoodTypeHaveID_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			bool b = UIUtility.GoodTypeHaveID(goodsType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E7B RID: 138875 RVA: 0x00B895E4 File Offset: 0x00B877E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AppendRandomDropRewardGoodsToList_s(IntPtr l)
	{
		int result;
		try
		{
			int dropId;
			LuaObject.checkType(l, 1, out dropId);
			List<Goods> goods;
			LuaObject.checkType<List<Goods>>(l, 2, out goods);
			UIUtility.AppendRandomDropRewardGoodsToList(dropId, goods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E7C RID: 138876 RVA: 0x00B8963C File Offset: 0x00B8783C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsCount_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 1, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int goodsCount = UIUtility.GetGoodsCount(goodsType, goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E7D RID: 138877 RVA: 0x00B8969C File Offset: 0x00B8789C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrencyCount_s(IntPtr l)
	{
		int result;
		try
		{
			GoodsType currencyType;
			LuaObject.checkEnum<GoodsType>(l, 1, out currencyType);
			int currencyCount = UIUtility.GetCurrencyCount(currencyType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currencyCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E7E RID: 138878 RVA: 0x00B896F0 File Offset: 0x00B878F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerHeadIconImageName_s(IntPtr l)
	{
		int result;
		try
		{
			int headIconId;
			LuaObject.checkType(l, 1, out headIconId);
			string playerHeadIconImageName = UIUtility.GetPlayerHeadIconImageName(headIconId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerHeadIconImageName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E7F RID: 138879 RVA: 0x00B89744 File Offset: 0x00B87944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerSmallHeadIconImageName_s(IntPtr l)
	{
		int result;
		try
		{
			int headIconId;
			LuaObject.checkType(l, 1, out headIconId);
			string playerSmallHeadIconImageName = UIUtility.GetPlayerSmallHeadIconImageName(headIconId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSmallHeadIconImageName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E80 RID: 138880 RVA: 0x00B89798 File Offset: 0x00B87998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerRoundHeadIconImageName_s(IntPtr l)
	{
		int result;
		try
		{
			int headIconId;
			LuaObject.checkType(l, 1, out headIconId);
			string playerRoundHeadIconImageName = UIUtility.GetPlayerRoundHeadIconImageName(headIconId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerRoundHeadIconImageName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E81 RID: 138881 RVA: 0x00B897EC File Offset: 0x00B879EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerHeadFrameImageName_s(IntPtr l)
	{
		int result;
		try
		{
			int headFrameId;
			LuaObject.checkType(l, 1, out headFrameId);
			string playerHeadFrameImageName = UIUtility.GetPlayerHeadFrameImageName(headFrameId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerHeadFrameImageName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E82 RID: 138882 RVA: 0x00B89840 File Offset: 0x00B87A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerHeadFrame_s(IntPtr l)
	{
		int result;
		try
		{
			Transform parent;
			LuaObject.checkType<Transform>(l, 1, out parent);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			bool ingoreDefaultHeadFame;
			LuaObject.checkType(l, 3, out ingoreDefaultHeadFame);
			string uiState;
			LuaObject.checkType(l, 4, out uiState);
			GameObject o = UIUtility.SetPlayerHeadFrame(parent, headFrameId, ingoreDefaultHeadFame, uiState);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E83 RID: 138883 RVA: 0x00B898BC File Offset: 0x00B87ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattlePlayerTagImageName_s(IntPtr l)
	{
		int result;
		try
		{
			int playerIndex;
			LuaObject.checkType(l, 1, out playerIndex);
			string battlePlayerTagImageName = UIUtility.GetBattlePlayerTagImageName(playerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battlePlayerTagImageName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E84 RID: 138884 RVA: 0x00B89910 File Offset: 0x00B87B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoldierCurSkillDesc_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 1, out soldierInfo);
			string soldierCurSkillDesc = UIUtility.GetSoldierCurSkillDesc(soldierInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierCurSkillDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E85 RID: 138885 RVA: 0x00B89964 File Offset: 0x00B87B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSkillIdFromEquipment_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo equipmentInfo;
			LuaObject.checkType<ConfigDataEquipmentInfo>(l, 1, out equipmentInfo);
			int equipmentLevel;
			LuaObject.checkType(l, 2, out equipmentLevel);
			string s;
			LuaObject.checkType(l, 3, out s);
			int skillIdFromEquipment = UIUtility.GetSkillIdFromEquipment(equipmentInfo, equipmentLevel, ref s);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillIdFromEquipment);
			LuaObject.pushValue(l, s);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E86 RID: 138886 RVA: 0x00B899DC File Offset: 0x00B87BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRankImage_s(IntPtr l)
	{
		int result;
		try
		{
			int rank;
			LuaObject.checkType(l, 1, out rank);
			string rankImage = UIUtility.GetRankImage(rank);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E87 RID: 138887 RVA: 0x00B89A30 File Offset: 0x00B87C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoldierRankImage_s(IntPtr l)
	{
		int result;
		try
		{
			int rank;
			LuaObject.checkType(l, 1, out rank);
			string soldierRankImage = UIUtility.GetSoldierRankImage(rank);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierRankImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E88 RID: 138888 RVA: 0x00B89A84 File Offset: 0x00B87C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroCharAssetPath_s(IntPtr l)
	{
		int result;
		try
		{
			Hero hero;
			LuaObject.checkType<Hero>(l, 1, out hero);
			string heroCharAssetPath = UIUtility.GetHeroCharAssetPath(hero);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharAssetPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E89 RID: 138889 RVA: 0x00B89AD8 File Offset: 0x00B87CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroModelAssetPath_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(Hero)))
			{
				Hero hero;
				LuaObject.checkType<Hero>(l, 1, out hero);
				string heroModelAssetPath = UIUtility.GetHeroModelAssetPath(hero);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, heroModelAssetPath);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(BattleHero)))
			{
				BattleHero hero2;
				LuaObject.checkType<BattleHero>(l, 1, out hero2);
				string heroModelAssetPath2 = UIUtility.GetHeroModelAssetPath(hero2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, heroModelAssetPath2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetHeroModelAssetPath to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E8A RID: 138890 RVA: 0x00B89BA4 File Offset: 0x00B87DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSoldierModelAssetPath_s(IntPtr l)
	{
		int result;
		try
		{
			Hero hero;
			LuaObject.checkType<Hero>(l, 1, out hero);
			int soldierId;
			LuaObject.checkType(l, 2, out soldierId);
			string soldierModelAssetPath = UIUtility.GetSoldierModelAssetPath(hero, soldierId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierModelAssetPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E8B RID: 138891 RVA: 0x00B89C04 File Offset: 0x00B87E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSelectedSoldierModelAssetPath_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 1, out hero);
			int team;
			LuaObject.checkType(l, 2, out team);
			string selectedSoldierModelAssetPath = UIUtility.GetSelectedSoldierModelAssetPath(hero, team);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectedSoldierModelAssetPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E8C RID: 138892 RVA: 0x00B89C64 File Offset: 0x00B87E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMemberOnlineText_s(IntPtr l)
	{
		int result;
		try
		{
			bool isOnline;
			LuaObject.checkType(l, 1, out isOnline);
			DateTime logountTime;
			LuaObject.checkValueType<DateTime>(l, 2, out logountTime);
			string memberOnlineText = UIUtility.GetMemberOnlineText(isOnline, logountTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memberOnlineText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E8D RID: 138893 RVA: 0x00B89CC4 File Offset: 0x00B87EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSepAlphaTextureName_s(IntPtr l)
	{
		int result;
		try
		{
			string colorTextureName;
			LuaObject.checkType(l, 1, out colorTextureName);
			string sepAlphaTextureName = UIUtility.GetSepAlphaTextureName(colorTextureName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sepAlphaTextureName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E8E RID: 138894 RVA: 0x00B89D18 File Offset: 0x00B87F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGameFunctionOpenMessage_s(IntPtr l)
	{
		int result;
		try
		{
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 1, out gameFunctionType);
			string gameFunctionOpenMessage = UIUtility.GetGameFunctionOpenMessage(gameFunctionType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameFunctionOpenMessage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E8F RID: 138895 RVA: 0x00B89D6C File Offset: 0x00B87F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLeaderboardRankingImageName_s(IntPtr l)
	{
		int result;
		try
		{
			int ranking;
			LuaObject.checkType(l, 1, out ranking);
			string leaderboardRankingImageName = UIUtility.GetLeaderboardRankingImageName(ranking);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, leaderboardRankingImageName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E90 RID: 138896 RVA: 0x00B89DC0 File Offset: 0x00B87FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDescText_s(IntPtr l)
	{
		int result;
		try
		{
			string format;
			LuaObject.checkType(l, 1, out format);
			List<string> args;
			LuaObject.checkType<List<string>>(l, 2, out args);
			string descText = UIUtility.GetDescText(format, args);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, descText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E91 RID: 138897 RVA: 0x00B89E20 File Offset: 0x00B88020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MarginAdjustHorizontal_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rt;
			LuaObject.checkType<RectTransform>(l, 1, out rt);
			bool b = UIUtility.MarginAdjustHorizontal(rt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E92 RID: 138898 RVA: 0x00B89E74 File Offset: 0x00B88074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MarginAdjustVertical_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rt;
			LuaObject.checkType<RectTransform>(l, 1, out rt);
			bool b = UIUtility.MarginAdjustVertical(rt);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E93 RID: 138899 RVA: 0x00B89EC8 File Offset: 0x00B880C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLongFrame_s(IntPtr l)
	{
		int result;
		try
		{
			UIUtility.SetLongFrame();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E94 RID: 138900 RVA: 0x00B89F08 File Offset: 0x00B88108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckLongFrame_s(IntPtr l)
	{
		int result;
		try
		{
			UIUtility.CheckLongFrame();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E95 RID: 138901 RVA: 0x00B89F48 File Offset: 0x00B88148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TweenHorizontalScrollRecPosition_s(IntPtr l)
	{
		int result;
		try
		{
			ScrollRect scrollRect;
			LuaObject.checkType<ScrollRect>(l, 1, out scrollRect);
			float from;
			LuaObject.checkType(l, 2, out from);
			float to;
			LuaObject.checkType(l, 3, out to);
			float duration;
			LuaObject.checkType(l, 4, out duration);
			IEnumerator o = UIUtility.TweenHorizontalScrollRecPosition(scrollRect, from, to, duration);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E96 RID: 138902 RVA: 0x00B89FC4 File Offset: 0x00B881C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGiftItemPdsdkGoodType_s(IntPtr l)
	{
		int result;
		try
		{
			int firstPrice;
			LuaObject.checkType(l, 1, out firstPrice);
			int normalPrice;
			LuaObject.checkType(l, 2, out normalPrice);
			bool isfristBuy;
			LuaObject.checkType(l, 3, out isfristBuy);
			bool isAppleSubscribe;
			LuaObject.checkType(l, 4, out isAppleSubscribe);
			PDSDKGoodType giftItemPdsdkGoodType = UIUtility.GetGiftItemPdsdkGoodType(firstPrice, normalPrice, isfristBuy, isAppleSubscribe);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)giftItemPdsdkGoodType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E97 RID: 138903 RVA: 0x00B8A040 File Offset: 0x00B88240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInputFieldCharacterLimit_s(IntPtr l)
	{
		int result;
		try
		{
			int limit;
			LuaObject.checkType(l, 1, out limit);
			int inputFieldCharacterLimit = UIUtility.GetInputFieldCharacterLimit(limit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inputFieldCharacterLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E98 RID: 138904 RVA: 0x00B8A094 File Offset: 0x00B88294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindUITaskWithType_s(IntPtr l)
	{
		int result;
		try
		{
			Type taskType;
			LuaObject.checkType(l, 1, out taskType);
			UITaskBase o = UIUtility.FindUITaskWithType(taskType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E99 RID: 138905 RVA: 0x00B8A0E8 File Offset: 0x00B882E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUITaskRunning_s(IntPtr l)
	{
		int result;
		try
		{
			Type type;
			LuaObject.checkType(l, 1, out type);
			bool b = UIUtility.IsUITaskRunning(type);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E9A RID: 138906 RVA: 0x00B8A13C File Offset: 0x00B8833C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDefaultPixelDragThreshold_s(IntPtr l)
	{
		int result;
		try
		{
			int defaultPixelDragThreshold;
			LuaObject.checkType(l, 1, out defaultPixelDragThreshold);
			UIUtility.SetDefaultPixelDragThreshold(defaultPixelDragThreshold);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E9B RID: 138907 RVA: 0x00B8A188 File Offset: 0x00B88388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDefaultPixelDragThreshold_s(IntPtr l)
	{
		int result;
		try
		{
			int defaultPixelDragThreshold = UIUtility.GetDefaultPixelDragThreshold();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, defaultPixelDragThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E9C RID: 138908 RVA: 0x00B8A1D0 File Offset: 0x00B883D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsIosSubscribe_s(IntPtr l)
	{
		int result;
		try
		{
			bool isSubscribe;
			LuaObject.checkType(l, 1, out isSubscribe);
			bool b = UIUtility.IsIosSubscribe(isSubscribe);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E9D RID: 138909 RVA: 0x00B8A224 File Offset: 0x00B88424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsYYBChannel_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = UIUtility.IsYYBChannel();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E9E RID: 138910 RVA: 0x00B8A26C File Offset: 0x00B8846C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsZiLongChannel_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = UIUtility.IsZiLongChannel();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021E9F RID: 138911 RVA: 0x00B8A2B4 File Offset: 0x00B884B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOppoChannel_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = UIUtility.IsOppoChannel();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EA0 RID: 138912 RVA: 0x00B8A2FC File Offset: 0x00B884FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Share_s(IntPtr l)
	{
		int result;
		try
		{
			int sharePlatform;
			LuaObject.checkType(l, 1, out sharePlatform);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int archiveId;
			LuaObject.checkType(l, 3, out archiveId);
			UIUtility.Share(sharePlatform, heroId, archiveId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EA1 RID: 138913 RVA: 0x00B8A360 File Offset: 0x00B88560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LocalizedString_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject goRoot;
			LuaObject.checkType<GameObject>(l, 1, out goRoot);
			UIUtility.LocalizedString(goRoot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EA2 RID: 138914 RVA: 0x00B8A3AC File Offset: 0x00B885AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Translate_s(IntPtr l)
	{
		int result;
		try
		{
			string srcStr;
			LuaObject.checkType(l, 1, out srcStr);
			string s = UIUtility.LuaExportHelper.Translate(srcStr);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EA3 RID: 138915 RVA: 0x00B8A400 File Offset: 0x00B88600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTweenFinished_s(IntPtr l)
	{
		int result;
		try
		{
			TweenMain[] tweens;
			LuaObject.checkArray<TweenMain>(l, 1, out tweens);
			Action onFinished;
			LuaObject.checkDelegate<Action>(l, 2, out onFinished);
			bool b = UIUtility.LuaExportHelper.SetTweenFinished(tweens, onFinished);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EA4 RID: 138916 RVA: 0x00B8A460 File Offset: 0x00B88660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveTweenFinished_s(IntPtr l)
	{
		int result;
		try
		{
			TweenMain[] tweens;
			LuaObject.checkArray<TweenMain>(l, 1, out tweens);
			UIUtility.LuaExportHelper.RemoveTweenFinished(tweens);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EA5 RID: 138917 RVA: 0x00B8A4AC File Offset: 0x00B886AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerHeadIconCharImageInfo_s(IntPtr l)
	{
		int result;
		try
		{
			int headIconId;
			LuaObject.checkType(l, 1, out headIconId);
			ConfigDataCharImageInfo playerHeadIconCharImageInfo = UIUtility.LuaExportHelper.GetPlayerHeadIconCharImageInfo(headIconId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerHeadIconCharImageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EA6 RID: 138918 RVA: 0x00B8A500 File Offset: 0x00B88700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PointerLongDownTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.5f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EA7 RID: 138919 RVA: 0x00B8A548 File Offset: 0x00B88748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PointerClickTorrent(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.02f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EA8 RID: 138920 RVA: 0x00B8A590 File Offset: 0x00B88790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PointerDragTorrent(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.01f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EA9 RID: 138921 RVA: 0x00B8A5D8 File Offset: 0x00B887D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_translateTable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIUtility.LuaExportHelper.m_translateTable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EAA RID: 138922 RVA: 0x00B8A620 File Offset: 0x00B88820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_translateTable(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<string, string> translateTable;
			LuaObject.checkType<Dictionary<string, string>>(l, 2, out translateTable);
			UIUtility.LuaExportHelper.m_translateTable = translateTable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EAB RID: 138923 RVA: 0x00B8A66C File Offset: 0x00B8886C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MarginFixX(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIUtility.LuaExportHelper.MarginFixX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EAC RID: 138924 RVA: 0x00B8A6B4 File Offset: 0x00B888B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MarginFixY(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIUtility.LuaExportHelper.MarginFixY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EAD RID: 138925 RVA: 0x00B8A6FC File Offset: 0x00B888FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_DefaultPixelDragThreshold(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIUtility.LuaExportHelper.s_DefaultPixelDragThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EAE RID: 138926 RVA: 0x00B8A744 File Offset: 0x00B88944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_DefaultPixelDragThreshold(IntPtr l)
	{
		int result;
		try
		{
			int s_DefaultPixelDragThreshold;
			LuaObject.checkType(l, 2, out s_DefaultPixelDragThreshold);
			UIUtility.LuaExportHelper.s_DefaultPixelDragThreshold = s_DefaultPixelDragThreshold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EAF RID: 138927 RVA: 0x00B8A790 File Offset: 0x00B88990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_longFrameCountdown(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIUtility.LuaExportHelper.s_longFrameCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EB0 RID: 138928 RVA: 0x00B8A7D8 File Offset: 0x00B889D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_longFrameCountdown(IntPtr l)
	{
		int result;
		try
		{
			int s_longFrameCountdown;
			LuaObject.checkType(l, 2, out s_longFrameCountdown);
			UIUtility.LuaExportHelper.s_longFrameCountdown = s_longFrameCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EB1 RID: 138929 RVA: 0x00B8A824 File Offset: 0x00B88A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_defaultMaximumDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIUtility.LuaExportHelper.s_defaultMaximumDeltaTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EB2 RID: 138930 RVA: 0x00B8A86C File Offset: 0x00B88A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_defaultMaximumDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			float s_defaultMaximumDeltaTime;
			LuaObject.checkType(l, 2, out s_defaultMaximumDeltaTime);
			UIUtility.LuaExportHelper.s_defaultMaximumDeltaTime = s_defaultMaximumDeltaTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EB3 RID: 138931 RVA: 0x00B8A8B8 File Offset: 0x00B88AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MyGreenColor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIUtility.MyGreenColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EB4 RID: 138932 RVA: 0x00B8A900 File Offset: 0x00B88B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MyGreenColor(IntPtr l)
	{
		int result;
		try
		{
			Color myGreenColor;
			LuaObject.checkType(l, 2, out myGreenColor);
			UIUtility.MyGreenColor = myGreenColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EB5 RID: 138933 RVA: 0x00B8A94C File Offset: 0x00B88B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MyGrayColor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIUtility.MyGrayColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EB6 RID: 138934 RVA: 0x00B8A994 File Offset: 0x00B88B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MyGrayColor(IntPtr l)
	{
		int result;
		try
		{
			Color myGrayColor;
			LuaObject.checkType(l, 2, out myGrayColor);
			UIUtility.MyGrayColor = myGrayColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EB7 RID: 138935 RVA: 0x00B8A9E0 File Offset: 0x00B88BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MAX_DEBUG_REPORT_TIME(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 10f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EB8 RID: 138936 RVA: 0x00B8AA28 File Offset: 0x00B88C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_STR_UPDATE_REPORT_DESC(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UploadLogByTouches");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021EB9 RID: 138937 RVA: 0x00B8AA70 File Offset: 0x00B88C70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UIUtility");
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.LoadTranslateTable_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.WorldToLocalPosition_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.ScreenToLocalPosition_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.AddColorTag_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.ActivateLayer_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.IsLayerActive_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.ClickButton_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.ClickToggle_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.TimeSpanToString_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.TimeSpanToString2_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.DateTimeToString_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.SetDailyRewardCount_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.ResetTween_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.ReplayTween_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.ReversePlayTween_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.SetTweenIgnoreTimeScale_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.SetUIStateOpen_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.SetUIStateClose_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.SetUIStateOpenAndClose_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.SetUIState_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetUIStateCurrentStateName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.PlayAnimation_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.ShowGameObjectChildrenByColor_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.SetGameObjectChildrenActiveCount_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.ReverseShowGameObjectChildrenByActive_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetHeroItemFrameNameByRank_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetGoodsFrameNameByRank_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetPropertyRatingImageName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetGoodsName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetGoodsRank_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetGoodsIconName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetGoodsIconMaterialName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetGoodsFrameName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.IsGoodsHeroFragment_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.IsGoodsGoblin_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetGoodsDesc_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetGuildTitleText_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.IsRankSSR_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetBagItemAlchemyGold_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetBagItemDropID_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetBagItemDropDisplayCount_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GoodTypeHaveID_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.AppendRandomDropRewardGoodsToList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetGoodsCount_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetCurrencyCount_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetPlayerHeadIconImageName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetPlayerSmallHeadIconImageName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetPlayerRoundHeadIconImageName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetPlayerHeadFrameImageName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.SetPlayerHeadFrame_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetBattlePlayerTagImageName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetSoldierCurSkillDesc_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetSkillIdFromEquipment_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetRankImage_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetSoldierRankImage_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetHeroCharAssetPath_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetHeroModelAssetPath_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetSoldierModelAssetPath_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetSelectedSoldierModelAssetPath_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetMemberOnlineText_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetSepAlphaTextureName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetGameFunctionOpenMessage_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetLeaderboardRankingImageName_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetDescText_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.MarginAdjustHorizontal_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.MarginAdjustVertical_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.SetLongFrame_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.CheckLongFrame_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.TweenHorizontalScrollRecPosition_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetGiftItemPdsdkGoodType_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetInputFieldCharacterLimit_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.FindUITaskWithType_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.IsUITaskRunning_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.SetDefaultPixelDragThreshold_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetDefaultPixelDragThreshold_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.IsIosSubscribe_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.IsYYBChannel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.IsZiLongChannel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.IsOppoChannel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.Share_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.LocalizedString_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.Translate_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.SetTweenFinished_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.RemoveTweenFinished_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.GetPlayerHeadIconCharImageInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache54);
		string name = "PointerLongDownTime";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_PointerLongDownTime);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache55, null, false);
		string name2 = "PointerClickTorrent";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_PointerClickTorrent);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache56, null, false);
		string name3 = "PointerDragTorrent";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_PointerDragTorrent);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache57, null, false);
		string name4 = "m_translateTable";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_m_translateTable);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.set_m_translateTable);
		}
		LuaObject.addMember(l, name4, get, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache59, false);
		string name5 = "MarginFixX";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_MarginFixX);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5A, null, false);
		string name6 = "MarginFixY";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_MarginFixY);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5B, null, false);
		string name7 = "s_DefaultPixelDragThreshold";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_s_DefaultPixelDragThreshold);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.set_s_DefaultPixelDragThreshold);
		}
		LuaObject.addMember(l, name7, get2, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5D, false);
		string name8 = "s_longFrameCountdown";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_s_longFrameCountdown);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.set_s_longFrameCountdown);
		}
		LuaObject.addMember(l, name8, get3, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache5F, false);
		string name9 = "s_defaultMaximumDeltaTime";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_s_defaultMaximumDeltaTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.set_s_defaultMaximumDeltaTime);
		}
		LuaObject.addMember(l, name9, get4, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache61, false);
		string name10 = "MyGreenColor";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_MyGreenColor);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.set_MyGreenColor);
		}
		LuaObject.addMember(l, name10, get5, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache63, false);
		string name11 = "MyGrayColor";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_MyGrayColor);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.set_MyGrayColor);
		}
		LuaObject.addMember(l, name11, get6, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache65, false);
		string name12 = "MAX_DEBUG_REPORT_TIME";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_MAX_DEBUG_REPORT_TIME);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache66, null, false);
		string name13 = "STR_UPDATE_REPORT_DESC";
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.get_STR_UPDATE_REPORT_DESC);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache67, null, false);
		if (Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UIUtility.<>f__mg$cache68, typeof(UIUtility));
	}

	// Token: 0x04017CAC RID: 97452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017CAD RID: 97453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017CAE RID: 97454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017CAF RID: 97455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017CB0 RID: 97456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017CB1 RID: 97457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017CB2 RID: 97458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017CB3 RID: 97459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017CB4 RID: 97460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017CB5 RID: 97461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017CB6 RID: 97462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017CB7 RID: 97463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017CB8 RID: 97464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017CB9 RID: 97465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017CBA RID: 97466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017CBB RID: 97467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017CBC RID: 97468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017CBD RID: 97469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017CBE RID: 97470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017CBF RID: 97471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017CC0 RID: 97472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017CC1 RID: 97473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017CC2 RID: 97474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017CC3 RID: 97475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017CC4 RID: 97476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017CC5 RID: 97477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017CC6 RID: 97478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017CC7 RID: 97479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017CC8 RID: 97480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017CC9 RID: 97481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017CCA RID: 97482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017CCB RID: 97483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017CCC RID: 97484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017CCD RID: 97485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017CCE RID: 97486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017CCF RID: 97487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017CD0 RID: 97488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017CD1 RID: 97489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017CD2 RID: 97490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017CD3 RID: 97491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017CD4 RID: 97492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017CD5 RID: 97493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017CD6 RID: 97494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017CD7 RID: 97495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017CD8 RID: 97496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017CD9 RID: 97497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017CDA RID: 97498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017CDB RID: 97499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017CDC RID: 97500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017CDD RID: 97501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017CDE RID: 97502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017CDF RID: 97503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017CE0 RID: 97504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017CE1 RID: 97505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017CE2 RID: 97506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017CE3 RID: 97507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017CE4 RID: 97508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017CE5 RID: 97509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017CE6 RID: 97510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017CE7 RID: 97511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017CE8 RID: 97512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017CE9 RID: 97513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017CEA RID: 97514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017CEB RID: 97515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017CEC RID: 97516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04017CED RID: 97517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04017CEE RID: 97518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04017CEF RID: 97519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04017CF0 RID: 97520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04017CF1 RID: 97521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04017CF2 RID: 97522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04017CF3 RID: 97523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017CF4 RID: 97524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04017CF5 RID: 97525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04017CF6 RID: 97526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04017CF7 RID: 97527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04017CF8 RID: 97528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04017CF9 RID: 97529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04017CFA RID: 97530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04017CFB RID: 97531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04017CFC RID: 97532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04017CFD RID: 97533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04017CFE RID: 97534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04017CFF RID: 97535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04017D00 RID: 97536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04017D01 RID: 97537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04017D02 RID: 97538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04017D03 RID: 97539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04017D04 RID: 97540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04017D05 RID: 97541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04017D06 RID: 97542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04017D07 RID: 97543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04017D08 RID: 97544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04017D09 RID: 97545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04017D0A RID: 97546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04017D0B RID: 97547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04017D0C RID: 97548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04017D0D RID: 97549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04017D0E RID: 97550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04017D0F RID: 97551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04017D10 RID: 97552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04017D11 RID: 97553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04017D12 RID: 97554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04017D13 RID: 97555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04017D14 RID: 97556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;
}
