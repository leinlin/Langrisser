using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F3D RID: 3901
	[HotFix]
	public class SoldierShowItemController
	{
		// Token: 0x060136CB RID: 79563 RVA: 0x004F33A4 File Offset: 0x004F15A4
		public SoldierShowItemController(GameObject soldierItem)
		{
			this.m_item = soldierItem;
			this.m_nameText = soldierItem.transform.Find("SoldierNamePanel/SoldierNameText").GetComponent<Text>();
			this.m_spineObj = soldierItem.transform.Find("Char").gameObject;
			this.m_itemStateCtrl = soldierItem.GetComponent<CommonUIStateController>();
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorGameObject_hotfix != null)
			{
				this.m_ctorGameObject_hotfix.call(new object[]
				{
					this,
					soldierItem
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060136CC RID: 79564 RVA: 0x004F3464 File Offset: 0x004F1664
		public void SetActive(bool active)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetActiveBoolean_hotfix != null)
			{
				this.m_SetActiveBoolean_hotfix.call(new object[]
				{
					this,
					active
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_item.gameObject.SetActive(active);
		}

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x060136CD RID: 79565 RVA: 0x004F34E8 File Offset: 0x004F16E8
		// (set) Token: 0x060136CE RID: 79566 RVA: 0x004F3508 File Offset: 0x004F1708
		[DoNotToLua]
		public SoldierShowItemController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new SoldierShowItemController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060136CF RID: 79567 RVA: 0x004F3514 File Offset: 0x004F1714
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
					this.m_ctorGameObject_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_SetActiveBoolean_hotfix = (luaObj.RawGet("SetActive") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060136D0 RID: 79568 RVA: 0x004F35F8 File Offset: 0x004F17F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SoldierShowItemController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AC8F RID: 44175
		public UISpineGraphic m_soldierSkinGraphic;

		// Token: 0x0400AC90 RID: 44176
		public Text m_nameText;

		// Token: 0x0400AC91 RID: 44177
		public GameObject m_spineObj;

		// Token: 0x0400AC92 RID: 44178
		public CommonUIStateController m_itemStateCtrl;

		// Token: 0x0400AC93 RID: 44179
		private GameObject m_item;

		// Token: 0x0400AC94 RID: 44180
		[DoNotToLua]
		private SoldierShowItemController.LuaExportHelper luaExportHelper;

		// Token: 0x0400AC95 RID: 44181
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400AC96 RID: 44182
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400AC97 RID: 44183
		private LuaFunction m_ctorGameObject_hotfix;

		// Token: 0x0400AC98 RID: 44184
		private LuaFunction m_SetActiveBoolean_hotfix;

		// Token: 0x02000F3E RID: 3902
		public class LuaExportHelper
		{
			// Token: 0x060136D1 RID: 79569 RVA: 0x004F3660 File Offset: 0x004F1860
			public LuaExportHelper(SoldierShowItemController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17003A8F RID: 14991
			// (get) Token: 0x060136D2 RID: 79570 RVA: 0x004F3670 File Offset: 0x004F1870
			// (set) Token: 0x060136D3 RID: 79571 RVA: 0x004F3680 File Offset: 0x004F1880
			public GameObject m_item
			{
				get
				{
					return this.m_owner.m_item;
				}
				set
				{
					this.m_owner.m_item = value;
				}
			}

			// Token: 0x0400AC99 RID: 44185
			private SoldierShowItemController m_owner;
		}
	}
}
