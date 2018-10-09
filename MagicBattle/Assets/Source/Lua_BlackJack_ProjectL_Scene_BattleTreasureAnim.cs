using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012EC RID: 4844
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim : LuaObject
{
	// Token: 0x0601A186 RID: 106886 RVA: 0x007AB980 File Offset: 0x007A9B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleTreasureAnim o = new BattleTreasureAnim();
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

	// Token: 0x0601A187 RID: 106887 RVA: 0x007AB9C8 File Offset: 0x007A9BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Idle(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Standby");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A188 RID: 106888 RVA: 0x007ABA10 File Offset: 0x007A9C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Open(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Open");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A189 RID: 106889 RVA: 0x007ABA58 File Offset: 0x007A9C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Opened(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Opened");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A18A RID: 106890 RVA: 0x007ABAA0 File Offset: 0x007A9CA0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.BattleTreasureAnim");
		string name = "Idle";
		if (Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.get_Idle);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache0, null, false);
		string name2 = "Open";
		if (Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.get_Open);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache1, null, false);
		string name3 = "Opened";
		if (Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.get_Opened);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache2, null, false);
		if (Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_BattleTreasureAnim.<>f__mg$cache3, typeof(BattleTreasureAnim));
	}

	// Token: 0x04010590 RID: 66960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010591 RID: 66961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010592 RID: 66962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010593 RID: 66963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
