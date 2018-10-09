using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001316 RID: 4886
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo : LuaObject
{
	// Token: 0x0601A2D0 RID: 107216 RVA: 0x007B3588 File Offset: 0x007B1788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo o = new ClientActorHitInfo();
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

	// Token: 0x0601A2D1 RID: 107217 RVA: 0x007B35D0 File Offset: 0x007B17D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorHitInfo.m_heroHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2D2 RID: 107218 RVA: 0x007B3624 File Offset: 0x007B1824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			int heroHp;
			LuaObject.checkType(l, 2, out heroHp);
			clientActorHitInfo.m_heroHp = heroHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2D3 RID: 107219 RVA: 0x007B367C File Offset: 0x007B187C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorHitInfo.m_soldierHp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2D4 RID: 107220 RVA: 0x007B36D0 File Offset: 0x007B18D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHp(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			int soldierHp;
			LuaObject.checkType(l, 2, out soldierHp);
			clientActorHitInfo.m_soldierHp = soldierHp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2D5 RID: 107221 RVA: 0x007B3728 File Offset: 0x007B1928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorHitInfo.m_heroHpModify);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2D6 RID: 107222 RVA: 0x007B377C File Offset: 0x007B197C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			int heroHpModify;
			LuaObject.checkType(l, 2, out heroHpModify);
			clientActorHitInfo.m_heroHpModify = heroHpModify;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2D7 RID: 107223 RVA: 0x007B37D4 File Offset: 0x007B19D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorHitInfo.m_soldierHpModify);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2D8 RID: 107224 RVA: 0x007B3828 File Offset: 0x007B1A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierHpModify(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			int soldierHpModify;
			LuaObject.checkType(l, 2, out soldierHpModify);
			clientActorHitInfo.m_soldierHpModify = soldierHpModify;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2D9 RID: 107225 RVA: 0x007B3880 File Offset: 0x007B1A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frame(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorHitInfo.m_frame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2DA RID: 107226 RVA: 0x007B38D4 File Offset: 0x007B1AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frame(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			int frame;
			LuaObject.checkType(l, 2, out frame);
			clientActorHitInfo.m_frame = frame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2DB RID: 107227 RVA: 0x007B392C File Offset: 0x007B1B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_damageNumberType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)clientActorHitInfo.m_damageNumberType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2DC RID: 107228 RVA: 0x007B3980 File Offset: 0x007B1B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_damageNumberType(IntPtr l)
	{
		int result;
		try
		{
			ClientActorHitInfo clientActorHitInfo = (ClientActorHitInfo)LuaObject.checkSelf(l);
			DamageNumberType damageNumberType;
			LuaObject.checkEnum<DamageNumberType>(l, 2, out damageNumberType);
			clientActorHitInfo.m_damageNumberType = damageNumberType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2DD RID: 107229 RVA: 0x007B39D8 File Offset: 0x007B1BD8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorHitInfo");
		string name = "m_heroHp";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.get_m_heroHp);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.set_m_heroHp);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache1, true);
		string name2 = "m_soldierHp";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.get_m_soldierHp);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.set_m_soldierHp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache3, true);
		string name3 = "m_heroHpModify";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.get_m_heroHpModify);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.set_m_heroHpModify);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache5, true);
		string name4 = "m_soldierHpModify";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.get_m_soldierHpModify);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.set_m_soldierHpModify);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache7, true);
		string name5 = "m_frame";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.get_m_frame);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.set_m_frame);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cache9, true);
		string name6 = "m_damageNumberType";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.get_m_damageNumberType);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.set_m_damageNumberType);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorHitInfo.<>f__mg$cacheC, typeof(ClientActorHitInfo));
	}

	// Token: 0x04010686 RID: 67206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010687 RID: 67207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010688 RID: 67208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010689 RID: 67209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401068A RID: 67210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401068B RID: 67211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401068C RID: 67212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401068D RID: 67213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401068E RID: 67214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401068F RID: 67215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010690 RID: 67216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010691 RID: 67217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010692 RID: 67218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
