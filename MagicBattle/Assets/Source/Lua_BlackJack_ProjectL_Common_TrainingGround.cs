using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200128B RID: 4747
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TrainingGround : LuaObject
{
	// Token: 0x06018BBD RID: 101309 RVA: 0x006FE234 File Offset: 0x006FC434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround o = new TrainingGround();
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

	// Token: 0x06018BBE RID: 101310 RVA: 0x006FE27C File Offset: 0x006FC47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReloadConfigData(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			trainingGround.ReloadConfigData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BBF RID: 101311 RVA: 0x006FE2C8 File Offset: 0x006FC4C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateInstantiatedData(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			List<TrainingTech> availableTechs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out availableTechs);
			trainingGround.UpdateInstantiatedData(availableTechs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BC0 RID: 101312 RVA: 0x006FE320 File Offset: 0x006FC520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRoom(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			TrainingRoom room = trainingGround.GetRoom(roomId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, room);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BC1 RID: 101313 RVA: 0x006FE384 File Offset: 0x006FC584
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLearntTech(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			TrainingTech learntTech = trainingGround.GetLearntTech(techId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, learntTech);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BC2 RID: 101314 RVA: 0x006FE3E8 File Offset: 0x006FC5E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetUnlearntTech(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			TrainingTech unlearntTech = trainingGround.GetUnlearntTech(techId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unlearntTech);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BC3 RID: 101315 RVA: 0x006FE44C File Offset: 0x006FC64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAvailableTechs(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			List<TrainingTech> availableTechs = trainingGround.GetAvailableTechs();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, availableTechs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BC4 RID: 101316 RVA: 0x006FE4A0 File Offset: 0x006FC6A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IterateAvailableTechs(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			IEnumerable<TrainingTech> o = trainingGround.IterateAvailableTechs();
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

	// Token: 0x06018BC5 RID: 101317 RVA: 0x006FE4F4 File Offset: 0x006FC6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddNewLearntTech(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			TrainingTech tech;
			LuaObject.checkType<TrainingTech>(l, 2, out tech);
			trainingGround.AddNewLearntTech(tech);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BC6 RID: 101318 RVA: 0x006FE54C File Offset: 0x006FC74C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IterateAvailableTechInfos(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround tg = (TrainingGround)LuaObject.checkSelf(l);
			IEnumerable<TrainingTechInfo> o = tg.IterateAvailableTechInfos();
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

	// Token: 0x06018BC7 RID: 101319 RVA: 0x006FE5A0 File Offset: 0x006FC7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTechLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround tg = (TrainingGround)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int techLevel = tg.GetTechLevel(techId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, techLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BC8 RID: 101320 RVA: 0x006FE604 File Offset: 0x006FC804
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTechLevelBySoldierId(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround tg = (TrainingGround)LuaObject.checkSelf(l);
			int soldierId;
			LuaObject.checkType(l, 2, out soldierId);
			int techLevelBySoldierId = tg.GetTechLevelBySoldierId(soldierId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, techLevelBySoldierId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BC9 RID: 101321 RVA: 0x006FE668 File Offset: 0x006FC868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsAnikiGymLevelCleared(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			AnikiGymLevelClearCheck anikiGymLevelClearCheck;
			int num = LuaObject.checkDelegate<AnikiGymLevelClearCheck>(l, 2, out anikiGymLevelClearCheck);
			if (num == 0)
			{
				trainingGround.IsAnikiGymLevelCleared = anikiGymLevelClearCheck;
			}
			else if (num == 1)
			{
				TrainingGround trainingGround2 = trainingGround;
				trainingGround2.IsAnikiGymLevelCleared = (AnikiGymLevelClearCheck)Delegate.Combine(trainingGround2.IsAnikiGymLevelCleared, anikiGymLevelClearCheck);
			}
			else if (num == 2)
			{
				TrainingGround trainingGround3 = trainingGround;
				trainingGround3.IsAnikiGymLevelCleared = (AnikiGymLevelClearCheck)Delegate.Remove(trainingGround3.IsAnikiGymLevelCleared, anikiGymLevelClearCheck);
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

	// Token: 0x06018BCA RID: 101322 RVA: 0x006FE710 File Offset: 0x006FC910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rooms(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingGround.Rooms);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BCB RID: 101323 RVA: 0x006FE764 File Offset: 0x006FC964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Rooms(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			List<TrainingRoom> rooms;
			LuaObject.checkType<List<TrainingRoom>>(l, 2, out rooms);
			trainingGround.Rooms = rooms;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BCC RID: 101324 RVA: 0x006FE7BC File Offset: 0x006FC9BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingGround.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BCD RID: 101325 RVA: 0x006FE810 File Offset: 0x006FCA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingGround trainingGround = (TrainingGround)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			trainingGround.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BCE RID: 101326 RVA: 0x006FE868 File Offset: 0x006FCA68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TrainingGround");
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.ReloadConfigData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.UpdateInstantiatedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.GetRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.GetLearntTech);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.GetUnlearntTech);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.GetAvailableTechs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.IterateAvailableTechs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.AddNewLearntTech);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.IterateAvailableTechInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.GetTechLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.GetTechLevelBySoldierId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheA);
		string name = "IsAnikiGymLevelCleared";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.set_IsAnikiGymLevelCleared);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheB, true);
		string name2 = "Rooms";
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.get_Rooms);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.set_Rooms);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheD, true);
		string name3 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.get_ConfigDataLoader);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGround.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TrainingGround.<>f__mg$cache10, typeof(TrainingGround));
	}

	// Token: 0x0400F089 RID: 61577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F08A RID: 61578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F08B RID: 61579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F08C RID: 61580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F08D RID: 61581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F08E RID: 61582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F08F RID: 61583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F090 RID: 61584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F091 RID: 61585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F092 RID: 61586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F093 RID: 61587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F094 RID: 61588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F095 RID: 61589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F096 RID: 61590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F097 RID: 61591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F098 RID: 61592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F099 RID: 61593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
