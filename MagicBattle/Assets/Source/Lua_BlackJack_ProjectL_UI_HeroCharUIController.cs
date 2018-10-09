using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014A8 RID: 5288
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroCharUIController : LuaObject
{
	// Token: 0x0601EA30 RID: 125488 RVA: 0x009E88AC File Offset: 0x009E6AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGraphic(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
				Hero hero;
				LuaObject.checkType<Hero>(l, 2, out hero);
				HeroCharUIController.PerformanceState performanceState;
				LuaObject.checkEnum<HeroCharUIController.PerformanceState>(l, 3, out performanceState);
				bool canClick;
				LuaObject.checkType(l, 4, out canClick);
				string assetPath;
				LuaObject.checkType(l, 5, out assetPath);
				heroCharUIController.CreateGraphic(hero, performanceState, canClick, assetPath);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				HeroCharUIController heroCharUIController2 = (HeroCharUIController)LuaObject.checkSelf(l);
				ConfigDataHeroInfo heroInfo;
				LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
				heroCharUIController2.CreateGraphic(heroInfo);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				HeroCharUIController heroCharUIController3 = (HeroCharUIController)LuaObject.checkSelf(l);
				ConfigDataHeroInfo heroInfo2;
				LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo2);
				string spinePath;
				LuaObject.checkType(l, 3, out spinePath);
				int heroSkinId;
				LuaObject.checkType(l, 4, out heroSkinId);
				heroCharUIController3.CreateGraphic(heroInfo2, spinePath, heroSkinId);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CreateGraphic to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA31 RID: 125489 RVA: 0x009E89D8 File Offset: 0x009E6BD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCharImageInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo = heroCharUIController.GetCharImageInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, charImageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA32 RID: 125490 RVA: 0x009E8A2C File Offset: 0x009E6C2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroCharSkinId(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			int heroCharSkinId = heroCharUIController.GetHeroCharSkinId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharSkinId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA33 RID: 125491 RVA: 0x009E8A80 File Offset: 0x009E6C80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DestroyGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			heroCharUIController.DestroyGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA34 RID: 125492 RVA: 0x009E8ACC File Offset: 0x009E6CCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(bool)))
			{
				HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
				string animName;
				LuaObject.checkType(l, 2, out animName);
				bool loop;
				LuaObject.checkType(l, 3, out loop);
				heroCharUIController.PlayAnimation(animName, loop);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(bool)))
			{
				HeroCharUIController heroCharUIController2 = (HeroCharUIController)LuaObject.checkSelf(l);
				int idx;
				LuaObject.checkType(l, 2, out idx);
				bool loop2;
				LuaObject.checkType(l, 3, out loop2);
				float o = heroCharUIController2.PlayAnimation(idx, loop2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PlayAnimation to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA35 RID: 125493 RVA: 0x009E8BDC File Offset: 0x009E6DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayVoice(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			IAudioPlayback o = heroCharUIController.PlayVoice(idx);
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

	// Token: 0x0601EA36 RID: 125494 RVA: 0x009E8C40 File Offset: 0x009E6E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWords(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			float autoCloseTime;
			LuaObject.checkType(l, 3, out autoCloseTime);
			float o = heroCharUIController.ShowWords(idx, autoCloseTime);
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

	// Token: 0x0601EA37 RID: 125495 RVA: 0x009E8CB0 File Offset: 0x009E6EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSpineColor(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			Color spineColor;
			LuaObject.checkType(l, 2, out spineColor);
			heroCharUIController.SetSpineColor(spineColor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA38 RID: 125496 RVA: 0x009E8D08 File Offset: 0x009E6F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroCharUIController.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA39 RID: 125497 RVA: 0x009E8D60 File Offset: 0x009E6F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCanClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			bool canClick;
			LuaObject.checkType(l, 2, out canClick);
			heroCharUIController.SetCanClick(canClick);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA3A RID: 125498 RVA: 0x009E8DB8 File Offset: 0x009E6FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayOneRandomPerformance(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			bool canInterrupt;
			LuaObject.checkType(l, 2, out canInterrupt);
			float o = heroCharUIController.PlayOneRandomPerformance(canInterrupt);
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

	// Token: 0x0601EA3B RID: 125499 RVA: 0x009E8E1C File Offset: 0x009E701C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayOneSpecifiedPerformance(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			int heroPerformanceId;
			LuaObject.checkType(l, 2, out heroPerformanceId);
			float o = heroCharUIController.PlayOneSpecifiedPerformance(heroPerformanceId);
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

	// Token: 0x0601EA3C RID: 125500 RVA: 0x009E8E80 File Offset: 0x009E7080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			heroCharUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA3D RID: 125501 RVA: 0x009E8ED4 File Offset: 0x009E70D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			heroCharUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA3E RID: 125502 RVA: 0x009E8F28 File Offset: 0x009E7128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseWordPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			IEnumerator o = heroCharUIController.m_luaExportHelper.CloseWordPanel(time);
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

	// Token: 0x0601EA3F RID: 125503 RVA: 0x009E8F90 File Offset: 0x009E7190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			heroCharUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA40 RID: 125504 RVA: 0x009E8FE4 File Offset: 0x009E71E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsClickInCharRoot(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			GameObject clickGameObject;
			LuaObject.checkType<GameObject>(l, 2, out clickGameObject);
			bool b = heroCharUIController.m_luaExportHelper.IsClickInCharRoot(clickGameObject);
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

	// Token: 0x0601EA41 RID: 125505 RVA: 0x009E904C File Offset: 0x009E724C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanPlayRandomHeroPerformancesIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			bool b = heroCharUIController.m_luaExportHelper.CanPlayRandomHeroPerformancesIndex(index);
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

	// Token: 0x0601EA42 RID: 125506 RVA: 0x009E90B4 File Offset: 0x009E72B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPerformanceIdByState(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			int favorabilityLevel;
			LuaObject.checkType(l, 2, out favorabilityLevel);
			Hero hero;
			LuaObject.checkType<Hero>(l, 3, out hero);
			HeroCharUIController.PerformanceState performanceState;
			LuaObject.checkEnum<HeroCharUIController.PerformanceState>(l, 4, out performanceState);
			int performanceIdByState = heroCharUIController.m_luaExportHelper.GetPerformanceIdByState(favorabilityLevel, hero, performanceState);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, performanceIdByState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA43 RID: 125507 RVA: 0x009E9138 File Offset: 0x009E7338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroCharUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA44 RID: 125508 RVA: 0x009E91A4 File Offset: 0x009E73A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			heroCharUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA45 RID: 125509 RVA: 0x009E91F8 File Offset: 0x009E73F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			heroCharUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA46 RID: 125510 RVA: 0x009E924C File Offset: 0x009E744C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = heroCharUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EA47 RID: 125511 RVA: 0x009E92F4 File Offset: 0x009E74F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			heroCharUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA48 RID: 125512 RVA: 0x009E9348 File Offset: 0x009E7548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroCharUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA49 RID: 125513 RVA: 0x009E93B4 File Offset: 0x009E75B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroCharUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroCharUIController heroCharUIController2 = (HeroCharUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroCharUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA4A RID: 125514 RVA: 0x009E94C4 File Offset: 0x009E76C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCharUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA4B RID: 125515 RVA: 0x009E9530 File Offset: 0x009E7730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCharUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA4C RID: 125516 RVA: 0x009E959C File Offset: 0x009E779C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCharUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA4D RID: 125517 RVA: 0x009E9608 File Offset: 0x009E7808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCharUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA4E RID: 125518 RVA: 0x009E9674 File Offset: 0x009E7874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroCharUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroCharUIController heroCharUIController2 = (HeroCharUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroCharUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA4F RID: 125519 RVA: 0x009E9784 File Offset: 0x009E7984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			string s = heroCharUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EA50 RID: 125520 RVA: 0x009E97E0 File Offset: 0x009E79E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			heroCharUIController.m_luaExportHelper.__callDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA51 RID: 125521 RVA: 0x009E9834 File Offset: 0x009E7A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			heroCharUIController.m_luaExportHelper.__clearDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA52 RID: 125522 RVA: 0x009E9888 File Offset: 0x009E7A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroCharUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					heroCharUIController.EventOnClick -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA53 RID: 125523 RVA: 0x009E9908 File Offset: 0x009E7B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charRoot(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_charRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA54 RID: 125524 RVA: 0x009E9960 File Offset: 0x009E7B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charRoot(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			GameObject charRoot;
			LuaObject.checkType<GameObject>(l, 2, out charRoot);
			heroCharUIController.m_luaExportHelper.m_charRoot = charRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA55 RID: 125525 RVA: 0x009E99BC File Offset: 0x009E7BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_root(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_root);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA56 RID: 125526 RVA: 0x009E9A14 File Offset: 0x009E7C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_root(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			GameObject root;
			LuaObject.checkType<GameObject>(l, 2, out root);
			heroCharUIController.m_luaExportHelper.m_root = root;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA57 RID: 125527 RVA: 0x009E9A70 File Offset: 0x009E7C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_wordGo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_wordGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA58 RID: 125528 RVA: 0x009E9AC8 File Offset: 0x009E7CC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_wordGo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			GameObject wordGo;
			LuaObject.checkType<GameObject>(l, 2, out wordGo);
			heroCharUIController.m_luaExportHelper.m_wordGo = wordGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA59 RID: 125529 RVA: 0x009E9B24 File Offset: 0x009E7D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA5A RID: 125530 RVA: 0x009E9B7C File Offset: 0x009E7D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			Text text;
			LuaObject.checkType<Text>(l, 2, out text);
			heroCharUIController.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA5B RID: 125531 RVA: 0x009E9BD8 File Offset: 0x009E7DD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA5C RID: 125532 RVA: 0x009E9C30 File Offset: 0x009E7E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			heroCharUIController.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA5D RID: 125533 RVA: 0x009E9C8C File Offset: 0x009E7E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_spineGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA5E RID: 125534 RVA: 0x009E9CE4 File Offset: 0x009E7EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			UISpineGraphic spineGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out spineGraphic);
			heroCharUIController.m_luaExportHelper.m_spineGraphic = spineGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA5F RID: 125535 RVA: 0x009E9D40 File Offset: 0x009E7F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_performanceIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_performanceIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA60 RID: 125536 RVA: 0x009E9D98 File Offset: 0x009E7F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_performanceIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			int performanceIndex;
			LuaObject.checkType(l, 2, out performanceIndex);
			heroCharUIController.m_luaExportHelper.m_performanceIndex = performanceIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA61 RID: 125537 RVA: 0x009E9DF4 File Offset: 0x009E7FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPerformanceId(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_heroPerformanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA62 RID: 125538 RVA: 0x009E9E4C File Offset: 0x009E804C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroPerformanceId(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			int heroPerformanceId;
			LuaObject.checkType(l, 2, out heroPerformanceId);
			heroCharUIController.m_luaExportHelper.m_heroPerformanceId = heroPerformanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA63 RID: 125539 RVA: 0x009E9EA8 File Offset: 0x009E80A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroPerformanceInfoList(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroCharUIController.LuaExportHelper.HeroPerformanceInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA64 RID: 125540 RVA: 0x009E9EF0 File Offset: 0x009E80F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroPerformanceInfoList(IntPtr l)
	{
		int result;
		try
		{
			List<ConfigDataHeroPerformanceInfo> heroPerformanceInfoList;
			LuaObject.checkType<List<ConfigDataHeroPerformanceInfo>>(l, 2, out heroPerformanceInfoList);
			HeroCharUIController.LuaExportHelper.HeroPerformanceInfoList = heroPerformanceInfoList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA65 RID: 125541 RVA: 0x009E9F3C File Offset: 0x009E813C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroCharSkinId(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_heroCharSkinId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA66 RID: 125542 RVA: 0x009E9F94 File Offset: 0x009E8194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharSkinId(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			int heroCharSkinId;
			LuaObject.checkType(l, 2, out heroCharSkinId);
			heroCharUIController.m_luaExportHelper.m_heroCharSkinId = heroCharSkinId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA67 RID: 125543 RVA: 0x009E9FF0 File Offset: 0x009E81F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_charImageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA68 RID: 125544 RVA: 0x009EA048 File Offset: 0x009E8248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			heroCharUIController.m_luaExportHelper.m_charImageInfo = charImageInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA69 RID: 125545 RVA: 0x009EA0A4 File Offset: 0x009E82A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_canClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_canClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA6A RID: 125546 RVA: 0x009EA0FC File Offset: 0x009E82FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_canClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			bool canClick;
			LuaObject.checkType(l, 2, out canClick);
			heroCharUIController.m_luaExportHelper.m_canClick = canClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA6B RID: 125547 RVA: 0x009EA158 File Offset: 0x009E8358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAnimationPlayed(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_isAnimationPlayed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA6C RID: 125548 RVA: 0x009EA1B0 File Offset: 0x009E83B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAnimationPlayed(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			bool isAnimationPlayed;
			LuaObject.checkType(l, 2, out isAnimationPlayed);
			heroCharUIController.m_luaExportHelper.m_isAnimationPlayed = isAnimationPlayed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA6D RID: 125549 RVA: 0x009EA20C File Offset: 0x009E840C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA6E RID: 125550 RVA: 0x009EA264 File Offset: 0x009E8464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroCharUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA6F RID: 125551 RVA: 0x009EA2C0 File Offset: 0x009E84C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curState(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)heroCharUIController.m_luaExportHelper.m_curState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA70 RID: 125552 RVA: 0x009EA318 File Offset: 0x009E8518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curState(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			HeroCharUIController.PerformanceState curState;
			LuaObject.checkEnum<HeroCharUIController.PerformanceState>(l, 2, out curState);
			heroCharUIController.m_luaExportHelper.m_curState = curState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA71 RID: 125553 RVA: 0x009EA374 File Offset: 0x009E8574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_audioPlayback(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_audioPlayback);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA72 RID: 125554 RVA: 0x009EA3CC File Offset: 0x009E85CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_audioPlayback(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			IAudioPlayback audioPlayback;
			LuaObject.checkType<IAudioPlayback>(l, 2, out audioPlayback);
			heroCharUIController.m_luaExportHelper.m_audioPlayback = audioPlayback;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA73 RID: 125555 RVA: 0x009EA428 File Offset: 0x009E8628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCharUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA74 RID: 125556 RVA: 0x009EA480 File Offset: 0x009E8680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroCharUIController heroCharUIController = (HeroCharUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroCharUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA75 RID: 125557 RVA: 0x009EA4DC File Offset: 0x009E86DC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroCharUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.CreateGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.GetCharImageInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.GetHeroCharSkinId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.DestroyGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.PlayVoice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.ShowWords);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.SetSpineColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.SetCanClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.PlayOneRandomPerformance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.PlayOneSpecifiedPerformance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.CloseWordPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.IsClickInCharRoot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.CanPlayRandomHeroPerformancesIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.GetPerformanceIdByState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache21);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache22, true);
		string name2 = "m_charRoot";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_charRoot);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_charRoot);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache24, true);
		string name3 = "m_root";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_root);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_root);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache26, true);
		string name4 = "m_wordGo";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_wordGo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_wordGo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache28, true);
		string name5 = "m_text";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_text);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_text);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2A, true);
		string name6 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_image);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_image);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2C, true);
		string name7 = "m_spineGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_spineGraphic);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_spineGraphic);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2E, true);
		string name8 = "m_performanceIndex";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_performanceIndex);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_performanceIndex);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache30, true);
		string name9 = "m_heroPerformanceId";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_heroPerformanceId);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_heroPerformanceId);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache32, true);
		string name10 = "HeroPerformanceInfoList";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_HeroPerformanceInfoList);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_HeroPerformanceInfoList);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache34, false);
		string name11 = "m_heroCharSkinId";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_heroCharSkinId);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_heroCharSkinId);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache36, true);
		string name12 = "m_charImageInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_charImageInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_charImageInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache38, true);
		string name13 = "m_canClick";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_canClick);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_canClick);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3A, true);
		string name14 = "m_isAnimationPlayed";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_isAnimationPlayed);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_isAnimationPlayed);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3C, true);
		string name15 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_configDataLoader);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3E, true);
		string name16 = "m_curState";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_curState);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_curState);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache40, true);
		string name17 = "m_audioPlayback";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_audioPlayback);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_audioPlayback);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache42, true);
		string name18 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.get_m_hero);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCharUIController.set_m_hero);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroCharUIController.<>f__mg$cache44, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroCharUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014AC2 RID: 84674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014AC3 RID: 84675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014AC4 RID: 84676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014AC5 RID: 84677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014AC6 RID: 84678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014AC7 RID: 84679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014AC8 RID: 84680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014AC9 RID: 84681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014ACA RID: 84682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014ACB RID: 84683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014ACC RID: 84684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014ACD RID: 84685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014ACE RID: 84686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014ACF RID: 84687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014AD0 RID: 84688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014AD1 RID: 84689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014AD2 RID: 84690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014AD3 RID: 84691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014AD4 RID: 84692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014AD5 RID: 84693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014AD6 RID: 84694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014AD7 RID: 84695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014AD8 RID: 84696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014AD9 RID: 84697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014ADA RID: 84698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014ADB RID: 84699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014ADC RID: 84700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014ADD RID: 84701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014ADE RID: 84702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014ADF RID: 84703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014AE0 RID: 84704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014AE1 RID: 84705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014AE2 RID: 84706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014AE3 RID: 84707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014AE4 RID: 84708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014AE5 RID: 84709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014AE6 RID: 84710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014AE7 RID: 84711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014AE8 RID: 84712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014AE9 RID: 84713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014AEA RID: 84714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014AEB RID: 84715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014AEC RID: 84716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014AED RID: 84717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014AEE RID: 84718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014AEF RID: 84719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014AF0 RID: 84720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014AF1 RID: 84721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014AF2 RID: 84722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014AF3 RID: 84723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014AF4 RID: 84724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014AF5 RID: 84725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014AF6 RID: 84726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014AF7 RID: 84727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014AF8 RID: 84728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014AF9 RID: 84729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014AFA RID: 84730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014AFB RID: 84731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014AFC RID: 84732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014AFD RID: 84733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014AFE RID: 84734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04014AFF RID: 84735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04014B00 RID: 84736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04014B01 RID: 84737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014B02 RID: 84738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014B03 RID: 84739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014B04 RID: 84740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014B05 RID: 84741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014B06 RID: 84742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;
}
