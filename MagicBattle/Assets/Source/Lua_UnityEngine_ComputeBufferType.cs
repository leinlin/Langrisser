using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001671 RID: 5745
[Preserve]
public class Lua_UnityEngine_ComputeBufferType : LuaObject
{
	// Token: 0x06022F24 RID: 143140 RVA: 0x00C16ECC File Offset: 0x00C150CC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ComputeBufferType");
		LuaObject.addMember(l, 0, "Default");
		LuaObject.addMember(l, 1, "Raw");
		LuaObject.addMember(l, 2, "Append");
		LuaObject.addMember(l, 4, "Counter");
		LuaObject.addMember(l, 256, "IndirectArguments");
		LuaObject.addMember(l, 256, "DrawIndirect");
		LuaObject.addMember(l, 512, "GPUMemory");
		LuaDLL.lua_pop(l, 1);
	}
}
