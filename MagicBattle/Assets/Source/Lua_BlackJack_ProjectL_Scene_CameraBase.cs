using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020012ED RID: 4845
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_CameraBase : LuaObject
{
	// Token: 0x0601A18C RID: 106892 RVA: 0x007ABB6C File Offset: 0x007A9D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CameraBase o = new CameraBase();
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

	// Token: 0x0601A18D RID: 106893 RVA: 0x007ABBB4 File Offset: 0x007A9DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetViewSize(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			float o;
			float o2;
			cameraBase.GetViewSize(out o, out o2);
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

	// Token: 0x0601A18E RID: 106894 RVA: 0x007ABC14 File Offset: 0x007A9E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			cameraBase.PlayAnimation(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A18F RID: 106895 RVA: 0x007ABC6C File Offset: 0x007A9E6C
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
				CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
				Vector2 p;
				LuaObject.checkType(l, 2, out p);
				bool b = cameraBase.IsCulled(p);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				CameraBase cameraBase2 = (CameraBase)LuaObject.checkSelf(l);
				Vector2 bmin;
				LuaObject.checkType(l, 2, out bmin);
				Vector2 bmax;
				LuaObject.checkType(l, 3, out bmax);
				bool b2 = cameraBase2.IsCulled(bmin, bmax);
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

	// Token: 0x0601A190 RID: 106896 RVA: 0x007ABD44 File Offset: 0x007A9F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetViewSize_s(IntPtr l)
	{
		int result;
		try
		{
			Camera cam;
			LuaObject.checkType<Camera>(l, 1, out cam);
			float o;
			float o2;
			CameraBase.GetViewSize(cam, out o, out o2);
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

	// Token: 0x0601A191 RID: 106897 RVA: 0x007ABDA4 File Offset: 0x007A9FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCulled_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Camera cam;
				LuaObject.checkType<Camera>(l, 1, out cam);
				Vector2 p;
				LuaObject.checkType(l, 2, out p);
				bool b = CameraBase.IsCulled(cam, p);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				Camera cam2;
				LuaObject.checkType<Camera>(l, 1, out cam2);
				Vector2 bmin;
				LuaObject.checkType(l, 2, out bmin);
				Vector2 bmax;
				LuaObject.checkType(l, 3, out bmax);
				bool b2 = CameraBase.IsCulled(cam2, bmin, bmax);
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

	// Token: 0x0601A192 RID: 106898 RVA: 0x007ABE78 File Offset: 0x007AA078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AspectScale_s(IntPtr l)
	{
		int result;
		try
		{
			float o = CameraBase.AspectScale();
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

	// Token: 0x0601A193 RID: 106899 RVA: 0x007ABEC0 File Offset: 0x007AA0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			GameObject cameraGo;
			LuaObject.checkType<GameObject>(l, 2, out cameraGo);
			GameObject animatorGo;
			LuaObject.checkType<GameObject>(l, 3, out animatorGo);
			cameraBase.m_luaExportHelper.Initialize(cameraGo, animatorGo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A194 RID: 106900 RVA: 0x007ABF2C File Offset: 0x007AA12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnimationOffset(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			Vector3 animationOffset = cameraBase.m_luaExportHelper.GetAnimationOffset();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A195 RID: 106901 RVA: 0x007ABF88 File Offset: 0x007AA188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_camera(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cameraBase.m_luaExportHelper.m_camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A196 RID: 106902 RVA: 0x007ABFE0 File Offset: 0x007AA1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_camera(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			cameraBase.m_luaExportHelper.m_camera = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A197 RID: 106903 RVA: 0x007AC03C File Offset: 0x007AA23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_animator(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cameraBase.m_luaExportHelper.m_animator);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A198 RID: 106904 RVA: 0x007AC094 File Offset: 0x007AA294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_animator(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			Animator animator;
			LuaObject.checkType<Animator>(l, 2, out animator);
			cameraBase.m_luaExportHelper.m_animator = animator;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A199 RID: 106905 RVA: 0x007AC0F0 File Offset: 0x007AA2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_animationGameObject(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cameraBase.m_luaExportHelper.m_animationGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A19A RID: 106906 RVA: 0x007AC148 File Offset: 0x007AA348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_animationGameObject(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			GameObject animationGameObject;
			LuaObject.checkType<GameObject>(l, 2, out animationGameObject);
			cameraBase.m_luaExportHelper.m_animationGameObject = animationGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A19B RID: 106907 RVA: 0x007AC1A4 File Offset: 0x007AA3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cameraBase.m_luaExportHelper.m_isPlayAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A19C RID: 106908 RVA: 0x007AC1FC File Offset: 0x007AA3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			bool isPlayAnimation;
			LuaObject.checkType(l, 2, out isPlayAnimation);
			cameraBase.m_luaExportHelper.m_isPlayAnimation = isPlayAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A19D RID: 106909 RVA: 0x007AC258 File Offset: 0x007AA458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Camera(IntPtr l)
	{
		int result;
		try
		{
			CameraBase cameraBase = (CameraBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cameraBase.Camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A19E RID: 106910 RVA: 0x007AC2AC File Offset: 0x007AA4AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.CameraBase");
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.GetViewSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.IsCulled);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.GetViewSize_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.IsCulled_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.AspectScale_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.GetAnimationOffset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache7);
		string name = "m_camera";
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.get_m_camera);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.set_m_camera);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache9, true);
		string name2 = "m_animator";
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.get_m_animator);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.set_m_animator);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheB, true);
		string name3 = "m_animationGameObject";
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.get_m_animationGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.set_m_animationGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheD, true);
		string name4 = "m_isPlayAnimation";
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.get_m_isPlayAnimation);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.set_m_isPlayAnimation);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cacheF, true);
		string name5 = "Camera";
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.get_Camera);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache10, null, true);
		if (Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_CameraBase.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_CameraBase.<>f__mg$cache11, typeof(CameraBase));
	}

	// Token: 0x04010594 RID: 66964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010595 RID: 66965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010596 RID: 66966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010597 RID: 66967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010598 RID: 66968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010599 RID: 66969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401059A RID: 66970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401059B RID: 66971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401059C RID: 66972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401059D RID: 66973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401059E RID: 66974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401059F RID: 66975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040105A0 RID: 66976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040105A1 RID: 66977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040105A2 RID: 66978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040105A3 RID: 66979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040105A4 RID: 66980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040105A5 RID: 66981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
