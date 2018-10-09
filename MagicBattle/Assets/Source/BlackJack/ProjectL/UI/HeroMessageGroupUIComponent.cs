using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Scene;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009E4 RID: 2532
	[HotFix]
	public class HeroMessageGroupUIComponent
	{
		// Token: 0x06009615 RID: 38421 RVA: 0x002AF83C File Offset: 0x002ADA3C
		public HeroMessageGroupUIComponent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06009616 RID: 38422 RVA: 0x002AF8A4 File Offset: 0x002ADAA4
		public void Init(GameObject obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGameObject_hotfix != null)
			{
				this.m_InitGameObject_hotfix.call(new object[]
				{
					this,
					obj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_root = obj;
			this.m_ssrGameObject = GameObjectUtility.FindGameObjectByName(obj.transform, "SSR");
			if (this.m_ssrGameObject == null)
			{
				global::Debug.LogError(string.Format("HeroMessageGroupUIComponent.Init Failed to find {0} from {1}", "SSR", SceneManager.GetObjectPath(obj)));
			}
			this.m_srGameObject = GameObjectUtility.FindGameObjectByName(obj.transform, "SR");
			if (this.m_srGameObject == null)
			{
				global::Debug.LogError(string.Format("HeroMessageGroupUIComponent.Init Failed to find {0} from {1}", "SR", SceneManager.GetObjectPath(obj)));
			}
			this.m_rGameObject = GameObjectUtility.FindGameObjectByName(obj.transform, "R");
			if (this.m_rGameObject == null)
			{
				global::Debug.LogError(string.Format("HeroMessageGroupUIComponent.Init Failed to find {0} from {1}", "R", SceneManager.GetObjectPath(obj)));
			}
			this.m_heroNameText = GameObjectUtility.FindComponentByName<Text>(obj.transform, "HeroNameText");
			if (this.m_heroNameText == null)
			{
				global::Debug.LogError(string.Format("HeroMessageGroupUIComponent.Init Failed to find {0} from {1}", "HeroNameText", SceneManager.GetObjectPath(obj)));
			}
			this.m_cvNameText = GameObjectUtility.FindComponentByName<Text>(obj.transform, "CVNameText");
			if (this.m_cvNameText == null)
			{
				global::Debug.LogError(string.Format("HeroMessageGroupUIComponent.Init Failed to find {0} from {1}", "CVNameText", SceneManager.GetObjectPath(obj)));
			}
		}

		// Token: 0x06009617 RID: 38423 RVA: 0x002AFA60 File Offset: 0x002ADC60
		public void SetEnglishNameText(Text heroEnglishNameText)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEnglishNameTextText_hotfix != null)
			{
				this.m_SetEnglishNameTextText_hotfix.call(new object[]
				{
					this,
					heroEnglishNameText
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroEnglishNameText = heroEnglishNameText;
		}

		// Token: 0x06009618 RID: 38424 RVA: 0x002AFAD8 File Offset: 0x002ADCD8
		public void Refresh(ConfigDataHeroInfo heroInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshConfigDataHeroInfo_hotfix != null)
			{
				this.m_RefreshConfigDataHeroInfo_hotfix.call(new object[]
				{
					this,
					heroInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataCharImageInfo charImageInfo = heroInfo.GetCharImageInfo(heroInfo.Star);
			this.m_ssrGameObject.SetActive(false);
			this.m_srGameObject.SetActive(false);
			this.m_rGameObject.SetActive(false);
			switch (heroInfo.Rank)
			{
			case 1:
				this.m_rGameObject.SetActive(true);
				break;
			case 2:
				this.m_rGameObject.SetActive(true);
				break;
			case 3:
				this.m_srGameObject.SetActive(true);
				break;
			case 4:
				this.m_ssrGameObject.SetActive(true);
				break;
			}
			this.m_heroNameText.text = heroInfo.Name;
			if (this.m_heroEnglishNameText != null)
			{
				this.m_heroEnglishNameText.text = heroInfo.Name_Eng;
			}
			this.m_cvNameText.text = "CV：" + charImageInfo.CVName;
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06009619 RID: 38425 RVA: 0x002AFC30 File Offset: 0x002ADE30
		// (set) Token: 0x0600961A RID: 38426 RVA: 0x002AFC50 File Offset: 0x002ADE50
		[DoNotToLua]
		public HeroMessageGroupUIComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroMessageGroupUIComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600961B RID: 38427 RVA: 0x002AFC5C File Offset: 0x002ADE5C
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_InitGameObject_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_SetEnglishNameTextText_hotfix = (luaObj.RawGet("SetEnglishNameText") as LuaFunction);
					this.m_RefreshConfigDataHeroInfo_hotfix = (luaObj.RawGet("Refresh") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600961C RID: 38428 RVA: 0x002AFD74 File Offset: 0x002ADF74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroMessageGroupUIComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006791 RID: 26513
		private GameObject m_ssrGameObject;

		// Token: 0x04006792 RID: 26514
		private GameObject m_srGameObject;

		// Token: 0x04006793 RID: 26515
		private GameObject m_rGameObject;

		// Token: 0x04006794 RID: 26516
		private Text m_heroNameText;

		// Token: 0x04006795 RID: 26517
		private Text m_heroEnglishNameText;

		// Token: 0x04006796 RID: 26518
		private Text m_cvNameText;

		// Token: 0x04006797 RID: 26519
		private GameObject m_root;

		// Token: 0x04006798 RID: 26520
		[DoNotToLua]
		private HeroMessageGroupUIComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04006799 RID: 26521
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400679A RID: 26522
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400679B RID: 26523
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400679C RID: 26524
		private LuaFunction m_InitGameObject_hotfix;

		// Token: 0x0400679D RID: 26525
		private LuaFunction m_SetEnglishNameTextText_hotfix;

		// Token: 0x0400679E RID: 26526
		private LuaFunction m_RefreshConfigDataHeroInfo_hotfix;

		// Token: 0x020009E5 RID: 2533
		public class LuaExportHelper
		{
			// Token: 0x0600961D RID: 38429 RVA: 0x002AFDDC File Offset: 0x002ADFDC
			public LuaExportHelper(HeroMessageGroupUIComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001EF8 RID: 7928
			// (get) Token: 0x0600961E RID: 38430 RVA: 0x002AFDEC File Offset: 0x002ADFEC
			// (set) Token: 0x0600961F RID: 38431 RVA: 0x002AFDFC File Offset: 0x002ADFFC
			public GameObject m_ssrGameObject
			{
				get
				{
					return this.m_owner.m_ssrGameObject;
				}
				set
				{
					this.m_owner.m_ssrGameObject = value;
				}
			}

			// Token: 0x17001EF9 RID: 7929
			// (get) Token: 0x06009620 RID: 38432 RVA: 0x002AFE0C File Offset: 0x002AE00C
			// (set) Token: 0x06009621 RID: 38433 RVA: 0x002AFE1C File Offset: 0x002AE01C
			public GameObject m_srGameObject
			{
				get
				{
					return this.m_owner.m_srGameObject;
				}
				set
				{
					this.m_owner.m_srGameObject = value;
				}
			}

			// Token: 0x17001EFA RID: 7930
			// (get) Token: 0x06009622 RID: 38434 RVA: 0x002AFE2C File Offset: 0x002AE02C
			// (set) Token: 0x06009623 RID: 38435 RVA: 0x002AFE3C File Offset: 0x002AE03C
			public GameObject m_rGameObject
			{
				get
				{
					return this.m_owner.m_rGameObject;
				}
				set
				{
					this.m_owner.m_rGameObject = value;
				}
			}

			// Token: 0x17001EFB RID: 7931
			// (get) Token: 0x06009624 RID: 38436 RVA: 0x002AFE4C File Offset: 0x002AE04C
			// (set) Token: 0x06009625 RID: 38437 RVA: 0x002AFE5C File Offset: 0x002AE05C
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

			// Token: 0x17001EFC RID: 7932
			// (get) Token: 0x06009626 RID: 38438 RVA: 0x002AFE6C File Offset: 0x002AE06C
			// (set) Token: 0x06009627 RID: 38439 RVA: 0x002AFE7C File Offset: 0x002AE07C
			public Text m_heroEnglishNameText
			{
				get
				{
					return this.m_owner.m_heroEnglishNameText;
				}
				set
				{
					this.m_owner.m_heroEnglishNameText = value;
				}
			}

			// Token: 0x17001EFD RID: 7933
			// (get) Token: 0x06009628 RID: 38440 RVA: 0x002AFE8C File Offset: 0x002AE08C
			// (set) Token: 0x06009629 RID: 38441 RVA: 0x002AFE9C File Offset: 0x002AE09C
			public Text m_cvNameText
			{
				get
				{
					return this.m_owner.m_cvNameText;
				}
				set
				{
					this.m_owner.m_cvNameText = value;
				}
			}

			// Token: 0x17001EFE RID: 7934
			// (get) Token: 0x0600962A RID: 38442 RVA: 0x002AFEAC File Offset: 0x002AE0AC
			// (set) Token: 0x0600962B RID: 38443 RVA: 0x002AFEBC File Offset: 0x002AE0BC
			public GameObject m_root
			{
				get
				{
					return this.m_owner.m_root;
				}
				set
				{
					this.m_owner.m_root = value;
				}
			}

			// Token: 0x0400679F RID: 26527
			private HeroMessageGroupUIComponent m_owner;
		}
	}
}
