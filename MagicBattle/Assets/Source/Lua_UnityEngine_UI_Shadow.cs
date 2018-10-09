using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200185D RID: 6237
[Preserve]
public class Lua_UnityEngine_UI_Shadow : LuaObject
{
	// Token: 0x0602427D RID: 148093 RVA: 0x00CB2D74 File Offset: 0x00CB0F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ModifyMesh(IntPtr l)
	{
		int result;
		try
		{
			Shadow shadow = (Shadow)LuaObject.checkSelf(l);
			VertexHelper vh;
			LuaObject.checkType<VertexHelper>(l, 2, out vh);
			shadow.ModifyMesh(vh);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602427E RID: 148094 RVA: 0x00CB2DCC File Offset: 0x00CB0FCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_effectColor(IntPtr l)
	{
		int result;
		try
		{
			Shadow shadow = (Shadow)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shadow.effectColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602427F RID: 148095 RVA: 0x00CB2E20 File Offset: 0x00CB1020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_effectColor(IntPtr l)
	{
		int result;
		try
		{
			Shadow shadow = (Shadow)LuaObject.checkSelf(l);
			Color effectColor;
			LuaObject.checkType(l, 2, out effectColor);
			shadow.effectColor = effectColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024280 RID: 148096 RVA: 0x00CB2E78 File Offset: 0x00CB1078
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_effectDistance(IntPtr l)
	{
		int result;
		try
		{
			Shadow shadow = (Shadow)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shadow.effectDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024281 RID: 148097 RVA: 0x00CB2ECC File Offset: 0x00CB10CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_effectDistance(IntPtr l)
	{
		int result;
		try
		{
			Shadow shadow = (Shadow)LuaObject.checkSelf(l);
			Vector2 effectDistance;
			LuaObject.checkType(l, 2, out effectDistance);
			shadow.effectDistance = effectDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024282 RID: 148098 RVA: 0x00CB2F24 File Offset: 0x00CB1124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useGraphicAlpha(IntPtr l)
	{
		int result;
		try
		{
			Shadow shadow = (Shadow)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shadow.useGraphicAlpha);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024283 RID: 148099 RVA: 0x00CB2F78 File Offset: 0x00CB1178
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_useGraphicAlpha(IntPtr l)
	{
		int result;
		try
		{
			Shadow shadow = (Shadow)LuaObject.checkSelf(l);
			bool useGraphicAlpha;
			LuaObject.checkType(l, 2, out useGraphicAlpha);
			shadow.useGraphicAlpha = useGraphicAlpha;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024284 RID: 148100 RVA: 0x00CB2FD0 File Offset: 0x00CB11D0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Shadow");
		if (Lua_UnityEngine_UI_Shadow.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Shadow.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Shadow.ModifyMesh);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Shadow.<>f__mg$cache0);
		string name = "effectColor";
		if (Lua_UnityEngine_UI_Shadow.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Shadow.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Shadow.get_effectColor);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Shadow.<>f__mg$cache1;
		if (Lua_UnityEngine_UI_Shadow.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Shadow.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Shadow.set_effectColor);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_Shadow.<>f__mg$cache2, true);
		string name2 = "effectDistance";
		if (Lua_UnityEngine_UI_Shadow.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Shadow.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Shadow.get_effectDistance);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_Shadow.<>f__mg$cache3;
		if (Lua_UnityEngine_UI_Shadow.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Shadow.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Shadow.set_effectDistance);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_Shadow.<>f__mg$cache4, true);
		string name3 = "useGraphicAlpha";
		if (Lua_UnityEngine_UI_Shadow.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_Shadow.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_Shadow.get_useGraphicAlpha);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_Shadow.<>f__mg$cache5;
		if (Lua_UnityEngine_UI_Shadow.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_Shadow.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_Shadow.set_useGraphicAlpha);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_Shadow.<>f__mg$cache6, true);
		LuaObject.createTypeMetatable(l, null, typeof(Shadow), typeof(BaseMeshEffect));
	}

	// Token: 0x04019E21 RID: 106017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019E22 RID: 106018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019E23 RID: 106019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019E24 RID: 106020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019E25 RID: 106021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019E26 RID: 106022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019E27 RID: 106023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
