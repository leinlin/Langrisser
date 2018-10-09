using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DC8 RID: 3528
	[HotFix]
	public class HeroJobTransferConditionItemUIController : UIControllerBase
	{
		// Token: 0x06010D9E RID: 69022 RVA: 0x0045D7EC File Offset: 0x0045B9EC
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

		// Token: 0x06010D9F RID: 69023 RVA: 0x0045D860 File Offset: 0x0045BA60
		public void InitConditionItem(ConfigDataJobUnlockConditionInfo condition, HeroJob heroJob)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitConditionItemConfigDataJobUnlockConditionInfoHeroJob_hotfix != null)
			{
				this.m_InitConditionItemConfigDataJobUnlockConditionInfoHeroJob_hotfix.call(new object[]
				{
					this,
					condition,
					heroJob
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.ConditionInfo = condition;
			this.m_text.text = condition.Desc;
			bool active = true;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (condition.ID != 0)
			{
				active = (heroJob != null && heroJob.Achievements.Contains(condition.ID));
			}
			else if (condition.ItemCost.Count != 0)
			{
				foreach (Goods goods in condition.ItemCost)
				{
					int bagItemCountByType = projectLPlayerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, goods.Id);
					if (bagItemCountByType < goods.Count)
					{
						active = false;
						break;
					}
				}
			}
			this.m_finishTag.SetActive(active);
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x06010DA1 RID: 69025 RVA: 0x0045DA38 File Offset: 0x0045BC38
		// (set) Token: 0x06010DA0 RID: 69024 RVA: 0x0045D9C0 File Offset: 0x0045BBC0
		public ConfigDataJobUnlockConditionInfo ConditionInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ConditionInfo_hotfix != null)
				{
					return (ConfigDataJobUnlockConditionInfo)this.m_get_ConditionInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<ConditionInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ConditionInfoConfigDataJobUnlockConditionInfo_hotfix != null)
				{
					this.m_set_ConditionInfoConfigDataJobUnlockConditionInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<ConditionInfo>k__BackingField = value;
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x06010DA2 RID: 69026 RVA: 0x0045DAAC File Offset: 0x0045BCAC
		// (set) Token: 0x06010DA3 RID: 69027 RVA: 0x0045DACC File Offset: 0x0045BCCC
		[DoNotToLua]
		public new HeroJobTransferConditionItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroJobTransferConditionItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010DA4 RID: 69028 RVA: 0x0045DAD8 File Offset: 0x0045BCD8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06010DA5 RID: 69029 RVA: 0x0045DAE4 File Offset: 0x0045BCE4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06010DA6 RID: 69030 RVA: 0x0045DAEC File Offset: 0x0045BCEC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06010DA7 RID: 69031 RVA: 0x0045DAF4 File Offset: 0x0045BCF4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06010DA8 RID: 69032 RVA: 0x0045DB08 File Offset: 0x0045BD08
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06010DA9 RID: 69033 RVA: 0x0045DB10 File Offset: 0x0045BD10
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06010DAA RID: 69034 RVA: 0x0045DB1C File Offset: 0x0045BD1C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06010DAB RID: 69035 RVA: 0x0045DB28 File Offset: 0x0045BD28
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06010DAC RID: 69036 RVA: 0x0045DB34 File Offset: 0x0045BD34
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06010DAD RID: 69037 RVA: 0x0045DB40 File Offset: 0x0045BD40
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06010DAE RID: 69038 RVA: 0x0045DB4C File Offset: 0x0045BD4C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06010DAF RID: 69039 RVA: 0x0045DB58 File Offset: 0x0045BD58
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06010DB0 RID: 69040 RVA: 0x0045DB64 File Offset: 0x0045BD64
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06010DB1 RID: 69041 RVA: 0x0045DB70 File Offset: 0x0045BD70
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06010DB2 RID: 69042 RVA: 0x0045DB7C File Offset: 0x0045BD7C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06010DB3 RID: 69043 RVA: 0x0045DB84 File Offset: 0x0045BD84
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
					this.m_InitConditionItemConfigDataJobUnlockConditionInfoHeroJob_hotfix = (luaObj.RawGet("InitConditionItem") as LuaFunction);
					this.m_set_ConditionInfoConfigDataJobUnlockConditionInfo_hotfix = (luaObj.RawGet("set_ConditionInfo") as LuaFunction);
					this.m_get_ConditionInfo_hotfix = (luaObj.RawGet("get_ConditionInfo") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010DB4 RID: 69044 RVA: 0x0045DC9C File Offset: 0x0045BE9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobTransferConditionItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009B5F RID: 39775
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_text;

		// Token: 0x04009B60 RID: 39776
		[AutoBind("./FinishTag", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_finishTag;

		// Token: 0x04009B62 RID: 39778
		[DoNotToLua]
		private HeroJobTransferConditionItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009B63 RID: 39779
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009B64 RID: 39780
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009B65 RID: 39781
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009B66 RID: 39782
		private LuaFunction m_InitConditionItemConfigDataJobUnlockConditionInfoHeroJob_hotfix;

		// Token: 0x04009B67 RID: 39783
		private LuaFunction m_set_ConditionInfoConfigDataJobUnlockConditionInfo_hotfix;

		// Token: 0x04009B68 RID: 39784
		private LuaFunction m_get_ConditionInfo_hotfix;

		// Token: 0x02000DC9 RID: 3529
		public new class LuaExportHelper
		{
			// Token: 0x06010DB5 RID: 69045 RVA: 0x0045DD04 File Offset: 0x0045BF04
			public LuaExportHelper(HeroJobTransferConditionItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010DB6 RID: 69046 RVA: 0x0045DD14 File Offset: 0x0045BF14
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06010DB7 RID: 69047 RVA: 0x0045DD24 File Offset: 0x0045BF24
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06010DB8 RID: 69048 RVA: 0x0045DD34 File Offset: 0x0045BF34
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06010DB9 RID: 69049 RVA: 0x0045DD44 File Offset: 0x0045BF44
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06010DBA RID: 69050 RVA: 0x0045DD5C File Offset: 0x0045BF5C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06010DBB RID: 69051 RVA: 0x0045DD6C File Offset: 0x0045BF6C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06010DBC RID: 69052 RVA: 0x0045DD7C File Offset: 0x0045BF7C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06010DBD RID: 69053 RVA: 0x0045DD8C File Offset: 0x0045BF8C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06010DBE RID: 69054 RVA: 0x0045DD9C File Offset: 0x0045BF9C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06010DBF RID: 69055 RVA: 0x0045DDAC File Offset: 0x0045BFAC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06010DC0 RID: 69056 RVA: 0x0045DDBC File Offset: 0x0045BFBC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06010DC1 RID: 69057 RVA: 0x0045DDCC File Offset: 0x0045BFCC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06010DC2 RID: 69058 RVA: 0x0045DDDC File Offset: 0x0045BFDC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06010DC3 RID: 69059 RVA: 0x0045DDEC File Offset: 0x0045BFEC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06010DC4 RID: 69060 RVA: 0x0045DDFC File Offset: 0x0045BFFC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003443 RID: 13379
			// (get) Token: 0x06010DC5 RID: 69061 RVA: 0x0045DE0C File Offset: 0x0045C00C
			// (set) Token: 0x06010DC6 RID: 69062 RVA: 0x0045DE1C File Offset: 0x0045C01C
			public Text m_text
			{
				get
				{
					return this.m_owner.m_text;
				}
				set
				{
					this.m_owner.m_text = value;
				}
			}

			// Token: 0x17003444 RID: 13380
			// (get) Token: 0x06010DC7 RID: 69063 RVA: 0x0045DE2C File Offset: 0x0045C02C
			// (set) Token: 0x06010DC8 RID: 69064 RVA: 0x0045DE3C File Offset: 0x0045C03C
			public GameObject m_finishTag
			{
				get
				{
					return this.m_owner.m_finishTag;
				}
				set
				{
					this.m_owner.m_finishTag = value;
				}
			}

			// Token: 0x17003445 RID: 13381
			// (set) Token: 0x06010DC9 RID: 69065 RVA: 0x0045DE4C File Offset: 0x0045C04C
			public ConfigDataJobUnlockConditionInfo ConditionInfo
			{
				set
				{
					this.m_owner.ConditionInfo = value;
				}
			}

			// Token: 0x06010DCA RID: 69066 RVA: 0x0045DE5C File Offset: 0x0045C05C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04009B69 RID: 39785
			private HeroJobTransferConditionItemUIController m_owner;
		}
	}
}
