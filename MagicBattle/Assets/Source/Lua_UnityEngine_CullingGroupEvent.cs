using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200167F RID: 5759
[Preserve]
public class Lua_UnityEngine_CullingGroupEvent : LuaObject
{
	// Token: 0x06023005 RID: 143365 RVA: 0x00C1E3EC File Offset: 0x00C1C5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CullingGroupEvent cullingGroupEvent = default(CullingGroupEvent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cullingGroupEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023006 RID: 143366 RVA: 0x00C1E43C File Offset: 0x00C1C63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_index(IntPtr l)
	{
		int result;
		try
		{
			CullingGroupEvent cullingGroupEvent;
			LuaObject.checkValueType<CullingGroupEvent>(l, 1, out cullingGroupEvent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cullingGroupEvent.index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023007 RID: 143367 RVA: 0x00C1E490 File Offset: 0x00C1C690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isVisible(IntPtr l)
	{
		int result;
		try
		{
			CullingGroupEvent cullingGroupEvent;
			LuaObject.checkValueType<CullingGroupEvent>(l, 1, out cullingGroupEvent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cullingGroupEvent.isVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023008 RID: 143368 RVA: 0x00C1E4E4 File Offset: 0x00C1C6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_wasVisible(IntPtr l)
	{
		int result;
		try
		{
			CullingGroupEvent cullingGroupEvent;
			LuaObject.checkValueType<CullingGroupEvent>(l, 1, out cullingGroupEvent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cullingGroupEvent.wasVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023009 RID: 143369 RVA: 0x00C1E538 File Offset: 0x00C1C738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasBecomeVisible(IntPtr l)
	{
		int result;
		try
		{
			CullingGroupEvent cullingGroupEvent;
			LuaObject.checkValueType<CullingGroupEvent>(l, 1, out cullingGroupEvent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cullingGroupEvent.hasBecomeVisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602300A RID: 143370 RVA: 0x00C1E58C File Offset: 0x00C1C78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasBecomeInvisible(IntPtr l)
	{
		int result;
		try
		{
			CullingGroupEvent cullingGroupEvent;
			LuaObject.checkValueType<CullingGroupEvent>(l, 1, out cullingGroupEvent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cullingGroupEvent.hasBecomeInvisible);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602300B RID: 143371 RVA: 0x00C1E5E0 File Offset: 0x00C1C7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_currentDistance(IntPtr l)
	{
		int result;
		try
		{
			CullingGroupEvent cullingGroupEvent;
			LuaObject.checkValueType<CullingGroupEvent>(l, 1, out cullingGroupEvent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cullingGroupEvent.currentDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602300C RID: 143372 RVA: 0x00C1E634 File Offset: 0x00C1C834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_previousDistance(IntPtr l)
	{
		int result;
		try
		{
			CullingGroupEvent cullingGroupEvent;
			LuaObject.checkValueType<CullingGroupEvent>(l, 1, out cullingGroupEvent);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cullingGroupEvent.previousDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602300D RID: 143373 RVA: 0x00C1E688 File Offset: 0x00C1C888
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CullingGroupEvent");
		string name = "index";
		if (Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CullingGroupEvent.get_index);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache0, null, true);
		string name2 = "isVisible";
		if (Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CullingGroupEvent.get_isVisible);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache1, null, true);
		string name3 = "wasVisible";
		if (Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CullingGroupEvent.get_wasVisible);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache2, null, true);
		string name4 = "hasBecomeVisible";
		if (Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CullingGroupEvent.get_hasBecomeVisible);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache3, null, true);
		string name5 = "hasBecomeInvisible";
		if (Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CullingGroupEvent.get_hasBecomeInvisible);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache4, null, true);
		string name6 = "currentDistance";
		if (Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CullingGroupEvent.get_currentDistance);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache5, null, true);
		string name7 = "previousDistance";
		if (Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CullingGroupEvent.get_previousDistance);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache6, null, true);
		if (Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CullingGroupEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_CullingGroupEvent.<>f__mg$cache7, typeof(CullingGroupEvent), typeof(ValueType));
	}

	// Token: 0x04018F65 RID: 102245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F66 RID: 102246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F67 RID: 102247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F68 RID: 102248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F69 RID: 102249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F6A RID: 102250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018F6B RID: 102251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018F6C RID: 102252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
