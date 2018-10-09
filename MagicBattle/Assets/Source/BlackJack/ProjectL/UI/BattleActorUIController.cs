using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A64 RID: 2660
	[HotFix]
	public class BattleActorUIController : UIControllerBase
	{
		// Token: 0x0600A6A4 RID: 42660 RVA: 0x002EBA48 File Offset: 0x002E9C48
		private BattleActorUIController()
		{
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x002EBA68 File Offset: 0x002E9C68
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
			for (int i = 0; i < 3; i++)
			{
				this.m_buffImages[i] = Utility.FindChildComponent<Image>(base.gameObject, "Buff" + i.ToString(), true);
				this.m_buffImages[i].gameObject.SetActive(false);
				this.m_buffTexts[i] = Utility.FindChildComponent<Text>(this.m_buffImages[i].gameObject, "Text", true);
			}
			this.m_npcGameObject.SetActive(false);
			this.m_enforceGameObject.SetActive(false);
			this.m_playerTagImage.gameObject.SetActive(false);
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x002EBB68 File Offset: 0x002E9D68
		public void SetArmyInfo(ConfigDataArmyInfo armyInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArmyInfoConfigDataArmyInfo_hotfix != null)
			{
				this.m_SetArmyInfoConfigDataArmyInfo_hotfix.call(new object[]
				{
					this,
					armyInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (armyInfo == null)
			{
				return;
			}
			this.m_armyIconImage.sprite = AssetUtility.Instance.GetSprite(armyInfo.Icon);
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x002EBBFC File Offset: 0x002E9DFC
		public void SetHpBarType(int barType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHpBarTypeInt32_hotfix != null)
			{
				this.m_SetHpBarTypeInt32_hotfix.call(new object[]
				{
					this,
					barType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string name = string.Empty;
			if (barType == 0)
			{
				name = "UI/Common_New_ABS/Pattern_Blood_Green.png";
			}
			else if (barType == 1)
			{
				name = "UI/Common_New_ABS/Pattern_Blood_Red.png";
			}
			else if (barType == 2)
			{
				name = "UI/Common_New_ABS/Pattern_Blood_Blue.png";
			}
			this.m_hpImage.sprite = AssetUtility.Instance.GetSprite(name);
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x002EBCB8 File Offset: 0x002E9EB8
		public void ShowTag(StageActorTagType tagType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowTagStageActorTagType_hotfix != null)
			{
				this.m_ShowTagStageActorTagType_hotfix.call(new object[]
				{
					this,
					tagType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_npcGameObject.SetActive(tagType == StageActorTagType.Npc);
			this.m_enforceGameObject.SetActive(tagType == StageActorTagType.Enforce);
			this.m_scoreBonusGameObject.SetActive(tagType == StageActorTagType.ScoreBonus);
			this.m_powerUpGameObject.SetActive(tagType == StageActorTagType.PowerUp);
			this.m_campUpGameObject.SetActive(tagType == StageActorTagType.CampUp);
		}

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x002EBD74 File Offset: 0x002E9F74
		public void ShowProtect(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowProtectBoolean_hotfix != null)
			{
				this.m_ShowProtectBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_protectGameObject.SetActive(show);
		}

		// Token: 0x0600A6AA RID: 42666 RVA: 0x002EBDF0 File Offset: 0x002E9FF0
		public void ShowBan(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowBanBoolean_hotfix != null)
			{
				this.m_ShowBanBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_banGameObject.SetActive(show);
		}

		// Token: 0x0600A6AB RID: 42667 RVA: 0x002EBE6C File Offset: 0x002EA06C
		public void ShowPlayerIndexTag(bool show)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowPlayerIndexTagBoolean_hotfix != null)
			{
				this.m_ShowPlayerIndexTagBoolean_hotfix.call(new object[]
				{
					this,
					show
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerTagImage.gameObject.SetActive(show);
		}

		// Token: 0x0600A6AC RID: 42668 RVA: 0x002EBEF0 File Offset: 0x002EA0F0
		public void SetPlayerIndex(int playerIndex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPlayerIndexInt32_hotfix != null)
			{
				this.m_SetPlayerIndexInt32_hotfix.call(new object[]
				{
					this,
					playerIndex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerTagImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetBattlePlayerTagImageName(playerIndex));
		}

		// Token: 0x0600A6AD RID: 42669 RVA: 0x002EBF7C File Offset: 0x002EA17C
		public void SetHp(int hp, int hpValue)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHpInt32Int32_hotfix != null)
			{
				this.m_SetHpInt32Int32_hotfix.call(new object[]
				{
					this,
					hp,
					hpValue
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hp > 0 && hpValue > 0)
			{
				this.m_hpImage.fillAmount = (float)hp / (float)hpValue;
			}
			else
			{
				this.m_hpImage.fillAmount = 0f;
			}
		}

		// Token: 0x0600A6AE RID: 42670 RVA: 0x002EC030 File Offset: 0x002EA230
		public void SetBuff(BattleActor a, List<ClientActorBuff> buffs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBuffBattleActorList`1_hotfix != null)
			{
				this.m_SetBuffBattleActorList`1_hotfix.call(new object[]
				{
					this,
					a,
					buffs
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int i = 0;
			if (buffs != null)
			{
				foreach (ClientActorBuff clientActorBuff in buffs)
				{
					if (clientActorBuff.m_buffState.m_buffInfo.IconDisplay)
					{
						if (a.IsBuffEffective(clientActorBuff.m_buffState))
						{
							this.m_buffImages[i].gameObject.SetActive(true);
							this.m_buffImages[i].sprite = AssetUtility.Instance.GetSprite(clientActorBuff.m_buffState.m_buffInfo.Icon);
							if (clientActorBuff.m_buffState.m_time > 0 && !clientActorBuff.m_buffState.m_buffInfo.IsInfiniteTime())
							{
								this.m_buffTexts[i].gameObject.SetActive(true);
								this.m_buffTexts[i].text = clientActorBuff.m_buffState.m_time.ToString();
							}
							else
							{
								this.m_buffTexts[i].gameObject.SetActive(false);
							}
							i++;
							if (i >= this.m_buffImages.Length)
							{
								break;
							}
						}
					}
				}
			}
			while (i < this.m_buffImages.Length)
			{
				this.m_buffImages[i].gameObject.SetActive(false);
				i++;
			}
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x0600A6AF RID: 42671 RVA: 0x002EC228 File Offset: 0x002EA428
		// (set) Token: 0x0600A6B0 RID: 42672 RVA: 0x002EC248 File Offset: 0x002EA448
		[DoNotToLua]
		public new BattleActorUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleActorUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A6B1 RID: 42673 RVA: 0x002EC254 File Offset: 0x002EA454
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A6B2 RID: 42674 RVA: 0x002EC260 File Offset: 0x002EA460
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A6B3 RID: 42675 RVA: 0x002EC268 File Offset: 0x002EA468
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A6B4 RID: 42676 RVA: 0x002EC270 File Offset: 0x002EA470
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A6B5 RID: 42677 RVA: 0x002EC284 File Offset: 0x002EA484
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A6B6 RID: 42678 RVA: 0x002EC28C File Offset: 0x002EA48C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A6B7 RID: 42679 RVA: 0x002EC298 File Offset: 0x002EA498
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A6B8 RID: 42680 RVA: 0x002EC2A4 File Offset: 0x002EA4A4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A6B9 RID: 42681 RVA: 0x002EC2B0 File Offset: 0x002EA4B0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A6BA RID: 42682 RVA: 0x002EC2BC File Offset: 0x002EA4BC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x002EC2C8 File Offset: 0x002EA4C8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A6BC RID: 42684 RVA: 0x002EC2D4 File Offset: 0x002EA4D4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A6BD RID: 42685 RVA: 0x002EC2E0 File Offset: 0x002EA4E0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A6BE RID: 42686 RVA: 0x002EC2EC File Offset: 0x002EA4EC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A6BF RID: 42687 RVA: 0x002EC2F8 File Offset: 0x002EA4F8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A6C0 RID: 42688 RVA: 0x002EC300 File Offset: 0x002EA500
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
					this.m_SetArmyInfoConfigDataArmyInfo_hotfix = (luaObj.RawGet("SetArmyInfo") as LuaFunction);
					this.m_SetHpBarTypeInt32_hotfix = (luaObj.RawGet("SetHpBarType") as LuaFunction);
					this.m_ShowTagStageActorTagType_hotfix = (luaObj.RawGet("ShowTag") as LuaFunction);
					this.m_ShowProtectBoolean_hotfix = (luaObj.RawGet("ShowProtect") as LuaFunction);
					this.m_ShowBanBoolean_hotfix = (luaObj.RawGet("ShowBan") as LuaFunction);
					this.m_ShowPlayerIndexTagBoolean_hotfix = (luaObj.RawGet("ShowPlayerIndexTag") as LuaFunction);
					this.m_SetPlayerIndexInt32_hotfix = (luaObj.RawGet("SetPlayerIndex") as LuaFunction);
					this.m_SetHpInt32Int32_hotfix = (luaObj.RawGet("SetHp") as LuaFunction);
					this.m_SetBuffBattleActorList`1_hotfix = (luaObj.RawGet("SetBuff") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A6C1 RID: 42689 RVA: 0x002EC4AC File Offset: 0x002EA6AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleActorUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006E92 RID: 28306
		[AutoBind("./HP", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_hpImage;

		// Token: 0x04006E93 RID: 28307
		[AutoBind("./Army/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_armyIconImage;

		// Token: 0x04006E94 RID: 28308
		[AutoBind("./PlayerTag", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_playerTagImage;

		// Token: 0x04006E95 RID: 28309
		[AutoBind("./Enforce", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enforceGameObject;

		// Token: 0x04006E96 RID: 28310
		[AutoBind("./Npc", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_npcGameObject;

		// Token: 0x04006E97 RID: 28311
		[AutoBind("./Protect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_protectGameObject;

		// Token: 0x04006E98 RID: 28312
		[AutoBind("./KickOut", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_banGameObject;

		// Token: 0x04006E99 RID: 28313
		[AutoBind("./ScoreUp", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_scoreBonusGameObject;

		// Token: 0x04006E9A RID: 28314
		[AutoBind("./PowerUp", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_powerUpGameObject;

		// Token: 0x04006E9B RID: 28315
		[AutoBind("./CampUp", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_campUpGameObject;

		// Token: 0x04006E9C RID: 28316
		private Image[] m_buffImages = new Image[3];

		// Token: 0x04006E9D RID: 28317
		private Text[] m_buffTexts = new Text[3];

		// Token: 0x04006E9E RID: 28318
		[DoNotToLua]
		private BattleActorUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006E9F RID: 28319
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006EA0 RID: 28320
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006EA1 RID: 28321
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006EA2 RID: 28322
		private LuaFunction m_SetArmyInfoConfigDataArmyInfo_hotfix;

		// Token: 0x04006EA3 RID: 28323
		private LuaFunction m_SetHpBarTypeInt32_hotfix;

		// Token: 0x04006EA4 RID: 28324
		private LuaFunction m_ShowTagStageActorTagType_hotfix;

		// Token: 0x04006EA5 RID: 28325
		private LuaFunction m_ShowProtectBoolean_hotfix;

		// Token: 0x04006EA6 RID: 28326
		private LuaFunction m_ShowBanBoolean_hotfix;

		// Token: 0x04006EA7 RID: 28327
		private LuaFunction m_ShowPlayerIndexTagBoolean_hotfix;

		// Token: 0x04006EA8 RID: 28328
		private LuaFunction m_SetPlayerIndexInt32_hotfix;

		// Token: 0x04006EA9 RID: 28329
		private LuaFunction m_SetHpInt32Int32_hotfix;

		// Token: 0x04006EAA RID: 28330
		private LuaFunction m_SetBuffBattleActorList;

		// Token: 0x02000A65 RID: 2661
		public new class LuaExportHelper
		{
			// Token: 0x0600A6C2 RID: 42690 RVA: 0x002EC514 File Offset: 0x002EA714
			public LuaExportHelper(BattleActorUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A6C3 RID: 42691 RVA: 0x002EC524 File Offset: 0x002EA724
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A6C4 RID: 42692 RVA: 0x002EC534 File Offset: 0x002EA734
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A6C5 RID: 42693 RVA: 0x002EC544 File Offset: 0x002EA744
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A6C6 RID: 42694 RVA: 0x002EC554 File Offset: 0x002EA754
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A6C7 RID: 42695 RVA: 0x002EC56C File Offset: 0x002EA76C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A6C8 RID: 42696 RVA: 0x002EC57C File Offset: 0x002EA77C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A6C9 RID: 42697 RVA: 0x002EC58C File Offset: 0x002EA78C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A6CA RID: 42698 RVA: 0x002EC59C File Offset: 0x002EA79C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A6CB RID: 42699 RVA: 0x002EC5AC File Offset: 0x002EA7AC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A6CC RID: 42700 RVA: 0x002EC5BC File Offset: 0x002EA7BC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A6CD RID: 42701 RVA: 0x002EC5CC File Offset: 0x002EA7CC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A6CE RID: 42702 RVA: 0x002EC5DC File Offset: 0x002EA7DC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A6CF RID: 42703 RVA: 0x002EC5EC File Offset: 0x002EA7EC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A6D0 RID: 42704 RVA: 0x002EC5FC File Offset: 0x002EA7FC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A6D1 RID: 42705 RVA: 0x002EC60C File Offset: 0x002EA80C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170021E6 RID: 8678
			// (get) Token: 0x0600A6D2 RID: 42706 RVA: 0x002EC61C File Offset: 0x002EA81C
			// (set) Token: 0x0600A6D3 RID: 42707 RVA: 0x002EC62C File Offset: 0x002EA82C
			public Image m_hpImage
			{
				get
				{
					return this.m_owner.m_hpImage;
				}
				set
				{
					this.m_owner.m_hpImage = value;
				}
			}

			// Token: 0x170021E7 RID: 8679
			// (get) Token: 0x0600A6D4 RID: 42708 RVA: 0x002EC63C File Offset: 0x002EA83C
			// (set) Token: 0x0600A6D5 RID: 42709 RVA: 0x002EC64C File Offset: 0x002EA84C
			public Image m_armyIconImage
			{
				get
				{
					return this.m_owner.m_armyIconImage;
				}
				set
				{
					this.m_owner.m_armyIconImage = value;
				}
			}

			// Token: 0x170021E8 RID: 8680
			// (get) Token: 0x0600A6D6 RID: 42710 RVA: 0x002EC65C File Offset: 0x002EA85C
			// (set) Token: 0x0600A6D7 RID: 42711 RVA: 0x002EC66C File Offset: 0x002EA86C
			public Image m_playerTagImage
			{
				get
				{
					return this.m_owner.m_playerTagImage;
				}
				set
				{
					this.m_owner.m_playerTagImage = value;
				}
			}

			// Token: 0x170021E9 RID: 8681
			// (get) Token: 0x0600A6D8 RID: 42712 RVA: 0x002EC67C File Offset: 0x002EA87C
			// (set) Token: 0x0600A6D9 RID: 42713 RVA: 0x002EC68C File Offset: 0x002EA88C
			public GameObject m_enforceGameObject
			{
				get
				{
					return this.m_owner.m_enforceGameObject;
				}
				set
				{
					this.m_owner.m_enforceGameObject = value;
				}
			}

			// Token: 0x170021EA RID: 8682
			// (get) Token: 0x0600A6DA RID: 42714 RVA: 0x002EC69C File Offset: 0x002EA89C
			// (set) Token: 0x0600A6DB RID: 42715 RVA: 0x002EC6AC File Offset: 0x002EA8AC
			public GameObject m_npcGameObject
			{
				get
				{
					return this.m_owner.m_npcGameObject;
				}
				set
				{
					this.m_owner.m_npcGameObject = value;
				}
			}

			// Token: 0x170021EB RID: 8683
			// (get) Token: 0x0600A6DC RID: 42716 RVA: 0x002EC6BC File Offset: 0x002EA8BC
			// (set) Token: 0x0600A6DD RID: 42717 RVA: 0x002EC6CC File Offset: 0x002EA8CC
			public GameObject m_protectGameObject
			{
				get
				{
					return this.m_owner.m_protectGameObject;
				}
				set
				{
					this.m_owner.m_protectGameObject = value;
				}
			}

			// Token: 0x170021EC RID: 8684
			// (get) Token: 0x0600A6DE RID: 42718 RVA: 0x002EC6DC File Offset: 0x002EA8DC
			// (set) Token: 0x0600A6DF RID: 42719 RVA: 0x002EC6EC File Offset: 0x002EA8EC
			public GameObject m_banGameObject
			{
				get
				{
					return this.m_owner.m_banGameObject;
				}
				set
				{
					this.m_owner.m_banGameObject = value;
				}
			}

			// Token: 0x170021ED RID: 8685
			// (get) Token: 0x0600A6E0 RID: 42720 RVA: 0x002EC6FC File Offset: 0x002EA8FC
			// (set) Token: 0x0600A6E1 RID: 42721 RVA: 0x002EC70C File Offset: 0x002EA90C
			public GameObject m_scoreBonusGameObject
			{
				get
				{
					return this.m_owner.m_scoreBonusGameObject;
				}
				set
				{
					this.m_owner.m_scoreBonusGameObject = value;
				}
			}

			// Token: 0x170021EE RID: 8686
			// (get) Token: 0x0600A6E2 RID: 42722 RVA: 0x002EC71C File Offset: 0x002EA91C
			// (set) Token: 0x0600A6E3 RID: 42723 RVA: 0x002EC72C File Offset: 0x002EA92C
			public GameObject m_powerUpGameObject
			{
				get
				{
					return this.m_owner.m_powerUpGameObject;
				}
				set
				{
					this.m_owner.m_powerUpGameObject = value;
				}
			}

			// Token: 0x170021EF RID: 8687
			// (get) Token: 0x0600A6E4 RID: 42724 RVA: 0x002EC73C File Offset: 0x002EA93C
			// (set) Token: 0x0600A6E5 RID: 42725 RVA: 0x002EC74C File Offset: 0x002EA94C
			public GameObject m_campUpGameObject
			{
				get
				{
					return this.m_owner.m_campUpGameObject;
				}
				set
				{
					this.m_owner.m_campUpGameObject = value;
				}
			}

			// Token: 0x170021F0 RID: 8688
			// (get) Token: 0x0600A6E6 RID: 42726 RVA: 0x002EC75C File Offset: 0x002EA95C
			// (set) Token: 0x0600A6E7 RID: 42727 RVA: 0x002EC76C File Offset: 0x002EA96C
			public Image[] m_buffImages
			{
				get
				{
					return this.m_owner.m_buffImages;
				}
				set
				{
					this.m_owner.m_buffImages = value;
				}
			}

			// Token: 0x170021F1 RID: 8689
			// (get) Token: 0x0600A6E8 RID: 42728 RVA: 0x002EC77C File Offset: 0x002EA97C
			// (set) Token: 0x0600A6E9 RID: 42729 RVA: 0x002EC78C File Offset: 0x002EA98C
			public Text[] m_buffTexts
			{
				get
				{
					return this.m_owner.m_buffTexts;
				}
				set
				{
					this.m_owner.m_buffTexts = value;
				}
			}

			// Token: 0x0600A6EA RID: 42730 RVA: 0x002EC79C File Offset: 0x002EA99C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04006EAB RID: 28331
			private BattleActorUIController m_owner;
		}
	}
}
