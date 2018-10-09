using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001703 RID: 5891
[Preserve]
public class Lua_UnityEngine_LayerMask : LuaObject
{
	// Token: 0x06023458 RID: 144472 RVA: 0x00C3F778 File Offset: 0x00C3D978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LayerMask mask = default(LayerMask);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023459 RID: 144473 RVA: 0x00C3F7C8 File Offset: 0x00C3D9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LayerToName_s(IntPtr l)
	{
		int result;
		try
		{
			int layer;
			LuaObject.checkType(l, 1, out layer);
			string s = LayerMask.LayerToName(layer);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602345A RID: 144474 RVA: 0x00C3F81C File Offset: 0x00C3DA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NameToLayer_s(IntPtr l)
	{
		int result;
		try
		{
			string layerName;
			LuaObject.checkType(l, 1, out layerName);
			int i = LayerMask.NameToLayer(layerName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602345B RID: 144475 RVA: 0x00C3F870 File Offset: 0x00C3DA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMask_s(IntPtr l)
	{
		int result;
		try
		{
			string[] layerNames;
			LuaObject.checkParams(l, 1, out layerNames);
			int mask = LayerMask.GetMask(layerNames);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602345C RID: 144476 RVA: 0x00C3F8C4 File Offset: 0x00C3DAC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_value(IntPtr l)
	{
		int result;
		try
		{
			LayerMask layerMask;
			LuaObject.checkValueType<LayerMask>(l, 1, out layerMask);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerMask.value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602345D RID: 144477 RVA: 0x00C3F918 File Offset: 0x00C3DB18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_value(IntPtr l)
	{
		int result;
		try
		{
			LayerMask layerMask;
			LuaObject.checkValueType<LayerMask>(l, 1, out layerMask);
			int value;
			LuaObject.checkType(l, 2, out value);
			layerMask.value = value;
			LuaObject.setBack(l, layerMask);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602345E RID: 144478 RVA: 0x00C3F97C File Offset: 0x00C3DB7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LayerMask");
		if (Lua_UnityEngine_LayerMask.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LayerMask.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LayerMask.LayerToName_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LayerMask.<>f__mg$cache0);
		if (Lua_UnityEngine_LayerMask.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LayerMask.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LayerMask.NameToLayer_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LayerMask.<>f__mg$cache1);
		if (Lua_UnityEngine_LayerMask.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LayerMask.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LayerMask.GetMask_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LayerMask.<>f__mg$cache2);
		string name = "value";
		if (Lua_UnityEngine_LayerMask.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LayerMask.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LayerMask.get_value);
		}
		LuaCSFunction get = Lua_UnityEngine_LayerMask.<>f__mg$cache3;
		if (Lua_UnityEngine_LayerMask.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LayerMask.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LayerMask.set_value);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_LayerMask.<>f__mg$cache4, true);
		if (Lua_UnityEngine_LayerMask.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LayerMask.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LayerMask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_LayerMask.<>f__mg$cache5, typeof(LayerMask), typeof(ValueType));
	}

	// Token: 0x040192B0 RID: 103088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040192B1 RID: 103089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040192B2 RID: 103090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040192B3 RID: 103091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040192B4 RID: 103092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040192B5 RID: 103093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
