using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200123F RID: 4671
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroDungeonLevel : LuaObject
{
	// Token: 0x0601847F RID: 99455 RVA: 0x006C86A4 File Offset: 0x006C68A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevel o = new HeroDungeonLevel();
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

	// Token: 0x06018480 RID: 99456 RVA: 0x006C86EC File Offset: 0x006C68EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPBLevel_s(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevel level;
			LuaObject.checkType<HeroDungeonLevel>(l, 1, out level);
			ProHeroDungeonLevel o = HeroDungeonLevel.ToPBLevel(level);
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

	// Token: 0x06018481 RID: 99457 RVA: 0x006C8740 File Offset: 0x006C6940
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LevelId(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevel heroDungeonLevel = (HeroDungeonLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevel.LevelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018482 RID: 99458 RVA: 0x006C8794 File Offset: 0x006C6994
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LevelId(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevel heroDungeonLevel = (HeroDungeonLevel)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			heroDungeonLevel.LevelId = levelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018483 RID: 99459 RVA: 0x006C87EC File Offset: 0x006C69EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Stars(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevel heroDungeonLevel = (HeroDungeonLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevel.Stars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018484 RID: 99460 RVA: 0x006C8840 File Offset: 0x006C6A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Stars(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevel heroDungeonLevel = (HeroDungeonLevel)LuaObject.checkSelf(l);
			int stars;
			LuaObject.checkType(l, 2, out stars);
			heroDungeonLevel.Stars = stars;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018485 RID: 99461 RVA: 0x006C8898 File Offset: 0x006C6A98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Nums(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevel heroDungeonLevel = (HeroDungeonLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonLevel.Nums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018486 RID: 99462 RVA: 0x006C88EC File Offset: 0x006C6AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Nums(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonLevel heroDungeonLevel = (HeroDungeonLevel)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			heroDungeonLevel.Nums = nums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018487 RID: 99463 RVA: 0x006C8944 File Offset: 0x006C6B44
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroDungeonLevel");
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.ToPBLevel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache0);
		string name = "LevelId";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.get_LevelId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.set_LevelId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache2, true);
		string name2 = "Stars";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.get_Stars);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.set_Stars);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache4, true);
		string name3 = "Nums";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.get_Nums);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.set_Nums);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroDungeonLevel.<>f__mg$cache7, typeof(HeroDungeonLevel));
	}

	// Token: 0x0400E9E3 RID: 59875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E9E4 RID: 59876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E9E5 RID: 59877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E9E6 RID: 59878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E9E7 RID: 59879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E9E8 RID: 59880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E9E9 RID: 59881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E9EA RID: 59882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
