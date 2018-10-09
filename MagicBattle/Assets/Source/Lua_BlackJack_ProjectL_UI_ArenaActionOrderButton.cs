using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001368 RID: 4968
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton : LuaObject
{
	// Token: 0x0601AD08 RID: 109832 RVA: 0x00802C2C File Offset: 0x00800E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Destroy(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			arenaActionOrderButton.Destroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD09 RID: 109833 RVA: 0x00802C78 File Offset: 0x00800E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHero(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			arenaActionOrderButton.SetHero(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD0A RID: 109834 RVA: 0x00802CD0 File Offset: 0x00800ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHero(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			BattleHero hero = arenaActionOrderButton.GetHero();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD0B RID: 109835 RVA: 0x00802D24 File Offset: 0x00800F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			arenaActionOrderButton.SetIndex(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD0C RID: 109836 RVA: 0x00802D7C File Offset: 0x00800F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			int index = arenaActionOrderButton.GetIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD0D RID: 109837 RVA: 0x00802DD0 File Offset: 0x00800FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaActionOrderButton.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD0E RID: 109838 RVA: 0x00802E28 File Offset: 0x00801028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaActionOrderButton.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD0F RID: 109839 RVA: 0x00802E80 File Offset: 0x00801080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaActionOrderButton.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD10 RID: 109840 RVA: 0x00802ED8 File Offset: 0x008010D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrop(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaActionOrderButton.OnDrop(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD11 RID: 109841 RVA: 0x00802F30 File Offset: 0x00801130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			arenaActionOrderButton.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD12 RID: 109842 RVA: 0x00802F84 File Offset: 0x00801184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			arenaActionOrderButton.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD13 RID: 109843 RVA: 0x00802FD8 File Offset: 0x008011D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaActionOrderButton.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD14 RID: 109844 RVA: 0x00803044 File Offset: 0x00801244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			arenaActionOrderButton.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD15 RID: 109845 RVA: 0x00803098 File Offset: 0x00801298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			arenaActionOrderButton.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD16 RID: 109846 RVA: 0x008030EC File Offset: 0x008012EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arenaActionOrderButton.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601AD17 RID: 109847 RVA: 0x00803194 File Offset: 0x00801394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			arenaActionOrderButton.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD18 RID: 109848 RVA: 0x008031E8 File Offset: 0x008013E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaActionOrderButton.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD19 RID: 109849 RVA: 0x00803254 File Offset: 0x00801454
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
				ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaActionOrderButton.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaActionOrderButton arenaActionOrderButton2 = (ArenaActionOrderButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaActionOrderButton2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601AD1A RID: 109850 RVA: 0x00803364 File Offset: 0x00801564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaActionOrderButton.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD1B RID: 109851 RVA: 0x008033D0 File Offset: 0x008015D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaActionOrderButton.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD1C RID: 109852 RVA: 0x0080343C File Offset: 0x0080163C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaActionOrderButton.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD1D RID: 109853 RVA: 0x008034A8 File Offset: 0x008016A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaActionOrderButton.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD1E RID: 109854 RVA: 0x00803514 File Offset: 0x00801714
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
				ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaActionOrderButton.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaActionOrderButton arenaActionOrderButton2 = (ArenaActionOrderButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaActionOrderButton2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601AD1F RID: 109855 RVA: 0x00803624 File Offset: 0x00801824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			string s = arenaActionOrderButton.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601AD20 RID: 109856 RVA: 0x00803680 File Offset: 0x00801880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			ArenaActionOrderButton obj;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out obj);
			arenaActionOrderButton.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD21 RID: 109857 RVA: 0x008036DC File Offset: 0x008018DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			ArenaActionOrderButton obj;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out obj);
			arenaActionOrderButton.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD22 RID: 109858 RVA: 0x00803738 File Offset: 0x00801938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			ArenaActionOrderButton arg;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			arenaActionOrderButton.m_luaExportHelper.__callDele_EventOnBeginDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD23 RID: 109859 RVA: 0x008037A4 File Offset: 0x008019A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			ArenaActionOrderButton arg;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			arenaActionOrderButton.m_luaExportHelper.__clearDele_EventOnBeginDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD24 RID: 109860 RVA: 0x00803810 File Offset: 0x00801A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			ArenaActionOrderButton arg;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			arenaActionOrderButton.m_luaExportHelper.__callDele_EventOnEndDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD25 RID: 109861 RVA: 0x0080387C File Offset: 0x00801A7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			ArenaActionOrderButton arg;
			LuaObject.checkType<ArenaActionOrderButton>(l, 2, out arg);
			PointerEventData arg2;
			LuaObject.checkType<PointerEventData>(l, 3, out arg2);
			arenaActionOrderButton.m_luaExportHelper.__clearDele_EventOnEndDrag(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD26 RID: 109862 RVA: 0x008038E8 File Offset: 0x00801AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaActionOrderButton.m_luaExportHelper.__callDele_EventOnDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD27 RID: 109863 RVA: 0x00803944 File Offset: 0x00801B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaActionOrderButton.m_luaExportHelper.__clearDele_EventOnDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD28 RID: 109864 RVA: 0x008039A0 File Offset: 0x00801BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDrop(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaActionOrderButton.m_luaExportHelper.__callDele_EventOnDrop(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD29 RID: 109865 RVA: 0x008039FC File Offset: 0x00801BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDrop(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaActionOrderButton.m_luaExportHelper.__clearDele_EventOnDrop(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD2A RID: 109866 RVA: 0x00803A58 File Offset: 0x00801C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			Action<ArenaActionOrderButton> value;
			int num = LuaObject.checkDelegate<Action<ArenaActionOrderButton>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaActionOrderButton.EventOnClick += value;
				}
				else if (num == 2)
				{
					arenaActionOrderButton.EventOnClick -= value;
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

	// Token: 0x0601AD2B RID: 109867 RVA: 0x00803AD8 File Offset: 0x00801CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			Action<ArenaActionOrderButton, PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<ArenaActionOrderButton, PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaActionOrderButton.EventOnBeginDrag += value;
				}
				else if (num == 2)
				{
					arenaActionOrderButton.EventOnBeginDrag -= value;
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

	// Token: 0x0601AD2C RID: 109868 RVA: 0x00803B58 File Offset: 0x00801D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			Action<ArenaActionOrderButton, PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<ArenaActionOrderButton, PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaActionOrderButton.EventOnEndDrag += value;
				}
				else if (num == 2)
				{
					arenaActionOrderButton.EventOnEndDrag -= value;
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

	// Token: 0x0601AD2D RID: 109869 RVA: 0x00803BD8 File Offset: 0x00801DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaActionOrderButton.EventOnDrag += value;
				}
				else if (num == 2)
				{
					arenaActionOrderButton.EventOnDrag -= value;
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

	// Token: 0x0601AD2E RID: 109870 RVA: 0x00803C58 File Offset: 0x00801E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDrop(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaActionOrderButton.EventOnDrop += value;
				}
				else if (num == 2)
				{
					arenaActionOrderButton.EventOnDrop -= value;
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

	// Token: 0x0601AD2F RID: 109871 RVA: 0x00803CD8 File Offset: 0x00801ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaActionOrderButton.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD30 RID: 109872 RVA: 0x00803D30 File Offset: 0x00801F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			arenaActionOrderButton.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD31 RID: 109873 RVA: 0x00803D8C File Offset: 0x00801F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaActionOrderButton.m_luaExportHelper.m_heroIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD32 RID: 109874 RVA: 0x00803DE4 File Offset: 0x00801FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			Image heroIconImage;
			LuaObject.checkType<Image>(l, 2, out heroIconImage);
			arenaActionOrderButton.m_luaExportHelper.m_heroIconImage = heroIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD33 RID: 109875 RVA: 0x00803E40 File Offset: 0x00802040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaActionOrderButton.m_luaExportHelper.m_armyIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD34 RID: 109876 RVA: 0x00803E98 File Offset: 0x00802098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyIconImage(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			Image armyIconImage;
			LuaObject.checkType<Image>(l, 2, out armyIconImage);
			arenaActionOrderButton.m_luaExportHelper.m_armyIconImage = armyIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD35 RID: 109877 RVA: 0x00803EF4 File Offset: 0x008020F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaActionOrderButton.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD36 RID: 109878 RVA: 0x00803F4C File Offset: 0x0080214C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			arenaActionOrderButton.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD37 RID: 109879 RVA: 0x00803FA8 File Offset: 0x008021A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaActionOrderButton.m_luaExportHelper.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD38 RID: 109880 RVA: 0x00804000 File Offset: 0x00802200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			ArenaActionOrderButton arenaActionOrderButton = (ArenaActionOrderButton)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			arenaActionOrderButton.m_luaExportHelper.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AD39 RID: 109881 RVA: 0x0080405C File Offset: 0x0080225C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaActionOrderButton");
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.Destroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.SetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.GetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.SetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.GetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.OnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__clearDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__clearDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callDele_EventOnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__clearDele_EventOnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__callDele_EventOnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.__clearDele_EventOnDrop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache21);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache22, true);
		string name2 = "EventOnBeginDrag";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.set_EventOnBeginDrag);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache23, true);
		string name3 = "EventOnEndDrag";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.set_EventOnEndDrag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache24, true);
		string name4 = "EventOnDrag";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.set_EventOnDrag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache25, true);
		string name5 = "EventOnDrop";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.set_EventOnDrop);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache26, true);
		string name6 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.get_m_button);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.set_m_button);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache28, true);
		string name7 = "m_heroIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.get_m_heroIconImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.set_m_heroIconImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2A, true);
		string name8 = "m_armyIconImage";
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.get_m_armyIconImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.set_m_armyIconImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2C, true);
		string name9 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.get_m_hero);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.set_m_hero);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2E, true);
		string name10 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.get_m_index);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.set_m_index);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ArenaActionOrderButton.<>f__mg$cache30, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaActionOrderButton), typeof(UIControllerBase));
	}

	// Token: 0x0401101A RID: 69658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401101B RID: 69659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401101C RID: 69660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401101D RID: 69661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401101E RID: 69662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401101F RID: 69663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011020 RID: 69664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011021 RID: 69665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011022 RID: 69666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011023 RID: 69667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011024 RID: 69668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011025 RID: 69669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011026 RID: 69670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011027 RID: 69671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011028 RID: 69672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011029 RID: 69673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401102A RID: 69674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401102B RID: 69675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401102C RID: 69676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401102D RID: 69677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401102E RID: 69678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401102F RID: 69679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011030 RID: 69680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011031 RID: 69681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011032 RID: 69682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011033 RID: 69683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011034 RID: 69684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011035 RID: 69685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011036 RID: 69686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011037 RID: 69687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011038 RID: 69688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011039 RID: 69689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401103A RID: 69690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401103B RID: 69691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401103C RID: 69692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401103D RID: 69693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401103E RID: 69694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401103F RID: 69695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011040 RID: 69696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011041 RID: 69697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011042 RID: 69698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011043 RID: 69699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011044 RID: 69700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011045 RID: 69701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011046 RID: 69702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011047 RID: 69703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011048 RID: 69704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011049 RID: 69705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401104A RID: 69706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
