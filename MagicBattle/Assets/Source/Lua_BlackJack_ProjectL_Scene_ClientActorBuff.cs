using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001315 RID: 4885
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorBuff : LuaObject
{
	// Token: 0x0601A2C9 RID: 107209 RVA: 0x007B330C File Offset: 0x007B150C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorBuff o = new ClientActorBuff();
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

	// Token: 0x0601A2CA RID: 107210 RVA: 0x007B3354 File Offset: 0x007B1554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorBuff clientActorBuff = (ClientActorBuff)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorBuff.m_buffState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2CB RID: 107211 RVA: 0x007B33A8 File Offset: 0x007B15A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorBuff clientActorBuff = (ClientActorBuff)LuaObject.checkSelf(l);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 2, out buffState);
			clientActorBuff.m_buffState = buffState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2CC RID: 107212 RVA: 0x007B3400 File Offset: 0x007B1600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fx(IntPtr l)
	{
		int result;
		try
		{
			ClientActorBuff clientActorBuff = (ClientActorBuff)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorBuff.m_fx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2CD RID: 107213 RVA: 0x007B3454 File Offset: 0x007B1654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fx(IntPtr l)
	{
		int result;
		try
		{
			ClientActorBuff clientActorBuff = (ClientActorBuff)LuaObject.checkSelf(l);
			GenericGraphic fx;
			LuaObject.checkType<GenericGraphic>(l, 2, out fx);
			clientActorBuff.m_fx = fx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2CE RID: 107214 RVA: 0x007B34AC File Offset: 0x007B16AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorBuff");
		string name = "m_buffState";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorBuff.get_m_buffState);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorBuff.set_m_buffState);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache1, true);
		string name2 = "m_fx";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorBuff.get_m_fx);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorBuff.set_m_fx);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorBuff.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorBuff.<>f__mg$cache4, typeof(ClientActorBuff));
	}

	// Token: 0x04010681 RID: 67201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010682 RID: 67202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010683 RID: 67203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010684 RID: 67204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010685 RID: 67205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
