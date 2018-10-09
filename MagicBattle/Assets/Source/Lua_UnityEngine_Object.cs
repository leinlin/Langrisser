using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001733 RID: 5939
[Preserve]
public class Lua_UnityEngine_Object : LuaObject
{
	// Token: 0x060236B5 RID: 145077 RVA: 0x00C53DF8 File Offset: 0x00C51FF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object o = new UnityEngine.Object();
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

	// Token: 0x060236B6 RID: 145078 RVA: 0x00C53E40 File Offset: 0x00C52040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInstanceID(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object @object = (UnityEngine.Object)LuaObject.checkSelf(l);
			int instanceID = @object.GetInstanceID();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instanceID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236B7 RID: 145079 RVA: 0x00C53E94 File Offset: 0x00C52094
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Destroy_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				UnityEngine.Object obj;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out obj);
				UnityEngine.Object.Destroy(obj);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				UnityEngine.Object obj2;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out obj2);
				float t;
				LuaObject.checkType(l, 2, out t);
				UnityEngine.Object.Destroy(obj2, t);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Destroy to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236B8 RID: 145080 RVA: 0x00C53F38 File Offset: 0x00C52138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyImmediate_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				UnityEngine.Object obj;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out obj);
				UnityEngine.Object.DestroyImmediate(obj);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				UnityEngine.Object obj2;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out obj2);
				bool allowDestroyingAssets;
				LuaObject.checkType(l, 2, out allowDestroyingAssets);
				UnityEngine.Object.DestroyImmediate(obj2, allowDestroyingAssets);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DestroyImmediate to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236B9 RID: 145081 RVA: 0x00C53FDC File Offset: 0x00C521DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindObjectsOfType_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Type type;
				LuaObject.checkType(l, 1, out type);
				UnityEngine.Object[] a = UnityEngine.Object.FindObjectsOfType(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 0)
			{
				UnityEngine.Object[] a2 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Object>();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function FindObjectsOfType to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236BA RID: 145082 RVA: 0x00C5407C File Offset: 0x00C5227C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DontDestroyOnLoad_s(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object target;
			LuaObject.checkType<UnityEngine.Object>(l, 1, out target);
			UnityEngine.Object.DontDestroyOnLoad(target);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236BB RID: 145083 RVA: 0x00C540C8 File Offset: 0x00C522C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyObject_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				UnityEngine.Object obj;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out obj);
				UnityEngine.Object.DestroyObject(obj);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				UnityEngine.Object obj2;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out obj2);
				float t;
				LuaObject.checkType(l, 2, out t);
				UnityEngine.Object.DestroyObject(obj2, t);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DestroyObject to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236BC RID: 145084 RVA: 0x00C5416C File Offset: 0x00C5236C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Instantiate_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(UnityEngine.Object), typeof(Transform), typeof(bool)))
			{
				UnityEngine.Object original;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out original);
				Transform parent;
				LuaObject.checkType<Transform>(l, 2, out parent);
				bool worldPositionStays;
				LuaObject.checkType(l, 3, out worldPositionStays);
				UnityEngine.Object o = UnityEngine.Object.Instantiate<UnityEngine.Object>(original, parent, worldPositionStays);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(UnityEngine.Object)))
			{
				UnityEngine.Object original2;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out original2);
				UnityEngine.Object o2 = UnityEngine.Object.Instantiate<UnityEngine.Object>(original2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(UnityEngine.Object)))
			{
				UnityEngine.Object original3;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out original3);
				UnityEngine.Object o3 = UnityEngine.Object.Instantiate(original3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(UnityEngine.Object), typeof(Transform)))
			{
				UnityEngine.Object original4;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out original4);
				Transform parent2;
				LuaObject.checkType<Transform>(l, 2, out parent2);
				UnityEngine.Object o4 = UnityEngine.Object.Instantiate(original4, parent2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(UnityEngine.Object), typeof(Transform)))
			{
				UnityEngine.Object original5;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out original5);
				Transform parent3;
				LuaObject.checkType<Transform>(l, 2, out parent3);
				UnityEngine.Object o5 = UnityEngine.Object.Instantiate<UnityEngine.Object>(original5, parent3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o5);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(UnityEngine.Object), typeof(Vector3), typeof(Quaternion)))
			{
				UnityEngine.Object original6;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out original6);
				Vector3 position;
				LuaObject.checkType(l, 2, out position);
				Quaternion rotation;
				LuaObject.checkType(l, 3, out rotation);
				UnityEngine.Object o6 = UnityEngine.Object.Instantiate<UnityEngine.Object>(original6, position, rotation);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o6);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(UnityEngine.Object), typeof(Vector3), typeof(Quaternion)))
			{
				UnityEngine.Object original7;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out original7);
				Vector3 position2;
				LuaObject.checkType(l, 2, out position2);
				Quaternion rotation2;
				LuaObject.checkType(l, 3, out rotation2);
				UnityEngine.Object o7 = UnityEngine.Object.Instantiate(original7, position2, rotation2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o7);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(UnityEngine.Object), typeof(Transform), typeof(bool)))
			{
				UnityEngine.Object original8;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out original8);
				Transform parent4;
				LuaObject.checkType<Transform>(l, 2, out parent4);
				bool instantiateInWorldSpace;
				LuaObject.checkType(l, 3, out instantiateInWorldSpace);
				UnityEngine.Object o8 = UnityEngine.Object.Instantiate(original8, parent4, instantiateInWorldSpace);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o8);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(UnityEngine.Object), typeof(Vector3), typeof(Quaternion), typeof(Transform)))
			{
				UnityEngine.Object original9;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out original9);
				Vector3 position3;
				LuaObject.checkType(l, 2, out position3);
				Quaternion rotation3;
				LuaObject.checkType(l, 3, out rotation3);
				Transform parent5;
				LuaObject.checkType<Transform>(l, 4, out parent5);
				UnityEngine.Object o9 = UnityEngine.Object.Instantiate(original9, position3, rotation3, parent5);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o9);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(UnityEngine.Object), typeof(Vector3), typeof(Quaternion), typeof(Transform)))
			{
				UnityEngine.Object original10;
				LuaObject.checkType<UnityEngine.Object>(l, 1, out original10);
				Vector3 position4;
				LuaObject.checkType(l, 2, out position4);
				Quaternion rotation4;
				LuaObject.checkType(l, 3, out rotation4);
				Transform parent6;
				LuaObject.checkType<Transform>(l, 4, out parent6);
				UnityEngine.Object o10 = UnityEngine.Object.Instantiate<UnityEngine.Object>(original10, position4, rotation4, parent6);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o10);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Instantiate to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236BD RID: 145085 RVA: 0x00C545B0 File Offset: 0x00C527B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindObjectOfType_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 0)
			{
				UnityEngine.Object o = UnityEngine.Object.FindObjectOfType<UnityEngine.Object>();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 1)
			{
				Type type;
				LuaObject.checkType(l, 1, out type);
				UnityEngine.Object o2 = UnityEngine.Object.FindObjectOfType(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function FindObjectOfType to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236BE RID: 145086 RVA: 0x00C54650 File Offset: 0x00C52850
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object x;
			LuaObject.checkType<UnityEngine.Object>(l, 1, out x);
			UnityEngine.Object y;
			LuaObject.checkType<UnityEngine.Object>(l, 2, out y);
			bool b = x == y;
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

	// Token: 0x060236BF RID: 145087 RVA: 0x00C546B0 File Offset: 0x00C528B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object x;
			LuaObject.checkType<UnityEngine.Object>(l, 1, out x);
			UnityEngine.Object y;
			LuaObject.checkType<UnityEngine.Object>(l, 2, out y);
			bool b = x != y;
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

	// Token: 0x060236C0 RID: 145088 RVA: 0x00C54710 File Offset: 0x00C52910
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_name(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object @object = (UnityEngine.Object)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @object.name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236C1 RID: 145089 RVA: 0x00C54764 File Offset: 0x00C52964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_name(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object @object = (UnityEngine.Object)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			@object.name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236C2 RID: 145090 RVA: 0x00C547BC File Offset: 0x00C529BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_hideFlags(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object @object = (UnityEngine.Object)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)@object.hideFlags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236C3 RID: 145091 RVA: 0x00C54810 File Offset: 0x00C52A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_hideFlags(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object @object = (UnityEngine.Object)LuaObject.checkSelf(l);
			HideFlags hideFlags;
			LuaObject.checkEnum<HideFlags>(l, 2, out hideFlags);
			@object.hideFlags = hideFlags;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236C4 RID: 145092 RVA: 0x00C54868 File Offset: 0x00C52A68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Object");
		if (Lua_UnityEngine_Object.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Object.GetInstanceID);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Object.<>f__mg$cache0);
		if (Lua_UnityEngine_Object.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Object.Destroy_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Object.<>f__mg$cache1);
		if (Lua_UnityEngine_Object.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Object.DestroyImmediate_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Object.<>f__mg$cache2);
		if (Lua_UnityEngine_Object.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Object.FindObjectsOfType_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Object.<>f__mg$cache3);
		if (Lua_UnityEngine_Object.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Object.DontDestroyOnLoad_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Object.<>f__mg$cache4);
		if (Lua_UnityEngine_Object.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Object.DestroyObject_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Object.<>f__mg$cache5);
		if (Lua_UnityEngine_Object.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Object.Instantiate_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Object.<>f__mg$cache6);
		if (Lua_UnityEngine_Object.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Object.FindObjectOfType_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Object.<>f__mg$cache7);
		if (Lua_UnityEngine_Object.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Object.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Object.<>f__mg$cache8);
		if (Lua_UnityEngine_Object.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Object.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Object.<>f__mg$cache9);
		string name = "name";
		if (Lua_UnityEngine_Object.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Object.get_name);
		}
		LuaCSFunction get = Lua_UnityEngine_Object.<>f__mg$cacheA;
		if (Lua_UnityEngine_Object.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Object.set_name);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Object.<>f__mg$cacheB, true);
		string name2 = "hideFlags";
		if (Lua_UnityEngine_Object.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Object.get_hideFlags);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Object.<>f__mg$cacheC;
		if (Lua_UnityEngine_Object.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Object.set_hideFlags);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Object.<>f__mg$cacheD, true);
		if (Lua_UnityEngine_Object.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Object.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Object.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Object.<>f__mg$cacheE, typeof(UnityEngine.Object));
	}

	// Token: 0x040194AD RID: 103597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040194AE RID: 103598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040194AF RID: 103599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040194B0 RID: 103600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040194B1 RID: 103601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040194B2 RID: 103602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040194B3 RID: 103603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040194B4 RID: 103604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040194B5 RID: 103605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040194B6 RID: 103606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040194B7 RID: 103607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040194B8 RID: 103608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040194B9 RID: 103609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040194BA RID: 103610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040194BB RID: 103611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
