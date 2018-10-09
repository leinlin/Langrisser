using System;
using BlackJack.BJFramework.Runtime;
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
	// Token: 0x02000A30 RID: 2608
	[HotFix]
	public class ArenaPointRewardListItemUIController : UIControllerBase
	{
		// Token: 0x06009FFD RID: 40957 RVA: 0x002D29A4 File Offset: 0x002D0BA4
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

		// Token: 0x06009FFE RID: 40958 RVA: 0x002D2A0C File Offset: 0x002D0C0C
		public void SetArenaLevelInfo(ConfigDataArenaLevelInfo levelInfo, ConfigDataArenaLevelInfo prevLevelInfo, GameObject rewardGoodPrefab)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaLevelInfoConfigDataArenaLevelInfoConfigDataArenaLevelInfoGameObject_hotfix != null)
			{
				this.m_SetArenaLevelInfoConfigDataArenaLevelInfoConfigDataArenaLevelInfoGameObject_hotfix.call(new object[]
				{
					this,
					levelInfo,
					prevLevelInfo,
					rewardGoodPrefab
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (levelInfo.UpgradePoints > 0 || prevLevelInfo == null)
			{
				this.m_nameText.text = levelInfo.UpgradePoints.ToString();
			}
			else
			{
				this.m_nameText.text = string.Format(configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Arena_ArenaPointLessThan), prevLevelInfo.UpgradePoints);
			}
			ConfigDataMailInfo configDataMailInfo = configDataLoader.GetConfigDataMailInfo(levelInfo.LevelRewardMailTemplateId);
			GameObjectUtility.DestroyChildren(this.m_rewardGroupGameObject);
			if (configDataMailInfo != null && configDataMailInfo.Attachments.Count > 0)
			{
				RewardGoodsUIController.CreateRewardGoodsList(configDataMailInfo.Attachments, this.m_rewardGroupGameObject.transform, rewardGoodPrefab, null, true, 0, true);
				this.m_noRewardGameObject.SetActive(false);
			}
			else
			{
				this.m_noRewardGameObject.SetActive(true);
			}
		}

		// Token: 0x06009FFF RID: 40959 RVA: 0x002D2B70 File Offset: 0x002D0D70
		public void SetIndex(int index)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIndexInt32_hotfix != null)
			{
				this.m_SetIndexInt32_hotfix.call(new object[]
				{
					this,
					index
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_backgroundGameObject.SetActive(index % 2 != 0);
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x0600A000 RID: 40960 RVA: 0x002D2BF4 File Offset: 0x002D0DF4
		// (set) Token: 0x0600A001 RID: 40961 RVA: 0x002D2C14 File Offset: 0x002D0E14
		[DoNotToLua]
		public new ArenaPointRewardListItemUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaPointRewardListItemUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A002 RID: 40962 RVA: 0x002D2C20 File Offset: 0x002D0E20
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A003 RID: 40963 RVA: 0x002D2C2C File Offset: 0x002D0E2C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A004 RID: 40964 RVA: 0x002D2C34 File Offset: 0x002D0E34
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A005 RID: 40965 RVA: 0x002D2C3C File Offset: 0x002D0E3C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A006 RID: 40966 RVA: 0x002D2C50 File Offset: 0x002D0E50
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A007 RID: 40967 RVA: 0x002D2C58 File Offset: 0x002D0E58
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A008 RID: 40968 RVA: 0x002D2C64 File Offset: 0x002D0E64
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A009 RID: 40969 RVA: 0x002D2C70 File Offset: 0x002D0E70
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A00A RID: 40970 RVA: 0x002D2C7C File Offset: 0x002D0E7C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A00B RID: 40971 RVA: 0x002D2C88 File Offset: 0x002D0E88
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A00C RID: 40972 RVA: 0x002D2C94 File Offset: 0x002D0E94
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x002D2CA0 File Offset: 0x002D0EA0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A00E RID: 40974 RVA: 0x002D2CAC File Offset: 0x002D0EAC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A00F RID: 40975 RVA: 0x002D2CB8 File Offset: 0x002D0EB8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A010 RID: 40976 RVA: 0x002D2CC4 File Offset: 0x002D0EC4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A011 RID: 40977 RVA: 0x002D2CCC File Offset: 0x002D0ECC
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
					this.m_SetArenaLevelInfoConfigDataArenaLevelInfoConfigDataArenaLevelInfoGameObject_hotfix = (luaObj.RawGet("SetArenaLevelInfo") as LuaFunction);
					this.m_SetIndexInt32_hotfix = (luaObj.RawGet("SetIndex") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A012 RID: 40978 RVA: 0x002D2DCC File Offset: 0x002D0FCC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaPointRewardListItemUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006BB8 RID: 27576
		[AutoBind("./NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_nameText;

		// Token: 0x04006BB9 RID: 27577
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardGroupGameObject;

		// Token: 0x04006BBA RID: 27578
		[AutoBind("./BGImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_backgroundGameObject;

		// Token: 0x04006BBB RID: 27579
		[AutoBind("./NoRewardText", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_noRewardGameObject;

		// Token: 0x04006BBC RID: 27580
		[DoNotToLua]
		private ArenaPointRewardListItemUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006BBD RID: 27581
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006BBE RID: 27582
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006BBF RID: 27583
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006BC0 RID: 27584
		private LuaFunction m_SetArenaLevelInfoConfigDataArenaLevelInfoConfigDataArenaLevelInfoGameObject_hotfix;

		// Token: 0x04006BC1 RID: 27585
		private LuaFunction m_SetIndexInt32_hotfix;

		// Token: 0x02000A31 RID: 2609
		public new class LuaExportHelper
		{
			// Token: 0x0600A013 RID: 40979 RVA: 0x002D2E34 File Offset: 0x002D1034
			public LuaExportHelper(ArenaPointRewardListItemUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A014 RID: 40980 RVA: 0x002D2E44 File Offset: 0x002D1044
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A015 RID: 40981 RVA: 0x002D2E54 File Offset: 0x002D1054
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A016 RID: 40982 RVA: 0x002D2E64 File Offset: 0x002D1064
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A017 RID: 40983 RVA: 0x002D2E74 File Offset: 0x002D1074
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A018 RID: 40984 RVA: 0x002D2E8C File Offset: 0x002D108C
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A019 RID: 40985 RVA: 0x002D2E9C File Offset: 0x002D109C
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A01A RID: 40986 RVA: 0x002D2EAC File Offset: 0x002D10AC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A01B RID: 40987 RVA: 0x002D2EBC File Offset: 0x002D10BC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A01C RID: 40988 RVA: 0x002D2ECC File Offset: 0x002D10CC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A01D RID: 40989 RVA: 0x002D2EDC File Offset: 0x002D10DC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A01E RID: 40990 RVA: 0x002D2EEC File Offset: 0x002D10EC
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A01F RID: 40991 RVA: 0x002D2EFC File Offset: 0x002D10FC
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A020 RID: 40992 RVA: 0x002D2F0C File Offset: 0x002D110C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A021 RID: 40993 RVA: 0x002D2F1C File Offset: 0x002D111C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A022 RID: 40994 RVA: 0x002D2F2C File Offset: 0x002D112C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170020AE RID: 8366
			// (get) Token: 0x0600A023 RID: 40995 RVA: 0x002D2F3C File Offset: 0x002D113C
			// (set) Token: 0x0600A024 RID: 40996 RVA: 0x002D2F4C File Offset: 0x002D114C
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

			// Token: 0x170020AF RID: 8367
			// (get) Token: 0x0600A025 RID: 40997 RVA: 0x002D2F5C File Offset: 0x002D115C
			// (set) Token: 0x0600A026 RID: 40998 RVA: 0x002D2F6C File Offset: 0x002D116C
			public GameObject m_rewardGroupGameObject
			{
				get
				{
					return this.m_owner.m_rewardGroupGameObject;
				}
				set
				{
					this.m_owner.m_rewardGroupGameObject = value;
				}
			}

			// Token: 0x170020B0 RID: 8368
			// (get) Token: 0x0600A027 RID: 40999 RVA: 0x002D2F7C File Offset: 0x002D117C
			// (set) Token: 0x0600A028 RID: 41000 RVA: 0x002D2F8C File Offset: 0x002D118C
			public GameObject m_backgroundGameObject
			{
				get
				{
					return this.m_owner.m_backgroundGameObject;
				}
				set
				{
					this.m_owner.m_backgroundGameObject = value;
				}
			}

			// Token: 0x170020B1 RID: 8369
			// (get) Token: 0x0600A029 RID: 41001 RVA: 0x002D2F9C File Offset: 0x002D119C
			// (set) Token: 0x0600A02A RID: 41002 RVA: 0x002D2FAC File Offset: 0x002D11AC
			public GameObject m_noRewardGameObject
			{
				get
				{
					return this.m_owner.m_noRewardGameObject;
				}
				set
				{
					this.m_owner.m_noRewardGameObject = value;
				}
			}

			// Token: 0x0600A02B RID: 41003 RVA: 0x002D2FBC File Offset: 0x002D11BC
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x04006BC2 RID: 27586
			private ArenaPointRewardListItemUIController m_owner;
		}
	}
}
