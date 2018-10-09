using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012F1 RID: 4849
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActActive : LuaObject
{
	// Token: 0x0601A1AD RID: 106925 RVA: 0x007AC910 File Offset: 0x007AAB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActActive o = new ClientActorActActive();
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

	// Token: 0x0601A1AE RID: 106926 RVA: 0x007AC958 File Offset: 0x007AAB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_newStep(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActActive clientActorActActive = (ClientActorActActive)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActActive.m_newStep);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1AF RID: 106927 RVA: 0x007AC9AC File Offset: 0x007AABAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_newStep(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActActive clientActorActActive = (ClientActorActActive)LuaObject.checkSelf(l);
			bool newStep;
			LuaObject.checkType(l, 2, out newStep);
			clientActorActActive.m_newStep = newStep;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1B0 RID: 106928 RVA: 0x007ACA04 File Offset: 0x007AAC04
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActActive");
		string name = "m_newStep";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActActive.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActActive.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActActive.get_m_newStep);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActActive.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActActive.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActActive.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActActive.set_m_newStep);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActActive.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActActive.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActActive.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActActive.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActActive.<>f__mg$cache2, typeof(ClientActorActActive), typeof(ClientActorAct));
	}

	// Token: 0x040105AD RID: 66989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105AE RID: 66990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105AF RID: 66991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
