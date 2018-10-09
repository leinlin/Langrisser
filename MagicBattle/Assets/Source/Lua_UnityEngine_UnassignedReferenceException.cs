using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200186F RID: 6255
[Preserve]
public class Lua_UnityEngine_UnassignedReferenceException : LuaObject
{
	// Token: 0x0602434A RID: 148298 RVA: 0x00CB83E8 File Offset: 0x00CB65E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				UnassignedReferenceException o = new UnassignedReferenceException();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				string message;
				LuaObject.checkType(l, 2, out message);
				UnassignedReferenceException o = new UnassignedReferenceException(message);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				string message2;
				LuaObject.checkType(l, 2, out message2);
				Exception innerException;
				LuaObject.checkType<Exception>(l, 3, out innerException);
				UnassignedReferenceException o = new UnassignedReferenceException(message2, innerException);
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

	// Token: 0x0602434B RID: 148299 RVA: 0x00CB84B8 File Offset: 0x00CB66B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UnassignedReferenceException");
		if (Lua_UnityEngine_UnassignedReferenceException.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UnassignedReferenceException.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UnassignedReferenceException.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UnassignedReferenceException.<>f__mg$cache0, typeof(UnassignedReferenceException), typeof(SystemException));
	}

	// Token: 0x04019ECA RID: 106186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
