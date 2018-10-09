using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
	// Token: 0x020009E8 RID: 2536
	[HotFix]
	public class HeroShowUIController : UIControllerBase
	{
		// Token: 0x06009667 RID: 38503 RVA: 0x002B07C4 File Offset: 0x002AE9C4
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
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_returnButton.onClick.AddListener(new UnityAction(this.OnReturnClick));
			this.m_ssrToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.SwitchRankShowClick(this.m_ssrToggle.gameObject);
				}
			});
			this.m_srToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.SwitchRankShowClick(this.m_srToggle.gameObject);
				}
			});
			this.m_rToggle.onValueChanged.AddListener(delegate(bool isSelect)
			{
				if (isSelect)
				{
					this.SwitchRankShowClick(this.m_rToggle.gameObject);
				}
			});
			GameObject asset = this.m_resourceContainer.GetAsset<GameObject>("ShareButton");
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(asset);
			gameObject.transform.SetParent(this.m_shareButtonDummy.transform, false);
			this.m_weiBoButton = GameObjectUtility.FindComponentByName<Button>(gameObject.transform, "WeiBoButton");
			this.m_weChatButton = GameObjectUtility.FindComponentByName<Button>(gameObject.transform, "WeChatButton");
			CommonUIStateController commonUIStateController = gameObject.GetComponent<CommonUIStateController>();
			if (commonUIStateController != null)
			{
				commonUIStateController.SetToUIState("BgOff", false, true);
			}
			asset = this.m_resourceContainer.GetAsset<GameObject>("SharePhoto");
			gameObject = UnityEngine.Object.Instantiate<GameObject>(asset);
			gameObject.transform.SetParent(this.m_sharePhotoDummy.transform, false);
			commonUIStateController = gameObject.GetComponentInChildren<CommonUIStateController>();
			if (commonUIStateController != null)
			{
				commonUIStateController.SetToUIState("Normal", false, true);
			}
			this.m_nameText = GameObjectUtility.FindComponentByName<Text>(gameObject.transform, "NameText");
			this.m_lvText = GameObjectUtility.FindComponentByName<Text>(gameObject.transform, "LvValueText");
			this.m_serverNameText = GameObjectUtility.FindComponentByName<Text>(gameObject.transform, "ServerNameText");
			this.m_weiBoButton.onClick.AddListener(new UnityAction(this.OnWeiBoClick));
			this.m_weChatButton.onClick.AddListener(new UnityAction(this.OnWeChatClick));
			this.m_nameText.text = this.m_playerContext.GetPlayerName();
			this.m_lvText.text = this.m_playerContext.GetPlayerLevel().ToString();
			this.m_serverNameText.text = LoginUITask.GetCurrentSelectServerInfo().m_name;
			this.m_sharePhotoDummy.SetActive(false);
			this.m_herosRGameObject.SetActive(false);
			this.m_herosSRGameObject.SetActive(false);
			this.m_herosSSRGameObject.SetActive(false);
		}

		// Token: 0x06009668 RID: 38504 RVA: 0x002B0A74 File Offset: 0x002AEC74
		public void SetTask(ArchiveUITask task)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTaskArchiveUITask_hotfix != null)
			{
				this.m_SetTaskArchiveUITask_hotfix.call(new object[]
				{
					this,
					task
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_task = task;
		}

		// Token: 0x06009669 RID: 38505 RVA: 0x002B0AEC File Offset: 0x002AECEC
		public void SwitchShowRankHero(int rank)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SwitchShowRankHeroInt32_hotfix != null)
			{
				this.m_SwitchShowRankHeroInt32_hotfix.call(new object[]
				{
					this,
					rank
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (rank != 4)
			{
				if (rank != 3)
				{
					if (rank == 2)
					{
						this.m_rToggle.isOn = true;
					}
				}
				else
				{
					this.m_srToggle.isOn = true;
				}
			}
			else
			{
				this.m_ssrToggle.isOn = true;
			}
		}

		// Token: 0x0600966A RID: 38506 RVA: 0x002B0BAC File Offset: 0x002AEDAC
		public void LoadHeroTeam(int rank)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoadHeroTeamInt32_hotfix != null)
			{
				this.m_LoadHeroTeamInt32_hotfix.call(new object[]
				{
					this,
					rank
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_herosRGameObject.SetActive(false);
			this.m_herosSRGameObject.SetActive(false);
			this.m_herosSSRGameObject.SetActive(false);
			GameObject teamGameObject = null;
			if (rank != 4)
			{
				if (rank != 3)
				{
					if (rank == 2)
					{
						teamGameObject = this.m_herosRGameObject;
					}
				}
				else
				{
					teamGameObject = this.m_herosSRGameObject;
				}
			}
			else
			{
				teamGameObject = this.m_herosSSRGameObject;
			}
			if (teamGameObject == null)
			{
				return;
			}
			this.m_task.CustomLoadAsset(delegate
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				IEnumerable<KeyValuePair<int, ConfigDataHeroInfo>> allConfigDataHeroInfo = configDataLoader.GetAllConfigDataHeroInfo();
				for (int i = 0; i < teamGameObject.transform.childCount; i++)
				{
					Transform child = teamGameObject.transform.GetChild(i);
					ConfigDataHeroInfo configDataHeroInfo = null;
					foreach (KeyValuePair<int, ConfigDataHeroInfo> keyValuePair in allConfigDataHeroInfo)
					{
						if (keyValuePair.Value.Useable && keyValuePair.Value.Name_Eng == child.name)
						{
							configDataHeroInfo = keyValuePair.Value;
							break;
						}
					}
					if (configDataHeroInfo != null)
					{
						ConfigDataCharImageInfo charImageInfo = configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star);
						if (charImageInfo != null)
						{
							this.m_task.CollectAssetWrap(charImageInfo.HeroPainting);
						}
					}
				}
			}, delegate
			{
				this.m_heroShowComponent = new HeroShowComponent();
				this.m_heroShowComponent.Init(teamGameObject);
			});
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x002B0CD8 File Offset: 0x002AEED8
		public void DestroyHeroShowComponent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyHeroShowComponent_hotfix != null)
			{
				this.m_DestroyHeroShowComponent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroShowComponent != null)
			{
				this.m_heroShowComponent.Dispose();
				this.m_heroShowComponent = null;
			}
		}

		// Token: 0x0600966C RID: 38508 RVA: 0x002B0D58 File Offset: 0x002AEF58
		private void OnWeiBoClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWeiBoClick_hotfix != null)
			{
				this.m_OnWeiBoClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.WeiBoShare());
		}

		// Token: 0x0600966D RID: 38509 RVA: 0x002B0DC8 File Offset: 0x002AEFC8
		private void OnWeChatClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnWeChatClick_hotfix != null)
			{
				this.m_OnWeChatClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartCoroutine(this.WeChatShare());
		}

		// Token: 0x0600966E RID: 38510 RVA: 0x002B0E38 File Offset: 0x002AF038
		private void OnReturnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReturnClick_hotfix != null)
			{
				this.m_OnReturnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				this.m_task.m_heroArchiveUIController.gameObject.SetActive(true);
				this.m_task.m_heroShowUIController.gameObject.SetActive(false);
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600966F RID: 38511 RVA: 0x002B0EBC File Offset: 0x002AF0BC
		private void SwitchRankShowClick(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SwitchRankShowClickGameObject_hotfix != null)
			{
				this.m_SwitchRankShowClickGameObject_hotfix.call(new object[]
				{
					this,
					obj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyHeroShowComponent();
			if (this.m_ssrToggle.gameObject == obj)
			{
				this.LoadHeroTeam(4);
			}
			else if (this.m_srToggle.gameObject == obj)
			{
				this.LoadHeroTeam(3);
			}
			else if (this.m_rToggle.gameObject == obj)
			{
				this.LoadHeroTeam(2);
			}
		}

		// Token: 0x06009670 RID: 38512 RVA: 0x002B0F94 File Offset: 0x002AF194
		[DebuggerHidden]
		private IEnumerator WeiBoShare()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WeiBoShare_hotfix != null)
			{
				return (IEnumerator)this.m_WeiBoShare_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroShowUIController.<WeiBoShare>c__Iterator0 <WeiBoShare>c__Iterator = new HeroShowUIController.<WeiBoShare>c__Iterator0();
			<WeiBoShare>c__Iterator.$this = this;
			return <WeiBoShare>c__Iterator;
		}

		// Token: 0x06009671 RID: 38513 RVA: 0x002B1010 File Offset: 0x002AF210
		[DebuggerHidden]
		private IEnumerator WeChatShare()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WeChatShare_hotfix != null)
			{
				return (IEnumerator)this.m_WeChatShare_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroShowUIController.<WeChatShare>c__Iterator1 <WeChatShare>c__Iterator = new HeroShowUIController.<WeChatShare>c__Iterator1();
			<WeChatShare>c__Iterator.$this = this;
			return <WeChatShare>c__Iterator;
		}

		// Token: 0x06009672 RID: 38514 RVA: 0x002B108C File Offset: 0x002AF28C
		[DebuggerHidden]
		private IEnumerator CaptureFrame()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CaptureFrame_hotfix != null)
			{
				return (IEnumerator)this.m_CaptureFrame_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			HeroShowUIController.<CaptureFrame>c__Iterator2 <CaptureFrame>c__Iterator = new HeroShowUIController.<CaptureFrame>c__Iterator2();
			<CaptureFrame>c__Iterator.$this = this;
			return <CaptureFrame>c__Iterator;
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06009673 RID: 38515 RVA: 0x002B1108 File Offset: 0x002AF308
		// (set) Token: 0x06009674 RID: 38516 RVA: 0x002B1128 File Offset: 0x002AF328
		[DoNotToLua]
		public new HeroShowUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroShowUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009675 RID: 38517 RVA: 0x002B1134 File Offset: 0x002AF334
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009676 RID: 38518 RVA: 0x002B1140 File Offset: 0x002AF340
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009677 RID: 38519 RVA: 0x002B1148 File Offset: 0x002AF348
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009678 RID: 38520 RVA: 0x002B1150 File Offset: 0x002AF350
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009679 RID: 38521 RVA: 0x002B1164 File Offset: 0x002AF364
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600967A RID: 38522 RVA: 0x002B116C File Offset: 0x002AF36C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600967B RID: 38523 RVA: 0x002B1178 File Offset: 0x002AF378
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600967C RID: 38524 RVA: 0x002B1184 File Offset: 0x002AF384
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600967D RID: 38525 RVA: 0x002B1190 File Offset: 0x002AF390
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600967E RID: 38526 RVA: 0x002B119C File Offset: 0x002AF39C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600967F RID: 38527 RVA: 0x002B11A8 File Offset: 0x002AF3A8
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06009680 RID: 38528 RVA: 0x002B11B4 File Offset: 0x002AF3B4
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06009681 RID: 38529 RVA: 0x002B11C0 File Offset: 0x002AF3C0
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06009682 RID: 38530 RVA: 0x002B11CC File Offset: 0x002AF3CC
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06009683 RID: 38531 RVA: 0x002B11D8 File Offset: 0x002AF3D8
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06009688 RID: 38536 RVA: 0x002B126C File Offset: 0x002AF46C
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
					this.m_SetTaskArchiveUITask_hotfix = (luaObj.RawGet("SetTask") as LuaFunction);
					this.m_SwitchShowRankHeroInt32_hotfix = (luaObj.RawGet("SwitchShowRankHero") as LuaFunction);
					this.m_LoadHeroTeamInt32_hotfix = (luaObj.RawGet("LoadHeroTeam") as LuaFunction);
					this.m_DestroyHeroShowComponent_hotfix = (luaObj.RawGet("DestroyHeroShowComponent") as LuaFunction);
					this.m_OnWeiBoClick_hotfix = (luaObj.RawGet("OnWeiBoClick") as LuaFunction);
					this.m_OnWeChatClick_hotfix = (luaObj.RawGet("OnWeChatClick") as LuaFunction);
					this.m_OnReturnClick_hotfix = (luaObj.RawGet("OnReturnClick") as LuaFunction);
					this.m_SwitchRankShowClickGameObject_hotfix = (luaObj.RawGet("SwitchRankShowClick") as LuaFunction);
					this.m_WeiBoShare_hotfix = (luaObj.RawGet("WeiBoShare") as LuaFunction);
					this.m_WeChatShare_hotfix = (luaObj.RawGet("WeChatShare") as LuaFunction);
					this.m_CaptureFrame_hotfix = (luaObj.RawGet("CaptureFrame") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009689 RID: 38537 RVA: 0x002B144C File Offset: 0x002AF64C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroShowUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040067B2 RID: 26546
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private PrefabResourceContainer m_resourceContainer;

		// Token: 0x040067B3 RID: 26547
		[AutoBind("./Heros/R", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_herosRGameObject;

		// Token: 0x040067B4 RID: 26548
		[AutoBind("./Heros/SR", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_herosSRGameObject;

		// Token: 0x040067B5 RID: 26549
		[AutoBind("./Heros/SSR", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_herosSSRGameObject;

		// Token: 0x040067B6 RID: 26550
		[AutoBind("./ShareButtonDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_shareButtonDummy;

		// Token: 0x040067B7 RID: 26551
		[AutoBind("./SharePhotpDummy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_sharePhotoDummy;

		// Token: 0x040067B8 RID: 26552
		[AutoBind("./BackButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_returnButton;

		// Token: 0x040067B9 RID: 26553
		[AutoBind("./FrontPanel/ToggleGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_toggleGroup;

		// Token: 0x040067BA RID: 26554
		[AutoBind("./FrontPanel/ToggleGroup/SSRToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_ssrToggle;

		// Token: 0x040067BB RID: 26555
		[AutoBind("./FrontPanel/ToggleGroup/SRToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_srToggle;

		// Token: 0x040067BC RID: 26556
		[AutoBind("./FrontPanel/ToggleGroup/RToggle", AutoBindAttribute.InitState.NotInit, false)]
		private Toggle m_rToggle;

		// Token: 0x040067BD RID: 26557
		private Button m_weiBoButton;

		// Token: 0x040067BE RID: 26558
		private Button m_weChatButton;

		// Token: 0x040067BF RID: 26559
		private Text m_nameText;

		// Token: 0x040067C0 RID: 26560
		private Text m_lvText;

		// Token: 0x040067C1 RID: 26561
		private Text m_serverNameText;

		// Token: 0x040067C2 RID: 26562
		private HeroShowComponent m_heroShowComponent;

		// Token: 0x040067C3 RID: 26563
		private ArchiveUITask m_task;

		// Token: 0x040067C4 RID: 26564
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040067C5 RID: 26565
		[DoNotToLua]
		private HeroShowUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040067C6 RID: 26566
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040067C7 RID: 26567
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040067C8 RID: 26568
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040067C9 RID: 26569
		private LuaFunction m_SetTaskArchiveUITask_hotfix;

		// Token: 0x040067CA RID: 26570
		private LuaFunction m_SwitchShowRankHeroInt32_hotfix;

		// Token: 0x040067CB RID: 26571
		private LuaFunction m_LoadHeroTeamInt32_hotfix;

		// Token: 0x040067CC RID: 26572
		private LuaFunction m_DestroyHeroShowComponent_hotfix;

		// Token: 0x040067CD RID: 26573
		private LuaFunction m_OnWeiBoClick_hotfix;

		// Token: 0x040067CE RID: 26574
		private LuaFunction m_OnWeChatClick_hotfix;

		// Token: 0x040067CF RID: 26575
		private LuaFunction m_OnReturnClick_hotfix;

		// Token: 0x040067D0 RID: 26576
		private LuaFunction m_SwitchRankShowClickGameObject_hotfix;

		// Token: 0x040067D1 RID: 26577
		private LuaFunction m_WeiBoShare_hotfix;

		// Token: 0x040067D2 RID: 26578
		private LuaFunction m_WeChatShare_hotfix;

		// Token: 0x040067D3 RID: 26579
		private LuaFunction m_CaptureFrame_hotfix;

		// Token: 0x020009E9 RID: 2537
		public new class LuaExportHelper
		{
			// Token: 0x0600968A RID: 38538 RVA: 0x002B14B4 File Offset: 0x002AF6B4
			public LuaExportHelper(HeroShowUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600968B RID: 38539 RVA: 0x002B14C4 File Offset: 0x002AF6C4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600968C RID: 38540 RVA: 0x002B14D4 File Offset: 0x002AF6D4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600968D RID: 38541 RVA: 0x002B14E4 File Offset: 0x002AF6E4
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600968E RID: 38542 RVA: 0x002B14F4 File Offset: 0x002AF6F4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600968F RID: 38543 RVA: 0x002B150C File Offset: 0x002AF70C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06009690 RID: 38544 RVA: 0x002B151C File Offset: 0x002AF71C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06009691 RID: 38545 RVA: 0x002B152C File Offset: 0x002AF72C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06009692 RID: 38546 RVA: 0x002B153C File Offset: 0x002AF73C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06009693 RID: 38547 RVA: 0x002B154C File Offset: 0x002AF74C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06009694 RID: 38548 RVA: 0x002B155C File Offset: 0x002AF75C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06009695 RID: 38549 RVA: 0x002B156C File Offset: 0x002AF76C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06009696 RID: 38550 RVA: 0x002B157C File Offset: 0x002AF77C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06009697 RID: 38551 RVA: 0x002B158C File Offset: 0x002AF78C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06009698 RID: 38552 RVA: 0x002B159C File Offset: 0x002AF79C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06009699 RID: 38553 RVA: 0x002B15AC File Offset: 0x002AF7AC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17001F06 RID: 7942
			// (get) Token: 0x0600969A RID: 38554 RVA: 0x002B15BC File Offset: 0x002AF7BC
			// (set) Token: 0x0600969B RID: 38555 RVA: 0x002B15CC File Offset: 0x002AF7CC
			public PrefabResourceContainer m_resourceContainer
			{
				get
				{
					return this.m_owner.m_resourceContainer;
				}
				set
				{
					this.m_owner.m_resourceContainer = value;
				}
			}

			// Token: 0x17001F07 RID: 7943
			// (get) Token: 0x0600969C RID: 38556 RVA: 0x002B15DC File Offset: 0x002AF7DC
			// (set) Token: 0x0600969D RID: 38557 RVA: 0x002B15EC File Offset: 0x002AF7EC
			public GameObject m_herosRGameObject
			{
				get
				{
					return this.m_owner.m_herosRGameObject;
				}
				set
				{
					this.m_owner.m_herosRGameObject = value;
				}
			}

			// Token: 0x17001F08 RID: 7944
			// (get) Token: 0x0600969E RID: 38558 RVA: 0x002B15FC File Offset: 0x002AF7FC
			// (set) Token: 0x0600969F RID: 38559 RVA: 0x002B160C File Offset: 0x002AF80C
			public GameObject m_herosSRGameObject
			{
				get
				{
					return this.m_owner.m_herosSRGameObject;
				}
				set
				{
					this.m_owner.m_herosSRGameObject = value;
				}
			}

			// Token: 0x17001F09 RID: 7945
			// (get) Token: 0x060096A0 RID: 38560 RVA: 0x002B161C File Offset: 0x002AF81C
			// (set) Token: 0x060096A1 RID: 38561 RVA: 0x002B162C File Offset: 0x002AF82C
			public GameObject m_herosSSRGameObject
			{
				get
				{
					return this.m_owner.m_herosSSRGameObject;
				}
				set
				{
					this.m_owner.m_herosSSRGameObject = value;
				}
			}

			// Token: 0x17001F0A RID: 7946
			// (get) Token: 0x060096A2 RID: 38562 RVA: 0x002B163C File Offset: 0x002AF83C
			// (set) Token: 0x060096A3 RID: 38563 RVA: 0x002B164C File Offset: 0x002AF84C
			public GameObject m_shareButtonDummy
			{
				get
				{
					return this.m_owner.m_shareButtonDummy;
				}
				set
				{
					this.m_owner.m_shareButtonDummy = value;
				}
			}

			// Token: 0x17001F0B RID: 7947
			// (get) Token: 0x060096A4 RID: 38564 RVA: 0x002B165C File Offset: 0x002AF85C
			// (set) Token: 0x060096A5 RID: 38565 RVA: 0x002B166C File Offset: 0x002AF86C
			public GameObject m_sharePhotoDummy
			{
				get
				{
					return this.m_owner.m_sharePhotoDummy;
				}
				set
				{
					this.m_owner.m_sharePhotoDummy = value;
				}
			}

			// Token: 0x17001F0C RID: 7948
			// (get) Token: 0x060096A6 RID: 38566 RVA: 0x002B167C File Offset: 0x002AF87C
			// (set) Token: 0x060096A7 RID: 38567 RVA: 0x002B168C File Offset: 0x002AF88C
			public Button m_returnButton
			{
				get
				{
					return this.m_owner.m_returnButton;
				}
				set
				{
					this.m_owner.m_returnButton = value;
				}
			}

			// Token: 0x17001F0D RID: 7949
			// (get) Token: 0x060096A8 RID: 38568 RVA: 0x002B169C File Offset: 0x002AF89C
			// (set) Token: 0x060096A9 RID: 38569 RVA: 0x002B16AC File Offset: 0x002AF8AC
			public GameObject m_toggleGroup
			{
				get
				{
					return this.m_owner.m_toggleGroup;
				}
				set
				{
					this.m_owner.m_toggleGroup = value;
				}
			}

			// Token: 0x17001F0E RID: 7950
			// (get) Token: 0x060096AA RID: 38570 RVA: 0x002B16BC File Offset: 0x002AF8BC
			// (set) Token: 0x060096AB RID: 38571 RVA: 0x002B16CC File Offset: 0x002AF8CC
			public Toggle m_ssrToggle
			{
				get
				{
					return this.m_owner.m_ssrToggle;
				}
				set
				{
					this.m_owner.m_ssrToggle = value;
				}
			}

			// Token: 0x17001F0F RID: 7951
			// (get) Token: 0x060096AC RID: 38572 RVA: 0x002B16DC File Offset: 0x002AF8DC
			// (set) Token: 0x060096AD RID: 38573 RVA: 0x002B16EC File Offset: 0x002AF8EC
			public Toggle m_srToggle
			{
				get
				{
					return this.m_owner.m_srToggle;
				}
				set
				{
					this.m_owner.m_srToggle = value;
				}
			}

			// Token: 0x17001F10 RID: 7952
			// (get) Token: 0x060096AE RID: 38574 RVA: 0x002B16FC File Offset: 0x002AF8FC
			// (set) Token: 0x060096AF RID: 38575 RVA: 0x002B170C File Offset: 0x002AF90C
			public Toggle m_rToggle
			{
				get
				{
					return this.m_owner.m_rToggle;
				}
				set
				{
					this.m_owner.m_rToggle = value;
				}
			}

			// Token: 0x17001F11 RID: 7953
			// (get) Token: 0x060096B0 RID: 38576 RVA: 0x002B171C File Offset: 0x002AF91C
			// (set) Token: 0x060096B1 RID: 38577 RVA: 0x002B172C File Offset: 0x002AF92C
			public Button m_weiBoButton
			{
				get
				{
					return this.m_owner.m_weiBoButton;
				}
				set
				{
					this.m_owner.m_weiBoButton = value;
				}
			}

			// Token: 0x17001F12 RID: 7954
			// (get) Token: 0x060096B2 RID: 38578 RVA: 0x002B173C File Offset: 0x002AF93C
			// (set) Token: 0x060096B3 RID: 38579 RVA: 0x002B174C File Offset: 0x002AF94C
			public Button m_weChatButton
			{
				get
				{
					return this.m_owner.m_weChatButton;
				}
				set
				{
					this.m_owner.m_weChatButton = value;
				}
			}

			// Token: 0x17001F13 RID: 7955
			// (get) Token: 0x060096B4 RID: 38580 RVA: 0x002B175C File Offset: 0x002AF95C
			// (set) Token: 0x060096B5 RID: 38581 RVA: 0x002B176C File Offset: 0x002AF96C
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

			// Token: 0x17001F14 RID: 7956
			// (get) Token: 0x060096B6 RID: 38582 RVA: 0x002B177C File Offset: 0x002AF97C
			// (set) Token: 0x060096B7 RID: 38583 RVA: 0x002B178C File Offset: 0x002AF98C
			public Text m_lvText
			{
				get
				{
					return this.m_owner.m_lvText;
				}
				set
				{
					this.m_owner.m_lvText = value;
				}
			}

			// Token: 0x17001F15 RID: 7957
			// (get) Token: 0x060096B8 RID: 38584 RVA: 0x002B179C File Offset: 0x002AF99C
			// (set) Token: 0x060096B9 RID: 38585 RVA: 0x002B17AC File Offset: 0x002AF9AC
			public Text m_serverNameText
			{
				get
				{
					return this.m_owner.m_serverNameText;
				}
				set
				{
					this.m_owner.m_serverNameText = value;
				}
			}

			// Token: 0x17001F16 RID: 7958
			// (get) Token: 0x060096BA RID: 38586 RVA: 0x002B17BC File Offset: 0x002AF9BC
			// (set) Token: 0x060096BB RID: 38587 RVA: 0x002B17CC File Offset: 0x002AF9CC
			public HeroShowComponent m_heroShowComponent
			{
				get
				{
					return this.m_owner.m_heroShowComponent;
				}
				set
				{
					this.m_owner.m_heroShowComponent = value;
				}
			}

			// Token: 0x17001F17 RID: 7959
			// (get) Token: 0x060096BC RID: 38588 RVA: 0x002B17DC File Offset: 0x002AF9DC
			// (set) Token: 0x060096BD RID: 38589 RVA: 0x002B17EC File Offset: 0x002AF9EC
			public ArchiveUITask m_task
			{
				get
				{
					return this.m_owner.m_task;
				}
				set
				{
					this.m_owner.m_task = value;
				}
			}

			// Token: 0x17001F18 RID: 7960
			// (get) Token: 0x060096BE RID: 38590 RVA: 0x002B17FC File Offset: 0x002AF9FC
			// (set) Token: 0x060096BF RID: 38591 RVA: 0x002B180C File Offset: 0x002AFA0C
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

			// Token: 0x060096C0 RID: 38592 RVA: 0x002B181C File Offset: 0x002AFA1C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060096C1 RID: 38593 RVA: 0x002B182C File Offset: 0x002AFA2C
			public void OnWeiBoClick()
			{
				this.m_owner.OnWeiBoClick();
			}

			// Token: 0x060096C2 RID: 38594 RVA: 0x002B183C File Offset: 0x002AFA3C
			public void OnWeChatClick()
			{
				this.m_owner.OnWeChatClick();
			}

			// Token: 0x060096C3 RID: 38595 RVA: 0x002B184C File Offset: 0x002AFA4C
			public void OnReturnClick()
			{
				this.m_owner.OnReturnClick();
			}

			// Token: 0x060096C4 RID: 38596 RVA: 0x002B185C File Offset: 0x002AFA5C
			public void SwitchRankShowClick(GameObject obj)
			{
				this.m_owner.SwitchRankShowClick(obj);
			}

			// Token: 0x060096C5 RID: 38597 RVA: 0x002B186C File Offset: 0x002AFA6C
			public IEnumerator WeiBoShare()
			{
				return this.m_owner.WeiBoShare();
			}

			// Token: 0x060096C6 RID: 38598 RVA: 0x002B187C File Offset: 0x002AFA7C
			public IEnumerator WeChatShare()
			{
				return this.m_owner.WeChatShare();
			}

			// Token: 0x060096C7 RID: 38599 RVA: 0x002B188C File Offset: 0x002AFA8C
			public IEnumerator CaptureFrame()
			{
				return this.m_owner.CaptureFrame();
			}

			// Token: 0x040067D4 RID: 26580
			private HeroShowUIController m_owner;
		}
	}
}
