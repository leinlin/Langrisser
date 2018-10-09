using System;
using System.Collections.Generic;
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
	// Token: 0x02000A5C RID: 2652
	[HotFix]
	public class BattleAchievementItemUIController : UIControllerBase
	{
		// Token: 0x0600A571 RID: 42353 RVA: 0x002E83C8 File Offset: 0x002E65C8
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
			this.m_rewardGoodsUIController = GameObjectUtility.AddControllerToGameObject<RewardGoodsUIController>(this.m_rewardGoodsGameObject);
		}

		// Token: 0x0600A572 RID: 42354 RVA: 0x002E8440 File Offset: 0x002E6640
		public void SetAchievement(ConfigDataBattleAchievementInfo a)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAchievementConfigDataBattleAchievementInfo_hotfix != null)
			{
				this.m_SetAchievementConfigDataBattleAchievementInfo_hotfix.call(new object[]
				{
					this,
					a
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = a.Name;
			this.m_descText.text = a.Desc;
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x002E84D4 File Offset: 0x002E66D4
		public void SetRewards(List<Goods> rewards)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRewardsList`1_hotfix != null)
			{
				this.m_SetRewardsList`1_hotfix.call(new object[]
				{
					this,
					rewards
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (rewards != null && rewards.Count > 0)
			{
				this.m_rewardGoodsUIController.gameObject.SetActive(true);
				this.m_rewardGoodsUIController.SetReward(rewards[0], 0, true);
			}
			else
			{
				this.m_rewardGoodsUIController.gameObject.SetActive(false);
			}
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x002E8594 File Offset: 0x002E6794
		public void SetComplete(bool complete)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCompleteBoolean_hotfix != null)
			{
				this.m_SetCompleteBoolean_hotfix.call(new object[]
				{
					this,
					complete
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_completeGameObject.SetActive(complete);
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x0600A575 RID: 42357 RVA: 0x002E8610 File Offset: 0x002E6810
		// (set) Token: 0x0600A576 RID: 42358 RVA: 0x002E8630 File Offset: 0x002E6830
		[DoNotToLua]
		public new BattleAchievementItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleAchievementItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A577 RID: 42359 RVA: 0x002E863C File Offset: 0x002E683C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A578 RID: 42360 RVA: 0x002E8648 File Offset: 0x002E6848
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A579 RID: 42361 RVA: 0x002E8650 File Offset: 0x002E6850
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A57A RID: 42362 RVA: 0x002E8658 File Offset: 0x002E6858
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A57B RID: 42363 RVA: 0x002E866C File Offset: 0x002E686C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A57C RID: 42364 RVA: 0x002E8674 File Offset: 0x002E6874
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A57D RID: 42365 RVA: 0x002E8680 File Offset: 0x002E6880
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A57E RID: 42366 RVA: 0x002E868C File Offset: 0x002E688C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x002E8698 File Offset: 0x002E6898
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A580 RID: 42368 RVA: 0x002E86A4 File Offset: 0x002E68A4
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A581 RID: 42369 RVA: 0x002E86B0 File Offset: 0x002E68B0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A582 RID: 42370 RVA: 0x002E86BC File Offset: 0x002E68BC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A583 RID: 42371 RVA: 0x002E86C8 File Offset: 0x002E68C8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A584 RID: 42372 RVA: 0x002E86D4 File Offset: 0x002E68D4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A585 RID: 42373 RVA: 0x002E86E0 File Offset: 0x002E68E0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x002E86E8 File Offset: 0x002E68E8
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
					this.m_SetAchievementConfigDataBattleAchievementInfo_hotfix = (luaObj.RawGet("SetAchievement") as LuaFunction);
					this.m_SetRewardsList`1_hotfix = (luaObj.RawGet("SetRewards") as LuaFunction);
					this.m_SetCompleteBoolean_hotfix = (luaObj.RawGet("SetComplete") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A587 RID: 42375 RVA: 0x002E8800 File Offset: 0x002E6A00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleAchievementItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006E10 RID: 28176
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04006E11 RID: 28177
		[AutoBind("./DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descText;

		// Token: 0x04006E12 RID: 28178
		[AutoBind("./RewardGoods", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGoodsGameObject;

		// Token: 0x04006E13 RID: 28179
		[AutoBind("./Complete", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_completeGameObject;

		// Token: 0x04006E14 RID: 28180
		private RewardGoodsUIController m_rewardGoodsUIController;

		// Token: 0x04006E15 RID: 28181
		[DoNotToLua]
		private BattleAchievementItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006E16 RID: 28182
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006E17 RID: 28183
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006E18 RID: 28184
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006E19 RID: 28185
		private LuaFunction m_SetAchievementConfigDataBattleAchievementInfo_hotfix;

		// Token: 0x04006E1A RID: 28186
		private LuaFunction m_SetRewardsList;

		// Token: 0x04006E1B RID: 28187
		private LuaFunction m_SetCompleteBoolean_hotfix;

		// Token: 0x02000A5D RID: 2653
		public new class LuaExportHelper
		{
			// Token: 0x0600A588 RID: 42376 RVA: 0x002E8868 File Offset: 0x002E6A68
			public LuaExportHelper(BattleAchievementItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A589 RID: 42377 RVA: 0x002E8878 File Offset: 0x002E6A78
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A58A RID: 42378 RVA: 0x002E8888 File Offset: 0x002E6A88
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A58B RID: 42379 RVA: 0x002E8898 File Offset: 0x002E6A98
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A58C RID: 42380 RVA: 0x002E88A8 File Offset: 0x002E6AA8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A58D RID: 42381 RVA: 0x002E88C0 File Offset: 0x002E6AC0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A58E RID: 42382 RVA: 0x002E88D0 File Offset: 0x002E6AD0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A58F RID: 42383 RVA: 0x002E88E0 File Offset: 0x002E6AE0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A590 RID: 42384 RVA: 0x002E88F0 File Offset: 0x002E6AF0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A591 RID: 42385 RVA: 0x002E8900 File Offset: 0x002E6B00
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A592 RID: 42386 RVA: 0x002E8910 File Offset: 0x002E6B10
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A593 RID: 42387 RVA: 0x002E8920 File Offset: 0x002E6B20
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A594 RID: 42388 RVA: 0x002E8930 File Offset: 0x002E6B30
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A595 RID: 42389 RVA: 0x002E8940 File Offset: 0x002E6B40
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A596 RID: 42390 RVA: 0x002E8950 File Offset: 0x002E6B50
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A597 RID: 42391 RVA: 0x002E8960 File Offset: 0x002E6B60
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002184 RID: 8580
			// (get) Token: 0x0600A598 RID: 42392 RVA: 0x002E8970 File Offset: 0x002E6B70
			// (set) Token: 0x0600A599 RID: 42393 RVA: 0x002E8980 File Offset: 0x002E6B80
			public Text m_nameText
			{
				get
				{
					return this.m_owner.m_nameText;
				}
				set
				{
					this.m_owner.m_nameText = value;
				}
			}

			// Token: 0x17002185 RID: 8581
			// (get) Token: 0x0600A59A RID: 42394 RVA: 0x002E8990 File Offset: 0x002E6B90
			// (set) Token: 0x0600A59B RID: 42395 RVA: 0x002E89A0 File Offset: 0x002E6BA0
			public Text m_descText
			{
				get
				{
					return this.m_owner.m_descText;
				}
				set
				{
					this.m_owner.m_descText = value;
				}
			}

			// Token: 0x17002186 RID: 8582
			// (get) Token: 0x0600A59C RID: 42396 RVA: 0x002E89B0 File Offset: 0x002E6BB0
			// (set) Token: 0x0600A59D RID: 42397 RVA: 0x002E89C0 File Offset: 0x002E6BC0
			public GameObject m_rewardGoodsGameObject
			{
				get
				{
					return this.m_owner.m_rewardGoodsGameObject;
				}
				set
				{
					this.m_owner.m_rewardGoodsGameObject = value;
				}
			}

			// Token: 0x17002187 RID: 8583
			// (get) Token: 0x0600A59E RID: 42398 RVA: 0x002E89D0 File Offset: 0x002E6BD0
			// (set) Token: 0x0600A59F RID: 42399 RVA: 0x002E89E0 File Offset: 0x002E6BE0
			public GameObject m_completeGameObject
			{
				get
				{
					return this.m_owner.m_completeGameObject;
				}
				set
				{
					this.m_owner.m_completeGameObject = value;
				}
			}

			// Token: 0x17002188 RID: 8584
			// (get) Token: 0x0600A5A0 RID: 42400 RVA: 0x002E89F0 File Offset: 0x002E6BF0
			// (set) Token: 0x0600A5A1 RID: 42401 RVA: 0x002E8A00 File Offset: 0x002E6C00
			public RewardGoodsUIController m_rewardGoodsUIController
			{
				get
				{
					return this.m_owner.m_rewardGoodsUIController;
				}
				set
				{
					this.m_owner.m_rewardGoodsUIController = value;
				}
			}

			// Token: 0x0600A5A2 RID: 42402 RVA: 0x002E8A10 File Offset: 0x002E6C10
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04006E1C RID: 28188
			private BattleAchievementItemUIController m_owner;
		}
	}
}
