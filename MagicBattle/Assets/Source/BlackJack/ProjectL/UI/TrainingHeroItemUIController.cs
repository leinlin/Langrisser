using System;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C52 RID: 3154
	[HotFix]
	public class TrainingHeroItemUIController : UIControllerBase
	{
		// Token: 0x0600DF63 RID: 57187 RVA: 0x003C4D30 File Offset: 0x003C2F30
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
			base.gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OnHeroItemClick));
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600DF64 RID: 57188 RVA: 0x003C4DC4 File Offset: 0x003C2FC4
		public void InitTrainingHeroItem(Hero hero, bool isAchivementUp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTrainingHeroItemHeroBoolean_hotfix != null)
			{
				this.m_InitTrainingHeroItemHeroBoolean_hotfix.call(new object[]
				{
					this,
					hero,
					isAchivementUp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			this.m_heroLvText.text = hero.Level.ToString();
			UIUtility.SetGameObjectChildrenActiveCount(this.m_heroStar, hero.StarLevel);
			ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
			if (charImageInfo != null)
			{
				this.m_heroIconImg.sprite = AssetUtility.Instance.GetSprite(AssetUtility.MakeSpriteAssetName(charImageInfo.CardHeadImage, "_1"));
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataArmyInfo configDataArmyInfo = configDataLoader.GetConfigDataArmyInfo(hero.GetActiveJob().JobConnectionInfo.m_jobInfo.Army_ID);
			this.m_heroTypeImg.sprite = AssetUtility.Instance.GetSprite(configDataArmyInfo.Icon);
			this.m_frameImg.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetHeroItemFrameNameByRank(hero.HeroInfo.GetRank(hero.StarLevel)));
			this.m_ssrFrameEffect.SetActive(hero.HeroInfo.GetRank(hero.StarLevel) >= 4);
			this.m_achivementUpImage.SetActive(isAchivementUp);
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (!projectLPlayerContext.IsHeroAssigned(this.m_hero.HeroId))
			{
				this.m_uiStateCtrl.SetToUIState("Normal", false, true);
			}
			else
			{
				this.m_uiStateCtrl.SetToUIState("Assistant", false, true);
			}
		}

		// Token: 0x0600DF65 RID: 57189 RVA: 0x003C4FB0 File Offset: 0x003C31B0
		public void ShowSelectFrameImage(bool isShow)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowSelectFrameImageBoolean_hotfix != null)
			{
				this.m_ShowSelectFrameImageBoolean_hotfix.call(new object[]
				{
					this,
					isShow
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_selectFrameImg.SetActive(isShow);
		}

		// Token: 0x0600DF66 RID: 57190 RVA: 0x003C502C File Offset: 0x003C322C
		private void OnHeroItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeroItemClick_hotfix != null)
			{
				this.m_OnHeroItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			bool flag = projectLPlayerContext.IsHeroAssigned(this.m_hero.HeroId);
			if (flag)
			{
				CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_Msg_AlreadyInAssistant, 2f, null, true);
				return;
			}
			if (this.EventOnHeroItemClick != null)
			{
				this.EventOnHeroItemClick(this);
			}
		}

		// Token: 0x140002C7 RID: 711
		// (add) Token: 0x0600DF67 RID: 57191 RVA: 0x003C50E4 File Offset: 0x003C32E4
		// (remove) Token: 0x0600DF68 RID: 57192 RVA: 0x003C5180 File Offset: 0x003C3380
		public event Action<TrainingHeroItemUIController> EventOnHeroItemClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnHeroItemClickAction`1_hotfix != null)
				{
					this.m_add_EventOnHeroItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TrainingHeroItemUIController> action = this.EventOnHeroItemClick;
				Action<TrainingHeroItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TrainingHeroItemUIController>>(ref this.EventOnHeroItemClick, (Action<TrainingHeroItemUIController>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnHeroItemClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnHeroItemClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<TrainingHeroItemUIController> action = this.EventOnHeroItemClick;
				Action<TrainingHeroItemUIController> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<TrainingHeroItemUIController>>(ref this.EventOnHeroItemClick, (Action<TrainingHeroItemUIController>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x0600DF69 RID: 57193 RVA: 0x003C521C File Offset: 0x003C341C
		// (set) Token: 0x0600DF6A RID: 57194 RVA: 0x003C523C File Offset: 0x003C343C
		[DoNotToLua]
		public new TrainingHeroItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TrainingHeroItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600DF6B RID: 57195 RVA: 0x003C5248 File Offset: 0x003C3448
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600DF6C RID: 57196 RVA: 0x003C5254 File Offset: 0x003C3454
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600DF6D RID: 57197 RVA: 0x003C525C File Offset: 0x003C345C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600DF6E RID: 57198 RVA: 0x003C5264 File Offset: 0x003C3464
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600DF6F RID: 57199 RVA: 0x003C5278 File Offset: 0x003C3478
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600DF70 RID: 57200 RVA: 0x003C5280 File Offset: 0x003C3480
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600DF71 RID: 57201 RVA: 0x003C528C File Offset: 0x003C348C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600DF72 RID: 57202 RVA: 0x003C5298 File Offset: 0x003C3498
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600DF73 RID: 57203 RVA: 0x003C52A4 File Offset: 0x003C34A4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600DF74 RID: 57204 RVA: 0x003C52B0 File Offset: 0x003C34B0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600DF75 RID: 57205 RVA: 0x003C52BC File Offset: 0x003C34BC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600DF76 RID: 57206 RVA: 0x003C52C8 File Offset: 0x003C34C8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600DF77 RID: 57207 RVA: 0x003C52D4 File Offset: 0x003C34D4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600DF78 RID: 57208 RVA: 0x003C52E0 File Offset: 0x003C34E0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600DF79 RID: 57209 RVA: 0x003C52EC File Offset: 0x003C34EC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600DF7A RID: 57210 RVA: 0x003C52F4 File Offset: 0x003C34F4
		private void __callDele_EventOnHeroItemClick(TrainingHeroItemUIController obj)
		{
			Action<TrainingHeroItemUIController> eventOnHeroItemClick = this.EventOnHeroItemClick;
			if (eventOnHeroItemClick != null)
			{
				eventOnHeroItemClick(obj);
			}
		}

		// Token: 0x0600DF7B RID: 57211 RVA: 0x003C5318 File Offset: 0x003C3518
		private void __clearDele_EventOnHeroItemClick(TrainingHeroItemUIController obj)
		{
			this.EventOnHeroItemClick = null;
		}

		// Token: 0x0600DF7C RID: 57212 RVA: 0x003C5324 File Offset: 0x003C3524
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
					this.m_InitTrainingHeroItemHeroBoolean_hotfix = (luaObj.RawGet("InitTrainingHeroItem") as LuaFunction);
					this.m_ShowSelectFrameImageBoolean_hotfix = (luaObj.RawGet("ShowSelectFrameImage") as LuaFunction);
					this.m_OnHeroItemClick_hotfix = (luaObj.RawGet("OnHeroItemClick") as LuaFunction);
					this.m_add_EventOnHeroItemClickAction`1_hotfix = (luaObj.RawGet("add_EventOnHeroItemClick") as LuaFunction);
					this.m_remove_EventOnHeroItemClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnHeroItemClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600DF7D RID: 57213 RVA: 0x003C546C File Offset: 0x003C366C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TrainingHeroItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008801 RID: 34817
		[AutoBind("./SelectImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_selectFrameImg;

		// Token: 0x04008802 RID: 34818
		[AutoBind("./HeroStars", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroStar;

		// Token: 0x04008803 RID: 34819
		[AutoBind("./JobTypeImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroTypeImg;

		// Token: 0x04008804 RID: 34820
		[AutoBind("./HeroLvText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroLvText;

		// Token: 0x04008805 RID: 34821
		[AutoBind("./SSRFrameEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_ssrFrameEffect;

		// Token: 0x04008806 RID: 34822
		[AutoBind("./FrameImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_frameImg;

		// Token: 0x04008807 RID: 34823
		[AutoBind("./CharImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroIconImg;

		// Token: 0x04008808 RID: 34824
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateCtrl;

		// Token: 0x04008809 RID: 34825
		[AutoBind("./AchivementUpImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_achivementUpImage;

		// Token: 0x0400880A RID: 34826
		public Hero m_hero;

		// Token: 0x0400880B RID: 34827
		[DoNotToLua]
		private TrainingHeroItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400880C RID: 34828
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400880D RID: 34829
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400880E RID: 34830
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400880F RID: 34831
		private LuaFunction m_InitTrainingHeroItemHeroBoolean_hotfix;

		// Token: 0x04008810 RID: 34832
		private LuaFunction m_ShowSelectFrameImageBoolean_hotfix;

		// Token: 0x04008811 RID: 34833
		private LuaFunction m_OnHeroItemClick_hotfix;

		// Token: 0x04008812 RID: 34834
		private LuaFunction m_add_EventOnHeroItemClickAction;

		// Token: 0x04008813 RID: 34835
		private LuaFunction m_remove_EventOnHeroItemClickAction;

		// Token: 0x02000C53 RID: 3155
		public new class LuaExportHelper
		{
			// Token: 0x0600DF7E RID: 57214 RVA: 0x003C54D4 File Offset: 0x003C36D4
			public LuaExportHelper(TrainingHeroItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600DF7F RID: 57215 RVA: 0x003C54E4 File Offset: 0x003C36E4
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600DF80 RID: 57216 RVA: 0x003C54F4 File Offset: 0x003C36F4
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600DF81 RID: 57217 RVA: 0x003C5504 File Offset: 0x003C3704
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600DF82 RID: 57218 RVA: 0x003C5514 File Offset: 0x003C3714
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600DF83 RID: 57219 RVA: 0x003C552C File Offset: 0x003C372C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600DF84 RID: 57220 RVA: 0x003C553C File Offset: 0x003C373C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600DF85 RID: 57221 RVA: 0x003C554C File Offset: 0x003C374C
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600DF86 RID: 57222 RVA: 0x003C555C File Offset: 0x003C375C
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600DF87 RID: 57223 RVA: 0x003C556C File Offset: 0x003C376C
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600DF88 RID: 57224 RVA: 0x003C557C File Offset: 0x003C377C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600DF89 RID: 57225 RVA: 0x003C558C File Offset: 0x003C378C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600DF8A RID: 57226 RVA: 0x003C559C File Offset: 0x003C379C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600DF8B RID: 57227 RVA: 0x003C55AC File Offset: 0x003C37AC
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600DF8C RID: 57228 RVA: 0x003C55BC File Offset: 0x003C37BC
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600DF8D RID: 57229 RVA: 0x003C55CC File Offset: 0x003C37CC
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600DF8E RID: 57230 RVA: 0x003C55DC File Offset: 0x003C37DC
			public void __callDele_EventOnHeroItemClick(TrainingHeroItemUIController obj)
			{
				this.m_owner.__callDele_EventOnHeroItemClick(obj);
			}

			// Token: 0x0600DF8F RID: 57231 RVA: 0x003C55EC File Offset: 0x003C37EC
			public void __clearDele_EventOnHeroItemClick(TrainingHeroItemUIController obj)
			{
				this.m_owner.__clearDele_EventOnHeroItemClick(obj);
			}

			// Token: 0x17002B6A RID: 11114
			// (get) Token: 0x0600DF90 RID: 57232 RVA: 0x003C55FC File Offset: 0x003C37FC
			// (set) Token: 0x0600DF91 RID: 57233 RVA: 0x003C560C File Offset: 0x003C380C
			public GameObject m_selectFrameImg
			{
				get
				{
					return this.m_owner.m_selectFrameImg;
				}
				set
				{
					this.m_owner.m_selectFrameImg = value;
				}
			}

			// Token: 0x17002B6B RID: 11115
			// (get) Token: 0x0600DF92 RID: 57234 RVA: 0x003C561C File Offset: 0x003C381C
			// (set) Token: 0x0600DF93 RID: 57235 RVA: 0x003C562C File Offset: 0x003C382C
			public GameObject m_heroStar
			{
				get
				{
					return this.m_owner.m_heroStar;
				}
				set
				{
					this.m_owner.m_heroStar = value;
				}
			}

			// Token: 0x17002B6C RID: 11116
			// (get) Token: 0x0600DF94 RID: 57236 RVA: 0x003C563C File Offset: 0x003C383C
			// (set) Token: 0x0600DF95 RID: 57237 RVA: 0x003C564C File Offset: 0x003C384C
			public Image m_heroTypeImg
			{
				get
				{
					return this.m_owner.m_heroTypeImg;
				}
				set
				{
					this.m_owner.m_heroTypeImg = value;
				}
			}

			// Token: 0x17002B6D RID: 11117
			// (get) Token: 0x0600DF96 RID: 57238 RVA: 0x003C565C File Offset: 0x003C385C
			// (set) Token: 0x0600DF97 RID: 57239 RVA: 0x003C566C File Offset: 0x003C386C
			public Text m_heroLvText
			{
				get
				{
					return this.m_owner.m_heroLvText;
				}
				set
				{
					this.m_owner.m_heroLvText = value;
				}
			}

			// Token: 0x17002B6E RID: 11118
			// (get) Token: 0x0600DF98 RID: 57240 RVA: 0x003C567C File Offset: 0x003C387C
			// (set) Token: 0x0600DF99 RID: 57241 RVA: 0x003C568C File Offset: 0x003C388C
			public GameObject m_ssrFrameEffect
			{
				get
				{
					return this.m_owner.m_ssrFrameEffect;
				}
				set
				{
					this.m_owner.m_ssrFrameEffect = value;
				}
			}

			// Token: 0x17002B6F RID: 11119
			// (get) Token: 0x0600DF9A RID: 57242 RVA: 0x003C569C File Offset: 0x003C389C
			// (set) Token: 0x0600DF9B RID: 57243 RVA: 0x003C56AC File Offset: 0x003C38AC
			public Image m_frameImg
			{
				get
				{
					return this.m_owner.m_frameImg;
				}
				set
				{
					this.m_owner.m_frameImg = value;
				}
			}

			// Token: 0x17002B70 RID: 11120
			// (get) Token: 0x0600DF9C RID: 57244 RVA: 0x003C56BC File Offset: 0x003C38BC
			// (set) Token: 0x0600DF9D RID: 57245 RVA: 0x003C56CC File Offset: 0x003C38CC
			public Image m_heroIconImg
			{
				get
				{
					return this.m_owner.m_heroIconImg;
				}
				set
				{
					this.m_owner.m_heroIconImg = value;
				}
			}

			// Token: 0x17002B71 RID: 11121
			// (get) Token: 0x0600DF9E RID: 57246 RVA: 0x003C56DC File Offset: 0x003C38DC
			// (set) Token: 0x0600DF9F RID: 57247 RVA: 0x003C56EC File Offset: 0x003C38EC
			public CommonUIStateController m_uiStateCtrl
			{
				get
				{
					return this.m_owner.m_uiStateCtrl;
				}
				set
				{
					this.m_owner.m_uiStateCtrl = value;
				}
			}

			// Token: 0x17002B72 RID: 11122
			// (get) Token: 0x0600DFA0 RID: 57248 RVA: 0x003C56FC File Offset: 0x003C38FC
			// (set) Token: 0x0600DFA1 RID: 57249 RVA: 0x003C570C File Offset: 0x003C390C
			public GameObject m_achivementUpImage
			{
				get
				{
					return this.m_owner.m_achivementUpImage;
				}
				set
				{
					this.m_owner.m_achivementUpImage = value;
				}
			}

			// Token: 0x0600DFA2 RID: 57250 RVA: 0x003C571C File Offset: 0x003C391C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600DFA3 RID: 57251 RVA: 0x003C572C File Offset: 0x003C392C
			public void OnHeroItemClick()
			{
				this.m_owner.OnHeroItemClick();
			}

			// Token: 0x04008814 RID: 34836
			private TrainingHeroItemUIController m_owner;
		}
	}
}
