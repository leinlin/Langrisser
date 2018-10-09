using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011AC RID: 4524
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_EntityList : LuaObject
{
	// Token: 0x060176C2 RID: 95938 RVA: 0x00663180 File Offset: 0x00661380
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			EntityList o = new EntityList();
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

	// Token: 0x060176C3 RID: 95939 RVA: 0x006631C8 File Offset: 0x006613C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveAll_s(IntPtr l)
	{
		int result;
		try
		{
			List<Entity> list;
			LuaObject.checkType<List<Entity>>(l, 1, out list);
			EntityList.RemoveAll<Entity>(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176C4 RID: 95940 RVA: 0x00663214 File Offset: 0x00661414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick_s(IntPtr l)
	{
		int result;
		try
		{
			List<Entity> list;
			LuaObject.checkType<List<Entity>>(l, 1, out list);
			EntityList.Tick<Entity>(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176C5 RID: 95941 RVA: 0x00663260 File Offset: 0x00661460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveDeleted_s(IntPtr l)
	{
		int result;
		try
		{
			List<Entity> list;
			LuaObject.checkType<List<Entity>>(l, 1, out list);
			EntityList.RemoveDeleted<Entity>(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176C6 RID: 95942 RVA: 0x006632AC File Offset: 0x006614AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TickGraphic_s(IntPtr l)
	{
		int result;
		try
		{
			List<Entity> list;
			LuaObject.checkType<List<Entity>>(l, 1, out list);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			EntityList.TickGraphic<Entity>(list, dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176C7 RID: 95943 RVA: 0x00663304 File Offset: 0x00661504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Draw_s(IntPtr l)
	{
		int result;
		try
		{
			List<Entity> list;
			LuaObject.checkType<List<Entity>>(l, 1, out list);
			EntityList.Draw<Entity>(list);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176C8 RID: 95944 RVA: 0x00663350 File Offset: 0x00661550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Pause_s(IntPtr l)
	{
		int result;
		try
		{
			List<Entity> list;
			LuaObject.checkType<List<Entity>>(l, 1, out list);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			EntityList.Pause<Entity>(list, pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176C9 RID: 95945 RVA: 0x006633A8 File Offset: 0x006615A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.EntityList");
		if (Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_EntityList.RemoveAll_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_EntityList.Tick_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_EntityList.RemoveDeleted_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_EntityList.TickGraphic_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_EntityList.Draw_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_EntityList.Pause_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_EntityList.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_EntityList.<>f__mg$cache6, typeof(EntityList));
	}

	// Token: 0x0400DD4C RID: 56652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DD4D RID: 56653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DD4E RID: 56654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DD4F RID: 56655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DD50 RID: 56656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DD51 RID: 56657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DD52 RID: 56658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
