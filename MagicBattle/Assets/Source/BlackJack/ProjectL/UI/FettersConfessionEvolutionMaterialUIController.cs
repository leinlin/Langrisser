using System;
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
	// Token: 0x02000C6E RID: 3182
	[HotFix]
	public class FettersConfessionEvolutionMaterialUIController : UIControllerBase
	{
		// Token: 0x0600E3A9 RID: 58281 RVA: 0x003D3448 File Offset: 0x003D1648
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
			this.m_materialButton.onClick.AddListener(new UnityAction(this.OnClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600E3AA RID: 58282 RVA: 0x003D34D8 File Offset: 0x003D16D8
		public void InitFettersConfessionEvolutionMaterial(GoodsType goodsType, int goodsId, int needCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitFettersConfessionEvolutionMaterialGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_InitFettersConfessionEvolutionMaterialGoodsTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					goodsType,
					goodsId,
					needCount
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_goodsType = goodsType;
			this.m_goodsId = goodsId;
			this.m_needCount = needCount;
			if (goodsId == 0)
			{
				this.m_stateCtrl.SetToUIState("Empty", false, true);
			}
			else
			{
				this.m_stateCtrl.SetToUIState("Have", false, true);
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				int bagItemCountByType = projectLPlayerContext.GetBagItemCountByType(this.m_goodsType, this.m_goodsId);
				this.m_materialHaveCount.text = bagItemCountByType.ToString();
				this.m_materialNeedCount.text = needCount.ToString();
				if (bagItemCountByType >= needCount)
				{
					this.m_materialCountStateCtrl.SetToUIState("White", false, true);
				}
				else
				{
					this.m_materialCountStateCtrl.SetToUIState("Red", false, true);
				}
				this.m_materialIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(this.m_goodsType, this.m_goodsId));
				this.m_materialIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(this.m_goodsType, this.m_goodsId));
				this.m_materialBgImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameName(this.m_goodsType, this.m_goodsId));
			}
		}

		// Token: 0x0600E3AB RID: 58283 RVA: 0x003D36A4 File Offset: 0x003D18A4
		private void OnClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClick_hotfix != null)
			{
				this.m_OnClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnClick != null && this.m_goodsId != 0)
			{
				this.EventOnClick(this.m_goodsType, this.m_goodsId, this.m_needCount);
			}
		}

		// Token: 0x140002DE RID: 734
		// (add) Token: 0x0600E3AC RID: 58284 RVA: 0x003D3738 File Offset: 0x003D1938
		// (remove) Token: 0x0600E3AD RID: 58285 RVA: 0x003D37D4 File Offset: 0x003D19D4
		public event Action<GoodsType, int, int> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`3_hotfix != null)
				{
					this.m_add_EventOnClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnClick, (Action<GoodsType, int, int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`3_hotfix != null)
				{
					this.m_remove_EventOnClickAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<GoodsType, int, int> action = this.EventOnClick;
				Action<GoodsType, int, int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<GoodsType, int, int>>(ref this.EventOnClick, (Action<GoodsType, int, int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x0600E3AE RID: 58286 RVA: 0x003D3870 File Offset: 0x003D1A70
		// (set) Token: 0x0600E3AF RID: 58287 RVA: 0x003D3890 File Offset: 0x003D1A90
		[DoNotToLua]
		public new FettersConfessionEvolutionMaterialUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new FettersConfessionEvolutionMaterialUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E3B0 RID: 58288 RVA: 0x003D389C File Offset: 0x003D1A9C
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600E3B1 RID: 58289 RVA: 0x003D38A8 File Offset: 0x003D1AA8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600E3B2 RID: 58290 RVA: 0x003D38B0 File Offset: 0x003D1AB0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600E3B3 RID: 58291 RVA: 0x003D38B8 File Offset: 0x003D1AB8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600E3B4 RID: 58292 RVA: 0x003D38CC File Offset: 0x003D1ACC
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600E3B5 RID: 58293 RVA: 0x003D38D4 File Offset: 0x003D1AD4
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600E3B6 RID: 58294 RVA: 0x003D38E0 File Offset: 0x003D1AE0
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600E3B7 RID: 58295 RVA: 0x003D38EC File Offset: 0x003D1AEC
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600E3B8 RID: 58296 RVA: 0x003D38F8 File Offset: 0x003D1AF8
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600E3B9 RID: 58297 RVA: 0x003D3904 File Offset: 0x003D1B04
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600E3BA RID: 58298 RVA: 0x003D3910 File Offset: 0x003D1B10
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600E3BB RID: 58299 RVA: 0x003D391C File Offset: 0x003D1B1C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600E3BC RID: 58300 RVA: 0x003D3928 File Offset: 0x003D1B28
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600E3BD RID: 58301 RVA: 0x003D3934 File Offset: 0x003D1B34
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600E3BE RID: 58302 RVA: 0x003D3940 File Offset: 0x003D1B40
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600E3BF RID: 58303 RVA: 0x003D3948 File Offset: 0x003D1B48
		private void __callDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
		{
			Action<GoodsType, int, int> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600E3C0 RID: 58304 RVA: 0x003D396C File Offset: 0x003D1B6C
		private void __clearDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600E3C1 RID: 58305 RVA: 0x003D3978 File Offset: 0x003D1B78
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
					this.m_InitFettersConfessionEvolutionMaterialGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("InitFettersConfessionEvolutionMaterial") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`3_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E3C2 RID: 58306 RVA: 0x003D3AA8 File Offset: 0x003D1CA8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FettersConfessionEvolutionMaterialUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040089B4 RID: 35252
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_stateCtrl;

		// Token: 0x040089B5 RID: 35253
		[AutoBind("./ValueGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_materialCountStateCtrl;

		// Token: 0x040089B6 RID: 35254
		[AutoBind("./ValueGroup/HaveCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_materialHaveCount;

		// Token: 0x040089B7 RID: 35255
		[AutoBind("./ValueGroup/NeedCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_materialNeedCount;

		// Token: 0x040089B8 RID: 35256
		[AutoBind("./Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_materialIconImage;

		// Token: 0x040089B9 RID: 35257
		[AutoBind("./BgImg", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_materialBgImage;

		// Token: 0x040089BA RID: 35258
		[AutoBind("./BgImg", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_materialButton;

		// Token: 0x040089BB RID: 35259
		private GoodsType m_goodsType;

		// Token: 0x040089BC RID: 35260
		private int m_goodsId;

		// Token: 0x040089BD RID: 35261
		private int m_needCount;

		// Token: 0x040089BE RID: 35262
		[DoNotToLua]
		private FettersConfessionEvolutionMaterialUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040089BF RID: 35263
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040089C0 RID: 35264
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040089C1 RID: 35265
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x040089C2 RID: 35266
		private LuaFunction m_InitFettersConfessionEvolutionMaterialGoodsTypeInt32Int32_hotfix;

		// Token: 0x040089C3 RID: 35267
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x040089C4 RID: 35268
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x040089C5 RID: 35269
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000C6F RID: 3183
		public new class LuaExportHelper
		{
			// Token: 0x0600E3C3 RID: 58307 RVA: 0x003D3B10 File Offset: 0x003D1D10
			public LuaExportHelper(FettersConfessionEvolutionMaterialUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E3C4 RID: 58308 RVA: 0x003D3B20 File Offset: 0x003D1D20
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600E3C5 RID: 58309 RVA: 0x003D3B30 File Offset: 0x003D1D30
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600E3C6 RID: 58310 RVA: 0x003D3B40 File Offset: 0x003D1D40
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600E3C7 RID: 58311 RVA: 0x003D3B50 File Offset: 0x003D1D50
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600E3C8 RID: 58312 RVA: 0x003D3B68 File Offset: 0x003D1D68
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600E3C9 RID: 58313 RVA: 0x003D3B78 File Offset: 0x003D1D78
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600E3CA RID: 58314 RVA: 0x003D3B88 File Offset: 0x003D1D88
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600E3CB RID: 58315 RVA: 0x003D3B98 File Offset: 0x003D1D98
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600E3CC RID: 58316 RVA: 0x003D3BA8 File Offset: 0x003D1DA8
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600E3CD RID: 58317 RVA: 0x003D3BB8 File Offset: 0x003D1DB8
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600E3CE RID: 58318 RVA: 0x003D3BC8 File Offset: 0x003D1DC8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600E3CF RID: 58319 RVA: 0x003D3BD8 File Offset: 0x003D1DD8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600E3D0 RID: 58320 RVA: 0x003D3BE8 File Offset: 0x003D1DE8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600E3D1 RID: 58321 RVA: 0x003D3BF8 File Offset: 0x003D1DF8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600E3D2 RID: 58322 RVA: 0x003D3C08 File Offset: 0x003D1E08
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600E3D3 RID: 58323 RVA: 0x003D3C18 File Offset: 0x003D1E18
			public void __callDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnClick(arg1, arg2, arg3);
			}

			// Token: 0x0600E3D4 RID: 58324 RVA: 0x003D3C28 File Offset: 0x003D1E28
			public void __clearDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnClick(arg1, arg2, arg3);
			}

			// Token: 0x17002C33 RID: 11315
			// (get) Token: 0x0600E3D5 RID: 58325 RVA: 0x003D3C38 File Offset: 0x003D1E38
			// (set) Token: 0x0600E3D6 RID: 58326 RVA: 0x003D3C48 File Offset: 0x003D1E48
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

			// Token: 0x17002C34 RID: 11316
			// (get) Token: 0x0600E3D7 RID: 58327 RVA: 0x003D3C58 File Offset: 0x003D1E58
			// (set) Token: 0x0600E3D8 RID: 58328 RVA: 0x003D3C68 File Offset: 0x003D1E68
			public CommonUIStateController m_materialCountStateCtrl
			{
				get
				{
					return this.m_owner.m_materialCountStateCtrl;
				}
				set
				{
					this.m_owner.m_materialCountStateCtrl = value;
				}
			}

			// Token: 0x17002C35 RID: 11317
			// (get) Token: 0x0600E3D9 RID: 58329 RVA: 0x003D3C78 File Offset: 0x003D1E78
			// (set) Token: 0x0600E3DA RID: 58330 RVA: 0x003D3C88 File Offset: 0x003D1E88
			public Text m_materialHaveCount
			{
				get
				{
					return this.m_owner.m_materialHaveCount;
				}
				set
				{
					this.m_owner.m_materialHaveCount = value;
				}
			}

			// Token: 0x17002C36 RID: 11318
			// (get) Token: 0x0600E3DB RID: 58331 RVA: 0x003D3C98 File Offset: 0x003D1E98
			// (set) Token: 0x0600E3DC RID: 58332 RVA: 0x003D3CA8 File Offset: 0x003D1EA8
			public Text m_materialNeedCount
			{
				get
				{
					return this.m_owner.m_materialNeedCount;
				}
				set
				{
					this.m_owner.m_materialNeedCount = value;
				}
			}

			// Token: 0x17002C37 RID: 11319
			// (get) Token: 0x0600E3DD RID: 58333 RVA: 0x003D3CB8 File Offset: 0x003D1EB8
			// (set) Token: 0x0600E3DE RID: 58334 RVA: 0x003D3CC8 File Offset: 0x003D1EC8
			public Image m_materialIconImage
			{
				get
				{
					return this.m_owner.m_materialIconImage;
				}
				set
				{
					this.m_owner.m_materialIconImage = value;
				}
			}

			// Token: 0x17002C38 RID: 11320
			// (get) Token: 0x0600E3DF RID: 58335 RVA: 0x003D3CD8 File Offset: 0x003D1ED8
			// (set) Token: 0x0600E3E0 RID: 58336 RVA: 0x003D3CE8 File Offset: 0x003D1EE8
			public Image m_materialBgImage
			{
				get
				{
					return this.m_owner.m_materialBgImage;
				}
				set
				{
					this.m_owner.m_materialBgImage = value;
				}
			}

			// Token: 0x17002C39 RID: 11321
			// (get) Token: 0x0600E3E1 RID: 58337 RVA: 0x003D3CF8 File Offset: 0x003D1EF8
			// (set) Token: 0x0600E3E2 RID: 58338 RVA: 0x003D3D08 File Offset: 0x003D1F08
			public Button m_materialButton
			{
				get
				{
					return this.m_owner.m_materialButton;
				}
				set
				{
					this.m_owner.m_materialButton = value;
				}
			}

			// Token: 0x17002C3A RID: 11322
			// (get) Token: 0x0600E3E3 RID: 58339 RVA: 0x003D3D18 File Offset: 0x003D1F18
			// (set) Token: 0x0600E3E4 RID: 58340 RVA: 0x003D3D28 File Offset: 0x003D1F28
			public GoodsType m_goodsType
			{
				get
				{
					return this.m_owner.m_goodsType;
				}
				set
				{
					this.m_owner.m_goodsType = value;
				}
			}

			// Token: 0x17002C3B RID: 11323
			// (get) Token: 0x0600E3E5 RID: 58341 RVA: 0x003D3D38 File Offset: 0x003D1F38
			// (set) Token: 0x0600E3E6 RID: 58342 RVA: 0x003D3D48 File Offset: 0x003D1F48
			public int m_goodsId
			{
				get
				{
					return this.m_owner.m_goodsId;
				}
				set
				{
					this.m_owner.m_goodsId = value;
				}
			}

			// Token: 0x17002C3C RID: 11324
			// (get) Token: 0x0600E3E7 RID: 58343 RVA: 0x003D3D58 File Offset: 0x003D1F58
			// (set) Token: 0x0600E3E8 RID: 58344 RVA: 0x003D3D68 File Offset: 0x003D1F68
			public int m_needCount
			{
				get
				{
					return this.m_owner.m_needCount;
				}
				set
				{
					this.m_owner.m_needCount = value;
				}
			}

			// Token: 0x0600E3E9 RID: 58345 RVA: 0x003D3D78 File Offset: 0x003D1F78
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600E3EA RID: 58346 RVA: 0x003D3D88 File Offset: 0x003D1F88
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x040089C6 RID: 35270
			private FettersConfessionEvolutionMaterialUIController m_owner;
		}
	}
}
