using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014E0 RID: 5344
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController : LuaObject
{
	// Token: 0x0601F796 RID: 128918 RVA: 0x00A54264 File Offset: 0x00A52464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSkillItem(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			heroSkillItemUIController.InitSkillItem(skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F797 RID: 128919 RVA: 0x00A542BC File Offset: 0x00A524BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelectPanelActive(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			bool selectPanelActive;
			LuaObject.checkType(l, 2, out selectPanelActive);
			heroSkillItemUIController.SetSelectPanelActive(selectPanelActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F798 RID: 128920 RVA: 0x00A54314 File Offset: 0x00A52514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChoosenImageActive(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			bool choosenImageActive;
			LuaObject.checkType(l, 2, out choosenImageActive);
			heroSkillItemUIController.SetChoosenImageActive(choosenImageActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F799 RID: 128921 RVA: 0x00A5436C File Offset: 0x00A5256C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLimitTagObjActive(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			bool limitTagObjActive;
			LuaObject.checkType(l, 2, out limitTagObjActive);
			heroSkillItemUIController.SetLimitTagObjActive(limitTagObjActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F79A RID: 128922 RVA: 0x00A543C4 File Offset: 0x00A525C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCostPanelActive(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			bool costPanelActive;
			LuaObject.checkType(l, 2, out costPanelActive);
			heroSkillItemUIController.SetCostPanelActive(costPanelActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F79B RID: 128923 RVA: 0x00A5441C File Offset: 0x00A5261C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			heroSkillItemUIController.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F79C RID: 128924 RVA: 0x00A54474 File Offset: 0x00A52674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			heroSkillItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F79D RID: 128925 RVA: 0x00A544C8 File Offset: 0x00A526C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroSkillItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F79E RID: 128926 RVA: 0x00A54534 File Offset: 0x00A52734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			heroSkillItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F79F RID: 128927 RVA: 0x00A54588 File Offset: 0x00A52788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			heroSkillItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7A0 RID: 128928 RVA: 0x00A545DC File Offset: 0x00A527DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroSkillItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F7A1 RID: 128929 RVA: 0x00A54684 File Offset: 0x00A52884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			heroSkillItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7A2 RID: 128930 RVA: 0x00A546D8 File Offset: 0x00A528D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroSkillItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7A3 RID: 128931 RVA: 0x00A54744 File Offset: 0x00A52944
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
				HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroSkillItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroSkillItemUIController heroSkillItemUIController2 = (HeroSkillItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroSkillItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F7A4 RID: 128932 RVA: 0x00A54854 File Offset: 0x00A52A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkillItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7A5 RID: 128933 RVA: 0x00A548C0 File Offset: 0x00A52AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7A6 RID: 128934 RVA: 0x00A5492C File Offset: 0x00A52B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7A7 RID: 128935 RVA: 0x00A54998 File Offset: 0x00A52B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7A8 RID: 128936 RVA: 0x00A54A04 File Offset: 0x00A52C04
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
				HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroSkillItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroSkillItemUIController heroSkillItemUIController2 = (HeroSkillItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroSkillItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F7A9 RID: 128937 RVA: 0x00A54B14 File Offset: 0x00A52D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			string s = heroSkillItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F7AA RID: 128938 RVA: 0x00A54B70 File Offset: 0x00A52D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowDesc(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			HeroSkillItemUIController obj;
			LuaObject.checkType<HeroSkillItemUIController>(l, 2, out obj);
			heroSkillItemUIController.m_luaExportHelper.__callDele_EventOnShowDesc(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7AB RID: 128939 RVA: 0x00A54BCC File Offset: 0x00A52DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowDesc(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			HeroSkillItemUIController obj;
			LuaObject.checkType<HeroSkillItemUIController>(l, 2, out obj);
			heroSkillItemUIController.m_luaExportHelper.__clearDele_EventOnShowDesc(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7AC RID: 128940 RVA: 0x00A54C28 File Offset: 0x00A52E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowDesc(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			Action<HeroSkillItemUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroSkillItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSkillItemUIController.EventOnShowDesc += value;
				}
				else if (num == 2)
				{
					heroSkillItemUIController.EventOnShowDesc -= value;
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

	// Token: 0x0601F7AD RID: 128941 RVA: 0x00A54CA8 File Offset: 0x00A52EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillCost(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkillItemUIController.m_luaExportHelper.m_skillCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7AE RID: 128942 RVA: 0x00A54D00 File Offset: 0x00A52F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillCost(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			GameObject skillCost;
			LuaObject.checkType<GameObject>(l, 2, out skillCost);
			heroSkillItemUIController.m_luaExportHelper.m_skillCost = skillCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7AF RID: 128943 RVA: 0x00A54D5C File Offset: 0x00A52F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillCostBg(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkillItemUIController.m_luaExportHelper.m_skillCostBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7B0 RID: 128944 RVA: 0x00A54DB4 File Offset: 0x00A52FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillCostBg(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			GameObject skillCostBg;
			LuaObject.checkType<GameObject>(l, 2, out skillCostBg);
			heroSkillItemUIController.m_luaExportHelper.m_skillCostBg = skillCostBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7B1 RID: 128945 RVA: 0x00A54E10 File Offset: 0x00A53010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkillItemUIController.m_luaExportHelper.m_infoSelectPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7B2 RID: 128946 RVA: 0x00A54E68 File Offset: 0x00A53068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoSelectPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			GameObject infoSelectPanel;
			LuaObject.checkType<GameObject>(l, 2, out infoSelectPanel);
			heroSkillItemUIController.m_luaExportHelper.m_infoSelectPanel = infoSelectPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7B3 RID: 128947 RVA: 0x00A54EC4 File Offset: 0x00A530C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkillItemUIController.m_luaExportHelper.m_skillIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7B4 RID: 128948 RVA: 0x00A54F1C File Offset: 0x00A5311C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			Image skillIconImg;
			LuaObject.checkType<Image>(l, 2, out skillIconImg);
			heroSkillItemUIController.m_luaExportHelper.m_skillIconImg = skillIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7B5 RID: 128949 RVA: 0x00A54F78 File Offset: 0x00A53178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_limitTagObj(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkillItemUIController.m_luaExportHelper.m_limitTagObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7B6 RID: 128950 RVA: 0x00A54FD0 File Offset: 0x00A531D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_limitTagObj(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			GameObject limitTagObj;
			LuaObject.checkType<GameObject>(l, 2, out limitTagObj);
			heroSkillItemUIController.m_luaExportHelper.m_limitTagObj = limitTagObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7B7 RID: 128951 RVA: 0x00A5502C File Offset: 0x00A5322C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_passivityText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkillItemUIController.m_luaExportHelper.m_passivityText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7B8 RID: 128952 RVA: 0x00A55084 File Offset: 0x00A53284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_passivityText(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			GameObject passivityText;
			LuaObject.checkType<GameObject>(l, 2, out passivityText);
			heroSkillItemUIController.m_luaExportHelper.m_passivityText = passivityText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7B9 RID: 128953 RVA: 0x00A550E0 File Offset: 0x00A532E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_choosenImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkillItemUIController.m_luaExportHelper.m_choosenImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7BA RID: 128954 RVA: 0x00A55138 File Offset: 0x00A53338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_choosenImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			GameObject choosenImage;
			LuaObject.checkType<GameObject>(l, 2, out choosenImage);
			heroSkillItemUIController.m_luaExportHelper.m_choosenImage = choosenImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7BB RID: 128955 RVA: 0x00A55194 File Offset: 0x00A53394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkillItemUIController.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7BC RID: 128956 RVA: 0x00A551E8 File Offset: 0x00A533E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			heroSkillItemUIController.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7BD RID: 128957 RVA: 0x00A55240 File Offset: 0x00A53440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSkillLimited(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkillItemUIController.m_luaExportHelper.m_isSkillLimited);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7BE RID: 128958 RVA: 0x00A55298 File Offset: 0x00A53498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSkillLimited(IntPtr l)
	{
		int result;
		try
		{
			HeroSkillItemUIController heroSkillItemUIController = (HeroSkillItemUIController)LuaObject.checkSelf(l);
			bool isSkillLimited;
			LuaObject.checkType(l, 2, out isSkillLimited);
			heroSkillItemUIController.m_luaExportHelper.m_isSkillLimited = isSkillLimited;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F7BF RID: 128959 RVA: 0x00A552F4 File Offset: 0x00A534F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroSkillItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.InitSkillItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.SetSelectPanelActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.SetChoosenImageActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.SetLimitTagObjActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.SetCostPanelActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__callDele_EventOnShowDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.__clearDele_EventOnShowDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache15);
		string name = "EventOnShowDesc";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.set_EventOnShowDesc);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache16, true);
		string name2 = "m_skillCost";
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.get_m_skillCost);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.set_m_skillCost);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache18, true);
		string name3 = "m_skillCostBg";
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.get_m_skillCostBg);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.set_m_skillCostBg);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1A, true);
		string name4 = "m_infoSelectPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.get_m_infoSelectPanel);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.set_m_infoSelectPanel);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1C, true);
		string name5 = "m_skillIconImg";
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.get_m_skillIconImg);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.set_m_skillIconImg);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1E, true);
		string name6 = "m_limitTagObj";
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.get_m_limitTagObj);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.set_m_limitTagObj);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache20, true);
		string name7 = "m_passivityText";
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.get_m_passivityText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.set_m_passivityText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache22, true);
		string name8 = "m_choosenImage";
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.get_m_choosenImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.set_m_choosenImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache24, true);
		string name9 = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.get_m_skillInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.set_m_skillInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache26, true);
		string name10 = "m_isSkillLimited";
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.get_m_isSkillLimited);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.set_m_isSkillLimited);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroSkillItemUIController.<>f__mg$cache28, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroSkillItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040157B8 RID: 87992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040157B9 RID: 87993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040157BA RID: 87994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040157BB RID: 87995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040157BC RID: 87996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040157BD RID: 87997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040157BE RID: 87998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040157BF RID: 87999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040157C0 RID: 88000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040157C1 RID: 88001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040157C2 RID: 88002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040157C3 RID: 88003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040157C4 RID: 88004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040157C5 RID: 88005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040157C6 RID: 88006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040157C7 RID: 88007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040157C8 RID: 88008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040157C9 RID: 88009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040157CA RID: 88010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040157CB RID: 88011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040157CC RID: 88012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040157CD RID: 88013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040157CE RID: 88014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040157CF RID: 88015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040157D0 RID: 88016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040157D1 RID: 88017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040157D2 RID: 88018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040157D3 RID: 88019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040157D4 RID: 88020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040157D5 RID: 88021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040157D6 RID: 88022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040157D7 RID: 88023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040157D8 RID: 88024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040157D9 RID: 88025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040157DA RID: 88026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040157DB RID: 88027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040157DC RID: 88028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040157DD RID: 88029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040157DE RID: 88030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040157DF RID: 88031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040157E0 RID: 88032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;
}
