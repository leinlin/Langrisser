using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001388 RID: 5000
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ARHeroCardUIController : LuaObject
{
	// Token: 0x0601B343 RID: 111427 RVA: 0x008344BC File Offset: 0x008326BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroListItemInfo(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			ARHeroListUIController.HeroWrap heroListItemInfo;
			LuaObject.checkType<ARHeroListUIController.HeroWrap>(l, 2, out heroListItemInfo);
			arheroCardUIController.SetHeroListItemInfo(heroListItemInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B344 RID: 111428 RVA: 0x00834514 File Offset: 0x00832714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshHeroSelect(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			arheroCardUIController.RefreshHeroSelect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B345 RID: 111429 RVA: 0x00834560 File Offset: 0x00832760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			arheroCardUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B346 RID: 111430 RVA: 0x008345B4 File Offset: 0x008327B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			arheroCardUIController.m_luaExportHelper.OnHeroItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B347 RID: 111431 RVA: 0x00834608 File Offset: 0x00832808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arheroCardUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B348 RID: 111432 RVA: 0x00834674 File Offset: 0x00832874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			arheroCardUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B349 RID: 111433 RVA: 0x008346C8 File Offset: 0x008328C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			arheroCardUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B34A RID: 111434 RVA: 0x0083471C File Offset: 0x0083291C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arheroCardUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B34B RID: 111435 RVA: 0x008347C4 File Offset: 0x008329C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			arheroCardUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B34C RID: 111436 RVA: 0x00834818 File Offset: 0x00832A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arheroCardUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B34D RID: 111437 RVA: 0x00834884 File Offset: 0x00832A84
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
				ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arheroCardUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ARHeroCardUIController arheroCardUIController2 = (ARHeroCardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arheroCardUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B34E RID: 111438 RVA: 0x00834994 File Offset: 0x00832B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arheroCardUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B34F RID: 111439 RVA: 0x00834A00 File Offset: 0x00832C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arheroCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B350 RID: 111440 RVA: 0x00834A6C File Offset: 0x00832C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arheroCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B351 RID: 111441 RVA: 0x00834AD8 File Offset: 0x00832CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arheroCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B352 RID: 111442 RVA: 0x00834B44 File Offset: 0x00832D44
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
				ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arheroCardUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ARHeroCardUIController arheroCardUIController2 = (ARHeroCardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arheroCardUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B353 RID: 111443 RVA: 0x00834C54 File Offset: 0x00832E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			string s = arheroCardUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B354 RID: 111444 RVA: 0x00834CB0 File Offset: 0x00832EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectHeroItem(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			ARHeroCardUIController obj;
			LuaObject.checkType<ARHeroCardUIController>(l, 2, out obj);
			arheroCardUIController.m_luaExportHelper.__callDele_EventOnSelectHeroItem(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B355 RID: 111445 RVA: 0x00834D0C File Offset: 0x00832F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectHeroItem(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			ARHeroCardUIController obj;
			LuaObject.checkType<ARHeroCardUIController>(l, 2, out obj);
			arheroCardUIController.m_luaExportHelper.__clearDele_EventOnSelectHeroItem(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B356 RID: 111446 RVA: 0x00834D68 File Offset: 0x00832F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectHeroItem(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			Action<ARHeroCardUIController> value;
			int num = LuaObject.checkDelegate<Action<ARHeroCardUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arheroCardUIController.EventOnSelectHeroItem += value;
				}
				else if (num == 2)
				{
					arheroCardUIController.EventOnSelectHeroItem -= value;
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

	// Token: 0x0601B357 RID: 111447 RVA: 0x00834DE8 File Offset: 0x00832FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroItemButton(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_luaExportHelper.m_heroItemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B358 RID: 111448 RVA: 0x00834E40 File Offset: 0x00833040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroItemButton(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			Button heroItemButton;
			LuaObject.checkType<Button>(l, 2, out heroItemButton);
			arheroCardUIController.m_luaExportHelper.m_heroItemButton = heroItemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B359 RID: 111449 RVA: 0x00834E9C File Offset: 0x0083309C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroItemUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_luaExportHelper.m_heroItemUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B35A RID: 111450 RVA: 0x00834EF4 File Offset: 0x008330F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroItemUIStateController(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			CommonUIStateController heroItemUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out heroItemUIStateController);
			arheroCardUIController.m_luaExportHelper.m_heroItemUIStateController = heroItemUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B35B RID: 111451 RVA: 0x00834F50 File Offset: 0x00833150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_luaExportHelper.m_heroStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B35C RID: 111452 RVA: 0x00834FA8 File Offset: 0x008331A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			GameObject heroStar;
			LuaObject.checkType<GameObject>(l, 2, out heroStar);
			arheroCardUIController.m_luaExportHelper.m_heroStar = heroStar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B35D RID: 111453 RVA: 0x00835004 File Offset: 0x00833204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTypeImg(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_luaExportHelper.m_heroTypeImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B35E RID: 111454 RVA: 0x0083505C File Offset: 0x0083325C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTypeImg(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			Image heroTypeImg;
			LuaObject.checkType<Image>(l, 2, out heroTypeImg);
			arheroCardUIController.m_luaExportHelper.m_heroTypeImg = heroTypeImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B35F RID: 111455 RVA: 0x008350B8 File Offset: 0x008332B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroLvText(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_luaExportHelper.m_heroLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B360 RID: 111456 RVA: 0x00835110 File Offset: 0x00833310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroLvText(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			Text heroLvText;
			LuaObject.checkType<Text>(l, 2, out heroLvText);
			arheroCardUIController.m_luaExportHelper.m_heroLvText = heroLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B361 RID: 111457 RVA: 0x0083516C File Offset: 0x0083336C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSSRFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_luaExportHelper.m_heroSSRFrameEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B362 RID: 111458 RVA: 0x008351C4 File Offset: 0x008333C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSSRFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			GameObject heroSSRFrameEffect;
			LuaObject.checkType<GameObject>(l, 2, out heroSSRFrameEffect);
			arheroCardUIController.m_luaExportHelper.m_heroSSRFrameEffect = heroSSRFrameEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B363 RID: 111459 RVA: 0x00835220 File Offset: 0x00833420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroFrameImg(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_luaExportHelper.m_heroFrameImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B364 RID: 111460 RVA: 0x00835278 File Offset: 0x00833478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroFrameImg(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			Image heroFrameImg;
			LuaObject.checkType<Image>(l, 2, out heroFrameImg);
			arheroCardUIController.m_luaExportHelper.m_heroFrameImg = heroFrameImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B365 RID: 111461 RVA: 0x008352D4 File Offset: 0x008334D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroIconImg(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_luaExportHelper.m_heroIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B366 RID: 111462 RVA: 0x0083532C File Offset: 0x0083352C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIconImg(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			Image heroIconImg;
			LuaObject.checkType<Image>(l, 2, out heroIconImg);
			arheroCardUIController.m_luaExportHelper.m_heroIconImg = heroIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B367 RID: 111463 RVA: 0x00835388 File Offset: 0x00833588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSelectFrame(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_luaExportHelper.m_heroSelectFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B368 RID: 111464 RVA: 0x008353E0 File Offset: 0x008335E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSelectFrame(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			GameObject heroSelectFrame;
			LuaObject.checkType<GameObject>(l, 2, out heroSelectFrame);
			arheroCardUIController.m_luaExportHelper.m_heroSelectFrame = heroSelectFrame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B369 RID: 111465 RVA: 0x0083543C File Offset: 0x0083363C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSelectFront(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_luaExportHelper.m_heroSelectFront);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B36A RID: 111466 RVA: 0x00835494 File Offset: 0x00833694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSelectFront(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			GameObject heroSelectFront;
			LuaObject.checkType<GameObject>(l, 2, out heroSelectFront);
			arheroCardUIController.m_luaExportHelper.m_heroSelectFront = heroSelectFront;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B36B RID: 111467 RVA: 0x008354F0 File Offset: 0x008336F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroWrap(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_heroWrap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B36C RID: 111468 RVA: 0x00835544 File Offset: 0x00833744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroWrap(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			ARHeroListUIController.HeroWrap heroWrap;
			LuaObject.checkType<ARHeroListUIController.HeroWrap>(l, 2, out heroWrap);
			arheroCardUIController.m_heroWrap = heroWrap;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B36D RID: 111469 RVA: 0x0083559C File Offset: 0x0083379C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arheroCardUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B36E RID: 111470 RVA: 0x008355F4 File Offset: 0x008337F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ARHeroCardUIController arheroCardUIController = (ARHeroCardUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			arheroCardUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B36F RID: 111471 RVA: 0x00835650 File Offset: 0x00833850
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ARHeroCardUIController");
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.SetHeroListItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.RefreshHeroSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.OnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__callDele_EventOnSelectHeroItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.__clearDele_EventOnSelectHeroItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache12);
		string name = "EventOnSelectHeroItem";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_EventOnSelectHeroItem);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache13, true);
		string name2 = "m_heroItemButton";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_heroItemButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_heroItemButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache15, true);
		string name3 = "m_heroItemUIStateController";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_heroItemUIStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_heroItemUIStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache17, true);
		string name4 = "m_heroStar";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_heroStar);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_heroStar);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache19, true);
		string name5 = "m_heroTypeImg";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_heroTypeImg);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_heroTypeImg);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1B, true);
		string name6 = "m_heroLvText";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_heroLvText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_heroLvText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1D, true);
		string name7 = "m_heroSSRFrameEffect";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_heroSSRFrameEffect);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_heroSSRFrameEffect);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache1F, true);
		string name8 = "m_heroFrameImg";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_heroFrameImg);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_heroFrameImg);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache21, true);
		string name9 = "m_heroIconImg";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_heroIconImg);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_heroIconImg);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache23, true);
		string name10 = "m_heroSelectFrame";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_heroSelectFrame);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_heroSelectFrame);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache25, true);
		string name11 = "m_heroSelectFront";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_heroSelectFront);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_heroSelectFront);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache27, true);
		string name12 = "m_heroWrap";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_heroWrap);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_heroWrap);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache29, true);
		string name13 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.get_m_configDataLoader);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ARHeroCardUIController.<>f__mg$cache2B, true);
		LuaObject.createTypeMetatable(l, null, typeof(ARHeroCardUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011615 RID: 71189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011616 RID: 71190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011617 RID: 71191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011618 RID: 71192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011619 RID: 71193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401161A RID: 71194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401161B RID: 71195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401161C RID: 71196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401161D RID: 71197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401161E RID: 71198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401161F RID: 71199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011620 RID: 71200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011621 RID: 71201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011622 RID: 71202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011623 RID: 71203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011624 RID: 71204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011625 RID: 71205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011626 RID: 71206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011627 RID: 71207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011628 RID: 71208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011629 RID: 71209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401162A RID: 71210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401162B RID: 71211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401162C RID: 71212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401162D RID: 71213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401162E RID: 71214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401162F RID: 71215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011630 RID: 71216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011631 RID: 71217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011632 RID: 71218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011633 RID: 71219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011634 RID: 71220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011635 RID: 71221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011636 RID: 71222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011637 RID: 71223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011638 RID: 71224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011639 RID: 71225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401163A RID: 71226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401163B RID: 71227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401163C RID: 71228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401163D RID: 71229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401163E RID: 71230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401163F RID: 71231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011640 RID: 71232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
