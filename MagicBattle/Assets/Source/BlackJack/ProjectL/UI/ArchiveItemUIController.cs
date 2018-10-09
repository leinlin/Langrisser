using System;
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
	// Token: 0x020009DB RID: 2523
	[HotFix]
	public class ArchiveItemUIController : UIControllerBase
	{
		// Token: 0x060094DA RID: 38106 RVA: 0x002AC100 File Offset: 0x002AA300
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
			this.m_ItemButton.onClick.AddListener(new UnityAction(this.OnItemClick));
		}

		// Token: 0x060094DB RID: 38107 RVA: 0x002AC184 File Offset: 0x002AA384
		public void SetEquipmentInfo(EquipmentArchiveUIController.EquipmentInfoWrap equipmentInfoWrap)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEquipmentInfoEquipmentInfoWrap_hotfix != null)
			{
				this.m_SetEquipmentInfoEquipmentInfoWrap_hotfix.call(new object[]
				{
					this,
					equipmentInfoWrap
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_equipmentInfoWrap = equipmentInfoWrap;
			this.Refresh();
		}

		// Token: 0x060094DC RID: 38108 RVA: 0x002AC204 File Offset: 0x002AA404
		public void Refresh()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Refresh_hotfix != null)
			{
				this.m_Refresh_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataEquipmentInfo equipmentInfo = this.m_equipmentInfoWrap.equipmentInfo;
			string goodsFrameNameByRank = UIUtility.GetGoodsFrameNameByRank(equipmentInfo.Rank);
			this.m_bgImage.sprite = AssetUtility.Instance.GetSprite(goodsFrameNameByRank);
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(equipmentInfo.Icon);
			this.m_ssrEffect.SetActive(false);
			if (equipmentInfo.Rank == 4)
			{
				this.m_ssrEffect.SetActive(true);
			}
			this.m_selectImage.gameObject.SetActive(this.m_equipmentInfoWrap.isSelect);
			this.m_darkCoverImage.SetActive(!this.m_equipmentInfoWrap.isUnlocked);
			for (int i = 0; i < 6; i++)
			{
				if (equipmentInfo.BornStarLevel > i)
				{
					this.m_starGroup.transform.GetChild(i).gameObject.SetActive(true);
				}
				else
				{
					this.m_starGroup.transform.GetChild(i).gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x060094DD RID: 38109 RVA: 0x002AC360 File Offset: 0x002AA560
		public void OnItemClick()
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
			if (this.OnItemClickEvent != null)
			{
				this.OnItemClickEvent(this);
			}
		}

		// Token: 0x060094DE RID: 38110 RVA: 0x002AC3D8 File Offset: 0x002AA5D8
		public void SetSelected(bool isSelected)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSelectedBoolean_hotfix != null)
			{
				this.m_SetSelectedBoolean_hotfix.call(new object[]
				{
					this,
					isSelected
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_equipmentInfoWrap.isSelect = isSelected;
			this.Refresh();
		}

		// Token: 0x140001A2 RID: 418
		// (add) Token: 0x060094DF RID: 38111 RVA: 0x002AC45C File Offset: 0x002AA65C
		// (remove) Token: 0x060094E0 RID: 38112 RVA: 0x002AC4F8 File Offset: 0x002AA6F8
		public event Action<ArchiveItemUIController> OnItemClickEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_OnItemClickEventAction`1_hotfix != null)
				{
					this.m_add_OnItemClickEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArchiveItemUIController> action = this.OnItemClickEvent;
				Action<ArchiveItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArchiveItemUIController>>(ref this.OnItemClickEvent, (Action<ArchiveItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_OnItemClickEventAction`1_hotfix != null)
				{
					this.m_remove_OnItemClickEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArchiveItemUIController> action = this.OnItemClickEvent;
				Action<ArchiveItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArchiveItemUIController>>(ref this.OnItemClickEvent, (Action<ArchiveItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x060094E1 RID: 38113 RVA: 0x002AC594 File Offset: 0x002AA794
		// (set) Token: 0x060094E2 RID: 38114 RVA: 0x002AC5B4 File Offset: 0x002AA7B4
		[DoNotToLua]
		public new ArchiveItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArchiveItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060094E3 RID: 38115 RVA: 0x002AC5C0 File Offset: 0x002AA7C0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060094E4 RID: 38116 RVA: 0x002AC5CC File Offset: 0x002AA7CC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060094E5 RID: 38117 RVA: 0x002AC5D4 File Offset: 0x002AA7D4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060094E6 RID: 38118 RVA: 0x002AC5DC File Offset: 0x002AA7DC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060094E7 RID: 38119 RVA: 0x002AC5F0 File Offset: 0x002AA7F0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060094E8 RID: 38120 RVA: 0x002AC5F8 File Offset: 0x002AA7F8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060094E9 RID: 38121 RVA: 0x002AC604 File Offset: 0x002AA804
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060094EA RID: 38122 RVA: 0x002AC610 File Offset: 0x002AA810
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x002AC61C File Offset: 0x002AA81C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060094EC RID: 38124 RVA: 0x002AC628 File Offset: 0x002AA828
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060094ED RID: 38125 RVA: 0x002AC634 File Offset: 0x002AA834
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060094EE RID: 38126 RVA: 0x002AC640 File Offset: 0x002AA840
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060094EF RID: 38127 RVA: 0x002AC64C File Offset: 0x002AA84C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060094F0 RID: 38128 RVA: 0x002AC658 File Offset: 0x002AA858
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060094F1 RID: 38129 RVA: 0x002AC664 File Offset: 0x002AA864
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060094F2 RID: 38130 RVA: 0x002AC66C File Offset: 0x002AA86C
		private void __callDele_OnItemClickEvent(ArchiveItemUIController obj)
		{
			Action<ArchiveItemUIController> onItemClickEvent = this.OnItemClickEvent;
			if (onItemClickEvent != null)
			{
				onItemClickEvent(obj);
			}
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x002AC690 File Offset: 0x002AA890
		private void __clearDele_OnItemClickEvent(ArchiveItemUIController obj)
		{
			this.OnItemClickEvent = null;
		}

		// Token: 0x060094F4 RID: 38132 RVA: 0x002AC69C File Offset: 0x002AA89C
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
					this.m_SetEquipmentInfoEquipmentInfoWrap_hotfix = (luaObj.RawGet("SetEquipmentInfo") as LuaFunction);
					this.m_Refresh_hotfix = (luaObj.RawGet("Refresh") as LuaFunction);
					this.m_OnItemClick_hotfix = (luaObj.RawGet("OnItemClick") as LuaFunction);
					this.m_SetSelectedBoolean_hotfix = (luaObj.RawGet("SetSelected") as LuaFunction);
					this.m_add_OnItemClickEventAction`1_hotfix = (luaObj.RawGet("add_OnItemClickEvent") as LuaFunction);
					this.m_remove_OnItemClickEventAction`1_hotfix = (luaObj.RawGet("remove_OnItemClickEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060094F5 RID: 38133 RVA: 0x002AC800 File Offset: 0x002AAA00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArchiveItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006717 RID: 26391
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_ItemButton;

		// Token: 0x04006718 RID: 26392
		[AutoBind("./SelectFrameImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_selectImage;

		// Token: 0x04006719 RID: 26393
		[AutoBind("./BgImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_bgImage;

		// Token: 0x0400671A RID: 26394
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x0400671B RID: 26395
		[AutoBind("./SSREffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_ssrEffect;

		// Token: 0x0400671C RID: 26396
		[AutoBind("./StarGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_starGroup;

		// Token: 0x0400671D RID: 26397
		[AutoBind("./DarkCoverImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_darkCoverImage;

		// Token: 0x0400671E RID: 26398
		public EquipmentArchiveUIController.EquipmentInfoWrap m_equipmentInfoWrap;

		// Token: 0x0400671F RID: 26399
		private const int SSRRank = 4;

		// Token: 0x04006720 RID: 26400
		[DoNotToLua]
		private ArchiveItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006721 RID: 26401
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006722 RID: 26402
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006723 RID: 26403
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006724 RID: 26404
		private LuaFunction m_SetEquipmentInfoEquipmentInfoWrap_hotfix;

		// Token: 0x04006725 RID: 26405
		private LuaFunction m_Refresh_hotfix;

		// Token: 0x04006726 RID: 26406
		private LuaFunction m_OnItemClick_hotfix;

		// Token: 0x04006727 RID: 26407
		private LuaFunction m_SetSelectedBoolean_hotfix;

		// Token: 0x04006728 RID: 26408
		private LuaFunction m_add_OnItemClickEventAction;

		// Token: 0x04006729 RID: 26409
		private LuaFunction m_remove_OnItemClickEventAction;

		// Token: 0x020009DC RID: 2524
		public new class LuaExportHelper
		{
			// Token: 0x060094F6 RID: 38134 RVA: 0x002AC868 File Offset: 0x002AAA68
			public LuaExportHelper(ArchiveItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060094F7 RID: 38135 RVA: 0x002AC878 File Offset: 0x002AAA78
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060094F8 RID: 38136 RVA: 0x002AC888 File Offset: 0x002AAA88
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060094F9 RID: 38137 RVA: 0x002AC898 File Offset: 0x002AAA98
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060094FA RID: 38138 RVA: 0x002AC8A8 File Offset: 0x002AAAA8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060094FB RID: 38139 RVA: 0x002AC8C0 File Offset: 0x002AAAC0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060094FC RID: 38140 RVA: 0x002AC8D0 File Offset: 0x002AAAD0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060094FD RID: 38141 RVA: 0x002AC8E0 File Offset: 0x002AAAE0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060094FE RID: 38142 RVA: 0x002AC8F0 File Offset: 0x002AAAF0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060094FF RID: 38143 RVA: 0x002AC900 File Offset: 0x002AAB00
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009500 RID: 38144 RVA: 0x002AC910 File Offset: 0x002AAB10
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009501 RID: 38145 RVA: 0x002AC920 File Offset: 0x002AAB20
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009502 RID: 38146 RVA: 0x002AC930 File Offset: 0x002AAB30
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009503 RID: 38147 RVA: 0x002AC940 File Offset: 0x002AAB40
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009504 RID: 38148 RVA: 0x002AC950 File Offset: 0x002AAB50
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009505 RID: 38149 RVA: 0x002AC960 File Offset: 0x002AAB60
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06009506 RID: 38150 RVA: 0x002AC970 File Offset: 0x002AAB70
			public void __callDele_OnItemClickEvent(ArchiveItemUIController obj)
			{
				this.m_owner.__callDele_OnItemClickEvent(obj);
			}

			// Token: 0x06009507 RID: 38151 RVA: 0x002AC980 File Offset: 0x002AAB80
			public void __clearDele_OnItemClickEvent(ArchiveItemUIController obj)
			{
				this.m_owner.__clearDele_OnItemClickEvent(obj);
			}

			// Token: 0x17001EAC RID: 7852
			// (get) Token: 0x06009508 RID: 38152 RVA: 0x002AC990 File Offset: 0x002AAB90
			// (set) Token: 0x06009509 RID: 38153 RVA: 0x002AC9A0 File Offset: 0x002AABA0
			public Button m_ItemButton
			{
				get
				{
					return this.m_owner.m_ItemButton;
				}
				set
				{
					this.m_owner.m_ItemButton = value;
				}
			}

			// Token: 0x17001EAD RID: 7853
			// (get) Token: 0x0600950A RID: 38154 RVA: 0x002AC9B0 File Offset: 0x002AABB0
			// (set) Token: 0x0600950B RID: 38155 RVA: 0x002AC9C0 File Offset: 0x002AABC0
			public Image m_selectImage
			{
				get
				{
					return this.m_owner.m_selectImage;
				}
				set
				{
					this.m_owner.m_selectImage = value;
				}
			}

			// Token: 0x17001EAE RID: 7854
			// (get) Token: 0x0600950C RID: 38156 RVA: 0x002AC9D0 File Offset: 0x002AABD0
			// (set) Token: 0x0600950D RID: 38157 RVA: 0x002AC9E0 File Offset: 0x002AABE0
			public Image m_bgImage
			{
				get
				{
					return this.m_owner.m_bgImage;
				}
				set
				{
					this.m_owner.m_bgImage = value;
				}
			}

			// Token: 0x17001EAF RID: 7855
			// (get) Token: 0x0600950E RID: 38158 RVA: 0x002AC9F0 File Offset: 0x002AABF0
			// (set) Token: 0x0600950F RID: 38159 RVA: 0x002ACA00 File Offset: 0x002AAC00
			public Image m_iconImage
			{
				get
				{
					return this.m_owner.m_iconImage;
				}
				set
				{
					this.m_owner.m_iconImage = value;
				}
			}

			// Token: 0x17001EB0 RID: 7856
			// (get) Token: 0x06009510 RID: 38160 RVA: 0x002ACA10 File Offset: 0x002AAC10
			// (set) Token: 0x06009511 RID: 38161 RVA: 0x002ACA20 File Offset: 0x002AAC20
			public GameObject m_ssrEffect
			{
				get
				{
					return this.m_owner.m_ssrEffect;
				}
				set
				{
					this.m_owner.m_ssrEffect = value;
				}
			}

			// Token: 0x17001EB1 RID: 7857
			// (get) Token: 0x06009512 RID: 38162 RVA: 0x002ACA30 File Offset: 0x002AAC30
			// (set) Token: 0x06009513 RID: 38163 RVA: 0x002ACA40 File Offset: 0x002AAC40
			public GameObject m_starGroup
			{
				get
				{
					return this.m_owner.m_starGroup;
				}
				set
				{
					this.m_owner.m_starGroup = value;
				}
			}

			// Token: 0x17001EB2 RID: 7858
			// (get) Token: 0x06009514 RID: 38164 RVA: 0x002ACA50 File Offset: 0x002AAC50
			// (set) Token: 0x06009515 RID: 38165 RVA: 0x002ACA60 File Offset: 0x002AAC60
			public GameObject m_darkCoverImage
			{
				get
				{
					return this.m_owner.m_darkCoverImage;
				}
				set
				{
					this.m_owner.m_darkCoverImage = value;
				}
			}

			// Token: 0x17001EB3 RID: 7859
			// (get) Token: 0x06009516 RID: 38166 RVA: 0x002ACA70 File Offset: 0x002AAC70
			public static int SSRRank
			{
				get
				{
					return 4;
				}
			}

			// Token: 0x06009517 RID: 38167 RVA: 0x002ACA74 File Offset: 0x002AAC74
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400672A RID: 26410
			private ArchiveItemUIController m_owner;
		}
	}
}
