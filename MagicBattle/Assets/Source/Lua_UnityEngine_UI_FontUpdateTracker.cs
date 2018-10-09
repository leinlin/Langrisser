using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001821 RID: 6177
[Preserve]
public class Lua_UnityEngine_UI_FontUpdateTracker : LuaObject
{
	// Token: 0x0602404A RID: 147530 RVA: 0x00CA4B40 File Offset: 0x00CA2D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TrackText_s(IntPtr l)
	{
		int result;
		try
		{
			Text t;
			LuaObject.checkType<Text>(l, 1, out t);
			FontUpdateTracker.TrackText(t);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602404B RID: 147531 RVA: 0x00CA4B8C File Offset: 0x00CA2D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UntrackText_s(IntPtr l)
	{
		int result;
		try
		{
			Text t;
			LuaObject.checkType<Text>(l, 1, out t);
			FontUpdateTracker.UntrackText(t);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602404C RID: 147532 RVA: 0x00CA4BD8 File Offset: 0x00CA2DD8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.FontUpdateTracker");
		if (Lua_UnityEngine_UI_FontUpdateTracker.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_FontUpdateTracker.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_FontUpdateTracker.TrackText_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_FontUpdateTracker.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_FontUpdateTracker.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_FontUpdateTracker.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_FontUpdateTracker.UntrackText_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_FontUpdateTracker.<>f__mg$cache1);
		LuaObject.createTypeMetatable(l, null, typeof(FontUpdateTracker));
	}

	// Token: 0x04019C66 RID: 105574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C67 RID: 105575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
