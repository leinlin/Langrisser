using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016F4 RID: 5876
[Preserve]
public class Lua_UnityEngine_ISerializationCallbackReceiver : LuaObject
{
	// Token: 0x060233D2 RID: 144338 RVA: 0x00C3ADCC File Offset: 0x00C38FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeforeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ISerializationCallbackReceiver serializationCallbackReceiver = (ISerializationCallbackReceiver)LuaObject.checkSelf(l);
			serializationCallbackReceiver.OnBeforeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233D3 RID: 144339 RVA: 0x00C3AE18 File Offset: 0x00C39018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAfterDeserialize(IntPtr l)
	{
		int result;
		try
		{
			ISerializationCallbackReceiver serializationCallbackReceiver = (ISerializationCallbackReceiver)LuaObject.checkSelf(l);
			serializationCallbackReceiver.OnAfterDeserialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233D4 RID: 144340 RVA: 0x00C3AE64 File Offset: 0x00C39064
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ISerializationCallbackReceiver");
		if (Lua_UnityEngine_ISerializationCallbackReceiver.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ISerializationCallbackReceiver.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ISerializationCallbackReceiver.OnBeforeSerialize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ISerializationCallbackReceiver.<>f__mg$cache0);
		if (Lua_UnityEngine_ISerializationCallbackReceiver.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ISerializationCallbackReceiver.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ISerializationCallbackReceiver.OnAfterDeserialize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ISerializationCallbackReceiver.<>f__mg$cache1);
		LuaObject.createTypeMetatable(l, null, typeof(ISerializationCallbackReceiver));
	}

	// Token: 0x04019248 RID: 102984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019249 RID: 102985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
