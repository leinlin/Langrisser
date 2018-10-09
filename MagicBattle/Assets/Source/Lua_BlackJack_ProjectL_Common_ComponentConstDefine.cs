using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011E8 RID: 4584
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ComponentConstDefine : LuaObject
{
	// Token: 0x06017C21 RID: 97313 RVA: 0x0068ABFC File Offset: 0x00688DFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ComponentConstDefine o = new ComponentConstDefine();
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

	// Token: 0x06017C22 RID: 97314 RVA: 0x0068AC44 File Offset: 0x00688E44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerBasicInfoComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "PlayerBasicInfo");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C23 RID: 97315 RVA: 0x0068AC8C File Offset: 0x00688E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BagComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Bag");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C24 RID: 97316 RVA: 0x0068ACD4 File Offset: 0x00688ED4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Hero");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C25 RID: 97317 RVA: 0x0068AD1C File Offset: 0x00688F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Battle");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C26 RID: 97318 RVA: 0x0068AD64 File Offset: 0x00688F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Level");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C27 RID: 97319 RVA: 0x0068ADAC File Offset: 0x00688FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RiftComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Rift");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C28 RID: 97320 RVA: 0x0068ADF4 File Offset: 0x00688FF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MailComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Mail");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C29 RID: 97321 RVA: 0x0068AE3C File Offset: 0x0068903C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RandomStoreComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "RandomStore");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C2A RID: 97322 RVA: 0x0068AE84 File Offset: 0x00689084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FixedStoreComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FixedStore");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C2B RID: 97323 RVA: 0x0068AECC File Offset: 0x006890CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChatComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Chat");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C2C RID: 97324 RVA: 0x0068AF14 File Offset: 0x00689114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatGroupComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "ChatGroup");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C2D RID: 97325 RVA: 0x0068AF5C File Offset: 0x0068915C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SelectCardComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "SelectCard");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C2E RID: 97326 RVA: 0x0068AFA4 File Offset: 0x006891A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RaffleComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Raffle");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C2F RID: 97327 RVA: 0x0068AFEC File Offset: 0x006891EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SurveyComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Survey");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C30 RID: 97328 RVA: 0x0068B034 File Offset: 0x00689234
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MissionComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Mission");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C31 RID: 97329 RVA: 0x0068B07C File Offset: 0x0068927C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CommentComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Comment");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C32 RID: 97330 RVA: 0x0068B0C4 File Offset: 0x006892C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StatisticalDataComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "StatisticalData");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C33 RID: 97331 RVA: 0x0068B10C File Offset: 0x0068930C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ThearchyTrailComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "ThearchyTrail");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C34 RID: 97332 RVA: 0x0068B154 File Offset: 0x00689354
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AnikiGymComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "AnikiGym");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C35 RID: 97333 RVA: 0x0068B19C File Offset: 0x0068939C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroDungeonComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "HeroDungeon");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C36 RID: 97334 RVA: 0x0068B1E4 File Offset: 0x006893E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroTrainningComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "HeroTrainning");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C37 RID: 97335 RVA: 0x0068B22C File Offset: 0x0068942C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TreasureMapComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "TreasureMap");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C38 RID: 97336 RVA: 0x0068B274 File Offset: 0x00689474
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TrainingGroundComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "TrainingGround");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C39 RID: 97337 RVA: 0x0068B2BC File Offset: 0x006894BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroAssistantsComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "HeroAssistants");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C3A RID: 97338 RVA: 0x0068B304 File Offset: 0x00689504
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MemoryCorridorComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "MemoryCorridor");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C3B RID: 97339 RVA: 0x0068B34C File Offset: 0x0068954C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Arena");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C3C RID: 97340 RVA: 0x0068B394 File Offset: 0x00689594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OperationalActivityComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "OperationalActivity");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C3D RID: 97341 RVA: 0x0068B3DC File Offset: 0x006895DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DanmakuComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Danmaku");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C3E RID: 97342 RVA: 0x0068B424 File Offset: 0x00689624
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Team");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C3F RID: 97343 RVA: 0x0068B46C File Offset: 0x0068966C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GlobalRankingListComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "GlobalRankingListComponent");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C40 RID: 97344 RVA: 0x0068B4B4 File Offset: 0x006896B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FriendComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Friend");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C41 RID: 97345 RVA: 0x0068B4FC File Offset: 0x006896FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroPhantomComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "HeroPhantom");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C42 RID: 97346 RVA: 0x0068B544 File Offset: 0x00689744
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CooperateBattleComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "CooperateBattle");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C43 RID: 97347 RVA: 0x0068B58C File Offset: 0x0068978C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NoviceComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Novice");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C44 RID: 97348 RVA: 0x0068B5D4 File Offset: 0x006897D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RechargeStoreComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "RechargeStore");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C45 RID: 97349 RVA: 0x0068B61C File Offset: 0x0068981C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GiftStoreComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "GiftStore");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C46 RID: 97350 RVA: 0x0068B664 File Offset: 0x00689864
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ResourceComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Resource");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C47 RID: 97351 RVA: 0x0068B6AC File Offset: 0x006898AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RealTimePVPComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "RealTimePVP");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C48 RID: 97352 RVA: 0x0068B6F4 File Offset: 0x006898F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Guild");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C49 RID: 97353 RVA: 0x0068B73C File Offset: 0x0068993C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UnchartedScoreComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UnchartedScore");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C4A RID: 97354 RVA: 0x0068B784 File Offset: 0x00689984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ClimbTowerComponentName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "ClimbTower");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C4B RID: 97355 RVA: 0x0068B7CC File Offset: 0x006899CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerStartLvl(IntPtr l)
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

	// Token: 0x06017C4C RID: 97356 RVA: 0x0068B810 File Offset: 0x00689A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CustomMailTemplateId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C4D RID: 97357 RVA: 0x0068B854 File Offset: 0x00689A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MailStatusUnread(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C4E RID: 97358 RVA: 0x0068B898 File Offset: 0x00689A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MailStatusReaded(IntPtr l)
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

	// Token: 0x06017C4F RID: 97359 RVA: 0x0068B8DC File Offset: 0x00689ADC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MailStatusGotAttachments(IntPtr l)
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

	// Token: 0x06017C50 RID: 97360 RVA: 0x0068B920 File Offset: 0x00689B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelectOneTimes(IntPtr l)
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

	// Token: 0x06017C51 RID: 97361 RVA: 0x0068B964 File Offset: 0x00689B64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SelectTenTimes(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 10);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C52 RID: 97362 RVA: 0x0068B9A8 File Offset: 0x00689BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InsignificanceParam(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C53 RID: 97363 RVA: 0x0068B9EC File Offset: 0x00689BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AnyTypeParam(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C54 RID: 97364 RVA: 0x0068BA30 File Offset: 0x00689C30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RiftLevelSimpleDifficulty(IntPtr l)
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

	// Token: 0x06017C55 RID: 97365 RVA: 0x0068BA74 File Offset: 0x00689C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RiftLevelDiffcultDiffculty(IntPtr l)
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

	// Token: 0x06017C56 RID: 97366 RVA: 0x0068BAB8 File Offset: 0x00689CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaOpponentNumsPerZone(IntPtr l)
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

	// Token: 0x06017C57 RID: 97367 RVA: 0x0068BAFC File Offset: 0x00689CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaOpponentNums(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C58 RID: 97368 RVA: 0x0068BB40 File Offset: 0x00689D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CoachStartLvl(IntPtr l)
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

	// Token: 0x06017C59 RID: 97369 RVA: 0x0068BB84 File Offset: 0x00689D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InstrumentStartLvl(IntPtr l)
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

	// Token: 0x06017C5A RID: 97370 RVA: 0x0068BBC8 File Offset: 0x00689DC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CoachFavorabilityStartLvl(IntPtr l)
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

	// Token: 0x06017C5B RID: 97371 RVA: 0x0068BC0C File Offset: 0x00689E0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HotCommentNumInAllComments(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C5C RID: 97372 RVA: 0x0068BC50 File Offset: 0x00689E50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaRevengeOpponentPointZoneId(IntPtr l)
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

	// Token: 0x06017C5D RID: 97373 RVA: 0x0068BC94 File Offset: 0x00689E94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaThisWeekBattleIdNums(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C5E RID: 97374 RVA: 0x0068BCD8 File Offset: 0x00689ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaMinArenaPoints(IntPtr l)
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

	// Token: 0x06017C5F RID: 97375 RVA: 0x0068BD1C File Offset: 0x00689F1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MaxEnhanceMaterialNums(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C60 RID: 97376 RVA: 0x0068BD60 File Offset: 0x00689F60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChatVoiceTimeLengthMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 20u);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C61 RID: 97377 RVA: 0x0068BDA4 File Offset: 0x00689FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatVoiceTimeLengthMin(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1u);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C62 RID: 97378 RVA: 0x0068BDE8 File Offset: 0x00689FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatRecordFrequency(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 16000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C63 RID: 97379 RVA: 0x0068BE30 File Offset: 0x0068A030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChatEncodeAndDecodeSampleSize(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 640);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C64 RID: 97380 RVA: 0x0068BE78 File Offset: 0x0068A078
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChatTextLengthLimit(IntPtr l)
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

	// Token: 0x06017C65 RID: 97381 RVA: 0x0068BEBC File Offset: 0x0068A0BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChatVoiceCacheCountMaxInWorldChannel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 10000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C66 RID: 97382 RVA: 0x0068BF04 File Offset: 0x0068A104
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChatVoiceTimeoutInWorldChannel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 7200000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C67 RID: 97383 RVA: 0x0068BF4C File Offset: 0x0068A14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChatVoiceCacheCountMaxInGuildChannel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 10000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C68 RID: 97384 RVA: 0x0068BF94 File Offset: 0x0068A194
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChatVoiceTimeoutInGuildChannel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 7200000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C69 RID: 97385 RVA: 0x0068BFDC File Offset: 0x0068A1DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChatRoomCountMaxInWorldChannel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 999);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C6A RID: 97386 RVA: 0x0068C024 File Offset: 0x0068A224
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RankingListForTopHeroNum(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C6B RID: 97387 RVA: 0x0068C068 File Offset: 0x0068A268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RankingListQueryPeriod(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C6C RID: 97388 RVA: 0x0068C0B0 File Offset: 0x0068A2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ZilongCheckAdvencePeriodSeconds(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C6D RID: 97389 RVA: 0x0068C0F4 File Offset: 0x0068A2F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildSearchPeriod(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3000);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C6E RID: 97390 RVA: 0x0068C13C File Offset: 0x0068A33C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ComponentConstDefine");
		string name = "PlayerBasicInfoComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_PlayerBasicInfoComponentName);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache0, null, false);
		string name2 = "BagComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_BagComponentName);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1, null, false);
		string name3 = "HeroComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_HeroComponentName);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2, null, false);
		string name4 = "BattleComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_BattleComponentName);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3, null, false);
		string name5 = "LevelComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_LevelComponentName);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4, null, false);
		string name6 = "RiftComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_RiftComponentName);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache5, null, false);
		string name7 = "MailComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_MailComponentName);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache6, null, false);
		string name8 = "RandomStoreComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_RandomStoreComponentName);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache7, null, false);
		string name9 = "FixedStoreComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_FixedStoreComponentName);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache8, null, false);
		string name10 = "ChatComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatComponentName);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache9, null, false);
		string name11 = "ChatGroupComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatGroupComponentName);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheA, null, false);
		string name12 = "SelectCardComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_SelectCardComponentName);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheB, null, false);
		string name13 = "RaffleComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_RaffleComponentName);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheC, null, false);
		string name14 = "SurveyComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_SurveyComponentName);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheD, null, false);
		string name15 = "MissionComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_MissionComponentName);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheE, null, false);
		string name16 = "CommentComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_CommentComponentName);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cacheF, null, false);
		string name17 = "StatisticalDataComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_StatisticalDataComponentName);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache10, null, false);
		string name18 = "ThearchyTrailComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ThearchyTrailComponentName);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache11, null, false);
		string name19 = "AnikiGymComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_AnikiGymComponentName);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache12, null, false);
		string name20 = "HeroDungeonComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_HeroDungeonComponentName);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache13, null, false);
		string name21 = "HeroTrainningComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_HeroTrainningComponentName);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache14, null, false);
		string name22 = "TreasureMapComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_TreasureMapComponentName);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache15, null, false);
		string name23 = "TrainingGroundComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_TrainingGroundComponentName);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache16, null, false);
		string name24 = "HeroAssistantsComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_HeroAssistantsComponentName);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache17, null, false);
		string name25 = "MemoryCorridorComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_MemoryCorridorComponentName);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache18, null, false);
		string name26 = "ArenaComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ArenaComponentName);
		}
		LuaObject.addMember(l, name26, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache19, null, false);
		string name27 = "OperationalActivityComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_OperationalActivityComponentName);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1A, null, false);
		string name28 = "DanmakuComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_DanmakuComponentName);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1B, null, false);
		string name29 = "TeamComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_TeamComponentName);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1C, null, false);
		string name30 = "GlobalRankingListComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_GlobalRankingListComponentName);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1D, null, false);
		string name31 = "FriendComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_FriendComponentName);
		}
		LuaObject.addMember(l, name31, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1E, null, false);
		string name32 = "HeroPhantomComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_HeroPhantomComponentName);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache1F, null, false);
		string name33 = "CooperateBattleComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_CooperateBattleComponentName);
		}
		LuaObject.addMember(l, name33, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache20, null, false);
		string name34 = "NoviceComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_NoviceComponentName);
		}
		LuaObject.addMember(l, name34, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache21, null, false);
		string name35 = "RechargeStoreComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_RechargeStoreComponentName);
		}
		LuaObject.addMember(l, name35, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache22, null, false);
		string name36 = "GiftStoreComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_GiftStoreComponentName);
		}
		LuaObject.addMember(l, name36, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache23, null, false);
		string name37 = "ResourceComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ResourceComponentName);
		}
		LuaObject.addMember(l, name37, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache24, null, false);
		string name38 = "RealTimePVPComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_RealTimePVPComponentName);
		}
		LuaObject.addMember(l, name38, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache25, null, false);
		string name39 = "GuildComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_GuildComponentName);
		}
		LuaObject.addMember(l, name39, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache26, null, false);
		string name40 = "UnchartedScoreComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_UnchartedScoreComponentName);
		}
		LuaObject.addMember(l, name40, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache27, null, false);
		string name41 = "ClimbTowerComponentName";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ClimbTowerComponentName);
		}
		LuaObject.addMember(l, name41, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache28, null, false);
		string name42 = "PlayerStartLvl";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_PlayerStartLvl);
		}
		LuaObject.addMember(l, name42, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache29, null, false);
		string name43 = "CustomMailTemplateId";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_CustomMailTemplateId);
		}
		LuaObject.addMember(l, name43, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2A, null, false);
		string name44 = "MailStatusUnread";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_MailStatusUnread);
		}
		LuaObject.addMember(l, name44, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2B, null, false);
		string name45 = "MailStatusReaded";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_MailStatusReaded);
		}
		LuaObject.addMember(l, name45, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2C, null, false);
		string name46 = "MailStatusGotAttachments";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_MailStatusGotAttachments);
		}
		LuaObject.addMember(l, name46, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2D, null, false);
		string name47 = "SelectOneTimes";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_SelectOneTimes);
		}
		LuaObject.addMember(l, name47, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2E, null, false);
		string name48 = "SelectTenTimes";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_SelectTenTimes);
		}
		LuaObject.addMember(l, name48, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache2F, null, false);
		string name49 = "InsignificanceParam";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_InsignificanceParam);
		}
		LuaObject.addMember(l, name49, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache30, null, false);
		string name50 = "AnyTypeParam";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_AnyTypeParam);
		}
		LuaObject.addMember(l, name50, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache31, null, false);
		string name51 = "RiftLevelSimpleDifficulty";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_RiftLevelSimpleDifficulty);
		}
		LuaObject.addMember(l, name51, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache32, null, false);
		string name52 = "RiftLevelDiffcultDiffculty";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_RiftLevelDiffcultDiffculty);
		}
		LuaObject.addMember(l, name52, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache33, null, false);
		string name53 = "ArenaOpponentNumsPerZone";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ArenaOpponentNumsPerZone);
		}
		LuaObject.addMember(l, name53, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache34, null, false);
		string name54 = "ArenaOpponentNums";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ArenaOpponentNums);
		}
		LuaObject.addMember(l, name54, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache35, null, false);
		string name55 = "CoachStartLvl";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_CoachStartLvl);
		}
		LuaObject.addMember(l, name55, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache36, null, false);
		string name56 = "InstrumentStartLvl";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_InstrumentStartLvl);
		}
		LuaObject.addMember(l, name56, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache37, null, false);
		string name57 = "CoachFavorabilityStartLvl";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_CoachFavorabilityStartLvl);
		}
		LuaObject.addMember(l, name57, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache38, null, false);
		string name58 = "HotCommentNumInAllComments";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_HotCommentNumInAllComments);
		}
		LuaObject.addMember(l, name58, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache39, null, false);
		string name59 = "ArenaRevengeOpponentPointZoneId";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ArenaRevengeOpponentPointZoneId);
		}
		LuaObject.addMember(l, name59, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3A, null, false);
		string name60 = "ArenaThisWeekBattleIdNums";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ArenaThisWeekBattleIdNums);
		}
		LuaObject.addMember(l, name60, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3B, null, false);
		string name61 = "ArenaMinArenaPoints";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ArenaMinArenaPoints);
		}
		LuaObject.addMember(l, name61, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3C, null, false);
		string name62 = "MaxEnhanceMaterialNums";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_MaxEnhanceMaterialNums);
		}
		LuaObject.addMember(l, name62, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3D, null, false);
		string name63 = "ChatVoiceTimeLengthMax";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatVoiceTimeLengthMax);
		}
		LuaObject.addMember(l, name63, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3E, null, false);
		string name64 = "ChatVoiceTimeLengthMin";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatVoiceTimeLengthMin);
		}
		LuaObject.addMember(l, name64, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache3F, null, false);
		string name65 = "ChatRecordFrequency";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatRecordFrequency);
		}
		LuaObject.addMember(l, name65, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache40, null, false);
		string name66 = "ChatEncodeAndDecodeSampleSize";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatEncodeAndDecodeSampleSize);
		}
		LuaObject.addMember(l, name66, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache41, null, false);
		string name67 = "ChatTextLengthLimit";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatTextLengthLimit);
		}
		LuaObject.addMember(l, name67, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache42, null, false);
		string name68 = "ChatVoiceCacheCountMaxInWorldChannel";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatVoiceCacheCountMaxInWorldChannel);
		}
		LuaObject.addMember(l, name68, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache43, null, false);
		string name69 = "ChatVoiceTimeoutInWorldChannel";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatVoiceTimeoutInWorldChannel);
		}
		LuaObject.addMember(l, name69, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache44, null, false);
		string name70 = "ChatVoiceCacheCountMaxInGuildChannel";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatVoiceCacheCountMaxInGuildChannel);
		}
		LuaObject.addMember(l, name70, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache45, null, false);
		string name71 = "ChatVoiceTimeoutInGuildChannel";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatVoiceTimeoutInGuildChannel);
		}
		LuaObject.addMember(l, name71, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache46, null, false);
		string name72 = "ChatRoomCountMaxInWorldChannel";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ChatRoomCountMaxInWorldChannel);
		}
		LuaObject.addMember(l, name72, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache47, null, false);
		string name73 = "RankingListForTopHeroNum";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_RankingListForTopHeroNum);
		}
		LuaObject.addMember(l, name73, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache48, null, false);
		string name74 = "RankingListQueryPeriod";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_RankingListQueryPeriod);
		}
		LuaObject.addMember(l, name74, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache49, null, false);
		string name75 = "ZilongCheckAdvencePeriodSeconds";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_ZilongCheckAdvencePeriodSeconds);
		}
		LuaObject.addMember(l, name75, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4A, null, false);
		string name76 = "GuildSearchPeriod";
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.get_GuildSearchPeriod);
		}
		LuaObject.addMember(l, name76, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4B, null, false);
		if (Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ComponentConstDefine.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ComponentConstDefine.<>f__mg$cache4C, typeof(ComponentConstDefine));
	}

	// Token: 0x0400E233 RID: 57907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E234 RID: 57908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E235 RID: 57909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E236 RID: 57910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E237 RID: 57911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E238 RID: 57912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E239 RID: 57913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E23A RID: 57914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E23B RID: 57915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E23C RID: 57916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E23D RID: 57917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E23E RID: 57918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E23F RID: 57919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E240 RID: 57920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E241 RID: 57921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E242 RID: 57922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E243 RID: 57923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E244 RID: 57924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E245 RID: 57925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E246 RID: 57926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E247 RID: 57927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E248 RID: 57928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E249 RID: 57929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E24A RID: 57930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E24B RID: 57931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E24C RID: 57932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E24D RID: 57933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E24E RID: 57934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E24F RID: 57935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E250 RID: 57936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E251 RID: 57937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E252 RID: 57938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E253 RID: 57939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E254 RID: 57940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E255 RID: 57941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E256 RID: 57942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E257 RID: 57943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E258 RID: 57944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E259 RID: 57945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E25A RID: 57946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E25B RID: 57947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E25C RID: 57948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E25D RID: 57949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400E25E RID: 57950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400E25F RID: 57951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400E260 RID: 57952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400E261 RID: 57953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400E262 RID: 57954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400E263 RID: 57955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400E264 RID: 57956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400E265 RID: 57957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400E266 RID: 57958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400E267 RID: 57959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400E268 RID: 57960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400E269 RID: 57961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400E26A RID: 57962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400E26B RID: 57963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400E26C RID: 57964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400E26D RID: 57965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400E26E RID: 57966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400E26F RID: 57967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400E270 RID: 57968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400E271 RID: 57969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400E272 RID: 57970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400E273 RID: 57971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400E274 RID: 57972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400E275 RID: 57973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400E276 RID: 57974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400E277 RID: 57975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400E278 RID: 57976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400E279 RID: 57977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400E27A RID: 57978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400E27B RID: 57979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400E27C RID: 57980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400E27D RID: 57981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400E27E RID: 57982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400E27F RID: 57983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;
}
