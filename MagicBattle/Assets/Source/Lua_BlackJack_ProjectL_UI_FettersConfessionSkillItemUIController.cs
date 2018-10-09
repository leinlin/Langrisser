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

// Token: 0x02001437 RID: 5175
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController : LuaObject
{
	// Token: 0x0601DACD RID: 121549 RVA: 0x0096F1C0 File Offset: 0x0096D3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitFettersConfessionSkillItem(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			int fetterId;
			LuaObject.checkType(l, 2, out fetterId);
			int curFavoribilityLevel;
			LuaObject.checkType(l, 3, out curFavoribilityLevel);
			bool hasUnLock;
			LuaObject.checkType(l, 4, out hasUnLock);
			int skillLv;
			LuaObject.checkType(l, 5, out skillLv);
			fettersConfessionSkillItemUIController.InitFettersConfessionSkillItem(fetterId, curFavoribilityLevel, hasUnLock, skillLv);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DACE RID: 121550 RVA: 0x0096F240 File Offset: 0x0096D440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayUnlockEffect(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			fettersConfessionSkillItemUIController.PlayUnlockEffect(rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DACF RID: 121551 RVA: 0x0096F298 File Offset: 0x0096D498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayPromoteEffect(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			fettersConfessionSkillItemUIController.PlayPromoteEffect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAD0 RID: 121552 RVA: 0x0096F2E4 File Offset: 0x0096D4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			fettersConfessionSkillItemUIController.ShowSelectImage(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAD1 RID: 121553 RVA: 0x0096F33C File Offset: 0x0096D53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			fettersConfessionSkillItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAD2 RID: 121554 RVA: 0x0096F390 File Offset: 0x0096D590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkillToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			fettersConfessionSkillItemUIController.m_luaExportHelper.OnSkillToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAD3 RID: 121555 RVA: 0x0096F3EC File Offset: 0x0096D5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAD4 RID: 121556 RVA: 0x0096F458 File Offset: 0x0096D658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAD5 RID: 121557 RVA: 0x0096F4AC File Offset: 0x0096D6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAD6 RID: 121558 RVA: 0x0096F500 File Offset: 0x0096D700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DAD7 RID: 121559 RVA: 0x0096F5A8 File Offset: 0x0096D7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAD8 RID: 121560 RVA: 0x0096F5FC File Offset: 0x0096D7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAD9 RID: 121561 RVA: 0x0096F668 File Offset: 0x0096D868
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
				FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController2 = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				fettersConfessionSkillItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DADA RID: 121562 RVA: 0x0096F778 File Offset: 0x0096D978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DADB RID: 121563 RVA: 0x0096F7E4 File Offset: 0x0096D9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DADC RID: 121564 RVA: 0x0096F850 File Offset: 0x0096DA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DADD RID: 121565 RVA: 0x0096F8BC File Offset: 0x0096DABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DADE RID: 121566 RVA: 0x0096F928 File Offset: 0x0096DB28
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
				FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController2 = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				fettersConfessionSkillItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DADF RID: 121567 RVA: 0x0096FA38 File Offset: 0x0096DC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			string s = fettersConfessionSkillItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DAE0 RID: 121568 RVA: 0x0096FA94 File Offset: 0x0096DC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			FettersConfessionSkillItemUIController obj;
			LuaObject.checkType<FettersConfessionSkillItemUIController>(l, 2, out obj);
			fettersConfessionSkillItemUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAE1 RID: 121569 RVA: 0x0096FAF0 File Offset: 0x0096DCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			FettersConfessionSkillItemUIController obj;
			LuaObject.checkType<FettersConfessionSkillItemUIController>(l, 2, out obj);
			fettersConfessionSkillItemUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAE2 RID: 121570 RVA: 0x0096FB4C File Offset: 0x0096DD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			Action<FettersConfessionSkillItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FettersConfessionSkillItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersConfessionSkillItemUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					fettersConfessionSkillItemUIController.EventOnClick -= value;
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

	// Token: 0x0601DAE3 RID: 121571 RVA: 0x0096FBCC File Offset: 0x0096DDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAE4 RID: 121572 RVA: 0x0096FC24 File Offset: 0x0096DE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			ToggleEx toggle;
			LuaObject.checkType<ToggleEx>(l, 2, out toggle);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_toggle = toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAE5 RID: 121573 RVA: 0x0096FC80 File Offset: 0x0096DE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAE6 RID: 121574 RVA: 0x0096FCD8 File Offset: 0x0096DED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAE7 RID: 121575 RVA: 0x0096FD34 File Offset: 0x0096DF34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lvValueText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_lvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAE8 RID: 121576 RVA: 0x0096FD8C File Offset: 0x0096DF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lvValueText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			Text lvValueText;
			LuaObject.checkType<Text>(l, 2, out lvValueText);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_lvValueText = lvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAE9 RID: 121577 RVA: 0x0096FDE8 File Offset: 0x0096DFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redPoint(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_redPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAEA RID: 121578 RVA: 0x0096FE40 File Offset: 0x0096E040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redPoint(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			GameObject redPoint;
			LuaObject.checkType<GameObject>(l, 2, out redPoint);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_redPoint = redPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAEB RID: 121579 RVA: 0x0096FE9C File Offset: 0x0096E09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockConditionText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_unlockConditionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAEC RID: 121580 RVA: 0x0096FEF4 File Offset: 0x0096E0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockConditionText(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			Text unlockConditionText;
			LuaObject.checkType<Text>(l, 2, out unlockConditionText);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_unlockConditionText = unlockConditionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAED RID: 121581 RVA: 0x0096FF50 File Offset: 0x0096E150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillIconImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_skillIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAEE RID: 121582 RVA: 0x0096FFA8 File Offset: 0x0096E1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillIconImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			Image skillIconImage;
			LuaObject.checkType<Image>(l, 2, out skillIconImage);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_skillIconImage = skillIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAEF RID: 121583 RVA: 0x00970004 File Offset: 0x0096E204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockSelectImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_unlockSelectImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAF0 RID: 121584 RVA: 0x0097005C File Offset: 0x0096E25C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockSelectImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			GameObject unlockSelectImage;
			LuaObject.checkType<GameObject>(l, 2, out unlockSelectImage);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_unlockSelectImage = unlockSelectImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAF1 RID: 121585 RVA: 0x009700B8 File Offset: 0x0096E2B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockSelectImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_lockSelectImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAF2 RID: 121586 RVA: 0x00970110 File Offset: 0x0096E310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockSelectImage(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			GameObject lockSelectImage;
			LuaObject.checkType<GameObject>(l, 2, out lockSelectImage);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_lockSelectImage = lockSelectImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAF3 RID: 121587 RVA: 0x0097016C File Offset: 0x0096E36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hasUnLocked(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_hasUnLocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAF4 RID: 121588 RVA: 0x009701C4 File Offset: 0x0096E3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hasUnLocked(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			bool hasUnLocked;
			LuaObject.checkType(l, 2, out hasUnLocked);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_hasUnLocked = hasUnLocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAF5 RID: 121589 RVA: 0x00970220 File Offset: 0x0096E420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockFavoribilityLevel(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_unlockFavoribilityLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAF6 RID: 121590 RVA: 0x00970278 File Offset: 0x0096E478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockFavoribilityLevel(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			int unlockFavoribilityLevel;
			LuaObject.checkType(l, 2, out unlockFavoribilityLevel);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_unlockFavoribilityLevel = unlockFavoribilityLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAF7 RID: 121591 RVA: 0x009702D4 File Offset: 0x0096E4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curFavoribilityLevel(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_curFavoribilityLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAF8 RID: 121592 RVA: 0x0097032C File Offset: 0x0096E52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curFavoribilityLevel(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			int curFavoribilityLevel;
			LuaObject.checkType(l, 2, out curFavoribilityLevel);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_curFavoribilityLevel = curFavoribilityLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAF9 RID: 121593 RVA: 0x00970388 File Offset: 0x0096E588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_heroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAFA RID: 121594 RVA: 0x009703E0 File Offset: 0x0096E5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_heroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAFB RID: 121595 RVA: 0x0097043C File Offset: 0x0096E63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAFC RID: 121596 RVA: 0x00970494 File Offset: 0x0096E694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAFD RID: 121597 RVA: 0x009704F0 File Offset: 0x0096E6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAFE RID: 121598 RVA: 0x00970548 File Offset: 0x0096E748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DAFF RID: 121599 RVA: 0x009705A4 File Offset: 0x0096E7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillLv(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.m_luaExportHelper.m_skillLv);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB00 RID: 121600 RVA: 0x009705FC File Offset: 0x0096E7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillLv(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			int skillLv;
			LuaObject.checkType(l, 2, out skillLv);
			fettersConfessionSkillItemUIController.m_luaExportHelper.m_skillLv = skillLv;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB01 RID: 121601 RVA: 0x00970658 File Offset: 0x0096E858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroFetterInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersConfessionSkillItemUIController.HeroFetterInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB02 RID: 121602 RVA: 0x009706AC File Offset: 0x0096E8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroFetterInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersConfessionSkillItemUIController fettersConfessionSkillItemUIController = (FettersConfessionSkillItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroFetterInfo heroFetterInfo;
			LuaObject.checkType<ConfigDataHeroFetterInfo>(l, 2, out heroFetterInfo);
			fettersConfessionSkillItemUIController.m_luaExportHelper.HeroFetterInfo = heroFetterInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DB03 RID: 121603 RVA: 0x00970708 File Offset: 0x0096E908
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersConfessionSkillItemUIController");
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.InitFettersConfessionSkillItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.PlayUnlockEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.PlayPromoteEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.ShowSelectImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.OnSkillToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache14);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache15, true);
		string name2 = "m_toggle";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_toggle);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_toggle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache17, true);
		string name3 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_stateCtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache19, true);
		string name4 = "m_lvValueText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_lvValueText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_lvValueText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1B, true);
		string name5 = "m_redPoint";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_redPoint);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_redPoint);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1D, true);
		string name6 = "m_unlockConditionText";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_unlockConditionText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_unlockConditionText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache1F, true);
		string name7 = "m_skillIconImage";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_skillIconImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_skillIconImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache21, true);
		string name8 = "m_unlockSelectImage";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_unlockSelectImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_unlockSelectImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache23, true);
		string name9 = "m_lockSelectImage";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_lockSelectImage);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_lockSelectImage);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache25, true);
		string name10 = "m_hasUnLocked";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_hasUnLocked);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_hasUnLocked);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache27, true);
		string name11 = "m_unlockFavoribilityLevel";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_unlockFavoribilityLevel);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_unlockFavoribilityLevel);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache29, true);
		string name12 = "m_curFavoribilityLevel";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_curFavoribilityLevel);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_curFavoribilityLevel);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2B, true);
		string name13 = "m_heroId";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_heroId);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_heroId);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2D, true);
		string name14 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_configDataLoader);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache2F, true);
		string name15 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_playerContext);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache31, true);
		string name16 = "m_skillLv";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_m_skillLv);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_m_skillLv);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache33, true);
		string name17 = "HeroFetterInfo";
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.get_HeroFetterInfo);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.set_HeroFetterInfo);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_FettersConfessionSkillItemUIController.<>f__mg$cache35, true);
		LuaObject.createTypeMetatable(l, null, typeof(FettersConfessionSkillItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013C41 RID: 80961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013C42 RID: 80962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013C43 RID: 80963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013C44 RID: 80964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013C45 RID: 80965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013C46 RID: 80966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013C47 RID: 80967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013C48 RID: 80968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013C49 RID: 80969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013C4A RID: 80970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013C4B RID: 80971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013C4C RID: 80972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013C4D RID: 80973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013C4E RID: 80974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013C4F RID: 80975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013C50 RID: 80976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013C51 RID: 80977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013C52 RID: 80978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013C53 RID: 80979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013C54 RID: 80980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013C55 RID: 80981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013C56 RID: 80982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013C57 RID: 80983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013C58 RID: 80984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013C59 RID: 80985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013C5A RID: 80986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013C5B RID: 80987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013C5C RID: 80988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013C5D RID: 80989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013C5E RID: 80990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013C5F RID: 80991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013C60 RID: 80992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013C61 RID: 80993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013C62 RID: 80994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013C63 RID: 80995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013C64 RID: 80996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013C65 RID: 80997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013C66 RID: 80998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013C67 RID: 80999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013C68 RID: 81000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013C69 RID: 81001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013C6A RID: 81002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013C6B RID: 81003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013C6C RID: 81004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013C6D RID: 81005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013C6E RID: 81006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013C6F RID: 81007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013C70 RID: 81008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013C71 RID: 81009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013C72 RID: 81010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013C73 RID: 81011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013C74 RID: 81012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013C75 RID: 81013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013C76 RID: 81014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;
}
