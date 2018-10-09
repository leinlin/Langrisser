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
	// Token: 0x02000C70 RID: 3184
	[HotFix]
	public class FettersConfessionUnlockConditionUIController : UIControllerBase
	{
		// Token: 0x0600E3EC RID: 58348 RVA: 0x003D3DA0 File Offset: 0x003D1FA0
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
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600E3ED RID: 58349 RVA: 0x003D3E14 File Offset: 0x003D2014
		public void InitFettersConfessionUnlockCondition(int heroFetterId, int confessLevel, bool isFetterUnLock, int curLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitFettersConfessionUnlockConditionInt32Int32BooleanInt32_hotfix != null)
			{
				this.m_InitFettersConfessionUnlockConditionInt32Int32BooleanInt32_hotfix.call(new object[]
				{
					this,
					heroFetterId,
					confessLevel,
					isFetterUnLock,
					curLevel
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataHeroFetterInfo configDataHeroFetterInfo = configDataLoader.GetConfigDataHeroFetterInfo(heroFetterId);
			if (!isFetterUnLock)
			{
				this.m_stateCtrl.SetToUIState("Lock", false, true);
			}
			else
			{
				if (curLevel != confessLevel)
				{
					this.m_skillCurLevelValue.text = curLevel.ToString();
					this.m_skillMaxLevelValue.text = confessLevel.ToString();
					this.m_stateCtrl.SetToUIState("Normal", false, true);
				}
				else
				{
					this.m_stateCtrl.SetToUIState("Max", false, true);
				}
				this.m_skillIconImage.sprite = AssetUtility.Instance.GetSprite(configDataHeroFetterInfo.Icon);
				this.m_skillNameText.text = configDataHeroFetterInfo.Name;
			}
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x0600E3EE RID: 58350 RVA: 0x003D3F78 File Offset: 0x003D2178
		// (set) Token: 0x0600E3EF RID: 58351 RVA: 0x003D3F98 File Offset: 0x003D2198
		[DoNotToLua]
		public new FettersConfessionUnlockConditionUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersConfessionUnlockConditionUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E3F0 RID: 58352 RVA: 0x003D3FA4 File Offset: 0x003D21A4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E3F1 RID: 58353 RVA: 0x003D3FB0 File Offset: 0x003D21B0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E3F2 RID: 58354 RVA: 0x003D3FB8 File Offset: 0x003D21B8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E3F3 RID: 58355 RVA: 0x003D3FC0 File Offset: 0x003D21C0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E3F4 RID: 58356 RVA: 0x003D3FD4 File Offset: 0x003D21D4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E3F5 RID: 58357 RVA: 0x003D3FDC File Offset: 0x003D21DC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E3F6 RID: 58358 RVA: 0x003D3FE8 File Offset: 0x003D21E8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E3F7 RID: 58359 RVA: 0x003D3FF4 File Offset: 0x003D21F4
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E3F8 RID: 58360 RVA: 0x003D4000 File Offset: 0x003D2200
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E3F9 RID: 58361 RVA: 0x003D400C File Offset: 0x003D220C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E3FA RID: 58362 RVA: 0x003D4018 File Offset: 0x003D2218
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E3FB RID: 58363 RVA: 0x003D4024 File Offset: 0x003D2224
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E3FC RID: 58364 RVA: 0x003D4030 File Offset: 0x003D2230
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E3FD RID: 58365 RVA: 0x003D403C File Offset: 0x003D223C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E3FE RID: 58366 RVA: 0x003D4048 File Offset: 0x003D2248
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E3FF RID: 58367 RVA: 0x003D4050 File Offset: 0x003D2250
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
					this.m_InitFettersConfessionUnlockConditionInt32Int32BooleanInt32_hotfix = (luaObj.RawGet("InitFettersConfessionUnlockCondition") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E400 RID: 58368 RVA: 0x003D4134 File Offset: 0x003D2334
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersConfessionUnlockConditionUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040089C7 RID: 35271
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x040089C8 RID: 35272
		[AutoBind("./SkillIconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_skillIconImage;

		// Token: 0x040089C9 RID: 35273
		[AutoBind("./NameGroup/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillNameText;

		// Token: 0x040089CA RID: 35274
		[AutoBind("./Value/First", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillCurLevelValue;

		// Token: 0x040089CB RID: 35275
		[AutoBind("./Value/Last", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_skillMaxLevelValue;

		// Token: 0x040089CC RID: 35276
		[DoNotToLua]
		private FettersConfessionUnlockConditionUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040089CD RID: 35277
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040089CE RID: 35278
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040089CF RID: 35279
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040089D0 RID: 35280
		private LuaFunction m_InitFettersConfessionUnlockConditionInt32Int32BooleanInt32_hotfix;

		// Token: 0x02000C71 RID: 3185
		public new class LuaExportHelper
		{
			// Token: 0x0600E401 RID: 58369 RVA: 0x003D419C File Offset: 0x003D239C
			public LuaExportHelper(FettersConfessionUnlockConditionUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E402 RID: 58370 RVA: 0x003D41AC File Offset: 0x003D23AC
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E403 RID: 58371 RVA: 0x003D41BC File Offset: 0x003D23BC
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E404 RID: 58372 RVA: 0x003D41CC File Offset: 0x003D23CC
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E405 RID: 58373 RVA: 0x003D41DC File Offset: 0x003D23DC
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E406 RID: 58374 RVA: 0x003D41F4 File Offset: 0x003D23F4
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E407 RID: 58375 RVA: 0x003D4204 File Offset: 0x003D2404
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E408 RID: 58376 RVA: 0x003D4214 File Offset: 0x003D2414
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E409 RID: 58377 RVA: 0x003D4224 File Offset: 0x003D2424
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E40A RID: 58378 RVA: 0x003D4234 File Offset: 0x003D2434
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E40B RID: 58379 RVA: 0x003D4244 File Offset: 0x003D2444
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E40C RID: 58380 RVA: 0x003D4254 File Offset: 0x003D2454
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E40D RID: 58381 RVA: 0x003D4264 File Offset: 0x003D2464
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E40E RID: 58382 RVA: 0x003D4274 File Offset: 0x003D2474
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E40F RID: 58383 RVA: 0x003D4284 File Offset: 0x003D2484
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E410 RID: 58384 RVA: 0x003D4294 File Offset: 0x003D2494
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17002C3E RID: 11326
			// (get) Token: 0x0600E411 RID: 58385 RVA: 0x003D42A4 File Offset: 0x003D24A4
			// (set) Token: 0x0600E412 RID: 58386 RVA: 0x003D42B4 File Offset: 0x003D24B4
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

			// Token: 0x17002C3F RID: 11327
			// (get) Token: 0x0600E413 RID: 58387 RVA: 0x003D42C4 File Offset: 0x003D24C4
			// (set) Token: 0x0600E414 RID: 58388 RVA: 0x003D42D4 File Offset: 0x003D24D4
			public Image m_skillIconImage
			{
				get
				{
					return this.m_owner.m_skillIconImage;
				}
				set
				{
					this.m_owner.m_skillIconImage = value;
				}
			}

			// Token: 0x17002C40 RID: 11328
			// (get) Token: 0x0600E415 RID: 58389 RVA: 0x003D42E4 File Offset: 0x003D24E4
			// (set) Token: 0x0600E416 RID: 58390 RVA: 0x003D42F4 File Offset: 0x003D24F4
			public Text m_skillNameText
			{
				get
				{
					return this.m_owner.m_skillNameText;
				}
				set
				{
					this.m_owner.m_skillNameText = value;
				}
			}

			// Token: 0x17002C41 RID: 11329
			// (get) Token: 0x0600E417 RID: 58391 RVA: 0x003D4304 File Offset: 0x003D2504
			// (set) Token: 0x0600E418 RID: 58392 RVA: 0x003D4314 File Offset: 0x003D2514
			public Text m_skillCurLevelValue
			{
				get
				{
					return this.m_owner.m_skillCurLevelValue;
				}
				set
				{
					this.m_owner.m_skillCurLevelValue = value;
				}
			}

			// Token: 0x17002C42 RID: 11330
			// (get) Token: 0x0600E419 RID: 58393 RVA: 0x003D4324 File Offset: 0x003D2524
			// (set) Token: 0x0600E41A RID: 58394 RVA: 0x003D4334 File Offset: 0x003D2534
			public Text m_skillMaxLevelValue
			{
				get
				{
					return this.m_owner.m_skillMaxLevelValue;
				}
				set
				{
					this.m_owner.m_skillMaxLevelValue = value;
				}
			}

			// Token: 0x0600E41B RID: 58395 RVA: 0x003D4344 File Offset: 0x003D2544
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x040089D1 RID: 35281
			private FettersConfessionUnlockConditionUIController m_owner;
		}
	}
}
