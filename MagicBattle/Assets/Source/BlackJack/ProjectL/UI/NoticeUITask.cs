using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000E84 RID: 3716
	[HotFix]
	public class NoticeUITask : UITask
	{
		// Token: 0x06012180 RID: 74112 RVA: 0x004A9880 File Offset: 0x004A7A80
		public NoticeUITask(string name) : base(name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06012181 RID: 74113 RVA: 0x004A9988 File Offset: 0x004A7B88
		public static void StartUITask(string contentStr, string uiStateName, ChatChannel chatChannel, bool isVoiceMsg = false)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(NoticeUITask).Name, null);
			uiintentCustom.SetParam(NoticeUITask.ParamKey_NoticeInfo, contentStr);
			uiintentCustom.SetParam(NoticeUITask.ParamKey_NoticeStateName, uiStateName);
			uiintentCustom.SetParam(NoticeUITask.ParamKey_NoticeChatChannel, chatChannel);
			uiintentCustom.SetParam(NoticeUITask.ParamKey_NoticeIsVoice, isVoiceMsg);
			UIManager.Instance.StartUITask(uiintentCustom, false, false, null);
		}

		// Token: 0x06012182 RID: 74114 RVA: 0x004A99F4 File Offset: 0x004A7BF4
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x06012183 RID: 74115 RVA: 0x004A9A80 File Offset: 0x004A7C80
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			if (this.m_noticeUICtrl == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_noticeUICtrl = (this.m_uiCtrlArray[0] as NoticeUIController);
				}
				if (!(this.m_noticeUICtrl != null))
				{
					Debug.LogError("NoticeUIController is null");
					return;
				}
				this.m_noticeUICtrl.EventOnNoticeClick += this.NoticeUIController_OnNoticeClick;
			}
		}

		// Token: 0x06012184 RID: 74116 RVA: 0x004A9B50 File Offset: 0x004A7D50
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			if (this.m_noticeUICtrl != null)
			{
				this.m_noticeUICtrl.EventOnNoticeClick -= this.NoticeUIController_OnNoticeClick;
				this.m_noticeUICtrl = null;
			}
		}

		// Token: 0x06012185 RID: 74117 RVA: 0x004A9BE8 File Offset: 0x004A7DE8
		public override void EnableUIInput(bool isEnable, bool? isGlobalEnable = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EnableUIInputBooleanNullable`1_hotfix != null)
			{
				this.m_EnableUIInputBooleanNullable`1_hotfix.call(new object[]
				{
					this,
					isEnable,
					isGlobalEnable
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06012186 RID: 74118 RVA: 0x004A9C68 File Offset: 0x004A7E68
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_noticeUICtrl.ShowNotice(this.m_currentNoticeInfo, this.m_currentNoticeStateName, this.m_chatChannel, this.m_currentNoticeIsVoice);
		}

		// Token: 0x06012187 RID: 74119 RVA: 0x004A9CEC File Offset: 0x004A7EEC
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			return base.OnResume(intent);
		}

		// Token: 0x06012188 RID: 74120 RVA: 0x004A9D78 File Offset: 0x004A7F78
		public override bool OnNewIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNewIntentUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnNewIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.MainLayer == null)
			{
				return false;
			}
			this.InitDataFromUIIntent(intent);
			return base.OnNewIntent(intent);
		}

		// Token: 0x06012189 RID: 74121 RVA: 0x004A9E18 File Offset: 0x004A8018
		private void InitDataFromUIIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDataFromUIIntentUIIntent_hotfix != null)
			{
				this.m_InitDataFromUIIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_currentNoticeInfo = uiintentCustom.GetClassParam<string>(NoticeUITask.ParamKey_NoticeInfo);
				this.m_currentNoticeStateName = uiintentCustom.GetClassParam<string>(NoticeUITask.ParamKey_NoticeStateName);
				this.m_chatChannel = uiintentCustom.GetStructParam<ChatChannel>(NoticeUITask.ParamKey_NoticeChatChannel);
				this.m_currentNoticeIsVoice = uiintentCustom.GetStructParam<bool>(NoticeUITask.ParamKey_NoticeIsVoice);
			}
		}

		// Token: 0x0601218A RID: 74122 RVA: 0x004A9EDC File Offset: 0x004A80DC
		private void NoticeUIController_OnNoticeClick(NoticeText currentNoticeText)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NoticeUIController_OnNoticeClickNoticeText_hotfix != null)
			{
				this.m_NoticeUIController_OnNoticeClickNoticeText_hotfix.call(new object[]
				{
					this,
					currentNoticeText
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!NoticeUITask.m_isEnableClick)
			{
				return;
			}
			if (CommonUIController.Instance.IsAnyDisableInput() || CommonUIController.Instance.IsFading())
			{
				return;
			}
			ChatUITask.StartChatUITaskToEnterAppointChannel(currentNoticeText.channel, this.m_currIntent, string.Empty);
		}

		// Token: 0x0601218B RID: 74123 RVA: 0x004A9F90 File Offset: 0x004A8190
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
			if (this.m_noticeUICtrl == null)
			{
				return;
			}
			this.UpdatePositionState();
		}

		// Token: 0x0601218C RID: 74124 RVA: 0x004AA010 File Offset: 0x004A8210
		public void UpdatePositionState()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdatePositionState_hotfix != null)
			{
				this.m_UpdatePositionState_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_noticeUICtrl.gameObject.activeSelf)
			{
				UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(WorldUITask));
				UITaskBase uitaskBase2 = UIUtility.FindUITaskWithType(typeof(BattleUITask));
				string text = string.Empty;
				if (uitaskBase != null)
				{
					if (uitaskBase.State == Task.TaskState.Paused || uitaskBase.State == Task.TaskState.Stopped)
					{
						UITaskBase uitaskBase3 = UIUtility.FindUITaskWithType(typeof(RiftUITask));
						if (uitaskBase3 != null && uitaskBase3.State == Task.TaskState.Running)
						{
							text = "InRift";
						}
						else
						{
							text = "InOther";
						}
					}
					else
					{
						text = "InWorld";
					}
				}
				if (uitaskBase2 != null && uitaskBase2.State == Task.TaskState.Running)
				{
					text = "InBattle";
				}
				if (!string.IsNullOrEmpty(text))
				{
					this.m_noticeUICtrl.SetPositionState(text);
				}
			}
		}

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0601218D RID: 74125 RVA: 0x004AA138 File Offset: 0x004A8338
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0601218E RID: 74126 RVA: 0x004AA1AC File Offset: 0x004A83AC
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0601218F RID: 74127 RVA: 0x004AA220 File Offset: 0x004A8420
		// (set) Token: 0x06012190 RID: 74128 RVA: 0x004AA240 File Offset: 0x004A8440
		[DoNotToLua]
		public new NoticeUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new NoticeUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012191 RID: 74129 RVA: 0x004AA24C File Offset: 0x004A844C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06012192 RID: 74130 RVA: 0x004AA258 File Offset: 0x004A8458
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06012193 RID: 74131 RVA: 0x004AA260 File Offset: 0x004A8460
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06012194 RID: 74132 RVA: 0x004AA268 File Offset: 0x004A8468
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06012195 RID: 74133 RVA: 0x004AA274 File Offset: 0x004A8474
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06012196 RID: 74134 RVA: 0x004AA280 File Offset: 0x004A8480
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06012197 RID: 74135 RVA: 0x004AA28C File Offset: 0x004A848C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06012198 RID: 74136 RVA: 0x004AA294 File Offset: 0x004A8494
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06012199 RID: 74137 RVA: 0x004AA29C File Offset: 0x004A849C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0601219A RID: 74138 RVA: 0x004AA2A4 File Offset: 0x004A84A4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0601219B RID: 74139 RVA: 0x004AA2AC File Offset: 0x004A84AC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0601219C RID: 74140 RVA: 0x004AA2B4 File Offset: 0x004A84B4
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0601219D RID: 74141 RVA: 0x004AA2BC File Offset: 0x004A84BC
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0601219E RID: 74142 RVA: 0x004AA2C4 File Offset: 0x004A84C4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0601219F RID: 74143 RVA: 0x004AA2D0 File Offset: 0x004A84D0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060121A0 RID: 74144 RVA: 0x004AA2DC File Offset: 0x004A84DC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060121A1 RID: 74145 RVA: 0x004AA2E8 File Offset: 0x004A84E8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060121A2 RID: 74146 RVA: 0x004AA2F4 File Offset: 0x004A84F4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060121A3 RID: 74147 RVA: 0x004AA2FC File Offset: 0x004A84FC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060121A4 RID: 74148 RVA: 0x004AA304 File Offset: 0x004A8504
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060121A5 RID: 74149 RVA: 0x004AA30C File Offset: 0x004A850C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060121A6 RID: 74150 RVA: 0x004AA314 File Offset: 0x004A8514
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060121A7 RID: 74151 RVA: 0x004AA31C File Offset: 0x004A851C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060121A9 RID: 74153 RVA: 0x004AA354 File Offset: 0x004A8554
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_EnableUIInputBooleanNullable`1_hotfix = (luaObj.RawGet("EnableUIInput") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_OnNewIntentUIIntent_hotfix = (luaObj.RawGet("OnNewIntent") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_NoticeUIController_OnNoticeClickNoticeText_hotfix = (luaObj.RawGet("NoticeUIController_OnNoticeClick") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_UpdatePositionState_hotfix = (luaObj.RawGet("UpdatePositionState") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060121AA RID: 74154 RVA: 0x004AA564 File Offset: 0x004A8764
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NoticeUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A3A2 RID: 41890
		private string m_currentNoticeInfo = string.Empty;

		// Token: 0x0400A3A3 RID: 41891
		private string m_currentNoticeStateName = string.Empty;

		// Token: 0x0400A3A4 RID: 41892
		private ChatChannel m_chatChannel;

		// Token: 0x0400A3A5 RID: 41893
		private bool m_currentNoticeIsVoice;

		// Token: 0x0400A3A6 RID: 41894
		private NoticeUIController m_noticeUICtrl;

		// Token: 0x0400A3A7 RID: 41895
		public static readonly string ParamKey_NoticeInfo = "NoticeInfo";

		// Token: 0x0400A3A8 RID: 41896
		public static readonly string ParamKey_NoticeStateName = "NoticeStateName";

		// Token: 0x0400A3A9 RID: 41897
		public static readonly string ParamKey_NoticeChatChannel = "NoticeChatChannel";

		// Token: 0x0400A3AA RID: 41898
		public static readonly string ParamKey_NoticeIsVoice = "NoticeIsVoice";

		// Token: 0x0400A3AB RID: 41899
		public static bool m_isEnableClick = true;

		// Token: 0x0400A3AC RID: 41900
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "NoticeUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Notice_ABS/Prefab/NoticeUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400A3AD RID: 41901
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "NoticeUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.NoticeUIController"),
				m_ctrlName = "NoticeUIController"
			}
		};

		// Token: 0x0400A3AE RID: 41902
		[DoNotToLua]
		private NoticeUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400A3AF RID: 41903
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A3B0 RID: 41904
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A3B1 RID: 41905
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400A3B2 RID: 41906
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400A3B3 RID: 41907
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400A3B4 RID: 41908
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400A3B5 RID: 41909
		private LuaFunction m_EnableUIInputBooleanNullable;

		// Token: 0x0400A3B6 RID: 41910
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400A3B7 RID: 41911
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400A3B8 RID: 41912
		private LuaFunction m_OnNewIntentUIIntent_hotfix;

		// Token: 0x0400A3B9 RID: 41913
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400A3BA RID: 41914
		private LuaFunction m_NoticeUIController_OnNoticeClickNoticeText_hotfix;

		// Token: 0x0400A3BB RID: 41915
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400A3BC RID: 41916
		private LuaFunction m_UpdatePositionState_hotfix;

		// Token: 0x0400A3BD RID: 41917
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400A3BE RID: 41918
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E85 RID: 3717
		public new class LuaExportHelper
		{
			// Token: 0x060121AB RID: 74155 RVA: 0x004AA5CC File Offset: 0x004A87CC
			public LuaExportHelper(NoticeUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060121AC RID: 74156 RVA: 0x004AA5DC File Offset: 0x004A87DC
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060121AD RID: 74157 RVA: 0x004AA5EC File Offset: 0x004A87EC
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060121AE RID: 74158 RVA: 0x004AA5FC File Offset: 0x004A87FC
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060121AF RID: 74159 RVA: 0x004AA60C File Offset: 0x004A880C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060121B0 RID: 74160 RVA: 0x004AA61C File Offset: 0x004A881C
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060121B1 RID: 74161 RVA: 0x004AA62C File Offset: 0x004A882C
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060121B2 RID: 74162 RVA: 0x004AA63C File Offset: 0x004A883C
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060121B3 RID: 74163 RVA: 0x004AA64C File Offset: 0x004A884C
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060121B4 RID: 74164 RVA: 0x004AA65C File Offset: 0x004A885C
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060121B5 RID: 74165 RVA: 0x004AA66C File Offset: 0x004A886C
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060121B6 RID: 74166 RVA: 0x004AA67C File Offset: 0x004A887C
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060121B7 RID: 74167 RVA: 0x004AA68C File Offset: 0x004A888C
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060121B8 RID: 74168 RVA: 0x004AA69C File Offset: 0x004A889C
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060121B9 RID: 74169 RVA: 0x004AA6AC File Offset: 0x004A88AC
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060121BA RID: 74170 RVA: 0x004AA6BC File Offset: 0x004A88BC
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060121BB RID: 74171 RVA: 0x004AA6CC File Offset: 0x004A88CC
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060121BC RID: 74172 RVA: 0x004AA6DC File Offset: 0x004A88DC
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060121BD RID: 74173 RVA: 0x004AA6EC File Offset: 0x004A88EC
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060121BE RID: 74174 RVA: 0x004AA6FC File Offset: 0x004A88FC
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060121BF RID: 74175 RVA: 0x004AA70C File Offset: 0x004A890C
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060121C0 RID: 74176 RVA: 0x004AA71C File Offset: 0x004A891C
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060121C1 RID: 74177 RVA: 0x004AA72C File Offset: 0x004A892C
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060121C2 RID: 74178 RVA: 0x004AA73C File Offset: 0x004A893C
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x1700373E RID: 14142
			// (get) Token: 0x060121C3 RID: 74179 RVA: 0x004AA74C File Offset: 0x004A894C
			// (set) Token: 0x060121C4 RID: 74180 RVA: 0x004AA75C File Offset: 0x004A895C
			public string m_currentNoticeInfo
			{
				get
				{
					return this.m_owner.m_currentNoticeInfo;
				}
				set
				{
					this.m_owner.m_currentNoticeInfo = value;
				}
			}

			// Token: 0x1700373F RID: 14143
			// (get) Token: 0x060121C5 RID: 74181 RVA: 0x004AA76C File Offset: 0x004A896C
			// (set) Token: 0x060121C6 RID: 74182 RVA: 0x004AA77C File Offset: 0x004A897C
			public string m_currentNoticeStateName
			{
				get
				{
					return this.m_owner.m_currentNoticeStateName;
				}
				set
				{
					this.m_owner.m_currentNoticeStateName = value;
				}
			}

			// Token: 0x17003740 RID: 14144
			// (get) Token: 0x060121C7 RID: 74183 RVA: 0x004AA78C File Offset: 0x004A898C
			// (set) Token: 0x060121C8 RID: 74184 RVA: 0x004AA79C File Offset: 0x004A899C
			public ChatChannel m_chatChannel
			{
				get
				{
					return this.m_owner.m_chatChannel;
				}
				set
				{
					this.m_owner.m_chatChannel = value;
				}
			}

			// Token: 0x17003741 RID: 14145
			// (get) Token: 0x060121C9 RID: 74185 RVA: 0x004AA7AC File Offset: 0x004A89AC
			// (set) Token: 0x060121CA RID: 74186 RVA: 0x004AA7BC File Offset: 0x004A89BC
			public bool m_currentNoticeIsVoice
			{
				get
				{
					return this.m_owner.m_currentNoticeIsVoice;
				}
				set
				{
					this.m_owner.m_currentNoticeIsVoice = value;
				}
			}

			// Token: 0x17003742 RID: 14146
			// (get) Token: 0x060121CB RID: 74187 RVA: 0x004AA7CC File Offset: 0x004A89CC
			// (set) Token: 0x060121CC RID: 74188 RVA: 0x004AA7DC File Offset: 0x004A89DC
			public NoticeUIController m_noticeUICtrl
			{
				get
				{
					return this.m_owner.m_noticeUICtrl;
				}
				set
				{
					this.m_owner.m_noticeUICtrl = value;
				}
			}

			// Token: 0x17003743 RID: 14147
			// (get) Token: 0x060121CD RID: 74189 RVA: 0x004AA7EC File Offset: 0x004A89EC
			// (set) Token: 0x060121CE RID: 74190 RVA: 0x004AA7FC File Offset: 0x004A89FC
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x17003744 RID: 14148
			// (get) Token: 0x060121CF RID: 74191 RVA: 0x004AA80C File Offset: 0x004A8A0C
			// (set) Token: 0x060121D0 RID: 74192 RVA: 0x004AA81C File Offset: 0x004A8A1C
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x17003745 RID: 14149
			// (get) Token: 0x060121D1 RID: 74193 RVA: 0x004AA82C File Offset: 0x004A8A2C
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003746 RID: 14150
			// (get) Token: 0x060121D2 RID: 74194 RVA: 0x004AA83C File Offset: 0x004A8A3C
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060121D3 RID: 74195 RVA: 0x004AA84C File Offset: 0x004A8A4C
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x060121D4 RID: 74196 RVA: 0x004AA85C File Offset: 0x004A8A5C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060121D5 RID: 74197 RVA: 0x004AA86C File Offset: 0x004A8A6C
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060121D6 RID: 74198 RVA: 0x004AA87C File Offset: 0x004A8A7C
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060121D7 RID: 74199 RVA: 0x004AA88C File Offset: 0x004A8A8C
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x060121D8 RID: 74200 RVA: 0x004AA89C File Offset: 0x004A8A9C
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x060121D9 RID: 74201 RVA: 0x004AA8AC File Offset: 0x004A8AAC
			public void NoticeUIController_OnNoticeClick(NoticeText currentNoticeText)
			{
				this.m_owner.NoticeUIController_OnNoticeClick(currentNoticeText);
			}

			// Token: 0x060121DA RID: 74202 RVA: 0x004AA8BC File Offset: 0x004A8ABC
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0400A3BF RID: 41919
			private NoticeUITask m_owner;
		}
	}
}
