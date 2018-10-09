using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001565 RID: 5477
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftLevelButton : LuaObject
{
	// Token: 0x06020C80 RID: 134272 RVA: 0x00AFA3E0 File Offset: 0x00AF85E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRiftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			riftLevelButton.SetRiftLevelInfo(riftLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C81 RID: 134273 RVA: 0x00AFA438 File Offset: 0x00AF8638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRiftLevel(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevel = riftLevelButton.GetRiftLevel();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C82 RID: 134274 RVA: 0x00AFA48C File Offset: 0x00AF868C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStatus(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			RiftLevelStatus status;
			LuaObject.checkEnum<RiftLevelStatus>(l, 2, out status);
			bool isNew;
			LuaObject.checkType(l, 3, out isNew);
			bool isClear;
			LuaObject.checkType(l, 4, out isClear);
			bool isAllTreasureGot;
			LuaObject.checkType(l, 5, out isAllTreasureGot);
			riftLevelButton.SetStatus(status, isNew, isClear, isAllTreasureGot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C83 RID: 134275 RVA: 0x00AFA50C File Offset: 0x00AF870C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStatus(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			RiftLevelStatus status = riftLevelButton.GetStatus();
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

	// Token: 0x06020C84 RID: 134276 RVA: 0x00AFA560 File Offset: 0x00AF8760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStar(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			int star;
			LuaObject.checkType(l, 2, out star);
			riftLevelButton.SetStar(star);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C85 RID: 134277 RVA: 0x00AFA5B8 File Offset: 0x00AF87B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChallengeCount(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			int countMax;
			LuaObject.checkType(l, 3, out countMax);
			riftLevelButton.SetChallengeCount(count, countMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C86 RID: 134278 RVA: 0x00AFA61C File Offset: 0x00AF881C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAchievementCount(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			int countMax;
			LuaObject.checkType(l, 3, out countMax);
			riftLevelButton.SetAchievementCount(count, countMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C87 RID: 134279 RVA: 0x00AFA680 File Offset: 0x00AF8880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			riftLevelButton.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C88 RID: 134280 RVA: 0x00AFA6D4 File Offset: 0x00AF88D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			riftLevelButton.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C89 RID: 134281 RVA: 0x00AFA728 File Offset: 0x00AF8928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			riftLevelButton.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C8A RID: 134282 RVA: 0x00AFA794 File Offset: 0x00AF8994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			riftLevelButton.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C8B RID: 134283 RVA: 0x00AFA7E8 File Offset: 0x00AF89E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			riftLevelButton.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C8C RID: 134284 RVA: 0x00AFA83C File Offset: 0x00AF8A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = riftLevelButton.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020C8D RID: 134285 RVA: 0x00AFA8E4 File Offset: 0x00AF8AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			riftLevelButton.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C8E RID: 134286 RVA: 0x00AFA938 File Offset: 0x00AF8B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			riftLevelButton.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C8F RID: 134287 RVA: 0x00AFA9A4 File Offset: 0x00AF8BA4
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
				RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				riftLevelButton.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RiftLevelButton riftLevelButton2 = (RiftLevelButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				riftLevelButton2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020C90 RID: 134288 RVA: 0x00AFAAB4 File Offset: 0x00AF8CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelButton.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C91 RID: 134289 RVA: 0x00AFAB20 File Offset: 0x00AF8D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelButton.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C92 RID: 134290 RVA: 0x00AFAB8C File Offset: 0x00AF8D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelButton.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C93 RID: 134291 RVA: 0x00AFABF8 File Offset: 0x00AF8DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftLevelButton.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C94 RID: 134292 RVA: 0x00AFAC64 File Offset: 0x00AF8E64
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
				RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				riftLevelButton.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RiftLevelButton riftLevelButton2 = (RiftLevelButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				riftLevelButton2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020C95 RID: 134293 RVA: 0x00AFAD74 File Offset: 0x00AF8F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			string s = riftLevelButton.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020C96 RID: 134294 RVA: 0x00AFADD0 File Offset: 0x00AF8FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			RiftLevelButton obj;
			LuaObject.checkType<RiftLevelButton>(l, 2, out obj);
			riftLevelButton.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C97 RID: 134295 RVA: 0x00AFAE2C File Offset: 0x00AF902C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			RiftLevelButton obj;
			LuaObject.checkType<RiftLevelButton>(l, 2, out obj);
			riftLevelButton.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C98 RID: 134296 RVA: 0x00AFAE88 File Offset: 0x00AF9088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			Action<RiftLevelButton> value;
			int num = LuaObject.checkDelegate<Action<RiftLevelButton>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftLevelButton.EventOnClick += value;
				}
				else if (num == 2)
				{
					riftLevelButton.EventOnClick -= value;
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

	// Token: 0x06020C99 RID: 134297 RVA: 0x00AFAF08 File Offset: 0x00AF9108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelButton.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C9A RID: 134298 RVA: 0x00AFAF60 File Offset: 0x00AF9160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			riftLevelButton.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C9B RID: 134299 RVA: 0x00AFAFBC File Offset: 0x00AF91BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelButton.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C9C RID: 134300 RVA: 0x00AFB014 File Offset: 0x00AF9214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			riftLevelButton.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C9D RID: 134301 RVA: 0x00AFB070 File Offset: 0x00AF9270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameNumText(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelButton.m_luaExportHelper.m_nameNumText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C9E RID: 134302 RVA: 0x00AFB0C8 File Offset: 0x00AF92C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameNumText(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			Text nameNumText;
			LuaObject.checkType<Text>(l, 2, out nameNumText);
			riftLevelButton.m_luaExportHelper.m_nameNumText = nameNumText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C9F RID: 134303 RVA: 0x00AFB124 File Offset: 0x00AF9324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_challengeCountText(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelButton.m_luaExportHelper.m_challengeCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CA0 RID: 134304 RVA: 0x00AFB17C File Offset: 0x00AF937C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_challengeCountText(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			Text challengeCountText;
			LuaObject.checkType<Text>(l, 2, out challengeCountText);
			riftLevelButton.m_luaExportHelper.m_challengeCountText = challengeCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CA1 RID: 134305 RVA: 0x00AFB1D8 File Offset: 0x00AF93D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star1GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelButton.m_luaExportHelper.m_star1GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CA2 RID: 134306 RVA: 0x00AFB230 File Offset: 0x00AF9430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_star1GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			GameObject star1GameObject;
			LuaObject.checkType<GameObject>(l, 2, out star1GameObject);
			riftLevelButton.m_luaExportHelper.m_star1GameObject = star1GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CA3 RID: 134307 RVA: 0x00AFB28C File Offset: 0x00AF948C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star2GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelButton.m_luaExportHelper.m_star2GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CA4 RID: 134308 RVA: 0x00AFB2E4 File Offset: 0x00AF94E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_star2GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			GameObject star2GameObject;
			LuaObject.checkType<GameObject>(l, 2, out star2GameObject);
			riftLevelButton.m_luaExportHelper.m_star2GameObject = star2GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CA5 RID: 134309 RVA: 0x00AFB340 File Offset: 0x00AF9540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_star3GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelButton.m_luaExportHelper.m_star3GameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CA6 RID: 134310 RVA: 0x00AFB398 File Offset: 0x00AF9598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_star3GameObject(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			GameObject star3GameObject;
			LuaObject.checkType<GameObject>(l, 2, out star3GameObject);
			riftLevelButton.m_luaExportHelper.m_star3GameObject = star3GameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CA7 RID: 134311 RVA: 0x00AFB3F4 File Offset: 0x00AF95F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementCountText(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelButton.m_luaExportHelper.m_achievementCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CA8 RID: 134312 RVA: 0x00AFB44C File Offset: 0x00AF964C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementCountText(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			Text achievementCountText;
			LuaObject.checkType<Text>(l, 2, out achievementCountText);
			riftLevelButton.m_luaExportHelper.m_achievementCountText = achievementCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CA9 RID: 134313 RVA: 0x00AFB4A8 File Offset: 0x00AF96A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelButton.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CAA RID: 134314 RVA: 0x00AFB500 File Offset: 0x00AF9700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			riftLevelButton.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CAB RID: 134315 RVA: 0x00AFB55C File Offset: 0x00AF975C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image1(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelButton.m_luaExportHelper.m_image1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CAC RID: 134316 RVA: 0x00AFB5B4 File Offset: 0x00AF97B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image1(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			riftLevelButton.m_luaExportHelper.m_image1 = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CAD RID: 134317 RVA: 0x00AFB610 File Offset: 0x00AF9810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelButton.m_luaExportHelper.m_riftLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CAE RID: 134318 RVA: 0x00AFB668 File Offset: 0x00AF9868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_riftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			riftLevelButton.m_luaExportHelper.m_riftLevelInfo = riftLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CAF RID: 134319 RVA: 0x00AFB6C4 File Offset: 0x00AF98C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_status(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)riftLevelButton.m_luaExportHelper.m_status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CB0 RID: 134320 RVA: 0x00AFB71C File Offset: 0x00AF991C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_status(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelButton riftLevelButton = (RiftLevelButton)LuaObject.checkSelf(l);
			RiftLevelStatus status;
			LuaObject.checkEnum<RiftLevelStatus>(l, 2, out status);
			riftLevelButton.m_luaExportHelper.m_status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020CB1 RID: 134321 RVA: 0x00AFB778 File Offset: 0x00AF9978
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftLevelButton");
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.SetRiftLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.GetRiftLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.SetStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.GetStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.SetStar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.SetChallengeCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.SetAchievementCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache17);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache18, true);
		string name2 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_button);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_button);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1A, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1C, true);
		string name4 = "m_nameNumText";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_nameNumText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_nameNumText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1E, true);
		string name5 = "m_challengeCountText";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_challengeCountText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_challengeCountText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache20, true);
		string name6 = "m_star1GameObject";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_star1GameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_star1GameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache22, true);
		string name7 = "m_star2GameObject";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_star2GameObject);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_star2GameObject);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache24, true);
		string name8 = "m_star3GameObject";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_star3GameObject);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_star3GameObject);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache26, true);
		string name9 = "m_achievementCountText";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_achievementCountText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_achievementCountText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache28, true);
		string name10 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_image);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_image);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2A, true);
		string name11 = "m_image1";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_image1);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_image1);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2C, true);
		string name12 = "m_riftLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_riftLevelInfo);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_riftLevelInfo);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2E, true);
		string name13 = "m_status";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.get_m_status);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelButton.set_m_status);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RiftLevelButton.<>f__mg$cache30, true);
		LuaObject.createTypeMetatable(l, null, typeof(RiftLevelButton), typeof(UIControllerBase));
	}

	// Token: 0x04016B98 RID: 93080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016B99 RID: 93081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016B9A RID: 93082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016B9B RID: 93083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016B9C RID: 93084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016B9D RID: 93085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016B9E RID: 93086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016B9F RID: 93087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016BA0 RID: 93088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016BA1 RID: 93089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016BA2 RID: 93090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016BA3 RID: 93091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016BA4 RID: 93092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016BA5 RID: 93093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016BA6 RID: 93094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016BA7 RID: 93095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016BA8 RID: 93096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016BA9 RID: 93097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016BAA RID: 93098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016BAB RID: 93099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016BAC RID: 93100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016BAD RID: 93101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016BAE RID: 93102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016BAF RID: 93103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016BB0 RID: 93104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016BB1 RID: 93105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016BB2 RID: 93106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016BB3 RID: 93107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016BB4 RID: 93108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016BB5 RID: 93109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016BB6 RID: 93110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016BB7 RID: 93111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016BB8 RID: 93112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016BB9 RID: 93113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016BBA RID: 93114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016BBB RID: 93115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016BBC RID: 93116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016BBD RID: 93117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016BBE RID: 93118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016BBF RID: 93119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016BC0 RID: 93120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016BC1 RID: 93121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016BC2 RID: 93122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016BC3 RID: 93123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016BC4 RID: 93124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016BC5 RID: 93125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016BC6 RID: 93126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016BC7 RID: 93127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016BC8 RID: 93128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
