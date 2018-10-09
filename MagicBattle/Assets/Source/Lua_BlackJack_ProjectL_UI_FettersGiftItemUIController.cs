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

// Token: 0x0200143B RID: 5179
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController : LuaObject
{
	// Token: 0x0601DCC6 RID: 122054 RVA: 0x0097F1C0 File Offset: 0x0097D3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGiftItemInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			int heroId;
			LuaObject.checkType(l, 3, out heroId);
			fettersGiftItemUIController.SetGiftItemInfo(bagItem, heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCC7 RID: 122055 RVA: 0x0097F224 File Offset: 0x0097D424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectFrameImage(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			fettersGiftItemUIController.ShowSelectFrameImage(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCC8 RID: 122056 RVA: 0x0097F27C File Offset: 0x0097D47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCountTextValue(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			int countTextValue;
			LuaObject.checkType(l, 2, out countTextValue);
			fettersGiftItemUIController.SetCountTextValue(countTextValue);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCC9 RID: 122057 RVA: 0x0097F2D4 File Offset: 0x0097D4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			fettersGiftItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCCA RID: 122058 RVA: 0x0097F328 File Offset: 0x0097D528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			fettersGiftItemUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCCB RID: 122059 RVA: 0x0097F37C File Offset: 0x0097D57C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			fettersGiftItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCCC RID: 122060 RVA: 0x0097F3E8 File Offset: 0x0097D5E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			fettersGiftItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCCD RID: 122061 RVA: 0x0097F43C File Offset: 0x0097D63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			fettersGiftItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCCE RID: 122062 RVA: 0x0097F490 File Offset: 0x0097D690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = fettersGiftItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DCCF RID: 122063 RVA: 0x0097F538 File Offset: 0x0097D738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			fettersGiftItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCD0 RID: 122064 RVA: 0x0097F58C File Offset: 0x0097D78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			fettersGiftItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCD1 RID: 122065 RVA: 0x0097F5F8 File Offset: 0x0097D7F8
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
				FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				fettersGiftItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FettersGiftItemUIController fettersGiftItemUIController2 = (FettersGiftItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				fettersGiftItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DCD2 RID: 122066 RVA: 0x0097F708 File Offset: 0x0097D908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersGiftItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCD3 RID: 122067 RVA: 0x0097F774 File Offset: 0x0097D974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersGiftItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCD4 RID: 122068 RVA: 0x0097F7E0 File Offset: 0x0097D9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersGiftItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCD5 RID: 122069 RVA: 0x0097F84C File Offset: 0x0097DA4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersGiftItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCD6 RID: 122070 RVA: 0x0097F8B8 File Offset: 0x0097DAB8
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
				FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				fettersGiftItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FettersGiftItemUIController fettersGiftItemUIController2 = (FettersGiftItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				fettersGiftItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DCD7 RID: 122071 RVA: 0x0097F9C8 File Offset: 0x0097DBC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			string s = fettersGiftItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DCD8 RID: 122072 RVA: 0x0097FA24 File Offset: 0x0097DC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			FettersGiftItemUIController arg;
			LuaObject.checkType<FettersGiftItemUIController>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			fettersGiftItemUIController.m_luaExportHelper.__callDele_EventOnItemClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCD9 RID: 122073 RVA: 0x0097FA90 File Offset: 0x0097DC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			FettersGiftItemUIController arg;
			LuaObject.checkType<FettersGiftItemUIController>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			fettersGiftItemUIController.m_luaExportHelper.__clearDele_EventOnItemClick(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCDA RID: 122074 RVA: 0x0097FAFC File Offset: 0x0097DCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			Action<FettersGiftItemUIController, bool> value;
			int num = LuaObject.checkDelegate<Action<FettersGiftItemUIController, bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersGiftItemUIController.EventOnItemClick += value;
				}
				else if (num == 2)
				{
					fettersGiftItemUIController.EventOnItemClick -= value;
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

	// Token: 0x0601DCDB RID: 122075 RVA: 0x0097FB7C File Offset: 0x0097DD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersGiftItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCDC RID: 122076 RVA: 0x0097FBD4 File Offset: 0x0097DDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			fettersGiftItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCDD RID: 122077 RVA: 0x0097FC30 File Offset: 0x0097DE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rankBgImage(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersGiftItemUIController.m_luaExportHelper.m_rankBgImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCDE RID: 122078 RVA: 0x0097FC88 File Offset: 0x0097DE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rankBgImage(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			Image rankBgImage;
			LuaObject.checkType<Image>(l, 2, out rankBgImage);
			fettersGiftItemUIController.m_luaExportHelper.m_rankBgImage = rankBgImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCDF RID: 122079 RVA: 0x0097FCE4 File Offset: 0x0097DEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersGiftItemUIController.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCE0 RID: 122080 RVA: 0x0097FD3C File Offset: 0x0097DF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			fettersGiftItemUIController.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCE1 RID: 122081 RVA: 0x0097FD98 File Offset: 0x0097DF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countText(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersGiftItemUIController.m_luaExportHelper.m_countText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCE2 RID: 122082 RVA: 0x0097FDF0 File Offset: 0x0097DFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countText(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			Text countText;
			LuaObject.checkType<Text>(l, 2, out countText);
			fettersGiftItemUIController.m_luaExportHelper.m_countText = countText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCE3 RID: 122083 RVA: 0x0097FE4C File Offset: 0x0097E04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addGo(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersGiftItemUIController.m_luaExportHelper.m_addGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCE4 RID: 122084 RVA: 0x0097FEA4 File Offset: 0x0097E0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addGo(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			GameObject addGo;
			LuaObject.checkType<GameObject>(l, 2, out addGo);
			fettersGiftItemUIController.m_luaExportHelper.m_addGo = addGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCE5 RID: 122085 RVA: 0x0097FF00 File Offset: 0x0097E100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectFrameImage(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersGiftItemUIController.m_luaExportHelper.m_selectFrameImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCE6 RID: 122086 RVA: 0x0097FF58 File Offset: 0x0097E158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectFrameImage(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			GameObject selectFrameImage;
			LuaObject.checkType<GameObject>(l, 2, out selectFrameImage);
			fettersGiftItemUIController.m_luaExportHelper.m_selectFrameImage = selectFrameImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCE7 RID: 122087 RVA: 0x0097FFB4 File Offset: 0x0097E1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goods(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersGiftItemUIController.m_luaExportHelper.m_goods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCE8 RID: 122088 RVA: 0x0098000C File Offset: 0x0097E20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goods(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			Goods goods;
			LuaObject.checkType<Goods>(l, 2, out goods);
			fettersGiftItemUIController.m_luaExportHelper.m_goods = goods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCE9 RID: 122089 RVA: 0x00980068 File Offset: 0x0097E268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BagItem(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersGiftItemUIController.BagItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCEA RID: 122090 RVA: 0x009800BC File Offset: 0x0097E2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BagItem(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			fettersGiftItemUIController.m_luaExportHelper.BagItem = bagItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCEB RID: 122091 RVA: 0x00980118 File Offset: 0x0097E318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AddExpValue(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersGiftItemUIController.AddExpValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCEC RID: 122092 RVA: 0x0098016C File Offset: 0x0097E36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AddExpValue(IntPtr l)
	{
		int result;
		try
		{
			FettersGiftItemUIController fettersGiftItemUIController = (FettersGiftItemUIController)LuaObject.checkSelf(l);
			int addExpValue;
			LuaObject.checkType(l, 2, out addExpValue);
			fettersGiftItemUIController.m_luaExportHelper.AddExpValue = addExpValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DCED RID: 122093 RVA: 0x009801C8 File Offset: 0x0097E3C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersGiftItemUIController");
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.SetGiftItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.ShowSelectFrameImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.SetCountTextValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__callDele_EventOnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.__clearDele_EventOnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache13);
		string name = "EventOnItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.set_EventOnItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache14, true);
		string name2 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.get_m_button);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache16, true);
		string name3 = "m_rankBgImage";
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.get_m_rankBgImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.set_m_rankBgImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache18, true);
		string name4 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.get_m_image);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.set_m_image);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1A, true);
		string name5 = "m_countText";
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.get_m_countText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.set_m_countText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1C, true);
		string name6 = "m_addGo";
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.get_m_addGo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.set_m_addGo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1E, true);
		string name7 = "m_selectFrameImage";
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.get_m_selectFrameImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.set_m_selectFrameImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache20, true);
		string name8 = "m_goods";
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.get_m_goods);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.set_m_goods);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache22, true);
		string name9 = "BagItem";
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.get_BagItem);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.set_BagItem);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache24, true);
		string name10 = "AddExpValue";
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.get_AddExpValue);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.set_AddExpValue);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FettersGiftItemUIController.<>f__mg$cache26, true);
		LuaObject.createTypeMetatable(l, null, typeof(FettersGiftItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013E32 RID: 81458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013E33 RID: 81459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013E34 RID: 81460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013E35 RID: 81461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013E36 RID: 81462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013E37 RID: 81463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013E38 RID: 81464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013E39 RID: 81465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013E3A RID: 81466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013E3B RID: 81467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013E3C RID: 81468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013E3D RID: 81469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013E3E RID: 81470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013E3F RID: 81471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013E40 RID: 81472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013E41 RID: 81473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013E42 RID: 81474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013E43 RID: 81475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013E44 RID: 81476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013E45 RID: 81477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013E46 RID: 81478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013E47 RID: 81479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013E48 RID: 81480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013E49 RID: 81481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013E4A RID: 81482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013E4B RID: 81483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013E4C RID: 81484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013E4D RID: 81485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013E4E RID: 81486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013E4F RID: 81487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013E50 RID: 81488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013E51 RID: 81489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013E52 RID: 81490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013E53 RID: 81491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013E54 RID: 81492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013E55 RID: 81493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013E56 RID: 81494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013E57 RID: 81495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013E58 RID: 81496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
