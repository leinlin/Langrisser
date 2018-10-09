using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016D4 RID: 5844
[Preserve]
public class Lua_UnityEngine_GameObject : LuaObject
{
	// Token: 0x06023270 RID: 143984 RVA: 0x00C2DB6C File Offset: 0x00C2BD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				string name;
				LuaObject.checkType(l, 2, out name);
				GameObject o = new GameObject(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 1)
			{
				GameObject o = new GameObject();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				string name2;
				LuaObject.checkType(l, 2, out name2);
				Type[] components;
				LuaObject.checkParams<Type>(l, 3, out components);
				GameObject o = new GameObject(name2, components);
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

	// Token: 0x06023271 RID: 143985 RVA: 0x00C2DC3C File Offset: 0x00C2BE3C
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
				GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
				Type type;
				LuaObject.checkType(l, 2, out type);
				Component component = gameObject.GetComponent(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, component);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				GameObject gameObject2 = (GameObject)LuaObject.checkSelf(l);
				string type2;
				LuaObject.checkType(l, 2, out type2);
				Component component2 = gameObject2.GetComponent(type2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, component2);
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

	// Token: 0x06023272 RID: 143986 RVA: 0x00C2DD28 File Offset: 0x00C2BF28
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
				GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
				Type type;
				LuaObject.checkType(l, 2, out type);
				Component componentInChildren = gameObject.GetComponentInChildren(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, componentInChildren);
				result = 2;
			}
			else if (num == 3)
			{
				GameObject gameObject2 = (GameObject)LuaObject.checkSelf(l);
				Type type2;
				LuaObject.checkType(l, 2, out type2);
				bool includeInactive;
				LuaObject.checkType(l, 3, out includeInactive);
				Component componentInChildren2 = gameObject2.GetComponentInChildren(type2, includeInactive);
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

	// Token: 0x06023273 RID: 143987 RVA: 0x00C2DE00 File Offset: 0x00C2C000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetComponentInParent(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			Type type;
			LuaObject.checkType(l, 2, out type);
			Component componentInParent = gameObject.GetComponentInParent(type);
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

	// Token: 0x06023274 RID: 143988 RVA: 0x00C2DE64 File Offset: 0x00C2C064
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
				GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
				Type type;
				LuaObject.checkType(l, 2, out type);
				Component[] components = gameObject.GetComponents(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, components);
				result = 2;
			}
			else if (num == 3)
			{
				GameObject gameObject2 = (GameObject)LuaObject.checkSelf(l);
				Type type2;
				LuaObject.checkType(l, 2, out type2);
				List<Component> results;
				LuaObject.checkType<List<Component>>(l, 3, out results);
				gameObject2.GetComponents(type2, results);
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

	// Token: 0x06023275 RID: 143989 RVA: 0x00C2DF34 File Offset: 0x00C2C134
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
				GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
				Type type;
				LuaObject.checkType(l, 2, out type);
				Component[] componentsInChildren = gameObject.GetComponentsInChildren(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, componentsInChildren);
				result = 2;
			}
			else if (num == 3)
			{
				GameObject gameObject2 = (GameObject)LuaObject.checkSelf(l);
				Type type2;
				LuaObject.checkType(l, 2, out type2);
				bool includeInactive;
				LuaObject.checkType(l, 3, out includeInactive);
				Component[] componentsInChildren2 = gameObject2.GetComponentsInChildren(type2, includeInactive);
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

	// Token: 0x06023276 RID: 143990 RVA: 0x00C2E00C File Offset: 0x00C2C20C
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
				GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
				Type type;
				LuaObject.checkType(l, 2, out type);
				Component[] componentsInParent = gameObject.GetComponentsInParent(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, componentsInParent);
				result = 2;
			}
			else if (num == 3)
			{
				GameObject gameObject2 = (GameObject)LuaObject.checkSelf(l);
				Type type2;
				LuaObject.checkType(l, 2, out type2);
				bool includeInactive;
				LuaObject.checkType(l, 3, out includeInactive);
				Component[] componentsInParent2 = gameObject2.GetComponentsInParent(type2, includeInactive);
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

	// Token: 0x06023277 RID: 143991 RVA: 0x00C2E0E4 File Offset: 0x00C2C2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetActive(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			bool active;
			LuaObject.checkType(l, 2, out active);
			gameObject.SetActive(active);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023278 RID: 143992 RVA: 0x00C2E13C File Offset: 0x00C2C33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareTag(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			bool b = gameObject.CompareTag(tag);
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

	// Token: 0x06023279 RID: 143993 RVA: 0x00C2E1A0 File Offset: 0x00C2C3A0
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
				GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
				string methodName;
				LuaObject.checkType(l, 2, out methodName);
				gameObject.SendMessageUpwards(methodName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(SendMessageOptions)))
			{
				GameObject gameObject2 = (GameObject)LuaObject.checkSelf(l);
				string methodName2;
				LuaObject.checkType(l, 2, out methodName2);
				SendMessageOptions options;
				LuaObject.checkEnum<SendMessageOptions>(l, 3, out options);
				gameObject2.SendMessageUpwards(methodName2, options);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(object)))
			{
				GameObject gameObject3 = (GameObject)LuaObject.checkSelf(l);
				string methodName3;
				LuaObject.checkType(l, 2, out methodName3);
				object value;
				LuaObject.checkType<object>(l, 3, out value);
				gameObject3.SendMessageUpwards(methodName3, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				GameObject gameObject4 = (GameObject)LuaObject.checkSelf(l);
				string methodName4;
				LuaObject.checkType(l, 2, out methodName4);
				object value2;
				LuaObject.checkType<object>(l, 3, out value2);
				SendMessageOptions options2;
				LuaObject.checkEnum<SendMessageOptions>(l, 4, out options2);
				gameObject4.SendMessageUpwards(methodName4, value2, options2);
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

	// Token: 0x0602327A RID: 143994 RVA: 0x00C2E330 File Offset: 0x00C2C530
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
				GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
				string methodName;
				LuaObject.checkType(l, 2, out methodName);
				gameObject.SendMessage(methodName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(SendMessageOptions)))
			{
				GameObject gameObject2 = (GameObject)LuaObject.checkSelf(l);
				string methodName2;
				LuaObject.checkType(l, 2, out methodName2);
				SendMessageOptions options;
				LuaObject.checkEnum<SendMessageOptions>(l, 3, out options);
				gameObject2.SendMessage(methodName2, options);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(object)))
			{
				GameObject gameObject3 = (GameObject)LuaObject.checkSelf(l);
				string methodName3;
				LuaObject.checkType(l, 2, out methodName3);
				object value;
				LuaObject.checkType<object>(l, 3, out value);
				gameObject3.SendMessage(methodName3, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				GameObject gameObject4 = (GameObject)LuaObject.checkSelf(l);
				string methodName4;
				LuaObject.checkType(l, 2, out methodName4);
				object value2;
				LuaObject.checkType<object>(l, 3, out value2);
				SendMessageOptions options2;
				LuaObject.checkEnum<SendMessageOptions>(l, 4, out options2);
				gameObject4.SendMessage(methodName4, value2, options2);
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

	// Token: 0x0602327B RID: 143995 RVA: 0x00C2E4C0 File Offset: 0x00C2C6C0
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
				GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
				string methodName;
				LuaObject.checkType(l, 2, out methodName);
				gameObject.BroadcastMessage(methodName);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(SendMessageOptions)))
			{
				GameObject gameObject2 = (GameObject)LuaObject.checkSelf(l);
				string methodName2;
				LuaObject.checkType(l, 2, out methodName2);
				SendMessageOptions options;
				LuaObject.checkEnum<SendMessageOptions>(l, 3, out options);
				gameObject2.BroadcastMessage(methodName2, options);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(object)))
			{
				GameObject gameObject3 = (GameObject)LuaObject.checkSelf(l);
				string methodName3;
				LuaObject.checkType(l, 2, out methodName3);
				object parameter;
				LuaObject.checkType<object>(l, 3, out parameter);
				gameObject3.BroadcastMessage(methodName3, parameter);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				GameObject gameObject4 = (GameObject)LuaObject.checkSelf(l);
				string methodName4;
				LuaObject.checkType(l, 2, out methodName4);
				object parameter2;
				LuaObject.checkType<object>(l, 3, out parameter2);
				SendMessageOptions options2;
				LuaObject.checkEnum<SendMessageOptions>(l, 4, out options2);
				gameObject4.BroadcastMessage(methodName4, parameter2, options2);
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

	// Token: 0x0602327C RID: 143996 RVA: 0x00C2E650 File Offset: 0x00C2C850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddComponent(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
				Type componentType;
				LuaObject.checkType(l, 2, out componentType);
				Component o = gameObject.AddComponent(componentType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 1)
			{
				GameObject gameObject2 = (GameObject)LuaObject.checkSelf(l);
				Component o2 = gameObject2.AddComponent<Component>();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddComponent to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602327D RID: 143997 RVA: 0x00C2E710 File Offset: 0x00C2C910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreatePrimitive_s(IntPtr l)
	{
		int result;
		try
		{
			PrimitiveType type;
			LuaObject.checkEnum<PrimitiveType>(l, 1, out type);
			GameObject o = GameObject.CreatePrimitive(type);
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

	// Token: 0x0602327E RID: 143998 RVA: 0x00C2E764 File Offset: 0x00C2C964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindGameObjectWithTag_s(IntPtr l)
	{
		int result;
		try
		{
			string tag;
			LuaObject.checkType(l, 1, out tag);
			GameObject o = GameObject.FindGameObjectWithTag(tag);
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

	// Token: 0x0602327F RID: 143999 RVA: 0x00C2E7B8 File Offset: 0x00C2C9B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindWithTag_s(IntPtr l)
	{
		int result;
		try
		{
			string tag;
			LuaObject.checkType(l, 1, out tag);
			GameObject o = GameObject.FindWithTag(tag);
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

	// Token: 0x06023280 RID: 144000 RVA: 0x00C2E80C File Offset: 0x00C2CA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindGameObjectsWithTag_s(IntPtr l)
	{
		int result;
		try
		{
			string tag;
			LuaObject.checkType(l, 1, out tag);
			GameObject[] a = GameObject.FindGameObjectsWithTag(tag);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, a);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023281 RID: 144001 RVA: 0x00C2E860 File Offset: 0x00C2CA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Find_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			GameObject o = GameObject.Find(name);
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

	// Token: 0x06023282 RID: 144002 RVA: 0x00C2E8B4 File Offset: 0x00C2CAB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transform(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameObject.transform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023283 RID: 144003 RVA: 0x00C2E908 File Offset: 0x00C2CB08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layer(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameObject.layer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023284 RID: 144004 RVA: 0x00C2E95C File Offset: 0x00C2CB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_layer(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			int layer;
			LuaObject.checkType(l, 2, out layer);
			gameObject.layer = layer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023285 RID: 144005 RVA: 0x00C2E9B4 File Offset: 0x00C2CBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_activeSelf(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameObject.activeSelf);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023286 RID: 144006 RVA: 0x00C2EA08 File Offset: 0x00C2CC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_activeInHierarchy(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameObject.activeInHierarchy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023287 RID: 144007 RVA: 0x00C2EA5C File Offset: 0x00C2CC5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isStatic(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameObject.isStatic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023288 RID: 144008 RVA: 0x00C2EAB0 File Offset: 0x00C2CCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isStatic(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			bool isStatic;
			LuaObject.checkType(l, 2, out isStatic);
			gameObject.isStatic = isStatic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023289 RID: 144009 RVA: 0x00C2EB08 File Offset: 0x00C2CD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tag(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameObject.tag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602328A RID: 144010 RVA: 0x00C2EB5C File Offset: 0x00C2CD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_tag(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			string tag;
			LuaObject.checkType(l, 2, out tag);
			gameObject.tag = tag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602328B RID: 144011 RVA: 0x00C2EBB4 File Offset: 0x00C2CDB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_scene(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameObject.scene);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602328C RID: 144012 RVA: 0x00C2EC0C File Offset: 0x00C2CE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gameObject(IntPtr l)
	{
		int result;
		try
		{
			GameObject gameObject = (GameObject)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameObject.gameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602328D RID: 144013 RVA: 0x00C2EC60 File Offset: 0x00C2CE60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.GameObject");
		if (Lua_UnityEngine_GameObject.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_GameObject.GetComponent);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cache0);
		if (Lua_UnityEngine_GameObject.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_GameObject.GetComponentInChildren);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cache1);
		if (Lua_UnityEngine_GameObject.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_GameObject.GetComponentInParent);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cache2);
		if (Lua_UnityEngine_GameObject.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_GameObject.GetComponents);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cache3);
		if (Lua_UnityEngine_GameObject.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_GameObject.GetComponentsInChildren);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cache4);
		if (Lua_UnityEngine_GameObject.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_GameObject.GetComponentsInParent);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cache5);
		if (Lua_UnityEngine_GameObject.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_GameObject.SetActive);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cache6);
		if (Lua_UnityEngine_GameObject.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_GameObject.CompareTag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cache7);
		if (Lua_UnityEngine_GameObject.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_GameObject.SendMessageUpwards);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cache8);
		if (Lua_UnityEngine_GameObject.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_GameObject.SendMessage);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cache9);
		if (Lua_UnityEngine_GameObject.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_GameObject.BroadcastMessage);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cacheA);
		if (Lua_UnityEngine_GameObject.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_GameObject.AddComponent);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cacheB);
		if (Lua_UnityEngine_GameObject.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_GameObject.CreatePrimitive_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cacheC);
		if (Lua_UnityEngine_GameObject.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_GameObject.FindGameObjectWithTag_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cacheD);
		if (Lua_UnityEngine_GameObject.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_GameObject.FindWithTag_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cacheE);
		if (Lua_UnityEngine_GameObject.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_GameObject.FindGameObjectsWithTag_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cacheF);
		if (Lua_UnityEngine_GameObject.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_GameObject.Find_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_GameObject.<>f__mg$cache10);
		string name = "transform";
		if (Lua_UnityEngine_GameObject.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_GameObject.get_transform);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_GameObject.<>f__mg$cache11, null, true);
		string name2 = "layer";
		if (Lua_UnityEngine_GameObject.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_GameObject.get_layer);
		}
		LuaCSFunction get = Lua_UnityEngine_GameObject.<>f__mg$cache12;
		if (Lua_UnityEngine_GameObject.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_GameObject.set_layer);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_GameObject.<>f__mg$cache13, true);
		string name3 = "activeSelf";
		if (Lua_UnityEngine_GameObject.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_GameObject.get_activeSelf);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_GameObject.<>f__mg$cache14, null, true);
		string name4 = "activeInHierarchy";
		if (Lua_UnityEngine_GameObject.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_GameObject.get_activeInHierarchy);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_GameObject.<>f__mg$cache15, null, true);
		string name5 = "isStatic";
		if (Lua_UnityEngine_GameObject.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_GameObject.get_isStatic);
		}
		LuaCSFunction get2 = Lua_UnityEngine_GameObject.<>f__mg$cache16;
		if (Lua_UnityEngine_GameObject.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_GameObject.set_isStatic);
		}
		LuaObject.addMember(l, name5, get2, Lua_UnityEngine_GameObject.<>f__mg$cache17, true);
		string name6 = "tag";
		if (Lua_UnityEngine_GameObject.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_GameObject.get_tag);
		}
		LuaCSFunction get3 = Lua_UnityEngine_GameObject.<>f__mg$cache18;
		if (Lua_UnityEngine_GameObject.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_GameObject.set_tag);
		}
		LuaObject.addMember(l, name6, get3, Lua_UnityEngine_GameObject.<>f__mg$cache19, true);
		string name7 = "scene";
		if (Lua_UnityEngine_GameObject.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_GameObject.get_scene);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_GameObject.<>f__mg$cache1A, null, true);
		string name8 = "gameObject";
		if (Lua_UnityEngine_GameObject.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_GameObject.get_gameObject);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_GameObject.<>f__mg$cache1B, null, true);
		if (Lua_UnityEngine_GameObject.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_GameObject.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_GameObject.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_GameObject.<>f__mg$cache1C, typeof(GameObject), typeof(UnityEngine.Object));
	}

	// Token: 0x04019126 RID: 102694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019127 RID: 102695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019128 RID: 102696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019129 RID: 102697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401912A RID: 102698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401912B RID: 102699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401912C RID: 102700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401912D RID: 102701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401912E RID: 102702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401912F RID: 102703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019130 RID: 102704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019131 RID: 102705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019132 RID: 102706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019133 RID: 102707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019134 RID: 102708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019135 RID: 102709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019136 RID: 102710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019137 RID: 102711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019138 RID: 102712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019139 RID: 102713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401913A RID: 102714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401913B RID: 102715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401913C RID: 102716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401913D RID: 102717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401913E RID: 102718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401913F RID: 102719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019140 RID: 102720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019141 RID: 102721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019142 RID: 102722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
