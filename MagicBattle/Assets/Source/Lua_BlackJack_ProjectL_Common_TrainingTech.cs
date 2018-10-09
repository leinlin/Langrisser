using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200128E RID: 4750
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TrainingTech : LuaObject
{
	// Token: 0x06018C10 RID: 101392 RVA: 0x00700974 File Offset: 0x006FEB74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TrainingTech o = new TrainingTech();
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

	// Token: 0x06018C11 RID: 101393 RVA: 0x007009BC File Offset: 0x006FEBBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateInstantiatedData(IntPtr l)
	{
		int result;
		try
		{
			TrainingTech trainingTech = (TrainingTech)LuaObject.checkSelf(l);
			List<TrainingTech> availableTechs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out availableTechs);
			trainingTech.UpdateInstantiatedData(availableTechs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C12 RID: 101394 RVA: 0x00700A14 File Offset: 0x006FEC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPro(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, new Type[0]))
			{
				TrainingTech trainingTech = (TrainingTech)LuaObject.checkSelf(l);
				ProTrainingTech o = trainingTech.ToPro();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, new Type[0]))
			{
				TrainingTech trainingTech2 = (TrainingTech)LuaObject.checkSelf(l);
				ProTrainingTech o2 = trainingTech2.ToPro();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ToPro to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C13 RID: 101395 RVA: 0x00700ADC File Offset: 0x006FECDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromDataSection_s(IntPtr l)
	{
		int result;
		try
		{
			ProTrainingTech tech;
			LuaObject.checkType<ProTrainingTech>(l, 1, out tech);
			TrainingTech o = TrainingTech.FromDataSection(tech);
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

	// Token: 0x06018C14 RID: 101396 RVA: 0x00700B30 File Offset: 0x006FED30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigId(IntPtr l)
	{
		int result;
		try
		{
			TrainingTech trainingTech = (TrainingTech)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTech.ConfigId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C15 RID: 101397 RVA: 0x00700B84 File Offset: 0x006FED84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ConfigId(IntPtr l)
	{
		int result;
		try
		{
			TrainingTech trainingTech = (TrainingTech)LuaObject.checkSelf(l);
			int configId;
			LuaObject.checkType(l, 2, out configId);
			trainingTech.ConfigId = configId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C16 RID: 101398 RVA: 0x00700BDC File Offset: 0x006FEDDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Infos(IntPtr l)
	{
		int result;
		try
		{
			TrainingTech trainingTech = (TrainingTech)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTech.Infos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C17 RID: 101399 RVA: 0x00700C30 File Offset: 0x006FEE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			TrainingTech trainingTech = (TrainingTech)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTech.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C18 RID: 101400 RVA: 0x00700C84 File Offset: 0x006FEE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			TrainingTech trainingTech = (TrainingTech)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			trainingTech.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C19 RID: 101401 RVA: 0x00700CDC File Offset: 0x006FEEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			TrainingTech trainingTech = (TrainingTech)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTech.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C1A RID: 101402 RVA: 0x00700D30 File Offset: 0x006FEF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingTech trainingTech = (TrainingTech)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingTech.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C1B RID: 101403 RVA: 0x00700D84 File Offset: 0x006FEF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingTech trainingTech = (TrainingTech)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			trainingTech.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018C1C RID: 101404 RVA: 0x00700DDC File Offset: 0x006FEFDC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TrainingTech");
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.UpdateInstantiatedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.ToPro);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.FromDataSection_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache2);
		string name = "ConfigId";
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.get_ConfigId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.set_ConfigId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache4, true);
		string name2 = "Infos";
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.get_Infos);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache5, null, true);
		string name3 = "Level";
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.get_Level);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.set_Level);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache7, true);
		string name4 = "Config";
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.get_Config);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache8, null, true);
		string name5 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.get_ConfigDataLoader);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name5, get3, Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cacheA, true);
		if (Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingTech.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TrainingTech.<>f__mg$cacheB, typeof(TrainingTech));
	}

	// Token: 0x0400F0D6 RID: 61654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F0D7 RID: 61655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F0D8 RID: 61656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F0D9 RID: 61657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F0DA RID: 61658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F0DB RID: 61659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F0DC RID: 61660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F0DD RID: 61661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F0DE RID: 61662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F0DF RID: 61663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F0E0 RID: 61664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F0E1 RID: 61665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
