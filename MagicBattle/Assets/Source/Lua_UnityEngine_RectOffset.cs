using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200176F RID: 5999
[Preserve]
public class Lua_UnityEngine_RectOffset : LuaObject
{
	// Token: 0x060239BC RID: 145852 RVA: 0x00C715F0 File Offset: 0x00C6F7F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				RectOffset o = new RectOffset();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 5)
			{
				int left;
				LuaObject.checkType(l, 2, out left);
				int right;
				LuaObject.checkType(l, 3, out right);
				int top;
				LuaObject.checkType(l, 4, out top);
				int bottom;
				LuaObject.checkType(l, 5, out bottom);
				RectOffset o = new RectOffset(left, right, top, bottom);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239BD RID: 145853 RVA: 0x00C716AC File Offset: 0x00C6F8AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Add(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 2, out rect);
			Rect rect2 = rectOffset.Add(rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239BE RID: 145854 RVA: 0x00C71714 File Offset: 0x00C6F914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Remove(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 2, out rect);
			Rect rect2 = rectOffset.Remove(rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239BF RID: 145855 RVA: 0x00C7177C File Offset: 0x00C6F97C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_left(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectOffset.left);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239C0 RID: 145856 RVA: 0x00C717D0 File Offset: 0x00C6F9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_left(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			int left;
			LuaObject.checkType(l, 2, out left);
			rectOffset.left = left;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239C1 RID: 145857 RVA: 0x00C71828 File Offset: 0x00C6FA28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_right(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectOffset.right);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239C2 RID: 145858 RVA: 0x00C7187C File Offset: 0x00C6FA7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_right(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			int right;
			LuaObject.checkType(l, 2, out right);
			rectOffset.right = right;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239C3 RID: 145859 RVA: 0x00C718D4 File Offset: 0x00C6FAD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_top(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectOffset.top);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239C4 RID: 145860 RVA: 0x00C71928 File Offset: 0x00C6FB28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_top(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			int top;
			LuaObject.checkType(l, 2, out top);
			rectOffset.top = top;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239C5 RID: 145861 RVA: 0x00C71980 File Offset: 0x00C6FB80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_bottom(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectOffset.bottom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239C6 RID: 145862 RVA: 0x00C719D4 File Offset: 0x00C6FBD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_bottom(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			int bottom;
			LuaObject.checkType(l, 2, out bottom);
			rectOffset.bottom = bottom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239C7 RID: 145863 RVA: 0x00C71A2C File Offset: 0x00C6FC2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_horizontal(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectOffset.horizontal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239C8 RID: 145864 RVA: 0x00C71A80 File Offset: 0x00C6FC80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_vertical(IntPtr l)
	{
		int result;
		try
		{
			RectOffset rectOffset = (RectOffset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectOffset.vertical);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239C9 RID: 145865 RVA: 0x00C71AD4 File Offset: 0x00C6FCD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RectOffset");
		if (Lua_UnityEngine_RectOffset.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RectOffset.Add);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectOffset.<>f__mg$cache0);
		if (Lua_UnityEngine_RectOffset.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RectOffset.Remove);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectOffset.<>f__mg$cache1);
		string name = "left";
		if (Lua_UnityEngine_RectOffset.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RectOffset.get_left);
		}
		LuaCSFunction get = Lua_UnityEngine_RectOffset.<>f__mg$cache2;
		if (Lua_UnityEngine_RectOffset.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RectOffset.set_left);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_RectOffset.<>f__mg$cache3, true);
		string name2 = "right";
		if (Lua_UnityEngine_RectOffset.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RectOffset.get_right);
		}
		LuaCSFunction get2 = Lua_UnityEngine_RectOffset.<>f__mg$cache4;
		if (Lua_UnityEngine_RectOffset.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RectOffset.set_right);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_RectOffset.<>f__mg$cache5, true);
		string name3 = "top";
		if (Lua_UnityEngine_RectOffset.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_RectOffset.get_top);
		}
		LuaCSFunction get3 = Lua_UnityEngine_RectOffset.<>f__mg$cache6;
		if (Lua_UnityEngine_RectOffset.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_RectOffset.set_top);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_RectOffset.<>f__mg$cache7, true);
		string name4 = "bottom";
		if (Lua_UnityEngine_RectOffset.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_RectOffset.get_bottom);
		}
		LuaCSFunction get4 = Lua_UnityEngine_RectOffset.<>f__mg$cache8;
		if (Lua_UnityEngine_RectOffset.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_RectOffset.set_bottom);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_RectOffset.<>f__mg$cache9, true);
		string name5 = "horizontal";
		if (Lua_UnityEngine_RectOffset.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_RectOffset.get_horizontal);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_RectOffset.<>f__mg$cacheA, null, true);
		string name6 = "vertical";
		if (Lua_UnityEngine_RectOffset.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_RectOffset.get_vertical);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_RectOffset.<>f__mg$cacheB, null, true);
		if (Lua_UnityEngine_RectOffset.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_RectOffset.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_RectOffset.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_RectOffset.<>f__mg$cacheC, typeof(RectOffset));
	}

	// Token: 0x0401973C RID: 104252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401973D RID: 104253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401973E RID: 104254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401973F RID: 104255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019740 RID: 104256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019741 RID: 104257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019742 RID: 104258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019743 RID: 104259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019744 RID: 104260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019745 RID: 104261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019746 RID: 104262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019747 RID: 104263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019748 RID: 104264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
