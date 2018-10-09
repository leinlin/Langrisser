using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001809 RID: 6153
[Preserve]
public class Lua_UnityEngine_UI_AnimationTriggers : LuaObject
{
	// Token: 0x06023F79 RID: 147321 RVA: 0x00C9F7C0 File Offset: 0x00C9D9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimationTriggers o = new AnimationTriggers();
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

	// Token: 0x06023F7A RID: 147322 RVA: 0x00C9F808 File Offset: 0x00C9DA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalTrigger(IntPtr l)
	{
		int result;
		try
		{
			AnimationTriggers animationTriggers = (AnimationTriggers)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationTriggers.normalTrigger);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F7B RID: 147323 RVA: 0x00C9F85C File Offset: 0x00C9DA5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_normalTrigger(IntPtr l)
	{
		int result;
		try
		{
			AnimationTriggers animationTriggers = (AnimationTriggers)LuaObject.checkSelf(l);
			string normalTrigger;
			LuaObject.checkType(l, 2, out normalTrigger);
			animationTriggers.normalTrigger = normalTrigger;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F7C RID: 147324 RVA: 0x00C9F8B4 File Offset: 0x00C9DAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_highlightedTrigger(IntPtr l)
	{
		int result;
		try
		{
			AnimationTriggers animationTriggers = (AnimationTriggers)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationTriggers.highlightedTrigger);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F7D RID: 147325 RVA: 0x00C9F908 File Offset: 0x00C9DB08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_highlightedTrigger(IntPtr l)
	{
		int result;
		try
		{
			AnimationTriggers animationTriggers = (AnimationTriggers)LuaObject.checkSelf(l);
			string highlightedTrigger;
			LuaObject.checkType(l, 2, out highlightedTrigger);
			animationTriggers.highlightedTrigger = highlightedTrigger;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F7E RID: 147326 RVA: 0x00C9F960 File Offset: 0x00C9DB60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_pressedTrigger(IntPtr l)
	{
		int result;
		try
		{
			AnimationTriggers animationTriggers = (AnimationTriggers)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationTriggers.pressedTrigger);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F7F RID: 147327 RVA: 0x00C9F9B4 File Offset: 0x00C9DBB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_pressedTrigger(IntPtr l)
	{
		int result;
		try
		{
			AnimationTriggers animationTriggers = (AnimationTriggers)LuaObject.checkSelf(l);
			string pressedTrigger;
			LuaObject.checkType(l, 2, out pressedTrigger);
			animationTriggers.pressedTrigger = pressedTrigger;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F80 RID: 147328 RVA: 0x00C9FA0C File Offset: 0x00C9DC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_disabledTrigger(IntPtr l)
	{
		int result;
		try
		{
			AnimationTriggers animationTriggers = (AnimationTriggers)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationTriggers.disabledTrigger);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F81 RID: 147329 RVA: 0x00C9FA60 File Offset: 0x00C9DC60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_disabledTrigger(IntPtr l)
	{
		int result;
		try
		{
			AnimationTriggers animationTriggers = (AnimationTriggers)LuaObject.checkSelf(l);
			string disabledTrigger;
			LuaObject.checkType(l, 2, out disabledTrigger);
			animationTriggers.disabledTrigger = disabledTrigger;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F82 RID: 147330 RVA: 0x00C9FAB8 File Offset: 0x00C9DCB8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.AnimationTriggers");
		string name = "normalTrigger";
		if (Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_AnimationTriggers.get_normalTrigger);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache0;
		if (Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_AnimationTriggers.set_normalTrigger);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache1, true);
		string name2 = "highlightedTrigger";
		if (Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_AnimationTriggers.get_highlightedTrigger);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_AnimationTriggers.set_highlightedTrigger);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache3, true);
		string name3 = "pressedTrigger";
		if (Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_AnimationTriggers.get_pressedTrigger);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_AnimationTriggers.set_pressedTrigger);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache5, true);
		string name4 = "disabledTrigger";
		if (Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_AnimationTriggers.get_disabledTrigger);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache6;
		if (Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_AnimationTriggers.set_disabledTrigger);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache7, true);
		if (Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_AnimationTriggers.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_AnimationTriggers.<>f__mg$cache8, typeof(AnimationTriggers));
	}

	// Token: 0x04019BC5 RID: 105413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019BC6 RID: 105414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019BC7 RID: 105415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019BC8 RID: 105416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019BC9 RID: 105417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019BCA RID: 105418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019BCB RID: 105419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019BCC RID: 105420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019BCD RID: 105421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
