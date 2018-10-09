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
	// Token: 0x02000C4B RID: 3147
	[HotFix]
	public class TrainingSkillEvolutionMaterialUIController : UIControllerBase
	{
		// Token: 0x0600DE50 RID: 56912 RVA: 0x003C136C File Offset: 0x003BF56C
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

		// Token: 0x0600DE51 RID: 56913 RVA: 0x003C13FC File Offset: 0x003BF5FC
		public void InitTrainingSkillEvolutionMaterial(GoodsType goodsType, int goodsId, int needCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTrainingSkillEvolutionMaterialGoodsTypeInt32Int32_hotfix != null)
			{
				this.m_InitTrainingSkillEvolutionMaterialGoodsTypeInt32Int32_hotfix.call(new object[]
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
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int bagItemCountByType = projectLPlayerContext.GetBagItemCountByType(this.m_goodsType, this.m_goodsId);
			this.m_materialHaveCount.text = bagItemCountByType.ToString();
			this.m_materialNeedCount.text = needCount.ToString();
			if (bagItemCountByType >= needCount)
			{
				this.m_materialCountStateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_materialCountStateCtrl.SetToUIState("Red", false, true);
			}
			this.m_materialIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(this.m_goodsType, this.m_goodsId));
			this.m_materialIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(this.m_goodsType, this.m_goodsId));
			this.m_materialFrameImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsFrameName(this.m_goodsType, this.m_goodsId));
		}

		// Token: 0x0600DE52 RID: 56914 RVA: 0x003C1598 File Offset: 0x003BF798
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

		// Token: 0x140002C3 RID: 707
		// (add) Token: 0x0600DE53 RID: 56915 RVA: 0x003C162C File Offset: 0x003BF82C
		// (remove) Token: 0x0600DE54 RID: 56916 RVA: 0x003C16C8 File Offset: 0x003BF8C8
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

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x0600DE55 RID: 56917 RVA: 0x003C1764 File Offset: 0x003BF964
		// (set) Token: 0x0600DE56 RID: 56918 RVA: 0x003C1784 File Offset: 0x003BF984
		[DoNotToLua]
		public new TrainingSkillEvolutionMaterialUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TrainingSkillEvolutionMaterialUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600DE57 RID: 56919 RVA: 0x003C1790 File Offset: 0x003BF990
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600DE58 RID: 56920 RVA: 0x003C179C File Offset: 0x003BF99C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600DE59 RID: 56921 RVA: 0x003C17A4 File Offset: 0x003BF9A4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600DE5A RID: 56922 RVA: 0x003C17AC File Offset: 0x003BF9AC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600DE5B RID: 56923 RVA: 0x003C17C0 File Offset: 0x003BF9C0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600DE5C RID: 56924 RVA: 0x003C17C8 File Offset: 0x003BF9C8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600DE5D RID: 56925 RVA: 0x003C17D4 File Offset: 0x003BF9D4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600DE5E RID: 56926 RVA: 0x003C17E0 File Offset: 0x003BF9E0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600DE5F RID: 56927 RVA: 0x003C17EC File Offset: 0x003BF9EC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600DE60 RID: 56928 RVA: 0x003C17F8 File Offset: 0x003BF9F8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600DE61 RID: 56929 RVA: 0x003C1804 File Offset: 0x003BFA04
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600DE62 RID: 56930 RVA: 0x003C1810 File Offset: 0x003BFA10
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600DE63 RID: 56931 RVA: 0x003C181C File Offset: 0x003BFA1C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600DE64 RID: 56932 RVA: 0x003C1828 File Offset: 0x003BFA28
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600DE65 RID: 56933 RVA: 0x003C1834 File Offset: 0x003BFA34
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600DE66 RID: 56934 RVA: 0x003C183C File Offset: 0x003BFA3C
		private void __callDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
		{
			Action<GoodsType, int, int> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(arg1, arg2, arg3);
			}
		}

		// Token: 0x0600DE67 RID: 56935 RVA: 0x003C1860 File Offset: 0x003BFA60
		private void __clearDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600DE68 RID: 56936 RVA: 0x003C186C File Offset: 0x003BFA6C
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
					this.m_InitTrainingSkillEvolutionMaterialGoodsTypeInt32Int32_hotfix = (luaObj.RawGet("InitTrainingSkillEvolutionMaterial") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_add_EventOnClickAction`3_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`3_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600DE69 RID: 56937 RVA: 0x003C199C File Offset: 0x003BFB9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TrainingSkillEvolutionMaterialUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400878D RID: 34701
		[AutoBind("./ValueGroup", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_materialCountStateCtrl;

		// Token: 0x0400878E RID: 34702
		[AutoBind("./ValueGroup/HaveCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_materialHaveCount;

		// Token: 0x0400878F RID: 34703
		[AutoBind("./ValueGroup/NeedCount", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_materialNeedCount;

		// Token: 0x04008790 RID: 34704
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_materialIconImage;

		// Token: 0x04008791 RID: 34705
		[AutoBind("./FrameImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_materialFrameImage;

		// Token: 0x04008792 RID: 34706
		[AutoBind("./FrameImage", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_materialButton;

		// Token: 0x04008793 RID: 34707
		private GoodsType m_goodsType;

		// Token: 0x04008794 RID: 34708
		private int m_goodsId;

		// Token: 0x04008795 RID: 34709
		private int m_needCount;

		// Token: 0x04008796 RID: 34710
		[DoNotToLua]
		private TrainingSkillEvolutionMaterialUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04008797 RID: 34711
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008798 RID: 34712
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008799 RID: 34713
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400879A RID: 34714
		private LuaFunction m_InitTrainingSkillEvolutionMaterialGoodsTypeInt32Int32_hotfix;

		// Token: 0x0400879B RID: 34715
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x0400879C RID: 34716
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x0400879D RID: 34717
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x02000C4C RID: 3148
		public new class LuaExportHelper
		{
			// Token: 0x0600DE6A RID: 56938 RVA: 0x003C1A04 File Offset: 0x003BFC04
			public LuaExportHelper(TrainingSkillEvolutionMaterialUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600DE6B RID: 56939 RVA: 0x003C1A14 File Offset: 0x003BFC14
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600DE6C RID: 56940 RVA: 0x003C1A24 File Offset: 0x003BFC24
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600DE6D RID: 56941 RVA: 0x003C1A34 File Offset: 0x003BFC34
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600DE6E RID: 56942 RVA: 0x003C1A44 File Offset: 0x003BFC44
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600DE6F RID: 56943 RVA: 0x003C1A5C File Offset: 0x003BFC5C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600DE70 RID: 56944 RVA: 0x003C1A6C File Offset: 0x003BFC6C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600DE71 RID: 56945 RVA: 0x003C1A7C File Offset: 0x003BFC7C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600DE72 RID: 56946 RVA: 0x003C1A8C File Offset: 0x003BFC8C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600DE73 RID: 56947 RVA: 0x003C1A9C File Offset: 0x003BFC9C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600DE74 RID: 56948 RVA: 0x003C1AAC File Offset: 0x003BFCAC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600DE75 RID: 56949 RVA: 0x003C1ABC File Offset: 0x003BFCBC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600DE76 RID: 56950 RVA: 0x003C1ACC File Offset: 0x003BFCCC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600DE77 RID: 56951 RVA: 0x003C1ADC File Offset: 0x003BFCDC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600DE78 RID: 56952 RVA: 0x003C1AEC File Offset: 0x003BFCEC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600DE79 RID: 56953 RVA: 0x003C1AFC File Offset: 0x003BFCFC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600DE7A RID: 56954 RVA: 0x003C1B0C File Offset: 0x003BFD0C
			public void __callDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__callDele_EventOnClick(arg1, arg2, arg3);
			}

			// Token: 0x0600DE7B RID: 56955 RVA: 0x003C1B1C File Offset: 0x003BFD1C
			public void __clearDele_EventOnClick(GoodsType arg1, int arg2, int arg3)
			{
				this.m_owner.__clearDele_EventOnClick(arg1, arg2, arg3);
			}

			// Token: 0x17002B32 RID: 11058
			// (get) Token: 0x0600DE7C RID: 56956 RVA: 0x003C1B2C File Offset: 0x003BFD2C
			// (set) Token: 0x0600DE7D RID: 56957 RVA: 0x003C1B3C File Offset: 0x003BFD3C
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

			// Token: 0x17002B33 RID: 11059
			// (get) Token: 0x0600DE7E RID: 56958 RVA: 0x003C1B4C File Offset: 0x003BFD4C
			// (set) Token: 0x0600DE7F RID: 56959 RVA: 0x003C1B5C File Offset: 0x003BFD5C
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

			// Token: 0x17002B34 RID: 11060
			// (get) Token: 0x0600DE80 RID: 56960 RVA: 0x003C1B6C File Offset: 0x003BFD6C
			// (set) Token: 0x0600DE81 RID: 56961 RVA: 0x003C1B7C File Offset: 0x003BFD7C
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

			// Token: 0x17002B35 RID: 11061
			// (get) Token: 0x0600DE82 RID: 56962 RVA: 0x003C1B8C File Offset: 0x003BFD8C
			// (set) Token: 0x0600DE83 RID: 56963 RVA: 0x003C1B9C File Offset: 0x003BFD9C
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

			// Token: 0x17002B36 RID: 11062
			// (get) Token: 0x0600DE84 RID: 56964 RVA: 0x003C1BAC File Offset: 0x003BFDAC
			// (set) Token: 0x0600DE85 RID: 56965 RVA: 0x003C1BBC File Offset: 0x003BFDBC
			public Image m_materialFrameImage
			{
				get
				{
					return this.m_owner.m_materialFrameImage;
				}
				set
				{
					this.m_owner.m_materialFrameImage = value;
				}
			}

			// Token: 0x17002B37 RID: 11063
			// (get) Token: 0x0600DE86 RID: 56966 RVA: 0x003C1BCC File Offset: 0x003BFDCC
			// (set) Token: 0x0600DE87 RID: 56967 RVA: 0x003C1BDC File Offset: 0x003BFDDC
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

			// Token: 0x17002B38 RID: 11064
			// (get) Token: 0x0600DE88 RID: 56968 RVA: 0x003C1BEC File Offset: 0x003BFDEC
			// (set) Token: 0x0600DE89 RID: 56969 RVA: 0x003C1BFC File Offset: 0x003BFDFC
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

			// Token: 0x17002B39 RID: 11065
			// (get) Token: 0x0600DE8A RID: 56970 RVA: 0x003C1C0C File Offset: 0x003BFE0C
			// (set) Token: 0x0600DE8B RID: 56971 RVA: 0x003C1C1C File Offset: 0x003BFE1C
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

			// Token: 0x17002B3A RID: 11066
			// (get) Token: 0x0600DE8C RID: 56972 RVA: 0x003C1C2C File Offset: 0x003BFE2C
			// (set) Token: 0x0600DE8D RID: 56973 RVA: 0x003C1C3C File Offset: 0x003BFE3C
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

			// Token: 0x0600DE8E RID: 56974 RVA: 0x003C1C4C File Offset: 0x003BFE4C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600DE8F RID: 56975 RVA: 0x003C1C5C File Offset: 0x003BFE5C
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0400879E RID: 34718
			private TrainingSkillEvolutionMaterialUIController m_owner;
		}
	}
}
