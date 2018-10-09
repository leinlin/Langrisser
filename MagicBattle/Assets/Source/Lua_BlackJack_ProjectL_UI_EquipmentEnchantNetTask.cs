using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001427 RID: 5159
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask : LuaObject
{
	// Token: 0x0601D774 RID: 120692 RVA: 0x00954D70 File Offset: 0x00952F70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 2, out equipmentInstanceId);
			ulong enchantStoneInstanceId;
			LuaObject.checkType(l, 3, out enchantStoneInstanceId);
			EquipmentEnchantNetTask o = new EquipmentEnchantNetTask(equipmentInstanceId, enchantStoneInstanceId);
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

	// Token: 0x0601D775 RID: 120693 RVA: 0x00954DD0 File Offset: 0x00952FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NewResonanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentEnchantNetTask equipmentEnchantNetTask = (EquipmentEnchantNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentEnchantNetTask.NewResonanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D776 RID: 120694 RVA: 0x00954E24 File Offset: 0x00953024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NewResonanceId(IntPtr l)
	{
		int result;
		try
		{
			EquipmentEnchantNetTask equipmentEnchantNetTask = (EquipmentEnchantNetTask)LuaObject.checkSelf(l);
			int newResonanceId;
			LuaObject.checkType(l, 2, out newResonanceId);
			equipmentEnchantNetTask.NewResonanceId = newResonanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D777 RID: 120695 RVA: 0x00954E7C File Offset: 0x0095307C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Properties(IntPtr l)
	{
		int result;
		try
		{
			EquipmentEnchantNetTask equipmentEnchantNetTask = (EquipmentEnchantNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentEnchantNetTask.Properties);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D778 RID: 120696 RVA: 0x00954ED0 File Offset: 0x009530D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Properties(IntPtr l)
	{
		int result;
		try
		{
			EquipmentEnchantNetTask equipmentEnchantNetTask = (EquipmentEnchantNetTask)LuaObject.checkSelf(l);
			List<CommonBattleProperty> properties;
			LuaObject.checkType<List<CommonBattleProperty>>(l, 2, out properties);
			equipmentEnchantNetTask.Properties = properties;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D779 RID: 120697 RVA: 0x00954F28 File Offset: 0x00953128
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentEnchantNetTask");
		string name = "NewResonanceId";
		if (Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.get_NewResonanceId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.set_NewResonanceId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache1, true);
		string name2 = "Properties";
		if (Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.get_Properties);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.set_Properties);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EquipmentEnchantNetTask.<>f__mg$cache4, typeof(EquipmentEnchantNetTask), typeof(UINetTask));
	}

	// Token: 0x04013908 RID: 80136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013909 RID: 80137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401390A RID: 80138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401390B RID: 80139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401390C RID: 80140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
