using System;
using System.Runtime.CompilerServices;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015F3 RID: 5619
[Preserve]
public class Lua_BlackJack_UtilityTools_HeadIconTools : LuaObject
{
	// Token: 0x060227D4 RID: 141268 RVA: 0x00BD3890 File Offset: 0x00BD1A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeadIconTools o = new HeadIconTools();
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

	// Token: 0x060227D5 RID: 141269 RVA: 0x00BD38D8 File Offset: 0x00BD1AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeadPortrait_s(IntPtr l)
	{
		int result;
		try
		{
			int headIcon;
			LuaObject.checkType(l, 1, out headIcon);
			int headPortrait = HeadIconTools.GetHeadPortrait(headIcon);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, headPortrait);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227D6 RID: 141270 RVA: 0x00BD392C File Offset: 0x00BD1B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeadFrame_s(IntPtr l)
	{
		int result;
		try
		{
			int headIcon;
			LuaObject.checkType(l, 1, out headIcon);
			int headFrame = HeadIconTools.GetHeadFrame(headIcon);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, headFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227D7 RID: 141271 RVA: 0x00BD3980 File Offset: 0x00BD1B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeadIcon_s(IntPtr l)
	{
		int result;
		try
		{
			int headPortraitId;
			LuaObject.checkType(l, 1, out headPortraitId);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			int headIcon = HeadIconTools.GetHeadIcon(headPortraitId, headFrameId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, headIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227D8 RID: 141272 RVA: 0x00BD39E0 File Offset: 0x00BD1BE0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.UtilityTools.HeadIconTools");
		if (Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_UtilityTools_HeadIconTools.GetHeadPortrait_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache0);
		if (Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_UtilityTools_HeadIconTools.GetHeadFrame_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache1);
		if (Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_UtilityTools_HeadIconTools.GetHeadIcon_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache2);
		if (Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_UtilityTools_HeadIconTools.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_UtilityTools_HeadIconTools.<>f__mg$cache3, typeof(HeadIconTools));
	}

	// Token: 0x040185D0 RID: 99792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185D1 RID: 99793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185D2 RID: 99794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185D3 RID: 99795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
