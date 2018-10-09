using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001119 RID: 4377
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc : LuaObject
{
	// Token: 0x06015C2C RID: 89132 RVA: 0x0059BB5C File Offset: 0x00599D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Opaque(IntPtr l)
	{
		int result;
		try
		{
			LayerLayoutDesc layerLayoutDesc = (LayerLayoutDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerLayoutDesc.Opaque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C2D RID: 89133 RVA: 0x0059BBB0 File Offset: 0x00599DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Opaque(IntPtr l)
	{
		int result;
		try
		{
			LayerLayoutDesc layerLayoutDesc = (LayerLayoutDesc)LuaObject.checkSelf(l);
			bool opaque;
			LuaObject.checkType(l, 2, out opaque);
			layerLayoutDesc.Opaque = opaque;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C2E RID: 89134 RVA: 0x0059BC08 File Offset: 0x00599E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FullScreen(IntPtr l)
	{
		int result;
		try
		{
			LayerLayoutDesc layerLayoutDesc = (LayerLayoutDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerLayoutDesc.FullScreen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C2F RID: 89135 RVA: 0x0059BC5C File Offset: 0x00599E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FullScreen(IntPtr l)
	{
		int result;
		try
		{
			LayerLayoutDesc layerLayoutDesc = (LayerLayoutDesc)LuaObject.checkSelf(l);
			bool fullScreen;
			LuaObject.checkType(l, 2, out fullScreen);
			layerLayoutDesc.FullScreen = fullScreen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C30 RID: 89136 RVA: 0x0059BCB4 File Offset: 0x00599EB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StayOnTop(IntPtr l)
	{
		int result;
		try
		{
			LayerLayoutDesc layerLayoutDesc = (LayerLayoutDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerLayoutDesc.StayOnTop);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C31 RID: 89137 RVA: 0x0059BD08 File Offset: 0x00599F08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StayOnTop(IntPtr l)
	{
		int result;
		try
		{
			LayerLayoutDesc layerLayoutDesc = (LayerLayoutDesc)LuaObject.checkSelf(l);
			bool stayOnTop;
			LuaObject.checkType(l, 2, out stayOnTop);
			layerLayoutDesc.StayOnTop = stayOnTop;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C32 RID: 89138 RVA: 0x0059BD60 File Offset: 0x00599F60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Scene.LayerLayoutDesc");
		string name = "Opaque";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.get_Opaque);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache0;
		if (Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.set_Opaque);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache1, true);
		string name2 = "FullScreen";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.get_FullScreen);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache2;
		if (Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.set_FullScreen);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache3, true);
		string name3 = "StayOnTop";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.get_StayOnTop);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache4;
		if (Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.set_StayOnTop);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_Scene_LayerLayoutDesc.<>f__mg$cache5, true);
		LuaObject.createTypeMetatable(l, null, typeof(LayerLayoutDesc), typeof(MonoBehaviour));
	}

	// Token: 0x0400C3DC RID: 50140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C3DD RID: 50141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C3DE RID: 50142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C3DF RID: 50143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C3E0 RID: 50144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C3E1 RID: 50145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
