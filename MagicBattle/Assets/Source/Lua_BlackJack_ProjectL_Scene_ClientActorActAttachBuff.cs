using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012F3 RID: 4851
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff : LuaObject
{
	// Token: 0x0601A1B9 RID: 106937 RVA: 0x007ACD28 File Offset: 0x007AAF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAttachBuff o = new ClientActorActAttachBuff();
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

	// Token: 0x0601A1BA RID: 106938 RVA: 0x007ACD70 File Offset: 0x007AAF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAttachBuff clientActorActAttachBuff = (ClientActorActAttachBuff)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActAttachBuff.m_buffState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1BB RID: 106939 RVA: 0x007ACDC4 File Offset: 0x007AAFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffState(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAttachBuff clientActorActAttachBuff = (ClientActorActAttachBuff)LuaObject.checkSelf(l);
			BuffState buffState;
			LuaObject.checkType<BuffState>(l, 2, out buffState);
			clientActorActAttachBuff.m_buffState = buffState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1BC RID: 106940 RVA: 0x007ACE1C File Offset: 0x007AB01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fightTags(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAttachBuff clientActorActAttachBuff = (ClientActorActAttachBuff)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActAttachBuff.m_fightTags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1BD RID: 106941 RVA: 0x007ACE70 File Offset: 0x007AB070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fightTags(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAttachBuff clientActorActAttachBuff = (ClientActorActAttachBuff)LuaObject.checkSelf(l);
			uint fightTags;
			LuaObject.checkType(l, 2, out fightTags);
			clientActorActAttachBuff.m_fightTags = fightTags;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1BE RID: 106942 RVA: 0x007ACEC8 File Offset: 0x007AB0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHpMax(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAttachBuff clientActorActAttachBuff = (ClientActorActAttachBuff)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActAttachBuff.m_heroHpMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1BF RID: 106943 RVA: 0x007ACF1C File Offset: 0x007AB11C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHpMax(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAttachBuff clientActorActAttachBuff = (ClientActorActAttachBuff)LuaObject.checkSelf(l);
			int heroHpMax;
			LuaObject.checkType(l, 2, out heroHpMax);
			clientActorActAttachBuff.m_heroHpMax = heroHpMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1C0 RID: 106944 RVA: 0x007ACF74 File Offset: 0x007AB174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHpMax(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAttachBuff clientActorActAttachBuff = (ClientActorActAttachBuff)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActAttachBuff.m_soldierHpMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1C1 RID: 106945 RVA: 0x007ACFC8 File Offset: 0x007AB1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHpMax(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActAttachBuff clientActorActAttachBuff = (ClientActorActAttachBuff)LuaObject.checkSelf(l);
			int soldierHpMax;
			LuaObject.checkType(l, 2, out soldierHpMax);
			clientActorActAttachBuff.m_soldierHpMax = soldierHpMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1C2 RID: 106946 RVA: 0x007AD020 File Offset: 0x007AB220
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActAttachBuff");
		string name = "m_buffState";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.get_m_buffState);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.set_m_buffState);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache1, true);
		string name2 = "m_fightTags";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.get_m_fightTags);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.set_m_fightTags);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache3, true);
		string name3 = "m_heroHpMax";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.get_m_heroHpMax);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.set_m_heroHpMax);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache5, true);
		string name4 = "m_soldierHpMax";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.get_m_soldierHpMax);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.set_m_soldierHpMax);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActAttachBuff.<>f__mg$cache8, typeof(ClientActorActAttachBuff), typeof(ClientActorAct));
	}

	// Token: 0x040105B5 RID: 66997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105B6 RID: 66998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105B7 RID: 66999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040105B8 RID: 67000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040105B9 RID: 67001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040105BA RID: 67002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040105BB RID: 67003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040105BC RID: 67004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040105BD RID: 67005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
