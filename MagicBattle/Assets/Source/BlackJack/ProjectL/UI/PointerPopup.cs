using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BF2 RID: 3058
	[HotFix]
	public class PointerPopup : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
	{
		// Token: 0x0600D583 RID: 54659 RVA: 0x003A3830 File Offset: 0x003A1A30
		public void SetPopupGameObject(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPopupGameObjectGameObject_hotfix != null)
			{
				this.m_SetPopupGameObjectGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_popupGameObject = go;
			if (go != null)
			{
				go.SetActive(false);
				this.m_uiStateController = go.GetComponent<CommonUIStateController>();
			}
			else
			{
				this.m_uiStateController = null;
			}
		}

		// Token: 0x0600D584 RID: 54660 RVA: 0x003A38D4 File Offset: 0x003A1AD4
		public void OnPointerDown(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerDownPointerEventData_hotfix != null)
			{
				this.m_OnPointerDownPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_popupGameObject != null)
			{
				if (this.m_uiStateController != null)
				{
					UIUtility.SetUIStateOpen(this.m_uiStateController, "PanelOpen", null, false, true);
				}
				else
				{
					this.m_popupGameObject.SetActive(true);
					UIUtility.ReplayTween(this.m_popupGameObject, null);
				}
			}
		}

		// Token: 0x0600D585 RID: 54661 RVA: 0x003A3998 File Offset: 0x003A1B98
		public void OnPointerUp(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerUpPointerEventData_hotfix != null)
			{
				this.m_OnPointerUpPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_popupGameObject != null && this.m_popupGameObject.activeSelf)
			{
				if (this.m_uiStateController != null)
				{
					UIUtility.SetUIStateClose(this.m_uiStateController, "PanelClose", null, false, true);
				}
				else
				{
					UIUtility.ReversePlayTween(this.m_popupGameObject, delegate
					{
						this.m_popupGameObject.SetActive(false);
					});
				}
			}
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x0600D586 RID: 54662 RVA: 0x003A3A6C File Offset: 0x003A1C6C
		// (set) Token: 0x0600D587 RID: 54663 RVA: 0x003A3A8C File Offset: 0x003A1C8C
		[DoNotToLua]
		public PointerPopup.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PointerPopup.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600D589 RID: 54665 RVA: 0x003A3AA8 File Offset: 0x003A1CA8
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
					this.m_SetPopupGameObjectGameObject_hotfix = (luaObj.RawGet("SetPopupGameObject") as LuaFunction);
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600D58A RID: 54666 RVA: 0x003A3BA8 File Offset: 0x003A1DA8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PointerPopup));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040083C4 RID: 33732
		private GameObject m_popupGameObject;

		// Token: 0x040083C5 RID: 33733
		private CommonUIStateController m_uiStateController;

		// Token: 0x040083C6 RID: 33734
		[DoNotToLua]
		private PointerPopup.LuaExportHelper luaExportHelper;

		// Token: 0x040083C7 RID: 33735
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040083C8 RID: 33736
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040083C9 RID: 33737
		private LuaFunction m_SetPopupGameObjectGameObject_hotfix;

		// Token: 0x040083CA RID: 33738
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x040083CB RID: 33739
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x02000BF3 RID: 3059
		public class LuaExportHelper
		{
			// Token: 0x0600D58B RID: 54667 RVA: 0x003A3C10 File Offset: 0x003A1E10
			public LuaExportHelper(PointerPopup owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170029A5 RID: 10661
			// (get) Token: 0x0600D58C RID: 54668 RVA: 0x003A3C20 File Offset: 0x003A1E20
			// (set) Token: 0x0600D58D RID: 54669 RVA: 0x003A3C30 File Offset: 0x003A1E30
			public GameObject m_popupGameObject
			{
				get
				{
					return this.m_owner.m_popupGameObject;
				}
				set
				{
					this.m_owner.m_popupGameObject = value;
				}
			}

			// Token: 0x170029A6 RID: 10662
			// (get) Token: 0x0600D58E RID: 54670 RVA: 0x003A3C40 File Offset: 0x003A1E40
			// (set) Token: 0x0600D58F RID: 54671 RVA: 0x003A3C50 File Offset: 0x003A1E50
			public CommonUIStateController m_uiStateController
			{
				get
				{
					return this.m_owner.m_uiStateController;
				}
				set
				{
					this.m_owner.m_uiStateController = value;
				}
			}

			// Token: 0x040083CC RID: 33740
			private PointerPopup m_owner;
		}
	}
}
