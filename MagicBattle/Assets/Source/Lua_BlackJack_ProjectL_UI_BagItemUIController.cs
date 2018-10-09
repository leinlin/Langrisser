using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001394 RID: 5012
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BagItemUIController : LuaObject
{
	// Token: 0x0601B528 RID: 111912 RVA: 0x00843660 File Offset: 0x00841860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBagItemInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			BagItemBase bagItemInfo;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItemInfo);
			bagItemUIController.SetBagItemInfo(bagItemInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B529 RID: 111913 RVA: 0x008436B8 File Offset: 0x008418B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowFrame(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			bagItemUIController.ShowFrame(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B52A RID: 111914 RVA: 0x00843710 File Offset: 0x00841910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCheckFrame(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			bagItemUIController.ShowCheckFrame(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B52B RID: 111915 RVA: 0x00843768 File Offset: 0x00841968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowGreyMask(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			bagItemUIController.ShowGreyMask(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B52C RID: 111916 RVA: 0x008437C0 File Offset: 0x008419C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			bagItemUIController.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B52D RID: 111917 RVA: 0x0084380C File Offset: 0x00841A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterItemClickEvent(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			bagItemUIController.RegisterItemClickEvent(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B52E RID: 111918 RVA: 0x00843864 File Offset: 0x00841A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterItemNeedFillEvent(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			bagItemUIController.RegisterItemNeedFillEvent(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B52F RID: 111919 RVA: 0x008438BC File Offset: 0x00841ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			bagItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B530 RID: 111920 RVA: 0x00843910 File Offset: 0x00841B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetItemInfoByType(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			GoodsType itemInfoByType;
			LuaObject.checkEnum<GoodsType>(l, 2, out itemInfoByType);
			bagItemUIController.m_luaExportHelper.SetItemInfoByType(itemInfoByType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B531 RID: 111921 RVA: 0x0084396C File Offset: 0x00841B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetItemStateByType(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			GoodsType itemStateByType;
			LuaObject.checkEnum<GoodsType>(l, 2, out itemStateByType);
			bagItemUIController.m_luaExportHelper.SetItemStateByType(itemStateByType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B532 RID: 111922 RVA: 0x008439C8 File Offset: 0x00841BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			bagItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B533 RID: 111923 RVA: 0x00843A34 File Offset: 0x00841C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			bagItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B534 RID: 111924 RVA: 0x00843A88 File Offset: 0x00841C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			bagItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B535 RID: 111925 RVA: 0x00843ADC File Offset: 0x00841CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = bagItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B536 RID: 111926 RVA: 0x00843B84 File Offset: 0x00841D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			bagItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B537 RID: 111927 RVA: 0x00843BD8 File Offset: 0x00841DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			bagItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B538 RID: 111928 RVA: 0x00843C44 File Offset: 0x00841E44
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
				BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				bagItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BagItemUIController bagItemUIController2 = (BagItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				bagItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B539 RID: 111929 RVA: 0x00843D54 File Offset: 0x00841F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B53A RID: 111930 RVA: 0x00843DC0 File Offset: 0x00841FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B53B RID: 111931 RVA: 0x00843E2C File Offset: 0x0084202C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B53C RID: 111932 RVA: 0x00843E98 File Offset: 0x00842098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			bagItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B53D RID: 111933 RVA: 0x00843F04 File Offset: 0x00842104
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
				BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				bagItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BagItemUIController bagItemUIController2 = (BagItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				bagItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B53E RID: 111934 RVA: 0x00844014 File Offset: 0x00842214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			string s = bagItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B53F RID: 111935 RVA: 0x00844070 File Offset: 0x00842270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B540 RID: 111936 RVA: 0x008440C4 File Offset: 0x008422C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			bagItemUIController.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B541 RID: 111937 RVA: 0x0084411C File Offset: 0x0084231C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countText(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_countText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B542 RID: 111938 RVA: 0x00844170 File Offset: 0x00842370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countText(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			Text countText;
			LuaObject.checkType<Text>(l, 2, out countText);
			bagItemUIController.m_countText = countText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B543 RID: 111939 RVA: 0x008441C8 File Offset: 0x008423C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B544 RID: 111940 RVA: 0x0084421C File Offset: 0x0084241C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			bagItemUIController.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B545 RID: 111941 RVA: 0x00844274 File Offset: 0x00842474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectFrameImage(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_selectFrameImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B546 RID: 111942 RVA: 0x008442C8 File Offset: 0x008424C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectFrameImage(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			GameObject selectFrameImage;
			LuaObject.checkType<GameObject>(l, 2, out selectFrameImage);
			bagItemUIController.m_selectFrameImage = selectFrameImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B547 RID: 111943 RVA: 0x00844320 File Offset: 0x00842520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fragmentSelectFrameImg(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_fragmentSelectFrameImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B548 RID: 111944 RVA: 0x00844374 File Offset: 0x00842574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fragmentSelectFrameImg(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			GameObject fragmentSelectFrameImg;
			LuaObject.checkType<GameObject>(l, 2, out fragmentSelectFrameImg);
			bagItemUIController.m_fragmentSelectFrameImg = fragmentSelectFrameImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B549 RID: 111945 RVA: 0x008443CC File Offset: 0x008425CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_checkFrameImage(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_checkFrameImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B54A RID: 111946 RVA: 0x00844420 File Offset: 0x00842620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_checkFrameImage(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			GameObject checkFrameImage;
			LuaObject.checkType<GameObject>(l, 2, out checkFrameImage);
			bagItemUIController.m_checkFrameImage = checkFrameImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B54B RID: 111947 RVA: 0x00844478 File Offset: 0x00842678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgImage(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_bgImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B54C RID: 111948 RVA: 0x008444CC File Offset: 0x008426CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgImage(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			Image bgImage;
			LuaObject.checkType<Image>(l, 2, out bgImage);
			bagItemUIController.m_bgImage = bgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B54D RID: 111949 RVA: 0x00844524 File Offset: 0x00842724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrEffect(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_ssrEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B54E RID: 111950 RVA: 0x00844578 File Offset: 0x00842778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrEffect(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			GameObject ssrEffect;
			LuaObject.checkType<GameObject>(l, 2, out ssrEffect);
			bagItemUIController.m_ssrEffect = ssrEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B54F RID: 111951 RVA: 0x008445D0 File Offset: 0x008427D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockImage(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_lockImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B550 RID: 111952 RVA: 0x00844624 File Offset: 0x00842824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockImage(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			GameObject lockImage;
			LuaObject.checkType<GameObject>(l, 2, out lockImage);
			bagItemUIController.m_lockImage = lockImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B551 RID: 111953 RVA: 0x0084467C File Offset: 0x0084287C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lvValueText(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_lvValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B552 RID: 111954 RVA: 0x008446D0 File Offset: 0x008428D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lvValueText(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			Text lvValueText;
			LuaObject.checkType<Text>(l, 2, out lvValueText);
			bagItemUIController.m_lvValueText = lvValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B553 RID: 111955 RVA: 0x00844728 File Offset: 0x00842928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipingTag(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_equipingTag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B554 RID: 111956 RVA: 0x0084477C File Offset: 0x0084297C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipingTag(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			GameObject equipingTag;
			LuaObject.checkType<GameObject>(l, 2, out equipingTag);
			bagItemUIController.m_equipingTag = equipingTag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B555 RID: 111957 RVA: 0x008447D4 File Offset: 0x008429D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipingTagHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_equipingTagHeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B556 RID: 111958 RVA: 0x00844828 File Offset: 0x00842A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipingTagHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			Image equipingTagHeadIcon;
			LuaObject.checkType<Image>(l, 2, out equipingTagHeadIcon);
			bagItemUIController.m_equipingTagHeadIcon = equipingTagHeadIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B557 RID: 111959 RVA: 0x00844880 File Offset: 0x00842A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starGroup(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_starGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B558 RID: 111960 RVA: 0x008448D4 File Offset: 0x00842AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starGroup(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			GameObject starGroup;
			LuaObject.checkType<GameObject>(l, 2, out starGroup);
			bagItemUIController.m_starGroup = starGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B559 RID: 111961 RVA: 0x0084492C File Offset: 0x00842B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_greyMaskItem(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_greyMaskItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B55A RID: 111962 RVA: 0x00844980 File Offset: 0x00842B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_greyMaskItem(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			GameObject greyMaskItem;
			LuaObject.checkType<GameObject>(l, 2, out greyMaskItem);
			bagItemUIController.m_greyMaskItem = greyMaskItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B55B RID: 111963 RVA: 0x008449D8 File Offset: 0x00842BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_greyMaskPiece(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_greyMaskPiece);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B55C RID: 111964 RVA: 0x00844A2C File Offset: 0x00842C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_greyMaskPiece(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			GameObject greyMaskPiece;
			LuaObject.checkType<GameObject>(l, 2, out greyMaskPiece);
			bagItemUIController.m_greyMaskPiece = greyMaskPiece;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B55D RID: 111965 RVA: 0x00844A84 File Offset: 0x00842C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantmentIcon(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_enchantmentIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B55E RID: 111966 RVA: 0x00844AD8 File Offset: 0x00842CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantmentIcon(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			Image enchantmentIcon;
			LuaObject.checkType<Image>(l, 2, out enchantmentIcon);
			bagItemUIController.m_enchantmentIcon = enchantmentIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B55F RID: 111967 RVA: 0x00844B30 File Offset: 0x00842D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_itemInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B560 RID: 111968 RVA: 0x00844B84 File Offset: 0x00842D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			ConfigDataItemInfo itemInfo;
			LuaObject.checkType<ConfigDataItemInfo>(l, 2, out itemInfo);
			bagItemUIController.m_itemInfo = itemInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B561 RID: 111969 RVA: 0x00844BDC File Offset: 0x00842DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMaterialInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_jobMaterialInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B562 RID: 111970 RVA: 0x00844C30 File Offset: 0x00842E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMaterialInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			ConfigDataJobMaterialInfo jobMaterialInfo;
			LuaObject.checkType<ConfigDataJobMaterialInfo>(l, 2, out jobMaterialInfo);
			bagItemUIController.m_jobMaterialInfo = jobMaterialInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B563 RID: 111971 RVA: 0x00844C88 File Offset: 0x00842E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_equipmentInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B564 RID: 111972 RVA: 0x00844CDC File Offset: 0x00842EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			ConfigDataEquipmentInfo equipmentInfo;
			LuaObject.checkType<ConfigDataEquipmentInfo>(l, 2, out equipmentInfo);
			bagItemUIController.m_equipmentInfo = equipmentInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B565 RID: 111973 RVA: 0x00844D34 File Offset: 0x00842F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enchantStoneInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.m_enchantStoneInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B566 RID: 111974 RVA: 0x00844D88 File Offset: 0x00842F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enchantStoneInfo(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			ConfigDataEnchantStoneInfo enchantStoneInfo;
			LuaObject.checkType<ConfigDataEnchantStoneInfo>(l, 2, out enchantStoneInfo);
			bagItemUIController.m_enchantStoneInfo = enchantStoneInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B567 RID: 111975 RVA: 0x00844DE0 File Offset: 0x00842FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScrollItemBaseUICtrl(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.ScrollItemBaseUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B568 RID: 111976 RVA: 0x00844E34 File Offset: 0x00843034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ScrollItemBaseUICtrl(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			ScrollItemBaseUIController scrollItemBaseUICtrl;
			LuaObject.checkType<ScrollItemBaseUIController>(l, 2, out scrollItemBaseUICtrl);
			bagItemUIController.ScrollItemBaseUICtrl = scrollItemBaseUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B569 RID: 111977 RVA: 0x00844E8C File Offset: 0x0084308C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BagItem(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemUIController.BagItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B56A RID: 111978 RVA: 0x00844EE0 File Offset: 0x008430E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BagItem(IntPtr l)
	{
		int result;
		try
		{
			BagItemUIController bagItemUIController = (BagItemUIController)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			bagItemUIController.m_luaExportHelper.BagItem = bagItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B56B RID: 111979 RVA: 0x00844F3C File Offset: 0x0084313C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BagItemUIController");
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.SetBagItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.ShowFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.ShowCheckFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.ShowGreyMask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.RegisterItemClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.RegisterItemNeedFillEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.SetItemInfoByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.SetItemStateByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache16);
		string name = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_stateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache18, true);
		string name2 = "m_countText";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_countText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_countText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1A, true);
		string name3 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_iconImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1C, true);
		string name4 = "m_selectFrameImage";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_selectFrameImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_selectFrameImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1E, true);
		string name5 = "m_fragmentSelectFrameImg";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_fragmentSelectFrameImg);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_fragmentSelectFrameImg);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache20, true);
		string name6 = "m_checkFrameImage";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_checkFrameImage);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_checkFrameImage);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache22, true);
		string name7 = "m_bgImage";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_bgImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_bgImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache24, true);
		string name8 = "m_ssrEffect";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_ssrEffect);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_ssrEffect);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache26, true);
		string name9 = "m_lockImage";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_lockImage);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_lockImage);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache28, true);
		string name10 = "m_lvValueText";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_lvValueText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_lvValueText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2A, true);
		string name11 = "m_equipingTag";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_equipingTag);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_equipingTag);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2C, true);
		string name12 = "m_equipingTagHeadIcon";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_equipingTagHeadIcon);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_equipingTagHeadIcon);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2E, true);
		string name13 = "m_starGroup";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_starGroup);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_starGroup);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache30, true);
		string name14 = "m_greyMaskItem";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_greyMaskItem);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_greyMaskItem);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache32, true);
		string name15 = "m_greyMaskPiece";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_greyMaskPiece);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_greyMaskPiece);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache34, true);
		string name16 = "m_enchantmentIcon";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_enchantmentIcon);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_enchantmentIcon);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache36, true);
		string name17 = "m_itemInfo";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_itemInfo);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_itemInfo);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache38, true);
		string name18 = "m_jobMaterialInfo";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_jobMaterialInfo);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_jobMaterialInfo);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3A, true);
		string name19 = "m_equipmentInfo";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_equipmentInfo);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_equipmentInfo);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3C, true);
		string name20 = "m_enchantStoneInfo";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_m_enchantStoneInfo);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_m_enchantStoneInfo);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3E, true);
		string name21 = "ScrollItemBaseUICtrl";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_ScrollItemBaseUICtrl);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_ScrollItemBaseUICtrl);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache40, true);
		string name22 = "BagItem";
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.get_BagItem);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemUIController.set_BagItem);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BagItemUIController.<>f__mg$cache42, true);
		LuaObject.createTypeMetatable(l, null, typeof(BagItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040117E2 RID: 71650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040117E3 RID: 71651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040117E4 RID: 71652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040117E5 RID: 71653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040117E6 RID: 71654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040117E7 RID: 71655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040117E8 RID: 71656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040117E9 RID: 71657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040117EA RID: 71658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040117EB RID: 71659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040117EC RID: 71660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040117ED RID: 71661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040117EE RID: 71662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040117EF RID: 71663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040117F0 RID: 71664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040117F1 RID: 71665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040117F2 RID: 71666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040117F3 RID: 71667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040117F4 RID: 71668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040117F5 RID: 71669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040117F6 RID: 71670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040117F7 RID: 71671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040117F8 RID: 71672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040117F9 RID: 71673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040117FA RID: 71674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040117FB RID: 71675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040117FC RID: 71676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040117FD RID: 71677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040117FE RID: 71678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040117FF RID: 71679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011800 RID: 71680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011801 RID: 71681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011802 RID: 71682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011803 RID: 71683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011804 RID: 71684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011805 RID: 71685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011806 RID: 71686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011807 RID: 71687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011808 RID: 71688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011809 RID: 71689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401180A RID: 71690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401180B RID: 71691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401180C RID: 71692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401180D RID: 71693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401180E RID: 71694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401180F RID: 71695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011810 RID: 71696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011811 RID: 71697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011812 RID: 71698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011813 RID: 71699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011814 RID: 71700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04011815 RID: 71701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04011816 RID: 71702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04011817 RID: 71703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04011818 RID: 71704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04011819 RID: 71705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401181A RID: 71706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401181B RID: 71707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401181C RID: 71708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401181D RID: 71709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401181E RID: 71710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401181F RID: 71711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011820 RID: 71712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04011821 RID: 71713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04011822 RID: 71714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04011823 RID: 71715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04011824 RID: 71716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;
}
