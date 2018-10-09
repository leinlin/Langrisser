using System;
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
	// Token: 0x02000E0E RID: 3598
	[HotFix]
	public class HeroSkinJobUIController : UIControllerBase
	{
		// Token: 0x0601143B RID: 70715 RVA: 0x0047AC08 File Offset: 0x00478E08
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

		// Token: 0x0601143C RID: 70716 RVA: 0x0047AC7C File Offset: 0x00478E7C
		public void InitHeroSkinJobItem(ConfigDataJobConnectionInfo jobConnectionInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitHeroSkinJobItemConfigDataJobConnectionInfo_hotfix != null)
			{
				this.m_InitHeroSkinJobItemConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					jobConnectionInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nameText.text = jobConnectionInfo.m_jobInfo.Name;
			this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(jobConnectionInfo.m_jobInfo.JobIcon);
		}

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x0601143D RID: 70717 RVA: 0x0047AD24 File Offset: 0x00478F24
		// (set) Token: 0x0601143E RID: 70718 RVA: 0x0047AD44 File Offset: 0x00478F44
		[DoNotToLua]
		public new HeroSkinJobUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroSkinJobUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601143F RID: 70719 RVA: 0x0047AD50 File Offset: 0x00478F50
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06011440 RID: 70720 RVA: 0x0047AD5C File Offset: 0x00478F5C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06011441 RID: 70721 RVA: 0x0047AD64 File Offset: 0x00478F64
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06011442 RID: 70722 RVA: 0x0047AD6C File Offset: 0x00478F6C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06011443 RID: 70723 RVA: 0x0047AD80 File Offset: 0x00478F80
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06011444 RID: 70724 RVA: 0x0047AD88 File Offset: 0x00478F88
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06011445 RID: 70725 RVA: 0x0047AD94 File Offset: 0x00478F94
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06011446 RID: 70726 RVA: 0x0047ADA0 File Offset: 0x00478FA0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06011447 RID: 70727 RVA: 0x0047ADAC File Offset: 0x00478FAC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06011448 RID: 70728 RVA: 0x0047ADB8 File Offset: 0x00478FB8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06011449 RID: 70729 RVA: 0x0047ADC4 File Offset: 0x00478FC4
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601144A RID: 70730 RVA: 0x0047ADD0 File Offset: 0x00478FD0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0601144B RID: 70731 RVA: 0x0047ADDC File Offset: 0x00478FDC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0601144C RID: 70732 RVA: 0x0047ADE8 File Offset: 0x00478FE8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0601144D RID: 70733 RVA: 0x0047ADF4 File Offset: 0x00478FF4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0601144E RID: 70734 RVA: 0x0047ADFC File Offset: 0x00478FFC
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
					this.m_InitHeroSkinJobItemConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("InitHeroSkinJobItem") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601144F RID: 70735 RVA: 0x0047AEE0 File Offset: 0x004790E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroSkinJobUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009E60 RID: 40544
		[AutoBind("./Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04009E61 RID: 40545
		[AutoBind("./Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x04009E62 RID: 40546
		[DoNotToLua]
		private HeroSkinJobUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04009E63 RID: 40547
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009E64 RID: 40548
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009E65 RID: 40549
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04009E66 RID: 40550
		private LuaFunction m_InitHeroSkinJobItemConfigDataJobConnectionInfo_hotfix;

		// Token: 0x02000E0F RID: 3599
		public new class LuaExportHelper
		{
			// Token: 0x06011450 RID: 70736 RVA: 0x0047AF48 File Offset: 0x00479148
			public LuaExportHelper(HeroSkinJobUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011451 RID: 70737 RVA: 0x0047AF58 File Offset: 0x00479158
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06011452 RID: 70738 RVA: 0x0047AF68 File Offset: 0x00479168
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06011453 RID: 70739 RVA: 0x0047AF78 File Offset: 0x00479178
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06011454 RID: 70740 RVA: 0x0047AF88 File Offset: 0x00479188
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06011455 RID: 70741 RVA: 0x0047AFA0 File Offset: 0x004791A0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06011456 RID: 70742 RVA: 0x0047AFB0 File Offset: 0x004791B0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06011457 RID: 70743 RVA: 0x0047AFC0 File Offset: 0x004791C0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06011458 RID: 70744 RVA: 0x0047AFD0 File Offset: 0x004791D0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06011459 RID: 70745 RVA: 0x0047AFE0 File Offset: 0x004791E0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601145A RID: 70746 RVA: 0x0047AFF0 File Offset: 0x004791F0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601145B RID: 70747 RVA: 0x0047B000 File Offset: 0x00479200
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601145C RID: 70748 RVA: 0x0047B010 File Offset: 0x00479210
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601145D RID: 70749 RVA: 0x0047B020 File Offset: 0x00479220
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601145E RID: 70750 RVA: 0x0047B030 File Offset: 0x00479230
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601145F RID: 70751 RVA: 0x0047B040 File Offset: 0x00479240
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x1700353D RID: 13629
			// (get) Token: 0x06011460 RID: 70752 RVA: 0x0047B050 File Offset: 0x00479250
			// (set) Token: 0x06011461 RID: 70753 RVA: 0x0047B060 File Offset: 0x00479260
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

			// Token: 0x1700353E RID: 13630
			// (get) Token: 0x06011462 RID: 70754 RVA: 0x0047B070 File Offset: 0x00479270
			// (set) Token: 0x06011463 RID: 70755 RVA: 0x0047B080 File Offset: 0x00479280
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

			// Token: 0x06011464 RID: 70756 RVA: 0x0047B090 File Offset: 0x00479290
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04009E67 RID: 40551
			private HeroSkinJobUIController m_owner;
		}
	}
}
