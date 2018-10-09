using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001422 RID: 5154
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap : LuaObject
{
	// Token: 0x0601D5EE RID: 120302 RVA: 0x00948ADC File Offset: 0x00946CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController.EquipmentInfoWrap o = new EquipmentArchiveUIController.EquipmentInfoWrap();
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

	// Token: 0x0601D5EF RID: 120303 RVA: 0x00948B24 File Offset: 0x00946D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_equipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap = (EquipmentArchiveUIController.EquipmentInfoWrap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentInfoWrap.equipmentInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5F0 RID: 120304 RVA: 0x00948B78 File Offset: 0x00946D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_equipmentInfo(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap = (EquipmentArchiveUIController.EquipmentInfoWrap)LuaObject.checkSelf(l);
			ConfigDataEquipmentInfo equipmentInfo;
			LuaObject.checkType<ConfigDataEquipmentInfo>(l, 2, out equipmentInfo);
			equipmentInfoWrap.equipmentInfo = equipmentInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5F1 RID: 120305 RVA: 0x00948BD0 File Offset: 0x00946DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isUnlocked(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap = (EquipmentArchiveUIController.EquipmentInfoWrap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentInfoWrap.isUnlocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5F2 RID: 120306 RVA: 0x00948C24 File Offset: 0x00946E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isUnlocked(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap = (EquipmentArchiveUIController.EquipmentInfoWrap)LuaObject.checkSelf(l);
			bool isUnlocked;
			LuaObject.checkType(l, 2, out isUnlocked);
			equipmentInfoWrap.isUnlocked = isUnlocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5F3 RID: 120307 RVA: 0x00948C7C File Offset: 0x00946E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isSelect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap = (EquipmentArchiveUIController.EquipmentInfoWrap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentInfoWrap.isSelect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5F4 RID: 120308 RVA: 0x00948CD0 File Offset: 0x00946ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isSelect(IntPtr l)
	{
		int result;
		try
		{
			EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap = (EquipmentArchiveUIController.EquipmentInfoWrap)LuaObject.checkSelf(l);
			bool isSelect;
			LuaObject.checkType(l, 2, out isSelect);
			equipmentInfoWrap.isSelect = isSelect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D5F5 RID: 120309 RVA: 0x00948D28 File Offset: 0x00946F28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EquipmentArchiveUIController.EquipmentInfoWrap");
		string name = "equipmentInfo";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.get_equipmentInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.set_equipmentInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache1, true);
		string name2 = "isUnlocked";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.get_isUnlocked);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.set_isUnlocked);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache3, true);
		string name3 = "isSelect";
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.get_isSelect);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.set_isSelect);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EquipmentArchiveUIController_EquipmentInfoWrap.<>f__mg$cache6, typeof(EquipmentArchiveUIController.EquipmentInfoWrap));
	}

	// Token: 0x0401378C RID: 79756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401378D RID: 79757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401378E RID: 79758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401378F RID: 79759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013790 RID: 79760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013791 RID: 79761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013792 RID: 79762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
