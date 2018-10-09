using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C6B RID: 3179
	[HotFix]
	public class FettersConfessionSkillItemUIController : UIControllerBase
	{
		// Token: 0x0600E353 RID: 58195 RVA: 0x003D2560 File Offset: 0x003D0760
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
			this.m_toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnSkillToggleValueChanged));
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600E354 RID: 58196 RVA: 0x003D2618 File Offset: 0x003D0818
		public void InitFettersConfessionSkillItem(int fetterId, int curFavoribilityLevel, bool hasUnLock, int skillLv)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitFettersConfessionSkillItemInt32Int32BooleanInt32_hotfix != null)
			{
				this.m_InitFettersConfessionSkillItemInt32Int32BooleanInt32_hotfix.call(new object[]
				{
					this,
					fetterId,
					curFavoribilityLevel,
					hasUnLock,
					skillLv
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hasUnLocked = hasUnLock;
			this.HeroFetterInfo = this.m_configDataLoader.GetConfigDataHeroFetterInfo(fetterId);
			foreach (HeroFetterCompletionCondition heroFetterCompletionCondition in this.HeroFetterInfo.CompletionConditions)
			{
				if (heroFetterCompletionCondition.ConditionType == FetterCompleteConditionType.FetterCompleteConditionType_HeroFavorabilityLevel)
				{
					this.m_heroId = heroFetterCompletionCondition.Parm1;
					this.m_unlockFavoribilityLevel = heroFetterCompletionCondition.Parm2;
				}
			}
			this.m_curFavoribilityLevel = curFavoribilityLevel;
			this.m_unlockConditionText.text = string.Format(this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Msg_FetterFavorabilityLevelLimit), this.m_unlockFavoribilityLevel);
			this.m_skillIconImage.sprite = AssetUtility.Instance.GetSprite(this.HeroFetterInfo.Icon);
			this.m_skillLv = skillLv;
			this.m_lvValueText.text = skillLv.ToString();
			if (this.m_hasUnLocked)
			{
				if (skillLv >= this.HeroFetterInfo.MaxLevel)
				{
					this.m_stateCtrl.SetToUIState("Max", false, true);
				}
				else
				{
					this.m_stateCtrl.SetToUIState("Normal", false, true);
				}
			}
			else
			{
				int num = this.m_playerContext.CanUnlockHeroFetter(this.m_heroId, fetterId);
				if (num != 0)
				{
					this.m_stateCtrl.SetToUIState("Lock", false, true);
				}
				else
				{
					this.m_stateCtrl.SetToUIState("UnlockNotic", false, true);
				}
			}
			this.m_redPoint.SetActive(false);
		}

		// Token: 0x0600E355 RID: 58197 RVA: 0x003D2850 File Offset: 0x003D0A50
		private void OnSkillToggleValueChanged(bool isOn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnSkillToggleValueChangedBoolean_hotfix != null)
			{
				this.m_OnSkillToggleValueChangedBoolean_hotfix.call(new object[]
				{
					this,
					isOn
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ShowSelectImage(isOn);
			if (isOn)
			{
				if (!this.m_hasUnLocked)
				{
					Hero hero = this.m_playerContext.GetHero(this.m_heroId);
					this.m_hasUnLocked = hero.Fetters.ContainsKey(this.HeroFetterInfo.ID);
				}
				if (this.m_hasUnLocked)
				{
					AudioUtility.PlaySound("UI_LargeIconClick");
				}
				else if (this.m_playerContext.CanUnlockHeroFetter(this.m_heroId, this.HeroFetterInfo.ID) == 0)
				{
					AudioUtility.PlaySound("UI_ReadytoUnlock");
				}
				else
				{
					AudioUtility.PlaySound("UI_CantUnlock");
				}
				if (this.EventOnClick != null)
				{
					this.EventOnClick(this);
				}
			}
		}

		// Token: 0x0600E356 RID: 58198 RVA: 0x003D2978 File Offset: 0x003D0B78
		public void PlayUnlockEffect(List<Goods> rewards)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayUnlockEffectList`1_hotfix != null)
			{
				this.m_PlayUnlockEffectList`1_hotfix.call(new object[]
				{
					this,
					rewards2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> rewards = rewards2;
			if (rewards != null && rewards.Count != 0)
			{
				this.m_stateCtrl.SetActionForUIStateFinshed("UnlockEffect", delegate
				{
					GetRewardGoodsUITask.StartUITask(rewards);
				});
			}
			this.m_stateCtrl.SetToUIState("UnlockEffect", false, true);
		}

		// Token: 0x0600E357 RID: 58199 RVA: 0x003D2A40 File Offset: 0x003D0C40
		public void PlayPromoteEffect()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayPromoteEffect_hotfix != null)
			{
				this.m_PlayPromoteEffect_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_stateCtrl.SetActionForUIStateFinshed("Promote", delegate
			{
				if (this.m_hasUnLocked && this.m_skillLv >= this.HeroFetterInfo.MaxLevel)
				{
					this.m_stateCtrl.SetToUIState("Max", false, true);
				}
			});
			this.m_stateCtrl.SetToUIState("Promote", false, true);
		}

		// Token: 0x0600E358 RID: 58200 RVA: 0x003D2AD0 File Offset: 0x003D0CD0
		public void ShowSelectImage(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectImageBoolean_hotfix != null)
			{
				this.m_ShowSelectImageBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_unlockSelectImage.SetActive(isShow && this.m_hasUnLocked);
			this.m_lockSelectImage.SetActive(isShow && !this.m_hasUnLocked);
		}

		// Token: 0x140002DD RID: 733
		// (add) Token: 0x0600E359 RID: 58201 RVA: 0x003D2B78 File Offset: 0x003D0D78
		// (remove) Token: 0x0600E35A RID: 58202 RVA: 0x003D2C14 File Offset: 0x003D0E14
		public event Action<FettersConfessionSkillItemUIController> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`1_hotfix != null)
				{
					this.m_add_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FettersConfessionSkillItemUIController> action = this.EventOnClick;
				Action<FettersConfessionSkillItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FettersConfessionSkillItemUIController>>(ref this.EventOnClick, (Action<FettersConfessionSkillItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<FettersConfessionSkillItemUIController> action = this.EventOnClick;
				Action<FettersConfessionSkillItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<FettersConfessionSkillItemUIController>>(ref this.EventOnClick, (Action<FettersConfessionSkillItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x0600E35C RID: 58204 RVA: 0x003D2D28 File Offset: 0x003D0F28
		// (set) Token: 0x0600E35B RID: 58203 RVA: 0x003D2CB0 File Offset: 0x003D0EB0
		public ConfigDataHeroFetterInfo HeroFetterInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroFetterInfo_hotfix != null)
				{
					return (ConfigDataHeroFetterInfo)this.m_get_HeroFetterInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<HeroFetterInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HeroFetterInfoConfigDataHeroFetterInfo_hotfix != null)
				{
					this.m_set_HeroFetterInfoConfigDataHeroFetterInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<HeroFetterInfo>k__BackingField = value;
			}
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x0600E35D RID: 58205 RVA: 0x003D2D9C File Offset: 0x003D0F9C
		// (set) Token: 0x0600E35E RID: 58206 RVA: 0x003D2DBC File Offset: 0x003D0FBC
		[DoNotToLua]
		public new FettersConfessionSkillItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersConfessionSkillItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E35F RID: 58207 RVA: 0x003D2DC8 File Offset: 0x003D0FC8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E360 RID: 58208 RVA: 0x003D2DD4 File Offset: 0x003D0FD4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E361 RID: 58209 RVA: 0x003D2DDC File Offset: 0x003D0FDC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E362 RID: 58210 RVA: 0x003D2DE4 File Offset: 0x003D0FE4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E363 RID: 58211 RVA: 0x003D2DF8 File Offset: 0x003D0FF8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E364 RID: 58212 RVA: 0x003D2E00 File Offset: 0x003D1000
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E365 RID: 58213 RVA: 0x003D2E0C File Offset: 0x003D100C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E366 RID: 58214 RVA: 0x003D2E18 File Offset: 0x003D1018
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E367 RID: 58215 RVA: 0x003D2E24 File Offset: 0x003D1024
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E368 RID: 58216 RVA: 0x003D2E30 File Offset: 0x003D1030
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E369 RID: 58217 RVA: 0x003D2E3C File Offset: 0x003D103C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E36A RID: 58218 RVA: 0x003D2E48 File Offset: 0x003D1048
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E36B RID: 58219 RVA: 0x003D2E54 File Offset: 0x003D1054
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E36C RID: 58220 RVA: 0x003D2E60 File Offset: 0x003D1060
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E36D RID: 58221 RVA: 0x003D2E6C File Offset: 0x003D106C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E36E RID: 58222 RVA: 0x003D2E74 File Offset: 0x003D1074
		private void __callDele_EventOnClick(FettersConfessionSkillItemUIController obj)
		{
			Action<FettersConfessionSkillItemUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600E36F RID: 58223 RVA: 0x003D2E98 File Offset: 0x003D1098
		private void __clearDele_EventOnClick(FettersConfessionSkillItemUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600E371 RID: 58225 RVA: 0x003D2EDC File Offset: 0x003D10DC
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
					this.m_InitFettersConfessionSkillItemInt32Int32BooleanInt32_hotfix = (luaObj.RawGet("InitFettersConfessionSkillItem") as LuaFunction);
					this.m_OnSkillToggleValueChangedBoolean_hotfix = (luaObj.RawGet("OnSkillToggleValueChanged") as LuaFunction);
					this.m_PlayUnlockEffectList`1_hotfix = (luaObj.RawGet("PlayUnlockEffect") as LuaFunction);
					this.m_PlayPromoteEffect_hotfix = (luaObj.RawGet("PlayPromoteEffect") as LuaFunction);
					this.m_ShowSelectImageBoolean_hotfix = (luaObj.RawGet("ShowSelectImage") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					this.m_set_HeroFetterInfoConfigDataHeroFetterInfo_hotfix = (luaObj.RawGet("set_HeroFetterInfo") as LuaFunction);
					this.m_get_HeroFetterInfo_hotfix = (luaObj.RawGet("get_HeroFetterInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E372 RID: 58226 RVA: 0x003D3088 File Offset: 0x003D1288
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersConfessionSkillItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008994 RID: 35220
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private ToggleEx m_toggle;

		// Token: 0x04008995 RID: 35221
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04008996 RID: 35222
		[AutoBind("./SkillGroup/LvValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_lvValueText;

		// Token: 0x04008997 RID: 35223
		[AutoBind("./SkillGroup/RecPoint", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_redPoint;

		// Token: 0x04008998 RID: 35224
		[AutoBind("./BlackBG/UnlockConditionText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_unlockConditionText;

		// Token: 0x04008999 RID: 35225
		[AutoBind("./SkillGroup/SkillIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_skillIconImage;

		// Token: 0x0400899A RID: 35226
		[AutoBind("./SkillGroup/UnlockSelectImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_unlockSelectImage;

		// Token: 0x0400899B RID: 35227
		[AutoBind("./LockSelectImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_lockSelectImage;

		// Token: 0x0400899D RID: 35229
		private bool m_hasUnLocked;

		// Token: 0x0400899E RID: 35230
		private int m_unlockFavoribilityLevel;

		// Token: 0x0400899F RID: 35231
		private int m_curFavoribilityLevel;

		// Token: 0x040089A0 RID: 35232
		private int m_heroId;

		// Token: 0x040089A1 RID: 35233
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040089A2 RID: 35234
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040089A3 RID: 35235
		private int m_skillLv;

		// Token: 0x040089A4 RID: 35236
		[DoNotToLua]
		private FettersConfessionSkillItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040089A5 RID: 35237
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040089A6 RID: 35238
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040089A7 RID: 35239
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040089A8 RID: 35240
		private LuaFunction m_InitFettersConfessionSkillItemInt32Int32BooleanInt32_hotfix;

		// Token: 0x040089A9 RID: 35241
		private LuaFunction m_OnSkillToggleValueChangedBoolean_hotfix;

		// Token: 0x040089AA RID: 35242
		private LuaFunction m_PlayUnlockEffectList;

		// Token: 0x040089AB RID: 35243
		private LuaFunction m_PlayPromoteEffect_hotfix;

		// Token: 0x040089AC RID: 35244
		private LuaFunction m_ShowSelectImageBoolean_hotfix;

		// Token: 0x040089AD RID: 35245
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x040089AE RID: 35246
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x040089AF RID: 35247
		private LuaFunction m_set_HeroFetterInfoConfigDataHeroFetterInfo_hotfix;

		// Token: 0x040089B0 RID: 35248
		private LuaFunction m_get_HeroFetterInfo_hotfix;

		// Token: 0x02000C6C RID: 3180
		public new class LuaExportHelper
		{
			// Token: 0x0600E373 RID: 58227 RVA: 0x003D30F0 File Offset: 0x003D12F0
			public LuaExportHelper(FettersConfessionSkillItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E374 RID: 58228 RVA: 0x003D3100 File Offset: 0x003D1300
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E375 RID: 58229 RVA: 0x003D3110 File Offset: 0x003D1310
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E376 RID: 58230 RVA: 0x003D3120 File Offset: 0x003D1320
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E377 RID: 58231 RVA: 0x003D3130 File Offset: 0x003D1330
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E378 RID: 58232 RVA: 0x003D3148 File Offset: 0x003D1348
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E379 RID: 58233 RVA: 0x003D3158 File Offset: 0x003D1358
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E37A RID: 58234 RVA: 0x003D3168 File Offset: 0x003D1368
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E37B RID: 58235 RVA: 0x003D3178 File Offset: 0x003D1378
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E37C RID: 58236 RVA: 0x003D3188 File Offset: 0x003D1388
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E37D RID: 58237 RVA: 0x003D3198 File Offset: 0x003D1398
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E37E RID: 58238 RVA: 0x003D31A8 File Offset: 0x003D13A8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E37F RID: 58239 RVA: 0x003D31B8 File Offset: 0x003D13B8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E380 RID: 58240 RVA: 0x003D31C8 File Offset: 0x003D13C8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E381 RID: 58241 RVA: 0x003D31D8 File Offset: 0x003D13D8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E382 RID: 58242 RVA: 0x003D31E8 File Offset: 0x003D13E8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E383 RID: 58243 RVA: 0x003D31F8 File Offset: 0x003D13F8
			public void __callDele_EventOnClick(FettersConfessionSkillItemUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600E384 RID: 58244 RVA: 0x003D3208 File Offset: 0x003D1408
			public void __clearDele_EventOnClick(FettersConfessionSkillItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002C22 RID: 11298
			// (get) Token: 0x0600E385 RID: 58245 RVA: 0x003D3218 File Offset: 0x003D1418
			// (set) Token: 0x0600E386 RID: 58246 RVA: 0x003D3228 File Offset: 0x003D1428
			public ToggleEx m_toggle
			{
				get
				{
					return this.m_owner.m_toggle;
				}
				set
				{
					this.m_owner.m_toggle = value;
				}
			}

			// Token: 0x17002C23 RID: 11299
			// (get) Token: 0x0600E387 RID: 58247 RVA: 0x003D3238 File Offset: 0x003D1438
			// (set) Token: 0x0600E388 RID: 58248 RVA: 0x003D3248 File Offset: 0x003D1448
			public CommonUIStateController m_stateCtrl
			{
				get
				{
					return this.m_owner.m_stateCtrl;
				}
				set
				{
					this.m_owner.m_stateCtrl = value;
				}
			}

			// Token: 0x17002C24 RID: 11300
			// (get) Token: 0x0600E389 RID: 58249 RVA: 0x003D3258 File Offset: 0x003D1458
			// (set) Token: 0x0600E38A RID: 58250 RVA: 0x003D3268 File Offset: 0x003D1468
			public Text m_lvValueText
			{
				get
				{
					return this.m_owner.m_lvValueText;
				}
				set
				{
					this.m_owner.m_lvValueText = value;
				}
			}

			// Token: 0x17002C25 RID: 11301
			// (get) Token: 0x0600E38B RID: 58251 RVA: 0x003D3278 File Offset: 0x003D1478
			// (set) Token: 0x0600E38C RID: 58252 RVA: 0x003D3288 File Offset: 0x003D1488
			public GameObject m_redPoint
			{
				get
				{
					return this.m_owner.m_redPoint;
				}
				set
				{
					this.m_owner.m_redPoint = value;
				}
			}

			// Token: 0x17002C26 RID: 11302
			// (get) Token: 0x0600E38D RID: 58253 RVA: 0x003D3298 File Offset: 0x003D1498
			// (set) Token: 0x0600E38E RID: 58254 RVA: 0x003D32A8 File Offset: 0x003D14A8
			public Text m_unlockConditionText
			{
				get
				{
					return this.m_owner.m_unlockConditionText;
				}
				set
				{
					this.m_owner.m_unlockConditionText = value;
				}
			}

			// Token: 0x17002C27 RID: 11303
			// (get) Token: 0x0600E38F RID: 58255 RVA: 0x003D32B8 File Offset: 0x003D14B8
			// (set) Token: 0x0600E390 RID: 58256 RVA: 0x003D32C8 File Offset: 0x003D14C8
			public Image m_skillIconImage
			{
				get
				{
					return this.m_owner.m_skillIconImage;
				}
				set
				{
					this.m_owner.m_skillIconImage = value;
				}
			}

			// Token: 0x17002C28 RID: 11304
			// (get) Token: 0x0600E391 RID: 58257 RVA: 0x003D32D8 File Offset: 0x003D14D8
			// (set) Token: 0x0600E392 RID: 58258 RVA: 0x003D32E8 File Offset: 0x003D14E8
			public GameObject m_unlockSelectImage
			{
				get
				{
					return this.m_owner.m_unlockSelectImage;
				}
				set
				{
					this.m_owner.m_unlockSelectImage = value;
				}
			}

			// Token: 0x17002C29 RID: 11305
			// (get) Token: 0x0600E393 RID: 58259 RVA: 0x003D32F8 File Offset: 0x003D14F8
			// (set) Token: 0x0600E394 RID: 58260 RVA: 0x003D3308 File Offset: 0x003D1508
			public GameObject m_lockSelectImage
			{
				get
				{
					return this.m_owner.m_lockSelectImage;
				}
				set
				{
					this.m_owner.m_lockSelectImage = value;
				}
			}

			// Token: 0x17002C2A RID: 11306
			// (get) Token: 0x0600E395 RID: 58261 RVA: 0x003D3318 File Offset: 0x003D1518
			// (set) Token: 0x0600E396 RID: 58262 RVA: 0x003D3328 File Offset: 0x003D1528
			public bool m_hasUnLocked
			{
				get
				{
					return this.m_owner.m_hasUnLocked;
				}
				set
				{
					this.m_owner.m_hasUnLocked = value;
				}
			}

			// Token: 0x17002C2B RID: 11307
			// (get) Token: 0x0600E397 RID: 58263 RVA: 0x003D3338 File Offset: 0x003D1538
			// (set) Token: 0x0600E398 RID: 58264 RVA: 0x003D3348 File Offset: 0x003D1548
			public int m_unlockFavoribilityLevel
			{
				get
				{
					return this.m_owner.m_unlockFavoribilityLevel;
				}
				set
				{
					this.m_owner.m_unlockFavoribilityLevel = value;
				}
			}

			// Token: 0x17002C2C RID: 11308
			// (get) Token: 0x0600E399 RID: 58265 RVA: 0x003D3358 File Offset: 0x003D1558
			// (set) Token: 0x0600E39A RID: 58266 RVA: 0x003D3368 File Offset: 0x003D1568
			public int m_curFavoribilityLevel
			{
				get
				{
					return this.m_owner.m_curFavoribilityLevel;
				}
				set
				{
					this.m_owner.m_curFavoribilityLevel = value;
				}
			}

			// Token: 0x17002C2D RID: 11309
			// (get) Token: 0x0600E39B RID: 58267 RVA: 0x003D3378 File Offset: 0x003D1578
			// (set) Token: 0x0600E39C RID: 58268 RVA: 0x003D3388 File Offset: 0x003D1588
			public int m_heroId
			{
				get
				{
					return this.m_owner.m_heroId;
				}
				set
				{
					this.m_owner.m_heroId = value;
				}
			}

			// Token: 0x17002C2E RID: 11310
			// (get) Token: 0x0600E39D RID: 58269 RVA: 0x003D3398 File Offset: 0x003D1598
			// (set) Token: 0x0600E39E RID: 58270 RVA: 0x003D33A8 File Offset: 0x003D15A8
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17002C2F RID: 11311
			// (get) Token: 0x0600E39F RID: 58271 RVA: 0x003D33B8 File Offset: 0x003D15B8
			// (set) Token: 0x0600E3A0 RID: 58272 RVA: 0x003D33C8 File Offset: 0x003D15C8
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17002C30 RID: 11312
			// (get) Token: 0x0600E3A1 RID: 58273 RVA: 0x003D33D8 File Offset: 0x003D15D8
			// (set) Token: 0x0600E3A2 RID: 58274 RVA: 0x003D33E8 File Offset: 0x003D15E8
			public int m_skillLv
			{
				get
				{
					return this.m_owner.m_skillLv;
				}
				set
				{
					this.m_owner.m_skillLv = value;
				}
			}

			// Token: 0x17002C31 RID: 11313
			// (set) Token: 0x0600E3A3 RID: 58275 RVA: 0x003D33F8 File Offset: 0x003D15F8
			public ConfigDataHeroFetterInfo HeroFetterInfo
			{
				set
				{
					this.m_owner.HeroFetterInfo = value;
				}
			}

			// Token: 0x0600E3A4 RID: 58276 RVA: 0x003D3408 File Offset: 0x003D1608
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E3A5 RID: 58277 RVA: 0x003D3418 File Offset: 0x003D1618
			public void OnSkillToggleValueChanged(bool isOn)
			{
				this.m_owner.OnSkillToggleValueChanged(isOn);
			}

			// Token: 0x040089B1 RID: 35249
			private FettersConfessionSkillItemUIController m_owner;
		}
	}
}
