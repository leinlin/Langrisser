using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200145A RID: 5210
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GainRewardButton : LuaObject
{
	// Token: 0x0601E147 RID: 123207 RVA: 0x009A2C84 File Offset: 0x009A0E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetId(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			gainRewardButton.SetId(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E148 RID: 123208 RVA: 0x009A2CDC File Offset: 0x009A0EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetId(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			int id = gainRewardButton.GetId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E149 RID: 123209 RVA: 0x009A2D30 File Offset: 0x009A0F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNum(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			int num;
			LuaObject.checkType(l, 2, out num);
			gainRewardButton.SetNum(num);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E14A RID: 123210 RVA: 0x009A2D88 File Offset: 0x009A0F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNum(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			int num = gainRewardButton.GetNum();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, num);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E14B RID: 123211 RVA: 0x009A2DDC File Offset: 0x009A0FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStatus(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			GainRewardStatus status;
			LuaObject.checkEnum<GainRewardStatus>(l, 2, out status);
			gainRewardButton.SetStatus(status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E14C RID: 123212 RVA: 0x009A2E34 File Offset: 0x009A1034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStatus(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			GainRewardStatus status = gainRewardButton.GetStatus();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E14D RID: 123213 RVA: 0x009A2E88 File Offset: 0x009A1088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			gainRewardButton.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E14E RID: 123214 RVA: 0x009A2EDC File Offset: 0x009A10DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			gainRewardButton.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E14F RID: 123215 RVA: 0x009A2F30 File Offset: 0x009A1130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			gainRewardButton.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E150 RID: 123216 RVA: 0x009A2F9C File Offset: 0x009A119C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			gainRewardButton.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E151 RID: 123217 RVA: 0x009A2FF0 File Offset: 0x009A11F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			gainRewardButton.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E152 RID: 123218 RVA: 0x009A3044 File Offset: 0x009A1244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = gainRewardButton.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E153 RID: 123219 RVA: 0x009A30EC File Offset: 0x009A12EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			gainRewardButton.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E154 RID: 123220 RVA: 0x009A3140 File Offset: 0x009A1340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			gainRewardButton.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E155 RID: 123221 RVA: 0x009A31AC File Offset: 0x009A13AC
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
				GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				gainRewardButton.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GainRewardButton gainRewardButton2 = (GainRewardButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				gainRewardButton2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E156 RID: 123222 RVA: 0x009A32BC File Offset: 0x009A14BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			gainRewardButton.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E157 RID: 123223 RVA: 0x009A3328 File Offset: 0x009A1528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			gainRewardButton.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E158 RID: 123224 RVA: 0x009A3394 File Offset: 0x009A1594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			gainRewardButton.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E159 RID: 123225 RVA: 0x009A3400 File Offset: 0x009A1600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			gainRewardButton.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E15A RID: 123226 RVA: 0x009A346C File Offset: 0x009A166C
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
				GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				gainRewardButton.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GainRewardButton gainRewardButton2 = (GainRewardButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				gainRewardButton2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E15B RID: 123227 RVA: 0x009A357C File Offset: 0x009A177C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			string s = gainRewardButton.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E15C RID: 123228 RVA: 0x009A35D8 File Offset: 0x009A17D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			GainRewardButton obj;
			LuaObject.checkType<GainRewardButton>(l, 2, out obj);
			gainRewardButton.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E15D RID: 123229 RVA: 0x009A3634 File Offset: 0x009A1834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			GainRewardButton obj;
			LuaObject.checkType<GainRewardButton>(l, 2, out obj);
			gainRewardButton.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E15E RID: 123230 RVA: 0x009A3690 File Offset: 0x009A1890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			Action<GainRewardButton> value;
			int num = LuaObject.checkDelegate<Action<GainRewardButton>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					gainRewardButton.EventOnClick += value;
				}
				else if (num == 2)
				{
					gainRewardButton.EventOnClick -= value;
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

	// Token: 0x0601E15F RID: 123231 RVA: 0x009A3710 File Offset: 0x009A1910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gainRewardButton.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E160 RID: 123232 RVA: 0x009A3768 File Offset: 0x009A1968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			gainRewardButton.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E161 RID: 123233 RVA: 0x009A37C4 File Offset: 0x009A19C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_numText(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gainRewardButton.m_luaExportHelper.m_numText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E162 RID: 123234 RVA: 0x009A381C File Offset: 0x009A1A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_numText(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			Text numText;
			LuaObject.checkType<Text>(l, 2, out numText);
			gainRewardButton.m_luaExportHelper.m_numText = numText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E163 RID: 123235 RVA: 0x009A3878 File Offset: 0x009A1A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeGameObject(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gainRewardButton.m_luaExportHelper.m_closeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E164 RID: 123236 RVA: 0x009A38D0 File Offset: 0x009A1AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeGameObject(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			GameObject closeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out closeGameObject);
			gainRewardButton.m_luaExportHelper.m_closeGameObject = closeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E165 RID: 123237 RVA: 0x009A392C File Offset: 0x009A1B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_openGameObject(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gainRewardButton.m_luaExportHelper.m_openGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E166 RID: 123238 RVA: 0x009A3984 File Offset: 0x009A1B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_openGameObject(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			GameObject openGameObject;
			LuaObject.checkType<GameObject>(l, 2, out openGameObject);
			gainRewardButton.m_luaExportHelper.m_openGameObject = openGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E167 RID: 123239 RVA: 0x009A39E0 File Offset: 0x009A1BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_id(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gainRewardButton.m_luaExportHelper.m_id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E168 RID: 123240 RVA: 0x009A3A38 File Offset: 0x009A1C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_id(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			gainRewardButton.m_luaExportHelper.m_id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E169 RID: 123241 RVA: 0x009A3A94 File Offset: 0x009A1C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_num(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gainRewardButton.m_luaExportHelper.m_num);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E16A RID: 123242 RVA: 0x009A3AEC File Offset: 0x009A1CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_num(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			int num;
			LuaObject.checkType(l, 2, out num);
			gainRewardButton.m_luaExportHelper.m_num = num;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E16B RID: 123243 RVA: 0x009A3B48 File Offset: 0x009A1D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_status(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)gainRewardButton.m_luaExportHelper.m_status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E16C RID: 123244 RVA: 0x009A3BA0 File Offset: 0x009A1DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_status(IntPtr l)
	{
		int result;
		try
		{
			GainRewardButton gainRewardButton = (GainRewardButton)LuaObject.checkSelf(l);
			GainRewardStatus status;
			LuaObject.checkEnum<GainRewardStatus>(l, 2, out status);
			gainRewardButton.m_luaExportHelper.m_status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E16D RID: 123245 RVA: 0x009A3BFC File Offset: 0x009A1DFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GainRewardButton");
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.SetId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.GetId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.SetNum);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.GetNum);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.SetStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.GetStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache16);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache17, true);
		string name2 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.get_m_button);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.set_m_button);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache19, true);
		string name3 = "m_numText";
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.get_m_numText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.set_m_numText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1B, true);
		string name4 = "m_closeGameObject";
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.get_m_closeGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.set_m_closeGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1D, true);
		string name5 = "m_openGameObject";
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.get_m_openGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.set_m_openGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache1F, true);
		string name6 = "m_id";
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.get_m_id);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.set_m_id);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache21, true);
		string name7 = "m_num";
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.get_m_num);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.set_m_num);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache23, true);
		string name8 = "m_status";
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.get_m_status);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GainRewardButton.set_m_status);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GainRewardButton.<>f__mg$cache25, true);
		LuaObject.createTypeMetatable(l, null, typeof(GainRewardButton), typeof(UIControllerBase));
	}

	// Token: 0x04014275 RID: 82549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014276 RID: 82550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014277 RID: 82551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014278 RID: 82552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014279 RID: 82553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401427A RID: 82554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401427B RID: 82555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401427C RID: 82556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401427D RID: 82557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401427E RID: 82558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401427F RID: 82559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014280 RID: 82560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014281 RID: 82561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014282 RID: 82562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014283 RID: 82563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014284 RID: 82564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014285 RID: 82565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014286 RID: 82566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014287 RID: 82567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014288 RID: 82568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014289 RID: 82569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401428A RID: 82570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401428B RID: 82571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401428C RID: 82572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401428D RID: 82573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401428E RID: 82574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401428F RID: 82575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014290 RID: 82576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014291 RID: 82577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014292 RID: 82578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014293 RID: 82579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014294 RID: 82580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014295 RID: 82581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014296 RID: 82582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014297 RID: 82583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014298 RID: 82584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014299 RID: 82585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401429A RID: 82586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
