using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001359 RID: 4953
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ActorFx : LuaObject
{
	// Token: 0x0601AA86 RID: 109190 RVA: 0x007EEF28 File Offset: 0x007ED128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ActorFx o = new ActorFx();
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

	// Token: 0x0601AA87 RID: 109191 RVA: 0x007EEF70 File Offset: 0x007ED170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Death1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Spine/Effect_ABS/effect_death/EffectDeath1Prefab.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA88 RID: 109192 RVA: 0x007EEFB8 File Offset: 0x007ED1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Death2(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Spine/Effect_ABS/effect_death/EffectDeath2Prefab.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA89 RID: 109193 RVA: 0x007EF000 File Offset: 0x007ED200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Death(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/common_die.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA8A RID: 109194 RVA: 0x007EF048 File Offset: 0x007ED248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerTeleportDisappear(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/common_Teleport_2start.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA8B RID: 109195 RVA: 0x007EF090 File Offset: 0x007ED290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerTeleportAppear(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/common_Teleport_2end.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA8C RID: 109196 RVA: 0x007EF0D8 File Offset: 0x007ED2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EventAppear(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/common_Refresh.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA8D RID: 109197 RVA: 0x007EF120 File Offset: 0x007ED320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StagePosition0A(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceEmpty_G.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA8E RID: 109198 RVA: 0x007EF168 File Offset: 0x007ED368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StagePosition0B(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceInMan_G.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA8F RID: 109199 RVA: 0x007EF1B0 File Offset: 0x007ED3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StagePosition0C(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchEnd_G.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA90 RID: 109200 RVA: 0x007EF1F8 File Offset: 0x007ED3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StagePosition1A(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceEmpty_R.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA91 RID: 109201 RVA: 0x007EF240 File Offset: 0x007ED440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StagePosition1B(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceInMan_R.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA92 RID: 109202 RVA: 0x007EF288 File Offset: 0x007ED488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StagePosition1C(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchEnd_R.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA93 RID: 109203 RVA: 0x007EF2D0 File Offset: 0x007ED4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StagePosition2A(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceEmpty_B.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA94 RID: 109204 RVA: 0x007EF318 File Offset: 0x007ED518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StagePosition2B(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchMovePlaceInMan_B.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA95 RID: 109205 RVA: 0x007EF360 File Offset: 0x007ED560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StagePosition2C(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/Common_ABS/CommonFX/OnTouchMovePlaceInMan/OnTouchEnd_B.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AA96 RID: 109206 RVA: 0x007EF3A8 File Offset: 0x007ED5A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ActorFx");
		string name = "Death1";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_Death1);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache0, null, false);
		string name2 = "Death2";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_Death2);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache1, null, false);
		string name3 = "Death";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_Death);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache2, null, false);
		string name4 = "PlayerTeleportDisappear";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_PlayerTeleportDisappear);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache3, null, false);
		string name5 = "PlayerTeleportAppear";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_PlayerTeleportAppear);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache4, null, false);
		string name6 = "EventAppear";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_EventAppear);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache5, null, false);
		string name7 = "StagePosition0A";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_StagePosition0A);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache6, null, false);
		string name8 = "StagePosition0B";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_StagePosition0B);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache7, null, false);
		string name9 = "StagePosition0C";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_StagePosition0C);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache8, null, false);
		string name10 = "StagePosition1A";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_StagePosition1A);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cache9, null, false);
		string name11 = "StagePosition1B";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_StagePosition1B);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheA, null, false);
		string name12 = "StagePosition1C";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_StagePosition1C);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheB, null, false);
		string name13 = "StagePosition2A";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_StagePosition2A);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheC, null, false);
		string name14 = "StagePosition2B";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_StagePosition2B);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheD, null, false);
		string name15 = "StagePosition2C";
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.get_StagePosition2C);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheE, null, false);
		if (Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActorFx.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ActorFx.<>f__mg$cacheF, typeof(ActorFx));
	}

	// Token: 0x04010DB6 RID: 69046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010DB7 RID: 69047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010DB8 RID: 69048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010DB9 RID: 69049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010DBA RID: 69050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010DBB RID: 69051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010DBC RID: 69052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010DBD RID: 69053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010DBE RID: 69054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010DBF RID: 69055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010DC0 RID: 69056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010DC1 RID: 69057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010DC2 RID: 69058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010DC3 RID: 69059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010DC4 RID: 69060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010DC5 RID: 69061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
