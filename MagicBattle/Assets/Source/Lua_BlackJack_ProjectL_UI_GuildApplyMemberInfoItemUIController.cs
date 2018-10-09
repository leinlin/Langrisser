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

// Token: 0x0200146F RID: 5231
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController : LuaObject
{
	// Token: 0x0601E3C3 RID: 123843 RVA: 0x009B667C File Offset: 0x009B487C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitItemInfo(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			UserSummary player;
			LuaObject.checkType<UserSummary>(l, 2, out player);
			guildApplyMemberInfoItemUIController.InitItemInfo(player);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3C4 RID: 123844 RVA: 0x009B66D4 File Offset: 0x009B48D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3C5 RID: 123845 RVA: 0x009B6728 File Offset: 0x009B4928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAgreeClick(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.OnAgreeClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3C6 RID: 123846 RVA: 0x009B677C File Offset: 0x009B497C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRefuseClick(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.OnRefuseClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3C7 RID: 123847 RVA: 0x009B67D0 File Offset: 0x009B49D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3C8 RID: 123848 RVA: 0x009B683C File Offset: 0x009B4A3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3C9 RID: 123849 RVA: 0x009B6890 File Offset: 0x009B4A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3CA RID: 123850 RVA: 0x009B68E4 File Offset: 0x009B4AE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E3CB RID: 123851 RVA: 0x009B698C File Offset: 0x009B4B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3CC RID: 123852 RVA: 0x009B69E0 File Offset: 0x009B4BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3CD RID: 123853 RVA: 0x009B6A4C File Offset: 0x009B4C4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController2 = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				guildApplyMemberInfoItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E3CE RID: 123854 RVA: 0x009B6B5C File Offset: 0x009B4D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3CF RID: 123855 RVA: 0x009B6BC8 File Offset: 0x009B4DC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3D0 RID: 123856 RVA: 0x009B6C34 File Offset: 0x009B4E34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3D1 RID: 123857 RVA: 0x009B6CA0 File Offset: 0x009B4EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3D2 RID: 123858 RVA: 0x009B6D0C File Offset: 0x009B4F0C
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
				GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController2 = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				guildApplyMemberInfoItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E3D3 RID: 123859 RVA: 0x009B6E1C File Offset: 0x009B501C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			string s = guildApplyMemberInfoItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E3D4 RID: 123860 RVA: 0x009B6E78 File Offset: 0x009B5078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAcceptResult(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			GuildApplyMemberInfoItemUIController arg;
			LuaObject.checkType<GuildApplyMemberInfoItemUIController>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.__callDele_EventOnAcceptResult(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3D5 RID: 123861 RVA: 0x009B6EE4 File Offset: 0x009B50E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnAcceptResult(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			GuildApplyMemberInfoItemUIController arg;
			LuaObject.checkType<GuildApplyMemberInfoItemUIController>(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.__clearDele_EventOnAcceptResult(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3D6 RID: 123862 RVA: 0x009B6F50 File Offset: 0x009B5150
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnAcceptResult(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			Action<GuildApplyMemberInfoItemUIController, bool> value;
			int num = LuaObject.checkDelegate<Action<GuildApplyMemberInfoItemUIController, bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					guildApplyMemberInfoItemUIController.EventOnAcceptResult += value;
				}
				else if (num == 2)
				{
					guildApplyMemberInfoItemUIController.EventOnAcceptResult -= value;
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

	// Token: 0x0601E3D7 RID: 123863 RVA: 0x009B6FD0 File Offset: 0x009B51D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_headIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildApplyMemberInfoItemUIController.m_luaExportHelper.m_headIconStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3D8 RID: 123864 RVA: 0x009B7028 File Offset: 0x009B5228
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_headIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController headIconStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out headIconStateCtrl);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.m_headIconStateCtrl = headIconStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3D9 RID: 123865 RVA: 0x009B7084 File Offset: 0x009B5284
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_headIconGrey(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildApplyMemberInfoItemUIController.m_luaExportHelper.m_headIconGrey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3DA RID: 123866 RVA: 0x009B70DC File Offset: 0x009B52DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headIconGrey(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			Image headIconGrey;
			LuaObject.checkType<Image>(l, 2, out headIconGrey);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.m_headIconGrey = headIconGrey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3DB RID: 123867 RVA: 0x009B7138 File Offset: 0x009B5338
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_headIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildApplyMemberInfoItemUIController.m_luaExportHelper.m_headIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3DC RID: 123868 RVA: 0x009B7190 File Offset: 0x009B5390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_headIcon(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			Image headIcon;
			LuaObject.checkType<Image>(l, 2, out headIcon);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.m_headIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3DD RID: 123869 RVA: 0x009B71EC File Offset: 0x009B53EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_HeadFrameDummy(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildApplyMemberInfoItemUIController.m_luaExportHelper.m_HeadFrameDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3DE RID: 123870 RVA: 0x009B7244 File Offset: 0x009B5444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_HeadFrameDummy(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			Transform headFrameDummy;
			LuaObject.checkType<Transform>(l, 2, out headFrameDummy);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.m_HeadFrameDummy = headFrameDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3DF RID: 123871 RVA: 0x009B72A0 File Offset: 0x009B54A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildApplyMemberInfoItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3E0 RID: 123872 RVA: 0x009B72F8 File Offset: 0x009B54F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3E1 RID: 123873 RVA: 0x009B7354 File Offset: 0x009B5554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildApplyMemberInfoItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3E2 RID: 123874 RVA: 0x009B73AC File Offset: 0x009B55AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3E3 RID: 123875 RVA: 0x009B7408 File Offset: 0x009B5608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_powerText(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildApplyMemberInfoItemUIController.m_luaExportHelper.m_powerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3E4 RID: 123876 RVA: 0x009B7460 File Offset: 0x009B5660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_powerText(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			Text powerText;
			LuaObject.checkType<Text>(l, 2, out powerText);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.m_powerText = powerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3E5 RID: 123877 RVA: 0x009B74BC File Offset: 0x009B56BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_refuseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildApplyMemberInfoItemUIController.m_luaExportHelper.m_refuseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3E6 RID: 123878 RVA: 0x009B7514 File Offset: 0x009B5714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_refuseButton(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			Button refuseButton;
			LuaObject.checkType<Button>(l, 2, out refuseButton);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.m_refuseButton = refuseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3E7 RID: 123879 RVA: 0x009B7570 File Offset: 0x009B5770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_agreeButton(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildApplyMemberInfoItemUIController.m_luaExportHelper.m_agreeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3E8 RID: 123880 RVA: 0x009B75C8 File Offset: 0x009B57C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_agreeButton(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			Button agreeButton;
			LuaObject.checkType<Button>(l, 2, out agreeButton);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.m_agreeButton = agreeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3E9 RID: 123881 RVA: 0x009B7624 File Offset: 0x009B5824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Player(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, guildApplyMemberInfoItemUIController.Player);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3EA RID: 123882 RVA: 0x009B7678 File Offset: 0x009B5878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Player(IntPtr l)
	{
		int result;
		try
		{
			GuildApplyMemberInfoItemUIController guildApplyMemberInfoItemUIController = (GuildApplyMemberInfoItemUIController)LuaObject.checkSelf(l);
			UserSummary player;
			LuaObject.checkType<UserSummary>(l, 2, out player);
			guildApplyMemberInfoItemUIController.m_luaExportHelper.Player = player;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E3EB RID: 123883 RVA: 0x009B76D4 File Offset: 0x009B58D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GuildApplyMemberInfoItemUIController");
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.InitItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.OnAgreeClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.OnRefuseClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__callDele_EventOnAcceptResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.__clearDele_EventOnAcceptResult);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache12);
		string name = "EventOnAcceptResult";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.set_EventOnAcceptResult);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache13, true);
		string name2 = "m_headIconStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.get_m_headIconStateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.set_m_headIconStateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache15, true);
		string name3 = "m_headIconGrey";
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.get_m_headIconGrey);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.set_m_headIconGrey);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache17, true);
		string name4 = "m_headIcon";
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.get_m_headIcon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.set_m_headIcon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache19, true);
		string name5 = "m_HeadFrameDummy";
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.get_m_HeadFrameDummy);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.set_m_HeadFrameDummy);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1B, true);
		string name6 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.get_m_levelText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1D, true);
		string name7 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.get_m_nameText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache1F, true);
		string name8 = "m_powerText";
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.get_m_powerText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.set_m_powerText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache21, true);
		string name9 = "m_refuseButton";
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.get_m_refuseButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.set_m_refuseButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache23, true);
		string name10 = "m_agreeButton";
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.get_m_agreeButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.set_m_agreeButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache25, true);
		string name11 = "Player";
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.get_Player);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.set_Player);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_GuildApplyMemberInfoItemUIController.<>f__mg$cache27, true);
		LuaObject.createTypeMetatable(l, null, typeof(GuildApplyMemberInfoItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040144C7 RID: 83143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040144C8 RID: 83144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040144C9 RID: 83145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040144CA RID: 83146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040144CB RID: 83147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040144CC RID: 83148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040144CD RID: 83149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040144CE RID: 83150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040144CF RID: 83151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040144D0 RID: 83152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040144D1 RID: 83153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040144D2 RID: 83154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040144D3 RID: 83155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040144D4 RID: 83156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040144D5 RID: 83157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040144D6 RID: 83158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040144D7 RID: 83159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040144D8 RID: 83160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040144D9 RID: 83161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040144DA RID: 83162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040144DB RID: 83163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040144DC RID: 83164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040144DD RID: 83165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040144DE RID: 83166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040144DF RID: 83167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040144E0 RID: 83168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040144E1 RID: 83169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040144E2 RID: 83170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040144E3 RID: 83171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040144E4 RID: 83172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040144E5 RID: 83173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040144E6 RID: 83174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040144E7 RID: 83175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040144E8 RID: 83176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040144E9 RID: 83177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040144EA RID: 83178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040144EB RID: 83179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040144EC RID: 83180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040144ED RID: 83181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040144EE RID: 83182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
