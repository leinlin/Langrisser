using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001278 RID: 4728
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo : LuaObject
{
	// Token: 0x06018A57 RID: 100951 RVA: 0x006F4200 File Offset: 0x006F2400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnLockInfo o = new RiftLevelUnLockInfo();
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

	// Token: 0x06018A58 RID: 100952 RVA: 0x006F4248 File Offset: 0x006F2448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FinishedRiftLevelIds(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnLockInfo riftLevelUnLockInfo = (RiftLevelUnLockInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUnLockInfo.FinishedRiftLevelIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A59 RID: 100953 RVA: 0x006F429C File Offset: 0x006F249C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FinishedRiftLevelIds(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnLockInfo riftLevelUnLockInfo = (RiftLevelUnLockInfo)LuaObject.checkSelf(l);
			HashSet<int> finishedRiftLevelIds;
			LuaObject.checkType<HashSet<int>>(l, 2, out finishedRiftLevelIds);
			riftLevelUnLockInfo.FinishedRiftLevelIds = finishedRiftLevelIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A5A RID: 100954 RVA: 0x006F42F4 File Offset: 0x006F24F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GainRiftAchievementRelationIds(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnLockInfo riftLevelUnLockInfo = (RiftLevelUnLockInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUnLockInfo.GainRiftAchievementRelationIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A5B RID: 100955 RVA: 0x006F4348 File Offset: 0x006F2548
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GainRiftAchievementRelationIds(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnLockInfo riftLevelUnLockInfo = (RiftLevelUnLockInfo)LuaObject.checkSelf(l);
			HashSet<int> gainRiftAchievementRelationIds;
			LuaObject.checkType<HashSet<int>>(l, 2, out gainRiftAchievementRelationIds);
			riftLevelUnLockInfo.GainRiftAchievementRelationIds = gainRiftAchievementRelationIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A5C RID: 100956 RVA: 0x006F43A0 File Offset: 0x006F25A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GainHeroIds(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnLockInfo riftLevelUnLockInfo = (RiftLevelUnLockInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelUnLockInfo.GainHeroIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A5D RID: 100957 RVA: 0x006F43F4 File Offset: 0x006F25F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GainHeroIds(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelUnLockInfo riftLevelUnLockInfo = (RiftLevelUnLockInfo)LuaObject.checkSelf(l);
			HashSet<int> gainHeroIds;
			LuaObject.checkType<HashSet<int>>(l, 2, out gainHeroIds);
			riftLevelUnLockInfo.GainHeroIds = gainHeroIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A5E RID: 100958 RVA: 0x006F444C File Offset: 0x006F264C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RiftLevelUnLockInfo");
		string name = "FinishedRiftLevelIds";
		if (Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.get_FinishedRiftLevelIds);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.set_FinishedRiftLevelIds);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache1, true);
		string name2 = "GainRiftAchievementRelationIds";
		if (Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.get_GainRiftAchievementRelationIds);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.set_GainRiftAchievementRelationIds);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache3, true);
		string name3 = "GainHeroIds";
		if (Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.get_GainHeroIds);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.set_GainHeroIds);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RiftLevelUnLockInfo.<>f__mg$cache6, typeof(RiftLevelUnLockInfo));
	}

	// Token: 0x0400EF49 RID: 61257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EF4A RID: 61258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EF4B RID: 61259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EF4C RID: 61260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EF4D RID: 61261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EF4E RID: 61262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EF4F RID: 61263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
