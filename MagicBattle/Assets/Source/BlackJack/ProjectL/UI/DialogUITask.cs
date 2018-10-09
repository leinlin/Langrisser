using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C37 RID: 3127
	[HotFix]
	public class DialogUITask : UITask
	{
		// Token: 0x0600DBA8 RID: 56232 RVA: 0x003B8990 File Offset: 0x003B6B90
		public DialogUITask(string name) : base(name)
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

		// Token: 0x0600DBA9 RID: 56233 RVA: 0x003B8A84 File Offset: 0x003B6C84
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

		// Token: 0x0600DBAA RID: 56234 RVA: 0x003B8B10 File Offset: 0x003B6D10
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

		// Token: 0x0600DBAB RID: 56235 RVA: 0x003B8B9C File Offset: 0x003B6D9C
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
			this.m_dialogInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_dialogInfo = uiintentCustom.GetClassParam<ConfigDataDialogInfo>("DialogInfo");
			}
		}

		// Token: 0x0600DBAC RID: 56236 RVA: 0x003B8C34 File Offset: 0x003B6E34
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			base.ClearAssetList();
			if (this.m_dialogInfo != null)
			{
				base.CollectAsset(this.m_dialogInfo.Background);
				base.CollectSpriteAsset(this.m_dialogInfo.BackgroundImage);
				if (this.m_dialogInfo.BeforeEnterEffectGroup1 != null && this.m_dialogInfo.BeforeEnterEffectGroup1.Count > 0 && this.m_dialogInfo.BeforeEnterEffectGroup1[0] != -1)
				{
					foreach (int key in this.m_dialogInfo.BeforeEnterEffectGroup1)
					{
						base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(key).Prefab);
					}
				}
				if (this.m_dialogInfo.BeforeEnterEffectGroup2 != null && this.m_dialogInfo.BeforeEnterEffectGroup2.Count > 0 && this.m_dialogInfo.BeforeEnterEffectGroup2[0] != -1)
				{
					foreach (int key2 in this.m_dialogInfo.BeforeEnterEffectGroup2)
					{
						base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(key2).Prefab);
					}
				}
				if (this.m_dialogInfo.BeforeEnterEffectGroup3 != null && this.m_dialogInfo.BeforeEnterEffectGroup3.Count > 0 && this.m_dialogInfo.BeforeEnterEffectGroup3[0] != -1)
				{
					foreach (int key3 in this.m_dialogInfo.BeforeEnterEffectGroup3)
					{
						base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(key3).Prefab);
					}
				}
				if (this.m_dialogInfo.BeforeTalkEffectGroup1 != null && this.m_dialogInfo.BeforeTalkEffectGroup1.Count > 0 && this.m_dialogInfo.BeforeTalkEffectGroup1[0] != -1)
				{
					foreach (int key4 in this.m_dialogInfo.BeforeTalkEffectGroup1)
					{
						base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(key4).Prefab);
					}
				}
				if (this.m_dialogInfo.BeforeTalkEffectGroup2 != null && this.m_dialogInfo.BeforeTalkEffectGroup2.Count > 0 && this.m_dialogInfo.BeforeTalkEffectGroup2[0] != -1)
				{
					foreach (int key5 in this.m_dialogInfo.BeforeTalkEffectGroup2)
					{
						base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(key5).Prefab);
					}
				}
				if (this.m_dialogInfo.BeforeTalkEffectGroup3 != null && this.m_dialogInfo.BeforeTalkEffectGroup3.Count > 0 && this.m_dialogInfo.BeforeTalkEffectGroup3[0] != -1)
				{
					foreach (int key6 in this.m_dialogInfo.BeforeTalkEffectGroup3)
					{
						base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(key6).Prefab);
					}
				}
				if (this.m_dialogInfo.AfterTalkEffectGroup1 != null && this.m_dialogInfo.AfterTalkEffectGroup1.Count > 0 && this.m_dialogInfo.AfterTalkEffectGroup1[0] != -1)
				{
					foreach (int key7 in this.m_dialogInfo.AfterTalkEffectGroup1)
					{
						base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(key7).Prefab);
					}
				}
				if (this.m_dialogInfo.AfterTalkEffectGroup2 != null && this.m_dialogInfo.AfterTalkEffectGroup2.Count > 0 && this.m_dialogInfo.AfterTalkEffectGroup2[0] != -1)
				{
					foreach (int key8 in this.m_dialogInfo.AfterTalkEffectGroup2)
					{
						base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(key8).Prefab);
					}
				}
				if (this.m_dialogInfo.AfterTalkEffectGroup3 != null && this.m_dialogInfo.AfterTalkEffectGroup3.Count > 0 && this.m_dialogInfo.AfterTalkEffectGroup3[0] != -1)
				{
					foreach (int key9 in this.m_dialogInfo.AfterTalkEffectGroup3)
					{
						base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(key9).Prefab);
					}
				}
				if (this.m_dialogInfo.BeforeEnterInsertEffect != 0 && this.m_dialogInfo.BeforeEnterInsertEffect != -1)
				{
					base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(this.m_dialogInfo.BeforeEnterInsertEffect).Prefab);
				}
				if (this.m_dialogInfo.BeforeTalkInsertEffect != 0 && this.m_dialogInfo.BeforeTalkInsertEffect != -1)
				{
					base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(this.m_dialogInfo.BeforeTalkInsertEffect).Prefab);
				}
				if (this.m_dialogInfo.AfterTalkInsertEffect != 0 && this.m_dialogInfo.AfterTalkInsertEffect != -1)
				{
					base.CollectAsset(configDataLoader.GetConfigDataPrefabStateInfo(this.m_dialogInfo.AfterTalkInsertEffect).Prefab);
				}
				if (this.m_dialogInfo.m_charImageInfo != null)
				{
					base.CollectAsset(this.m_dialogInfo.m_charImageInfo.Spine);
					base.CollectSpriteAsset(this.m_dialogInfo.m_charImageInfo.Image);
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600DBAD RID: 56237 RVA: 0x003B9350 File Offset: 0x003B7550
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
			this.InitDialogUIController();
		}

		// Token: 0x0600DBAE RID: 56238 RVA: 0x003B93BC File Offset: 0x003B75BC
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
			this.UninitDialogUIController();
		}

		// Token: 0x0600DBAF RID: 56239 RVA: 0x003B9428 File Offset: 0x003B7628
		protected override void OnMemoryWarning()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryWarning_hotfix != null)
			{
				this.m_OnMemoryWarning_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600DBB0 RID: 56240 RVA: 0x003B9490 File Offset: 0x003B7690
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
			if (this.m_dialogInfo != null)
			{
				this.m_dialogUIController.ShowDialog(this.m_dialogInfo, this.m_needBGChangeTween);
			}
		}

		// Token: 0x0600DBB1 RID: 56241 RVA: 0x003B9514 File Offset: 0x003B7714
		private void InitDialogUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDialogUIController_hotfix != null)
			{
				this.m_InitDialogUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_dialogUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_dialogUIController = (this.m_uiCtrlArray[0] as DialogUIController);
				}
				if (!(this.m_dialogUIController != null))
				{
					global::Debug.LogError("DialogUIController is null");
					return;
				}
				this.m_dialogUIController.EventOnSkip += this.DialogUIController_OnSkip;
				this.m_dialogUIController.EventOnNext += this.DialogUIController_OnNext;
				this.m_dialogUIController.EventOnClose += this.DialogUIController_OnClose;
			}
		}

		// Token: 0x0600DBB2 RID: 56242 RVA: 0x003B960C File Offset: 0x003B780C
		private void UninitDialogUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitDialogUIController_hotfix != null)
			{
				this.m_UninitDialogUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_dialogUIController != null)
			{
				this.m_dialogUIController.EventOnSkip -= this.DialogUIController_OnSkip;
				this.m_dialogUIController.EventOnNext -= this.DialogUIController_OnNext;
				this.m_dialogUIController.EventOnClose -= this.DialogUIController_OnClose;
				this.m_dialogUIController = null;
			}
		}

		// Token: 0x0600DBB3 RID: 56243 RVA: 0x003B96CC File Offset: 0x003B78CC
		private void DialogUIController_OnSkip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DialogUIController_OnSkip_hotfix != null)
			{
				this.m_DialogUIController_OnSkip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Dialog_SkipDialog, new Action<DialogBoxResult>(this.SkipDialogDialogBoxCallback), (StringTableId)0, (StringTableId)0);
		}

		// Token: 0x0600DBB4 RID: 56244 RVA: 0x003B974C File Offset: 0x003B794C
		private void SkipDialogDialogBoxCallback(DialogBoxResult r)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkipDialogDialogBoxCallbackDialogBoxResult_hotfix != null)
			{
				this.m_SkipDialogDialogBoxCallbackDialogBoxResult_hotfix.call(new object[]
				{
					this,
					r
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (r == DialogBoxResult.Ok)
			{
				this.m_isSkipClose = true;
				this.m_dialogUIController.CloseDialog();
				CommonUIController.Instance.FadeOut(0.5f, Color.black, null);
			}
		}

		// Token: 0x0600DBB5 RID: 56245 RVA: 0x003B97EC File Offset: 0x003B79EC
		private void DialogUIController_OnNext(bool needBGChangeTween)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DialogUIController_OnNextBoolean_hotfix != null)
			{
				this.m_DialogUIController_OnNextBoolean_hotfix.call(new object[]
				{
					this,
					needBGChangeTween
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_dialogInfo != null && this.m_dialogInfo.m_nextDialogInfo != null)
			{
				this.m_dialogInfo = this.m_dialogInfo.m_nextDialogInfo;
				this.m_needBGChangeTween = needBGChangeTween;
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else
			{
				this.m_isSkipClose = false;
				this.m_dialogUIController.CloseDialog();
				CommonUIController.Instance.FadeOut(0.5f, Color.black, null);
			}
		}

		// Token: 0x0600DBB6 RID: 56246 RVA: 0x003B98C8 File Offset: 0x003B7AC8
		private void DialogUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DialogUIController_OnClose_hotfix != null)
			{
				this.m_DialogUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Stop();
			base.ReturnPrevUITask();
			CommonUIController.Instance.FadeIn(0.5f, Color.black, null);
			if (this.EventOnClose != null)
			{
				this.EventOnClose(this.m_isSkipClose);
			}
		}

		// Token: 0x140002B8 RID: 696
		// (add) Token: 0x0600DBB7 RID: 56247 RVA: 0x003B9968 File Offset: 0x003B7B68
		// (remove) Token: 0x0600DBB8 RID: 56248 RVA: 0x003B9A04 File Offset: 0x003B7C04
		public event Action<bool> EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction`1_hotfix != null)
				{
					this.m_add_EventOnCloseAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnClose;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnClose, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction`1_hotfix != null)
				{
					this.m_remove_EventOnCloseAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnClose;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnClose, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x0600DBB9 RID: 56249 RVA: 0x003B9AA0 File Offset: 0x003B7CA0
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

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x0600DBBA RID: 56250 RVA: 0x003B9B14 File Offset: 0x003B7D14
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

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x0600DBBB RID: 56251 RVA: 0x003B9B88 File Offset: 0x003B7D88
		// (set) Token: 0x0600DBBC RID: 56252 RVA: 0x003B9BA8 File Offset: 0x003B7DA8
		[DoNotToLua]
		public new DialogUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new DialogUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600DBBD RID: 56253 RVA: 0x003B9BB4 File Offset: 0x003B7DB4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600DBBE RID: 56254 RVA: 0x003B9BC0 File Offset: 0x003B7DC0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600DBBF RID: 56255 RVA: 0x003B9BC8 File Offset: 0x003B7DC8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600DBC0 RID: 56256 RVA: 0x003B9BD0 File Offset: 0x003B7DD0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600DBC1 RID: 56257 RVA: 0x003B9BDC File Offset: 0x003B7DDC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600DBC2 RID: 56258 RVA: 0x003B9BE8 File Offset: 0x003B7DE8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600DBC3 RID: 56259 RVA: 0x003B9BF4 File Offset: 0x003B7DF4
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600DBC4 RID: 56260 RVA: 0x003B9BFC File Offset: 0x003B7DFC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600DBC5 RID: 56261 RVA: 0x003B9C04 File Offset: 0x003B7E04
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600DBC6 RID: 56262 RVA: 0x003B9C0C File Offset: 0x003B7E0C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600DBC7 RID: 56263 RVA: 0x003B9C14 File Offset: 0x003B7E14
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600DBC8 RID: 56264 RVA: 0x003B9C1C File Offset: 0x003B7E1C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600DBC9 RID: 56265 RVA: 0x003B9C24 File Offset: 0x003B7E24
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600DBCA RID: 56266 RVA: 0x003B9C2C File Offset: 0x003B7E2C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600DBCB RID: 56267 RVA: 0x003B9C38 File Offset: 0x003B7E38
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600DBCC RID: 56268 RVA: 0x003B9C44 File Offset: 0x003B7E44
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600DBCD RID: 56269 RVA: 0x003B9C50 File Offset: 0x003B7E50
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600DBCE RID: 56270 RVA: 0x003B9C5C File Offset: 0x003B7E5C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600DBCF RID: 56271 RVA: 0x003B9C64 File Offset: 0x003B7E64
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600DBD0 RID: 56272 RVA: 0x003B9C6C File Offset: 0x003B7E6C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600DBD1 RID: 56273 RVA: 0x003B9C74 File Offset: 0x003B7E74
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600DBD2 RID: 56274 RVA: 0x003B9C7C File Offset: 0x003B7E7C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600DBD3 RID: 56275 RVA: 0x003B9C84 File Offset: 0x003B7E84
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600DBD4 RID: 56276 RVA: 0x003B9C8C File Offset: 0x003B7E8C
		private void __callDele_EventOnClose(bool obj)
		{
			Action<bool> eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose(obj);
			}
		}

		// Token: 0x0600DBD5 RID: 56277 RVA: 0x003B9CB0 File Offset: 0x003B7EB0
		private void __clearDele_EventOnClose(bool obj)
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600DBD6 RID: 56278 RVA: 0x003B9CBC File Offset: 0x003B7EBC
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_InitDialogUIController_hotfix = (luaObj.RawGet("InitDialogUIController") as LuaFunction);
					this.m_UninitDialogUIController_hotfix = (luaObj.RawGet("UninitDialogUIController") as LuaFunction);
					this.m_DialogUIController_OnSkip_hotfix = (luaObj.RawGet("DialogUIController_OnSkip") as LuaFunction);
					this.m_SkipDialogDialogBoxCallbackDialogBoxResult_hotfix = (luaObj.RawGet("SkipDialogDialogBoxCallback") as LuaFunction);
					this.m_DialogUIController_OnNextBoolean_hotfix = (luaObj.RawGet("DialogUIController_OnNext") as LuaFunction);
					this.m_DialogUIController_OnClose_hotfix = (luaObj.RawGet("DialogUIController_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction`1_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction`1_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600DBD7 RID: 56279 RVA: 0x003B9F4C File Offset: 0x003B814C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DialogUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008680 RID: 34432
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "DialogUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Dialog_ABS/Prefab/DialogUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04008681 RID: 34433
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "DialogUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.DialogUIController"),
				m_ctrlName = "DialogUIController"
			}
		};

		// Token: 0x04008682 RID: 34434
		private DialogUIController m_dialogUIController;

		// Token: 0x04008683 RID: 34435
		private ConfigDataDialogInfo m_dialogInfo;

		// Token: 0x04008684 RID: 34436
		private bool m_needBGChangeTween;

		// Token: 0x04008685 RID: 34437
		private bool m_isSkipClose;

		// Token: 0x04008686 RID: 34438
		[DoNotToLua]
		private DialogUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04008687 RID: 34439
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008688 RID: 34440
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008689 RID: 34441
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400868A RID: 34442
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400868B RID: 34443
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400868C RID: 34444
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400868D RID: 34445
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400868E RID: 34446
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400868F RID: 34447
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04008690 RID: 34448
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04008691 RID: 34449
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008692 RID: 34450
		private LuaFunction m_InitDialogUIController_hotfix;

		// Token: 0x04008693 RID: 34451
		private LuaFunction m_UninitDialogUIController_hotfix;

		// Token: 0x04008694 RID: 34452
		private LuaFunction m_DialogUIController_OnSkip_hotfix;

		// Token: 0x04008695 RID: 34453
		private LuaFunction m_SkipDialogDialogBoxCallbackDialogBoxResult_hotfix;

		// Token: 0x04008696 RID: 34454
		private LuaFunction m_DialogUIController_OnNextBoolean_hotfix;

		// Token: 0x04008697 RID: 34455
		private LuaFunction m_DialogUIController_OnClose_hotfix;

		// Token: 0x04008698 RID: 34456
		private LuaFunction m_add_EventOnCloseAction;

		// Token: 0x04008699 RID: 34457
		private LuaFunction m_remove_EventOnCloseAction;

		// Token: 0x0400869A RID: 34458
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400869B RID: 34459
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000C38 RID: 3128
		public new class LuaExportHelper
		{
			// Token: 0x0600DBD8 RID: 56280 RVA: 0x003B9FB4 File Offset: 0x003B81B4
			public LuaExportHelper(DialogUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600DBD9 RID: 56281 RVA: 0x003B9FC4 File Offset: 0x003B81C4
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600DBDA RID: 56282 RVA: 0x003B9FD4 File Offset: 0x003B81D4
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600DBDB RID: 56283 RVA: 0x003B9FE4 File Offset: 0x003B81E4
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600DBDC RID: 56284 RVA: 0x003B9FF4 File Offset: 0x003B81F4
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600DBDD RID: 56285 RVA: 0x003BA004 File Offset: 0x003B8204
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600DBDE RID: 56286 RVA: 0x003BA014 File Offset: 0x003B8214
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600DBDF RID: 56287 RVA: 0x003BA024 File Offset: 0x003B8224
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600DBE0 RID: 56288 RVA: 0x003BA034 File Offset: 0x003B8234
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600DBE1 RID: 56289 RVA: 0x003BA044 File Offset: 0x003B8244
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600DBE2 RID: 56290 RVA: 0x003BA054 File Offset: 0x003B8254
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600DBE3 RID: 56291 RVA: 0x003BA064 File Offset: 0x003B8264
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600DBE4 RID: 56292 RVA: 0x003BA074 File Offset: 0x003B8274
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600DBE5 RID: 56293 RVA: 0x003BA084 File Offset: 0x003B8284
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600DBE6 RID: 56294 RVA: 0x003BA094 File Offset: 0x003B8294
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600DBE7 RID: 56295 RVA: 0x003BA0A4 File Offset: 0x003B82A4
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600DBE8 RID: 56296 RVA: 0x003BA0B4 File Offset: 0x003B82B4
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600DBE9 RID: 56297 RVA: 0x003BA0C4 File Offset: 0x003B82C4
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600DBEA RID: 56298 RVA: 0x003BA0D4 File Offset: 0x003B82D4
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600DBEB RID: 56299 RVA: 0x003BA0E4 File Offset: 0x003B82E4
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600DBEC RID: 56300 RVA: 0x003BA0F4 File Offset: 0x003B82F4
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600DBED RID: 56301 RVA: 0x003BA104 File Offset: 0x003B8304
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600DBEE RID: 56302 RVA: 0x003BA114 File Offset: 0x003B8314
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600DBEF RID: 56303 RVA: 0x003BA124 File Offset: 0x003B8324
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600DBF0 RID: 56304 RVA: 0x003BA134 File Offset: 0x003B8334
			public void __callDele_EventOnClose(bool obj)
			{
				this.m_owner.__callDele_EventOnClose(obj);
			}

			// Token: 0x0600DBF1 RID: 56305 RVA: 0x003BA144 File Offset: 0x003B8344
			public void __clearDele_EventOnClose(bool obj)
			{
				this.m_owner.__clearDele_EventOnClose(obj);
			}

			// Token: 0x17002AA8 RID: 10920
			// (get) Token: 0x0600DBF2 RID: 56306 RVA: 0x003BA154 File Offset: 0x003B8354
			// (set) Token: 0x0600DBF3 RID: 56307 RVA: 0x003BA164 File Offset: 0x003B8364
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

			// Token: 0x17002AA9 RID: 10921
			// (get) Token: 0x0600DBF4 RID: 56308 RVA: 0x003BA174 File Offset: 0x003B8374
			// (set) Token: 0x0600DBF5 RID: 56309 RVA: 0x003BA184 File Offset: 0x003B8384
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

			// Token: 0x17002AAA RID: 10922
			// (get) Token: 0x0600DBF6 RID: 56310 RVA: 0x003BA194 File Offset: 0x003B8394
			// (set) Token: 0x0600DBF7 RID: 56311 RVA: 0x003BA1A4 File Offset: 0x003B83A4
			public DialogUIController m_dialogUIController
			{
				get
				{
					return this.m_owner.m_dialogUIController;
				}
				set
				{
					this.m_owner.m_dialogUIController = value;
				}
			}

			// Token: 0x17002AAB RID: 10923
			// (get) Token: 0x0600DBF8 RID: 56312 RVA: 0x003BA1B4 File Offset: 0x003B83B4
			// (set) Token: 0x0600DBF9 RID: 56313 RVA: 0x003BA1C4 File Offset: 0x003B83C4
			public ConfigDataDialogInfo m_dialogInfo
			{
				get
				{
					return this.m_owner.m_dialogInfo;
				}
				set
				{
					this.m_owner.m_dialogInfo = value;
				}
			}

			// Token: 0x17002AAC RID: 10924
			// (get) Token: 0x0600DBFA RID: 56314 RVA: 0x003BA1D4 File Offset: 0x003B83D4
			// (set) Token: 0x0600DBFB RID: 56315 RVA: 0x003BA1E4 File Offset: 0x003B83E4
			public bool m_needBGChangeTween
			{
				get
				{
					return this.m_owner.m_needBGChangeTween;
				}
				set
				{
					this.m_owner.m_needBGChangeTween = value;
				}
			}

			// Token: 0x17002AAD RID: 10925
			// (get) Token: 0x0600DBFC RID: 56316 RVA: 0x003BA1F4 File Offset: 0x003B83F4
			// (set) Token: 0x0600DBFD RID: 56317 RVA: 0x003BA204 File Offset: 0x003B8404
			public bool m_isSkipClose
			{
				get
				{
					return this.m_owner.m_isSkipClose;
				}
				set
				{
					this.m_owner.m_isSkipClose = value;
				}
			}

			// Token: 0x17002AAE RID: 10926
			// (get) Token: 0x0600DBFE RID: 56318 RVA: 0x003BA214 File Offset: 0x003B8414
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002AAF RID: 10927
			// (get) Token: 0x0600DBFF RID: 56319 RVA: 0x003BA224 File Offset: 0x003B8424
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600DC00 RID: 56320 RVA: 0x003BA234 File Offset: 0x003B8434
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600DC01 RID: 56321 RVA: 0x003BA244 File Offset: 0x003B8444
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600DC02 RID: 56322 RVA: 0x003BA254 File Offset: 0x003B8454
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600DC03 RID: 56323 RVA: 0x003BA264 File Offset: 0x003B8464
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600DC04 RID: 56324 RVA: 0x003BA274 File Offset: 0x003B8474
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600DC05 RID: 56325 RVA: 0x003BA284 File Offset: 0x003B8484
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600DC06 RID: 56326 RVA: 0x003BA294 File Offset: 0x003B8494
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x0600DC07 RID: 56327 RVA: 0x003BA2A4 File Offset: 0x003B84A4
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600DC08 RID: 56328 RVA: 0x003BA2B4 File Offset: 0x003B84B4
			public void InitDialogUIController()
			{
				this.m_owner.InitDialogUIController();
			}

			// Token: 0x0600DC09 RID: 56329 RVA: 0x003BA2C4 File Offset: 0x003B84C4
			public void UninitDialogUIController()
			{
				this.m_owner.UninitDialogUIController();
			}

			// Token: 0x0600DC0A RID: 56330 RVA: 0x003BA2D4 File Offset: 0x003B84D4
			public void DialogUIController_OnSkip()
			{
				this.m_owner.DialogUIController_OnSkip();
			}

			// Token: 0x0600DC0B RID: 56331 RVA: 0x003BA2E4 File Offset: 0x003B84E4
			public void SkipDialogDialogBoxCallback(DialogBoxResult r)
			{
				this.m_owner.SkipDialogDialogBoxCallback(r);
			}

			// Token: 0x0600DC0C RID: 56332 RVA: 0x003BA2F4 File Offset: 0x003B84F4
			public void DialogUIController_OnNext(bool needBGChangeTween)
			{
				this.m_owner.DialogUIController_OnNext(needBGChangeTween);
			}

			// Token: 0x0600DC0D RID: 56333 RVA: 0x003BA304 File Offset: 0x003B8504
			public void DialogUIController_OnClose()
			{
				this.m_owner.DialogUIController_OnClose();
			}

			// Token: 0x0400869C RID: 34460
			private DialogUITask m_owner;
		}
	}
}
