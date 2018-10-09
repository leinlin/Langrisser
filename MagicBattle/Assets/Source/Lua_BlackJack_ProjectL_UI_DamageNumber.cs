using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200140F RID: 5135
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DamageNumber : LuaObject
{
	// Token: 0x0601D0A1 RID: 118945 RVA: 0x0091E278 File Offset: 0x0091C478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNumber(IntPtr l)
	{
		int result;
		try
		{
			DamageNumber damageNumber = (DamageNumber)LuaObject.checkSelf(l);
			int number;
			LuaObject.checkType(l, 2, out number);
			damageNumber.SetNumber(number);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0A2 RID: 118946 RVA: 0x0091E2D0 File Offset: 0x0091C4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			DamageNumber damageNumber = (DamageNumber)LuaObject.checkSelf(l);
			damageNumber.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0A3 RID: 118947 RVA: 0x0091E31C File Offset: 0x0091C51C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Awake(IntPtr l)
	{
		int result;
		try
		{
			DamageNumber damageNumber = (DamageNumber)LuaObject.checkSelf(l);
			damageNumber.m_luaExportHelper.Awake();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0A4 RID: 118948 RVA: 0x0091E370 File Offset: 0x0091C570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnable(IntPtr l)
	{
		int result;
		try
		{
			DamageNumber damageNumber = (DamageNumber)LuaObject.checkSelf(l);
			damageNumber.m_luaExportHelper.OnEnable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0A5 RID: 118949 RVA: 0x0091E3C4 File Offset: 0x0091C5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startTime(IntPtr l)
	{
		int result;
		try
		{
			DamageNumber damageNumber = (DamageNumber)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, damageNumber.m_luaExportHelper.m_startTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0A6 RID: 118950 RVA: 0x0091E41C File Offset: 0x0091C61C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_startTime(IntPtr l)
	{
		int result;
		try
		{
			DamageNumber damageNumber = (DamageNumber)LuaObject.checkSelf(l);
			float startTime;
			LuaObject.checkType(l, 2, out startTime);
			damageNumber.m_luaExportHelper.m_startTime = startTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0A7 RID: 118951 RVA: 0x0091E478 File Offset: 0x0091C678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_text(IntPtr l)
	{
		int result;
		try
		{
			DamageNumber damageNumber = (DamageNumber)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, damageNumber.m_luaExportHelper.m_text);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0A8 RID: 118952 RVA: 0x0091E4D0 File Offset: 0x0091C6D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_text(IntPtr l)
	{
		int result;
		try
		{
			DamageNumber damageNumber = (DamageNumber)LuaObject.checkSelf(l);
			Text text;
			LuaObject.checkType<Text>(l, 2, out text);
			damageNumber.m_luaExportHelper.m_text = text;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D0A9 RID: 118953 RVA: 0x0091E52C File Offset: 0x0091C72C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DamageNumber");
		if (Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DamageNumber.SetNumber);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DamageNumber.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DamageNumber.Awake);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DamageNumber.OnEnable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache3);
		string name = "m_startTime";
		if (Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DamageNumber.get_m_startTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DamageNumber.set_m_startTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache5, true);
		string name2 = "m_text";
		if (Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DamageNumber.get_m_text);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DamageNumber.set_m_text);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_DamageNumber.<>f__mg$cache7, true);
		LuaObject.createTypeMetatable(l, null, typeof(DamageNumber), typeof(MonoBehaviour));
	}

	// Token: 0x04013265 RID: 78437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013266 RID: 78438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013267 RID: 78439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013268 RID: 78440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013269 RID: 78441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401326A RID: 78442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401326B RID: 78443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401326C RID: 78444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
