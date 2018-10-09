using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FF9 RID: 4089
	[HotFix]
	public class UnchartedScoreRecommendHeroListItemUIController : UIControllerBase
	{
		// Token: 0x060148EC RID: 84204 RVA: 0x00537400 File Offset: 0x00535600
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnClick));
		}

		// Token: 0x060148ED RID: 84205 RVA: 0x00537484 File Offset: 0x00535684
		public void SetHero(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroInt32_hotfix != null)
			{
				this.m_SetHeroInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroId = heroId;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataHeroInfo configDataHeroInfo = configDataLoader.GetConfigDataHeroInfo(heroId);
			if (configDataHeroInfo != null)
			{
				this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(configDataHeroInfo.m_charImageInfo.SummonHeadImage);
			}
		}

		// Token: 0x060148EE RID: 84206 RVA: 0x0053753C File Offset: 0x0053573C
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
			RewardGoodsDescUITask.StartUITask(this, GoodsType.GoodsType_Hero, this.m_heroId, 0, null, true);
		}

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x060148EF RID: 84207 RVA: 0x005375B0 File Offset: 0x005357B0
		// (set) Token: 0x060148F0 RID: 84208 RVA: 0x005375D0 File Offset: 0x005357D0
		[DoNotToLua]
		public new UnchartedScoreRecommendHeroListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UnchartedScoreRecommendHeroListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060148F1 RID: 84209 RVA: 0x005375DC File Offset: 0x005357DC
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x060148F2 RID: 84210 RVA: 0x005375E8 File Offset: 0x005357E8
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x060148F3 RID: 84211 RVA: 0x005375F0 File Offset: 0x005357F0
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x060148F4 RID: 84212 RVA: 0x005375F8 File Offset: 0x005357F8
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x060148F5 RID: 84213 RVA: 0x0053760C File Offset: 0x0053580C
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x060148F6 RID: 84214 RVA: 0x00537614 File Offset: 0x00535814
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x060148F7 RID: 84215 RVA: 0x00537620 File Offset: 0x00535820
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x060148F8 RID: 84216 RVA: 0x0053762C File Offset: 0x0053582C
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x060148F9 RID: 84217 RVA: 0x00537638 File Offset: 0x00535838
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x060148FA RID: 84218 RVA: 0x00537644 File Offset: 0x00535844
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x060148FB RID: 84219 RVA: 0x00537650 File Offset: 0x00535850
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x060148FC RID: 84220 RVA: 0x0053765C File Offset: 0x0053585C
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x060148FD RID: 84221 RVA: 0x00537668 File Offset: 0x00535868
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x060148FE RID: 84222 RVA: 0x00537674 File Offset: 0x00535874
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x060148FF RID: 84223 RVA: 0x00537680 File Offset: 0x00535880
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014900 RID: 84224 RVA: 0x00537688 File Offset: 0x00535888
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
					this.m_SetHeroInt32_hotfix = (luaObj.RawGet("SetHero") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014901 RID: 84225 RVA: 0x00537788 File Offset: 0x00535988
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreRecommendHeroListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B4BB RID: 46267
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x0400B4BC RID: 46268
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x0400B4BD RID: 46269
		private int m_heroId;

		// Token: 0x0400B4BE RID: 46270
		[DoNotToLua]
		private UnchartedScoreRecommendHeroListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B4BF RID: 46271
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B4C0 RID: 46272
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B4C1 RID: 46273
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B4C2 RID: 46274
		private LuaFunction m_SetHeroInt32_hotfix;

		// Token: 0x0400B4C3 RID: 46275
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x02000FFA RID: 4090
		public new class LuaExportHelper
		{
			// Token: 0x06014902 RID: 84226 RVA: 0x005377F0 File Offset: 0x005359F0
			public LuaExportHelper(UnchartedScoreRecommendHeroListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014903 RID: 84227 RVA: 0x00537800 File Offset: 0x00535A00
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014904 RID: 84228 RVA: 0x00537810 File Offset: 0x00535A10
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014905 RID: 84229 RVA: 0x00537820 File Offset: 0x00535A20
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014906 RID: 84230 RVA: 0x00537830 File Offset: 0x00535A30
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014907 RID: 84231 RVA: 0x00537848 File Offset: 0x00535A48
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014908 RID: 84232 RVA: 0x00537858 File Offset: 0x00535A58
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014909 RID: 84233 RVA: 0x00537868 File Offset: 0x00535A68
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601490A RID: 84234 RVA: 0x00537878 File Offset: 0x00535A78
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601490B RID: 84235 RVA: 0x00537888 File Offset: 0x00535A88
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601490C RID: 84236 RVA: 0x00537898 File Offset: 0x00535A98
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0601490D RID: 84237 RVA: 0x005378A8 File Offset: 0x00535AA8
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601490E RID: 84238 RVA: 0x005378B8 File Offset: 0x00535AB8
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601490F RID: 84239 RVA: 0x005378C8 File Offset: 0x00535AC8
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014910 RID: 84240 RVA: 0x005378D8 File Offset: 0x00535AD8
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014911 RID: 84241 RVA: 0x005378E8 File Offset: 0x00535AE8
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003CE6 RID: 15590
			// (get) Token: 0x06014912 RID: 84242 RVA: 0x005378F8 File Offset: 0x00535AF8
			// (set) Token: 0x06014913 RID: 84243 RVA: 0x00537908 File Offset: 0x00535B08
			public Button m_button
			{
				get
				{
					return this.m_owner.m_button;
				}
				set
				{
					this.m_owner.m_button = value;
				}
			}

			// Token: 0x17003CE7 RID: 15591
			// (get) Token: 0x06014914 RID: 84244 RVA: 0x00537918 File Offset: 0x00535B18
			// (set) Token: 0x06014915 RID: 84245 RVA: 0x00537928 File Offset: 0x00535B28
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

			// Token: 0x17003CE8 RID: 15592
			// (get) Token: 0x06014916 RID: 84246 RVA: 0x00537938 File Offset: 0x00535B38
			// (set) Token: 0x06014917 RID: 84247 RVA: 0x00537948 File Offset: 0x00535B48
			public int m_heroId
			{
				get
				{
					return this.m_owner.m_heroId;
				}
				set
				{
					this.m_owner.m_heroId = value;
				}
			}

			// Token: 0x06014918 RID: 84248 RVA: 0x00537958 File Offset: 0x00535B58
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014919 RID: 84249 RVA: 0x00537968 File Offset: 0x00535B68
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0400B4C4 RID: 46276
			private UnchartedScoreRecommendHeroListItemUIController m_owner;
		}
	}
}
