using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200158B RID: 5515
[Preserve]
public class Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController : LuaObject
{
	// Token: 0x0602153A RID: 136506 RVA: 0x00B405C8 File Offset: 0x00B3E7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierSkinItemInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			FixedStoreItem soldierSkinItemInfo;
			LuaObject.checkType<FixedStoreItem>(l, 2, out soldierSkinItemInfo);
			storeSoldierSkinItemUIController.SetSoldierSkinItemInfo(soldierSkinItemInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602153B RID: 136507 RVA: 0x00B40620 File Offset: 0x00B3E820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetItemState(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			storeSoldierSkinItemUIController.SetItemState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602153C RID: 136508 RVA: 0x00B4066C File Offset: 0x00B3E86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			storeSoldierSkinItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602153D RID: 136509 RVA: 0x00B406C0 File Offset: 0x00B3E8C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierSpineAnim(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierSkinInfo soldierSpineAnim;
			LuaObject.checkType<ConfigDataSoldierSkinInfo>(l, 2, out soldierSpineAnim);
			storeSoldierSkinItemUIController.m_luaExportHelper.SetSoldierSpineAnim(soldierSpineAnim);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602153E RID: 136510 RVA: 0x00B4071C File Offset: 0x00B3E91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStoreItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			storeSoldierSkinItemUIController.m_luaExportHelper.OnStoreItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602153F RID: 136511 RVA: 0x00B40770 File Offset: 0x00B3E970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021540 RID: 136512 RVA: 0x00B407DC File Offset: 0x00B3E9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021541 RID: 136513 RVA: 0x00B40830 File Offset: 0x00B3EA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021542 RID: 136514 RVA: 0x00B40884 File Offset: 0x00B3EA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021543 RID: 136515 RVA: 0x00B4092C File Offset: 0x00B3EB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021544 RID: 136516 RVA: 0x00B40980 File Offset: 0x00B3EB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021545 RID: 136517 RVA: 0x00B409EC File Offset: 0x00B3EBEC
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
				StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				StoreSoldierSkinItemUIController storeSoldierSkinItemUIController2 = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				storeSoldierSkinItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021546 RID: 136518 RVA: 0x00B40AFC File Offset: 0x00B3ECFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021547 RID: 136519 RVA: 0x00B40B68 File Offset: 0x00B3ED68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021548 RID: 136520 RVA: 0x00B40BD4 File Offset: 0x00B3EDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021549 RID: 136521 RVA: 0x00B40C40 File Offset: 0x00B3EE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602154A RID: 136522 RVA: 0x00B40CAC File Offset: 0x00B3EEAC
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
				StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				StoreSoldierSkinItemUIController storeSoldierSkinItemUIController2 = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				storeSoldierSkinItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602154B RID: 136523 RVA: 0x00B40DBC File Offset: 0x00B3EFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			string s = storeSoldierSkinItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602154C RID: 136524 RVA: 0x00B40E18 File Offset: 0x00B3F018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			StoreSoldierSkinItemUIController obj;
			LuaObject.checkType<StoreSoldierSkinItemUIController>(l, 2, out obj);
			storeSoldierSkinItemUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602154D RID: 136525 RVA: 0x00B40E74 File Offset: 0x00B3F074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			StoreSoldierSkinItemUIController obj;
			LuaObject.checkType<StoreSoldierSkinItemUIController>(l, 2, out obj);
			storeSoldierSkinItemUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602154E RID: 136526 RVA: 0x00B40ED0 File Offset: 0x00B3F0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			Action<StoreSoldierSkinItemUIController> value;
			int num = LuaObject.checkDelegate<Action<StoreSoldierSkinItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeSoldierSkinItemUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					storeSoldierSkinItemUIController.EventOnClick -= value;
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

	// Token: 0x0602154F RID: 136527 RVA: 0x00B40F50 File Offset: 0x00B3F150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeType(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeSoldierSkinItemUIController.m_storeType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021550 RID: 136528 RVA: 0x00B40FA4 File Offset: 0x00B3F1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeType(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			StoreType storeType;
			LuaObject.checkEnum<StoreType>(l, 2, out storeType);
			storeSoldierSkinItemUIController.m_storeType = storeType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021551 RID: 136529 RVA: 0x00B40FFC File Offset: 0x00B3F1FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeItemConfig(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinItemUIController.m_storeItemConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021552 RID: 136530 RVA: 0x00B41050 File Offset: 0x00B3F250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeItemConfig(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo storeItemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out storeItemConfig);
			storeSoldierSkinItemUIController.m_storeItemConfig = storeItemConfig;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021553 RID: 136531 RVA: 0x00B410A8 File Offset: 0x00B3F2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinItemUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021554 RID: 136532 RVA: 0x00B41100 File Offset: 0x00B3F300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			storeSoldierSkinItemUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021555 RID: 136533 RVA: 0x00B4115C File Offset: 0x00B3F35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinItemUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021556 RID: 136534 RVA: 0x00B411B4 File Offset: 0x00B3F3B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			storeSoldierSkinItemUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021557 RID: 136535 RVA: 0x00B41210 File Offset: 0x00B3F410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinItemUIController.m_luaExportHelper.m_soldierGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021558 RID: 136536 RVA: 0x00B41268 File Offset: 0x00B3F468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierGraphic);
			storeSoldierSkinItemUIController.m_luaExportHelper.m_soldierGraphic = soldierGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021559 RID: 136537 RVA: 0x00B412C4 File Offset: 0x00B3F4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeItemButton(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinItemUIController.m_storeItemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602155A RID: 136538 RVA: 0x00B41318 File Offset: 0x00B3F518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeItemButton(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			Button storeItemButton;
			LuaObject.checkType<Button>(l, 2, out storeItemButton);
			storeSoldierSkinItemUIController.m_storeItemButton = storeItemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602155B RID: 136539 RVA: 0x00B41370 File Offset: 0x00B3F570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spineAnimObj(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinItemUIController.m_spineAnimObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602155C RID: 136540 RVA: 0x00B413C4 File Offset: 0x00B3F5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_spineAnimObj(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			GameObject spineAnimObj;
			LuaObject.checkType<GameObject>(l, 2, out spineAnimObj);
			storeSoldierSkinItemUIController.m_spineAnimObj = spineAnimObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602155D RID: 136541 RVA: 0x00B4141C File Offset: 0x00B3F61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierName(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinItemUIController.m_soldierName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602155E RID: 136542 RVA: 0x00B41470 File Offset: 0x00B3F670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierName(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			Text soldierName;
			LuaObject.checkType<Text>(l, 2, out soldierName);
			storeSoldierSkinItemUIController.m_soldierName = soldierName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602155F RID: 136543 RVA: 0x00B414C8 File Offset: 0x00B3F6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_restTime(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinItemUIController.m_restTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021560 RID: 136544 RVA: 0x00B4151C File Offset: 0x00B3F71C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_restTime(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			Text restTime;
			LuaObject.checkType<Text>(l, 2, out restTime);
			storeSoldierSkinItemUIController.m_restTime = restTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021561 RID: 136545 RVA: 0x00B41574 File Offset: 0x00B3F774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_priceText(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinItemUIController.m_priceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021562 RID: 136546 RVA: 0x00B415C8 File Offset: 0x00B3F7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_priceText(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			Text priceText;
			LuaObject.checkType<Text>(l, 2, out priceText);
			storeSoldierSkinItemUIController.m_priceText = priceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021563 RID: 136547 RVA: 0x00B41620 File Offset: 0x00B3F820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinItemUIController.m_itemUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021564 RID: 136548 RVA: 0x00B41674 File Offset: 0x00B3F874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinItemUIController storeSoldierSkinItemUIController = (StoreSoldierSkinItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController itemUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out itemUIStateCtrl);
			storeSoldierSkinItemUIController.m_itemUIStateCtrl = itemUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021565 RID: 136549 RVA: 0x00B416CC File Offset: 0x00B3F8CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.StoreSoldierSkinItemUIController");
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.SetSoldierSkinItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.SetItemState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.SetSoldierSpineAnim);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.OnStoreItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache13);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache14, true);
		string name2 = "m_storeType";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.get_m_storeType);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_m_storeType);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache16, true);
		string name3 = "m_storeItemConfig";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.get_m_storeItemConfig);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_m_storeItemConfig);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache18, true);
		string name4 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.get_m_playerContext);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1A, true);
		string name5 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.get_m_configDataLoader);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1C, true);
		string name6 = "m_soldierGraphic";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.get_m_soldierGraphic);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_m_soldierGraphic);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1E, true);
		string name7 = "m_storeItemButton";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.get_m_storeItemButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_m_storeItemButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache20, true);
		string name8 = "m_spineAnimObj";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.get_m_spineAnimObj);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_m_spineAnimObj);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache22, true);
		string name9 = "m_soldierName";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.get_m_soldierName);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_m_soldierName);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache24, true);
		string name10 = "m_restTime";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.get_m_restTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_m_restTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache26, true);
		string name11 = "m_priceText";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.get_m_priceText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_m_priceText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache28, true);
		string name12 = "m_itemUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.get_m_itemUIStateCtrl);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.set_m_itemUIStateCtrl);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinItemUIController.<>f__mg$cache2A, true);
		LuaObject.createTypeMetatable(l, null, typeof(StoreSoldierSkinItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017406 RID: 95238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017407 RID: 95239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017408 RID: 95240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017409 RID: 95241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401740A RID: 95242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401740B RID: 95243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401740C RID: 95244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401740D RID: 95245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401740E RID: 95246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401740F RID: 95247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017410 RID: 95248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017411 RID: 95249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017412 RID: 95250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017413 RID: 95251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017414 RID: 95252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017415 RID: 95253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017416 RID: 95254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017417 RID: 95255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017418 RID: 95256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017419 RID: 95257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401741A RID: 95258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401741B RID: 95259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401741C RID: 95260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401741D RID: 95261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401741E RID: 95262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401741F RID: 95263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017420 RID: 95264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017421 RID: 95265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017422 RID: 95266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017423 RID: 95267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017424 RID: 95268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017425 RID: 95269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017426 RID: 95270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017427 RID: 95271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017428 RID: 95272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017429 RID: 95273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401742A RID: 95274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401742B RID: 95275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401742C RID: 95276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401742D RID: 95277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401742E RID: 95278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401742F RID: 95279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017430 RID: 95280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
