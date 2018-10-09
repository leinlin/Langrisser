using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001340 RID: 4928
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_CutsceneCamera : LuaObject
{
	// Token: 0x0601A783 RID: 108419 RVA: 0x007D7C18 File Offset: 0x007D5E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera o = new CutsceneCamera();
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

	// Token: 0x0601A784 RID: 108420 RVA: 0x007D7C60 File Offset: 0x007D5E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			cutsceneCamera.Initialize(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A785 RID: 108421 RVA: 0x007D7CB8 File Offset: 0x007D5EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			cutsceneCamera.Update(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A786 RID: 108422 RVA: 0x007D7D10 File Offset: 0x007D5F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCutscene(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			cutsceneCamera.StartCutscene();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A787 RID: 108423 RVA: 0x007D7D5C File Offset: 0x007D5F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopCutscene(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			cutsceneCamera.StopCutscene();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A788 RID: 108424 RVA: 0x007D7DA8 File Offset: 0x007D5FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayClipAnimation(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			cutsceneCamera.PlayClipAnimation(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A789 RID: 108425 RVA: 0x007D7E00 File Offset: 0x007D6000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initialize(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			GameObject cameraGo;
			LuaObject.checkType<GameObject>(l, 2, out cameraGo);
			GameObject animatorGo;
			LuaObject.checkType<GameObject>(l, 3, out animatorGo);
			cutsceneCamera.m_luaExportHelper.__callBase_Initialize(cameraGo, animatorGo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A78A RID: 108426 RVA: 0x007D7E6C File Offset: 0x007D606C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetViewSize(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			float o;
			float o2;
			cutsceneCamera.m_luaExportHelper.__callBase_GetViewSize(out o, out o2);
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

	// Token: 0x0601A78B RID: 108427 RVA: 0x007D7ED4 File Offset: 0x007D60D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			cutsceneCamera.m_luaExportHelper.__callBase_PlayAnimation(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A78C RID: 108428 RVA: 0x007D7F30 File Offset: 0x007D6130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAnimationOffset(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			Vector3 o = cutsceneCamera.m_luaExportHelper.__callBase_GetAnimationOffset();
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

	// Token: 0x0601A78D RID: 108429 RVA: 0x007D7F8C File Offset: 0x007D618C
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
				CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
				Vector2 p;
				LuaObject.checkType(l, 2, out p);
				bool b = cutsceneCamera.m_luaExportHelper.__callBase_IsCulled(p);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				CutsceneCamera cutsceneCamera2 = (CutsceneCamera)LuaObject.checkSelf(l);
				Vector2 bmin;
				LuaObject.checkType(l, 2, out bmin);
				Vector2 bmax;
				LuaObject.checkType(l, 3, out bmax);
				bool b2 = cutsceneCamera2.m_luaExportHelper.__callBase_IsCulled(bmin, bmax);
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

	// Token: 0x0601A78E RID: 108430 RVA: 0x007D8070 File Offset: 0x007D6270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clipAnimator(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cutsceneCamera.m_luaExportHelper.m_clipAnimator);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A78F RID: 108431 RVA: 0x007D80C8 File Offset: 0x007D62C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clipAnimator(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			Animator clipAnimator;
			LuaObject.checkType<Animator>(l, 2, out clipAnimator);
			cutsceneCamera.m_luaExportHelper.m_clipAnimator = clipAnimator;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A790 RID: 108432 RVA: 0x007D8124 File Offset: 0x007D6324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initOrthographicSize(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cutsceneCamera.m_luaExportHelper.m_initOrthographicSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A791 RID: 108433 RVA: 0x007D817C File Offset: 0x007D637C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initOrthographicSize(IntPtr l)
	{
		int result;
		try
		{
			CutsceneCamera cutsceneCamera = (CutsceneCamera)LuaObject.checkSelf(l);
			float initOrthographicSize;
			LuaObject.checkType(l, 2, out initOrthographicSize);
			cutsceneCamera.m_luaExportHelper.m_initOrthographicSize = initOrthographicSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A792 RID: 108434 RVA: 0x007D81D8 File Offset: 0x007D63D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.CutsceneCamera");
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.StartCutscene);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.StopCutscene);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.PlayClipAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.__callBase_Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.__callBase_GetViewSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.__callBase_PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.__callBase_GetAnimationOffset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.__callBase_IsCulled);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cache9);
		string name = "m_clipAnimator";
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.get_m_clipAnimator);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.set_m_clipAnimator);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheB, true);
		string name2 = "m_initOrthographicSize";
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.get_m_initOrthographicSize);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.set_m_initOrthographicSize);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheD, true);
		if (Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CutsceneCamera.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_CutsceneCamera.<>f__mg$cacheE, typeof(CutsceneCamera), typeof(CameraBase));
	}

	// Token: 0x04010AE5 RID: 68325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010AE6 RID: 68326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010AE7 RID: 68327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010AE8 RID: 68328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010AE9 RID: 68329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010AEA RID: 68330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010AEB RID: 68331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010AEC RID: 68332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010AED RID: 68333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010AEE RID: 68334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010AEF RID: 68335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010AF0 RID: 68336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010AF1 RID: 68337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010AF2 RID: 68338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010AF3 RID: 68339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
