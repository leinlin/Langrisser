using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011D2 RID: 4562
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleRoomPlayer : LuaObject
{
	// Token: 0x06017AB2 RID: 96946 RVA: 0x00680A64 File Offset: 0x0067EC64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer o = new BattleRoomPlayer();
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

	// Token: 0x06017AB3 RID: 96947 RVA: 0x00680AAC File Offset: 0x0067ECAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindBattleHero(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			BattleHero o = battleRoomPlayer.FindBattleHero(heroId);
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

	// Token: 0x06017AB4 RID: 96948 RVA: 0x00680B10 File Offset: 0x0067ED10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleRoomPlayerToPbBattleRoomPlayer_s(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer player;
			LuaObject.checkType<BattleRoomPlayer>(l, 1, out player);
			ProBattleRoomPlayer o = BattleRoomPlayer.BattleRoomPlayerToPbBattleRoomPlayer(player);
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

	// Token: 0x06017AB5 RID: 96949 RVA: 0x00680B64 File Offset: 0x0067ED64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PbBattleRoomPlayerToBattleRoomPlayer_s(IntPtr l)
	{
		int result;
		try
		{
			ProBattleRoomPlayer pbPlayer;
			LuaObject.checkType<ProBattleRoomPlayer>(l, 1, out pbPlayer);
			BattleRoomPlayer o = BattleRoomPlayer.PbBattleRoomPlayerToBattleRoomPlayer(pbPlayer);
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

	// Token: 0x06017AB6 RID: 96950 RVA: 0x00680BB8 File Offset: 0x0067EDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Heroes(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomPlayer.Heroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AB7 RID: 96951 RVA: 0x00680C0C File Offset: 0x0067EE0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Heroes(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			List<BattleHero> heroes;
			LuaObject.checkType<List<BattleHero>>(l, 2, out heroes);
			battleRoomPlayer.Heroes = heroes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AB8 RID: 96952 RVA: 0x00680C64 File Offset: 0x0067EE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Techs(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomPlayer.Techs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AB9 RID: 96953 RVA: 0x00680CB8 File Offset: 0x0067EEB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Techs(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out techs);
			battleRoomPlayer.Techs = techs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ABA RID: 96954 RVA: 0x00680D10 File Offset: 0x0067EF10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomPlayer.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ABB RID: 96955 RVA: 0x00680D64 File Offset: 0x0067EF64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			battleRoomPlayer.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ABC RID: 96956 RVA: 0x00680DBC File Offset: 0x0067EFBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SessionId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomPlayer.SessionId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ABD RID: 96957 RVA: 0x00680E10 File Offset: 0x0067F010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SessionId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			battleRoomPlayer.SessionId = sessionId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ABE RID: 96958 RVA: 0x00680E68 File Offset: 0x0067F068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChannelId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomPlayer.ChannelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ABF RID: 96959 RVA: 0x00680EBC File Offset: 0x0067F0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChannelId(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			int channelId;
			LuaObject.checkType(l, 2, out channelId);
			battleRoomPlayer.ChannelId = channelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AC0 RID: 96960 RVA: 0x00680F14 File Offset: 0x0067F114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomPlayer.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AC1 RID: 96961 RVA: 0x00680F68 File Offset: 0x0067F168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			battleRoomPlayer.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AC2 RID: 96962 RVA: 0x00680FC0 File Offset: 0x0067F1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomPlayer.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AC3 RID: 96963 RVA: 0x00681014 File Offset: 0x0067F214
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			battleRoomPlayer.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AC4 RID: 96964 RVA: 0x0068106C File Offset: 0x0067F26C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomPlayer.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AC5 RID: 96965 RVA: 0x006810C0 File Offset: 0x0067F2C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			battleRoomPlayer.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AC6 RID: 96966 RVA: 0x00681118 File Offset: 0x0067F318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RTPVPInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomPlayer.RTPVPInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AC7 RID: 96967 RVA: 0x0068116C File Offset: 0x0067F36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RTPVPInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			RealTimePVPInfo rtpvpinfo;
			LuaObject.checkType<RealTimePVPInfo>(l, 2, out rtpvpinfo);
			battleRoomPlayer.RTPVPInfo = rtpvpinfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AC8 RID: 96968 RVA: 0x006811C4 File Offset: 0x0067F3C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsOffline(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleRoomPlayer.IsOffline);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AC9 RID: 96969 RVA: 0x00681218 File Offset: 0x0067F418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsOffline(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			bool isOffline;
			LuaObject.checkType(l, 2, out isOffline);
			battleRoomPlayer.IsOffline = isOffline;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ACA RID: 96970 RVA: 0x00681270 File Offset: 0x0067F470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerBattleStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleRoomPlayer.PlayerBattleStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ACB RID: 96971 RVA: 0x006812C4 File Offset: 0x0067F4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerBattleStatus(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayer battleRoomPlayer = (BattleRoomPlayer)LuaObject.checkSelf(l);
			PlayerBattleStatus playerBattleStatus;
			LuaObject.checkEnum<PlayerBattleStatus>(l, 2, out playerBattleStatus);
			battleRoomPlayer.PlayerBattleStatus = playerBattleStatus;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ACC RID: 96972 RVA: 0x0068131C File Offset: 0x0067F51C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleRoomPlayer");
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.FindBattleHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.BattleRoomPlayerToPbBattleRoomPlayer_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.PbBattleRoomPlayerToBattleRoomPlayer_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache2);
		string name = "Heroes";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.get_Heroes);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.set_Heroes);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache4, true);
		string name2 = "Techs";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.get_Techs);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.set_Techs);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache6, true);
		string name3 = "UserId";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.get_UserId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.set_UserId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache8, true);
		string name4 = "SessionId";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.get_SessionId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.set_SessionId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheA, true);
		string name5 = "ChannelId";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.get_ChannelId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.set_ChannelId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheC, true);
		string name6 = "Name";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheE, true);
		string name7 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.get_HeadIcon);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.set_HeadIcon);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache10, true);
		string name8 = "Level";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.get_Level);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.set_Level);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache12, true);
		string name9 = "RTPVPInfo";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.get_RTPVPInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.set_RTPVPInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache14, true);
		string name10 = "IsOffline";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.get_IsOffline);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.set_IsOffline);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache16, true);
		string name11 = "PlayerBattleStatus";
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.get_PlayerBattleStatus);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.set_PlayerBattleStatus);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache18, true);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayer.<>f__mg$cache19, typeof(BattleRoomPlayer));
	}

	// Token: 0x0400E0F0 RID: 57584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E0F1 RID: 57585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E0F2 RID: 57586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E0F3 RID: 57587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E0F4 RID: 57588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E0F5 RID: 57589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E0F6 RID: 57590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E0F7 RID: 57591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E0F8 RID: 57592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E0F9 RID: 57593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E0FA RID: 57594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E0FB RID: 57595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E0FC RID: 57596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E0FD RID: 57597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E0FE RID: 57598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E0FF RID: 57599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E100 RID: 57600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E101 RID: 57601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E102 RID: 57602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E103 RID: 57603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E104 RID: 57604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E105 RID: 57605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E106 RID: 57606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E107 RID: 57607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E108 RID: 57608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E109 RID: 57609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
