using System;
using System.Collections.Generic;
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
	// Token: 0x02000EA6 RID: 3750
	[HotFix]
	public class RaffleRewardItemUIController : UIControllerBase
	{
		// Token: 0x06012509 RID: 75017 RVA: 0x004B47CC File Offset: 0x004B29CC
		public void UpdateRaffleRewardItemInfo(int level, List<RaffleItem> itemList, HashSet<int> drawedRaffleIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRaffleRewardItemInfoInt32List`1HashSet`1_hotfix != null)
			{
				this.m_UpdateRaffleRewardItemInfoInt32List`1HashSet`1_hotfix.call(new object[]
				{
					this,
					level,
					itemList,
					drawedRaffleIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.LevelText.text = this.GetLvNameByLevel(level);
			this.UIStateCtrl.SetToUIState(this.GetLvStateNameByLevel(level), false, true);
			List<Goods> list = new List<Goods>();
			foreach (RaffleItem raffleItem in itemList)
			{
				Goods item = new Goods
				{
					Count = raffleItem.ItemCount,
					GoodsType = raffleItem.GoodsType,
					Id = raffleItem.ItemID
				};
				list.Add(item);
			}
			GameObject assetInContainer = base.GetAssetInContainer<GameObject>("RewardGoods");
			this.m_goodsCtrlList.Clear();
			GameObjectUtility.DestroyChildren(this.GoodsItemRoot.gameObject);
			RewardGoodsUIController.CreateRewardGoodsList(list, this.GoodsItemRoot, assetInContainer, this.m_goodsCtrlList, true, 0, true);
			this.UpdateRewardItemGotState(itemList, drawedRaffleIds);
		}

		// Token: 0x0601250A RID: 75018 RVA: 0x004B494C File Offset: 0x004B2B4C
		public void UpdateRewardItemGotState(List<RaffleItem> itemList, HashSet<int> drawedRaffleIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateRewardItemGotStateList`1HashSet`1_hotfix != null)
			{
				this.m_UpdateRewardItemGotStateList`1HashSet`1_hotfix.call(new object[]
				{
					this,
					itemList,
					drawedRaffleIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_goodsCtrlList == null || this.m_goodsCtrlList.Count != itemList.Count)
			{
				global::Debug.LogError("UpdateRewardItemGotState error:  m_goodsCtrlList.Count != itemList.Count");
				return;
			}
			for (int i = 0; i < itemList.Count; i++)
			{
				if (drawedRaffleIds.Contains(itemList[i].RaffleID))
				{
					this.m_goodsCtrlList[i].ShowHaveGot(true);
				}
			}
		}

		// Token: 0x0601250B RID: 75019 RVA: 0x004B4A38 File Offset: 0x004B2C38
		public string GetLvNameByLevel(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLvNameByLevelInt32_hotfix != null)
			{
				return (string)this.m_GetLvNameByLevelInt32_hotfix.call(new object[]
				{
					this,
					level
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StringTableId levelStrByLevel = this.GetLevelStrByLevel(level);
			return (GameManager.Instance.ConfigDataLoader as IConfigDataLoader).UtilityGetStringByStringTable(levelStrByLevel);
		}

		// Token: 0x0601250C RID: 75020 RVA: 0x004B4AD4 File Offset: 0x004B2CD4
		protected StringTableId GetLevelStrByLevel(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLevelStrByLevelInt32_hotfix != null)
			{
				return (StringTableId)this.m_GetLevelStrByLevelInt32_hotfix.call(new object[]
				{
					this,
					level
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (level)
			{
			case 0:
				return StringTableId.StringTableId_Raffle_Level0;
			case 1:
				return StringTableId.StringTableId_Raffle_Level1;
			case 2:
				return StringTableId.StringTableId_Raffle_Level2;
			case 3:
				return StringTableId.StringTableId_Raffle_Level3;
			case 4:
				return StringTableId.StringTableId_Raffle_Level4;
			case 5:
				return StringTableId.StringTableId_Raffle_Level5;
			case 6:
				return StringTableId.StringTableId_Raffle_Level6;
			case 7:
				return StringTableId.StringTableId_Raffle_Level6;
			case 8:
				return StringTableId.StringTableId_Raffle_Level6;
			case 9:
				return StringTableId.StringTableId_Raffle_Level6;
			case 10:
				return StringTableId.StringTableId_Raffle_Level6;
			default:
				return StringTableId.StringTableId_Raffle_Level6;
			}
		}

		// Token: 0x0601250D RID: 75021 RVA: 0x004B4BD0 File Offset: 0x004B2DD0
		protected string GetLvStateNameByLevel(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLvStateNameByLevelInt32_hotfix != null)
			{
				return (string)this.m_GetLvStateNameByLevelInt32_hotfix.call(new object[]
				{
					this,
					level
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (level)
			{
			case 0:
				return "Special";
			case 1:
				return "First";
			case 2:
				return "Second";
			case 3:
				return "Third";
			default:
				return "Third";
			}
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0601250E RID: 75022 RVA: 0x004B4C84 File Offset: 0x004B2E84
		// (set) Token: 0x0601250F RID: 75023 RVA: 0x004B4CA4 File Offset: 0x004B2EA4
		[DoNotToLua]
		public new RaffleRewardItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RaffleRewardItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012510 RID: 75024 RVA: 0x004B4CB0 File Offset: 0x004B2EB0
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012511 RID: 75025 RVA: 0x004B4CBC File Offset: 0x004B2EBC
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012512 RID: 75026 RVA: 0x004B4CC4 File Offset: 0x004B2EC4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012513 RID: 75027 RVA: 0x004B4CCC File Offset: 0x004B2ECC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012514 RID: 75028 RVA: 0x004B4CE0 File Offset: 0x004B2EE0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012515 RID: 75029 RVA: 0x004B4CE8 File Offset: 0x004B2EE8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012516 RID: 75030 RVA: 0x004B4CF4 File Offset: 0x004B2EF4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012517 RID: 75031 RVA: 0x004B4D00 File Offset: 0x004B2F00
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012518 RID: 75032 RVA: 0x004B4D0C File Offset: 0x004B2F0C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012519 RID: 75033 RVA: 0x004B4D18 File Offset: 0x004B2F18
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601251A RID: 75034 RVA: 0x004B4D24 File Offset: 0x004B2F24
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601251B RID: 75035 RVA: 0x004B4D30 File Offset: 0x004B2F30
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601251C RID: 75036 RVA: 0x004B4D3C File Offset: 0x004B2F3C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601251D RID: 75037 RVA: 0x004B4D48 File Offset: 0x004B2F48
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601251E RID: 75038 RVA: 0x004B4D54 File Offset: 0x004B2F54
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601251F RID: 75039 RVA: 0x004B4D5C File Offset: 0x004B2F5C
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
					this.m_UpdateRaffleRewardItemInfoInt32List`1HashSet`1_hotfix = (luaObj.RawGet("UpdateRaffleRewardItemInfo") as LuaFunction);
					this.m_UpdateRewardItemGotStateList`1HashSet`1_hotfix = (luaObj.RawGet("UpdateRewardItemGotState") as LuaFunction);
					this.m_GetLvNameByLevelInt32_hotfix = (luaObj.RawGet("GetLvNameByLevel") as LuaFunction);
					this.m_GetLevelStrByLevelInt32_hotfix = (luaObj.RawGet("GetLevelStrByLevel") as LuaFunction);
					this.m_GetLvStateNameByLevelInt32_hotfix = (luaObj.RawGet("GetLvStateNameByLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012520 RID: 75040 RVA: 0x004B4E8C File Offset: 0x004B308C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RaffleRewardItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A4FB RID: 42235
		protected List<RewardGoodsUIController> m_goodsCtrlList = new List<RewardGoodsUIController>();

		// Token: 0x0400A4FC RID: 42236
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		public CommonUIStateController UIStateCtrl;

		// Token: 0x0400A4FD RID: 42237
		[AutoBind("./Detail/TitleGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		public Text LevelText;

		// Token: 0x0400A4FE RID: 42238
		[AutoBind("./Detail/ItemContent", AutoBindAttribute.InitState.NotInit, false)]
		public Transform GoodsItemRoot;

		// Token: 0x0400A4FF RID: 42239
		[DoNotToLua]
		private RaffleRewardItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A500 RID: 42240
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A501 RID: 42241
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A502 RID: 42242
		private LuaFunction m_UpdateRaffleRewardItemInfoInt32List`1HashSet;

		// Token: 0x0400A503 RID: 42243
		private LuaFunction m_UpdateRewardItemGotStateList`1HashSet;

		// Token: 0x0400A504 RID: 42244
		private LuaFunction m_GetLvNameByLevelInt32_hotfix;

		// Token: 0x0400A505 RID: 42245
		private LuaFunction m_GetLevelStrByLevelInt32_hotfix;

		// Token: 0x0400A506 RID: 42246
		private LuaFunction m_GetLvStateNameByLevelInt32_hotfix;

		// Token: 0x02000EA7 RID: 3751
		public new class LuaExportHelper
		{
			// Token: 0x06012521 RID: 75041 RVA: 0x004B4EF4 File Offset: 0x004B30F4
			public LuaExportHelper(RaffleRewardItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012522 RID: 75042 RVA: 0x004B4F04 File Offset: 0x004B3104
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012523 RID: 75043 RVA: 0x004B4F14 File Offset: 0x004B3114
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012524 RID: 75044 RVA: 0x004B4F24 File Offset: 0x004B3124
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012525 RID: 75045 RVA: 0x004B4F34 File Offset: 0x004B3134
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012526 RID: 75046 RVA: 0x004B4F4C File Offset: 0x004B314C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012527 RID: 75047 RVA: 0x004B4F5C File Offset: 0x004B315C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012528 RID: 75048 RVA: 0x004B4F6C File Offset: 0x004B316C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012529 RID: 75049 RVA: 0x004B4F7C File Offset: 0x004B317C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601252A RID: 75050 RVA: 0x004B4F8C File Offset: 0x004B318C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601252B RID: 75051 RVA: 0x004B4F9C File Offset: 0x004B319C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601252C RID: 75052 RVA: 0x004B4FAC File Offset: 0x004B31AC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601252D RID: 75053 RVA: 0x004B4FBC File Offset: 0x004B31BC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601252E RID: 75054 RVA: 0x004B4FCC File Offset: 0x004B31CC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601252F RID: 75055 RVA: 0x004B4FDC File Offset: 0x004B31DC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012530 RID: 75056 RVA: 0x004B4FEC File Offset: 0x004B31EC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170037AF RID: 14255
			// (get) Token: 0x06012531 RID: 75057 RVA: 0x004B4FFC File Offset: 0x004B31FC
			// (set) Token: 0x06012532 RID: 75058 RVA: 0x004B500C File Offset: 0x004B320C
			public List<RewardGoodsUIController> m_goodsCtrlList
			{
				get
				{
					return this.m_owner.m_goodsCtrlList;
				}
				set
				{
					this.m_owner.m_goodsCtrlList = value;
				}
			}

			// Token: 0x06012533 RID: 75059 RVA: 0x004B501C File Offset: 0x004B321C
			public StringTableId GetLevelStrByLevel(int level)
			{
				return this.m_owner.GetLevelStrByLevel(level);
			}

			// Token: 0x06012534 RID: 75060 RVA: 0x004B502C File Offset: 0x004B322C
			public string GetLvStateNameByLevel(int level)
			{
				return this.m_owner.GetLvStateNameByLevel(level);
			}

			// Token: 0x0400A507 RID: 42247
			private RaffleRewardItemUIController m_owner;
		}
	}
}
