using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D8A RID: 3466
	[HotFix]
	public class PlayerHeroSkillUIController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
	{
		// Token: 0x060102EB RID: 66283 RVA: 0x0043AE88 File Offset: 0x00439088
		public void SetSkillInfoAndDescObj(ConfigDataSkillInfo skillInfo, GameObject descObj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSkillInfoAndDescObjConfigDataSkillInfoGameObject_hotfix != null)
			{
				this.m_SetSkillInfoAndDescObjConfigDataSkillInfoGameObject_hotfix.call(new object[]
				{
					this,
					skillInfo,
					descObj
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_skillInfo = skillInfo;
			this.m_popupGameObject = descObj;
			if (descObj != null)
			{
				descObj.SetActive(false);
			}
		}

		// Token: 0x060102EC RID: 66284 RVA: 0x0043AF2C File Offset: 0x0043912C
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
			if (this.EventOnSkillClick != null)
			{
				this.EventOnSkillClick(this.m_skillInfo);
			}
			if (this.m_popupGameObject != null)
			{
				this.m_popupGameObject.SetActive(true);
			}
		}

		// Token: 0x060102ED RID: 66285 RVA: 0x0043AFD8 File Offset: 0x004391D8
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
				this.m_popupGameObject.SetActive(false);
			}
		}

		// Token: 0x14000368 RID: 872
		// (add) Token: 0x060102EE RID: 66286 RVA: 0x0043B078 File Offset: 0x00439278
		// (remove) Token: 0x060102EF RID: 66287 RVA: 0x0043B114 File Offset: 0x00439314
		public event Action<ConfigDataSkillInfo> EventOnSkillClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSkillClickAction`1_hotfix != null)
				{
					this.m_add_EventOnSkillClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataSkillInfo> action = this.EventOnSkillClick;
				Action<ConfigDataSkillInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataSkillInfo>>(ref this.EventOnSkillClick, (Action<ConfigDataSkillInfo>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSkillClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnSkillClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ConfigDataSkillInfo> action = this.EventOnSkillClick;
				Action<ConfigDataSkillInfo> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ConfigDataSkillInfo>>(ref this.EventOnSkillClick, (Action<ConfigDataSkillInfo>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x060102F0 RID: 66288 RVA: 0x0043B1B0 File Offset: 0x004393B0
		// (set) Token: 0x060102F1 RID: 66289 RVA: 0x0043B1D0 File Offset: 0x004393D0
		[DoNotToLua]
		public PlayerHeroSkillUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerHeroSkillUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060102F2 RID: 66290 RVA: 0x0043B1DC File Offset: 0x004393DC
		private void __callDele_EventOnSkillClick(ConfigDataSkillInfo obj)
		{
			Action<ConfigDataSkillInfo> eventOnSkillClick = this.EventOnSkillClick;
			if (eventOnSkillClick != null)
			{
				eventOnSkillClick(obj);
			}
		}

		// Token: 0x060102F3 RID: 66291 RVA: 0x0043B200 File Offset: 0x00439400
		private void __clearDele_EventOnSkillClick(ConfigDataSkillInfo obj)
		{
			this.EventOnSkillClick = null;
		}

		// Token: 0x060102F4 RID: 66292 RVA: 0x0043B20C File Offset: 0x0043940C
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
					this.m_SetSkillInfoAndDescObjConfigDataSkillInfoGameObject_hotfix = (luaObj.RawGet("SetSkillInfoAndDescObj") as LuaFunction);
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					this.m_add_EventOnSkillClickAction`1_hotfix = (luaObj.RawGet("add_EventOnSkillClick") as LuaFunction);
					this.m_remove_EventOnSkillClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnSkillClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060102F5 RID: 66293 RVA: 0x0043B33C File Offset: 0x0043953C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerHeroSkillUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040096D1 RID: 38609
		private GameObject m_popupGameObject;

		// Token: 0x040096D2 RID: 38610
		private ConfigDataSkillInfo m_skillInfo;

		// Token: 0x040096D3 RID: 38611
		[DoNotToLua]
		private PlayerHeroSkillUIController.LuaExportHelper luaExportHelper;

		// Token: 0x040096D4 RID: 38612
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040096D5 RID: 38613
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040096D6 RID: 38614
		private LuaFunction m_SetSkillInfoAndDescObjConfigDataSkillInfoGameObject_hotfix;

		// Token: 0x040096D7 RID: 38615
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x040096D8 RID: 38616
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x040096D9 RID: 38617
		private LuaFunction m_add_EventOnSkillClickAction;

		// Token: 0x040096DA RID: 38618
		private LuaFunction m_remove_EventOnSkillClickAction;

		// Token: 0x02000D8B RID: 3467
		public class LuaExportHelper
		{
			// Token: 0x060102F6 RID: 66294 RVA: 0x0043B3A4 File Offset: 0x004395A4
			public LuaExportHelper(PlayerHeroSkillUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060102F7 RID: 66295 RVA: 0x0043B3B4 File Offset: 0x004395B4
			public void __callDele_EventOnSkillClick(ConfigDataSkillInfo obj)
			{
				this.m_owner.__callDele_EventOnSkillClick(obj);
			}

			// Token: 0x060102F8 RID: 66296 RVA: 0x0043B3C4 File Offset: 0x004395C4
			public void __clearDele_EventOnSkillClick(ConfigDataSkillInfo obj)
			{
				this.m_owner.__clearDele_EventOnSkillClick(obj);
			}

			// Token: 0x170031D6 RID: 12758
			// (get) Token: 0x060102F9 RID: 66297 RVA: 0x0043B3D4 File Offset: 0x004395D4
			// (set) Token: 0x060102FA RID: 66298 RVA: 0x0043B3E4 File Offset: 0x004395E4
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

			// Token: 0x170031D7 RID: 12759
			// (get) Token: 0x060102FB RID: 66299 RVA: 0x0043B3F4 File Offset: 0x004395F4
			// (set) Token: 0x060102FC RID: 66300 RVA: 0x0043B404 File Offset: 0x00439604
			public ConfigDataSkillInfo m_skillInfo
			{
				get
				{
					return this.m_owner.m_skillInfo;
				}
				set
				{
					this.m_owner.m_skillInfo = value;
				}
			}

			// Token: 0x040096DB RID: 38619
			private PlayerHeroSkillUIController m_owner;
		}
	}
}
