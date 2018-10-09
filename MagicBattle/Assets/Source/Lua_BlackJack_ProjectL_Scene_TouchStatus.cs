using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001349 RID: 4937
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_TouchStatus : LuaObject
{
	// Token: 0x0601A842 RID: 108610 RVA: 0x007DD178 File Offset: 0x007DB378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TouchStatus o = new TouchStatus();
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

	// Token: 0x0601A843 RID: 108611 RVA: 0x007DD1C0 File Offset: 0x007DB3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_beginPosition(IntPtr l)
	{
		int result;
		try
		{
			TouchStatus touchStatus = (TouchStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchStatus.m_beginPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A844 RID: 108612 RVA: 0x007DD214 File Offset: 0x007DB414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_beginPosition(IntPtr l)
	{
		int result;
		try
		{
			TouchStatus touchStatus = (TouchStatus)LuaObject.checkSelf(l);
			Vector2 beginPosition;
			LuaObject.checkType(l, 2, out beginPosition);
			touchStatus.m_beginPosition = beginPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A845 RID: 108613 RVA: 0x007DD26C File Offset: 0x007DB46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentPosition(IntPtr l)
	{
		int result;
		try
		{
			TouchStatus touchStatus = (TouchStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchStatus.m_currentPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A846 RID: 108614 RVA: 0x007DD2C0 File Offset: 0x007DB4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentPosition(IntPtr l)
	{
		int result;
		try
		{
			TouchStatus touchStatus = (TouchStatus)LuaObject.checkSelf(l);
			Vector2 currentPosition;
			LuaObject.checkType(l, 2, out currentPosition);
			touchStatus.m_currentPosition = currentPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A847 RID: 108615 RVA: 0x007DD318 File Offset: 0x007DB518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prevPosition(IntPtr l)
	{
		int result;
		try
		{
			TouchStatus touchStatus = (TouchStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchStatus.m_prevPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A848 RID: 108616 RVA: 0x007DD36C File Offset: 0x007DB56C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prevPosition(IntPtr l)
	{
		int result;
		try
		{
			TouchStatus touchStatus = (TouchStatus)LuaObject.checkSelf(l);
			Vector2 prevPosition;
			LuaObject.checkType(l, 2, out prevPosition);
			touchStatus.m_prevPosition = prevPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A849 RID: 108617 RVA: 0x007DD3C4 File Offset: 0x007DB5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pressed(IntPtr l)
	{
		int result;
		try
		{
			TouchStatus touchStatus = (TouchStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchStatus.m_pressed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A84A RID: 108618 RVA: 0x007DD418 File Offset: 0x007DB618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pressed(IntPtr l)
	{
		int result;
		try
		{
			TouchStatus touchStatus = (TouchStatus)LuaObject.checkSelf(l);
			bool pressed;
			LuaObject.checkType(l, 2, out pressed);
			touchStatus.m_pressed = pressed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A84B RID: 108619 RVA: 0x007DD470 File Offset: 0x007DB670
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.TouchStatus");
		string name = "m_beginPosition";
		if (Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_TouchStatus.get_m_beginPosition);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_TouchStatus.set_m_beginPosition);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache1, true);
		string name2 = "m_currentPosition";
		if (Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_TouchStatus.get_m_currentPosition);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_TouchStatus.set_m_currentPosition);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache3, true);
		string name3 = "m_prevPosition";
		if (Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_TouchStatus.get_m_prevPosition);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_TouchStatus.set_m_prevPosition);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache5, true);
		string name4 = "m_pressed";
		if (Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_TouchStatus.get_m_pressed);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_TouchStatus.set_m_pressed);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_TouchStatus.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_TouchStatus.<>f__mg$cache8, typeof(TouchStatus));
	}

	// Token: 0x04010B92 RID: 68498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010B93 RID: 68499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010B94 RID: 68500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010B95 RID: 68501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010B96 RID: 68502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010B97 RID: 68503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010B98 RID: 68504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010B99 RID: 68505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010B9A RID: 68506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
