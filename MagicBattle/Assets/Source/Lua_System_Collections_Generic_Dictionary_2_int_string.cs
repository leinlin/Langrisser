using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001602 RID: 5634
[Preserve]
public class Lua_System_Collections_Generic_Dictionary_2_int_string : LuaObject
{
	// Token: 0x060228E9 RID: 141545 RVA: 0x00BDBA1C File Offset: 0x00BD9C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Dictionary<int, string> o = new Dictionary<int, string>();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(IEqualityComparer<int>)))
			{
				IEqualityComparer<int> comparer;
				LuaObject.checkType<IEqualityComparer<int>>(l, 2, out comparer);
				Dictionary<int, string> o = new Dictionary<int, string>(comparer);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(IDictionary<int, string>)))
			{
				IDictionary<int, string> dictionary;
				LuaObject.checkType<IDictionary<int, string>>(l, 2, out dictionary);
				Dictionary<int, string> o = new Dictionary<int, string>(dictionary);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int)))
			{
				int capacity;
				LuaObject.checkType(l, 2, out capacity);
				Dictionary<int, string> o = new Dictionary<int, string>(capacity);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(IDictionary<int, string>), typeof(IEqualityComparer<int>)))
			{
				IDictionary<int, string> dictionary2;
				LuaObject.checkType<IDictionary<int, string>>(l, 2, out dictionary2);
				IEqualityComparer<int> comparer2;
				LuaObject.checkType<IEqualityComparer<int>>(l, 3, out comparer2);
				Dictionary<int, string> o = new Dictionary<int, string>(dictionary2, comparer2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(IEqualityComparer<int>)))
			{
				int capacity2;
				LuaObject.checkType(l, 2, out capacity2);
				IEqualityComparer<int> comparer3;
				LuaObject.checkType<IEqualityComparer<int>>(l, 3, out comparer3);
				Dictionary<int, string> o = new Dictionary<int, string>(capacity2, comparer3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228EA RID: 141546 RVA: 0x00BDBBF4 File Offset: 0x00BD9DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Add(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			int key;
			LuaObject.checkType(l, 2, out key);
			string value;
			LuaObject.checkType(l, 3, out value);
			dictionary.Add(key, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228EB RID: 141547 RVA: 0x00BDBC58 File Offset: 0x00BD9E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			dictionary.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228EC RID: 141548 RVA: 0x00BDBCA4 File Offset: 0x00BD9EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ContainsKey(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			int key;
			LuaObject.checkType(l, 2, out key);
			bool b = dictionary.ContainsKey(key);
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

	// Token: 0x060228ED RID: 141549 RVA: 0x00BDBD08 File Offset: 0x00BD9F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ContainsValue(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			string value;
			LuaObject.checkType(l, 2, out value);
			bool b = dictionary.ContainsValue(value);
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

	// Token: 0x060228EE RID: 141550 RVA: 0x00BDBD6C File Offset: 0x00BD9F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetObjectData(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			SerializationInfo info;
			LuaObject.checkType<SerializationInfo>(l, 2, out info);
			StreamingContext context;
			LuaObject.checkValueType<StreamingContext>(l, 3, out context);
			dictionary.GetObjectData(info, context);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228EF RID: 141551 RVA: 0x00BDBDD0 File Offset: 0x00BD9FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDeserialization(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			object sender;
			LuaObject.checkType<object>(l, 2, out sender);
			dictionary.OnDeserialization(sender);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228F0 RID: 141552 RVA: 0x00BDBE28 File Offset: 0x00BDA028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Remove(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			int key;
			LuaObject.checkType(l, 2, out key);
			bool b = dictionary.Remove(key);
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

	// Token: 0x060228F1 RID: 141553 RVA: 0x00BDBE8C File Offset: 0x00BDA08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryGetValue(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			int key;
			LuaObject.checkType(l, 2, out key);
			string s;
			bool b = dictionary.TryGetValue(key, out s);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, s);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228F2 RID: 141554 RVA: 0x00BDBEFC File Offset: 0x00BDA0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Count(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dictionary.Count);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228F3 RID: 141555 RVA: 0x00BDBF50 File Offset: 0x00BDA150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Comparer(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dictionary.Comparer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228F4 RID: 141556 RVA: 0x00BDBFA4 File Offset: 0x00BDA1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Keys(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dictionary.Keys);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228F5 RID: 141557 RVA: 0x00BDBFF8 File Offset: 0x00BDA1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Values(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dictionary.Values);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228F6 RID: 141558 RVA: 0x00BDC04C File Offset: 0x00BDA24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			int key;
			LuaObject.checkType(l, 2, out key);
			string s = dictionary[key];
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228F7 RID: 141559 RVA: 0x00BDC0B0 File Offset: 0x00BDA2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, string> dictionary = (Dictionary<int, string>)LuaObject.checkSelf(l);
			int key;
			LuaObject.checkType(l, 2, out key);
			string value;
			LuaObject.checkType(l, 3, out value);
			dictionary[key] = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060228F8 RID: 141560 RVA: 0x00BDC114 File Offset: 0x00BDA314
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "DictIntStr");
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache0 == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache0 = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.Add);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache0);
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache1 == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache1 = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.Clear);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache1);
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache2 == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache2 = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.ContainsKey);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache2);
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache3 == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache3 = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.ContainsValue);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache3);
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache4 == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache4 = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.GetObjectData);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache4);
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache5 == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache5 = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.OnDeserialization);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache5);
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache6 == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache6 = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.Remove);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache6);
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache7 == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache7 = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.TryGetValue);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache7);
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache8 == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache8 = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.getItem);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache8);
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache9 == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache9 = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.setItem);
		}
		LuaObject.addMember(l, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cache9);
		string name = "Count";
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheA == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheA = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.get_Count);
		}
		LuaObject.addMember(l, name, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheA, null, true);
		string name2 = "Comparer";
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheB == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheB = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.get_Comparer);
		}
		LuaObject.addMember(l, name2, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheB, null, true);
		string name3 = "Keys";
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheC == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheC = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.get_Keys);
		}
		LuaObject.addMember(l, name3, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheC, null, true);
		string name4 = "Values";
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheD == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheD = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.get_Values);
		}
		LuaObject.addMember(l, name4, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheD, null, true);
		if (Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheE == null)
		{
			Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheE = new LuaCSFunction(Lua_System_Collections_Generic_Dictionary_2_int_string.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_System_Collections_Generic_Dictionary_2_int_string.<>f__mg$cacheE, typeof(Dictionary<int, string>));
	}

	// Token: 0x040186C7 RID: 100039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040186C8 RID: 100040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040186C9 RID: 100041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040186CA RID: 100042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040186CB RID: 100043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040186CC RID: 100044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040186CD RID: 100045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040186CE RID: 100046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040186CF RID: 100047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040186D0 RID: 100048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040186D1 RID: 100049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040186D2 RID: 100050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040186D3 RID: 100051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040186D4 RID: 100052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040186D5 RID: 100053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
