using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B3A RID: 2874
	[HotFix]
	public class BigExpressionItem
	{
		// Token: 0x0600C33A RID: 49978 RVA: 0x00361F9C File Offset: 0x0036019C
		public BigExpressionItem(ConfigDataBigExpressionInfo bigExpressionInfo, GameObject expression, Action<int> click)
		{
			this.m_bigExpressionInfo = bigExpressionInfo;
			this.m_expression = expression;
			this.m_onClick = click;
			this.imageIcon = expression.GetComponent<Image>();
			this.imageIcon.sprite = AssetUtility.Instance.GetSprite(bigExpressionInfo.ExpressionIconPath);
			expression.GetComponent<ButtonEx>().onClick.AddListener(new UnityAction(this.OnClick));
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorConfigDataBigExpressionInfoGameObjectAction`1_hotfix != null)
			{
				this.m_ctorConfigDataBigExpressionInfoGameObjectAction`1_hotfix.call(new object[]
				{
					this,
					bigExpressionInfo,
					expression,
					click
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600C33B RID: 49979 RVA: 0x0036208C File Offset: 0x0036028C
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
			this.m_onClick(this.m_bigExpressionInfo.ID);
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x0600C33C RID: 49980 RVA: 0x00362104 File Offset: 0x00360304
		// (set) Token: 0x0600C33D RID: 49981 RVA: 0x00362124 File Offset: 0x00360324
		[DoNotToLua]
		public BigExpressionItem.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BigExpressionItem.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C33E RID: 49982 RVA: 0x00362130 File Offset: 0x00360330
		private void __callDele_m_onClick(int obj)
		{
			Action<int> onClick = this.m_onClick;
			if (onClick != null)
			{
				onClick(obj);
			}
		}

		// Token: 0x0600C33F RID: 49983 RVA: 0x00362154 File Offset: 0x00360354
		private void __clearDele_m_onClick(int obj)
		{
			this.m_onClick = null;
		}

		// Token: 0x0600C340 RID: 49984 RVA: 0x00362160 File Offset: 0x00360360
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
					this.m_ctorConfigDataBigExpressionInfoGameObjectAction`1_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C341 RID: 49985 RVA: 0x00362244 File Offset: 0x00360444
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BigExpressionItem));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007BD4 RID: 31700
		private Action<int> m_onClick;

		// Token: 0x04007BD5 RID: 31701
		public ConfigDataBigExpressionInfo m_bigExpressionInfo;

		// Token: 0x04007BD6 RID: 31702
		public GameObject m_expression;

		// Token: 0x04007BD7 RID: 31703
		private Image imageIcon;

		// Token: 0x04007BD8 RID: 31704
		[DoNotToLua]
		private BigExpressionItem.LuaExportHelper luaExportHelper;

		// Token: 0x04007BD9 RID: 31705
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007BDA RID: 31706
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007BDB RID: 31707
		private LuaFunction m_ctorConfigDataBigExpressionInfoGameObjectAction;

		// Token: 0x04007BDC RID: 31708
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x02000B3B RID: 2875
		public class LuaExportHelper
		{
			// Token: 0x0600C342 RID: 49986 RVA: 0x003622AC File Offset: 0x003604AC
			public LuaExportHelper(BigExpressionItem owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C343 RID: 49987 RVA: 0x003622BC File Offset: 0x003604BC
			public void __callDele_m_onClick(int obj)
			{
				this.m_owner.__callDele_m_onClick(obj);
			}

			// Token: 0x0600C344 RID: 49988 RVA: 0x003622CC File Offset: 0x003604CC
			public void __clearDele_m_onClick(int obj)
			{
				this.m_owner.__clearDele_m_onClick(obj);
			}

			// Token: 0x1700272E RID: 10030
			// (get) Token: 0x0600C345 RID: 49989 RVA: 0x003622DC File Offset: 0x003604DC
			// (set) Token: 0x0600C346 RID: 49990 RVA: 0x003622EC File Offset: 0x003604EC
			public Action<int> m_onClick
			{
				get
				{
					return this.m_owner.m_onClick;
				}
				set
				{
					this.m_owner.m_onClick = value;
				}
			}

			// Token: 0x1700272F RID: 10031
			// (get) Token: 0x0600C347 RID: 49991 RVA: 0x003622FC File Offset: 0x003604FC
			// (set) Token: 0x0600C348 RID: 49992 RVA: 0x0036230C File Offset: 0x0036050C
			public Image imageIcon
			{
				get
				{
					return this.m_owner.imageIcon;
				}
				set
				{
					this.m_owner.imageIcon = value;
				}
			}

			// Token: 0x0600C349 RID: 49993 RVA: 0x0036231C File Offset: 0x0036051C
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x04007BDD RID: 31709
			private BigExpressionItem m_owner;
		}
	}
}
