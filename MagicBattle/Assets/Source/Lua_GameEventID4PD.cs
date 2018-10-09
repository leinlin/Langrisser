using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015FE RID: 5630
[Preserve]
public class Lua_GameEventID4PD : LuaObject
{
	// Token: 0x0602281E RID: 141342 RVA: 0x00BD5858 File Offset: 0x00BD3A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GameEventID4PD o = new GameEventID4PD();
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

	// Token: 0x0602281F RID: 141343 RVA: 0x00BD58A0 File Offset: 0x00BD3AA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_launchGame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "1");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022820 RID: 141344 RVA: 0x00BD58E8 File Offset: 0x00BD3AE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_showLoginUI(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "3");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022821 RID: 141345 RVA: 0x00BD5930 File Offset: 0x00BD3B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_loginPDSucceed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "20");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022822 RID: 141346 RVA: 0x00BD5978 File Offset: 0x00BD3B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateClientBegin(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "15");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022823 RID: 141347 RVA: 0x00BD59C0 File Offset: 0x00BD3BC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_updateClientFromServer1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "16");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022824 RID: 141348 RVA: 0x00BD5A08 File Offset: 0x00BD3C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateClientFromServer2(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "17");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022825 RID: 141349 RVA: 0x00BD5A50 File Offset: 0x00BD3C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateClientAllFailed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "18");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022826 RID: 141350 RVA: 0x00BD5A98 File Offset: 0x00BD3C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateAudioFilesFailed(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "18.1");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022827 RID: 141351 RVA: 0x00BD5AE0 File Offset: 0x00BD3CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateClientFinished(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "19");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022828 RID: 141352 RVA: 0x00BD5B28 File Offset: 0x00BD3D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_confirmGameMessageBoard(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "21");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022829 RID: 141353 RVA: 0x00BD5B70 File Offset: 0x00BD3D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clickOpenAnnounceButton(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "22");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602282A RID: 141354 RVA: 0x00BD5BB8 File Offset: 0x00BD3DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_showServerList(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "23");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602282B RID: 141355 RVA: 0x00BD5C00 File Offset: 0x00BD3E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_selectServer(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "24");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602282C RID: 141356 RVA: 0x00BD5C48 File Offset: 0x00BD3E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clickStartGameButton(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "25");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602282D RID: 141357 RVA: 0x00BD5C90 File Offset: 0x00BD3E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_showSelectCharactorUI(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "25.5");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602282E RID: 141358 RVA: 0x00BD5CD8 File Offset: 0x00BD3ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clickRandomCharName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "26");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602282F RID: 141359 RVA: 0x00BD5D20 File Offset: 0x00BD3F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clickCreateCharactorButton(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "27");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022830 RID: 141360 RVA: 0x00BD5D68 File Offset: 0x00BD3F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_showGoddessDialogUI(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "28");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022831 RID: 141361 RVA: 0x00BD5DB0 File Offset: 0x00BD3FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_showGoddessGivingJobUI(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "29");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022832 RID: 141362 RVA: 0x00BD5DF8 File Offset: 0x00BD3FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clickAcceptJobButton(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "30");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022833 RID: 141363 RVA: 0x00BD5E40 File Offset: 0x00BD4040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clickReselectJobButton(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "31");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022834 RID: 141364 RVA: 0x00BD5E88 File Offset: 0x00BD4088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_showWorldScene(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "34");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022835 RID: 141365 RVA: 0x00BD5ED0 File Offset: 0x00BD40D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_battle_start(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "40");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022836 RID: 141366 RVA: 0x00BD5F18 File Offset: 0x00BD4118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_battle_arena_start(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "41");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022837 RID: 141367 RVA: 0x00BD5F60 File Offset: 0x00BD4160
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_battle_team(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "42");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022838 RID: 141368 RVA: 0x00BD5FA8 File Offset: 0x00BD41A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_battle_move(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "43");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022839 RID: 141369 RVA: 0x00BD5FF0 File Offset: 0x00BD41F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_battle_attack(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "44");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602283A RID: 141370 RVA: 0x00BD6038 File Offset: 0x00BD4238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_battle_skill(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "45");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602283B RID: 141371 RVA: 0x00BD6080 File Offset: 0x00BD4280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_battle_standby(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "46");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602283C RID: 141372 RVA: 0x00BD60C8 File Offset: 0x00BD42C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_battle_die(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "47");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602283D RID: 141373 RVA: 0x00BD6110 File Offset: 0x00BD4310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_battle_stop(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "48");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602283E RID: 141374 RVA: 0x00BD6158 File Offset: 0x00BD4358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_startPreload(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "50");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602283F RID: 141375 RVA: 0x00BD61A0 File Offset: 0x00BD43A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_endPreload(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "51");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022840 RID: 141376 RVA: 0x00BD61E8 File Offset: 0x00BD43E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_completeUserGuideBaseNum(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022841 RID: 141377 RVA: 0x00BD6230 File Offset: 0x00BD4430
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "GameEventID4PD");
		string name = "launchGame";
		if (Lua_GameEventID4PD.<>f__mg$cache0 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache0 = new LuaCSFunction(Lua_GameEventID4PD.get_launchGame);
		}
		LuaObject.addMember(l, name, Lua_GameEventID4PD.<>f__mg$cache0, null, false);
		string name2 = "showLoginUI";
		if (Lua_GameEventID4PD.<>f__mg$cache1 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache1 = new LuaCSFunction(Lua_GameEventID4PD.get_showLoginUI);
		}
		LuaObject.addMember(l, name2, Lua_GameEventID4PD.<>f__mg$cache1, null, false);
		string name3 = "loginPDSucceed";
		if (Lua_GameEventID4PD.<>f__mg$cache2 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache2 = new LuaCSFunction(Lua_GameEventID4PD.get_loginPDSucceed);
		}
		LuaObject.addMember(l, name3, Lua_GameEventID4PD.<>f__mg$cache2, null, false);
		string name4 = "updateClientBegin";
		if (Lua_GameEventID4PD.<>f__mg$cache3 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache3 = new LuaCSFunction(Lua_GameEventID4PD.get_updateClientBegin);
		}
		LuaObject.addMember(l, name4, Lua_GameEventID4PD.<>f__mg$cache3, null, false);
		string name5 = "updateClientFromServer1";
		if (Lua_GameEventID4PD.<>f__mg$cache4 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache4 = new LuaCSFunction(Lua_GameEventID4PD.get_updateClientFromServer1);
		}
		LuaObject.addMember(l, name5, Lua_GameEventID4PD.<>f__mg$cache4, null, false);
		string name6 = "updateClientFromServer2";
		if (Lua_GameEventID4PD.<>f__mg$cache5 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache5 = new LuaCSFunction(Lua_GameEventID4PD.get_updateClientFromServer2);
		}
		LuaObject.addMember(l, name6, Lua_GameEventID4PD.<>f__mg$cache5, null, false);
		string name7 = "updateClientAllFailed";
		if (Lua_GameEventID4PD.<>f__mg$cache6 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache6 = new LuaCSFunction(Lua_GameEventID4PD.get_updateClientAllFailed);
		}
		LuaObject.addMember(l, name7, Lua_GameEventID4PD.<>f__mg$cache6, null, false);
		string name8 = "updateAudioFilesFailed";
		if (Lua_GameEventID4PD.<>f__mg$cache7 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache7 = new LuaCSFunction(Lua_GameEventID4PD.get_updateAudioFilesFailed);
		}
		LuaObject.addMember(l, name8, Lua_GameEventID4PD.<>f__mg$cache7, null, false);
		string name9 = "updateClientFinished";
		if (Lua_GameEventID4PD.<>f__mg$cache8 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache8 = new LuaCSFunction(Lua_GameEventID4PD.get_updateClientFinished);
		}
		LuaObject.addMember(l, name9, Lua_GameEventID4PD.<>f__mg$cache8, null, false);
		string name10 = "confirmGameMessageBoard";
		if (Lua_GameEventID4PD.<>f__mg$cache9 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache9 = new LuaCSFunction(Lua_GameEventID4PD.get_confirmGameMessageBoard);
		}
		LuaObject.addMember(l, name10, Lua_GameEventID4PD.<>f__mg$cache9, null, false);
		string name11 = "clickOpenAnnounceButton";
		if (Lua_GameEventID4PD.<>f__mg$cacheA == null)
		{
			Lua_GameEventID4PD.<>f__mg$cacheA = new LuaCSFunction(Lua_GameEventID4PD.get_clickOpenAnnounceButton);
		}
		LuaObject.addMember(l, name11, Lua_GameEventID4PD.<>f__mg$cacheA, null, false);
		string name12 = "showServerList";
		if (Lua_GameEventID4PD.<>f__mg$cacheB == null)
		{
			Lua_GameEventID4PD.<>f__mg$cacheB = new LuaCSFunction(Lua_GameEventID4PD.get_showServerList);
		}
		LuaObject.addMember(l, name12, Lua_GameEventID4PD.<>f__mg$cacheB, null, false);
		string name13 = "selectServer";
		if (Lua_GameEventID4PD.<>f__mg$cacheC == null)
		{
			Lua_GameEventID4PD.<>f__mg$cacheC = new LuaCSFunction(Lua_GameEventID4PD.get_selectServer);
		}
		LuaObject.addMember(l, name13, Lua_GameEventID4PD.<>f__mg$cacheC, null, false);
		string name14 = "clickStartGameButton";
		if (Lua_GameEventID4PD.<>f__mg$cacheD == null)
		{
			Lua_GameEventID4PD.<>f__mg$cacheD = new LuaCSFunction(Lua_GameEventID4PD.get_clickStartGameButton);
		}
		LuaObject.addMember(l, name14, Lua_GameEventID4PD.<>f__mg$cacheD, null, false);
		string name15 = "showSelectCharactorUI";
		if (Lua_GameEventID4PD.<>f__mg$cacheE == null)
		{
			Lua_GameEventID4PD.<>f__mg$cacheE = new LuaCSFunction(Lua_GameEventID4PD.get_showSelectCharactorUI);
		}
		LuaObject.addMember(l, name15, Lua_GameEventID4PD.<>f__mg$cacheE, null, false);
		string name16 = "clickRandomCharName";
		if (Lua_GameEventID4PD.<>f__mg$cacheF == null)
		{
			Lua_GameEventID4PD.<>f__mg$cacheF = new LuaCSFunction(Lua_GameEventID4PD.get_clickRandomCharName);
		}
		LuaObject.addMember(l, name16, Lua_GameEventID4PD.<>f__mg$cacheF, null, false);
		string name17 = "clickCreateCharactorButton";
		if (Lua_GameEventID4PD.<>f__mg$cache10 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache10 = new LuaCSFunction(Lua_GameEventID4PD.get_clickCreateCharactorButton);
		}
		LuaObject.addMember(l, name17, Lua_GameEventID4PD.<>f__mg$cache10, null, false);
		string name18 = "showGoddessDialogUI";
		if (Lua_GameEventID4PD.<>f__mg$cache11 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache11 = new LuaCSFunction(Lua_GameEventID4PD.get_showGoddessDialogUI);
		}
		LuaObject.addMember(l, name18, Lua_GameEventID4PD.<>f__mg$cache11, null, false);
		string name19 = "showGoddessGivingJobUI";
		if (Lua_GameEventID4PD.<>f__mg$cache12 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache12 = new LuaCSFunction(Lua_GameEventID4PD.get_showGoddessGivingJobUI);
		}
		LuaObject.addMember(l, name19, Lua_GameEventID4PD.<>f__mg$cache12, null, false);
		string name20 = "clickAcceptJobButton";
		if (Lua_GameEventID4PD.<>f__mg$cache13 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache13 = new LuaCSFunction(Lua_GameEventID4PD.get_clickAcceptJobButton);
		}
		LuaObject.addMember(l, name20, Lua_GameEventID4PD.<>f__mg$cache13, null, false);
		string name21 = "clickReselectJobButton";
		if (Lua_GameEventID4PD.<>f__mg$cache14 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache14 = new LuaCSFunction(Lua_GameEventID4PD.get_clickReselectJobButton);
		}
		LuaObject.addMember(l, name21, Lua_GameEventID4PD.<>f__mg$cache14, null, false);
		string name22 = "showWorldScene";
		if (Lua_GameEventID4PD.<>f__mg$cache15 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache15 = new LuaCSFunction(Lua_GameEventID4PD.get_showWorldScene);
		}
		LuaObject.addMember(l, name22, Lua_GameEventID4PD.<>f__mg$cache15, null, false);
		string name23 = "battle_start";
		if (Lua_GameEventID4PD.<>f__mg$cache16 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache16 = new LuaCSFunction(Lua_GameEventID4PD.get_battle_start);
		}
		LuaObject.addMember(l, name23, Lua_GameEventID4PD.<>f__mg$cache16, null, false);
		string name24 = "battle_arena_start";
		if (Lua_GameEventID4PD.<>f__mg$cache17 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache17 = new LuaCSFunction(Lua_GameEventID4PD.get_battle_arena_start);
		}
		LuaObject.addMember(l, name24, Lua_GameEventID4PD.<>f__mg$cache17, null, false);
		string name25 = "battle_team";
		if (Lua_GameEventID4PD.<>f__mg$cache18 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache18 = new LuaCSFunction(Lua_GameEventID4PD.get_battle_team);
		}
		LuaObject.addMember(l, name25, Lua_GameEventID4PD.<>f__mg$cache18, null, false);
		string name26 = "battle_move";
		if (Lua_GameEventID4PD.<>f__mg$cache19 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache19 = new LuaCSFunction(Lua_GameEventID4PD.get_battle_move);
		}
		LuaObject.addMember(l, name26, Lua_GameEventID4PD.<>f__mg$cache19, null, false);
		string name27 = "battle_attack";
		if (Lua_GameEventID4PD.<>f__mg$cache1A == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache1A = new LuaCSFunction(Lua_GameEventID4PD.get_battle_attack);
		}
		LuaObject.addMember(l, name27, Lua_GameEventID4PD.<>f__mg$cache1A, null, false);
		string name28 = "battle_skill";
		if (Lua_GameEventID4PD.<>f__mg$cache1B == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache1B = new LuaCSFunction(Lua_GameEventID4PD.get_battle_skill);
		}
		LuaObject.addMember(l, name28, Lua_GameEventID4PD.<>f__mg$cache1B, null, false);
		string name29 = "battle_standby";
		if (Lua_GameEventID4PD.<>f__mg$cache1C == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache1C = new LuaCSFunction(Lua_GameEventID4PD.get_battle_standby);
		}
		LuaObject.addMember(l, name29, Lua_GameEventID4PD.<>f__mg$cache1C, null, false);
		string name30 = "battle_die";
		if (Lua_GameEventID4PD.<>f__mg$cache1D == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache1D = new LuaCSFunction(Lua_GameEventID4PD.get_battle_die);
		}
		LuaObject.addMember(l, name30, Lua_GameEventID4PD.<>f__mg$cache1D, null, false);
		string name31 = "battle_stop";
		if (Lua_GameEventID4PD.<>f__mg$cache1E == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache1E = new LuaCSFunction(Lua_GameEventID4PD.get_battle_stop);
		}
		LuaObject.addMember(l, name31, Lua_GameEventID4PD.<>f__mg$cache1E, null, false);
		string name32 = "startPreload";
		if (Lua_GameEventID4PD.<>f__mg$cache1F == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache1F = new LuaCSFunction(Lua_GameEventID4PD.get_startPreload);
		}
		LuaObject.addMember(l, name32, Lua_GameEventID4PD.<>f__mg$cache1F, null, false);
		string name33 = "endPreload";
		if (Lua_GameEventID4PD.<>f__mg$cache20 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache20 = new LuaCSFunction(Lua_GameEventID4PD.get_endPreload);
		}
		LuaObject.addMember(l, name33, Lua_GameEventID4PD.<>f__mg$cache20, null, false);
		string name34 = "completeUserGuideBaseNum";
		if (Lua_GameEventID4PD.<>f__mg$cache21 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache21 = new LuaCSFunction(Lua_GameEventID4PD.get_completeUserGuideBaseNum);
		}
		LuaObject.addMember(l, name34, Lua_GameEventID4PD.<>f__mg$cache21, null, false);
		if (Lua_GameEventID4PD.<>f__mg$cache22 == null)
		{
			Lua_GameEventID4PD.<>f__mg$cache22 = new LuaCSFunction(Lua_GameEventID4PD.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_GameEventID4PD.<>f__mg$cache22, typeof(GameEventID4PD));
	}

	// Token: 0x04018604 RID: 99844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018605 RID: 99845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018606 RID: 99846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018607 RID: 99847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018608 RID: 99848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018609 RID: 99849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401860A RID: 99850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401860B RID: 99851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401860C RID: 99852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401860D RID: 99853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401860E RID: 99854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401860F RID: 99855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018610 RID: 99856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018611 RID: 99857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018612 RID: 99858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018613 RID: 99859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018614 RID: 99860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018615 RID: 99861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018616 RID: 99862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018617 RID: 99863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018618 RID: 99864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018619 RID: 99865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401861A RID: 99866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401861B RID: 99867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401861C RID: 99868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401861D RID: 99869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401861E RID: 99870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401861F RID: 99871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018620 RID: 99872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018621 RID: 99873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018622 RID: 99874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018623 RID: 99875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018624 RID: 99876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018625 RID: 99877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018626 RID: 99878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;
}
