using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014C8 RID: 5320
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController : LuaObject
{
	// Token: 0x0601F1F3 RID: 127475 RVA: 0x00A26EE0 File Offset: 0x00A250E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroJobCardItem(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 3, out jobConnectionInfo);
			int rank;
			LuaObject.checkType(l, 4, out rank);
			heroJobCardItemUIController.InitHeroJobCardItem(hero, jobConnectionInfo, rank);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1F4 RID: 127476 RVA: 0x00A26F54 File Offset: 0x00A25154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFrameImage(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			bool frameImage;
			LuaObject.checkType(l, 2, out frameImage);
			heroJobCardItemUIController.SetFrameImage(frameImage);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1F5 RID: 127477 RVA: 0x00A26FAC File Offset: 0x00A251AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsJobMaster(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			bool b = heroJobCardItemUIController.IsJobMaster();
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

	// Token: 0x0601F1F6 RID: 127478 RVA: 0x00A27000 File Offset: 0x00A25200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			heroJobCardItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1F7 RID: 127479 RVA: 0x00A27054 File Offset: 0x00A25254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInfoByState(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			heroJobCardItemUIController.m_luaExportHelper.SetInfoByState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1F8 RID: 127480 RVA: 0x00A270A8 File Offset: 0x00A252A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLight(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			bool b = heroJobCardItemUIController.m_luaExportHelper.IsLight();
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

	// Token: 0x0601F1F9 RID: 127481 RVA: 0x00A27104 File Offset: 0x00A25304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroJobCardItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			heroJobCardItemUIController.m_luaExportHelper.OnHeroJobCardItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1FA RID: 127482 RVA: 0x00A27158 File Offset: 0x00A25358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroJobCardItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1FB RID: 127483 RVA: 0x00A271C4 File Offset: 0x00A253C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			heroJobCardItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1FC RID: 127484 RVA: 0x00A27218 File Offset: 0x00A25418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			heroJobCardItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1FD RID: 127485 RVA: 0x00A2726C File Offset: 0x00A2546C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroJobCardItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F1FE RID: 127486 RVA: 0x00A27314 File Offset: 0x00A25514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			heroJobCardItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1FF RID: 127487 RVA: 0x00A27368 File Offset: 0x00A25568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroJobCardItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F200 RID: 127488 RVA: 0x00A273D4 File Offset: 0x00A255D4
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
				HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroJobCardItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroJobCardItemUIController heroJobCardItemUIController2 = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroJobCardItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F201 RID: 127489 RVA: 0x00A274E4 File Offset: 0x00A256E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobCardItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F202 RID: 127490 RVA: 0x00A27550 File Offset: 0x00A25750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobCardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F203 RID: 127491 RVA: 0x00A275BC File Offset: 0x00A257BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobCardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F204 RID: 127492 RVA: 0x00A27628 File Offset: 0x00A25828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobCardItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F205 RID: 127493 RVA: 0x00A27694 File Offset: 0x00A25894
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
				HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroJobCardItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroJobCardItemUIController heroJobCardItemUIController2 = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroJobCardItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F206 RID: 127494 RVA: 0x00A277A4 File Offset: 0x00A259A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			string s = heroJobCardItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F207 RID: 127495 RVA: 0x00A27800 File Offset: 0x00A25A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnJobCardItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			HeroJobCardItemUIController obj;
			LuaObject.checkType<HeroJobCardItemUIController>(l, 2, out obj);
			heroJobCardItemUIController.m_luaExportHelper.__callDele_EventOnJobCardItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F208 RID: 127496 RVA: 0x00A2785C File Offset: 0x00A25A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnJobCardItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			HeroJobCardItemUIController obj;
			LuaObject.checkType<HeroJobCardItemUIController>(l, 2, out obj);
			heroJobCardItemUIController.m_luaExportHelper.__clearDele_EventOnJobCardItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F209 RID: 127497 RVA: 0x00A278B8 File Offset: 0x00A25AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnJobCardItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			Action<HeroJobCardItemUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroJobCardItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroJobCardItemUIController.EventOnJobCardItemClick += value;
				}
				else if (num == 2)
				{
					heroJobCardItemUIController.EventOnJobCardItemClick -= value;
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

	// Token: 0x0601F20A RID: 127498 RVA: 0x00A27938 File Offset: 0x00A25B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_icon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.m_luaExportHelper.m_icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F20B RID: 127499 RVA: 0x00A27990 File Offset: 0x00A25B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_icon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			Image icon;
			LuaObject.checkType<Image>(l, 2, out icon);
			heroJobCardItemUIController.m_luaExportHelper.m_icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F20C RID: 127500 RVA: 0x00A279EC File Offset: 0x00A25BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curJobImg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.m_luaExportHelper.m_curJobImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F20D RID: 127501 RVA: 0x00A27A44 File Offset: 0x00A25C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curJobImg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			GameObject curJobImg;
			LuaObject.checkType<GameObject>(l, 2, out curJobImg);
			heroJobCardItemUIController.m_luaExportHelper.m_curJobImg = curJobImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F20E RID: 127502 RVA: 0x00A27AA0 File Offset: 0x00A25CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_magicStone(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.m_luaExportHelper.m_magicStone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F20F RID: 127503 RVA: 0x00A27AF8 File Offset: 0x00A25CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_magicStone(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			GameObject magicStone;
			LuaObject.checkType<GameObject>(l, 2, out magicStone);
			heroJobCardItemUIController.m_luaExportHelper.m_magicStone = magicStone;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F210 RID: 127504 RVA: 0x00A27B54 File Offset: 0x00A25D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockImg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.m_luaExportHelper.m_lockImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F211 RID: 127505 RVA: 0x00A27BAC File Offset: 0x00A25DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockImg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			GameObject lockImg;
			LuaObject.checkType<GameObject>(l, 2, out lockImg);
			heroJobCardItemUIController.m_luaExportHelper.m_lockImg = lockImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F212 RID: 127506 RVA: 0x00A27C08 File Offset: 0x00A25E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F213 RID: 127507 RVA: 0x00A27C60 File Offset: 0x00A25E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			heroJobCardItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F214 RID: 127508 RVA: 0x00A27CBC File Offset: 0x00A25EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frameImg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.m_luaExportHelper.m_frameImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F215 RID: 127509 RVA: 0x00A27D14 File Offset: 0x00A25F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameImg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			GameObject frameImg;
			LuaObject.checkType<GameObject>(l, 2, out frameImg);
			heroJobCardItemUIController.m_luaExportHelper.m_frameImg = frameImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F216 RID: 127510 RVA: 0x00A27D70 File Offset: 0x00A25F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.m_luaExportHelper.m_redIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F217 RID: 127511 RVA: 0x00A27DC8 File Offset: 0x00A25FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			GameObject redIcon;
			LuaObject.checkType<GameObject>(l, 2, out redIcon);
			heroJobCardItemUIController.m_luaExportHelper.m_redIcon = redIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F218 RID: 127512 RVA: 0x00A27E24 File Offset: 0x00A26024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_masterIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.m_luaExportHelper.m_masterIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F219 RID: 127513 RVA: 0x00A27E7C File Offset: 0x00A2607C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_masterIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			GameObject masterIcon;
			LuaObject.checkType<GameObject>(l, 2, out masterIcon);
			heroJobCardItemUIController.m_luaExportHelper.m_masterIcon = masterIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F21A RID: 127514 RVA: 0x00A27ED8 File Offset: 0x00A260D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F21B RID: 127515 RVA: 0x00A27F30 File Offset: 0x00A26130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroJobCardItemUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F21C RID: 127516 RVA: 0x00A27F8C File Offset: 0x00A2618C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rank(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.m_luaExportHelper.m_rank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F21D RID: 127517 RVA: 0x00A27FE4 File Offset: 0x00A261E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rank(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			int rank;
			LuaObject.checkType(l, 2, out rank);
			heroJobCardItemUIController.m_luaExportHelper.m_rank = rank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F21E RID: 127518 RVA: 0x00A28040 File Offset: 0x00A26240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.JobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F21F RID: 127519 RVA: 0x00A28094 File Offset: 0x00A26294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			heroJobCardItemUIController.m_luaExportHelper.JobConnectionInfo = jobConnectionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F220 RID: 127520 RVA: 0x00A280F0 File Offset: 0x00A262F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsNeedMagicStone(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.IsNeedMagicStone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F221 RID: 127521 RVA: 0x00A28144 File Offset: 0x00A26344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsNeedMagicStone(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			bool isNeedMagicStone;
			LuaObject.checkType(l, 2, out isNeedMagicStone);
			heroJobCardItemUIController.m_luaExportHelper.IsNeedMagicStone = isNeedMagicStone;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F222 RID: 127522 RVA: 0x00A281A0 File Offset: 0x00A263A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsJobLocked(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.IsJobLocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F223 RID: 127523 RVA: 0x00A281F4 File Offset: 0x00A263F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsJobLocked(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			bool isJobLocked;
			LuaObject.checkType(l, 2, out isJobLocked);
			heroJobCardItemUIController.m_luaExportHelper.IsJobLocked = isJobLocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F224 RID: 127524 RVA: 0x00A28250 File Offset: 0x00A26450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HaveRedIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobCardItemUIController.HaveRedIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F225 RID: 127525 RVA: 0x00A282A4 File Offset: 0x00A264A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HaveRedIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobCardItemUIController heroJobCardItemUIController = (HeroJobCardItemUIController)LuaObject.checkSelf(l);
			bool haveRedIcon;
			LuaObject.checkType(l, 2, out haveRedIcon);
			heroJobCardItemUIController.m_luaExportHelper.HaveRedIcon = haveRedIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F226 RID: 127526 RVA: 0x00A28300 File Offset: 0x00A26500
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroJobCardItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.InitHeroJobCardItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.SetFrameImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.IsJobMaster);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.SetInfoByState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.IsLight);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.OnHeroJobCardItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__callDele_EventOnJobCardItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.__clearDele_EventOnJobCardItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache15);
		string name = "EventOnJobCardItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_EventOnJobCardItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache16, true);
		string name2 = "m_icon";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_m_icon);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_m_icon);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache18, true);
		string name3 = "m_curJobImg";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_m_curJobImg);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_m_curJobImg);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1A, true);
		string name4 = "m_magicStone";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_m_magicStone);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_m_magicStone);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1C, true);
		string name5 = "m_lockImg";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_m_lockImg);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_m_lockImg);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1E, true);
		string name6 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_m_nameText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache20, true);
		string name7 = "m_frameImg";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_m_frameImg);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_m_frameImg);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache22, true);
		string name8 = "m_redIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_m_redIcon);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_m_redIcon);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache24, true);
		string name9 = "m_masterIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_m_masterIcon);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_m_masterIcon);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache26, true);
		string name10 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_m_hero);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_m_hero);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache28, true);
		string name11 = "m_rank";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_m_rank);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_m_rank);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2A, true);
		string name12 = "JobConnectionInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_JobConnectionInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_JobConnectionInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2C, true);
		string name13 = "IsNeedMagicStone";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_IsNeedMagicStone);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_IsNeedMagicStone);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2E, true);
		string name14 = "IsJobLocked";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_IsJobLocked);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_IsJobLocked);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache30, true);
		string name15 = "HaveRedIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.get_HaveRedIcon);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.set_HaveRedIcon);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroJobCardItemUIController.<>f__mg$cache32, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroJobCardItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015245 RID: 86597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015246 RID: 86598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015247 RID: 86599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015248 RID: 86600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015249 RID: 86601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401524A RID: 86602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401524B RID: 86603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401524C RID: 86604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401524D RID: 86605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401524E RID: 86606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401524F RID: 86607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015250 RID: 86608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015251 RID: 86609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015252 RID: 86610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015253 RID: 86611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015254 RID: 86612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015255 RID: 86613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015256 RID: 86614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015257 RID: 86615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015258 RID: 86616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015259 RID: 86617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401525A RID: 86618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401525B RID: 86619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401525C RID: 86620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401525D RID: 86621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401525E RID: 86622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401525F RID: 86623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015260 RID: 86624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015261 RID: 86625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015262 RID: 86626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015263 RID: 86627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015264 RID: 86628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015265 RID: 86629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015266 RID: 86630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015267 RID: 86631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015268 RID: 86632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015269 RID: 86633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401526A RID: 86634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401526B RID: 86635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401526C RID: 86636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401526D RID: 86637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401526E RID: 86638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401526F RID: 86639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015270 RID: 86640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015271 RID: 86641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015272 RID: 86642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015273 RID: 86643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015274 RID: 86644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015275 RID: 86645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015276 RID: 86646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015277 RID: 86647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;
}
