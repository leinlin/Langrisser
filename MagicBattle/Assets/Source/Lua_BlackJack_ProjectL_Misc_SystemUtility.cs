using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020012AF RID: 4783
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_SystemUtility : LuaObject
{
	// Token: 0x0601913F RID: 102719 RVA: 0x0072618C File Offset: 0x0072438C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SystemUtility o = new SystemUtility();
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

	// Token: 0x06019140 RID: 102720 RVA: 0x007261D4 File Offset: 0x007243D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTimeScale_s(IntPtr l)
	{
		int result;
		try
		{
			float timeScale;
			LuaObject.checkType(l, 1, out timeScale);
			SystemUtility.SetTimeScale(timeScale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019141 RID: 102721 RVA: 0x00726220 File Offset: 0x00724420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetConfigDataDeviceSetting_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataDeviceSetting configDataDeviceSetting = SystemUtility.GetConfigDataDeviceSetting();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataDeviceSetting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019142 RID: 102722 RVA: 0x00726268 File Offset: 0x00724468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsiPhoneX_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = SystemUtility.IsiPhoneX();
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

	// Token: 0x06019143 RID: 102723 RVA: 0x007262B0 File Offset: 0x007244B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLowSystemMemory_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = SystemUtility.IsLowSystemMemory();
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

	// Token: 0x06019144 RID: 102724 RVA: 0x007262F8 File Offset: 0x007244F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLargeSystemMemory_s(IntPtr l)
	{
		int result;
		try
		{
			bool b = SystemUtility.IsLargeSystemMemory();
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

	// Token: 0x06019145 RID: 102725 RVA: 0x00726340 File Offset: 0x00724540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBatteryStatus_s(IntPtr l)
	{
		int result;
		try
		{
			BatteryStatus batteryStatus = SystemUtility.GetBatteryStatus();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)batteryStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019146 RID: 102726 RVA: 0x00726388 File Offset: 0x00724588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBatteryLevel_s(IntPtr l)
	{
		int result;
		try
		{
			float batteryLevel = SystemUtility.GetBatteryLevel();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, batteryLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019147 RID: 102727 RVA: 0x007263D0 File Offset: 0x007245D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogBatteryStatus_s(IntPtr l)
	{
		int result;
		try
		{
			SystemUtility.LogBatteryStatus();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019148 RID: 102728 RVA: 0x00726410 File Offset: 0x00724610
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TimeScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SystemUtility.TimeScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019149 RID: 102729 RVA: 0x00726458 File Offset: 0x00724658
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TimeScale(IntPtr l)
	{
		int result;
		try
		{
			float timeScale;
			LuaObject.checkType(l, 2, out timeScale);
			SystemUtility.TimeScale = timeScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601914A RID: 102730 RVA: 0x007264A4 File Offset: 0x007246A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.SystemUtility");
		if (Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_SystemUtility.SetTimeScale_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_SystemUtility.GetConfigDataDeviceSetting_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_SystemUtility.IsiPhoneX_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_SystemUtility.IsLowSystemMemory_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_SystemUtility.IsLargeSystemMemory_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_SystemUtility.GetBatteryStatus_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_SystemUtility.GetBatteryLevel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_SystemUtility.LogBatteryStatus_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache7);
		string name = "TimeScale";
		if (Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_SystemUtility.get_TimeScale);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_SystemUtility.set_TimeScale);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cache9, false);
		if (Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_SystemUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_SystemUtility.<>f__mg$cacheA, typeof(SystemUtility));
	}

	// Token: 0x0400F5C3 RID: 62915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F5C4 RID: 62916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F5C5 RID: 62917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F5C6 RID: 62918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F5C7 RID: 62919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F5C8 RID: 62920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F5C9 RID: 62921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F5CA RID: 62922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F5CB RID: 62923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F5CC RID: 62924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F5CD RID: 62925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
