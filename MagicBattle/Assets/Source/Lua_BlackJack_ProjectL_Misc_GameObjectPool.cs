using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020012A2 RID: 4770
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_GameObjectPool : LuaObject
{
	// Token: 0x0601904B RID: 102475 RVA: 0x0071EA8C File Offset: 0x0071CC8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GameObjectPool o = new GameObjectPool();
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

	// Token: 0x0601904C RID: 102476 RVA: 0x0071EAD4 File Offset: 0x0071CCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Setup(IntPtr l)
	{
		int result;
		try
		{
			GameObjectPool gameObjectPool = (GameObjectPool)LuaObject.checkSelf(l);
			GameObject prefab;
			LuaObject.checkType<GameObject>(l, 2, out prefab);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 3, out parent);
			gameObjectPool.Setup(prefab, parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601904D RID: 102477 RVA: 0x0071EB38 File Offset: 0x0071CD38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Allocate(IntPtr l)
	{
		int result;
		try
		{
			GameObjectPool gameObjectPool = (GameObjectPool)LuaObject.checkSelf(l);
			GameObject o = gameObjectPool.Allocate();
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

	// Token: 0x0601904E RID: 102478 RVA: 0x0071EB8C File Offset: 0x0071CD8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Deactive(IntPtr l)
	{
		int result;
		try
		{
			GameObjectPool gameObjectPool = (GameObjectPool)LuaObject.checkSelf(l);
			gameObjectPool.Deactive();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601904F RID: 102479 RVA: 0x0071EBD8 File Offset: 0x0071CDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Destroy(IntPtr l)
	{
		int result;
		try
		{
			GameObjectPool gameObjectPool = (GameObjectPool)LuaObject.checkSelf(l);
			gameObjectPool.Destroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019050 RID: 102480 RVA: 0x0071EC24 File Offset: 0x0071CE24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetList(IntPtr l)
	{
		int result;
		try
		{
			GameObjectPool gameObjectPool = (GameObjectPool)LuaObject.checkSelf(l);
			List<GameObject> list = gameObjectPool.GetList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, list);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019051 RID: 102481 RVA: 0x0071EC78 File Offset: 0x0071CE78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_list(IntPtr l)
	{
		int result;
		try
		{
			GameObjectPool gameObjectPool = (GameObjectPool)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameObjectPool.m_list);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019052 RID: 102482 RVA: 0x0071ECCC File Offset: 0x0071CECC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_list(IntPtr l)
	{
		int result;
		try
		{
			GameObjectPool gameObjectPool = (GameObjectPool)LuaObject.checkSelf(l);
			List<GameObject> list;
			LuaObject.checkType<List<GameObject>>(l, 2, out list);
			gameObjectPool.m_list = list;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019053 RID: 102483 RVA: 0x0071ED24 File Offset: 0x0071CF24
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.GameObjectPool");
		if (Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectPool.Setup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectPool.Allocate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectPool.Deactive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectPool.Destroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectPool.GetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache4);
		string name = "m_list";
		if (Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectPool.get_m_list);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectPool.set_m_list);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_GameObjectPool.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_GameObjectPool.<>f__mg$cache7, typeof(GameObjectPool));
	}

	// Token: 0x0400F4E9 RID: 62697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F4EA RID: 62698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F4EB RID: 62699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F4EC RID: 62700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F4ED RID: 62701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F4EE RID: 62702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F4EF RID: 62703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F4F0 RID: 62704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
