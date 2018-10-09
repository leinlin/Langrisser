using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D1F RID: 3359
	[HotFix]
	public class GuildMassiveCombatLastHeroUIController : UIControllerBase
	{
		// Token: 0x0600F784 RID: 63364 RVA: 0x004160FC File Offset: 0x004142FC
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

		// Token: 0x0600F785 RID: 63365 RVA: 0x00416164 File Offset: 0x00414364
		public void InitGuildMassiveCombatLastHeroInfo(Hero hero, bool isUsed, bool isPowerUp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGuildMassiveCombatLastHeroInfoHeroBooleanBoolean_hotfix != null)
			{
				this.m_InitGuildMassiveCombatLastHeroInfoHeroBooleanBoolean_hotfix.call(new object[]
				{
					this,
					hero,
					isUsed,
					isPowerUp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.gameObject.SetActive(true);
			this.m_stateCtrl.SetToUIState((!isUsed) ? "Normal" : "Dark", false, true);
			this.m_powerUpGo.SetActive(isPowerUp);
			ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
			if (charImageInfo != null)
			{
				this.m_heroIcon.sprite = AssetUtility.Instance.GetSprite(charImageInfo.RoundHeadImage);
			}
			ConfigDataArmyInfo armyInfo = hero.GetActiveJob().JobConnectionInfo.m_jobInfo.m_armyInfo;
			this.m_armyIcon.sprite = AssetUtility.Instance.GetSprite(armyInfo.Icon);
			this.m_levelText.text = hero.Level.ToString();
		}

		// Token: 0x0600F786 RID: 63366 RVA: 0x004162B4 File Offset: 0x004144B4
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x14000346 RID: 838
		// (add) Token: 0x0600F787 RID: 63367 RVA: 0x0041632C File Offset: 0x0041452C
		// (remove) Token: 0x0600F788 RID: 63368 RVA: 0x004163C8 File Offset: 0x004145C8
		public event Action<GuildMassiveCombatLastHeroUIController> EventOnClick
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
				Action<GuildMassiveCombatLastHeroUIController> action = this.EventOnClick;
				Action<GuildMassiveCombatLastHeroUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildMassiveCombatLastHeroUIController>>(ref this.EventOnClick, (Action<GuildMassiveCombatLastHeroUIController>)Delegate.Combine(action2, value), action);
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
				Action<GuildMassiveCombatLastHeroUIController> action = this.EventOnClick;
				Action<GuildMassiveCombatLastHeroUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GuildMassiveCombatLastHeroUIController>>(ref this.EventOnClick, (Action<GuildMassiveCombatLastHeroUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x0600F789 RID: 63369 RVA: 0x00416464 File Offset: 0x00414664
		// (set) Token: 0x0600F78A RID: 63370 RVA: 0x00416484 File Offset: 0x00414684
		[DoNotToLua]
		public new GuildMassiveCombatLastHeroUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildMassiveCombatLastHeroUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F78B RID: 63371 RVA: 0x00416490 File Offset: 0x00414690
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600F78C RID: 63372 RVA: 0x0041649C File Offset: 0x0041469C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600F78D RID: 63373 RVA: 0x004164A4 File Offset: 0x004146A4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600F78E RID: 63374 RVA: 0x004164AC File Offset: 0x004146AC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600F78F RID: 63375 RVA: 0x004164C0 File Offset: 0x004146C0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600F790 RID: 63376 RVA: 0x004164C8 File Offset: 0x004146C8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600F791 RID: 63377 RVA: 0x004164D4 File Offset: 0x004146D4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600F792 RID: 63378 RVA: 0x004164E0 File Offset: 0x004146E0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600F793 RID: 63379 RVA: 0x004164EC File Offset: 0x004146EC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600F794 RID: 63380 RVA: 0x004164F8 File Offset: 0x004146F8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600F795 RID: 63381 RVA: 0x00416504 File Offset: 0x00414704
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600F796 RID: 63382 RVA: 0x00416510 File Offset: 0x00414710
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600F797 RID: 63383 RVA: 0x0041651C File Offset: 0x0041471C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600F798 RID: 63384 RVA: 0x00416528 File Offset: 0x00414728
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600F799 RID: 63385 RVA: 0x00416534 File Offset: 0x00414734
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600F79A RID: 63386 RVA: 0x0041653C File Offset: 0x0041473C
		private void __callDele_EventOnClick(GuildMassiveCombatLastHeroUIController obj)
		{
			Action<GuildMassiveCombatLastHeroUIController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600F79B RID: 63387 RVA: 0x00416560 File Offset: 0x00414760
		private void __clearDele_EventOnClick(GuildMassiveCombatLastHeroUIController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600F79C RID: 63388 RVA: 0x0041656C File Offset: 0x0041476C
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
					this.m_InitGuildMassiveCombatLastHeroInfoHeroBooleanBoolean_hotfix = (luaObj.RawGet("InitGuildMassiveCombatLastHeroInfo") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F79D RID: 63389 RVA: 0x0041669C File Offset: 0x0041489C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatLastHeroUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009204 RID: 37380
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04009205 RID: 37381
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroIcon;

		// Token: 0x04009206 RID: 37382
		[AutoBind("./ArmyIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_armyIcon;

		// Token: 0x04009207 RID: 37383
		[AutoBind("./LvGroup/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x04009208 RID: 37384
		[AutoBind("./PowerUp", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_powerUpGo;

		// Token: 0x04009209 RID: 37385
		[DoNotToLua]
		private GuildMassiveCombatLastHeroUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400920A RID: 37386
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400920B RID: 37387
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400920C RID: 37388
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400920D RID: 37389
		private LuaFunction m_InitGuildMassiveCombatLastHeroInfoHeroBooleanBoolean_hotfix;

		// Token: 0x0400920E RID: 37390
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x0400920F RID: 37391
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04009210 RID: 37392
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000D20 RID: 3360
		public new class LuaExportHelper
		{
			// Token: 0x0600F79E RID: 63390 RVA: 0x00416704 File Offset: 0x00414904
			public LuaExportHelper(GuildMassiveCombatLastHeroUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F79F RID: 63391 RVA: 0x00416714 File Offset: 0x00414914
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600F7A0 RID: 63392 RVA: 0x00416724 File Offset: 0x00414924
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600F7A1 RID: 63393 RVA: 0x00416734 File Offset: 0x00414934
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600F7A2 RID: 63394 RVA: 0x00416744 File Offset: 0x00414944
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600F7A3 RID: 63395 RVA: 0x0041675C File Offset: 0x0041495C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600F7A4 RID: 63396 RVA: 0x0041676C File Offset: 0x0041496C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600F7A5 RID: 63397 RVA: 0x0041677C File Offset: 0x0041497C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600F7A6 RID: 63398 RVA: 0x0041678C File Offset: 0x0041498C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600F7A7 RID: 63399 RVA: 0x0041679C File Offset: 0x0041499C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600F7A8 RID: 63400 RVA: 0x004167AC File Offset: 0x004149AC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600F7A9 RID: 63401 RVA: 0x004167BC File Offset: 0x004149BC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600F7AA RID: 63402 RVA: 0x004167CC File Offset: 0x004149CC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600F7AB RID: 63403 RVA: 0x004167DC File Offset: 0x004149DC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600F7AC RID: 63404 RVA: 0x004167EC File Offset: 0x004149EC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600F7AD RID: 63405 RVA: 0x004167FC File Offset: 0x004149FC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600F7AE RID: 63406 RVA: 0x0041680C File Offset: 0x00414A0C
			public void __callDele_EventOnClick(GuildMassiveCombatLastHeroUIController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600F7AF RID: 63407 RVA: 0x0041681C File Offset: 0x00414A1C
			public void __clearDele_EventOnClick(GuildMassiveCombatLastHeroUIController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002F6F RID: 12143
			// (get) Token: 0x0600F7B0 RID: 63408 RVA: 0x0041682C File Offset: 0x00414A2C
			// (set) Token: 0x0600F7B1 RID: 63409 RVA: 0x0041683C File Offset: 0x00414A3C
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

			// Token: 0x17002F70 RID: 12144
			// (get) Token: 0x0600F7B2 RID: 63410 RVA: 0x0041684C File Offset: 0x00414A4C
			// (set) Token: 0x0600F7B3 RID: 63411 RVA: 0x0041685C File Offset: 0x00414A5C
			public Image m_heroIcon
			{
				get
				{
					return this.m_owner.m_heroIcon;
				}
				set
				{
					this.m_owner.m_heroIcon = value;
				}
			}

			// Token: 0x17002F71 RID: 12145
			// (get) Token: 0x0600F7B4 RID: 63412 RVA: 0x0041686C File Offset: 0x00414A6C
			// (set) Token: 0x0600F7B5 RID: 63413 RVA: 0x0041687C File Offset: 0x00414A7C
			public Image m_armyIcon
			{
				get
				{
					return this.m_owner.m_armyIcon;
				}
				set
				{
					this.m_owner.m_armyIcon = value;
				}
			}

			// Token: 0x17002F72 RID: 12146
			// (get) Token: 0x0600F7B6 RID: 63414 RVA: 0x0041688C File Offset: 0x00414A8C
			// (set) Token: 0x0600F7B7 RID: 63415 RVA: 0x0041689C File Offset: 0x00414A9C
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x17002F73 RID: 12147
			// (get) Token: 0x0600F7B8 RID: 63416 RVA: 0x004168AC File Offset: 0x00414AAC
			// (set) Token: 0x0600F7B9 RID: 63417 RVA: 0x004168BC File Offset: 0x00414ABC
			public GameObject m_powerUpGo
			{
				get
				{
					return this.m_owner.m_powerUpGo;
				}
				set
				{
					this.m_owner.m_powerUpGo = value;
				}
			}

			// Token: 0x0600F7BA RID: 63418 RVA: 0x004168CC File Offset: 0x00414ACC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600F7BB RID: 63419 RVA: 0x004168DC File Offset: 0x00414ADC
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x04009211 RID: 37393
			private GuildMassiveCombatLastHeroUIController m_owner;
		}
	}
}
