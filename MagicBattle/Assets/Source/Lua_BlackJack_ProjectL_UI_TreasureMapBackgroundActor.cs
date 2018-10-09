using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Art;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020015BC RID: 5564
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor : LuaObject
{
	// Token: 0x06021D00 RID: 138496 RVA: 0x00B7E6EC File Offset: 0x00B7C8EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapBackgroundActor o = new TreasureMapBackgroundActor();
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

	// Token: 0x06021D01 RID: 138497 RVA: 0x00B7E734 File Offset: 0x00B7C934
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Create(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapBackgroundActor treasureMapBackgroundActor = (TreasureMapBackgroundActor)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 3, out parent);
			treasureMapBackgroundActor.Create(name, parent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D02 RID: 138498 RVA: 0x00B7E798 File Offset: 0x00B7C998
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Destroy(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapBackgroundActor treasureMapBackgroundActor = (TreasureMapBackgroundActor)LuaObject.checkSelf(l);
			treasureMapBackgroundActor.Destroy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D03 RID: 138499 RVA: 0x00B7E7E4 File Offset: 0x00B7C9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSound(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapBackgroundActor treasureMapBackgroundActor = (TreasureMapBackgroundActor)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			treasureMapBackgroundActor.OnSound(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x06021D04 RID: 138500 RVA: 0x00B7E848 File Offset: 0x00B7CA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCameraEffect(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapBackgroundActor treasureMapBackgroundActor = (TreasureMapBackgroundActor)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			treasureMapBackgroundActor.OnCameraEffect(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x06021D05 RID: 138501 RVA: 0x00B7E8AC File Offset: 0x00B7CAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScreenEffect(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapBackgroundActor treasureMapBackgroundActor = (TreasureMapBackgroundActor)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string name;
			LuaObject.checkType(l, 3, out name);
			treasureMapBackgroundActor.OnScreenEffect(e, name);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x06021D06 RID: 138502 RVA: 0x00B7E910 File Offset: 0x00B7CB10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnGeneral(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapBackgroundActor treasureMapBackgroundActor = (TreasureMapBackgroundActor)LuaObject.checkSelf(l);
			FxEvent e;
			LuaObject.checkType<FxEvent>(l, 2, out e);
			string cmd;
			LuaObject.checkType(l, 3, out cmd);
			treasureMapBackgroundActor.OnGeneral(e, cmd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x06021D07 RID: 138503 RVA: 0x00B7E974 File Offset: 0x00B7CB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapBackgroundActor treasureMapBackgroundActor = (TreasureMapBackgroundActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, treasureMapBackgroundActor.m_luaExportHelper.m_spineGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D08 RID: 138504 RVA: 0x00B7E9CC File Offset: 0x00B7CBCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			TreasureMapBackgroundActor treasureMapBackgroundActor = (TreasureMapBackgroundActor)LuaObject.checkSelf(l);
			UISpineGraphic spineGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out spineGraphic);
			treasureMapBackgroundActor.m_luaExportHelper.m_spineGraphic = spineGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D09 RID: 138505 RVA: 0x00B7EA28 File Offset: 0x00B7CC28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TreasureMapBackgroundActor");
		if (Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.Create);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.Destroy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.OnSound);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.OnCameraEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.OnScreenEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.OnGeneral);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache5);
		string name = "m_spineGraphic";
		if (Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.get_m_spineGraphic);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.set_m_spineGraphic);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TreasureMapBackgroundActor.<>f__mg$cache8, typeof(TreasureMapBackgroundActor));
	}

	// Token: 0x04017B6A RID: 97130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017B6B RID: 97131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017B6C RID: 97132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017B6D RID: 97133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017B6E RID: 97134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017B6F RID: 97135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017B70 RID: 97136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017B71 RID: 97137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017B72 RID: 97138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
