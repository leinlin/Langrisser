using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200186B RID: 6251
[Preserve]
public class Lua_UnityEngine_UILineInfo : LuaObject
{
	// Token: 0x06024322 RID: 148258 RVA: 0x00CB73AC File Offset: 0x00CB55AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UILineInfo uilineInfo = default(UILineInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uilineInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024323 RID: 148259 RVA: 0x00CB73FC File Offset: 0x00CB55FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_startCharIdx(IntPtr l)
	{
		int result;
		try
		{
			UILineInfo uilineInfo;
			LuaObject.checkValueType<UILineInfo>(l, 1, out uilineInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uilineInfo.startCharIdx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024324 RID: 148260 RVA: 0x00CB7450 File Offset: 0x00CB5650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_startCharIdx(IntPtr l)
	{
		int result;
		try
		{
			UILineInfo uilineInfo;
			LuaObject.checkValueType<UILineInfo>(l, 1, out uilineInfo);
			int startCharIdx;
			LuaObject.checkType(l, 2, out startCharIdx);
			uilineInfo.startCharIdx = startCharIdx;
			LuaObject.setBack(l, uilineInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024325 RID: 148261 RVA: 0x00CB74B4 File Offset: 0x00CB56B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_height(IntPtr l)
	{
		int result;
		try
		{
			UILineInfo uilineInfo;
			LuaObject.checkValueType<UILineInfo>(l, 1, out uilineInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uilineInfo.height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024326 RID: 148262 RVA: 0x00CB7508 File Offset: 0x00CB5708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_height(IntPtr l)
	{
		int result;
		try
		{
			UILineInfo uilineInfo;
			LuaObject.checkValueType<UILineInfo>(l, 1, out uilineInfo);
			int height;
			LuaObject.checkType(l, 2, out height);
			uilineInfo.height = height;
			LuaObject.setBack(l, uilineInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024327 RID: 148263 RVA: 0x00CB756C File Offset: 0x00CB576C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_topY(IntPtr l)
	{
		int result;
		try
		{
			UILineInfo uilineInfo;
			LuaObject.checkValueType<UILineInfo>(l, 1, out uilineInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uilineInfo.topY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024328 RID: 148264 RVA: 0x00CB75C0 File Offset: 0x00CB57C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_topY(IntPtr l)
	{
		int result;
		try
		{
			UILineInfo uilineInfo;
			LuaObject.checkValueType<UILineInfo>(l, 1, out uilineInfo);
			float topY;
			LuaObject.checkType(l, 2, out topY);
			uilineInfo.topY = topY;
			LuaObject.setBack(l, uilineInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024329 RID: 148265 RVA: 0x00CB7624 File Offset: 0x00CB5824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_leading(IntPtr l)
	{
		int result;
		try
		{
			UILineInfo uilineInfo;
			LuaObject.checkValueType<UILineInfo>(l, 1, out uilineInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uilineInfo.leading);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602432A RID: 148266 RVA: 0x00CB7678 File Offset: 0x00CB5878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_leading(IntPtr l)
	{
		int result;
		try
		{
			UILineInfo uilineInfo;
			LuaObject.checkValueType<UILineInfo>(l, 1, out uilineInfo);
			float leading;
			LuaObject.checkType(l, 2, out leading);
			uilineInfo.leading = leading;
			LuaObject.setBack(l, uilineInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602432B RID: 148267 RVA: 0x00CB76DC File Offset: 0x00CB58DC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UILineInfo");
		string name = "startCharIdx";
		if (Lua_UnityEngine_UILineInfo.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UILineInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UILineInfo.get_startCharIdx);
		}
		LuaCSFunction get = Lua_UnityEngine_UILineInfo.<>f__mg$cache0;
		if (Lua_UnityEngine_UILineInfo.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UILineInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UILineInfo.set_startCharIdx);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UILineInfo.<>f__mg$cache1, true);
		string name2 = "height";
		if (Lua_UnityEngine_UILineInfo.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UILineInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UILineInfo.get_height);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UILineInfo.<>f__mg$cache2;
		if (Lua_UnityEngine_UILineInfo.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UILineInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UILineInfo.set_height);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UILineInfo.<>f__mg$cache3, true);
		string name3 = "topY";
		if (Lua_UnityEngine_UILineInfo.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UILineInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UILineInfo.get_topY);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UILineInfo.<>f__mg$cache4;
		if (Lua_UnityEngine_UILineInfo.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UILineInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UILineInfo.set_topY);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UILineInfo.<>f__mg$cache5, true);
		string name4 = "leading";
		if (Lua_UnityEngine_UILineInfo.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UILineInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UILineInfo.get_leading);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UILineInfo.<>f__mg$cache6;
		if (Lua_UnityEngine_UILineInfo.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UILineInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UILineInfo.set_leading);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UILineInfo.<>f__mg$cache7, true);
		if (Lua_UnityEngine_UILineInfo.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UILineInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UILineInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UILineInfo.<>f__mg$cache8, typeof(UILineInfo), typeof(ValueType));
	}

	// Token: 0x04019EAA RID: 106154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019EAB RID: 106155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019EAC RID: 106156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019EAD RID: 106157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019EAE RID: 106158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019EAF RID: 106159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019EB0 RID: 106160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019EB1 RID: 106161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019EB2 RID: 106162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
