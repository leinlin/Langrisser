using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009CE RID: 2510
	[HotFix]
	public class AnikiLevelListItemUIController : UIControllerBase
	{
		// Token: 0x060092BC RID: 37564 RVA: 0x002A5FD8 File Offset: 0x002A41D8
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
			this.m_startButton.onClick.AddListener(new UnityAction(this.OnStartButtonClick));
			this.m_lockedButton.onClick.AddListener(new UnityAction(this.OnLockedButtonClick));
		}

		// Token: 0x060092BD RID: 37565 RVA: 0x002A6078 File Offset: 0x002A4278
		public void SetAnikiLevelInfo(ConfigDataAnikiLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetAnikiLevelInfoConfigDataAnikiLevelInfo_hotfix != null)
			{
				this.m_SetAnikiLevelInfoConfigDataAnikiLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_anikiLevelInfo = levelInfo;
			this.m_nameText.text = levelInfo.Name;
			this.m_levelText.text = levelInfo.MonsterLevel.ToString();
			this.m_icon1Image.sprite = AssetUtility.Instance.GetSprite(levelInfo.Icon1);
			this.m_icon2Image.sprite = AssetUtility.Instance.GetSprite(levelInfo.Icon2);
			this.m_energyText.text = levelInfo.EnergySuccess.ToString();
			GameObjectUtility.DestroyChildren(this.m_rewardGroupGameObject);
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			List<Goods> list = new List<Goods>();
			UIUtility.AppendRandomDropRewardGoodsToList(levelInfo.Drop_ID, list);
			if (list.Count > levelInfo.DisplayRewardCount)
			{
				list.RemoveRange(levelInfo.DisplayRewardCount, list.Count - levelInfo.DisplayRewardCount);
			}
			RewardGoodsUIController.CreateRewardGoodsList(list, this.m_rewardGroupGameObject.transform, assetInContainer, null, false, 0, true);
		}

		// Token: 0x060092BE RID: 37566 RVA: 0x002A61E0 File Offset: 0x002A43E0
		public ConfigDataAnikiLevelInfo GetAnikiLevelInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAnikiLevelInfo_hotfix != null)
			{
				return (ConfigDataAnikiLevelInfo)this.m_GetAnikiLevelInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_anikiLevelInfo;
		}

		// Token: 0x060092BF RID: 37567 RVA: 0x002A6254 File Offset: 0x002A4454
		public void SetLocked(bool locked)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLockedBoolean_hotfix != null)
			{
				this.m_SetLockedBoolean_hotfix.call(new object[]
				{
					this,
					locked
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_lockedButton.gameObject.SetActive(locked);
		}

		// Token: 0x060092C0 RID: 37568 RVA: 0x002A62D8 File Offset: 0x002A44D8
		private void OnStartButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartButtonClick_hotfix != null)
			{
				this.m_OnStartButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnStartButtonClick != null)
			{
				this.EventOnStartButtonClick(this);
			}
		}

		// Token: 0x060092C1 RID: 37569 RVA: 0x002A6350 File Offset: 0x002A4550
		private void OnLockedButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLockedButtonClick_hotfix != null)
			{
				this.m_OnLockedButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_AnikiLevelNotOpen, 2f, null, true);
		}

		// Token: 0x1400019E RID: 414
		// (add) Token: 0x060092C2 RID: 37570 RVA: 0x002A63C8 File Offset: 0x002A45C8
		// (remove) Token: 0x060092C3 RID: 37571 RVA: 0x002A6464 File Offset: 0x002A4664
		public event Action<AnikiLevelListItemUIController> EventOnStartButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnStartButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnStartButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<AnikiLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<AnikiLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<AnikiLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<AnikiLevelListItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnStartButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnStartButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<AnikiLevelListItemUIController> action = this.EventOnStartButtonClick;
				Action<AnikiLevelListItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<AnikiLevelListItemUIController>>(ref this.EventOnStartButtonClick, (Action<AnikiLevelListItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x060092C4 RID: 37572 RVA: 0x002A6500 File Offset: 0x002A4700
		// (set) Token: 0x060092C5 RID: 37573 RVA: 0x002A6520 File Offset: 0x002A4720
		[DoNotToLua]
		public new AnikiLevelListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new AnikiLevelListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060092C6 RID: 37574 RVA: 0x002A652C File Offset: 0x002A472C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060092C7 RID: 37575 RVA: 0x002A6538 File Offset: 0x002A4738
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060092C8 RID: 37576 RVA: 0x002A6540 File Offset: 0x002A4740
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060092C9 RID: 37577 RVA: 0x002A6548 File Offset: 0x002A4748
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060092CA RID: 37578 RVA: 0x002A655C File Offset: 0x002A475C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060092CB RID: 37579 RVA: 0x002A6564 File Offset: 0x002A4764
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060092CC RID: 37580 RVA: 0x002A6570 File Offset: 0x002A4770
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060092CD RID: 37581 RVA: 0x002A657C File Offset: 0x002A477C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060092CE RID: 37582 RVA: 0x002A6588 File Offset: 0x002A4788
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060092CF RID: 37583 RVA: 0x002A6594 File Offset: 0x002A4794
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060092D0 RID: 37584 RVA: 0x002A65A0 File Offset: 0x002A47A0
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060092D1 RID: 37585 RVA: 0x002A65AC File Offset: 0x002A47AC
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060092D2 RID: 37586 RVA: 0x002A65B8 File Offset: 0x002A47B8
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060092D3 RID: 37587 RVA: 0x002A65C4 File Offset: 0x002A47C4
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060092D4 RID: 37588 RVA: 0x002A65D0 File Offset: 0x002A47D0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060092D5 RID: 37589 RVA: 0x002A65D8 File Offset: 0x002A47D8
		private void __callDele_EventOnStartButtonClick(AnikiLevelListItemUIController obj)
		{
			Action<AnikiLevelListItemUIController> eventOnStartButtonClick = this.EventOnStartButtonClick;
			if (eventOnStartButtonClick != null)
			{
				eventOnStartButtonClick(obj);
			}
		}

		// Token: 0x060092D6 RID: 37590 RVA: 0x002A65FC File Offset: 0x002A47FC
		private void __clearDele_EventOnStartButtonClick(AnikiLevelListItemUIController obj)
		{
			this.EventOnStartButtonClick = null;
		}

		// Token: 0x060092D7 RID: 37591 RVA: 0x002A6608 File Offset: 0x002A4808
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
					this.m_SetAnikiLevelInfoConfigDataAnikiLevelInfo_hotfix = (luaObj.RawGet("SetAnikiLevelInfo") as LuaFunction);
					this.m_GetAnikiLevelInfo_hotfix = (luaObj.RawGet("GetAnikiLevelInfo") as LuaFunction);
					this.m_SetLockedBoolean_hotfix = (luaObj.RawGet("SetLocked") as LuaFunction);
					this.m_OnStartButtonClick_hotfix = (luaObj.RawGet("OnStartButtonClick") as LuaFunction);
					this.m_OnLockedButtonClick_hotfix = (luaObj.RawGet("OnLockedButtonClick") as LuaFunction);
					this.m_add_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnStartButtonClick") as LuaFunction);
					this.m_remove_EventOnStartButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnStartButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060092D8 RID: 37592 RVA: 0x002A6784 File Offset: 0x002A4984
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AnikiLevelListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400666C RID: 26220
		[AutoBind("./Icon1", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_icon1Image;

		// Token: 0x0400666D RID: 26221
		[AutoBind("./Icon2", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_icon2Image;

		// Token: 0x0400666E RID: 26222
		[AutoBind("./Level/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x0400666F RID: 26223
		[AutoBind("./Name/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04006670 RID: 26224
		[AutoBind("./EnergyValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_energyText;

		// Token: 0x04006671 RID: 26225
		[AutoBind("./Locked", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_lockedButton;

		// Token: 0x04006672 RID: 26226
		[AutoBind("./StartButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_startButton;

		// Token: 0x04006673 RID: 26227
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGroupGameObject;

		// Token: 0x04006674 RID: 26228
		private ConfigDataAnikiLevelInfo m_anikiLevelInfo;

		// Token: 0x04006675 RID: 26229
		[DoNotToLua]
		private AnikiLevelListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006676 RID: 26230
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006677 RID: 26231
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006678 RID: 26232
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006679 RID: 26233
		private LuaFunction m_SetAnikiLevelInfoConfigDataAnikiLevelInfo_hotfix;

		// Token: 0x0400667A RID: 26234
		private LuaFunction m_GetAnikiLevelInfo_hotfix;

		// Token: 0x0400667B RID: 26235
		private LuaFunction m_SetLockedBoolean_hotfix;

		// Token: 0x0400667C RID: 26236
		private LuaFunction m_OnStartButtonClick_hotfix;

		// Token: 0x0400667D RID: 26237
		private LuaFunction m_OnLockedButtonClick_hotfix;

		// Token: 0x0400667E RID: 26238
		private LuaFunction m_add_EventOnStartButtonClickAction;

		// Token: 0x0400667F RID: 26239
		private LuaFunction m_remove_EventOnStartButtonClickAction;

		// Token: 0x020009CF RID: 2511
		public new class LuaExportHelper
		{
			// Token: 0x060092D9 RID: 37593 RVA: 0x002A67EC File Offset: 0x002A49EC
			public LuaExportHelper(AnikiLevelListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060092DA RID: 37594 RVA: 0x002A67FC File Offset: 0x002A49FC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060092DB RID: 37595 RVA: 0x002A680C File Offset: 0x002A4A0C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060092DC RID: 37596 RVA: 0x002A681C File Offset: 0x002A4A1C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060092DD RID: 37597 RVA: 0x002A682C File Offset: 0x002A4A2C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060092DE RID: 37598 RVA: 0x002A6844 File Offset: 0x002A4A44
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060092DF RID: 37599 RVA: 0x002A6854 File Offset: 0x002A4A54
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060092E0 RID: 37600 RVA: 0x002A6864 File Offset: 0x002A4A64
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060092E1 RID: 37601 RVA: 0x002A6874 File Offset: 0x002A4A74
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060092E2 RID: 37602 RVA: 0x002A6884 File Offset: 0x002A4A84
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060092E3 RID: 37603 RVA: 0x002A6894 File Offset: 0x002A4A94
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060092E4 RID: 37604 RVA: 0x002A68A4 File Offset: 0x002A4AA4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060092E5 RID: 37605 RVA: 0x002A68B4 File Offset: 0x002A4AB4
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060092E6 RID: 37606 RVA: 0x002A68C4 File Offset: 0x002A4AC4
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060092E7 RID: 37607 RVA: 0x002A68D4 File Offset: 0x002A4AD4
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060092E8 RID: 37608 RVA: 0x002A68E4 File Offset: 0x002A4AE4
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060092E9 RID: 37609 RVA: 0x002A68F4 File Offset: 0x002A4AF4
			public void __callDele_EventOnStartButtonClick(AnikiLevelListItemUIController obj)
			{
				this.m_owner.__callDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x060092EA RID: 37610 RVA: 0x002A6904 File Offset: 0x002A4B04
			public void __clearDele_EventOnStartButtonClick(AnikiLevelListItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnStartButtonClick(obj);
			}

			// Token: 0x17001E5E RID: 7774
			// (get) Token: 0x060092EB RID: 37611 RVA: 0x002A6914 File Offset: 0x002A4B14
			// (set) Token: 0x060092EC RID: 37612 RVA: 0x002A6924 File Offset: 0x002A4B24
			public Image m_icon1Image
			{
				get
				{
					return this.m_owner.m_icon1Image;
				}
				set
				{
					this.m_owner.m_icon1Image = value;
				}
			}

			// Token: 0x17001E5F RID: 7775
			// (get) Token: 0x060092ED RID: 37613 RVA: 0x002A6934 File Offset: 0x002A4B34
			// (set) Token: 0x060092EE RID: 37614 RVA: 0x002A6944 File Offset: 0x002A4B44
			public Image m_icon2Image
			{
				get
				{
					return this.m_owner.m_icon2Image;
				}
				set
				{
					this.m_owner.m_icon2Image = value;
				}
			}

			// Token: 0x17001E60 RID: 7776
			// (get) Token: 0x060092EF RID: 37615 RVA: 0x002A6954 File Offset: 0x002A4B54
			// (set) Token: 0x060092F0 RID: 37616 RVA: 0x002A6964 File Offset: 0x002A4B64
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

			// Token: 0x17001E61 RID: 7777
			// (get) Token: 0x060092F1 RID: 37617 RVA: 0x002A6974 File Offset: 0x002A4B74
			// (set) Token: 0x060092F2 RID: 37618 RVA: 0x002A6984 File Offset: 0x002A4B84
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

			// Token: 0x17001E62 RID: 7778
			// (get) Token: 0x060092F3 RID: 37619 RVA: 0x002A6994 File Offset: 0x002A4B94
			// (set) Token: 0x060092F4 RID: 37620 RVA: 0x002A69A4 File Offset: 0x002A4BA4
			public Text m_energyText
			{
				get
				{
					return this.m_owner.m_energyText;
				}
				set
				{
					this.m_owner.m_energyText = value;
				}
			}

			// Token: 0x17001E63 RID: 7779
			// (get) Token: 0x060092F5 RID: 37621 RVA: 0x002A69B4 File Offset: 0x002A4BB4
			// (set) Token: 0x060092F6 RID: 37622 RVA: 0x002A69C4 File Offset: 0x002A4BC4
			public Button m_lockedButton
			{
				get
				{
					return this.m_owner.m_lockedButton;
				}
				set
				{
					this.m_owner.m_lockedButton = value;
				}
			}

			// Token: 0x17001E64 RID: 7780
			// (get) Token: 0x060092F7 RID: 37623 RVA: 0x002A69D4 File Offset: 0x002A4BD4
			// (set) Token: 0x060092F8 RID: 37624 RVA: 0x002A69E4 File Offset: 0x002A4BE4
			public Button m_startButton
			{
				get
				{
					return this.m_owner.m_startButton;
				}
				set
				{
					this.m_owner.m_startButton = value;
				}
			}

			// Token: 0x17001E65 RID: 7781
			// (get) Token: 0x060092F9 RID: 37625 RVA: 0x002A69F4 File Offset: 0x002A4BF4
			// (set) Token: 0x060092FA RID: 37626 RVA: 0x002A6A04 File Offset: 0x002A4C04
			public GameObject m_rewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_rewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_rewardGroupGameObject = value;
				}
			}

			// Token: 0x17001E66 RID: 7782
			// (get) Token: 0x060092FB RID: 37627 RVA: 0x002A6A14 File Offset: 0x002A4C14
			// (set) Token: 0x060092FC RID: 37628 RVA: 0x002A6A24 File Offset: 0x002A4C24
			public ConfigDataAnikiLevelInfo m_anikiLevelInfo
			{
				get
				{
					return this.m_owner.m_anikiLevelInfo;
				}
				set
				{
					this.m_owner.m_anikiLevelInfo = value;
				}
			}

			// Token: 0x060092FD RID: 37629 RVA: 0x002A6A34 File Offset: 0x002A4C34
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060092FE RID: 37630 RVA: 0x002A6A44 File Offset: 0x002A4C44
			public void OnStartButtonClick()
			{
				this.m_owner.OnStartButtonClick();
			}

			// Token: 0x060092FF RID: 37631 RVA: 0x002A6A54 File Offset: 0x002A4C54
			public void OnLockedButtonClick()
			{
				this.m_owner.OnLockedButtonClick();
			}

			// Token: 0x04006680 RID: 26240
			private AnikiLevelListItemUIController m_owner;
		}
	}
}
