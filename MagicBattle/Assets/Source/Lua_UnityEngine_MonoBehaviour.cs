using System;
using System.Collections;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001731 RID: 5937
[Preserve]
public class Lua_UnityEngine_MonoBehaviour : LuaObject
{
	// Token: 0x060236A9 RID: 145065 RVA: 0x00C536E8 File Offset: 0x00C518E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Invoke(IntPtr l)
	{
		int result;
		try
		{
			MonoBehaviour monoBehaviour = (MonoBehaviour)LuaObject.checkSelf(l);
			string methodName;
			LuaObject.checkType(l, 2, out methodName);
			float time;
			LuaObject.checkType(l, 3, out time);
			monoBehaviour.Invoke(methodName, time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236AA RID: 145066 RVA: 0x00C5374C File Offset: 0x00C5194C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InvokeRepeating(IntPtr l)
	{
		int result;
		try
		{
			MonoBehaviour monoBehaviour = (MonoBehaviour)LuaObject.checkSelf(l);
			string methodName;
			LuaObject.checkType(l, 2, out methodName);
			float time;
			LuaObject.checkType(l, 3, out time);
			float repeatRate;
			LuaObject.checkType(l, 4, out repeatRate);
			monoBehaviour.InvokeRepeating(methodName, time, repeatRate);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236AB RID: 145067 RVA: 0x00C537C0 File Offset: 0x00C519C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CancelInvoke(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				MonoBehaviour monoBehaviour = (MonoBehaviour)LuaObject.checkSelf(l);
				monoBehaviour.CancelInvoke();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				MonoBehaviour monoBehaviour2 = (MonoBehaviour)LuaObject.checkSelf(l);
				string methodName;
				LuaObject.checkType(l, 2, out methodName);
				monoBehaviour2.CancelInvoke(methodName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CancelInvoke to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236AC RID: 145068 RVA: 0x00C53868 File Offset: 0x00C51A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInvoking(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				MonoBehaviour monoBehaviour = (MonoBehaviour)LuaObject.checkSelf(l);
				string methodName;
				LuaObject.checkType(l, 2, out methodName);
				bool b = monoBehaviour.IsInvoking(methodName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 1)
			{
				MonoBehaviour monoBehaviour2 = (MonoBehaviour)LuaObject.checkSelf(l);
				bool b2 = monoBehaviour2.IsInvoking();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsInvoking to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236AD RID: 145069 RVA: 0x00C53928 File Offset: 0x00C51B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartCoroutine(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(LuaFunction)))
			{
				MonoBehaviour mb = (MonoBehaviour)LuaObject.checkSelf(l);
				LuaFunction func;
				LuaObject.checkType(l, 2, out func);
				mb.StartCoroutine(func);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(IEnumerator)))
			{
				MonoBehaviour monoBehaviour = (MonoBehaviour)LuaObject.checkSelf(l);
				IEnumerator routine;
				LuaObject.checkType<IEnumerator>(l, 2, out routine);
				Coroutine o = monoBehaviour.StartCoroutine(routine);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string)))
			{
				MonoBehaviour monoBehaviour2 = (MonoBehaviour)LuaObject.checkSelf(l);
				string methodName;
				LuaObject.checkType(l, 2, out methodName);
				Coroutine o2 = monoBehaviour2.StartCoroutine(methodName);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 3)
			{
				MonoBehaviour monoBehaviour3 = (MonoBehaviour)LuaObject.checkSelf(l);
				string methodName2;
				LuaObject.checkType(l, 2, out methodName2);
				object value;
				LuaObject.checkType<object>(l, 3, out value);
				Coroutine o3 = monoBehaviour3.StartCoroutine(methodName2, value);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function StartCoroutine to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236AE RID: 145070 RVA: 0x00C53AB0 File Offset: 0x00C51CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopCoroutine(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				MonoBehaviour monoBehaviour = (MonoBehaviour)LuaObject.checkSelf(l);
				string methodName;
				LuaObject.checkType(l, 2, out methodName);
				monoBehaviour.StopCoroutine(methodName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(IEnumerator)))
			{
				MonoBehaviour monoBehaviour2 = (MonoBehaviour)LuaObject.checkSelf(l);
				IEnumerator routine;
				LuaObject.checkType<IEnumerator>(l, 2, out routine);
				monoBehaviour2.StopCoroutine(routine);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Coroutine)))
			{
				MonoBehaviour monoBehaviour3 = (MonoBehaviour)LuaObject.checkSelf(l);
				Coroutine routine2;
				LuaObject.checkType<Coroutine>(l, 2, out routine2);
				monoBehaviour3.StopCoroutine(routine2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function StopCoroutine to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236AF RID: 145071 RVA: 0x00C53BCC File Offset: 0x00C51DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopAllCoroutines(IntPtr l)
	{
		int result;
		try
		{
			MonoBehaviour monoBehaviour = (MonoBehaviour)LuaObject.checkSelf(l);
			monoBehaviour.StopAllCoroutines();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236B0 RID: 145072 RVA: 0x00C53C18 File Offset: 0x00C51E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int print_s(IntPtr l)
	{
		int result;
		try
		{
			object message;
			LuaObject.checkType<object>(l, 1, out message);
			MonoBehaviour.print(message);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236B1 RID: 145073 RVA: 0x00C53C64 File Offset: 0x00C51E64
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.MonoBehaviour");
		if (Lua_UnityEngine_MonoBehaviour.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_MonoBehaviour.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_MonoBehaviour.Invoke);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MonoBehaviour.<>f__mg$cache0);
		if (Lua_UnityEngine_MonoBehaviour.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_MonoBehaviour.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_MonoBehaviour.InvokeRepeating);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MonoBehaviour.<>f__mg$cache1);
		if (Lua_UnityEngine_MonoBehaviour.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_MonoBehaviour.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_MonoBehaviour.CancelInvoke);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MonoBehaviour.<>f__mg$cache2);
		if (Lua_UnityEngine_MonoBehaviour.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_MonoBehaviour.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_MonoBehaviour.IsInvoking);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MonoBehaviour.<>f__mg$cache3);
		if (Lua_UnityEngine_MonoBehaviour.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_MonoBehaviour.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_MonoBehaviour.StartCoroutine);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MonoBehaviour.<>f__mg$cache4);
		if (Lua_UnityEngine_MonoBehaviour.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_MonoBehaviour.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_MonoBehaviour.StopCoroutine);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MonoBehaviour.<>f__mg$cache5);
		if (Lua_UnityEngine_MonoBehaviour.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_MonoBehaviour.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_MonoBehaviour.StopAllCoroutines);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MonoBehaviour.<>f__mg$cache6);
		if (Lua_UnityEngine_MonoBehaviour.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_MonoBehaviour.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_MonoBehaviour.print_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_MonoBehaviour.<>f__mg$cache7);
		LuaObject.createTypeMetatable(l, null, typeof(MonoBehaviour), typeof(Behaviour));
	}

	// Token: 0x040194A5 RID: 103589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040194A6 RID: 103590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040194A7 RID: 103591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040194A8 RID: 103592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040194A9 RID: 103593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040194AA RID: 103594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040194AB RID: 103595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040194AC RID: 103596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
