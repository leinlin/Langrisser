using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011AB RID: 4523
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_Entity : LuaObject
{
	// Token: 0x060176AF RID: 95919 RVA: 0x00662954 File Offset: 0x00660B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Entity o = new Entity();
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

	// Token: 0x060176B0 RID: 95920 RVA: 0x0066299C File Offset: 0x00660B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			entity.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176B1 RID: 95921 RVA: 0x006629E8 File Offset: 0x00660BE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			entity.Tick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176B2 RID: 95922 RVA: 0x00662A34 File Offset: 0x00660C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TickGraphic(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			entity.TickGraphic(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176B3 RID: 95923 RVA: 0x00662A8C File Offset: 0x00660C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Draw(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			entity.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176B4 RID: 95924 RVA: 0x00662AD8 File Offset: 0x00660CD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Pause(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			entity.Pause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176B5 RID: 95925 RVA: 0x00662B30 File Offset: 0x00660D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoPause(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			bool pause;
			LuaObject.checkType(l, 2, out pause);
			entity.DoPause(pause);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176B6 RID: 95926 RVA: 0x00662B88 File Offset: 0x00660D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeleteMe(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			entity.DeleteMe();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176B7 RID: 95927 RVA: 0x00662BD4 File Offset: 0x00660DD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isDeleteMe(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, entity.m_luaExportHelper.m_isDeleteMe);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176B8 RID: 95928 RVA: 0x00662C2C File Offset: 0x00660E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDeleteMe(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			bool isDeleteMe;
			LuaObject.checkType(l, 2, out isDeleteMe);
			entity.m_luaExportHelper.m_isDeleteMe = isDeleteMe;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176B9 RID: 95929 RVA: 0x00662C88 File Offset: 0x00660E88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isPaused(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, entity.m_luaExportHelper.m_isPaused);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176BA RID: 95930 RVA: 0x00662CE0 File Offset: 0x00660EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPaused(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			bool isPaused;
			LuaObject.checkType(l, 2, out isPaused);
			entity.m_luaExportHelper.m_isPaused = isPaused;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176BB RID: 95931 RVA: 0x00662D3C File Offset: 0x00660F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_id(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, entity.m_luaExportHelper.m_id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176BC RID: 95932 RVA: 0x00662D94 File Offset: 0x00660F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_id(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			entity.m_luaExportHelper.m_id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176BD RID: 95933 RVA: 0x00662DF0 File Offset: 0x00660FF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, entity.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176BE RID: 95934 RVA: 0x00662E44 File Offset: 0x00661044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsDeleteMe(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, entity.IsDeleteMe);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176BF RID: 95935 RVA: 0x00662E98 File Offset: 0x00661098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsPaused(IntPtr l)
	{
		int result;
		try
		{
			Entity entity = (Entity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, entity.IsPaused);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060176C0 RID: 95936 RVA: 0x00662EEC File Offset: 0x006610EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.Entity");
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.TickGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.Draw);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.Pause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.DoPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.DeleteMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache6);
		string name = "m_isDeleteMe";
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.get_m_isDeleteMe);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.set_m_isDeleteMe);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache8, true);
		string name2 = "m_isPaused";
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.get_m_isPaused);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.set_m_isPaused);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheA, true);
		string name3 = "m_id";
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.get_m_id);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.set_m_id);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheC, true);
		string name4 = "Id";
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.get_Id);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheD, null, true);
		string name5 = "IsDeleteMe";
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.get_IsDeleteMe);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheE, null, true);
		string name6 = "IsPaused";
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.get_IsPaused);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cacheF, null, true);
		if (Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_Entity.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_Entity.<>f__mg$cache10, typeof(Entity));
	}

	// Token: 0x0400DD3B RID: 56635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DD3C RID: 56636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DD3D RID: 56637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DD3E RID: 56638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DD3F RID: 56639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DD40 RID: 56640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DD41 RID: 56641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DD42 RID: 56642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DD43 RID: 56643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DD44 RID: 56644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DD45 RID: 56645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DD46 RID: 56646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DD47 RID: 56647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DD48 RID: 56648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DD49 RID: 56649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DD4A RID: 56650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DD4B RID: 56651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
