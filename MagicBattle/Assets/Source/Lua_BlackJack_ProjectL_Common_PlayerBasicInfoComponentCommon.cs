using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001259 RID: 4697
[Preserve]
public class Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon : LuaObject
{
	// Token: 0x06018786 RID: 100230 RVA: 0x006DF4B8 File Offset: 0x006DD6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon o = new PlayerBasicInfoComponentCommon();
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

	// Token: 0x06018787 RID: 100231 RVA: 0x006DF500 File Offset: 0x006DD700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			string name = playerBasicInfoComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018788 RID: 100232 RVA: 0x006DF554 File Offset: 0x006DD754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018789 RID: 100233 RVA: 0x006DF5A0 File Offset: 0x006DD7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601878A RID: 100234 RVA: 0x006DF5EC File Offset: 0x006DD7EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601878B RID: 100235 RVA: 0x006DF638 File Offset: 0x006DD838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			playerBasicInfoComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601878C RID: 100236 RVA: 0x006DF690 File Offset: 0x006DD890
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601878D RID: 100237 RVA: 0x006DF6DC File Offset: 0x006DD8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGameFunctionOpened(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			bool b = playerBasicInfoComponentCommon.IsGameFunctionOpened(gameFunctionType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601878E RID: 100238 RVA: 0x006DF740 File Offset: 0x006DD940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCreateTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			DateTime createTime = playerBasicInfoComponentCommon.GetCreateTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601878F RID: 100239 RVA: 0x006DF79C File Offset: 0x006DD99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCreateTimeUtc(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			DateTime createTimeUtc = playerBasicInfoComponentCommon.GetCreateTimeUtc();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, createTimeUtc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018790 RID: 100240 RVA: 0x006DF7F8 File Offset: 0x006DD9F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLastLogoutTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			DateTime lastLogoutTime = playerBasicInfoComponentCommon.GetLastLogoutTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lastLogoutTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018791 RID: 100241 RVA: 0x006DF854 File Offset: 0x006DDA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLoginTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			DateTime loginTime = playerBasicInfoComponentCommon.GetLoginTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, loginTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018792 RID: 100242 RVA: 0x006DF8B0 File Offset: 0x006DDAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayerName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			string playerName = playerBasicInfoComponentCommon.GetPlayerName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018793 RID: 100243 RVA: 0x006DF904 File Offset: 0x006DDB04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetUserId(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			string userId = playerBasicInfoComponentCommon.GetUserId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018794 RID: 100244 RVA: 0x006DF958 File Offset: 0x006DDB58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMe(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = playerBasicInfoComponentCommon.IsMe(userId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018795 RID: 100245 RVA: 0x006DF9BC File Offset: 0x006DDBBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCurrentLevelExp(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int currentLevelExp = playerBasicInfoComponentCommon.GetCurrentLevelExp();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentLevelExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018796 RID: 100246 RVA: 0x006DFA10 File Offset: 0x006DDC10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRechargedCsystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int rechargedCsystal = playerBasicInfoComponentCommon.GetRechargedCsystal();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rechargedCsystal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018797 RID: 100247 RVA: 0x006DFA64 File Offset: 0x006DDC64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRechargeRMB(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			long rechargeRMB = playerBasicInfoComponentCommon.GetRechargeRMB();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rechargeRMB);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018798 RID: 100248 RVA: 0x006DFAB8 File Offset: 0x006DDCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int headIcon = playerBasicInfoComponentCommon.GetHeadIcon();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, headIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018799 RID: 100249 RVA: 0x006DFB0C File Offset: 0x006DDD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDefaultHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int defaultHeadIcon = playerBasicInfoComponentCommon.GetDefaultHeadIcon();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, defaultHeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601879A RID: 100250 RVA: 0x006DFB60 File Offset: 0x006DDD60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeadPortrait(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int headPortrait = playerBasicInfoComponentCommon.GetHeadPortrait();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, headPortrait);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601879B RID: 100251 RVA: 0x006DFBB4 File Offset: 0x006DDDB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int headFrame = playerBasicInfoComponentCommon.GetHeadFrame();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, headFrame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601879C RID: 100252 RVA: 0x006DFC08 File Offset: 0x006DDE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPlayerLevelMax(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponentCommon.IsPlayerLevelMax();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601879D RID: 100253 RVA: 0x006DFC5C File Offset: 0x006DDE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddPlayerExp(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			int i = playerBasicInfoComponentCommon.AddPlayerExp(exp);
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

	// Token: 0x0601879E RID: 100254 RVA: 0x006DFCC0 File Offset: 0x006DDEC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddGold(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponentCommon.AddGold(nums, causeId, location);
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

	// Token: 0x0601879F RID: 100255 RVA: 0x006DFD3C File Offset: 0x006DDF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGoldEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int useGoldCount;
			LuaObject.checkType(l, 2, out useGoldCount);
			bool b = playerBasicInfoComponentCommon.IsGoldEnough(useGoldCount);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187A0 RID: 100256 RVA: 0x006DFDA0 File Offset: 0x006DDFA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsGoldOverFlow(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int addNums;
			LuaObject.checkType(l, 2, out addNums);
			bool b = playerBasicInfoComponentCommon.IsGoldOverFlow(addNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187A1 RID: 100257 RVA: 0x006DFE04 File Offset: 0x006DE004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGold(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int gold = playerBasicInfoComponentCommon.GetGold();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187A2 RID: 100258 RVA: 0x006DFE58 File Offset: 0x006DE058
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddBrillianceMithralStone(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
				int nums;
				LuaObject.checkType(l, 2, out nums);
				int i = playerBasicInfoComponentCommon.AddBrillianceMithralStone(nums);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon2 = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
				int nums2;
				LuaObject.checkType(l, 2, out nums2);
				GameFunctionType causeId;
				LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
				string location;
				LuaObject.checkType(l, 4, out location);
				int i2 = playerBasicInfoComponentCommon2.AddBrillianceMithralStone(nums2, causeId, location);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddBrillianceMithralStone to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187A3 RID: 100259 RVA: 0x006DFF3C File Offset: 0x006DE13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMithralStone(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
				int nums;
				LuaObject.checkType(l, 2, out nums);
				int i = playerBasicInfoComponentCommon.AddMithralStone(nums);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 4)
			{
				PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon2 = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
				int nums2;
				LuaObject.checkType(l, 2, out nums2);
				GameFunctionType causeId;
				LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
				string location;
				LuaObject.checkType(l, 4, out location);
				int i2 = playerBasicInfoComponentCommon2.AddMithralStone(nums2, causeId, location);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddMithralStone to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187A4 RID: 100260 RVA: 0x006E0020 File Offset: 0x006DE220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMithralStoneEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			bool b = playerBasicInfoComponentCommon.IsMithralStoneEnough(nums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187A5 RID: 100261 RVA: 0x006E0084 File Offset: 0x006DE284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBrillianceMithralStoneEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			bool b = playerBasicInfoComponentCommon.IsBrillianceMithralStoneEnough(nums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187A6 RID: 100262 RVA: 0x006E00E8 File Offset: 0x006DE2E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsCurrencyEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			GoodsType currencyType;
			LuaObject.checkEnum<GoodsType>(l, 2, out currencyType);
			int consumeNums;
			LuaObject.checkType(l, 3, out consumeNums);
			int i = playerBasicInfoComponentCommon.IsCurrencyEnough(currencyType, consumeNums);
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

	// Token: 0x060187A7 RID: 100263 RVA: 0x006E0158 File Offset: 0x006DE358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCurrency(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			GoodsType currencyType;
			LuaObject.checkEnum<GoodsType>(l, 2, out currencyType);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out causeId);
			string location;
			LuaObject.checkType(l, 5, out location);
			int i = playerBasicInfoComponentCommon.AddCurrency(currencyType, nums, causeId, location);
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

	// Token: 0x060187A8 RID: 100264 RVA: 0x006E01E0 File Offset: 0x006DE3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRechargeRMB(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			DateTime rechargeTime;
			LuaObject.checkValueType<DateTime>(l, 3, out rechargeTime);
			bool needSync2Client;
			LuaObject.checkType(l, 4, out needSync2Client);
			long i = playerBasicInfoComponentCommon.AddRechargeRMB(nums, rechargeTime, needSync2Client);
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

	// Token: 0x060187A9 RID: 100265 RVA: 0x006E025C File Offset: 0x006DE45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddCrystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponentCommon.AddCrystal(nums, causeId, location);
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

	// Token: 0x060187AA RID: 100266 RVA: 0x006E02D8 File Offset: 0x006DE4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsCrystalEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponentCommon.IsCrystalEnough(consumeNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187AB RID: 100267 RVA: 0x006E033C File Offset: 0x006DE53C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsReachEnergyMax(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			long currentEnergy;
			LuaObject.checkType(l, 2, out currentEnergy);
			bool b = playerBasicInfoComponentCommon.IsReachEnergyMax(currentEnergy);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187AC RID: 100268 RVA: 0x006E03A0 File Offset: 0x006DE5A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FlushEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.FlushEnergy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187AD RID: 100269 RVA: 0x006E03EC File Offset: 0x006DE5EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanFlushEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponentCommon.CanFlushEnergy();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187AE RID: 100270 RVA: 0x006E0440 File Offset: 0x006DE640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanFlushPlayerAction(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponentCommon.CanFlushPlayerAction();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187AF RID: 100271 RVA: 0x006E0494 File Offset: 0x006DE694
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ResetPlayerActionNextFlushTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.ResetPlayerActionNextFlushTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187B0 RID: 100272 RVA: 0x006E04E0 File Offset: 0x006DE6E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IncreamentEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			long energyAddNums;
			LuaObject.checkType(l, 2, out energyAddNums);
			bool canAboveMaxEnergy;
			LuaObject.checkType(l, 3, out canAboveMaxEnergy);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out causeId);
			string location;
			LuaObject.checkType(l, 5, out location);
			int i = playerBasicInfoComponentCommon.IncreamentEnergy(energyAddNums, canAboveMaxEnergy, causeId, location);
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

	// Token: 0x060187B1 RID: 100273 RVA: 0x006E0568 File Offset: 0x006DE768
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DecreaseEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int energyCost;
			LuaObject.checkType(l, 2, out energyCost);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponentCommon.DecreaseEnergy(energyCost, causeId, location);
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

	// Token: 0x060187B2 RID: 100274 RVA: 0x006E05E4 File Offset: 0x006DE7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEnergyEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int consumeEnergy;
			LuaObject.checkType(l, 2, out consumeEnergy);
			bool b = playerBasicInfoComponentCommon.IsEnergyEnough(consumeEnergy);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187B3 RID: 100275 RVA: 0x006E0648 File Offset: 0x006DE848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int energy = playerBasicInfoComponentCommon.GetEnergy();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, energy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187B4 RID: 100276 RVA: 0x006E069C File Offset: 0x006DE89C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCurrentTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			DateTime currentTime = playerBasicInfoComponentCommon.GetCurrentTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187B5 RID: 100277 RVA: 0x006E06F8 File Offset: 0x006DE8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSigned(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponentCommon.IsSigned();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187B6 RID: 100278 RVA: 0x006E074C File Offset: 0x006DE94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSignToday(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponentCommon.CanSignToday();
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

	// Token: 0x060187B7 RID: 100279 RVA: 0x006E07A0 File Offset: 0x006DE9A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanBuyEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponentCommon.CanBuyEnergy();
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

	// Token: 0x060187B8 RID: 100280 RVA: 0x006E07F4 File Offset: 0x006DE9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponentCommon.BuyEnergy();
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

	// Token: 0x060187B9 RID: 100281 RVA: 0x006E0848 File Offset: 0x006DEA48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanBuyArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponentCommon.CanBuyArenaTickets();
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

	// Token: 0x060187BA RID: 100282 RVA: 0x006E089C File Offset: 0x006DEA9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BuyArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int i = playerBasicInfoComponentCommon.BuyArenaTickets();
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

	// Token: 0x060187BB RID: 100283 RVA: 0x006E08F0 File Offset: 0x006DEAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNextFlushPlayerActionTime(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			DateTime nextFlushPlayerActionTime = playerBasicInfoComponentCommon.GetNextFlushPlayerActionTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextFlushPlayerActionTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187BC RID: 100284 RVA: 0x006E094C File Offset: 0x006DEB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushPlayerAction(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponentCommon.FlushPlayerAction();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187BD RID: 100285 RVA: 0x006E09A0 File Offset: 0x006DEBA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsArenaTicketsEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponentCommon.IsArenaTicketsEnough(consumeNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187BE RID: 100286 RVA: 0x006E0A04 File Offset: 0x006DEC04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsArenaTicketsFull(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponentCommon.IsArenaTicketsFull();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187BF RID: 100287 RVA: 0x006E0A58 File Offset: 0x006DEC58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			bool arenaGiven;
			LuaObject.checkType(l, 3, out arenaGiven);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out causeId);
			string location;
			LuaObject.checkType(l, 5, out location);
			int i = playerBasicInfoComponentCommon.AddArenaTickets(nums, arenaGiven, causeId, location);
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

	// Token: 0x060187C0 RID: 100288 RVA: 0x006E0AE0 File Offset: 0x006DECE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAreanaTicketNums(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int areanaTicketNums = playerBasicInfoComponentCommon.GetAreanaTicketNums();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, areanaTicketNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187C1 RID: 100289 RVA: 0x006E0B34 File Offset: 0x006DED34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRechargedCrystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = playerBasicInfoComponentCommon.AddRechargedCrystal(nums);
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

	// Token: 0x060187C2 RID: 100290 RVA: 0x006E0B98 File Offset: 0x006DED98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddArenaHonour(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponentCommon.AddArenaHonour(nums, causeId, location);
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

	// Token: 0x060187C3 RID: 100291 RVA: 0x006E0C14 File Offset: 0x006DEE14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetArenaHonour(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int arenaHonour = playerBasicInfoComponentCommon.GetArenaHonour();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaHonour);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187C4 RID: 100292 RVA: 0x006E0C68 File Offset: 0x006DEE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRealTimePVPHonor(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponentCommon.AddRealTimePVPHonor(nums, causeId, location);
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

	// Token: 0x060187C5 RID: 100293 RVA: 0x006E0CE4 File Offset: 0x006DEEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRealTimePVPHonor(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int realTimePVPHonor = playerBasicInfoComponentCommon.GetRealTimePVPHonor();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPHonor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187C6 RID: 100294 RVA: 0x006E0D38 File Offset: 0x006DEF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int friendshipPoints = playerBasicInfoComponentCommon.GetFriendshipPoints();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendshipPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187C7 RID: 100295 RVA: 0x006E0D8C File Offset: 0x006DEF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSkinTickets(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int skinTickets = playerBasicInfoComponentCommon.GetSkinTickets();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skinTickets);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187C8 RID: 100296 RVA: 0x006E0DE0 File Offset: 0x006DEFE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponentCommon.AddFriendshipPoints(nums, causeId, location);
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

	// Token: 0x060187C9 RID: 100297 RVA: 0x006E0E5C File Offset: 0x006DF05C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSkinTickets(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponentCommon.AddSkinTickets(nums, causeId, location);
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

	// Token: 0x060187CA RID: 100298 RVA: 0x006E0ED8 File Offset: 0x006DF0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMemoryEssence(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponentCommon.AddMemoryEssence(nums, causeId, location);
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

	// Token: 0x060187CB RID: 100299 RVA: 0x006E0F54 File Offset: 0x006DF154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddGuildMedal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = playerBasicInfoComponentCommon.AddGuildMedal(nums, causeId, location);
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

	// Token: 0x060187CC RID: 100300 RVA: 0x006E0FD0 File Offset: 0x006DF1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsGuildMedalEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponentCommon.IsGuildMedalEnough(consumeNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187CD RID: 100301 RVA: 0x006E1034 File Offset: 0x006DF234
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsFriendshipPointsEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponentCommon.IsFriendshipPointsEnough(consumeNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187CE RID: 100302 RVA: 0x006E1098 File Offset: 0x006DF298
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsArenaHonourEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponentCommon.IsArenaHonourEnough(consumeNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187CF RID: 100303 RVA: 0x006E10FC File Offset: 0x006DF2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRealTimePVPHonorEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponentCommon.IsRealTimePVPHonorEnough(consumeNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187D0 RID: 100304 RVA: 0x006E1160 File Offset: 0x006DF360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSkinTicketEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponentCommon.IsSkinTicketEnough(consumeNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187D1 RID: 100305 RVA: 0x006E11C4 File Offset: 0x006DF3C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsMemoryEssenceEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int consumeNums;
			LuaObject.checkType(l, 2, out consumeNums);
			bool b = playerBasicInfoComponentCommon.IsMemoryEssenceEnough(consumeNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187D2 RID: 100306 RVA: 0x006E1228 File Offset: 0x006DF428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSetUserGuide(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			List<int> completeStepIds;
			LuaObject.checkType<List<int>>(l, 2, out completeStepIds);
			int i = playerBasicInfoComponentCommon.CanSetUserGuide(completeStepIds);
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

	// Token: 0x060187D3 RID: 100307 RVA: 0x006E128C File Offset: 0x006DF48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUserGuide(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			List<int> userGuide;
			LuaObject.checkType<List<int>>(l, 2, out userGuide);
			int i = playerBasicInfoComponentCommon.SetUserGuide(userGuide);
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

	// Token: 0x060187D4 RID: 100308 RVA: 0x006E12F0 File Offset: 0x006DF4F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CleanUserGuide(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			List<int> completeStepIds;
			LuaObject.checkType<List<int>>(l, 2, out completeStepIds);
			playerBasicInfoComponentCommon.CleanUserGuide(completeStepIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187D5 RID: 100309 RVA: 0x006E1348 File Offset: 0x006DF548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompleteAllUserGuides(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.CompleteAllUserGuides();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187D6 RID: 100310 RVA: 0x006E1394 File Offset: 0x006DF594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUserGuideCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int stepId;
			LuaObject.checkType(l, 2, out stepId);
			bool b = playerBasicInfoComponentCommon.IsUserGuideCompleted(stepId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187D7 RID: 100311 RVA: 0x006E13F8 File Offset: 0x006DF5F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int level = playerBasicInfoComponentCommon.GetLevel();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187D8 RID: 100312 RVA: 0x006E144C File Offset: 0x006DF64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRechargedCrystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int rechargedCrystal = playerBasicInfoComponentCommon.GetRechargedCrystal();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rechargedCrystal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187D9 RID: 100313 RVA: 0x006E14A0 File Offset: 0x006DF6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCrystal(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int crystal = playerBasicInfoComponentCommon.GetCrystal();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, crystal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187DA RID: 100314 RVA: 0x006E14F4 File Offset: 0x006DF6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckRankingListAddPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponentCommon.CheckRankingListAddPlayerLevel();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187DB RID: 100315 RVA: 0x006E1548 File Offset: 0x006DF748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateRankingPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int championHeroId;
			LuaObject.checkType(l, 2, out championHeroId);
			RankingPlayerInfo o = playerBasicInfoComponentCommon.CreateRankingPlayerInfo(championHeroId);
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

	// Token: 0x060187DC RID: 100316 RVA: 0x006E15AC File Offset: 0x006DF7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRankingListPlayerInfoChange(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.OnRankingListPlayerInfoChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187DD RID: 100317 RVA: 0x006E15F8 File Offset: 0x006DF7F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OpenGameRating(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.OpenGameRating();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187DE RID: 100318 RVA: 0x006E1644 File Offset: 0x006DF844
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsOpenGameRating(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponentCommon.IsOpenGameRating();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187DF RID: 100319 RVA: 0x006E1698 File Offset: 0x006DF898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetMemoryStoreOpenStatus(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool memoryStoreOpenStatus;
			LuaObject.checkType(l, 2, out memoryStoreOpenStatus);
			playerBasicInfoComponentCommon.SetMemoryStoreOpenStatus(memoryStoreOpenStatus);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187E0 RID: 100320 RVA: 0x006E16F0 File Offset: 0x006DF8F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsMemoryStoreOpen(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponentCommon.IsMemoryStoreOpen();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187E1 RID: 100321 RVA: 0x006E1744 File Offset: 0x006DF944
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLevelUpAddEnergyFromConfig(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int levelUpAddEnergyFromConfig = playerBasicInfoComponentCommon.GetLevelUpAddEnergyFromConfig();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelUpAddEnergyFromConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187E2 RID: 100322 RVA: 0x006E1798 File Offset: 0x006DF998
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNextLevelExpFromConfig(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int nextLevelExpFromConfig = playerBasicInfoComponentCommon.GetNextLevelExpFromConfig();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextLevelExpFromConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187E3 RID: 100323 RVA: 0x006E17EC File Offset: 0x006DF9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSetHeadPortraitAndHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int headPortraitId;
			LuaObject.checkType(l, 2, out headPortraitId);
			int headFrameId;
			LuaObject.checkType(l, 3, out headFrameId);
			int i = playerBasicInfoComponentCommon.CanSetHeadPortraitAndHeadFrame(headPortraitId, headFrameId);
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

	// Token: 0x060187E4 RID: 100324 RVA: 0x006E185C File Offset: 0x006DFA5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeadPortraitAndHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int headPortraitId;
			LuaObject.checkType(l, 2, out headPortraitId);
			int headFrameId;
			LuaObject.checkType(l, 3, out headFrameId);
			int i = playerBasicInfoComponentCommon.SetHeadPortraitAndHeadFrame(headPortraitId, headFrameId);
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

	// Token: 0x060187E5 RID: 100325 RVA: 0x006E18CC File Offset: 0x006DFACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSetHeadPortrait(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int headPortraitId;
			LuaObject.checkType(l, 2, out headPortraitId);
			int i = playerBasicInfoComponentCommon.CanSetHeadPortrait(headPortraitId);
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

	// Token: 0x060187E6 RID: 100326 RVA: 0x006E1930 File Offset: 0x006DFB30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeadPortrait(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int headPortrait;
			LuaObject.checkType(l, 2, out headPortrait);
			int i = playerBasicInfoComponentCommon.SetHeadPortrait(headPortrait);
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

	// Token: 0x060187E7 RID: 100327 RVA: 0x006E1994 File Offset: 0x006DFB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSetHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			int i = playerBasicInfoComponentCommon.CanSetHeadFrame(headFrameId);
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

	// Token: 0x060187E8 RID: 100328 RVA: 0x006E19F8 File Offset: 0x006DFBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int headFrame;
			LuaObject.checkType(l, 2, out headFrame);
			int i = playerBasicInfoComponentCommon.SetHeadFrame(headFrame);
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

	// Token: 0x060187E9 RID: 100329 RVA: 0x006E1A5C File Offset: 0x006DFC5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanChangePlayerName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			string newName;
			LuaObject.checkType(l, 2, out newName);
			int i = playerBasicInfoComponentCommon.CanChangePlayerName(newName);
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

	// Token: 0x060187EA RID: 100330 RVA: 0x006E1AC0 File Offset: 0x006DFCC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChangePlayerName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			string newName;
			LuaObject.checkType(l, 2, out newName);
			int i = playerBasicInfoComponentCommon.ChangePlayerName(newName);
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

	// Token: 0x060187EB RID: 100331 RVA: 0x006E1B24 File Offset: 0x006DFD24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckPlayerName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			int i = playerBasicInfoComponentCommon.CheckPlayerName(name);
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

	// Token: 0x060187EC RID: 100332 RVA: 0x006E1B88 File Offset: 0x006DFD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoShare(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.DoShare();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187ED RID: 100333 RVA: 0x006E1BD4 File Offset: 0x006DFDD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TryUpdateSignedDays(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.m_luaExportHelper.TryUpdateSignedDays();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187EE RID: 100334 RVA: 0x006E1C28 File Offset: 0x006DFE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGameFunctionOpenInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionType);
			ConfigDataGameFunctionOpenInfo gameFunctionOpenInfo = playerBasicInfoComponentCommon.m_luaExportHelper.GetGameFunctionOpenInfo(gameFunctionType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameFunctionOpenInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187EF RID: 100335 RVA: 0x006E1C90 File Offset: 0x006DFE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAddPlayerExp(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponentCommon.m_luaExportHelper.CanAddPlayerExp();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187F0 RID: 100336 RVA: 0x006E1CEC File Offset: 0x006DFEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLevelChange(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int upLevel;
			LuaObject.checkType(l, 2, out upLevel);
			int addExp;
			LuaObject.checkType(l, 3, out addExp);
			playerBasicInfoComponentCommon.m_luaExportHelper.OnLevelChange(upLevel, addExp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187F1 RID: 100337 RVA: 0x006E1D58 File Offset: 0x006DFF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LevelUp(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.m_luaExportHelper.LevelUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187F2 RID: 100338 RVA: 0x006E1DAC File Offset: 0x006DFFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitEnergy(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			long secondPast;
			LuaObject.checkType(l, 2, out secondPast);
			playerBasicInfoComponentCommon.m_luaExportHelper.InitEnergy(secondPast);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187F3 RID: 100339 RVA: 0x006E1E08 File Offset: 0x006E0008
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBuyEnergyConfig(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			ConfigDataBuyEnergyInfo buyEnergyConfig = playerBasicInfoComponentCommon.m_luaExportHelper.GetBuyEnergyConfig();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyEnergyConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187F4 RID: 100340 RVA: 0x006E1E64 File Offset: 0x006E0064
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBoughtNumsUsedOut(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			bool b = playerBasicInfoComponentCommon.m_luaExportHelper.IsBoughtNumsUsedOut();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187F5 RID: 100341 RVA: 0x006E1EC0 File Offset: 0x006E00C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBuyArenaTicketConfig(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			ConfigDataBuyArenaTicketInfo buyArenaTicketConfig = playerBasicInfoComponentCommon.m_luaExportHelper.GetBuyArenaTicketConfig();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buyArenaTicketConfig);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187F6 RID: 100342 RVA: 0x006E1F1C File Offset: 0x006E011C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayerActionFlushEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.m_luaExportHelper.OnPlayerActionFlushEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187F7 RID: 100343 RVA: 0x006E1F70 File Offset: 0x006E0170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFlush(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.m_luaExportHelper.OnFlush();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187F8 RID: 100344 RVA: 0x006E1FC4 File Offset: 0x006E01C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHeadIconChange(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.m_luaExportHelper.OnHeadIconChange();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187F9 RID: 100345 RVA: 0x006E2018 File Offset: 0x006E0218
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TryChangePlayerName(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			string newName;
			LuaObject.checkType(l, 2, out newName);
			int i = playerBasicInfoComponentCommon.m_luaExportHelper.TryChangePlayerName(newName);
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

	// Token: 0x060187FA RID: 100346 RVA: 0x006E2080 File Offset: 0x006E0280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_LevelUpPlayerLevelEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__callDele_LevelUpPlayerLevelEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187FB RID: 100347 RVA: 0x006E20DC File Offset: 0x006E02DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_LevelUpPlayerLevelEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__clearDele_LevelUpPlayerLevelEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187FC RID: 100348 RVA: 0x006E2138 File Offset: 0x006E0338
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_ConsumeEnergyMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__callDele_ConsumeEnergyMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187FD RID: 100349 RVA: 0x006E2194 File Offset: 0x006E0394
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_ConsumeEnergyMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__clearDele_ConsumeEnergyMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187FE RID: 100350 RVA: 0x006E21F0 File Offset: 0x006E03F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_ConsumeGoldMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__callDele_ConsumeGoldMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060187FF RID: 100351 RVA: 0x006E224C File Offset: 0x006E044C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_ConsumeGoldMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__clearDele_ConsumeGoldMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018800 RID: 100352 RVA: 0x006E22A8 File Offset: 0x006E04A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_ConsumeCrystalMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__callDele_ConsumeCrystalMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018801 RID: 100353 RVA: 0x006E2304 File Offset: 0x006E0504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_ConsumeCrystalMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__clearDele_ConsumeCrystalMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018802 RID: 100354 RVA: 0x006E2360 File Offset: 0x006E0560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_LevelUpPlayerLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__callDele_LevelUpPlayerLevelMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018803 RID: 100355 RVA: 0x006E23BC File Offset: 0x006E05BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_LevelUpPlayerLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__clearDele_LevelUpPlayerLevelMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018804 RID: 100356 RVA: 0x006E2418 File Offset: 0x006E0618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_AddBuyEnergyMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__callDele_AddBuyEnergyMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018805 RID: 100357 RVA: 0x006E2474 File Offset: 0x006E0674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_AddBuyEnergyMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__clearDele_AddBuyEnergyMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018806 RID: 100358 RVA: 0x006E24D0 File Offset: 0x006E06D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_PlayerActionFlushEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.m_luaExportHelper.__callDele_PlayerActionFlushEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018807 RID: 100359 RVA: 0x006E2524 File Offset: 0x006E0724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_PlayerActionFlushEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.m_luaExportHelper.__clearDele_PlayerActionFlushEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018808 RID: 100360 RVA: 0x006E2578 File Offset: 0x006E0778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_ConsumeFriendshipPointsEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__callDele_ConsumeFriendshipPointsEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018809 RID: 100361 RVA: 0x006E25D4 File Offset: 0x006E07D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_ConsumeFriendshipPointsEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__clearDele_ConsumeFriendshipPointsEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601880A RID: 100362 RVA: 0x006E2630 File Offset: 0x006E0830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_SetHeadIconEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__callDele_SetHeadIconEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601880B RID: 100363 RVA: 0x006E268C File Offset: 0x006E088C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_SetHeadIconEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			playerBasicInfoComponentCommon.m_luaExportHelper.__clearDele_SetHeadIconEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601880C RID: 100364 RVA: 0x006E26E8 File Offset: 0x006E08E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_AddRechargeRMBEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			DateTime arg2;
			LuaObject.checkValueType<DateTime>(l, 3, out arg2);
			playerBasicInfoComponentCommon.m_luaExportHelper.__callDele_AddRechargeRMBEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601880D RID: 100365 RVA: 0x006E2754 File Offset: 0x006E0954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_AddRechargeRMBEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			DateTime arg2;
			LuaObject.checkValueType<DateTime>(l, 3, out arg2);
			playerBasicInfoComponentCommon.m_luaExportHelper.__clearDele_AddRechargeRMBEvent(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601880E RID: 100366 RVA: 0x006E27C0 File Offset: 0x006E09C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_DoShareEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.m_luaExportHelper.__callDele_DoShareEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601880F RID: 100367 RVA: 0x006E2814 File Offset: 0x006E0A14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_DoShareEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			playerBasicInfoComponentCommon.m_luaExportHelper.__clearDele_DoShareEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018810 RID: 100368 RVA: 0x006E2868 File Offset: 0x006E0A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018811 RID: 100369 RVA: 0x006E28C0 File Offset: 0x006E0AC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			playerBasicInfoComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018812 RID: 100370 RVA: 0x006E291C File Offset: 0x006E0B1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_level(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.m_luaExportHelper.m_level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018813 RID: 100371 RVA: 0x006E2974 File Offset: 0x006E0B74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_level(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LevelComponentCommon level;
			LuaObject.checkType<LevelComponentCommon>(l, 2, out level);
			playerBasicInfoComponentCommon.m_luaExportHelper.m_level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018814 RID: 100372 RVA: 0x006E29D0 File Offset: 0x006E0BD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018815 RID: 100373 RVA: 0x006E2A28 File Offset: 0x006E0C28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			playerBasicInfoComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018816 RID: 100374 RVA: 0x006E2A84 File Offset: 0x006E0C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mission(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.m_luaExportHelper.m_mission);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018817 RID: 100375 RVA: 0x006E2ADC File Offset: 0x006E0CDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_mission(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			MissionComponentCommon mission;
			LuaObject.checkType<MissionComponentCommon>(l, 2, out mission);
			playerBasicInfoComponentCommon.m_luaExportHelper.m_mission = mission;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018818 RID: 100376 RVA: 0x006E2B38 File Offset: 0x006E0D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018819 RID: 100377 RVA: 0x006E2B90 File Offset: 0x006E0D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			playerBasicInfoComponentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601881A RID: 100378 RVA: 0x006E2BEC File Offset: 0x006E0DEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601881B RID: 100379 RVA: 0x006E2C44 File Offset: 0x006E0E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			playerBasicInfoComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601881C RID: 100380 RVA: 0x006E2CA0 File Offset: 0x006E0EA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_thearchyTrial(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.m_luaExportHelper.m_thearchyTrial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601881D RID: 100381 RVA: 0x006E2CF8 File Offset: 0x006E0EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_thearchyTrial(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			ThearchyTrialCompomentCommon thearchyTrial;
			LuaObject.checkType<ThearchyTrialCompomentCommon>(l, 2, out thearchyTrial);
			playerBasicInfoComponentCommon.m_luaExportHelper.m_thearchyTrial = thearchyTrial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601881E RID: 100382 RVA: 0x006E2D54 File Offset: 0x006E0F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resource(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.m_luaExportHelper.m_resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601881F RID: 100383 RVA: 0x006E2DAC File Offset: 0x006E0FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resource(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			ResourceComponentCommon resource;
			LuaObject.checkType<ResourceComponentCommon>(l, 2, out resource);
			playerBasicInfoComponentCommon.m_luaExportHelper.m_resource = resource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018820 RID: 100384 RVA: 0x006E2E08 File Offset: 0x006E1008
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guild(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.m_luaExportHelper.m_guild);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018821 RID: 100385 RVA: 0x006E2E60 File Offset: 0x006E1060
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_guild(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			GuildComponentCommon guild;
			LuaObject.checkType<GuildComponentCommon>(l, 2, out guild);
			playerBasicInfoComponentCommon.m_luaExportHelper.m_guild = guild;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018822 RID: 100386 RVA: 0x006E2EBC File Offset: 0x006E10BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changedGoods(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.m_luaExportHelper.m_changedGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018823 RID: 100387 RVA: 0x006E2F14 File Offset: 0x006E1114
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_changedGoods(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			List<BagItemBase> changedGoods;
			LuaObject.checkType<List<BagItemBase>>(l, 2, out changedGoods);
			playerBasicInfoComponentCommon.m_luaExportHelper.m_changedGoods = changedGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018824 RID: 100388 RVA: 0x006E2F70 File Offset: 0x006E1170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LevelUpPlayerLevelEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerBasicInfoComponentCommon.LevelUpPlayerLevelEvent += value;
				}
				else if (num == 2)
				{
					playerBasicInfoComponentCommon.LevelUpPlayerLevelEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018825 RID: 100389 RVA: 0x006E2FF0 File Offset: 0x006E11F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerBasicDS(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.m_playerBasicDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018826 RID: 100390 RVA: 0x006E3044 File Offset: 0x006E1244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerBasicDS(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			DataSectionPlayerBasicInfo playerBasicDS;
			LuaObject.checkType<DataSectionPlayerBasicInfo>(l, 2, out playerBasicDS);
			playerBasicInfoComponentCommon.m_playerBasicDS = playerBasicDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018827 RID: 100391 RVA: 0x006E309C File Offset: 0x006E129C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConsumeEnergyMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerBasicInfoComponentCommon.ConsumeEnergyMissionEvent += value;
				}
				else if (num == 2)
				{
					playerBasicInfoComponentCommon.ConsumeEnergyMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018828 RID: 100392 RVA: 0x006E311C File Offset: 0x006E131C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConsumeGoldMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerBasicInfoComponentCommon.ConsumeGoldMissionEvent += value;
				}
				else if (num == 2)
				{
					playerBasicInfoComponentCommon.ConsumeGoldMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018829 RID: 100393 RVA: 0x006E319C File Offset: 0x006E139C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConsumeCrystalMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerBasicInfoComponentCommon.ConsumeCrystalMissionEvent += value;
				}
				else if (num == 2)
				{
					playerBasicInfoComponentCommon.ConsumeCrystalMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601882A RID: 100394 RVA: 0x006E321C File Offset: 0x006E141C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LevelUpPlayerLevelMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerBasicInfoComponentCommon.LevelUpPlayerLevelMissionEvent += value;
				}
				else if (num == 2)
				{
					playerBasicInfoComponentCommon.LevelUpPlayerLevelMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601882B RID: 100395 RVA: 0x006E329C File Offset: 0x006E149C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AddBuyEnergyMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerBasicInfoComponentCommon.AddBuyEnergyMissionEvent += value;
				}
				else if (num == 2)
				{
					playerBasicInfoComponentCommon.AddBuyEnergyMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601882C RID: 100396 RVA: 0x006E331C File Offset: 0x006E151C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PlayerActionFlushEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerBasicInfoComponentCommon.PlayerActionFlushEvent += value;
				}
				else if (num == 2)
				{
					playerBasicInfoComponentCommon.PlayerActionFlushEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601882D RID: 100397 RVA: 0x006E339C File Offset: 0x006E159C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConsumeFriendshipPointsEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerBasicInfoComponentCommon.ConsumeFriendshipPointsEvent += value;
				}
				else if (num == 2)
				{
					playerBasicInfoComponentCommon.ConsumeFriendshipPointsEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601882E RID: 100398 RVA: 0x006E341C File Offset: 0x006E161C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SetHeadIconEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerBasicInfoComponentCommon.SetHeadIconEvent += value;
				}
				else if (num == 2)
				{
					playerBasicInfoComponentCommon.SetHeadIconEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601882F RID: 100399 RVA: 0x006E349C File Offset: 0x006E169C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AddRechargeRMBEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			Action<int, DateTime> value;
			int num = LuaObject.checkDelegate<Action<int, DateTime>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerBasicInfoComponentCommon.AddRechargeRMBEvent += value;
				}
				else if (num == 2)
				{
					playerBasicInfoComponentCommon.AddRechargeRMBEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018830 RID: 100400 RVA: 0x006E351C File Offset: 0x006E171C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DoShareEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerBasicInfoComponentCommon.DoShareEvent += value;
				}
				else if (num == 2)
				{
					playerBasicInfoComponentCommon.DoShareEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018831 RID: 100401 RVA: 0x006E359C File Offset: 0x006E179C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerBasicInfoComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018832 RID: 100402 RVA: 0x006E35F0 File Offset: 0x006E17F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			PlayerBasicInfoComponentCommon playerBasicInfoComponentCommon = (PlayerBasicInfoComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			playerBasicInfoComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018833 RID: 100403 RVA: 0x006E3648 File Offset: 0x006E1848
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.PlayerBasicInfoComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsGameFunctionOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetCreateTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetCreateTimeUtc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetLastLogoutTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetLoginTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetPlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetUserId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsMe);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetCurrentLevelExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetRechargedCsystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetRechargeRMB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetHeadIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetDefaultHeadIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetHeadPortrait);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsPlayerLevelMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddPlayerExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsGoldEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsGoldOverFlow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddBrillianceMithralStone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddMithralStone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsMithralStoneEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsBrillianceMithralStoneEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsCurrencyEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddCurrency);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddRechargeRMB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsCrystalEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsReachEnergyMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.FlushEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CanFlushEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CanFlushPlayerAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.ResetPlayerActionNextFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IncreamentEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.DecreaseEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsEnergyEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetCurrentTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsSigned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CanSignToday);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CanBuyEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.BuyEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CanBuyArenaTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.BuyArenaTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetNextFlushPlayerActionTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.FlushPlayerAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsArenaTicketsEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsArenaTicketsFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddArenaTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetAreanaTicketNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddRechargedCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddArenaHonour);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetArenaHonour);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddRealTimePVPHonor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetRealTimePVPHonor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetFriendshipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetSkinTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddFriendshipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddSkinTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddMemoryEssence);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.AddGuildMedal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsGuildMedalEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsFriendshipPointsEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsArenaHonourEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsRealTimePVPHonorEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsSkinTicketEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsMemoryEssenceEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CanSetUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.SetUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CleanUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CompleteAllUserGuides);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsUserGuideCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetRechargedCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CheckRankingListAddPlayerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CreateRankingPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.OnRankingListPlayerInfoChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.OpenGameRating);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsOpenGameRating);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.SetMemoryStoreOpenStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsMemoryStoreOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetLevelUpAddEnergyFromConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetNextLevelExpFromConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CanSetHeadPortraitAndHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.SetHeadPortraitAndHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CanSetHeadPortrait);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.SetHeadPortrait);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CanSetHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.SetHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CanChangePlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.ChangePlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CheckPlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.DoShare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.TryUpdateSignedDays);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetGameFunctionOpenInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.CanAddPlayerExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.OnLevelChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.LevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.InitEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetBuyEnergyConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.IsBoughtNumsUsedOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.GetBuyArenaTicketConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.OnPlayerActionFlushEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.OnFlush);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.OnHeadIconChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.TryChangePlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__callDele_LevelUpPlayerLevelEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__clearDele_LevelUpPlayerLevelEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__callDele_ConsumeEnergyMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__clearDele_ConsumeEnergyMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__callDele_ConsumeGoldMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__clearDele_ConsumeGoldMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__callDele_ConsumeCrystalMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__clearDele_ConsumeCrystalMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__callDele_LevelUpPlayerLevelMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__clearDele_LevelUpPlayerLevelMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__callDele_AddBuyEnergyMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__clearDele_AddBuyEnergyMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__callDele_PlayerActionFlushEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__clearDele_PlayerActionFlushEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__callDele_ConsumeFriendshipPointsEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__clearDele_ConsumeFriendshipPointsEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__callDele_SetHeadIconEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__clearDele_SetHeadIconEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__callDele_AddRechargeRMBEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__clearDele_AddRechargeRMBEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__callDele_DoShareEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.__clearDele_DoShareEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache88);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8A, true);
		string name2 = "m_level";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_m_level);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_m_level);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8C, true);
		string name3 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_m_bag);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8E, true);
		string name4 = "m_mission";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_m_mission);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_m_mission);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache90, true);
		string name5 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_m_rift);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache92, true);
		string name6 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_m_hero);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache94, true);
		string name7 = "m_thearchyTrial";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_m_thearchyTrial);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_m_thearchyTrial);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache96, true);
		string name8 = "m_resource";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_m_resource);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_m_resource);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache98, true);
		string name9 = "m_guild";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_m_guild);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_m_guild);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9A, true);
		string name10 = "m_changedGoods";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_m_changedGoods);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_m_changedGoods);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9C, true);
		string name11 = "LevelUpPlayerLevelEvent";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_LevelUpPlayerLevelEvent);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9D, true);
		string name12 = "m_playerBasicDS";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_m_playerBasicDS);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9E;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_m_playerBasicDS);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cache9F, true);
		string name13 = "ConsumeEnergyMissionEvent";
		LuaCSFunction get13 = null;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_ConsumeEnergyMissionEvent);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA0, true);
		string name14 = "ConsumeGoldMissionEvent";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_ConsumeGoldMissionEvent);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA1, true);
		string name15 = "ConsumeCrystalMissionEvent";
		LuaCSFunction get15 = null;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_ConsumeCrystalMissionEvent);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA2, true);
		string name16 = "LevelUpPlayerLevelMissionEvent";
		LuaCSFunction get16 = null;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_LevelUpPlayerLevelMissionEvent);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA3, true);
		string name17 = "AddBuyEnergyMissionEvent";
		LuaCSFunction get17 = null;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_AddBuyEnergyMissionEvent);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA4, true);
		string name18 = "PlayerActionFlushEvent";
		LuaCSFunction get18 = null;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_PlayerActionFlushEvent);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA5, true);
		string name19 = "ConsumeFriendshipPointsEvent";
		LuaCSFunction get19 = null;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_ConsumeFriendshipPointsEvent);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA6, true);
		string name20 = "SetHeadIconEvent";
		LuaCSFunction get20 = null;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_SetHeadIconEvent);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA7, true);
		string name21 = "AddRechargeRMBEvent";
		LuaCSFunction get21 = null;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_AddRechargeRMBEvent);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA8, true);
		string name22 = "DoShareEvent";
		LuaCSFunction get22 = null;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_DoShareEvent);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheA9, true);
		string name23 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.get_Owner);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheAA;
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheAB, true);
		if (Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_PlayerBasicInfoComponentCommon.<>f__mg$cacheAC, typeof(PlayerBasicInfoComponentCommon));
	}

	// Token: 0x0400ECB6 RID: 60598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400ECB7 RID: 60599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400ECB8 RID: 60600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400ECB9 RID: 60601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400ECBA RID: 60602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400ECBB RID: 60603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400ECBC RID: 60604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400ECBD RID: 60605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400ECBE RID: 60606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400ECBF RID: 60607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400ECC0 RID: 60608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400ECC1 RID: 60609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400ECC2 RID: 60610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400ECC3 RID: 60611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400ECC4 RID: 60612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400ECC5 RID: 60613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400ECC6 RID: 60614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400ECC7 RID: 60615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400ECC8 RID: 60616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400ECC9 RID: 60617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400ECCA RID: 60618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400ECCB RID: 60619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400ECCC RID: 60620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400ECCD RID: 60621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400ECCE RID: 60622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400ECCF RID: 60623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400ECD0 RID: 60624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400ECD1 RID: 60625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400ECD2 RID: 60626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400ECD3 RID: 60627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400ECD4 RID: 60628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400ECD5 RID: 60629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400ECD6 RID: 60630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400ECD7 RID: 60631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400ECD8 RID: 60632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400ECD9 RID: 60633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400ECDA RID: 60634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400ECDB RID: 60635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400ECDC RID: 60636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400ECDD RID: 60637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400ECDE RID: 60638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400ECDF RID: 60639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400ECE0 RID: 60640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400ECE1 RID: 60641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400ECE2 RID: 60642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400ECE3 RID: 60643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400ECE4 RID: 60644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400ECE5 RID: 60645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400ECE6 RID: 60646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400ECE7 RID: 60647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400ECE8 RID: 60648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400ECE9 RID: 60649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400ECEA RID: 60650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400ECEB RID: 60651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400ECEC RID: 60652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400ECED RID: 60653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400ECEE RID: 60654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400ECEF RID: 60655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400ECF0 RID: 60656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400ECF1 RID: 60657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400ECF2 RID: 60658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400ECF3 RID: 60659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400ECF4 RID: 60660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400ECF5 RID: 60661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400ECF6 RID: 60662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400ECF7 RID: 60663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400ECF8 RID: 60664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400ECF9 RID: 60665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400ECFA RID: 60666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400ECFB RID: 60667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400ECFC RID: 60668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400ECFD RID: 60669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400ECFE RID: 60670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400ECFF RID: 60671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400ED00 RID: 60672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400ED01 RID: 60673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400ED02 RID: 60674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400ED03 RID: 60675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400ED04 RID: 60676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400ED05 RID: 60677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400ED06 RID: 60678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400ED07 RID: 60679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400ED08 RID: 60680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400ED09 RID: 60681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400ED0A RID: 60682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400ED0B RID: 60683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400ED0C RID: 60684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400ED0D RID: 60685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400ED0E RID: 60686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400ED0F RID: 60687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400ED10 RID: 60688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400ED11 RID: 60689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400ED12 RID: 60690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400ED13 RID: 60691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400ED14 RID: 60692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400ED15 RID: 60693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400ED16 RID: 60694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400ED17 RID: 60695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400ED18 RID: 60696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400ED19 RID: 60697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400ED1A RID: 60698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400ED1B RID: 60699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400ED1C RID: 60700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400ED1D RID: 60701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400ED1E RID: 60702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400ED1F RID: 60703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400ED20 RID: 60704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400ED21 RID: 60705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400ED22 RID: 60706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400ED23 RID: 60707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400ED24 RID: 60708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400ED25 RID: 60709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400ED26 RID: 60710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400ED27 RID: 60711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400ED28 RID: 60712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400ED29 RID: 60713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400ED2A RID: 60714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400ED2B RID: 60715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400ED2C RID: 60716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0400ED2D RID: 60717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0400ED2E RID: 60718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0400ED2F RID: 60719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0400ED30 RID: 60720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0400ED31 RID: 60721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0400ED32 RID: 60722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0400ED33 RID: 60723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0400ED34 RID: 60724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0400ED35 RID: 60725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0400ED36 RID: 60726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0400ED37 RID: 60727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0400ED38 RID: 60728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0400ED39 RID: 60729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0400ED3A RID: 60730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0400ED3B RID: 60731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0400ED3C RID: 60732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0400ED3D RID: 60733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0400ED3E RID: 60734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0400ED3F RID: 60735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0400ED40 RID: 60736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0400ED41 RID: 60737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0400ED42 RID: 60738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0400ED43 RID: 60739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0400ED44 RID: 60740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0400ED45 RID: 60741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0400ED46 RID: 60742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0400ED47 RID: 60743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x0400ED48 RID: 60744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x0400ED49 RID: 60745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x0400ED4A RID: 60746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x0400ED4B RID: 60747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x0400ED4C RID: 60748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x0400ED4D RID: 60749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x0400ED4E RID: 60750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x0400ED4F RID: 60751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x0400ED50 RID: 60752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x0400ED51 RID: 60753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x0400ED52 RID: 60754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x0400ED53 RID: 60755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x0400ED54 RID: 60756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x0400ED55 RID: 60757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x0400ED56 RID: 60758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x0400ED57 RID: 60759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x0400ED58 RID: 60760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x0400ED59 RID: 60761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x0400ED5A RID: 60762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x0400ED5B RID: 60763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x0400ED5C RID: 60764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x0400ED5D RID: 60765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x0400ED5E RID: 60766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x0400ED5F RID: 60767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x0400ED60 RID: 60768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x0400ED61 RID: 60769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x0400ED62 RID: 60770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;
}
