using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014BF RID: 5311
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDungeonUIController : LuaObject
{
	// Token: 0x0601F068 RID: 127080 RVA: 0x00A1A738 File Offset: 0x00A18938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F069 RID: 127081 RVA: 0x00A1A784 File Offset: 0x00A18984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroDungeonLevelListItem(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out levelInfo);
			heroDungeonUIController.AddHeroDungeonLevelListItem(levelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F06A RID: 127082 RVA: 0x00A1A7DC File Offset: 0x00A189DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearHeroDungeonLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.ClearHeroDungeonLevelListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F06B RID: 127083 RVA: 0x00A1A828 File Offset: 0x00A18A28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateDungeonLevelListItem(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			heroDungeonUIController.UpdateDungeonLevelListItem(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F06C RID: 127084 RVA: 0x00A1A880 File Offset: 0x00A18A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurrentDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo currentDungeonLevel;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out currentDungeonLevel);
			heroDungeonUIController.SetCurrentDungeonLevel(currentDungeonLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F06D RID: 127085 RVA: 0x00A1A8D8 File Offset: 0x00A18AD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeroChar(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			int heroChar;
			LuaObject.checkType(l, 2, out heroChar);
			heroDungeonUIController.SetHeroChar(heroChar);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F06E RID: 127086 RVA: 0x00A1A930 File Offset: 0x00A18B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDungeonStarsProgress(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			ConfigDataHeroInformationInfo dungeonStarsProgress;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 2, out dungeonStarsProgress);
			heroDungeonUIController.SetDungeonStarsProgress(dungeonStarsProgress);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F06F RID: 127087 RVA: 0x00A1A988 File Offset: 0x00A18B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChallengeCountValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			int challengeCountValueText;
			LuaObject.checkType(l, 2, out challengeCountValueText);
			heroDungeonUIController.SetChallengeCountValueText(challengeCountValueText);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F070 RID: 127088 RVA: 0x00A1A9E0 File Offset: 0x00A18BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F071 RID: 127089 RVA: 0x00A1AA34 File Offset: 0x00A18C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LateUpdate(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.LateUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F072 RID: 127090 RVA: 0x00A1AA88 File Offset: 0x00A18C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLineOnEllipseIntersection(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			double x;
			LuaObject.checkType(l, 2, out x);
			double x2;
			LuaObject.checkType(l, 3, out x2);
			double y;
			LuaObject.checkType(l, 4, out y);
			double y2;
			LuaObject.checkType(l, 5, out y2);
			double midX;
			LuaObject.checkType(l, 6, out midX);
			double midY;
			LuaObject.checkType(l, 7, out midY);
			double h;
			LuaObject.checkType(l, 8, out h);
			double v;
			LuaObject.checkType(l, 9, out v);
			List<Vector2> lineOnEllipseIntersection = heroDungeonUIController.m_luaExportHelper.GetLineOnEllipseIntersection(x, x2, y, y2, midX, midY, h, v);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineOnEllipseIntersection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F073 RID: 127091 RVA: 0x00A1AB48 File Offset: 0x00A18D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int isPointInLine(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			double x;
			LuaObject.checkType(l, 2, out x);
			double x2;
			LuaObject.checkType(l, 3, out x2);
			double y;
			LuaObject.checkType(l, 4, out y);
			double y2;
			LuaObject.checkType(l, 5, out y2);
			double px;
			LuaObject.checkType(l, 6, out px);
			double py;
			LuaObject.checkType(l, 7, out py);
			bool b = heroDungeonUIController.m_luaExportHelper.isPointInLine(x, x2, y, y2, px, py);
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

	// Token: 0x0601F074 RID: 127092 RVA: 0x00A1ABF0 File Offset: 0x00A18DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLineLineIntersection(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Vector2 p;
			LuaObject.checkType(l, 2, out p);
			Vector2 p2;
			LuaObject.checkType(l, 3, out p2);
			Vector2 p3;
			LuaObject.checkType(l, 4, out p3);
			Vector2 p4;
			LuaObject.checkType(l, 5, out p4);
			Vector2 lineLineIntersection = heroDungeonUIController.m_luaExportHelper.GetLineLineIntersection(p, p2, p3, p4);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lineLineIntersection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F075 RID: 127093 RVA: 0x00A1AC80 File Offset: 0x00A18E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCircleRotation(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			float circleRotation;
			LuaObject.checkType(l, 2, out circleRotation);
			heroDungeonUIController.m_luaExportHelper.SetCircleRotation(circleRotation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F076 RID: 127094 RVA: 0x00A1ACDC File Offset: 0x00A18EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStarRewardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			GainRewardButton b;
			LuaObject.checkType<GainRewardButton>(l, 2, out b);
			heroDungeonUIController.m_luaExportHelper.OnStarRewardButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F077 RID: 127095 RVA: 0x00A1AD38 File Offset: 0x00A18F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddStarRewardPreviewGoods(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			ConfigDataHeroInformationInfo heroDungeonInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 2, out heroDungeonInfo);
			int idx;
			LuaObject.checkType(l, 3, out idx);
			heroDungeonUIController.m_luaExportHelper.AddStarRewardPreviewGoods(heroDungeonInfo, idx);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F078 RID: 127096 RVA: 0x00A1ADA4 File Offset: 0x00A18FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F079 RID: 127097 RVA: 0x00A1ADF8 File Offset: 0x00A18FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F07A RID: 127098 RVA: 0x00A1AE4C File Offset: 0x00A1904C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroDungeonLevelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			HeroDungeonLevelListItemUIController b;
			LuaObject.checkType<HeroDungeonLevelListItemUIController>(l, 2, out b);
			heroDungeonUIController.m_luaExportHelper.OnHeroDungeonLevelButtonClick(b);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F07B RID: 127099 RVA: 0x00A1AEA8 File Offset: 0x00A190A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStarRewardPreviewBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.OnStarRewardPreviewBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F07C RID: 127100 RVA: 0x00A1AEFC File Offset: 0x00A190FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroDungeonUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F07D RID: 127101 RVA: 0x00A1AF68 File Offset: 0x00A19168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F07E RID: 127102 RVA: 0x00A1AFBC File Offset: 0x00A191BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F07F RID: 127103 RVA: 0x00A1B010 File Offset: 0x00A19210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroDungeonUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F080 RID: 127104 RVA: 0x00A1B0B8 File Offset: 0x00A192B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F081 RID: 127105 RVA: 0x00A1B10C File Offset: 0x00A1930C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroDungeonUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F082 RID: 127106 RVA: 0x00A1B178 File Offset: 0x00A19378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroDungeonUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroDungeonUIController heroDungeonUIController2 = (HeroDungeonUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroDungeonUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F083 RID: 127107 RVA: 0x00A1B288 File Offset: 0x00A19488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDungeonUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F084 RID: 127108 RVA: 0x00A1B2F4 File Offset: 0x00A194F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDungeonUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F085 RID: 127109 RVA: 0x00A1B360 File Offset: 0x00A19560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDungeonUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F086 RID: 127110 RVA: 0x00A1B3CC File Offset: 0x00A195CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDungeonUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F087 RID: 127111 RVA: 0x00A1B438 File Offset: 0x00A19638
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
				HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroDungeonUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDungeonUIController heroDungeonUIController2 = (HeroDungeonUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroDungeonUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F088 RID: 127112 RVA: 0x00A1B548 File Offset: 0x00A19748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			string s = heroDungeonUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F089 RID: 127113 RVA: 0x00A1B5A4 File Offset: 0x00A197A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F08A RID: 127114 RVA: 0x00A1B5F8 File Offset: 0x00A197F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F08B RID: 127115 RVA: 0x00A1B64C File Offset: 0x00A1984C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.__callDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F08C RID: 127116 RVA: 0x00A1B6A0 File Offset: 0x00A198A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			heroDungeonUIController.m_luaExportHelper.__clearDele_EventOnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F08D RID: 127117 RVA: 0x00A1B6F4 File Offset: 0x00A198F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetStarReward(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroDungeonUIController.m_luaExportHelper.__callDele_EventOnGetStarReward(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F08E RID: 127118 RVA: 0x00A1B750 File Offset: 0x00A19950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetStarReward(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroDungeonUIController.m_luaExportHelper.__clearDele_EventOnGetStarReward(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F08F RID: 127119 RVA: 0x00A1B7AC File Offset: 0x00A199AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo obj;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out obj);
			heroDungeonUIController.m_luaExportHelper.__callDele_EventOnSelectDungeonLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F090 RID: 127120 RVA: 0x00A1B808 File Offset: 0x00A19A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			ConfigDataHeroDungeonLevelInfo obj;
			LuaObject.checkType<ConfigDataHeroDungeonLevelInfo>(l, 2, out obj);
			heroDungeonUIController.m_luaExportHelper.__clearDele_EventOnSelectDungeonLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F091 RID: 127121 RVA: 0x00A1B864 File Offset: 0x00A19A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDungeonUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroDungeonUIController.EventOnReturn -= value;
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

	// Token: 0x0601F092 RID: 127122 RVA: 0x00A1B8E4 File Offset: 0x00A19AE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDungeonUIController.EventOnShowHelp += value;
				}
				else if (num == 2)
				{
					heroDungeonUIController.EventOnShowHelp -= value;
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

	// Token: 0x0601F093 RID: 127123 RVA: 0x00A1B964 File Offset: 0x00A19B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetStarReward(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDungeonUIController.EventOnGetStarReward += value;
				}
				else if (num == 2)
				{
					heroDungeonUIController.EventOnGetStarReward -= value;
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

	// Token: 0x0601F094 RID: 127124 RVA: 0x00A1B9E4 File Offset: 0x00A19BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectDungeonLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Action<ConfigDataHeroDungeonLevelInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataHeroDungeonLevelInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDungeonUIController.EventOnSelectDungeonLevel += value;
				}
				else if (num == 2)
				{
					heroDungeonUIController.EventOnSelectDungeonLevel -= value;
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

	// Token: 0x0601F095 RID: 127125 RVA: 0x00A1BA64 File Offset: 0x00A19C64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F096 RID: 127126 RVA: 0x00A1BABC File Offset: 0x00A19CBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			heroDungeonUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F097 RID: 127127 RVA: 0x00A1BB18 File Offset: 0x00A19D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F098 RID: 127128 RVA: 0x00A1BB70 File Offset: 0x00A19D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			heroDungeonUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F099 RID: 127129 RVA: 0x00A1BBCC File Offset: 0x00A19DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGameObjectRoot(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_charGameObjectRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F09A RID: 127130 RVA: 0x00A1BC24 File Offset: 0x00A19E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGameObjectRoot(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			GameObject charGameObjectRoot;
			LuaObject.checkType<GameObject>(l, 2, out charGameObjectRoot);
			heroDungeonUIController.m_luaExportHelper.m_charGameObjectRoot = charGameObjectRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F09B RID: 127131 RVA: 0x00A1BC80 File Offset: 0x00A19E80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelsScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_levelsScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F09C RID: 127132 RVA: 0x00A1BCD8 File Offset: 0x00A19ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelsScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			ScrollRect levelsScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out levelsScrollRect);
			heroDungeonUIController.m_luaExportHelper.m_levelsScrollRect = levelsScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F09D RID: 127133 RVA: 0x00A1BD34 File Offset: 0x00A19F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_challengeCountValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_challengeCountValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F09E RID: 127134 RVA: 0x00A1BD8C File Offset: 0x00A19F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_challengeCountValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Text challengeCountValueText;
			LuaObject.checkType<Text>(l, 2, out challengeCountValueText);
			heroDungeonUIController.m_luaExportHelper.m_challengeCountValueText = challengeCountValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F09F RID: 127135 RVA: 0x00A1BDE8 File Offset: 0x00A19FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_progressGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0A0 RID: 127136 RVA: 0x00A1BE40 File Offset: 0x00A1A040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			GameObject progressGameObject;
			LuaObject.checkType<GameObject>(l, 2, out progressGameObject);
			heroDungeonUIController.m_luaExportHelper.m_progressGameObject = progressGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0A1 RID: 127137 RVA: 0x00A1BE9C File Offset: 0x00A1A09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_progressText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0A2 RID: 127138 RVA: 0x00A1BEF4 File Offset: 0x00A1A0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressText(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Text progressText;
			LuaObject.checkType<Text>(l, 2, out progressText);
			heroDungeonUIController.m_luaExportHelper.m_progressText = progressText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0A3 RID: 127139 RVA: 0x00A1BF50 File Offset: 0x00A1A150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_progressImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0A4 RID: 127140 RVA: 0x00A1BFA8 File Offset: 0x00A1A1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Image progressImage;
			LuaObject.checkType<Image>(l, 2, out progressImage);
			heroDungeonUIController.m_luaExportHelper.m_progressImage = progressImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0A5 RID: 127141 RVA: 0x00A1C004 File Offset: 0x00A1A204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_starRewardButton1GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_starRewardButton1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0A6 RID: 127142 RVA: 0x00A1C05C File Offset: 0x00A1A25C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardButton1GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			GameObject starRewardButton1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out starRewardButton1GameObject);
			heroDungeonUIController.m_luaExportHelper.m_starRewardButton1GameObject = starRewardButton1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0A7 RID: 127143 RVA: 0x00A1C0B8 File Offset: 0x00A1A2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardButton2GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_starRewardButton2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0A8 RID: 127144 RVA: 0x00A1C110 File Offset: 0x00A1A310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardButton2GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			GameObject starRewardButton2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out starRewardButton2GameObject);
			heroDungeonUIController.m_luaExportHelper.m_starRewardButton2GameObject = starRewardButton2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0A9 RID: 127145 RVA: 0x00A1C16C File Offset: 0x00A1A36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardButton3GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_starRewardButton3GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0AA RID: 127146 RVA: 0x00A1C1C4 File Offset: 0x00A1A3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardButton3GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			GameObject starRewardButton3GameObject;
			LuaObject.checkType<GameObject>(l, 2, out starRewardButton3GameObject);
			heroDungeonUIController.m_luaExportHelper.m_starRewardButton3GameObject = starRewardButton3GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0AB RID: 127147 RVA: 0x00A1C220 File Offset: 0x00A1A420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardPreviewUIStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_starRewardPreviewUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0AC RID: 127148 RVA: 0x00A1C278 File Offset: 0x00A1A478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardPreviewUIStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			CommonUIStateController starRewardPreviewUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out starRewardPreviewUIStateController);
			heroDungeonUIController.m_luaExportHelper.m_starRewardPreviewUIStateController = starRewardPreviewUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0AD RID: 127149 RVA: 0x00A1C2D4 File Offset: 0x00A1A4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardPreviewBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_starRewardPreviewBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0AE RID: 127150 RVA: 0x00A1C32C File Offset: 0x00A1A52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardPreviewBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Button starRewardPreviewBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out starRewardPreviewBackgroundButton);
			heroDungeonUIController.m_luaExportHelper.m_starRewardPreviewBackgroundButton = starRewardPreviewBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0AF RID: 127151 RVA: 0x00A1C388 File Offset: 0x00A1A588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardPreviewScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_starRewardPreviewScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0B0 RID: 127152 RVA: 0x00A1C3E0 File Offset: 0x00A1A5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardPreviewScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			ScrollRect starRewardPreviewScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out starRewardPreviewScrollRect);
			heroDungeonUIController.m_luaExportHelper.m_starRewardPreviewScrollRect = starRewardPreviewScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0B1 RID: 127153 RVA: 0x00A1C43C File Offset: 0x00A1A63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_circle1GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_circle1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0B2 RID: 127154 RVA: 0x00A1C494 File Offset: 0x00A1A694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_circle1GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			GameObject circle1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out circle1GameObject);
			heroDungeonUIController.m_luaExportHelper.m_circle1GameObject = circle1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0B3 RID: 127155 RVA: 0x00A1C4F0 File Offset: 0x00A1A6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_circle2GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_circle2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0B4 RID: 127156 RVA: 0x00A1C548 File Offset: 0x00A1A748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_circle2GameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			GameObject circle2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out circle2GameObject);
			heroDungeonUIController.m_luaExportHelper.m_circle2GameObject = circle2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0B5 RID: 127157 RVA: 0x00A1C5A4 File Offset: 0x00A1A7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_prefabGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0B6 RID: 127158 RVA: 0x00A1C5FC File Offset: 0x00A1A7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			GameObject prefabGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabGameObject);
			heroDungeonUIController.m_luaExportHelper.m_prefabGameObject = prefabGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0B7 RID: 127159 RVA: 0x00A1C658 File Offset: 0x00A1A858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDungeonLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_heroDungeonLevelListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0B8 RID: 127160 RVA: 0x00A1C6B0 File Offset: 0x00A1A8B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroDungeonLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			GameObject heroDungeonLevelListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroDungeonLevelListItemPrefab);
			heroDungeonUIController.m_luaExportHelper.m_heroDungeonLevelListItemPrefab = heroDungeonLevelListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0B9 RID: 127161 RVA: 0x00A1C70C File Offset: 0x00A1A90C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_ellipseImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_ellipseImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0BA RID: 127162 RVA: 0x00A1C764 File Offset: 0x00A1A964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ellipseImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			Image ellipseImage;
			LuaObject.checkType<Image>(l, 2, out ellipseImage);
			heroDungeonUIController.m_luaExportHelper.m_ellipseImage = ellipseImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0BB RID: 127163 RVA: 0x00A1C7C0 File Offset: 0x00A1A9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDungeonLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_heroDungeonLevelListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0BC RID: 127164 RVA: 0x00A1C818 File Offset: 0x00A1AA18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroDungeonLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			List<HeroDungeonLevelListItemUIController> heroDungeonLevelListItems;
			LuaObject.checkType<List<HeroDungeonLevelListItemUIController>>(l, 2, out heroDungeonLevelListItems);
			heroDungeonUIController.m_luaExportHelper.m_heroDungeonLevelListItems = heroDungeonLevelListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0BD RID: 127165 RVA: 0x00A1C874 File Offset: 0x00A1AA74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gearRollThreasholdValue(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroDungeonUIController.LuaExportHelper.gearRollThreasholdValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0BE RID: 127166 RVA: 0x00A1C8BC File Offset: 0x00A1AABC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rotationCount(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_rotationCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0BF RID: 127167 RVA: 0x00A1C914 File Offset: 0x00A1AB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rotationCount(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			float rotationCount;
			LuaObject.checkType(l, 2, out rotationCount);
			heroDungeonUIController.m_luaExportHelper.m_rotationCount = rotationCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0C0 RID: 127168 RVA: 0x00A1C970 File Offset: 0x00A1AB70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_curLevelIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_curLevelIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0C1 RID: 127169 RVA: 0x00A1C9C8 File Offset: 0x00A1ABC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curLevelIndex(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			int curLevelIndex;
			LuaObject.checkType(l, 2, out curLevelIndex);
			heroDungeonUIController.m_luaExportHelper.m_curLevelIndex = curLevelIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0C2 RID: 127170 RVA: 0x00A1CA24 File Offset: 0x00A1AC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dy2(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.dy2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0C3 RID: 127171 RVA: 0x00A1CA7C File Offset: 0x00A1AC7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_dy2(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			float dy;
			LuaObject.checkType(l, 2, out dy);
			heroDungeonUIController.m_luaExportHelper.dy2 = dy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0C4 RID: 127172 RVA: 0x00A1CAD8 File Offset: 0x00A1ACD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starRewardButtons(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_starRewardButtons);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0C5 RID: 127173 RVA: 0x00A1CB30 File Offset: 0x00A1AD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starRewardButtons(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			GainRewardButton[] starRewardButtons;
			LuaObject.checkArray<GainRewardButton>(l, 2, out starRewardButtons);
			heroDungeonUIController.m_luaExportHelper.m_starRewardButtons = starRewardButtons;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0C6 RID: 127174 RVA: 0x00A1CB8C File Offset: 0x00A1AD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0C7 RID: 127175 RVA: 0x00A1CBE4 File Offset: 0x00A1ADE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			heroDungeonUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0C8 RID: 127176 RVA: 0x00A1CC40 File Offset: 0x00A1AE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDungeonInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_heroDungeonInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0C9 RID: 127177 RVA: 0x00A1CC98 File Offset: 0x00A1AE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDungeonInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			ConfigDataHeroInformationInfo heroDungeonInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 2, out heroDungeonInfo);
			heroDungeonUIController.m_luaExportHelper.m_heroDungeonInfo = heroDungeonInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0CA RID: 127178 RVA: 0x00A1CCF4 File Offset: 0x00A1AEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelsScrollViewVerticalSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_levelsScrollViewVerticalSnapCenter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0CB RID: 127179 RVA: 0x00A1CD4C File Offset: 0x00A1AF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelsScrollViewVerticalSnapCenter(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			ScrollSnapCenter levelsScrollViewVerticalSnapCenter;
			LuaObject.checkType<ScrollSnapCenter>(l, 2, out levelsScrollViewVerticalSnapCenter);
			heroDungeonUIController.m_luaExportHelper.m_levelsScrollViewVerticalSnapCenter = levelsScrollViewVerticalSnapCenter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0CC RID: 127180 RVA: 0x00A1CDA8 File Offset: 0x00A1AFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0CD RID: 127181 RVA: 0x00A1CE00 File Offset: 0x00A1B000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDungeonUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0CE RID: 127182 RVA: 0x00A1CE5C File Offset: 0x00A1B05C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0CF RID: 127183 RVA: 0x00A1CEB4 File Offset: 0x00A1B0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonUIController heroDungeonUIController = (HeroDungeonUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroDungeonUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F0D0 RID: 127184 RVA: 0x00A1CF10 File Offset: 0x00A1B110
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDungeonUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.AddHeroDungeonLevelListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.ClearHeroDungeonLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.UpdateDungeonLevelListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.SetCurrentDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.SetHeroChar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.SetDungeonStarsProgress);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.SetChallengeCountValueText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.LateUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.GetLineOnEllipseIntersection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.isPointInLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.GetLineLineIntersection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.SetCircleRotation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.OnStarRewardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.AddStarRewardPreviewGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.OnHeroDungeonLevelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.OnStarRewardPreviewBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__clearDele_EventOnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callDele_EventOnGetStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__clearDele_EventOnGetStarReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__callDele_EventOnSelectDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.__clearDele_EventOnSelectDungeonLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache28);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache29, true);
		string name2 = "EventOnShowHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_EventOnShowHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2A, true);
		string name3 = "EventOnGetStarReward";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_EventOnGetStarReward);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2B, true);
		string name4 = "EventOnSelectDungeonLevel";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_EventOnSelectDungeonLevel);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2C, true);
		string name5 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_returnButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2E, true);
		string name6 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_helpButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache30, true);
		string name7 = "m_charGameObjectRoot";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_charGameObjectRoot);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_charGameObjectRoot);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache32, true);
		string name8 = "m_levelsScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_levelsScrollRect);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_levelsScrollRect);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache34, true);
		string name9 = "m_challengeCountValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_challengeCountValueText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_challengeCountValueText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache36, true);
		string name10 = "m_progressGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_progressGameObject);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_progressGameObject);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache38, true);
		string name11 = "m_progressText";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_progressText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_progressText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3A, true);
		string name12 = "m_progressImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_progressImage);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_progressImage);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3C, true);
		string name13 = "m_starRewardButton1GameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_starRewardButton1GameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_starRewardButton1GameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3E, true);
		string name14 = "m_starRewardButton2GameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_starRewardButton2GameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_starRewardButton2GameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache40, true);
		string name15 = "m_starRewardButton3GameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_starRewardButton3GameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_starRewardButton3GameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache42, true);
		string name16 = "m_starRewardPreviewUIStateController";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_starRewardPreviewUIStateController);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_starRewardPreviewUIStateController);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache44, true);
		string name17 = "m_starRewardPreviewBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_starRewardPreviewBackgroundButton);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_starRewardPreviewBackgroundButton);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache46, true);
		string name18 = "m_starRewardPreviewScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_starRewardPreviewScrollRect);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_starRewardPreviewScrollRect);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache48, true);
		string name19 = "m_circle1GameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_circle1GameObject);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_circle1GameObject);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4A, true);
		string name20 = "m_circle2GameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_circle2GameObject);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_circle2GameObject);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4C, true);
		string name21 = "m_prefabGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_prefabGameObject);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_prefabGameObject);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4E, true);
		string name22 = "m_heroDungeonLevelListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_heroDungeonLevelListItemPrefab);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_heroDungeonLevelListItemPrefab);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache50, true);
		string name23 = "m_ellipseImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_ellipseImage);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_ellipseImage);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache52, true);
		string name24 = "m_heroDungeonLevelListItems";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_heroDungeonLevelListItems);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_heroDungeonLevelListItems);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache54, true);
		string name25 = "gearRollThreasholdValue";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_gearRollThreasholdValue);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache55, null, false);
		string name26 = "m_rotationCount";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_rotationCount);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_rotationCount);
		}
		LuaObject.addMember(l, name26, get25, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache57, true);
		string name27 = "m_curLevelIndex";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_curLevelIndex);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_curLevelIndex);
		}
		LuaObject.addMember(l, name27, get26, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache59, true);
		string name28 = "dy2";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_dy2);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_dy2);
		}
		LuaObject.addMember(l, name28, get27, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5B, true);
		string name29 = "m_starRewardButtons";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_starRewardButtons);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_starRewardButtons);
		}
		LuaObject.addMember(l, name29, get28, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5D, true);
		string name30 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name30, get29, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache5F, true);
		string name31 = "m_heroDungeonInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_heroDungeonInfo);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_heroDungeonInfo);
		}
		LuaObject.addMember(l, name31, get30, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache61, true);
		string name32 = "m_levelsScrollViewVerticalSnapCenter";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_levelsScrollViewVerticalSnapCenter);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_levelsScrollViewVerticalSnapCenter);
		}
		LuaObject.addMember(l, name32, get31, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache63, true);
		string name33 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_configDataLoader);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name33, get32, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache65, true);
		string name34 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.get_m_playerContext);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name34, get33, Lua_BlackJack_ProjectL_UI_HeroDungeonUIController.<>f__mg$cache67, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroDungeonUIController), typeof(UIControllerBase));
	}

	// Token: 0x040150CC RID: 86220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040150CD RID: 86221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040150CE RID: 86222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040150CF RID: 86223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040150D0 RID: 86224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040150D1 RID: 86225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040150D2 RID: 86226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040150D3 RID: 86227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040150D4 RID: 86228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040150D5 RID: 86229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040150D6 RID: 86230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040150D7 RID: 86231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040150D8 RID: 86232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040150D9 RID: 86233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040150DA RID: 86234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040150DB RID: 86235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040150DC RID: 86236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040150DD RID: 86237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040150DE RID: 86238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040150DF RID: 86239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040150E0 RID: 86240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040150E1 RID: 86241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040150E2 RID: 86242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040150E3 RID: 86243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040150E4 RID: 86244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040150E5 RID: 86245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040150E6 RID: 86246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040150E7 RID: 86247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040150E8 RID: 86248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040150E9 RID: 86249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040150EA RID: 86250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040150EB RID: 86251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040150EC RID: 86252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040150ED RID: 86253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040150EE RID: 86254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040150EF RID: 86255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040150F0 RID: 86256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040150F1 RID: 86257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040150F2 RID: 86258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040150F3 RID: 86259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040150F4 RID: 86260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040150F5 RID: 86261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040150F6 RID: 86262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040150F7 RID: 86263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040150F8 RID: 86264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040150F9 RID: 86265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040150FA RID: 86266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040150FB RID: 86267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040150FC RID: 86268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040150FD RID: 86269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040150FE RID: 86270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040150FF RID: 86271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015100 RID: 86272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015101 RID: 86273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015102 RID: 86274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015103 RID: 86275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015104 RID: 86276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015105 RID: 86277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015106 RID: 86278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015107 RID: 86279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015108 RID: 86280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04015109 RID: 86281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401510A RID: 86282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401510B RID: 86283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401510C RID: 86284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401510D RID: 86285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401510E RID: 86286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401510F RID: 86287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04015110 RID: 86288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04015111 RID: 86289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04015112 RID: 86290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04015113 RID: 86291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04015114 RID: 86292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04015115 RID: 86293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04015116 RID: 86294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04015117 RID: 86295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04015118 RID: 86296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04015119 RID: 86297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401511A RID: 86298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0401511B RID: 86299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0401511C RID: 86300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0401511D RID: 86301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0401511E RID: 86302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401511F RID: 86303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04015120 RID: 86304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04015121 RID: 86305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04015122 RID: 86306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04015123 RID: 86307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04015124 RID: 86308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04015125 RID: 86309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04015126 RID: 86310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04015127 RID: 86311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04015128 RID: 86312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04015129 RID: 86313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401512A RID: 86314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0401512B RID: 86315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0401512C RID: 86316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0401512D RID: 86317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0401512E RID: 86318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0401512F RID: 86319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04015130 RID: 86320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04015131 RID: 86321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04015132 RID: 86322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04015133 RID: 86323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;
}
