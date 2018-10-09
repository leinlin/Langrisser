using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001220 RID: 4640
[Preserve]
public class Lua_BlackJack_ProjectL_Common_FriendComponentCommon : LuaObject
{
	// Token: 0x06018106 RID: 98566 RVA: 0x006AE064 File Offset: 0x006AC264
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon o = new FriendComponentCommon();
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

	// Token: 0x06018107 RID: 98567 RVA: 0x006AE0AC File Offset: 0x006AC2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string name = friendComponentCommon.GetName();
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

	// Token: 0x06018108 RID: 98568 RVA: 0x006AE100 File Offset: 0x006AC300
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			friendComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018109 RID: 98569 RVA: 0x006AE14C File Offset: 0x006AC34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			friendComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601810A RID: 98570 RVA: 0x006AE198 File Offset: 0x006AC398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			friendComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601810B RID: 98571 RVA: 0x006AE1E4 File Offset: 0x006AC3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			friendComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601810C RID: 98572 RVA: 0x006AE23C File Offset: 0x006AC43C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			friendComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601810D RID: 98573 RVA: 0x006AE288 File Offset: 0x006AC488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Ban(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			DateTime banTime;
			LuaObject.checkValueType<DateTime>(l, 2, out banTime);
			friendComponentCommon.Ban(banTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601810E RID: 98574 RVA: 0x006AE2E0 File Offset: 0x006AC4E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBanned(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 2, out currentTime);
			bool b = friendComponentCommon.IsBanned(currentTime);
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

	// Token: 0x0601810F RID: 98575 RVA: 0x006AE344 File Offset: 0x006AC544
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBusinessCardInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			BusinessCardInfoSet businessCardInfo;
			LuaObject.checkType<BusinessCardInfoSet>(l, 2, out businessCardInfo);
			friendComponentCommon.SetBusinessCardInfo(businessCardInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018110 RID: 98576 RVA: 0x006AE39C File Offset: 0x006AC59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLikes(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			int likes;
			LuaObject.checkType(l, 2, out likes);
			friendComponentCommon.SetLikes(likes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018111 RID: 98577 RVA: 0x006AE3F4 File Offset: 0x006AC5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSendLikes(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponentCommon.CanSendLikes(targetUserId);
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

	// Token: 0x06018112 RID: 98578 RVA: 0x006AE458 File Offset: 0x006AC658
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddLikedUser(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			friendComponentCommon.AddLikedUser(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018113 RID: 98579 RVA: 0x006AE4B0 File Offset: 0x006AC6B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SendFriendshipPointsCheck(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponentCommon.SendFriendshipPointsCheck(targetUserId);
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

	// Token: 0x06018114 RID: 98580 RVA: 0x006AE514 File Offset: 0x006AC714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FilterInvalidSendFriendPointsTargets(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			List<string> targetUserIds;
			LuaObject.checkType<List<string>>(l, 2, out targetUserIds);
			List<string> o = friendComponentCommon.FilterInvalidSendFriendPointsTargets(targetUserIds);
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

	// Token: 0x06018115 RID: 98581 RVA: 0x006AE578 File Offset: 0x006AC778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendFriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponentCommon.SendFriendshipPoints(targetUserId);
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

	// Token: 0x06018116 RID: 98582 RVA: 0x006AE5DC File Offset: 0x006AC7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReceiveFriendshipPointsFromFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponentCommon.ReceiveFriendshipPointsFromFriend(targetUserId);
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

	// Token: 0x06018117 RID: 98583 RVA: 0x006AE640 File Offset: 0x006AC840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClaimFriendshipPointsFromFriendCheck(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponentCommon.ClaimFriendshipPointsFromFriendCheck(targetUserId);
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

	// Token: 0x06018118 RID: 98584 RVA: 0x006AE6A4 File Offset: 0x006AC8A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClaimFriendshipPointsFromFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string targetUserId;
			LuaObject.checkType(l, 2, out targetUserId);
			int i = friendComponentCommon.ClaimFriendshipPointsFromFriend(targetUserId);
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

	// Token: 0x06018119 RID: 98585 RVA: 0x006AE708 File Offset: 0x006AC908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClaimFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			int point;
			LuaObject.checkType(l, 2, out point);
			friendComponentCommon.ClaimFriendShipPoints(point);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601811A RID: 98586 RVA: 0x006AE760 File Offset: 0x006AC960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFriendshipPointsFromFightWithFriendsToday(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			int friendshipPointsFromFightWithFriendsToday = friendComponentCommon.GetFriendshipPointsFromFightWithFriendsToday();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendshipPointsFromFightWithFriendsToday);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601811B RID: 98587 RVA: 0x006AE7B4 File Offset: 0x006AC9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFriendshipPointsFromFightWithFriendsToday(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			int pointsToAdd;
			LuaObject.checkType(l, 2, out pointsToAdd);
			int i = friendComponentCommon.AddFriendshipPointsFromFightWithFriendsToday(pointsToAdd);
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

	// Token: 0x0601811C RID: 98588 RVA: 0x006AE818 File Offset: 0x006ACA18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanUpdateBusinessCardDesc(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			int i = friendComponentCommon.CanUpdateBusinessCardDesc(desc);
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

	// Token: 0x0601811D RID: 98589 RVA: 0x006AE87C File Offset: 0x006ACA7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanUpdateBusinessCardHeroSets(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			List<BusinessCardHeroSet> heroSets;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 2, out heroSets);
			int i = friendComponentCommon.CanUpdateBusinessCardHeroSets(heroSets);
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

	// Token: 0x0601811E RID: 98590 RVA: 0x006AE8E0 File Offset: 0x006ACAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasSentFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = friendComponentCommon.HasSentFriendShipPoints(userId);
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

	// Token: 0x0601811F RID: 98591 RVA: 0x006AE944 File Offset: 0x006ACB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasReceivedFriendShipPoints(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = friendComponentCommon.HasReceivedFriendShipPoints(userId);
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

	// Token: 0x06018120 RID: 98592 RVA: 0x006AE9A8 File Offset: 0x006ACBA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBusinessCardDesc(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string businessCardDesc;
			LuaObject.checkType(l, 2, out businessCardDesc);
			friendComponentCommon.SetBusinessCardDesc(businessCardDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018121 RID: 98593 RVA: 0x006AEA00 File Offset: 0x006ACC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBusinessCardHeroSet(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			List<BusinessCardHeroSet> businessCardHeroSet;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 2, out businessCardHeroSet);
			friendComponentCommon.SetBusinessCardHeroSet(businessCardHeroSet);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018122 RID: 98594 RVA: 0x006AEA58 File Offset: 0x006ACC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomHeroAction(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			bool randomHeroAction;
			LuaObject.checkType(l, 2, out randomHeroAction);
			friendComponentCommon.SetRandomHeroAction(randomHeroAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018123 RID: 98595 RVA: 0x006AEAB0 File Offset: 0x006ACCB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveFriendshipPointsReceivedUser(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			friendComponentCommon.RemoveFriendshipPointsReceivedUser(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018124 RID: 98596 RVA: 0x006AEB08 File Offset: 0x006ACD08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetFriendshipPointsReceivedUsers(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			List<string> friendshipPointsReceivedUsers = friendComponentCommon.GetFriendshipPointsReceivedUsers();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendshipPointsReceivedUsers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018125 RID: 98597 RVA: 0x006AEB5C File Offset: 0x006ACD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInviteFriendSuccess(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			friendComponentCommon.OnInviteFriendSuccess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018126 RID: 98598 RVA: 0x006AEBA8 File Offset: 0x006ACDA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFlushFriend(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			friendComponentCommon.m_luaExportHelper.OnFlushFriend();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018127 RID: 98599 RVA: 0x006AEBFC File Offset: 0x006ACDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMySelf(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = friendComponentCommon.m_luaExportHelper.IsMySelf(userId);
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

	// Token: 0x06018128 RID: 98600 RVA: 0x006AEC64 File Offset: 0x006ACE64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasSendLikesToday(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = friendComponentCommon.m_luaExportHelper.HasSendLikesToday(userId);
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

	// Token: 0x06018129 RID: 98601 RVA: 0x006AECCC File Offset: 0x006ACECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_InviteFriendMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			friendComponentCommon.m_luaExportHelper.__callDele_InviteFriendMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601812A RID: 98602 RVA: 0x006AED20 File Offset: 0x006ACF20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_InviteFriendMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			friendComponentCommon.m_luaExportHelper.__clearDele_InviteFriendMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601812B RID: 98603 RVA: 0x006AED74 File Offset: 0x006ACF74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601812C RID: 98604 RVA: 0x006AEDCC File Offset: 0x006ACFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			friendComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601812D RID: 98605 RVA: 0x006AEE28 File Offset: 0x006AD028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601812E RID: 98606 RVA: 0x006AEE80 File Offset: 0x006AD080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			friendComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601812F RID: 98607 RVA: 0x006AEEDC File Offset: 0x006AD0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018130 RID: 98608 RVA: 0x006AEF34 File Offset: 0x006AD134
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			friendComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018131 RID: 98609 RVA: 0x006AEF90 File Offset: 0x006AD190
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018132 RID: 98610 RVA: 0x006AEFE8 File Offset: 0x006AD1E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			friendComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018133 RID: 98611 RVA: 0x006AF044 File Offset: 0x006AD244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_friendDS(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponentCommon.m_luaExportHelper.m_friendDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018134 RID: 98612 RVA: 0x006AF09C File Offset: 0x006AD29C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_friendDS(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			DataSectionFriend friendDS;
			LuaObject.checkType<DataSectionFriend>(l, 2, out friendDS);
			friendComponentCommon.m_luaExportHelper.m_friendDS = friendDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018135 RID: 98613 RVA: 0x006AF0F8 File Offset: 0x006AD2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_InviteFriendMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					friendComponentCommon.InviteFriendMissionEvent += value;
				}
				else if (num == 2)
				{
					friendComponentCommon.InviteFriendMissionEvent -= value;
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

	// Token: 0x06018136 RID: 98614 RVA: 0x006AF178 File Offset: 0x006AD378
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, friendComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018137 RID: 98615 RVA: 0x006AF1CC File Offset: 0x006AD3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			FriendComponentCommon friendComponentCommon = (FriendComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			friendComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018138 RID: 98616 RVA: 0x006AF224 File Offset: 0x006AD424
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.FriendComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.Ban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.IsBanned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.SetBusinessCardInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.SetLikes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.CanSendLikes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.AddLikedUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.SendFriendshipPointsCheck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.FilterInvalidSendFriendPointsTargets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.SendFriendshipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.ReceiveFriendshipPointsFromFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.ClaimFriendshipPointsFromFriendCheck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.ClaimFriendshipPointsFromFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.ClaimFriendShipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.GetFriendshipPointsFromFightWithFriendsToday);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.AddFriendshipPointsFromFightWithFriendsToday);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.CanUpdateBusinessCardDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.CanUpdateBusinessCardHeroSets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.HasSentFriendShipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.HasReceivedFriendShipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.SetBusinessCardDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.SetBusinessCardHeroSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.SetRandomHeroAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.RemoveFriendshipPointsReceivedUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.GetFriendshipPointsReceivedUsers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.OnInviteFriendSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.OnFlushFriend);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.IsMySelf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.HasSendLikesToday);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.__callDele_InviteFriendMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.__clearDele_InviteFriendMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache23);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache25, true);
		string name2 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache27, true);
		string name3 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.get_m_hero);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache29, true);
		string name4 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.get_m_bag);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2B, true);
		string name5 = "m_friendDS";
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.get_m_friendDS);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.set_m_friendDS);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2D, true);
		string name6 = "InviteFriendMissionEvent";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.set_InviteFriendMissionEvent);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2E, true);
		string name7 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.get_Owner);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache30, true);
		if (Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_FriendComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_FriendComponentCommon.<>f__mg$cache31, typeof(FriendComponentCommon));
	}

	// Token: 0x0400E6A8 RID: 59048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E6A9 RID: 59049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E6AA RID: 59050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E6AB RID: 59051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E6AC RID: 59052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E6AD RID: 59053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E6AE RID: 59054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E6AF RID: 59055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E6B0 RID: 59056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E6B1 RID: 59057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E6B2 RID: 59058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E6B3 RID: 59059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E6B4 RID: 59060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E6B5 RID: 59061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E6B6 RID: 59062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E6B7 RID: 59063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E6B8 RID: 59064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E6B9 RID: 59065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E6BA RID: 59066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E6BB RID: 59067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E6BC RID: 59068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E6BD RID: 59069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E6BE RID: 59070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E6BF RID: 59071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E6C0 RID: 59072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E6C1 RID: 59073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E6C2 RID: 59074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E6C3 RID: 59075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E6C4 RID: 59076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E6C5 RID: 59077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E6C6 RID: 59078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E6C7 RID: 59079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E6C8 RID: 59080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E6C9 RID: 59081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E6CA RID: 59082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E6CB RID: 59083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E6CC RID: 59084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E6CD RID: 59085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E6CE RID: 59086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E6CF RID: 59087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E6D0 RID: 59088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E6D1 RID: 59089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E6D2 RID: 59090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400E6D3 RID: 59091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400E6D4 RID: 59092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400E6D5 RID: 59093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400E6D6 RID: 59094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400E6D7 RID: 59095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400E6D8 RID: 59096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400E6D9 RID: 59097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;
}
