using System;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009FE RID: 2558
	[HotFix]
	public class ArenaActionOrderButton : UIControllerBase, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler, IEventSystemHandler
	{
		// Token: 0x0600997A RID: 39290 RVA: 0x002BD168 File Offset: 0x002BB368
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
			this.m_button.onClick.AddListener(new UnityAction(this.OnClick));
		}

		// Token: 0x0600997B RID: 39291 RVA: 0x002BD1EC File Offset: 0x002BB3EC
		public void Destroy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Destroy_hotfix != null)
			{
				this.m_Destroy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UnityEngine.Object.Destroy(base.gameObject);
		}

		// Token: 0x0600997C RID: 39292 RVA: 0x002BD258 File Offset: 0x002BB458
		public void SetHero(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeroBattleHero_hotfix != null)
			{
				this.m_SetHeroBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_hero = hero;
			if (hero == null)
			{
				return;
			}
			ConfigDataCharImageInfo charImageInfo = hero.HeroInfo.GetCharImageInfo(hero.StarLevel);
			if (charImageInfo != null)
			{
				this.m_heroIconImage.sprite = AssetUtility.Instance.GetSprite(charImageInfo.RoundHeadImage);
			}
			ConfigDataArmyInfo armyInfo = hero.GetActiveJob().JobConnectionInfo.m_jobInfo.m_armyInfo;
			this.m_armyIconImage.sprite = AssetUtility.Instance.GetSprite(armyInfo.Icon);
		}

		// Token: 0x0600997D RID: 39293 RVA: 0x002BD33C File Offset: 0x002BB53C
		public BattleHero GetHero()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHero_hotfix != null)
			{
				return (BattleHero)this.m_GetHero_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_hero;
		}

		// Token: 0x0600997E RID: 39294 RVA: 0x002BD3B0 File Offset: 0x002BB5B0
		public void SetIndex(int idx)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetIndexInt32_hotfix != null)
			{
				this.m_SetIndexInt32_hotfix.call(new object[]
				{
					this,
					idx
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_index = idx;
		}

		// Token: 0x0600997F RID: 39295 RVA: 0x002BD428 File Offset: 0x002BB628
		public int GetIndex()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetIndex_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetIndex_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_index;
		}

		// Token: 0x06009980 RID: 39296 RVA: 0x002BD49C File Offset: 0x002BB69C
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
			if (this.EventOnClick != null)
			{
				this.EventOnClick(this);
			}
		}

		// Token: 0x06009981 RID: 39297 RVA: 0x002BD514 File Offset: 0x002BB714
		public void OnBeginDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBeginDragPointerEventData_hotfix != null)
			{
				this.m_OnBeginDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_button.interactable = false;
			if (this.EventOnBeginDrag != null)
			{
				this.EventOnBeginDrag(this, eventData);
			}
		}

		// Token: 0x06009982 RID: 39298 RVA: 0x002BD5A8 File Offset: 0x002BB7A8
		public void OnEndDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnEndDragPointerEventData_hotfix != null)
			{
				this.m_OnEndDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_button.interactable = true;
			if (this.EventOnEndDrag != null)
			{
				this.EventOnEndDrag(this, eventData);
			}
		}

		// Token: 0x06009983 RID: 39299 RVA: 0x002BD63C File Offset: 0x002BB83C
		public void OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDragPointerEventData_hotfix != null)
			{
				this.m_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnDrag != null)
			{
				this.EventOnDrag(eventData);
			}
		}

		// Token: 0x06009984 RID: 39300 RVA: 0x002BD6C4 File Offset: 0x002BB8C4
		public void OnDrop(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDropPointerEventData_hotfix != null)
			{
				this.m_OnDropPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.EventOnDrop != null)
			{
				this.EventOnDrop(eventData);
			}
		}

		// Token: 0x140001BC RID: 444
		// (add) Token: 0x06009985 RID: 39301 RVA: 0x002BD74C File Offset: 0x002BB94C
		// (remove) Token: 0x06009986 RID: 39302 RVA: 0x002BD7E8 File Offset: 0x002BB9E8
		public event Action<ArenaActionOrderButton> EventOnClick
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnClickAction`1_hotfix != null)
				{
					this.m_add_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaActionOrderButton> action = this.EventOnClick;
				Action<ArenaActionOrderButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaActionOrderButton>>(ref this.EventOnClick, (Action<ArenaActionOrderButton>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnClickAction`1_hotfix != null)
				{
					this.m_remove_EventOnClickAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaActionOrderButton> action = this.EventOnClick;
				Action<ArenaActionOrderButton> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaActionOrderButton>>(ref this.EventOnClick, (Action<ArenaActionOrderButton>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001BD RID: 445
		// (add) Token: 0x06009987 RID: 39303 RVA: 0x002BD884 File Offset: 0x002BBA84
		// (remove) Token: 0x06009988 RID: 39304 RVA: 0x002BD920 File Offset: 0x002BBB20
		public event Action<ArenaActionOrderButton, PointerEventData> EventOnBeginDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBeginDragAction`2_hotfix != null)
				{
					this.m_add_EventOnBeginDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaActionOrderButton, PointerEventData> action = this.EventOnBeginDrag;
				Action<ArenaActionOrderButton, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaActionOrderButton, PointerEventData>>(ref this.EventOnBeginDrag, (Action<ArenaActionOrderButton, PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBeginDragAction`2_hotfix != null)
				{
					this.m_remove_EventOnBeginDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaActionOrderButton, PointerEventData> action = this.EventOnBeginDrag;
				Action<ArenaActionOrderButton, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaActionOrderButton, PointerEventData>>(ref this.EventOnBeginDrag, (Action<ArenaActionOrderButton, PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001BE RID: 446
		// (add) Token: 0x06009989 RID: 39305 RVA: 0x002BD9BC File Offset: 0x002BBBBC
		// (remove) Token: 0x0600998A RID: 39306 RVA: 0x002BDA58 File Offset: 0x002BBC58
		public event Action<ArenaActionOrderButton, PointerEventData> EventOnEndDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEndDragAction`2_hotfix != null)
				{
					this.m_add_EventOnEndDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaActionOrderButton, PointerEventData> action = this.EventOnEndDrag;
				Action<ArenaActionOrderButton, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaActionOrderButton, PointerEventData>>(ref this.EventOnEndDrag, (Action<ArenaActionOrderButton, PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEndDragAction`2_hotfix != null)
				{
					this.m_remove_EventOnEndDragAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaActionOrderButton, PointerEventData> action = this.EventOnEndDrag;
				Action<ArenaActionOrderButton, PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaActionOrderButton, PointerEventData>>(ref this.EventOnEndDrag, (Action<ArenaActionOrderButton, PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001BF RID: 447
		// (add) Token: 0x0600998B RID: 39307 RVA: 0x002BDAF4 File Offset: 0x002BBCF4
		// (remove) Token: 0x0600998C RID: 39308 RVA: 0x002BDB90 File Offset: 0x002BBD90
		public event Action<PointerEventData> EventOnDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDragAction`1_hotfix != null)
				{
					this.m_add_EventOnDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrag, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDragAction`1_hotfix != null)
				{
					this.m_remove_EventOnDragAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrag;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrag, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001C0 RID: 448
		// (add) Token: 0x0600998D RID: 39309 RVA: 0x002BDC2C File Offset: 0x002BBE2C
		// (remove) Token: 0x0600998E RID: 39310 RVA: 0x002BDCC8 File Offset: 0x002BBEC8
		public event Action<PointerEventData> EventOnDrop
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnDropAction`1_hotfix != null)
				{
					this.m_add_EventOnDropAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrop;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrop, (Action<PointerEventData>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnDropAction`1_hotfix != null)
				{
					this.m_remove_EventOnDropAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<PointerEventData> action = this.EventOnDrop;
				Action<PointerEventData> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<PointerEventData>>(ref this.EventOnDrop, (Action<PointerEventData>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x0600998F RID: 39311 RVA: 0x002BDD64 File Offset: 0x002BBF64
		// (set) Token: 0x06009990 RID: 39312 RVA: 0x002BDD84 File Offset: 0x002BBF84
		[DoNotToLua]
		public new ArenaActionOrderButton.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaActionOrderButton.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009991 RID: 39313 RVA: 0x002BDD90 File Offset: 0x002BBF90
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x06009992 RID: 39314 RVA: 0x002BDD9C File Offset: 0x002BBF9C
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x06009993 RID: 39315 RVA: 0x002BDDA4 File Offset: 0x002BBFA4
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x06009994 RID: 39316 RVA: 0x002BDDAC File Offset: 0x002BBFAC
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x06009995 RID: 39317 RVA: 0x002BDDC0 File Offset: 0x002BBFC0
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x06009996 RID: 39318 RVA: 0x002BDDC8 File Offset: 0x002BBFC8
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x06009997 RID: 39319 RVA: 0x002BDDD4 File Offset: 0x002BBFD4
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x06009998 RID: 39320 RVA: 0x002BDDE0 File Offset: 0x002BBFE0
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x06009999 RID: 39321 RVA: 0x002BDDEC File Offset: 0x002BBFEC
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600999A RID: 39322 RVA: 0x002BDDF8 File Offset: 0x002BBFF8
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600999B RID: 39323 RVA: 0x002BDE04 File Offset: 0x002BC004
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600999C RID: 39324 RVA: 0x002BDE10 File Offset: 0x002BC010
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600999D RID: 39325 RVA: 0x002BDE1C File Offset: 0x002BC01C
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600999E RID: 39326 RVA: 0x002BDE28 File Offset: 0x002BC028
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600999F RID: 39327 RVA: 0x002BDE34 File Offset: 0x002BC034
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x060099A0 RID: 39328 RVA: 0x002BDE3C File Offset: 0x002BC03C
		private void __callDele_EventOnClick(ArenaActionOrderButton obj)
		{
			Action<ArenaActionOrderButton> eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick(obj);
			}
		}

		// Token: 0x060099A1 RID: 39329 RVA: 0x002BDE60 File Offset: 0x002BC060
		private void __clearDele_EventOnClick(ArenaActionOrderButton obj)
		{
			this.EventOnClick = null;
		}

		// Token: 0x060099A2 RID: 39330 RVA: 0x002BDE6C File Offset: 0x002BC06C
		private void __callDele_EventOnBeginDrag(ArenaActionOrderButton arg1, PointerEventData arg2)
		{
			Action<ArenaActionOrderButton, PointerEventData> eventOnBeginDrag = this.EventOnBeginDrag;
			if (eventOnBeginDrag != null)
			{
				eventOnBeginDrag(arg1, arg2);
			}
		}

		// Token: 0x060099A3 RID: 39331 RVA: 0x002BDE90 File Offset: 0x002BC090
		private void __clearDele_EventOnBeginDrag(ArenaActionOrderButton arg1, PointerEventData arg2)
		{
			this.EventOnBeginDrag = null;
		}

		// Token: 0x060099A4 RID: 39332 RVA: 0x002BDE9C File Offset: 0x002BC09C
		private void __callDele_EventOnEndDrag(ArenaActionOrderButton arg1, PointerEventData arg2)
		{
			Action<ArenaActionOrderButton, PointerEventData> eventOnEndDrag = this.EventOnEndDrag;
			if (eventOnEndDrag != null)
			{
				eventOnEndDrag(arg1, arg2);
			}
		}

		// Token: 0x060099A5 RID: 39333 RVA: 0x002BDEC0 File Offset: 0x002BC0C0
		private void __clearDele_EventOnEndDrag(ArenaActionOrderButton arg1, PointerEventData arg2)
		{
			this.EventOnEndDrag = null;
		}

		// Token: 0x060099A6 RID: 39334 RVA: 0x002BDECC File Offset: 0x002BC0CC
		private void __callDele_EventOnDrag(PointerEventData obj)
		{
			Action<PointerEventData> eventOnDrag = this.EventOnDrag;
			if (eventOnDrag != null)
			{
				eventOnDrag(obj);
			}
		}

		// Token: 0x060099A7 RID: 39335 RVA: 0x002BDEF0 File Offset: 0x002BC0F0
		private void __clearDele_EventOnDrag(PointerEventData obj)
		{
			this.EventOnDrag = null;
		}

		// Token: 0x060099A8 RID: 39336 RVA: 0x002BDEFC File Offset: 0x002BC0FC
		private void __callDele_EventOnDrop(PointerEventData obj)
		{
			Action<PointerEventData> eventOnDrop = this.EventOnDrop;
			if (eventOnDrop != null)
			{
				eventOnDrop(obj);
			}
		}

		// Token: 0x060099A9 RID: 39337 RVA: 0x002BDF20 File Offset: 0x002BC120
		private void __clearDele_EventOnDrop(PointerEventData obj)
		{
			this.EventOnDrop = null;
		}

		// Token: 0x060099AA RID: 39338 RVA: 0x002BDF2C File Offset: 0x002BC12C
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
					this.m_Destroy_hotfix = (luaObj.RawGet("Destroy") as LuaFunction);
					this.m_SetHeroBattleHero_hotfix = (luaObj.RawGet("SetHero") as LuaFunction);
					this.m_GetHero_hotfix = (luaObj.RawGet("GetHero") as LuaFunction);
					this.m_SetIndexInt32_hotfix = (luaObj.RawGet("SetIndex") as LuaFunction);
					this.m_GetIndex_hotfix = (luaObj.RawGet("GetIndex") as LuaFunction);
					this.m_OnClick_hotfix = (luaObj.RawGet("OnClick") as LuaFunction);
					this.m_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnBeginDrag") as LuaFunction);
					this.m_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_OnDragPointerEventData_hotfix = (luaObj.RawGet("OnDrag") as LuaFunction);
					this.m_OnDropPointerEventData_hotfix = (luaObj.RawGet("OnDrop") as LuaFunction);
					this.m_add_EventOnClickAction`1_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction`1_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					this.m_add_EventOnBeginDragAction`2_hotfix = (luaObj.RawGet("add_EventOnBeginDrag") as LuaFunction);
					this.m_remove_EventOnBeginDragAction`2_hotfix = (luaObj.RawGet("remove_EventOnBeginDrag") as LuaFunction);
					this.m_add_EventOnEndDragAction`2_hotfix = (luaObj.RawGet("add_EventOnEndDrag") as LuaFunction);
					this.m_remove_EventOnEndDragAction`2_hotfix = (luaObj.RawGet("remove_EventOnEndDrag") as LuaFunction);
					this.m_add_EventOnDragAction`1_hotfix = (luaObj.RawGet("add_EventOnDrag") as LuaFunction);
					this.m_remove_EventOnDragAction`1_hotfix = (luaObj.RawGet("remove_EventOnDrag") as LuaFunction);
					this.m_add_EventOnDropAction`1_hotfix = (luaObj.RawGet("add_EventOnDrop") as LuaFunction);
					this.m_remove_EventOnDropAction`1_hotfix = (luaObj.RawGet("remove_EventOnDrop") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060099AB RID: 39339 RVA: 0x002BE1EC File Offset: 0x002BC3EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaActionOrderButton));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400692F RID: 26927
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_button;

		// Token: 0x04006930 RID: 26928
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_heroIconImage;

		// Token: 0x04006931 RID: 26929
		[AutoBind("./ArmyIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_armyIconImage;

		// Token: 0x04006932 RID: 26930
		private BattleHero m_hero;

		// Token: 0x04006933 RID: 26931
		private int m_index;

		// Token: 0x04006934 RID: 26932
		[DoNotToLua]
		private ArenaActionOrderButton.LuaExportHelper luaExportHelper;

		// Token: 0x04006935 RID: 26933
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006936 RID: 26934
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006937 RID: 26935
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006938 RID: 26936
		private LuaFunction m_Destroy_hotfix;

		// Token: 0x04006939 RID: 26937
		private LuaFunction m_SetHeroBattleHero_hotfix;

		// Token: 0x0400693A RID: 26938
		private LuaFunction m_GetHero_hotfix;

		// Token: 0x0400693B RID: 26939
		private LuaFunction m_SetIndexInt32_hotfix;

		// Token: 0x0400693C RID: 26940
		private LuaFunction m_GetIndex_hotfix;

		// Token: 0x0400693D RID: 26941
		private LuaFunction m_OnClick_hotfix;

		// Token: 0x0400693E RID: 26942
		private LuaFunction m_OnBeginDragPointerEventData_hotfix;

		// Token: 0x0400693F RID: 26943
		private LuaFunction m_OnEndDragPointerEventData_hotfix;

		// Token: 0x04006940 RID: 26944
		private LuaFunction m_OnDragPointerEventData_hotfix;

		// Token: 0x04006941 RID: 26945
		private LuaFunction m_OnDropPointerEventData_hotfix;

		// Token: 0x04006942 RID: 26946
		private LuaFunction m_add_EventOnClickAction;

		// Token: 0x04006943 RID: 26947
		private LuaFunction m_remove_EventOnClickAction;

		// Token: 0x04006944 RID: 26948
		private LuaFunction m_add_EventOnBeginDragAction;

		// Token: 0x04006945 RID: 26949
		private LuaFunction m_remove_EventOnBeginDragAction;

		// Token: 0x04006946 RID: 26950
		private LuaFunction m_add_EventOnEndDragAction;

		// Token: 0x04006947 RID: 26951
		private LuaFunction m_remove_EventOnEndDragAction;

		// Token: 0x04006948 RID: 26952
		private LuaFunction m_add_EventOnDragAction;

		// Token: 0x04006949 RID: 26953
		private LuaFunction m_remove_EventOnDragAction;

		// Token: 0x0400694A RID: 26954
		private LuaFunction m_add_EventOnDropAction;

		// Token: 0x0400694B RID: 26955
		private LuaFunction m_remove_EventOnDropAction;

		// Token: 0x020009FF RID: 2559
		public new class LuaExportHelper
		{
			// Token: 0x060099AC RID: 39340 RVA: 0x002BE254 File Offset: 0x002BC454
			public LuaExportHelper(ArenaActionOrderButton owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060099AD RID: 39341 RVA: 0x002BE264 File Offset: 0x002BC464
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x060099AE RID: 39342 RVA: 0x002BE274 File Offset: 0x002BC474
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x060099AF RID: 39343 RVA: 0x002BE284 File Offset: 0x002BC484
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x060099B0 RID: 39344 RVA: 0x002BE294 File Offset: 0x002BC494
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x060099B1 RID: 39345 RVA: 0x002BE2AC File Offset: 0x002BC4AC
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x060099B2 RID: 39346 RVA: 0x002BE2BC File Offset: 0x002BC4BC
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x060099B3 RID: 39347 RVA: 0x002BE2CC File Offset: 0x002BC4CC
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x060099B4 RID: 39348 RVA: 0x002BE2DC File Offset: 0x002BC4DC
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x060099B5 RID: 39349 RVA: 0x002BE2EC File Offset: 0x002BC4EC
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x060099B6 RID: 39350 RVA: 0x002BE2FC File Offset: 0x002BC4FC
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x060099B7 RID: 39351 RVA: 0x002BE30C File Offset: 0x002BC50C
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x060099B8 RID: 39352 RVA: 0x002BE31C File Offset: 0x002BC51C
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x060099B9 RID: 39353 RVA: 0x002BE32C File Offset: 0x002BC52C
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x060099BA RID: 39354 RVA: 0x002BE33C File Offset: 0x002BC53C
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x060099BB RID: 39355 RVA: 0x002BE34C File Offset: 0x002BC54C
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x060099BC RID: 39356 RVA: 0x002BE35C File Offset: 0x002BC55C
			public void __callDele_EventOnClick(ArenaActionOrderButton obj)
			{
				this.m_owner.__callDele_EventOnClick(obj);
			}

			// Token: 0x060099BD RID: 39357 RVA: 0x002BE36C File Offset: 0x002BC56C
			public void __clearDele_EventOnClick(ArenaActionOrderButton obj)
			{
				this.m_owner.__clearDele_EventOnClick(obj);
			}

			// Token: 0x060099BE RID: 39358 RVA: 0x002BE37C File Offset: 0x002BC57C
			public void __callDele_EventOnBeginDrag(ArenaActionOrderButton arg1, PointerEventData arg2)
			{
				this.m_owner.__callDele_EventOnBeginDrag(arg1, arg2);
			}

			// Token: 0x060099BF RID: 39359 RVA: 0x002BE38C File Offset: 0x002BC58C
			public void __clearDele_EventOnBeginDrag(ArenaActionOrderButton arg1, PointerEventData arg2)
			{
				this.m_owner.__clearDele_EventOnBeginDrag(arg1, arg2);
			}

			// Token: 0x060099C0 RID: 39360 RVA: 0x002BE39C File Offset: 0x002BC59C
			public void __callDele_EventOnEndDrag(ArenaActionOrderButton arg1, PointerEventData arg2)
			{
				this.m_owner.__callDele_EventOnEndDrag(arg1, arg2);
			}

			// Token: 0x060099C1 RID: 39361 RVA: 0x002BE3AC File Offset: 0x002BC5AC
			public void __clearDele_EventOnEndDrag(ArenaActionOrderButton arg1, PointerEventData arg2)
			{
				this.m_owner.__clearDele_EventOnEndDrag(arg1, arg2);
			}

			// Token: 0x060099C2 RID: 39362 RVA: 0x002BE3BC File Offset: 0x002BC5BC
			public void __callDele_EventOnDrag(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnDrag(obj);
			}

			// Token: 0x060099C3 RID: 39363 RVA: 0x002BE3CC File Offset: 0x002BC5CC
			public void __clearDele_EventOnDrag(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnDrag(obj);
			}

			// Token: 0x060099C4 RID: 39364 RVA: 0x002BE3DC File Offset: 0x002BC5DC
			public void __callDele_EventOnDrop(PointerEventData obj)
			{
				this.m_owner.__callDele_EventOnDrop(obj);
			}

			// Token: 0x060099C5 RID: 39365 RVA: 0x002BE3EC File Offset: 0x002BC5EC
			public void __clearDele_EventOnDrop(PointerEventData obj)
			{
				this.m_owner.__clearDele_EventOnDrop(obj);
			}

			// Token: 0x17001F7E RID: 8062
			// (get) Token: 0x060099C6 RID: 39366 RVA: 0x002BE3FC File Offset: 0x002BC5FC
			// (set) Token: 0x060099C7 RID: 39367 RVA: 0x002BE40C File Offset: 0x002BC60C
			public Button m_button
			{
				get
				{
					return this.m_owner.m_button;
				}
				set
				{
					this.m_owner.m_button = value;
				}
			}

			// Token: 0x17001F7F RID: 8063
			// (get) Token: 0x060099C8 RID: 39368 RVA: 0x002BE41C File Offset: 0x002BC61C
			// (set) Token: 0x060099C9 RID: 39369 RVA: 0x002BE42C File Offset: 0x002BC62C
			public Image m_heroIconImage
			{
				get
				{
					return this.m_owner.m_heroIconImage;
				}
				set
				{
					this.m_owner.m_heroIconImage = value;
				}
			}

			// Token: 0x17001F80 RID: 8064
			// (get) Token: 0x060099CA RID: 39370 RVA: 0x002BE43C File Offset: 0x002BC63C
			// (set) Token: 0x060099CB RID: 39371 RVA: 0x002BE44C File Offset: 0x002BC64C
			public Image m_armyIconImage
			{
				get
				{
					return this.m_owner.m_armyIconImage;
				}
				set
				{
					this.m_owner.m_armyIconImage = value;
				}
			}

			// Token: 0x17001F81 RID: 8065
			// (get) Token: 0x060099CC RID: 39372 RVA: 0x002BE45C File Offset: 0x002BC65C
			// (set) Token: 0x060099CD RID: 39373 RVA: 0x002BE46C File Offset: 0x002BC66C
			public BattleHero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x17001F82 RID: 8066
			// (get) Token: 0x060099CE RID: 39374 RVA: 0x002BE47C File Offset: 0x002BC67C
			// (set) Token: 0x060099CF RID: 39375 RVA: 0x002BE48C File Offset: 0x002BC68C
			public int m_index
			{
				get
				{
					return this.m_owner.m_index;
				}
				set
				{
					this.m_owner.m_index = value;
				}
			}

			// Token: 0x060099D0 RID: 39376 RVA: 0x002BE49C File Offset: 0x002BC69C
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x060099D1 RID: 39377 RVA: 0x002BE4AC File Offset: 0x002BC6AC
			public void OnClick()
			{
				this.m_owner.OnClick();
			}

			// Token: 0x0400694C RID: 26956
			private ArenaActionOrderButton m_owner;
		}
	}
}
