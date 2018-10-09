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
	// Token: 0x02000A32 RID: 2610
	[HotFix]
	public class ArenaRankingRewardListItemUIController : UIControllerBase
	{
		// Token: 0x0600A02D RID: 41005 RVA: 0x002D2FD4 File Offset: 0x002D11D4
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

		// Token: 0x0600A02E RID: 41006 RVA: 0x002D303C File Offset: 0x002D123C
		public void SetArenaRankRewardInfo(ConfigDataArenaRankRewardInfo rankRewardInfo, GameObject rewardGoodPrefab)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaRankRewardInfoConfigDataArenaRankRewardInfoGameObject_hotfix != null)
			{
				this.m_SetArenaRankRewardInfoConfigDataArenaRankRewardInfoGameObject_hotfix.call(new object[]
				{
					this,
					rankRewardInfo,
					rewardGoodPrefab
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = rankRewardInfo.Name;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataMailInfo configDataMailInfo = configDataLoader.GetConfigDataMailInfo(rankRewardInfo.RankRewardMailTemplateId);
			GameObjectUtility.DestroyChildren(this.m_rewardGroupGameObject);
			if (configDataMailInfo != null && configDataMailInfo.Attachments.Count > 0)
			{
				RewardGoodsUIController.CreateRewardGoodsList(configDataMailInfo.Attachments, this.m_rewardGroupGameObject.transform, rewardGoodPrefab, null, true, 0, true);
				this.m_noRewardGameObject.SetActive(false);
			}
			else
			{
				this.m_noRewardGameObject.SetActive(true);
			}
		}

		// Token: 0x0600A02F RID: 41007 RVA: 0x002D3144 File Offset: 0x002D1344
		public void SetRealTimePVPRankBonusInfo(ConfigDataRealTimePVPRankingRewardInfo rankRewardInfo, GameObject rewardGoodPrefab)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRealTimePVPRankBonusInfoConfigDataRealTimePVPRankingRewardInfoGameObject_hotfix != null)
			{
				this.m_SetRealTimePVPRankBonusInfoConfigDataRealTimePVPRankingRewardInfoGameObject_hotfix.call(new object[]
				{
					this,
					rankRewardInfo,
					rewardGoodPrefab
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = rankRewardInfo.Name;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataMailInfo configDataMailInfo = configDataLoader.GetConfigDataMailInfo(rankRewardInfo.RankingRewardMailTemplateId);
			GameObjectUtility.DestroyChildren(this.m_rewardGroupGameObject);
			if (configDataMailInfo != null && configDataMailInfo.Attachments.Count > 0)
			{
				RewardGoodsUIController.CreateRewardGoodsList(configDataMailInfo.Attachments, this.m_rewardGroupGameObject.transform, rewardGoodPrefab, null, true, 0, true);
				this.m_noRewardGameObject.SetActive(false);
			}
			else
			{
				this.m_noRewardGameObject.SetActive(true);
			}
		}

		// Token: 0x0600A030 RID: 41008 RVA: 0x002D324C File Offset: 0x002D144C
		public void SetIndex(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIndexInt32_hotfix != null)
			{
				this.m_SetIndexInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_backgroundGameObject.SetActive(index % 2 != 0);
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x0600A031 RID: 41009 RVA: 0x002D32D0 File Offset: 0x002D14D0
		// (set) Token: 0x0600A032 RID: 41010 RVA: 0x002D32F0 File Offset: 0x002D14F0
		[DoNotToLua]
		public new ArenaRankingRewardListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaRankingRewardListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x002D32FC File Offset: 0x002D14FC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A034 RID: 41012 RVA: 0x002D3308 File Offset: 0x002D1508
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x002D3310 File Offset: 0x002D1510
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x002D3318 File Offset: 0x002D1518
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A037 RID: 41015 RVA: 0x002D332C File Offset: 0x002D152C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A038 RID: 41016 RVA: 0x002D3334 File Offset: 0x002D1534
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x002D3340 File Offset: 0x002D1540
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x002D334C File Offset: 0x002D154C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x002D3358 File Offset: 0x002D1558
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x002D3364 File Offset: 0x002D1564
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x002D3370 File Offset: 0x002D1570
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A03E RID: 41022 RVA: 0x002D337C File Offset: 0x002D157C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A03F RID: 41023 RVA: 0x002D3388 File Offset: 0x002D1588
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A040 RID: 41024 RVA: 0x002D3394 File Offset: 0x002D1594
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A041 RID: 41025 RVA: 0x002D33A0 File Offset: 0x002D15A0
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A042 RID: 41026 RVA: 0x002D33A8 File Offset: 0x002D15A8
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
					this.m_SetArenaRankRewardInfoConfigDataArenaRankRewardInfoGameObject_hotfix = (luaObj.RawGet("SetArenaRankRewardInfo") as LuaFunction);
					this.m_SetRealTimePVPRankBonusInfoConfigDataRealTimePVPRankingRewardInfoGameObject_hotfix = (luaObj.RawGet("SetRealTimePVPRankBonusInfo") as LuaFunction);
					this.m_SetIndexInt32_hotfix = (luaObj.RawGet("SetIndex") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A043 RID: 41027 RVA: 0x002D34C0 File Offset: 0x002D16C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaRankingRewardListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006BC3 RID: 27587
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04006BC4 RID: 27588
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGroupGameObject;

		// Token: 0x04006BC5 RID: 27589
		[AutoBind("./BGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_backgroundGameObject;

		// Token: 0x04006BC6 RID: 27590
		[AutoBind("./NoRewardText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_noRewardGameObject;

		// Token: 0x04006BC7 RID: 27591
		[DoNotToLua]
		private ArenaRankingRewardListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006BC8 RID: 27592
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006BC9 RID: 27593
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006BCA RID: 27594
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006BCB RID: 27595
		private LuaFunction m_SetArenaRankRewardInfoConfigDataArenaRankRewardInfoGameObject_hotfix;

		// Token: 0x04006BCC RID: 27596
		private LuaFunction m_SetRealTimePVPRankBonusInfoConfigDataRealTimePVPRankingRewardInfoGameObject_hotfix;

		// Token: 0x04006BCD RID: 27597
		private LuaFunction m_SetIndexInt32_hotfix;

		// Token: 0x02000A33 RID: 2611
		public new class LuaExportHelper
		{
			// Token: 0x0600A044 RID: 41028 RVA: 0x002D3528 File Offset: 0x002D1728
			public LuaExportHelper(ArenaRankingRewardListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A045 RID: 41029 RVA: 0x002D3538 File Offset: 0x002D1738
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A046 RID: 41030 RVA: 0x002D3548 File Offset: 0x002D1748
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A047 RID: 41031 RVA: 0x002D3558 File Offset: 0x002D1758
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A048 RID: 41032 RVA: 0x002D3568 File Offset: 0x002D1768
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A049 RID: 41033 RVA: 0x002D3580 File Offset: 0x002D1780
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A04A RID: 41034 RVA: 0x002D3590 File Offset: 0x002D1790
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A04B RID: 41035 RVA: 0x002D35A0 File Offset: 0x002D17A0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A04C RID: 41036 RVA: 0x002D35B0 File Offset: 0x002D17B0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A04D RID: 41037 RVA: 0x002D35C0 File Offset: 0x002D17C0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A04E RID: 41038 RVA: 0x002D35D0 File Offset: 0x002D17D0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A04F RID: 41039 RVA: 0x002D35E0 File Offset: 0x002D17E0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A050 RID: 41040 RVA: 0x002D35F0 File Offset: 0x002D17F0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A051 RID: 41041 RVA: 0x002D3600 File Offset: 0x002D1800
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A052 RID: 41042 RVA: 0x002D3610 File Offset: 0x002D1810
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A053 RID: 41043 RVA: 0x002D3620 File Offset: 0x002D1820
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170020B3 RID: 8371
			// (get) Token: 0x0600A054 RID: 41044 RVA: 0x002D3630 File Offset: 0x002D1830
			// (set) Token: 0x0600A055 RID: 41045 RVA: 0x002D3640 File Offset: 0x002D1840
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

			// Token: 0x170020B4 RID: 8372
			// (get) Token: 0x0600A056 RID: 41046 RVA: 0x002D3650 File Offset: 0x002D1850
			// (set) Token: 0x0600A057 RID: 41047 RVA: 0x002D3660 File Offset: 0x002D1860
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

			// Token: 0x170020B5 RID: 8373
			// (get) Token: 0x0600A058 RID: 41048 RVA: 0x002D3670 File Offset: 0x002D1870
			// (set) Token: 0x0600A059 RID: 41049 RVA: 0x002D3680 File Offset: 0x002D1880
			public GameObject m_backgroundGameObject
			{
				get
				{
					return this.m_owner.m_backgroundGameObject;
				}
				set
				{
					this.m_owner.m_backgroundGameObject = value;
				}
			}

			// Token: 0x170020B6 RID: 8374
			// (get) Token: 0x0600A05A RID: 41050 RVA: 0x002D3690 File Offset: 0x002D1890
			// (set) Token: 0x0600A05B RID: 41051 RVA: 0x002D36A0 File Offset: 0x002D18A0
			public GameObject m_noRewardGameObject
			{
				get
				{
					return this.m_owner.m_noRewardGameObject;
				}
				set
				{
					this.m_owner.m_noRewardGameObject = value;
				}
			}

			// Token: 0x0600A05C RID: 41052 RVA: 0x002D36B0 File Offset: 0x002D18B0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04006BCE RID: 27598
			private ArenaRankingRewardListItemUIController m_owner;
		}
	}
}
