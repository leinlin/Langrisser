using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200133D RID: 4925
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientWorldRegion : LuaObject
{
	// Token: 0x0601A70F RID: 108303 RVA: 0x007D4540 File Offset: 0x007D2740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion o = new ClientWorldRegion();
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

	// Token: 0x0601A710 RID: 108304 RVA: 0x007D4588 File Offset: 0x007D2788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			ClientWorld world;
			LuaObject.checkType<ClientWorld>(l, 2, out world);
			ConfigDataRegionInfo regionInfo;
			LuaObject.checkType<ConfigDataRegionInfo>(l, 3, out regionInfo);
			clientWorldRegion.Initialize(world, regionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A711 RID: 108305 RVA: 0x007D45EC File Offset: 0x007D27EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGameObject(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			GameObject gameObject;
			LuaObject.checkType<GameObject>(l, 2, out gameObject);
			clientWorldRegion.SetGameObject(gameObject);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A712 RID: 108306 RVA: 0x007D4644 File Offset: 0x007D2844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			clientWorldRegion.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A713 RID: 108307 RVA: 0x007D4690 File Offset: 0x007D2890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			clientWorldRegion.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A714 RID: 108308 RVA: 0x007D46DC File Offset: 0x007D28DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientWorldRegion.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A715 RID: 108309 RVA: 0x007D4734 File Offset: 0x007D2934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			clientWorldRegion.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A716 RID: 108310 RVA: 0x007D4780 File Offset: 0x007D2980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOpen(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			bool open;
			LuaObject.checkType(l, 2, out open);
			clientWorldRegion.SetOpen(open);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A717 RID: 108311 RVA: 0x007D47D8 File Offset: 0x007D29D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpened(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			bool b = clientWorldRegion.IsOpened();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A718 RID: 108312 RVA: 0x007D482C File Offset: 0x007D2A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldRegion.DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A719 RID: 108313 RVA: 0x007D4884 File Offset: 0x007D2A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			bool visible;
			LuaObject.checkType(l, 2, out visible);
			clientWorldRegion.SetVisible(visible);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A71A RID: 108314 RVA: 0x007D48DC File Offset: 0x007D2ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			bool b = clientWorldRegion.IsVisible();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A71B RID: 108315 RVA: 0x007D4930 File Offset: 0x007D2B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			clientWorldRegion.m_luaExportHelper.PlayAnimation(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A71C RID: 108316 RVA: 0x007D498C File Offset: 0x007D2B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Dispose(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			clientWorldRegion.m_luaExportHelper.__callBase_Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A71D RID: 108317 RVA: 0x007D49E0 File Offset: 0x007D2BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			clientWorldRegion.m_luaExportHelper.__callBase_Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A71E RID: 108318 RVA: 0x007D4A34 File Offset: 0x007D2C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			clientWorldRegion.m_luaExportHelper.__callBase_TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A71F RID: 108319 RVA: 0x007D4A90 File Offset: 0x007D2C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Draw(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			clientWorldRegion.m_luaExportHelper.__callBase_Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A720 RID: 108320 RVA: 0x007D4AE4 File Offset: 0x007D2CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Pause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldRegion.m_luaExportHelper.__callBase_Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A721 RID: 108321 RVA: 0x007D4B40 File Offset: 0x007D2D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DoPause(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			clientWorldRegion.m_luaExportHelper.__callBase_DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A722 RID: 108322 RVA: 0x007D4B9C File Offset: 0x007D2D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeleteMe(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			clientWorldRegion.m_luaExportHelper.__callBase_DeleteMe();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A723 RID: 108323 RVA: 0x007D4BF0 File Offset: 0x007D2DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_regionInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldRegion.m_luaExportHelper.m_regionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A724 RID: 108324 RVA: 0x007D4C48 File Offset: 0x007D2E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_regionInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			ConfigDataRegionInfo regionInfo;
			LuaObject.checkType<ConfigDataRegionInfo>(l, 2, out regionInfo);
			clientWorldRegion.m_luaExportHelper.m_regionInfo = regionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A725 RID: 108325 RVA: 0x007D4CA4 File Offset: 0x007D2EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameObject(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldRegion.m_luaExportHelper.m_gameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A726 RID: 108326 RVA: 0x007D4CFC File Offset: 0x007D2EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameObject(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			GameObject gameObject;
			LuaObject.checkType<GameObject>(l, 2, out gameObject);
			clientWorldRegion.m_luaExportHelper.m_gameObject = gameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A727 RID: 108327 RVA: 0x007D4D58 File Offset: 0x007D2F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_animator(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldRegion.m_luaExportHelper.m_animator);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A728 RID: 108328 RVA: 0x007D4DB0 File Offset: 0x007D2FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_animator(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			Animator animator;
			LuaObject.checkType<Animator>(l, 2, out animator);
			clientWorldRegion.m_luaExportHelper.m_animator = animator;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A729 RID: 108329 RVA: 0x007D4E0C File Offset: 0x007D300C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldRegion.m_luaExportHelper.m_isOpened);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A72A RID: 108330 RVA: 0x007D4E64 File Offset: 0x007D3064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isOpened(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			bool isOpened;
			LuaObject.checkType(l, 2, out isOpened);
			clientWorldRegion.m_luaExportHelper.m_isOpened = isOpened;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A72B RID: 108331 RVA: 0x007D4EC0 File Offset: 0x007D30C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldRegion.m_luaExportHelper.m_isVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A72C RID: 108332 RVA: 0x007D4F18 File Offset: 0x007D3118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isVisible(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			bool isVisible;
			LuaObject.checkType(l, 2, out isVisible);
			clientWorldRegion.m_luaExportHelper.m_isVisible = isVisible;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A72D RID: 108333 RVA: 0x007D4F74 File Offset: 0x007D3174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldRegion.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A72E RID: 108334 RVA: 0x007D4FC8 File Offset: 0x007D31C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RegionInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldRegion clientWorldRegion = (ClientWorldRegion)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientWorldRegion.RegionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A72F RID: 108335 RVA: 0x007D501C File Offset: 0x007D321C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientWorldRegion");
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.SetGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.SetOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.IsOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.SetVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.IsVisible);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.__callBase_Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.__callBase_TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.__callBase_Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.__callBase_Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.__callBase_DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.__callBase_DeleteMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache12);
		string name = "m_regionInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.get_m_regionInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.set_m_regionInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache14, true);
		string name2 = "m_gameObject";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.get_m_gameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.set_m_gameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache16, true);
		string name3 = "m_animator";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.get_m_animator);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.set_m_animator);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache18, true);
		string name4 = "m_isOpened";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.get_m_isOpened);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.set_m_isOpened);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1A, true);
		string name5 = "m_isVisible";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.get_m_isVisible);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.set_m_isVisible);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1C, true);
		string name6 = "Position";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.get_Position);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1D, null, true);
		string name7 = "RegionInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.get_RegionInfo);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1E, null, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientWorldRegion.<>f__mg$cache1F, typeof(ClientWorldRegion), typeof(Entity));
	}

	// Token: 0x04010A77 RID: 68215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010A78 RID: 68216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010A79 RID: 68217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010A7A RID: 68218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010A7B RID: 68219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010A7C RID: 68220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010A7D RID: 68221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010A7E RID: 68222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010A7F RID: 68223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010A80 RID: 68224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010A81 RID: 68225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010A82 RID: 68226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010A83 RID: 68227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010A84 RID: 68228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010A85 RID: 68229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010A86 RID: 68230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010A87 RID: 68231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010A88 RID: 68232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010A89 RID: 68233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010A8A RID: 68234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010A8B RID: 68235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010A8C RID: 68236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010A8D RID: 68237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010A8E RID: 68238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010A8F RID: 68239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010A90 RID: 68240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010A91 RID: 68241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04010A92 RID: 68242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04010A93 RID: 68243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04010A94 RID: 68244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04010A95 RID: 68245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04010A96 RID: 68246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
