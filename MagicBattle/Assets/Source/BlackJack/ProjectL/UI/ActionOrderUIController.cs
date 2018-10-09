using System;
using System.Collections.Generic;
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
	// Token: 0x02000A5A RID: 2650
	[HotFix]
	public class ActionOrderUIController : UIControllerBase
	{
		// Token: 0x0600A50F RID: 42255 RVA: 0x002E6E68 File Offset: 0x002E5068
		private ActionOrderUIController()
		{
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x002E6E7C File Offset: 0x002E507C
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
			this.m_backgroundButton.onClick.AddListener(new UnityAction(this.OnBackgroundButtonClick));
			this.m_okButton.onClick.AddListener(new UnityAction(this.OnOkButtonClick));
			for (int i = 0; i < this.m_actionOrderButtons.Length; i++)
			{
				Transform parent = this.m_actionOrdersGameObject.transform.GetChild(i).Find("ActionOrderButtonDummy");
				this.m_actionOrderButtons[i] = this.CreateActionOrderButton(null, parent);
				this.m_actionOrderButtons[i].SetIndex(i);
			}
			this.m_camera = base.GetComponentInParent<Camera>();
			this.m_prefabsGameObject.SetActive(false);
		}

		// Token: 0x0600A511 RID: 42257 RVA: 0x002E6F88 File Offset: 0x002E5188
		public void Open()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Open_hotfix != null)
			{
				this.m_Open_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
		}

		// Token: 0x0600A512 RID: 42258 RVA: 0x002E6FFC File Offset: 0x002E51FC
		private void OnDisable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisable_hotfix != null)
			{
				this.m_OnDisable_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingActionOrderButton != null)
			{
				this.DestroyDragginActionOrderButton();
			}
		}

		// Token: 0x0600A513 RID: 42259 RVA: 0x002E7074 File Offset: 0x002E5274
		private void OnApplicationPause(bool isPause)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnApplicationPauseBoolean_hotfix != null)
			{
				this.m_OnApplicationPauseBoolean_hotfix.call(new object[]
				{
					this,
					isPause
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingActionOrderButton != null)
			{
				this.DestroyDragginActionOrderButton();
			}
		}

		// Token: 0x0600A514 RID: 42260 RVA: 0x002E70FC File Offset: 0x002E52FC
		private void OnApplicationFocus(bool focus)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnApplicationFocusBoolean_hotfix != null)
			{
				this.m_OnApplicationFocusBoolean_hotfix.call(new object[]
				{
					this,
					focus
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!focus && this.m_draggingActionOrderButton != null)
			{
				this.DestroyDragginActionOrderButton();
			}
		}

		// Token: 0x0600A515 RID: 42261 RVA: 0x002E718C File Offset: 0x002E538C
		public void SetHeros(List<BattleHero> heros)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHerosList`1_hotfix != null)
			{
				this.m_SetHerosList`1_hotfix.call(new object[]
				{
					this,
					heros
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			for (int i = 0; i < this.m_actionOrderButtons.Length; i++)
			{
				if (i < heros.Count)
				{
					this.m_actionOrderButtons[i].SetHero(heros[i]);
					this.m_actionOrderButtons[i].gameObject.SetActive(true);
				}
				else
				{
					this.m_actionOrderButtons[i].SetHero(null);
					this.m_actionOrderButtons[i].gameObject.SetActive(false);
				}
			}
		}

		// Token: 0x0600A516 RID: 42262 RVA: 0x002E7270 File Offset: 0x002E5470
		public int GetHeroActionOrderIndex(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroActionOrderIndexBattleHero_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroActionOrderIndexBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ArenaActionOrderButton arenaActionOrderButton in this.m_actionOrderButtons)
			{
				if (arenaActionOrderButton.GetHero() == hero)
				{
					return arenaActionOrderButton.GetIndex();
				}
			}
			return 0;
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x002E7320 File Offset: 0x002E5520
		private ArenaActionOrderButton CreateActionOrderButton(BattleHero hero, Transform parent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateActionOrderButtonBattleHeroTransform_hotfix != null)
			{
				return (ArenaActionOrderButton)this.m_CreateActionOrderButtonBattleHeroTransform_hotfix.call(new object[]
				{
					this,
					hero,
					parent
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GameObject go = UnityEngine.Object.Instantiate<GameObject>(this.m_actionOrderButtonPrefab, parent, false);
			ArenaActionOrderButton arenaActionOrderButton = GameObjectUtility.AddControllerToGameObject<ArenaActionOrderButton>(go);
			if (hero != null)
			{
				arenaActionOrderButton.SetHero(hero);
			}
			arenaActionOrderButton.EventOnClick += this.ActionOrderButton_OnClick;
			arenaActionOrderButton.EventOnBeginDrag += this.ActionOrderButton_OnBeginDrag;
			arenaActionOrderButton.EventOnEndDrag += this.ActionOrderButton_OnEndDrag;
			arenaActionOrderButton.EventOnDrag += this.ActionOrderButton_OnDrag;
			arenaActionOrderButton.EventOnDrop += this.ActionOrderButton_OnDrop;
			return arenaActionOrderButton;
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x002E742C File Offset: 0x002E562C
		private void CreateDraggingActionOrderButton(BattleHero hero)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateDraggingActionOrderButtonBattleHero_hotfix != null)
			{
				this.m_CreateDraggingActionOrderButtonBattleHero_hotfix.call(new object[]
				{
					this,
					hero
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyDragginActionOrderButton();
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			this.m_draggingActionOrderButton = this.CreateActionOrderButton(hero, componentInParent.transform);
			this.m_draggingActionOrderButton.transform.SetAsLastSibling();
			AudioUtility.PlaySound(SoundTableId.SoundTableId_DragHero);
			CommonUIController.Instance.EnableInput(false);
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x002E74E0 File Offset: 0x002E56E0
		private void DestroyDragginActionOrderButton()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DestroyDragginActionOrderButton_hotfix != null)
			{
				this.m_DestroyDragginActionOrderButton_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingActionOrderButton == null)
			{
				return;
			}
			this.m_draggingActionOrderButton.Destroy();
			this.m_draggingActionOrderButton = null;
			CommonUIController.Instance.EnableInput(true);
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x002E7570 File Offset: 0x002E5770
		private void MoveDraggingActionOrderButton(Vector2 pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_MoveDraggingActionOrderButtonVector2_hotfix != null)
			{
				this.m_MoveDraggingActionOrderButtonVector2_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingActionOrderButton == null)
			{
				return;
			}
			Canvas componentInParent = base.GetComponentInParent<Canvas>();
			RectTransform rect = componentInParent.transform as RectTransform;
			Vector3 position;
			if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, pos, this.m_camera, out position))
			{
				position.y += 0.3f;
				this.m_draggingActionOrderButton.transform.position = position;
			}
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x002E7640 File Offset: 0x002E5840
		private void DropDraggingActionOrderButton(Vector3 pos)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DropDraggingActionOrderButtonVector3_hotfix != null)
			{
				this.m_DropDraggingActionOrderButtonVector3_hotfix.call(new object[]
				{
					this,
					pos
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_draggingActionOrderButton == null)
			{
				return;
			}
			foreach (ArenaActionOrderButton arenaActionOrderButton in this.m_actionOrderButtons)
			{
				if (arenaActionOrderButton.GetHero() != null && arenaActionOrderButton.gameObject.activeSelf)
				{
					RectTransform rect = arenaActionOrderButton.transform as RectTransform;
					if (RectTransformUtility.RectangleContainsScreenPoint(rect, pos, this.m_camera))
					{
						BattleHero hero = arenaActionOrderButton.GetHero();
						arenaActionOrderButton.SetHero(this.m_draggingActionOrderButton.GetHero());
						this.m_actionOrderButtons[this.m_draggingActionOrderButtonIndex].SetHero(hero);
						AudioUtility.PlaySound(SoundTableId.SoundTableId_DropHero);
						break;
					}
				}
			}
			this.DestroyDragginActionOrderButton();
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x002E7764 File Offset: 0x002E5964
		private void OnBackgroundButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnBackgroundButtonClick_hotfix != null)
			{
				this.m_OnBackgroundButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", null, false, true);
		}

		// Token: 0x0600A51D RID: 42269 RVA: 0x002E77D8 File Offset: 0x002E59D8
		private void OnOkButtonClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnOkButtonClick_hotfix != null)
			{
				this.m_OnOkButtonClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", null, false, true);
			if (this.EventOnConfirm != null)
			{
				this.EventOnConfirm();
			}
		}

		// Token: 0x0600A51E RID: 42270 RVA: 0x002E7864 File Offset: 0x002E5A64
		private void ActionOrderButton_OnClick(ArenaActionOrderButton b)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionOrderButton_OnClickArenaActionOrderButton_hotfix != null)
			{
				this.m_ActionOrderButton_OnClickArenaActionOrderButton_hotfix.call(new object[]
				{
					this,
					b
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600A51F RID: 42271 RVA: 0x002E78D4 File Offset: 0x002E5AD4
		private void ActionOrderButton_OnBeginDrag(ArenaActionOrderButton b, PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionOrderButton_OnBeginDragArenaActionOrderButtonPointerEventData_hotfix != null)
			{
				this.m_ActionOrderButton_OnBeginDragArenaActionOrderButtonPointerEventData_hotfix.call(new object[]
				{
					this,
					b,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_draggingActionOrderButtonIndex = b.GetIndex();
			this.CreateDraggingActionOrderButton(b.GetHero());
		}

		// Token: 0x0600A520 RID: 42272 RVA: 0x002E796C File Offset: 0x002E5B6C
		private void ActionOrderButton_OnEndDrag(ArenaActionOrderButton b, PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionOrderButton_OnEndDragArenaActionOrderButtonPointerEventData_hotfix != null)
			{
				this.m_ActionOrderButton_OnEndDragArenaActionOrderButtonPointerEventData_hotfix.call(new object[]
				{
					this,
					b,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DestroyDragginActionOrderButton();
		}

		// Token: 0x0600A521 RID: 42273 RVA: 0x002E79F4 File Offset: 0x002E5BF4
		private void ActionOrderButton_OnDrag(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionOrderButton_OnDragPointerEventData_hotfix != null)
			{
				this.m_ActionOrderButton_OnDragPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.MoveDraggingActionOrderButton(eventData.position);
		}

		// Token: 0x0600A522 RID: 42274 RVA: 0x002E7A70 File Offset: 0x002E5C70
		private void ActionOrderButton_OnDrop(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ActionOrderButton_OnDropPointerEventData_hotfix != null)
			{
				this.m_ActionOrderButton_OnDropPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DropDraggingActionOrderButton(eventData.position);
		}

		// Token: 0x140001EE RID: 494
		// (add) Token: 0x0600A523 RID: 42275 RVA: 0x002E7AF4 File Offset: 0x002E5CF4
		// (remove) Token: 0x0600A524 RID: 42276 RVA: 0x002E7B90 File Offset: 0x002E5D90
		public event Action EventOnConfirm
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnConfirmAction_hotfix != null)
				{
					this.m_add_EventOnConfirmAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnConfirm;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnConfirm, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnConfirmAction_hotfix != null)
				{
					this.m_remove_EventOnConfirmAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnConfirm;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnConfirm, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x0600A525 RID: 42277 RVA: 0x002E7C2C File Offset: 0x002E5E2C
		// (set) Token: 0x0600A526 RID: 42278 RVA: 0x002E7C4C File Offset: 0x002E5E4C
		[DoNotToLua]
		public new ActionOrderUIController.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ActionOrderUIController.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A527 RID: 42279 RVA: 0x002E7C58 File Offset: 0x002E5E58
		private void __callBase_Initlize(string ctrlName, bool bindNow)
		{
			base.Initlize(ctrlName, bindNow);
		}

		// Token: 0x0600A528 RID: 42280 RVA: 0x002E7C64 File Offset: 0x002E5E64
		private void __callBase_BindFields()
		{
			base.BindFields();
		}

		// Token: 0x0600A529 RID: 42281 RVA: 0x002E7C6C File Offset: 0x002E5E6C
		private void __callBase_OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
		}

		// Token: 0x0600A52A RID: 42282 RVA: 0x002E7C74 File Offset: 0x002E5E74
		private UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
		{
			return base.BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
		}

		// Token: 0x0600A52B RID: 42283 RVA: 0x002E7C88 File Offset: 0x002E5E88
		private void __callBase_Clear()
		{
			base.Clear();
		}

		// Token: 0x0600A52C RID: 42284 RVA: 0x002E7C90 File Offset: 0x002E5E90
		private void __callBase_OnButtonClick(Button button, string fieldName)
		{
			base.OnButtonClick(button, fieldName);
		}

		// Token: 0x0600A52D RID: 42285 RVA: 0x002E7C9C File Offset: 0x002E5E9C
		private void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldName, action);
		}

		// Token: 0x0600A52E RID: 42286 RVA: 0x002E7CA8 File Offset: 0x002E5EA8
		private void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
		{
			base.SetButtonClickListener(fieldNames, action);
		}

		// Token: 0x0600A52F RID: 42287 RVA: 0x002E7CB4 File Offset: 0x002E5EB4
		private void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonDoubleClickListener(fieldName, action);
		}

		// Token: 0x0600A530 RID: 42288 RVA: 0x002E7CC0 File Offset: 0x002E5EC0
		private void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressStartListener(fieldName, action);
		}

		// Token: 0x0600A531 RID: 42289 RVA: 0x002E7CCC File Offset: 0x002E5ECC
		private void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressingListener(fieldName, action);
		}

		// Token: 0x0600A532 RID: 42290 RVA: 0x002E7CD8 File Offset: 0x002E5ED8
		private void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
		{
			base.SetButtonLongPressEndListener(fieldName, action);
		}

		// Token: 0x0600A533 RID: 42291 RVA: 0x002E7CE4 File Offset: 0x002E5EE4
		private void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldName, action);
		}

		// Token: 0x0600A534 RID: 42292 RVA: 0x002E7CF0 File Offset: 0x002E5EF0
		private void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
		{
			base.SetToggleValueChangedListener(fieldNames, action);
		}

		// Token: 0x0600A535 RID: 42293 RVA: 0x002E7CFC File Offset: 0x002E5EFC
		private string __callBase_ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600A536 RID: 42294 RVA: 0x002E7D04 File Offset: 0x002E5F04
		private void __callDele_EventOnConfirm()
		{
			Action eventOnConfirm = this.EventOnConfirm;
			if (eventOnConfirm != null)
			{
				eventOnConfirm();
			}
		}

		// Token: 0x0600A537 RID: 42295 RVA: 0x002E7D24 File Offset: 0x002E5F24
		private void __clearDele_EventOnConfirm()
		{
			this.EventOnConfirm = null;
		}

		// Token: 0x0600A538 RID: 42296 RVA: 0x002E7D30 File Offset: 0x002E5F30
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
					this.m_Open_hotfix = (luaObj.RawGet("Open") as LuaFunction);
					this.m_OnDisable_hotfix = (luaObj.RawGet("OnDisable") as LuaFunction);
					this.m_OnApplicationPauseBoolean_hotfix = (luaObj.RawGet("OnApplicationPause") as LuaFunction);
					this.m_OnApplicationFocusBoolean_hotfix = (luaObj.RawGet("OnApplicationFocus") as LuaFunction);
					this.m_SetHerosList`1_hotfix = (luaObj.RawGet("SetHeros") as LuaFunction);
					this.m_GetHeroActionOrderIndexBattleHero_hotfix = (luaObj.RawGet("GetHeroActionOrderIndex") as LuaFunction);
					this.m_CreateActionOrderButtonBattleHeroTransform_hotfix = (luaObj.RawGet("CreateActionOrderButton") as LuaFunction);
					this.m_CreateDraggingActionOrderButtonBattleHero_hotfix = (luaObj.RawGet("CreateDraggingActionOrderButton") as LuaFunction);
					this.m_DestroyDragginActionOrderButton_hotfix = (luaObj.RawGet("DestroyDragginActionOrderButton") as LuaFunction);
					this.m_MoveDraggingActionOrderButtonVector2_hotfix = (luaObj.RawGet("MoveDraggingActionOrderButton") as LuaFunction);
					this.m_DropDraggingActionOrderButtonVector3_hotfix = (luaObj.RawGet("DropDraggingActionOrderButton") as LuaFunction);
					this.m_OnBackgroundButtonClick_hotfix = (luaObj.RawGet("OnBackgroundButtonClick") as LuaFunction);
					this.m_OnOkButtonClick_hotfix = (luaObj.RawGet("OnOkButtonClick") as LuaFunction);
					this.m_ActionOrderButton_OnClickArenaActionOrderButton_hotfix = (luaObj.RawGet("ActionOrderButton_OnClick") as LuaFunction);
					this.m_ActionOrderButton_OnBeginDragArenaActionOrderButtonPointerEventData_hotfix = (luaObj.RawGet("ActionOrderButton_OnBeginDrag") as LuaFunction);
					this.m_ActionOrderButton_OnEndDragArenaActionOrderButtonPointerEventData_hotfix = (luaObj.RawGet("ActionOrderButton_OnEndDrag") as LuaFunction);
					this.m_ActionOrderButton_OnDragPointerEventData_hotfix = (luaObj.RawGet("ActionOrderButton_OnDrag") as LuaFunction);
					this.m_ActionOrderButton_OnDropPointerEventData_hotfix = (luaObj.RawGet("ActionOrderButton_OnDrop") as LuaFunction);
					this.m_add_EventOnConfirmAction_hotfix = (luaObj.RawGet("add_EventOnConfirm") as LuaFunction);
					this.m_remove_EventOnConfirmAction_hotfix = (luaObj.RawGet("remove_EventOnConfirm") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A539 RID: 42297 RVA: 0x002E7FF0 File Offset: 0x002E61F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ActionOrderUIController));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006DED RID: 28141
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x04006DEE RID: 28142
		[AutoBind("./BackgroundButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_backgroundButton;

		// Token: 0x04006DEF RID: 28143
		[AutoBind("./Panel/Slots", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actionOrdersGameObject;

		// Token: 0x04006DF0 RID: 28144
		[AutoBind("./Panel/OkButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_okButton;

		// Token: 0x04006DF1 RID: 28145
		[AutoBind("./Prefabs", AutoBindAttribute.InitState.Inactive, false)]
		private GameObject m_prefabsGameObject;

		// Token: 0x04006DF2 RID: 28146
		[AutoBind("./Prefabs/ActionOrderButton", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_actionOrderButtonPrefab;

		// Token: 0x04006DF3 RID: 28147
		private ArenaActionOrderButton[] m_actionOrderButtons = new ArenaActionOrderButton[5];

		// Token: 0x04006DF4 RID: 28148
		private ArenaActionOrderButton m_draggingActionOrderButton;

		// Token: 0x04006DF5 RID: 28149
		private int m_draggingActionOrderButtonIndex;

		// Token: 0x04006DF6 RID: 28150
		private Camera m_camera;

		// Token: 0x04006DF7 RID: 28151
		[DoNotToLua]
		private ActionOrderUIController.LuaExportHelper luaExportHelper;

		// Token: 0x04006DF8 RID: 28152
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006DF9 RID: 28153
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006DFA RID: 28154
		private LuaFunction m_OnBindFiledsCompleted_hotfix;

		// Token: 0x04006DFB RID: 28155
		private LuaFunction m_Open_hotfix;

		// Token: 0x04006DFC RID: 28156
		private LuaFunction m_OnDisable_hotfix;

		// Token: 0x04006DFD RID: 28157
		private LuaFunction m_OnApplicationPauseBoolean_hotfix;

		// Token: 0x04006DFE RID: 28158
		private LuaFunction m_OnApplicationFocusBoolean_hotfix;

		// Token: 0x04006DFF RID: 28159
		private LuaFunction m_SetHerosList;

		// Token: 0x04006E00 RID: 28160
		private LuaFunction m_GetHeroActionOrderIndexBattleHero_hotfix;

		// Token: 0x04006E01 RID: 28161
		private LuaFunction m_CreateActionOrderButtonBattleHeroTransform_hotfix;

		// Token: 0x04006E02 RID: 28162
		private LuaFunction m_CreateDraggingActionOrderButtonBattleHero_hotfix;

		// Token: 0x04006E03 RID: 28163
		private LuaFunction m_DestroyDragginActionOrderButton_hotfix;

		// Token: 0x04006E04 RID: 28164
		private LuaFunction m_MoveDraggingActionOrderButtonVector2_hotfix;

		// Token: 0x04006E05 RID: 28165
		private LuaFunction m_DropDraggingActionOrderButtonVector3_hotfix;

		// Token: 0x04006E06 RID: 28166
		private LuaFunction m_OnBackgroundButtonClick_hotfix;

		// Token: 0x04006E07 RID: 28167
		private LuaFunction m_OnOkButtonClick_hotfix;

		// Token: 0x04006E08 RID: 28168
		private LuaFunction m_ActionOrderButton_OnClickArenaActionOrderButton_hotfix;

		// Token: 0x04006E09 RID: 28169
		private LuaFunction m_ActionOrderButton_OnBeginDragArenaActionOrderButtonPointerEventData_hotfix;

		// Token: 0x04006E0A RID: 28170
		private LuaFunction m_ActionOrderButton_OnEndDragArenaActionOrderButtonPointerEventData_hotfix;

		// Token: 0x04006E0B RID: 28171
		private LuaFunction m_ActionOrderButton_OnDragPointerEventData_hotfix;

		// Token: 0x04006E0C RID: 28172
		private LuaFunction m_ActionOrderButton_OnDropPointerEventData_hotfix;

		// Token: 0x04006E0D RID: 28173
		private LuaFunction m_add_EventOnConfirmAction_hotfix;

		// Token: 0x04006E0E RID: 28174
		private LuaFunction m_remove_EventOnConfirmAction_hotfix;

		// Token: 0x02000A5B RID: 2651
		public new class LuaExportHelper
		{
			// Token: 0x0600A53A RID: 42298 RVA: 0x002E8058 File Offset: 0x002E6258
			public LuaExportHelper(ActionOrderUIController owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A53B RID: 42299 RVA: 0x002E8068 File Offset: 0x002E6268
			public void __callBase_Initlize(string ctrlName, bool bindNow)
			{
				this.m_owner.__callBase_Initlize(ctrlName, bindNow);
			}

			// Token: 0x0600A53C RID: 42300 RVA: 0x002E8078 File Offset: 0x002E6278
			public void __callBase_BindFields()
			{
				this.m_owner.__callBase_BindFields();
			}

			// Token: 0x0600A53D RID: 42301 RVA: 0x002E8088 File Offset: 0x002E6288
			public void __callBase_OnBindFiledsCompleted()
			{
				this.m_owner.__callBase_OnBindFiledsCompleted();
			}

			// Token: 0x0600A53E RID: 42302 RVA: 0x002E8098 File Offset: 0x002E6298
			public UnityEngine.Object __callBase_BindFieldImpl(Type fieldType, string path, AutoBindAttribute.InitState initState, string fieldName, string ctrlName, bool optional)
			{
				return this.m_owner.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
			}

			// Token: 0x0600A53F RID: 42303 RVA: 0x002E80B0 File Offset: 0x002E62B0
			public void __callBase_Clear()
			{
				this.m_owner.__callBase_Clear();
			}

			// Token: 0x0600A540 RID: 42304 RVA: 0x002E80C0 File Offset: 0x002E62C0
			public void __callBase_OnButtonClick(Button button, string fieldName)
			{
				this.m_owner.__callBase_OnButtonClick(button, fieldName);
			}

			// Token: 0x0600A541 RID: 42305 RVA: 0x002E80D0 File Offset: 0x002E62D0
			public void __callBase_SetButtonClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldName, action);
			}

			// Token: 0x0600A542 RID: 42306 RVA: 0x002E80E0 File Offset: 0x002E62E0
			public void __callBase_SetButtonClickListener(string[] fieldNames, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonClickListener(fieldNames, action);
			}

			// Token: 0x0600A543 RID: 42307 RVA: 0x002E80F0 File Offset: 0x002E62F0
			public void __callBase_SetButtonDoubleClickListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonDoubleClickListener(fieldName, action);
			}

			// Token: 0x0600A544 RID: 42308 RVA: 0x002E8100 File Offset: 0x002E6300
			public void __callBase_SetButtonLongPressStartListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressStartListener(fieldName, action);
			}

			// Token: 0x0600A545 RID: 42309 RVA: 0x002E8110 File Offset: 0x002E6310
			public void __callBase_SetButtonLongPressingListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressingListener(fieldName, action);
			}

			// Token: 0x0600A546 RID: 42310 RVA: 0x002E8120 File Offset: 0x002E6320
			public void __callBase_SetButtonLongPressEndListener(string fieldName, Action<UIControllerBase> action)
			{
				this.m_owner.__callBase_SetButtonLongPressEndListener(fieldName, action);
			}

			// Token: 0x0600A547 RID: 42311 RVA: 0x002E8130 File Offset: 0x002E6330
			public void __callBase_SetToggleValueChangedListener(string fieldName, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldName, action);
			}

			// Token: 0x0600A548 RID: 42312 RVA: 0x002E8140 File Offset: 0x002E6340
			public void __callBase_SetToggleValueChangedListener(string[] fieldNames, Action<UIControllerBase, bool> action)
			{
				this.m_owner.__callBase_SetToggleValueChangedListener(fieldNames, action);
			}

			// Token: 0x0600A549 RID: 42313 RVA: 0x002E8150 File Offset: 0x002E6350
			public string __callBase_ToString()
			{
				return this.m_owner.__callBase_ToString();
			}

			// Token: 0x0600A54A RID: 42314 RVA: 0x002E8160 File Offset: 0x002E6360
			public void __callDele_EventOnConfirm()
			{
				this.m_owner.__callDele_EventOnConfirm();
			}

			// Token: 0x0600A54B RID: 42315 RVA: 0x002E8170 File Offset: 0x002E6370
			public void __clearDele_EventOnConfirm()
			{
				this.m_owner.__clearDele_EventOnConfirm();
			}

			// Token: 0x17002179 RID: 8569
			// (get) Token: 0x0600A54C RID: 42316 RVA: 0x002E8180 File Offset: 0x002E6380
			// (set) Token: 0x0600A54D RID: 42317 RVA: 0x002E8190 File Offset: 0x002E6390
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

			// Token: 0x1700217A RID: 8570
			// (get) Token: 0x0600A54E RID: 42318 RVA: 0x002E81A0 File Offset: 0x002E63A0
			// (set) Token: 0x0600A54F RID: 42319 RVA: 0x002E81B0 File Offset: 0x002E63B0
			public Button m_backgroundButton
			{
				get
				{
					return this.m_owner.m_backgroundButton;
				}
				set
				{
					this.m_owner.m_backgroundButton = value;
				}
			}

			// Token: 0x1700217B RID: 8571
			// (get) Token: 0x0600A550 RID: 42320 RVA: 0x002E81C0 File Offset: 0x002E63C0
			// (set) Token: 0x0600A551 RID: 42321 RVA: 0x002E81D0 File Offset: 0x002E63D0
			public GameObject m_actionOrdersGameObject
			{
				get
				{
					return this.m_owner.m_actionOrdersGameObject;
				}
				set
				{
					this.m_owner.m_actionOrdersGameObject = value;
				}
			}

			// Token: 0x1700217C RID: 8572
			// (get) Token: 0x0600A552 RID: 42322 RVA: 0x002E81E0 File Offset: 0x002E63E0
			// (set) Token: 0x0600A553 RID: 42323 RVA: 0x002E81F0 File Offset: 0x002E63F0
			public Button m_okButton
			{
				get
				{
					return this.m_owner.m_okButton;
				}
				set
				{
					this.m_owner.m_okButton = value;
				}
			}

			// Token: 0x1700217D RID: 8573
			// (get) Token: 0x0600A554 RID: 42324 RVA: 0x002E8200 File Offset: 0x002E6400
			// (set) Token: 0x0600A555 RID: 42325 RVA: 0x002E8210 File Offset: 0x002E6410
			public GameObject m_prefabsGameObject
			{
				get
				{
					return this.m_owner.m_prefabsGameObject;
				}
				set
				{
					this.m_owner.m_prefabsGameObject = value;
				}
			}

			// Token: 0x1700217E RID: 8574
			// (get) Token: 0x0600A556 RID: 42326 RVA: 0x002E8220 File Offset: 0x002E6420
			// (set) Token: 0x0600A557 RID: 42327 RVA: 0x002E8230 File Offset: 0x002E6430
			public GameObject m_actionOrderButtonPrefab
			{
				get
				{
					return this.m_owner.m_actionOrderButtonPrefab;
				}
				set
				{
					this.m_owner.m_actionOrderButtonPrefab = value;
				}
			}

			// Token: 0x1700217F RID: 8575
			// (get) Token: 0x0600A558 RID: 42328 RVA: 0x002E8240 File Offset: 0x002E6440
			// (set) Token: 0x0600A559 RID: 42329 RVA: 0x002E8250 File Offset: 0x002E6450
			public ArenaActionOrderButton[] m_actionOrderButtons
			{
				get
				{
					return this.m_owner.m_actionOrderButtons;
				}
				set
				{
					this.m_owner.m_actionOrderButtons = value;
				}
			}

			// Token: 0x17002180 RID: 8576
			// (get) Token: 0x0600A55A RID: 42330 RVA: 0x002E8260 File Offset: 0x002E6460
			// (set) Token: 0x0600A55B RID: 42331 RVA: 0x002E8270 File Offset: 0x002E6470
			public ArenaActionOrderButton m_draggingActionOrderButton
			{
				get
				{
					return this.m_owner.m_draggingActionOrderButton;
				}
				set
				{
					this.m_owner.m_draggingActionOrderButton = value;
				}
			}

			// Token: 0x17002181 RID: 8577
			// (get) Token: 0x0600A55C RID: 42332 RVA: 0x002E8280 File Offset: 0x002E6480
			// (set) Token: 0x0600A55D RID: 42333 RVA: 0x002E8290 File Offset: 0x002E6490
			public int m_draggingActionOrderButtonIndex
			{
				get
				{
					return this.m_owner.m_draggingActionOrderButtonIndex;
				}
				set
				{
					this.m_owner.m_draggingActionOrderButtonIndex = value;
				}
			}

			// Token: 0x17002182 RID: 8578
			// (get) Token: 0x0600A55E RID: 42334 RVA: 0x002E82A0 File Offset: 0x002E64A0
			// (set) Token: 0x0600A55F RID: 42335 RVA: 0x002E82B0 File Offset: 0x002E64B0
			public Camera m_camera
			{
				get
				{
					return this.m_owner.m_camera;
				}
				set
				{
					this.m_owner.m_camera = value;
				}
			}

			// Token: 0x0600A560 RID: 42336 RVA: 0x002E82C0 File Offset: 0x002E64C0
			public void OnBindFiledsCompleted()
			{
				this.m_owner.OnBindFiledsCompleted();
			}

			// Token: 0x0600A561 RID: 42337 RVA: 0x002E82D0 File Offset: 0x002E64D0
			public void OnDisable()
			{
				this.m_owner.OnDisable();
			}

			// Token: 0x0600A562 RID: 42338 RVA: 0x002E82E0 File Offset: 0x002E64E0
			public void OnApplicationPause(bool isPause)
			{
				this.m_owner.OnApplicationPause(isPause);
			}

			// Token: 0x0600A563 RID: 42339 RVA: 0x002E82F0 File Offset: 0x002E64F0
			public void OnApplicationFocus(bool focus)
			{
				this.m_owner.OnApplicationFocus(focus);
			}

			// Token: 0x0600A564 RID: 42340 RVA: 0x002E8300 File Offset: 0x002E6500
			public ArenaActionOrderButton CreateActionOrderButton(BattleHero hero, Transform parent)
			{
				return this.m_owner.CreateActionOrderButton(hero, parent);
			}

			// Token: 0x0600A565 RID: 42341 RVA: 0x002E8310 File Offset: 0x002E6510
			public void CreateDraggingActionOrderButton(BattleHero hero)
			{
				this.m_owner.CreateDraggingActionOrderButton(hero);
			}

			// Token: 0x0600A566 RID: 42342 RVA: 0x002E8320 File Offset: 0x002E6520
			public void DestroyDragginActionOrderButton()
			{
				this.m_owner.DestroyDragginActionOrderButton();
			}

			// Token: 0x0600A567 RID: 42343 RVA: 0x002E8330 File Offset: 0x002E6530
			public void MoveDraggingActionOrderButton(Vector2 pos)
			{
				this.m_owner.MoveDraggingActionOrderButton(pos);
			}

			// Token: 0x0600A568 RID: 42344 RVA: 0x002E8340 File Offset: 0x002E6540
			public void DropDraggingActionOrderButton(Vector3 pos)
			{
				this.m_owner.DropDraggingActionOrderButton(pos);
			}

			// Token: 0x0600A569 RID: 42345 RVA: 0x002E8350 File Offset: 0x002E6550
			public void OnBackgroundButtonClick()
			{
				this.m_owner.OnBackgroundButtonClick();
			}

			// Token: 0x0600A56A RID: 42346 RVA: 0x002E8360 File Offset: 0x002E6560
			public void OnOkButtonClick()
			{
				this.m_owner.OnOkButtonClick();
			}

			// Token: 0x0600A56B RID: 42347 RVA: 0x002E8370 File Offset: 0x002E6570
			public void ActionOrderButton_OnClick(ArenaActionOrderButton b)
			{
				this.m_owner.ActionOrderButton_OnClick(b);
			}

			// Token: 0x0600A56C RID: 42348 RVA: 0x002E8380 File Offset: 0x002E6580
			public void ActionOrderButton_OnBeginDrag(ArenaActionOrderButton b, PointerEventData eventData)
			{
				this.m_owner.ActionOrderButton_OnBeginDrag(b, eventData);
			}

			// Token: 0x0600A56D RID: 42349 RVA: 0x002E8390 File Offset: 0x002E6590
			public void ActionOrderButton_OnEndDrag(ArenaActionOrderButton b, PointerEventData eventData)
			{
				this.m_owner.ActionOrderButton_OnEndDrag(b, eventData);
			}

			// Token: 0x0600A56E RID: 42350 RVA: 0x002E83A0 File Offset: 0x002E65A0
			public void ActionOrderButton_OnDrag(PointerEventData eventData)
			{
				this.m_owner.ActionOrderButton_OnDrag(eventData);
			}

			// Token: 0x0600A56F RID: 42351 RVA: 0x002E83B0 File Offset: 0x002E65B0
			public void ActionOrderButton_OnDrop(PointerEventData eventData)
			{
				this.m_owner.ActionOrderButton_OnDrop(eventData);
			}

			// Token: 0x04006E0F RID: 28175
			private ActionOrderUIController m_owner;
		}
	}
}
