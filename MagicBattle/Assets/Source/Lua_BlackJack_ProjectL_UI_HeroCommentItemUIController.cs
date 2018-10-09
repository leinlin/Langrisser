using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014AA RID: 5290
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController : LuaObject
{
	// Token: 0x0601EA7A RID: 125562 RVA: 0x009EAF3C File Offset: 0x009E913C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitCommentItem(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			HeroCommentEntry comment;
			LuaObject.checkType<HeroCommentEntry>(l, 2, out comment);
			bool isShowPraisedIcon;
			LuaObject.checkType(l, 3, out isShowPraisedIcon);
			heroCommentItemUIController.InitCommentItem(comment, isShowPraisedIcon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA7B RID: 125563 RVA: 0x009EAFA0 File Offset: 0x009E91A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			heroCommentItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA7C RID: 125564 RVA: 0x009EAFF4 File Offset: 0x009E91F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPlayerNameButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			heroCommentItemUIController.m_luaExportHelper.OnPlayerNameButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA7D RID: 125565 RVA: 0x009EB048 File Offset: 0x009E9248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayerPraisedButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			heroCommentItemUIController.m_luaExportHelper.OnPlayerPraisedButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA7E RID: 125566 RVA: 0x009EB09C File Offset: 0x009E929C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroCommentItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA7F RID: 125567 RVA: 0x009EB108 File Offset: 0x009E9308
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			heroCommentItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA80 RID: 125568 RVA: 0x009EB15C File Offset: 0x009E935C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			heroCommentItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA81 RID: 125569 RVA: 0x009EB1B0 File Offset: 0x009E93B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroCommentItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EA82 RID: 125570 RVA: 0x009EB258 File Offset: 0x009E9458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			heroCommentItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA83 RID: 125571 RVA: 0x009EB2AC File Offset: 0x009E94AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroCommentItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA84 RID: 125572 RVA: 0x009EB318 File Offset: 0x009E9518
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
				HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroCommentItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroCommentItemUIController heroCommentItemUIController2 = (HeroCommentItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroCommentItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601EA85 RID: 125573 RVA: 0x009EB428 File Offset: 0x009E9628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCommentItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA86 RID: 125574 RVA: 0x009EB494 File Offset: 0x009E9694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCommentItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA87 RID: 125575 RVA: 0x009EB500 File Offset: 0x009E9700
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCommentItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA88 RID: 125576 RVA: 0x009EB56C File Offset: 0x009E976C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroCommentItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA89 RID: 125577 RVA: 0x009EB5D8 File Offset: 0x009E97D8
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
				HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroCommentItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroCommentItemUIController heroCommentItemUIController2 = (HeroCommentItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroCommentItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601EA8A RID: 125578 RVA: 0x009EB6E8 File Offset: 0x009E98E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			string s = heroCommentItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EA8B RID: 125579 RVA: 0x009EB744 File Offset: 0x009E9944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNameClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			HeroCommentEntry obj;
			LuaObject.checkType<HeroCommentEntry>(l, 2, out obj);
			heroCommentItemUIController.m_luaExportHelper.__callDele_EventOnNameClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA8C RID: 125580 RVA: 0x009EB7A0 File Offset: 0x009E99A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNameClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			HeroCommentEntry obj;
			LuaObject.checkType<HeroCommentEntry>(l, 2, out obj);
			heroCommentItemUIController.m_luaExportHelper.__clearDele_EventOnNameClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA8D RID: 125581 RVA: 0x009EB7FC File Offset: 0x009E99FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnPraisedBtnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			ulong obj;
			LuaObject.checkType(l, 2, out obj);
			heroCommentItemUIController.m_luaExportHelper.__callDele_EventOnPraisedBtnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA8E RID: 125582 RVA: 0x009EB858 File Offset: 0x009E9A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPraisedBtnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			ulong obj;
			LuaObject.checkType(l, 2, out obj);
			heroCommentItemUIController.m_luaExportHelper.__clearDele_EventOnPraisedBtnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA8F RID: 125583 RVA: 0x009EB8B4 File Offset: 0x009E9AB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnNameClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			Action<HeroCommentEntry> value;
			int num = LuaObject.checkDelegate<Action<HeroCommentEntry>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroCommentItemUIController.EventOnNameClick += value;
				}
				else if (num == 2)
				{
					heroCommentItemUIController.EventOnNameClick -= value;
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

	// Token: 0x0601EA90 RID: 125584 RVA: 0x009EB934 File Offset: 0x009E9B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPraisedBtnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			Action<ulong> value;
			int num = LuaObject.checkDelegate<Action<ulong>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroCommentItemUIController.EventOnPraisedBtnClick += value;
				}
				else if (num == 2)
				{
					heroCommentItemUIController.EventOnPraisedBtnClick -= value;
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

	// Token: 0x0601EA91 RID: 125585 RVA: 0x009EB9B4 File Offset: 0x009E9BB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerPraisedIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentItemUIController.m_luaExportHelper.m_playerPraisedIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA92 RID: 125586 RVA: 0x009EBA0C File Offset: 0x009E9C0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerPraisedIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			GameObject playerPraisedIcon;
			LuaObject.checkType<GameObject>(l, 2, out playerPraisedIcon);
			heroCommentItemUIController.m_luaExportHelper.m_playerPraisedIcon = playerPraisedIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA93 RID: 125587 RVA: 0x009EBA68 File Offset: 0x009E9C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLvText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentItemUIController.m_luaExportHelper.m_playerLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA94 RID: 125588 RVA: 0x009EBAC0 File Offset: 0x009E9CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLvText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			Text playerLvText;
			LuaObject.checkType<Text>(l, 2, out playerLvText);
			heroCommentItemUIController.m_luaExportHelper.m_playerLvText = playerLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA95 RID: 125589 RVA: 0x009EBB1C File Offset: 0x009E9D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentItemUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA96 RID: 125590 RVA: 0x009EBB74 File Offset: 0x009E9D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			heroCommentItemUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA97 RID: 125591 RVA: 0x009EBBD0 File Offset: 0x009E9DD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerNameBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentItemUIController.m_luaExportHelper.m_playerNameBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA98 RID: 125592 RVA: 0x009EBC28 File Offset: 0x009E9E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			Button playerNameBtn;
			LuaObject.checkType<Button>(l, 2, out playerNameBtn);
			heroCommentItemUIController.m_luaExportHelper.m_playerNameBtn = playerNameBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA99 RID: 125593 RVA: 0x009EBC84 File Offset: 0x009E9E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerCommentText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentItemUIController.m_luaExportHelper.m_playerCommentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA9A RID: 125594 RVA: 0x009EBCDC File Offset: 0x009E9EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerCommentText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			Text playerCommentText;
			LuaObject.checkType<Text>(l, 2, out playerCommentText);
			heroCommentItemUIController.m_luaExportHelper.m_playerCommentText = playerCommentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA9B RID: 125595 RVA: 0x009EBD38 File Offset: 0x009E9F38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerPraisedNumText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentItemUIController.m_luaExportHelper.m_playerPraisedNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA9C RID: 125596 RVA: 0x009EBD90 File Offset: 0x009E9F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerPraisedNumText(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			Text playerPraisedNumText;
			LuaObject.checkType<Text>(l, 2, out playerPraisedNumText);
			heroCommentItemUIController.m_luaExportHelper.m_playerPraisedNumText = playerPraisedNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA9D RID: 125597 RVA: 0x009EBDEC File Offset: 0x009E9FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerPraisedBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentItemUIController.m_luaExportHelper.m_playerPraisedBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA9E RID: 125598 RVA: 0x009EBE44 File Offset: 0x009EA044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerPraisedBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			Button playerPraisedBtn;
			LuaObject.checkType<Button>(l, 2, out playerPraisedBtn);
			heroCommentItemUIController.m_luaExportHelper.m_playerPraisedBtn = playerPraisedBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EA9F RID: 125599 RVA: 0x009EBEA0 File Offset: 0x009EA0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Comment(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentItemUIController.Comment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAA0 RID: 125600 RVA: 0x009EBEF4 File Offset: 0x009EA0F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Comment(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			HeroCommentEntry comment;
			LuaObject.checkType<HeroCommentEntry>(l, 2, out comment);
			heroCommentItemUIController.m_luaExportHelper.Comment = comment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAA1 RID: 125601 RVA: 0x009EBF50 File Offset: 0x009EA150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CommenterId(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentItemUIController.CommenterId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAA2 RID: 125602 RVA: 0x009EBFA4 File Offset: 0x009EA1A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CommenterId(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			string commenterId;
			LuaObject.checkType(l, 2, out commenterId);
			heroCommentItemUIController.m_luaExportHelper.CommenterId = commenterId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAA3 RID: 125603 RVA: 0x009EC000 File Offset: 0x009EA200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CommentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentItemUIController.CommentInstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAA4 RID: 125604 RVA: 0x009EC054 File Offset: 0x009EA254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CommentInstanceId(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentItemUIController heroCommentItemUIController = (HeroCommentItemUIController)LuaObject.checkSelf(l);
			ulong commentInstanceId;
			LuaObject.checkType(l, 2, out commentInstanceId);
			heroCommentItemUIController.m_luaExportHelper.CommentInstanceId = commentInstanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EAA5 RID: 125605 RVA: 0x009EC0B0 File Offset: 0x009EA2B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroCommentItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.InitCommentItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.OnPlayerNameButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.OnPlayerPraisedButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callDele_EventOnNameClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__clearDele_EventOnNameClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__callDele_EventOnPraisedBtnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.__clearDele_EventOnPraisedBtnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache14);
		string name = "EventOnNameClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_EventOnNameClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache15, true);
		string name2 = "EventOnPraisedBtnClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_EventOnPraisedBtnClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache16, true);
		string name3 = "m_playerPraisedIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.get_m_playerPraisedIcon);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_m_playerPraisedIcon);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache18, true);
		string name4 = "m_playerLvText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.get_m_playerLvText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_m_playerLvText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1A, true);
		string name5 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.get_m_playerNameText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1C, true);
		string name6 = "m_playerNameBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.get_m_playerNameBtn);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_m_playerNameBtn);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1E, true);
		string name7 = "m_playerCommentText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.get_m_playerCommentText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_m_playerCommentText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache20, true);
		string name8 = "m_playerPraisedNumText";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.get_m_playerPraisedNumText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_m_playerPraisedNumText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache22, true);
		string name9 = "m_playerPraisedBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.get_m_playerPraisedBtn);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_m_playerPraisedBtn);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache24, true);
		string name10 = "Comment";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.get_Comment);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_Comment);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache26, true);
		string name11 = "CommenterId";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.get_CommenterId);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_CommenterId);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache28, true);
		string name12 = "CommentInstanceId";
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.get_CommentInstanceId);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.set_CommentInstanceId);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroCommentItemUIController.<>f__mg$cache2A, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroCommentItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014B08 RID: 84744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014B09 RID: 84745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014B0A RID: 84746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014B0B RID: 84747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014B0C RID: 84748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014B0D RID: 84749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014B0E RID: 84750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014B0F RID: 84751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014B10 RID: 84752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014B11 RID: 84753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014B12 RID: 84754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014B13 RID: 84755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014B14 RID: 84756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014B15 RID: 84757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014B16 RID: 84758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014B17 RID: 84759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014B18 RID: 84760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014B19 RID: 84761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014B1A RID: 84762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014B1B RID: 84763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014B1C RID: 84764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014B1D RID: 84765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014B1E RID: 84766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014B1F RID: 84767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014B20 RID: 84768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014B21 RID: 84769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014B22 RID: 84770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014B23 RID: 84771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014B24 RID: 84772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014B25 RID: 84773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014B26 RID: 84774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014B27 RID: 84775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014B28 RID: 84776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014B29 RID: 84777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014B2A RID: 84778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014B2B RID: 84779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014B2C RID: 84780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014B2D RID: 84781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014B2E RID: 84782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014B2F RID: 84783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014B30 RID: 84784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014B31 RID: 84785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014B32 RID: 84786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
