using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F07 RID: 3847
	[HotFix]
	public class ShareTenSelectCardUIController : UIControllerBase
	{
		// Token: 0x0601310E RID: 78094 RVA: 0x004DD55C File Offset: 0x004DB75C
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
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			for (int i = 0; i < 5; i++)
			{
				string name = string.Format("Hero{0}L", i + 1);
				string name2 = string.Format("Hero{0}R", i + 1);
				Transform item = this.m_heroGroup.transform.Find(name);
				Transform item2 = this.m_heroGroup.transform.Find(name2);
				this.m_heroDummyParentList.Add(item);
				this.m_heroDummyParentList.Add(item2);
			}
		}

		// Token: 0x0601310F RID: 78095 RVA: 0x004DD650 File Offset: 0x004DB850
		public void Refresh(List<int> m_heroIDList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RefreshList`1_hotfix != null)
			{
				this.m_RefreshList`1_hotfix.call(new object[]
				{
					this,
					m_heroIDList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (GameObject obj in this.m_heroGameObject)
			{
				UnityEngine.Object.Destroy(obj);
			}
			this.m_heroGameObject.Clear();
			m_heroIDList.Sort(new Comparison<int>(this.Compare));
			for (int i = 0; i < 10; i++)
			{
				ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(m_heroIDList[i]);
				ConfigDataCharImageInfo charImageInfo = configDataHeroInfo.GetCharImageInfo(configDataHeroInfo.Star);
				GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(charImageInfo.HeroPainting);
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(asset);
				Transform transform = GameObjectUtility.FindGameObjectByName(this.m_heroDummyParentList[i], "HeroDummy").transform;
				CommonUIStateController commonUIStateController = GameObjectUtility.FindComponentByName<CommonUIStateController>(this.m_heroDummyParentList[i], "Quality");
				Text text = GameObjectUtility.FindComponentByName<Text>(this.m_heroDummyParentList[i], "HeroNameText");
				text.text = configDataHeroInfo.Name;
				gameObject.transform.SetParent(transform, false);
				int rank = configDataHeroInfo.Rank;
				if (rank != 2)
				{
					if (rank != 3)
					{
						if (rank == 4)
						{
							commonUIStateController.SetToUIState("SSR", false, true);
						}
					}
					else
					{
						commonUIStateController.SetToUIState("SR", false, true);
					}
				}
				else
				{
					commonUIStateController.SetToUIState("R", false, true);
				}
				this.m_heroGameObject.Add(gameObject);
			}
			this.UpdateSharePlayerInfo();
		}

		// Token: 0x06013110 RID: 78096 RVA: 0x004DD858 File Offset: 0x004DBA58
		private void UpdateSharePlayerInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateSharePlayerInfo_hotfix != null)
			{
				this.m_UpdateSharePlayerInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			this.m_playerNameText.text = projectLPlayerContext.GetPlayerName();
			this.m_playerLvText.text = projectLPlayerContext.GetPlayerLevel().ToString();
			this.m_serverNameText.text = LoginUITask.GetCurrentSelectServerInfo().m_name;
		}

		// Token: 0x06013111 RID: 78097 RVA: 0x004DD910 File Offset: 0x004DBB10
		private int Compare(int leftHeroID, int rightHeroID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CompareInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CompareInt32Int32_hotfix.call(new object[]
				{
					this,
					leftHeroID,
					rightHeroID
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(leftHeroID);
			ConfigDataHeroInfo configDataHeroInfo2 = this.m_configDataLoader.GetConfigDataHeroInfo(rightHeroID);
			int num = configDataHeroInfo2.Rank - configDataHeroInfo.Rank;
			if (num != 0)
			{
				return num;
			}
			return configDataHeroInfo2.ID - configDataHeroInfo.ID;
		}

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x06013112 RID: 78098 RVA: 0x004DD9DC File Offset: 0x004DBBDC
		// (set) Token: 0x06013113 RID: 78099 RVA: 0x004DD9FC File Offset: 0x004DBBFC
		[DoNotToLua]
		public new ShareTenSelectCardUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ShareTenSelectCardUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013114 RID: 78100 RVA: 0x004DDA08 File Offset: 0x004DBC08
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06013115 RID: 78101 RVA: 0x004DDA14 File Offset: 0x004DBC14
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06013116 RID: 78102 RVA: 0x004DDA1C File Offset: 0x004DBC1C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06013117 RID: 78103 RVA: 0x004DDA24 File Offset: 0x004DBC24
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06013118 RID: 78104 RVA: 0x004DDA38 File Offset: 0x004DBC38
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06013119 RID: 78105 RVA: 0x004DDA40 File Offset: 0x004DBC40
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601311A RID: 78106 RVA: 0x004DDA4C File Offset: 0x004DBC4C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601311B RID: 78107 RVA: 0x004DDA58 File Offset: 0x004DBC58
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601311C RID: 78108 RVA: 0x004DDA64 File Offset: 0x004DBC64
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0601311D RID: 78109 RVA: 0x004DDA70 File Offset: 0x004DBC70
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0601311E RID: 78110 RVA: 0x004DDA7C File Offset: 0x004DBC7C
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0601311F RID: 78111 RVA: 0x004DDA88 File Offset: 0x004DBC88
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06013120 RID: 78112 RVA: 0x004DDA94 File Offset: 0x004DBC94
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06013121 RID: 78113 RVA: 0x004DDAA0 File Offset: 0x004DBCA0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06013122 RID: 78114 RVA: 0x004DDAAC File Offset: 0x004DBCAC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06013123 RID: 78115 RVA: 0x004DDAB4 File Offset: 0x004DBCB4
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
					this.m_RefreshList`1_hotfix = (luaObj.RawGet("Refresh") as LuaFunction);
					this.m_UpdateSharePlayerInfo_hotfix = (luaObj.RawGet("UpdateSharePlayerInfo") as LuaFunction);
					this.m_CompareInt32Int32_hotfix = (luaObj.RawGet("Compare") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013124 RID: 78116 RVA: 0x004DDBCC File Offset: 0x004DBDCC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ShareTenSelectCardUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AA03 RID: 43523
		[AutoBind("./HeroGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_heroGroup;

		// Token: 0x0400AA04 RID: 43524
		[AutoBind("./Share/PlayerInfo/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerNameText;

		// Token: 0x0400AA05 RID: 43525
		[AutoBind("./Share/PlayerInfo/Lvbg/LvValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_playerLvText;

		// Token: 0x0400AA06 RID: 43526
		[AutoBind("./Share/ServerNameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_serverNameText;

		// Token: 0x0400AA07 RID: 43527
		private List<Transform> m_heroDummyParentList = new List<Transform>();

		// Token: 0x0400AA08 RID: 43528
		private List<GameObject> m_heroGameObject = new List<GameObject>();

		// Token: 0x0400AA09 RID: 43529
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400AA0A RID: 43530
		[DoNotToLua]
		private ShareTenSelectCardUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AA0B RID: 43531
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AA0C RID: 43532
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AA0D RID: 43533
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400AA0E RID: 43534
		private LuaFunction m_RefreshList;

		// Token: 0x0400AA0F RID: 43535
		private LuaFunction m_UpdateSharePlayerInfo_hotfix;

		// Token: 0x0400AA10 RID: 43536
		private LuaFunction m_CompareInt32Int32_hotfix;

		// Token: 0x02000F08 RID: 3848
		public new class LuaExportHelper
		{
			// Token: 0x06013125 RID: 78117 RVA: 0x004DDC34 File Offset: 0x004DBE34
			public LuaExportHelper(ShareTenSelectCardUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06013126 RID: 78118 RVA: 0x004DDC44 File Offset: 0x004DBE44
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06013127 RID: 78119 RVA: 0x004DDC54 File Offset: 0x004DBE54
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06013128 RID: 78120 RVA: 0x004DDC64 File Offset: 0x004DBE64
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06013129 RID: 78121 RVA: 0x004DDC74 File Offset: 0x004DBE74
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0601312A RID: 78122 RVA: 0x004DDC8C File Offset: 0x004DBE8C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0601312B RID: 78123 RVA: 0x004DDC9C File Offset: 0x004DBE9C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0601312C RID: 78124 RVA: 0x004DDCAC File Offset: 0x004DBEAC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0601312D RID: 78125 RVA: 0x004DDCBC File Offset: 0x004DBEBC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0601312E RID: 78126 RVA: 0x004DDCCC File Offset: 0x004DBECC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0601312F RID: 78127 RVA: 0x004DDCDC File Offset: 0x004DBEDC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06013130 RID: 78128 RVA: 0x004DDCEC File Offset: 0x004DBEEC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06013131 RID: 78129 RVA: 0x004DDCFC File Offset: 0x004DBEFC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06013132 RID: 78130 RVA: 0x004DDD0C File Offset: 0x004DBF0C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06013133 RID: 78131 RVA: 0x004DDD1C File Offset: 0x004DBF1C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06013134 RID: 78132 RVA: 0x004DDD2C File Offset: 0x004DBF2C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x17003989 RID: 14729
			// (get) Token: 0x06013135 RID: 78133 RVA: 0x004DDD3C File Offset: 0x004DBF3C
			// (set) Token: 0x06013136 RID: 78134 RVA: 0x004DDD4C File Offset: 0x004DBF4C
			public GameObject m_heroGroup
			{
				get
				{
					return this.m_owner.m_heroGroup;
				}
				set
				{
					this.m_owner.m_heroGroup = value;
				}
			}

			// Token: 0x1700398A RID: 14730
			// (get) Token: 0x06013137 RID: 78135 RVA: 0x004DDD5C File Offset: 0x004DBF5C
			// (set) Token: 0x06013138 RID: 78136 RVA: 0x004DDD6C File Offset: 0x004DBF6C
			public Text m_playerNameText
			{
				get
				{
					return this.m_owner.m_playerNameText;
				}
				set
				{
					this.m_owner.m_playerNameText = value;
				}
			}

			// Token: 0x1700398B RID: 14731
			// (get) Token: 0x06013139 RID: 78137 RVA: 0x004DDD7C File Offset: 0x004DBF7C
			// (set) Token: 0x0601313A RID: 78138 RVA: 0x004DDD8C File Offset: 0x004DBF8C
			public Text m_playerLvText
			{
				get
				{
					return this.m_owner.m_playerLvText;
				}
				set
				{
					this.m_owner.m_playerLvText = value;
				}
			}

			// Token: 0x1700398C RID: 14732
			// (get) Token: 0x0601313B RID: 78139 RVA: 0x004DDD9C File Offset: 0x004DBF9C
			// (set) Token: 0x0601313C RID: 78140 RVA: 0x004DDDAC File Offset: 0x004DBFAC
			public Text m_serverNameText
			{
				get
				{
					return this.m_owner.m_serverNameText;
				}
				set
				{
					this.m_owner.m_serverNameText = value;
				}
			}

			// Token: 0x1700398D RID: 14733
			// (get) Token: 0x0601313D RID: 78141 RVA: 0x004DDDBC File Offset: 0x004DBFBC
			// (set) Token: 0x0601313E RID: 78142 RVA: 0x004DDDCC File Offset: 0x004DBFCC
			public List<Transform> m_heroDummyParentList
			{
				get
				{
					return this.m_owner.m_heroDummyParentList;
				}
				set
				{
					this.m_owner.m_heroDummyParentList = value;
				}
			}

			// Token: 0x1700398E RID: 14734
			// (get) Token: 0x0601313F RID: 78143 RVA: 0x004DDDDC File Offset: 0x004DBFDC
			// (set) Token: 0x06013140 RID: 78144 RVA: 0x004DDDEC File Offset: 0x004DBFEC
			public List<GameObject> m_heroGameObject
			{
				get
				{
					return this.m_owner.m_heroGameObject;
				}
				set
				{
					this.m_owner.m_heroGameObject = value;
				}
			}

			// Token: 0x1700398F RID: 14735
			// (get) Token: 0x06013141 RID: 78145 RVA: 0x004DDDFC File Offset: 0x004DBFFC
			// (set) Token: 0x06013142 RID: 78146 RVA: 0x004DDE0C File Offset: 0x004DC00C
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

			// Token: 0x06013143 RID: 78147 RVA: 0x004DDE1C File Offset: 0x004DC01C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06013144 RID: 78148 RVA: 0x004DDE2C File Offset: 0x004DC02C
			public void UpdateSharePlayerInfo()
			{
				this.m_owner.UpdateSharePlayerInfo();
			}

			// Token: 0x06013145 RID: 78149 RVA: 0x004DDE3C File Offset: 0x004DC03C
			public int Compare(int leftHeroID, int rightHeroID)
			{
				return this.m_owner.Compare(leftHeroID, rightHeroID);
			}

			// Token: 0x0400AA11 RID: 43537
			private ShareTenSelectCardUIController m_owner;
		}
	}
}
