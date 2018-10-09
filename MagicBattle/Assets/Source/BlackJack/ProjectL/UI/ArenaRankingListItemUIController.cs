using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectLBasic;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A2E RID: 2606
	[HotFix]
	public class ArenaRankingListItemUIController : UIControllerBase
	{
		// Token: 0x06009FC1 RID: 40897 RVA: 0x002D1F7C File Offset: 0x002D017C
		protected override void OnBindFiledsCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBindFiledsCompleted_hotfix != null)
			{
				this.m_OnBindFiledsCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnBindFiledsCompleted();
			this.m_playerIconImage = Utility.FindChildComponent<Image>(base.gameObject, "HeadIcon", false);
			if (this.m_playerIconImage != null)
			{
				this.m_playerHeadFrameTransform = Utility.FindChildComponent<Transform>(this.m_playerIconImage.gameObject, "HeadFrameDummy", false);
				this.m_playerLevelText = Utility.FindChildComponent<Text>(this.m_playerIconImage.gameObject, "LevelText", false);
			}
			this.m_arenaLevelIconImage = Utility.FindChildComponent<Image>(base.gameObject, "ArenaLevelIcon", false);
		}

		// Token: 0x06009FC2 RID: 40898 RVA: 0x002D205C File Offset: 0x002D025C
		public void SetRanking(int ranking)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRankingInt32_hotfix != null)
			{
				this.m_SetRankingInt32_hotfix.call(new object[]
				{
					this,
					ranking
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string leaderboardRankingImageName = UIUtility.GetLeaderboardRankingImageName(ranking);
			if (!string.IsNullOrEmpty(leaderboardRankingImageName))
			{
				this.m_rankingImage.gameObject.SetActive(true);
				this.m_rankingImage.sprite = AssetUtility.Instance.GetSprite(leaderboardRankingImageName);
				this.m_rankingText.gameObject.SetActive(false);
			}
			else
			{
				this.m_rankingImage.gameObject.SetActive(false);
				this.m_rankingText.gameObject.SetActive(true);
				this.m_rankingText.text = ranking.ToString();
			}
		}

		// Token: 0x06009FC3 RID: 40899 RVA: 0x002D2158 File Offset: 0x002D0358
		public void SetIndex(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIndexInt32_hotfix != null)
			{
				this.m_SetIndexInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_backgroundGameObject.SetActive(index % 2 == 0);
		}

		// Token: 0x06009FC4 RID: 40900 RVA: 0x002D21DC File Offset: 0x002D03DC
		public void SetPlayer(ProArenaTopRankPlayer player)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerProArenaTopRankPlayer_hotfix != null)
			{
				this.m_SetPlayerProArenaTopRankPlayer_hotfix.call(new object[]
				{
					this,
					player
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerNameText.text = player.Name;
			this.m_arenaPointsText.text = player.ArenaPoints.ToString();
			if (this.m_playerIconImage != null)
			{
				this.m_playerIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(player.HeadIcon)));
			}
			if (this.m_playerHeadFrameTransform != null)
			{
				UIUtility.SetPlayerHeadFrame(this.m_playerHeadFrameTransform, HeadIconTools.GetHeadFrame(player.HeadIcon), true, "Normal");
			}
			if (this.m_playerLevelText != null)
			{
				this.m_playerLevelText.text = player.Level.ToString();
			}
			if (this.m_arenaLevelIconImage != null)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataArenaLevelInfo configDataArenaLevelInfo = configDataLoader.GetConfigDataArenaLevelInfo(player.ArenaLevel);
				if (configDataArenaLevelInfo != null)
				{
					this.m_arenaLevelIconImage.sprite = AssetUtility.Instance.GetSprite(configDataArenaLevelInfo.Icon);
				}
			}
		}

		// Token: 0x06009FC5 RID: 40901 RVA: 0x002D2360 File Offset: 0x002D0560
		public void SetPlayer(ProRealTimePVPLeaderboardPlayerInfo player, ProUserSummary userSummary)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerProRealTimePVPLeaderboardPlayerInfoProUserSummary_hotfix != null)
			{
				this.m_SetPlayerProRealTimePVPLeaderboardPlayerInfoProUserSummary_hotfix.call(new object[]
				{
					this,
					player,
					userSummary
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerNameText.text = userSummary.Name;
			this.m_arenaPointsText.text = player.Score.ToString();
			if (this.m_playerIconImage != null)
			{
				this.m_playerIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetPlayerSmallHeadIconImageName(HeadIconTools.GetHeadPortrait(userSummary.HeadIcon)));
			}
			if (this.m_playerHeadFrameTransform != null)
			{
				UIUtility.SetPlayerHeadFrame(this.m_playerHeadFrameTransform, HeadIconTools.GetHeadFrame(userSummary.HeadIcon), true, "Normal");
			}
			if (this.m_playerLevelText != null)
			{
				this.m_playerLevelText.text = userSummary.Level.ToString();
			}
			if (this.m_arenaLevelIconImage != null)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataRealTimePVPDanInfo configDataRealTimePVPDanInfo = configDataLoader.GetConfigDataRealTimePVPDanInfo(player.Dan);
				if (configDataRealTimePVPDanInfo != null)
				{
					this.m_arenaLevelIconImage.sprite = AssetUtility.Instance.GetSprite(configDataRealTimePVPDanInfo.Icon);
				}
			}
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06009FC6 RID: 40902 RVA: 0x002D24F4 File Offset: 0x002D06F4
		// (set) Token: 0x06009FC7 RID: 40903 RVA: 0x002D2514 File Offset: 0x002D0714
		[DoNotToLua]
		public new ArenaRankingListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaRankingListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009FC8 RID: 40904 RVA: 0x002D2520 File Offset: 0x002D0720
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009FC9 RID: 40905 RVA: 0x002D252C File Offset: 0x002D072C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009FCA RID: 40906 RVA: 0x002D2534 File Offset: 0x002D0734
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009FCB RID: 40907 RVA: 0x002D253C File Offset: 0x002D073C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009FCC RID: 40908 RVA: 0x002D2550 File Offset: 0x002D0750
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009FCD RID: 40909 RVA: 0x002D2558 File Offset: 0x002D0758
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009FCE RID: 40910 RVA: 0x002D2564 File Offset: 0x002D0764
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009FCF RID: 40911 RVA: 0x002D2570 File Offset: 0x002D0770
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009FD0 RID: 40912 RVA: 0x002D257C File Offset: 0x002D077C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009FD1 RID: 40913 RVA: 0x002D2588 File Offset: 0x002D0788
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009FD2 RID: 40914 RVA: 0x002D2594 File Offset: 0x002D0794
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009FD3 RID: 40915 RVA: 0x002D25A0 File Offset: 0x002D07A0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x002D25AC File Offset: 0x002D07AC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x002D25B8 File Offset: 0x002D07B8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009FD6 RID: 40918 RVA: 0x002D25C4 File Offset: 0x002D07C4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x002D25CC File Offset: 0x002D07CC
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_OnBindFiledsCompleted_hotfix = (luaObj.RawGet("OnBindFiledsCompleted") as LuaFunction);
					this.m_SetRankingInt32_hotfix = (luaObj.RawGet("SetRanking") as LuaFunction);
					this.m_SetIndexInt32_hotfix = (luaObj.RawGet("SetIndex") as LuaFunction);
					this.m_SetPlayerProArenaTopRankPlayer_hotfix = (luaObj.RawGet("SetPlayer") as LuaFunction);
					this.m_SetPlayerProRealTimePVPLeaderboardPlayerInfoProUserSummary_hotfix = (luaObj.RawGet("SetPlayer") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x002D26FC File Offset: 0x002D08FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaRankingListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006BA6 RID: 27558
		[AutoBind("./RankingIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_rankingImage;

		// Token: 0x04006BA7 RID: 27559
		[AutoBind("./RankingText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_rankingText;

		// Token: 0x04006BA8 RID: 27560
		[AutoBind("./PlayerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x04006BA9 RID: 27561
		[AutoBind("./ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_arenaPointsText;

		// Token: 0x04006BAA RID: 27562
		[AutoBind("./BGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_backgroundGameObject;

		// Token: 0x04006BAB RID: 27563
		private Image m_playerIconImage;

		// Token: 0x04006BAC RID: 27564
		private Transform m_playerHeadFrameTransform;

		// Token: 0x04006BAD RID: 27565
		private Image m_arenaLevelIconImage;

		// Token: 0x04006BAE RID: 27566
		private Text m_playerLevelText;

		// Token: 0x04006BAF RID: 27567
		[DoNotToLua]
		private ArenaRankingListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006BB0 RID: 27568
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006BB1 RID: 27569
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006BB2 RID: 27570
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006BB3 RID: 27571
		private LuaFunction m_SetRankingInt32_hotfix;

		// Token: 0x04006BB4 RID: 27572
		private LuaFunction m_SetIndexInt32_hotfix;

		// Token: 0x04006BB5 RID: 27573
		private LuaFunction m_SetPlayerProArenaTopRankPlayer_hotfix;

		// Token: 0x04006BB6 RID: 27574
		private LuaFunction m_SetPlayerProRealTimePVPLeaderboardPlayerInfoProUserSummary_hotfix;

		// Token: 0x02000A2F RID: 2607
		public new class LuaExportHelper
		{
			// Token: 0x06009FD9 RID: 40921 RVA: 0x002D2764 File Offset: 0x002D0964
			public LuaExportHelper(ArenaRankingListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009FDA RID: 40922 RVA: 0x002D2774 File Offset: 0x002D0974
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009FDB RID: 40923 RVA: 0x002D2784 File Offset: 0x002D0984
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009FDC RID: 40924 RVA: 0x002D2794 File Offset: 0x002D0994
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06009FDD RID: 40925 RVA: 0x002D27A4 File Offset: 0x002D09A4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06009FDE RID: 40926 RVA: 0x002D27BC File Offset: 0x002D09BC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009FDF RID: 40927 RVA: 0x002D27CC File Offset: 0x002D09CC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009FE0 RID: 40928 RVA: 0x002D27DC File Offset: 0x002D09DC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009FE1 RID: 40929 RVA: 0x002D27EC File Offset: 0x002D09EC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009FE2 RID: 40930 RVA: 0x002D27FC File Offset: 0x002D09FC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009FE3 RID: 40931 RVA: 0x002D280C File Offset: 0x002D0A0C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009FE4 RID: 40932 RVA: 0x002D281C File Offset: 0x002D0A1C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009FE5 RID: 40933 RVA: 0x002D282C File Offset: 0x002D0A2C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009FE6 RID: 40934 RVA: 0x002D283C File Offset: 0x002D0A3C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009FE7 RID: 40935 RVA: 0x002D284C File Offset: 0x002D0A4C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009FE8 RID: 40936 RVA: 0x002D285C File Offset: 0x002D0A5C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170020A4 RID: 8356
			// (get) Token: 0x06009FE9 RID: 40937 RVA: 0x002D286C File Offset: 0x002D0A6C
			// (set) Token: 0x06009FEA RID: 40938 RVA: 0x002D287C File Offset: 0x002D0A7C
			public Image m_rankingImage
			{
				get
				{
					return this.m_owner.m_rankingImage;
				}
				set
				{
					this.m_owner.m_rankingImage = value;
				}
			}

			// Token: 0x170020A5 RID: 8357
			// (get) Token: 0x06009FEB RID: 40939 RVA: 0x002D288C File Offset: 0x002D0A8C
			// (set) Token: 0x06009FEC RID: 40940 RVA: 0x002D289C File Offset: 0x002D0A9C
			public Text m_rankingText
			{
				get
				{
					return this.m_owner.m_rankingText;
				}
				set
				{
					this.m_owner.m_rankingText = value;
				}
			}

			// Token: 0x170020A6 RID: 8358
			// (get) Token: 0x06009FED RID: 40941 RVA: 0x002D28AC File Offset: 0x002D0AAC
			// (set) Token: 0x06009FEE RID: 40942 RVA: 0x002D28BC File Offset: 0x002D0ABC
			public Text m_playerNameText
			{
				get
				{
					return this.m_owner.m_playerNameText;
				}
				set
				{
					this.m_owner.m_playerNameText = value;
				}
			}

			// Token: 0x170020A7 RID: 8359
			// (get) Token: 0x06009FEF RID: 40943 RVA: 0x002D28CC File Offset: 0x002D0ACC
			// (set) Token: 0x06009FF0 RID: 40944 RVA: 0x002D28DC File Offset: 0x002D0ADC
			public Text m_arenaPointsText
			{
				get
				{
					return this.m_owner.m_arenaPointsText;
				}
				set
				{
					this.m_owner.m_arenaPointsText = value;
				}
			}

			// Token: 0x170020A8 RID: 8360
			// (get) Token: 0x06009FF1 RID: 40945 RVA: 0x002D28EC File Offset: 0x002D0AEC
			// (set) Token: 0x06009FF2 RID: 40946 RVA: 0x002D28FC File Offset: 0x002D0AFC
			public GameObject m_backgroundGameObject
			{
				get
				{
					return this.m_owner.m_backgroundGameObject;
				}
				set
				{
					this.m_owner.m_backgroundGameObject = value;
				}
			}

			// Token: 0x170020A9 RID: 8361
			// (get) Token: 0x06009FF3 RID: 40947 RVA: 0x002D290C File Offset: 0x002D0B0C
			// (set) Token: 0x06009FF4 RID: 40948 RVA: 0x002D291C File Offset: 0x002D0B1C
			public Image m_playerIconImage
			{
				get
				{
					return this.m_owner.m_playerIconImage;
				}
				set
				{
					this.m_owner.m_playerIconImage = value;
				}
			}

			// Token: 0x170020AA RID: 8362
			// (get) Token: 0x06009FF5 RID: 40949 RVA: 0x002D292C File Offset: 0x002D0B2C
			// (set) Token: 0x06009FF6 RID: 40950 RVA: 0x002D293C File Offset: 0x002D0B3C
			public Transform m_playerHeadFrameTransform
			{
				get
				{
					return this.m_owner.m_playerHeadFrameTransform;
				}
				set
				{
					this.m_owner.m_playerHeadFrameTransform = value;
				}
			}

			// Token: 0x170020AB RID: 8363
			// (get) Token: 0x06009FF7 RID: 40951 RVA: 0x002D294C File Offset: 0x002D0B4C
			// (set) Token: 0x06009FF8 RID: 40952 RVA: 0x002D295C File Offset: 0x002D0B5C
			public Image m_arenaLevelIconImage
			{
				get
				{
					return this.m_owner.m_arenaLevelIconImage;
				}
				set
				{
					this.m_owner.m_arenaLevelIconImage = value;
				}
			}

			// Token: 0x170020AC RID: 8364
			// (get) Token: 0x06009FF9 RID: 40953 RVA: 0x002D296C File Offset: 0x002D0B6C
			// (set) Token: 0x06009FFA RID: 40954 RVA: 0x002D297C File Offset: 0x002D0B7C
			public Text m_playerLevelText
			{
				get
				{
					return this.m_owner.m_playerLevelText;
				}
				set
				{
					this.m_owner.m_playerLevelText = value;
				}
			}

			// Token: 0x06009FFB RID: 40955 RVA: 0x002D298C File Offset: 0x002D0B8C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04006BB7 RID: 27575
			private ArenaRankingListItemUIController m_owner;
		}
	}
}
