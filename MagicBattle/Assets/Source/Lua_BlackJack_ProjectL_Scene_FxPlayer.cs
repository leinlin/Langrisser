using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001342 RID: 4930
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_FxPlayer : LuaObject
{
	// Token: 0x0601A7AB RID: 108459 RVA: 0x007D8E28 File Offset: 0x007D7028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GraphicPool pool;
			LuaObject.checkType<GraphicPool>(l, 2, out pool);
			FxPlayer o = new FxPlayer(pool);
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

	// Token: 0x0601A7AC RID: 108460 RVA: 0x007D8E7C File Offset: 0x007D707C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			FxPlayer fxPlayer = (FxPlayer)LuaObject.checkSelf(l);
			fxPlayer.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7AD RID: 108461 RVA: 0x007D8EC8 File Offset: 0x007D70C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDefaultParent(IntPtr l)
	{
		int result;
		try
		{
			FxPlayer fxPlayer = (FxPlayer)LuaObject.checkSelf(l);
			GameObject defaultParent;
			LuaObject.checkType<GameObject>(l, 2, out defaultParent);
			fxPlayer.SetDefaultParent(defaultParent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7AE RID: 108462 RVA: 0x007D8F20 File Offset: 0x007D7120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Play(IntPtr l)
	{
		int result;
		try
		{
			FxPlayer fxPlayer = (FxPlayer)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			GenericGraphic o = fxPlayer.Play(assetName);
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

	// Token: 0x0601A7AF RID: 108463 RVA: 0x007D8F84 File Offset: 0x007D7184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PauseAll(IntPtr l)
	{
		int result;
		try
		{
			FxPlayer fxPlayer = (FxPlayer)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			fxPlayer.PauseAll(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7B0 RID: 108464 RVA: 0x007D8FDC File Offset: 0x007D71DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeleteAutoDeleteFxs(IntPtr l)
	{
		int result;
		try
		{
			FxPlayer fxPlayer = (FxPlayer)LuaObject.checkSelf(l);
			fxPlayer.DeleteAutoDeleteFxs();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7B1 RID: 108465 RVA: 0x007D9028 File Offset: 0x007D7228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			FxPlayer fxPlayer = (FxPlayer)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			fxPlayer.Tick(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7B2 RID: 108466 RVA: 0x007D9080 File Offset: 0x007D7280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_parentGameObject(IntPtr l)
	{
		int result;
		try
		{
			FxPlayer fxPlayer = (FxPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fxPlayer.m_parentGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7B3 RID: 108467 RVA: 0x007D90D4 File Offset: 0x007D72D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_parentGameObject(IntPtr l)
	{
		int result;
		try
		{
			FxPlayer fxPlayer = (FxPlayer)LuaObject.checkSelf(l);
			GameObject parentGameObject;
			LuaObject.checkType<GameObject>(l, 2, out parentGameObject);
			fxPlayer.m_parentGameObject = parentGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7B4 RID: 108468 RVA: 0x007D912C File Offset: 0x007D732C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.FxPlayer");
		if (Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FxPlayer.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FxPlayer.SetDefaultParent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FxPlayer.Play);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FxPlayer.PauseAll);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FxPlayer.DeleteAutoDeleteFxs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FxPlayer.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache5);
		string name = "m_parentGameObject";
		if (Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FxPlayer.get_m_parentGameObject);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FxPlayer.set_m_parentGameObject);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_FxPlayer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_FxPlayer.<>f__mg$cache8, typeof(FxPlayer));
	}

	// Token: 0x04010B09 RID: 68361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010B0A RID: 68362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010B0B RID: 68363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010B0C RID: 68364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010B0D RID: 68365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010B0E RID: 68366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010B0F RID: 68367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010B10 RID: 68368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010B11 RID: 68369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
