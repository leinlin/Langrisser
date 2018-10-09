using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200125C RID: 4700
[Preserve]
public class Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity : LuaObject
{
	// Token: 0x06018848 RID: 100424 RVA: 0x006E560C File Offset: 0x006E380C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				PlayerLevelUpOperationalActivity o = new PlayerLevelUpOperationalActivity();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				ulong instanceId;
				LuaObject.checkType(l, 2, out instanceId);
				int operationalActivityId;
				LuaObject.checkType(l, 3, out operationalActivityId);
				OperationalActivityType operationalActivityType;
				LuaObject.checkEnum<OperationalActivityType>(l, 4, out operationalActivityType);
				PlayerLevelUpOperationalActivity o = new PlayerLevelUpOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018849 RID: 100425 RVA: 0x006E56BC File Offset: 0x006E38BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeserializeFromPB(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity = (PlayerLevelUpOperationalActivity)LuaObject.checkSelf(l);
			ProPlayerLevelUpOperationalActivity pbOperationalActivity;
			LuaObject.checkType<ProPlayerLevelUpOperationalActivity>(l, 2, out pbOperationalActivity);
			ConfigDataOperationalActivityInfo config;
			LuaObject.checkType<ConfigDataOperationalActivityInfo>(l, 3, out config);
			playerLevelUpOperationalActivity.DeserializeFromPB(pbOperationalActivity, config);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601884A RID: 100426 RVA: 0x006E5720 File Offset: 0x006E3920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPBNtf(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity = (PlayerLevelUpOperationalActivity)LuaObject.checkSelf(l);
			DSOperationalActivityNtf ntf;
			LuaObject.checkType<DSOperationalActivityNtf>(l, 2, out ntf);
			playerLevelUpOperationalActivity.ToPBNtf(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601884B RID: 100427 RVA: 0x006E5778 File Offset: 0x006E3978
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToPB(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity = (PlayerLevelUpOperationalActivity)LuaObject.checkSelf(l);
			ProPlayerLevelUpOperationalActivity o = playerLevelUpOperationalActivity.SerializeToPB();
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

	// Token: 0x0601884C RID: 100428 RVA: 0x006E57CC File Offset: 0x006E39CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGainRewardByIndex(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity = (PlayerLevelUpOperationalActivity)LuaObject.checkSelf(l);
			int rewardIndex;
			LuaObject.checkType(l, 2, out rewardIndex);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currentTime);
			int i = playerLevelUpOperationalActivity.CanGainRewardByIndex(rewardIndex, currentTime);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601884D RID: 100429 RVA: 0x006E583C File Offset: 0x006E3A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity = (PlayerLevelUpOperationalActivity)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			playerLevelUpOperationalActivity.SetPlayerLevel(playerLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601884E RID: 100430 RVA: 0x006E5894 File Offset: 0x006E3A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity = (PlayerLevelUpOperationalActivity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpOperationalActivity.PlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601884F RID: 100431 RVA: 0x006E58E8 File Offset: 0x006E3AE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity = (PlayerLevelUpOperationalActivity)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			playerLevelUpOperationalActivity.PlayerLevel = playerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018850 RID: 100432 RVA: 0x006E5940 File Offset: 0x006E3B40
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.PlayerLevelUpOperationalActivity");
		if (Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.DeserializeFromPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.ToPBNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.SerializeToPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.CanGainRewardByIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.SetPlayerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache4);
		string name = "PlayerLevel";
		if (Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.get_PlayerLevel);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.set_PlayerLevel);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_PlayerLevelUpOperationalActivity.<>f__mg$cache7, typeof(PlayerLevelUpOperationalActivity), typeof(AwardOperationalActivityBase));
	}

	// Token: 0x0400ED72 RID: 60786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400ED73 RID: 60787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400ED74 RID: 60788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400ED75 RID: 60789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400ED76 RID: 60790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400ED77 RID: 60791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400ED78 RID: 60792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400ED79 RID: 60793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
