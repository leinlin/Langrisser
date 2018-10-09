using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001277 RID: 4727
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RiftLevel : LuaObject
{
	// Token: 0x06018A4C RID: 100940 RVA: 0x006F3D7C File Offset: 0x006F1F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			int stars;
			LuaObject.checkType(l, 4, out stars);
			RiftLevel o = new RiftLevel(levelId, nums, stars);
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

	// Token: 0x06018A4D RID: 100941 RVA: 0x006F3DEC File Offset: 0x006F1FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBRiftLevelToRiftLevel_s(IntPtr l)
	{
		int result;
		try
		{
			ProRiftLevel pbRiftLevel;
			LuaObject.checkType<ProRiftLevel>(l, 1, out pbRiftLevel);
			RiftLevel o = RiftLevel.PBRiftLevelToRiftLevel(pbRiftLevel);
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

	// Token: 0x06018A4E RID: 100942 RVA: 0x006F3E40 File Offset: 0x006F2040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RiftLevelToPBRiftLevel_s(IntPtr l)
	{
		int result;
		try
		{
			RiftLevel riftLevel;
			LuaObject.checkType<RiftLevel>(l, 1, out riftLevel);
			ProRiftLevel o = RiftLevel.RiftLevelToPBRiftLevel(riftLevel);
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

	// Token: 0x06018A4F RID: 100943 RVA: 0x006F3E94 File Offset: 0x006F2094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelId(IntPtr l)
	{
		int result;
		try
		{
			RiftLevel riftLevel = (RiftLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevel.LevelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A50 RID: 100944 RVA: 0x006F3EE8 File Offset: 0x006F20E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LevelId(IntPtr l)
	{
		int result;
		try
		{
			RiftLevel riftLevel = (RiftLevel)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			riftLevel.LevelId = levelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A51 RID: 100945 RVA: 0x006F3F40 File Offset: 0x006F2140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Nums(IntPtr l)
	{
		int result;
		try
		{
			RiftLevel riftLevel = (RiftLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevel.Nums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A52 RID: 100946 RVA: 0x006F3F94 File Offset: 0x006F2194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Nums(IntPtr l)
	{
		int result;
		try
		{
			RiftLevel riftLevel = (RiftLevel)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			riftLevel.Nums = nums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A53 RID: 100947 RVA: 0x006F3FEC File Offset: 0x006F21EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Stars(IntPtr l)
	{
		int result;
		try
		{
			RiftLevel riftLevel = (RiftLevel)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevel.Stars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A54 RID: 100948 RVA: 0x006F4040 File Offset: 0x006F2240
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Stars(IntPtr l)
	{
		int result;
		try
		{
			RiftLevel riftLevel = (RiftLevel)LuaObject.checkSelf(l);
			int stars;
			LuaObject.checkType(l, 2, out stars);
			riftLevel.Stars = stars;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A55 RID: 100949 RVA: 0x006F4098 File Offset: 0x006F2298
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RiftLevel");
		if (Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevel.PBRiftLevelToRiftLevel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevel.RiftLevelToPBRiftLevel_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache1);
		string name = "LevelId";
		if (Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevel.get_LevelId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevel.set_LevelId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache3, true);
		string name2 = "Nums";
		if (Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevel.get_Nums);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevel.set_Nums);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache5, true);
		string name3 = "Stars";
		if (Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevel.get_Stars);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevel.set_Stars);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftLevel.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RiftLevel.<>f__mg$cache8, typeof(RiftLevel));
	}

	// Token: 0x0400EF40 RID: 61248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EF41 RID: 61249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EF42 RID: 61250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EF43 RID: 61251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EF44 RID: 61252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EF45 RID: 61253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EF46 RID: 61254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EF47 RID: 61255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EF48 RID: 61256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
