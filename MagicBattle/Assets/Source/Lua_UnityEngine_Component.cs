using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200166C RID: 5740
[Preserve]
public class Lua_UnityEngine_Component : LuaObject
{
	// Token: 0x06022EF4 RID: 143092 RVA: 0x00C153C0 File Offset: 0x00C135C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Component o = new Component();
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

	// Token: 0x06022EF5 RID: 143093 RVA: 0x00C15408 File Offset: 0x00C13608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetComponent(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Type)))
			{
				Component component = (Component)LuaObject.checkSelf(l);
				Type type;
				LuaObject.checkType(l, 2, out type);
				Component component2 = component.GetComponent(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, component2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Component component3 = (Component)LuaObject.checkSelf(l);
				string type2;
				LuaObject.checkType(l, 2, out type2);
				Component component4 = component3.GetComponent(type2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, component4);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetComponent to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EF6 RID: 143094 RVA: 0x00C154F4 File Offset: 0x00C136F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetComponentInChildren(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Component component = (Component)LuaObject.checkSelf(l);
				Type t;
				LuaObject.checkType(l, 2, out t);
				Component componentInChildren = component.GetComponentInChildren(t);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, componentInChildren);
				result = 2;
			}
			else if (num == 3)
			{
				Component component2 = (Component)LuaObject.checkSelf(l);
				Type t2;
				LuaObject.checkType(l, 2, out t2);
				bool includeInactive;
				LuaObject.checkType(l, 3, out includeInactive);
				Component componentInChildren2 = component2.GetComponentInChildren(t2, includeInactive);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, componentInChildren2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetComponentInChildren to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EF7 RID: 143095 RVA: 0x00C155CC File Offset: 0x00C137CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetComponentsInChildren(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Component component = (Component)LuaObject.checkSelf(l);
				Type t;
				LuaObject.checkType(l, 2, out t);
				Component[] componentsInChildren = component.GetComponentsInChildren(t);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, componentsInChildren);
				result = 2;
			}
			else if (num == 3)
			{
				Component component2 = (Component)LuaObject.checkSelf(l);
				Type t2;
				LuaObject.checkType(l, 2, out t2);
				bool includeInactive;
				LuaObject.checkType(l, 3, out includeInactive);
				Component[] componentsInChildren2 = component2.GetComponentsInChildren(t2, includeInactive);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, componentsInChildren2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetComponentsInChildren to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EF8 RID: 143096 RVA: 0x00C156A4 File Offset: 0x00C138A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetComponentInParent(IntPtr l)
	{
		int result;
		try
		{
			Component component = (Component)LuaObject.checkSelf(l);
			Type t;
			LuaObject.checkType(l, 2, out t);
			Component componentInParent = component.GetComponentInParent(t);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, componentInParent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EF9 RID: 143097 RVA: 0x00C15708 File Offset: 0x00C13908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetComponentsInParent(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Component component = (Component)LuaObject.checkSelf(l);
				Type t;
				LuaObject.checkType(l, 2, out t);
				Component[] componentsInParent = component.GetComponentsInParent(t);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, componentsInParent);
				result = 2;
			}
			else if (num == 3)
			{
				Component component2 = (Component)LuaObject.checkSelf(l);
				Type t2;
				LuaObject.checkType(l, 2, out t2);
				bool includeInactive;
				LuaObject.checkType(l, 3, out includeInactive);
				Component[] componentsInParent2 = component2.GetComponentsInParent(t2, includeInactive);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, componentsInParent2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetComponentsInParent to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EFA RID: 143098 RVA: 0x00C157E0 File Offset: 0x00C139E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetComponents(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Component component = (Component)LuaObject.checkSelf(l);
				Type type;
				LuaObject.checkType(l, 2, out type);
				Component[] components = component.GetComponents(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, components);
				result = 2;
			}
			else if (num == 3)
			{
				Component component2 = (Component)LuaObject.checkSelf(l);
				Type type2;
				LuaObject.checkType(l, 2, out type2);
				List<Component> results;
				LuaObject.checkType<List<Component>>(l, 3, out results);
				component2.GetComponents(type2, results);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetComponents to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EFB RID: 143099 RVA: 0x00C158B0 File Offset: 0x00C13AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareTag(IntPtr l)
	{
		int result;
		try
		{
			Component component = (Component)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			bool b = component.CompareTag(tag);
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

	// Token: 0x06022EFC RID: 143100 RVA: 0x00C15914 File Offset: 0x00C13B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendMessageUpwards(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Component component = (Component)LuaObject.checkSelf(l);
				string methodName;
				LuaObject.checkType(l, 2, out methodName);
				component.SendMessageUpwards(methodName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(SendMessageOptions)))
			{
				Component component2 = (Component)LuaObject.checkSelf(l);
				string methodName2;
				LuaObject.checkType(l, 2, out methodName2);
				SendMessageOptions options;
				LuaObject.checkEnum<SendMessageOptions>(l, 3, out options);
				component2.SendMessageUpwards(methodName2, options);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(object)))
			{
				Component component3 = (Component)LuaObject.checkSelf(l);
				string methodName3;
				LuaObject.checkType(l, 2, out methodName3);
				object value;
				LuaObject.checkType<object>(l, 3, out value);
				component3.SendMessageUpwards(methodName3, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Component component4 = (Component)LuaObject.checkSelf(l);
				string methodName4;
				LuaObject.checkType(l, 2, out methodName4);
				object value2;
				LuaObject.checkType<object>(l, 3, out value2);
				SendMessageOptions options2;
				LuaObject.checkEnum<SendMessageOptions>(l, 4, out options2);
				component4.SendMessageUpwards(methodName4, value2, options2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SendMessageUpwards to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EFD RID: 143101 RVA: 0x00C15AA4 File Offset: 0x00C13CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendMessage(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Component component = (Component)LuaObject.checkSelf(l);
				string methodName;
				LuaObject.checkType(l, 2, out methodName);
				component.SendMessage(methodName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(SendMessageOptions)))
			{
				Component component2 = (Component)LuaObject.checkSelf(l);
				string methodName2;
				LuaObject.checkType(l, 2, out methodName2);
				SendMessageOptions options;
				LuaObject.checkEnum<SendMessageOptions>(l, 3, out options);
				component2.SendMessage(methodName2, options);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(object)))
			{
				Component component3 = (Component)LuaObject.checkSelf(l);
				string methodName3;
				LuaObject.checkType(l, 2, out methodName3);
				object value;
				LuaObject.checkType<object>(l, 3, out value);
				component3.SendMessage(methodName3, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Component component4 = (Component)LuaObject.checkSelf(l);
				string methodName4;
				LuaObject.checkType(l, 2, out methodName4);
				object value2;
				LuaObject.checkType<object>(l, 3, out value2);
				SendMessageOptions options2;
				LuaObject.checkEnum<SendMessageOptions>(l, 4, out options2);
				component4.SendMessage(methodName4, value2, options2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SendMessage to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EFE RID: 143102 RVA: 0x00C15C34 File Offset: 0x00C13E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BroadcastMessage(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Component component = (Component)LuaObject.checkSelf(l);
				string methodName;
				LuaObject.checkType(l, 2, out methodName);
				component.BroadcastMessage(methodName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(SendMessageOptions)))
			{
				Component component2 = (Component)LuaObject.checkSelf(l);
				string methodName2;
				LuaObject.checkType(l, 2, out methodName2);
				SendMessageOptions options;
				LuaObject.checkEnum<SendMessageOptions>(l, 3, out options);
				component2.BroadcastMessage(methodName2, options);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(object)))
			{
				Component component3 = (Component)LuaObject.checkSelf(l);
				string methodName3;
				LuaObject.checkType(l, 2, out methodName3);
				object parameter;
				LuaObject.checkType<object>(l, 3, out parameter);
				component3.BroadcastMessage(methodName3, parameter);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Component component4 = (Component)LuaObject.checkSelf(l);
				string methodName4;
				LuaObject.checkType(l, 2, out methodName4);
				object parameter2;
				LuaObject.checkType<object>(l, 3, out parameter2);
				SendMessageOptions options2;
				LuaObject.checkEnum<SendMessageOptions>(l, 4, out options2);
				component4.BroadcastMessage(methodName4, parameter2, options2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function BroadcastMessage to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EFF RID: 143103 RVA: 0x00C15DC4 File Offset: 0x00C13FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transform(IntPtr l)
	{
		int result;
		try
		{
			Component component = (Component)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, component.transform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F00 RID: 143104 RVA: 0x00C15E18 File Offset: 0x00C14018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gameObject(IntPtr l)
	{
		int result;
		try
		{
			Component component = (Component)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, component.gameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F01 RID: 143105 RVA: 0x00C15E6C File Offset: 0x00C1406C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tag(IntPtr l)
	{
		int result;
		try
		{
			Component component = (Component)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, component.tag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F02 RID: 143106 RVA: 0x00C15EC0 File Offset: 0x00C140C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_tag(IntPtr l)
	{
		int result;
		try
		{
			Component component = (Component)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			component.tag = tag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F03 RID: 143107 RVA: 0x00C15F18 File Offset: 0x00C14118
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Component");
		if (Lua_UnityEngine_Component.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Component.GetComponent);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Component.<>f__mg$cache0);
		if (Lua_UnityEngine_Component.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Component.GetComponentInChildren);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Component.<>f__mg$cache1);
		if (Lua_UnityEngine_Component.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Component.GetComponentsInChildren);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Component.<>f__mg$cache2);
		if (Lua_UnityEngine_Component.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Component.GetComponentInParent);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Component.<>f__mg$cache3);
		if (Lua_UnityEngine_Component.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Component.GetComponentsInParent);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Component.<>f__mg$cache4);
		if (Lua_UnityEngine_Component.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Component.GetComponents);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Component.<>f__mg$cache5);
		if (Lua_UnityEngine_Component.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Component.CompareTag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Component.<>f__mg$cache6);
		if (Lua_UnityEngine_Component.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Component.SendMessageUpwards);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Component.<>f__mg$cache7);
		if (Lua_UnityEngine_Component.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Component.SendMessage);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Component.<>f__mg$cache8);
		if (Lua_UnityEngine_Component.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Component.BroadcastMessage);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Component.<>f__mg$cache9);
		string name = "transform";
		if (Lua_UnityEngine_Component.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Component.get_transform);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Component.<>f__mg$cacheA, null, true);
		string name2 = "gameObject";
		if (Lua_UnityEngine_Component.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Component.get_gameObject);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Component.<>f__mg$cacheB, null, true);
		string name3 = "tag";
		if (Lua_UnityEngine_Component.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Component.get_tag);
		}
		LuaCSFunction get = Lua_UnityEngine_Component.<>f__mg$cacheC;
		if (Lua_UnityEngine_Component.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Component.set_tag);
		}
		LuaObject.addMember(l, name3, get, Lua_UnityEngine_Component.<>f__mg$cacheD, true);
		if (Lua_UnityEngine_Component.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Component.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Component.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Component.<>f__mg$cacheE, typeof(Component), typeof(UnityEngine.Object));
	}

	// Token: 0x04018E7A RID: 102010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018E7B RID: 102011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018E7C RID: 102012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018E7D RID: 102013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018E7E RID: 102014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018E7F RID: 102015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018E80 RID: 102016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018E81 RID: 102017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018E82 RID: 102018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018E83 RID: 102019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018E84 RID: 102020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018E85 RID: 102021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018E86 RID: 102022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018E87 RID: 102023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018E88 RID: 102024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
