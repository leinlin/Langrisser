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

// Token: 0x020015A3 RID: 5539
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController : LuaObject
{
	// Token: 0x0602186F RID: 137327 RVA: 0x00B59CC8 File Offset: 0x00B57EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGameFunctionTypeName(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			string gameFunctionTypeName;
			LuaObject.checkType(l, 2, out gameFunctionTypeName);
			teamRoomListItemUIController.SetGameFunctionTypeName(gameFunctionTypeName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021870 RID: 137328 RVA: 0x00B59D20 File Offset: 0x00B57F20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLocationName(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			string locationName;
			LuaObject.checkType(l, 2, out locationName);
			teamRoomListItemUIController.SetLocationName(locationName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021871 RID: 137329 RVA: 0x00B59D78 File Offset: 0x00B57F78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetRoomId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			teamRoomListItemUIController.SetRoomId(roomId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021872 RID: 137330 RVA: 0x00B59DD0 File Offset: 0x00B57FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRoomId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			int roomId = teamRoomListItemUIController.GetRoomId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, roomId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021873 RID: 137331 RVA: 0x00B59E24 File Offset: 0x00B58024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetGameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			teamRoomListItemUIController.SetGameFunctionType(gameFunctionType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021874 RID: 137332 RVA: 0x00B59E7C File Offset: 0x00B5807C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType = teamRoomListItemUIController.GetGameFunctionType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)gameFunctionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021875 RID: 137333 RVA: 0x00B59ED0 File Offset: 0x00B580D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			teamRoomListItemUIController.SetLocationId(locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021876 RID: 137334 RVA: 0x00B59F28 File Offset: 0x00B58128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLocationIdId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			int locationIdId = teamRoomListItemUIController.GetLocationIdId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationIdId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021877 RID: 137335 RVA: 0x00B59F7C File Offset: 0x00B5817C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayer(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			int headIconId;
			LuaObject.checkType(l, 3, out headIconId);
			int level;
			LuaObject.checkType(l, 4, out level);
			teamRoomListItemUIController.SetPlayer(index, headIconId, level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021878 RID: 137336 RVA: 0x00B59FF0 File Offset: 0x00B581F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerOff(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			int playerOff;
			LuaObject.checkType(l, 2, out playerOff);
			teamRoomListItemUIController.SetPlayerOff(playerOff);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021879 RID: 137337 RVA: 0x00B5A048 File Offset: 0x00B58248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerLevelRange(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			int levelMin;
			LuaObject.checkType(l, 2, out levelMin);
			int levelMax;
			LuaObject.checkType(l, 3, out levelMax);
			teamRoomListItemUIController.SetPlayerLevelRange(levelMin, levelMax);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602187A RID: 137338 RVA: 0x00B5A0AC File Offset: 0x00B582AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			teamRoomListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602187B RID: 137339 RVA: 0x00B5A100 File Offset: 0x00B58300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerInfoGameObject(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			GameObject playerInfoGameObject = teamRoomListItemUIController.m_luaExportHelper.GetPlayerInfoGameObject(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602187C RID: 137340 RVA: 0x00B5A168 File Offset: 0x00B58368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJoinButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			teamRoomListItemUIController.m_luaExportHelper.OnJoinButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602187D RID: 137341 RVA: 0x00B5A1BC File Offset: 0x00B583BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			teamRoomListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602187E RID: 137342 RVA: 0x00B5A228 File Offset: 0x00B58428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			teamRoomListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602187F RID: 137343 RVA: 0x00B5A27C File Offset: 0x00B5847C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			teamRoomListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021880 RID: 137344 RVA: 0x00B5A2D0 File Offset: 0x00B584D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = teamRoomListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021881 RID: 137345 RVA: 0x00B5A378 File Offset: 0x00B58578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			teamRoomListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021882 RID: 137346 RVA: 0x00B5A3CC File Offset: 0x00B585CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			teamRoomListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021883 RID: 137347 RVA: 0x00B5A438 File Offset: 0x00B58638
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
				TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				teamRoomListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TeamRoomListItemUIController teamRoomListItemUIController2 = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				teamRoomListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021884 RID: 137348 RVA: 0x00B5A548 File Offset: 0x00B58748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021885 RID: 137349 RVA: 0x00B5A5B4 File Offset: 0x00B587B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021886 RID: 137350 RVA: 0x00B5A620 File Offset: 0x00B58820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021887 RID: 137351 RVA: 0x00B5A68C File Offset: 0x00B5888C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			teamRoomListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021888 RID: 137352 RVA: 0x00B5A6F8 File Offset: 0x00B588F8
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
				TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				teamRoomListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TeamRoomListItemUIController teamRoomListItemUIController2 = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				teamRoomListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021889 RID: 137353 RVA: 0x00B5A808 File Offset: 0x00B58A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			string s = teamRoomListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602188A RID: 137354 RVA: 0x00B5A864 File Offset: 0x00B58A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnJoinButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			TeamRoomListItemUIController obj;
			LuaObject.checkType<TeamRoomListItemUIController>(l, 2, out obj);
			teamRoomListItemUIController.m_luaExportHelper.__callDele_EventOnJoinButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602188B RID: 137355 RVA: 0x00B5A8C0 File Offset: 0x00B58AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnJoinButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			TeamRoomListItemUIController obj;
			LuaObject.checkType<TeamRoomListItemUIController>(l, 2, out obj);
			teamRoomListItemUIController.m_luaExportHelper.__clearDele_EventOnJoinButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602188C RID: 137356 RVA: 0x00B5A91C File Offset: 0x00B58B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnJoinButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			Action<TeamRoomListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<TeamRoomListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					teamRoomListItemUIController.EventOnJoinButtonClick += value;
				}
				else if (num == 2)
				{
					teamRoomListItemUIController.EventOnJoinButtonClick -= value;
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

	// Token: 0x0602188D RID: 137357 RVA: 0x00B5A99C File Offset: 0x00B58B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_joinButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomListItemUIController.m_luaExportHelper.m_joinButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602188E RID: 137358 RVA: 0x00B5A9F4 File Offset: 0x00B58BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_joinButton(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			Button joinButton;
			LuaObject.checkType<Button>(l, 2, out joinButton);
			teamRoomListItemUIController.m_luaExportHelper.m_joinButton = joinButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602188F RID: 137359 RVA: 0x00B5AA50 File Offset: 0x00B58C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameFunctionTypeNameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomListItemUIController.m_luaExportHelper.m_gameFunctionTypeNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021890 RID: 137360 RVA: 0x00B5AAA8 File Offset: 0x00B58CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameFunctionTypeNameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			Text gameFunctionTypeNameText;
			LuaObject.checkType<Text>(l, 2, out gameFunctionTypeNameText);
			teamRoomListItemUIController.m_luaExportHelper.m_gameFunctionTypeNameText = gameFunctionTypeNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021891 RID: 137361 RVA: 0x00B5AB04 File Offset: 0x00B58D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locationNameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomListItemUIController.m_luaExportHelper.m_locationNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021892 RID: 137362 RVA: 0x00B5AB5C File Offset: 0x00B58D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationNameText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			Text locationNameText;
			LuaObject.checkType<Text>(l, 2, out locationNameText);
			teamRoomListItemUIController.m_luaExportHelper.m_locationNameText = locationNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021893 RID: 137363 RVA: 0x00B5ABB8 File Offset: 0x00B58DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomListItemUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021894 RID: 137364 RVA: 0x00B5AC10 File Offset: 0x00B58E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			teamRoomListItemUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021895 RID: 137365 RVA: 0x00B5AC6C File Offset: 0x00B58E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)teamRoomListItemUIController.m_luaExportHelper.m_gameFunctionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021896 RID: 137366 RVA: 0x00B5ACC4 File Offset: 0x00B58EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameFunctionType(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			teamRoomListItemUIController.m_luaExportHelper.m_gameFunctionType = gameFunctionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021897 RID: 137367 RVA: 0x00B5AD20 File Offset: 0x00B58F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_locationId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomListItemUIController.m_luaExportHelper.m_locationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021898 RID: 137368 RVA: 0x00B5AD78 File Offset: 0x00B58F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_locationId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			teamRoomListItemUIController.m_luaExportHelper.m_locationId = locationId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021899 RID: 137369 RVA: 0x00B5ADD4 File Offset: 0x00B58FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_roomId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamRoomListItemUIController.m_luaExportHelper.m_roomId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602189A RID: 137370 RVA: 0x00B5AE2C File Offset: 0x00B5902C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_roomId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomListItemUIController teamRoomListItemUIController = (TeamRoomListItemUIController)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			teamRoomListItemUIController.m_luaExportHelper.m_roomId = roomId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602189B RID: 137371 RVA: 0x00B5AE88 File Offset: 0x00B59088
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.SetGameFunctionTypeName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.SetLocationName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.SetRoomId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.GetRoomId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.SetGameFunctionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.GetGameFunctionType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.SetLocationId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.GetLocationIdId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.SetPlayer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.SetPlayerOff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.SetPlayerLevelRange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.GetPlayerInfoGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.OnJoinButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__callDele_EventOnJoinButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.__clearDele_EventOnJoinButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1C);
		string name = "EventOnJoinButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.set_EventOnJoinButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1D, true);
		string name2 = "m_joinButton";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.get_m_joinButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.set_m_joinButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache1F, true);
		string name3 = "m_gameFunctionTypeNameText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.get_m_gameFunctionTypeNameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.set_m_gameFunctionTypeNameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache21, true);
		string name4 = "m_locationNameText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.get_m_locationNameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.set_m_locationNameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache23, true);
		string name5 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.get_m_playerLevelText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache25, true);
		string name6 = "m_gameFunctionType";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.get_m_gameFunctionType);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.set_m_gameFunctionType);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache27, true);
		string name7 = "m_locationId";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.get_m_locationId);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.set_m_locationId);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache29, true);
		string name8 = "m_roomId";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.get_m_roomId);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.set_m_roomId);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TeamRoomListItemUIController.<>f__mg$cache2B, true);
		LuaObject.createTypeMetatable(l, null, typeof(TeamRoomListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401770B RID: 96011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401770C RID: 96012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401770D RID: 96013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401770E RID: 96014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401770F RID: 96015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017710 RID: 96016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017711 RID: 96017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017712 RID: 96018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017713 RID: 96019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017714 RID: 96020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017715 RID: 96021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017716 RID: 96022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017717 RID: 96023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017718 RID: 96024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017719 RID: 96025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401771A RID: 96026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401771B RID: 96027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401771C RID: 96028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401771D RID: 96029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401771E RID: 96030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401771F RID: 96031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017720 RID: 96032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017721 RID: 96033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017722 RID: 96034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017723 RID: 96035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017724 RID: 96036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017725 RID: 96037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017726 RID: 96038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017727 RID: 96039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017728 RID: 96040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017729 RID: 96041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401772A RID: 96042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401772B RID: 96043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401772C RID: 96044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401772D RID: 96045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401772E RID: 96046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401772F RID: 96047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017730 RID: 96048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017731 RID: 96049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017732 RID: 96050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017733 RID: 96051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017734 RID: 96052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017735 RID: 96053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017736 RID: 96054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
