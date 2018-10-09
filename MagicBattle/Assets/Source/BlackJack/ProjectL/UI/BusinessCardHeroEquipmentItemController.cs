using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B2D RID: 2861
	[HotFix]
	public class BusinessCardHeroEquipmentItemController : UIControllerBase
	{
		// Token: 0x0600C1CC RID: 49612 RVA: 0x0035DD80 File Offset: 0x0035BF80
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
			this.m_equipmentItemButton.onClick.AddListener(new UnityAction(this.OnItemClick));
		}

		// Token: 0x0600C1CD RID: 49613 RVA: 0x0035DE04 File Offset: 0x0035C004
		public void SetEquipmentInfo(BattleHeroEquipment equipment)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentInfoBattleHeroEquipment_hotfix != null)
			{
				this.m_SetEquipmentInfoBattleHeroEquipment_hotfix.call(new object[]
				{
					this,
					equipment
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (equipment != null)
			{
				this.m_equipment = equipment;
				this.m_equipmentItemBGImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameNameByRank(equipment.EquipmentInfo.Rank));
				this.m_equipmentItemIcon.sprite = AssetUtility.Instance.GetSprite(equipment.EquipmentInfo.Icon);
				UIUtility.SetGameObjectChildrenActiveCount(this.m_equipmentItemStarGroup, equipment.StarLevel);
				this.m_equipmentSSREffectGameObject.SetActive(UIUtility.IsRankSSR(equipment.EquipmentInfo.Rank));
			}
		}

		// Token: 0x0600C1CE RID: 49614 RVA: 0x0035DEF4 File Offset: 0x0035C0F4
		public BattleHeroEquipment GetEquipment()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEquipment_hotfix != null)
			{
				return (BattleHeroEquipment)this.m_GetEquipment_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_equipment;
		}

		// Token: 0x0600C1CF RID: 49615 RVA: 0x0035DF68 File Offset: 0x0035C168
		private void OnItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnItemClick_hotfix != null)
			{
				this.m_OnItemClick_hotfix.call(new object[]
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

		// Token: 0x14000250 RID: 592
		// (add) Token: 0x0600C1D0 RID: 49616 RVA: 0x0035DFE0 File Offset: 0x0035C1E0
		// (remove) Token: 0x0600C1D1 RID: 49617 RVA: 0x0035E07C File Offset: 0x0035C27C
		public event Action<BusinessCardHeroEquipmentItemController> EventOnClick
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
				Action<BusinessCardHeroEquipmentItemController> action = this.EventOnClick;
				Action<BusinessCardHeroEquipmentItemController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BusinessCardHeroEquipmentItemController>>(ref this.EventOnClick, (Action<BusinessCardHeroEquipmentItemController>)Delegate.Combine(action2, value), action);
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
				Action<BusinessCardHeroEquipmentItemController> action = this.EventOnClick;
				Action<BusinessCardHeroEquipmentItemController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BusinessCardHeroEquipmentItemController>>(ref this.EventOnClick, (Action<BusinessCardHeroEquipmentItemController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x0600C1D2 RID: 49618 RVA: 0x0035E118 File Offset: 0x0035C318
		// (set) Token: 0x0600C1D3 RID: 49619 RVA: 0x0035E138 File Offset: 0x0035C338
		[DoNotToLua]
		public new BusinessCardHeroEquipmentItemController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BusinessCardHeroEquipmentItemController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C1D4 RID: 49620 RVA: 0x0035E144 File Offset: 0x0035C344
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600C1D5 RID: 49621 RVA: 0x0035E150 File Offset: 0x0035C350
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600C1D6 RID: 49622 RVA: 0x0035E158 File Offset: 0x0035C358
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600C1D7 RID: 49623 RVA: 0x0035E160 File Offset: 0x0035C360
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600C1D8 RID: 49624 RVA: 0x0035E174 File Offset: 0x0035C374
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600C1D9 RID: 49625 RVA: 0x0035E17C File Offset: 0x0035C37C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600C1DA RID: 49626 RVA: 0x0035E188 File Offset: 0x0035C388
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600C1DB RID: 49627 RVA: 0x0035E194 File Offset: 0x0035C394
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600C1DC RID: 49628 RVA: 0x0035E1A0 File Offset: 0x0035C3A0
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600C1DD RID: 49629 RVA: 0x0035E1AC File Offset: 0x0035C3AC
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600C1DE RID: 49630 RVA: 0x0035E1B8 File Offset: 0x0035C3B8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600C1DF RID: 49631 RVA: 0x0035E1C4 File Offset: 0x0035C3C4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600C1E0 RID: 49632 RVA: 0x0035E1D0 File Offset: 0x0035C3D0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600C1E1 RID: 49633 RVA: 0x0035E1DC File Offset: 0x0035C3DC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600C1E2 RID: 49634 RVA: 0x0035E1E8 File Offset: 0x0035C3E8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600C1E3 RID: 49635 RVA: 0x0035E1F0 File Offset: 0x0035C3F0
		private void __callDele_EventOnClick(BusinessCardHeroEquipmentItemController obj)
		{
			Action<BusinessCardHeroEquipmentItemController> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x0600C1E4 RID: 49636 RVA: 0x0035E214 File Offset: 0x0035C414
		private void __clearDele_EventOnClick(BusinessCardHeroEquipmentItemController obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600C1E5 RID: 49637 RVA: 0x0035E220 File Offset: 0x0035C420
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
					this.m_SetEquipmentInfoBattleHeroEquipment_hotfix = (luaObj.RawGet("SetEquipmentInfo") as LuaFunction);
					this.m_GetEquipment_hotfix = (luaObj.RawGet("GetEquipment") as LuaFunction);
					this.m_OnItemClick_hotfix = (luaObj.RawGet("OnItemClick") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C1E6 RID: 49638 RVA: 0x0035E368 File Offset: 0x0035C568
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardHeroEquipmentItemController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007B5D RID: 31581
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_equipmentItemButton;

		// Token: 0x04007B5E RID: 31582
		[AutoBind("./BGFrame", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_equipmentItemBGImage;

		// Token: 0x04007B5F RID: 31583
		[AutoBind("./SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentSSREffectGameObject;

		// Token: 0x04007B60 RID: 31584
		[AutoBind("./Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_equipmentItemIcon;

		// Token: 0x04007B61 RID: 31585
		[AutoBind("./StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_equipmentItemStarGroup;

		// Token: 0x04007B62 RID: 31586
		private BattleHeroEquipment m_equipment;

		// Token: 0x04007B63 RID: 31587
		[DoNotToLua]
		private BusinessCardHeroEquipmentItemController.LuaExportHelper luaExportHelper;

		// Token: 0x04007B64 RID: 31588
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007B65 RID: 31589
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007B66 RID: 31590
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007B67 RID: 31591
		private LuaFunction m_SetEquipmentInfoBattleHeroEquipment_hotfix;

		// Token: 0x04007B68 RID: 31592
		private LuaFunction m_GetEquipment_hotfix;

		// Token: 0x04007B69 RID: 31593
		private LuaFunction m_OnItemClick_hotfix;

		// Token: 0x04007B6A RID: 31594
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04007B6B RID: 31595
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000B2E RID: 2862
		public new class LuaExportHelper
		{
			// Token: 0x0600C1E7 RID: 49639 RVA: 0x0035E3D0 File Offset: 0x0035C5D0
			public LuaExportHelper(BusinessCardHeroEquipmentItemController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C1E8 RID: 49640 RVA: 0x0035E3E0 File Offset: 0x0035C5E0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600C1E9 RID: 49641 RVA: 0x0035E3F0 File Offset: 0x0035C5F0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600C1EA RID: 49642 RVA: 0x0035E400 File Offset: 0x0035C600
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600C1EB RID: 49643 RVA: 0x0035E410 File Offset: 0x0035C610
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600C1EC RID: 49644 RVA: 0x0035E428 File Offset: 0x0035C628
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600C1ED RID: 49645 RVA: 0x0035E438 File Offset: 0x0035C638
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600C1EE RID: 49646 RVA: 0x0035E448 File Offset: 0x0035C648
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600C1EF RID: 49647 RVA: 0x0035E458 File Offset: 0x0035C658
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600C1F0 RID: 49648 RVA: 0x0035E468 File Offset: 0x0035C668
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600C1F1 RID: 49649 RVA: 0x0035E478 File Offset: 0x0035C678
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600C1F2 RID: 49650 RVA: 0x0035E488 File Offset: 0x0035C688
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600C1F3 RID: 49651 RVA: 0x0035E498 File Offset: 0x0035C698
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600C1F4 RID: 49652 RVA: 0x0035E4A8 File Offset: 0x0035C6A8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600C1F5 RID: 49653 RVA: 0x0035E4B8 File Offset: 0x0035C6B8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600C1F6 RID: 49654 RVA: 0x0035E4C8 File Offset: 0x0035C6C8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600C1F7 RID: 49655 RVA: 0x0035E4D8 File Offset: 0x0035C6D8
			public void __callDele_EventOnClick(BusinessCardHeroEquipmentItemController obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x0600C1F8 RID: 49656 RVA: 0x0035E4E8 File Offset: 0x0035C6E8
			public void __clearDele_EventOnClick(BusinessCardHeroEquipmentItemController obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x17002703 RID: 9987
			// (get) Token: 0x0600C1F9 RID: 49657 RVA: 0x0035E4F8 File Offset: 0x0035C6F8
			// (set) Token: 0x0600C1FA RID: 49658 RVA: 0x0035E508 File Offset: 0x0035C708
			public Button m_equipmentItemButton
			{
				get
				{
					return this.m_owner.m_equipmentItemButton;
				}
				set
				{
					this.m_owner.m_equipmentItemButton = value;
				}
			}

			// Token: 0x17002704 RID: 9988
			// (get) Token: 0x0600C1FB RID: 49659 RVA: 0x0035E518 File Offset: 0x0035C718
			// (set) Token: 0x0600C1FC RID: 49660 RVA: 0x0035E528 File Offset: 0x0035C728
			public Image m_equipmentItemBGImage
			{
				get
				{
					return this.m_owner.m_equipmentItemBGImage;
				}
				set
				{
					this.m_owner.m_equipmentItemBGImage = value;
				}
			}

			// Token: 0x17002705 RID: 9989
			// (get) Token: 0x0600C1FD RID: 49661 RVA: 0x0035E538 File Offset: 0x0035C738
			// (set) Token: 0x0600C1FE RID: 49662 RVA: 0x0035E548 File Offset: 0x0035C748
			public GameObject m_equipmentSSREffectGameObject
			{
				get
				{
					return this.m_owner.m_equipmentSSREffectGameObject;
				}
				set
				{
					this.m_owner.m_equipmentSSREffectGameObject = value;
				}
			}

			// Token: 0x17002706 RID: 9990
			// (get) Token: 0x0600C1FF RID: 49663 RVA: 0x0035E558 File Offset: 0x0035C758
			// (set) Token: 0x0600C200 RID: 49664 RVA: 0x0035E568 File Offset: 0x0035C768
			public Image m_equipmentItemIcon
			{
				get
				{
					return this.m_owner.m_equipmentItemIcon;
				}
				set
				{
					this.m_owner.m_equipmentItemIcon = value;
				}
			}

			// Token: 0x17002707 RID: 9991
			// (get) Token: 0x0600C201 RID: 49665 RVA: 0x0035E578 File Offset: 0x0035C778
			// (set) Token: 0x0600C202 RID: 49666 RVA: 0x0035E588 File Offset: 0x0035C788
			public GameObject m_equipmentItemStarGroup
			{
				get
				{
					return this.m_owner.m_equipmentItemStarGroup;
				}
				set
				{
					this.m_owner.m_equipmentItemStarGroup = value;
				}
			}

			// Token: 0x17002708 RID: 9992
			// (get) Token: 0x0600C203 RID: 49667 RVA: 0x0035E598 File Offset: 0x0035C798
			// (set) Token: 0x0600C204 RID: 49668 RVA: 0x0035E5A8 File Offset: 0x0035C7A8
			public BattleHeroEquipment m_equipment
			{
				get
				{
					return this.m_owner.m_equipment;
				}
				set
				{
					this.m_owner.m_equipment = value;
				}
			}

			// Token: 0x0600C205 RID: 49669 RVA: 0x0035E5B8 File Offset: 0x0035C7B8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600C206 RID: 49670 RVA: 0x0035E5C8 File Offset: 0x0035C7C8
			public void OnItemClick()
			{
				this.m_owner.OnItemClick();
			}

			// Token: 0x04007B6C RID: 31596
			private BusinessCardHeroEquipmentItemController m_owner;
		}
	}
}
