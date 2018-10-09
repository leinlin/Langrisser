using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011FD RID: 4605
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionFriend : LuaObject
{
	// Token: 0x06017DFB RID: 97787 RVA: 0x00697F9C File Offset: 0x0069619C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend o = new DataSectionFriend();
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

	// Token: 0x06017DFC RID: 97788 RVA: 0x00697FE4 File Offset: 0x006961E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			dataSectionFriend.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DFD RID: 97789 RVA: 0x00698030 File Offset: 0x00696230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			object o = dataSectionFriend.SerializeToClient();
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

	// Token: 0x06017DFE RID: 97790 RVA: 0x00698084 File Offset: 0x00696284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBusinessCardInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			BusinessCardInfoSet businessCardInfo;
			LuaObject.checkType<BusinessCardInfoSet>(l, 2, out businessCardInfo);
			dataSectionFriend.SetBusinessCardInfo(businessCardInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DFF RID: 97791 RVA: 0x006980DC File Offset: 0x006962DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFlushOfTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			dataSectionFriend.OnFlushOfTime();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E00 RID: 97792 RVA: 0x00698128 File Offset: 0x00696328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearLikedUsers(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			dataSectionFriend.ClearLikedUsers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E01 RID: 97793 RVA: 0x00698174 File Offset: 0x00696374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLikes(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			int likes;
			LuaObject.checkType(l, 2, out likes);
			dataSectionFriend.SetLikes(likes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E02 RID: 97794 RVA: 0x006981CC File Offset: 0x006963CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddLikes(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			int addValue;
			LuaObject.checkType(l, 2, out addValue);
			int i = dataSectionFriend.AddLikes(addValue);
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

	// Token: 0x06017E03 RID: 97795 RVA: 0x00698230 File Offset: 0x00696430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddLikedUser(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			dataSectionFriend.AddLikedUser(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E04 RID: 97796 RVA: 0x00698288 File Offset: 0x00696488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFriendshipPointsReceivedUser(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			dataSectionFriend.AddFriendshipPointsReceivedUser(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E05 RID: 97797 RVA: 0x006982E0 File Offset: 0x006964E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveFriendshipPointsReceivedUser(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = dataSectionFriend.RemoveFriendshipPointsReceivedUser(userId);
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

	// Token: 0x06017E06 RID: 97798 RVA: 0x00698344 File Offset: 0x00696544
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveFriendshipPointsSentUser(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			bool b = dataSectionFriend.RemoveFriendshipPointsSentUser(userId);
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

	// Token: 0x06017E07 RID: 97799 RVA: 0x006983A8 File Offset: 0x006965A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFriendshipPointsSentUser(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			dataSectionFriend.AddFriendshipPointsSentUser(userId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E08 RID: 97800 RVA: 0x00698400 File Offset: 0x00696600
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBusinessCardDesc(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			string businessCardDesc;
			LuaObject.checkType(l, 2, out businessCardDesc);
			dataSectionFriend.SetBusinessCardDesc(businessCardDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E09 RID: 97801 RVA: 0x00698458 File Offset: 0x00696658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBusinessCardHeroSet(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			List<BusinessCardHeroSet> businessCardHeroSet;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 2, out businessCardHeroSet);
			dataSectionFriend.SetBusinessCardHeroSet(businessCardHeroSet);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E0A RID: 97802 RVA: 0x006984B0 File Offset: 0x006966B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomHeroAction(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			bool randomHeroAction;
			LuaObject.checkType(l, 2, out randomHeroAction);
			dataSectionFriend.SetRandomHeroAction(randomHeroAction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E0B RID: 97803 RVA: 0x00698508 File Offset: 0x00696708
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetFriendshipPointsFromFightWithFriendsToday(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			int friendshipPointsFromFightWithFriendsToday;
			LuaObject.checkType(l, 2, out friendshipPointsFromFightWithFriendsToday);
			dataSectionFriend.SetFriendshipPointsFromFightWithFriendsToday(friendshipPointsFromFightWithFriendsToday);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E0C RID: 97804 RVA: 0x00698560 File Offset: 0x00696760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFriendshipPointsClaimedToday(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			int friendshipPointsClaimedToday;
			LuaObject.checkType(l, 2, out friendshipPointsClaimedToday);
			dataSectionFriend.SetFriendshipPointsClaimedToday(friendshipPointsClaimedToday);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E0D RID: 97805 RVA: 0x006985B8 File Offset: 0x006967B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBanned(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 2, out currentTime);
			bool b = dataSectionFriend.IsBanned(currentTime);
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

	// Token: 0x06017E0E RID: 97806 RVA: 0x0069861C File Offset: 0x0069681C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Ban(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			DateTime banTime;
			LuaObject.checkValueType<DateTime>(l, 2, out banTime);
			dataSectionFriend.Ban(banTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E0F RID: 97807 RVA: 0x00698674 File Offset: 0x00696874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LikedUsers(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionFriend.LikedUsers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E10 RID: 97808 RVA: 0x006986C8 File Offset: 0x006968C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LikedUsers(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			List<string> likedUsers;
			LuaObject.checkType<List<string>>(l, 2, out likedUsers);
			dataSectionFriend.LikedUsers = likedUsers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E11 RID: 97809 RVA: 0x00698720 File Offset: 0x00696920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FriendshipPointsSent(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionFriend.FriendshipPointsSent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E12 RID: 97810 RVA: 0x00698774 File Offset: 0x00696974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FriendshipPointsSent(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			List<string> friendshipPointsSent;
			LuaObject.checkType<List<string>>(l, 2, out friendshipPointsSent);
			dataSectionFriend.FriendshipPointsSent = friendshipPointsSent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E13 RID: 97811 RVA: 0x006987CC File Offset: 0x006969CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FriendshipPointsReceived(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionFriend.FriendshipPointsReceived);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E14 RID: 97812 RVA: 0x00698820 File Offset: 0x00696A20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FriendshipPointsReceived(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			List<string> friendshipPointsReceived;
			LuaObject.checkType<List<string>>(l, 2, out friendshipPointsReceived);
			dataSectionFriend.FriendshipPointsReceived = friendshipPointsReceived;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E15 RID: 97813 RVA: 0x00698878 File Offset: 0x00696A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BannedTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionFriend.BannedTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E16 RID: 97814 RVA: 0x006988D0 File Offset: 0x00696AD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BannedTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			DateTime bannedTime;
			LuaObject.checkValueType<DateTime>(l, 2, out bannedTime);
			dataSectionFriend.BannedTime = bannedTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E17 RID: 97815 RVA: 0x00698928 File Offset: 0x00696B28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BusinessCardSetInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionFriend.BusinessCardSetInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E18 RID: 97816 RVA: 0x0069897C File Offset: 0x00696B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BusinessCardSetInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			BusinessCardInfoSet businessCardSetInfo;
			LuaObject.checkType<BusinessCardInfoSet>(l, 2, out businessCardSetInfo);
			dataSectionFriend.BusinessCardSetInfo = businessCardSetInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E19 RID: 97817 RVA: 0x006989D4 File Offset: 0x00696BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Likes(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionFriend.Likes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E1A RID: 97818 RVA: 0x00698A28 File Offset: 0x00696C28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Likes(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			int likes;
			LuaObject.checkType(l, 2, out likes);
			dataSectionFriend.Likes = likes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E1B RID: 97819 RVA: 0x00698A80 File Offset: 0x00696C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FriendshipPointsFromFightWithFriendsToday(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionFriend.FriendshipPointsFromFightWithFriendsToday);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E1C RID: 97820 RVA: 0x00698AD4 File Offset: 0x00696CD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FriendshipPointsFromFightWithFriendsToday(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			int friendshipPointsFromFightWithFriendsToday;
			LuaObject.checkType(l, 2, out friendshipPointsFromFightWithFriendsToday);
			dataSectionFriend.FriendshipPointsFromFightWithFriendsToday = friendshipPointsFromFightWithFriendsToday;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E1D RID: 97821 RVA: 0x00698B2C File Offset: 0x00696D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FriendshipPointsClaimedToday(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionFriend.FriendshipPointsClaimedToday);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E1E RID: 97822 RVA: 0x00698B80 File Offset: 0x00696D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FriendshipPointsClaimedToday(IntPtr l)
	{
		int result;
		try
		{
			DataSectionFriend dataSectionFriend = (DataSectionFriend)LuaObject.checkSelf(l);
			int friendshipPointsClaimedToday;
			LuaObject.checkType(l, 2, out friendshipPointsClaimedToday);
			dataSectionFriend.FriendshipPointsClaimedToday = friendshipPointsClaimedToday;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017E1F RID: 97823 RVA: 0x00698BD8 File Offset: 0x00696DD8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionFriend");
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.SetBusinessCardInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.OnFlushOfTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.ClearLikedUsers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.SetLikes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.AddLikes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.AddLikedUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.AddFriendshipPointsReceivedUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.RemoveFriendshipPointsReceivedUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.RemoveFriendshipPointsSentUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.AddFriendshipPointsSentUser);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.SetBusinessCardDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.SetBusinessCardHeroSet);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.SetRandomHeroAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.SetFriendshipPointsFromFightWithFriendsToday);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.SetFriendshipPointsClaimedToday);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.IsBanned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.Ban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache12);
		string name = "LikedUsers";
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.get_LikedUsers);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.set_LikedUsers);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache14, true);
		string name2 = "FriendshipPointsSent";
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.get_FriendshipPointsSent);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.set_FriendshipPointsSent);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache16, true);
		string name3 = "FriendshipPointsReceived";
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.get_FriendshipPointsReceived);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.set_FriendshipPointsReceived);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache18, true);
		string name4 = "BannedTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.get_BannedTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.set_BannedTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1A, true);
		string name5 = "BusinessCardSetInfo";
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.get_BusinessCardSetInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.set_BusinessCardSetInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1C, true);
		string name6 = "Likes";
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.get_Likes);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.set_Likes);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1E, true);
		string name7 = "FriendshipPointsFromFightWithFriendsToday";
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.get_FriendshipPointsFromFightWithFriendsToday);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.set_FriendshipPointsFromFightWithFriendsToday);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache20, true);
		string name8 = "FriendshipPointsClaimedToday";
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.get_FriendshipPointsClaimedToday);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.set_FriendshipPointsClaimedToday);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache22, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionFriend.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionFriend.<>f__mg$cache23, typeof(DataSectionFriend), typeof(DataSection));
	}

	// Token: 0x0400E3E3 RID: 58339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E3E4 RID: 58340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E3E5 RID: 58341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E3E6 RID: 58342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E3E7 RID: 58343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E3E8 RID: 58344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E3E9 RID: 58345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E3EA RID: 58346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E3EB RID: 58347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E3EC RID: 58348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E3ED RID: 58349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E3EE RID: 58350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E3EF RID: 58351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E3F0 RID: 58352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E3F1 RID: 58353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E3F2 RID: 58354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E3F3 RID: 58355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E3F4 RID: 58356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E3F5 RID: 58357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E3F6 RID: 58358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E3F7 RID: 58359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E3F8 RID: 58360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E3F9 RID: 58361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E3FA RID: 58362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E3FB RID: 58363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E3FC RID: 58364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E3FD RID: 58365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E3FE RID: 58366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E3FF RID: 58367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E400 RID: 58368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E401 RID: 58369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E402 RID: 58370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E403 RID: 58371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E404 RID: 58372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E405 RID: 58373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E406 RID: 58374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
