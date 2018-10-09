using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200155D RID: 5469
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RewardHeroUIController : LuaObject
{
	// Token: 0x06020B85 RID: 134021 RVA: 0x00AF235C File Offset: 0x00AF055C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHero(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			rewardHeroUIController.SetHero(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B86 RID: 134022 RVA: 0x00AF23B4 File Offset: 0x00AF05B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetExp(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			rewardHeroUIController.SetExp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B87 RID: 134023 RVA: 0x00AF2400 File Offset: 0x00AF0600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLevel(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			rewardHeroUIController.SetLevel(level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B88 RID: 134024 RVA: 0x00AF2458 File Offset: 0x00AF0658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			rewardHeroUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B89 RID: 134025 RVA: 0x00AF24AC File Offset: 0x00AF06AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddExpBarWidth(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			float intervalTime;
			LuaObject.checkType(l, 2, out intervalTime);
			IEnumerator o = rewardHeroUIController.m_luaExportHelper.AddExpBarWidth(intervalTime);
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

	// Token: 0x06020B8A RID: 134026 RVA: 0x00AF2514 File Offset: 0x00AF0714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTextValue(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			rewardHeroUIController.m_luaExportHelper.UpdateTextValue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B8B RID: 134027 RVA: 0x00AF2568 File Offset: 0x00AF0768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			rewardHeroUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B8C RID: 134028 RVA: 0x00AF25D4 File Offset: 0x00AF07D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			rewardHeroUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B8D RID: 134029 RVA: 0x00AF2628 File Offset: 0x00AF0828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			rewardHeroUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B8E RID: 134030 RVA: 0x00AF267C File Offset: 0x00AF087C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = rewardHeroUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020B8F RID: 134031 RVA: 0x00AF2724 File Offset: 0x00AF0924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			rewardHeroUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B90 RID: 134032 RVA: 0x00AF2778 File Offset: 0x00AF0978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			rewardHeroUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B91 RID: 134033 RVA: 0x00AF27E4 File Offset: 0x00AF09E4
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
				RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				rewardHeroUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RewardHeroUIController rewardHeroUIController2 = (RewardHeroUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				rewardHeroUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020B92 RID: 134034 RVA: 0x00AF28F4 File Offset: 0x00AF0AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardHeroUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B93 RID: 134035 RVA: 0x00AF2960 File Offset: 0x00AF0B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardHeroUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B94 RID: 134036 RVA: 0x00AF29CC File Offset: 0x00AF0BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardHeroUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B95 RID: 134037 RVA: 0x00AF2A38 File Offset: 0x00AF0C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardHeroUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B96 RID: 134038 RVA: 0x00AF2AA4 File Offset: 0x00AF0CA4
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
				RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				rewardHeroUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RewardHeroUIController rewardHeroUIController2 = (RewardHeroUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				rewardHeroUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020B97 RID: 134039 RVA: 0x00AF2BB4 File Offset: 0x00AF0DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			string s = rewardHeroUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020B98 RID: 134040 RVA: 0x00AF2C10 File Offset: 0x00AF0E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B99 RID: 134041 RVA: 0x00AF2C68 File Offset: 0x00AF0E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			rewardHeroUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B9A RID: 134042 RVA: 0x00AF2CC4 File Offset: 0x00AF0EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B9B RID: 134043 RVA: 0x00AF2D1C File Offset: 0x00AF0F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			rewardHeroUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B9C RID: 134044 RVA: 0x00AF2D78 File Offset: 0x00AF0F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expText(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroUIController.m_luaExportHelper.m_expText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B9D RID: 134045 RVA: 0x00AF2DD0 File Offset: 0x00AF0FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expText(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			Text expText;
			LuaObject.checkType<Text>(l, 2, out expText);
			rewardHeroUIController.m_luaExportHelper.m_expText = expText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B9E RID: 134046 RVA: 0x00AF2E2C File Offset: 0x00AF102C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expImage(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroUIController.m_luaExportHelper.m_expImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B9F RID: 134047 RVA: 0x00AF2E84 File Offset: 0x00AF1084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expImage(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			Image expImage;
			LuaObject.checkType<Image>(l, 2, out expImage);
			rewardHeroUIController.m_luaExportHelper.m_expImage = expImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BA0 RID: 134048 RVA: 0x00AF2EE0 File Offset: 0x00AF10E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelUpGameObject(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroUIController.m_luaExportHelper.m_levelUpGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BA1 RID: 134049 RVA: 0x00AF2F38 File Offset: 0x00AF1138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelUpGameObject(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			GameObject levelUpGameObject;
			LuaObject.checkType<GameObject>(l, 2, out levelUpGameObject);
			rewardHeroUIController.m_luaExportHelper.m_levelUpGameObject = levelUpGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BA2 RID: 134050 RVA: 0x00AF2F94 File Offset: 0x00AF1194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_effectRoot(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroUIController.m_luaExportHelper.m_effectRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BA3 RID: 134051 RVA: 0x00AF2FEC File Offset: 0x00AF11EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_effectRoot(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			GameObject effectRoot;
			LuaObject.checkType<GameObject>(l, 2, out effectRoot);
			rewardHeroUIController.m_luaExportHelper.m_effectRoot = effectRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BA4 RID: 134052 RVA: 0x00AF3048 File Offset: 0x00AF1248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroExpTotalWidth(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroUIController.m_luaExportHelper.m_heroExpTotalWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BA5 RID: 134053 RVA: 0x00AF30A0 File Offset: 0x00AF12A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroExpTotalWidth(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			float heroExpTotalWidth;
			LuaObject.checkType(l, 2, out heroExpTotalWidth);
			rewardHeroUIController.m_luaExportHelper.m_heroExpTotalWidth = heroExpTotalWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BA6 RID: 134054 RVA: 0x00AF30FC File Offset: 0x00AF12FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BA7 RID: 134055 RVA: 0x00AF3154 File Offset: 0x00AF1354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			rewardHeroUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BA8 RID: 134056 RVA: 0x00AF31B0 File Offset: 0x00AF13B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_singleAddExp(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroUIController.m_luaExportHelper.m_singleAddExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BA9 RID: 134057 RVA: 0x00AF3208 File Offset: 0x00AF1408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_singleAddExp(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			float singleAddExp;
			LuaObject.checkType(l, 2, out singleAddExp);
			rewardHeroUIController.m_luaExportHelper.m_singleAddExp = singleAddExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BAA RID: 134058 RVA: 0x00AF3264 File Offset: 0x00AF1464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_beforeHeroExp(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroUIController.m_luaExportHelper.m_beforeHeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BAB RID: 134059 RVA: 0x00AF32BC File Offset: 0x00AF14BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_beforeHeroExp(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			float beforeHeroExp;
			LuaObject.checkType(l, 2, out beforeHeroExp);
			rewardHeroUIController.m_luaExportHelper.m_beforeHeroExp = beforeHeroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BAC RID: 134060 RVA: 0x00AF3318 File Offset: 0x00AF1518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finalHeroExp(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardHeroUIController.m_luaExportHelper.m_finalHeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BAD RID: 134061 RVA: 0x00AF3370 File Offset: 0x00AF1570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finalHeroExp(IntPtr l)
	{
		int result;
		try
		{
			RewardHeroUIController rewardHeroUIController = (RewardHeroUIController)LuaObject.checkSelf(l);
			int finalHeroExp;
			LuaObject.checkType(l, 2, out finalHeroExp);
			rewardHeroUIController.m_luaExportHelper.m_finalHeroExp = finalHeroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BAE RID: 134062 RVA: 0x00AF33CC File Offset: 0x00AF15CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RewardHeroUIController");
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.SetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.SetExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.SetLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.AddExpBarWidth);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.UpdateTextValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache12);
		string name = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.get_m_iconImage);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache14, true);
		string name2 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.get_m_levelText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache16, true);
		string name3 = "m_expText";
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.get_m_expText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.set_m_expText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache18, true);
		string name4 = "m_expImage";
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.get_m_expImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.set_m_expImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1A, true);
		string name5 = "m_levelUpGameObject";
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.get_m_levelUpGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.set_m_levelUpGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1C, true);
		string name6 = "m_effectRoot";
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.get_m_effectRoot);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.set_m_effectRoot);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1E, true);
		string name7 = "m_heroExpTotalWidth";
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.get_m_heroExpTotalWidth);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.set_m_heroExpTotalWidth);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache20, true);
		string name8 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.get_m_hero);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.set_m_hero);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache22, true);
		string name9 = "m_singleAddExp";
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.get_m_singleAddExp);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.set_m_singleAddExp);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache24, true);
		string name10 = "m_beforeHeroExp";
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.get_m_beforeHeroExp);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.set_m_beforeHeroExp);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache26, true);
		string name11 = "m_finalHeroExp";
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.get_m_finalHeroExp);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardHeroUIController.set_m_finalHeroExp);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RewardHeroUIController.<>f__mg$cache28, true);
		LuaObject.createTypeMetatable(l, null, typeof(RewardHeroUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016AAD RID: 92845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016AAE RID: 92846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016AAF RID: 92847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016AB0 RID: 92848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016AB1 RID: 92849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016AB2 RID: 92850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016AB3 RID: 92851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016AB4 RID: 92852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016AB5 RID: 92853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016AB6 RID: 92854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016AB7 RID: 92855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016AB8 RID: 92856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016AB9 RID: 92857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016ABA RID: 92858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016ABB RID: 92859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016ABC RID: 92860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016ABD RID: 92861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016ABE RID: 92862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016ABF RID: 92863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016AC0 RID: 92864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016AC1 RID: 92865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016AC2 RID: 92866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016AC3 RID: 92867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016AC4 RID: 92868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016AC5 RID: 92869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016AC6 RID: 92870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016AC7 RID: 92871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016AC8 RID: 92872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016AC9 RID: 92873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016ACA RID: 92874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016ACB RID: 92875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016ACC RID: 92876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016ACD RID: 92877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016ACE RID: 92878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016ACF RID: 92879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016AD0 RID: 92880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016AD1 RID: 92881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016AD2 RID: 92882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016AD3 RID: 92883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016AD4 RID: 92884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016AD5 RID: 92885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;
}
