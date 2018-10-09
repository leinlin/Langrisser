using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012FD RID: 4861
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove : LuaObject
{
	// Token: 0x0601A203 RID: 107011 RVA: 0x007AE83C File Offset: 0x007ACA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActExchangeMove o = new ClientActorActExchangeMove();
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

	// Token: 0x0601A204 RID: 107012 RVA: 0x007AE884 File Offset: 0x007ACA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActExchangeMove clientActorActExchangeMove = (ClientActorActExchangeMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActExchangeMove.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A205 RID: 107013 RVA: 0x007AE8DC File Offset: 0x007ACADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActExchangeMove clientActorActExchangeMove = (ClientActorActExchangeMove)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientActorActExchangeMove.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A206 RID: 107014 RVA: 0x007AE934 File Offset: 0x007ACB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActExchangeMove clientActorActExchangeMove = (ClientActorActExchangeMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActExchangeMove.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A207 RID: 107015 RVA: 0x007AE988 File Offset: 0x007ACB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActExchangeMove clientActorActExchangeMove = (ClientActorActExchangeMove)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientActorActExchangeMove.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A208 RID: 107016 RVA: 0x007AE9E0 File Offset: 0x007ACBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActExchangeMove clientActorActExchangeMove = (ClientActorActExchangeMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActExchangeMove.m_fxName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A209 RID: 107017 RVA: 0x007AEA34 File Offset: 0x007ACC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActExchangeMove clientActorActExchangeMove = (ClientActorActExchangeMove)LuaObject.checkSelf(l);
			string fxName;
			LuaObject.checkType(l, 2, out fxName);
			clientActorActExchangeMove.m_fxName = fxName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A20A RID: 107018 RVA: 0x007AEA8C File Offset: 0x007ACC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_moveType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActExchangeMove clientActorActExchangeMove = (ClientActorActExchangeMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActExchangeMove.m_moveType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A20B RID: 107019 RVA: 0x007AEAE0 File Offset: 0x007ACCE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_moveType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActExchangeMove clientActorActExchangeMove = (ClientActorActExchangeMove)LuaObject.checkSelf(l);
			int moveType;
			LuaObject.checkType(l, 2, out moveType);
			clientActorActExchangeMove.m_moveType = moveType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A20C RID: 107020 RVA: 0x007AEB38 File Offset: 0x007ACD38
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActExchangeMove");
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache1, true);
		string name2 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.get_m_direction);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.set_m_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache3, true);
		string name3 = "m_fxName";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.get_m_fxName);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.set_m_fxName);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache5, true);
		string name4 = "m_moveType";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.get_m_moveType);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.set_m_moveType);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActExchangeMove.<>f__mg$cache8, typeof(ClientActorActExchangeMove), typeof(ClientActorAct));
	}

	// Token: 0x040105EB RID: 67051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105EC RID: 67052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105ED RID: 67053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040105EE RID: 67054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040105EF RID: 67055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040105F0 RID: 67056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040105F1 RID: 67057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040105F2 RID: 67058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040105F3 RID: 67059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
