using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200137D RID: 4989
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController : LuaObject
{
	// Token: 0x0601AFEB RID: 110571 RVA: 0x00819C5C File Offset: 0x00817E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			ConfigDataArenaLevelInfo levelInfo;
			LuaObject.checkType<ConfigDataArenaLevelInfo>(l, 2, out levelInfo);
			ConfigDataArenaLevelInfo prevLevelInfo;
			LuaObject.checkType<ConfigDataArenaLevelInfo>(l, 3, out prevLevelInfo);
			GameObject rewardGoodPrefab;
			LuaObject.checkType<GameObject>(l, 4, out rewardGoodPrefab);
			arenaPointRewardListItemUIController.SetArenaLevelInfo(levelInfo, prevLevelInfo, rewardGoodPrefab);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFEC RID: 110572 RVA: 0x00819CD0 File Offset: 0x00817ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIndex(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			arenaPointRewardListItemUIController.SetIndex(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFED RID: 110573 RVA: 0x00819D28 File Offset: 0x00817F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			arenaPointRewardListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFEE RID: 110574 RVA: 0x00819D7C File Offset: 0x00817F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFEF RID: 110575 RVA: 0x00819DE8 File Offset: 0x00817FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFF0 RID: 110576 RVA: 0x00819E3C File Offset: 0x0081803C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFF1 RID: 110577 RVA: 0x00819E90 File Offset: 0x00818090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601AFF2 RID: 110578 RVA: 0x00819F38 File Offset: 0x00818138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFF3 RID: 110579 RVA: 0x00819F8C File Offset: 0x0081818C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFF4 RID: 110580 RVA: 0x00819FF8 File Offset: 0x008181F8
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
				ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaPointRewardListItemUIController arenaPointRewardListItemUIController2 = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaPointRewardListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601AFF5 RID: 110581 RVA: 0x0081A108 File Offset: 0x00818308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFF6 RID: 110582 RVA: 0x0081A174 File Offset: 0x00818374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFF7 RID: 110583 RVA: 0x0081A1E0 File Offset: 0x008183E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFF8 RID: 110584 RVA: 0x0081A24C File Offset: 0x0081844C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFF9 RID: 110585 RVA: 0x0081A2B8 File Offset: 0x008184B8
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
				ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaPointRewardListItemUIController arenaPointRewardListItemUIController2 = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaPointRewardListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601AFFA RID: 110586 RVA: 0x0081A3C8 File Offset: 0x008185C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			string s = arenaPointRewardListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601AFFB RID: 110587 RVA: 0x0081A424 File Offset: 0x00818624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPointRewardListItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFFC RID: 110588 RVA: 0x0081A47C File Offset: 0x0081867C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			arenaPointRewardListItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFFD RID: 110589 RVA: 0x0081A4D8 File Offset: 0x008186D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPointRewardListItemUIController.m_luaExportHelper.m_rewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFFE RID: 110590 RVA: 0x0081A530 File Offset: 0x00818730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			GameObject rewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGroupGameObject);
			arenaPointRewardListItemUIController.m_luaExportHelper.m_rewardGroupGameObject = rewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AFFF RID: 110591 RVA: 0x0081A58C File Offset: 0x0081878C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPointRewardListItemUIController.m_luaExportHelper.m_backgroundGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B000 RID: 110592 RVA: 0x0081A5E4 File Offset: 0x008187E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			GameObject backgroundGameObject;
			LuaObject.checkType<GameObject>(l, 2, out backgroundGameObject);
			arenaPointRewardListItemUIController.m_luaExportHelper.m_backgroundGameObject = backgroundGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B001 RID: 110593 RVA: 0x0081A640 File Offset: 0x00818840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noRewardGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaPointRewardListItemUIController.m_luaExportHelper.m_noRewardGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B002 RID: 110594 RVA: 0x0081A698 File Offset: 0x00818898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noRewardGameObject(IntPtr l)
	{
		int result;
		try
		{
			ArenaPointRewardListItemUIController arenaPointRewardListItemUIController = (ArenaPointRewardListItemUIController)LuaObject.checkSelf(l);
			GameObject noRewardGameObject;
			LuaObject.checkType<GameObject>(l, 2, out noRewardGameObject);
			arenaPointRewardListItemUIController.m_luaExportHelper.m_noRewardGameObject = noRewardGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B003 RID: 110595 RVA: 0x0081A6F4 File Offset: 0x008188F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaPointRewardListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.SetArenaLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.SetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cacheF);
		string name = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.get_m_nameText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache11, true);
		string name2 = "m_rewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.get_m_rewardGroupGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.set_m_rewardGroupGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache13, true);
		string name3 = "m_backgroundGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.get_m_backgroundGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.set_m_backgroundGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache15, true);
		string name4 = "m_noRewardGameObject";
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.get_m_noRewardGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.set_m_noRewardGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaPointRewardListItemUIController.<>f__mg$cache17, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaPointRewardListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040112D3 RID: 70355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040112D4 RID: 70356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040112D5 RID: 70357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040112D6 RID: 70358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040112D7 RID: 70359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040112D8 RID: 70360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040112D9 RID: 70361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040112DA RID: 70362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040112DB RID: 70363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040112DC RID: 70364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040112DD RID: 70365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040112DE RID: 70366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040112DF RID: 70367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040112E0 RID: 70368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040112E1 RID: 70369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040112E2 RID: 70370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040112E3 RID: 70371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040112E4 RID: 70372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040112E5 RID: 70373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040112E6 RID: 70374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040112E7 RID: 70375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040112E8 RID: 70376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040112E9 RID: 70377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040112EA RID: 70378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
