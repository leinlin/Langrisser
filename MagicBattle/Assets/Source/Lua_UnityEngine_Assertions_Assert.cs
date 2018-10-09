using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Scripting;

// Token: 0x0200162D RID: 5677
[Preserve]
public class Lua_UnityEngine_Assertions_Assert : LuaObject
{
	// Token: 0x06022BD1 RID: 142289 RVA: 0x00BFD660 File Offset: 0x00BFB860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTrue_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				bool flag;
				LuaObject.checkType(l, 1, out flag);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				bool flag2;
				LuaObject.checkType(l, 1, out flag2);
				string text;
				LuaObject.checkType(l, 2, out text);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsTrue to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BD2 RID: 142290 RVA: 0x00BFD6F8 File Offset: 0x00BFB8F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsFalse_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				bool flag;
				LuaObject.checkType(l, 1, out flag);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				bool flag2;
				LuaObject.checkType(l, 1, out flag2);
				string text;
				LuaObject.checkType(l, 2, out text);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsFalse to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BD3 RID: 142291 RVA: 0x00BFD790 File Offset: 0x00BFB990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AreApproximatelyEqual_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				float num2;
				LuaObject.checkType(l, 1, out num2);
				float num3;
				LuaObject.checkType(l, 2, out num3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(float), typeof(float), typeof(float)))
			{
				float num4;
				LuaObject.checkType(l, 1, out num4);
				float num5;
				LuaObject.checkType(l, 2, out num5);
				float num6;
				LuaObject.checkType(l, 3, out num6);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(float), typeof(float), typeof(string)))
			{
				float num7;
				LuaObject.checkType(l, 1, out num7);
				float num8;
				LuaObject.checkType(l, 2, out num8);
				string text;
				LuaObject.checkType(l, 3, out text);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				float num9;
				LuaObject.checkType(l, 1, out num9);
				float num10;
				LuaObject.checkType(l, 2, out num10);
				float num11;
				LuaObject.checkType(l, 3, out num11);
				string text2;
				LuaObject.checkType(l, 4, out text2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AreApproximatelyEqual to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BD4 RID: 142292 RVA: 0x00BFD900 File Offset: 0x00BFBB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AreNotApproximatelyEqual_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				float num2;
				LuaObject.checkType(l, 1, out num2);
				float num3;
				LuaObject.checkType(l, 2, out num3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(float), typeof(float), typeof(float)))
			{
				float num4;
				LuaObject.checkType(l, 1, out num4);
				float num5;
				LuaObject.checkType(l, 2, out num5);
				float num6;
				LuaObject.checkType(l, 3, out num6);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 1, typeof(float), typeof(float), typeof(string)))
			{
				float num7;
				LuaObject.checkType(l, 1, out num7);
				float num8;
				LuaObject.checkType(l, 2, out num8);
				string text;
				LuaObject.checkType(l, 3, out text);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				float num9;
				LuaObject.checkType(l, 1, out num9);
				float num10;
				LuaObject.checkType(l, 2, out num10);
				float num11;
				LuaObject.checkType(l, 3, out num11);
				string text2;
				LuaObject.checkType(l, 4, out text2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AreNotApproximatelyEqual to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BD5 RID: 142293 RVA: 0x00BFDA70 File Offset: 0x00BFBC70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AreEqual_s(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object @object;
			LuaObject.checkType<UnityEngine.Object>(l, 1, out @object);
			UnityEngine.Object object2;
			LuaObject.checkType<UnityEngine.Object>(l, 2, out object2);
			string text;
			LuaObject.checkType(l, 3, out text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BD6 RID: 142294 RVA: 0x00BFDACC File Offset: 0x00BFBCCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AreNotEqual_s(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object @object;
			LuaObject.checkType<UnityEngine.Object>(l, 1, out @object);
			UnityEngine.Object object2;
			LuaObject.checkType<UnityEngine.Object>(l, 2, out object2);
			string text;
			LuaObject.checkType(l, 3, out text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BD7 RID: 142295 RVA: 0x00BFDB28 File Offset: 0x00BFBD28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNull_s(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object @object;
			LuaObject.checkType<UnityEngine.Object>(l, 1, out @object);
			string text;
			LuaObject.checkType(l, 2, out text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BD8 RID: 142296 RVA: 0x00BFDB78 File Offset: 0x00BFBD78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNotNull_s(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object @object;
			LuaObject.checkType<UnityEngine.Object>(l, 1, out @object);
			string text;
			LuaObject.checkType(l, 2, out text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BD9 RID: 142297 RVA: 0x00BFDBC8 File Offset: 0x00BFBDC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_raiseExceptions(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Assert.raiseExceptions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BDA RID: 142298 RVA: 0x00BFDC10 File Offset: 0x00BFBE10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_raiseExceptions(IntPtr l)
	{
		int result;
		try
		{
			bool raiseExceptions;
			LuaObject.checkType(l, 2, out raiseExceptions);
			Assert.raiseExceptions = raiseExceptions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BDB RID: 142299 RVA: 0x00BFDC5C File Offset: 0x00BFBE5C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Assertions.Assert");
		if (Lua_UnityEngine_Assertions_Assert.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Assertions_Assert.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Assertions_Assert.IsTrue_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Assertions_Assert.<>f__mg$cache0);
		if (Lua_UnityEngine_Assertions_Assert.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Assertions_Assert.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Assertions_Assert.IsFalse_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Assertions_Assert.<>f__mg$cache1);
		if (Lua_UnityEngine_Assertions_Assert.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Assertions_Assert.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Assertions_Assert.AreApproximatelyEqual_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Assertions_Assert.<>f__mg$cache2);
		if (Lua_UnityEngine_Assertions_Assert.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Assertions_Assert.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Assertions_Assert.AreNotApproximatelyEqual_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Assertions_Assert.<>f__mg$cache3);
		if (Lua_UnityEngine_Assertions_Assert.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Assertions_Assert.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Assertions_Assert.AreEqual_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Assertions_Assert.<>f__mg$cache4);
		if (Lua_UnityEngine_Assertions_Assert.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Assertions_Assert.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Assertions_Assert.AreNotEqual_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Assertions_Assert.<>f__mg$cache5);
		if (Lua_UnityEngine_Assertions_Assert.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Assertions_Assert.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Assertions_Assert.IsNull_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Assertions_Assert.<>f__mg$cache6);
		if (Lua_UnityEngine_Assertions_Assert.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Assertions_Assert.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Assertions_Assert.IsNotNull_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Assertions_Assert.<>f__mg$cache7);
		string name = "raiseExceptions";
		if (Lua_UnityEngine_Assertions_Assert.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Assertions_Assert.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Assertions_Assert.get_raiseExceptions);
		}
		LuaCSFunction get = Lua_UnityEngine_Assertions_Assert.<>f__mg$cache8;
		if (Lua_UnityEngine_Assertions_Assert.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Assertions_Assert.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Assertions_Assert.set_raiseExceptions);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Assertions_Assert.<>f__mg$cache9, false);
		LuaObject.createTypeMetatable(l, null, typeof(Assert));
	}

	// Token: 0x04018BD5 RID: 101333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018BD6 RID: 101334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018BD7 RID: 101335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018BD8 RID: 101336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018BD9 RID: 101337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018BDA RID: 101338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018BDB RID: 101339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018BDC RID: 101340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018BDD RID: 101341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018BDE RID: 101342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
