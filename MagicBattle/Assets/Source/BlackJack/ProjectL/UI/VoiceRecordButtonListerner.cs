using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B78 RID: 2936
	[HotFix]
	public class VoiceRecordButtonListerner : MonoBehaviour
	{
		// Token: 0x0600C79D RID: 51101 RVA: 0x003750A8 File Offset: 0x003732A8
		private void Awake()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Awake_hotfix != null)
			{
				this.m_Awake_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.TalkButton = base.gameObject.GetComponent<Button>();
			if (this.TalkButton != null)
			{
				EventTriggerListener eventTriggerListener = this.TalkButton.gameObject.AddComponent<EventTriggerListener>();
				EventTriggerListener eventTriggerListener2 = eventTriggerListener;
				eventTriggerListener2.onExit = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener2.onExit, new EventTriggerListener.VoidDelegate(this.OnExitTalkButton));
				EventTriggerListener eventTriggerListener3 = eventTriggerListener;
				eventTriggerListener3.onEnter = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener3.onEnter, new EventTriggerListener.VoidDelegate(this.OnEnterTalkButton));
				EventTriggerListener eventTriggerListener4 = eventTriggerListener;
				eventTriggerListener4.onDown = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener4.onDown, new EventTriggerListener.VoidDelegate(this.OnTalkButtonClickDown));
				EventTriggerListener eventTriggerListener5 = eventTriggerListener;
				eventTriggerListener5.onUp = (EventTriggerListener.VoidDelegate)Delegate.Combine(eventTriggerListener5.onUp, new EventTriggerListener.VoidDelegate(this.OnTalkButtonClickUp));
			}
		}

		// Token: 0x0600C79E RID: 51102 RVA: 0x003751C4 File Offset: 0x003733C4
		private void OnExitTalkButton(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnExitTalkButtonGameObject_hotfix != null)
			{
				this.m_OnExitTalkButtonGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("VoiceRecordButtonListener.OnExitTalkButton");
			if (this.EventOnExitTalkButtonClick != null)
			{
				this.EventOnExitTalkButtonClick();
			}
		}

		// Token: 0x0600C79F RID: 51103 RVA: 0x00375254 File Offset: 0x00373454
		private void OnEnterTalkButton(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEnterTalkButtonGameObject_hotfix != null)
			{
				this.m_OnEnterTalkButtonGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("VoiceRecordButtonListener.OnEnterTalkButton");
			if (this.EventOnEnterTalkButtonClick != null)
			{
				this.EventOnEnterTalkButtonClick();
			}
		}

		// Token: 0x0600C7A0 RID: 51104 RVA: 0x003752E4 File Offset: 0x003734E4
		private void OnTalkButtonClickDown(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTalkButtonClickDownGameObject_hotfix != null)
			{
				this.m_OnTalkButtonClickDownGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("VoiceRecordButtonListener.OnTalkButtonClickDown");
			if (this.m_coroutineTalkButtonTestHolding != null)
			{
				base.StopCoroutine(this.m_coroutineTalkButtonTestHolding);
			}
			this.m_coroutineTalkButtonTestHolding = base.StartCoroutine(this.OnTalkButtonTestHoding());
		}

		// Token: 0x0600C7A1 RID: 51105 RVA: 0x00375388 File Offset: 0x00373588
		private void OnTalkButtonClickUp(GameObject go)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTalkButtonClickUpGameObject_hotfix != null)
			{
				this.m_OnTalkButtonClickUpGameObject_hotfix.call(new object[]
				{
					this,
					go
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("VoiceRecordButtonListener.OnTalkButtonClickUp");
			if (this.m_coroutineTalkButtonTestHolding != null)
			{
				base.StopCoroutine(this.m_coroutineTalkButtonTestHolding);
				this.m_coroutineTalkButtonTestHolding = null;
			}
			this.SetTalkButtonSize(new Vector2(100f, 100f));
			if (this.EventOnTalkButtonClickUp != null)
			{
				this.EventOnTalkButtonClickUp();
			}
		}

		// Token: 0x0600C7A2 RID: 51106 RVA: 0x0037544C File Offset: 0x0037364C
		[DebuggerHidden]
		private IEnumerator OnTalkButtonTestHoding()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTalkButtonTestHoding_hotfix != null)
			{
				return (IEnumerator)this.m_OnTalkButtonTestHoding_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			VoiceRecordButtonListerner.<OnTalkButtonTestHoding>c__Iterator0 <OnTalkButtonTestHoding>c__Iterator = new VoiceRecordButtonListerner.<OnTalkButtonTestHoding>c__Iterator0();
			<OnTalkButtonTestHoding>c__Iterator.$this = this;
			return <OnTalkButtonTestHoding>c__Iterator;
		}

		// Token: 0x0600C7A3 RID: 51107 RVA: 0x003754C8 File Offset: 0x003736C8
		public void SetTalkButtonSize(Vector2 size)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTalkButtonSizeVector2_hotfix != null)
			{
				this.m_SetTalkButtonSizeVector2_hotfix.call(new object[]
				{
					this,
					size
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.TalkButton != null)
			{
				RectTransform rectTransform = this.TalkButton.transform as RectTransform;
				rectTransform.sizeDelta = size;
			}
		}

		// Token: 0x14000267 RID: 615
		// (add) Token: 0x0600C7A4 RID: 51108 RVA: 0x00375564 File Offset: 0x00373764
		// (remove) Token: 0x0600C7A5 RID: 51109 RVA: 0x00375600 File Offset: 0x00373800
		public event Action EventOnTalkButtonHold
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTalkButtonHoldAction_hotfix != null)
				{
					this.m_add_EventOnTalkButtonHoldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnTalkButtonHold;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnTalkButtonHold, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTalkButtonHoldAction_hotfix != null)
				{
					this.m_remove_EventOnTalkButtonHoldAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnTalkButtonHold;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnTalkButtonHold, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000268 RID: 616
		// (add) Token: 0x0600C7A6 RID: 51110 RVA: 0x0037569C File Offset: 0x0037389C
		// (remove) Token: 0x0600C7A7 RID: 51111 RVA: 0x00375738 File Offset: 0x00373938
		public event Action EventOnTalkButtonClickUp
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnTalkButtonClickUpAction_hotfix != null)
				{
					this.m_add_EventOnTalkButtonClickUpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnTalkButtonClickUp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnTalkButtonClickUp, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnTalkButtonClickUpAction_hotfix != null)
				{
					this.m_remove_EventOnTalkButtonClickUpAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnTalkButtonClickUp;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnTalkButtonClickUp, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000269 RID: 617
		// (add) Token: 0x0600C7A8 RID: 51112 RVA: 0x003757D4 File Offset: 0x003739D4
		// (remove) Token: 0x0600C7A9 RID: 51113 RVA: 0x00375870 File Offset: 0x00373A70
		public event Action EventOnExitTalkButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnExitTalkButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnExitTalkButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExitTalkButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExitTalkButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnExitTalkButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnExitTalkButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnExitTalkButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnExitTalkButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400026A RID: 618
		// (add) Token: 0x0600C7AA RID: 51114 RVA: 0x0037590C File Offset: 0x00373B0C
		// (remove) Token: 0x0600C7AB RID: 51115 RVA: 0x003759A8 File Offset: 0x00373BA8
		public event Action EventOnEnterTalkButtonClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEnterTalkButtonClickAction_hotfix != null)
				{
					this.m_add_EventOnEnterTalkButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEnterTalkButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEnterTalkButtonClick, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEnterTalkButtonClickAction_hotfix != null)
				{
					this.m_remove_EventOnEnterTalkButtonClickAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEnterTalkButtonClick;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEnterTalkButtonClick, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x0600C7AC RID: 51116 RVA: 0x00375A44 File Offset: 0x00373C44
		// (set) Token: 0x0600C7AD RID: 51117 RVA: 0x00375A64 File Offset: 0x00373C64
		[DoNotToLua]
		public VoiceRecordButtonListerner.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new VoiceRecordButtonListerner.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C7AE RID: 51118 RVA: 0x00375A70 File Offset: 0x00373C70
		private void __callDele_EventOnTalkButtonHold()
		{
			Action eventOnTalkButtonHold = this.EventOnTalkButtonHold;
			if (eventOnTalkButtonHold != null)
			{
				eventOnTalkButtonHold();
			}
		}

		// Token: 0x0600C7AF RID: 51119 RVA: 0x00375A90 File Offset: 0x00373C90
		private void __clearDele_EventOnTalkButtonHold()
		{
			this.EventOnTalkButtonHold = null;
		}

		// Token: 0x0600C7B0 RID: 51120 RVA: 0x00375A9C File Offset: 0x00373C9C
		private void __callDele_EventOnTalkButtonClickUp()
		{
			Action eventOnTalkButtonClickUp = this.EventOnTalkButtonClickUp;
			if (eventOnTalkButtonClickUp != null)
			{
				eventOnTalkButtonClickUp();
			}
		}

		// Token: 0x0600C7B1 RID: 51121 RVA: 0x00375ABC File Offset: 0x00373CBC
		private void __clearDele_EventOnTalkButtonClickUp()
		{
			this.EventOnTalkButtonClickUp = null;
		}

		// Token: 0x0600C7B2 RID: 51122 RVA: 0x00375AC8 File Offset: 0x00373CC8
		private void __callDele_EventOnExitTalkButtonClick()
		{
			Action eventOnExitTalkButtonClick = this.EventOnExitTalkButtonClick;
			if (eventOnExitTalkButtonClick != null)
			{
				eventOnExitTalkButtonClick();
			}
		}

		// Token: 0x0600C7B3 RID: 51123 RVA: 0x00375AE8 File Offset: 0x00373CE8
		private void __clearDele_EventOnExitTalkButtonClick()
		{
			this.EventOnExitTalkButtonClick = null;
		}

		// Token: 0x0600C7B4 RID: 51124 RVA: 0x00375AF4 File Offset: 0x00373CF4
		private void __callDele_EventOnEnterTalkButtonClick()
		{
			Action eventOnEnterTalkButtonClick = this.EventOnEnterTalkButtonClick;
			if (eventOnEnterTalkButtonClick != null)
			{
				eventOnEnterTalkButtonClick();
			}
		}

		// Token: 0x0600C7B5 RID: 51125 RVA: 0x00375B14 File Offset: 0x00373D14
		private void __clearDele_EventOnEnterTalkButtonClick()
		{
			this.EventOnEnterTalkButtonClick = null;
		}

		// Token: 0x0600C7B6 RID: 51126 RVA: 0x00375B20 File Offset: 0x00373D20
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
					this.m_Awake_hotfix = (luaObj.RawGet("Awake") as LuaFunction);
					this.m_OnExitTalkButtonGameObject_hotfix = (luaObj.RawGet("OnExitTalkButton") as LuaFunction);
					this.m_OnEnterTalkButtonGameObject_hotfix = (luaObj.RawGet("OnEnterTalkButton") as LuaFunction);
					this.m_OnTalkButtonClickDownGameObject_hotfix = (luaObj.RawGet("OnTalkButtonClickDown") as LuaFunction);
					this.m_OnTalkButtonClickUpGameObject_hotfix = (luaObj.RawGet("OnTalkButtonClickUp") as LuaFunction);
					this.m_OnTalkButtonTestHoding_hotfix = (luaObj.RawGet("OnTalkButtonTestHoding") as LuaFunction);
					this.m_SetTalkButtonSizeVector2_hotfix = (luaObj.RawGet("SetTalkButtonSize") as LuaFunction);
					this.m_add_EventOnTalkButtonHoldAction_hotfix = (luaObj.RawGet("add_EventOnTalkButtonHold") as LuaFunction);
					this.m_remove_EventOnTalkButtonHoldAction_hotfix = (luaObj.RawGet("remove_EventOnTalkButtonHold") as LuaFunction);
					this.m_add_EventOnTalkButtonClickUpAction_hotfix = (luaObj.RawGet("add_EventOnTalkButtonClickUp") as LuaFunction);
					this.m_remove_EventOnTalkButtonClickUpAction_hotfix = (luaObj.RawGet("remove_EventOnTalkButtonClickUp") as LuaFunction);
					this.m_add_EventOnExitTalkButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnExitTalkButtonClick") as LuaFunction);
					this.m_remove_EventOnExitTalkButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnExitTalkButtonClick") as LuaFunction);
					this.m_add_EventOnEnterTalkButtonClickAction_hotfix = (luaObj.RawGet("add_EventOnEnterTalkButtonClick") as LuaFunction);
					this.m_remove_EventOnEnterTalkButtonClickAction_hotfix = (luaObj.RawGet("remove_EventOnEnterTalkButtonClick") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C7B7 RID: 51127 RVA: 0x00375D4C File Offset: 0x00373F4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(VoiceRecordButtonListerner));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007E5C RID: 32348
		private Button TalkButton;

		// Token: 0x04007E5D RID: 32349
		private Coroutine m_coroutineTalkButtonTestHolding;

		// Token: 0x04007E62 RID: 32354
		[DoNotToLua]
		private VoiceRecordButtonListerner.LuaExportHelper luaExportHelper;

		// Token: 0x04007E63 RID: 32355
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007E64 RID: 32356
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007E65 RID: 32357
		private LuaFunction m_Awake_hotfix;

		// Token: 0x04007E66 RID: 32358
		private LuaFunction m_OnExitTalkButtonGameObject_hotfix;

		// Token: 0x04007E67 RID: 32359
		private LuaFunction m_OnEnterTalkButtonGameObject_hotfix;

		// Token: 0x04007E68 RID: 32360
		private LuaFunction m_OnTalkButtonClickDownGameObject_hotfix;

		// Token: 0x04007E69 RID: 32361
		private LuaFunction m_OnTalkButtonClickUpGameObject_hotfix;

		// Token: 0x04007E6A RID: 32362
		private LuaFunction m_OnTalkButtonTestHoding_hotfix;

		// Token: 0x04007E6B RID: 32363
		private LuaFunction m_SetTalkButtonSizeVector2_hotfix;

		// Token: 0x04007E6C RID: 32364
		private LuaFunction m_add_EventOnTalkButtonHoldAction_hotfix;

		// Token: 0x04007E6D RID: 32365
		private LuaFunction m_remove_EventOnTalkButtonHoldAction_hotfix;

		// Token: 0x04007E6E RID: 32366
		private LuaFunction m_add_EventOnTalkButtonClickUpAction_hotfix;

		// Token: 0x04007E6F RID: 32367
		private LuaFunction m_remove_EventOnTalkButtonClickUpAction_hotfix;

		// Token: 0x04007E70 RID: 32368
		private LuaFunction m_add_EventOnExitTalkButtonClickAction_hotfix;

		// Token: 0x04007E71 RID: 32369
		private LuaFunction m_remove_EventOnExitTalkButtonClickAction_hotfix;

		// Token: 0x04007E72 RID: 32370
		private LuaFunction m_add_EventOnEnterTalkButtonClickAction_hotfix;

		// Token: 0x04007E73 RID: 32371
		private LuaFunction m_remove_EventOnEnterTalkButtonClickAction_hotfix;

		// Token: 0x02000B79 RID: 2937
		public class LuaExportHelper
		{
			// Token: 0x0600C7B8 RID: 51128 RVA: 0x00375DB4 File Offset: 0x00373FB4
			public LuaExportHelper(VoiceRecordButtonListerner owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C7B9 RID: 51129 RVA: 0x00375DC4 File Offset: 0x00373FC4
			public void __callDele_EventOnTalkButtonHold()
			{
				this.m_owner.__callDele_EventOnTalkButtonHold();
			}

			// Token: 0x0600C7BA RID: 51130 RVA: 0x00375DD4 File Offset: 0x00373FD4
			public void __clearDele_EventOnTalkButtonHold()
			{
				this.m_owner.__clearDele_EventOnTalkButtonHold();
			}

			// Token: 0x0600C7BB RID: 51131 RVA: 0x00375DE4 File Offset: 0x00373FE4
			public void __callDele_EventOnTalkButtonClickUp()
			{
				this.m_owner.__callDele_EventOnTalkButtonClickUp();
			}

			// Token: 0x0600C7BC RID: 51132 RVA: 0x00375DF4 File Offset: 0x00373FF4
			public void __clearDele_EventOnTalkButtonClickUp()
			{
				this.m_owner.__clearDele_EventOnTalkButtonClickUp();
			}

			// Token: 0x0600C7BD RID: 51133 RVA: 0x00375E04 File Offset: 0x00374004
			public void __callDele_EventOnExitTalkButtonClick()
			{
				this.m_owner.__callDele_EventOnExitTalkButtonClick();
			}

			// Token: 0x0600C7BE RID: 51134 RVA: 0x00375E14 File Offset: 0x00374014
			public void __clearDele_EventOnExitTalkButtonClick()
			{
				this.m_owner.__clearDele_EventOnExitTalkButtonClick();
			}

			// Token: 0x0600C7BF RID: 51135 RVA: 0x00375E24 File Offset: 0x00374024
			public void __callDele_EventOnEnterTalkButtonClick()
			{
				this.m_owner.__callDele_EventOnEnterTalkButtonClick();
			}

			// Token: 0x0600C7C0 RID: 51136 RVA: 0x00375E34 File Offset: 0x00374034
			public void __clearDele_EventOnEnterTalkButtonClick()
			{
				this.m_owner.__clearDele_EventOnEnterTalkButtonClick();
			}

			// Token: 0x170027C6 RID: 10182
			// (get) Token: 0x0600C7C1 RID: 51137 RVA: 0x00375E44 File Offset: 0x00374044
			// (set) Token: 0x0600C7C2 RID: 51138 RVA: 0x00375E54 File Offset: 0x00374054
			public Button TalkButton
			{
				get
				{
					return this.m_owner.TalkButton;
				}
				set
				{
					this.m_owner.TalkButton = value;
				}
			}

			// Token: 0x170027C7 RID: 10183
			// (get) Token: 0x0600C7C3 RID: 51139 RVA: 0x00375E64 File Offset: 0x00374064
			// (set) Token: 0x0600C7C4 RID: 51140 RVA: 0x00375E74 File Offset: 0x00374074
			public Coroutine m_coroutineTalkButtonTestHolding
			{
				get
				{
					return this.m_owner.m_coroutineTalkButtonTestHolding;
				}
				set
				{
					this.m_owner.m_coroutineTalkButtonTestHolding = value;
				}
			}

			// Token: 0x0600C7C5 RID: 51141 RVA: 0x00375E84 File Offset: 0x00374084
			public void Awake()
			{
				this.m_owner.Awake();
			}

			// Token: 0x0600C7C6 RID: 51142 RVA: 0x00375E94 File Offset: 0x00374094
			public void OnExitTalkButton(GameObject go)
			{
				this.m_owner.OnExitTalkButton(go);
			}

			// Token: 0x0600C7C7 RID: 51143 RVA: 0x00375EA4 File Offset: 0x003740A4
			public void OnEnterTalkButton(GameObject go)
			{
				this.m_owner.OnEnterTalkButton(go);
			}

			// Token: 0x0600C7C8 RID: 51144 RVA: 0x00375EB4 File Offset: 0x003740B4
			public void OnTalkButtonClickDown(GameObject go)
			{
				this.m_owner.OnTalkButtonClickDown(go);
			}

			// Token: 0x0600C7C9 RID: 51145 RVA: 0x00375EC4 File Offset: 0x003740C4
			public void OnTalkButtonClickUp(GameObject go)
			{
				this.m_owner.OnTalkButtonClickUp(go);
			}

			// Token: 0x0600C7CA RID: 51146 RVA: 0x00375ED4 File Offset: 0x003740D4
			public IEnumerator OnTalkButtonTestHoding()
			{
				return this.m_owner.OnTalkButtonTestHoding();
			}

			// Token: 0x04007E74 RID: 32372
			private VoiceRecordButtonListerner m_owner;
		}
	}
}
