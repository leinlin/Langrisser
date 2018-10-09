using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Sprites;

// Token: 0x020017E8 RID: 6120
[Preserve]
public class Lua_UnityEngine_Sprites_DataUtility : LuaObject
{
	// Token: 0x06023DC6 RID: 146886 RVA: 0x00C91EC0 File Offset: 0x00C900C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataUtility o = new DataUtility();
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

	// Token: 0x06023DC7 RID: 146887 RVA: 0x00C91F08 File Offset: 0x00C90108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInnerUV_s(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite;
			LuaObject.checkType<Sprite>(l, 1, out sprite);
			Vector4 innerUV = DataUtility.GetInnerUV(sprite);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, innerUV);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DC8 RID: 146888 RVA: 0x00C91F5C File Offset: 0x00C9015C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOuterUV_s(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite;
			LuaObject.checkType<Sprite>(l, 1, out sprite);
			Vector4 outerUV = DataUtility.GetOuterUV(sprite);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, outerUV);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DC9 RID: 146889 RVA: 0x00C91FB0 File Offset: 0x00C901B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPadding_s(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite;
			LuaObject.checkType<Sprite>(l, 1, out sprite);
			Vector4 padding = DataUtility.GetPadding(sprite);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, padding);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DCA RID: 146890 RVA: 0x00C92004 File Offset: 0x00C90204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMinSize_s(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite;
			LuaObject.checkType<Sprite>(l, 1, out sprite);
			Vector2 minSize = DataUtility.GetMinSize(sprite);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, minSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DCB RID: 146891 RVA: 0x00C92058 File Offset: 0x00C90258
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Sprites.DataUtility");
		if (Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Sprites_DataUtility.GetInnerUV_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache0);
		if (Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Sprites_DataUtility.GetOuterUV_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache1);
		if (Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Sprites_DataUtility.GetPadding_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache2);
		if (Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Sprites_DataUtility.GetMinSize_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache3);
		if (Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Sprites_DataUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Sprites_DataUtility.<>f__mg$cache4, typeof(DataUtility));
	}

	// Token: 0x04019A54 RID: 105044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A55 RID: 105045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A56 RID: 105046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A57 RID: 105047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019A58 RID: 105048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
