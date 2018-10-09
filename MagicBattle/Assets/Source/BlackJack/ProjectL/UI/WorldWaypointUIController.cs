using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001067 RID: 4199
	[HotFix]
	public class WorldWaypointUIController : UIControllerBase, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06015524 RID: 87332 RVA: 0x00569548 File Offset: 0x00567748
		private WorldWaypointUIController()
		{
		}

		// Token: 0x06015525 RID: 87333 RVA: 0x00569550 File Offset: 0x00567750
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
			this.m_nameText = Utility.FindChildComponent<Text>(base.gameObject, "NameText", false);
			this.m_nameBackgroundImage = Utility.FindChildComponent<Image>(base.gameObject, "NameBG", false);
			if (this.m_nameBackgroundImage != null)
			{
				RectTransform rectTransform = this.m_nameBackgroundImage.transform as RectTransform;
				this.m_initNameBackgroundWidth = rectTransform.sizeDelta.x;
			}
		}

		// Token: 0x06015526 RID: 87334 RVA: 0x0056961C File Offset: 0x0056781C
		public void SetWaypoint(ConfigDataWaypointInfo waypointInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetWaypointConfigDataWaypointInfo_hotfix != null)
			{
				this.m_SetWaypointConfigDataWaypointInfo_hotfix.call(new object[]
				{
					this,
					waypointInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (waypointInfo == null)
			{
				return;
			}
			this.m_waypointInfo = waypointInfo;
			if (waypointInfo.FuncType == WaypointFuncType.WaypointFuncType_Scenario || waypointInfo.FuncType == WaypointFuncType.WaypointFuncType_Portal)
			{
				this.m_nameText.text = waypointInfo.Name;
				RectTransform rectTransform = this.m_nameBackgroundImage.transform as RectTransform;
				rectTransform.sizeDelta = new Vector2(Mathf.Max(this.m_nameText.preferredWidth + 55f, this.m_initNameBackgroundWidth), rectTransform.sizeDelta.y);
			}
		}

		// Token: 0x06015527 RID: 87335 RVA: 0x00569710 File Offset: 0x00567910
		public void SetStatus(WayPointStatus status)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetStatusWayPointStatus_hotfix != null)
			{
				this.m_SetStatusWayPointStatus_hotfix.call(new object[]
				{
					this,
					status
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_waypointInfo == null)
			{
				return;
			}
			if (this.m_nameText != null)
			{
				bool flag = status == WayPointStatus.Close || status == WayPointStatus.Open;
				this.m_nameText.gameObject.SetActive(!flag);
				this.m_nameBackgroundImage.gameObject.SetActive(!flag);
			}
			this.m_testText.gameObject.SetActive(LocalConfig.Instance.Data.IsDeveloper);
			this.m_testText.text = this.m_waypointInfo.ID + " " + status;
		}

		// Token: 0x06015528 RID: 87336 RVA: 0x00569820 File Offset: 0x00567A20
		public void SetCanClick(bool canClick)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetCanClickBoolean_hotfix != null)
			{
				this.m_SetCanClickBoolean_hotfix.call(new object[]
				{
					this,
					canClick
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hitGameObject.SetActive(canClick);
		}

		// Token: 0x06015529 RID: 87337 RVA: 0x0056989C File Offset: 0x00567A9C
		public bool CanClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanClick_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanClick_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_hitGameObject.activeSelf;
		}

		// Token: 0x0601552A RID: 87338 RVA: 0x00569914 File Offset: 0x00567B14
		public void IgnoreClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IgnoreClick_hotfix != null)
			{
				this.m_IgnoreClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_ignoreClick = true;
			if (this.m_isPointerDown)
			{
				this.m_isPointerDown = false;
				if (this.EventOnPointerUp != null)
				{
					this.EventOnPointerUp();
				}
			}
		}

		// Token: 0x0601552B RID: 87339 RVA: 0x005699A4 File Offset: 0x00567BA4
		public RectTransform GetClickTransform()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetClickTransform_hotfix != null)
			{
				return (RectTransform)this.m_GetClickTransform_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_hitGameObject.transform as RectTransform;
		}

		// Token: 0x0601552C RID: 87340 RVA: 0x00569A20 File Offset: 0x00567C20
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
			this.m_isPointerDown = true;
			this.m_ignoreClick = false;
			if (this.EventOnPointerDown != null)
			{
				this.EventOnPointerDown();
			}
		}

		// Token: 0x0601552D RID: 87341 RVA: 0x00569AB4 File Offset: 0x00567CB4
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
			this.m_isPointerDown = false;
			if (this.EventOnPointerUp != null)
			{
				this.EventOnPointerUp();
			}
		}

		// Token: 0x0601552E RID: 87342 RVA: 0x00569B44 File Offset: 0x00567D44
		public void OnPointerClick(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPointerClickPointerEventData_hotfix != null)
			{
				this.m_OnPointerClickPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_ignoreClick)
			{
				this.m_ignoreClick = false;
				return;
			}
			if (this.EventOnClick != null)
			{
				this.EventOnClick();
			}
		}

		// Token: 0x140004CA RID: 1226
		// (add) Token: 0x0601552F RID: 87343 RVA: 0x00569BE0 File Offset: 0x00567DE0
		// (remove) Token: 0x06015530 RID: 87344 RVA: 0x00569C7C File Offset: 0x00567E7C
		public event Action EventOnPointerDown
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerDownAction_hotfix != null)
				{
					this.m_add_EventOnPointerDownAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointerDown;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointerDown, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerDownAction_hotfix != null)
				{
					this.m_remove_EventOnPointerDownAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointerDown;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointerDown, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004CB RID: 1227
		// (add) Token: 0x06015531 RID: 87345 RVA: 0x00569D18 File Offset: 0x00567F18
		// (remove) Token: 0x06015532 RID: 87346 RVA: 0x00569DB4 File Offset: 0x00567FB4
		public event Action EventOnPointerUp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnPointerUpAction_hotfix != null)
				{
					this.m_add_EventOnPointerUpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointerUp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointerUp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnPointerUpAction_hotfix != null)
				{
					this.m_remove_EventOnPointerUpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnPointerUp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnPointerUp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140004CC RID: 1228
		// (add) Token: 0x06015533 RID: 87347 RVA: 0x00569E50 File Offset: 0x00568050
		// (remove) Token: 0x06015534 RID: 87348 RVA: 0x00569EEC File Offset: 0x005680EC
		public event Action EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction_hotfix != null)
				{
					this.m_add_EventOnClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction_hotfix != null)
				{
					this.m_remove_EventOnClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x06015535 RID: 87349 RVA: 0x00569F88 File Offset: 0x00568188
		// (set) Token: 0x06015536 RID: 87350 RVA: 0x00569FA8 File Offset: 0x005681A8
		[DoNotToLua]
		public new WorldWaypointUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldWaypointUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06015537 RID: 87351 RVA: 0x00569FB4 File Offset: 0x005681B4
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06015538 RID: 87352 RVA: 0x00569FC0 File Offset: 0x005681C0
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06015539 RID: 87353 RVA: 0x00569FC8 File Offset: 0x005681C8
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0601553A RID: 87354 RVA: 0x00569FD0 File Offset: 0x005681D0
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0601553B RID: 87355 RVA: 0x00569FE4 File Offset: 0x005681E4
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0601553C RID: 87356 RVA: 0x00569FEC File Offset: 0x005681EC
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0601553D RID: 87357 RVA: 0x00569FF8 File Offset: 0x005681F8
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0601553E RID: 87358 RVA: 0x0056A004 File Offset: 0x00568204
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0601553F RID: 87359 RVA: 0x0056A010 File Offset: 0x00568210
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06015540 RID: 87360 RVA: 0x0056A01C File Offset: 0x0056821C
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06015541 RID: 87361 RVA: 0x0056A028 File Offset: 0x00568228
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06015542 RID: 87362 RVA: 0x0056A034 File Offset: 0x00568234
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06015543 RID: 87363 RVA: 0x0056A040 File Offset: 0x00568240
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06015544 RID: 87364 RVA: 0x0056A04C File Offset: 0x0056824C
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06015545 RID: 87365 RVA: 0x0056A058 File Offset: 0x00568258
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06015546 RID: 87366 RVA: 0x0056A060 File Offset: 0x00568260
		private void __callDele_EventOnPointerDown()
		{
			Action eventOnPointerDown = this.EventOnPointerDown;
			if (eventOnPointerDown != null)
			{
				eventOnPointerDown();
			}
		}

		// Token: 0x06015547 RID: 87367 RVA: 0x0056A080 File Offset: 0x00568280
		private void __clearDele_EventOnPointerDown()
		{
			this.EventOnPointerDown = null;
		}

		// Token: 0x06015548 RID: 87368 RVA: 0x0056A08C File Offset: 0x0056828C
		private void __callDele_EventOnPointerUp()
		{
			Action eventOnPointerUp = this.EventOnPointerUp;
			if (eventOnPointerUp != null)
			{
				eventOnPointerUp();
			}
		}

		// Token: 0x06015549 RID: 87369 RVA: 0x0056A0AC File Offset: 0x005682AC
		private void __clearDele_EventOnPointerUp()
		{
			this.EventOnPointerUp = null;
		}

		// Token: 0x0601554A RID: 87370 RVA: 0x0056A0B8 File Offset: 0x005682B8
		private void __callDele_EventOnClick()
		{
			Action eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick();
			}
		}

		// Token: 0x0601554B RID: 87371 RVA: 0x0056A0D8 File Offset: 0x005682D8
		private void __clearDele_EventOnClick()
		{
			this.EventOnClick = null;
		}

		// Token: 0x0601554C RID: 87372 RVA: 0x0056A0E4 File Offset: 0x005682E4
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
					this.m_SetWaypointConfigDataWaypointInfo_hotfix = (luaObj.RawGet("SetWaypoint") as LuaFunction);
					this.m_SetStatusWayPointStatus_hotfix = (luaObj.RawGet("SetStatus") as LuaFunction);
					this.m_SetCanClickBoolean_hotfix = (luaObj.RawGet("SetCanClick") as LuaFunction);
					this.m_CanClick_hotfix = (luaObj.RawGet("CanClick") as LuaFunction);
					this.m_IgnoreClick_hotfix = (luaObj.RawGet("IgnoreClick") as LuaFunction);
					this.m_GetClickTransform_hotfix = (luaObj.RawGet("GetClickTransform") as LuaFunction);
					this.m_OnPointerDownPointerEventData_hotfix = (luaObj.RawGet("OnPointerDown") as LuaFunction);
					this.m_OnPointerUpPointerEventData_hotfix = (luaObj.RawGet("OnPointerUp") as LuaFunction);
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_add_EventOnPointerDownAction_hotfix = (luaObj.RawGet("add_EventOnPointerDown") as LuaFunction);
					this.m_remove_EventOnPointerDownAction_hotfix = (luaObj.RawGet("remove_EventOnPointerDown") as LuaFunction);
					this.m_add_EventOnPointerUpAction_hotfix = (luaObj.RawGet("add_EventOnPointerUp") as LuaFunction);
					this.m_remove_EventOnPointerUpAction_hotfix = (luaObj.RawGet("remove_EventOnPointerUp") as LuaFunction);
					this.m_add_EventOnClickAction_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601554D RID: 87373 RVA: 0x0056A328 File Offset: 0x00568528
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldWaypointUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B9F8 RID: 47608
		[AutoBind("./TestText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_testText;

		// Token: 0x0400B9F9 RID: 47609
		[AutoBind("./WorldHitImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_hitGameObject;

		// Token: 0x0400B9FA RID: 47610
		private Text m_nameText;

		// Token: 0x0400B9FB RID: 47611
		private Image m_nameBackgroundImage;

		// Token: 0x0400B9FC RID: 47612
		private ConfigDataWaypointInfo m_waypointInfo;

		// Token: 0x0400B9FD RID: 47613
		private bool m_isPointerDown;

		// Token: 0x0400B9FE RID: 47614
		private bool m_ignoreClick;

		// Token: 0x0400B9FF RID: 47615
		private float m_initNameBackgroundWidth;

		// Token: 0x0400BA00 RID: 47616
		[DoNotToLua]
		private WorldWaypointUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400BA01 RID: 47617
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400BA02 RID: 47618
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400BA03 RID: 47619
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400BA04 RID: 47620
		private LuaFunction m_SetWaypointConfigDataWaypointInfo_hotfix;

		// Token: 0x0400BA05 RID: 47621
		private LuaFunction m_SetStatusWayPointStatus_hotfix;

		// Token: 0x0400BA06 RID: 47622
		private LuaFunction m_SetCanClickBoolean_hotfix;

		// Token: 0x0400BA07 RID: 47623
		private LuaFunction m_CanClick_hotfix;

		// Token: 0x0400BA08 RID: 47624
		private LuaFunction m_IgnoreClick_hotfix;

		// Token: 0x0400BA09 RID: 47625
		private LuaFunction m_GetClickTransform_hotfix;

		// Token: 0x0400BA0A RID: 47626
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x0400BA0B RID: 47627
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x0400BA0C RID: 47628
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x0400BA0D RID: 47629
		private LuaFunction m_add_EventOnPointerDownAction_hotfix;

		// Token: 0x0400BA0E RID: 47630
		private LuaFunction m_remove_EventOnPointerDownAction_hotfix;

		// Token: 0x0400BA0F RID: 47631
		private LuaFunction m_add_EventOnPointerUpAction_hotfix;

		// Token: 0x0400BA10 RID: 47632
		private LuaFunction m_remove_EventOnPointerUpAction_hotfix;

		// Token: 0x0400BA11 RID: 47633
		private LuaFunction m_add_EventOnClickAction_hotfix;

		// Token: 0x0400BA12 RID: 47634
		private LuaFunction m_remove_EventOnClickAction_hotfix;

		// Token: 0x02001068 RID: 4200
		public new class LuaExportHelper
		{
			// Token: 0x0601554E RID: 87374 RVA: 0x0056A390 File Offset: 0x00568590
			public LuaExportHelper(WorldWaypointUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601554F RID: 87375 RVA: 0x0056A3A0 File Offset: 0x005685A0
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06015550 RID: 87376 RVA: 0x0056A3B0 File Offset: 0x005685B0
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06015551 RID: 87377 RVA: 0x0056A3C0 File Offset: 0x005685C0
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06015552 RID: 87378 RVA: 0x0056A3D0 File Offset: 0x005685D0
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06015553 RID: 87379 RVA: 0x0056A3E8 File Offset: 0x005685E8
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06015554 RID: 87380 RVA: 0x0056A3F8 File Offset: 0x005685F8
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06015555 RID: 87381 RVA: 0x0056A408 File Offset: 0x00568608
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06015556 RID: 87382 RVA: 0x0056A418 File Offset: 0x00568618
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06015557 RID: 87383 RVA: 0x0056A428 File Offset: 0x00568628
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06015558 RID: 87384 RVA: 0x0056A438 File Offset: 0x00568638
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06015559 RID: 87385 RVA: 0x0056A448 File Offset: 0x00568648
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0601555A RID: 87386 RVA: 0x0056A458 File Offset: 0x00568658
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0601555B RID: 87387 RVA: 0x0056A468 File Offset: 0x00568668
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0601555C RID: 87388 RVA: 0x0056A478 File Offset: 0x00568678
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0601555D RID: 87389 RVA: 0x0056A488 File Offset: 0x00568688
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0601555E RID: 87390 RVA: 0x0056A498 File Offset: 0x00568698
			public void __callDele_EventOnPointerDown()
			{
				this.m_owner.__callDele_EventOnPointerDown();
			}

			// Token: 0x0601555F RID: 87391 RVA: 0x0056A4A8 File Offset: 0x005686A8
			public void __clearDele_EventOnPointerDown()
			{
				this.m_owner.__clearDele_EventOnPointerDown();
			}

			// Token: 0x06015560 RID: 87392 RVA: 0x0056A4B8 File Offset: 0x005686B8
			public void __callDele_EventOnPointerUp()
			{
				this.m_owner.__callDele_EventOnPointerUp();
			}

			// Token: 0x06015561 RID: 87393 RVA: 0x0056A4C8 File Offset: 0x005686C8
			public void __clearDele_EventOnPointerUp()
			{
				this.m_owner.__clearDele_EventOnPointerUp();
			}

			// Token: 0x06015562 RID: 87394 RVA: 0x0056A4D8 File Offset: 0x005686D8
			public void __callDele_EventOnClick()
			{
				this.m_owner.__callDele_EventOnClick();
			}

			// Token: 0x06015563 RID: 87395 RVA: 0x0056A4E8 File Offset: 0x005686E8
			public void __clearDele_EventOnClick()
			{
				this.m_owner.__clearDele_EventOnClick();
			}

			// Token: 0x17003E4C RID: 15948
			// (get) Token: 0x06015564 RID: 87396 RVA: 0x0056A4F8 File Offset: 0x005686F8
			// (set) Token: 0x06015565 RID: 87397 RVA: 0x0056A508 File Offset: 0x00568708
			public Text m_testText
			{
				get
				{
					return this.m_owner.m_testText;
				}
				set
				{
					this.m_owner.m_testText = value;
				}
			}

			// Token: 0x17003E4D RID: 15949
			// (get) Token: 0x06015566 RID: 87398 RVA: 0x0056A518 File Offset: 0x00568718
			// (set) Token: 0x06015567 RID: 87399 RVA: 0x0056A528 File Offset: 0x00568728
			public GameObject m_hitGameObject
			{
				get
				{
					return this.m_owner.m_hitGameObject;
				}
				set
				{
					this.m_owner.m_hitGameObject = value;
				}
			}

			// Token: 0x17003E4E RID: 15950
			// (get) Token: 0x06015568 RID: 87400 RVA: 0x0056A538 File Offset: 0x00568738
			// (set) Token: 0x06015569 RID: 87401 RVA: 0x0056A548 File Offset: 0x00568748
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

			// Token: 0x17003E4F RID: 15951
			// (get) Token: 0x0601556A RID: 87402 RVA: 0x0056A558 File Offset: 0x00568758
			// (set) Token: 0x0601556B RID: 87403 RVA: 0x0056A568 File Offset: 0x00568768
			public Image m_nameBackgroundImage
			{
				get
				{
					return this.m_owner.m_nameBackgroundImage;
				}
				set
				{
					this.m_owner.m_nameBackgroundImage = value;
				}
			}

			// Token: 0x17003E50 RID: 15952
			// (get) Token: 0x0601556C RID: 87404 RVA: 0x0056A578 File Offset: 0x00568778
			// (set) Token: 0x0601556D RID: 87405 RVA: 0x0056A588 File Offset: 0x00568788
			public ConfigDataWaypointInfo m_waypointInfo
			{
				get
				{
					return this.m_owner.m_waypointInfo;
				}
				set
				{
					this.m_owner.m_waypointInfo = value;
				}
			}

			// Token: 0x17003E51 RID: 15953
			// (get) Token: 0x0601556E RID: 87406 RVA: 0x0056A598 File Offset: 0x00568798
			// (set) Token: 0x0601556F RID: 87407 RVA: 0x0056A5A8 File Offset: 0x005687A8
			public bool m_isPointerDown
			{
				get
				{
					return this.m_owner.m_isPointerDown;
				}
				set
				{
					this.m_owner.m_isPointerDown = value;
				}
			}

			// Token: 0x17003E52 RID: 15954
			// (get) Token: 0x06015570 RID: 87408 RVA: 0x0056A5B8 File Offset: 0x005687B8
			// (set) Token: 0x06015571 RID: 87409 RVA: 0x0056A5C8 File Offset: 0x005687C8
			public bool m_ignoreClick
			{
				get
				{
					return this.m_owner.m_ignoreClick;
				}
				set
				{
					this.m_owner.m_ignoreClick = value;
				}
			}

			// Token: 0x17003E53 RID: 15955
			// (get) Token: 0x06015572 RID: 87410 RVA: 0x0056A5D8 File Offset: 0x005687D8
			// (set) Token: 0x06015573 RID: 87411 RVA: 0x0056A5E8 File Offset: 0x005687E8
			public float m_initNameBackgroundWidth
			{
				get
				{
					return this.m_owner.m_initNameBackgroundWidth;
				}
				set
				{
					this.m_owner.m_initNameBackgroundWidth = value;
				}
			}

			// Token: 0x06015574 RID: 87412 RVA: 0x0056A5F8 File Offset: 0x005687F8
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0400BA13 RID: 47635
			private WorldWaypointUIController m_owner;
		}
	}
}
