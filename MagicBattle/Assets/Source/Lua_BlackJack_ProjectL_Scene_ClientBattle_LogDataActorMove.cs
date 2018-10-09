using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200131A RID: 4890
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove : LuaObject
{
	// Token: 0x0601A46B RID: 107627 RVA: 0x007C03F0 File Offset: 0x007BE5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorMove o = new ClientBattle.LogDataActorMove();
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

	// Token: 0x0601A46C RID: 107628 RVA: 0x007C0438 File Offset: 0x007BE638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorMove logDataActorMove = (ClientBattle.LogDataActorMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorMove.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A46D RID: 107629 RVA: 0x007C048C File Offset: 0x007BE68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorMove logDataActorMove = (ClientBattle.LogDataActorMove)LuaObject.checkSelf(l);
			string type;
			LuaObject.checkType(l, 2, out type);
			logDataActorMove.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A46E RID: 107630 RVA: 0x007C04E4 File Offset: 0x007BE6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Turn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorMove logDataActorMove = (ClientBattle.LogDataActorMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorMove.Turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A46F RID: 107631 RVA: 0x007C0538 File Offset: 0x007BE738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Turn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorMove logDataActorMove = (ClientBattle.LogDataActorMove)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			logDataActorMove.Turn = turn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A470 RID: 107632 RVA: 0x007C0590 File Offset: 0x007BE790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorMove logDataActorMove = (ClientBattle.LogDataActorMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorMove.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A471 RID: 107633 RVA: 0x007C05E4 File Offset: 0x007BE7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorMove logDataActorMove = (ClientBattle.LogDataActorMove)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			logDataActorMove.HeroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A472 RID: 107634 RVA: 0x007C063C File Offset: 0x007BE83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FromPos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorMove logDataActorMove = (ClientBattle.LogDataActorMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorMove.FromPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A473 RID: 107635 RVA: 0x007C0694 File Offset: 0x007BE894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FromPos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorMove logDataActorMove = (ClientBattle.LogDataActorMove)LuaObject.checkSelf(l);
			GridPosition fromPos;
			LuaObject.checkValueType<GridPosition>(l, 2, out fromPos);
			logDataActorMove.FromPos = fromPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A474 RID: 107636 RVA: 0x007C06EC File Offset: 0x007BE8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ToPos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorMove logDataActorMove = (ClientBattle.LogDataActorMove)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorMove.ToPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A475 RID: 107637 RVA: 0x007C0744 File Offset: 0x007BE944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ToPos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorMove logDataActorMove = (ClientBattle.LogDataActorMove)LuaObject.checkSelf(l);
			GridPosition toPos;
			LuaObject.checkValueType<GridPosition>(l, 2, out toPos);
			logDataActorMove.ToPos = toPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A476 RID: 107638 RVA: 0x007C079C File Offset: 0x007BE99C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattle.LogDataActorMove");
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache1, true);
		string name2 = "Turn";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.get_Turn);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.set_Turn);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache3, true);
		string name3 = "HeroId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.get_HeroId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.set_HeroId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache5, true);
		string name4 = "FromPos";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.get_FromPos);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.set_FromPos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache7, true);
		string name5 = "ToPos";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.get_ToPos);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.set_ToPos);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorMove.<>f__mg$cacheA, typeof(ClientBattle.LogDataActorMove));
	}

	// Token: 0x04010819 RID: 67609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401081A RID: 67610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401081B RID: 67611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401081C RID: 67612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401081D RID: 67613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401081E RID: 67614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401081F RID: 67615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010820 RID: 67616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010821 RID: 67617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010822 RID: 67618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010823 RID: 67619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
