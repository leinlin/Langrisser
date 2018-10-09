using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200157D RID: 5501
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller : LuaObject
{
	// Token: 0x0602116B RID: 135531 RVA: 0x00B21A9C File Offset: 0x00B1FC9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			smallExpressionItemContrller.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602116C RID: 135532 RVA: 0x00B21AE8 File Offset: 0x00B1FCE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterUIEvent(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			Action<SmallExpressionItemContrller> action;
			LuaObject.checkDelegate<Action<SmallExpressionItemContrller>>(l, 2, out action);
			smallExpressionItemContrller.RegisterUIEvent(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602116D RID: 135533 RVA: 0x00B21B40 File Offset: 0x00B1FD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetExpressionIcon(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			Sprite expressionIcon;
			LuaObject.checkType<Sprite>(l, 2, out expressionIcon);
			smallExpressionItemContrller.SetExpressionIcon(expressionIcon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602116E RID: 135534 RVA: 0x00B21B98 File Offset: 0x00B1FD98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectExpressionAsset_s(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller.CollectExpressionAsset();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602116F RID: 135535 RVA: 0x00B21BD8 File Offset: 0x00B1FDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			smallExpressionItemContrller.m_luaExportHelper.OnExpressionClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021170 RID: 135536 RVA: 0x00B21C2C File Offset: 0x00B1FE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			smallExpressionItemContrller.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021171 RID: 135537 RVA: 0x00B21C98 File Offset: 0x00B1FE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			smallExpressionItemContrller.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021172 RID: 135538 RVA: 0x00B21CEC File Offset: 0x00B1FEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			smallExpressionItemContrller.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021173 RID: 135539 RVA: 0x00B21D40 File Offset: 0x00B1FF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = smallExpressionItemContrller.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021174 RID: 135540 RVA: 0x00B21DE8 File Offset: 0x00B1FFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			smallExpressionItemContrller.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021175 RID: 135541 RVA: 0x00B21E3C File Offset: 0x00B2003C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			smallExpressionItemContrller.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021176 RID: 135542 RVA: 0x00B21EA8 File Offset: 0x00B200A8
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
				SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				smallExpressionItemContrller.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SmallExpressionItemContrller smallExpressionItemContrller2 = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				smallExpressionItemContrller2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021177 RID: 135543 RVA: 0x00B21FB8 File Offset: 0x00B201B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			smallExpressionItemContrller.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021178 RID: 135544 RVA: 0x00B22024 File Offset: 0x00B20224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			smallExpressionItemContrller.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021179 RID: 135545 RVA: 0x00B22090 File Offset: 0x00B20290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			smallExpressionItemContrller.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602117A RID: 135546 RVA: 0x00B220FC File Offset: 0x00B202FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			smallExpressionItemContrller.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602117B RID: 135547 RVA: 0x00B22168 File Offset: 0x00B20368
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
				SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				smallExpressionItemContrller.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SmallExpressionItemContrller smallExpressionItemContrller2 = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				smallExpressionItemContrller2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602117C RID: 135548 RVA: 0x00B22278 File Offset: 0x00B20478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			string s = smallExpressionItemContrller.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602117D RID: 135549 RVA: 0x00B222D4 File Offset: 0x00B204D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			SmallExpressionItemContrller obj;
			LuaObject.checkType<SmallExpressionItemContrller>(l, 2, out obj);
			smallExpressionItemContrller.m_luaExportHelper.__callDele_EventOnExpressionClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602117E RID: 135550 RVA: 0x00B22330 File Offset: 0x00B20530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			SmallExpressionItemContrller obj;
			LuaObject.checkType<SmallExpressionItemContrller>(l, 2, out obj);
			smallExpressionItemContrller.m_luaExportHelper.__clearDele_EventOnExpressionClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602117F RID: 135551 RVA: 0x00B2238C File Offset: 0x00B2058C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnExpressionClick(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			Action<SmallExpressionItemContrller> value;
			int num = LuaObject.checkDelegate<Action<SmallExpressionItemContrller>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					smallExpressionItemContrller.EventOnExpressionClick += value;
				}
				else if (num == 2)
				{
					smallExpressionItemContrller.EventOnExpressionClick -= value;
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

	// Token: 0x06021180 RID: 135552 RVA: 0x00B2240C File Offset: 0x00B2060C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_key(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, smallExpressionItemContrller.m_key);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021181 RID: 135553 RVA: 0x00B22460 File Offset: 0x00B20660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_key(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			int key;
			LuaObject.checkType(l, 2, out key);
			smallExpressionItemContrller.m_key = key;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021182 RID: 135554 RVA: 0x00B224B8 File Offset: 0x00B206B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_assetPath(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, smallExpressionItemContrller.m_assetPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021183 RID: 135555 RVA: 0x00B2250C File Offset: 0x00B2070C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_assetPath(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			string assetPath;
			LuaObject.checkType(l, 2, out assetPath);
			smallExpressionItemContrller.m_assetPath = assetPath;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021184 RID: 135556 RVA: 0x00B22564 File Offset: 0x00B20764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_icon(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, smallExpressionItemContrller.m_luaExportHelper.m_icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021185 RID: 135557 RVA: 0x00B225BC File Offset: 0x00B207BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_icon(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			Image icon;
			LuaObject.checkType<Image>(l, 2, out icon);
			smallExpressionItemContrller.m_luaExportHelper.m_icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021186 RID: 135558 RVA: 0x00B22618 File Offset: 0x00B20818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, smallExpressionItemContrller.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021187 RID: 135559 RVA: 0x00B22670 File Offset: 0x00B20870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			SmallExpressionItemContrller smallExpressionItemContrller = (SmallExpressionItemContrller)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			smallExpressionItemContrller.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021188 RID: 135560 RVA: 0x00B226CC File Offset: 0x00B208CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SmallExpressionItemContrller");
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.RegisterUIEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.SetExpressionIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.CollectExpressionAsset_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.OnExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__callDele_EventOnExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.__clearDele_EventOnExpressionClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache13);
		string name = "EventOnExpressionClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.set_EventOnExpressionClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache14, true);
		string name2 = "m_key";
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.get_m_key);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.set_m_key);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache16, true);
		string name3 = "m_assetPath";
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.get_m_assetPath);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.set_m_assetPath);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache18, true);
		string name4 = "m_icon";
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.get_m_icon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.set_m_icon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1A, true);
		string name5 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.get_m_button);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.set_m_button);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SmallExpressionItemContrller.<>f__mg$cache1C, true);
		LuaObject.createTypeMetatable(l, null, typeof(SmallExpressionItemContrller), typeof(UIControllerBase));
	}

	// Token: 0x04017053 RID: 94291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017054 RID: 94292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017055 RID: 94293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017056 RID: 94294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017057 RID: 94295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017058 RID: 94296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017059 RID: 94297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401705A RID: 94298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401705B RID: 94299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401705C RID: 94300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401705D RID: 94301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401705E RID: 94302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401705F RID: 94303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017060 RID: 94304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017061 RID: 94305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017062 RID: 94306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017063 RID: 94307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017064 RID: 94308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017065 RID: 94309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017066 RID: 94310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017067 RID: 94311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017068 RID: 94312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017069 RID: 94313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401706A RID: 94314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401706B RID: 94315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401706C RID: 94316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401706D RID: 94317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401706E RID: 94318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401706F RID: 94319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
