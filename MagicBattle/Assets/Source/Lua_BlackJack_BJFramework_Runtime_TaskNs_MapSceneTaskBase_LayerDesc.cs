using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.TaskNs;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001121 RID: 4385
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc : LuaObject
{
	// Token: 0x06015CB5 RID: 89269 RVA: 0x0059F8D8 File Offset: 0x0059DAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase.LayerDesc layerDesc = default(MapSceneTaskBase.LayerDesc);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CB6 RID: 89270 RVA: 0x0059F928 File Offset: 0x0059DB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerName(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase.LayerDesc layerDesc;
			LuaObject.checkValueType<MapSceneTaskBase.LayerDesc>(l, 1, out layerDesc);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerDesc.m_layerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CB7 RID: 89271 RVA: 0x0059F97C File Offset: 0x0059DB7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerName(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase.LayerDesc layerDesc;
			LuaObject.checkValueType<MapSceneTaskBase.LayerDesc>(l, 1, out layerDesc);
			string layerName;
			LuaObject.checkType(l, 2, out layerName);
			layerDesc.m_layerName = layerName;
			LuaObject.setBack(l, layerDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CB8 RID: 89272 RVA: 0x0059F9E0 File Offset: 0x0059DBE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerResPath(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase.LayerDesc layerDesc;
			LuaObject.checkValueType<MapSceneTaskBase.LayerDesc>(l, 1, out layerDesc);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerDesc.m_layerResPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CB9 RID: 89273 RVA: 0x0059FA34 File Offset: 0x0059DC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerResPath(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase.LayerDesc layerDesc;
			LuaObject.checkValueType<MapSceneTaskBase.LayerDesc>(l, 1, out layerDesc);
			string layerResPath;
			LuaObject.checkType(l, 2, out layerResPath);
			layerDesc.m_layerResPath = layerResPath;
			LuaObject.setBack(l, layerDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CBA RID: 89274 RVA: 0x0059FA98 File Offset: 0x0059DC98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isUILayer(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase.LayerDesc layerDesc;
			LuaObject.checkValueType<MapSceneTaskBase.LayerDesc>(l, 1, out layerDesc);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerDesc.m_isUILayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CBB RID: 89275 RVA: 0x0059FAEC File Offset: 0x0059DCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isUILayer(IntPtr l)
	{
		int result;
		try
		{
			MapSceneTaskBase.LayerDesc layerDesc;
			LuaObject.checkValueType<MapSceneTaskBase.LayerDesc>(l, 1, out layerDesc);
			bool isUILayer;
			LuaObject.checkType(l, 2, out isUILayer);
			layerDesc.m_isUILayer = isUILayer;
			LuaObject.setBack(l, layerDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015CBC RID: 89276 RVA: 0x0059FB50 File Offset: 0x0059DD50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.TaskNs.MapSceneTaskBase.LayerDesc");
		string name = "m_layerName";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.get_m_layerName);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache0;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.set_m_layerName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache1, true);
		string name2 = "m_layerResPath";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.get_m_layerResPath);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache2;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.set_m_layerResPath);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache3, true);
		string name3 = "m_isUILayer";
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.get_m_isUILayer);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache4;
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.set_m_isUILayer);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache5, true);
		if (Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_TaskNs_MapSceneTaskBase_LayerDesc.<>f__mg$cache6, typeof(MapSceneTaskBase.LayerDesc), typeof(ValueType));
	}

	// Token: 0x0400C455 RID: 50261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C456 RID: 50262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C457 RID: 50263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C458 RID: 50264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C459 RID: 50265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C45A RID: 50266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C45B RID: 50267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
