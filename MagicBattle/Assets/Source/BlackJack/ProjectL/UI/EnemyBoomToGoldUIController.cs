using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000ABF RID: 2751
	[HotFix]
	public class EnemyBoomToGoldUIController : UIControllerBase
	{
		// Token: 0x0600B179 RID: 45433 RVA: 0x00312820 File Offset: 0x00310A20
		public GameObject GetEnemyGameObject()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEnemyGameObject_hotfix != null)
			{
				return (GameObject)this.m_GetEnemyGameObject_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_enemyGameObject;
		}

		// Token: 0x0600B17A RID: 45434 RVA: 0x00312894 File Offset: 0x00310A94
		[DebuggerHidden]
		public IEnumerator Co_ShowBoomAndGold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Co_ShowBoomAndGold_hotfix != null)
			{
				return (IEnumerator)this.m_Co_ShowBoomAndGold_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			EnemyBoomToGoldUIController.<Co_ShowBoomAndGold>c__Iterator0 <Co_ShowBoomAndGold>c__Iterator = new EnemyBoomToGoldUIController.<Co_ShowBoomAndGold>c__Iterator0();
			<Co_ShowBoomAndGold>c__Iterator.$this = this;
			return <Co_ShowBoomAndGold>c__Iterator;
		}

		// Token: 0x0600B17B RID: 45435 RVA: 0x00312910 File Offset: 0x00310B10
		public int GetEnemyGoldCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEnemyGoldCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetEnemyGoldCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (KeyValuePair<int, ConfigDataBanditInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataBanditInfo())
			{
				if (this.HeroID != 0 && keyValuePair.Value.HeroID == this.HeroID)
				{
					return keyValuePair.Value.Gold;
				}
			}
			global::Debug.LogWarning("Don't have this Enemy in BanditInfo!");
			return 0;
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x0600B17C RID: 45436 RVA: 0x00312A08 File Offset: 0x00310C08
		// (set) Token: 0x0600B17D RID: 45437 RVA: 0x00312A7C File Offset: 0x00310C7C
		public int HeroID
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeroID_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeroID_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<HeroID>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HeroIDInt32_hotfix != null)
				{
					this.m_set_HeroIDInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<HeroID>k__BackingField = value;
			}
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x0600B17E RID: 45438 RVA: 0x00312AF4 File Offset: 0x00310CF4
		// (set) Token: 0x0600B17F RID: 45439 RVA: 0x00312B14 File Offset: 0x00310D14
		[DoNotToLua]
		public new EnemyBoomToGoldUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new EnemyBoomToGoldUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600B180 RID: 45440 RVA: 0x00312B20 File Offset: 0x00310D20
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600B181 RID: 45441 RVA: 0x00312B2C File Offset: 0x00310D2C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600B182 RID: 45442 RVA: 0x00312B34 File Offset: 0x00310D34
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600B183 RID: 45443 RVA: 0x00312B3C File Offset: 0x00310D3C
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600B184 RID: 45444 RVA: 0x00312B50 File Offset: 0x00310D50
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600B185 RID: 45445 RVA: 0x00312B58 File Offset: 0x00310D58
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600B186 RID: 45446 RVA: 0x00312B64 File Offset: 0x00310D64
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x00312B70 File Offset: 0x00310D70
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600B188 RID: 45448 RVA: 0x00312B7C File Offset: 0x00310D7C
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600B189 RID: 45449 RVA: 0x00312B88 File Offset: 0x00310D88
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600B18A RID: 45450 RVA: 0x00312B94 File Offset: 0x00310D94
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600B18B RID: 45451 RVA: 0x00312BA0 File Offset: 0x00310DA0
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600B18C RID: 45452 RVA: 0x00312BAC File Offset: 0x00310DAC
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600B18D RID: 45453 RVA: 0x00312BB8 File Offset: 0x00310DB8
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600B18E RID: 45454 RVA: 0x00312BC4 File Offset: 0x00310DC4
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600B18F RID: 45455 RVA: 0x00312BCC File Offset: 0x00310DCC
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
					this.m_GetEnemyGameObject_hotfix = (luaObj.RawGet("GetEnemyGameObject") as LuaFunction);
					this.m_Co_ShowBoomAndGold_hotfix = (luaObj.RawGet("Co_ShowBoomAndGold") as LuaFunction);
					this.m_GetEnemyGoldCount_hotfix = (luaObj.RawGet("GetEnemyGoldCount") as LuaFunction);
					this.m_get_HeroID_hotfix = (luaObj.RawGet("get_HeroID") as LuaFunction);
					this.m_set_HeroIDInt32_hotfix = (luaObj.RawGet("set_HeroID") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600B190 RID: 45456 RVA: 0x00312CFC File Offset: 0x00310EFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EnemyBoomToGoldUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007383 RID: 29571
		private IConfigDataLoader m_configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;

		// Token: 0x04007384 RID: 29572
		[AutoBind("./Enemy", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_enemyGameObject;

		// Token: 0x04007385 RID: 29573
		[AutoBind("./Gold", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_goldGameObject;

		// Token: 0x04007386 RID: 29574
		[AutoBind("./Gold/Text", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_goldText;

		// Token: 0x04007387 RID: 29575
		[AutoBind("./DieEffect", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_dieEffectGameObject;

		// Token: 0x04007388 RID: 29576
		[DoNotToLua]
		private EnemyBoomToGoldUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04007389 RID: 29577
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400738A RID: 29578
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400738B RID: 29579
		private LuaFunction m_GetEnemyGameObject_hotfix;

		// Token: 0x0400738C RID: 29580
		private LuaFunction m_Co_ShowBoomAndGold_hotfix;

		// Token: 0x0400738D RID: 29581
		private LuaFunction m_GetEnemyGoldCount_hotfix;

		// Token: 0x0400738E RID: 29582
		private LuaFunction m_get_HeroID_hotfix;

		// Token: 0x0400738F RID: 29583
		private LuaFunction m_set_HeroIDInt32_hotfix;

		// Token: 0x02000AC0 RID: 2752
		public new class LuaExportHelper
		{
			// Token: 0x0600B191 RID: 45457 RVA: 0x00312D64 File Offset: 0x00310F64
			public LuaExportHelper(EnemyBoomToGoldUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600B192 RID: 45458 RVA: 0x00312D74 File Offset: 0x00310F74
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600B193 RID: 45459 RVA: 0x00312D84 File Offset: 0x00310F84
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600B194 RID: 45460 RVA: 0x00312D94 File Offset: 0x00310F94
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600B195 RID: 45461 RVA: 0x00312DA4 File Offset: 0x00310FA4
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600B196 RID: 45462 RVA: 0x00312DBC File Offset: 0x00310FBC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600B197 RID: 45463 RVA: 0x00312DCC File Offset: 0x00310FCC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600B198 RID: 45464 RVA: 0x00312DDC File Offset: 0x00310FDC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600B199 RID: 45465 RVA: 0x00312DEC File Offset: 0x00310FEC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600B19A RID: 45466 RVA: 0x00312DFC File Offset: 0x00310FFC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600B19B RID: 45467 RVA: 0x00312E0C File Offset: 0x0031100C
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600B19C RID: 45468 RVA: 0x00312E1C File Offset: 0x0031101C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600B19D RID: 45469 RVA: 0x00312E2C File Offset: 0x0031102C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600B19E RID: 45470 RVA: 0x00312E3C File Offset: 0x0031103C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600B19F RID: 45471 RVA: 0x00312E4C File Offset: 0x0031104C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600B1A0 RID: 45472 RVA: 0x00312E5C File Offset: 0x0031105C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x170023FA RID: 9210
			// (get) Token: 0x0600B1A1 RID: 45473 RVA: 0x00312E6C File Offset: 0x0031106C
			// (set) Token: 0x0600B1A2 RID: 45474 RVA: 0x00312E7C File Offset: 0x0031107C
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

			// Token: 0x170023FB RID: 9211
			// (get) Token: 0x0600B1A3 RID: 45475 RVA: 0x00312E8C File Offset: 0x0031108C
			// (set) Token: 0x0600B1A4 RID: 45476 RVA: 0x00312E9C File Offset: 0x0031109C
			public GameObject m_enemyGameObject
			{
				get
				{
					return this.m_owner.m_enemyGameObject;
				}
				set
				{
					this.m_owner.m_enemyGameObject = value;
				}
			}

			// Token: 0x170023FC RID: 9212
			// (get) Token: 0x0600B1A5 RID: 45477 RVA: 0x00312EAC File Offset: 0x003110AC
			// (set) Token: 0x0600B1A6 RID: 45478 RVA: 0x00312EBC File Offset: 0x003110BC
			public GameObject m_goldGameObject
			{
				get
				{
					return this.m_owner.m_goldGameObject;
				}
				set
				{
					this.m_owner.m_goldGameObject = value;
				}
			}

			// Token: 0x170023FD RID: 9213
			// (get) Token: 0x0600B1A7 RID: 45479 RVA: 0x00312ECC File Offset: 0x003110CC
			// (set) Token: 0x0600B1A8 RID: 45480 RVA: 0x00312EDC File Offset: 0x003110DC
			public Text m_goldText
			{
				get
				{
					return this.m_owner.m_goldText;
				}
				set
				{
					this.m_owner.m_goldText = value;
				}
			}

			// Token: 0x170023FE RID: 9214
			// (get) Token: 0x0600B1A9 RID: 45481 RVA: 0x00312EEC File Offset: 0x003110EC
			// (set) Token: 0x0600B1AA RID: 45482 RVA: 0x00312EFC File Offset: 0x003110FC
			public GameObject m_dieEffectGameObject
			{
				get
				{
					return this.m_owner.m_dieEffectGameObject;
				}
				set
				{
					this.m_owner.m_dieEffectGameObject = value;
				}
			}

			// Token: 0x04007390 RID: 29584
			private EnemyBoomToGoldUIController m_owner;
		}
	}
}
