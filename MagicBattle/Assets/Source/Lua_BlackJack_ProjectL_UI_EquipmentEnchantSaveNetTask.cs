using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001428 RID: 5160
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask : LuaObject
{
	// Token: 0x0601D77B RID: 120699 RVA: 0x0095500C File Offset: 0x0095320C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			EquipmentEnchantSaveNetTask o = new EquipmentEnchantSaveNetTask();
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

	// Token: 0x0601D77C RID: 120700 RVA: 0x00955054 File Offset: 0x00953254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EquipBagItem(IntPtr l)
	{
		int result;
		try
		{
			EquipmentEnchantSaveNetTask equipmentEnchantSaveNetTask = (EquipmentEnchantSaveNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentEnchantSaveNetTask.EquipBagItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D77D RID: 120701 RVA: 0x009550A8 File Offset: 0x009532A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EquipBagItem(IntPtr l)
	{
		int result;
		try
		{
			EquipmentEnchantSaveNetTask equipmentEnchantSaveNetTask = (EquipmentEnchantSaveNetTask)LuaObject.checkSelf(l);
			EquipmentBagItem equipBagItem;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipBagItem);
			equipmentEnchantSaveNetTask.EquipBagItem = equipBagItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D77E RID: 120702 RVA: 0x00955100 File Offset: 0x00953300
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentEnchantSaveNetTask");
		string name = "EquipBagItem";
		if (Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.get_EquipBagItem);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.set_EquipBagItem);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EquipmentEnchantSaveNetTask.<>f__mg$cache2, typeof(EquipmentEnchantSaveNetTask), typeof(UINetTask));
	}

	// Token: 0x0401390D RID: 80141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401390E RID: 80142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401390F RID: 80143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
