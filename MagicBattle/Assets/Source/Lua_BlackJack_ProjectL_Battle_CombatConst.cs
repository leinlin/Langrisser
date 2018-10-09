using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011A7 RID: 4519
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_CombatConst : LuaObject
{
	// Token: 0x060175D2 RID: 95698 RVA: 0x0065C19C File Offset: 0x0065A39C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CombatConst o = new CombatConst();
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

	// Token: 0x060175D3 RID: 95699 RVA: 0x0065C1E4 File Offset: 0x0065A3E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TickRate(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 30);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175D4 RID: 95700 RVA: 0x0065C228 File Offset: 0x0065A428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TickTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, CombatConst.TickTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175D5 RID: 95701 RVA: 0x0065C274 File Offset: 0x0065A474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CameraAngle(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 30);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175D6 RID: 95702 RVA: 0x0065C2B8 File Offset: 0x0065A4B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CameraAngleSin(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.5f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175D7 RID: 95703 RVA: 0x0065C300 File Offset: 0x0065A500
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CameraAngleCos(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.866f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175D8 RID: 95704 RVA: 0x0065C348 File Offset: 0x0065A548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatToWorldXScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.02f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175D9 RID: 95705 RVA: 0x0065C390 File Offset: 0x0065A590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatToWorldYScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.01f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175DA RID: 95706 RVA: 0x0065C3D8 File Offset: 0x0065A5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatToWorldZScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.01732f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175DB RID: 95707 RVA: 0x0065C420 File Offset: 0x0065A620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatToWorldXOblique(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -0.005f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175DC RID: 95708 RVA: 0x0065C468 File Offset: 0x0065A668
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CombatToWorldZOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.005f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175DD RID: 95709 RVA: 0x0065C4B0 File Offset: 0x0065A6B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroInitY(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -20);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175DE RID: 95710 RVA: 0x0065C4F4 File Offset: 0x0065A6F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroSoldierColumnSpace(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 60);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175DF RID: 95711 RVA: 0x0065C538 File Offset: 0x0065A738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierColumnSpace(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 50);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175E0 RID: 95712 RVA: 0x0065C57C File Offset: 0x0065A77C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierRowSpace(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 40);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175E1 RID: 95713 RVA: 0x0065C5C0 File Offset: 0x0065A7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnterMoveDistance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175E2 RID: 95714 RVA: 0x0065C608 File Offset: 0x0065A808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnterMoveTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 250);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175E3 RID: 95715 RVA: 0x0065C650 File Offset: 0x0065A850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChargeReturnDistance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 300);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175E4 RID: 95716 RVA: 0x0065C698 File Offset: 0x0065A898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HitMaxDistance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 100);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175E5 RID: 95717 RVA: 0x0065C6DC File Offset: 0x0065A8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillFadeZOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 25);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175E6 RID: 95718 RVA: 0x0065C720 File Offset: 0x0065A920
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FlyObjectDownStraightZ(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 80);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175E7 RID: 95719 RVA: 0x0065C764 File Offset: 0x0065A964
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FlyObjectUpStraightZ(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 150);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175E8 RID: 95720 RVA: 0x0065C7AC File Offset: 0x0065A9AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillFxTag(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175E9 RID: 95721 RVA: 0x0065C7F0 File Offset: 0x0065A9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BuffFxTag(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175EA RID: 95722 RVA: 0x0065C834 File Offset: 0x0065AA34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SkillFxTagMask(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175EB RID: 95723 RVA: 0x0065C878 File Offset: 0x0065AA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BuffFxTagMask(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060175EC RID: 95724 RVA: 0x0065C8BC File Offset: 0x0065AABC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.CombatConst");
		string name = "TickRate";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_TickRate);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache0, null, false);
		string name2 = "TickTime";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_TickTime);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache1, null, false);
		string name3 = "CameraAngle";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_CameraAngle);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache2, null, false);
		string name4 = "CameraAngleSin";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_CameraAngleSin);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache3, null, false);
		string name5 = "CameraAngleCos";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_CameraAngleCos);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache4, null, false);
		string name6 = "CombatToWorldXScale";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_CombatToWorldXScale);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache5, null, false);
		string name7 = "CombatToWorldYScale";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_CombatToWorldYScale);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache6, null, false);
		string name8 = "CombatToWorldZScale";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_CombatToWorldZScale);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache7, null, false);
		string name9 = "CombatToWorldXOblique";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_CombatToWorldXOblique);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache8, null, false);
		string name10 = "CombatToWorldZOffset";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_CombatToWorldZOffset);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache9, null, false);
		string name11 = "HeroInitY";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_HeroInitY);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheA, null, false);
		string name12 = "HeroSoldierColumnSpace";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_HeroSoldierColumnSpace);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheB, null, false);
		string name13 = "SoldierColumnSpace";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_SoldierColumnSpace);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheC, null, false);
		string name14 = "SoldierRowSpace";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_SoldierRowSpace);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheD, null, false);
		string name15 = "EnterMoveDistance";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_EnterMoveDistance);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheE, null, false);
		string name16 = "EnterMoveTime";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_EnterMoveTime);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cacheF, null, false);
		string name17 = "ChargeReturnDistance";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_ChargeReturnDistance);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache10, null, false);
		string name18 = "HitMaxDistance";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_HitMaxDistance);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache11, null, false);
		string name19 = "SkillFadeZOffset";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_SkillFadeZOffset);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache12, null, false);
		string name20 = "FlyObjectDownStraightZ";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_FlyObjectDownStraightZ);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache13, null, false);
		string name21 = "FlyObjectUpStraightZ";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_FlyObjectUpStraightZ);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache14, null, false);
		string name22 = "SkillFxTag";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_SkillFxTag);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache15, null, false);
		string name23 = "BuffFxTag";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_BuffFxTag);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache16, null, false);
		string name24 = "SkillFxTagMask";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_SkillFxTagMask);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache17, null, false);
		string name25 = "BuffFxTagMask";
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.get_BuffFxTagMask);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache18, null, false);
		if (Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_CombatConst.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_CombatConst.<>f__mg$cache19, typeof(CombatConst));
	}

	// Token: 0x0400DC66 RID: 56422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DC67 RID: 56423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DC68 RID: 56424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DC69 RID: 56425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DC6A RID: 56426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DC6B RID: 56427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DC6C RID: 56428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DC6D RID: 56429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DC6E RID: 56430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DC6F RID: 56431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DC70 RID: 56432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DC71 RID: 56433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DC72 RID: 56434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DC73 RID: 56435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DC74 RID: 56436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DC75 RID: 56437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DC76 RID: 56438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400DC77 RID: 56439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400DC78 RID: 56440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400DC79 RID: 56441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400DC7A RID: 56442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400DC7B RID: 56443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400DC7C RID: 56444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400DC7D RID: 56445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400DC7E RID: 56446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400DC7F RID: 56447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
