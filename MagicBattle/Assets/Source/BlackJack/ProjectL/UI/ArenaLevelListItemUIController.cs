using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A2C RID: 2604
	[HotFix]
	public class ArenaLevelListItemUIController : UIControllerBase
	{
		// Token: 0x06009F69 RID: 40809 RVA: 0x002D0E50 File Offset: 0x002CF050
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
		}

		// Token: 0x06009F6A RID: 40810 RVA: 0x002D0EB8 File Offset: 0x002CF0B8
		public void SetArenaLevelInfo(ConfigDataArenaLevelInfo arenaLevelInfo, GameObject rewardGoodsPrefab, int playerArenaLevelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaLevelInfoConfigDataArenaLevelInfoGameObjectInt32_hotfix != null)
			{
				this.m_SetArenaLevelInfoConfigDataArenaLevelInfoGameObjectInt32_hotfix.call(new object[]
				{
					this,
					arenaLevelInfo,
					rewardGoodsPrefab,
					playerArenaLevelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			GameObjectUtility.DestroyChildren(this.m_lowRewardGroupGameObject);
			GameObjectUtility.DestroyChildren(this.m_middleRewardGroupGameObject);
			GameObjectUtility.DestroyChildren(this.m_highRewardGroupGameObject);
			GameObjectUtility.DestroyChildren(this.m_topRewardGroupGameObject);
			ConfigDataMailInfo configDataMailInfo = configDataLoader.GetConfigDataMailInfo(arenaLevelInfo.LevelRewardMailTemplateId);
			if (arenaLevelInfo.ID == 1 || arenaLevelInfo.ID == 2 || arenaLevelInfo.ID == 3)
			{
				this.m_arenaLevelUIStateCtrl.SetToUIState("Low", false, true);
				this.m_lowLevelUIStateCtrl.SetToUIState("ArenalLevel" + arenaLevelInfo.ID, false, true);
				this.m_lowLevelIconImage.sprite = AssetUtility.Instance.GetSprite(arenaLevelInfo.Icon);
				this.m_lowLevelText.text = arenaLevelInfo.Name;
				this.m_lowArenaPointText.text = arenaLevelInfo.UpgradePoints.ToString();
				if (arenaLevelInfo.ID == playerArenaLevelId)
				{
					this.m_lowUIStateCtrl.SetToUIState("Now", false, true);
				}
				else if (arenaLevelInfo.ID % 2 == 0)
				{
					this.m_lowUIStateCtrl.SetToUIState("Color", false, true);
				}
				else
				{
					this.m_lowUIStateCtrl.SetToUIState("None", false, true);
				}
				if (configDataMailInfo != null)
				{
					RewardGoodsUIController.CreateRewardGoodsList(configDataMailInfo.Attachments, this.m_lowRewardGroupGameObject.transform, rewardGoodsPrefab, null, true, 0, true);
				}
			}
			else if (arenaLevelInfo.ID == 4 || arenaLevelInfo.ID == 5 || arenaLevelInfo.ID == 6)
			{
				this.m_arenaLevelUIStateCtrl.SetToUIState("Middle", false, true);
				this.m_middleLevelUIStateCtrl.SetToUIState("ArenalLevel" + arenaLevelInfo.ID, false, true);
				this.m_middleLevelIconImage.sprite = AssetUtility.Instance.GetSprite(arenaLevelInfo.Icon);
				this.m_middleLevelText.text = arenaLevelInfo.Name;
				this.m_middleArenaPointText.text = arenaLevelInfo.UpgradePoints.ToString();
				if (arenaLevelInfo.ID == playerArenaLevelId)
				{
					this.m_middleUIStateCtrl.SetToUIState("Now", false, true);
				}
				else if (arenaLevelInfo.ID % 2 == 0)
				{
					this.m_middleUIStateCtrl.SetToUIState("Color", false, true);
				}
				else
				{
					this.m_middleUIStateCtrl.SetToUIState("None", false, true);
				}
				if (configDataMailInfo != null)
				{
					RewardGoodsUIController.CreateRewardGoodsList(configDataMailInfo.Attachments, this.m_middleRewardGroupGameObject.transform, rewardGoodsPrefab, null, true, 0, true);
				}
			}
			else if (arenaLevelInfo.ID == 7 || arenaLevelInfo.ID == 8 || arenaLevelInfo.ID == 9)
			{
				this.m_arenaLevelUIStateCtrl.SetToUIState("High", false, true);
				this.m_highLevelUIStateCtrl.SetToUIState("ArenalLevel" + arenaLevelInfo.ID, false, true);
				this.m_highLevelIconImage.sprite = AssetUtility.Instance.GetSprite(arenaLevelInfo.Icon);
				this.m_highLevelText.text = arenaLevelInfo.Name;
				this.m_highArenaPointText.text = arenaLevelInfo.UpgradePoints.ToString();
				if (arenaLevelInfo.ID == playerArenaLevelId)
				{
					this.m_highUIStateCtrl.SetToUIState("Now", false, true);
				}
				else if (arenaLevelInfo.ID % 2 == 0)
				{
					this.m_highUIStateCtrl.SetToUIState("Color", false, true);
				}
				else
				{
					this.m_highUIStateCtrl.SetToUIState("None", false, true);
				}
				if (configDataMailInfo != null)
				{
					RewardGoodsUIController.CreateRewardGoodsList(configDataMailInfo.Attachments, this.m_highRewardGroupGameObject.transform, rewardGoodsPrefab, null, true, 0, true);
				}
			}
			else if (arenaLevelInfo.ID == 10)
			{
				this.m_arenaLevelUIStateCtrl.SetToUIState("Top", false, true);
				this.m_topLevelIconImage.sprite = AssetUtility.Instance.GetSprite(arenaLevelInfo.Icon);
				this.m_topLevelText.text = arenaLevelInfo.Name;
				this.m_topArenaPointText.text = arenaLevelInfo.UpgradePoints.ToString();
				if (arenaLevelInfo.ID == playerArenaLevelId)
				{
					this.m_topUIStateCtrl.SetToUIState("Now", false, true);
				}
				else if (arenaLevelInfo.ID % 2 == 0)
				{
					this.m_topUIStateCtrl.SetToUIState("Color", false, true);
				}
				else
				{
					this.m_topUIStateCtrl.SetToUIState("None", false, true);
				}
				if (configDataMailInfo != null)
				{
					RewardGoodsUIController.CreateRewardGoodsList(configDataMailInfo.Attachments, this.m_topRewardGroupGameObject.transform, rewardGoodsPrefab, null, true, 0, true);
				}
			}
		}

		// Token: 0x06009F6B RID: 40811 RVA: 0x002D13E0 File Offset: 0x002CF5E0
		public void SetDanInfo(ConfigDataRealTimePVPDanInfo danInfo, GameObject rewardGoodsPrefab, int playerDanId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDanInfoConfigDataRealTimePVPDanInfoGameObjectInt32_hotfix != null)
			{
				this.m_SetDanInfoConfigDataRealTimePVPDanInfoGameObjectInt32_hotfix.call(new object[]
				{
					this,
					danInfo,
					rewardGoodsPrefab,
					playerDanId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataMailInfo configDataMailInfo = null;
			ConfigDataRealTimePVPDanRewardInfo configDataRealTimePVPDanRewardInfo = configDataLoader.GetConfigDataRealTimePVPDanRewardInfo(danInfo.ID);
			if (configDataRealTimePVPDanRewardInfo != null)
			{
				configDataMailInfo = configDataLoader.GetConfigDataMailInfo(configDataRealTimePVPDanRewardInfo.DanRewardMailTemplateId);
			}
			GameObjectUtility.DestroyChildren(this.m_lowRewardGroupGameObject);
			GameObjectUtility.DestroyChildren(this.m_middleRewardGroupGameObject);
			GameObjectUtility.DestroyChildren(this.m_highRewardGroupGameObject);
			GameObjectUtility.DestroyChildren(this.m_topRewardGroupGameObject);
			if (danInfo.ID == 1 || danInfo.ID == 2 || danInfo.ID == 3)
			{
				this.m_arenaLevelUIStateCtrl.SetToUIState("Low", false, true);
				this.m_lowLevelUIStateCtrl.SetToUIState("ArenalLevel" + danInfo.ID, false, true);
				this.m_lowLevelIconImage.sprite = AssetUtility.Instance.GetSprite(danInfo.Icon);
				this.m_lowLevelText.text = danInfo.Name;
				this.m_lowArenaPointText.text = danInfo.RelegationScore.ToString();
				if (danInfo.ID == playerDanId)
				{
					this.m_lowUIStateCtrl.SetToUIState("Now", false, true);
				}
				else if (danInfo.ID % 2 == 0)
				{
					this.m_lowUIStateCtrl.SetToUIState("Color", false, true);
				}
				else
				{
					this.m_lowUIStateCtrl.SetToUIState("None", false, true);
				}
				if (configDataMailInfo != null)
				{
					RewardGoodsUIController.CreateRewardGoodsList(configDataMailInfo.Attachments, this.m_lowRewardGroupGameObject.transform, rewardGoodsPrefab, null, true, 0, true);
				}
			}
			else if (danInfo.ID == 4 || danInfo.ID == 5 || danInfo.ID == 6)
			{
				this.m_arenaLevelUIStateCtrl.SetToUIState("Middle", false, true);
				this.m_middleLevelUIStateCtrl.SetToUIState("ArenalLevel" + danInfo.ID, false, true);
				this.m_middleLevelIconImage.sprite = AssetUtility.Instance.GetSprite(danInfo.Icon);
				this.m_middleLevelText.text = danInfo.Name;
				this.m_middleArenaPointText.text = danInfo.RelegationScore.ToString();
				if (danInfo.ID == playerDanId)
				{
					this.m_middleUIStateCtrl.SetToUIState("Now", false, true);
				}
				else if (danInfo.ID % 2 == 0)
				{
					this.m_middleUIStateCtrl.SetToUIState("Color", false, true);
				}
				else
				{
					this.m_middleUIStateCtrl.SetToUIState("None", false, true);
				}
				if (configDataMailInfo != null)
				{
					RewardGoodsUIController.CreateRewardGoodsList(configDataMailInfo.Attachments, this.m_middleRewardGroupGameObject.transform, rewardGoodsPrefab, null, true, 0, true);
				}
			}
			else if (danInfo.ID == 7 || danInfo.ID == 8 || danInfo.ID == 9)
			{
				this.m_arenaLevelUIStateCtrl.SetToUIState("High", false, true);
				this.m_highLevelUIStateCtrl.SetToUIState("ArenalLevel" + danInfo.ID, false, true);
				this.m_highLevelIconImage.sprite = AssetUtility.Instance.GetSprite(danInfo.Icon);
				this.m_highLevelText.text = danInfo.Name;
				this.m_highArenaPointText.text = danInfo.RelegationScore.ToString();
				if (danInfo.ID == playerDanId)
				{
					this.m_highUIStateCtrl.SetToUIState("Now", false, true);
				}
				else if (danInfo.ID % 2 == 0)
				{
					this.m_highUIStateCtrl.SetToUIState("Color", false, true);
				}
				else
				{
					this.m_highUIStateCtrl.SetToUIState("None", false, true);
				}
				if (configDataMailInfo != null)
				{
					RewardGoodsUIController.CreateRewardGoodsList(configDataMailInfo.Attachments, this.m_highRewardGroupGameObject.transform, rewardGoodsPrefab, null, true, 0, true);
				}
			}
			else if (danInfo.ID == 10)
			{
				this.m_arenaLevelUIStateCtrl.SetToUIState("Top", false, true);
				this.m_topLevelIconImage.sprite = AssetUtility.Instance.GetSprite(danInfo.Icon);
				this.m_topLevelText.text = danInfo.Name;
				this.m_topArenaPointText.text = danInfo.RelegationScore.ToString();
				if (danInfo.ID == playerDanId)
				{
					this.m_topUIStateCtrl.SetToUIState("Now", false, true);
				}
				else if (danInfo.ID % 2 == 0)
				{
					this.m_topUIStateCtrl.SetToUIState("Color", false, true);
				}
				else
				{
					this.m_topUIStateCtrl.SetToUIState("None", false, true);
				}
				if (configDataMailInfo != null)
				{
					RewardGoodsUIController.CreateRewardGoodsList(configDataMailInfo.Attachments, this.m_topRewardGroupGameObject.transform, rewardGoodsPrefab, null, true, 0, true);
				}
			}
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x06009F6C RID: 40812 RVA: 0x002D191C File Offset: 0x002CFB1C
		// (set) Token: 0x06009F6D RID: 40813 RVA: 0x002D193C File Offset: 0x002CFB3C
		[DoNotToLua]
		public new ArenaLevelListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaLevelListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009F6E RID: 40814 RVA: 0x002D1948 File Offset: 0x002CFB48
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009F6F RID: 40815 RVA: 0x002D1954 File Offset: 0x002CFB54
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009F70 RID: 40816 RVA: 0x002D195C File Offset: 0x002CFB5C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009F71 RID: 40817 RVA: 0x002D1964 File Offset: 0x002CFB64
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009F72 RID: 40818 RVA: 0x002D1978 File Offset: 0x002CFB78
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009F73 RID: 40819 RVA: 0x002D1980 File Offset: 0x002CFB80
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009F74 RID: 40820 RVA: 0x002D198C File Offset: 0x002CFB8C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009F75 RID: 40821 RVA: 0x002D1998 File Offset: 0x002CFB98
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009F76 RID: 40822 RVA: 0x002D19A4 File Offset: 0x002CFBA4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06009F77 RID: 40823 RVA: 0x002D19B0 File Offset: 0x002CFBB0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06009F78 RID: 40824 RVA: 0x002D19BC File Offset: 0x002CFBBC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009F79 RID: 40825 RVA: 0x002D19C8 File Offset: 0x002CFBC8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009F7A RID: 40826 RVA: 0x002D19D4 File Offset: 0x002CFBD4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009F7B RID: 40827 RVA: 0x002D19E0 File Offset: 0x002CFBE0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009F7C RID: 40828 RVA: 0x002D19EC File Offset: 0x002CFBEC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009F7D RID: 40829 RVA: 0x002D19F4 File Offset: 0x002CFBF4
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
					this.m_SetArenaLevelInfoConfigDataArenaLevelInfoGameObjectInt32_hotfix = (luaObj.RawGet("SetArenaLevelInfo") as LuaFunction);
					this.m_SetDanInfoConfigDataRealTimePVPDanInfoGameObjectInt32_hotfix = (luaObj.RawGet("SetDanInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009F7E RID: 40830 RVA: 0x002D1AF4 File Offset: 0x002CFCF4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaLevelListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006B87 RID: 27527
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_arenaLevelUIStateCtrl;

		// Token: 0x04006B88 RID: 27528
		[AutoBind("./Low", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_lowUIStateCtrl;

		// Token: 0x04006B89 RID: 27529
		[AutoBind("./Low/ArenalLevel1_3", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_lowLevelUIStateCtrl;

		// Token: 0x04006B8A RID: 27530
		[AutoBind("./Low/ArenalLevel1_3/LevelIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_lowLevelIconImage;

		// Token: 0x04006B8B RID: 27531
		[AutoBind("./Low/ArenalLevel1_3/LevelIcon/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lowLevelText;

		// Token: 0x04006B8C RID: 27532
		[AutoBind("./Low/ArenalLevel1_3/Reward", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lowRewardGroupGameObject;

		// Token: 0x04006B8D RID: 27533
		[AutoBind("./Low/ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lowArenaPointText;

		// Token: 0x04006B8E RID: 27534
		[AutoBind("./Middle", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_middleUIStateCtrl;

		// Token: 0x04006B8F RID: 27535
		[AutoBind("./Middle/ArenalLevel4_6", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_middleLevelUIStateCtrl;

		// Token: 0x04006B90 RID: 27536
		[AutoBind("./Middle/ArenalLevel4_6/LevelIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_middleLevelIconImage;

		// Token: 0x04006B91 RID: 27537
		[AutoBind("./Middle/ArenalLevel4_6/LevelIcon/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_middleLevelText;

		// Token: 0x04006B92 RID: 27538
		[AutoBind("./Middle/ArenalLevel4_6/Reward", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_middleRewardGroupGameObject;

		// Token: 0x04006B93 RID: 27539
		[AutoBind("./Middle/ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_middleArenaPointText;

		// Token: 0x04006B94 RID: 27540
		[AutoBind("./High", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_highUIStateCtrl;

		// Token: 0x04006B95 RID: 27541
		[AutoBind("./High/ArenalLevel7_9", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_highLevelUIStateCtrl;

		// Token: 0x04006B96 RID: 27542
		[AutoBind("./High/ArenalLevel7_9/LevelIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_highLevelIconImage;

		// Token: 0x04006B97 RID: 27543
		[AutoBind("./High/ArenalLevel7_9/LevelIcon/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_highLevelText;

		// Token: 0x04006B98 RID: 27544
		[AutoBind("./High/ArenalLevel7_9/Reward", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_highRewardGroupGameObject;

		// Token: 0x04006B99 RID: 27545
		[AutoBind("./High/ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_highArenaPointText;

		// Token: 0x04006B9A RID: 27546
		[AutoBind("./Top", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_topUIStateCtrl;

		// Token: 0x04006B9B RID: 27547
		[AutoBind("./Top/ArenalLevel10/LevelIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_topLevelIconImage;

		// Token: 0x04006B9C RID: 27548
		[AutoBind("./Top/ArenalLevel10/LevelIcon/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_topLevelText;

		// Token: 0x04006B9D RID: 27549
		[AutoBind("./Top/ArenalLevel10/Reward", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_topRewardGroupGameObject;

		// Token: 0x04006B9E RID: 27550
		[AutoBind("./Top/ArenaPoints/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_topArenaPointText;

		// Token: 0x04006B9F RID: 27551
		[DoNotToLua]
		private ArenaLevelListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006BA0 RID: 27552
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006BA1 RID: 27553
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006BA2 RID: 27554
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006BA3 RID: 27555
		private LuaFunction m_SetArenaLevelInfoConfigDataArenaLevelInfoGameObjectInt32_hotfix;

		// Token: 0x04006BA4 RID: 27556
		private LuaFunction m_SetDanInfoConfigDataRealTimePVPDanInfoGameObjectInt32_hotfix;

		// Token: 0x02000A2D RID: 2605
		public new class LuaExportHelper
		{
			// Token: 0x06009F7F RID: 40831 RVA: 0x002D1B5C File Offset: 0x002CFD5C
			public LuaExportHelper(ArenaLevelListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009F80 RID: 40832 RVA: 0x002D1B6C File Offset: 0x002CFD6C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06009F81 RID: 40833 RVA: 0x002D1B7C File Offset: 0x002CFD7C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06009F82 RID: 40834 RVA: 0x002D1B8C File Offset: 0x002CFD8C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06009F83 RID: 40835 RVA: 0x002D1B9C File Offset: 0x002CFD9C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06009F84 RID: 40836 RVA: 0x002D1BB4 File Offset: 0x002CFDB4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009F85 RID: 40837 RVA: 0x002D1BC4 File Offset: 0x002CFDC4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009F86 RID: 40838 RVA: 0x002D1BD4 File Offset: 0x002CFDD4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009F87 RID: 40839 RVA: 0x002D1BE4 File Offset: 0x002CFDE4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009F88 RID: 40840 RVA: 0x002D1BF4 File Offset: 0x002CFDF4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009F89 RID: 40841 RVA: 0x002D1C04 File Offset: 0x002CFE04
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009F8A RID: 40842 RVA: 0x002D1C14 File Offset: 0x002CFE14
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009F8B RID: 40843 RVA: 0x002D1C24 File Offset: 0x002CFE24
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009F8C RID: 40844 RVA: 0x002D1C34 File Offset: 0x002CFE34
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009F8D RID: 40845 RVA: 0x002D1C44 File Offset: 0x002CFE44
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009F8E RID: 40846 RVA: 0x002D1C54 File Offset: 0x002CFE54
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700208B RID: 8331
			// (get) Token: 0x06009F8F RID: 40847 RVA: 0x002D1C64 File Offset: 0x002CFE64
			// (set) Token: 0x06009F90 RID: 40848 RVA: 0x002D1C74 File Offset: 0x002CFE74
			public CommonUIStateController m_arenaLevelUIStateCtrl
			{
				get
				{
					return this.m_owner.m_arenaLevelUIStateCtrl;
				}
				set
				{
					this.m_owner.m_arenaLevelUIStateCtrl = value;
				}
			}

			// Token: 0x1700208C RID: 8332
			// (get) Token: 0x06009F91 RID: 40849 RVA: 0x002D1C84 File Offset: 0x002CFE84
			// (set) Token: 0x06009F92 RID: 40850 RVA: 0x002D1C94 File Offset: 0x002CFE94
			public CommonUIStateController m_lowUIStateCtrl
			{
				get
				{
					return this.m_owner.m_lowUIStateCtrl;
				}
				set
				{
					this.m_owner.m_lowUIStateCtrl = value;
				}
			}

			// Token: 0x1700208D RID: 8333
			// (get) Token: 0x06009F93 RID: 40851 RVA: 0x002D1CA4 File Offset: 0x002CFEA4
			// (set) Token: 0x06009F94 RID: 40852 RVA: 0x002D1CB4 File Offset: 0x002CFEB4
			public CommonUIStateController m_lowLevelUIStateCtrl
			{
				get
				{
					return this.m_owner.m_lowLevelUIStateCtrl;
				}
				set
				{
					this.m_owner.m_lowLevelUIStateCtrl = value;
				}
			}

			// Token: 0x1700208E RID: 8334
			// (get) Token: 0x06009F95 RID: 40853 RVA: 0x002D1CC4 File Offset: 0x002CFEC4
			// (set) Token: 0x06009F96 RID: 40854 RVA: 0x002D1CD4 File Offset: 0x002CFED4
			public Image m_lowLevelIconImage
			{
				get
				{
					return this.m_owner.m_lowLevelIconImage;
				}
				set
				{
					this.m_owner.m_lowLevelIconImage = value;
				}
			}

			// Token: 0x1700208F RID: 8335
			// (get) Token: 0x06009F97 RID: 40855 RVA: 0x002D1CE4 File Offset: 0x002CFEE4
			// (set) Token: 0x06009F98 RID: 40856 RVA: 0x002D1CF4 File Offset: 0x002CFEF4
			public Text m_lowLevelText
			{
				get
				{
					return this.m_owner.m_lowLevelText;
				}
				set
				{
					this.m_owner.m_lowLevelText = value;
				}
			}

			// Token: 0x17002090 RID: 8336
			// (get) Token: 0x06009F99 RID: 40857 RVA: 0x002D1D04 File Offset: 0x002CFF04
			// (set) Token: 0x06009F9A RID: 40858 RVA: 0x002D1D14 File Offset: 0x002CFF14
			public GameObject m_lowRewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_lowRewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_lowRewardGroupGameObject = value;
				}
			}

			// Token: 0x17002091 RID: 8337
			// (get) Token: 0x06009F9B RID: 40859 RVA: 0x002D1D24 File Offset: 0x002CFF24
			// (set) Token: 0x06009F9C RID: 40860 RVA: 0x002D1D34 File Offset: 0x002CFF34
			public Text m_lowArenaPointText
			{
				get
				{
					return this.m_owner.m_lowArenaPointText;
				}
				set
				{
					this.m_owner.m_lowArenaPointText = value;
				}
			}

			// Token: 0x17002092 RID: 8338
			// (get) Token: 0x06009F9D RID: 40861 RVA: 0x002D1D44 File Offset: 0x002CFF44
			// (set) Token: 0x06009F9E RID: 40862 RVA: 0x002D1D54 File Offset: 0x002CFF54
			public CommonUIStateController m_middleUIStateCtrl
			{
				get
				{
					return this.m_owner.m_middleUIStateCtrl;
				}
				set
				{
					this.m_owner.m_middleUIStateCtrl = value;
				}
			}

			// Token: 0x17002093 RID: 8339
			// (get) Token: 0x06009F9F RID: 40863 RVA: 0x002D1D64 File Offset: 0x002CFF64
			// (set) Token: 0x06009FA0 RID: 40864 RVA: 0x002D1D74 File Offset: 0x002CFF74
			public CommonUIStateController m_middleLevelUIStateCtrl
			{
				get
				{
					return this.m_owner.m_middleLevelUIStateCtrl;
				}
				set
				{
					this.m_owner.m_middleLevelUIStateCtrl = value;
				}
			}

			// Token: 0x17002094 RID: 8340
			// (get) Token: 0x06009FA1 RID: 40865 RVA: 0x002D1D84 File Offset: 0x002CFF84
			// (set) Token: 0x06009FA2 RID: 40866 RVA: 0x002D1D94 File Offset: 0x002CFF94
			public Image m_middleLevelIconImage
			{
				get
				{
					return this.m_owner.m_middleLevelIconImage;
				}
				set
				{
					this.m_owner.m_middleLevelIconImage = value;
				}
			}

			// Token: 0x17002095 RID: 8341
			// (get) Token: 0x06009FA3 RID: 40867 RVA: 0x002D1DA4 File Offset: 0x002CFFA4
			// (set) Token: 0x06009FA4 RID: 40868 RVA: 0x002D1DB4 File Offset: 0x002CFFB4
			public Text m_middleLevelText
			{
				get
				{
					return this.m_owner.m_middleLevelText;
				}
				set
				{
					this.m_owner.m_middleLevelText = value;
				}
			}

			// Token: 0x17002096 RID: 8342
			// (get) Token: 0x06009FA5 RID: 40869 RVA: 0x002D1DC4 File Offset: 0x002CFFC4
			// (set) Token: 0x06009FA6 RID: 40870 RVA: 0x002D1DD4 File Offset: 0x002CFFD4
			public GameObject m_middleRewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_middleRewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_middleRewardGroupGameObject = value;
				}
			}

			// Token: 0x17002097 RID: 8343
			// (get) Token: 0x06009FA7 RID: 40871 RVA: 0x002D1DE4 File Offset: 0x002CFFE4
			// (set) Token: 0x06009FA8 RID: 40872 RVA: 0x002D1DF4 File Offset: 0x002CFFF4
			public Text m_middleArenaPointText
			{
				get
				{
					return this.m_owner.m_middleArenaPointText;
				}
				set
				{
					this.m_owner.m_middleArenaPointText = value;
				}
			}

			// Token: 0x17002098 RID: 8344
			// (get) Token: 0x06009FA9 RID: 40873 RVA: 0x002D1E04 File Offset: 0x002D0004
			// (set) Token: 0x06009FAA RID: 40874 RVA: 0x002D1E14 File Offset: 0x002D0014
			public CommonUIStateController m_highUIStateCtrl
			{
				get
				{
					return this.m_owner.m_highUIStateCtrl;
				}
				set
				{
					this.m_owner.m_highUIStateCtrl = value;
				}
			}

			// Token: 0x17002099 RID: 8345
			// (get) Token: 0x06009FAB RID: 40875 RVA: 0x002D1E24 File Offset: 0x002D0024
			// (set) Token: 0x06009FAC RID: 40876 RVA: 0x002D1E34 File Offset: 0x002D0034
			public CommonUIStateController m_highLevelUIStateCtrl
			{
				get
				{
					return this.m_owner.m_highLevelUIStateCtrl;
				}
				set
				{
					this.m_owner.m_highLevelUIStateCtrl = value;
				}
			}

			// Token: 0x1700209A RID: 8346
			// (get) Token: 0x06009FAD RID: 40877 RVA: 0x002D1E44 File Offset: 0x002D0044
			// (set) Token: 0x06009FAE RID: 40878 RVA: 0x002D1E54 File Offset: 0x002D0054
			public Image m_highLevelIconImage
			{
				get
				{
					return this.m_owner.m_highLevelIconImage;
				}
				set
				{
					this.m_owner.m_highLevelIconImage = value;
				}
			}

			// Token: 0x1700209B RID: 8347
			// (get) Token: 0x06009FAF RID: 40879 RVA: 0x002D1E64 File Offset: 0x002D0064
			// (set) Token: 0x06009FB0 RID: 40880 RVA: 0x002D1E74 File Offset: 0x002D0074
			public Text m_highLevelText
			{
				get
				{
					return this.m_owner.m_highLevelText;
				}
				set
				{
					this.m_owner.m_highLevelText = value;
				}
			}

			// Token: 0x1700209C RID: 8348
			// (get) Token: 0x06009FB1 RID: 40881 RVA: 0x002D1E84 File Offset: 0x002D0084
			// (set) Token: 0x06009FB2 RID: 40882 RVA: 0x002D1E94 File Offset: 0x002D0094
			public GameObject m_highRewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_highRewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_highRewardGroupGameObject = value;
				}
			}

			// Token: 0x1700209D RID: 8349
			// (get) Token: 0x06009FB3 RID: 40883 RVA: 0x002D1EA4 File Offset: 0x002D00A4
			// (set) Token: 0x06009FB4 RID: 40884 RVA: 0x002D1EB4 File Offset: 0x002D00B4
			public Text m_highArenaPointText
			{
				get
				{
					return this.m_owner.m_highArenaPointText;
				}
				set
				{
					this.m_owner.m_highArenaPointText = value;
				}
			}

			// Token: 0x1700209E RID: 8350
			// (get) Token: 0x06009FB5 RID: 40885 RVA: 0x002D1EC4 File Offset: 0x002D00C4
			// (set) Token: 0x06009FB6 RID: 40886 RVA: 0x002D1ED4 File Offset: 0x002D00D4
			public CommonUIStateController m_topUIStateCtrl
			{
				get
				{
					return this.m_owner.m_topUIStateCtrl;
				}
				set
				{
					this.m_owner.m_topUIStateCtrl = value;
				}
			}

			// Token: 0x1700209F RID: 8351
			// (get) Token: 0x06009FB7 RID: 40887 RVA: 0x002D1EE4 File Offset: 0x002D00E4
			// (set) Token: 0x06009FB8 RID: 40888 RVA: 0x002D1EF4 File Offset: 0x002D00F4
			public Image m_topLevelIconImage
			{
				get
				{
					return this.m_owner.m_topLevelIconImage;
				}
				set
				{
					this.m_owner.m_topLevelIconImage = value;
				}
			}

			// Token: 0x170020A0 RID: 8352
			// (get) Token: 0x06009FB9 RID: 40889 RVA: 0x002D1F04 File Offset: 0x002D0104
			// (set) Token: 0x06009FBA RID: 40890 RVA: 0x002D1F14 File Offset: 0x002D0114
			public Text m_topLevelText
			{
				get
				{
					return this.m_owner.m_topLevelText;
				}
				set
				{
					this.m_owner.m_topLevelText = value;
				}
			}

			// Token: 0x170020A1 RID: 8353
			// (get) Token: 0x06009FBB RID: 40891 RVA: 0x002D1F24 File Offset: 0x002D0124
			// (set) Token: 0x06009FBC RID: 40892 RVA: 0x002D1F34 File Offset: 0x002D0134
			public GameObject m_topRewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_topRewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_topRewardGroupGameObject = value;
				}
			}

			// Token: 0x170020A2 RID: 8354
			// (get) Token: 0x06009FBD RID: 40893 RVA: 0x002D1F44 File Offset: 0x002D0144
			// (set) Token: 0x06009FBE RID: 40894 RVA: 0x002D1F54 File Offset: 0x002D0154
			public Text m_topArenaPointText
			{
				get
				{
					return this.m_owner.m_topArenaPointText;
				}
				set
				{
					this.m_owner.m_topArenaPointText = value;
				}
			}

			// Token: 0x06009FBF RID: 40895 RVA: 0x002D1F64 File Offset: 0x002D0164
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04006BA5 RID: 27557
			private ArenaLevelListItemUIController m_owner;
		}
	}
}
