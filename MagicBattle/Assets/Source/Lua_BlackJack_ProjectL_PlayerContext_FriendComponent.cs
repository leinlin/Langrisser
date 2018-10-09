using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012C2 RID: 4802
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_FriendComponent : LuaObject
{
	// Token: 0x0601942D RID: 103469 RVA: 0x0073CC98 File Offset: 0x0073AE98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent o = new FriendComponent();
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

	// Token: 0x0601942E RID: 103470 RVA: 0x0073CCE0 File Offset: 0x0073AEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			friendComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601942F RID: 103471 RVA: 0x0073CD2C File Offset: 0x0073AF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			friendComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019430 RID: 103472 RVA: 0x0073CD78 File Offset: 0x0073AF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			friendComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019431 RID: 103473 RVA: 0x0073CDC4 File Offset: 0x0073AFC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			ushort dsversion = friendComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019432 RID: 103474 RVA: 0x0073CE18 File Offset: 0x0073B018
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Deserialize(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(DSFriendNtf)))
			{
				FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
				DSFriendNtf ntf;
				LuaObject.checkType<DSFriendNtf>(l, 2, out ntf);
				friendComponent.Deserialize(ntf);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(FriendInfoUpdateNtf)))
			{
				FriendComponent friendComponent2 = (FriendComponent)LuaObject.checkSelf(l);
				FriendInfoUpdateNtf ntf2;
				LuaObject.checkType<FriendInfoUpdateNtf>(l, 2, out ntf2);
				friendComponent2.Deserialize(ntf2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Deserialize to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019433 RID: 103475 RVA: 0x0073CEF0 File Offset: 0x0073B0F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBusinessCardHeroes(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<BattleHero> businessCardHeroes = friendComponent.GetBusinessCardHeroes();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019434 RID: 103476 RVA: 0x0073CF44 File Offset: 0x0073B144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBusinessCardInfoSet(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			BusinessCardInfoSet businessCardInfoSet = friendComponent.GetBusinessCardInfoSet();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardInfoSet);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019435 RID: 103477 RVA: 0x0073CF98 File Offset: 0x0073B198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSendFriendShipPointsCount(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			int sendFriendShipPointsCount = friendComponent.GetSendFriendShipPointsCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sendFriendShipPointsCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019436 RID: 103478 RVA: 0x0073CFEC File Offset: 0x0073B1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetClaimedFriendShipPointsCount(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			int claimedFriendShipPointsCount = friendComponent.GetClaimedFriendShipPointsCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, claimedFriendShipPointsCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019437 RID: 103479 RVA: 0x0073D040 File Offset: 0x0073B240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReceivedFriendShipPointsCount(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			int i = friendComponent.ReceivedFriendShipPointsCount();
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

	// Token: 0x06019438 RID: 103480 RVA: 0x0073D094 File Offset: 0x0073B294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadFromPBData(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			DSFriendNtf pbFriendInfo;
			LuaObject.checkType<DSFriendNtf>(l, 2, out pbFriendInfo);
			friendComponent.m_luaExportHelper.LoadFromPBData(pbFriendInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019439 RID: 103481 RVA: 0x0073D0F0 File Offset: 0x0073B2F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string s = friendComponent.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601943A RID: 103482 RVA: 0x0073D14C File Offset: 0x0073B34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			friendComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601943B RID: 103483 RVA: 0x0073D1A0 File Offset: 0x0073B3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			friendComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601943C RID: 103484 RVA: 0x0073D1F4 File Offset: 0x0073B3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			friendComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601943D RID: 103485 RVA: 0x0073D248 File Offset: 0x0073B448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			friendComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601943E RID: 103486 RVA: 0x0073D2A4 File Offset: 0x0073B4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			friendComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601943F RID: 103487 RVA: 0x0073D2F8 File Offset: 0x0073B4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Ban(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			DateTime banTime;
			LuaObject.checkValueType<DateTime>(l, 2, out banTime);
			friendComponent.m_luaExportHelper.__callBase_Ban(banTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019440 RID: 103488 RVA: 0x0073D354 File Offset: 0x0073B554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsBanned(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 2, out currentTime);
			bool b = friendComponent.m_luaExportHelper.__callBase_IsBanned(currentTime);
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

	// Token: 0x06019441 RID: 103489 RVA: 0x0073D3BC File Offset: 0x0073B5BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetBusinessCardInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			BusinessCardInfoSet setInfo;
			LuaObject.checkType<BusinessCardInfoSet>(l, 2, out setInfo);
			friendComponent.m_luaExportHelper.__callBase_SetBusinessCardInfo(setInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019442 RID: 103490 RVA: 0x0073D418 File Offset: 0x0073B618
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetLikes(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			int likes;
			LuaObject.checkType(l, 2, out likes);
			friendComponent.m_luaExportHelper.__callBase_SetLikes(likes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019443 RID: 103491 RVA: 0x0073D474 File Offset: 0x0073B674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanSendLikes(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponent.m_luaExportHelper.__callBase_CanSendLikes(targetUserId);
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

	// Token: 0x06019444 RID: 103492 RVA: 0x0073D4DC File Offset: 0x0073B6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddLikedUser(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			friendComponent.m_luaExportHelper.__callBase_AddLikedUser(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019445 RID: 103493 RVA: 0x0073D538 File Offset: 0x0073B738
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SendFriendshipPointsCheck(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponent.m_luaExportHelper.__callBase_SendFriendshipPointsCheck(targetUserId);
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

	// Token: 0x06019446 RID: 103494 RVA: 0x0073D5A0 File Offset: 0x0073B7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FilterInvalidSendFriendPointsTargets(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<string> targetUserIds;
			LuaObject.checkType<List<string>>(l, 2, out targetUserIds);
			List<string> o = friendComponent.m_luaExportHelper.__callBase_FilterInvalidSendFriendPointsTargets(targetUserIds);
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

	// Token: 0x06019447 RID: 103495 RVA: 0x0073D608 File Offset: 0x0073B808
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SendFriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponent.m_luaExportHelper.__callBase_SendFriendshipPoints(targetUserId);
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

	// Token: 0x06019448 RID: 103496 RVA: 0x0073D670 File Offset: 0x0073B870
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ReceiveFriendshipPointsFromFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponent.m_luaExportHelper.__callBase_ReceiveFriendshipPointsFromFriend(targetUserId);
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

	// Token: 0x06019449 RID: 103497 RVA: 0x0073D6D8 File Offset: 0x0073B8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClaimFriendshipPointsFromFriendCheck(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponent.m_luaExportHelper.__callBase_ClaimFriendshipPointsFromFriendCheck(targetUserId);
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

	// Token: 0x0601944A RID: 103498 RVA: 0x0073D740 File Offset: 0x0073B940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClaimFriendshipPointsFromFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponent.m_luaExportHelper.__callBase_ClaimFriendshipPointsFromFriend(targetUserId);
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

	// Token: 0x0601944B RID: 103499 RVA: 0x0073D7A8 File Offset: 0x0073B9A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClaimFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			int point;
			LuaObject.checkType(l, 2, out point);
			friendComponent.m_luaExportHelper.__callBase_ClaimFriendShipPoints(point);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601944C RID: 103500 RVA: 0x0073D804 File Offset: 0x0073BA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetFriendshipPointsFromFightWithFriendsToday(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			int i = friendComponent.m_luaExportHelper.__callBase_GetFriendshipPointsFromFightWithFriendsToday();
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

	// Token: 0x0601944D RID: 103501 RVA: 0x0073D860 File Offset: 0x0073BA60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddFriendshipPointsFromFightWithFriendsToday(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			int pointsToAdd;
			LuaObject.checkType(l, 2, out pointsToAdd);
			int i = friendComponent.m_luaExportHelper.__callBase_AddFriendshipPointsFromFightWithFriendsToday(pointsToAdd);
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

	// Token: 0x0601944E RID: 103502 RVA: 0x0073D8C8 File Offset: 0x0073BAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanUpdateBusinessCardDesc(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			int i = friendComponent.m_luaExportHelper.__callBase_CanUpdateBusinessCardDesc(desc);
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

	// Token: 0x0601944F RID: 103503 RVA: 0x0073D930 File Offset: 0x0073BB30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanUpdateBusinessCardHeroSets(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<BusinessCardHeroSet> heroSets;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 2, out heroSets);
			int i = friendComponent.m_luaExportHelper.__callBase_CanUpdateBusinessCardHeroSets(heroSets);
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

	// Token: 0x06019450 RID: 103504 RVA: 0x0073D998 File Offset: 0x0073BB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasSentFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = friendComponent.m_luaExportHelper.__callBase_HasSentFriendShipPoints(userId);
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

	// Token: 0x06019451 RID: 103505 RVA: 0x0073DA00 File Offset: 0x0073BC00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_HasReceivedFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = friendComponent.m_luaExportHelper.__callBase_HasReceivedFriendShipPoints(userId);
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

	// Token: 0x06019452 RID: 103506 RVA: 0x0073DA68 File Offset: 0x0073BC68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetBusinessCardDesc(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			friendComponent.m_luaExportHelper.__callBase_SetBusinessCardDesc(desc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019453 RID: 103507 RVA: 0x0073DAC4 File Offset: 0x0073BCC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetBusinessCardHeroSet(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<BusinessCardHeroSet> heroSets;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 2, out heroSets);
			friendComponent.m_luaExportHelper.__callBase_SetBusinessCardHeroSet(heroSets);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019454 RID: 103508 RVA: 0x0073DB20 File Offset: 0x0073BD20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetRandomHeroAction(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			bool actionRandom;
			LuaObject.checkType(l, 2, out actionRandom);
			friendComponent.m_luaExportHelper.__callBase_SetRandomHeroAction(actionRandom);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019455 RID: 103509 RVA: 0x0073DB7C File Offset: 0x0073BD7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RemoveFriendshipPointsReceivedUser(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			friendComponent.m_luaExportHelper.__callBase_RemoveFriendshipPointsReceivedUser(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019456 RID: 103510 RVA: 0x0073DBD8 File Offset: 0x0073BDD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetFriendshipPointsReceivedUsers(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<string> o = friendComponent.m_luaExportHelper.__callBase_GetFriendshipPointsReceivedUsers();
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

	// Token: 0x06019457 RID: 103511 RVA: 0x0073DC34 File Offset: 0x0073BE34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnInviteFriendSuccess(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			friendComponent.m_luaExportHelper.__callBase_OnInviteFriendSuccess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019458 RID: 103512 RVA: 0x0073DC88 File Offset: 0x0073BE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Friends(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponent.Friends);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019459 RID: 103513 RVA: 0x0073DCDC File Offset: 0x0073BEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Friends(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<UserSummary> friends;
			LuaObject.checkType<List<UserSummary>>(l, 2, out friends);
			friendComponent.Friends = friends;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601945A RID: 103514 RVA: 0x0073DD34 File Offset: 0x0073BF34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Blacklist(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponent.Blacklist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601945B RID: 103515 RVA: 0x0073DD88 File Offset: 0x0073BF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Blacklist(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<UserSummary> blacklist;
			LuaObject.checkType<List<UserSummary>>(l, 2, out blacklist);
			friendComponent.Blacklist = blacklist;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601945C RID: 103516 RVA: 0x0073DDE0 File Offset: 0x0073BFE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Invite(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponent.Invite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601945D RID: 103517 RVA: 0x0073DE34 File Offset: 0x0073C034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Invite(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<UserSummary> invite;
			LuaObject.checkType<List<UserSummary>>(l, 2, out invite);
			friendComponent.Invite = invite;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601945E RID: 103518 RVA: 0x0073DE8C File Offset: 0x0073C08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Invited(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponent.Invited);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601945F RID: 103519 RVA: 0x0073DEE0 File Offset: 0x0073C0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Invited(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<UserSummary> invited;
			LuaObject.checkType<List<UserSummary>>(l, 2, out invited);
			friendComponent.Invited = invited;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019460 RID: 103520 RVA: 0x0073DF38 File Offset: 0x0073C138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildPlayers(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponent.GuildPlayers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019461 RID: 103521 RVA: 0x0073DF8C File Offset: 0x0073C18C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GuildPlayers(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<UserSummary> guildPlayers;
			LuaObject.checkType<List<UserSummary>>(l, 2, out guildPlayers);
			friendComponent.GuildPlayers = guildPlayers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019462 RID: 103522 RVA: 0x0073DFE4 File Offset: 0x0073C1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RecentContactsChat(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponent.RecentContactsChat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019463 RID: 103523 RVA: 0x0073E038 File Offset: 0x0073C238
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RecentContactsChat(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<UserSummary> recentContactsChat;
			LuaObject.checkType<List<UserSummary>>(l, 2, out recentContactsChat);
			friendComponent.RecentContactsChat = recentContactsChat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019464 RID: 103524 RVA: 0x0073E090 File Offset: 0x0073C290
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RecentContactsTeamBattle(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponent.RecentContactsTeamBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019465 RID: 103525 RVA: 0x0073E0E4 File Offset: 0x0073C2E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RecentContactsTeamBattle(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<UserSummary> recentContactsTeamBattle;
			LuaObject.checkType<List<UserSummary>>(l, 2, out recentContactsTeamBattle);
			friendComponent.RecentContactsTeamBattle = recentContactsTeamBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019466 RID: 103526 RVA: 0x0073E13C File Offset: 0x0073C33C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PVPInviteInfos(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponent.PVPInviteInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019467 RID: 103527 RVA: 0x0073E190 File Offset: 0x0073C390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PVPInviteInfos(IntPtr l)
	{
		int result;
		try
		{
			FriendComponent friendComponent = (FriendComponent)LuaObject.checkSelf(l);
			List<PVPInviteInfo> pvpinviteInfos;
			LuaObject.checkType<List<PVPInviteInfo>>(l, 2, out pvpinviteInfos);
			friendComponent.PVPInviteInfos = pvpinviteInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019468 RID: 103528 RVA: 0x0073E1E8 File Offset: 0x0073C3E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.FriendComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.Deserialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.GetBusinessCardHeroes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.GetBusinessCardInfoSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.GetSendFriendShipPointsCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.GetClaimedFriendShipPointsCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.ReceivedFriendShipPointsCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.LoadFromPBData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_Ban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_IsBanned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_SetBusinessCardInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_SetLikes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_CanSendLikes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_AddLikedUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_SendFriendshipPointsCheck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_FilterInvalidSendFriendPointsTargets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_SendFriendshipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_ReceiveFriendshipPointsFromFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_ClaimFriendshipPointsFromFriendCheck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_ClaimFriendshipPointsFromFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_ClaimFriendShipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_GetFriendshipPointsFromFightWithFriendsToday);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_AddFriendshipPointsFromFightWithFriendsToday);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_CanUpdateBusinessCardDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_CanUpdateBusinessCardHeroSets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_HasSentFriendShipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_HasReceivedFriendShipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_SetBusinessCardDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_SetBusinessCardHeroSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_SetRandomHeroAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_RemoveFriendshipPointsReceivedUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_GetFriendshipPointsReceivedUsers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.__callBase_OnInviteFriendSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache29);
		string name = "Friends";
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.get_Friends);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.set_Friends);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2B, true);
		string name2 = "Blacklist";
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.get_Blacklist);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.set_Blacklist);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2D, true);
		string name3 = "Invite";
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.get_Invite);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.set_Invite);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache2F, true);
		string name4 = "Invited";
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.get_Invited);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.set_Invited);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache31, true);
		string name5 = "GuildPlayers";
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.get_GuildPlayers);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.set_GuildPlayers);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache33, true);
		string name6 = "RecentContactsChat";
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.get_RecentContactsChat);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.set_RecentContactsChat);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache35, true);
		string name7 = "RecentContactsTeamBattle";
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.get_RecentContactsTeamBattle);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.set_RecentContactsTeamBattle);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache37, true);
		string name8 = "PVPInviteInfos";
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.get_PVPInviteInfos);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.set_PVPInviteInfos);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache39, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_FriendComponent.<>f__mg$cache3A, typeof(FriendComponent), typeof(FriendComponentCommon));
	}

	// Token: 0x0400F88B RID: 63627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F88C RID: 63628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F88D RID: 63629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F88E RID: 63630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F88F RID: 63631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F890 RID: 63632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F891 RID: 63633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F892 RID: 63634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F893 RID: 63635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F894 RID: 63636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F895 RID: 63637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F896 RID: 63638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F897 RID: 63639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F898 RID: 63640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F899 RID: 63641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F89A RID: 63642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F89B RID: 63643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F89C RID: 63644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F89D RID: 63645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F89E RID: 63646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F89F RID: 63647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F8A0 RID: 63648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F8A1 RID: 63649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F8A2 RID: 63650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F8A3 RID: 63651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F8A4 RID: 63652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F8A5 RID: 63653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F8A6 RID: 63654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F8A7 RID: 63655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F8A8 RID: 63656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F8A9 RID: 63657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F8AA RID: 63658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F8AB RID: 63659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F8AC RID: 63660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F8AD RID: 63661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F8AE RID: 63662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F8AF RID: 63663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F8B0 RID: 63664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F8B1 RID: 63665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F8B2 RID: 63666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F8B3 RID: 63667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F8B4 RID: 63668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F8B5 RID: 63669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F8B6 RID: 63670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F8B7 RID: 63671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F8B8 RID: 63672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F8B9 RID: 63673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F8BA RID: 63674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F8BB RID: 63675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F8BC RID: 63676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F8BD RID: 63677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F8BE RID: 63678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F8BF RID: 63679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400F8C0 RID: 63680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400F8C1 RID: 63681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400F8C2 RID: 63682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400F8C3 RID: 63683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400F8C4 RID: 63684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400F8C5 RID: 63685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;
}
