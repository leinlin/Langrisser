using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001691 RID: 5777
[Preserve]
public class Lua_UnityEngine_DynamicGI : LuaObject
{
	// Token: 0x0602308C RID: 143500 RVA: 0x00C22144 File Offset: 0x00C20344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DynamicGI o = new DynamicGI();
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

	// Token: 0x0602308D RID: 143501 RVA: 0x00C2218C File Offset: 0x00C2038C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEmissive_s(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer;
			LuaObject.checkType<Renderer>(l, 1, out renderer);
			Color color;
			LuaObject.checkType(l, 2, out color);
			DynamicGI.SetEmissive(renderer, color);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602308E RID: 143502 RVA: 0x00C221E4 File Offset: 0x00C203E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEnvironmentData_s(IntPtr l)
	{
		int result;
		try
		{
			float[] environmentData;
			LuaObject.checkArray<float>(l, 1, out environmentData);
			DynamicGI.SetEnvironmentData(environmentData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602308F RID: 143503 RVA: 0x00C22230 File Offset: 0x00C20430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateEnvironment_s(IntPtr l)
	{
		int result;
		try
		{
			DynamicGI.UpdateEnvironment();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023090 RID: 143504 RVA: 0x00C22270 File Offset: 0x00C20470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_indirectScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DynamicGI.indirectScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023091 RID: 143505 RVA: 0x00C222B8 File Offset: 0x00C204B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_indirectScale(IntPtr l)
	{
		int result;
		try
		{
			float indirectScale;
			LuaObject.checkType(l, 2, out indirectScale);
			DynamicGI.indirectScale = indirectScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023092 RID: 143506 RVA: 0x00C22304 File Offset: 0x00C20504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateThreshold(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DynamicGI.updateThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023093 RID: 143507 RVA: 0x00C2234C File Offset: 0x00C2054C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_updateThreshold(IntPtr l)
	{
		int result;
		try
		{
			float updateThreshold;
			LuaObject.checkType(l, 2, out updateThreshold);
			DynamicGI.updateThreshold = updateThreshold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023094 RID: 143508 RVA: 0x00C22398 File Offset: 0x00C20598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_synchronousMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DynamicGI.synchronousMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023095 RID: 143509 RVA: 0x00C223E0 File Offset: 0x00C205E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_synchronousMode(IntPtr l)
	{
		int result;
		try
		{
			bool synchronousMode;
			LuaObject.checkType(l, 2, out synchronousMode);
			DynamicGI.synchronousMode = synchronousMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023096 RID: 143510 RVA: 0x00C2242C File Offset: 0x00C2062C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isConverged(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, DynamicGI.isConverged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023097 RID: 143511 RVA: 0x00C22474 File Offset: 0x00C20674
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.DynamicGI");
		if (Lua_UnityEngine_DynamicGI.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_DynamicGI.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_DynamicGI.SetEmissive_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_DynamicGI.<>f__mg$cache0);
		if (Lua_UnityEngine_DynamicGI.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_DynamicGI.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_DynamicGI.SetEnvironmentData_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_DynamicGI.<>f__mg$cache1);
		if (Lua_UnityEngine_DynamicGI.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_DynamicGI.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_DynamicGI.UpdateEnvironment_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_DynamicGI.<>f__mg$cache2);
		string name = "indirectScale";
		if (Lua_UnityEngine_DynamicGI.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_DynamicGI.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_DynamicGI.get_indirectScale);
		}
		LuaCSFunction get = Lua_UnityEngine_DynamicGI.<>f__mg$cache3;
		if (Lua_UnityEngine_DynamicGI.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_DynamicGI.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_DynamicGI.set_indirectScale);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_DynamicGI.<>f__mg$cache4, false);
		string name2 = "updateThreshold";
		if (Lua_UnityEngine_DynamicGI.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_DynamicGI.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_DynamicGI.get_updateThreshold);
		}
		LuaCSFunction get2 = Lua_UnityEngine_DynamicGI.<>f__mg$cache5;
		if (Lua_UnityEngine_DynamicGI.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_DynamicGI.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_DynamicGI.set_updateThreshold);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_DynamicGI.<>f__mg$cache6, false);
		string name3 = "synchronousMode";
		if (Lua_UnityEngine_DynamicGI.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_DynamicGI.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_DynamicGI.get_synchronousMode);
		}
		LuaCSFunction get3 = Lua_UnityEngine_DynamicGI.<>f__mg$cache7;
		if (Lua_UnityEngine_DynamicGI.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_DynamicGI.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_DynamicGI.set_synchronousMode);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_DynamicGI.<>f__mg$cache8, false);
		string name4 = "isConverged";
		if (Lua_UnityEngine_DynamicGI.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_DynamicGI.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_DynamicGI.get_isConverged);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_DynamicGI.<>f__mg$cache9, null, false);
		if (Lua_UnityEngine_DynamicGI.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_DynamicGI.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_DynamicGI.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_DynamicGI.<>f__mg$cacheA, typeof(DynamicGI));
	}

	// Token: 0x04018FC8 RID: 102344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018FC9 RID: 102345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018FCA RID: 102346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018FCB RID: 102347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018FCC RID: 102348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018FCD RID: 102349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018FCE RID: 102350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018FCF RID: 102351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018FD0 RID: 102352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018FD1 RID: 102353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018FD2 RID: 102354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
