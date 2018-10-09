using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001348 RID: 4936
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_GraphicPool : LuaObject
{
	// Token: 0x0601A83B RID: 108603 RVA: 0x007DCEE8 File Offset: 0x007DB0E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			bool isFx;
			LuaObject.checkType(l, 2, out isFx);
			GraphicPool o = new GraphicPool(isFx);
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

	// Token: 0x0601A83C RID: 108604 RVA: 0x007DCF3C File Offset: 0x007DB13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDefaultParent(IntPtr l)
	{
		int result;
		try
		{
			GraphicPool graphicPool = (GraphicPool)LuaObject.checkSelf(l);
			GameObject defaultParent;
			LuaObject.checkType<GameObject>(l, 2, out defaultParent);
			graphicPool.SetDefaultParent(defaultParent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A83D RID: 108605 RVA: 0x007DCF94 File Offset: 0x007DB194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Create(IntPtr l)
	{
		int result;
		try
		{
			GraphicPool graphicPool = (GraphicPool)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			GenericGraphic o = graphicPool.Create(assetName);
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

	// Token: 0x0601A83E RID: 108606 RVA: 0x007DCFF8 File Offset: 0x007DB1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Destroy(IntPtr l)
	{
		int result;
		try
		{
			GraphicPool graphicPool = (GraphicPool)LuaObject.checkSelf(l);
			GenericGraphic g;
			LuaObject.checkType<GenericGraphic>(l, 2, out g);
			graphicPool.Destroy(g);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A83F RID: 108607 RVA: 0x007DD050 File Offset: 0x007DB250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			GraphicPool graphicPool = (GraphicPool)LuaObject.checkSelf(l);
			graphicPool.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A840 RID: 108608 RVA: 0x007DD09C File Offset: 0x007DB29C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.GraphicPool");
		if (Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GraphicPool.SetDefaultParent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GraphicPool.Create);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GraphicPool.Destroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GraphicPool.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GraphicPool.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_GraphicPool.<>f__mg$cache4, typeof(GraphicPool));
	}

	// Token: 0x04010B8D RID: 68493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010B8E RID: 68494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010B8F RID: 68495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010B90 RID: 68496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010B91 RID: 68497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
