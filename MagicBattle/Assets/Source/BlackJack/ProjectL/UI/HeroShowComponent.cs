using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009EE RID: 2542
	[HotFix]
	public class HeroShowComponent
	{
		// Token: 0x060096DD RID: 38621 RVA: 0x002B1CF8 File Offset: 0x002AFEF8
		public HeroShowComponent()
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

		// Token: 0x060096DE RID: 38622 RVA: 0x002B1D6C File Offset: 0x002AFF6C
		public void Init(GameObject root)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitGameObject_hotfix != null)
			{
				this.m_InitGameObject_hotfix.call(new object[]
				{
					this,
					root
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_root = root;
			this.m_root.SetActive(true);
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			IEnumerable<KeyValuePair<int, ConfigDataHeroInfo>> allConfigDataHeroInfo = this.m_configDataLoader.GetAllConfigDataHeroInfo();
			int childCount = this.m_root.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				Transform child = this.m_root.transform.GetChild(i);
				ConfigDataHeroInfo configDataHeroInfo = null;
				foreach (KeyValuePair<int, ConfigDataHeroInfo> keyValuePair in allConfigDataHeroInfo)
				{
					if (keyValuePair.Value.Useable && keyValuePair.Value.Name_Eng == child.name)
					{
						configDataHeroInfo = keyValuePair.Value;
						break;
					}
				}
				if (configDataHeroInfo != null)
				{
					ConfigDataCharImageInfo charImageInfo = configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star);
					if (charImageInfo != null)
					{
						GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(charImageInfo.HeroPainting);
						if (asset != null)
						{
							GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(asset);
							gameObject.transform.SetParent(child, false);
							CommonUIStateController component = gameObject.GetComponent<CommonUIStateController>();
							component.SetToUIState("Dark", false, true);
							this.heroDictionary.Add(child.name, component);
						}
					}
				}
			}
			List<Hero> heros = this.m_playerContext.GetHeros();
			foreach (Hero hero in heros)
			{
				CommonUIStateController commonUIStateController = null;
				if (this.heroDictionary.TryGetValue(hero.HeroInfo.Name_Eng, out commonUIStateController))
				{
					commonUIStateController.SetToUIState("Normal", false, true);
				}
			}
		}

		// Token: 0x060096DF RID: 38623 RVA: 0x002B1FDC File Offset: 0x002B01DC
		public void Dispose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Dispose_hotfix != null)
			{
				this.m_Dispose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int childCount = this.m_root.transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				Transform child = this.m_root.transform.GetChild(i);
				GameObjectUtility.DestroyChildren(child.gameObject);
			}
		}

		// Token: 0x060096E0 RID: 38624 RVA: 0x002B207C File Offset: 0x002B027C
		public void ShowComponent(bool isActive)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowComponentBoolean_hotfix != null)
			{
				this.m_ShowComponentBoolean_hotfix.call(new object[]
				{
					this,
					isActive
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_root.gameObject.SetActive(isActive);
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x060096E1 RID: 38625 RVA: 0x002B2100 File Offset: 0x002B0300
		// (set) Token: 0x060096E2 RID: 38626 RVA: 0x002B2120 File Offset: 0x002B0320
		[DoNotToLua]
		public HeroShowComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroShowComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060096E3 RID: 38627 RVA: 0x002B212C File Offset: 0x002B032C
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
					this.m_Dispose_hotfix = (luaObj.RawGet("Dispose") as LuaFunction);
					this.m_ShowComponentBoolean_hotfix = (luaObj.RawGet("ShowComponent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060096E4 RID: 38628 RVA: 0x002B2244 File Offset: 0x002B0444
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroShowComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040067E5 RID: 26597
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040067E6 RID: 26598
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040067E7 RID: 26599
		private GameObject m_root;

		// Token: 0x040067E8 RID: 26600
		private Dictionary<string, CommonUIStateController> heroDictionary = new Dictionary<string, CommonUIStateController>();

		// Token: 0x040067E9 RID: 26601
		[DoNotToLua]
		private HeroShowComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040067EA RID: 26602
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040067EB RID: 26603
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040067EC RID: 26604
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040067ED RID: 26605
		private LuaFunction m_InitGameObject_hotfix;

		// Token: 0x040067EE RID: 26606
		private LuaFunction m_Dispose_hotfix;

		// Token: 0x040067EF RID: 26607
		private LuaFunction m_ShowComponentBoolean_hotfix;

		// Token: 0x020009EF RID: 2543
		public class LuaExportHelper
		{
			// Token: 0x060096E5 RID: 38629 RVA: 0x002B22AC File Offset: 0x002B04AC
			public LuaExportHelper(HeroShowComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001F20 RID: 7968
			// (get) Token: 0x060096E6 RID: 38630 RVA: 0x002B22BC File Offset: 0x002B04BC
			// (set) Token: 0x060096E7 RID: 38631 RVA: 0x002B22CC File Offset: 0x002B04CC
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17001F21 RID: 7969
			// (get) Token: 0x060096E8 RID: 38632 RVA: 0x002B22DC File Offset: 0x002B04DC
			// (set) Token: 0x060096E9 RID: 38633 RVA: 0x002B22EC File Offset: 0x002B04EC
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x17001F22 RID: 7970
			// (get) Token: 0x060096EA RID: 38634 RVA: 0x002B22FC File Offset: 0x002B04FC
			// (set) Token: 0x060096EB RID: 38635 RVA: 0x002B230C File Offset: 0x002B050C
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

			// Token: 0x17001F23 RID: 7971
			// (get) Token: 0x060096EC RID: 38636 RVA: 0x002B231C File Offset: 0x002B051C
			// (set) Token: 0x060096ED RID: 38637 RVA: 0x002B232C File Offset: 0x002B052C
			public Dictionary<string, CommonUIStateController> heroDictionary
			{
				get
				{
					return this.m_owner.heroDictionary;
				}
				set
				{
					this.m_owner.heroDictionary = value;
				}
			}

			// Token: 0x040067F0 RID: 26608
			private HeroShowComponent m_owner;
		}
	}
}
