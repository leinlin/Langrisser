using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000EFC RID: 3836
	[HotFix]
	public class HeroSimpleItemInfoUIController : UIControllerBase
	{
		// Token: 0x06012F90 RID: 77712 RVA: 0x004D93EC File Offset: 0x004D75EC
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

		// Token: 0x06012F91 RID: 77713 RVA: 0x004D9460 File Offset: 0x004D7660
		public void InitHeroSimpleItemInfo(Hero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitHeroSimpleItemInfoHero_hotfix != null)
			{
				this.m_InitHeroSimpleItemInfoHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
		}

		// Token: 0x06012F92 RID: 77714 RVA: 0x004D94D8 File Offset: 0x004D76D8
		private void SetValues()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetValues_hotfix != null)
			{
				this.m_SetValues_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroNameText.text = this.m_hero.HeroInfo.Name;
			this.m_heroJobText.text = this.m_hero.HeroInfo.m_jobConnectionInfo.m_jobInfo.Name;
			this.m_armyImage.sprite = AssetUtility.Instance.GetSprite(this.m_hero.HeroInfo.m_jobConnectionInfo.m_jobInfo.m_armyInfo.Icon);
			this.m_armyText.text = this.m_hero.HeroInfo.m_jobConnectionInfo.m_jobInfo.m_armyInfo.Name;
			UIUtility.SetGameObjectChildrenActiveCount(this.m_heroStars, this.m_hero.Level);
			char[] array = this.m_hero.GetActiveJob().JobConnectionInfo.PropertyRating.ToCharArray();
			List<Image> list = new List<Image>();
			list.Add(this.m_heroHPImage);
			list.Add(this.m_heroATImage);
			list.Add(this.m_heroMagicImage);
			list.Add(this.m_heroDFImage);
			list.Add(this.m_heroMagicDFImage);
			list.Add(this.m_heroDEXImage);
			for (int i = 0; i < array.Length; i++)
			{
				string propertyRatingImageName = UIUtility.GetPropertyRatingImageName(array[i]);
				list[i].sprite = AssetUtility.Instance.GetSprite(propertyRatingImageName);
			}
			ConfigDataSkillInfo talentSkillInfo = this.m_hero.GetActiveJob().JobConnectionInfo.GetTalentSkillInfo(this.m_hero.StarLevel);
			if (talentSkillInfo != null)
			{
				this.m_talentIconImg.sprite = AssetUtility.Instance.GetSprite(talentSkillInfo.Icon);
				this.m_talentNameText.text = talentSkillInfo.Name;
				this.m_talentDescText.text = talentSkillInfo.Desc;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			List<ConfigDataJobConnectionInfo> list2 = new List<ConfigDataJobConnectionInfo>();
			foreach (int key in this.m_hero.HeroInfo.UseableJobConnections_ID)
			{
				ConfigDataJobConnectionInfo configDataJobConnectionInfo = configDataLoader.GetConfigDataJobConnectionInfo(key);
				ConfigDataJobInfo jobInfo = configDataJobConnectionInfo.m_jobInfo;
				if (jobInfo.Rank == 4)
				{
					list2.Add(configDataJobConnectionInfo);
				}
			}
			ConfigDataJobInfo jobInfo2 = list2[0].m_jobInfo;
			this.m_finalJob1CHNameText.text = jobInfo2.Name;
			this.m_finalJob1ENNameText.text = jobInfo2.Name_Eng;
			this.CreateSpineGraphic(list2[0], ref this.m_heroJobGraphic1, this.m_finalJob1GraphicObj);
			if (list2.Count == 2)
			{
				ConfigDataJobInfo jobInfo3 = list2[1].m_jobInfo;
				this.m_finalJob2Obj.SetActive(true);
				this.m_finalJob2CHNameText.text = jobInfo3.Name;
				this.m_finalJob2ENNameText.text = jobInfo3.Name_Eng;
				this.CreateSpineGraphic(list2[0], ref this.m_heroJobGraphic2, this.m_finalJob2GraphicObj);
			}
			else
			{
				this.m_finalJob2Obj.SetActive(false);
			}
		}

		// Token: 0x06012F93 RID: 77715 RVA: 0x004D984C File Offset: 0x004D7A4C
		private void CreateSpineGraphic(ConfigDataJobConnectionInfo jobConnectionInfo, ref UISpineGraphic m_graphic, GameObject m_grapgicObj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateSpineGraphicConfigDataJobConnectionInfoUISpineGraphic_GameObject_hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController_CreateSpineGraphic_ConfigDataJobConnectionInfo_UISpineGraphic_GameObject(this, this.m_CreateSpineGraphicConfigDataJobConnectionInfoUISpineGraphic_GameObject_hotfix, jobConnectionInfo, ref m_graphic, m_grapgicObj);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroySpineGraphic(ref m_graphic);
			if (jobConnectionInfo == null)
			{
				return;
			}
			m_graphic = new UISpineGraphic();
			float num = (float)jobConnectionInfo.UI_ModelScale * 0.01f;
			Vector2 position = new Vector2((float)jobConnectionInfo.UI_ModelOffsetX, (float)jobConnectionInfo.UI_ModelOffsetY);
			m_graphic.Create(jobConnectionInfo.Model);
			m_graphic.SetParent(m_grapgicObj);
			m_graphic.SetDirection(1);
			m_graphic.SetPosition(position);
			m_graphic.SetScale(num);
			m_graphic.SetRectTransformSize(new Vector2(500f / num, 500f / num));
			m_graphic.SetReplaceAnimations(jobConnectionInfo.ReplaceAnims);
			m_graphic.PlayAnimation("idle", true, 0);
			m_graphic.ForceUpdate();
		}

		// Token: 0x06012F94 RID: 77716 RVA: 0x004D9944 File Offset: 0x004D7B44
		private void DestroySpineGraphic(ref UISpineGraphic m_graphic)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroySpineGraphicUISpineGraphic__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController_DestroySpineGraphic_UISpineGraphic(this, this.m_DestroySpineGraphicUISpineGraphic__hotfix, ref m_graphic);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (m_graphic != null)
			{
				m_graphic.Destroy();
				m_graphic = null;
			}
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x06012F95 RID: 77717 RVA: 0x004D99A8 File Offset: 0x004D7BA8
		// (set) Token: 0x06012F96 RID: 77718 RVA: 0x004D99C8 File Offset: 0x004D7BC8
		[DoNotToLua]
		public new HeroSimpleItemInfoUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroSimpleItemInfoUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06012F97 RID: 77719 RVA: 0x004D99D4 File Offset: 0x004D7BD4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06012F98 RID: 77720 RVA: 0x004D99E0 File Offset: 0x004D7BE0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06012F99 RID: 77721 RVA: 0x004D99E8 File Offset: 0x004D7BE8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06012F9A RID: 77722 RVA: 0x004D99F0 File Offset: 0x004D7BF0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06012F9B RID: 77723 RVA: 0x004D9A04 File Offset: 0x004D7C04
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06012F9C RID: 77724 RVA: 0x004D9A0C File Offset: 0x004D7C0C
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06012F9D RID: 77725 RVA: 0x004D9A18 File Offset: 0x004D7C18
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06012F9E RID: 77726 RVA: 0x004D9A24 File Offset: 0x004D7C24
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06012F9F RID: 77727 RVA: 0x004D9A30 File Offset: 0x004D7C30
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06012FA0 RID: 77728 RVA: 0x004D9A3C File Offset: 0x004D7C3C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06012FA1 RID: 77729 RVA: 0x004D9A48 File Offset: 0x004D7C48
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06012FA2 RID: 77730 RVA: 0x004D9A54 File Offset: 0x004D7C54
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06012FA3 RID: 77731 RVA: 0x004D9A60 File Offset: 0x004D7C60
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06012FA4 RID: 77732 RVA: 0x004D9A6C File Offset: 0x004D7C6C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06012FA5 RID: 77733 RVA: 0x004D9A78 File Offset: 0x004D7C78
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06012FA6 RID: 77734 RVA: 0x004D9A80 File Offset: 0x004D7C80
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
					this.m_InitHeroSimpleItemInfoHero_hotfix = (luaObj.RawGet("InitHeroSimpleItemInfo") as LuaFunction);
					this.m_SetValues_hotfix = (luaObj.RawGet("SetValues") as LuaFunction);
					this.m_CreateSpineGraphicConfigDataJobConnectionInfoUISpineGraphic_GameObject_hotfix = (luaObj.RawGet("CreateSpineGraphic") as LuaFunction);
					this.m_DestroySpineGraphicUISpineGraphic__hotfix = (luaObj.RawGet("DestroySpineGraphic") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06012FA7 RID: 77735 RVA: 0x004D9BB0 File Offset: 0x004D7DB0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroSimpleItemInfoUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400A98C RID: 43404
		[AutoBind("./TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroNameText;

		// Token: 0x0400A98D RID: 43405
		[AutoBind("./Job/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_heroJobText;

		// Token: 0x0400A98E RID: 43406
		[AutoBind("./Army", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_armyImage;

		// Token: 0x0400A98F RID: 43407
		[AutoBind("./Army/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_armyText;

		// Token: 0x0400A990 RID: 43408
		[AutoBind("./HeroStars", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroStars;

		// Token: 0x0400A991 RID: 43409
		[AutoBind("./Property/HP/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroHPImage;

		// Token: 0x0400A992 RID: 43410
		[AutoBind("./Property/DF/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroDFImage;

		// Token: 0x0400A993 RID: 43411
		[AutoBind("./Property/AT/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroATImage;

		// Token: 0x0400A994 RID: 43412
		[AutoBind("./Property/MagicDF/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroMagicDFImage;

		// Token: 0x0400A995 RID: 43413
		[AutoBind("./Property/Magic/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroMagicImage;

		// Token: 0x0400A996 RID: 43414
		[AutoBind("./Property/DEX/Image", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroDEXImage;

		// Token: 0x0400A997 RID: 43415
		[AutoBind("./Talent/Icon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_talentIconImg;

		// Token: 0x0400A998 RID: 43416
		[AutoBind("./Talent/TitleText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_talentNameText;

		// Token: 0x0400A999 RID: 43417
		[AutoBind("./Talent/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_talentDescText;

		// Token: 0x0400A99A RID: 43418
		[AutoBind("./FinalJobs/Job1/NameText_CH", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_finalJob1CHNameText;

		// Token: 0x0400A99B RID: 43419
		[AutoBind("./FinalJobs/Job1/NameText_EN", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_finalJob1ENNameText;

		// Token: 0x0400A99C RID: 43420
		[AutoBind("./FinalJobs/Job1/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_finalJob1GraphicObj;

		// Token: 0x0400A99D RID: 43421
		[AutoBind("./FinalJobs/Job2", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_finalJob2Obj;

		// Token: 0x0400A99E RID: 43422
		[AutoBind("./FinalJobs/Job2/NameText_CH", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_finalJob2CHNameText;

		// Token: 0x0400A99F RID: 43423
		[AutoBind("./FinalJobs/Job2/NameText_EN", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_finalJob2ENNameText;

		// Token: 0x0400A9A0 RID: 43424
		[AutoBind("./FinalJobs/Job2/Graphic", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_finalJob2GraphicObj;

		// Token: 0x0400A9A1 RID: 43425
		public Hero m_hero;

		// Token: 0x0400A9A2 RID: 43426
		private UISpineGraphic m_heroJobGraphic1;

		// Token: 0x0400A9A3 RID: 43427
		private UISpineGraphic m_heroJobGraphic2;

		// Token: 0x0400A9A4 RID: 43428
		[DoNotToLua]
		private HeroSimpleItemInfoUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400A9A5 RID: 43429
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400A9A6 RID: 43430
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400A9A7 RID: 43431
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400A9A8 RID: 43432
		private LuaFunction m_InitHeroSimpleItemInfoHero_hotfix;

		// Token: 0x0400A9A9 RID: 43433
		private LuaFunction m_SetValues_hotfix;

		// Token: 0x0400A9AA RID: 43434
		private LuaFunction m_CreateSpineGraphicConfigDataJobConnectionInfoUISpineGraphic_GameObject_hotfix;

		// Token: 0x0400A9AB RID: 43435
		private LuaFunction m_DestroySpineGraphicUISpineGraphic__hotfix;

		// Token: 0x02000EFD RID: 3837
		public new class LuaExportHelper
		{
			// Token: 0x06012FA8 RID: 77736 RVA: 0x004D9C18 File Offset: 0x004D7E18
			public LuaExportHelper(HeroSimpleItemInfoUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06012FA9 RID: 77737 RVA: 0x004D9C28 File Offset: 0x004D7E28
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06012FAA RID: 77738 RVA: 0x004D9C38 File Offset: 0x004D7E38
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06012FAB RID: 77739 RVA: 0x004D9C48 File Offset: 0x004D7E48
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06012FAC RID: 77740 RVA: 0x004D9C58 File Offset: 0x004D7E58
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06012FAD RID: 77741 RVA: 0x004D9C70 File Offset: 0x004D7E70
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06012FAE RID: 77742 RVA: 0x004D9C80 File Offset: 0x004D7E80
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06012FAF RID: 77743 RVA: 0x004D9C90 File Offset: 0x004D7E90
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06012FB0 RID: 77744 RVA: 0x004D9CA0 File Offset: 0x004D7EA0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06012FB1 RID: 77745 RVA: 0x004D9CB0 File Offset: 0x004D7EB0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06012FB2 RID: 77746 RVA: 0x004D9CC0 File Offset: 0x004D7EC0
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06012FB3 RID: 77747 RVA: 0x004D9CD0 File Offset: 0x004D7ED0
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06012FB4 RID: 77748 RVA: 0x004D9CE0 File Offset: 0x004D7EE0
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06012FB5 RID: 77749 RVA: 0x004D9CF0 File Offset: 0x004D7EF0
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06012FB6 RID: 77750 RVA: 0x004D9D00 File Offset: 0x004D7F00
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06012FB7 RID: 77751 RVA: 0x004D9D10 File Offset: 0x004D7F10
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003948 RID: 14664
			// (get) Token: 0x06012FB8 RID: 77752 RVA: 0x004D9D20 File Offset: 0x004D7F20
			// (set) Token: 0x06012FB9 RID: 77753 RVA: 0x004D9D30 File Offset: 0x004D7F30
			public Text m_heroNameText
			{
				get
				{
					return this.m_owner.m_heroNameText;
				}
				set
				{
					this.m_owner.m_heroNameText = value;
				}
			}

			// Token: 0x17003949 RID: 14665
			// (get) Token: 0x06012FBA RID: 77754 RVA: 0x004D9D40 File Offset: 0x004D7F40
			// (set) Token: 0x06012FBB RID: 77755 RVA: 0x004D9D50 File Offset: 0x004D7F50
			public Text m_heroJobText
			{
				get
				{
					return this.m_owner.m_heroJobText;
				}
				set
				{
					this.m_owner.m_heroJobText = value;
				}
			}

			// Token: 0x1700394A RID: 14666
			// (get) Token: 0x06012FBC RID: 77756 RVA: 0x004D9D60 File Offset: 0x004D7F60
			// (set) Token: 0x06012FBD RID: 77757 RVA: 0x004D9D70 File Offset: 0x004D7F70
			public Image m_armyImage
			{
				get
				{
					return this.m_owner.m_armyImage;
				}
				set
				{
					this.m_owner.m_armyImage = value;
				}
			}

			// Token: 0x1700394B RID: 14667
			// (get) Token: 0x06012FBE RID: 77758 RVA: 0x004D9D80 File Offset: 0x004D7F80
			// (set) Token: 0x06012FBF RID: 77759 RVA: 0x004D9D90 File Offset: 0x004D7F90
			public Text m_armyText
			{
				get
				{
					return this.m_owner.m_armyText;
				}
				set
				{
					this.m_owner.m_armyText = value;
				}
			}

			// Token: 0x1700394C RID: 14668
			// (get) Token: 0x06012FC0 RID: 77760 RVA: 0x004D9DA0 File Offset: 0x004D7FA0
			// (set) Token: 0x06012FC1 RID: 77761 RVA: 0x004D9DB0 File Offset: 0x004D7FB0
			public GameObject m_heroStars
			{
				get
				{
					return this.m_owner.m_heroStars;
				}
				set
				{
					this.m_owner.m_heroStars = value;
				}
			}

			// Token: 0x1700394D RID: 14669
			// (get) Token: 0x06012FC2 RID: 77762 RVA: 0x004D9DC0 File Offset: 0x004D7FC0
			// (set) Token: 0x06012FC3 RID: 77763 RVA: 0x004D9DD0 File Offset: 0x004D7FD0
			public Image m_heroHPImage
			{
				get
				{
					return this.m_owner.m_heroHPImage;
				}
				set
				{
					this.m_owner.m_heroHPImage = value;
				}
			}

			// Token: 0x1700394E RID: 14670
			// (get) Token: 0x06012FC4 RID: 77764 RVA: 0x004D9DE0 File Offset: 0x004D7FE0
			// (set) Token: 0x06012FC5 RID: 77765 RVA: 0x004D9DF0 File Offset: 0x004D7FF0
			public Image m_heroDFImage
			{
				get
				{
					return this.m_owner.m_heroDFImage;
				}
				set
				{
					this.m_owner.m_heroDFImage = value;
				}
			}

			// Token: 0x1700394F RID: 14671
			// (get) Token: 0x06012FC6 RID: 77766 RVA: 0x004D9E00 File Offset: 0x004D8000
			// (set) Token: 0x06012FC7 RID: 77767 RVA: 0x004D9E10 File Offset: 0x004D8010
			public Image m_heroATImage
			{
				get
				{
					return this.m_owner.m_heroATImage;
				}
				set
				{
					this.m_owner.m_heroATImage = value;
				}
			}

			// Token: 0x17003950 RID: 14672
			// (get) Token: 0x06012FC8 RID: 77768 RVA: 0x004D9E20 File Offset: 0x004D8020
			// (set) Token: 0x06012FC9 RID: 77769 RVA: 0x004D9E30 File Offset: 0x004D8030
			public Image m_heroMagicDFImage
			{
				get
				{
					return this.m_owner.m_heroMagicDFImage;
				}
				set
				{
					this.m_owner.m_heroMagicDFImage = value;
				}
			}

			// Token: 0x17003951 RID: 14673
			// (get) Token: 0x06012FCA RID: 77770 RVA: 0x004D9E40 File Offset: 0x004D8040
			// (set) Token: 0x06012FCB RID: 77771 RVA: 0x004D9E50 File Offset: 0x004D8050
			public Image m_heroMagicImage
			{
				get
				{
					return this.m_owner.m_heroMagicImage;
				}
				set
				{
					this.m_owner.m_heroMagicImage = value;
				}
			}

			// Token: 0x17003952 RID: 14674
			// (get) Token: 0x06012FCC RID: 77772 RVA: 0x004D9E60 File Offset: 0x004D8060
			// (set) Token: 0x06012FCD RID: 77773 RVA: 0x004D9E70 File Offset: 0x004D8070
			public Image m_heroDEXImage
			{
				get
				{
					return this.m_owner.m_heroDEXImage;
				}
				set
				{
					this.m_owner.m_heroDEXImage = value;
				}
			}

			// Token: 0x17003953 RID: 14675
			// (get) Token: 0x06012FCE RID: 77774 RVA: 0x004D9E80 File Offset: 0x004D8080
			// (set) Token: 0x06012FCF RID: 77775 RVA: 0x004D9E90 File Offset: 0x004D8090
			public Image m_talentIconImg
			{
				get
				{
					return this.m_owner.m_talentIconImg;
				}
				set
				{
					this.m_owner.m_talentIconImg = value;
				}
			}

			// Token: 0x17003954 RID: 14676
			// (get) Token: 0x06012FD0 RID: 77776 RVA: 0x004D9EA0 File Offset: 0x004D80A0
			// (set) Token: 0x06012FD1 RID: 77777 RVA: 0x004D9EB0 File Offset: 0x004D80B0
			public Text m_talentNameText
			{
				get
				{
					return this.m_owner.m_talentNameText;
				}
				set
				{
					this.m_owner.m_talentNameText = value;
				}
			}

			// Token: 0x17003955 RID: 14677
			// (get) Token: 0x06012FD2 RID: 77778 RVA: 0x004D9EC0 File Offset: 0x004D80C0
			// (set) Token: 0x06012FD3 RID: 77779 RVA: 0x004D9ED0 File Offset: 0x004D80D0
			public Text m_talentDescText
			{
				get
				{
					return this.m_owner.m_talentDescText;
				}
				set
				{
					this.m_owner.m_talentDescText = value;
				}
			}

			// Token: 0x17003956 RID: 14678
			// (get) Token: 0x06012FD4 RID: 77780 RVA: 0x004D9EE0 File Offset: 0x004D80E0
			// (set) Token: 0x06012FD5 RID: 77781 RVA: 0x004D9EF0 File Offset: 0x004D80F0
			public Text m_finalJob1CHNameText
			{
				get
				{
					return this.m_owner.m_finalJob1CHNameText;
				}
				set
				{
					this.m_owner.m_finalJob1CHNameText = value;
				}
			}

			// Token: 0x17003957 RID: 14679
			// (get) Token: 0x06012FD6 RID: 77782 RVA: 0x004D9F00 File Offset: 0x004D8100
			// (set) Token: 0x06012FD7 RID: 77783 RVA: 0x004D9F10 File Offset: 0x004D8110
			public Text m_finalJob1ENNameText
			{
				get
				{
					return this.m_owner.m_finalJob1ENNameText;
				}
				set
				{
					this.m_owner.m_finalJob1ENNameText = value;
				}
			}

			// Token: 0x17003958 RID: 14680
			// (get) Token: 0x06012FD8 RID: 77784 RVA: 0x004D9F20 File Offset: 0x004D8120
			// (set) Token: 0x06012FD9 RID: 77785 RVA: 0x004D9F30 File Offset: 0x004D8130
			public GameObject m_finalJob1GraphicObj
			{
				get
				{
					return this.m_owner.m_finalJob1GraphicObj;
				}
				set
				{
					this.m_owner.m_finalJob1GraphicObj = value;
				}
			}

			// Token: 0x17003959 RID: 14681
			// (get) Token: 0x06012FDA RID: 77786 RVA: 0x004D9F40 File Offset: 0x004D8140
			// (set) Token: 0x06012FDB RID: 77787 RVA: 0x004D9F50 File Offset: 0x004D8150
			public GameObject m_finalJob2Obj
			{
				get
				{
					return this.m_owner.m_finalJob2Obj;
				}
				set
				{
					this.m_owner.m_finalJob2Obj = value;
				}
			}

			// Token: 0x1700395A RID: 14682
			// (get) Token: 0x06012FDC RID: 77788 RVA: 0x004D9F60 File Offset: 0x004D8160
			// (set) Token: 0x06012FDD RID: 77789 RVA: 0x004D9F70 File Offset: 0x004D8170
			public Text m_finalJob2CHNameText
			{
				get
				{
					return this.m_owner.m_finalJob2CHNameText;
				}
				set
				{
					this.m_owner.m_finalJob2CHNameText = value;
				}
			}

			// Token: 0x1700395B RID: 14683
			// (get) Token: 0x06012FDE RID: 77790 RVA: 0x004D9F80 File Offset: 0x004D8180
			// (set) Token: 0x06012FDF RID: 77791 RVA: 0x004D9F90 File Offset: 0x004D8190
			public Text m_finalJob2ENNameText
			{
				get
				{
					return this.m_owner.m_finalJob2ENNameText;
				}
				set
				{
					this.m_owner.m_finalJob2ENNameText = value;
				}
			}

			// Token: 0x1700395C RID: 14684
			// (get) Token: 0x06012FE0 RID: 77792 RVA: 0x004D9FA0 File Offset: 0x004D81A0
			// (set) Token: 0x06012FE1 RID: 77793 RVA: 0x004D9FB0 File Offset: 0x004D81B0
			public GameObject m_finalJob2GraphicObj
			{
				get
				{
					return this.m_owner.m_finalJob2GraphicObj;
				}
				set
				{
					this.m_owner.m_finalJob2GraphicObj = value;
				}
			}

			// Token: 0x1700395D RID: 14685
			// (get) Token: 0x06012FE2 RID: 77794 RVA: 0x004D9FC0 File Offset: 0x004D81C0
			// (set) Token: 0x06012FE3 RID: 77795 RVA: 0x004D9FD0 File Offset: 0x004D81D0
			public UISpineGraphic m_heroJobGraphic1
			{
				get
				{
					return this.m_owner.m_heroJobGraphic1;
				}
				set
				{
					this.m_owner.m_heroJobGraphic1 = value;
				}
			}

			// Token: 0x1700395E RID: 14686
			// (get) Token: 0x06012FE4 RID: 77796 RVA: 0x004D9FE0 File Offset: 0x004D81E0
			// (set) Token: 0x06012FE5 RID: 77797 RVA: 0x004D9FF0 File Offset: 0x004D81F0
			public UISpineGraphic m_heroJobGraphic2
			{
				get
				{
					return this.m_owner.m_heroJobGraphic2;
				}
				set
				{
					this.m_owner.m_heroJobGraphic2 = value;
				}
			}

			// Token: 0x06012FE6 RID: 77798 RVA: 0x004DA000 File Offset: 0x004D8200
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06012FE7 RID: 77799 RVA: 0x004DA010 File Offset: 0x004D8210
			public void SetValues()
			{
				this.m_owner.SetValues();
			}

			// Token: 0x06012FE8 RID: 77800 RVA: 0x004DA020 File Offset: 0x004D8220
			public void CreateSpineGraphic(ConfigDataJobConnectionInfo jobConnectionInfo, ref UISpineGraphic m_graphic, GameObject m_grapgicObj)
			{
				this.m_owner.CreateSpineGraphic(jobConnectionInfo, ref m_graphic, m_grapgicObj);
			}

			// Token: 0x06012FE9 RID: 77801 RVA: 0x004DA030 File Offset: 0x004D8230
			public void DestroySpineGraphic(ref UISpineGraphic m_graphic)
			{
				this.m_owner.DestroySpineGraphic(ref m_graphic);
			}

			// Token: 0x0400A9AC RID: 43436
			private HeroSimpleItemInfoUIController m_owner;
		}
	}
}
