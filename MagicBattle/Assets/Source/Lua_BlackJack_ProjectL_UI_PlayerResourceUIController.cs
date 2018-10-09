using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200152F RID: 5423
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerResourceUIController : LuaObject
{
	// Token: 0x0602041F RID: 132127 RVA: 0x00AB7834 File Offset: 0x00AB5A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdatePlayerResource(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.UpdatePlayerResource();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020420 RID: 132128 RVA: 0x00AB7880 File Offset: 0x00AB5A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020421 RID: 132129 RVA: 0x00AB78D4 File Offset: 0x00AB5AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnable(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.OnEnable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020422 RID: 132130 RVA: 0x00AB7928 File Offset: 0x00AB5B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020423 RID: 132131 RVA: 0x00AB797C File Offset: 0x00AB5B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDestroy(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.OnDestroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020424 RID: 132132 RVA: 0x00AB79D0 File Offset: 0x00AB5BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGoldCount(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			int goldCount;
			LuaObject.checkType(l, 2, out goldCount);
			playerResourceUIController.m_luaExportHelper.SetGoldCount(goldCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020425 RID: 132133 RVA: 0x00AB7A2C File Offset: 0x00AB5C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCrystalCount(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			int crystalCount;
			LuaObject.checkType(l, 2, out crystalCount);
			playerResourceUIController.m_luaExportHelper.SetCrystalCount(crystalCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020426 RID: 132134 RVA: 0x00AB7A88 File Offset: 0x00AB5C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			int max;
			LuaObject.checkType(l, 3, out max);
			playerResourceUIController.m_luaExportHelper.SetEnergy(count, max);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020427 RID: 132135 RVA: 0x00AB7AF4 File Offset: 0x00AB5CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddGoldButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.OnAddGoldButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020428 RID: 132136 RVA: 0x00AB7B48 File Offset: 0x00AB5D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddCrystalButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.OnAddCrystalButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020429 RID: 132137 RVA: 0x00AB7B9C File Offset: 0x00AB5D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddEnergyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.OnAddEnergyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602042A RID: 132138 RVA: 0x00AB7BF0 File Offset: 0x00AB5DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnergyStatusButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.OnEnergyStatusButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602042B RID: 132139 RVA: 0x00AB7C44 File Offset: 0x00AB5E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerContext_OnPlayerInfoChangeNtf(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.PlayerContext_OnPlayerInfoChangeNtf();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602042C RID: 132140 RVA: 0x00AB7C98 File Offset: 0x00AB5E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			playerResourceUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602042D RID: 132141 RVA: 0x00AB7D04 File Offset: 0x00AB5F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602042E RID: 132142 RVA: 0x00AB7D58 File Offset: 0x00AB5F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602042F RID: 132143 RVA: 0x00AB7DAC File Offset: 0x00AB5FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = playerResourceUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020430 RID: 132144 RVA: 0x00AB7E54 File Offset: 0x00AB6054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020431 RID: 132145 RVA: 0x00AB7EA8 File Offset: 0x00AB60A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			playerResourceUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020432 RID: 132146 RVA: 0x00AB7F14 File Offset: 0x00AB6114
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
				PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				playerResourceUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PlayerResourceUIController playerResourceUIController2 = (PlayerResourceUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				playerResourceUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020433 RID: 132147 RVA: 0x00AB8024 File Offset: 0x00AB6224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerResourceUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020434 RID: 132148 RVA: 0x00AB8090 File Offset: 0x00AB6290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerResourceUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020435 RID: 132149 RVA: 0x00AB80FC File Offset: 0x00AB62FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerResourceUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020436 RID: 132150 RVA: 0x00AB8168 File Offset: 0x00AB6368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerResourceUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020437 RID: 132151 RVA: 0x00AB81D4 File Offset: 0x00AB63D4
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
				PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				playerResourceUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PlayerResourceUIController playerResourceUIController2 = (PlayerResourceUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				playerResourceUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020438 RID: 132152 RVA: 0x00AB82E4 File Offset: 0x00AB64E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			string s = playerResourceUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020439 RID: 132153 RVA: 0x00AB8340 File Offset: 0x00AB6540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddGold(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.__callDele_EventOnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602043A RID: 132154 RVA: 0x00AB8394 File Offset: 0x00AB6594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddGold(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.__clearDele_EventOnAddGold();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602043B RID: 132155 RVA: 0x00AB83E8 File Offset: 0x00AB65E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.__callDele_EventOnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602043C RID: 132156 RVA: 0x00AB843C File Offset: 0x00AB663C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			playerResourceUIController.m_luaExportHelper.__clearDele_EventOnAddCrystal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602043D RID: 132157 RVA: 0x00AB8490 File Offset: 0x00AB6690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddGold(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerResourceUIController.EventOnAddGold += value;
				}
				else if (num == 2)
				{
					playerResourceUIController.EventOnAddGold -= value;
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

	// Token: 0x0602043E RID: 132158 RVA: 0x00AB8510 File Offset: 0x00AB6710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddCrystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerResourceUIController.EventOnAddCrystal += value;
				}
				else if (num == 2)
				{
					playerResourceUIController.EventOnAddCrystal -= value;
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

	// Token: 0x0602043F RID: 132159 RVA: 0x00AB8590 File Offset: 0x00AB6790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerResourceUIController.m_luaExportHelper.m_goldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020440 RID: 132160 RVA: 0x00AB85E8 File Offset: 0x00AB67E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			Text goldText;
			LuaObject.checkType<Text>(l, 2, out goldText);
			playerResourceUIController.m_luaExportHelper.m_goldText = goldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020441 RID: 132161 RVA: 0x00AB8644 File Offset: 0x00AB6844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addGoldButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerResourceUIController.m_luaExportHelper.m_addGoldButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020442 RID: 132162 RVA: 0x00AB869C File Offset: 0x00AB689C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addGoldButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			Button addGoldButton;
			LuaObject.checkType<Button>(l, 2, out addGoldButton);
			playerResourceUIController.m_luaExportHelper.m_addGoldButton = addGoldButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020443 RID: 132163 RVA: 0x00AB86F8 File Offset: 0x00AB68F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_crystalText(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerResourceUIController.m_luaExportHelper.m_crystalText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020444 RID: 132164 RVA: 0x00AB8750 File Offset: 0x00AB6950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_crystalText(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			Text crystalText;
			LuaObject.checkType<Text>(l, 2, out crystalText);
			playerResourceUIController.m_luaExportHelper.m_crystalText = crystalText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020445 RID: 132165 RVA: 0x00AB87AC File Offset: 0x00AB69AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addCrystalButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerResourceUIController.m_luaExportHelper.m_addCrystalButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020446 RID: 132166 RVA: 0x00AB8804 File Offset: 0x00AB6A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addCrystalButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			Button addCrystalButton;
			LuaObject.checkType<Button>(l, 2, out addCrystalButton);
			playerResourceUIController.m_luaExportHelper.m_addCrystalButton = addCrystalButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020447 RID: 132167 RVA: 0x00AB8860 File Offset: 0x00AB6A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerResourceUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020448 RID: 132168 RVA: 0x00AB88B8 File Offset: 0x00AB6AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			playerResourceUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020449 RID: 132169 RVA: 0x00AB8914 File Offset: 0x00AB6B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addEnergyButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerResourceUIController.m_luaExportHelper.m_addEnergyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602044A RID: 132170 RVA: 0x00AB896C File Offset: 0x00AB6B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addEnergyButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			Button addEnergyButton;
			LuaObject.checkType<Button>(l, 2, out addEnergyButton);
			playerResourceUIController.m_luaExportHelper.m_addEnergyButton = addEnergyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602044B RID: 132171 RVA: 0x00AB89C8 File Offset: 0x00AB6BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyStatusButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerResourceUIController.m_luaExportHelper.m_energyStatusButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602044C RID: 132172 RVA: 0x00AB8A20 File Offset: 0x00AB6C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyStatusButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			Button energyStatusButton;
			LuaObject.checkType<Button>(l, 2, out energyStatusButton);
			playerResourceUIController.m_luaExportHelper.m_energyStatusButton = energyStatusButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602044D RID: 132173 RVA: 0x00AB8A7C File Offset: 0x00AB6C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyEnergyUITask(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerResourceUIController.m_luaExportHelper.m_buyEnergyUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602044E RID: 132174 RVA: 0x00AB8AD4 File Offset: 0x00AB6CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyEnergyUITask(IntPtr l)
	{
		int result;
		try
		{
			PlayerResourceUIController playerResourceUIController = (PlayerResourceUIController)LuaObject.checkSelf(l);
			BuyEnergyUITask buyEnergyUITask;
			LuaObject.checkType<BuyEnergyUITask>(l, 2, out buyEnergyUITask);
			playerResourceUIController.m_luaExportHelper.m_buyEnergyUITask = buyEnergyUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602044F RID: 132175 RVA: 0x00AB8B30 File Offset: 0x00AB6D30
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerResourceUIController");
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.UpdatePlayerResource);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.OnEnable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.OnDestroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.SetGoldCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.SetCrystalCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.SetEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.OnAddGoldButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.OnAddCrystalButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.OnAddEnergyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.OnEnergyStatusButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.PlayerContext_OnPlayerInfoChangeNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callDele_EventOnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__clearDele_EventOnAddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__callDele_EventOnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.__clearDele_EventOnAddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1D);
		string name = "EventOnAddGold";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.set_EventOnAddGold);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1E, true);
		string name2 = "EventOnAddCrystal";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.set_EventOnAddCrystal);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache1F, true);
		string name3 = "m_goldText";
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.get_m_goldText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.set_m_goldText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache21, true);
		string name4 = "m_addGoldButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.get_m_addGoldButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.set_m_addGoldButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache23, true);
		string name5 = "m_crystalText";
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.get_m_crystalText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.set_m_crystalText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache25, true);
		string name6 = "m_addCrystalButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.get_m_addCrystalButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.set_m_addCrystalButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache27, true);
		string name7 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.get_m_energyText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache29, true);
		string name8 = "m_addEnergyButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.get_m_addEnergyButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.set_m_addEnergyButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2B, true);
		string name9 = "m_energyStatusButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.get_m_energyStatusButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.set_m_energyStatusButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2D, true);
		string name10 = "m_buyEnergyUITask";
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.get_m_buyEnergyUITask);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.set_m_buyEnergyUITask);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_PlayerResourceUIController.<>f__mg$cache2F, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerResourceUIController), typeof(UIControllerBase));
	}

	// Token: 0x040163A3 RID: 91043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040163A4 RID: 91044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040163A5 RID: 91045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040163A6 RID: 91046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040163A7 RID: 91047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040163A8 RID: 91048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040163A9 RID: 91049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040163AA RID: 91050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040163AB RID: 91051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040163AC RID: 91052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040163AD RID: 91053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040163AE RID: 91054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040163AF RID: 91055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040163B0 RID: 91056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040163B1 RID: 91057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040163B2 RID: 91058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040163B3 RID: 91059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040163B4 RID: 91060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040163B5 RID: 91061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040163B6 RID: 91062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040163B7 RID: 91063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040163B8 RID: 91064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040163B9 RID: 91065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040163BA RID: 91066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040163BB RID: 91067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040163BC RID: 91068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040163BD RID: 91069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040163BE RID: 91070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040163BF RID: 91071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040163C0 RID: 91072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040163C1 RID: 91073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040163C2 RID: 91074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040163C3 RID: 91075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040163C4 RID: 91076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040163C5 RID: 91077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040163C6 RID: 91078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040163C7 RID: 91079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040163C8 RID: 91080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040163C9 RID: 91081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040163CA RID: 91082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040163CB RID: 91083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040163CC RID: 91084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040163CD RID: 91085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040163CE RID: 91086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040163CF RID: 91087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040163D0 RID: 91088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040163D1 RID: 91089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040163D2 RID: 91090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
