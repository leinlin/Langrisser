using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012AA RID: 4778
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle : LuaObject
{
	// Token: 0x06019100 RID: 102656 RVA: 0x007247F8 File Offset: 0x007229F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattle o = new LocalProcessingBattle();
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

	// Token: 0x06019101 RID: 102657 RVA: 0x00724840 File Offset: 0x00722A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFileName(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattle localProcessingBattle = (LocalProcessingBattle)LuaObject.checkSelf(l);
			string fileName;
			LuaObject.checkType(l, 2, out fileName);
			localProcessingBattle.SetFileName(fileName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019102 RID: 102658 RVA: 0x00724898 File Offset: 0x00722A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Save(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattle localProcessingBattle = (LocalProcessingBattle)LuaObject.checkSelf(l);
			bool b = localProcessingBattle.Save();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019103 RID: 102659 RVA: 0x007248EC File Offset: 0x00722AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Load(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattle localProcessingBattle = (LocalProcessingBattle)LuaObject.checkSelf(l);
			bool b = localProcessingBattle.Load();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019104 RID: 102660 RVA: 0x00724940 File Offset: 0x00722B40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Delete(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattle localProcessingBattle = (LocalProcessingBattle)LuaObject.checkSelf(l);
			bool b = localProcessingBattle.Delete();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019105 RID: 102661 RVA: 0x00724994 File Offset: 0x00722B94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Data(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattle localProcessingBattle = (LocalProcessingBattle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localProcessingBattle.Data);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019106 RID: 102662 RVA: 0x007249E8 File Offset: 0x00722BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LocalProcessingBattle.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019107 RID: 102663 RVA: 0x00724A30 File Offset: 0x00722C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Instance(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattle instance;
			LuaObject.checkType<LocalProcessingBattle>(l, 2, out instance);
			LocalProcessingBattle.Instance = instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019108 RID: 102664 RVA: 0x00724A7C File Offset: 0x00722C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaInstance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LocalProcessingBattle.ArenaInstance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019109 RID: 102665 RVA: 0x00724AC4 File Offset: 0x00722CC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ArenaInstance(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattle arenaInstance;
			LuaObject.checkType<LocalProcessingBattle>(l, 2, out arenaInstance);
			LocalProcessingBattle.ArenaInstance = arenaInstance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601910A RID: 102666 RVA: 0x00724B10 File Offset: 0x00722D10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.LocalProcessingBattle");
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.SetFileName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.Save);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.Load);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.Delete);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache3);
		string name = "Data";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.get_Data);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache4, null, true);
		string name2 = "Instance";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.get_Instance);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.set_Instance);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache6, false);
		string name3 = "ArenaInstance";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.get_ArenaInstance);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.set_ArenaInstance);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache8, false);
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattle.<>f__mg$cache9, typeof(LocalProcessingBattle));
	}

	// Token: 0x0400F58E RID: 62862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F58F RID: 62863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F590 RID: 62864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F591 RID: 62865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F592 RID: 62866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F593 RID: 62867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F594 RID: 62868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F595 RID: 62869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F596 RID: 62870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F597 RID: 62871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
