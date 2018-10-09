using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200133F RID: 4927
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_CombatCamera : LuaObject
{
	// Token: 0x0601A769 RID: 108393 RVA: 0x007D6F18 File Offset: 0x007D5118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera o = new CombatCamera();
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

	// Token: 0x0601A76A RID: 108394 RVA: 0x007D6F60 File Offset: 0x007D5160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			combatCamera.Initialize(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A76B RID: 108395 RVA: 0x007D6FB8 File Offset: 0x007D51B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCombat(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			bool splitScreen;
			LuaObject.checkType(l, 2, out splitScreen);
			combatCamera.StartCombat(splitScreen);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A76C RID: 108396 RVA: 0x007D7010 File Offset: 0x007D5210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			combatCamera.Update(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A76D RID: 108397 RVA: 0x007D7068 File Offset: 0x007D5268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCulled(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
				Vector2 p;
				LuaObject.checkType(l, 2, out p);
				bool b = combatCamera.IsCulled(p);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				CombatCamera combatCamera2 = (CombatCamera)LuaObject.checkSelf(l);
				Vector2 bmin;
				LuaObject.checkType(l, 2, out bmin);
				Vector2 bmax;
				LuaObject.checkType(l, 3, out bmax);
				bool b2 = combatCamera2.IsCulled(bmin, bmax);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsCulled to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A76E RID: 108398 RVA: 0x007D7140 File Offset: 0x007D5340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initialize(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			GameObject cameraGo;
			LuaObject.checkType<GameObject>(l, 2, out cameraGo);
			GameObject animatorGo;
			LuaObject.checkType<GameObject>(l, 3, out animatorGo);
			combatCamera.m_luaExportHelper.__callBase_Initialize(cameraGo, animatorGo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A76F RID: 108399 RVA: 0x007D71AC File Offset: 0x007D53AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetViewSize(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			float o;
			float o2;
			combatCamera.m_luaExportHelper.__callBase_GetViewSize(out o, out o2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			LuaObject.pushValue(l, o2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A770 RID: 108400 RVA: 0x007D7214 File Offset: 0x007D5414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			combatCamera.m_luaExportHelper.__callBase_PlayAnimation(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A771 RID: 108401 RVA: 0x007D7270 File Offset: 0x007D5470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAnimationOffset(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			Vector3 o = combatCamera.m_luaExportHelper.__callBase_GetAnimationOffset();
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

	// Token: 0x0601A772 RID: 108402 RVA: 0x007D72CC File Offset: 0x007D54CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsCulled(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
				Vector2 p;
				LuaObject.checkType(l, 2, out p);
				bool b = combatCamera.m_luaExportHelper.__callBase_IsCulled(p);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				CombatCamera combatCamera2 = (CombatCamera)LuaObject.checkSelf(l);
				Vector2 bmin;
				LuaObject.checkType(l, 2, out bmin);
				Vector2 bmax;
				LuaObject.checkType(l, 3, out bmax);
				bool b2 = combatCamera2.m_luaExportHelper.__callBase_IsCulled(bmin, bmax);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_IsCulled to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A773 RID: 108403 RVA: 0x007D73B0 File Offset: 0x007D55B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSplitScreen(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatCamera.m_luaExportHelper.m_isSplitScreen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A774 RID: 108404 RVA: 0x007D7408 File Offset: 0x007D5608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSplitScreen(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			bool isSplitScreen;
			LuaObject.checkType(l, 2, out isSplitScreen);
			combatCamera.m_luaExportHelper.m_isSplitScreen = isSplitScreen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A775 RID: 108405 RVA: 0x007D7464 File Offset: 0x007D5664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatCamera.m_luaExportHelper.m_gameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A776 RID: 108406 RVA: 0x007D74BC File Offset: 0x007D56BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gameObject(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			GameObject gameObject;
			LuaObject.checkType<GameObject>(l, 2, out gameObject);
			combatCamera.m_luaExportHelper.m_gameObject = gameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A777 RID: 108407 RVA: 0x007D7518 File Offset: 0x007D5718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_camera1(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatCamera.m_luaExportHelper.m_camera1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A778 RID: 108408 RVA: 0x007D7570 File Offset: 0x007D5770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_camera1(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			combatCamera.m_luaExportHelper.m_camera1 = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A779 RID: 108409 RVA: 0x007D75CC File Offset: 0x007D57CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_camera2(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatCamera.m_luaExportHelper.m_camera2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A77A RID: 108410 RVA: 0x007D7624 File Offset: 0x007D5824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_camera2(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			combatCamera.m_luaExportHelper.m_camera2 = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A77B RID: 108411 RVA: 0x007D7680 File Offset: 0x007D5880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatCamera.m_luaExportHelper.m_initPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A77C RID: 108412 RVA: 0x007D76D8 File Offset: 0x007D58D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initPosition(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			Vector3 initPosition;
			LuaObject.checkType(l, 2, out initPosition);
			combatCamera.m_luaExportHelper.m_initPosition = initPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A77D RID: 108413 RVA: 0x007D7734 File Offset: 0x007D5934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initOrthographicSize(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatCamera.m_luaExportHelper.m_initOrthographicSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A77E RID: 108414 RVA: 0x007D778C File Offset: 0x007D598C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initOrthographicSize(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			float initOrthographicSize;
			LuaObject.checkType(l, 2, out initOrthographicSize);
			combatCamera.m_luaExportHelper.m_initOrthographicSize = initOrthographicSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A77F RID: 108415 RVA: 0x007D77E8 File Offset: 0x007D59E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initSplitScreenOrthographicSize(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatCamera.m_luaExportHelper.m_initSplitScreenOrthographicSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A780 RID: 108416 RVA: 0x007D7840 File Offset: 0x007D5A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initSplitScreenOrthographicSize(IntPtr l)
	{
		int result;
		try
		{
			CombatCamera combatCamera = (CombatCamera)LuaObject.checkSelf(l);
			float initSplitScreenOrthographicSize;
			LuaObject.checkType(l, 2, out initSplitScreenOrthographicSize);
			combatCamera.m_luaExportHelper.m_initSplitScreenOrthographicSize = initSplitScreenOrthographicSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A781 RID: 108417 RVA: 0x007D789C File Offset: 0x007D5A9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.CombatCamera");
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.StartCombat);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.IsCulled);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.__callBase_Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.__callBase_GetViewSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.__callBase_PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.__callBase_GetAnimationOffset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.__callBase_IsCulled);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache8);
		string name = "m_isSplitScreen";
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.get_m_isSplitScreen);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.set_m_isSplitScreen);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheA, true);
		string name2 = "m_gameObject";
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.get_m_gameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.set_m_gameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheC, true);
		string name3 = "m_camera1";
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.get_m_camera1);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.set_m_camera1);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheE, true);
		string name4 = "m_camera2";
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.get_m_camera2);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.set_m_camera2);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache10, true);
		string name5 = "m_initPosition";
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.get_m_initPosition);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.set_m_initPosition);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache12, true);
		string name6 = "m_initOrthographicSize";
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.get_m_initOrthographicSize);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.set_m_initOrthographicSize);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache14, true);
		string name7 = "m_initSplitScreenOrthographicSize";
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.get_m_initSplitScreenOrthographicSize);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.set_m_initSplitScreenOrthographicSize);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache16, true);
		if (Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CombatCamera.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_CombatCamera.<>f__mg$cache17, typeof(CombatCamera), typeof(CameraBase));
	}

	// Token: 0x04010ACD RID: 68301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010ACE RID: 68302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010ACF RID: 68303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010AD0 RID: 68304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010AD1 RID: 68305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010AD2 RID: 68306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010AD3 RID: 68307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010AD4 RID: 68308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010AD5 RID: 68309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010AD6 RID: 68310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010AD7 RID: 68311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010AD8 RID: 68312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010AD9 RID: 68313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010ADA RID: 68314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010ADB RID: 68315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010ADC RID: 68316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010ADD RID: 68317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010ADE RID: 68318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010ADF RID: 68319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010AE0 RID: 68320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010AE1 RID: 68321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010AE2 RID: 68322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010AE3 RID: 68323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010AE4 RID: 68324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
