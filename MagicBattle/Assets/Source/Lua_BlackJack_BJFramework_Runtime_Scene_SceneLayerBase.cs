using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200111A RID: 4378
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase : LuaObject
{
	// Token: 0x06015C34 RID: 89140 RVA: 0x0059BE70 File Offset: 0x0059A070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetName(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			sceneLayerBase.SetName(name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C35 RID: 89141 RVA: 0x0059BEC8 File Offset: 0x0059A0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsOpaque(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			bool b = sceneLayerBase.IsOpaque();
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

	// Token: 0x06015C36 RID: 89142 RVA: 0x0059BF1C File Offset: 0x0059A11C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsFullScreen(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			bool b = sceneLayerBase.IsFullScreen();
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

	// Token: 0x06015C37 RID: 89143 RVA: 0x0059BF70 File Offset: 0x0059A170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsStayOnTop(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			bool b = sceneLayerBase.IsStayOnTop();
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

	// Token: 0x06015C38 RID: 89144 RVA: 0x0059BFC4 File Offset: 0x0059A1C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AttachGameObject(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			sceneLayerBase.AttachGameObject(go);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C39 RID: 89145 RVA: 0x0059C01C File Offset: 0x0059A21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRenderSetting(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			LayerRenderSettingDesc renderSetting = sceneLayerBase.GetRenderSetting();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, renderSetting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C3A RID: 89146 RVA: 0x0059C070 File Offset: 0x0059A270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsReserve(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			bool b = sceneLayerBase.IsReserve();
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

	// Token: 0x06015C3B RID: 89147 RVA: 0x0059C0C4 File Offset: 0x0059A2C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetReserve(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			bool reserve;
			LuaObject.checkType(l, 2, out reserve);
			sceneLayerBase.SetReserve(reserve);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C3C RID: 89148 RVA: 0x0059C11C File Offset: 0x0059A31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_State(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)sceneLayerBase.State);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C3D RID: 89149 RVA: 0x0059C170 File Offset: 0x0059A370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_State(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			SceneLayerBase.LayerState state;
			LuaObject.checkEnum<SceneLayerBase.LayerState>(l, 2, out state);
			sceneLayerBase.State = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C3E RID: 89150 RVA: 0x0059C1C8 File Offset: 0x0059A3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerName(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sceneLayerBase.LayerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C3F RID: 89151 RVA: 0x0059C21C File Offset: 0x0059A41C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerCamera(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sceneLayerBase.LayerCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C40 RID: 89152 RVA: 0x0059C270 File Offset: 0x0059A470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LayerPrefabRoot(IntPtr l)
	{
		int result;
		try
		{
			SceneLayerBase sceneLayerBase = (SceneLayerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sceneLayerBase.LayerPrefabRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015C41 RID: 89153 RVA: 0x0059C2C4 File Offset: 0x0059A4C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Scene.SceneLayerBase");
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.SetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.IsOpaque);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.IsFullScreen);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.IsStayOnTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.AttachGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.GetRenderSetting);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.IsReserve);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache6);
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.SetReserve);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache7);
		string name = "State";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.get_State);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache8;
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.set_State);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cache9, true);
		string name2 = "LayerName";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.get_LayerName);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cacheA, null, true);
		string name3 = "LayerCamera";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.get_LayerCamera);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cacheB, null, true);
		string name4 = "LayerPrefabRoot";
		if (Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.get_LayerPrefabRoot);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_BJFramework_Runtime_Scene_SceneLayerBase.<>f__mg$cacheC, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(SceneLayerBase), typeof(MonoBehaviour));
	}

	// Token: 0x0400C3E2 RID: 50146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C3E3 RID: 50147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C3E4 RID: 50148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C3E5 RID: 50149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C3E6 RID: 50150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C3E7 RID: 50151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C3E8 RID: 50152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C3E9 RID: 50153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C3EA RID: 50154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C3EB RID: 50155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C3EC RID: 50156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C3ED RID: 50157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C3EE RID: 50158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
