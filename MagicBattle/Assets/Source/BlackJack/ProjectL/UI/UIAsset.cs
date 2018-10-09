using System;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FD3 RID: 4051
	[CustomLuaClass]
	public class UIAsset
	{
		// Token: 0x0400B2CE RID: 45774
		public const string UISpineMaterial = "UI/Common_New_ABS/Material/UISpine.mat";

		// Token: 0x0400B2CF RID: 45775
		public const string UISpine2Material = "UI/Common_New_ABS/Material/UISpine2.mat";

		// Token: 0x0400B2D0 RID: 45776
		public const string UISpineMaterial_SepAlpha = "UI/Common_New_ABS/Material/UISpine_SepAlpha.mat";

		// Token: 0x0400B2D1 RID: 45777
		public const string UISpine2Material_SepAlpha = "UI/Common_New_ABS/Material/UISpine2_SepAlpha.mat";

		// Token: 0x0400B2D2 RID: 45778
		public const string HeroFragmentIconMaterial = "UI/Icon/Piece_ABS/Material/PieceIcon.mat";

		// Token: 0x0400B2D3 RID: 45779
		public const string HeroSummonIconMaterial = "UI/Icon/Card_ABS/Material/CardIcon.mat";

		// Token: 0x0400B2D4 RID: 45780
		public const string HeroSkinIconMaterial = "UI/Icon/HeroSkin_ABS/Material/HeroSkinIcon.mat";

		// Token: 0x0400B2D5 RID: 45781
		public const string SoldierSkinIconMaterial = "UI/Icon/SoldierSkin_ABS/Material/SoldierSkinIcon.mat";

		// Token: 0x0400B2D6 RID: 45782
		public const string TeamIcon0 = "UI/Common_New_ABS/Icon/Bead_Blue.png";

		// Token: 0x0400B2D7 RID: 45783
		public const string TeamIcon1 = "UI/Common_New_ABS/Icon/Bead_Green.png";

		// Token: 0x0400B2D8 RID: 45784
		public const string HpBar0 = "UI/Common_New_ABS/Pattern_Blood_Green.png";

		// Token: 0x0400B2D9 RID: 45785
		public const string HpBar1 = "UI/Common_New_ABS/Pattern_Blood_Red.png";

		// Token: 0x0400B2DA RID: 45786
		public const string HpBarNpc = "UI/Common_New_ABS/Pattern_Blood_Blue.png";

		// Token: 0x0400B2DB RID: 45787
		public const string ActorInfoHpBar0 = "UI/Common_New_ABS/Pattern_Blood_Green01.png";

		// Token: 0x0400B2DC RID: 45788
		public const string ActorInfoHpBar1 = "UI/Common_New_ABS/Pattern_Blood_Red01.png";

		// Token: 0x0400B2DD RID: 45789
		public const string BattlePlayerTag1 = "UI/Common_New_ABS/Font/Word_1P.png";

		// Token: 0x0400B2DE RID: 45790
		public const string BattlePlayerTag2 = "UI/Common_New_ABS/Font/Word_2P.png";

		// Token: 0x0400B2DF RID: 45791
		public const string BattlePlayerTag3 = "UI/Common_New_ABS/Font/Word_3P.png";

		// Token: 0x0400B2E0 RID: 45792
		public const string GoldIcon = "UI/Icon/Item_ABS/Item_Gold.png";

		// Token: 0x0400B2E1 RID: 45793
		public const string ExpIcon = "UI/Icon/Item_ABS/Item_PlayerExp.png";

		// Token: 0x0400B2E2 RID: 45794
		public const string CrystalIcon = "UI/Icon/Item_ABS/Item_MagicCrystal.png";

		// Token: 0x0400B2E3 RID: 45795
		public const string EnergyIcon = "UI/Icon/Item_ABS/Item_Bread.png";

		// Token: 0x0400B2E4 RID: 45796
		public const string FriendShipPointIcon = "UI/Common_New_ABS/Icon/Icon_Friendship_1.png";

		// Token: 0x0400B2E5 RID: 45797
		public const string ArenaTicketIcon = "UI/Icon/Item_ABS/Item_PVPTicket.png";

		// Token: 0x0400B2E6 RID: 45798
		public const string ArenaHonourIcon = "UI/Icon/Item_ABS/Item_PvpCoin.png";

		// Token: 0x0400B2E7 RID: 45799
		public const string SkinTicketIcon = "UI/Icon/Item_ABS/Item_ETicket-God.png";

		// Token: 0x0400B2E8 RID: 45800
		public const string MemoryEssenceIcon = "UI/Icon/Item_ABS/Item_MemoryEssence.png";

		// Token: 0x0400B2E9 RID: 45801
		public const string MithralStoneIcon = "UI/Icon/Item_ABS/Icon_DragonScale_01.png";

		// Token: 0x0400B2EA RID: 45802
		public const string BrillianceMithralStoneIcon = "UI/Icon/Item_ABS/Icon_DragonScale_02.png";

		// Token: 0x0400B2EB RID: 45803
		public const string GuildMedalIcon = "UI/Common_New_ABS/Icon/Icon_GuildCoin.png";

		// Token: 0x0400B2EC RID: 45804
		public const string ItemIconRank0Frame = "UI/Common_New_ABS/Border_Icon_Copper.png";

		// Token: 0x0400B2ED RID: 45805
		public const string ItemIconRank1Frame = "UI/Common_New_ABS/Border_Icon_Copper.png";

		// Token: 0x0400B2EE RID: 45806
		public const string ItemIconRank2Frame = "UI/Common_New_ABS/Border_Icon_Silver.png";

		// Token: 0x0400B2EF RID: 45807
		public const string ItemIconRank3Frame = "UI/Common_New_ABS/Border_Icon_Gold.png";

		// Token: 0x0400B2F0 RID: 45808
		public const string ItemIconRank4Frame = "UI/Common_New_ABS/Border_Icon_Colour.png";

		// Token: 0x0400B2F1 RID: 45809
		public const string ItemIconRank5Frame = "UI/Common_New_ABS/Border_Icon_Colour.png";

		// Token: 0x0400B2F2 RID: 45810
		public const string ItemIconRank9Frame = "UI/Common_New_ABS/Border_Icon_Gray.png";

		// Token: 0x0400B2F3 RID: 45811
		public const string RankNImage = "UI/Common_New_ABS/Font/Rank_N.png";

		// Token: 0x0400B2F4 RID: 45812
		public const string RankRImage = "UI/Common_New_ABS/Font/Rank_R.png";

		// Token: 0x0400B2F5 RID: 45813
		public const string RankSRImage = "UI/Common_New_ABS/Font/Rank_SR.png";

		// Token: 0x0400B2F6 RID: 45814
		public const string RankSSRImage = "UI/Common_New_ABS/Font/Rank_SSR.png";

		// Token: 0x0400B2F7 RID: 45815
		public const string SoldierRank1Image = "UI/Common_New_ABS/Font/Word_1.png";

		// Token: 0x0400B2F8 RID: 45816
		public const string SoldierRank2Image = "UI/Common_New_ABS/Font/Word_2.png";

		// Token: 0x0400B2F9 RID: 45817
		public const string SoldierRank3Image = "UI/Common_New_ABS/Font/Word_3.png";

		// Token: 0x0400B2FA RID: 45818
		public const string PropertyRankSIcon = "UI/Common_New_ABS/Font/Font_S.png";

		// Token: 0x0400B2FB RID: 45819
		public const string PropertyRankAIcon = "UI/Common_New_ABS/Font/Font_A.png";

		// Token: 0x0400B2FC RID: 45820
		public const string PropertyRankBIcon = "UI/Common_New_ABS/Font/Font_B.png";

		// Token: 0x0400B2FD RID: 45821
		public const string PropertyRankCIcon = "UI/Common_New_ABS/Font/Font_C.png";

		// Token: 0x0400B2FE RID: 45822
		public const string PropertyRankDIcon = "UI/Common_New_ABS/Font/Font_D.png";

		// Token: 0x0400B2FF RID: 45823
		public const string PropertyRankEIcon = "UI/Common_New_ABS/Font/Font_E.png";

		// Token: 0x0400B300 RID: 45824
		public const string HeroListRank1Frame = "UI/HeadFrame_ABS/Card_Thumbnail_04.png";

		// Token: 0x0400B301 RID: 45825
		public const string HeroListRank2Frame = "UI/HeadFrame_ABS/Card_Thumbnail_03.png";

		// Token: 0x0400B302 RID: 45826
		public const string HeroListRank3Frame = "UI/HeadFrame_ABS/Card_Thumbnail_02.png";

		// Token: 0x0400B303 RID: 45827
		public const string HeroListRank4Frame = "UI/HeadFrame_ABS/Card_Thumbnail_01.png";

		// Token: 0x0400B304 RID: 45828
		public const string HeroListRank5Frame = "UI/HeadFrame_ABS/Card_Thumbnail_01.png";

		// Token: 0x0400B305 RID: 45829
		public const string HeroJobTransferRank1Img = "UI/JobTransfer_ABS/Pattern_Job_01.png";

		// Token: 0x0400B306 RID: 45830
		public const string HeroJobTransferRank2Img = "UI/JobTransfer_ABS/Pattern_Job_02.png";

		// Token: 0x0400B307 RID: 45831
		public const string HeroJobTransferRank3Img = "UI/JobTransfer_ABS/Pattern_Job_03.png";

		// Token: 0x0400B308 RID: 45832
		public const string HeroJobTransferRank4Img = "UI/JobTransfer_ABS/Pattern_Job_04.png";

		// Token: 0x0400B309 RID: 45833
		public const string HeroJobTransferRank5Img = "UI/JobTransfer_ABS/Pattern_Job_05.png";

		// Token: 0x0400B30A RID: 45834
		public const string HeroJobTransferValUp = "UI/Common_New_ABS/Icon_Up.png";

		// Token: 0x0400B30B RID: 45835
		public const string HeroJobTransferValSame = "UI/Common_New_ABS/Icon_Minus.png";

		// Token: 0x0400B30C RID: 45836
		public const string HeroJobTransferValDown = "UI/Common_New_ABS/Icon_Down.png";

		// Token: 0x0400B30D RID: 45837
		public const string Ranking1Image = "UI/Common_New_ABS/Icon/Icon_One.png";

		// Token: 0x0400B30E RID: 45838
		public const string Ranking2Image = "UI/Common_New_ABS/Icon/Icon_Two.png";

		// Token: 0x0400B30F RID: 45839
		public const string Ranking3Image = "UI/Common_New_ABS/Icon/Icon_Three.png";

		// Token: 0x0400B310 RID: 45840
		public const string ActivityPlusIcon = "UI/Common_New_ABS/Icon/Icon_Plus_01.png";

		// Token: 0x0400B311 RID: 45841
		public const string ActivityEqualIcon = "UI/Common_New_ABS/Icon/Icon_Equal_01.png";

		// Token: 0x0400B312 RID: 45842
		public const string ActivityIcon = "UI/Activity_ABS/Icon_activity.png";

		// Token: 0x0400B313 RID: 45843
		public const string AnnouncementIcon = "UI/Activity_ABS/Icon_Repair.png";

		// Token: 0x0400B314 RID: 45844
		public const string LoginNoticeLabel = "UI/Login_ABS/Label_Notice.png";

		// Token: 0x0400B315 RID: 45845
		public const string LoginActivityLabel = "UI/Login_ABS/Label_Activity.png";

		// Token: 0x0400B316 RID: 45846
		public const string TouchHitFx = "FX/UI_ABS/UI_Fx/U_click_down.prefab";

		// Token: 0x0400B317 RID: 45847
		public const string TouchHitFx2 = "FX/UI_ABS/UI_Fx/U_click_down.prefab";

		// Token: 0x0400B318 RID: 45848
		public const string TouchLoopFx = "FX/UI_ABS/UI_Fx/U_click.prefab";

		// Token: 0x0400B319 RID: 45849
		public const string TouchLoopFx2 = "FX/UI_ABS/UI_Fx/U_click_open.prefab";

		// Token: 0x0400B31A RID: 45850
		public const string HPBreakFxLarge = "FX/UI_ABS/UIFX_HPBarBreak_L_Pfb.prefab";

		// Token: 0x0400B31B RID: 45851
		public const string HPBreakFxSmall = "FX/UI_ABS/UIFX_HPBarBreak_S_Pfb.prefab";

		// Token: 0x0400B31C RID: 45852
		public const string TreasureMapCharSpine1 = "Spine/General/Goblin_ABS/Goblin_1_Prefab.prefab";

		// Token: 0x0400B31D RID: 45853
		public const string TreasureMapCharSpine2 = "Spine/General/Goblin_ABS/Goblin_2_Prefab.prefab";

		// Token: 0x0400B31E RID: 45854
		public const string TreasureMapCharSpine3 = "Spine/General/Goblin_ABS/Goblin_3_Prefab.prefab";

		// Token: 0x0400B31F RID: 45855
		public const string TreasureMapCharSpine4 = "Spine/General/Goblin_ABS/Goblin_4_Prefab.prefab";

		// Token: 0x0400B320 RID: 45856
		public const string StorePrivilegeIconFrame = "UI/Common_New_ABS/Border_Icon_Colour.png";

		// Token: 0x0400B321 RID: 45857
		public const string DrillBgSlot0 = "UI/Drill_ABS/1/1.png";

		// Token: 0x0400B322 RID: 45858
		public const string DrillBgSlot1 = "UI/Drill_ABS/1/2.png";

		// Token: 0x0400B323 RID: 45859
		public const string DrillBgSlot2 = "UI/Drill_ABS/1/3.png";

		// Token: 0x0400B324 RID: 45860
		public static readonly string[] GoldNumbers = new string[]
		{
			"UI/Common_New_ABS/Font/Number_Gold_00.png",
			"UI/Common_New_ABS/Font/Number_Gold_01.png",
			"UI/Common_New_ABS/Font/Number_Gold_02.png",
			"UI/Common_New_ABS/Font/Number_Gold_03.png",
			"UI/Common_New_ABS/Font/Number_Gold_04.png",
			"UI/Common_New_ABS/Font/Number_Gold_05.png",
			"UI/Common_New_ABS/Font/Number_Gold_06.png",
			"UI/Common_New_ABS/Font/Number_Gold_07.png",
			"UI/Common_New_ABS/Font/Number_Gold_08.png",
			"UI/Common_New_ABS/Font/Number_Gold_09.png"
		};

		// Token: 0x0400B325 RID: 45861
		public static readonly string[] ServerStateSpritePath = new string[]
		{
			"UI/Login_ABS/Icon_Hot.png",
			"UI/Login_ABS/Icon_Crowd.png",
			"UI/Login_ABS/Icon_Maintain.png",
			"UI/Login_ABS/Icon_Normal.png"
		};

		// Token: 0x0400B326 RID: 45862
		public const string DialogBox = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/DialogBox.prefab";

		// Token: 0x0400B327 RID: 45863
		public const string RealtimePVPNoticePrefab = "UI/UserGuide_ABS/Prefab/UserGuide_17UIPrefab.prefab";
	}
}
