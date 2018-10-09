using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200144E RID: 5198
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FriendGroupUIController : LuaObject
{
	// Token: 0x0601DEF4 RID: 122612 RVA: 0x00990588 File Offset: 0x0098E788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			ProChatGroupCompactInfo groupInfo;
			LuaObject.checkType<ProChatGroupCompactInfo>(l, 2, out groupInfo);
			friendGroupUIController.SetGroupInfo(groupInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEF5 RID: 122613 RVA: 0x009905E0 File Offset: 0x0098E7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			ProChatGroupCompactInfo groupInfo = friendGroupUIController.GetGroupInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, groupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEF6 RID: 122614 RVA: 0x00990634 File Offset: 0x0098E834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			friendGroupUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEF7 RID: 122615 RVA: 0x00990688 File Offset: 0x0098E888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			friendGroupUIController.m_luaExportHelper.OnChatButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEF8 RID: 122616 RVA: 0x009906DC File Offset: 0x0098E8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWatchStaffButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			friendGroupUIController.m_luaExportHelper.OnWatchStaffButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEF9 RID: 122617 RVA: 0x00990730 File Offset: 0x0098E930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			friendGroupUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEFA RID: 122618 RVA: 0x0099079C File Offset: 0x0098E99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			friendGroupUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEFB RID: 122619 RVA: 0x009907F0 File Offset: 0x0098E9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			friendGroupUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEFC RID: 122620 RVA: 0x00990844 File Offset: 0x0098EA44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = friendGroupUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DEFD RID: 122621 RVA: 0x009908EC File Offset: 0x0098EAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			friendGroupUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEFE RID: 122622 RVA: 0x00990940 File Offset: 0x0098EB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			friendGroupUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DEFF RID: 122623 RVA: 0x009909AC File Offset: 0x0098EBAC
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
				FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				friendGroupUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FriendGroupUIController friendGroupUIController2 = (FriendGroupUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				friendGroupUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DF00 RID: 122624 RVA: 0x00990ABC File Offset: 0x0098ECBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendGroupUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF01 RID: 122625 RVA: 0x00990B28 File Offset: 0x0098ED28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendGroupUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF02 RID: 122626 RVA: 0x00990B94 File Offset: 0x0098ED94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendGroupUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF03 RID: 122627 RVA: 0x00990C00 File Offset: 0x0098EE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			friendGroupUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF04 RID: 122628 RVA: 0x00990C6C File Offset: 0x0098EE6C
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
				FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				friendGroupUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FriendGroupUIController friendGroupUIController2 = (FriendGroupUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				friendGroupUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DF05 RID: 122629 RVA: 0x00990D7C File Offset: 0x0098EF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			string s = friendGroupUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DF06 RID: 122630 RVA: 0x00990DD8 File Offset: 0x0098EFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnWatchGroupStaffButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			FriendGroupUIController obj;
			LuaObject.checkType<FriendGroupUIController>(l, 2, out obj);
			friendGroupUIController.m_luaExportHelper.__callDele_EventOnWatchGroupStaffButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF07 RID: 122631 RVA: 0x00990E34 File Offset: 0x0098F034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnWatchGroupStaffButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			FriendGroupUIController obj;
			LuaObject.checkType<FriendGroupUIController>(l, 2, out obj);
			friendGroupUIController.m_luaExportHelper.__clearDele_EventOnWatchGroupStaffButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF08 RID: 122632 RVA: 0x00990E90 File Offset: 0x0098F090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			FriendGroupUIController obj;
			LuaObject.checkType<FriendGroupUIController>(l, 2, out obj);
			friendGroupUIController.m_luaExportHelper.__callDele_EventOnChatButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF09 RID: 122633 RVA: 0x00990EEC File Offset: 0x0098F0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			FriendGroupUIController obj;
			LuaObject.checkType<FriendGroupUIController>(l, 2, out obj);
			friendGroupUIController.m_luaExportHelper.__clearDele_EventOnChatButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF0A RID: 122634 RVA: 0x00990F48 File Offset: 0x0098F148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnWatchGroupStaffButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			Action<FriendGroupUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendGroupUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendGroupUIController.EventOnWatchGroupStaffButtonClick += value;
				}
				else if (num == 2)
				{
					friendGroupUIController.EventOnWatchGroupStaffButtonClick -= value;
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

	// Token: 0x0601DF0B RID: 122635 RVA: 0x00990FC8 File Offset: 0x0098F1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChatButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			Action<FriendGroupUIController> value;
			int num = LuaObject.checkDelegate<Action<FriendGroupUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendGroupUIController.EventOnChatButtonClick += value;
				}
				else if (num == 2)
				{
					friendGroupUIController.EventOnChatButtonClick -= value;
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

	// Token: 0x0601DF0C RID: 122636 RVA: 0x00991048 File Offset: 0x0098F248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupIconImage(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupUIController.m_luaExportHelper.m_groupIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF0D RID: 122637 RVA: 0x009910A0 File Offset: 0x0098F2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupIconImage(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			Image groupIconImage;
			LuaObject.checkType<Image>(l, 2, out groupIconImage);
			friendGroupUIController.m_luaExportHelper.m_groupIconImage = groupIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF0E RID: 122638 RVA: 0x009910FC File Offset: 0x0098F2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupUIController.m_luaExportHelper.m_groupHeadFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF0F RID: 122639 RVA: 0x00991154 File Offset: 0x0098F354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			Transform groupHeadFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out groupHeadFrameTransform);
			friendGroupUIController.m_luaExportHelper.m_groupHeadFrameTransform = groupHeadFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF10 RID: 122640 RVA: 0x009911B0 File Offset: 0x0098F3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupUIController.m_luaExportHelper.m_chatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF11 RID: 122641 RVA: 0x00991208 File Offset: 0x0098F408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatButton(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			Button chatButton;
			LuaObject.checkType<Button>(l, 2, out chatButton);
			friendGroupUIController.m_luaExportHelper.m_chatButton = chatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF12 RID: 122642 RVA: 0x00991264 File Offset: 0x0098F464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_watchStaffButton(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupUIController.m_luaExportHelper.m_watchStaffButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF13 RID: 122643 RVA: 0x009912BC File Offset: 0x0098F4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_watchStaffButton(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			Button watchStaffButton;
			LuaObject.checkType<Button>(l, 2, out watchStaffButton);
			friendGroupUIController.m_luaExportHelper.m_watchStaffButton = watchStaffButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF14 RID: 122644 RVA: 0x00991318 File Offset: 0x0098F518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlinePlayerNumText(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupUIController.m_luaExportHelper.m_onlinePlayerNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF15 RID: 122645 RVA: 0x00991370 File Offset: 0x0098F570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlinePlayerNumText(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			Text onlinePlayerNumText;
			LuaObject.checkType<Text>(l, 2, out onlinePlayerNumText);
			friendGroupUIController.m_luaExportHelper.m_onlinePlayerNumText = onlinePlayerNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF16 RID: 122646 RVA: 0x009913CC File Offset: 0x0098F5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupNameText(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupUIController.m_luaExportHelper.m_groupNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF17 RID: 122647 RVA: 0x00991424 File Offset: 0x0098F624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupNameText(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			Text groupNameText;
			LuaObject.checkType<Text>(l, 2, out groupNameText);
			friendGroupUIController.m_luaExportHelper.m_groupNameText = groupNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF18 RID: 122648 RVA: 0x00991480 File Offset: 0x0098F680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF19 RID: 122649 RVA: 0x009914D8 File Offset: 0x0098F6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			friendGroupUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF1A RID: 122650 RVA: 0x00991534 File Offset: 0x0098F734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendGroupUIController.m_luaExportHelper.m_groupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF1B RID: 122651 RVA: 0x0099158C File Offset: 0x0098F78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendGroupUIController friendGroupUIController = (FriendGroupUIController)LuaObject.checkSelf(l);
			ProChatGroupCompactInfo groupInfo;
			LuaObject.checkType<ProChatGroupCompactInfo>(l, 2, out groupInfo);
			friendGroupUIController.m_luaExportHelper.m_groupInfo = groupInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DF1C RID: 122652 RVA: 0x009915E8 File Offset: 0x0098F7E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FriendGroupUIController");
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.SetGroupInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.GetGroupInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.OnChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.OnWatchStaffButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callDele_EventOnWatchGroupStaffButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__clearDele_EventOnWatchGroupStaffButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__callDele_EventOnChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.__clearDele_EventOnChatButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache15);
		string name = "EventOnWatchGroupStaffButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.set_EventOnWatchGroupStaffButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache16, true);
		string name2 = "EventOnChatButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.set_EventOnChatButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache17, true);
		string name3 = "m_groupIconImage";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.get_m_groupIconImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.set_m_groupIconImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache19, true);
		string name4 = "m_groupHeadFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.get_m_groupHeadFrameTransform);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.set_m_groupHeadFrameTransform);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1B, true);
		string name5 = "m_chatButton";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.get_m_chatButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.set_m_chatButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1D, true);
		string name6 = "m_watchStaffButton";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.get_m_watchStaffButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.set_m_watchStaffButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache1F, true);
		string name7 = "m_onlinePlayerNumText";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.get_m_onlinePlayerNumText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.set_m_onlinePlayerNumText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache21, true);
		string name8 = "m_groupNameText";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.get_m_groupNameText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.set_m_groupNameText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache23, true);
		string name9 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.get_m_configDataLoader);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache25, true);
		string name10 = "m_groupInfo";
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.get_m_groupInfo);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FriendGroupUIController.set_m_groupInfo);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FriendGroupUIController.<>f__mg$cache27, true);
		LuaObject.createTypeMetatable(l, null, typeof(FriendGroupUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401403A RID: 81978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401403B RID: 81979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401403C RID: 81980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401403D RID: 81981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401403E RID: 81982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401403F RID: 81983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014040 RID: 81984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014041 RID: 81985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014042 RID: 81986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014043 RID: 81987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014044 RID: 81988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014045 RID: 81989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014046 RID: 81990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014047 RID: 81991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014048 RID: 81992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014049 RID: 81993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401404A RID: 81994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401404B RID: 81995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401404C RID: 81996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401404D RID: 81997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401404E RID: 81998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401404F RID: 81999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014050 RID: 82000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014051 RID: 82001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014052 RID: 82002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014053 RID: 82003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014054 RID: 82004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014055 RID: 82005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014056 RID: 82006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014057 RID: 82007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014058 RID: 82008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014059 RID: 82009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401405A RID: 82010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401405B RID: 82011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401405C RID: 82012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401405D RID: 82013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401405E RID: 82014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401405F RID: 82015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014060 RID: 82016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014061 RID: 82017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
