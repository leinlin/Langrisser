using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x0200169F RID: 5791
[Preserve]
public class Lua_UnityEngine_EventSystems_BaseInputModule : LuaObject
{
	// Token: 0x06023113 RID: 143635 RVA: 0x00C257AC File Offset: 0x00C239AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Process(IntPtr l)
	{
		int result;
		try
		{
			BaseInputModule baseInputModule = (BaseInputModule)LuaObject.checkSelf(l);
			baseInputModule.Process();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023114 RID: 143636 RVA: 0x00C257F8 File Offset: 0x00C239F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPointerOverGameObject(IntPtr l)
	{
		int result;
		try
		{
			BaseInputModule baseInputModule = (BaseInputModule)LuaObject.checkSelf(l);
			int pointerId;
			LuaObject.checkType(l, 2, out pointerId);
			bool b = baseInputModule.IsPointerOverGameObject(pointerId);
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

	// Token: 0x06023115 RID: 143637 RVA: 0x00C2585C File Offset: 0x00C23A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShouldActivateModule(IntPtr l)
	{
		int result;
		try
		{
			BaseInputModule baseInputModule = (BaseInputModule)LuaObject.checkSelf(l);
			bool b = baseInputModule.ShouldActivateModule();
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

	// Token: 0x06023116 RID: 143638 RVA: 0x00C258B0 File Offset: 0x00C23AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeactivateModule(IntPtr l)
	{
		int result;
		try
		{
			BaseInputModule baseInputModule = (BaseInputModule)LuaObject.checkSelf(l);
			baseInputModule.DeactivateModule();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023117 RID: 143639 RVA: 0x00C258FC File Offset: 0x00C23AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivateModule(IntPtr l)
	{
		int result;
		try
		{
			BaseInputModule baseInputModule = (BaseInputModule)LuaObject.checkSelf(l);
			baseInputModule.ActivateModule();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023118 RID: 143640 RVA: 0x00C25948 File Offset: 0x00C23B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateModule(IntPtr l)
	{
		int result;
		try
		{
			BaseInputModule baseInputModule = (BaseInputModule)LuaObject.checkSelf(l);
			baseInputModule.UpdateModule();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023119 RID: 143641 RVA: 0x00C25994 File Offset: 0x00C23B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsModuleSupported(IntPtr l)
	{
		int result;
		try
		{
			BaseInputModule baseInputModule = (BaseInputModule)LuaObject.checkSelf(l);
			bool b = baseInputModule.IsModuleSupported();
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

	// Token: 0x0602311A RID: 143642 RVA: 0x00C259E8 File Offset: 0x00C23BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_input(IntPtr l)
	{
		int result;
		try
		{
			BaseInputModule baseInputModule = (BaseInputModule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseInputModule.input);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602311B RID: 143643 RVA: 0x00C25A3C File Offset: 0x00C23C3C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.BaseInputModule");
		if (Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInputModule.Process);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache0);
		if (Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInputModule.IsPointerOverGameObject);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache1);
		if (Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInputModule.ShouldActivateModule);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache2);
		if (Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInputModule.DeactivateModule);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache3);
		if (Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInputModule.ActivateModule);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache4);
		if (Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInputModule.UpdateModule);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache5);
		if (Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInputModule.IsModuleSupported);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache6);
		string name = "input";
		if (Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInputModule.get_input);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_EventSystems_BaseInputModule.<>f__mg$cache7, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(BaseInputModule), typeof(UIBehaviour));
	}

	// Token: 0x04019033 RID: 102451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019034 RID: 102452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019035 RID: 102453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019036 RID: 102454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019037 RID: 102455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019038 RID: 102456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019039 RID: 102457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401903A RID: 102458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
