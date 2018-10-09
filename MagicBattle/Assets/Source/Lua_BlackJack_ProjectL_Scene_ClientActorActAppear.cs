using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012F2 RID: 4850
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActAppear : LuaObject
{
	// Token: 0x0601A1B2 RID: 106930 RVA: 0x007ACAA4 File Offset: 0x007AACA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAppear o = new ClientActorActAppear();
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

	// Token: 0x0601A1B3 RID: 106931 RVA: 0x007ACAEC File Offset: 0x007AACEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_effectType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAppear clientActorActAppear = (ClientActorActAppear)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActAppear.m_effectType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1B4 RID: 106932 RVA: 0x007ACB40 File Offset: 0x007AAD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_effectType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAppear clientActorActAppear = (ClientActorActAppear)LuaObject.checkSelf(l);
			int effectType;
			LuaObject.checkType(l, 2, out effectType);
			clientActorActAppear.m_effectType = effectType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1B5 RID: 106933 RVA: 0x007ACB98 File Offset: 0x007AAD98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAppear clientActorActAppear = (ClientActorActAppear)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActAppear.m_fxName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1B6 RID: 106934 RVA: 0x007ACBEC File Offset: 0x007AADEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAppear clientActorActAppear = (ClientActorActAppear)LuaObject.checkSelf(l);
			string fxName;
			LuaObject.checkType(l, 2, out fxName);
			clientActorActAppear.m_fxName = fxName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1B7 RID: 106935 RVA: 0x007ACC44 File Offset: 0x007AAE44
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActAppear");
		string name = "m_effectType";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.get_m_effectType);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.set_m_effectType);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache1, true);
		string name2 = "m_fxName";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.get_m_fxName);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.set_m_fxName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActAppear.<>f__mg$cache4, typeof(ClientActorActAppear), typeof(ClientActorAct));
	}

	// Token: 0x040105B0 RID: 66992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105B1 RID: 66993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105B2 RID: 66994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040105B3 RID: 66995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040105B4 RID: 66996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
