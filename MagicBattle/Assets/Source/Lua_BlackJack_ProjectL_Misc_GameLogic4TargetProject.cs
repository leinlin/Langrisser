using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.PlayerContext;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012A1 RID: 4769
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject : LuaObject
{
	// Token: 0x06019045 RID: 102469 RVA: 0x0071E8A0 File Offset: 0x0071CAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GameLogic4TargetProject o = new GameLogic4TargetProject();
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

	// Token: 0x06019046 RID: 102470 RVA: 0x0071E8E8 File Offset: 0x0071CAE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnInitialize(IntPtr l)
	{
		int result;
		try
		{
			GameLogic4TargetProject gameLogic4TargetProject = (GameLogic4TargetProject)LuaObject.checkSelf(l);
			gameLogic4TargetProject.OnInitialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019047 RID: 102471 RVA: 0x0071E934 File Offset: 0x0071CB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnApplicationQuit(IntPtr l)
	{
		int result;
		try
		{
			GameLogic4TargetProject gameLogic4TargetProject = (GameLogic4TargetProject)LuaObject.checkSelf(l);
			gameLogic4TargetProject.OnApplicationQuit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019048 RID: 102472 RVA: 0x0071E980 File Offset: 0x0071CB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateNetWorkClient(IntPtr l)
	{
		int result;
		try
		{
			GameLogic4TargetProject gameLogic4TargetProject = (GameLogic4TargetProject)LuaObject.checkSelf(l);
			IPlayerContextNetworkClient o = gameLogic4TargetProject.CreateNetWorkClient();
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

	// Token: 0x06019049 RID: 102473 RVA: 0x0071E9D4 File Offset: 0x0071CBD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.GameLogic4TargetProject");
		if (Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.OnInitialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.OnApplicationQuit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.CreateNetWorkClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_GameLogic4TargetProject.<>f__mg$cache3, typeof(GameLogic4TargetProject));
	}

	// Token: 0x0400F4E5 RID: 62693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F4E6 RID: 62694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F4E7 RID: 62695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F4E8 RID: 62696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
