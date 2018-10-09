using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200186A RID: 6250
[Preserve]
public class Lua_UnityEngine_UICharInfo : LuaObject
{
	// Token: 0x0602431B RID: 148251 RVA: 0x00CB7108 File Offset: 0x00CB5308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UICharInfo uicharInfo = default(UICharInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicharInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602431C RID: 148252 RVA: 0x00CB7158 File Offset: 0x00CB5358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cursorPos(IntPtr l)
	{
		int result;
		try
		{
			UICharInfo uicharInfo;
			LuaObject.checkValueType<UICharInfo>(l, 1, out uicharInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicharInfo.cursorPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602431D RID: 148253 RVA: 0x00CB71AC File Offset: 0x00CB53AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cursorPos(IntPtr l)
	{
		int result;
		try
		{
			UICharInfo uicharInfo;
			LuaObject.checkValueType<UICharInfo>(l, 1, out uicharInfo);
			Vector2 cursorPos;
			LuaObject.checkType(l, 2, out cursorPos);
			uicharInfo.cursorPos = cursorPos;
			LuaObject.setBack(l, uicharInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602431E RID: 148254 RVA: 0x00CB7210 File Offset: 0x00CB5410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_charWidth(IntPtr l)
	{
		int result;
		try
		{
			UICharInfo uicharInfo;
			LuaObject.checkValueType<UICharInfo>(l, 1, out uicharInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uicharInfo.charWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602431F RID: 148255 RVA: 0x00CB7264 File Offset: 0x00CB5464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_charWidth(IntPtr l)
	{
		int result;
		try
		{
			UICharInfo uicharInfo;
			LuaObject.checkValueType<UICharInfo>(l, 1, out uicharInfo);
			float charWidth;
			LuaObject.checkType(l, 2, out charWidth);
			uicharInfo.charWidth = charWidth;
			LuaObject.setBack(l, uicharInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024320 RID: 148256 RVA: 0x00CB72C8 File Offset: 0x00CB54C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UICharInfo");
		string name = "cursorPos";
		if (Lua_UnityEngine_UICharInfo.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UICharInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UICharInfo.get_cursorPos);
		}
		LuaCSFunction get = Lua_UnityEngine_UICharInfo.<>f__mg$cache0;
		if (Lua_UnityEngine_UICharInfo.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UICharInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UICharInfo.set_cursorPos);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UICharInfo.<>f__mg$cache1, true);
		string name2 = "charWidth";
		if (Lua_UnityEngine_UICharInfo.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UICharInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UICharInfo.get_charWidth);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UICharInfo.<>f__mg$cache2;
		if (Lua_UnityEngine_UICharInfo.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UICharInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UICharInfo.set_charWidth);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UICharInfo.<>f__mg$cache3, true);
		if (Lua_UnityEngine_UICharInfo.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UICharInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UICharInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UICharInfo.<>f__mg$cache4, typeof(UICharInfo), typeof(ValueType));
	}

	// Token: 0x04019EA5 RID: 106149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019EA6 RID: 106150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019EA7 RID: 106151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019EA8 RID: 106152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019EA9 RID: 106153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
