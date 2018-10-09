using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001306 RID: 4870
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove : LuaObject
{
	// Token: 0x0601A244 RID: 107076 RVA: 0x007AFFE4 File Offset: 0x007AE1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPunchMove o = new ClientActorActPunchMove();
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

	// Token: 0x0601A245 RID: 107077 RVA: 0x007B002C File Offset: 0x007AE22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPunchMove clientActorActPunchMove = (ClientActorActPunchMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPunchMove.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A246 RID: 107078 RVA: 0x007B0084 File Offset: 0x007AE284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPunchMove clientActorActPunchMove = (ClientActorActPunchMove)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientActorActPunchMove.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A247 RID: 107079 RVA: 0x007B00DC File Offset: 0x007AE2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPunchMove clientActorActPunchMove = (ClientActorActPunchMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPunchMove.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A248 RID: 107080 RVA: 0x007B0130 File Offset: 0x007AE330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPunchMove clientActorActPunchMove = (ClientActorActPunchMove)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientActorActPunchMove.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A249 RID: 107081 RVA: 0x007B0188 File Offset: 0x007AE388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPunchMove clientActorActPunchMove = (ClientActorActPunchMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPunchMove.m_fxName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A24A RID: 107082 RVA: 0x007B01DC File Offset: 0x007AE3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPunchMove clientActorActPunchMove = (ClientActorActPunchMove)LuaObject.checkSelf(l);
			string fxName;
			LuaObject.checkType(l, 2, out fxName);
			clientActorActPunchMove.m_fxName = fxName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A24B RID: 107083 RVA: 0x007B0234 File Offset: 0x007AE434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDragExchange(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPunchMove clientActorActPunchMove = (ClientActorActPunchMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActPunchMove.m_isDragExchange);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A24C RID: 107084 RVA: 0x007B0288 File Offset: 0x007AE488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDragExchange(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActPunchMove clientActorActPunchMove = (ClientActorActPunchMove)LuaObject.checkSelf(l);
			bool isDragExchange;
			LuaObject.checkType(l, 2, out isDragExchange);
			clientActorActPunchMove.m_isDragExchange = isDragExchange;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A24D RID: 107085 RVA: 0x007B02E0 File Offset: 0x007AE4E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActPunchMove");
		string name = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.get_m_position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.set_m_position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache1, true);
		string name2 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.get_m_direction);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.set_m_direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache3, true);
		string name3 = "m_fxName";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.get_m_fxName);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.set_m_fxName);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache5, true);
		string name4 = "m_isDragExchange";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.get_m_isDragExchange);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.set_m_isDragExchange);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActPunchMove.<>f__mg$cache8, typeof(ClientActorActPunchMove), typeof(ClientActorAct));
	}

	// Token: 0x0401061A RID: 67098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401061B RID: 67099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401061C RID: 67100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401061D RID: 67101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401061E RID: 67102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401061F RID: 67103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010620 RID: 67104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010621 RID: 67105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010622 RID: 67106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
