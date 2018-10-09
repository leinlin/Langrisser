using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200146A RID: 5226
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton : LuaObject
{
	// Token: 0x0601E2BD RID: 123581 RVA: 0x009AE4A8 File Offset: 0x009AC6A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetJobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			goddessDialogJobButton.SetJobConnectionInfo(jobConnectionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2BE RID: 123582 RVA: 0x009AE500 File Offset: 0x009AC700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetJobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo = goddessDialogJobButton.GetJobConnectionInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2BF RID: 123583 RVA: 0x009AE554 File Offset: 0x009AC754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			goddessDialogJobButton.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2C0 RID: 123584 RVA: 0x009AE5A8 File Offset: 0x009AC7A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			goddessDialogJobButton.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2C1 RID: 123585 RVA: 0x009AE5FC File Offset: 0x009AC7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			goddessDialogJobButton.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2C2 RID: 123586 RVA: 0x009AE650 File Offset: 0x009AC850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			Vector2 offset;
			LuaObject.checkType(l, 4, out offset);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 5, out parent);
			List<ReplaceAnim> replaceAnims;
			LuaObject.checkType<List<ReplaceAnim>>(l, 6, out replaceAnims);
			goddessDialogJobButton.m_luaExportHelper.CreateSpineGraphic(assetName, scale, offset, parent, replaceAnims);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2C3 RID: 123587 RVA: 0x009AE6E0 File Offset: 0x009AC8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			goddessDialogJobButton.m_luaExportHelper.DestroySpineGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2C4 RID: 123588 RVA: 0x009AE734 File Offset: 0x009AC934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			goddessDialogJobButton.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2C5 RID: 123589 RVA: 0x009AE7A0 File Offset: 0x009AC9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			goddessDialogJobButton.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2C6 RID: 123590 RVA: 0x009AE7F4 File Offset: 0x009AC9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			goddessDialogJobButton.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2C7 RID: 123591 RVA: 0x009AE848 File Offset: 0x009ACA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = goddessDialogJobButton.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E2C8 RID: 123592 RVA: 0x009AE8F0 File Offset: 0x009ACAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			goddessDialogJobButton.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2C9 RID: 123593 RVA: 0x009AE944 File Offset: 0x009ACB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			goddessDialogJobButton.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2CA RID: 123594 RVA: 0x009AE9B0 File Offset: 0x009ACBB0
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
				GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				goddessDialogJobButton.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GoddessDialogJobButton goddessDialogJobButton2 = (GoddessDialogJobButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				goddessDialogJobButton2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E2CB RID: 123595 RVA: 0x009AEAC0 File Offset: 0x009ACCC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogJobButton.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2CC RID: 123596 RVA: 0x009AEB2C File Offset: 0x009ACD2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogJobButton.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2CD RID: 123597 RVA: 0x009AEB98 File Offset: 0x009ACD98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogJobButton.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2CE RID: 123598 RVA: 0x009AEC04 File Offset: 0x009ACE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			goddessDialogJobButton.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2CF RID: 123599 RVA: 0x009AEC70 File Offset: 0x009ACE70
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
				GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				goddessDialogJobButton.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GoddessDialogJobButton goddessDialogJobButton2 = (GoddessDialogJobButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				goddessDialogJobButton2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E2D0 RID: 123600 RVA: 0x009AED80 File Offset: 0x009ACF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			string s = goddessDialogJobButton.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E2D1 RID: 123601 RVA: 0x009AEDDC File Offset: 0x009ACFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			GoddessDialogJobButton obj;
			LuaObject.checkType<GoddessDialogJobButton>(l, 2, out obj);
			goddessDialogJobButton.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2D2 RID: 123602 RVA: 0x009AEE38 File Offset: 0x009AD038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			GoddessDialogJobButton obj;
			LuaObject.checkType<GoddessDialogJobButton>(l, 2, out obj);
			goddessDialogJobButton.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2D3 RID: 123603 RVA: 0x009AEE94 File Offset: 0x009AD094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			Action<GoddessDialogJobButton> value;
			int num = LuaObject.checkDelegate<Action<GoddessDialogJobButton>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					goddessDialogJobButton.EventOnClick += value;
				}
				else if (num == 2)
				{
					goddessDialogJobButton.EventOnClick -= value;
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

	// Token: 0x0601E2D4 RID: 123604 RVA: 0x009AEF14 File Offset: 0x009AD114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogJobButton.m_luaExportHelper.m_buton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2D5 RID: 123605 RVA: 0x009AEF6C File Offset: 0x009AD16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buton(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			Button buton;
			LuaObject.checkType<Button>(l, 2, out buton);
			goddessDialogJobButton.m_luaExportHelper.m_buton = buton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2D6 RID: 123606 RVA: 0x009AEFC8 File Offset: 0x009AD1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyIconImage(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogJobButton.m_luaExportHelper.m_armyIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2D7 RID: 123607 RVA: 0x009AF020 File Offset: 0x009AD220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyIconImage(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			Image armyIconImage;
			LuaObject.checkType<Image>(l, 2, out armyIconImage);
			goddessDialogJobButton.m_luaExportHelper.m_armyIconImage = armyIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2D8 RID: 123608 RVA: 0x009AF07C File Offset: 0x009AD27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameTex(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogJobButton.m_luaExportHelper.m_nameTex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2D9 RID: 123609 RVA: 0x009AF0D4 File Offset: 0x009AD2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameTex(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			Text nameTex;
			LuaObject.checkType<Text>(l, 2, out nameTex);
			goddessDialogJobButton.m_luaExportHelper.m_nameTex = nameTex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2DA RID: 123610 RVA: 0x009AF130 File Offset: 0x009AD330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descTex(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogJobButton.m_luaExportHelper.m_descTex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2DB RID: 123611 RVA: 0x009AF188 File Offset: 0x009AD388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descTex(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			Text descTex;
			LuaObject.checkType<Text>(l, 2, out descTex);
			goddessDialogJobButton.m_luaExportHelper.m_descTex = descTex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2DC RID: 123612 RVA: 0x009AF1E4 File Offset: 0x009AD3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogJobButton.m_luaExportHelper.m_graphicGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2DD RID: 123613 RVA: 0x009AF23C File Offset: 0x009AD43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicGameObject(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			GameObject graphicGameObject;
			LuaObject.checkType<GameObject>(l, 2, out graphicGameObject);
			goddessDialogJobButton.m_luaExportHelper.m_graphicGameObject = graphicGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2DE RID: 123614 RVA: 0x009AF298 File Offset: 0x009AD498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogJobButton.m_luaExportHelper.m_jobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2DF RID: 123615 RVA: 0x009AF2F0 File Offset: 0x009AD4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			goddessDialogJobButton.m_luaExportHelper.m_jobConnectionInfo = jobConnectionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2E0 RID: 123616 RVA: 0x009AF34C File Offset: 0x009AD54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goddessDialogJobButton.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2E1 RID: 123617 RVA: 0x009AF3A4 File Offset: 0x009AD5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			GoddessDialogJobButton goddessDialogJobButton = (GoddessDialogJobButton)LuaObject.checkSelf(l);
			UISpineGraphic graphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out graphic);
			goddessDialogJobButton.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E2E2 RID: 123618 RVA: 0x009AF400 File Offset: 0x009AD600
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GoddessDialogJobButton");
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.SetJobConnectionInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.GetJobConnectionInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache15);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache16, true);
		string name2 = "m_buton";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.get_m_buton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.set_m_buton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache18, true);
		string name3 = "m_armyIconImage";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.get_m_armyIconImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.set_m_armyIconImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1A, true);
		string name4 = "m_nameTex";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.get_m_nameTex);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.set_m_nameTex);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1C, true);
		string name5 = "m_descTex";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.get_m_descTex);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.set_m_descTex);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1E, true);
		string name6 = "m_graphicGameObject";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.get_m_graphicGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.set_m_graphicGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache20, true);
		string name7 = "m_jobConnectionInfo";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.get_m_jobConnectionInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.set_m_jobConnectionInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache22, true);
		string name8 = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.get_m_graphic);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.set_m_graphic);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GoddessDialogJobButton.<>f__mg$cache24, true);
		LuaObject.createTypeMetatable(l, null, typeof(GoddessDialogJobButton), typeof(UIControllerBase));
	}

	// Token: 0x040143CB RID: 82891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040143CC RID: 82892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040143CD RID: 82893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040143CE RID: 82894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040143CF RID: 82895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040143D0 RID: 82896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040143D1 RID: 82897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040143D2 RID: 82898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040143D3 RID: 82899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040143D4 RID: 82900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040143D5 RID: 82901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040143D6 RID: 82902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040143D7 RID: 82903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040143D8 RID: 82904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040143D9 RID: 82905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040143DA RID: 82906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040143DB RID: 82907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040143DC RID: 82908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040143DD RID: 82909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040143DE RID: 82910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040143DF RID: 82911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040143E0 RID: 82912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040143E1 RID: 82913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040143E2 RID: 82914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040143E3 RID: 82915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040143E4 RID: 82916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040143E5 RID: 82917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040143E6 RID: 82918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040143E7 RID: 82919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040143E8 RID: 82920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040143E9 RID: 82921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040143EA RID: 82922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040143EB RID: 82923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040143EC RID: 82924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040143ED RID: 82925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040143EE RID: 82926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040143EF RID: 82927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;
}
