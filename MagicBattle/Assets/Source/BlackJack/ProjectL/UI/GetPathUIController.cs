using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
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
	// Token: 0x02000BB9 RID: 3001
	[HotFix]
	public class GetPathUIController : UIControllerBase
	{
		// Token: 0x0600CE06 RID: 52742 RVA: 0x0038B1B4 File Offset: 0x003893B4
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
			this.m_returnImgButton.onClick.AddListener(new UnityAction(this.OnReturnImgButtonClick));
		}

		// Token: 0x0600CE07 RID: 52743 RVA: 0x0038B238 File Offset: 0x00389438
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_commonUIStateController, "Show", null, false, true);
		}

		// Token: 0x0600CE08 RID: 52744 RVA: 0x0038B2AC File Offset: 0x003894AC
		public void Close()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Close_hotfix != null)
			{
				this.m_Close_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_commonUIStateController, "Close", delegate
			{
				if (this.EventOnClose != null)
				{
					this.EventOnClose();
				}
			}, false, true);
		}

		// Token: 0x0600CE09 RID: 52745 RVA: 0x0038B32C File Offset: 0x0038952C
		public void UpdateViewInGetPathPanel(GoodsType goodsType, int goodsId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewInGetPathPanelGoodsTypeInt32_hotfix != null)
			{
				this.m_UpdateViewInGetPathPanelGoodsTypeInt32_hotfix.call(new object[]
				{
					this,
					goodsType,
					goodsId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			List<GetPathData> getPathList = null;
			string getPathDesc = string.Empty;
			switch (goodsType)
			{
			case GoodsType.GoodsType_JobMaterial:
			{
				ConfigDataJobMaterialInfo configDataJobMaterialInfo = configDataLoader.GetConfigDataJobMaterialInfo(goodsId);
				if (configDataJobMaterialInfo != null)
				{
					getPathList = configDataJobMaterialInfo.GetPathList;
					getPathDesc = configDataJobMaterialInfo.GetPathDesc;
				}
				break;
			}
			case GoodsType.GoodsType_Item:
			{
				ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(goodsId);
				if (configDataItemInfo != null)
				{
					getPathList = configDataItemInfo.GetPathList;
					getPathDesc = configDataItemInfo.GetPathDesc;
				}
				break;
			}
			case GoodsType.GoodsType_Equipment:
			{
				ConfigDataEquipmentInfo configDataEquipmentInfo = configDataLoader.GetConfigDataEquipmentInfo(goodsId);
				if (configDataEquipmentInfo != null)
				{
					getPathList = configDataEquipmentInfo.GetPathList;
					getPathDesc = configDataEquipmentInfo.GetPathDesc;
				}
				break;
			}
			case GoodsType.GoodsType_EnchantStone:
			{
				ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = configDataLoader.GetConfigDataEnchantStoneInfo(goodsId);
				if (configDataEnchantStoneInfo != null)
				{
					getPathList = configDataEnchantStoneInfo.GetPathList;
					getPathDesc = configDataEnchantStoneInfo.GetPathDesc;
				}
				break;
			}
			}
			this.m_nameText.text = UIUtility.GetGoodsName(goodsType, goodsId);
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(goodsType, goodsId));
			this.m_iconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(goodsType, goodsId));
			this.m_descText.text = UIUtility.GetGoodsDesc(goodsType, goodsId);
			this.CreatePathItemList(getPathList, getPathDesc);
		}

		// Token: 0x0600CE0A RID: 52746 RVA: 0x0038B4F8 File Offset: 0x003896F8
		private void CreatePathItemList(List<GetPathData> getPathList, string getPathDesc)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreatePathItemListList`1String_hotfix != null)
			{
				this.m_CreatePathItemListList`1String_hotfix.call(new object[]
				{
					this,
					getPathList,
					getPathDesc
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObjectUtility.DestroyChildren(this.m_contentObj);
			if (getPathList == null || getPathList.Count == 0)
			{
				this.m_tips.gameObject.SetActive(true);
				this.m_tipsText.text = getPathDesc;
				return;
			}
			this.m_tips.gameObject.SetActive(false);
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			foreach (GetPathData getPathData in getPathList)
			{
				if (getPathData.PathType == GetPathType.GetPathType_HeroDungeon)
				{
					ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = configDataLoader.GetConfigDataHeroDungeonLevelInfo(getPathData.ID);
					if (configDataHeroDungeonLevelInfo == null)
					{
						continue;
					}
					ConfigDataHeroInformationInfo configDataHeroInformationInfo = configDataLoader.GetConfigDataHeroInformationInfo(configDataHeroDungeonLevelInfo.m_chapterId);
					if (configDataHeroInformationInfo == null || !configDataHeroInformationInfo.IsDungeonLevelsUnLock)
					{
						continue;
					}
				}
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.m_itemPrefab);
				GetPathItemUIController getPathItemUIController = GameObjectUtility.AddControllerToGameObject<GetPathItemUIController>(gameObject);
				getPathItemUIController.EventOnGotoButtonClick += this.OnGetPathItemGotoButtonClick;
				getPathItemUIController.SetGetPath(getPathData);
				gameObject.transform.SetParent(this.m_contentObj.transform, false);
			}
		}

		// Token: 0x0600CE0B RID: 52747 RVA: 0x0038B6AC File Offset: 0x003898AC
		private void OnReturnImgButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnImgButtonClick_hotfix != null)
			{
				this.m_OnReturnImgButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Close();
		}

		// Token: 0x0600CE0C RID: 52748 RVA: 0x0038B714 File Offset: 0x00389914
		private void OnGetPathItemGotoButtonClick(GetPathData getPathInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetPathItemGotoButtonClickGetPathData_hotfix != null)
			{
				this.m_OnGetPathItemGotoButtonClickGetPathData_hotfix.call(new object[]
				{
					this,
					getPathInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnGotoButtonClick != null)
			{
				this.EventOnGotoButtonClick(getPathInfo);
			}
		}

		// Token: 0x14000277 RID: 631
		// (add) Token: 0x0600CE0D RID: 52749 RVA: 0x0038B79C File Offset: 0x0038999C
		// (remove) Token: 0x0600CE0E RID: 52750 RVA: 0x0038B838 File Offset: 0x00389A38
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000278 RID: 632
		// (add) Token: 0x0600CE0F RID: 52751 RVA: 0x0038B8D4 File Offset: 0x00389AD4
		// (remove) Token: 0x0600CE10 RID: 52752 RVA: 0x0038B970 File Offset: 0x00389B70
		public event Action<GetPathData> EventOnGotoButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnGotoButtonClickAction`1_hotfix != null)
				{
					this.m_add_EventOnGotoButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GetPathData> action = this.EventOnGotoButtonClick;
				Action<GetPathData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GetPathData>>(ref this.EventOnGotoButtonClick, (Action<GetPathData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnGotoButtonClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnGotoButtonClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GetPathData> action = this.EventOnGotoButtonClick;
				Action<GetPathData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GetPathData>>(ref this.EventOnGotoButtonClick, (Action<GetPathData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x0600CE11 RID: 52753 RVA: 0x0038BA0C File Offset: 0x00389C0C
		// (set) Token: 0x0600CE12 RID: 52754 RVA: 0x0038BA2C File Offset: 0x00389C2C
		[DoNotToLua]
		public new GetPathUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GetPathUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CE13 RID: 52755 RVA: 0x0038BA38 File Offset: 0x00389C38
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600CE14 RID: 52756 RVA: 0x0038BA44 File Offset: 0x00389C44
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600CE15 RID: 52757 RVA: 0x0038BA4C File Offset: 0x00389C4C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600CE16 RID: 52758 RVA: 0x0038BA54 File Offset: 0x00389C54
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600CE17 RID: 52759 RVA: 0x0038BA68 File Offset: 0x00389C68
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600CE18 RID: 52760 RVA: 0x0038BA70 File Offset: 0x00389C70
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600CE19 RID: 52761 RVA: 0x0038BA7C File Offset: 0x00389C7C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600CE1A RID: 52762 RVA: 0x0038BA88 File Offset: 0x00389C88
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600CE1B RID: 52763 RVA: 0x0038BA94 File Offset: 0x00389C94
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600CE1C RID: 52764 RVA: 0x0038BAA0 File Offset: 0x00389CA0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600CE1D RID: 52765 RVA: 0x0038BAAC File Offset: 0x00389CAC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600CE1E RID: 52766 RVA: 0x0038BAB8 File Offset: 0x00389CB8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600CE1F RID: 52767 RVA: 0x0038BAC4 File Offset: 0x00389CC4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600CE20 RID: 52768 RVA: 0x0038BAD0 File Offset: 0x00389CD0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600CE21 RID: 52769 RVA: 0x0038BADC File Offset: 0x00389CDC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600CE22 RID: 52770 RVA: 0x0038BAE4 File Offset: 0x00389CE4
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x0600CE23 RID: 52771 RVA: 0x0038BB04 File Offset: 0x00389D04
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600CE24 RID: 52772 RVA: 0x0038BB10 File Offset: 0x00389D10
		private void __callDele_EventOnGotoButtonClick(GetPathData obj)
		{
			Action<GetPathData> eventOnGotoButtonClick = this.EventOnGotoButtonClick;
			if (eventOnGotoButtonClick != null)
			{
				eventOnGotoButtonClick(obj);
			}
		}

		// Token: 0x0600CE25 RID: 52773 RVA: 0x0038BB34 File Offset: 0x00389D34
		private void __clearDele_EventOnGotoButtonClick(GetPathData obj)
		{
			this.EventOnGotoButtonClick = null;
		}

		// Token: 0x0600CE27 RID: 52775 RVA: 0x0038BB58 File Offset: 0x00389D58
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
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_Close_hotfix = (luaObj.RawGet("Close") as LuaFunction);
					this.m_UpdateViewInGetPathPanelGoodsTypeInt32_hotfix = (luaObj.RawGet("UpdateViewInGetPathPanel") as LuaFunction);
					this.m_CreatePathItemListList`1String_hotfix = (luaObj.RawGet("CreatePathItemList") as LuaFunction);
					this.m_OnReturnImgButtonClick_hotfix = (luaObj.RawGet("OnReturnImgButtonClick") as LuaFunction);
					this.m_OnGetPathItemGotoButtonClickGetPathData_hotfix = (luaObj.RawGet("OnGetPathItemGotoButtonClick") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnGotoButtonClickAction`1_hotfix = (luaObj.RawGet("add_EventOnGotoButtonClick") as LuaFunction);
					this.m_remove_EventOnGotoButtonClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnGotoButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CE28 RID: 52776 RVA: 0x0038BD20 File Offset: 0x00389F20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GetPathUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040080FE RID: 33022
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_commonUIStateController;

		// Token: 0x040080FF RID: 33023
		[AutoBind("./Panel/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04008100 RID: 33024
		[AutoBind("./Panel/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x04008101 RID: 33025
		[AutoBind("./Panel/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_descText;

		// Token: 0x04008102 RID: 33026
		[AutoBind("./ReturnImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnImgButton;

		// Token: 0x04008103 RID: 33027
		[AutoBind("./Panel/PathItemScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_contentObj;

		// Token: 0x04008104 RID: 33028
		[AutoBind("./Panel/Tips", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_tips;

		// Token: 0x04008105 RID: 33029
		[AutoBind("./Panel/Tips/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_tipsText;

		// Token: 0x04008106 RID: 33030
		[AutoBind("./Prefab/GetPathItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemPrefab;

		// Token: 0x04008107 RID: 33031
		[DoNotToLua]
		private GetPathUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008108 RID: 33032
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008109 RID: 33033
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400810A RID: 33034
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400810B RID: 33035
		private LuaFunction m_Open_hotfix;

		// Token: 0x0400810C RID: 33036
		private LuaFunction m_Close_hotfix;

		// Token: 0x0400810D RID: 33037
		private LuaFunction m_UpdateViewInGetPathPanelGoodsTypeInt32_hotfix;

		// Token: 0x0400810E RID: 33038
		private LuaFunction m_CreatePathItemListList;

		// Token: 0x0400810F RID: 33039
		private LuaFunction m_OnReturnImgButtonClick_hotfix;

		// Token: 0x04008110 RID: 33040
		private LuaFunction m_OnGetPathItemGotoButtonClickGetPathData_hotfix;

		// Token: 0x04008111 RID: 33041
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x04008112 RID: 33042
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x04008113 RID: 33043
		private LuaFunction m_add_EventOnGotoButtonClickAction;

		// Token: 0x04008114 RID: 33044
		private LuaFunction m_remove_EventOnGotoButtonClickAction;

		// Token: 0x02000BBA RID: 3002
		public new class LuaExportHelper
		{
			// Token: 0x0600CE29 RID: 52777 RVA: 0x0038BD88 File Offset: 0x00389F88
			public LuaExportHelper(GetPathUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CE2A RID: 52778 RVA: 0x0038BD98 File Offset: 0x00389F98
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600CE2B RID: 52779 RVA: 0x0038BDA8 File Offset: 0x00389FA8
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600CE2C RID: 52780 RVA: 0x0038BDB8 File Offset: 0x00389FB8
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600CE2D RID: 52781 RVA: 0x0038BDC8 File Offset: 0x00389FC8
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600CE2E RID: 52782 RVA: 0x0038BDE0 File Offset: 0x00389FE0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600CE2F RID: 52783 RVA: 0x0038BDF0 File Offset: 0x00389FF0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600CE30 RID: 52784 RVA: 0x0038BE00 File Offset: 0x0038A000
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600CE31 RID: 52785 RVA: 0x0038BE10 File Offset: 0x0038A010
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600CE32 RID: 52786 RVA: 0x0038BE20 File Offset: 0x0038A020
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600CE33 RID: 52787 RVA: 0x0038BE30 File Offset: 0x0038A030
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600CE34 RID: 52788 RVA: 0x0038BE40 File Offset: 0x0038A040
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600CE35 RID: 52789 RVA: 0x0038BE50 File Offset: 0x0038A050
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600CE36 RID: 52790 RVA: 0x0038BE60 File Offset: 0x0038A060
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600CE37 RID: 52791 RVA: 0x0038BE70 File Offset: 0x0038A070
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600CE38 RID: 52792 RVA: 0x0038BE80 File Offset: 0x0038A080
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600CE39 RID: 52793 RVA: 0x0038BE90 File Offset: 0x0038A090
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x0600CE3A RID: 52794 RVA: 0x0038BEA0 File Offset: 0x0038A0A0
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x0600CE3B RID: 52795 RVA: 0x0038BEB0 File Offset: 0x0038A0B0
			public void __callDele_EventOnGotoButtonClick(GetPathData obj)
			{
				this.m_owner.__callDele_EventOnGotoButtonClick(obj);
			}

			// Token: 0x0600CE3C RID: 52796 RVA: 0x0038BEC0 File Offset: 0x0038A0C0
			public void __clearDele_EventOnGotoButtonClick(GetPathData obj)
			{
				this.m_owner.__clearDele_EventOnGotoButtonClick(obj);
			}

			// Token: 0x170028C1 RID: 10433
			// (get) Token: 0x0600CE3D RID: 52797 RVA: 0x0038BED0 File Offset: 0x0038A0D0
			// (set) Token: 0x0600CE3E RID: 52798 RVA: 0x0038BEE0 File Offset: 0x0038A0E0
			public CommonUIStateController m_commonUIStateController
			{
				get
				{
					return this.m_owner.m_commonUIStateController;
				}
				set
				{
					this.m_owner.m_commonUIStateController = value;
				}
			}

			// Token: 0x170028C2 RID: 10434
			// (get) Token: 0x0600CE3F RID: 52799 RVA: 0x0038BEF0 File Offset: 0x0038A0F0
			// (set) Token: 0x0600CE40 RID: 52800 RVA: 0x0038BF00 File Offset: 0x0038A100
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

			// Token: 0x170028C3 RID: 10435
			// (get) Token: 0x0600CE41 RID: 52801 RVA: 0x0038BF10 File Offset: 0x0038A110
			// (set) Token: 0x0600CE42 RID: 52802 RVA: 0x0038BF20 File Offset: 0x0038A120
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

			// Token: 0x170028C4 RID: 10436
			// (get) Token: 0x0600CE43 RID: 52803 RVA: 0x0038BF30 File Offset: 0x0038A130
			// (set) Token: 0x0600CE44 RID: 52804 RVA: 0x0038BF40 File Offset: 0x0038A140
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

			// Token: 0x170028C5 RID: 10437
			// (get) Token: 0x0600CE45 RID: 52805 RVA: 0x0038BF50 File Offset: 0x0038A150
			// (set) Token: 0x0600CE46 RID: 52806 RVA: 0x0038BF60 File Offset: 0x0038A160
			public Button m_returnImgButton
			{
				get
				{
					return this.m_owner.m_returnImgButton;
				}
				set
				{
					this.m_owner.m_returnImgButton = value;
				}
			}

			// Token: 0x170028C6 RID: 10438
			// (get) Token: 0x0600CE47 RID: 52807 RVA: 0x0038BF70 File Offset: 0x0038A170
			// (set) Token: 0x0600CE48 RID: 52808 RVA: 0x0038BF80 File Offset: 0x0038A180
			public GameObject m_contentObj
			{
				get
				{
					return this.m_owner.m_contentObj;
				}
				set
				{
					this.m_owner.m_contentObj = value;
				}
			}

			// Token: 0x170028C7 RID: 10439
			// (get) Token: 0x0600CE49 RID: 52809 RVA: 0x0038BF90 File Offset: 0x0038A190
			// (set) Token: 0x0600CE4A RID: 52810 RVA: 0x0038BFA0 File Offset: 0x0038A1A0
			public GameObject m_tips
			{
				get
				{
					return this.m_owner.m_tips;
				}
				set
				{
					this.m_owner.m_tips = value;
				}
			}

			// Token: 0x170028C8 RID: 10440
			// (get) Token: 0x0600CE4B RID: 52811 RVA: 0x0038BFB0 File Offset: 0x0038A1B0
			// (set) Token: 0x0600CE4C RID: 52812 RVA: 0x0038BFC0 File Offset: 0x0038A1C0
			public Text m_tipsText
			{
				get
				{
					return this.m_owner.m_tipsText;
				}
				set
				{
					this.m_owner.m_tipsText = value;
				}
			}

			// Token: 0x170028C9 RID: 10441
			// (get) Token: 0x0600CE4D RID: 52813 RVA: 0x0038BFD0 File Offset: 0x0038A1D0
			// (set) Token: 0x0600CE4E RID: 52814 RVA: 0x0038BFE0 File Offset: 0x0038A1E0
			public GameObject m_itemPrefab
			{
				get
				{
					return this.m_owner.m_itemPrefab;
				}
				set
				{
					this.m_owner.m_itemPrefab = value;
				}
			}

			// Token: 0x0600CE4F RID: 52815 RVA: 0x0038BFF0 File Offset: 0x0038A1F0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600CE50 RID: 52816 RVA: 0x0038C000 File Offset: 0x0038A200
			public void CreatePathItemList(List<GetPathData> getPathList, string getPathDesc)
			{
				this.m_owner.CreatePathItemList(getPathList, getPathDesc);
			}

			// Token: 0x0600CE51 RID: 52817 RVA: 0x0038C010 File Offset: 0x0038A210
			public void OnReturnImgButtonClick()
			{
				this.m_owner.OnReturnImgButtonClick();
			}

			// Token: 0x0600CE52 RID: 52818 RVA: 0x0038C020 File Offset: 0x0038A220
			public void OnGetPathItemGotoButtonClick(GetPathData getPathInfo)
			{
				this.m_owner.OnGetPathItemGotoButtonClick(getPathInfo);
			}

			// Token: 0x04008115 RID: 33045
			private GetPathUIController m_owner;
		}
	}
}
