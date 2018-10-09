using System;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E05 RID: 3589
	[HotFix]
	public class HeroCharSkinItemUIController : UIControllerBase
	{
		// Token: 0x06011269 RID: 70249 RVA: 0x00472C14 File Offset: 0x00470E14
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
			base.gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnHeroJobCardItemClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x0601126A RID: 70250 RVA: 0x00472CA8 File Offset: 0x00470EA8
		public void SetHeroCharSkinItem(int heroSkinId, int index, ConfigDataHeroInfo heroInfo, int heroCurSkinId, string mode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroCharSkinItemInt32Int32ConfigDataHeroInfoInt32String_hotfix != null)
			{
				this.m_SetHeroCharSkinItemInt32Int32ConfigDataHeroInfoInt32String_hotfix.call(new object[]
				{
					this,
					heroSkinId,
					index,
					heroInfo,
					heroCurSkinId,
					mode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.HeroInfo = heroInfo;
			this.m_index = index;
			this.IsDefaultSkin = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.HeroSkinInfo = configDataLoader.GetConfigDataHeroSkinInfo(heroSkinId);
			if (this.HeroSkinInfo == null)
			{
				return;
			}
			this.CharSkinInfo = configDataLoader.GetConfigDataCharImageSkinResourceInfo(this.HeroSkinInfo.CharImageSkinResource_ID);
			if (!GameObjectUtility.HasChinese(this.CharSkinInfo.Image))
			{
				this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(this.CharSkinInfo.Image);
			}
			this.m_nameText.text = this.CharSkinInfo.Name;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			string stateName = null;
			if (projectLPlayerContext.HasOwn(GoodsType.GoodsType_HeroSkin, heroSkinId))
			{
				if (heroCurSkinId != heroSkinId)
				{
					if (mode != null)
					{
						if (!(mode == "ShowOneSkin"))
						{
							if (!(mode == "ShowSkinDetailMode"))
							{
								if (mode == "SkinBuyMode")
								{
									stateName = "Bought";
								}
							}
							else
							{
								stateName = "Got";
							}
						}
						else
						{
							stateName = "Normal";
						}
					}
				}
				else
				{
					stateName = "Wear";
				}
				this.m_timeGo.SetActive(false);
			}
			else
			{
				stateName = "Lock";
				ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = configDataLoader.GetConfigDataFixedStoreItemInfo(this.HeroSkinInfo.FixedStoreItemId);
				if (configDataFixedStoreItemInfo != null)
				{
					this.m_timeGo.SetActive(configDataFixedStoreItemInfo.ShowEndTime != DateTime.MaxValue.ToString());
				}
				else
				{
					this.m_timeGo.SetActive(false);
				}
			}
			this.m_stateCtrl.SetToUIState(stateName, false, true);
		}

		// Token: 0x0601126B RID: 70251 RVA: 0x00472F08 File Offset: 0x00471108
		public void CreateDefaultItem(ConfigDataHeroInfo heroInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateDefaultItemConfigDataHeroInfo_hotfix != null)
			{
				this.m_CreateDefaultItemConfigDataHeroInfo_hotfix.call(new object[]
				{
					this,
					heroInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.IsDefaultSkin = true;
			this.m_index = 0;
			this.HeroInfo = heroInfo;
			this.HeroSkinInfo = null;
			this.CharSkinInfo = null;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_nameText.text = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DefaultName);
			this.m_stateCtrl.SetToUIState("Default", false, true);
			this.m_timeGo.SetActive(false);
		}

		// Token: 0x0601126C RID: 70252 RVA: 0x00472FE0 File Offset: 0x004711E0
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
			this.m_selectImage.SetActive(isShow);
		}

		// Token: 0x0601126D RID: 70253 RVA: 0x0047305C File Offset: 0x0047125C
		private void OnHeroJobCardItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroJobCardItemClick_hotfix != null)
			{
				this.m_OnHeroJobCardItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnItemClick != null)
			{
				this.EventOnItemClick(this);
			}
		}

		// Token: 0x0601126E RID: 70254 RVA: 0x004730D4 File Offset: 0x004712D4
		public int GetIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_index;
		}

		// Token: 0x0601126F RID: 70255 RVA: 0x00473148 File Offset: 0x00471348
		public void SetLimitTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLimitTime_hotfix != null)
			{
				this.m_SetLimitTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsDefaultSkin)
			{
				this.m_timeGo.SetActive(false);
				return;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.HasOwn(GoodsType.GoodsType_HeroSkin, this.HeroSkinInfo.ID))
			{
				this.m_timeGo.SetActive(false);
				return;
			}
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = configDataLoader.GetConfigDataFixedStoreItemInfo(this.HeroSkinInfo.FixedStoreItemId);
			if (configDataFixedStoreItemInfo == null)
			{
				return;
			}
			DateTime dateTime = DateTime.Parse(configDataFixedStoreItemInfo.ShowEndTime);
			if (dateTime == DateTime.Parse(DateTime.MaxValue.ToString()))
			{
				this.m_timeGo.SetActive(false);
				return;
			}
			DateTime serverTime = projectLPlayerContext.GetServerTime();
			TimeSpan timeSpan = dateTime - serverTime;
			if (timeSpan.Days >= 1)
			{
				string arg = configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Time_Day);
				this.m_timeValueText.text = timeSpan.Days + arg;
			}
			else
			{
				this.m_timeValueText.text = UIUtility.TimeSpanToString2(timeSpan);
			}
			DateTime t = DateTime.Parse(configDataFixedStoreItemInfo.ShowStartTime);
			this.m_timeGo.SetActive(dateTime > serverTime && t < serverTime);
		}

		// Token: 0x140003AA RID: 938
		// (add) Token: 0x06011270 RID: 70256 RVA: 0x004732F0 File Offset: 0x004714F0
		// (remove) Token: 0x06011271 RID: 70257 RVA: 0x0047338C File Offset: 0x0047158C
		public event Action<HeroCharSkinItemUIController> EventOnItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroCharSkinItemUIController> action = this.EventOnItemClick;
				Action<HeroCharSkinItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroCharSkinItemUIController>>(ref this.EventOnItemClick, (Action<HeroCharSkinItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<HeroCharSkinItemUIController> action = this.EventOnItemClick;
				Action<HeroCharSkinItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<HeroCharSkinItemUIController>>(ref this.EventOnItemClick, (Action<HeroCharSkinItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170034EC RID: 13548
		// (get) Token: 0x06011272 RID: 70258 RVA: 0x00473428 File Offset: 0x00471628
		// (set) Token: 0x06011273 RID: 70259 RVA: 0x0047349C File Offset: 0x0047169C
		public bool IsDefaultSkin
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsDefaultSkin_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsDefaultSkin_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<IsDefaultSkin>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IsDefaultSkinBoolean_hotfix != null)
				{
					this.m_set_IsDefaultSkinBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<IsDefaultSkin>k__BackingField = value;
			}
		}

		// Token: 0x170034ED RID: 13549
		// (get) Token: 0x06011274 RID: 70260 RVA: 0x00473514 File Offset: 0x00471714
		// (set) Token: 0x06011275 RID: 70261 RVA: 0x00473588 File Offset: 0x00471788
		public ConfigDataHeroInfo HeroInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroInfo_hotfix != null)
				{
					return (ConfigDataHeroInfo)this.m_get_HeroInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<HeroInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HeroInfoConfigDataHeroInfo_hotfix != null)
				{
					this.m_set_HeroInfoConfigDataHeroInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<HeroInfo>k__BackingField = value;
			}
		}

		// Token: 0x170034EE RID: 13550
		// (get) Token: 0x06011276 RID: 70262 RVA: 0x00473600 File Offset: 0x00471800
		// (set) Token: 0x06011277 RID: 70263 RVA: 0x00473674 File Offset: 0x00471874
		public ConfigDataHeroSkinInfo HeroSkinInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroSkinInfo_hotfix != null)
				{
					return (ConfigDataHeroSkinInfo)this.m_get_HeroSkinInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<HeroSkinInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HeroSkinInfoConfigDataHeroSkinInfo_hotfix != null)
				{
					this.m_set_HeroSkinInfoConfigDataHeroSkinInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<HeroSkinInfo>k__BackingField = value;
			}
		}

		// Token: 0x170034EF RID: 13551
		// (get) Token: 0x06011278 RID: 70264 RVA: 0x004736EC File Offset: 0x004718EC
		// (set) Token: 0x06011279 RID: 70265 RVA: 0x00473760 File Offset: 0x00471960
		public ConfigDataCharImageSkinResourceInfo CharSkinInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_CharSkinInfo_hotfix != null)
				{
					return (ConfigDataCharImageSkinResourceInfo)this.m_get_CharSkinInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<CharSkinInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_CharSkinInfoConfigDataCharImageSkinResourceInfo_hotfix != null)
				{
					this.m_set_CharSkinInfoConfigDataCharImageSkinResourceInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<CharSkinInfo>k__BackingField = value;
			}
		}

		// Token: 0x170034F0 RID: 13552
		// (get) Token: 0x0601127A RID: 70266 RVA: 0x004737D8 File Offset: 0x004719D8
		// (set) Token: 0x0601127B RID: 70267 RVA: 0x004737F8 File Offset: 0x004719F8
		[DoNotToLua]
		public new HeroCharSkinItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroCharSkinItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601127C RID: 70268 RVA: 0x00473804 File Offset: 0x00471A04
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0601127D RID: 70269 RVA: 0x00473810 File Offset: 0x00471A10
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0601127E RID: 70270 RVA: 0x00473818 File Offset: 0x00471A18
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601127F RID: 70271 RVA: 0x00473820 File Offset: 0x00471A20
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011280 RID: 70272 RVA: 0x00473834 File Offset: 0x00471A34
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011281 RID: 70273 RVA: 0x0047383C File Offset: 0x00471A3C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011282 RID: 70274 RVA: 0x00473848 File Offset: 0x00471A48
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011283 RID: 70275 RVA: 0x00473854 File Offset: 0x00471A54
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011284 RID: 70276 RVA: 0x00473860 File Offset: 0x00471A60
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011285 RID: 70277 RVA: 0x0047386C File Offset: 0x00471A6C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011286 RID: 70278 RVA: 0x00473878 File Offset: 0x00471A78
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06011287 RID: 70279 RVA: 0x00473884 File Offset: 0x00471A84
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06011288 RID: 70280 RVA: 0x00473890 File Offset: 0x00471A90
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06011289 RID: 70281 RVA: 0x0047389C File Offset: 0x00471A9C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601128A RID: 70282 RVA: 0x004738A8 File Offset: 0x00471AA8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601128B RID: 70283 RVA: 0x004738B0 File Offset: 0x00471AB0
		private void __callDele_EventOnItemClick(HeroCharSkinItemUIController obj)
		{
			Action<HeroCharSkinItemUIController> eventOnItemClick = this.EventOnItemClick;
			if (eventOnItemClick != null)
			{
				eventOnItemClick(obj);
			}
		}

		// Token: 0x0601128C RID: 70284 RVA: 0x004738D4 File Offset: 0x00471AD4
		private void __clearDele_EventOnItemClick(HeroCharSkinItemUIController obj)
		{
			this.EventOnItemClick = null;
		}

		// Token: 0x0601128D RID: 70285 RVA: 0x004738E0 File Offset: 0x00471AE0
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
					this.m_SetHeroCharSkinItemInt32Int32ConfigDataHeroInfoInt32String_hotfix = (luaObj.RawGet("SetHeroCharSkinItem") as LuaFunction);
					this.m_CreateDefaultItemConfigDataHeroInfo_hotfix = (luaObj.RawGet("CreateDefaultItem") as LuaFunction);
					this.m_ShowSelectImageBoolean_hotfix = (luaObj.RawGet("ShowSelectImage") as LuaFunction);
					this.m_OnHeroJobCardItemClick_hotfix = (luaObj.RawGet("OnHeroJobCardItemClick") as LuaFunction);
					this.m_GetIndex_hotfix = (luaObj.RawGet("GetIndex") as LuaFunction);
					this.m_SetLimitTime_hotfix = (luaObj.RawGet("SetLimitTime") as LuaFunction);
					this.m_add_EventOnItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnItemClick") as LuaFunction);
					this.m_remove_EventOnItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnItemClick") as LuaFunction);
					this.m_get_IsDefaultSkin_hotfix = (luaObj.RawGet("get_IsDefaultSkin") as LuaFunction);
					this.m_set_IsDefaultSkinBoolean_hotfix = (luaObj.RawGet("set_IsDefaultSkin") as LuaFunction);
					this.m_get_HeroInfo_hotfix = (luaObj.RawGet("get_HeroInfo") as LuaFunction);
					this.m_set_HeroInfoConfigDataHeroInfo_hotfix = (luaObj.RawGet("set_HeroInfo") as LuaFunction);
					this.m_get_HeroSkinInfo_hotfix = (luaObj.RawGet("get_HeroSkinInfo") as LuaFunction);
					this.m_set_HeroSkinInfoConfigDataHeroSkinInfo_hotfix = (luaObj.RawGet("set_HeroSkinInfo") as LuaFunction);
					this.m_get_CharSkinInfo_hotfix = (luaObj.RawGet("get_CharSkinInfo") as LuaFunction);
					this.m_set_CharSkinInfoConfigDataCharImageSkinResourceInfo_hotfix = (luaObj.RawGet("set_CharSkinInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601128E RID: 70286 RVA: 0x00473B3C File Offset: 0x00471D3C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroCharSkinItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009D99 RID: 40345
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x04009D9A RID: 40346
		[AutoBind("./SelectImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectImage;

		// Token: 0x04009D9B RID: 40347
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x04009D9C RID: 40348
		[AutoBind("./SkinNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04009D9D RID: 40349
		[AutoBind("./LimitTime", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_timeGo;

		// Token: 0x04009D9E RID: 40350
		[AutoBind("./LimitTime/TimeValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_timeValueText;

		// Token: 0x04009D9F RID: 40351
		[AutoBind("./LimitTime", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_timeStateCtrl;

		// Token: 0x04009DA0 RID: 40352
		private int m_index;

		// Token: 0x04009DA5 RID: 40357
		[DoNotToLua]
		private HeroCharSkinItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009DA6 RID: 40358
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009DA7 RID: 40359
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009DA8 RID: 40360
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009DA9 RID: 40361
		private LuaFunction m_SetHeroCharSkinItemInt32Int32ConfigDataHeroInfoInt32String_hotfix;

		// Token: 0x04009DAA RID: 40362
		private LuaFunction m_CreateDefaultItemConfigDataHeroInfo_hotfix;

		// Token: 0x04009DAB RID: 40363
		private LuaFunction m_ShowSelectImageBoolean_hotfix;

		// Token: 0x04009DAC RID: 40364
		private LuaFunction m_OnHeroJobCardItemClick_hotfix;

		// Token: 0x04009DAD RID: 40365
		private LuaFunction m_GetIndex_hotfix;

		// Token: 0x04009DAE RID: 40366
		private LuaFunction m_SetLimitTime_hotfix;

		// Token: 0x04009DAF RID: 40367
		private LuaFunction m_add_EventOnItemClickAction;

		// Token: 0x04009DB0 RID: 40368
		private LuaFunction m_remove_EventOnItemClickAction;

		// Token: 0x04009DB1 RID: 40369
		private LuaFunction m_get_IsDefaultSkin_hotfix;

		// Token: 0x04009DB2 RID: 40370
		private LuaFunction m_set_IsDefaultSkinBoolean_hotfix;

		// Token: 0x04009DB3 RID: 40371
		private LuaFunction m_get_HeroInfo_hotfix;

		// Token: 0x04009DB4 RID: 40372
		private LuaFunction m_set_HeroInfoConfigDataHeroInfo_hotfix;

		// Token: 0x04009DB5 RID: 40373
		private LuaFunction m_get_HeroSkinInfo_hotfix;

		// Token: 0x04009DB6 RID: 40374
		private LuaFunction m_set_HeroSkinInfoConfigDataHeroSkinInfo_hotfix;

		// Token: 0x04009DB7 RID: 40375
		private LuaFunction m_get_CharSkinInfo_hotfix;

		// Token: 0x04009DB8 RID: 40376
		private LuaFunction m_set_CharSkinInfoConfigDataCharImageSkinResourceInfo_hotfix;

		// Token: 0x02000E06 RID: 3590
		public new class LuaExportHelper
		{
			// Token: 0x0601128F RID: 70287 RVA: 0x00473BA4 File Offset: 0x00471DA4
			public LuaExportHelper(HeroCharSkinItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011290 RID: 70288 RVA: 0x00473BB4 File Offset: 0x00471DB4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011291 RID: 70289 RVA: 0x00473BC4 File Offset: 0x00471DC4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011292 RID: 70290 RVA: 0x00473BD4 File Offset: 0x00471DD4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011293 RID: 70291 RVA: 0x00473BE4 File Offset: 0x00471DE4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011294 RID: 70292 RVA: 0x00473BFC File Offset: 0x00471DFC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011295 RID: 70293 RVA: 0x00473C0C File Offset: 0x00471E0C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011296 RID: 70294 RVA: 0x00473C1C File Offset: 0x00471E1C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011297 RID: 70295 RVA: 0x00473C2C File Offset: 0x00471E2C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011298 RID: 70296 RVA: 0x00473C3C File Offset: 0x00471E3C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06011299 RID: 70297 RVA: 0x00473C4C File Offset: 0x00471E4C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601129A RID: 70298 RVA: 0x00473C5C File Offset: 0x00471E5C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601129B RID: 70299 RVA: 0x00473C6C File Offset: 0x00471E6C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601129C RID: 70300 RVA: 0x00473C7C File Offset: 0x00471E7C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601129D RID: 70301 RVA: 0x00473C8C File Offset: 0x00471E8C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601129E RID: 70302 RVA: 0x00473C9C File Offset: 0x00471E9C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601129F RID: 70303 RVA: 0x00473CAC File Offset: 0x00471EAC
			public void __callDele_EventOnItemClick(HeroCharSkinItemUIController obj)
			{
				this.m_owner.__callDele_EventOnItemClick(obj);
			}

			// Token: 0x060112A0 RID: 70304 RVA: 0x00473CBC File Offset: 0x00471EBC
			public void __clearDele_EventOnItemClick(HeroCharSkinItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnItemClick(obj);
			}

			// Token: 0x170034F1 RID: 13553
			// (get) Token: 0x060112A1 RID: 70305 RVA: 0x00473CCC File Offset: 0x00471ECC
			// (set) Token: 0x060112A2 RID: 70306 RVA: 0x00473CDC File Offset: 0x00471EDC
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

			// Token: 0x170034F2 RID: 13554
			// (get) Token: 0x060112A3 RID: 70307 RVA: 0x00473CEC File Offset: 0x00471EEC
			// (set) Token: 0x060112A4 RID: 70308 RVA: 0x00473CFC File Offset: 0x00471EFC
			public GameObject m_selectImage
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

			// Token: 0x170034F3 RID: 13555
			// (get) Token: 0x060112A5 RID: 70309 RVA: 0x00473D0C File Offset: 0x00471F0C
			// (set) Token: 0x060112A6 RID: 70310 RVA: 0x00473D1C File Offset: 0x00471F1C
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

			// Token: 0x170034F4 RID: 13556
			// (get) Token: 0x060112A7 RID: 70311 RVA: 0x00473D2C File Offset: 0x00471F2C
			// (set) Token: 0x060112A8 RID: 70312 RVA: 0x00473D3C File Offset: 0x00471F3C
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

			// Token: 0x170034F5 RID: 13557
			// (get) Token: 0x060112A9 RID: 70313 RVA: 0x00473D4C File Offset: 0x00471F4C
			// (set) Token: 0x060112AA RID: 70314 RVA: 0x00473D5C File Offset: 0x00471F5C
			public GameObject m_timeGo
			{
				get
				{
					return this.m_owner.m_timeGo;
				}
				set
				{
					this.m_owner.m_timeGo = value;
				}
			}

			// Token: 0x170034F6 RID: 13558
			// (get) Token: 0x060112AB RID: 70315 RVA: 0x00473D6C File Offset: 0x00471F6C
			// (set) Token: 0x060112AC RID: 70316 RVA: 0x00473D7C File Offset: 0x00471F7C
			public Text m_timeValueText
			{
				get
				{
					return this.m_owner.m_timeValueText;
				}
				set
				{
					this.m_owner.m_timeValueText = value;
				}
			}

			// Token: 0x170034F7 RID: 13559
			// (get) Token: 0x060112AD RID: 70317 RVA: 0x00473D8C File Offset: 0x00471F8C
			// (set) Token: 0x060112AE RID: 70318 RVA: 0x00473D9C File Offset: 0x00471F9C
			public CommonUIStateController m_timeStateCtrl
			{
				get
				{
					return this.m_owner.m_timeStateCtrl;
				}
				set
				{
					this.m_owner.m_timeStateCtrl = value;
				}
			}

			// Token: 0x170034F8 RID: 13560
			// (get) Token: 0x060112AF RID: 70319 RVA: 0x00473DAC File Offset: 0x00471FAC
			// (set) Token: 0x060112B0 RID: 70320 RVA: 0x00473DBC File Offset: 0x00471FBC
			public int m_index
			{
				get
				{
					return this.m_owner.m_index;
				}
				set
				{
					this.m_owner.m_index = value;
				}
			}

			// Token: 0x170034F9 RID: 13561
			// (set) Token: 0x060112B1 RID: 70321 RVA: 0x00473DCC File Offset: 0x00471FCC
			public bool IsDefaultSkin
			{
				set
				{
					this.m_owner.IsDefaultSkin = value;
				}
			}

			// Token: 0x170034FA RID: 13562
			// (set) Token: 0x060112B2 RID: 70322 RVA: 0x00473DDC File Offset: 0x00471FDC
			public ConfigDataHeroInfo HeroInfo
			{
				set
				{
					this.m_owner.HeroInfo = value;
				}
			}

			// Token: 0x170034FB RID: 13563
			// (set) Token: 0x060112B3 RID: 70323 RVA: 0x00473DEC File Offset: 0x00471FEC
			public ConfigDataHeroSkinInfo HeroSkinInfo
			{
				set
				{
					this.m_owner.HeroSkinInfo = value;
				}
			}

			// Token: 0x170034FC RID: 13564
			// (set) Token: 0x060112B4 RID: 70324 RVA: 0x00473DFC File Offset: 0x00471FFC
			public ConfigDataCharImageSkinResourceInfo CharSkinInfo
			{
				set
				{
					this.m_owner.CharSkinInfo = value;
				}
			}

			// Token: 0x060112B5 RID: 70325 RVA: 0x00473E0C File Offset: 0x0047200C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060112B6 RID: 70326 RVA: 0x00473E1C File Offset: 0x0047201C
			public void OnHeroJobCardItemClick()
			{
				this.m_owner.OnHeroJobCardItemClick();
			}

			// Token: 0x04009DB9 RID: 40377
			private HeroCharSkinItemUIController m_owner;
		}
	}
}
