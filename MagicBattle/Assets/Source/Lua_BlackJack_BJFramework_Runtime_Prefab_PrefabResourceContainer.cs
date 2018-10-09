using System;
using BlackJack.BJFramework.Runtime.Prefab;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001116 RID: 4374
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_Prefab_PrefabResourceContainer : LuaObject
{
	// Token: 0x06015BF7 RID: 89079 RVA: 0x0059A15C File Offset: 0x0059835C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.Prefab.PrefabResourceContainer");
		LuaObject.createTypeMetatable(l, null, typeof(PrefabResourceContainer), typeof(PrefabResourceContainerBase));
	}
}
