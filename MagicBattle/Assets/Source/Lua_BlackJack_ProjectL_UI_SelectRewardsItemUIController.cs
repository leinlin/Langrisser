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

// Token: 0x02001571 RID: 5489
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController : LuaObject
{
	// Token: 0x06020FD1 RID: 135121 RVA: 0x00B14C14 File Offset: 0x00B12E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSelectRewardsInfo(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			bool isNew;
			LuaObject.checkType(l, 3, out isNew);
			bool isFragment;
			LuaObject.checkType(l, 4, out isFragment);
			selectRewardsItemUIController.InitSelectRewardsInfo(goods, isNew, isFragment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FD2 RID: 135122 RVA: 0x00B14C88 File Offset: 0x00B12E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			selectRewardsItemUIController.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FD3 RID: 135123 RVA: 0x00B14CE0 File Offset: 0x00B12EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			selectRewardsItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FD4 RID: 135124 RVA: 0x00B14D34 File Offset: 0x00B12F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			selectRewardsItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FD5 RID: 135125 RVA: 0x00B14DA0 File Offset: 0x00B12FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			selectRewardsItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FD6 RID: 135126 RVA: 0x00B14DF4 File Offset: 0x00B12FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			selectRewardsItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FD7 RID: 135127 RVA: 0x00B14E48 File Offset: 0x00B13048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = selectRewardsItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020FD8 RID: 135128 RVA: 0x00B14EF0 File Offset: 0x00B130F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			selectRewardsItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FD9 RID: 135129 RVA: 0x00B14F44 File Offset: 0x00B13144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			selectRewardsItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FDA RID: 135130 RVA: 0x00B14FB0 File Offset: 0x00B131B0
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
				SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				selectRewardsItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SelectRewardsItemUIController selectRewardsItemUIController2 = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				selectRewardsItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020FDB RID: 135131 RVA: 0x00B150C0 File Offset: 0x00B132C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectRewardsItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FDC RID: 135132 RVA: 0x00B1512C File Offset: 0x00B1332C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectRewardsItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FDD RID: 135133 RVA: 0x00B15198 File Offset: 0x00B13398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectRewardsItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FDE RID: 135134 RVA: 0x00B15204 File Offset: 0x00B13404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			selectRewardsItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FDF RID: 135135 RVA: 0x00B15270 File Offset: 0x00B13470
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
				SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				selectRewardsItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SelectRewardsItemUIController selectRewardsItemUIController2 = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				selectRewardsItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020FE0 RID: 135136 RVA: 0x00B15380 File Offset: 0x00B13580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			string s = selectRewardsItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020FE1 RID: 135137 RVA: 0x00B153DC File Offset: 0x00B135DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_icon(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectRewardsItemUIController.m_luaExportHelper.m_icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FE2 RID: 135138 RVA: 0x00B15434 File Offset: 0x00B13634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_icon(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			Image icon;
			LuaObject.checkType<Image>(l, 2, out icon);
			selectRewardsItemUIController.m_luaExportHelper.m_icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FE3 RID: 135139 RVA: 0x00B15490 File Offset: 0x00B13690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frame(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectRewardsItemUIController.m_luaExportHelper.m_frame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FE4 RID: 135140 RVA: 0x00B154E8 File Offset: 0x00B136E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frame(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			Image frame;
			LuaObject.checkType<Image>(l, 2, out frame);
			selectRewardsItemUIController.m_luaExportHelper.m_frame = frame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FE5 RID: 135141 RVA: 0x00B15544 File Offset: 0x00B13744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stars(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectRewardsItemUIController.m_luaExportHelper.m_stars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FE6 RID: 135142 RVA: 0x00B1559C File Offset: 0x00B1379C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stars(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			GameObject stars;
			LuaObject.checkType<GameObject>(l, 2, out stars);
			selectRewardsItemUIController.m_luaExportHelper.m_stars = stars;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FE7 RID: 135143 RVA: 0x00B155F8 File Offset: 0x00B137F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectRewardsItemUIController.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FE8 RID: 135144 RVA: 0x00B15650 File Offset: 0x00B13850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			Text text;
			LuaObject.checkType<Text>(l, 2, out text);
			selectRewardsItemUIController.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FE9 RID: 135145 RVA: 0x00B156AC File Offset: 0x00B138AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_new(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectRewardsItemUIController.m_luaExportHelper.m_new);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FEA RID: 135146 RVA: 0x00B15704 File Offset: 0x00B13904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_new(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			GameObject @new;
			LuaObject.checkType<GameObject>(l, 2, out @new);
			selectRewardsItemUIController.m_luaExportHelper.m_new = @new;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FEB RID: 135147 RVA: 0x00B15760 File Offset: 0x00B13960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectRewardsItemUIController.m_luaExportHelper.m_ssrEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FEC RID: 135148 RVA: 0x00B157B8 File Offset: 0x00B139B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			GameObject ssrEffect;
			LuaObject.checkType<GameObject>(l, 2, out ssrEffect);
			selectRewardsItemUIController.m_luaExportHelper.m_ssrEffect = ssrEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FED RID: 135149 RVA: 0x00B15814 File Offset: 0x00B13A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrPieceEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectRewardsItemUIController.m_luaExportHelper.m_ssrPieceEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FEE RID: 135150 RVA: 0x00B1586C File Offset: 0x00B13A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrPieceEffect(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			GameObject ssrPieceEffect;
			LuaObject.checkType<GameObject>(l, 2, out ssrPieceEffect);
			selectRewardsItemUIController.m_luaExportHelper.m_ssrPieceEffect = ssrPieceEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FEF RID: 135151 RVA: 0x00B158C8 File Offset: 0x00B13AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goods(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectRewardsItemUIController.m_luaExportHelper.m_goods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FF0 RID: 135152 RVA: 0x00B15920 File Offset: 0x00B13B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goods(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			selectRewardsItemUIController.m_luaExportHelper.m_goods = goods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FF1 RID: 135153 RVA: 0x00B1597C File Offset: 0x00B13B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fragmentItemID(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selectRewardsItemUIController.m_luaExportHelper.m_fragmentItemID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FF2 RID: 135154 RVA: 0x00B159D4 File Offset: 0x00B13BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fragmentItemID(IntPtr l)
	{
		int result;
		try
		{
			SelectRewardsItemUIController selectRewardsItemUIController = (SelectRewardsItemUIController)LuaObject.checkSelf(l);
			int fragmentItemID;
			LuaObject.checkType(l, 2, out fragmentItemID);
			selectRewardsItemUIController.m_luaExportHelper.m_fragmentItemID = fragmentItemID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FF3 RID: 135155 RVA: 0x00B15A30 File Offset: 0x00B13C30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SelectRewardsItemUIController");
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.InitSelectRewardsInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cacheF);
		string name = "m_icon";
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.get_m_icon);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.set_m_icon);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache11, true);
		string name2 = "m_frame";
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.get_m_frame);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.set_m_frame);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache13, true);
		string name3 = "m_stars";
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.get_m_stars);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.set_m_stars);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache15, true);
		string name4 = "m_text";
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.get_m_text);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.set_m_text);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache17, true);
		string name5 = "m_new";
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.get_m_new);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.set_m_new);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache19, true);
		string name6 = "m_ssrEffect";
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.get_m_ssrEffect);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.set_m_ssrEffect);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1B, true);
		string name7 = "m_ssrPieceEffect";
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.get_m_ssrPieceEffect);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.set_m_ssrPieceEffect);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1D, true);
		string name8 = "m_goods";
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.get_m_goods);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.set_m_goods);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache1F, true);
		string name9 = "m_fragmentItemID";
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.get_m_fragmentItemID);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.set_m_fragmentItemID);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_SelectRewardsItemUIController.<>f__mg$cache21, true);
		LuaObject.createTypeMetatable(l, null, typeof(SelectRewardsItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016ED1 RID: 93905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016ED2 RID: 93906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016ED3 RID: 93907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016ED4 RID: 93908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016ED5 RID: 93909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016ED6 RID: 93910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016ED7 RID: 93911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016ED8 RID: 93912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016ED9 RID: 93913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016EDA RID: 93914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016EDB RID: 93915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016EDC RID: 93916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016EDD RID: 93917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016EDE RID: 93918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016EDF RID: 93919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016EE0 RID: 93920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016EE1 RID: 93921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016EE2 RID: 93922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016EE3 RID: 93923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016EE4 RID: 93924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016EE5 RID: 93925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016EE6 RID: 93926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016EE7 RID: 93927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016EE8 RID: 93928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016EE9 RID: 93929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016EEA RID: 93930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016EEB RID: 93931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016EEC RID: 93932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016EED RID: 93933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016EEE RID: 93934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016EEF RID: 93935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016EF0 RID: 93936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016EF1 RID: 93937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016EF2 RID: 93938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
