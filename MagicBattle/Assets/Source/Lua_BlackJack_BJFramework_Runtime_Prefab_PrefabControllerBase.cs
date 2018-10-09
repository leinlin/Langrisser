using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001115 RID: 4373
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase : LuaObject
{
	// Token: 0x06015BEB RID: 89067 RVA: 0x00599B88 File Offset: 0x00597D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initlize(IntPtr l)
	{
		int result;
		try
		{
			PrefabControllerBase prefabControllerBase = (PrefabControllerBase)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			prefabControllerBase.Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BEC RID: 89068 RVA: 0x00599BEC File Offset: 0x00597DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAssetInContainer(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				PrefabControllerBase prefabControllerBase = (PrefabControllerBase)LuaObject.checkSelf(l);
				string resName;
				LuaObject.checkType(l, 2, out resName);
				UnityEngine.Object assetInContainer = prefabControllerBase.GetAssetInContainer<UnityEngine.Object>(resName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, assetInContainer);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				PrefabControllerBase prefabControllerBase2 = (PrefabControllerBase)LuaObject.checkSelf(l);
				string resName2;
				LuaObject.checkType(l, 2, out resName2);
				UnityEngine.Object assetInContainer2 = prefabControllerBase2.GetAssetInContainer(resName2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, assetInContainer2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetAssetInContainer to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BED RID: 89069 RVA: 0x00599CD8 File Offset: 0x00597ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BindResContainer(IntPtr l)
	{
		int result;
		try
		{
			PrefabControllerBase prefabControllerBase = (PrefabControllerBase)LuaObject.checkSelf(l);
			prefabControllerBase.BindResContainer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BEE RID: 89070 RVA: 0x00599D24 File Offset: 0x00597F24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BindFields(IntPtr l)
	{
		int result;
		try
		{
			PrefabControllerBase prefabControllerBase = (PrefabControllerBase)LuaObject.checkSelf(l);
			prefabControllerBase.BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BEF RID: 89071 RVA: 0x00599D70 File Offset: 0x00597F70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNextUpdateExecutor(IntPtr l)
	{
		int result;
		try
		{
			PrefabControllerBase prefabControllerBase = (PrefabControllerBase)LuaObject.checkSelf(l);
			PrefabControllerNextUpdateExecutor nextUpdateExecutor = prefabControllerBase.GetNextUpdateExecutor();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextUpdateExecutor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BF0 RID: 89072 RVA: 0x00599DC4 File Offset: 0x00597FC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetChildByPath(IntPtr l)
	{
		int result;
		try
		{
			PrefabControllerBase prefabControllerBase = (PrefabControllerBase)LuaObject.checkSelf(l);
			string path;
			LuaObject.checkType(l, 2, out path);
			GameObject childByPath = prefabControllerBase.GetChildByPath(path);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, childByPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BF1 RID: 89073 RVA: 0x00599E28 File Offset: 0x00598028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddControllerToGameObject_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject root;
			LuaObject.checkType<GameObject>(l, 1, out root);
			string path;
			LuaObject.checkType(l, 2, out path);
			TypeDNName ctrlTypeDNName;
			LuaObject.checkType<TypeDNName>(l, 3, out ctrlTypeDNName);
			string ctrlName;
			LuaObject.checkType(l, 4, out ctrlName);
			string luaModuleName;
			LuaObject.checkType(l, 5, out luaModuleName);
			bool autoBind;
			LuaObject.checkType(l, 6, out autoBind);
			PrefabControllerBase o = PrefabControllerBase.AddControllerToGameObject(root, path, ctrlTypeDNName, ctrlName, luaModuleName, autoBind);
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

	// Token: 0x06015BF2 RID: 89074 RVA: 0x00599EBC File Offset: 0x005980BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resContainer(IntPtr l)
	{
		int result;
		try
		{
			PrefabControllerBase prefabControllerBase = (PrefabControllerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, prefabControllerBase.m_resContainer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BF3 RID: 89075 RVA: 0x00599F10 File Offset: 0x00598110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_resContainer(IntPtr l)
	{
		int result;
		try
		{
			PrefabControllerBase prefabControllerBase = (PrefabControllerBase)LuaObject.checkSelf(l);
			PrefabResourceContainer resContainer;
			LuaObject.checkType<PrefabResourceContainer>(l, 2, out resContainer);
			prefabControllerBase.m_resContainer = resContainer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BF4 RID: 89076 RVA: 0x00599F68 File Offset: 0x00598168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CtrlName(IntPtr l)
	{
		int result;
		try
		{
			PrefabControllerBase prefabControllerBase = (PrefabControllerBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, prefabControllerBase.CtrlName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015BF5 RID: 89077 RVA: 0x00599FBC File Offset: 0x005981BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Prefab.PrefabControllerBase");
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.GetAssetInContainer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache1);
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.BindResContainer);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache2);
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache3);
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.GetNextUpdateExecutor);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache4);
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.GetChildByPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache5);
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.AddControllerToGameObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache6);
		string name = "m_resContainer";
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.get_m_resContainer);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache7;
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.set_m_resContainer);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache8, true);
		string name2 = "CtrlName";
		if (Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.get_CtrlName);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabControllerBase.<>f__mg$cache9, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(PrefabControllerBase), typeof(MonoBehaviour));
	}

	// Token: 0x0400C3A3 RID: 50083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C3A4 RID: 50084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C3A5 RID: 50085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C3A6 RID: 50086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C3A7 RID: 50087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C3A8 RID: 50088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C3A9 RID: 50089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C3AA RID: 50090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C3AB RID: 50091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C3AC RID: 50092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
