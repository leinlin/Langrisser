using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012FC RID: 4860
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear : LuaObject
{
	// Token: 0x0601A1FC RID: 107004 RVA: 0x007AE5B8 File Offset: 0x007AC7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDisappear o = new ClientActorActDisappear();
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

	// Token: 0x0601A1FD RID: 107005 RVA: 0x007AE600 File Offset: 0x007AC800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_effectType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDisappear clientActorActDisappear = (ClientActorActDisappear)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActDisappear.m_effectType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1FE RID: 107006 RVA: 0x007AE654 File Offset: 0x007AC854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_effectType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDisappear clientActorActDisappear = (ClientActorActDisappear)LuaObject.checkSelf(l);
			int effectType;
			LuaObject.checkType(l, 2, out effectType);
			clientActorActDisappear.m_effectType = effectType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1FF RID: 107007 RVA: 0x007AE6AC File Offset: 0x007AC8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDisappear clientActorActDisappear = (ClientActorActDisappear)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActDisappear.m_fxName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A200 RID: 107008 RVA: 0x007AE700 File Offset: 0x007AC900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDisappear clientActorActDisappear = (ClientActorActDisappear)LuaObject.checkSelf(l);
			string fxName;
			LuaObject.checkType(l, 2, out fxName);
			clientActorActDisappear.m_fxName = fxName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A201 RID: 107009 RVA: 0x007AE758 File Offset: 0x007AC958
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActDisappear");
		string name = "m_effectType";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.get_m_effectType);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.set_m_effectType);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache1, true);
		string name2 = "m_fxName";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.get_m_fxName);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.set_m_fxName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActDisappear.<>f__mg$cache4, typeof(ClientActorActDisappear), typeof(ClientActorAct));
	}

	// Token: 0x040105E6 RID: 67046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105E7 RID: 67047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105E8 RID: 67048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040105E9 RID: 67049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040105EA RID: 67050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
