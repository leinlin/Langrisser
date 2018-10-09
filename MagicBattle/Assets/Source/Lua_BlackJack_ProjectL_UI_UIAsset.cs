using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015BF RID: 5567
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UIAsset : LuaObject
{
	// Token: 0x06021D7A RID: 138618 RVA: 0x00B822B8 File Offset: 0x00B804B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UIAsset o = new UIAsset();
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

	// Token: 0x06021D7B RID: 138619 RVA: 0x00B82300 File Offset: 0x00B80500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UISpineMaterial(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Material/UISpine.mat");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D7C RID: 138620 RVA: 0x00B82348 File Offset: 0x00B80548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UISpine2Material(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Material/UISpine2.mat");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D7D RID: 138621 RVA: 0x00B82390 File Offset: 0x00B80590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UISpineMaterial_SepAlpha(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Material/UISpine_SepAlpha.mat");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D7E RID: 138622 RVA: 0x00B823D8 File Offset: 0x00B805D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UISpine2Material_SepAlpha(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Material/UISpine2_SepAlpha.mat");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D7F RID: 138623 RVA: 0x00B82420 File Offset: 0x00B80620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroFragmentIconMaterial(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Piece_ABS/Material/PieceIcon.mat");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D80 RID: 138624 RVA: 0x00B82468 File Offset: 0x00B80668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroSummonIconMaterial(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Card_ABS/Material/CardIcon.mat");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D81 RID: 138625 RVA: 0x00B824B0 File Offset: 0x00B806B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroSkinIconMaterial(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/HeroSkin_ABS/Material/HeroSkinIcon.mat");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D82 RID: 138626 RVA: 0x00B824F8 File Offset: 0x00B806F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierSkinIconMaterial(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/SoldierSkin_ABS/Material/SoldierSkinIcon.mat");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D83 RID: 138627 RVA: 0x00B82540 File Offset: 0x00B80740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamIcon0(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon/Bead_Blue.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D84 RID: 138628 RVA: 0x00B82588 File Offset: 0x00B80788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamIcon1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon/Bead_Green.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D85 RID: 138629 RVA: 0x00B825D0 File Offset: 0x00B807D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HpBar0(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Pattern_Blood_Green.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D86 RID: 138630 RVA: 0x00B82618 File Offset: 0x00B80818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HpBar1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Pattern_Blood_Red.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D87 RID: 138631 RVA: 0x00B82660 File Offset: 0x00B80860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HpBarNpc(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Pattern_Blood_Blue.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D88 RID: 138632 RVA: 0x00B826A8 File Offset: 0x00B808A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActorInfoHpBar0(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Pattern_Blood_Green01.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D89 RID: 138633 RVA: 0x00B826F0 File Offset: 0x00B808F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorInfoHpBar1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Pattern_Blood_Red01.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D8A RID: 138634 RVA: 0x00B82738 File Offset: 0x00B80938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePlayerTag1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Word_1P.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D8B RID: 138635 RVA: 0x00B82780 File Offset: 0x00B80980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePlayerTag2(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Word_2P.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D8C RID: 138636 RVA: 0x00B827C8 File Offset: 0x00B809C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePlayerTag3(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Word_3P.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D8D RID: 138637 RVA: 0x00B82810 File Offset: 0x00B80A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoldIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Item_ABS/Item_Gold.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D8E RID: 138638 RVA: 0x00B82858 File Offset: 0x00B80A58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ExpIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Item_ABS/Item_PlayerExp.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D8F RID: 138639 RVA: 0x00B828A0 File Offset: 0x00B80AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CrystalIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Item_ABS/Item_MagicCrystal.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D90 RID: 138640 RVA: 0x00B828E8 File Offset: 0x00B80AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergyIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Item_ABS/Item_Bread.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D91 RID: 138641 RVA: 0x00B82930 File Offset: 0x00B80B30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FriendShipPointIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon/Icon_Friendship_1.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D92 RID: 138642 RVA: 0x00B82978 File Offset: 0x00B80B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaTicketIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Item_ABS/Item_PVPTicket.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D93 RID: 138643 RVA: 0x00B829C0 File Offset: 0x00B80BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaHonourIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Item_ABS/Item_PvpCoin.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D94 RID: 138644 RVA: 0x00B82A08 File Offset: 0x00B80C08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SkinTicketIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Item_ABS/Item_ETicket-God.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D95 RID: 138645 RVA: 0x00B82A50 File Offset: 0x00B80C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MemoryEssenceIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Item_ABS/Item_MemoryEssence.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D96 RID: 138646 RVA: 0x00B82A98 File Offset: 0x00B80C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MithralStoneIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Item_ABS/Icon_DragonScale_01.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D97 RID: 138647 RVA: 0x00B82AE0 File Offset: 0x00B80CE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BrillianceMithralStoneIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Icon/Item_ABS/Icon_DragonScale_02.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D98 RID: 138648 RVA: 0x00B82B28 File Offset: 0x00B80D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuildMedalIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon/Icon_GuildCoin.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D99 RID: 138649 RVA: 0x00B82B70 File Offset: 0x00B80D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemIconRank0Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Border_Icon_Copper.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D9A RID: 138650 RVA: 0x00B82BB8 File Offset: 0x00B80DB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ItemIconRank1Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Border_Icon_Copper.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D9B RID: 138651 RVA: 0x00B82C00 File Offset: 0x00B80E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemIconRank2Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Border_Icon_Silver.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D9C RID: 138652 RVA: 0x00B82C48 File Offset: 0x00B80E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemIconRank3Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Border_Icon_Gold.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D9D RID: 138653 RVA: 0x00B82C90 File Offset: 0x00B80E90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ItemIconRank4Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Border_Icon_Colour.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D9E RID: 138654 RVA: 0x00B82CD8 File Offset: 0x00B80ED8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ItemIconRank5Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Border_Icon_Colour.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021D9F RID: 138655 RVA: 0x00B82D20 File Offset: 0x00B80F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemIconRank9Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Border_Icon_Gray.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DA0 RID: 138656 RVA: 0x00B82D68 File Offset: 0x00B80F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankNImage(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Rank_N.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DA1 RID: 138657 RVA: 0x00B82DB0 File Offset: 0x00B80FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankRImage(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Rank_R.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DA2 RID: 138658 RVA: 0x00B82DF8 File Offset: 0x00B80FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankSRImage(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Rank_SR.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DA3 RID: 138659 RVA: 0x00B82E40 File Offset: 0x00B81040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankSSRImage(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Rank_SSR.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DA4 RID: 138660 RVA: 0x00B82E88 File Offset: 0x00B81088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierRank1Image(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Word_1.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DA5 RID: 138661 RVA: 0x00B82ED0 File Offset: 0x00B810D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierRank2Image(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Word_2.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DA6 RID: 138662 RVA: 0x00B82F18 File Offset: 0x00B81118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierRank3Image(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Word_3.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DA7 RID: 138663 RVA: 0x00B82F60 File Offset: 0x00B81160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PropertyRankSIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Font_S.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DA8 RID: 138664 RVA: 0x00B82FA8 File Offset: 0x00B811A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PropertyRankAIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Font_A.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DA9 RID: 138665 RVA: 0x00B82FF0 File Offset: 0x00B811F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PropertyRankBIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Font_B.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DAA RID: 138666 RVA: 0x00B83038 File Offset: 0x00B81238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PropertyRankCIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Font_C.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DAB RID: 138667 RVA: 0x00B83080 File Offset: 0x00B81280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PropertyRankDIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Font_D.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DAC RID: 138668 RVA: 0x00B830C8 File Offset: 0x00B812C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PropertyRankEIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Font/Font_E.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DAD RID: 138669 RVA: 0x00B83110 File Offset: 0x00B81310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroListRank1Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/HeadFrame_ABS/Card_Thumbnail_04.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DAE RID: 138670 RVA: 0x00B83158 File Offset: 0x00B81358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroListRank2Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/HeadFrame_ABS/Card_Thumbnail_03.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DAF RID: 138671 RVA: 0x00B831A0 File Offset: 0x00B813A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroListRank3Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/HeadFrame_ABS/Card_Thumbnail_02.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DB0 RID: 138672 RVA: 0x00B831E8 File Offset: 0x00B813E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroListRank4Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/HeadFrame_ABS/Card_Thumbnail_01.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DB1 RID: 138673 RVA: 0x00B83230 File Offset: 0x00B81430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroListRank5Frame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/HeadFrame_ABS/Card_Thumbnail_01.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DB2 RID: 138674 RVA: 0x00B83278 File Offset: 0x00B81478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroJobTransferRank1Img(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/JobTransfer_ABS/Pattern_Job_01.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DB3 RID: 138675 RVA: 0x00B832C0 File Offset: 0x00B814C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroJobTransferRank2Img(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/JobTransfer_ABS/Pattern_Job_02.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DB4 RID: 138676 RVA: 0x00B83308 File Offset: 0x00B81508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroJobTransferRank3Img(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/JobTransfer_ABS/Pattern_Job_03.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DB5 RID: 138677 RVA: 0x00B83350 File Offset: 0x00B81550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroJobTransferRank4Img(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/JobTransfer_ABS/Pattern_Job_04.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DB6 RID: 138678 RVA: 0x00B83398 File Offset: 0x00B81598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroJobTransferRank5Img(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/JobTransfer_ABS/Pattern_Job_05.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DB7 RID: 138679 RVA: 0x00B833E0 File Offset: 0x00B815E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroJobTransferValUp(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon_Up.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DB8 RID: 138680 RVA: 0x00B83428 File Offset: 0x00B81628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroJobTransferValSame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon_Minus.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DB9 RID: 138681 RVA: 0x00B83470 File Offset: 0x00B81670
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroJobTransferValDown(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon_Down.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DBA RID: 138682 RVA: 0x00B834B8 File Offset: 0x00B816B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Ranking1Image(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon/Icon_One.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DBB RID: 138683 RVA: 0x00B83500 File Offset: 0x00B81700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Ranking2Image(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon/Icon_Two.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DBC RID: 138684 RVA: 0x00B83548 File Offset: 0x00B81748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Ranking3Image(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon/Icon_Three.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DBD RID: 138685 RVA: 0x00B83590 File Offset: 0x00B81790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActivityPlusIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon/Icon_Plus_01.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DBE RID: 138686 RVA: 0x00B835D8 File Offset: 0x00B817D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActivityEqualIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Icon/Icon_Equal_01.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DBF RID: 138687 RVA: 0x00B83620 File Offset: 0x00B81820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActivityIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Activity_ABS/Icon_activity.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DC0 RID: 138688 RVA: 0x00B83668 File Offset: 0x00B81868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AnnouncementIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Activity_ABS/Icon_Repair.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DC1 RID: 138689 RVA: 0x00B836B0 File Offset: 0x00B818B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoginNoticeLabel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Login_ABS/Label_Notice.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DC2 RID: 138690 RVA: 0x00B836F8 File Offset: 0x00B818F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoginActivityLabel(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Login_ABS/Label_Activity.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DC3 RID: 138691 RVA: 0x00B83740 File Offset: 0x00B81940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TouchHitFx(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/UI_ABS/UI_Fx/U_click_down.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DC4 RID: 138692 RVA: 0x00B83788 File Offset: 0x00B81988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TouchHitFx2(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/UI_ABS/UI_Fx/U_click_down.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DC5 RID: 138693 RVA: 0x00B837D0 File Offset: 0x00B819D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TouchLoopFx(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/UI_ABS/UI_Fx/U_click.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DC6 RID: 138694 RVA: 0x00B83818 File Offset: 0x00B81A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TouchLoopFx2(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/UI_ABS/UI_Fx/U_click_open.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DC7 RID: 138695 RVA: 0x00B83860 File Offset: 0x00B81A60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HPBreakFxLarge(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/UI_ABS/UIFX_HPBarBreak_L_Pfb.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DC8 RID: 138696 RVA: 0x00B838A8 File Offset: 0x00B81AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HPBreakFxSmall(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "FX/UI_ABS/UIFX_HPBarBreak_S_Pfb.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DC9 RID: 138697 RVA: 0x00B838F0 File Offset: 0x00B81AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TreasureMapCharSpine1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Spine/General/Goblin_ABS/Goblin_1_Prefab.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DCA RID: 138698 RVA: 0x00B83938 File Offset: 0x00B81B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TreasureMapCharSpine2(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Spine/General/Goblin_ABS/Goblin_2_Prefab.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DCB RID: 138699 RVA: 0x00B83980 File Offset: 0x00B81B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TreasureMapCharSpine3(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Spine/General/Goblin_ABS/Goblin_3_Prefab.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DCC RID: 138700 RVA: 0x00B839C8 File Offset: 0x00B81BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TreasureMapCharSpine4(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Spine/General/Goblin_ABS/Goblin_4_Prefab.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DCD RID: 138701 RVA: 0x00B83A10 File Offset: 0x00B81C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StorePrivilegeIconFrame(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Common_New_ABS/Border_Icon_Colour.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DCE RID: 138702 RVA: 0x00B83A58 File Offset: 0x00B81C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DrillBgSlot0(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Drill_ABS/1/1.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DCF RID: 138703 RVA: 0x00B83AA0 File Offset: 0x00B81CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DrillBgSlot1(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Drill_ABS/1/2.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DD0 RID: 138704 RVA: 0x00B83AE8 File Offset: 0x00B81CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DrillBgSlot2(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/Drill_ABS/1/3.png");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DD1 RID: 138705 RVA: 0x00B83B30 File Offset: 0x00B81D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoldNumbers(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIAsset.GoldNumbers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DD2 RID: 138706 RVA: 0x00B83B78 File Offset: 0x00B81D78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ServerStateSpritePath(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UIAsset.ServerStateSpritePath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DD3 RID: 138707 RVA: 0x00B83BC0 File Offset: 0x00B81DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DialogBox(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/DialogBox.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DD4 RID: 138708 RVA: 0x00B83C08 File Offset: 0x00B81E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RealtimePVPNoticePrefab(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "UI/UserGuide_ABS/Prefab/UserGuide_17UIPrefab.prefab");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021DD5 RID: 138709 RVA: 0x00B83C50 File Offset: 0x00B81E50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UIAsset");
		string name = "UISpineMaterial";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_UISpineMaterial);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache0, null, false);
		string name2 = "UISpine2Material";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_UISpine2Material);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1, null, false);
		string name3 = "UISpineMaterial_SepAlpha";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_UISpineMaterial_SepAlpha);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2, null, false);
		string name4 = "UISpine2Material_SepAlpha";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_UISpine2Material_SepAlpha);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3, null, false);
		string name5 = "HeroFragmentIconMaterial";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroFragmentIconMaterial);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4, null, false);
		string name6 = "HeroSummonIconMaterial";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroSummonIconMaterial);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache5, null, false);
		string name7 = "HeroSkinIconMaterial";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroSkinIconMaterial);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache6, null, false);
		string name8 = "SoldierSkinIconMaterial";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_SoldierSkinIconMaterial);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache7, null, false);
		string name9 = "TeamIcon0";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_TeamIcon0);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache8, null, false);
		string name10 = "TeamIcon1";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_TeamIcon1);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache9, null, false);
		string name11 = "HpBar0";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HpBar0);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheA, null, false);
		string name12 = "HpBar1";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HpBar1);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheB, null, false);
		string name13 = "HpBarNpc";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HpBarNpc);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheC, null, false);
		string name14 = "ActorInfoHpBar0";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ActorInfoHpBar0);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheD, null, false);
		string name15 = "ActorInfoHpBar1";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ActorInfoHpBar1);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheE, null, false);
		string name16 = "BattlePlayerTag1";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_BattlePlayerTag1);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cacheF, null, false);
		string name17 = "BattlePlayerTag2";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_BattlePlayerTag2);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache10, null, false);
		string name18 = "BattlePlayerTag3";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_BattlePlayerTag3);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache11, null, false);
		string name19 = "GoldIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_GoldIcon);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache12, null, false);
		string name20 = "ExpIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ExpIcon);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache13, null, false);
		string name21 = "CrystalIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_CrystalIcon);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache14, null, false);
		string name22 = "EnergyIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_EnergyIcon);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache15, null, false);
		string name23 = "FriendShipPointIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_FriendShipPointIcon);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache16, null, false);
		string name24 = "ArenaTicketIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ArenaTicketIcon);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache17, null, false);
		string name25 = "ArenaHonourIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ArenaHonourIcon);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache18, null, false);
		string name26 = "SkinTicketIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_SkinTicketIcon);
		}
		LuaObject.addMember(l, name26, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache19, null, false);
		string name27 = "MemoryEssenceIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_MemoryEssenceIcon);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1A, null, false);
		string name28 = "MithralStoneIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_MithralStoneIcon);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1B, null, false);
		string name29 = "BrillianceMithralStoneIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_BrillianceMithralStoneIcon);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1C, null, false);
		string name30 = "GuildMedalIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_GuildMedalIcon);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1D, null, false);
		string name31 = "ItemIconRank0Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ItemIconRank0Frame);
		}
		LuaObject.addMember(l, name31, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1E, null, false);
		string name32 = "ItemIconRank1Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ItemIconRank1Frame);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache1F, null, false);
		string name33 = "ItemIconRank2Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ItemIconRank2Frame);
		}
		LuaObject.addMember(l, name33, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache20, null, false);
		string name34 = "ItemIconRank3Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ItemIconRank3Frame);
		}
		LuaObject.addMember(l, name34, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache21, null, false);
		string name35 = "ItemIconRank4Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ItemIconRank4Frame);
		}
		LuaObject.addMember(l, name35, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache22, null, false);
		string name36 = "ItemIconRank5Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ItemIconRank5Frame);
		}
		LuaObject.addMember(l, name36, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache23, null, false);
		string name37 = "ItemIconRank9Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ItemIconRank9Frame);
		}
		LuaObject.addMember(l, name37, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache24, null, false);
		string name38 = "RankNImage";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_RankNImage);
		}
		LuaObject.addMember(l, name38, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache25, null, false);
		string name39 = "RankRImage";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_RankRImage);
		}
		LuaObject.addMember(l, name39, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache26, null, false);
		string name40 = "RankSRImage";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_RankSRImage);
		}
		LuaObject.addMember(l, name40, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache27, null, false);
		string name41 = "RankSSRImage";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_RankSSRImage);
		}
		LuaObject.addMember(l, name41, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache28, null, false);
		string name42 = "SoldierRank1Image";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_SoldierRank1Image);
		}
		LuaObject.addMember(l, name42, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache29, null, false);
		string name43 = "SoldierRank2Image";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_SoldierRank2Image);
		}
		LuaObject.addMember(l, name43, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2A, null, false);
		string name44 = "SoldierRank3Image";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_SoldierRank3Image);
		}
		LuaObject.addMember(l, name44, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2B, null, false);
		string name45 = "PropertyRankSIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_PropertyRankSIcon);
		}
		LuaObject.addMember(l, name45, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2C, null, false);
		string name46 = "PropertyRankAIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_PropertyRankAIcon);
		}
		LuaObject.addMember(l, name46, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2D, null, false);
		string name47 = "PropertyRankBIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_PropertyRankBIcon);
		}
		LuaObject.addMember(l, name47, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2E, null, false);
		string name48 = "PropertyRankCIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_PropertyRankCIcon);
		}
		LuaObject.addMember(l, name48, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache2F, null, false);
		string name49 = "PropertyRankDIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_PropertyRankDIcon);
		}
		LuaObject.addMember(l, name49, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache30, null, false);
		string name50 = "PropertyRankEIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_PropertyRankEIcon);
		}
		LuaObject.addMember(l, name50, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache31, null, false);
		string name51 = "HeroListRank1Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroListRank1Frame);
		}
		LuaObject.addMember(l, name51, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache32, null, false);
		string name52 = "HeroListRank2Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroListRank2Frame);
		}
		LuaObject.addMember(l, name52, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache33, null, false);
		string name53 = "HeroListRank3Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroListRank3Frame);
		}
		LuaObject.addMember(l, name53, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache34, null, false);
		string name54 = "HeroListRank4Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroListRank4Frame);
		}
		LuaObject.addMember(l, name54, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache35, null, false);
		string name55 = "HeroListRank5Frame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroListRank5Frame);
		}
		LuaObject.addMember(l, name55, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache36, null, false);
		string name56 = "HeroJobTransferRank1Img";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroJobTransferRank1Img);
		}
		LuaObject.addMember(l, name56, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache37, null, false);
		string name57 = "HeroJobTransferRank2Img";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroJobTransferRank2Img);
		}
		LuaObject.addMember(l, name57, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache38, null, false);
		string name58 = "HeroJobTransferRank3Img";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroJobTransferRank3Img);
		}
		LuaObject.addMember(l, name58, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache39, null, false);
		string name59 = "HeroJobTransferRank4Img";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroJobTransferRank4Img);
		}
		LuaObject.addMember(l, name59, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3A, null, false);
		string name60 = "HeroJobTransferRank5Img";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroJobTransferRank5Img);
		}
		LuaObject.addMember(l, name60, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3B, null, false);
		string name61 = "HeroJobTransferValUp";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroJobTransferValUp);
		}
		LuaObject.addMember(l, name61, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3C, null, false);
		string name62 = "HeroJobTransferValSame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroJobTransferValSame);
		}
		LuaObject.addMember(l, name62, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3D, null, false);
		string name63 = "HeroJobTransferValDown";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HeroJobTransferValDown);
		}
		LuaObject.addMember(l, name63, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3E, null, false);
		string name64 = "Ranking1Image";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_Ranking1Image);
		}
		LuaObject.addMember(l, name64, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache3F, null, false);
		string name65 = "Ranking2Image";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_Ranking2Image);
		}
		LuaObject.addMember(l, name65, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache40, null, false);
		string name66 = "Ranking3Image";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_Ranking3Image);
		}
		LuaObject.addMember(l, name66, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache41, null, false);
		string name67 = "ActivityPlusIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ActivityPlusIcon);
		}
		LuaObject.addMember(l, name67, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache42, null, false);
		string name68 = "ActivityEqualIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ActivityEqualIcon);
		}
		LuaObject.addMember(l, name68, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache43, null, false);
		string name69 = "ActivityIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ActivityIcon);
		}
		LuaObject.addMember(l, name69, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache44, null, false);
		string name70 = "AnnouncementIcon";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_AnnouncementIcon);
		}
		LuaObject.addMember(l, name70, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache45, null, false);
		string name71 = "LoginNoticeLabel";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_LoginNoticeLabel);
		}
		LuaObject.addMember(l, name71, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache46, null, false);
		string name72 = "LoginActivityLabel";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_LoginActivityLabel);
		}
		LuaObject.addMember(l, name72, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache47, null, false);
		string name73 = "TouchHitFx";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_TouchHitFx);
		}
		LuaObject.addMember(l, name73, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache48, null, false);
		string name74 = "TouchHitFx2";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_TouchHitFx2);
		}
		LuaObject.addMember(l, name74, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache49, null, false);
		string name75 = "TouchLoopFx";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_TouchLoopFx);
		}
		LuaObject.addMember(l, name75, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4A, null, false);
		string name76 = "TouchLoopFx2";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_TouchLoopFx2);
		}
		LuaObject.addMember(l, name76, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4B, null, false);
		string name77 = "HPBreakFxLarge";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HPBreakFxLarge);
		}
		LuaObject.addMember(l, name77, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4C, null, false);
		string name78 = "HPBreakFxSmall";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_HPBreakFxSmall);
		}
		LuaObject.addMember(l, name78, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4D, null, false);
		string name79 = "TreasureMapCharSpine1";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_TreasureMapCharSpine1);
		}
		LuaObject.addMember(l, name79, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4E, null, false);
		string name80 = "TreasureMapCharSpine2";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_TreasureMapCharSpine2);
		}
		LuaObject.addMember(l, name80, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache4F, null, false);
		string name81 = "TreasureMapCharSpine3";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_TreasureMapCharSpine3);
		}
		LuaObject.addMember(l, name81, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache50, null, false);
		string name82 = "TreasureMapCharSpine4";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_TreasureMapCharSpine4);
		}
		LuaObject.addMember(l, name82, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache51, null, false);
		string name83 = "StorePrivilegeIconFrame";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_StorePrivilegeIconFrame);
		}
		LuaObject.addMember(l, name83, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache52, null, false);
		string name84 = "DrillBgSlot0";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_DrillBgSlot0);
		}
		LuaObject.addMember(l, name84, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache53, null, false);
		string name85 = "DrillBgSlot1";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_DrillBgSlot1);
		}
		LuaObject.addMember(l, name85, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache54, null, false);
		string name86 = "DrillBgSlot2";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_DrillBgSlot2);
		}
		LuaObject.addMember(l, name86, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache55, null, false);
		string name87 = "GoldNumbers";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_GoldNumbers);
		}
		LuaObject.addMember(l, name87, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache56, null, false);
		string name88 = "ServerStateSpritePath";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_ServerStateSpritePath);
		}
		LuaObject.addMember(l, name88, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache57, null, false);
		string name89 = "DialogBox";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_DialogBox);
		}
		LuaObject.addMember(l, name89, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache58, null, false);
		string name90 = "RealtimePVPNoticePrefab";
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.get_RealtimePVPNoticePrefab);
		}
		LuaObject.addMember(l, name90, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache59, null, false);
		if (Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UIAsset.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UIAsset.<>f__mg$cache5A, typeof(UIAsset));
	}

	// Token: 0x04017BDE RID: 97246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017BDF RID: 97247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017BE0 RID: 97248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017BE1 RID: 97249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017BE2 RID: 97250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017BE3 RID: 97251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017BE4 RID: 97252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017BE5 RID: 97253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017BE6 RID: 97254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017BE7 RID: 97255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017BE8 RID: 97256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017BE9 RID: 97257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017BEA RID: 97258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017BEB RID: 97259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017BEC RID: 97260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017BED RID: 97261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017BEE RID: 97262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017BEF RID: 97263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017BF0 RID: 97264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017BF1 RID: 97265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017BF2 RID: 97266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017BF3 RID: 97267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017BF4 RID: 97268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017BF5 RID: 97269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017BF6 RID: 97270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017BF7 RID: 97271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017BF8 RID: 97272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017BF9 RID: 97273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017BFA RID: 97274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017BFB RID: 97275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017BFC RID: 97276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017BFD RID: 97277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017BFE RID: 97278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017BFF RID: 97279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017C00 RID: 97280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017C01 RID: 97281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017C02 RID: 97282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017C03 RID: 97283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017C04 RID: 97284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017C05 RID: 97285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017C06 RID: 97286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017C07 RID: 97287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017C08 RID: 97288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017C09 RID: 97289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017C0A RID: 97290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017C0B RID: 97291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017C0C RID: 97292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017C0D RID: 97293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017C0E RID: 97294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017C0F RID: 97295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017C10 RID: 97296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017C11 RID: 97297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017C12 RID: 97298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017C13 RID: 97299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017C14 RID: 97300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017C15 RID: 97301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017C16 RID: 97302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017C17 RID: 97303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017C18 RID: 97304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017C19 RID: 97305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017C1A RID: 97306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017C1B RID: 97307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017C1C RID: 97308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017C1D RID: 97309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017C1E RID: 97310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04017C1F RID: 97311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04017C20 RID: 97312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04017C21 RID: 97313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04017C22 RID: 97314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04017C23 RID: 97315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04017C24 RID: 97316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04017C25 RID: 97317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017C26 RID: 97318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04017C27 RID: 97319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04017C28 RID: 97320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04017C29 RID: 97321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04017C2A RID: 97322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04017C2B RID: 97323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04017C2C RID: 97324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04017C2D RID: 97325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04017C2E RID: 97326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04017C2F RID: 97327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04017C30 RID: 97328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04017C31 RID: 97329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04017C32 RID: 97330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04017C33 RID: 97331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04017C34 RID: 97332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04017C35 RID: 97333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04017C36 RID: 97334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04017C37 RID: 97335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04017C38 RID: 97336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;
}
