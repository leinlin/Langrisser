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

// Token: 0x0200135D RID: 4957
[Preserve]
public class Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController : LuaObject
{
	// Token: 0x0601AB2A RID: 109354 RVA: 0x007F3DAC File Offset: 0x007F1FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAnikiGymInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo anikiGymInfo;
			LuaObject.checkType<ConfigDataAnikiGymInfo>(l, 2, out anikiGymInfo);
			anikiGymListItemUIController.SetAnikiGymInfo(anikiGymInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB2B RID: 109355 RVA: 0x007F3E04 File Offset: 0x007F2004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnikiGymInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo anikiGymInfo = anikiGymListItemUIController.GetAnikiGymInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB2C RID: 109356 RVA: 0x007F3E58 File Offset: 0x007F2058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLocked(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			anikiGymListItemUIController.SetLocked(locked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB2D RID: 109357 RVA: 0x007F3EB0 File Offset: 0x007F20B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLocked(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			bool b = anikiGymListItemUIController.IsLocked();
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

	// Token: 0x0601AB2E RID: 109358 RVA: 0x007F3F04 File Offset: 0x007F2104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelected(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			bool selected;
			LuaObject.checkType(l, 2, out selected);
			anikiGymListItemUIController.SetSelected(selected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB2F RID: 109359 RVA: 0x007F3F5C File Offset: 0x007F215C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSelected(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			bool b = anikiGymListItemUIController.IsSelected();
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

	// Token: 0x0601AB30 RID: 109360 RVA: 0x007F3FB0 File Offset: 0x007F21B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetExpireTime(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			DateTime expireTime;
			LuaObject.checkValueType<DateTime>(l, 2, out expireTime);
			anikiGymListItemUIController.SetExpireTime(expireTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB31 RID: 109361 RVA: 0x007F4008 File Offset: 0x007F2208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			anikiGymListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB32 RID: 109362 RVA: 0x007F405C File Offset: 0x007F225C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRemainTime(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			anikiGymListItemUIController.m_luaExportHelper.UpdateRemainTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB33 RID: 109363 RVA: 0x007F40B0 File Offset: 0x007F22B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			anikiGymListItemUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB34 RID: 109364 RVA: 0x007F4104 File Offset: 0x007F2304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			anikiGymListItemUIController.m_luaExportHelper.OnToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB35 RID: 109365 RVA: 0x007F4160 File Offset: 0x007F2360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNotOpenButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			anikiGymListItemUIController.m_luaExportHelper.OnNotOpenButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB36 RID: 109366 RVA: 0x007F41B4 File Offset: 0x007F23B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			anikiGymListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB37 RID: 109367 RVA: 0x007F4220 File Offset: 0x007F2420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			anikiGymListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB38 RID: 109368 RVA: 0x007F4274 File Offset: 0x007F2474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			anikiGymListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB39 RID: 109369 RVA: 0x007F42C8 File Offset: 0x007F24C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = anikiGymListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601AB3A RID: 109370 RVA: 0x007F4370 File Offset: 0x007F2570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			anikiGymListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB3B RID: 109371 RVA: 0x007F43C4 File Offset: 0x007F25C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			anikiGymListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB3C RID: 109372 RVA: 0x007F4430 File Offset: 0x007F2630
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
				AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				anikiGymListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				AnikiGymListItemUIController anikiGymListItemUIController2 = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				anikiGymListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601AB3D RID: 109373 RVA: 0x007F4540 File Offset: 0x007F2740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiGymListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB3E RID: 109374 RVA: 0x007F45AC File Offset: 0x007F27AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiGymListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB3F RID: 109375 RVA: 0x007F4618 File Offset: 0x007F2818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiGymListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB40 RID: 109376 RVA: 0x007F4684 File Offset: 0x007F2884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			anikiGymListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB41 RID: 109377 RVA: 0x007F46F0 File Offset: 0x007F28F0
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
				AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				anikiGymListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				AnikiGymListItemUIController anikiGymListItemUIController2 = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				anikiGymListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601AB42 RID: 109378 RVA: 0x007F4800 File Offset: 0x007F2A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			string s = anikiGymListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601AB43 RID: 109379 RVA: 0x007F485C File Offset: 0x007F2A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			AnikiGymListItemUIController arg2;
			LuaObject.checkType<AnikiGymListItemUIController>(l, 3, out arg2);
			anikiGymListItemUIController.m_luaExportHelper.__callDele_EventOnToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB44 RID: 109380 RVA: 0x007F48C8 File Offset: 0x007F2AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			AnikiGymListItemUIController arg2;
			LuaObject.checkType<AnikiGymListItemUIController>(l, 3, out arg2);
			anikiGymListItemUIController.m_luaExportHelper.__clearDele_EventOnToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB45 RID: 109381 RVA: 0x007F4934 File Offset: 0x007F2B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			Action<bool, AnikiGymListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<bool, AnikiGymListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					anikiGymListItemUIController.EventOnToggleValueChanged += value;
				}
				else if (num == 2)
				{
					anikiGymListItemUIController.EventOnToggleValueChanged -= value;
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

	// Token: 0x0601AB46 RID: 109382 RVA: 0x007F49B4 File Offset: 0x007F2BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB47 RID: 109383 RVA: 0x007F4A0C File Offset: 0x007F2C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			anikiGymListItemUIController.m_luaExportHelper.m_toggle = toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB48 RID: 109384 RVA: 0x007F4A68 File Offset: 0x007F2C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB49 RID: 109385 RVA: 0x007F4AC0 File Offset: 0x007F2CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			anikiGymListItemUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB4A RID: 109386 RVA: 0x007F4B1C File Offset: 0x007F2D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB4B RID: 109387 RVA: 0x007F4B74 File Offset: 0x007F2D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			anikiGymListItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB4C RID: 109388 RVA: 0x007F4BD0 File Offset: 0x007F2DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameTextGray(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_nameTextGray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB4D RID: 109389 RVA: 0x007F4C28 File Offset: 0x007F2E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameTextGray(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			Text nameTextGray;
			LuaObject.checkType<Text>(l, 2, out nameTextGray);
			anikiGymListItemUIController.m_luaExportHelper.m_nameTextGray = nameTextGray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB4E RID: 109390 RVA: 0x007F4C84 File Offset: 0x007F2E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB4F RID: 109391 RVA: 0x007F4CDC File Offset: 0x007F2EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			anikiGymListItemUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB50 RID: 109392 RVA: 0x007F4D38 File Offset: 0x007F2F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImageGray(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_iconImageGray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB51 RID: 109393 RVA: 0x007F4D90 File Offset: 0x007F2F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImageGray(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			Image iconImageGray;
			LuaObject.checkType<Image>(l, 2, out iconImageGray);
			anikiGymListItemUIController.m_luaExportHelper.m_iconImageGray = iconImageGray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB52 RID: 109394 RVA: 0x007F4DEC File Offset: 0x007F2FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_openTimeText(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_openTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB53 RID: 109395 RVA: 0x007F4E44 File Offset: 0x007F3044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_openTimeText(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			Text openTimeText;
			LuaObject.checkType<Text>(l, 2, out openTimeText);
			anikiGymListItemUIController.m_luaExportHelper.m_openTimeText = openTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB54 RID: 109396 RVA: 0x007F4EA0 File Offset: 0x007F30A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeGameObject(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_timeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB55 RID: 109397 RVA: 0x007F4EF8 File Offset: 0x007F30F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeGameObject(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			GameObject timeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out timeGameObject);
			anikiGymListItemUIController.m_luaExportHelper.m_timeGameObject = timeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB56 RID: 109398 RVA: 0x007F4F54 File Offset: 0x007F3154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_timeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB57 RID: 109399 RVA: 0x007F4FAC File Offset: 0x007F31AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeText(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			Text timeText;
			LuaObject.checkType<Text>(l, 2, out timeText);
			anikiGymListItemUIController.m_luaExportHelper.m_timeText = timeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB58 RID: 109400 RVA: 0x007F5008 File Offset: 0x007F3208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_notOpenButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_notOpenButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB59 RID: 109401 RVA: 0x007F5060 File Offset: 0x007F3260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_notOpenButton(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			Button notOpenButton;
			LuaObject.checkType<Button>(l, 2, out notOpenButton);
			anikiGymListItemUIController.m_luaExportHelper.m_notOpenButton = notOpenButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB5A RID: 109402 RVA: 0x007F50BC File Offset: 0x007F32BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_anikiGymInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_anikiGymInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB5B RID: 109403 RVA: 0x007F5114 File Offset: 0x007F3314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiGymInfo(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			ConfigDataAnikiGymInfo anikiGymInfo;
			LuaObject.checkType<ConfigDataAnikiGymInfo>(l, 2, out anikiGymInfo);
			anikiGymListItemUIController.m_luaExportHelper.m_anikiGymInfo = anikiGymInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB5C RID: 109404 RVA: 0x007F5170 File Offset: 0x007F3370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_isLocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB5D RID: 109405 RVA: 0x007F51C8 File Offset: 0x007F33C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			bool isLocked;
			LuaObject.checkType(l, 2, out isLocked);
			anikiGymListItemUIController.m_luaExportHelper.m_isLocked = isLocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB5E RID: 109406 RVA: 0x007F5224 File Offset: 0x007F3424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expireTime(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_expireTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB5F RID: 109407 RVA: 0x007F5280 File Offset: 0x007F3480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expireTime(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			DateTime expireTime;
			LuaObject.checkValueType<DateTime>(l, 2, out expireTime);
			anikiGymListItemUIController.m_luaExportHelper.m_expireTime = expireTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB60 RID: 109408 RVA: 0x007F52DC File Offset: 0x007F34DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_updateCountdown(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, anikiGymListItemUIController.m_luaExportHelper.m_updateCountdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB61 RID: 109409 RVA: 0x007F5334 File Offset: 0x007F3534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_updateCountdown(IntPtr l)
	{
		int result;
		try
		{
			AnikiGymListItemUIController anikiGymListItemUIController = (AnikiGymListItemUIController)LuaObject.checkSelf(l);
			float updateCountdown;
			LuaObject.checkType(l, 2, out updateCountdown);
			anikiGymListItemUIController.m_luaExportHelper.m_updateCountdown = updateCountdown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AB62 RID: 109410 RVA: 0x007F5390 File Offset: 0x007F3590
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.AnikiGymListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.SetAnikiGymInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.GetAnikiGymInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.SetLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.IsLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.SetSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.IsSelected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.SetExpireTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.UpdateRemainTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.OnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.OnNotOpenButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__callDele_EventOnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.__clearDele_EventOnToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1A);
		string name = "EventOnToggleValueChanged";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_EventOnToggleValueChanged);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1B, true);
		string name2 = "m_toggle";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_toggle);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_toggle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1D, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache1F, true);
		string name4 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_nameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache21, true);
		string name5 = "m_nameTextGray";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_nameTextGray);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_nameTextGray);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache23, true);
		string name6 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_iconImage);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache25, true);
		string name7 = "m_iconImageGray";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_iconImageGray);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_iconImageGray);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache27, true);
		string name8 = "m_openTimeText";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_openTimeText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_openTimeText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache29, true);
		string name9 = "m_timeGameObject";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_timeGameObject);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_timeGameObject);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2B, true);
		string name10 = "m_timeText";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_timeText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_timeText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2D, true);
		string name11 = "m_notOpenButton";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_notOpenButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_notOpenButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache2F, true);
		string name12 = "m_anikiGymInfo";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_anikiGymInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_anikiGymInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache31, true);
		string name13 = "m_isLocked";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_isLocked);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_isLocked);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache33, true);
		string name14 = "m_expireTime";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_expireTime);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_expireTime);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache35, true);
		string name15 = "m_updateCountdown";
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.get_m_updateCountdown);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.set_m_updateCountdown);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_AnikiGymListItemUIController.<>f__mg$cache37, true);
		LuaObject.createTypeMetatable(l, null, typeof(AnikiGymListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04010E52 RID: 69202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010E53 RID: 69203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010E54 RID: 69204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010E55 RID: 69205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010E56 RID: 69206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010E57 RID: 69207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010E58 RID: 69208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010E59 RID: 69209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010E5A RID: 69210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010E5B RID: 69211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010E5C RID: 69212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010E5D RID: 69213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010E5E RID: 69214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010E5F RID: 69215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010E60 RID: 69216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010E61 RID: 69217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010E62 RID: 69218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010E63 RID: 69219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010E64 RID: 69220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010E65 RID: 69221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010E66 RID: 69222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010E67 RID: 69223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010E68 RID: 69224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010E69 RID: 69225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010E6A RID: 69226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010E6B RID: 69227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010E6C RID: 69228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010E6D RID: 69229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010E6E RID: 69230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010E6F RID: 69231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010E70 RID: 69232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010E71 RID: 69233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04010E72 RID: 69234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04010E73 RID: 69235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04010E74 RID: 69236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010E75 RID: 69237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04010E76 RID: 69238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04010E77 RID: 69239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04010E78 RID: 69240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04010E79 RID: 69241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04010E7A RID: 69242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04010E7B RID: 69243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04010E7C RID: 69244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04010E7D RID: 69245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04010E7E RID: 69246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04010E7F RID: 69247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04010E80 RID: 69248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04010E81 RID: 69249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04010E82 RID: 69250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04010E83 RID: 69251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04010E84 RID: 69252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04010E85 RID: 69253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04010E86 RID: 69254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04010E87 RID: 69255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04010E88 RID: 69256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04010E89 RID: 69257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
