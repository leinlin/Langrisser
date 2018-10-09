using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013E0 RID: 5088
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BuyEnergyUIController : LuaObject
{
	// Token: 0x0601C86D RID: 116845 RVA: 0x008DD00C File Offset: 0x008DB20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C86E RID: 116846 RVA: 0x008DD058 File Offset: 0x008DB258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEnergy(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			int energyCount;
			LuaObject.checkType(l, 2, out energyCount);
			int price;
			LuaObject.checkType(l, 3, out price);
			bool isBoughtNumsUsedOut;
			LuaObject.checkType(l, 4, out isBoughtNumsUsedOut);
			buyEnergyUIController.SetEnergy(energyCount, price, isBoughtNumsUsedOut);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C86F RID: 116847 RVA: 0x008DD0CC File Offset: 0x008DB2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMedicine(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			int energyCount;
			LuaObject.checkType(l, 2, out energyCount);
			int useMedicineCount;
			LuaObject.checkType(l, 3, out useMedicineCount);
			int redidueMedicineCount;
			LuaObject.checkType(l, 4, out redidueMedicineCount);
			buyEnergyUIController.SetMedicine(energyCount, useMedicineCount, redidueMedicineCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C870 RID: 116848 RVA: 0x008DD140 File Offset: 0x008DB340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowEnergyNotEnoughTip(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			string s;
			LuaObject.checkType(l, 2, out s);
			buyEnergyUIController.ShowEnergyNotEnoughTip(s);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C871 RID: 116849 RVA: 0x008DD198 File Offset: 0x008DB398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C872 RID: 116850 RVA: 0x008DD1E4 File Offset: 0x008DB3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C873 RID: 116851 RVA: 0x008DD238 File Offset: 0x008DB438
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C874 RID: 116852 RVA: 0x008DD28C File Offset: 0x008DB48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBuyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.OnBuyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C875 RID: 116853 RVA: 0x008DD2E0 File Offset: 0x008DB4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUseEnergyMedicineButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.OnUseEnergyMedicineButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C876 RID: 116854 RVA: 0x008DD334 File Offset: 0x008DB534
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			buyEnergyUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C877 RID: 116855 RVA: 0x008DD3A0 File Offset: 0x008DB5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C878 RID: 116856 RVA: 0x008DD3F4 File Offset: 0x008DB5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C879 RID: 116857 RVA: 0x008DD448 File Offset: 0x008DB648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = buyEnergyUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C87A RID: 116858 RVA: 0x008DD4F0 File Offset: 0x008DB6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C87B RID: 116859 RVA: 0x008DD544 File Offset: 0x008DB744
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			buyEnergyUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C87C RID: 116860 RVA: 0x008DD5B0 File Offset: 0x008DB7B0
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
				BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				buyEnergyUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BuyEnergyUIController buyEnergyUIController2 = (BuyEnergyUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				buyEnergyUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C87D RID: 116861 RVA: 0x008DD6C0 File Offset: 0x008DB8C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			buyEnergyUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C87E RID: 116862 RVA: 0x008DD72C File Offset: 0x008DB92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			buyEnergyUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C87F RID: 116863 RVA: 0x008DD798 File Offset: 0x008DB998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			buyEnergyUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C880 RID: 116864 RVA: 0x008DD804 File Offset: 0x008DBA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			buyEnergyUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C881 RID: 116865 RVA: 0x008DD870 File Offset: 0x008DBA70
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
				BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				buyEnergyUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BuyEnergyUIController buyEnergyUIController2 = (BuyEnergyUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				buyEnergyUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C882 RID: 116866 RVA: 0x008DD980 File Offset: 0x008DBB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			string s = buyEnergyUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C883 RID: 116867 RVA: 0x008DD9DC File Offset: 0x008DBBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUseEnergyMedicine(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.__callDele_EventOnUseEnergyMedicine();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C884 RID: 116868 RVA: 0x008DDA30 File Offset: 0x008DBC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnUseEnergyMedicine(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.__clearDele_EventOnUseEnergyMedicine();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C885 RID: 116869 RVA: 0x008DDA84 File Offset: 0x008DBC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBuyEnergy(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.__callDele_EventOnBuyEnergy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C886 RID: 116870 RVA: 0x008DDAD8 File Offset: 0x008DBCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBuyEnergy(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.__clearDele_EventOnBuyEnergy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C887 RID: 116871 RVA: 0x008DDB2C File Offset: 0x008DBD2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C888 RID: 116872 RVA: 0x008DDB80 File Offset: 0x008DBD80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			buyEnergyUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C889 RID: 116873 RVA: 0x008DDBD4 File Offset: 0x008DBDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUseEnergyMedicine(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					buyEnergyUIController.EventOnUseEnergyMedicine += value;
				}
				else if (num == 2)
				{
					buyEnergyUIController.EventOnUseEnergyMedicine -= value;
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

	// Token: 0x0601C88A RID: 116874 RVA: 0x008DDC54 File Offset: 0x008DBE54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBuyEnergy(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					buyEnergyUIController.EventOnBuyEnergy += value;
				}
				else if (num == 2)
				{
					buyEnergyUIController.EventOnBuyEnergy -= value;
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

	// Token: 0x0601C88B RID: 116875 RVA: 0x008DDCD4 File Offset: 0x008DBED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					buyEnergyUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					buyEnergyUIController.EventOnClose -= value;
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

	// Token: 0x0601C88C RID: 116876 RVA: 0x008DDD54 File Offset: 0x008DBF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C88D RID: 116877 RVA: 0x008DDDAC File Offset: 0x008DBFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			buyEnergyUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C88E RID: 116878 RVA: 0x008DDE08 File Offset: 0x008DC008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyCountText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_energyCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C88F RID: 116879 RVA: 0x008DDE60 File Offset: 0x008DC060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyCountText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Text energyCountText;
			LuaObject.checkType<Text>(l, 2, out energyCountText);
			buyEnergyUIController.m_luaExportHelper.m_energyCountText = energyCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C890 RID: 116880 RVA: 0x008DDEBC File Offset: 0x008DC0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyButton(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_buyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C891 RID: 116881 RVA: 0x008DDF14 File Offset: 0x008DC114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyButton(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Button buyButton;
			LuaObject.checkType<Button>(l, 2, out buyButton);
			buyEnergyUIController.m_luaExportHelper.m_buyButton = buyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C892 RID: 116882 RVA: 0x008DDF70 File Offset: 0x008DC170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_priceText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_priceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C893 RID: 116883 RVA: 0x008DDFC8 File Offset: 0x008DC1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_priceText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Text priceText;
			LuaObject.checkType<Text>(l, 2, out priceText);
			buyEnergyUIController.m_luaExportHelper.m_priceText = priceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C894 RID: 116884 RVA: 0x008DE024 File Offset: 0x008DC224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyGrayImage(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_buyGrayImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C895 RID: 116885 RVA: 0x008DE07C File Offset: 0x008DC27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyGrayImage(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Image buyGrayImage;
			LuaObject.checkType<Image>(l, 2, out buyGrayImage);
			buyEnergyUIController.m_luaExportHelper.m_buyGrayImage = buyGrayImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C896 RID: 116886 RVA: 0x008DE0D8 File Offset: 0x008DC2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyCountMedicineText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_energyCountMedicineText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C897 RID: 116887 RVA: 0x008DE130 File Offset: 0x008DC330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyCountMedicineText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Text energyCountMedicineText;
			LuaObject.checkType<Text>(l, 2, out energyCountMedicineText);
			buyEnergyUIController.m_luaExportHelper.m_energyCountMedicineText = energyCountMedicineText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C898 RID: 116888 RVA: 0x008DE18C File Offset: 0x008DC38C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_useMedicineButton(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_useMedicineButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C899 RID: 116889 RVA: 0x008DE1E4 File Offset: 0x008DC3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_useMedicineButton(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Button useMedicineButton;
			LuaObject.checkType<Button>(l, 2, out useMedicineButton);
			buyEnergyUIController.m_luaExportHelper.m_useMedicineButton = useMedicineButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C89A RID: 116890 RVA: 0x008DE240 File Offset: 0x008DC440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_useMedicineCountText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_useMedicineCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C89B RID: 116891 RVA: 0x008DE298 File Offset: 0x008DC498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_useMedicineCountText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Text useMedicineCountText;
			LuaObject.checkType<Text>(l, 2, out useMedicineCountText);
			buyEnergyUIController.m_luaExportHelper.m_useMedicineCountText = useMedicineCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C89C RID: 116892 RVA: 0x008DE2F4 File Offset: 0x008DC4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redidueMedicineCountText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_redidueMedicineCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C89D RID: 116893 RVA: 0x008DE34C File Offset: 0x008DC54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redidueMedicineCountText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Text redidueMedicineCountText;
			LuaObject.checkType<Text>(l, 2, out redidueMedicineCountText);
			buyEnergyUIController.m_luaExportHelper.m_redidueMedicineCountText = redidueMedicineCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C89E RID: 116894 RVA: 0x008DE3A8 File Offset: 0x008DC5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C89F RID: 116895 RVA: 0x008DE400 File Offset: 0x008DC600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			buyEnergyUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8A0 RID: 116896 RVA: 0x008DE45C File Offset: 0x008DC65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyNotEnoughTipStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_energyNotEnoughTipStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8A1 RID: 116897 RVA: 0x008DE4B4 File Offset: 0x008DC6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyNotEnoughTipStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			CommonUIStateController energyNotEnoughTipStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out energyNotEnoughTipStateCtrl);
			buyEnergyUIController.m_luaExportHelper.m_energyNotEnoughTipStateCtrl = energyNotEnoughTipStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8A2 RID: 116898 RVA: 0x008DE510 File Offset: 0x008DC710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyNotEnoughTipText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyUIController.m_luaExportHelper.m_energyNotEnoughTipText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8A3 RID: 116899 RVA: 0x008DE568 File Offset: 0x008DC768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyNotEnoughTipText(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyUIController buyEnergyUIController = (BuyEnergyUIController)LuaObject.checkSelf(l);
			Text energyNotEnoughTipText;
			LuaObject.checkType<Text>(l, 2, out energyNotEnoughTipText);
			buyEnergyUIController.m_luaExportHelper.m_energyNotEnoughTipText = energyNotEnoughTipText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8A4 RID: 116900 RVA: 0x008DE5C4 File Offset: 0x008DC7C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BuyEnergyUIController");
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.SetEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.SetMedicine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.ShowEnergyNotEnoughTip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.OnBuyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.OnUseEnergyMedicineButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callDele_EventOnUseEnergyMedicine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__clearDele_EventOnUseEnergyMedicine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callDele_EventOnBuyEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__clearDele_EventOnBuyEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1B);
		string name = "EventOnUseEnergyMedicine";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_EventOnUseEnergyMedicine);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1C, true);
		string name2 = "EventOnBuyEnergy";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_EventOnBuyEnergy);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1D, true);
		string name3 = "EventOnClose";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1E, true);
		string name4 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_uiStateController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache20, true);
		string name5 = "m_energyCountText";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_energyCountText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_energyCountText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache22, true);
		string name6 = "m_buyButton";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_buyButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_buyButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache24, true);
		string name7 = "m_priceText";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_priceText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_priceText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache26, true);
		string name8 = "m_buyGrayImage";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_buyGrayImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_buyGrayImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache28, true);
		string name9 = "m_energyCountMedicineText";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_energyCountMedicineText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_energyCountMedicineText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2A, true);
		string name10 = "m_useMedicineButton";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_useMedicineButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_useMedicineButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2C, true);
		string name11 = "m_useMedicineCountText";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_useMedicineCountText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_useMedicineCountText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2E, true);
		string name12 = "m_redidueMedicineCountText";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_redidueMedicineCountText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_redidueMedicineCountText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache30, true);
		string name13 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_backgroundButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache32, true);
		string name14 = "m_energyNotEnoughTipStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_energyNotEnoughTipStateCtrl);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_energyNotEnoughTipStateCtrl);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache34, true);
		string name15 = "m_energyNotEnoughTipText";
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.get_m_energyNotEnoughTipText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.set_m_energyNotEnoughTipText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BuyEnergyUIController.<>f__mg$cache36, true);
		LuaObject.createTypeMetatable(l, null, typeof(BuyEnergyUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012A8F RID: 76431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012A90 RID: 76432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012A91 RID: 76433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012A92 RID: 76434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012A93 RID: 76435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012A94 RID: 76436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012A95 RID: 76437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012A96 RID: 76438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012A97 RID: 76439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012A98 RID: 76440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012A99 RID: 76441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012A9A RID: 76442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012A9B RID: 76443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012A9C RID: 76444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012A9D RID: 76445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012A9E RID: 76446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012A9F RID: 76447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012AA0 RID: 76448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012AA1 RID: 76449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012AA2 RID: 76450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012AA3 RID: 76451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012AA4 RID: 76452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012AA5 RID: 76453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012AA6 RID: 76454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012AA7 RID: 76455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012AA8 RID: 76456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012AA9 RID: 76457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012AAA RID: 76458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012AAB RID: 76459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012AAC RID: 76460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012AAD RID: 76461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04012AAE RID: 76462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04012AAF RID: 76463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04012AB0 RID: 76464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04012AB1 RID: 76465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04012AB2 RID: 76466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04012AB3 RID: 76467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04012AB4 RID: 76468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04012AB5 RID: 76469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04012AB6 RID: 76470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04012AB7 RID: 76471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04012AB8 RID: 76472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04012AB9 RID: 76473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04012ABA RID: 76474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04012ABB RID: 76475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04012ABC RID: 76476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04012ABD RID: 76477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04012ABE RID: 76478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04012ABF RID: 76479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04012AC0 RID: 76480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04012AC1 RID: 76481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04012AC2 RID: 76482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04012AC3 RID: 76483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04012AC4 RID: 76484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04012AC5 RID: 76485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;
}
