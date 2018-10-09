using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x020017A3 RID: 6051
[Preserve]
public class Lua_UnityEngine_Rendering_SortingGroup : LuaObject
{
	// Token: 0x06023B17 RID: 146199 RVA: 0x00C7D5A0 File Offset: 0x00C7B7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortingLayerName(IntPtr l)
	{
		int result;
		try
		{
			SortingGroup sortingGroup = (SortingGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sortingGroup.sortingLayerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B18 RID: 146200 RVA: 0x00C7D5F4 File Offset: 0x00C7B7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sortingLayerName(IntPtr l)
	{
		int result;
		try
		{
			SortingGroup sortingGroup = (SortingGroup)LuaObject.checkSelf(l);
			string sortingLayerName;
			LuaObject.checkType(l, 2, out sortingLayerName);
			sortingGroup.sortingLayerName = sortingLayerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B19 RID: 146201 RVA: 0x00C7D64C File Offset: 0x00C7B84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortingLayerID(IntPtr l)
	{
		int result;
		try
		{
			SortingGroup sortingGroup = (SortingGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sortingGroup.sortingLayerID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B1A RID: 146202 RVA: 0x00C7D6A0 File Offset: 0x00C7B8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sortingLayerID(IntPtr l)
	{
		int result;
		try
		{
			SortingGroup sortingGroup = (SortingGroup)LuaObject.checkSelf(l);
			int sortingLayerID;
			LuaObject.checkType(l, 2, out sortingLayerID);
			sortingGroup.sortingLayerID = sortingLayerID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B1B RID: 146203 RVA: 0x00C7D6F8 File Offset: 0x00C7B8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortingOrder(IntPtr l)
	{
		int result;
		try
		{
			SortingGroup sortingGroup = (SortingGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sortingGroup.sortingOrder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B1C RID: 146204 RVA: 0x00C7D74C File Offset: 0x00C7B94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sortingOrder(IntPtr l)
	{
		int result;
		try
		{
			SortingGroup sortingGroup = (SortingGroup)LuaObject.checkSelf(l);
			int sortingOrder;
			LuaObject.checkType(l, 2, out sortingOrder);
			sortingGroup.sortingOrder = sortingOrder;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B1D RID: 146205 RVA: 0x00C7D7A4 File Offset: 0x00C7B9A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Rendering.SortingGroup");
		string name = "sortingLayerName";
		if (Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Rendering_SortingGroup.get_sortingLayerName);
		}
		LuaCSFunction get = Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache0;
		if (Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Rendering_SortingGroup.set_sortingLayerName);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache1, true);
		string name2 = "sortingLayerID";
		if (Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Rendering_SortingGroup.get_sortingLayerID);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache2;
		if (Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Rendering_SortingGroup.set_sortingLayerID);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache3, true);
		string name3 = "sortingOrder";
		if (Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Rendering_SortingGroup.get_sortingOrder);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache4;
		if (Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Rendering_SortingGroup.set_sortingOrder);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Rendering_SortingGroup.<>f__mg$cache5, true);
		LuaObject.createTypeMetatable(l, null, typeof(SortingGroup), typeof(Behaviour));
	}

	// Token: 0x0401982F RID: 104495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019830 RID: 104496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019831 RID: 104497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019832 RID: 104498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019833 RID: 104499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019834 RID: 104500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
