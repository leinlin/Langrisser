using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AC4 RID: 2756
	[HotFix]
	public class BattleRoomUIController : UIControllerBase
	{
		// Token: 0x0600B22A RID: 45610 RVA: 0x00314744 File Offset: 0x00312944
		private BattleRoomUIController()
		{
		}

		// Token: 0x0600B22B RID: 45611 RVA: 0x00314758 File Offset: 0x00312958
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
			this.m_timeGameObject.SetActive(false);
			this.m_bigTimeUIStateController.gameObject.SetActive(false);
			this.m_actionPlayerUIStateController.gameObject.SetActive(false);
			this.m_bigExpressionCtrl = UIUtility.CreateSubUI<BigExpressionController>(this.m_expressionGroup.transform);
			this.m_bigExpressionCtrl.EventOnExpressionClick += this.OnBigExpressionClick;
			this.ButtonBGMask.onClick.AddListener(new UnityAction(this.OnBigExpressionBGClick));
			this.m_expressionGroup.SetActive(false);
			this.m_expressionButton.onClick.AddListener(new UnityAction(this.OnExpressionButtonClick));
			this.m_prefabsGameObject.SetActive(false);
			UIUtility.MarginAdjustHorizontal(this.m_marginTransform);
		}

		// Token: 0x0600B22C RID: 45612 RVA: 0x00314878 File Offset: 0x00312A78
		public void StartBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattle_hotfix != null)
			{
				this.m_StartBattle_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_timeGameObject.SetActive(false);
			this.m_actionPlayerUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x0600B22D RID: 45613 RVA: 0x003148F8 File Offset: 0x00312AF8
		public void AddPlayers(BattleRoom battleRoom)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddPlayersBattleRoom_hotfix != null)
			{
				this.m_AddPlayersBattleRoom_hotfix.call(new object[]
				{
					this,
					battleRoom
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ClearPlayers();
			for (int i = 0; i < battleRoom.Players.Count; i++)
			{
				int heroCount = 0;
				bool showPlayerIndex = false;
				if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
				{
					heroCount = battleRoom.BattleRoomPlayerHeroSetup.GetHeroCountByPlayerIndex(i);
					showPlayerIndex = true;
				}
				this.AddPlayer(battleRoom.Players[i], heroCount, showPlayerIndex);
			}
		}

		// Token: 0x0600B22E RID: 45614 RVA: 0x003149BC File Offset: 0x00312BBC
		private void AddPlayer(BattleRoomPlayer player, int heroCount, bool showPlayerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddPlayerBattleRoomPlayerInt32Boolean_hotfix != null)
			{
				this.m_AddPlayerBattleRoomPlayerInt32Boolean_hotfix.call(new object[]
				{
					this,
					player,
					heroCount,
					showPlayerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_battleTeamPlayerPrefab, this.m_playerGroupGameObject.transform, false);
			BattleTeamPlayerUIController battleTeamPlayerUIController = GameObjectUtility.AddControllerToGameObject<BattleTeamPlayerUIController>(go);
			battleTeamPlayerUIController.SetName(player.Name);
			battleTeamPlayerUIController.SetLevel(player.Level);
			battleTeamPlayerUIController.SetHeadIcon(player.HeadIcon);
			battleTeamPlayerUIController.SetStatus(player.PlayerBattleStatus, player.IsOffline);
			battleTeamPlayerUIController.SetAction(false);
			battleTeamPlayerUIController.SetHeroCount(heroCount);
			battleTeamPlayerUIController.SetPlayerIndex(this.m_players.Count);
			battleTeamPlayerUIController.ShowPlayerIndex(showPlayerIndex);
			GameObject gameObject = this.m_expressionResContainer.GetAsset("EmojiShowImage") as GameObject;
			battleTeamPlayerUIController.InitEmojiText(this.m_expressionParseDesc.m_emSpace, gameObject.GetComponent<Image>());
			for (int i = 0; i < heroCount; i++)
			{
				battleTeamPlayerUIController.SetHeroAlive(i, true);
			}
			this.m_players.Add(battleTeamPlayerUIController);
		}

		// Token: 0x0600B22F RID: 45615 RVA: 0x00314B1C File Offset: 0x00312D1C
		private void ClearPlayers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearPlayers_hotfix != null)
			{
				this.m_ClearPlayers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyComponentList<BattleTeamPlayerUIController>(this.m_players);
			this.m_players.Clear();
		}

		// Token: 0x0600B230 RID: 45616 RVA: 0x00314B94 File Offset: 0x00312D94
		public void SetPlayerStatus(int playerIndex, PlayerBattleStatus status, bool isOffline)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerStatusInt32PlayerBattleStatusBoolean_hotfix != null)
			{
				this.m_SetPlayerStatusInt32PlayerBattleStatusBoolean_hotfix.call(new object[]
				{
					this,
					playerIndex,
					status,
					isOffline
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleTeamPlayerUIController playerUIController = this.GetPlayerUIController(playerIndex);
			if (playerUIController == null)
			{
				return;
			}
			playerUIController.SetStatus(status, isOffline);
		}

		// Token: 0x0600B231 RID: 45617 RVA: 0x00314C44 File Offset: 0x00312E44
		public void SetPlayerAction(int playerIndex, bool isAction)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerActionInt32Boolean_hotfix != null)
			{
				this.m_SetPlayerActionInt32Boolean_hotfix.call(new object[]
				{
					this,
					playerIndex,
					isAction
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleTeamPlayerUIController playerUIController = this.GetPlayerUIController(playerIndex);
			if (playerUIController == null)
			{
				return;
			}
			playerUIController.SetAction(isAction);
		}

		// Token: 0x0600B232 RID: 45618 RVA: 0x00314CE0 File Offset: 0x00312EE0
		public void SetPlayerHeroAlive(int playerIndex, int heroIndex, bool isAlive)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerHeroAliveInt32Int32Boolean_hotfix != null)
			{
				this.m_SetPlayerHeroAliveInt32Int32Boolean_hotfix.call(new object[]
				{
					this,
					playerIndex,
					heroIndex,
					isAlive
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleTeamPlayerUIController playerUIController = this.GetPlayerUIController(playerIndex);
			if (playerUIController == null)
			{
				return;
			}
			playerUIController.SetHeroAlive(heroIndex, isAlive);
		}

		// Token: 0x0600B233 RID: 45619 RVA: 0x00314D90 File Offset: 0x00312F90
		public void ShowPlayerChat(int playerIndex, string text)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerChatInt32String_hotfix != null)
			{
				this.m_ShowPlayerChatInt32String_hotfix.call(new object[]
				{
					this,
					playerIndex,
					text
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleTeamPlayerUIController playerUIController = this.GetPlayerUIController(playerIndex);
			if (playerUIController == null)
			{
				return;
			}
			playerUIController.ShowChat(text);
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x00314E2C File Offset: 0x0031302C
		public void ShowPlayerExpression(int playerIndex, int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerExpressionInt32Int32_hotfix != null)
			{
				this.m_ShowPlayerExpressionInt32Int32_hotfix.call(new object[]
				{
					this,
					playerIndex,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleTeamPlayerUIController playerUIController = this.GetPlayerUIController(playerIndex);
			if (playerUIController == null)
			{
				return;
			}
			playerUIController.ShowBigExpression(id);
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x00314EC8 File Offset: 0x003130C8
		public void ShowPlayerVoice(int playerIndex, ChatVoiceMessage voiceMessage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerVoiceInt32ChatVoiceMessage_hotfix != null)
			{
				this.m_ShowPlayerVoiceInt32ChatVoiceMessage_hotfix.call(new object[]
				{
					this,
					playerIndex,
					voiceMessage
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleTeamPlayerUIController playerUIController = this.GetPlayerUIController(playerIndex);
			if (playerUIController == null)
			{
				return;
			}
			playerUIController.ShowVoice(voiceMessage);
		}

		// Token: 0x0600B236 RID: 45622 RVA: 0x00314F64 File Offset: 0x00313164
		private BattleTeamPlayerUIController GetPlayerUIController(int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerUIControllerInt32_hotfix != null)
			{
				return (BattleTeamPlayerUIController)this.m_GetPlayerUIControllerInt32_hotfix.call(new object[]
				{
					this,
					playerIndex
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (playerIndex < 0 || playerIndex >= this.m_players.Count)
			{
				return null;
			}
			return this.m_players[playerIndex];
		}

		// Token: 0x0600B237 RID: 45623 RVA: 0x00315008 File Offset: 0x00313208
		public void SetOtherActionAsTeammate(int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOtherActionAsTeammateInt32_hotfix != null)
			{
				this.m_SetOtherActionAsTeammateInt32_hotfix.call(new object[]
				{
					this,
					playerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_actionPlayerEnemyUIStateController.SetToUIState("Friend", false, true);
			this.m_actionPlayerTagImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetBattlePlayerTagImageName(playerIndex));
		}

		// Token: 0x0600B238 RID: 45624 RVA: 0x003150A8 File Offset: 0x003132A8
		public void SetOtherActionAsEnemy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOtherActionAsEnemy_hotfix != null)
			{
				this.m_SetOtherActionAsEnemy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_actionPlayerEnemyUIStateController.SetToUIState("Enemy", false, true);
		}

		// Token: 0x0600B239 RID: 45625 RVA: 0x0031511C File Offset: 0x0031331C
		public void ShowOtherActionCountdown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowOtherActionCountdown_hotfix != null)
			{
				this.m_ShowOtherActionCountdown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_actionPlayerUIStateController, "Show", null, false, false);
		}

		// Token: 0x0600B23A RID: 45626 RVA: 0x00315190 File Offset: 0x00313390
		public void HideOtherActionCountdown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideOtherActionCountdown_hotfix != null)
			{
				this.m_HideOtherActionCountdown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_actionPlayerUIStateController, "Close", null, false, false);
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x00315204 File Offset: 0x00313404
		public void SetOtherActionCountdown(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetOtherActionCountdownTimeSpan_hotfix != null)
			{
				this.m_SetOtherActionCountdownTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_actionPlayerTimeText.text = Mathf.CeilToInt((float)ts.TotalSeconds).ToString();
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x0031529C File Offset: 0x0031349C
		public void ShowMyActionCountdown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowMyActionCountdown_hotfix != null)
			{
				this.m_ShowMyActionCountdown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_timeGameObject.SetActive(true);
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x00315308 File Offset: 0x00313508
		public void HideMyActionCountdown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HideMyActionCountdown_hotfix != null)
			{
				this.m_HideMyActionCountdown_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_timeGameObject.SetActive(false);
			this.m_bigTimeUIStateController.gameObject.SetActive(false);
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x00315388 File Offset: 0x00313588
		public void SetMyActionCountdown(TimeSpan ts)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMyActionCountdownTimeSpan_hotfix != null)
			{
				this.m_SetMyActionCountdownTimeSpan_hotfix.call(new object[]
				{
					this,
					ts
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = Mathf.CeilToInt((float)ts.TotalSeconds);
			this.m_timeText.text = num.ToString();
			ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
			if (this.m_timeGameObject.activeSelf && num <= clientConfigDataLoader.ConfigableConstId_BattleRoomPlayerActionCountdownBigNumberTime)
			{
				UIUtility.SetUIStateOpen(this.m_bigTimeUIStateController, "Show", delegate
				{
					this.m_bigTimeUIStateController.gameObject.SetActive(false);
				}, false, true);
				this.m_bigTimeText.text = num.ToString();
			}
		}

		// Token: 0x0600B23F RID: 45631 RVA: 0x00315480 File Offset: 0x00313680
		public void SetCanUseChat(bool canChat)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCanUseChatBoolean_hotfix != null)
			{
				this.m_SetCanUseChatBoolean_hotfix.call(new object[]
				{
					this,
					canChat
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatEmptyGameObject.gameObject.SetActive(canChat);
			this.TalkButton.gameObject.SetActive(canChat);
		}

		// Token: 0x0600B240 RID: 45632 RVA: 0x00315514 File Offset: 0x00313714
		private void OnExpressionButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExpressionButtonClick_hotfix != null)
			{
				this.m_OnExpressionButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool active = !this.m_expressionGroup.activeSelf;
			this.m_expressionGroup.SetActive(active);
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x00315590 File Offset: 0x00313790
		private void OnBigExpressionClick(int id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBigExpressionClickInt32_hotfix != null)
			{
				this.m_OnBigExpressionClickInt32_hotfix.call(new object[]
				{
					this,
					id
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_expressionGroup.SetActive(false);
		}

		// Token: 0x0600B242 RID: 45634 RVA: 0x0031560C File Offset: 0x0031380C
		private void OnBigExpressionBGClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBigExpressionBGClick_hotfix != null)
			{
				this.m_OnBigExpressionBGClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_expressionGroup.SetActive(false);
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x0600B243 RID: 45635 RVA: 0x00315678 File Offset: 0x00313878
		// (set) Token: 0x0600B244 RID: 45636 RVA: 0x00315698 File Offset: 0x00313898
		[DoNotToLua]
		public new BattleRoomUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleRoomUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B245 RID: 45637 RVA: 0x003156A4 File Offset: 0x003138A4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600B246 RID: 45638 RVA: 0x003156B0 File Offset: 0x003138B0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600B247 RID: 45639 RVA: 0x003156B8 File Offset: 0x003138B8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600B248 RID: 45640 RVA: 0x003156C0 File Offset: 0x003138C0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600B249 RID: 45641 RVA: 0x003156D4 File Offset: 0x003138D4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600B24A RID: 45642 RVA: 0x003156DC File Offset: 0x003138DC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600B24B RID: 45643 RVA: 0x003156E8 File Offset: 0x003138E8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600B24C RID: 45644 RVA: 0x003156F4 File Offset: 0x003138F4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600B24D RID: 45645 RVA: 0x00315700 File Offset: 0x00313900
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600B24E RID: 45646 RVA: 0x0031570C File Offset: 0x0031390C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600B24F RID: 45647 RVA: 0x00315718 File Offset: 0x00313918
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600B250 RID: 45648 RVA: 0x00315724 File Offset: 0x00313924
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600B251 RID: 45649 RVA: 0x00315730 File Offset: 0x00313930
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600B252 RID: 45650 RVA: 0x0031573C File Offset: 0x0031393C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600B253 RID: 45651 RVA: 0x00315748 File Offset: 0x00313948
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600B255 RID: 45653 RVA: 0x00315764 File Offset: 0x00313964
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
					this.m_StartBattle_hotfix = (luaObj.RawGet("StartBattle") as LuaFunction);
					this.m_AddPlayersBattleRoom_hotfix = (luaObj.RawGet("AddPlayers") as LuaFunction);
					this.m_AddPlayerBattleRoomPlayerInt32Boolean_hotfix = (luaObj.RawGet("AddPlayer") as LuaFunction);
					this.m_ClearPlayers_hotfix = (luaObj.RawGet("ClearPlayers") as LuaFunction);
					this.m_SetPlayerStatusInt32PlayerBattleStatusBoolean_hotfix = (luaObj.RawGet("SetPlayerStatus") as LuaFunction);
					this.m_SetPlayerActionInt32Boolean_hotfix = (luaObj.RawGet("SetPlayerAction") as LuaFunction);
					this.m_SetPlayerHeroAliveInt32Int32Boolean_hotfix = (luaObj.RawGet("SetPlayerHeroAlive") as LuaFunction);
					this.m_ShowPlayerChatInt32String_hotfix = (luaObj.RawGet("ShowPlayerChat") as LuaFunction);
					this.m_ShowPlayerExpressionInt32Int32_hotfix = (luaObj.RawGet("ShowPlayerExpression") as LuaFunction);
					this.m_ShowPlayerVoiceInt32ChatVoiceMessage_hotfix = (luaObj.RawGet("ShowPlayerVoice") as LuaFunction);
					this.m_GetPlayerUIControllerInt32_hotfix = (luaObj.RawGet("GetPlayerUIController") as LuaFunction);
					this.m_SetOtherActionAsTeammateInt32_hotfix = (luaObj.RawGet("SetOtherActionAsTeammate") as LuaFunction);
					this.m_SetOtherActionAsEnemy_hotfix = (luaObj.RawGet("SetOtherActionAsEnemy") as LuaFunction);
					this.m_ShowOtherActionCountdown_hotfix = (luaObj.RawGet("ShowOtherActionCountdown") as LuaFunction);
					this.m_HideOtherActionCountdown_hotfix = (luaObj.RawGet("HideOtherActionCountdown") as LuaFunction);
					this.m_SetOtherActionCountdownTimeSpan_hotfix = (luaObj.RawGet("SetOtherActionCountdown") as LuaFunction);
					this.m_ShowMyActionCountdown_hotfix = (luaObj.RawGet("ShowMyActionCountdown") as LuaFunction);
					this.m_HideMyActionCountdown_hotfix = (luaObj.RawGet("HideMyActionCountdown") as LuaFunction);
					this.m_SetMyActionCountdownTimeSpan_hotfix = (luaObj.RawGet("SetMyActionCountdown") as LuaFunction);
					this.m_SetCanUseChatBoolean_hotfix = (luaObj.RawGet("SetCanUseChat") as LuaFunction);
					this.m_OnExpressionButtonClick_hotfix = (luaObj.RawGet("OnExpressionButtonClick") as LuaFunction);
					this.m_OnBigExpressionClickInt32_hotfix = (luaObj.RawGet("OnBigExpressionClick") as LuaFunction);
					this.m_OnBigExpressionBGClick_hotfix = (luaObj.RawGet("OnBigExpressionBGClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B256 RID: 45654 RVA: 0x00315A70 File Offset: 0x00313C70
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040073BC RID: 29628
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private RectTransform m_marginTransform;

		// Token: 0x040073BD RID: 29629
		[AutoBind("/PlayerGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerGroupGameObject;

		// Token: 0x040073BE RID: 29630
		[AutoBind("./ExpressionGroup/Empty", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_chatEmptyGameObject;

		// Token: 0x040073BF RID: 29631
		[AutoBind("./ExpressionGroup/ExpressionButton", AutoBindAttribute.InitState.NotInit, false)]
		private ButtonEx m_expressionButton;

		// Token: 0x040073C0 RID: 29632
		[AutoBind("./ExpressionGroup/TalkButton", AutoBindAttribute.InitState.NotInit, false)]
		public Button TalkButton;

		// Token: 0x040073C1 RID: 29633
		[AutoBind("./ExpressionGroupDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_expressionGroup;

		// Token: 0x040073C2 RID: 29634
		[AutoBind("./ExpressionGroupDummy/BGMask", AutoBindAttribute.InitState.NotInit, false)]
		private ButtonEx ButtonBGMask;

		// Token: 0x040073C3 RID: 29635
		[AutoBind("./TimeGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_timeGameObject;

		// Token: 0x040073C4 RID: 29636
		[AutoBind("./TimeGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeText;

		// Token: 0x040073C5 RID: 29637
		[AutoBind("./BigNumberEffect", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_bigTimeUIStateController;

		// Token: 0x040073C6 RID: 29638
		[AutoBind("./BigNumberEffect/Number", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_bigTimeText;

		// Token: 0x040073C7 RID: 29639
		[AutoBind("./ActionPlayer", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actionPlayerUIStateController;

		// Token: 0x040073C8 RID: 29640
		[AutoBind("./ActionPlayer/Image", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_actionPlayerEnemyUIStateController;

		// Token: 0x040073C9 RID: 29641
		[AutoBind("./ActionPlayer/PlayerTag", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_actionPlayerTagImage;

		// Token: 0x040073CA RID: 29642
		[AutoBind("./ActionPlayer/TimeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_actionPlayerTimeText;

		// Token: 0x040073CB RID: 29643
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x040073CC RID: 29644
		[AutoBind("./Prefabs/BattleTeamPlayer", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_battleTeamPlayerPrefab;

		// Token: 0x040073CD RID: 29645
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.NotInit, false)]
		private SmallExpressionParseDesc m_expressionParseDesc;

		// Token: 0x040073CE RID: 29646
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.NotInit, false)]
		private PrefabResourceContainer m_expressionResContainer;

		// Token: 0x040073CF RID: 29647
		private List<BattleTeamPlayerUIController> m_players = new List<BattleTeamPlayerUIController>();

		// Token: 0x040073D0 RID: 29648
		private BigExpressionController m_bigExpressionCtrl;

		// Token: 0x040073D1 RID: 29649
		[DoNotToLua]
		private BattleRoomUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040073D2 RID: 29650
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040073D3 RID: 29651
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040073D4 RID: 29652
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040073D5 RID: 29653
		private LuaFunction m_StartBattle_hotfix;

		// Token: 0x040073D6 RID: 29654
		private LuaFunction m_AddPlayersBattleRoom_hotfix;

		// Token: 0x040073D7 RID: 29655
		private LuaFunction m_AddPlayerBattleRoomPlayerInt32Boolean_hotfix;

		// Token: 0x040073D8 RID: 29656
		private LuaFunction m_ClearPlayers_hotfix;

		// Token: 0x040073D9 RID: 29657
		private LuaFunction m_SetPlayerStatusInt32PlayerBattleStatusBoolean_hotfix;

		// Token: 0x040073DA RID: 29658
		private LuaFunction m_SetPlayerActionInt32Boolean_hotfix;

		// Token: 0x040073DB RID: 29659
		private LuaFunction m_SetPlayerHeroAliveInt32Int32Boolean_hotfix;

		// Token: 0x040073DC RID: 29660
		private LuaFunction m_ShowPlayerChatInt32String_hotfix;

		// Token: 0x040073DD RID: 29661
		private LuaFunction m_ShowPlayerExpressionInt32Int32_hotfix;

		// Token: 0x040073DE RID: 29662
		private LuaFunction m_ShowPlayerVoiceInt32ChatVoiceMessage_hotfix;

		// Token: 0x040073DF RID: 29663
		private LuaFunction m_GetPlayerUIControllerInt32_hotfix;

		// Token: 0x040073E0 RID: 29664
		private LuaFunction m_SetOtherActionAsTeammateInt32_hotfix;

		// Token: 0x040073E1 RID: 29665
		private LuaFunction m_SetOtherActionAsEnemy_hotfix;

		// Token: 0x040073E2 RID: 29666
		private LuaFunction m_ShowOtherActionCountdown_hotfix;

		// Token: 0x040073E3 RID: 29667
		private LuaFunction m_HideOtherActionCountdown_hotfix;

		// Token: 0x040073E4 RID: 29668
		private LuaFunction m_SetOtherActionCountdownTimeSpan_hotfix;

		// Token: 0x040073E5 RID: 29669
		private LuaFunction m_ShowMyActionCountdown_hotfix;

		// Token: 0x040073E6 RID: 29670
		private LuaFunction m_HideMyActionCountdown_hotfix;

		// Token: 0x040073E7 RID: 29671
		private LuaFunction m_SetMyActionCountdownTimeSpan_hotfix;

		// Token: 0x040073E8 RID: 29672
		private LuaFunction m_SetCanUseChatBoolean_hotfix;

		// Token: 0x040073E9 RID: 29673
		private LuaFunction m_OnExpressionButtonClick_hotfix;

		// Token: 0x040073EA RID: 29674
		private LuaFunction m_OnBigExpressionClickInt32_hotfix;

		// Token: 0x040073EB RID: 29675
		private LuaFunction m_OnBigExpressionBGClick_hotfix;

		// Token: 0x02000AC5 RID: 2757
		public new class LuaExportHelper
		{
			// Token: 0x0600B257 RID: 45655 RVA: 0x00315AD8 File Offset: 0x00313CD8
			public LuaExportHelper(BattleRoomUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B258 RID: 45656 RVA: 0x00315AE8 File Offset: 0x00313CE8
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600B259 RID: 45657 RVA: 0x00315AF8 File Offset: 0x00313CF8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600B25A RID: 45658 RVA: 0x00315B08 File Offset: 0x00313D08
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600B25B RID: 45659 RVA: 0x00315B18 File Offset: 0x00313D18
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600B25C RID: 45660 RVA: 0x00315B30 File Offset: 0x00313D30
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600B25D RID: 45661 RVA: 0x00315B40 File Offset: 0x00313D40
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600B25E RID: 45662 RVA: 0x00315B50 File Offset: 0x00313D50
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600B25F RID: 45663 RVA: 0x00315B60 File Offset: 0x00313D60
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600B260 RID: 45664 RVA: 0x00315B70 File Offset: 0x00313D70
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600B261 RID: 45665 RVA: 0x00315B80 File Offset: 0x00313D80
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600B262 RID: 45666 RVA: 0x00315B90 File Offset: 0x00313D90
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600B263 RID: 45667 RVA: 0x00315BA0 File Offset: 0x00313DA0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600B264 RID: 45668 RVA: 0x00315BB0 File Offset: 0x00313DB0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600B265 RID: 45669 RVA: 0x00315BC0 File Offset: 0x00313DC0
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600B266 RID: 45670 RVA: 0x00315BD0 File Offset: 0x00313DD0
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002416 RID: 9238
			// (get) Token: 0x0600B267 RID: 45671 RVA: 0x00315BE0 File Offset: 0x00313DE0
			// (set) Token: 0x0600B268 RID: 45672 RVA: 0x00315BF0 File Offset: 0x00313DF0
			public RectTransform m_marginTransform
			{
				get
				{
					return this.m_owner.m_marginTransform;
				}
				set
				{
					this.m_owner.m_marginTransform = value;
				}
			}

			// Token: 0x17002417 RID: 9239
			// (get) Token: 0x0600B269 RID: 45673 RVA: 0x00315C00 File Offset: 0x00313E00
			// (set) Token: 0x0600B26A RID: 45674 RVA: 0x00315C10 File Offset: 0x00313E10
			public GameObject m_playerGroupGameObject
			{
				get
				{
					return this.m_owner.m_playerGroupGameObject;
				}
				set
				{
					this.m_owner.m_playerGroupGameObject = value;
				}
			}

			// Token: 0x17002418 RID: 9240
			// (get) Token: 0x0600B26B RID: 45675 RVA: 0x00315C20 File Offset: 0x00313E20
			// (set) Token: 0x0600B26C RID: 45676 RVA: 0x00315C30 File Offset: 0x00313E30
			public GameObject m_chatEmptyGameObject
			{
				get
				{
					return this.m_owner.m_chatEmptyGameObject;
				}
				set
				{
					this.m_owner.m_chatEmptyGameObject = value;
				}
			}

			// Token: 0x17002419 RID: 9241
			// (get) Token: 0x0600B26D RID: 45677 RVA: 0x00315C40 File Offset: 0x00313E40
			// (set) Token: 0x0600B26E RID: 45678 RVA: 0x00315C50 File Offset: 0x00313E50
			public ButtonEx m_expressionButton
			{
				get
				{
					return this.m_owner.m_expressionButton;
				}
				set
				{
					this.m_owner.m_expressionButton = value;
				}
			}

			// Token: 0x1700241A RID: 9242
			// (get) Token: 0x0600B26F RID: 45679 RVA: 0x00315C60 File Offset: 0x00313E60
			// (set) Token: 0x0600B270 RID: 45680 RVA: 0x00315C70 File Offset: 0x00313E70
			public GameObject m_expressionGroup
			{
				get
				{
					return this.m_owner.m_expressionGroup;
				}
				set
				{
					this.m_owner.m_expressionGroup = value;
				}
			}

			// Token: 0x1700241B RID: 9243
			// (get) Token: 0x0600B271 RID: 45681 RVA: 0x00315C80 File Offset: 0x00313E80
			// (set) Token: 0x0600B272 RID: 45682 RVA: 0x00315C90 File Offset: 0x00313E90
			public ButtonEx ButtonBGMask
			{
				get
				{
					return this.m_owner.ButtonBGMask;
				}
				set
				{
					this.m_owner.ButtonBGMask = value;
				}
			}

			// Token: 0x1700241C RID: 9244
			// (get) Token: 0x0600B273 RID: 45683 RVA: 0x00315CA0 File Offset: 0x00313EA0
			// (set) Token: 0x0600B274 RID: 45684 RVA: 0x00315CB0 File Offset: 0x00313EB0
			public GameObject m_timeGameObject
			{
				get
				{
					return this.m_owner.m_timeGameObject;
				}
				set
				{
					this.m_owner.m_timeGameObject = value;
				}
			}

			// Token: 0x1700241D RID: 9245
			// (get) Token: 0x0600B275 RID: 45685 RVA: 0x00315CC0 File Offset: 0x00313EC0
			// (set) Token: 0x0600B276 RID: 45686 RVA: 0x00315CD0 File Offset: 0x00313ED0
			public Text m_timeText
			{
				get
				{
					return this.m_owner.m_timeText;
				}
				set
				{
					this.m_owner.m_timeText = value;
				}
			}

			// Token: 0x1700241E RID: 9246
			// (get) Token: 0x0600B277 RID: 45687 RVA: 0x00315CE0 File Offset: 0x00313EE0
			// (set) Token: 0x0600B278 RID: 45688 RVA: 0x00315CF0 File Offset: 0x00313EF0
			public CommonUIStateController m_bigTimeUIStateController
			{
				get
				{
					return this.m_owner.m_bigTimeUIStateController;
				}
				set
				{
					this.m_owner.m_bigTimeUIStateController = value;
				}
			}

			// Token: 0x1700241F RID: 9247
			// (get) Token: 0x0600B279 RID: 45689 RVA: 0x00315D00 File Offset: 0x00313F00
			// (set) Token: 0x0600B27A RID: 45690 RVA: 0x00315D10 File Offset: 0x00313F10
			public Text m_bigTimeText
			{
				get
				{
					return this.m_owner.m_bigTimeText;
				}
				set
				{
					this.m_owner.m_bigTimeText = value;
				}
			}

			// Token: 0x17002420 RID: 9248
			// (get) Token: 0x0600B27B RID: 45691 RVA: 0x00315D20 File Offset: 0x00313F20
			// (set) Token: 0x0600B27C RID: 45692 RVA: 0x00315D30 File Offset: 0x00313F30
			public CommonUIStateController m_actionPlayerUIStateController
			{
				get
				{
					return this.m_owner.m_actionPlayerUIStateController;
				}
				set
				{
					this.m_owner.m_actionPlayerUIStateController = value;
				}
			}

			// Token: 0x17002421 RID: 9249
			// (get) Token: 0x0600B27D RID: 45693 RVA: 0x00315D40 File Offset: 0x00313F40
			// (set) Token: 0x0600B27E RID: 45694 RVA: 0x00315D50 File Offset: 0x00313F50
			public CommonUIStateController m_actionPlayerEnemyUIStateController
			{
				get
				{
					return this.m_owner.m_actionPlayerEnemyUIStateController;
				}
				set
				{
					this.m_owner.m_actionPlayerEnemyUIStateController = value;
				}
			}

			// Token: 0x17002422 RID: 9250
			// (get) Token: 0x0600B27F RID: 45695 RVA: 0x00315D60 File Offset: 0x00313F60
			// (set) Token: 0x0600B280 RID: 45696 RVA: 0x00315D70 File Offset: 0x00313F70
			public Image m_actionPlayerTagImage
			{
				get
				{
					return this.m_owner.m_actionPlayerTagImage;
				}
				set
				{
					this.m_owner.m_actionPlayerTagImage = value;
				}
			}

			// Token: 0x17002423 RID: 9251
			// (get) Token: 0x0600B281 RID: 45697 RVA: 0x00315D80 File Offset: 0x00313F80
			// (set) Token: 0x0600B282 RID: 45698 RVA: 0x00315D90 File Offset: 0x00313F90
			public Text m_actionPlayerTimeText
			{
				get
				{
					return this.m_owner.m_actionPlayerTimeText;
				}
				set
				{
					this.m_owner.m_actionPlayerTimeText = value;
				}
			}

			// Token: 0x17002424 RID: 9252
			// (get) Token: 0x0600B283 RID: 45699 RVA: 0x00315DA0 File Offset: 0x00313FA0
			// (set) Token: 0x0600B284 RID: 45700 RVA: 0x00315DB0 File Offset: 0x00313FB0
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x17002425 RID: 9253
			// (get) Token: 0x0600B285 RID: 45701 RVA: 0x00315DC0 File Offset: 0x00313FC0
			// (set) Token: 0x0600B286 RID: 45702 RVA: 0x00315DD0 File Offset: 0x00313FD0
			public GameObject m_battleTeamPlayerPrefab
			{
				get
				{
					return this.m_owner.m_battleTeamPlayerPrefab;
				}
				set
				{
					this.m_owner.m_battleTeamPlayerPrefab = value;
				}
			}

			// Token: 0x17002426 RID: 9254
			// (get) Token: 0x0600B287 RID: 45703 RVA: 0x00315DE0 File Offset: 0x00313FE0
			// (set) Token: 0x0600B288 RID: 45704 RVA: 0x00315DF0 File Offset: 0x00313FF0
			public SmallExpressionParseDesc m_expressionParseDesc
			{
				get
				{
					return this.m_owner.m_expressionParseDesc;
				}
				set
				{
					this.m_owner.m_expressionParseDesc = value;
				}
			}

			// Token: 0x17002427 RID: 9255
			// (get) Token: 0x0600B289 RID: 45705 RVA: 0x00315E00 File Offset: 0x00314000
			// (set) Token: 0x0600B28A RID: 45706 RVA: 0x00315E10 File Offset: 0x00314010
			public PrefabResourceContainer m_expressionResContainer
			{
				get
				{
					return this.m_owner.m_expressionResContainer;
				}
				set
				{
					this.m_owner.m_expressionResContainer = value;
				}
			}

			// Token: 0x17002428 RID: 9256
			// (get) Token: 0x0600B28B RID: 45707 RVA: 0x00315E20 File Offset: 0x00314020
			// (set) Token: 0x0600B28C RID: 45708 RVA: 0x00315E30 File Offset: 0x00314030
			public List<BattleTeamPlayerUIController> m_players
			{
				get
				{
					return this.m_owner.m_players;
				}
				set
				{
					this.m_owner.m_players = value;
				}
			}

			// Token: 0x17002429 RID: 9257
			// (get) Token: 0x0600B28D RID: 45709 RVA: 0x00315E40 File Offset: 0x00314040
			// (set) Token: 0x0600B28E RID: 45710 RVA: 0x00315E50 File Offset: 0x00314050
			public BigExpressionController m_bigExpressionCtrl
			{
				get
				{
					return this.m_owner.m_bigExpressionCtrl;
				}
				set
				{
					this.m_owner.m_bigExpressionCtrl = value;
				}
			}

			// Token: 0x0600B28F RID: 45711 RVA: 0x00315E60 File Offset: 0x00314060
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600B290 RID: 45712 RVA: 0x00315E70 File Offset: 0x00314070
			public void AddPlayer(BattleRoomPlayer player, int heroCount, bool showPlayerIndex)
			{
				this.m_owner.AddPlayer(player, heroCount, showPlayerIndex);
			}

			// Token: 0x0600B291 RID: 45713 RVA: 0x00315E80 File Offset: 0x00314080
			public void ClearPlayers()
			{
				this.m_owner.ClearPlayers();
			}

			// Token: 0x0600B292 RID: 45714 RVA: 0x00315E90 File Offset: 0x00314090
			public BattleTeamPlayerUIController GetPlayerUIController(int playerIndex)
			{
				return this.m_owner.GetPlayerUIController(playerIndex);
			}

			// Token: 0x0600B293 RID: 45715 RVA: 0x00315EA0 File Offset: 0x003140A0
			public void OnExpressionButtonClick()
			{
				this.m_owner.OnExpressionButtonClick();
			}

			// Token: 0x0600B294 RID: 45716 RVA: 0x00315EB0 File Offset: 0x003140B0
			public void OnBigExpressionClick(int id)
			{
				this.m_owner.OnBigExpressionClick(id);
			}

			// Token: 0x0600B295 RID: 45717 RVA: 0x00315EC0 File Offset: 0x003140C0
			public void OnBigExpressionBGClick()
			{
				this.m_owner.OnBigExpressionBGClick();
			}

			// Token: 0x040073EC RID: 29676
			private BattleRoomUIController m_owner;
		}
	}
}
