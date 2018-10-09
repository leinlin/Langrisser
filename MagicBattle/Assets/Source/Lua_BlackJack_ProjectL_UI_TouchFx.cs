using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020015B4 RID: 5556
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TouchFx : LuaObject
{
	// Token: 0x06021C11 RID: 138257 RVA: 0x00B76D0C File Offset: 0x00B74F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TouchFx o = new TouchFx();
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

	// Token: 0x06021C12 RID: 138258 RVA: 0x00B76D54 File Offset: 0x00B74F54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 2, out parent);
			Camera camera;
			LuaObject.checkType<Camera>(l, 3, out camera);
			touchFx.Init(parent, camera);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C13 RID: 138259 RVA: 0x00B76DB8 File Offset: 0x00B74FB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHitFxName(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			string hitFxName;
			LuaObject.checkType(l, 2, out hitFxName);
			touchFx.SetHitFxName(hitFxName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C14 RID: 138260 RVA: 0x00B76E10 File Offset: 0x00B75010
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLoopFxName(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			string loopFxName;
			LuaObject.checkType(l, 2, out loopFxName);
			touchFx.SetLoopFxName(loopFxName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C15 RID: 138261 RVA: 0x00B76E68 File Offset: 0x00B75068
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetDisableInputGameObject(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			GameObject disableInputGameObject;
			LuaObject.checkType<GameObject>(l, 2, out disableInputGameObject);
			touchFx.SetDisableInputGameObject(disableInputGameObject);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C16 RID: 138262 RVA: 0x00B76EC0 File Offset: 0x00B750C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTouchFXParentActive(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			bool touchFXParentActive;
			LuaObject.checkType(l, 2, out touchFXParentActive);
			touchFx.SetTouchFXParentActive(touchFXParentActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C17 RID: 138263 RVA: 0x00B76F18 File Offset: 0x00B75118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearFx(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			touchFx.ClearFx();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C18 RID: 138264 RVA: 0x00B76F64 File Offset: 0x00B75164
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			touchFx.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C19 RID: 138265 RVA: 0x00B76FB0 File Offset: 0x00B751B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			touchFx.Tick(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C1A RID: 138266 RVA: 0x00B77008 File Offset: 0x00B75208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hitFxName(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchFx.m_luaExportHelper.m_hitFxName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C1B RID: 138267 RVA: 0x00B77060 File Offset: 0x00B75260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hitFxName(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			string hitFxName;
			LuaObject.checkType(l, 2, out hitFxName);
			touchFx.m_luaExportHelper.m_hitFxName = hitFxName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C1C RID: 138268 RVA: 0x00B770BC File Offset: 0x00B752BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_loopFxName(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchFx.m_luaExportHelper.m_loopFxName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C1D RID: 138269 RVA: 0x00B77114 File Offset: 0x00B75314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_loopFxName(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			string loopFxName;
			LuaObject.checkType(l, 2, out loopFxName);
			touchFx.m_luaExportHelper.m_loopFxName = loopFxName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C1E RID: 138270 RVA: 0x00B77170 File Offset: 0x00B75370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_camera(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchFx.m_luaExportHelper.m_camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C1F RID: 138271 RVA: 0x00B771C8 File Offset: 0x00B753C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_camera(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			touchFx.m_luaExportHelper.m_camera = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C20 RID: 138272 RVA: 0x00B77224 File Offset: 0x00B75424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_disableInputGameObject(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchFx.m_luaExportHelper.m_disableInputGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C21 RID: 138273 RVA: 0x00B7727C File Offset: 0x00B7547C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_disableInputGameObject(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			GameObject disableInputGameObject;
			LuaObject.checkType<GameObject>(l, 2, out disableInputGameObject);
			touchFx.m_luaExportHelper.m_disableInputGameObject = disableInputGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C22 RID: 138274 RVA: 0x00B772D8 File Offset: 0x00B754D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphicPool(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchFx.m_luaExportHelper.m_graphicPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C23 RID: 138275 RVA: 0x00B77330 File Offset: 0x00B75530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphicPool(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			GraphicPool graphicPool;
			LuaObject.checkType<GraphicPool>(l, 2, out graphicPool);
			touchFx.m_luaExportHelper.m_graphicPool = graphicPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C24 RID: 138276 RVA: 0x00B7738C File Offset: 0x00B7558C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxPlayer(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchFx.m_luaExportHelper.m_fxPlayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C25 RID: 138277 RVA: 0x00B773E4 File Offset: 0x00B755E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxPlayer(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			FxPlayer fxPlayer;
			LuaObject.checkType<FxPlayer>(l, 2, out fxPlayer);
			touchFx.m_luaExportHelper.m_fxPlayer = fxPlayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C26 RID: 138278 RVA: 0x00B77440 File Offset: 0x00B75640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_touchStates(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchFx.m_luaExportHelper.m_touchStates);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C27 RID: 138279 RVA: 0x00B77498 File Offset: 0x00B75698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_touchStates(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			List<TouchFx.TouchState> touchStates;
			LuaObject.checkType<List<TouchFx.TouchState>>(l, 2, out touchStates);
			touchFx.m_luaExportHelper.m_touchStates = touchStates;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C28 RID: 138280 RVA: 0x00B774F4 File Offset: 0x00B756F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loopFxs(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touchFx.m_luaExportHelper.m_loopFxs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C29 RID: 138281 RVA: 0x00B7754C File Offset: 0x00B7574C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loopFxs(IntPtr l)
	{
		int result;
		try
		{
			TouchFx touchFx = (TouchFx)LuaObject.checkSelf(l);
			GenericGraphic[] loopFxs;
			LuaObject.checkArray<GenericGraphic>(l, 2, out loopFxs);
			touchFx.m_luaExportHelper.m_loopFxs = loopFxs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C2A RID: 138282 RVA: 0x00B775A8 File Offset: 0x00B757A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TouchFx");
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.SetHitFxName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.SetLoopFxName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.SetDisableInputGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.SetTouchFXParentActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.ClearFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache7);
		string name = "m_hitFxName";
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.get_m_hitFxName);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.set_m_hitFxName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache9, true);
		string name2 = "m_loopFxName";
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.get_m_loopFxName);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.set_m_loopFxName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheB, true);
		string name3 = "m_camera";
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.get_m_camera);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.set_m_camera);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheD, true);
		string name4 = "m_disableInputGameObject";
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.get_m_disableInputGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.set_m_disableInputGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cacheF, true);
		string name5 = "m_graphicPool";
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.get_m_graphicPool);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.set_m_graphicPool);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache11, true);
		string name6 = "m_fxPlayer";
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.get_m_fxPlayer);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.set_m_fxPlayer);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache13, true);
		string name7 = "m_touchStates";
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.get_m_touchStates);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.set_m_touchStates);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache15, true);
		string name8 = "m_loopFxs";
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.get_m_loopFxs);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.set_m_loopFxs);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache17, true);
		if (Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TouchFx.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TouchFx.<>f__mg$cache18, typeof(TouchFx));
	}

	// Token: 0x04017A8B RID: 96907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017A8C RID: 96908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017A8D RID: 96909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017A8E RID: 96910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017A8F RID: 96911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017A90 RID: 96912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017A91 RID: 96913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017A92 RID: 96914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017A93 RID: 96915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017A94 RID: 96916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017A95 RID: 96917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017A96 RID: 96918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017A97 RID: 96919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017A98 RID: 96920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017A99 RID: 96921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017A9A RID: 96922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017A9B RID: 96923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017A9C RID: 96924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017A9D RID: 96925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017A9E RID: 96926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017A9F RID: 96927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017AA0 RID: 96928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017AA1 RID: 96929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017AA2 RID: 96930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017AA3 RID: 96931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
