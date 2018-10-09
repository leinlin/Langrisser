using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x0200101C RID: 4124
	[HotFix]
	public class WorldEventActorUIController : UIControllerBase, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06014D97 RID: 85399 RVA: 0x005489B4 File Offset: 0x00546BB4
		private WorldEventActorUIController()
		{
		}

		// Token: 0x06014D98 RID: 85400 RVA: 0x005489BC File Offset: 0x00546BBC
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

		// Token: 0x06014D99 RID: 85401 RVA: 0x00548A24 File Offset: 0x00546C24
		public void SetEvent(ConfigDataEventInfo eventInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEventConfigDataEventInfo_hotfix != null)
			{
				this.m_SetEventConfigDataEventInfo_hotfix.call(new object[]
				{
					this,
					eventInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (eventInfo == null)
			{
				return;
			}
			this.m_eventInfo = eventInfo;
			Vector2 v = new Vector2(0f, (float)eventInfo.MapIconY);
			GameObject asset = AssetUtility.Instance.GetAsset<GameObject>(eventInfo.MapIcon);
			if (asset != null)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(asset);
				gameObject.transform.localPosition = v;
				gameObject.transform.SetParent(this.m_iconGameObject.transform, false);
				CommonUIStateController component = gameObject.GetComponent<CommonUIStateController>();
				if (component != null)
				{
					component.SetToUIState("Standby", false, true);
				}
			}
			RectTransform rectTransform = this.m_hitGameObject.transform as RectTransform;
			rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, v.y + 100f);
			this.SetEnergy(eventInfo.EnergySuccess);
			this.m_testText.gameObject.SetActive(LocalConfig.Instance.Data.IsDeveloper);
			this.m_testText.text = eventInfo.ID.ToString();
		}

		// Token: 0x06014D9A RID: 85402 RVA: 0x00548BA8 File Offset: 0x00546DA8
		private void SetEnergy(int energy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetEnergyInt32_hotfix != null)
			{
				this.m_SetEnergyInt32_hotfix.call(new object[]
				{
					this,
					energy
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (energy > 0)
			{
				GameObject gameObject = GameObjectUtility.FindChildGameObject_R(base.gameObject, "EnergyText");
				if (gameObject != null)
				{
					Text component = gameObject.GetComponent<Text>();
					if (component != null)
					{
						component.text = energy.ToString();
					}
				}
			}
		}

		// Token: 0x06014D9B RID: 85403 RVA: 0x00548C64 File Offset: 0x00546E64
		public ConfigDataEventInfo GetEventInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEventInfo_hotfix != null)
			{
				return (ConfigDataEventInfo)this.m_GetEventInfo_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_eventInfo;
		}

		// Token: 0x06014D9C RID: 85404 RVA: 0x00548CD8 File Offset: 0x00546ED8
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

		// Token: 0x06014D9D RID: 85405 RVA: 0x00548D54 File Offset: 0x00546F54
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

		// Token: 0x06014D9E RID: 85406 RVA: 0x00548DE4 File Offset: 0x00546FE4
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

		// Token: 0x06014D9F RID: 85407 RVA: 0x00548E78 File Offset: 0x00547078
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

		// Token: 0x06014DA0 RID: 85408 RVA: 0x00548F08 File Offset: 0x00547108
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

		// Token: 0x14000496 RID: 1174
		// (add) Token: 0x06014DA1 RID: 85409 RVA: 0x00548FA4 File Offset: 0x005471A4
		// (remove) Token: 0x06014DA2 RID: 85410 RVA: 0x00549040 File Offset: 0x00547240
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

		// Token: 0x14000497 RID: 1175
		// (add) Token: 0x06014DA3 RID: 85411 RVA: 0x005490DC File Offset: 0x005472DC
		// (remove) Token: 0x06014DA4 RID: 85412 RVA: 0x00549178 File Offset: 0x00547378
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

		// Token: 0x14000498 RID: 1176
		// (add) Token: 0x06014DA5 RID: 85413 RVA: 0x00549214 File Offset: 0x00547414
		// (remove) Token: 0x06014DA6 RID: 85414 RVA: 0x005492B0 File Offset: 0x005474B0
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

		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x06014DA7 RID: 85415 RVA: 0x0054934C File Offset: 0x0054754C
		// (set) Token: 0x06014DA8 RID: 85416 RVA: 0x0054936C File Offset: 0x0054756C
		[DoNotToLua]
		public new WorldEventActorUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new WorldEventActorUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014DA9 RID: 85417 RVA: 0x00549378 File Offset: 0x00547578
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06014DAA RID: 85418 RVA: 0x00549384 File Offset: 0x00547584
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06014DAB RID: 85419 RVA: 0x0054938C File Offset: 0x0054758C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06014DAC RID: 85420 RVA: 0x00549394 File Offset: 0x00547594
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06014DAD RID: 85421 RVA: 0x005493A8 File Offset: 0x005475A8
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06014DAE RID: 85422 RVA: 0x005493B0 File Offset: 0x005475B0
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06014DAF RID: 85423 RVA: 0x005493BC File Offset: 0x005475BC
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06014DB0 RID: 85424 RVA: 0x005493C8 File Offset: 0x005475C8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06014DB1 RID: 85425 RVA: 0x005493D4 File Offset: 0x005475D4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x06014DB2 RID: 85426 RVA: 0x005493E0 File Offset: 0x005475E0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x06014DB3 RID: 85427 RVA: 0x005493EC File Offset: 0x005475EC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x06014DB4 RID: 85428 RVA: 0x005493F8 File Offset: 0x005475F8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x06014DB5 RID: 85429 RVA: 0x00549404 File Offset: 0x00547604
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x06014DB6 RID: 85430 RVA: 0x00549410 File Offset: 0x00547610
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x06014DB7 RID: 85431 RVA: 0x0054941C File Offset: 0x0054761C
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x06014DB8 RID: 85432 RVA: 0x00549424 File Offset: 0x00547624
		private void __callDele_EventOnPointerDown()
		{
			Action eventOnPointerDown = this.EventOnPointerDown;
			if (eventOnPointerDown != null)
			{
				eventOnPointerDown();
			}
		}

		// Token: 0x06014DB9 RID: 85433 RVA: 0x00549444 File Offset: 0x00547644
		private void __clearDele_EventOnPointerDown()
		{
			this.EventOnPointerDown = null;
		}

		// Token: 0x06014DBA RID: 85434 RVA: 0x00549450 File Offset: 0x00547650
		private void __callDele_EventOnPointerUp()
		{
			Action eventOnPointerUp = this.EventOnPointerUp;
			if (eventOnPointerUp != null)
			{
				eventOnPointerUp();
			}
		}

		// Token: 0x06014DBB RID: 85435 RVA: 0x00549470 File Offset: 0x00547670
		private void __clearDele_EventOnPointerUp()
		{
			this.EventOnPointerUp = null;
		}

		// Token: 0x06014DBC RID: 85436 RVA: 0x0054947C File Offset: 0x0054767C
		private void __callDele_EventOnClick()
		{
			Action eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick();
			}
		}

		// Token: 0x06014DBD RID: 85437 RVA: 0x0054949C File Offset: 0x0054769C
		private void __clearDele_EventOnClick()
		{
			this.EventOnClick = null;
		}

		// Token: 0x06014DBE RID: 85438 RVA: 0x005494A8 File Offset: 0x005476A8
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
					this.m_SetEventConfigDataEventInfo_hotfix = (luaObj.RawGet("SetEvent") as LuaFunction);
					this.m_SetEnergyInt32_hotfix = (luaObj.RawGet("SetEnergy") as LuaFunction);
					this.m_GetEventInfo_hotfix = (luaObj.RawGet("GetEventInfo") as LuaFunction);
					this.m_SetCanClickBoolean_hotfix = (luaObj.RawGet("SetCanClick") as LuaFunction);
					this.m_IgnoreClick_hotfix = (luaObj.RawGet("IgnoreClick") as LuaFunction);
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

		// Token: 0x06014DBF RID: 85439 RVA: 0x005496D4 File Offset: 0x005478D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WorldEventActorUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B68D RID: 46733
		[AutoBind("./TestText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_testText;

		// Token: 0x0400B68E RID: 46734
		[AutoBind("./Icon", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_iconGameObject;

		// Token: 0x0400B68F RID: 46735
		[AutoBind("./WorldHitImage", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_hitGameObject;

		// Token: 0x0400B690 RID: 46736
		private ConfigDataEventInfo m_eventInfo;

		// Token: 0x0400B691 RID: 46737
		private bool m_isPointerDown;

		// Token: 0x0400B692 RID: 46738
		private bool m_ignoreClick;

		// Token: 0x0400B693 RID: 46739
		[DoNotToLua]
		private WorldEventActorUIController.LuaExportHelper luaExportHelper;

		// Token: 0x0400B694 RID: 46740
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B695 RID: 46741
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B696 RID: 46742
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x0400B697 RID: 46743
		private LuaFunction m_SetEventConfigDataEventInfo_hotfix;

		// Token: 0x0400B698 RID: 46744
		private LuaFunction m_SetEnergyInt32_hotfix;

		// Token: 0x0400B699 RID: 46745
		private LuaFunction m_GetEventInfo_hotfix;

		// Token: 0x0400B69A RID: 46746
		private LuaFunction m_SetCanClickBoolean_hotfix;

		// Token: 0x0400B69B RID: 46747
		private LuaFunction m_IgnoreClick_hotfix;

		// Token: 0x0400B69C RID: 46748
		private LuaFunction m_OnPointerDownPointerEventData_hotfix;

		// Token: 0x0400B69D RID: 46749
		private LuaFunction m_OnPointerUpPointerEventData_hotfix;

		// Token: 0x0400B69E RID: 46750
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x0400B69F RID: 46751
		private LuaFunction m_add_EventOnPointerDownAction_hotfix;

		// Token: 0x0400B6A0 RID: 46752
		private LuaFunction m_remove_EventOnPointerDownAction_hotfix;

		// Token: 0x0400B6A1 RID: 46753
		private LuaFunction m_add_EventOnPointerUpAction_hotfix;

		// Token: 0x0400B6A2 RID: 46754
		private LuaFunction m_remove_EventOnPointerUpAction_hotfix;

		// Token: 0x0400B6A3 RID: 46755
		private LuaFunction m_add_EventOnClickAction_hotfix;

		// Token: 0x0400B6A4 RID: 46756
		private LuaFunction m_remove_EventOnClickAction_hotfix;

		// Token: 0x0200101D RID: 4125
		public new class LuaExportHelper
		{
			// Token: 0x06014DC0 RID: 85440 RVA: 0x0054973C File Offset: 0x0054793C
			public LuaExportHelper(WorldEventActorUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014DC1 RID: 85441 RVA: 0x0054974C File Offset: 0x0054794C
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x06014DC2 RID: 85442 RVA: 0x0054975C File Offset: 0x0054795C
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x06014DC3 RID: 85443 RVA: 0x0054976C File Offset: 0x0054796C
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x06014DC4 RID: 85444 RVA: 0x0054977C File Offset: 0x0054797C
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x06014DC5 RID: 85445 RVA: 0x00549794 File Offset: 0x00547994
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x06014DC6 RID: 85446 RVA: 0x005497A4 File Offset: 0x005479A4
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x06014DC7 RID: 85447 RVA: 0x005497B4 File Offset: 0x005479B4
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x06014DC8 RID: 85448 RVA: 0x005497C4 File Offset: 0x005479C4
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x06014DC9 RID: 85449 RVA: 0x005497D4 File Offset: 0x005479D4
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x06014DCA RID: 85450 RVA: 0x005497E4 File Offset: 0x005479E4
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x06014DCB RID: 85451 RVA: 0x005497F4 File Offset: 0x005479F4
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x06014DCC RID: 85452 RVA: 0x00549804 File Offset: 0x00547A04
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x06014DCD RID: 85453 RVA: 0x00549814 File Offset: 0x00547A14
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x06014DCE RID: 85454 RVA: 0x00549824 File Offset: 0x00547A24
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x06014DCF RID: 85455 RVA: 0x00549834 File Offset: 0x00547A34
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x06014DD0 RID: 85456 RVA: 0x00549844 File Offset: 0x00547A44
			public void __callDele_EventOnPointerDown()
			{
				this.m_owner.__callDele_EventOnPointerDown();
			}

			// Token: 0x06014DD1 RID: 85457 RVA: 0x00549854 File Offset: 0x00547A54
			public void __clearDele_EventOnPointerDown()
			{
				this.m_owner.__clearDele_EventOnPointerDown();
			}

			// Token: 0x06014DD2 RID: 85458 RVA: 0x00549864 File Offset: 0x00547A64
			public void __callDele_EventOnPointerUp()
			{
				this.m_owner.__callDele_EventOnPointerUp();
			}

			// Token: 0x06014DD3 RID: 85459 RVA: 0x00549874 File Offset: 0x00547A74
			public void __clearDele_EventOnPointerUp()
			{
				this.m_owner.__clearDele_EventOnPointerUp();
			}

			// Token: 0x06014DD4 RID: 85460 RVA: 0x00549884 File Offset: 0x00547A84
			public void __callDele_EventOnClick()
			{
				this.m_owner.__callDele_EventOnClick();
			}

			// Token: 0x06014DD5 RID: 85461 RVA: 0x00549894 File Offset: 0x00547A94
			public void __clearDele_EventOnClick()
			{
				this.m_owner.__clearDele_EventOnClick();
			}

			// Token: 0x17003D8C RID: 15756
			// (get) Token: 0x06014DD6 RID: 85462 RVA: 0x005498A4 File Offset: 0x00547AA4
			// (set) Token: 0x06014DD7 RID: 85463 RVA: 0x005498B4 File Offset: 0x00547AB4
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

			// Token: 0x17003D8D RID: 15757
			// (get) Token: 0x06014DD8 RID: 85464 RVA: 0x005498C4 File Offset: 0x00547AC4
			// (set) Token: 0x06014DD9 RID: 85465 RVA: 0x005498D4 File Offset: 0x00547AD4
			public GameObject m_iconGameObject
			{
				get
				{
					return this.m_owner.m_iconGameObject;
				}
				set
				{
					this.m_owner.m_iconGameObject = value;
				}
			}

			// Token: 0x17003D8E RID: 15758
			// (get) Token: 0x06014DDA RID: 85466 RVA: 0x005498E4 File Offset: 0x00547AE4
			// (set) Token: 0x06014DDB RID: 85467 RVA: 0x005498F4 File Offset: 0x00547AF4
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

			// Token: 0x17003D8F RID: 15759
			// (get) Token: 0x06014DDC RID: 85468 RVA: 0x00549904 File Offset: 0x00547B04
			// (set) Token: 0x06014DDD RID: 85469 RVA: 0x00549914 File Offset: 0x00547B14
			public ConfigDataEventInfo m_eventInfo
			{
				get
				{
					return this.m_owner.m_eventInfo;
				}
				set
				{
					this.m_owner.m_eventInfo = value;
				}
			}

			// Token: 0x17003D90 RID: 15760
			// (get) Token: 0x06014DDE RID: 85470 RVA: 0x00549924 File Offset: 0x00547B24
			// (set) Token: 0x06014DDF RID: 85471 RVA: 0x00549934 File Offset: 0x00547B34
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

			// Token: 0x17003D91 RID: 15761
			// (get) Token: 0x06014DE0 RID: 85472 RVA: 0x00549944 File Offset: 0x00547B44
			// (set) Token: 0x06014DE1 RID: 85473 RVA: 0x00549954 File Offset: 0x00547B54
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

			// Token: 0x06014DE2 RID: 85474 RVA: 0x00549964 File Offset: 0x00547B64
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x06014DE3 RID: 85475 RVA: 0x00549974 File Offset: 0x00547B74
			public void SetEnergy(int energy)
			{
				this.m_owner.SetEnergy(energy);
			}

			// Token: 0x0400B6A5 RID: 46757
			private WorldEventActorUIController m_owner;
		}
	}
}
