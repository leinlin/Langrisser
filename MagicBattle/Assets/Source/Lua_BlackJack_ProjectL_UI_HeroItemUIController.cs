using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014C7 RID: 5319
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroItemUIController : LuaObject
{
	// Token: 0x0601F1C1 RID: 127425 RVA: 0x00A25494 File Offset: 0x00A23694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitValuesInHeroItemUnlocked(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int heroLvText;
			LuaObject.checkType(l, 3, out heroLvText);
			int heroStarNum;
			LuaObject.checkType(l, 4, out heroStarNum);
			heroItemUIController.InitValuesInHeroItemUnlocked(hero, heroLvText, heroStarNum);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1C2 RID: 127426 RVA: 0x00A25508 File Offset: 0x00A23708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitValuesInHeroItemLocked(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int starNums;
			LuaObject.checkType(l, 3, out starNums);
			int collectCurNum;
			LuaObject.checkType(l, 4, out collectCurNum);
			int collectTotalNum;
			LuaObject.checkType(l, 5, out collectTotalNum);
			heroItemUIController.InitValuesInHeroItemLocked(hero, starNums, collectCurNum, collectTotalNum);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1C3 RID: 127427 RVA: 0x00A25588 File Offset: 0x00A23788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectFrameImage(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			heroItemUIController.ShowSelectFrameImage(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1C4 RID: 127428 RVA: 0x00A255E0 File Offset: 0x00A237E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			heroItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1C5 RID: 127429 RVA: 0x00A25634 File Offset: 0x00A23834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitValuesInHeroItem(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			int lvText;
			LuaObject.checkType(l, 2, out lvText);
			int starNum;
			LuaObject.checkType(l, 3, out starNum);
			int curNum;
			LuaObject.checkType(l, 4, out curNum);
			int totalNum;
			LuaObject.checkType(l, 5, out totalNum);
			int state;
			LuaObject.checkType(l, 6, out state);
			heroItemUIController.m_luaExportHelper.InitValuesInHeroItem(lvText, starNum, curNum, totalNum, state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1C6 RID: 127430 RVA: 0x00A256C4 File Offset: 0x00A238C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			heroItemUIController.m_luaExportHelper.OnHeroItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1C7 RID: 127431 RVA: 0x00A25718 File Offset: 0x00A23918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1C8 RID: 127432 RVA: 0x00A25784 File Offset: 0x00A23984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			heroItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1C9 RID: 127433 RVA: 0x00A257D8 File Offset: 0x00A239D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			heroItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1CA RID: 127434 RVA: 0x00A2582C File Offset: 0x00A23A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F1CB RID: 127435 RVA: 0x00A258D4 File Offset: 0x00A23AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			heroItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1CC RID: 127436 RVA: 0x00A25928 File Offset: 0x00A23B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1CD RID: 127437 RVA: 0x00A25994 File Offset: 0x00A23B94
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
				HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroItemUIController heroItemUIController2 = (HeroItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F1CE RID: 127438 RVA: 0x00A25AA4 File Offset: 0x00A23CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1CF RID: 127439 RVA: 0x00A25B10 File Offset: 0x00A23D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1D0 RID: 127440 RVA: 0x00A25B7C File Offset: 0x00A23D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1D1 RID: 127441 RVA: 0x00A25BE8 File Offset: 0x00A23DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1D2 RID: 127442 RVA: 0x00A25C54 File Offset: 0x00A23E54
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
				HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroItemUIController heroItemUIController2 = (HeroItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F1D3 RID: 127443 RVA: 0x00A25D64 File Offset: 0x00A23F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			string s = heroItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F1D4 RID: 127444 RVA: 0x00A25DC0 File Offset: 0x00A23FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			HeroItemUIController obj;
			LuaObject.checkType<HeroItemUIController>(l, 2, out obj);
			heroItemUIController.m_luaExportHelper.__callDele_EventOnHeroItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1D5 RID: 127445 RVA: 0x00A25E1C File Offset: 0x00A2401C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			HeroItemUIController obj;
			LuaObject.checkType<HeroItemUIController>(l, 2, out obj);
			heroItemUIController.m_luaExportHelper.__clearDele_EventOnHeroItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1D6 RID: 127446 RVA: 0x00A25E78 File Offset: 0x00A24078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Action<HeroItemUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroItemUIController.EventOnHeroItemClick += value;
				}
				else if (num == 2)
				{
					heroItemUIController.EventOnHeroItemClick -= value;
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

	// Token: 0x0601F1D7 RID: 127447 RVA: 0x00A25EF8 File Offset: 0x00A240F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCollectProgressImg(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_luaExportHelper.m_heroCollectProgressImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1D8 RID: 127448 RVA: 0x00A25F50 File Offset: 0x00A24150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCollectProgressImg(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Image heroCollectProgressImg;
			LuaObject.checkType<Image>(l, 2, out heroCollectProgressImg);
			heroItemUIController.m_luaExportHelper.m_heroCollectProgressImg = heroCollectProgressImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1D9 RID: 127449 RVA: 0x00A25FAC File Offset: 0x00A241AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCollectProgressText(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_luaExportHelper.m_heroCollectProgressText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1DA RID: 127450 RVA: 0x00A26004 File Offset: 0x00A24204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCollectProgressText(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Text heroCollectProgressText;
			LuaObject.checkType<Text>(l, 2, out heroCollectProgressText);
			heroItemUIController.m_luaExportHelper.m_heroCollectProgressText = heroCollectProgressText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1DB RID: 127451 RVA: 0x00A26060 File Offset: 0x00A24260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectFrameImg(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_luaExportHelper.m_selectFrameImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1DC RID: 127452 RVA: 0x00A260B8 File Offset: 0x00A242B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectFrameImg(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Image selectFrameImg;
			LuaObject.checkType<Image>(l, 2, out selectFrameImg);
			heroItemUIController.m_luaExportHelper.m_selectFrameImg = selectFrameImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1DD RID: 127453 RVA: 0x00A26114 File Offset: 0x00A24314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_luaExportHelper.m_heroStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1DE RID: 127454 RVA: 0x00A2616C File Offset: 0x00A2436C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			GameObject heroStar;
			LuaObject.checkType<GameObject>(l, 2, out heroStar);
			heroItemUIController.m_luaExportHelper.m_heroStar = heroStar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1DF RID: 127455 RVA: 0x00A261C8 File Offset: 0x00A243C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTypeImg(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_luaExportHelper.m_heroTypeImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1E0 RID: 127456 RVA: 0x00A26220 File Offset: 0x00A24420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTypeImg(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Image heroTypeImg;
			LuaObject.checkType<Image>(l, 2, out heroTypeImg);
			heroItemUIController.m_luaExportHelper.m_heroTypeImg = heroTypeImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1E1 RID: 127457 RVA: 0x00A2627C File Offset: 0x00A2447C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroLvText(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_luaExportHelper.m_heroLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1E2 RID: 127458 RVA: 0x00A262D4 File Offset: 0x00A244D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroLvText(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Text heroLvText;
			LuaObject.checkType<Text>(l, 2, out heroLvText);
			heroItemUIController.m_luaExportHelper.m_heroLvText = heroLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1E3 RID: 127459 RVA: 0x00A26330 File Offset: 0x00A24530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_luaExportHelper.m_ssrFrameEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1E4 RID: 127460 RVA: 0x00A26388 File Offset: 0x00A24588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			GameObject ssrFrameEffect;
			LuaObject.checkType<GameObject>(l, 2, out ssrFrameEffect);
			heroItemUIController.m_luaExportHelper.m_ssrFrameEffect = ssrFrameEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1E5 RID: 127461 RVA: 0x00A263E4 File Offset: 0x00A245E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frameImg(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_luaExportHelper.m_frameImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1E6 RID: 127462 RVA: 0x00A2643C File Offset: 0x00A2463C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameImg(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Image frameImg;
			LuaObject.checkType<Image>(l, 2, out frameImg);
			heroItemUIController.m_luaExportHelper.m_frameImg = frameImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1E7 RID: 127463 RVA: 0x00A26498 File Offset: 0x00A24698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_luaExportHelper.m_heroIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1E8 RID: 127464 RVA: 0x00A264F0 File Offset: 0x00A246F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Image heroIconImg;
			LuaObject.checkType<Image>(l, 2, out heroIconImg);
			heroItemUIController.m_luaExportHelper.m_heroIconImg = heroIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1E9 RID: 127465 RVA: 0x00A2654C File Offset: 0x00A2474C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_luaExportHelper.m_redMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1EA RID: 127466 RVA: 0x00A265A4 File Offset: 0x00A247A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redMark(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Image redMark;
			LuaObject.checkType<Image>(l, 2, out redMark);
			heroItemUIController.m_luaExportHelper.m_redMark = redMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1EB RID: 127467 RVA: 0x00A26600 File Offset: 0x00A24800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_luaExportHelper.m_uiStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1EC RID: 127468 RVA: 0x00A26658 File Offset: 0x00A24858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateCtrl);
			heroItemUIController.m_luaExportHelper.m_uiStateCtrl = uiStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1ED RID: 127469 RVA: 0x00A266B4 File Offset: 0x00A248B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curHeroItemState(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)heroItemUIController.m_curHeroItemState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1EE RID: 127470 RVA: 0x00A26708 File Offset: 0x00A24908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curHeroItemState(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			HeroItemUIController.HeroItemState curHeroItemState;
			LuaObject.checkEnum<HeroItemUIController.HeroItemState>(l, 2, out curHeroItemState);
			heroItemUIController.m_curHeroItemState = curHeroItemState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1EF RID: 127471 RVA: 0x00A26760 File Offset: 0x00A24960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroItemUIController.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1F0 RID: 127472 RVA: 0x00A267B4 File Offset: 0x00A249B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroItemUIController heroItemUIController = (HeroItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroItemUIController.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1F1 RID: 127473 RVA: 0x00A2680C File Offset: 0x00A24A0C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.InitValuesInHeroItemUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.InitValuesInHeroItemLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.ShowSelectFrameImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.InitValuesInHeroItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.OnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__callDele_EventOnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.__clearDele_EventOnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache14);
		string name = "EventOnHeroItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_EventOnHeroItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache15, true);
		string name2 = "m_heroCollectProgressImg";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_heroCollectProgressImg);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_heroCollectProgressImg);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache17, true);
		string name3 = "m_heroCollectProgressText";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_heroCollectProgressText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_heroCollectProgressText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache19, true);
		string name4 = "m_selectFrameImg";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_selectFrameImg);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_selectFrameImg);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1B, true);
		string name5 = "m_heroStar";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_heroStar);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_heroStar);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1D, true);
		string name6 = "m_heroTypeImg";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_heroTypeImg);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_heroTypeImg);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache1F, true);
		string name7 = "m_heroLvText";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_heroLvText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_heroLvText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache21, true);
		string name8 = "m_ssrFrameEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_ssrFrameEffect);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_ssrFrameEffect);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache23, true);
		string name9 = "m_frameImg";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_frameImg);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_frameImg);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache25, true);
		string name10 = "m_heroIconImg";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_heroIconImg);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_heroIconImg);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache27, true);
		string name11 = "m_redMark";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_redMark);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_redMark);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache29, true);
		string name12 = "m_uiStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_uiStateCtrl);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_uiStateCtrl);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2B, true);
		string name13 = "m_curHeroItemState";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_curHeroItemState);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_curHeroItemState);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2D, true);
		string name14 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.get_m_hero);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroItemUIController.set_m_hero);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroItemUIController.<>f__mg$cache2F, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015215 RID: 86549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015216 RID: 86550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015217 RID: 86551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015218 RID: 86552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015219 RID: 86553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401521A RID: 86554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401521B RID: 86555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401521C RID: 86556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401521D RID: 86557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401521E RID: 86558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401521F RID: 86559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015220 RID: 86560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015221 RID: 86561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015222 RID: 86562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015223 RID: 86563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015224 RID: 86564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015225 RID: 86565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015226 RID: 86566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015227 RID: 86567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015228 RID: 86568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015229 RID: 86569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401522A RID: 86570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401522B RID: 86571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401522C RID: 86572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401522D RID: 86573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401522E RID: 86574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401522F RID: 86575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015230 RID: 86576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015231 RID: 86577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015232 RID: 86578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015233 RID: 86579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015234 RID: 86580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015235 RID: 86581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015236 RID: 86582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015237 RID: 86583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015238 RID: 86584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015239 RID: 86585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401523A RID: 86586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401523B RID: 86587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401523C RID: 86588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401523D RID: 86589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401523E RID: 86590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401523F RID: 86591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015240 RID: 86592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015241 RID: 86593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015242 RID: 86594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015243 RID: 86595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015244 RID: 86596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
