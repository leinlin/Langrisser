using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017DA RID: 6106
[Preserve]
public class Lua_UnityEngine_SortingLayer : LuaObject
{
	// Token: 0x06023D5B RID: 146779 RVA: 0x00C8F1D4 File Offset: 0x00C8D3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SortingLayer sortingLayer = default(SortingLayer);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sortingLayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D5C RID: 146780 RVA: 0x00C8F224 File Offset: 0x00C8D424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerValueFromID_s(IntPtr l)
	{
		int result;
		try
		{
			int id;
			LuaObject.checkType(l, 1, out id);
			int layerValueFromID = SortingLayer.GetLayerValueFromID(id);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerValueFromID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D5D RID: 146781 RVA: 0x00C8F278 File Offset: 0x00C8D478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerValueFromName_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			int layerValueFromName = SortingLayer.GetLayerValueFromName(name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerValueFromName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D5E RID: 146782 RVA: 0x00C8F2CC File Offset: 0x00C8D4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NameToID_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			int i = SortingLayer.NameToID(name);
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

	// Token: 0x06023D5F RID: 146783 RVA: 0x00C8F320 File Offset: 0x00C8D520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IDToName_s(IntPtr l)
	{
		int result;
		try
		{
			int id;
			LuaObject.checkType(l, 1, out id);
			string s = SortingLayer.IDToName(id);
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

	// Token: 0x06023D60 RID: 146784 RVA: 0x00C8F374 File Offset: 0x00C8D574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsValid_s(IntPtr l)
	{
		int result;
		try
		{
			int id;
			LuaObject.checkType(l, 1, out id);
			bool b = SortingLayer.IsValid(id);
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

	// Token: 0x06023D61 RID: 146785 RVA: 0x00C8F3C8 File Offset: 0x00C8D5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_id(IntPtr l)
	{
		int result;
		try
		{
			SortingLayer sortingLayer;
			LuaObject.checkValueType<SortingLayer>(l, 1, out sortingLayer);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sortingLayer.id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D62 RID: 146786 RVA: 0x00C8F41C File Offset: 0x00C8D61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_name(IntPtr l)
	{
		int result;
		try
		{
			SortingLayer sortingLayer;
			LuaObject.checkValueType<SortingLayer>(l, 1, out sortingLayer);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sortingLayer.name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D63 RID: 146787 RVA: 0x00C8F470 File Offset: 0x00C8D670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_value(IntPtr l)
	{
		int result;
		try
		{
			SortingLayer sortingLayer;
			LuaObject.checkValueType<SortingLayer>(l, 1, out sortingLayer);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sortingLayer.value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D64 RID: 146788 RVA: 0x00C8F4C4 File Offset: 0x00C8D6C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layers(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SortingLayer.layers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D65 RID: 146789 RVA: 0x00C8F50C File Offset: 0x00C8D70C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SortingLayer");
		if (Lua_UnityEngine_SortingLayer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SortingLayer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SortingLayer.GetLayerValueFromID_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SortingLayer.<>f__mg$cache0);
		if (Lua_UnityEngine_SortingLayer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SortingLayer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SortingLayer.GetLayerValueFromName_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SortingLayer.<>f__mg$cache1);
		if (Lua_UnityEngine_SortingLayer.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SortingLayer.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SortingLayer.NameToID_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SortingLayer.<>f__mg$cache2);
		if (Lua_UnityEngine_SortingLayer.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SortingLayer.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SortingLayer.IDToName_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SortingLayer.<>f__mg$cache3);
		if (Lua_UnityEngine_SortingLayer.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SortingLayer.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SortingLayer.IsValid_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SortingLayer.<>f__mg$cache4);
		string name = "id";
		if (Lua_UnityEngine_SortingLayer.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SortingLayer.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SortingLayer.get_id);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_SortingLayer.<>f__mg$cache5, null, true);
		string name2 = "name";
		if (Lua_UnityEngine_SortingLayer.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SortingLayer.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SortingLayer.get_name);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_SortingLayer.<>f__mg$cache6, null, true);
		string name3 = "value";
		if (Lua_UnityEngine_SortingLayer.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_SortingLayer.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_SortingLayer.get_value);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_SortingLayer.<>f__mg$cache7, null, true);
		string name4 = "layers";
		if (Lua_UnityEngine_SortingLayer.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_SortingLayer.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_SortingLayer.get_layers);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_SortingLayer.<>f__mg$cache8, null, false);
		if (Lua_UnityEngine_SortingLayer.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_SortingLayer.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_SortingLayer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_SortingLayer.<>f__mg$cache9, typeof(SortingLayer), typeof(ValueType));
	}

	// Token: 0x04019A05 RID: 104965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A06 RID: 104966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A07 RID: 104967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A08 RID: 104968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019A09 RID: 104969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019A0A RID: 104970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019A0B RID: 104971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019A0C RID: 104972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019A0D RID: 104973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019A0E RID: 104974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
