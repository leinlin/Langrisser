using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001518 RID: 5400
[Preserve]
public class Lua_BlackJack_ProjectL_UI_NoticeUIController : LuaObject
{
	// Token: 0x06020041 RID: 131137 RVA: 0x00A98890 File Offset: 0x00A96A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			noticeUIController.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020042 RID: 131138 RVA: 0x00A988DC File Offset: 0x00A96ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowNotice(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			string txt;
			LuaObject.checkType(l, 2, out txt);
			string stateName;
			LuaObject.checkType(l, 3, out stateName);
			ChatChannel chatChannel;
			LuaObject.checkEnum<ChatChannel>(l, 4, out chatChannel);
			bool isVoiceMsg;
			LuaObject.checkType(l, 5, out isVoiceMsg);
			noticeUIController.ShowNotice(txt, stateName, chatChannel, isVoiceMsg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020043 RID: 131139 RVA: 0x00A9895C File Offset: 0x00A96B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPositionState(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			string positionState;
			LuaObject.checkType(l, 2, out positionState);
			noticeUIController.SetPositionState(positionState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020044 RID: 131140 RVA: 0x00A989B4 File Offset: 0x00A96BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			noticeUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020045 RID: 131141 RVA: 0x00A98A08 File Offset: 0x00A96C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowNextNotice(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			noticeUIController.m_luaExportHelper.ShowNextNotice();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020046 RID: 131142 RVA: 0x00A98A5C File Offset: 0x00A96C5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnNoticeShowTweenFinished(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			noticeUIController.m_luaExportHelper.OnNoticeShowTweenFinished();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020047 RID: 131143 RVA: 0x00A98AB0 File Offset: 0x00A96CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNoticeMoveTweenFinished(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			noticeUIController.m_luaExportHelper.OnNoticeMoveTweenFinished();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020048 RID: 131144 RVA: 0x00A98B04 File Offset: 0x00A96D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DelayHideNotice(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			float additiveTime;
			LuaObject.checkType(l, 3, out additiveTime);
			IEnumerator o = noticeUIController.m_luaExportHelper.DelayHideNotice(time, additiveTime);
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

	// Token: 0x06020049 RID: 131145 RVA: 0x00A98B78 File Offset: 0x00A96D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNoticeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			noticeUIController.m_luaExportHelper.OnNoticeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602004A RID: 131146 RVA: 0x00A98BCC File Offset: 0x00A96DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			noticeUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602004B RID: 131147 RVA: 0x00A98C38 File Offset: 0x00A96E38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			noticeUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602004C RID: 131148 RVA: 0x00A98C8C File Offset: 0x00A96E8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			noticeUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602004D RID: 131149 RVA: 0x00A98CE0 File Offset: 0x00A96EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = noticeUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602004E RID: 131150 RVA: 0x00A98D88 File Offset: 0x00A96F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			noticeUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602004F RID: 131151 RVA: 0x00A98DDC File Offset: 0x00A96FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			noticeUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020050 RID: 131152 RVA: 0x00A98E48 File Offset: 0x00A97048
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
				NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				noticeUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				NoticeUIController noticeUIController2 = (NoticeUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				noticeUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020051 RID: 131153 RVA: 0x00A98F58 File Offset: 0x00A97158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			noticeUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020052 RID: 131154 RVA: 0x00A98FC4 File Offset: 0x00A971C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			noticeUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020053 RID: 131155 RVA: 0x00A99030 File Offset: 0x00A97230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			noticeUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020054 RID: 131156 RVA: 0x00A9909C File Offset: 0x00A9729C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			noticeUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020055 RID: 131157 RVA: 0x00A99108 File Offset: 0x00A97308
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
				NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				noticeUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				NoticeUIController noticeUIController2 = (NoticeUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				noticeUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020056 RID: 131158 RVA: 0x00A99218 File Offset: 0x00A97418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			string s = noticeUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020057 RID: 131159 RVA: 0x00A99274 File Offset: 0x00A97474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNoticeClick(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			NoticeText obj;
			LuaObject.checkType<NoticeText>(l, 2, out obj);
			noticeUIController.m_luaExportHelper.__callDele_EventOnNoticeClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020058 RID: 131160 RVA: 0x00A992D0 File Offset: 0x00A974D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNoticeClick(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			NoticeText obj;
			LuaObject.checkType<NoticeText>(l, 2, out obj);
			noticeUIController.m_luaExportHelper.__clearDele_EventOnNoticeClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020059 RID: 131161 RVA: 0x00A9932C File Offset: 0x00A9752C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNoticeClick(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			Action<NoticeText> value;
			int num = LuaObject.checkDelegate<Action<NoticeText>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					noticeUIController.EventOnNoticeClick += value;
				}
				else if (num == 2)
				{
					noticeUIController.EventOnNoticeClick -= value;
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

	// Token: 0x0602005A RID: 131162 RVA: 0x00A993AC File Offset: 0x00A975AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeButton(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_noticeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602005B RID: 131163 RVA: 0x00A99404 File Offset: 0x00A97604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeButton(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			Button noticeButton;
			LuaObject.checkType<Button>(l, 2, out noticeButton);
			noticeUIController.m_luaExportHelper.m_noticeButton = noticeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602005C RID: 131164 RVA: 0x00A99460 File Offset: 0x00A97660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeDetailGo(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_noticeDetailGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602005D RID: 131165 RVA: 0x00A994B8 File Offset: 0x00A976B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeDetailGo(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			GameObject noticeDetailGo;
			LuaObject.checkType<GameObject>(l, 2, out noticeDetailGo);
			noticeUIController.m_luaExportHelper.m_noticeDetailGo = noticeDetailGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602005E RID: 131166 RVA: 0x00A99514 File Offset: 0x00A97714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeText(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_noticeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602005F RID: 131167 RVA: 0x00A9956C File Offset: 0x00A9776C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeText(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			EmojiText noticeText;
			LuaObject.checkType<EmojiText>(l, 2, out noticeText);
			noticeUIController.m_luaExportHelper.m_noticeText = noticeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020060 RID: 131168 RVA: 0x00A995C8 File Offset: 0x00A977C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeVoiceImage(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_noticeVoiceImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020061 RID: 131169 RVA: 0x00A99620 File Offset: 0x00A97820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeVoiceImage(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			GameObject noticeVoiceImage;
			LuaObject.checkType<GameObject>(l, 2, out noticeVoiceImage);
			noticeUIController.m_luaExportHelper.m_noticeVoiceImage = noticeVoiceImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020062 RID: 131170 RVA: 0x00A9967C File Offset: 0x00A9787C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020063 RID: 131171 RVA: 0x00A996D4 File Offset: 0x00A978D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			noticeUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020064 RID: 131172 RVA: 0x00A99730 File Offset: 0x00A97930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expressionParseDesc(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_expressionParseDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020065 RID: 131173 RVA: 0x00A99788 File Offset: 0x00A97988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expressionParseDesc(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			SmallExpressionParseDesc expressionParseDesc;
			LuaObject.checkType<SmallExpressionParseDesc>(l, 2, out expressionParseDesc);
			noticeUIController.m_luaExportHelper.m_expressionParseDesc = expressionParseDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020066 RID: 131174 RVA: 0x00A997E4 File Offset: 0x00A979E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_expressionResContainer(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_expressionResContainer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020067 RID: 131175 RVA: 0x00A9983C File Offset: 0x00A97A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_expressionResContainer(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			PrefabResourceContainer expressionResContainer;
			LuaObject.checkType<PrefabResourceContainer>(l, 2, out expressionResContainer);
			noticeUIController.m_luaExportHelper.m_expressionResContainer = expressionResContainer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020068 RID: 131176 RVA: 0x00A99898 File Offset: 0x00A97A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_isForceHide(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NoticeUIController.LuaExportHelper.s_isForceHide);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020069 RID: 131177 RVA: 0x00A998E0 File Offset: 0x00A97AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_isForceHide(IntPtr l)
	{
		int result;
		try
		{
			bool s_isForceHide;
			LuaObject.checkType(l, 2, out s_isForceHide);
			NoticeUIController.LuaExportHelper.s_isForceHide = s_isForceHide;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602006A RID: 131178 RVA: 0x00A9992C File Offset: 0x00A97B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NoticeUIController.LuaExportHelper.s_instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602006B RID: 131179 RVA: 0x00A99974 File Offset: 0x00A97B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_instance(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController s_instance;
			LuaObject.checkType<NoticeUIController>(l, 2, out s_instance);
			NoticeUIController.LuaExportHelper.s_instance = s_instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602006C RID: 131180 RVA: 0x00A999C0 File Offset: 0x00A97BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NoticeTweenSpeed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NoticeUIController.LuaExportHelper.NoticeTweenSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602006D RID: 131181 RVA: 0x00A99A08 File Offset: 0x00A97C08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ShowNoticeInterval(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NoticeUIController.LuaExportHelper.ShowNoticeInterval);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602006E RID: 131182 RVA: 0x00A99A50 File Offset: 0x00A97C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShowNoticeTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NoticeUIController.LuaExportHelper.ShowNoticeTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602006F RID: 131183 RVA: 0x00A99A98 File Offset: 0x00A97C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeTextInitPos(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_noticeTextInitPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020070 RID: 131184 RVA: 0x00A99AF0 File Offset: 0x00A97CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeTextInitPos(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			Vector3 noticeTextInitPos;
			LuaObject.checkType(l, 2, out noticeTextInitPos);
			noticeUIController.m_luaExportHelper.m_noticeTextInitPos = noticeTextInitPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020071 RID: 131185 RVA: 0x00A99B4C File Offset: 0x00A97D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeTextInitWidth(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_noticeTextInitWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020072 RID: 131186 RVA: 0x00A99BA4 File Offset: 0x00A97DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeTextInitWidth(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			float noticeTextInitWidth;
			LuaObject.checkType(l, 2, out noticeTextInitWidth);
			noticeUIController.m_luaExportHelper.m_noticeTextInitWidth = noticeTextInitWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020073 RID: 131187 RVA: 0x00A99C00 File Offset: 0x00A97E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_delayHideNoticeCoroutine(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_delayHideNoticeCoroutine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020074 RID: 131188 RVA: 0x00A99C58 File Offset: 0x00A97E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_delayHideNoticeCoroutine(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			Coroutine delayHideNoticeCoroutine;
			LuaObject.checkType<Coroutine>(l, 2, out delayHideNoticeCoroutine);
			noticeUIController.m_luaExportHelper.m_delayHideNoticeCoroutine = delayHideNoticeCoroutine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020075 RID: 131189 RVA: 0x00A99CB4 File Offset: 0x00A97EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeShowTween(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_noticeShowTween);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020076 RID: 131190 RVA: 0x00A99D0C File Offset: 0x00A97F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeShowTween(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			TweenPos noticeShowTween;
			LuaObject.checkType<TweenPos>(l, 2, out noticeShowTween);
			noticeUIController.m_luaExportHelper.m_noticeShowTween = noticeShowTween;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020077 RID: 131191 RVA: 0x00A99D68 File Offset: 0x00A97F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeMoveTween(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_noticeMoveTween);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020078 RID: 131192 RVA: 0x00A99DC0 File Offset: 0x00A97FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeMoveTween(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			TweenPos noticeMoveTween;
			LuaObject.checkType<TweenPos>(l, 2, out noticeMoveTween);
			noticeUIController.m_luaExportHelper.m_noticeMoveTween = noticeMoveTween;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020079 RID: 131193 RVA: 0x00A99E1C File Offset: 0x00A9801C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentNoticeText(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_currentNoticeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602007A RID: 131194 RVA: 0x00A99E74 File Offset: 0x00A98074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_currentNoticeText(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			NoticeText currentNoticeText;
			LuaObject.checkType<NoticeText>(l, 2, out currentNoticeText);
			noticeUIController.m_luaExportHelper.m_currentNoticeText = currentNoticeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602007B RID: 131195 RVA: 0x00A99ED0 File Offset: 0x00A980D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, noticeUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602007C RID: 131196 RVA: 0x00A99F28 File Offset: 0x00A98128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			NoticeUIController noticeUIController = (NoticeUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			noticeUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602007D RID: 131197 RVA: 0x00A99F84 File Offset: 0x00A98184
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsForceHide(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, NoticeUIController.IsForceHide);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602007E RID: 131198 RVA: 0x00A99FCC File Offset: 0x00A981CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsForceHide(IntPtr l)
	{
		int result;
		try
		{
			bool isForceHide;
			LuaObject.checkType(l, 2, out isForceHide);
			NoticeUIController.IsForceHide = isForceHide;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602007F RID: 131199 RVA: 0x00A9A018 File Offset: 0x00A98218
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.NoticeUIController");
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.ShowNotice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.SetPositionState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.ShowNextNotice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.OnNoticeShowTweenFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.OnNoticeMoveTweenFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.DelayHideNotice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.OnNoticeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__callDele_EventOnNoticeClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.__clearDele_EventOnNoticeClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache17);
		string name = "EventOnNoticeClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_EventOnNoticeClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache18, true);
		string name2 = "m_noticeButton";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_noticeButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_noticeButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1A, true);
		string name3 = "m_noticeDetailGo";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_noticeDetailGo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_noticeDetailGo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1C, true);
		string name4 = "m_noticeText";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_noticeText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_noticeText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1E, true);
		string name5 = "m_noticeVoiceImage";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_noticeVoiceImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_noticeVoiceImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache20, true);
		string name6 = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_stateCtrl);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache22, true);
		string name7 = "m_expressionParseDesc";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_expressionParseDesc);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_expressionParseDesc);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache24, true);
		string name8 = "m_expressionResContainer";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_expressionResContainer);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_expressionResContainer);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache26, true);
		string name9 = "s_isForceHide";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_s_isForceHide);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_s_isForceHide);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache28, false);
		string name10 = "s_instance";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_s_instance);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_s_instance);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2A, false);
		string name11 = "NoticeTweenSpeed";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_NoticeTweenSpeed);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2B, null, false);
		string name12 = "ShowNoticeInterval";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_ShowNoticeInterval);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2C, null, false);
		string name13 = "ShowNoticeTime";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_ShowNoticeTime);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2D, null, false);
		string name14 = "m_noticeTextInitPos";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_noticeTextInitPos);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_noticeTextInitPos);
		}
		LuaObject.addMember(l, name14, get11, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache2F, true);
		string name15 = "m_noticeTextInitWidth";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_noticeTextInitWidth);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_noticeTextInitWidth);
		}
		LuaObject.addMember(l, name15, get12, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache31, true);
		string name16 = "m_delayHideNoticeCoroutine";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_delayHideNoticeCoroutine);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_delayHideNoticeCoroutine);
		}
		LuaObject.addMember(l, name16, get13, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache33, true);
		string name17 = "m_noticeShowTween";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_noticeShowTween);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_noticeShowTween);
		}
		LuaObject.addMember(l, name17, get14, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache35, true);
		string name18 = "m_noticeMoveTween";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_noticeMoveTween);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_noticeMoveTween);
		}
		LuaObject.addMember(l, name18, get15, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache37, true);
		string name19 = "m_currentNoticeText";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_currentNoticeText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_currentNoticeText);
		}
		LuaObject.addMember(l, name19, get16, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache39, true);
		string name20 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_m_playerContext);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name20, get17, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3B, true);
		string name21 = "IsForceHide";
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.get_IsForceHide);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_NoticeUIController.set_IsForceHide);
		}
		LuaObject.addMember(l, name21, get18, Lua_BlackJack_ProjectL_UI_NoticeUIController.<>f__mg$cache3D, false);
		LuaObject.createTypeMetatable(l, null, typeof(NoticeUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015FF3 RID: 90099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015FF4 RID: 90100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015FF5 RID: 90101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015FF6 RID: 90102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015FF7 RID: 90103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015FF8 RID: 90104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015FF9 RID: 90105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015FFA RID: 90106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015FFB RID: 90107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015FFC RID: 90108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015FFD RID: 90109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015FFE RID: 90110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015FFF RID: 90111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016000 RID: 90112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016001 RID: 90113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016002 RID: 90114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016003 RID: 90115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016004 RID: 90116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016005 RID: 90117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016006 RID: 90118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016007 RID: 90119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016008 RID: 90120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016009 RID: 90121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401600A RID: 90122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401600B RID: 90123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401600C RID: 90124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401600D RID: 90125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401600E RID: 90126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401600F RID: 90127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016010 RID: 90128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016011 RID: 90129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016012 RID: 90130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016013 RID: 90131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016014 RID: 90132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016015 RID: 90133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016016 RID: 90134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016017 RID: 90135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016018 RID: 90136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016019 RID: 90137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401601A RID: 90138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401601B RID: 90139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401601C RID: 90140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401601D RID: 90141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401601E RID: 90142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401601F RID: 90143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016020 RID: 90144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016021 RID: 90145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016022 RID: 90146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016023 RID: 90147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016024 RID: 90148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016025 RID: 90149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016026 RID: 90150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016027 RID: 90151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016028 RID: 90152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016029 RID: 90153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401602A RID: 90154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401602B RID: 90155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401602C RID: 90156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401602D RID: 90157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401602E RID: 90158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401602F RID: 90159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016030 RID: 90160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;
}
