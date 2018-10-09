using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001861 RID: 6241
[Preserve]
public class Lua_UnityEngine_UI_SpriteState : LuaObject
{
	// Token: 0x060242AB RID: 148139 RVA: 0x00CB4068 File Offset: 0x00CB2268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SpriteState spriteState = default(SpriteState);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242AC RID: 148140 RVA: 0x00CB40B8 File Offset: 0x00CB22B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_highlightedSprite(IntPtr l)
	{
		int result;
		try
		{
			SpriteState spriteState;
			LuaObject.checkValueType<SpriteState>(l, 1, out spriteState);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteState.highlightedSprite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242AD RID: 148141 RVA: 0x00CB410C File Offset: 0x00CB230C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_highlightedSprite(IntPtr l)
	{
		int result;
		try
		{
			SpriteState spriteState;
			LuaObject.checkValueType<SpriteState>(l, 1, out spriteState);
			Sprite highlightedSprite;
			LuaObject.checkType<Sprite>(l, 2, out highlightedSprite);
			spriteState.highlightedSprite = highlightedSprite;
			LuaObject.setBack(l, spriteState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242AE RID: 148142 RVA: 0x00CB4170 File Offset: 0x00CB2370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_pressedSprite(IntPtr l)
	{
		int result;
		try
		{
			SpriteState spriteState;
			LuaObject.checkValueType<SpriteState>(l, 1, out spriteState);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteState.pressedSprite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242AF RID: 148143 RVA: 0x00CB41C4 File Offset: 0x00CB23C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pressedSprite(IntPtr l)
	{
		int result;
		try
		{
			SpriteState spriteState;
			LuaObject.checkValueType<SpriteState>(l, 1, out spriteState);
			Sprite pressedSprite;
			LuaObject.checkType<Sprite>(l, 2, out pressedSprite);
			spriteState.pressedSprite = pressedSprite;
			LuaObject.setBack(l, spriteState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242B0 RID: 148144 RVA: 0x00CB4228 File Offset: 0x00CB2428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_disabledSprite(IntPtr l)
	{
		int result;
		try
		{
			SpriteState spriteState;
			LuaObject.checkValueType<SpriteState>(l, 1, out spriteState);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spriteState.disabledSprite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242B1 RID: 148145 RVA: 0x00CB427C File Offset: 0x00CB247C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_disabledSprite(IntPtr l)
	{
		int result;
		try
		{
			SpriteState spriteState;
			LuaObject.checkValueType<SpriteState>(l, 1, out spriteState);
			Sprite disabledSprite;
			LuaObject.checkType<Sprite>(l, 2, out disabledSprite);
			spriteState.disabledSprite = disabledSprite;
			LuaObject.setBack(l, spriteState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242B2 RID: 148146 RVA: 0x00CB42E0 File Offset: 0x00CB24E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.SpriteState");
		string name = "highlightedSprite";
		if (Lua_UnityEngine_UI_SpriteState.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_SpriteState.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_SpriteState.get_highlightedSprite);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_SpriteState.<>f__mg$cache0;
		if (Lua_UnityEngine_UI_SpriteState.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_SpriteState.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_SpriteState.set_highlightedSprite);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_SpriteState.<>f__mg$cache1, true);
		string name2 = "pressedSprite";
		if (Lua_UnityEngine_UI_SpriteState.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_SpriteState.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_SpriteState.get_pressedSprite);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_SpriteState.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_SpriteState.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_SpriteState.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_SpriteState.set_pressedSprite);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_SpriteState.<>f__mg$cache3, true);
		string name3 = "disabledSprite";
		if (Lua_UnityEngine_UI_SpriteState.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_SpriteState.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_SpriteState.get_disabledSprite);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_SpriteState.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_SpriteState.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_SpriteState.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_SpriteState.set_disabledSprite);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_SpriteState.<>f__mg$cache5, true);
		if (Lua_UnityEngine_UI_SpriteState.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_SpriteState.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_SpriteState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_SpriteState.<>f__mg$cache6, typeof(SpriteState), typeof(ValueType));
	}

	// Token: 0x04019E47 RID: 106055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019E48 RID: 106056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019E49 RID: 106057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019E4A RID: 106058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019E4B RID: 106059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019E4C RID: 106060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019E4D RID: 106061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
