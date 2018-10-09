using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200183D RID: 6205
[Preserve]
public class Lua_UnityEngine_UI_IMaterialModifier : LuaObject
{
	// Token: 0x0602410F RID: 147727 RVA: 0x00CA9554 File Offset: 0x00CA7754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetModifiedMaterial(IntPtr l)
	{
		int result;
		try
		{
			IMaterialModifier materialModifier = (IMaterialModifier)LuaObject.checkSelf(l);
			Material baseMaterial;
			LuaObject.checkType<Material>(l, 2, out baseMaterial);
			Material modifiedMaterial = materialModifier.GetModifiedMaterial(baseMaterial);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, modifiedMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024110 RID: 147728 RVA: 0x00CA95B8 File Offset: 0x00CA77B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.IMaterialModifier");
		if (Lua_UnityEngine_UI_IMaterialModifier.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_IMaterialModifier.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_IMaterialModifier.GetModifiedMaterial);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_IMaterialModifier.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IMaterialModifier));
	}

	// Token: 0x04019CF3 RID: 105715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
