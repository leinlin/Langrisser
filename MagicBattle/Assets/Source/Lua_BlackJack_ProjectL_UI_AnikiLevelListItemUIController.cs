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

// Token: 0x02001360 RID: 4960
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController : LuaObject
{
	// Token: 0x0601AB6C RID: 109420 RVA: 0x007F5DDC File Offset: 0x007F3FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAnikiLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo anikiLevelInfo;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out anikiLevelInfo);
			anikiLevelListItemUIController.SetAnikiLevelInfo(anikiLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB6D RID: 109421 RVA: 0x007F5E34 File Offset: 0x007F4034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnikiLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo anikiLevelInfo = anikiLevelListItemUIController.GetAnikiLevelInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB6E RID: 109422 RVA: 0x007F5E88 File Offset: 0x007F4088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLocked(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			anikiLevelListItemUIController.SetLocked(locked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB6F RID: 109423 RVA: 0x007F5EE0 File Offset: 0x007F40E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			anikiLevelListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB70 RID: 109424 RVA: 0x007F5F34 File Offset: 0x007F4134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			anikiLevelListItemUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB71 RID: 109425 RVA: 0x007F5F88 File Offset: 0x007F4188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLockedButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			anikiLevelListItemUIController.m_luaExportHelper.OnLockedButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB72 RID: 109426 RVA: 0x007F5FDC File Offset: 0x007F41DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			anikiLevelListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB73 RID: 109427 RVA: 0x007F6048 File Offset: 0x007F4248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			anikiLevelListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB74 RID: 109428 RVA: 0x007F609C File Offset: 0x007F429C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			anikiLevelListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB75 RID: 109429 RVA: 0x007F60F0 File Offset: 0x007F42F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = anikiLevelListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601AB76 RID: 109430 RVA: 0x007F6198 File Offset: 0x007F4398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			anikiLevelListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB77 RID: 109431 RVA: 0x007F61EC File Offset: 0x007F43EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			anikiLevelListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB78 RID: 109432 RVA: 0x007F6258 File Offset: 0x007F4458
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
				AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				anikiLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				AnikiLevelListItemUIController anikiLevelListItemUIController2 = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				anikiLevelListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601AB79 RID: 109433 RVA: 0x007F6368 File Offset: 0x007F4568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB7A RID: 109434 RVA: 0x007F63D4 File Offset: 0x007F45D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB7B RID: 109435 RVA: 0x007F6440 File Offset: 0x007F4640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB7C RID: 109436 RVA: 0x007F64AC File Offset: 0x007F46AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB7D RID: 109437 RVA: 0x007F6518 File Offset: 0x007F4718
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
				AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				anikiLevelListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				AnikiLevelListItemUIController anikiLevelListItemUIController2 = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				anikiLevelListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601AB7E RID: 109438 RVA: 0x007F6628 File Offset: 0x007F4828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			string s = anikiLevelListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601AB7F RID: 109439 RVA: 0x007F6684 File Offset: 0x007F4884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			AnikiLevelListItemUIController obj;
			LuaObject.checkType<AnikiLevelListItemUIController>(l, 2, out obj);
			anikiLevelListItemUIController.m_luaExportHelper.__callDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB80 RID: 109440 RVA: 0x007F66E0 File Offset: 0x007F48E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			AnikiLevelListItemUIController obj;
			LuaObject.checkType<AnikiLevelListItemUIController>(l, 2, out obj);
			anikiLevelListItemUIController.m_luaExportHelper.__clearDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB81 RID: 109441 RVA: 0x007F673C File Offset: 0x007F493C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			Action<AnikiLevelListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<AnikiLevelListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					anikiLevelListItemUIController.EventOnStartButtonClick += value;
				}
				else if (num == 2)
				{
					anikiLevelListItemUIController.EventOnStartButtonClick -= value;
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

	// Token: 0x0601AB82 RID: 109442 RVA: 0x007F67BC File Offset: 0x007F49BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_icon1Image(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelListItemUIController.m_luaExportHelper.m_icon1Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB83 RID: 109443 RVA: 0x007F6814 File Offset: 0x007F4A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_icon1Image(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			Image icon1Image;
			LuaObject.checkType<Image>(l, 2, out icon1Image);
			anikiLevelListItemUIController.m_luaExportHelper.m_icon1Image = icon1Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB84 RID: 109444 RVA: 0x007F6870 File Offset: 0x007F4A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_icon2Image(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelListItemUIController.m_luaExportHelper.m_icon2Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB85 RID: 109445 RVA: 0x007F68C8 File Offset: 0x007F4AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_icon2Image(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			Image icon2Image;
			LuaObject.checkType<Image>(l, 2, out icon2Image);
			anikiLevelListItemUIController.m_luaExportHelper.m_icon2Image = icon2Image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB86 RID: 109446 RVA: 0x007F6924 File Offset: 0x007F4B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelListItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB87 RID: 109447 RVA: 0x007F697C File Offset: 0x007F4B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			anikiLevelListItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB88 RID: 109448 RVA: 0x007F69D8 File Offset: 0x007F4BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelListItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB89 RID: 109449 RVA: 0x007F6A30 File Offset: 0x007F4C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			anikiLevelListItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB8A RID: 109450 RVA: 0x007F6A8C File Offset: 0x007F4C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelListItemUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB8B RID: 109451 RVA: 0x007F6AE4 File Offset: 0x007F4CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			anikiLevelListItemUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB8C RID: 109452 RVA: 0x007F6B40 File Offset: 0x007F4D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelListItemUIController.m_luaExportHelper.m_lockedButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB8D RID: 109453 RVA: 0x007F6B98 File Offset: 0x007F4D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			Button lockedButton;
			LuaObject.checkType<Button>(l, 2, out lockedButton);
			anikiLevelListItemUIController.m_luaExportHelper.m_lockedButton = lockedButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB8E RID: 109454 RVA: 0x007F6BF4 File Offset: 0x007F4DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelListItemUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB8F RID: 109455 RVA: 0x007F6C4C File Offset: 0x007F4E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			anikiLevelListItemUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB90 RID: 109456 RVA: 0x007F6CA8 File Offset: 0x007F4EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB91 RID: 109457 RVA: 0x007F6D00 File Offset: 0x007F4F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject rewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGroupGameObject);
			anikiLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject = rewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB92 RID: 109458 RVA: 0x007F6D5C File Offset: 0x007F4F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_anikiLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiLevelListItemUIController.m_luaExportHelper.m_anikiLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB93 RID: 109459 RVA: 0x007F6DB4 File Offset: 0x007F4FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiLevelListItemUIController anikiLevelListItemUIController = (AnikiLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiLevelInfo anikiLevelInfo;
			LuaObject.checkType<ConfigDataAnikiLevelInfo>(l, 2, out anikiLevelInfo);
			anikiLevelListItemUIController.m_luaExportHelper.m_anikiLevelInfo = anikiLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB94 RID: 109460 RVA: 0x007F6E10 File Offset: 0x007F5010
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AnikiLevelListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.SetAnikiLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.GetAnikiLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.SetLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.OnLockedButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__callDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.__clearDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache14);
		string name = "EventOnStartButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.set_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache15, true);
		string name2 = "m_icon1Image";
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.get_m_icon1Image);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.set_m_icon1Image);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache17, true);
		string name3 = "m_icon2Image";
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.get_m_icon2Image);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.set_m_icon2Image);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache19, true);
		string name4 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.get_m_levelText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1B, true);
		string name5 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.get_m_nameText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1D, true);
		string name6 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.get_m_energyText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache1F, true);
		string name7 = "m_lockedButton";
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.get_m_lockedButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.set_m_lockedButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache21, true);
		string name8 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.get_m_startButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache23, true);
		string name9 = "m_rewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.get_m_rewardGroupGameObject);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.set_m_rewardGroupGameObject);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache25, true);
		string name10 = "m_anikiLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.get_m_anikiLevelInfo);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.set_m_anikiLevelInfo);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_AnikiLevelListItemUIController.<>f__mg$cache27, true);
		LuaObject.createTypeMetatable(l, null, typeof(AnikiLevelListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04010E8E RID: 69262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010E8F RID: 69263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010E90 RID: 69264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010E91 RID: 69265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010E92 RID: 69266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010E93 RID: 69267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010E94 RID: 69268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010E95 RID: 69269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010E96 RID: 69270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010E97 RID: 69271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010E98 RID: 69272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010E99 RID: 69273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010E9A RID: 69274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010E9B RID: 69275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010E9C RID: 69276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010E9D RID: 69277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010E9E RID: 69278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010E9F RID: 69279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010EA0 RID: 69280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010EA1 RID: 69281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010EA2 RID: 69282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010EA3 RID: 69283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010EA4 RID: 69284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010EA5 RID: 69285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010EA6 RID: 69286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010EA7 RID: 69287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010EA8 RID: 69288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010EA9 RID: 69289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010EAA RID: 69290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010EAB RID: 69291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010EAC RID: 69292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010EAD RID: 69293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010EAE RID: 69294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010EAF RID: 69295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010EB0 RID: 69296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010EB1 RID: 69297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010EB2 RID: 69298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010EB3 RID: 69299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010EB4 RID: 69300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010EB5 RID: 69301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
