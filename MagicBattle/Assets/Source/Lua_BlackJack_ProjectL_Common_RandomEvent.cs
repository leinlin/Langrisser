using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001263 RID: 4707
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RandomEvent : LuaObject
{
	// Token: 0x060188B5 RID: 100533 RVA: 0x006E859C File Offset: 0x006E679C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent o = new RandomEvent();
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

	// Token: 0x060188B6 RID: 100534 RVA: 0x006E85E4 File Offset: 0x006E67E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RandomEventToPBRandomEvent_s(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent;
			LuaObject.checkType<RandomEvent>(l, 1, out randomEvent);
			ProRandomEvent o = RandomEvent.RandomEventToPBRandomEvent(randomEvent);
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

	// Token: 0x060188B7 RID: 100535 RVA: 0x006E8638 File Offset: 0x006E6838
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RandomEventsToPBRandomEvents_s(IntPtr l)
	{
		int result;
		try
		{
			List<RandomEvent> randomEvents;
			LuaObject.checkType<List<RandomEvent>>(l, 1, out randomEvents);
			List<ProRandomEvent> o = RandomEvent.RandomEventsToPBRandomEvents(randomEvents);
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

	// Token: 0x060188B8 RID: 100536 RVA: 0x006E868C File Offset: 0x006E688C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBRandomEventToRandomEvent_s(IntPtr l)
	{
		int result;
		try
		{
			ProRandomEvent pbRadomEvent;
			LuaObject.checkType<ProRandomEvent>(l, 1, out pbRadomEvent);
			RandomEvent o = RandomEvent.PBRandomEventToRandomEvent(pbRadomEvent);
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

	// Token: 0x060188B9 RID: 100537 RVA: 0x006E86E0 File Offset: 0x006E68E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBRandomEventsToRandomEvents_s(IntPtr l)
	{
		int result;
		try
		{
			List<ProRandomEvent> pbRadomEvents;
			LuaObject.checkType<List<ProRandomEvent>>(l, 1, out pbRadomEvents);
			List<RandomEvent> o = RandomEvent.PBRandomEventsToRandomEvents(pbRadomEvents);
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

	// Token: 0x060188BA RID: 100538 RVA: 0x006E8734 File Offset: 0x006E6934
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EventId(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent = (RandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomEvent.EventId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188BB RID: 100539 RVA: 0x006E8788 File Offset: 0x006E6988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventId(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent = (RandomEvent)LuaObject.checkSelf(l);
			int eventId;
			LuaObject.checkType(l, 2, out eventId);
			randomEvent.EventId = eventId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188BC RID: 100540 RVA: 0x006E87E0 File Offset: 0x006E69E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WayPointId(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent = (RandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomEvent.WayPointId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188BD RID: 100541 RVA: 0x006E8834 File Offset: 0x006E6A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WayPointId(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent = (RandomEvent)LuaObject.checkSelf(l);
			int wayPointId;
			LuaObject.checkType(l, 2, out wayPointId);
			randomEvent.WayPointId = wayPointId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188BE RID: 100542 RVA: 0x006E888C File Offset: 0x006E6A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Lives(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent = (RandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomEvent.Lives);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188BF RID: 100543 RVA: 0x006E88E0 File Offset: 0x006E6AE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Lives(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent = (RandomEvent)LuaObject.checkSelf(l);
			int lives;
			LuaObject.checkType(l, 2, out lives);
			randomEvent.Lives = lives;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188C0 RID: 100544 RVA: 0x006E8938 File Offset: 0x006E6B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DeadLives(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent = (RandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomEvent.DeadLives);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188C1 RID: 100545 RVA: 0x006E898C File Offset: 0x006E6B8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DeadLives(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent = (RandomEvent)LuaObject.checkSelf(l);
			int deadLives;
			LuaObject.checkType(l, 2, out deadLives);
			randomEvent.DeadLives = deadLives;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188C2 RID: 100546 RVA: 0x006E89E4 File Offset: 0x006E6BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent = (RandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomEvent.ExpiredTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188C3 RID: 100547 RVA: 0x006E8A38 File Offset: 0x006E6C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			RandomEvent randomEvent = (RandomEvent)LuaObject.checkSelf(l);
			long expiredTime;
			LuaObject.checkType(l, 2, out expiredTime);
			randomEvent.ExpiredTime = expiredTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188C4 RID: 100548 RVA: 0x006E8A90 File Offset: 0x006E6C90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RandomEvent");
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.RandomEventToPBRandomEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.RandomEventsToPBRandomEvents_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.PBRandomEventToRandomEvent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.PBRandomEventsToRandomEvents_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache3);
		string name = "EventId";
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.get_EventId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.set_EventId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache5, true);
		string name2 = "WayPointId";
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.get_WayPointId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.set_WayPointId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache7, true);
		string name3 = "Lives";
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.get_Lives);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.set_Lives);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cache9, true);
		string name4 = "DeadLives";
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.get_DeadLives);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.set_DeadLives);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheB, true);
		string name5 = "ExpiredTime";
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.get_ExpiredTime);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.set_ExpiredTime);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheD, true);
		if (Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RandomEvent.<>f__mg$cacheE, typeof(RandomEvent));
	}

	// Token: 0x0400EDD1 RID: 60881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EDD2 RID: 60882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EDD3 RID: 60883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EDD4 RID: 60884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EDD5 RID: 60885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EDD6 RID: 60886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EDD7 RID: 60887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EDD8 RID: 60888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EDD9 RID: 60889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EDDA RID: 60890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EDDB RID: 60891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EDDC RID: 60892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EDDD RID: 60893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EDDE RID: 60894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EDDF RID: 60895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
