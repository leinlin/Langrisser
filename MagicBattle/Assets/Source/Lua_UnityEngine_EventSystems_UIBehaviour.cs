using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016C4 RID: 5828
[Preserve]
public class Lua_UnityEngine_EventSystems_UIBehaviour : LuaObject
{
	// Token: 0x06023211 RID: 143889 RVA: 0x00C2B6F4 File Offset: 0x00C298F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsActive(IntPtr l)
	{
		int result;
		try
		{
			UIBehaviour uibehaviour = (UIBehaviour)LuaObject.checkSelf(l);
			bool b = uibehaviour.IsActive();
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

	// Token: 0x06023212 RID: 143890 RVA: 0x00C2B748 File Offset: 0x00C29948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDestroyed(IntPtr l)
	{
		int result;
		try
		{
			UIBehaviour uibehaviour = (UIBehaviour)LuaObject.checkSelf(l);
			bool b = uibehaviour.IsDestroyed();
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

	// Token: 0x06023213 RID: 143891 RVA: 0x00C2B79C File Offset: 0x00C2999C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.UIBehaviour");
		if (Lua_UnityEngine_EventSystems_UIBehaviour.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_UIBehaviour.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_UIBehaviour.IsActive);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_UIBehaviour.<>f__mg$cache0);
		if (Lua_UnityEngine_EventSystems_UIBehaviour.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_UIBehaviour.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_UIBehaviour.IsDestroyed);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_UIBehaviour.<>f__mg$cache1);
		LuaObject.createTypeMetatable(l, null, typeof(UIBehaviour), typeof(MonoBehaviour));
	}

	// Token: 0x040190E7 RID: 102631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040190E8 RID: 102632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
