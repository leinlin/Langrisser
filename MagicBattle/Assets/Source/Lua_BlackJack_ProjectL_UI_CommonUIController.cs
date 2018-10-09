using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001403 RID: 5123
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CommonUIController : LuaObject
{
	// Token: 0x0601CDE5 RID: 118245 RVA: 0x00908158 File Offset: 0x00906358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTouchFx(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.InitTouchFx();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDE6 RID: 118246 RVA: 0x009081A4 File Offset: 0x009063A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DisposeTouchFx(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.DisposeTouchFx();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDE7 RID: 118247 RVA: 0x009081F0 File Offset: 0x009063F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTouchFxStyle(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			int touchFxStyle;
			LuaObject.checkType(l, 2, out touchFxStyle);
			commonUIController.SetTouchFxStyle(touchFxStyle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDE8 RID: 118248 RVA: 0x00908248 File Offset: 0x00906448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTouchFXParentActive(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool touchFXParentActive;
			LuaObject.checkType(l, 2, out touchFXParentActive);
			commonUIController.SetTouchFXParentActive(touchFXParentActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDE9 RID: 118249 RVA: 0x009082A0 File Offset: 0x009064A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMessage(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(StringTableId), typeof(float), typeof(Action), typeof(bool)))
			{
				CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
				StringTableId id;
				LuaObject.checkEnum<StringTableId>(l, 2, out id);
				float time;
				LuaObject.checkType(l, 3, out time);
				Action onEnd;
				LuaObject.checkDelegate<Action>(l, 4, out onEnd);
				bool disableInput;
				LuaObject.checkType(l, 5, out disableInput);
				commonUIController.ShowMessage(id, time, onEnd, disableInput);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(Action), typeof(bool)))
			{
				CommonUIController commonUIController2 = (CommonUIController)LuaObject.checkSelf(l);
				string txt;
				LuaObject.checkType(l, 2, out txt);
				float time2;
				LuaObject.checkType(l, 3, out time2);
				Action onEnd2;
				LuaObject.checkDelegate<Action>(l, 4, out onEnd2);
				bool disableInput2;
				LuaObject.checkType(l, 5, out disableInput2);
				commonUIController2.ShowMessage(txt, time2, onEnd2, disableInput2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowMessage to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDEA RID: 118250 RVA: 0x0090840C File Offset: 0x0090660C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowErrorMessage(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			int errorCode;
			LuaObject.checkType(l, 2, out errorCode);
			float time;
			LuaObject.checkType(l, 3, out time);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			bool disableInput;
			LuaObject.checkType(l, 5, out disableInput);
			commonUIController.ShowErrorMessage(errorCode, time, onEnd, disableInput);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDEB RID: 118251 RVA: 0x0090848C File Offset: 0x0090668C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowDialogBox(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(StringTableId), typeof(Action<DialogBoxResult>), typeof(StringTableId), typeof(StringTableId)))
			{
				CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
				StringTableId msgId;
				LuaObject.checkEnum<StringTableId>(l, 2, out msgId);
				Action<DialogBoxResult> callback;
				LuaObject.checkDelegate<Action<DialogBoxResult>>(l, 3, out callback);
				StringTableId okId;
				LuaObject.checkEnum<StringTableId>(l, 4, out okId);
				StringTableId cancelId;
				LuaObject.checkEnum<StringTableId>(l, 5, out cancelId);
				commonUIController.ShowDialogBox(msgId, callback, okId, cancelId);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<DialogBoxResult>), typeof(string), typeof(string)))
			{
				CommonUIController commonUIController2 = (CommonUIController)LuaObject.checkSelf(l);
				string msgText;
				LuaObject.checkType(l, 2, out msgText);
				Action<DialogBoxResult> callback2;
				LuaObject.checkDelegate<Action<DialogBoxResult>>(l, 3, out callback2);
				string okText;
				LuaObject.checkType(l, 4, out okText);
				string cancelText;
				LuaObject.checkType(l, 5, out cancelText);
				commonUIController2.ShowDialogBox(msgText, callback2, okText, cancelText);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowDialogBox to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDEC RID: 118252 RVA: 0x009085F8 File Offset: 0x009067F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CancelDialogBox(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool b = commonUIController.CancelDialogBox();
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

	// Token: 0x0601CDED RID: 118253 RVA: 0x0090864C File Offset: 0x0090684C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowExplanation(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
				string txt;
				LuaObject.checkType(l, 2, out txt);
				commonUIController.ShowExplanation(txt);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ExplanationId)))
			{
				CommonUIController commonUIController2 = (CommonUIController)LuaObject.checkSelf(l);
				ExplanationId id;
				LuaObject.checkEnum<ExplanationId>(l, 2, out id);
				commonUIController2.ShowExplanation(id);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ShowExplanation to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDEE RID: 118254 RVA: 0x00908724 File Offset: 0x00906924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTip(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			string txt;
			LuaObject.checkType(l, 2, out txt);
			commonUIController.ShowTip(txt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDEF RID: 118255 RVA: 0x0090877C File Offset: 0x0090697C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowNotice(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			string txt;
			LuaObject.checkType(l, 2, out txt);
			commonUIController.ShowNotice(txt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDF0 RID: 118256 RVA: 0x009087D4 File Offset: 0x009069D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowLoading(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			FadeStyle style;
			LuaObject.checkEnum<FadeStyle>(l, 2, out style);
			commonUIController.ShowLoading(style);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDF1 RID: 118257 RVA: 0x0090882C File Offset: 0x00906A2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HideLoading(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.HideLoading();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDF2 RID: 118258 RVA: 0x00908878 File Offset: 0x00906A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowWaitingNet(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			commonUIController.ShowWaitingNet(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDF3 RID: 118259 RVA: 0x009088D0 File Offset: 0x00906AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			commonUIController.EnableInput(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDF4 RID: 118260 RVA: 0x00908928 File Offset: 0x00906B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEnableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool b = commonUIController.IsEnableInput();
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

	// Token: 0x0601CDF5 RID: 118261 RVA: 0x0090897C File Offset: 0x00906B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FrameworkUITaskEnableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			commonUIController.FrameworkUITaskEnableInput(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDF6 RID: 118262 RVA: 0x009089D4 File Offset: 0x00906BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFrameworkUITaskDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool b = commonUIController.IsFrameworkUITaskDisableInput();
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

	// Token: 0x0601CDF7 RID: 118263 RVA: 0x00908A28 File Offset: 0x00906C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FrameworkNetTaskEnableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			commonUIController.FrameworkNetTaskEnableInput(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDF8 RID: 118264 RVA: 0x00908A80 File Offset: 0x00906C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFrameworkNetTaskDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool b = commonUIController.IsFrameworkNetTaskDisableInput();
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

	// Token: 0x0601CDF9 RID: 118265 RVA: 0x00908AD4 File Offset: 0x00906CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PDSDKEnableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			commonUIController.PDSDKEnableInput(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDFA RID: 118266 RVA: 0x00908B2C File Offset: 0x00906D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAnyDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool b = commonUIController.IsAnyDisableInput();
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

	// Token: 0x0601CDFB RID: 118267 RVA: 0x00908B80 File Offset: 0x00906D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDisableInputObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			bool b = commonUIController.IsDisableInputObject(obj);
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

	// Token: 0x0601CDFC RID: 118268 RVA: 0x00908BE4 File Offset: 0x00906DE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsTestToolbarObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			bool b = commonUIController.IsTestToolbarObject(obj);
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

	// Token: 0x0601CDFD RID: 118269 RVA: 0x00908C48 File Offset: 0x00906E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowBlackFrame(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			commonUIController.ShowBlackFrame(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDFE RID: 118270 RVA: 0x00908CA0 File Offset: 0x00906EA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowTestUIBackground(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool showToggle;
			LuaObject.checkType(l, 2, out showToggle);
			bool showBar;
			LuaObject.checkType(l, 3, out showBar);
			commonUIController.ShowTestUIBackground(showToggle, showBar);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CDFF RID: 118271 RVA: 0x00908D04 File Offset: 0x00906F04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowiPhoneXTest(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			commonUIController.ShowiPhoneXTest(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE00 RID: 118272 RVA: 0x00908D5C File Offset: 0x00906F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartFadeOut(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Action fadeoutEnd;
			LuaObject.checkDelegate<Action>(l, 2, out fadeoutEnd);
			FadeStyle style;
			LuaObject.checkEnum<FadeStyle>(l, 3, out style);
			float fadeOutTime;
			LuaObject.checkType(l, 4, out fadeOutTime);
			commonUIController.StartFadeOut(fadeoutEnd, style, fadeOutTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE01 RID: 118273 RVA: 0x00908DD0 File Offset: 0x00906FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartShowFadeOutLoadingFadeIn(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Action fadeOutEnd;
			LuaObject.checkDelegate<Action>(l, 2, out fadeOutEnd);
			FadeStyle style;
			LuaObject.checkEnum<FadeStyle>(l, 3, out style);
			float fadeOutTime;
			LuaObject.checkType(l, 4, out fadeOutTime);
			float fadeInTime;
			LuaObject.checkType(l, 5, out fadeInTime);
			commonUIController.StartShowFadeOutLoadingFadeIn(fadeOutEnd, style, fadeOutTime, fadeInTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE02 RID: 118274 RVA: 0x00908E50 File Offset: 0x00907050
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HideFadeOutLoadingFadeIn(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.HideFadeOutLoadingFadeIn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE03 RID: 118275 RVA: 0x00908E9C File Offset: 0x0090709C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FadeIn(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			Color color;
			LuaObject.checkType(l, 3, out color);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			commonUIController.FadeIn(time, color, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE04 RID: 118276 RVA: 0x00908F10 File Offset: 0x00907110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FadeOut(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			Color color;
			LuaObject.checkType(l, 3, out color);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			commonUIController.FadeOut(time, color, onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE05 RID: 118277 RVA: 0x00908F84 File Offset: 0x00907184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFading(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool b = commonUIController.IsFading();
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

	// Token: 0x0601CE06 RID: 118278 RVA: 0x00908FD8 File Offset: 0x009071D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StaticLateUpdate_s(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController.StaticLateUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE07 RID: 118279 RVA: 0x00909018 File Offset: 0x00907218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAndroidBackKeyUp_s(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController.OnAndroidBackKeyUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE08 RID: 118280 RVA: 0x00909058 File Offset: 0x00907258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE09 RID: 118281 RVA: 0x009090AC File Offset: 0x009072AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDestroy(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.OnDestroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE0A RID: 118282 RVA: 0x00909100 File Offset: 0x00907300
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE0B RID: 118283 RVA: 0x00909154 File Offset: 0x00907354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowMessage(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			string txt;
			LuaObject.checkType(l, 2, out txt);
			float time;
			LuaObject.checkType(l, 3, out time);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onEnd);
			bool disableInput;
			LuaObject.checkType(l, 5, out disableInput);
			IEnumerator o = commonUIController.m_luaExportHelper.Co_ShowMessage(txt, time, onEnd, disableInput);
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

	// Token: 0x0601CE0C RID: 118284 RVA: 0x009091E4 File Offset: 0x009073E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowNextNotice(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.ShowNextNotice();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE0D RID: 118285 RVA: 0x00909238 File Offset: 0x00907438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNoticeShowTweenFinished(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.OnNoticeShowTweenFinished();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE0E RID: 118286 RVA: 0x0090928C File Offset: 0x0090748C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnNoticeMoveTweenFinished(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.OnNoticeMoveTweenFinished();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE0F RID: 118287 RVA: 0x009092E0 File Offset: 0x009074E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DelayHideNotice(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			IEnumerator o = commonUIController.m_luaExportHelper.DelayHideNotice(time);
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

	// Token: 0x0601CE10 RID: 118288 RVA: 0x00909348 File Offset: 0x00907548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.UpdateDisableInput();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE11 RID: 118289 RVA: 0x0090939C File Offset: 0x0090759C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPDSDKWebViewOpen(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.OnPDSDKWebViewOpen();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE12 RID: 118290 RVA: 0x009093F0 File Offset: 0x009075F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPDSDKWebViewClose(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.OnPDSDKWebViewClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE13 RID: 118291 RVA: 0x00909444 File Offset: 0x00907644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDisableInputHintColor(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Color disableInputHintColor;
			LuaObject.checkType(l, 2, out disableInputHintColor);
			commonUIController.m_luaExportHelper.SetDisableInputHintColor(disableInputHintColor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE14 RID: 118292 RVA: 0x009094A0 File Offset: 0x009076A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowFadeOutLoadingFadeIn(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Action fadeOutEnd;
			LuaObject.checkDelegate<Action>(l, 2, out fadeOutEnd);
			FadeStyle style;
			LuaObject.checkEnum<FadeStyle>(l, 3, out style);
			float fadeOutTime;
			LuaObject.checkType(l, 4, out fadeOutTime);
			float fadeInTime;
			LuaObject.checkType(l, 5, out fadeInTime);
			IEnumerator o = commonUIController.m_luaExportHelper.ShowFadeOutLoadingFadeIn(fadeOutEnd, style, fadeOutTime, fadeInTime);
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

	// Token: 0x0601CE15 RID: 118293 RVA: 0x00909530 File Offset: 0x00907730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnApplicationFocus(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool focus;
			LuaObject.checkType(l, 2, out focus);
			commonUIController.m_luaExportHelper.OnApplicationFocus(focus);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE16 RID: 118294 RVA: 0x0090958C File Offset: 0x0090778C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnApplicationPause(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool isPause;
			LuaObject.checkType(l, 2, out isPause);
			commonUIController.m_luaExportHelper.OnApplicationPause(isPause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE17 RID: 118295 RVA: 0x009095E8 File Offset: 0x009077E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExplanationBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.OnExplanationBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE18 RID: 118296 RVA: 0x0090963C File Offset: 0x0090783C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			commonUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE19 RID: 118297 RVA: 0x009096A8 File Offset: 0x009078A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE1A RID: 118298 RVA: 0x009096FC File Offset: 0x009078FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE1B RID: 118299 RVA: 0x00909750 File Offset: 0x00907950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = commonUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CE1C RID: 118300 RVA: 0x009097F8 File Offset: 0x009079F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			commonUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE1D RID: 118301 RVA: 0x0090984C File Offset: 0x00907A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			commonUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE1E RID: 118302 RVA: 0x009098B8 File Offset: 0x00907AB8
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
				CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				commonUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				CommonUIController commonUIController2 = (CommonUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				commonUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CE1F RID: 118303 RVA: 0x009099C8 File Offset: 0x00907BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			commonUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE20 RID: 118304 RVA: 0x00909A34 File Offset: 0x00907C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			commonUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE21 RID: 118305 RVA: 0x00909AA0 File Offset: 0x00907CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			commonUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE22 RID: 118306 RVA: 0x00909B0C File Offset: 0x00907D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			commonUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE23 RID: 118307 RVA: 0x00909B78 File Offset: 0x00907D78
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
				CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				commonUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				CommonUIController commonUIController2 = (CommonUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				commonUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CE24 RID: 118308 RVA: 0x00909C88 File Offset: 0x00907E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			string s = commonUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CE25 RID: 118309 RVA: 0x00909CE4 File Offset: 0x00907EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MessageBoxAndQuitApp_s(IntPtr l)
	{
		int result;
		try
		{
			IEnumerator o = CommonUIController.LuaExportHelper.MessageBoxAndQuitApp();
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

	// Token: 0x0601CE26 RID: 118310 RVA: 0x00909D2C File Offset: 0x00907F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hasFinishAndroidBackEvent(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CommonUIController.m_hasFinishAndroidBackEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE27 RID: 118311 RVA: 0x00909D74 File Offset: 0x00907F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hasFinishAndroidBackEvent(IntPtr l)
	{
		int result;
		try
		{
			bool hasFinishAndroidBackEvent;
			LuaObject.checkType(l, 2, out hasFinishAndroidBackEvent);
			CommonUIController.m_hasFinishAndroidBackEvent = hasFinishAndroidBackEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE28 RID: 118312 RVA: 0x00909DC0 File Offset: 0x00907FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isRunningMessageBoxAndQuitApp(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CommonUIController.LuaExportHelper.m_isRunningMessageBoxAndQuitApp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE29 RID: 118313 RVA: 0x00909E08 File Offset: 0x00908008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isRunningMessageBoxAndQuitApp(IntPtr l)
	{
		int result;
		try
		{
			bool isRunningMessageBoxAndQuitApp;
			LuaObject.checkType(l, 2, out isRunningMessageBoxAndQuitApp);
			CommonUIController.LuaExportHelper.m_isRunningMessageBoxAndQuitApp = isRunningMessageBoxAndQuitApp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE2A RID: 118314 RVA: 0x00909E54 File Offset: 0x00908054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_s_instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CommonUIController.LuaExportHelper.s_instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE2B RID: 118315 RVA: 0x00909E9C File Offset: 0x0090809C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_s_instance(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController s_instance;
			LuaObject.checkType<CommonUIController>(l, 2, out s_instance);
			CommonUIController.LuaExportHelper.s_instance = s_instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE2C RID: 118316 RVA: 0x00909EE8 File Offset: 0x009080E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TestUI(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.TestUI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE2D RID: 118317 RVA: 0x00909F3C File Offset: 0x0090813C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TestUI(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			TestUI testUI;
			LuaObject.checkType<TestUI>(l, 2, out testUI);
			commonUIController.TestUI = testUI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE2E RID: 118318 RVA: 0x00909F94 File Offset: 0x00908194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_xfWrapper(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_xfWrapper);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE2F RID: 118319 RVA: 0x00909FE8 File Offset: 0x009081E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_xfWrapper(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			XunfeiSDKWrapper xfWrapper;
			LuaObject.checkType<XunfeiSDKWrapper>(l, 2, out xfWrapper);
			commonUIController.m_xfWrapper = xfWrapper;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE30 RID: 118320 RVA: 0x0090A040 File Offset: 0x00908240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loadingGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_loadingGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE31 RID: 118321 RVA: 0x0090A098 File Offset: 0x00908298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loadingGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject loadingGameObject;
			LuaObject.checkType<GameObject>(l, 2, out loadingGameObject);
			commonUIController.m_luaExportHelper.m_loadingGameObject = loadingGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE32 RID: 118322 RVA: 0x0090A0F4 File Offset: 0x009082F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_disableInputGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_disableInputGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE33 RID: 118323 RVA: 0x0090A14C File Offset: 0x0090834C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_disableInputGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject disableInputGameObject;
			LuaObject.checkType<GameObject>(l, 2, out disableInputGameObject);
			commonUIController.m_luaExportHelper.m_disableInputGameObject = disableInputGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE34 RID: 118324 RVA: 0x0090A1A8 File Offset: 0x009083A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_disableInputHintImage(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_disableInputHintImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE35 RID: 118325 RVA: 0x0090A200 File Offset: 0x00908400
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_disableInputHintImage(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Image disableInputHintImage;
			LuaObject.checkType<Image>(l, 2, out disableInputHintImage);
			commonUIController.m_luaExportHelper.m_disableInputHintImage = disableInputHintImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE36 RID: 118326 RVA: 0x0090A25C File Offset: 0x0090845C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_transparentMaskGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_transparentMaskGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE37 RID: 118327 RVA: 0x0090A2B4 File Offset: 0x009084B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_transparentMaskGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject transparentMaskGameObject;
			LuaObject.checkType<GameObject>(l, 2, out transparentMaskGameObject);
			commonUIController.m_luaExportHelper.m_transparentMaskGameObject = transparentMaskGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE38 RID: 118328 RVA: 0x0090A310 File Offset: 0x00908510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_blackFrameGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_blackFrameGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE39 RID: 118329 RVA: 0x0090A368 File Offset: 0x00908568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_blackFrameGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject blackFrameGameObject;
			LuaObject.checkType<GameObject>(l, 2, out blackFrameGameObject);
			commonUIController.m_luaExportHelper.m_blackFrameGameObject = blackFrameGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE3A RID: 118330 RVA: 0x0090A3C4 File Offset: 0x009085C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeImage(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_fadeImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE3B RID: 118331 RVA: 0x0090A41C File Offset: 0x0090861C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fadeImage(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Image fadeImage;
			LuaObject.checkType<Image>(l, 2, out fadeImage);
			commonUIController.m_luaExportHelper.m_fadeImage = fadeImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE3C RID: 118332 RVA: 0x0090A478 File Offset: 0x00908678
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_testUIBackgroundGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_testUIBackgroundGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE3D RID: 118333 RVA: 0x0090A4D0 File Offset: 0x009086D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_testUIBackgroundGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject testUIBackgroundGameObject;
			LuaObject.checkType<GameObject>(l, 2, out testUIBackgroundGameObject);
			commonUIController.m_luaExportHelper.m_testUIBackgroundGameObject = testUIBackgroundGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE3E RID: 118334 RVA: 0x0090A52C File Offset: 0x0090872C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testUIBackgroundToolBarGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_testUIBackgroundToolBarGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE3F RID: 118335 RVA: 0x0090A584 File Offset: 0x00908784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testUIBackgroundToolBarGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject testUIBackgroundToolBarGameObject;
			LuaObject.checkType<GameObject>(l, 2, out testUIBackgroundToolBarGameObject);
			commonUIController.m_luaExportHelper.m_testUIBackgroundToolBarGameObject = testUIBackgroundToolBarGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE40 RID: 118336 RVA: 0x0090A5E0 File Offset: 0x009087E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_testUIBackgroundToolToggleGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_testUIBackgroundToolToggleGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE41 RID: 118337 RVA: 0x0090A638 File Offset: 0x00908838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_testUIBackgroundToolToggleGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject testUIBackgroundToolToggleGameObject;
			LuaObject.checkType<GameObject>(l, 2, out testUIBackgroundToolToggleGameObject);
			commonUIController.m_luaExportHelper.m_testUIBackgroundToolToggleGameObject = testUIBackgroundToolToggleGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE42 RID: 118338 RVA: 0x0090A694 File Offset: 0x00908894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iPhoneXTestGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_iPhoneXTestGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE43 RID: 118339 RVA: 0x0090A6EC File Offset: 0x009088EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iPhoneXTestGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject iPhoneXTestGameObject;
			LuaObject.checkType<GameObject>(l, 2, out iPhoneXTestGameObject);
			commonUIController.m_luaExportHelper.m_iPhoneXTestGameObject = iPhoneXTestGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE44 RID: 118340 RVA: 0x0090A748 File Offset: 0x00908948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageUIStateController(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_messageUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE45 RID: 118341 RVA: 0x0090A7A0 File Offset: 0x009089A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_messageUIStateController(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			CommonUIStateController messageUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out messageUIStateController);
			commonUIController.m_luaExportHelper.m_messageUIStateController = messageUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE46 RID: 118342 RVA: 0x0090A7FC File Offset: 0x009089FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_messageText(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_messageText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE47 RID: 118343 RVA: 0x0090A854 File Offset: 0x00908A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_messageText(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Text messageText;
			LuaObject.checkType<Text>(l, 2, out messageText);
			commonUIController.m_luaExportHelper.m_messageText = messageText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE48 RID: 118344 RVA: 0x0090A8B0 File Offset: 0x00908AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_explanationUIStateController(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_explanationUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE49 RID: 118345 RVA: 0x0090A908 File Offset: 0x00908B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_explanationUIStateController(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			CommonUIStateController explanationUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out explanationUIStateController);
			commonUIController.m_luaExportHelper.m_explanationUIStateController = explanationUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE4A RID: 118346 RVA: 0x0090A964 File Offset: 0x00908B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_explanationBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_explanationBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE4B RID: 118347 RVA: 0x0090A9BC File Offset: 0x00908BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_explanationBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Button explanationBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out explanationBackgroundButton);
			commonUIController.m_luaExportHelper.m_explanationBackgroundButton = explanationBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE4C RID: 118348 RVA: 0x0090AA18 File Offset: 0x00908C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_explanationText(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_explanationText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE4D RID: 118349 RVA: 0x0090AA70 File Offset: 0x00908C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_explanationText(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Text explanationText;
			LuaObject.checkType<Text>(l, 2, out explanationText);
			commonUIController.m_luaExportHelper.m_explanationText = explanationText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE4E RID: 118350 RVA: 0x0090AACC File Offset: 0x00908CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_noticeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE4F RID: 118351 RVA: 0x0090AB24 File Offset: 0x00908D24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_noticeGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject noticeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out noticeGameObject);
			commonUIController.m_luaExportHelper.m_noticeGameObject = noticeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE50 RID: 118352 RVA: 0x0090AB80 File Offset: 0x00908D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeText(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_noticeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE51 RID: 118353 RVA: 0x0090ABD8 File Offset: 0x00908DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeText(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Text noticeText;
			LuaObject.checkType<Text>(l, 2, out noticeText);
			commonUIController.m_luaExportHelper.m_noticeText = noticeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE52 RID: 118354 RVA: 0x0090AC34 File Offset: 0x00908E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_screenRecorderGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_screenRecorderGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE53 RID: 118355 RVA: 0x0090AC8C File Offset: 0x00908E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_screenRecorderGameObject(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			GameObject screenRecorderGameObject;
			LuaObject.checkType<GameObject>(l, 2, out screenRecorderGameObject);
			commonUIController.m_luaExportHelper.m_screenRecorderGameObject = screenRecorderGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE54 RID: 118356 RVA: 0x0090ACE8 File Offset: 0x00908EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tipUIStateController(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_tipUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE55 RID: 118357 RVA: 0x0090AD40 File Offset: 0x00908F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tipUIStateController(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			CommonUIStateController tipUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out tipUIStateController);
			commonUIController.m_luaExportHelper.m_tipUIStateController = tipUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE56 RID: 118358 RVA: 0x0090AD9C File Offset: 0x00908F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tipText(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_tipText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE57 RID: 118359 RVA: 0x0090ADF4 File Offset: 0x00908FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tipText(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Text tipText;
			LuaObject.checkType<Text>(l, 2, out tipText);
			commonUIController.m_luaExportHelper.m_tipText = tipText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE58 RID: 118360 RVA: 0x0090AE50 File Offset: 0x00909050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogBox(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_dialogBox);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE59 RID: 118361 RVA: 0x0090AEA8 File Offset: 0x009090A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogBox(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			DialogBox dialogBox;
			LuaObject.checkType<DialogBox>(l, 2, out dialogBox);
			commonUIController.m_luaExportHelper.m_dialogBox = dialogBox;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE5A RID: 118362 RVA: 0x0090AF04 File Offset: 0x00909104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_networkWatingStateController(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_networkWatingStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE5B RID: 118363 RVA: 0x0090AF5C File Offset: 0x0090915C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_networkWatingStateController(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			CommonUIStateController networkWatingStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out networkWatingStateController);
			commonUIController.m_luaExportHelper.m_networkWatingStateController = networkWatingStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE5C RID: 118364 RVA: 0x0090AFB8 File Offset: 0x009091B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_screenFade(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_screenFade);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE5D RID: 118365 RVA: 0x0090B010 File Offset: 0x00909210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_screenFade(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			ScreenFade screenFade;
			LuaObject.checkType<ScreenFade>(l, 2, out screenFade);
			commonUIController.m_luaExportHelper.m_screenFade = screenFade;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE5E RID: 118366 RVA: 0x0090B06C File Offset: 0x0090926C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hideFadeOutLoadingFadeIn(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_hideFadeOutLoadingFadeIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE5F RID: 118367 RVA: 0x0090B0C4 File Offset: 0x009092C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hideFadeOutLoadingFadeIn(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool hideFadeOutLoadingFadeIn;
			LuaObject.checkType(l, 2, out hideFadeOutLoadingFadeIn);
			commonUIController.m_luaExportHelper.m_hideFadeOutLoadingFadeIn = hideFadeOutLoadingFadeIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE60 RID: 118368 RVA: 0x0090B120 File Offset: 0x00909320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defaultFadeOutTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_defaultFadeOutTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE61 RID: 118369 RVA: 0x0090B178 File Offset: 0x00909378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defaultFadeOutTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			float defaultFadeOutTime;
			LuaObject.checkType(l, 2, out defaultFadeOutTime);
			commonUIController.m_luaExportHelper.m_defaultFadeOutTime = defaultFadeOutTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE62 RID: 118370 RVA: 0x0090B1D4 File Offset: 0x009093D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_defaultFadeInTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_defaultFadeInTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE63 RID: 118371 RVA: 0x0090B22C File Offset: 0x0090942C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_defaultFadeInTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			float defaultFadeInTime;
			LuaObject.checkType(l, 2, out defaultFadeInTime);
			commonUIController.m_luaExportHelper.m_defaultFadeInTime = defaultFadeInTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE64 RID: 118372 RVA: 0x0090B288 File Offset: 0x00909488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NoticeTweenSpeed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CommonUIController.LuaExportHelper.NoticeTweenSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE65 RID: 118373 RVA: 0x0090B2D0 File Offset: 0x009094D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShowNoticeInterval(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CommonUIController.LuaExportHelper.ShowNoticeInterval);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE66 RID: 118374 RVA: 0x0090B318 File Offset: 0x00909518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShowNoticeTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CommonUIController.LuaExportHelper.ShowNoticeTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE67 RID: 118375 RVA: 0x0090B360 File Offset: 0x00909560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShowingNotice(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_isShowingNotice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE68 RID: 118376 RVA: 0x0090B3B8 File Offset: 0x009095B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isShowingNotice(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool isShowingNotice;
			LuaObject.checkType(l, 2, out isShowingNotice);
			commonUIController.m_luaExportHelper.m_isShowingNotice = isShowingNotice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE69 RID: 118377 RVA: 0x0090B414 File Offset: 0x00909614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waitingNotices(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_waitingNotices);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE6A RID: 118378 RVA: 0x0090B46C File Offset: 0x0090966C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_waitingNotices(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			List<string> waitingNotices;
			LuaObject.checkType<List<string>>(l, 2, out waitingNotices);
			commonUIController.m_luaExportHelper.m_waitingNotices = waitingNotices;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE6B RID: 118379 RVA: 0x0090B4C8 File Offset: 0x009096C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeTextInitPos(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_noticeTextInitPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE6C RID: 118380 RVA: 0x0090B520 File Offset: 0x00909720
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_noticeTextInitPos(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Vector3 noticeTextInitPos;
			LuaObject.checkType(l, 2, out noticeTextInitPos);
			commonUIController.m_luaExportHelper.m_noticeTextInitPos = noticeTextInitPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE6D RID: 118381 RVA: 0x0090B57C File Offset: 0x0090977C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeTextInitWidth(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_noticeTextInitWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE6E RID: 118382 RVA: 0x0090B5D4 File Offset: 0x009097D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeTextInitWidth(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			float noticeTextInitWidth;
			LuaObject.checkType(l, 2, out noticeTextInitWidth);
			commonUIController.m_luaExportHelper.m_noticeTextInitWidth = noticeTextInitWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE6F RID: 118383 RVA: 0x0090B630 File Offset: 0x00909830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_delayHideNoticeCoroutine(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_delayHideNoticeCoroutine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE70 RID: 118384 RVA: 0x0090B688 File Offset: 0x00909888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_delayHideNoticeCoroutine(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			Coroutine delayHideNoticeCoroutine;
			LuaObject.checkType<Coroutine>(l, 2, out delayHideNoticeCoroutine);
			commonUIController.m_luaExportHelper.m_delayHideNoticeCoroutine = delayHideNoticeCoroutine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE71 RID: 118385 RVA: 0x0090B6E4 File Offset: 0x009098E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeShowTween(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_noticeShowTween);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE72 RID: 118386 RVA: 0x0090B73C File Offset: 0x0090993C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeShowTween(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			TweenPos noticeShowTween;
			LuaObject.checkType<TweenPos>(l, 2, out noticeShowTween);
			commonUIController.m_luaExportHelper.m_noticeShowTween = noticeShowTween;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE73 RID: 118387 RVA: 0x0090B798 File Offset: 0x00909998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noticeMoveTween(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_noticeMoveTween);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE74 RID: 118388 RVA: 0x0090B7F0 File Offset: 0x009099F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noticeMoveTween(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			TweenPos noticeMoveTween;
			LuaObject.checkType<TweenPos>(l, 2, out noticeMoveTween);
			commonUIController.m_luaExportHelper.m_noticeMoveTween = noticeMoveTween;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE75 RID: 118389 RVA: 0x0090B84C File Offset: 0x00909A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isGameDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_isGameDisableInput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE76 RID: 118390 RVA: 0x0090B8A4 File Offset: 0x00909AA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isGameDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool isGameDisableInput;
			LuaObject.checkType(l, 2, out isGameDisableInput);
			commonUIController.m_luaExportHelper.m_isGameDisableInput = isGameDisableInput;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE77 RID: 118391 RVA: 0x0090B900 File Offset: 0x00909B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFrameworkUITaskDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_isFrameworkUITaskDisableInput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE78 RID: 118392 RVA: 0x0090B958 File Offset: 0x00909B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFrameworkUITaskDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool isFrameworkUITaskDisableInput;
			LuaObject.checkType(l, 2, out isFrameworkUITaskDisableInput);
			commonUIController.m_luaExportHelper.m_isFrameworkUITaskDisableInput = isFrameworkUITaskDisableInput;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE79 RID: 118393 RVA: 0x0090B9B4 File Offset: 0x00909BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFrameworkNetTaskDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_isFrameworkNetTaskDisableInput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE7A RID: 118394 RVA: 0x0090BA0C File Offset: 0x00909C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFrameworkNetTaskDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool isFrameworkNetTaskDisableInput;
			LuaObject.checkType(l, 2, out isFrameworkNetTaskDisableInput);
			commonUIController.m_luaExportHelper.m_isFrameworkNetTaskDisableInput = isFrameworkNetTaskDisableInput;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE7B RID: 118395 RVA: 0x0090BA68 File Offset: 0x00909C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPDSDKDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_isPDSDKDisableInput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE7C RID: 118396 RVA: 0x0090BAC0 File Offset: 0x00909CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPDSDKDisableInput(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool isPDSDKDisableInput;
			LuaObject.checkType(l, 2, out isPDSDKDisableInput);
			commonUIController.m_luaExportHelper.m_isPDSDKDisableInput = isPDSDKDisableInput;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE7D RID: 118397 RVA: 0x0090BB1C File Offset: 0x00909D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pauseTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_pauseTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE7E RID: 118398 RVA: 0x0090BB78 File Offset: 0x00909D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pauseTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			DateTime pauseTime;
			LuaObject.checkValueType<DateTime>(l, 2, out pauseTime);
			commonUIController.m_luaExportHelper.m_pauseTime = pauseTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE7F RID: 118399 RVA: 0x0090BBD4 File Offset: 0x00909DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unfocusDateTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_unfocusDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE80 RID: 118400 RVA: 0x0090BC30 File Offset: 0x00909E30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_unfocusDateTime(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			DateTime unfocusDateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out unfocusDateTime);
			commonUIController.m_luaExportHelper.m_unfocusDateTime = unfocusDateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE81 RID: 118401 RVA: 0x0090BC8C File Offset: 0x00909E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unfocusTimer(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_unfocusTimer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE82 RID: 118402 RVA: 0x0090BCE4 File Offset: 0x00909EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unfocusTimer(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			double unfocusTimer;
			LuaObject.checkType(l, 2, out unfocusTimer);
			commonUIController.m_luaExportHelper.m_unfocusTimer = unfocusTimer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE83 RID: 118403 RVA: 0x0090BD40 File Offset: 0x00909F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchFx(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.m_luaExportHelper.m_touchFx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE84 RID: 118404 RVA: 0x0090BD98 File Offset: 0x00909F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchFx(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			TouchFx touchFx;
			LuaObject.checkType<TouchFx>(l, 2, out touchFx);
			commonUIController.m_luaExportHelper.m_touchFx = touchFx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE85 RID: 118405 RVA: 0x0090BDF4 File Offset: 0x00909FF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnableScreenRecordFunction(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commonUIController.EnableScreenRecordFunction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE86 RID: 118406 RVA: 0x0090BE48 File Offset: 0x0090A048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnableScreenRecordFunction(IntPtr l)
	{
		int result;
		try
		{
			CommonUIController commonUIController = (CommonUIController)LuaObject.checkSelf(l);
			bool enableScreenRecordFunction;
			LuaObject.checkType(l, 2, out enableScreenRecordFunction);
			commonUIController.EnableScreenRecordFunction = enableScreenRecordFunction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE87 RID: 118407 RVA: 0x0090BEA0 File Offset: 0x0090A0A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CommonUIController.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CE88 RID: 118408 RVA: 0x0090BEE8 File Offset: 0x0090A0E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CommonUIController");
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.InitTouchFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.DisposeTouchFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.SetTouchFxStyle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.SetTouchFXParentActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowErrorMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowDialogBox);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.CancelDialogBox);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowExplanation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowNotice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowLoading);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.HideLoading);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowWaitingNet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.EnableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.IsEnableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.FrameworkUITaskEnableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.IsFrameworkUITaskDisableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.FrameworkNetTaskEnableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.IsFrameworkNetTaskDisableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.PDSDKEnableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.IsAnyDisableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.IsDisableInputObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.IsTestToolbarObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowBlackFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowTestUIBackground);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowiPhoneXTest);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.StartFadeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.StartShowFadeOutLoadingFadeIn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.HideFadeOutLoadingFadeIn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.FadeIn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.FadeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.IsFading);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.StaticLateUpdate_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.OnAndroidBackKeyUp_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.OnDestroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.Co_ShowMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowNextNotice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.OnNoticeShowTweenFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.OnNoticeMoveTweenFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.DelayHideNotice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.UpdateDisableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.OnPDSDKWebViewOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.OnPDSDKWebViewClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.SetDisableInputHintColor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.ShowFadeOutLoadingFadeIn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.OnApplicationFocus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.OnApplicationPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.OnExplanationBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.MessageBoxAndQuitApp_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache40);
		string name = "m_hasFinishAndroidBackEvent";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_hasFinishAndroidBackEvent);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_hasFinishAndroidBackEvent);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache42, false);
		string name2 = "m_isRunningMessageBoxAndQuitApp";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_isRunningMessageBoxAndQuitApp);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_isRunningMessageBoxAndQuitApp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache44, false);
		string name3 = "s_instance";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_s_instance);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_s_instance);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache46, false);
		string name4 = "TestUI";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_TestUI);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_TestUI);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache48, true);
		string name5 = "m_xfWrapper";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_xfWrapper);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_xfWrapper);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4A, true);
		string name6 = "m_loadingGameObject";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_loadingGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_loadingGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4C, true);
		string name7 = "m_disableInputGameObject";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_disableInputGameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_disableInputGameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4E, true);
		string name8 = "m_disableInputHintImage";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_disableInputHintImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_disableInputHintImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache50, true);
		string name9 = "m_transparentMaskGameObject";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_transparentMaskGameObject);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_transparentMaskGameObject);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache52, true);
		string name10 = "m_blackFrameGameObject";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_blackFrameGameObject);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_blackFrameGameObject);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache54, true);
		string name11 = "m_fadeImage";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_fadeImage);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_fadeImage);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache56, true);
		string name12 = "m_testUIBackgroundGameObject";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_testUIBackgroundGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_testUIBackgroundGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache58, true);
		string name13 = "m_testUIBackgroundToolBarGameObject";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_testUIBackgroundToolBarGameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_testUIBackgroundToolBarGameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5A, true);
		string name14 = "m_testUIBackgroundToolToggleGameObject";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_testUIBackgroundToolToggleGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_testUIBackgroundToolToggleGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5C, true);
		string name15 = "m_iPhoneXTestGameObject";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_iPhoneXTestGameObject);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_iPhoneXTestGameObject);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5E, true);
		string name16 = "m_messageUIStateController";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_messageUIStateController);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_messageUIStateController);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache60, true);
		string name17 = "m_messageText";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_messageText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_messageText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache62, true);
		string name18 = "m_explanationUIStateController";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_explanationUIStateController);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_explanationUIStateController);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache64, true);
		string name19 = "m_explanationBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_explanationBackgroundButton);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_explanationBackgroundButton);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache66, true);
		string name20 = "m_explanationText";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_explanationText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_explanationText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache68, true);
		string name21 = "m_noticeGameObject";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_noticeGameObject);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_noticeGameObject);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6A, true);
		string name22 = "m_noticeText";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_noticeText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_noticeText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6C, true);
		string name23 = "m_screenRecorderGameObject";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_screenRecorderGameObject);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_screenRecorderGameObject);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6E, true);
		string name24 = "m_tipUIStateController";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_tipUIStateController);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_tipUIStateController);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache70, true);
		string name25 = "m_tipText";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_tipText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_tipText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache72, true);
		string name26 = "m_dialogBox";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_dialogBox);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_dialogBox);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache74, true);
		string name27 = "m_networkWatingStateController";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_networkWatingStateController);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_networkWatingStateController);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache76, true);
		string name28 = "m_screenFade";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_screenFade);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_screenFade);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache78, true);
		string name29 = "m_hideFadeOutLoadingFadeIn";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_hideFadeOutLoadingFadeIn);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_hideFadeOutLoadingFadeIn);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7A, true);
		string name30 = "m_defaultFadeOutTime";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_defaultFadeOutTime);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_defaultFadeOutTime);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7C, true);
		string name31 = "m_defaultFadeInTime";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_defaultFadeInTime);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_defaultFadeInTime);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7E, true);
		string name32 = "NoticeTweenSpeed";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_NoticeTweenSpeed);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache7F, null, false);
		string name33 = "ShowNoticeInterval";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_ShowNoticeInterval);
		}
		LuaObject.addMember(l, name33, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache80, null, false);
		string name34 = "ShowNoticeTime";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_ShowNoticeTime);
		}
		LuaObject.addMember(l, name34, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache81, null, false);
		string name35 = "m_isShowingNotice";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_isShowingNotice);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache82;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_isShowingNotice);
		}
		LuaObject.addMember(l, name35, get32, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache83, true);
		string name36 = "m_waitingNotices";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_waitingNotices);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache84;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_waitingNotices);
		}
		LuaObject.addMember(l, name36, get33, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache85, true);
		string name37 = "m_noticeTextInitPos";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_noticeTextInitPos);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache86;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_noticeTextInitPos);
		}
		LuaObject.addMember(l, name37, get34, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache87, true);
		string name38 = "m_noticeTextInitWidth";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_noticeTextInitWidth);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache88;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_noticeTextInitWidth);
		}
		LuaObject.addMember(l, name38, get35, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache89, true);
		string name39 = "m_delayHideNoticeCoroutine";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_delayHideNoticeCoroutine);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8A;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_delayHideNoticeCoroutine);
		}
		LuaObject.addMember(l, name39, get36, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8B, true);
		string name40 = "m_noticeShowTween";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_noticeShowTween);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_noticeShowTween);
		}
		LuaObject.addMember(l, name40, get37, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8D, true);
		string name41 = "m_noticeMoveTween";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_noticeMoveTween);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_noticeMoveTween);
		}
		LuaObject.addMember(l, name41, get38, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache8F, true);
		string name42 = "m_isGameDisableInput";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_isGameDisableInput);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_isGameDisableInput);
		}
		LuaObject.addMember(l, name42, get39, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache91, true);
		string name43 = "m_isFrameworkUITaskDisableInput";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_isFrameworkUITaskDisableInput);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_isFrameworkUITaskDisableInput);
		}
		LuaObject.addMember(l, name43, get40, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache93, true);
		string name44 = "m_isFrameworkNetTaskDisableInput";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_isFrameworkNetTaskDisableInput);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache94;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_isFrameworkNetTaskDisableInput);
		}
		LuaObject.addMember(l, name44, get41, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache95, true);
		string name45 = "m_isPDSDKDisableInput";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_isPDSDKDisableInput);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache96;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_isPDSDKDisableInput);
		}
		LuaObject.addMember(l, name45, get42, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache97, true);
		string name46 = "m_pauseTime";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_pauseTime);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache98;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_pauseTime);
		}
		LuaObject.addMember(l, name46, get43, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache99, true);
		string name47 = "m_unfocusDateTime";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_unfocusDateTime);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9A;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_unfocusDateTime);
		}
		LuaObject.addMember(l, name47, get44, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9B, true);
		string name48 = "m_unfocusTimer";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_unfocusTimer);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9C;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_unfocusTimer);
		}
		LuaObject.addMember(l, name48, get45, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9D, true);
		string name49 = "m_touchFx";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_m_touchFx);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_m_touchFx);
		}
		LuaObject.addMember(l, name49, get46, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cache9F, true);
		string name50 = "EnableScreenRecordFunction";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_EnableScreenRecordFunction);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA0;
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.set_EnableScreenRecordFunction);
		}
		LuaObject.addMember(l, name50, get47, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA1, true);
		string name51 = "Instance";
		if (Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CommonUIController.get_Instance);
		}
		LuaObject.addMember(l, name51, Lua_BlackJack_ProjectL_UI_CommonUIController.<>f__mg$cacheA2, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(CommonUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012FC1 RID: 77761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012FC2 RID: 77762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012FC3 RID: 77763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012FC4 RID: 77764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012FC5 RID: 77765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012FC6 RID: 77766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012FC7 RID: 77767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012FC8 RID: 77768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012FC9 RID: 77769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012FCA RID: 77770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012FCB RID: 77771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012FCC RID: 77772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012FCD RID: 77773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012FCE RID: 77774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012FCF RID: 77775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012FD0 RID: 77776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012FD1 RID: 77777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012FD2 RID: 77778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012FD3 RID: 77779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012FD4 RID: 77780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012FD5 RID: 77781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012FD6 RID: 77782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012FD7 RID: 77783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012FD8 RID: 77784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012FD9 RID: 77785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012FDA RID: 77786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012FDB RID: 77787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012FDC RID: 77788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012FDD RID: 77789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012FDE RID: 77790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012FDF RID: 77791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012FE0 RID: 77792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012FE1 RID: 77793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012FE2 RID: 77794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012FE3 RID: 77795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012FE4 RID: 77796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012FE5 RID: 77797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012FE6 RID: 77798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012FE7 RID: 77799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012FE8 RID: 77800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012FE9 RID: 77801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012FEA RID: 77802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012FEB RID: 77803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012FEC RID: 77804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012FED RID: 77805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012FEE RID: 77806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012FEF RID: 77807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012FF0 RID: 77808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012FF1 RID: 77809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012FF2 RID: 77810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012FF3 RID: 77811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012FF4 RID: 77812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012FF5 RID: 77813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012FF6 RID: 77814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012FF7 RID: 77815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04012FF8 RID: 77816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04012FF9 RID: 77817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04012FFA RID: 77818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04012FFB RID: 77819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04012FFC RID: 77820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04012FFD RID: 77821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04012FFE RID: 77822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04012FFF RID: 77823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013000 RID: 77824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013001 RID: 77825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013002 RID: 77826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013003 RID: 77827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013004 RID: 77828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013005 RID: 77829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013006 RID: 77830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013007 RID: 77831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04013008 RID: 77832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04013009 RID: 77833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401300A RID: 77834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401300B RID: 77835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401300C RID: 77836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401300D RID: 77837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0401300E RID: 77838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0401300F RID: 77839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04013010 RID: 77840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04013011 RID: 77841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04013012 RID: 77842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04013013 RID: 77843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04013014 RID: 77844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04013015 RID: 77845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04013016 RID: 77846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04013017 RID: 77847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04013018 RID: 77848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04013019 RID: 77849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401301A RID: 77850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401301B RID: 77851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401301C RID: 77852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401301D RID: 77853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0401301E RID: 77854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0401301F RID: 77855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04013020 RID: 77856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04013021 RID: 77857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04013022 RID: 77858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04013023 RID: 77859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04013024 RID: 77860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04013025 RID: 77861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04013026 RID: 77862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04013027 RID: 77863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04013028 RID: 77864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04013029 RID: 77865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401302A RID: 77866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401302B RID: 77867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401302C RID: 77868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401302D RID: 77869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0401302E RID: 77870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0401302F RID: 77871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04013030 RID: 77872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04013031 RID: 77873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04013032 RID: 77874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04013033 RID: 77875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04013034 RID: 77876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04013035 RID: 77877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04013036 RID: 77878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04013037 RID: 77879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04013038 RID: 77880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04013039 RID: 77881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401303A RID: 77882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0401303B RID: 77883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0401303C RID: 77884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401303D RID: 77885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0401303E RID: 77886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0401303F RID: 77887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04013040 RID: 77888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04013041 RID: 77889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04013042 RID: 77890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04013043 RID: 77891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04013044 RID: 77892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04013045 RID: 77893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04013046 RID: 77894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04013047 RID: 77895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04013048 RID: 77896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04013049 RID: 77897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0401304A RID: 77898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0401304B RID: 77899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0401304C RID: 77900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401304D RID: 77901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401304E RID: 77902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0401304F RID: 77903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04013050 RID: 77904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04013051 RID: 77905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04013052 RID: 77906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04013053 RID: 77907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04013054 RID: 77908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04013055 RID: 77909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04013056 RID: 77910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04013057 RID: 77911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04013058 RID: 77912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04013059 RID: 77913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0401305A RID: 77914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0401305B RID: 77915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0401305C RID: 77916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0401305D RID: 77917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0401305E RID: 77918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0401305F RID: 77919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04013060 RID: 77920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04013061 RID: 77921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04013062 RID: 77922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04013063 RID: 77923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;
}
