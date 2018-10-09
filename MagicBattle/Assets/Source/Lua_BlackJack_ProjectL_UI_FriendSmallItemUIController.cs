using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001456 RID: 5206
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController : LuaObject
{
	// Token: 0x0601DF37 RID: 122679 RVA: 0x00992274 File Offset: 0x00990474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFriendInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			UserSummary userSummy;
			LuaObject.checkType<UserSummary>(l, 2, out userSummy);
			FriendInfoType friendInfoType;
			LuaObject.checkEnum<FriendInfoType>(l, 3, out friendInfoType);
			friendSmallItemUIController.SetFriendInfo(userSummy, friendInfoType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF38 RID: 122680 RVA: 0x009922D8 File Offset: 0x009904D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUserID(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			string userID = friendSmallItemUIController.GetUserID();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF39 RID: 122681 RVA: 0x0099232C File Offset: 0x0099052C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUserSummy(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			UserSummary userSummy = friendSmallItemUIController.GetUserSummy();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userSummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF3A RID: 122682 RVA: 0x00992380 File Offset: 0x00990580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUserSelect(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			bool userSelect;
			LuaObject.checkType(l, 2, out userSelect);
			friendSmallItemUIController.SetUserSelect(userSelect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF3B RID: 122683 RVA: 0x009923D8 File Offset: 0x009905D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUserInGroup(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			bool userInGroup;
			LuaObject.checkType(l, 2, out userInGroup);
			friendSmallItemUIController.SetUserInGroup(userInGroup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF3C RID: 122684 RVA: 0x00992430 File Offset: 0x00990630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSimpleInfoPostionType(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			PlayerSimpleInfoUITask.PostionType simpleInfoPostionType = friendSmallItemUIController.GetSimpleInfoPostionType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)simpleInfoPostionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF3D RID: 122685 RVA: 0x00992484 File Offset: 0x00990684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerSimpleInfoPos(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Vector3 playerSimpleInfoPos = friendSmallItemUIController.GetPlayerSimpleInfoPos();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSimpleInfoPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF3E RID: 122686 RVA: 0x009924D8 File Offset: 0x009906D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			friendSmallItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF3F RID: 122687 RVA: 0x0099252C File Offset: 0x0099072C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			friendSmallItemUIController.m_luaExportHelper.OnItemButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF40 RID: 122688 RVA: 0x00992580 File Offset: 0x00990780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			friendSmallItemUIController.m_luaExportHelper.OnChatButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF41 RID: 122689 RVA: 0x009925D4 File Offset: 0x009907D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAgreeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			friendSmallItemUIController.m_luaExportHelper.OnAgreeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF42 RID: 122690 RVA: 0x00992628 File Offset: 0x00990828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisagreeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			friendSmallItemUIController.m_luaExportHelper.OnDisagreeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF43 RID: 122691 RVA: 0x0099267C File Offset: 0x0099087C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInGroupButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			friendSmallItemUIController.m_luaExportHelper.OnInGroupButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF44 RID: 122692 RVA: 0x009926D0 File Offset: 0x009908D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			friendSmallItemUIController.m_luaExportHelper.OnAddButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF45 RID: 122693 RVA: 0x00992724 File Offset: 0x00990924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			friendSmallItemUIController.m_luaExportHelper.OnSelectToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF46 RID: 122694 RVA: 0x00992780 File Offset: 0x00990980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			friendSmallItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF47 RID: 122695 RVA: 0x009927EC File Offset: 0x009909EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			friendSmallItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF48 RID: 122696 RVA: 0x00992840 File Offset: 0x00990A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			friendSmallItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF49 RID: 122697 RVA: 0x00992894 File Offset: 0x00990A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = friendSmallItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DF4A RID: 122698 RVA: 0x0099293C File Offset: 0x00990B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			friendSmallItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF4B RID: 122699 RVA: 0x00992990 File Offset: 0x00990B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			friendSmallItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF4C RID: 122700 RVA: 0x009929FC File Offset: 0x00990BFC
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
				FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				friendSmallItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FriendSmallItemUIController friendSmallItemUIController2 = (FriendSmallItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				friendSmallItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DF4D RID: 122701 RVA: 0x00992B0C File Offset: 0x00990D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendSmallItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF4E RID: 122702 RVA: 0x00992B78 File Offset: 0x00990D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendSmallItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF4F RID: 122703 RVA: 0x00992BE4 File Offset: 0x00990DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendSmallItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF50 RID: 122704 RVA: 0x00992C50 File Offset: 0x00990E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendSmallItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF51 RID: 122705 RVA: 0x00992CBC File Offset: 0x00990EBC
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
				FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				friendSmallItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FriendSmallItemUIController friendSmallItemUIController2 = (FriendSmallItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				friendSmallItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DF52 RID: 122706 RVA: 0x00992DCC File Offset: 0x00990FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			string s = friendSmallItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DF53 RID: 122707 RVA: 0x00992E28 File Offset: 0x00991028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController obj;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out obj);
			friendSmallItemUIController.m_luaExportHelper.__callDele_EventOnShowPlayerSimpleInfo(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF54 RID: 122708 RVA: 0x00992E84 File Offset: 0x00991084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController obj;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out obj);
			friendSmallItemUIController.m_luaExportHelper.__clearDele_EventOnShowPlayerSimpleInfo(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF55 RID: 122709 RVA: 0x00992EE0 File Offset: 0x009910E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAgree(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController obj;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out obj);
			friendSmallItemUIController.m_luaExportHelper.__callDele_EventOnAgree(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF56 RID: 122710 RVA: 0x00992F3C File Offset: 0x0099113C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAgree(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController obj;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out obj);
			friendSmallItemUIController.m_luaExportHelper.__clearDele_EventOnAgree(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF57 RID: 122711 RVA: 0x00992F98 File Offset: 0x00991198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDisagree(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController obj;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out obj);
			friendSmallItemUIController.m_luaExportHelper.__callDele_EventOnDisagree(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF58 RID: 122712 RVA: 0x00992FF4 File Offset: 0x009911F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDisagree(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController obj;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out obj);
			friendSmallItemUIController.m_luaExportHelper.__clearDele_EventOnDisagree(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF59 RID: 122713 RVA: 0x00993050 File Offset: 0x00991250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAdd(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController obj;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out obj);
			friendSmallItemUIController.m_luaExportHelper.__callDele_EventOnAdd(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF5A RID: 122714 RVA: 0x009930AC File Offset: 0x009912AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAdd(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController obj;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out obj);
			friendSmallItemUIController.m_luaExportHelper.__clearDele_EventOnAdd(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF5B RID: 122715 RVA: 0x00993108 File Offset: 0x00991308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			FriendSmallItemUIController arg2;
			LuaObject.checkType<FriendSmallItemUIController>(l, 3, out arg2);
			friendSmallItemUIController.m_luaExportHelper.__callDele_EventOnSelectToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF5C RID: 122716 RVA: 0x00993174 File Offset: 0x00991374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			FriendSmallItemUIController arg2;
			LuaObject.checkType<FriendSmallItemUIController>(l, 3, out arg2);
			friendSmallItemUIController.m_luaExportHelper.__clearDele_EventOnSelectToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF5D RID: 122717 RVA: 0x009931E0 File Offset: 0x009913E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChat(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController obj;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out obj);
			friendSmallItemUIController.m_luaExportHelper.__callDele_EventOnChat(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF5E RID: 122718 RVA: 0x0099323C File Offset: 0x0099143C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChat(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			FriendSmallItemUIController obj;
			LuaObject.checkType<FriendSmallItemUIController>(l, 2, out obj);
			friendSmallItemUIController.m_luaExportHelper.__clearDele_EventOnChat(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF5F RID: 122719 RVA: 0x00993298 File Offset: 0x00991498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowPlayerSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Action<FriendSmallItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendSmallItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendSmallItemUIController.EventOnShowPlayerSimpleInfo += value;
				}
				else if (num == 2)
				{
					friendSmallItemUIController.EventOnShowPlayerSimpleInfo -= value;
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

	// Token: 0x0601DF60 RID: 122720 RVA: 0x00993318 File Offset: 0x00991518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAgree(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Action<FriendSmallItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendSmallItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendSmallItemUIController.EventOnAgree += value;
				}
				else if (num == 2)
				{
					friendSmallItemUIController.EventOnAgree -= value;
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

	// Token: 0x0601DF61 RID: 122721 RVA: 0x00993398 File Offset: 0x00991598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDisagree(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Action<FriendSmallItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendSmallItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendSmallItemUIController.EventOnDisagree += value;
				}
				else if (num == 2)
				{
					friendSmallItemUIController.EventOnDisagree -= value;
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

	// Token: 0x0601DF62 RID: 122722 RVA: 0x00993418 File Offset: 0x00991618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAdd(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Action<FriendSmallItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendSmallItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendSmallItemUIController.EventOnAdd += value;
				}
				else if (num == 2)
				{
					friendSmallItemUIController.EventOnAdd -= value;
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

	// Token: 0x0601DF63 RID: 122723 RVA: 0x00993498 File Offset: 0x00991698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Action<bool, FriendSmallItemUIController> value;
			int num = LuaObject.checkDelegate<Action<bool, FriendSmallItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendSmallItemUIController.EventOnSelectToggleValueChanged += value;
				}
				else if (num == 2)
				{
					friendSmallItemUIController.EventOnSelectToggleValueChanged -= value;
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

	// Token: 0x0601DF64 RID: 122724 RVA: 0x00993518 File Offset: 0x00991718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChat(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Action<FriendSmallItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendSmallItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendSmallItemUIController.EventOnChat += value;
				}
				else if (num == 2)
				{
					friendSmallItemUIController.EventOnChat -= value;
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

	// Token: 0x0601DF65 RID: 122725 RVA: 0x00993598 File Offset: 0x00991798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF66 RID: 122726 RVA: 0x009935F0 File Offset: 0x009917F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			friendSmallItemUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF67 RID: 122727 RVA: 0x0099364C File Offset: 0x0099184C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_itemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF68 RID: 122728 RVA: 0x009936A4 File Offset: 0x009918A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Button itemButton;
			LuaObject.checkType<Button>(l, 2, out itemButton);
			friendSmallItemUIController.m_luaExportHelper.m_itemButton = itemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF69 RID: 122729 RVA: 0x00993700 File Offset: 0x00991900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_chatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF6A RID: 122730 RVA: 0x00993758 File Offset: 0x00991958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Button chatButton;
			LuaObject.checkType<Button>(l, 2, out chatButton);
			friendSmallItemUIController.m_luaExportHelper.m_chatButton = chatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF6B RID: 122731 RVA: 0x009937B4 File Offset: 0x009919B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buttonGroupUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_buttonGroupUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF6C RID: 122732 RVA: 0x0099380C File Offset: 0x00991A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buttonGroupUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController buttonGroupUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out buttonGroupUIStateController);
			friendSmallItemUIController.m_luaExportHelper.m_buttonGroupUIStateController = buttonGroupUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF6D RID: 122733 RVA: 0x00993868 File Offset: 0x00991A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendOnlineUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_friendOnlineUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF6E RID: 122734 RVA: 0x009938C0 File Offset: 0x00991AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendOnlineUIStateController(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController friendOnlineUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out friendOnlineUIStateController);
			friendSmallItemUIController.m_luaExportHelper.m_friendOnlineUIStateController = friendOnlineUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF6F RID: 122735 RVA: 0x0099391C File Offset: 0x00991B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendOnlineLongText(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_friendOnlineLongText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF70 RID: 122736 RVA: 0x00993974 File Offset: 0x00991B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendOnlineLongText(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Text friendOnlineLongText;
			LuaObject.checkType<Text>(l, 2, out friendOnlineLongText);
			friendSmallItemUIController.m_luaExportHelper.m_friendOnlineLongText = friendOnlineLongText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF71 RID: 122737 RVA: 0x009939D0 File Offset: 0x00991BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendIconImage(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_friendIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF72 RID: 122738 RVA: 0x00993A28 File Offset: 0x00991C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendIconImage(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Image friendIconImage;
			LuaObject.checkType<Image>(l, 2, out friendIconImage);
			friendSmallItemUIController.m_luaExportHelper.m_friendIconImage = friendIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF73 RID: 122739 RVA: 0x00993A84 File Offset: 0x00991C84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_friendIconGreyImage(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_friendIconGreyImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF74 RID: 122740 RVA: 0x00993ADC File Offset: 0x00991CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendIconGreyImage(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Image friendIconGreyImage;
			LuaObject.checkType<Image>(l, 2, out friendIconGreyImage);
			friendSmallItemUIController.m_luaExportHelper.m_friendIconGreyImage = friendIconGreyImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF75 RID: 122741 RVA: 0x00993B38 File Offset: 0x00991D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_friendHeadFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF76 RID: 122742 RVA: 0x00993B90 File Offset: 0x00991D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Transform friendHeadFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out friendHeadFrameTransform);
			friendSmallItemUIController.m_luaExportHelper.m_friendHeadFrameTransform = friendHeadFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF77 RID: 122743 RVA: 0x00993BEC File Offset: 0x00991DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_agreeButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_agreeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF78 RID: 122744 RVA: 0x00993C44 File Offset: 0x00991E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_agreeButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Button agreeButton;
			LuaObject.checkType<Button>(l, 2, out agreeButton);
			friendSmallItemUIController.m_luaExportHelper.m_agreeButton = agreeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF79 RID: 122745 RVA: 0x00993CA0 File Offset: 0x00991EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_disagreeButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_disagreeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF7A RID: 122746 RVA: 0x00993CF8 File Offset: 0x00991EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_disagreeButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Button disagreeButton;
			LuaObject.checkType<Button>(l, 2, out disagreeButton);
			friendSmallItemUIController.m_luaExportHelper.m_disagreeButton = disagreeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF7B RID: 122747 RVA: 0x00993D54 File Offset: 0x00991F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_addButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF7C RID: 122748 RVA: 0x00993DAC File Offset: 0x00991FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Button addButton;
			LuaObject.checkType<Button>(l, 2, out addButton);
			friendSmallItemUIController.m_luaExportHelper.m_addButton = addButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF7D RID: 122749 RVA: 0x00993E08 File Offset: 0x00992008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_selectToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF7E RID: 122750 RVA: 0x00993E60 File Offset: 0x00992060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectToggle(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Toggle selectToggle;
			LuaObject.checkType<Toggle>(l, 2, out selectToggle);
			friendSmallItemUIController.m_luaExportHelper.m_selectToggle = selectToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF7F RID: 122751 RVA: 0x00993EBC File Offset: 0x009920BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendLevelText(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_friendLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF80 RID: 122752 RVA: 0x00993F14 File Offset: 0x00992114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendLevelText(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Text friendLevelText;
			LuaObject.checkType<Text>(l, 2, out friendLevelText);
			friendSmallItemUIController.m_luaExportHelper.m_friendLevelText = friendLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF81 RID: 122753 RVA: 0x00993F70 File Offset: 0x00992170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendNameText(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_friendNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF82 RID: 122754 RVA: 0x00993FC8 File Offset: 0x009921C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_friendNameText(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Text friendNameText;
			LuaObject.checkType<Text>(l, 2, out friendNameText);
			friendSmallItemUIController.m_luaExportHelper.m_friendNameText = friendNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF83 RID: 122755 RVA: 0x00994024 File Offset: 0x00992224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverText(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_serverText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF84 RID: 122756 RVA: 0x0099407C File Offset: 0x0099227C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverText(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Text serverText;
			LuaObject.checkType<Text>(l, 2, out serverText);
			friendSmallItemUIController.m_luaExportHelper.m_serverText = serverText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF85 RID: 122757 RVA: 0x009940D8 File Offset: 0x009922D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_inGroupButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_inGroupButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF86 RID: 122758 RVA: 0x00994130 File Offset: 0x00992330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_inGroupButton(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			Button inGroupButton;
			LuaObject.checkType<Button>(l, 2, out inGroupButton);
			friendSmallItemUIController.m_luaExportHelper.m_inGroupButton = inGroupButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF87 RID: 122759 RVA: 0x0099418C File Offset: 0x0099238C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userID(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_userID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF88 RID: 122760 RVA: 0x009941E4 File Offset: 0x009923E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userID(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			string userID;
			LuaObject.checkType(l, 2, out userID);
			friendSmallItemUIController.m_luaExportHelper.m_userID = userID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF89 RID: 122761 RVA: 0x00994240 File Offset: 0x00992440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userSummy(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_userSummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF8A RID: 122762 RVA: 0x00994298 File Offset: 0x00992498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userSummy(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			UserSummary userSummy;
			LuaObject.checkType<UserSummary>(l, 2, out userSummy);
			friendSmallItemUIController.m_luaExportHelper.m_userSummy = userSummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF8B RID: 122763 RVA: 0x009942F4 File Offset: 0x009924F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF8C RID: 122764 RVA: 0x0099434C File Offset: 0x0099254C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			friendSmallItemUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF8D RID: 122765 RVA: 0x009943A8 File Offset: 0x009925A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendSmallItemUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF8E RID: 122766 RVA: 0x00994400 File Offset: 0x00992600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			FriendSmallItemUIController friendSmallItemUIController = (FriendSmallItemUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			friendSmallItemUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF8F RID: 122767 RVA: 0x0099445C File Offset: 0x0099265C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendSmallItemUIController");
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.SetFriendInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.GetUserID);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.GetUserSummy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.SetUserSelect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.SetUserInGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.GetSimpleInfoPostionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.GetPlayerSimpleInfoPos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.OnItemButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.OnChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.OnAgreeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.OnDisagreeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.OnInGroupButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.OnAddButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.OnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callDele_EventOnShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__clearDele_EventOnShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callDele_EventOnAgree);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__clearDele_EventOnAgree);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callDele_EventOnDisagree);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__clearDele_EventOnDisagree);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callDele_EventOnAdd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__clearDele_EventOnAdd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callDele_EventOnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__clearDele_EventOnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__callDele_EventOnChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.__clearDele_EventOnChat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache27);
		string name = "EventOnShowPlayerSimpleInfo";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_EventOnShowPlayerSimpleInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache28, true);
		string name2 = "EventOnAgree";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_EventOnAgree);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache29, true);
		string name3 = "EventOnDisagree";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_EventOnDisagree);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2A, true);
		string name4 = "EventOnAdd";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_EventOnAdd);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2B, true);
		string name5 = "EventOnSelectToggleValueChanged";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_EventOnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2C, true);
		string name6 = "EventOnChat";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_EventOnChat);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2D, true);
		string name7 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_uiStateController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache2F, true);
		string name8 = "m_itemButton";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_itemButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_itemButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache31, true);
		string name9 = "m_chatButton";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_chatButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_chatButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache33, true);
		string name10 = "m_buttonGroupUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_buttonGroupUIStateController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_buttonGroupUIStateController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache35, true);
		string name11 = "m_friendOnlineUIStateController";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_friendOnlineUIStateController);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_friendOnlineUIStateController);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache37, true);
		string name12 = "m_friendOnlineLongText";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_friendOnlineLongText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_friendOnlineLongText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache39, true);
		string name13 = "m_friendIconImage";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_friendIconImage);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_friendIconImage);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3B, true);
		string name14 = "m_friendIconGreyImage";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_friendIconGreyImage);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_friendIconGreyImage);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3D, true);
		string name15 = "m_friendHeadFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_friendHeadFrameTransform);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_friendHeadFrameTransform);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache3F, true);
		string name16 = "m_agreeButton";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_agreeButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_agreeButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache41, true);
		string name17 = "m_disagreeButton";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_disagreeButton);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_disagreeButton);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache43, true);
		string name18 = "m_addButton";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_addButton);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_addButton);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache45, true);
		string name19 = "m_selectToggle";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_selectToggle);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_selectToggle);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache47, true);
		string name20 = "m_friendLevelText";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_friendLevelText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_friendLevelText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache49, true);
		string name21 = "m_friendNameText";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_friendNameText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_friendNameText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4B, true);
		string name22 = "m_serverText";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_serverText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_serverText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4D, true);
		string name23 = "m_inGroupButton";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_inGroupButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_inGroupButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache4F, true);
		string name24 = "m_userID";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_userID);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_userID);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache51, true);
		string name25 = "m_userSummy";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_userSummy);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_userSummy);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache53, true);
		string name26 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_configDataLoader);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache55, true);
		string name27 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.get_m_playerContext);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_FriendSmallItemUIController.<>f__mg$cache57, true);
		LuaObject.createTypeMetatable(l, null, typeof(FriendSmallItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401406D RID: 82029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401406E RID: 82030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401406F RID: 82031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014070 RID: 82032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014071 RID: 82033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014072 RID: 82034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014073 RID: 82035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014074 RID: 82036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014075 RID: 82037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014076 RID: 82038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014077 RID: 82039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014078 RID: 82040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014079 RID: 82041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401407A RID: 82042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401407B RID: 82043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401407C RID: 82044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401407D RID: 82045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401407E RID: 82046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401407F RID: 82047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014080 RID: 82048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014081 RID: 82049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014082 RID: 82050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014083 RID: 82051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014084 RID: 82052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014085 RID: 82053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014086 RID: 82054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014087 RID: 82055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014088 RID: 82056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014089 RID: 82057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401408A RID: 82058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401408B RID: 82059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401408C RID: 82060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401408D RID: 82061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401408E RID: 82062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401408F RID: 82063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014090 RID: 82064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014091 RID: 82065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014092 RID: 82066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014093 RID: 82067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014094 RID: 82068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014095 RID: 82069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014096 RID: 82070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014097 RID: 82071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014098 RID: 82072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014099 RID: 82073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401409A RID: 82074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401409B RID: 82075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401409C RID: 82076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401409D RID: 82077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401409E RID: 82078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401409F RID: 82079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040140A0 RID: 82080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040140A1 RID: 82081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040140A2 RID: 82082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040140A3 RID: 82083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040140A4 RID: 82084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040140A5 RID: 82085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040140A6 RID: 82086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040140A7 RID: 82087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040140A8 RID: 82088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040140A9 RID: 82089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040140AA RID: 82090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040140AB RID: 82091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040140AC RID: 82092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040140AD RID: 82093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040140AE RID: 82094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040140AF RID: 82095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040140B0 RID: 82096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040140B1 RID: 82097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040140B2 RID: 82098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040140B3 RID: 82099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040140B4 RID: 82100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040140B5 RID: 82101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040140B6 RID: 82102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040140B7 RID: 82103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040140B8 RID: 82104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040140B9 RID: 82105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040140BA RID: 82106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040140BB RID: 82107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040140BC RID: 82108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040140BD RID: 82109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040140BE RID: 82110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040140BF RID: 82111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040140C0 RID: 82112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040140C1 RID: 82113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040140C2 RID: 82114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040140C3 RID: 82115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040140C4 RID: 82116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;
}
