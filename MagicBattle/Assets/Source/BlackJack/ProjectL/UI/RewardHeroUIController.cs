using System;
using System.Collections;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000ABB RID: 2747
	[HotFix]
	public class RewardHeroUIController : UIControllerBase
	{
		// Token: 0x0600B12E RID: 45358 RVA: 0x003115EC File Offset: 0x0030F7EC
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
		}

		// Token: 0x0600B12F RID: 45359 RVA: 0x00311654 File Offset: 0x0030F854
		public void SetHero(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroHero_hotfix != null)
			{
				this.m_SetHeroHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (hero == null)
			{
				return;
			}
			this.m_hero = hero;
			ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
			if (charImageInfo != null)
			{
				this.m_iconImage.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_0"));
			}
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x00311710 File Offset: 0x0030F910
		public void SetExp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetExp_hotfix != null)
			{
				this.m_SetExp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_expText.text = "+0";
			base.StartCoroutine(this.AddExpBarWidth(2f));
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x00311794 File Offset: 0x0030F994
		[DebuggerHidden]
		private IEnumerator AddExpBarWidth(float intervalTime = 2f)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddExpBarWidthSingle_hotfix != null)
			{
				return (IEnumerator)this.m_AddExpBarWidthSingle_hotfix.call(new object[]
				{
					this,
					intervalTime
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RewardHeroUIController.<AddExpBarWidth>c__Iterator0 <AddExpBarWidth>c__Iterator = new RewardHeroUIController.<AddExpBarWidth>c__Iterator0();
			<AddExpBarWidth>c__Iterator.intervalTime = intervalTime;
			<AddExpBarWidth>c__Iterator.$this = this;
			return <AddExpBarWidth>c__Iterator;
		}

		// Token: 0x0600B132 RID: 45362 RVA: 0x00311828 File Offset: 0x0030FA28
		private void UpdateTextValue()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateTextValue_hotfix != null)
			{
				this.m_UpdateTextValue_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			float num = this.m_beforeHeroExp + this.m_singleAddExp;
			if (num >= (float)this.m_finalHeroExp)
			{
				this.m_expText.text = "+" + this.m_finalHeroExp;
				return;
			}
			if (Math.Ceiling((double)this.m_beforeHeroExp) != Math.Ceiling((double)num))
			{
				this.m_expText.text = "+" + Math.Ceiling((double)num);
			}
			this.m_beforeHeroExp = num;
		}

		// Token: 0x0600B133 RID: 45363 RVA: 0x00311904 File Offset: 0x0030FB04
		public void SetLevel(int level)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLevelInt32_hotfix != null)
			{
				this.m_SetLevelInt32_hotfix.call(new object[]
				{
					this,
					level
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_levelText.text = level.ToString();
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x0600B134 RID: 45364 RVA: 0x0031198C File Offset: 0x0030FB8C
		// (set) Token: 0x0600B135 RID: 45365 RVA: 0x003119AC File Offset: 0x0030FBAC
		[DoNotToLua]
		public new RewardHeroUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new RewardHeroUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B136 RID: 45366 RVA: 0x003119B8 File Offset: 0x0030FBB8
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x003119C4 File Offset: 0x0030FBC4
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600B138 RID: 45368 RVA: 0x003119CC File Offset: 0x0030FBCC
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600B139 RID: 45369 RVA: 0x003119D4 File Offset: 0x0030FBD4
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600B13A RID: 45370 RVA: 0x003119E8 File Offset: 0x0030FBE8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600B13B RID: 45371 RVA: 0x003119F0 File Offset: 0x0030FBF0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600B13C RID: 45372 RVA: 0x003119FC File Offset: 0x0030FBFC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600B13D RID: 45373 RVA: 0x00311A08 File Offset: 0x0030FC08
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600B13E RID: 45374 RVA: 0x00311A14 File Offset: 0x0030FC14
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x00311A20 File Offset: 0x0030FC20
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x00311A2C File Offset: 0x0030FC2C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600B141 RID: 45377 RVA: 0x00311A38 File Offset: 0x0030FC38
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600B142 RID: 45378 RVA: 0x00311A44 File Offset: 0x0030FC44
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600B143 RID: 45379 RVA: 0x00311A50 File Offset: 0x0030FC50
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600B144 RID: 45380 RVA: 0x00311A5C File Offset: 0x0030FC5C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600B145 RID: 45381 RVA: 0x00311A64 File Offset: 0x0030FC64
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
					this.m_SetHeroHero_hotfix = (luaObj.RawGet("SetHero") as LuaFunction);
					this.m_SetExp_hotfix = (luaObj.RawGet("SetExp") as LuaFunction);
					this.m_AddExpBarWidthSingle_hotfix = (luaObj.RawGet("AddExpBarWidth") as LuaFunction);
					this.m_UpdateTextValue_hotfix = (luaObj.RawGet("UpdateTextValue") as LuaFunction);
					this.m_SetLevelInt32_hotfix = (luaObj.RawGet("SetLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B146 RID: 45382 RVA: 0x00311BAC File Offset: 0x0030FDAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RewardHeroUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007358 RID: 29528
		[AutoBind("./IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_iconImage;

		// Token: 0x04007359 RID: 29529
		[AutoBind("./LvNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_levelText;

		// Token: 0x0400735A RID: 29530
		[AutoBind("./EXPNumberText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_expText;

		// Token: 0x0400735B RID: 29531
		[AutoBind("./ExpProgressBar", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_expImage;

		// Token: 0x0400735C RID: 29532
		[AutoBind("./LevelUpEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_levelUpGameObject;

		// Token: 0x0400735D RID: 29533
		[AutoBind("./EffectRoot", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_effectRoot;

		// Token: 0x0400735E RID: 29534
		private float m_heroExpTotalWidth;

		// Token: 0x0400735F RID: 29535
		private Hero m_hero;

		// Token: 0x04007360 RID: 29536
		private float m_singleAddExp;

		// Token: 0x04007361 RID: 29537
		private float m_beforeHeroExp;

		// Token: 0x04007362 RID: 29538
		private int m_finalHeroExp;

		// Token: 0x04007363 RID: 29539
		[DoNotToLua]
		private RewardHeroUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007364 RID: 29540
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007365 RID: 29541
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007366 RID: 29542
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04007367 RID: 29543
		private LuaFunction m_SetHeroHero_hotfix;

		// Token: 0x04007368 RID: 29544
		private LuaFunction m_SetExp_hotfix;

		// Token: 0x04007369 RID: 29545
		private LuaFunction m_AddExpBarWidthSingle_hotfix;

		// Token: 0x0400736A RID: 29546
		private LuaFunction m_UpdateTextValue_hotfix;

		// Token: 0x0400736B RID: 29547
		private LuaFunction m_SetLevelInt32_hotfix;

		// Token: 0x02000ABC RID: 2748
		public new class LuaExportHelper
		{
			// Token: 0x0600B147 RID: 45383 RVA: 0x00311C14 File Offset: 0x0030FE14
			public LuaExportHelper(RewardHeroUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B148 RID: 45384 RVA: 0x00311C24 File Offset: 0x0030FE24
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600B149 RID: 45385 RVA: 0x00311C34 File Offset: 0x0030FE34
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600B14A RID: 45386 RVA: 0x00311C44 File Offset: 0x0030FE44
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600B14B RID: 45387 RVA: 0x00311C54 File Offset: 0x0030FE54
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600B14C RID: 45388 RVA: 0x00311C6C File Offset: 0x0030FE6C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600B14D RID: 45389 RVA: 0x00311C7C File Offset: 0x0030FE7C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600B14E RID: 45390 RVA: 0x00311C8C File Offset: 0x0030FE8C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600B14F RID: 45391 RVA: 0x00311C9C File Offset: 0x0030FE9C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600B150 RID: 45392 RVA: 0x00311CAC File Offset: 0x0030FEAC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600B151 RID: 45393 RVA: 0x00311CBC File Offset: 0x0030FEBC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600B152 RID: 45394 RVA: 0x00311CCC File Offset: 0x0030FECC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600B153 RID: 45395 RVA: 0x00311CDC File Offset: 0x0030FEDC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600B154 RID: 45396 RVA: 0x00311CEC File Offset: 0x0030FEEC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600B155 RID: 45397 RVA: 0x00311CFC File Offset: 0x0030FEFC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600B156 RID: 45398 RVA: 0x00311D0C File Offset: 0x0030FF0C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170023EB RID: 9195
			// (get) Token: 0x0600B157 RID: 45399 RVA: 0x00311D1C File Offset: 0x0030FF1C
			// (set) Token: 0x0600B158 RID: 45400 RVA: 0x00311D2C File Offset: 0x0030FF2C
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

			// Token: 0x170023EC RID: 9196
			// (get) Token: 0x0600B159 RID: 45401 RVA: 0x00311D3C File Offset: 0x0030FF3C
			// (set) Token: 0x0600B15A RID: 45402 RVA: 0x00311D4C File Offset: 0x0030FF4C
			public Text m_levelText
			{
				get
				{
					return this.m_owner.m_levelText;
				}
				set
				{
					this.m_owner.m_levelText = value;
				}
			}

			// Token: 0x170023ED RID: 9197
			// (get) Token: 0x0600B15B RID: 45403 RVA: 0x00311D5C File Offset: 0x0030FF5C
			// (set) Token: 0x0600B15C RID: 45404 RVA: 0x00311D6C File Offset: 0x0030FF6C
			public Text m_expText
			{
				get
				{
					return this.m_owner.m_expText;
				}
				set
				{
					this.m_owner.m_expText = value;
				}
			}

			// Token: 0x170023EE RID: 9198
			// (get) Token: 0x0600B15D RID: 45405 RVA: 0x00311D7C File Offset: 0x0030FF7C
			// (set) Token: 0x0600B15E RID: 45406 RVA: 0x00311D8C File Offset: 0x0030FF8C
			public Image m_expImage
			{
				get
				{
					return this.m_owner.m_expImage;
				}
				set
				{
					this.m_owner.m_expImage = value;
				}
			}

			// Token: 0x170023EF RID: 9199
			// (get) Token: 0x0600B15F RID: 45407 RVA: 0x00311D9C File Offset: 0x0030FF9C
			// (set) Token: 0x0600B160 RID: 45408 RVA: 0x00311DAC File Offset: 0x0030FFAC
			public GameObject m_levelUpGameObject
			{
				get
				{
					return this.m_owner.m_levelUpGameObject;
				}
				set
				{
					this.m_owner.m_levelUpGameObject = value;
				}
			}

			// Token: 0x170023F0 RID: 9200
			// (get) Token: 0x0600B161 RID: 45409 RVA: 0x00311DBC File Offset: 0x0030FFBC
			// (set) Token: 0x0600B162 RID: 45410 RVA: 0x00311DCC File Offset: 0x0030FFCC
			public GameObject m_effectRoot
			{
				get
				{
					return this.m_owner.m_effectRoot;
				}
				set
				{
					this.m_owner.m_effectRoot = value;
				}
			}

			// Token: 0x170023F1 RID: 9201
			// (get) Token: 0x0600B163 RID: 45411 RVA: 0x00311DDC File Offset: 0x0030FFDC
			// (set) Token: 0x0600B164 RID: 45412 RVA: 0x00311DEC File Offset: 0x0030FFEC
			public float m_heroExpTotalWidth
			{
				get
				{
					return this.m_owner.m_heroExpTotalWidth;
				}
				set
				{
					this.m_owner.m_heroExpTotalWidth = value;
				}
			}

			// Token: 0x170023F2 RID: 9202
			// (get) Token: 0x0600B165 RID: 45413 RVA: 0x00311DFC File Offset: 0x0030FFFC
			// (set) Token: 0x0600B166 RID: 45414 RVA: 0x00311E0C File Offset: 0x0031000C
			public Hero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x170023F3 RID: 9203
			// (get) Token: 0x0600B167 RID: 45415 RVA: 0x00311E1C File Offset: 0x0031001C
			// (set) Token: 0x0600B168 RID: 45416 RVA: 0x00311E2C File Offset: 0x0031002C
			public float m_singleAddExp
			{
				get
				{
					return this.m_owner.m_singleAddExp;
				}
				set
				{
					this.m_owner.m_singleAddExp = value;
				}
			}

			// Token: 0x170023F4 RID: 9204
			// (get) Token: 0x0600B169 RID: 45417 RVA: 0x00311E3C File Offset: 0x0031003C
			// (set) Token: 0x0600B16A RID: 45418 RVA: 0x00311E4C File Offset: 0x0031004C
			public float m_beforeHeroExp
			{
				get
				{
					return this.m_owner.m_beforeHeroExp;
				}
				set
				{
					this.m_owner.m_beforeHeroExp = value;
				}
			}

			// Token: 0x170023F5 RID: 9205
			// (get) Token: 0x0600B16B RID: 45419 RVA: 0x00311E5C File Offset: 0x0031005C
			// (set) Token: 0x0600B16C RID: 45420 RVA: 0x00311E6C File Offset: 0x0031006C
			public int m_finalHeroExp
			{
				get
				{
					return this.m_owner.m_finalHeroExp;
				}
				set
				{
					this.m_owner.m_finalHeroExp = value;
				}
			}

			// Token: 0x0600B16D RID: 45421 RVA: 0x00311E7C File Offset: 0x0031007C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600B16E RID: 45422 RVA: 0x00311E8C File Offset: 0x0031008C
			public IEnumerator AddExpBarWidth(float intervalTime)
			{
				return this.m_owner.AddExpBarWidth(intervalTime);
			}

			// Token: 0x0600B16F RID: 45423 RVA: 0x00311E9C File Offset: 0x0031009C
			public void UpdateTextValue()
			{
				this.m_owner.UpdateTextValue();
			}

			// Token: 0x0400736C RID: 29548
			private RewardHeroUIController m_owner;
		}
	}
}
