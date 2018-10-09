using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000C7B RID: 3195
	[HotFix]
	public class OnDragTrigger : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x0600E590 RID: 58768 RVA: 0x003DA2DC File Offset: 0x003D84DC
		private void Start()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Start_hotfix != null)
			{
				this.m_Start_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			int num = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_MovePixelToSliderRatio);
			int configableConstId_HeroIntimateMaxValue = this.m_configDataLoader.ConfigableConstId_HeroIntimateMaxValue;
			this.m_totalNeedMovePixel = configableConstId_HeroIntimateMaxValue * num;
			this.m_pixelInterval = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_PixelIntervalForVoice);
		}

		// Token: 0x0600E591 RID: 58769 RVA: 0x003DA390 File Offset: 0x003D8590
		public void SetSliderAndEffectSlider(Slider slider, Slider effectSlider, List<int> heroPerformanceIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSliderAndEffectSliderSliderSliderList`1_hotfix != null)
			{
				this.m_SetSliderAndEffectSliderSliderSliderList`1_hotfix.call(new object[]
				{
					this,
					slider,
					effectSlider,
					heroPerformanceIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_slider = slider;
			this.m_effectSlider = effectSlider;
			this.m_heroPerformanceIds.Clear();
			this.m_heroPerformanceIds.AddRange(heroPerformanceIds);
		}

		// Token: 0x0600E592 RID: 58770 RVA: 0x003DA448 File Offset: 0x003D8648
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
			if (!this.m_isDrag && this.EventOnClick != null)
			{
				this.EventOnClick();
			}
		}

		// Token: 0x0600E593 RID: 58771 RVA: 0x003DA4DC File Offset: 0x003D86DC
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
			this.m_isDrag = true;
			this.m_hasDoneEvent = false;
			base.StopAllCoroutines();
			if (this.EventOnBeginDrag != null)
			{
				this.EventOnBeginDrag();
			}
		}

		// Token: 0x0600E594 RID: 58772 RVA: 0x003DA578 File Offset: 0x003D8778
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
			bool flag = this.m_curMovePixel >= (float)this.m_totalNeedMovePixel;
			if (this.EventOnEndDrag != null)
			{
				this.EventOnEndDrag();
			}
			if (flag)
			{
				this.m_slider.value = 0f;
				this.m_effectSlider.value = 0f;
				this.m_curMovePixel = 0f;
				this.m_isDrag = false;
			}
			else
			{
				base.StartCoroutine(this.SliderValueDown());
			}
		}

		// Token: 0x0600E595 RID: 58773 RVA: 0x003DA65C File Offset: 0x003D885C
		[DebuggerHidden]
		private IEnumerator SliderValueDown()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SliderValueDown_hotfix != null)
			{
				return (IEnumerator)this.m_SliderValueDown_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			OnDragTrigger.<SliderValueDown>c__Iterator0 <SliderValueDown>c__Iterator = new OnDragTrigger.<SliderValueDown>c__Iterator0();
			<SliderValueDown>c__Iterator.$this = this;
			return <SliderValueDown>c__Iterator;
		}

		// Token: 0x0600E596 RID: 58774 RVA: 0x003DA6D8 File Offset: 0x003D88D8
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
			this.SetDragObjPostion(eventData);
		}

		// Token: 0x0600E597 RID: 58775 RVA: 0x003DA750 File Offset: 0x003D8950
		private void SetDragObjPostion(PointerEventData eventData)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetDragObjPostionPointerEventData_hotfix != null)
			{
				this.m_SetDragObjPostionPointerEventData_hotfix.call(new object[]
				{
					this,
					eventData
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RectTransform component = this.m_touchImage.GetComponent<RectTransform>();
			Vector3 vector;
			if (RectTransformUtility.ScreenPointToWorldPointInRectangle(component, eventData.position, eventData.pressEventCamera, out vector))
			{
				this.m_curMovePixel += Vector3.Distance(component.position, vector);
				component.position = vector;
				if (this.m_curMovePixel > (float)this.m_totalNeedMovePixel && !this.m_hasDoneEvent)
				{
					this.m_slider.value = 1f;
					this.m_effectSlider.value = 1f;
					if (this.EventOnSliderFull != null)
					{
						this.EventOnSliderFull();
					}
					this.m_hasDoneEvent = true;
					return;
				}
				float value = this.m_curMovePixel / (float)this.m_totalNeedMovePixel;
				this.m_slider.value = value;
				this.m_effectSlider.value = value;
				int num = (int)this.m_curMovePixel / this.m_pixelInterval;
				if (this.m_lastCount != num)
				{
					this.m_lastCount = num;
					if (this.m_audioPlayback == null || this.m_audioPlayback.IsStoped())
					{
						System.Random random = new System.Random();
						int index = random.Next(this.m_heroPerformanceIds.Count);
						while (this.m_heroPerformanceIds[index] == this.m_lastHeroPerformanceId)
						{
							index = random.Next(this.m_heroPerformanceIds.Count);
						}
						this.m_lastHeroPerformanceId = this.m_heroPerformanceIds[index];
						ConfigDataHeroPerformanceInfo configDataHeroPerformanceInfo = this.m_configDataLoader.GetConfigDataHeroPerformanceInfo(this.m_lastHeroPerformanceId);
						if (configDataHeroPerformanceInfo != null)
						{
							this.m_audioPlayback = AudioUtility.PlaySound(configDataHeroPerformanceInfo.Voice);
						}
					}
				}
			}
		}

		// Token: 0x140002E8 RID: 744
		// (add) Token: 0x0600E598 RID: 58776 RVA: 0x003DA950 File Offset: 0x003D8B50
		// (remove) Token: 0x0600E599 RID: 58777 RVA: 0x003DA9EC File Offset: 0x003D8BEC
		public event Action EventOnBeginDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnBeginDragAction_hotfix != null)
				{
					this.m_add_EventOnBeginDragAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBeginDrag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBeginDrag, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnBeginDragAction_hotfix != null)
				{
					this.m_remove_EventOnBeginDragAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnBeginDrag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnBeginDrag, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002E9 RID: 745
		// (add) Token: 0x0600E59A RID: 58778 RVA: 0x003DAA88 File Offset: 0x003D8C88
		// (remove) Token: 0x0600E59B RID: 58779 RVA: 0x003DAB24 File Offset: 0x003D8D24
		public event Action EventOnEndDrag
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnEndDragAction_hotfix != null)
				{
					this.m_add_EventOnEndDragAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEndDrag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEndDrag, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnEndDragAction_hotfix != null)
				{
					this.m_remove_EventOnEndDragAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnEndDrag;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnEndDrag, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002EA RID: 746
		// (add) Token: 0x0600E59C RID: 58780 RVA: 0x003DABC0 File Offset: 0x003D8DC0
		// (remove) Token: 0x0600E59D RID: 58781 RVA: 0x003DAC5C File Offset: 0x003D8E5C
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

		// Token: 0x140002EB RID: 747
		// (add) Token: 0x0600E59E RID: 58782 RVA: 0x003DACF8 File Offset: 0x003D8EF8
		// (remove) Token: 0x0600E59F RID: 58783 RVA: 0x003DAD94 File Offset: 0x003D8F94
		public event Action EventOnSliderFull
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSliderFullAction_hotfix != null)
				{
					this.m_add_EventOnSliderFullAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSliderFull;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSliderFull, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSliderFullAction_hotfix != null)
				{
					this.m_remove_EventOnSliderFullAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSliderFull;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSliderFull, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140002EC RID: 748
		// (add) Token: 0x0600E5A0 RID: 58784 RVA: 0x003DAE30 File Offset: 0x003D9030
		// (remove) Token: 0x0600E5A1 RID: 58785 RVA: 0x003DAECC File Offset: 0x003D90CC
		public event Action EventOnSliderEmpty
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnSliderEmptyAction_hotfix != null)
				{
					this.m_add_EventOnSliderEmptyAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSliderEmpty;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSliderEmpty, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnSliderEmptyAction_hotfix != null)
				{
					this.m_remove_EventOnSliderEmptyAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnSliderEmpty;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnSliderEmpty, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x0600E5A2 RID: 58786 RVA: 0x003DAF68 File Offset: 0x003D9168
		// (set) Token: 0x0600E5A3 RID: 58787 RVA: 0x003DAF88 File Offset: 0x003D9188
		[DoNotToLua]
		public OnDragTrigger.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new OnDragTrigger.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600E5A4 RID: 58788 RVA: 0x003DAF94 File Offset: 0x003D9194
		private void __callDele_EventOnBeginDrag()
		{
			Action eventOnBeginDrag = this.EventOnBeginDrag;
			if (eventOnBeginDrag != null)
			{
				eventOnBeginDrag();
			}
		}

		// Token: 0x0600E5A5 RID: 58789 RVA: 0x003DAFB4 File Offset: 0x003D91B4
		private void __clearDele_EventOnBeginDrag()
		{
			this.EventOnBeginDrag = null;
		}

		// Token: 0x0600E5A6 RID: 58790 RVA: 0x003DAFC0 File Offset: 0x003D91C0
		private void __callDele_EventOnEndDrag()
		{
			Action eventOnEndDrag = this.EventOnEndDrag;
			if (eventOnEndDrag != null)
			{
				eventOnEndDrag();
			}
		}

		// Token: 0x0600E5A7 RID: 58791 RVA: 0x003DAFE0 File Offset: 0x003D91E0
		private void __clearDele_EventOnEndDrag()
		{
			this.EventOnEndDrag = null;
		}

		// Token: 0x0600E5A8 RID: 58792 RVA: 0x003DAFEC File Offset: 0x003D91EC
		private void __callDele_EventOnClick()
		{
			Action eventOnClick = this.EventOnClick;
			if (eventOnClick != null)
			{
				eventOnClick();
			}
		}

		// Token: 0x0600E5A9 RID: 58793 RVA: 0x003DB00C File Offset: 0x003D920C
		private void __clearDele_EventOnClick()
		{
			this.EventOnClick = null;
		}

		// Token: 0x0600E5AA RID: 58794 RVA: 0x003DB018 File Offset: 0x003D9218
		private void __callDele_EventOnSliderFull()
		{
			Action eventOnSliderFull = this.EventOnSliderFull;
			if (eventOnSliderFull != null)
			{
				eventOnSliderFull();
			}
		}

		// Token: 0x0600E5AB RID: 58795 RVA: 0x003DB038 File Offset: 0x003D9238
		private void __clearDele_EventOnSliderFull()
		{
			this.EventOnSliderFull = null;
		}

		// Token: 0x0600E5AC RID: 58796 RVA: 0x003DB044 File Offset: 0x003D9244
		private void __callDele_EventOnSliderEmpty()
		{
			Action eventOnSliderEmpty = this.EventOnSliderEmpty;
			if (eventOnSliderEmpty != null)
			{
				eventOnSliderEmpty();
			}
		}

		// Token: 0x0600E5AD RID: 58797 RVA: 0x003DB064 File Offset: 0x003D9264
		private void __clearDele_EventOnSliderEmpty()
		{
			this.EventOnSliderEmpty = null;
		}

		// Token: 0x0600E5AE RID: 58798 RVA: 0x003DB070 File Offset: 0x003D9270
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
					this.m_Start_hotfix = (luaObj.RawGet("Start") as LuaFunction);
					this.m_SetSliderAndEffectSliderSliderSliderList`1_hotfix = (luaObj.RawGet("SetSliderAndEffectSlider") as LuaFunction);
					this.m_OnPointerClickPointerEventData_hotfix = (luaObj.RawGet("OnPointerClick") as LuaFunction);
					this.m_OnBeginDragPointerEventData_hotfix = (luaObj.RawGet("OnBeginDrag") as LuaFunction);
					this.m_OnEndDragPointerEventData_hotfix = (luaObj.RawGet("OnEndDrag") as LuaFunction);
					this.m_SliderValueDown_hotfix = (luaObj.RawGet("SliderValueDown") as LuaFunction);
					this.m_OnDragPointerEventData_hotfix = (luaObj.RawGet("OnDrag") as LuaFunction);
					this.m_SetDragObjPostionPointerEventData_hotfix = (luaObj.RawGet("SetDragObjPostion") as LuaFunction);
					this.m_add_EventOnBeginDragAction_hotfix = (luaObj.RawGet("add_EventOnBeginDrag") as LuaFunction);
					this.m_remove_EventOnBeginDragAction_hotfix = (luaObj.RawGet("remove_EventOnBeginDrag") as LuaFunction);
					this.m_add_EventOnEndDragAction_hotfix = (luaObj.RawGet("add_EventOnEndDrag") as LuaFunction);
					this.m_remove_EventOnEndDragAction_hotfix = (luaObj.RawGet("remove_EventOnEndDrag") as LuaFunction);
					this.m_add_EventOnClickAction_hotfix = (luaObj.RawGet("add_EventOnClick") as LuaFunction);
					this.m_remove_EventOnClickAction_hotfix = (luaObj.RawGet("remove_EventOnClick") as LuaFunction);
					this.m_add_EventOnSliderFullAction_hotfix = (luaObj.RawGet("add_EventOnSliderFull") as LuaFunction);
					this.m_remove_EventOnSliderFullAction_hotfix = (luaObj.RawGet("remove_EventOnSliderFull") as LuaFunction);
					this.m_add_EventOnSliderEmptyAction_hotfix = (luaObj.RawGet("add_EventOnSliderEmpty") as LuaFunction);
					this.m_remove_EventOnSliderEmptyAction_hotfix = (luaObj.RawGet("remove_EventOnSliderEmpty") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600E5AF RID: 58799 RVA: 0x003DB2E4 File Offset: 0x003D94E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OnDragTrigger));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008A96 RID: 35478
		private int m_pixelInterval = 20;

		// Token: 0x04008A9C RID: 35484
		private GameObject m_touchImage;

		// Token: 0x04008A9D RID: 35485
		private Slider m_slider;

		// Token: 0x04008A9E RID: 35486
		private Slider m_effectSlider;

		// Token: 0x04008A9F RID: 35487
		public int m_totalNeedMovePixel;

		// Token: 0x04008AA0 RID: 35488
		private float m_curMovePixel;

		// Token: 0x04008AA1 RID: 35489
		private bool m_isDrag;

		// Token: 0x04008AA2 RID: 35490
		private bool m_hasDoneEvent;

		// Token: 0x04008AA3 RID: 35491
		private List<int> m_heroPerformanceIds = new List<int>();

		// Token: 0x04008AA4 RID: 35492
		private int m_lastCount;

		// Token: 0x04008AA5 RID: 35493
		private int m_lastHeroPerformanceId;

		// Token: 0x04008AA6 RID: 35494
		private IAudioPlayback m_audioPlayback;

		// Token: 0x04008AA7 RID: 35495
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008AA8 RID: 35496
		[DoNotToLua]
		private OnDragTrigger.LuaExportHelper luaExportHelper;

		// Token: 0x04008AA9 RID: 35497
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008AAA RID: 35498
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008AAB RID: 35499
		private LuaFunction m_Start_hotfix;

		// Token: 0x04008AAC RID: 35500
		private LuaFunction m_SetSliderAndEffectSliderSliderSliderList;

		// Token: 0x04008AAD RID: 35501
		private LuaFunction m_OnPointerClickPointerEventData_hotfix;

		// Token: 0x04008AAE RID: 35502
		private LuaFunction m_OnBeginDragPointerEventData_hotfix;

		// Token: 0x04008AAF RID: 35503
		private LuaFunction m_OnEndDragPointerEventData_hotfix;

		// Token: 0x04008AB0 RID: 35504
		private LuaFunction m_SliderValueDown_hotfix;

		// Token: 0x04008AB1 RID: 35505
		private LuaFunction m_OnDragPointerEventData_hotfix;

		// Token: 0x04008AB2 RID: 35506
		private LuaFunction m_SetDragObjPostionPointerEventData_hotfix;

		// Token: 0x04008AB3 RID: 35507
		private LuaFunction m_add_EventOnBeginDragAction_hotfix;

		// Token: 0x04008AB4 RID: 35508
		private LuaFunction m_remove_EventOnBeginDragAction_hotfix;

		// Token: 0x04008AB5 RID: 35509
		private LuaFunction m_add_EventOnEndDragAction_hotfix;

		// Token: 0x04008AB6 RID: 35510
		private LuaFunction m_remove_EventOnEndDragAction_hotfix;

		// Token: 0x04008AB7 RID: 35511
		private LuaFunction m_add_EventOnClickAction_hotfix;

		// Token: 0x04008AB8 RID: 35512
		private LuaFunction m_remove_EventOnClickAction_hotfix;

		// Token: 0x04008AB9 RID: 35513
		private LuaFunction m_add_EventOnSliderFullAction_hotfix;

		// Token: 0x04008ABA RID: 35514
		private LuaFunction m_remove_EventOnSliderFullAction_hotfix;

		// Token: 0x04008ABB RID: 35515
		private LuaFunction m_add_EventOnSliderEmptyAction_hotfix;

		// Token: 0x04008ABC RID: 35516
		private LuaFunction m_remove_EventOnSliderEmptyAction_hotfix;

		// Token: 0x02000C7C RID: 3196
		public class LuaExportHelper
		{
			// Token: 0x0600E5B0 RID: 58800 RVA: 0x003DB34C File Offset: 0x003D954C
			public LuaExportHelper(OnDragTrigger owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600E5B1 RID: 58801 RVA: 0x003DB35C File Offset: 0x003D955C
			public void __callDele_EventOnBeginDrag()
			{
				this.m_owner.__callDele_EventOnBeginDrag();
			}

			// Token: 0x0600E5B2 RID: 58802 RVA: 0x003DB36C File Offset: 0x003D956C
			public void __clearDele_EventOnBeginDrag()
			{
				this.m_owner.__clearDele_EventOnBeginDrag();
			}

			// Token: 0x0600E5B3 RID: 58803 RVA: 0x003DB37C File Offset: 0x003D957C
			public void __callDele_EventOnEndDrag()
			{
				this.m_owner.__callDele_EventOnEndDrag();
			}

			// Token: 0x0600E5B4 RID: 58804 RVA: 0x003DB38C File Offset: 0x003D958C
			public void __clearDele_EventOnEndDrag()
			{
				this.m_owner.__clearDele_EventOnEndDrag();
			}

			// Token: 0x0600E5B5 RID: 58805 RVA: 0x003DB39C File Offset: 0x003D959C
			public void __callDele_EventOnClick()
			{
				this.m_owner.__callDele_EventOnClick();
			}

			// Token: 0x0600E5B6 RID: 58806 RVA: 0x003DB3AC File Offset: 0x003D95AC
			public void __clearDele_EventOnClick()
			{
				this.m_owner.__clearDele_EventOnClick();
			}

			// Token: 0x0600E5B7 RID: 58807 RVA: 0x003DB3BC File Offset: 0x003D95BC
			public void __callDele_EventOnSliderFull()
			{
				this.m_owner.__callDele_EventOnSliderFull();
			}

			// Token: 0x0600E5B8 RID: 58808 RVA: 0x003DB3CC File Offset: 0x003D95CC
			public void __clearDele_EventOnSliderFull()
			{
				this.m_owner.__clearDele_EventOnSliderFull();
			}

			// Token: 0x0600E5B9 RID: 58809 RVA: 0x003DB3DC File Offset: 0x003D95DC
			public void __callDele_EventOnSliderEmpty()
			{
				this.m_owner.__callDele_EventOnSliderEmpty();
			}

			// Token: 0x0600E5BA RID: 58810 RVA: 0x003DB3EC File Offset: 0x003D95EC
			public void __clearDele_EventOnSliderEmpty()
			{
				this.m_owner.__clearDele_EventOnSliderEmpty();
			}

			// Token: 0x17002C9F RID: 11423
			// (get) Token: 0x0600E5BB RID: 58811 RVA: 0x003DB3FC File Offset: 0x003D95FC
			// (set) Token: 0x0600E5BC RID: 58812 RVA: 0x003DB40C File Offset: 0x003D960C
			public int m_pixelInterval
			{
				get
				{
					return this.m_owner.m_pixelInterval;
				}
				set
				{
					this.m_owner.m_pixelInterval = value;
				}
			}

			// Token: 0x17002CA0 RID: 11424
			// (get) Token: 0x0600E5BD RID: 58813 RVA: 0x003DB41C File Offset: 0x003D961C
			// (set) Token: 0x0600E5BE RID: 58814 RVA: 0x003DB42C File Offset: 0x003D962C
			public GameObject m_touchImage
			{
				get
				{
					return this.m_owner.m_touchImage;
				}
				set
				{
					this.m_owner.m_touchImage = value;
				}
			}

			// Token: 0x17002CA1 RID: 11425
			// (get) Token: 0x0600E5BF RID: 58815 RVA: 0x003DB43C File Offset: 0x003D963C
			// (set) Token: 0x0600E5C0 RID: 58816 RVA: 0x003DB44C File Offset: 0x003D964C
			public Slider m_slider
			{
				get
				{
					return this.m_owner.m_slider;
				}
				set
				{
					this.m_owner.m_slider = value;
				}
			}

			// Token: 0x17002CA2 RID: 11426
			// (get) Token: 0x0600E5C1 RID: 58817 RVA: 0x003DB45C File Offset: 0x003D965C
			// (set) Token: 0x0600E5C2 RID: 58818 RVA: 0x003DB46C File Offset: 0x003D966C
			public Slider m_effectSlider
			{
				get
				{
					return this.m_owner.m_effectSlider;
				}
				set
				{
					this.m_owner.m_effectSlider = value;
				}
			}

			// Token: 0x17002CA3 RID: 11427
			// (get) Token: 0x0600E5C3 RID: 58819 RVA: 0x003DB47C File Offset: 0x003D967C
			// (set) Token: 0x0600E5C4 RID: 58820 RVA: 0x003DB48C File Offset: 0x003D968C
			public float m_curMovePixel
			{
				get
				{
					return this.m_owner.m_curMovePixel;
				}
				set
				{
					this.m_owner.m_curMovePixel = value;
				}
			}

			// Token: 0x17002CA4 RID: 11428
			// (get) Token: 0x0600E5C5 RID: 58821 RVA: 0x003DB49C File Offset: 0x003D969C
			// (set) Token: 0x0600E5C6 RID: 58822 RVA: 0x003DB4AC File Offset: 0x003D96AC
			public bool m_isDrag
			{
				get
				{
					return this.m_owner.m_isDrag;
				}
				set
				{
					this.m_owner.m_isDrag = value;
				}
			}

			// Token: 0x17002CA5 RID: 11429
			// (get) Token: 0x0600E5C7 RID: 58823 RVA: 0x003DB4BC File Offset: 0x003D96BC
			// (set) Token: 0x0600E5C8 RID: 58824 RVA: 0x003DB4CC File Offset: 0x003D96CC
			public bool m_hasDoneEvent
			{
				get
				{
					return this.m_owner.m_hasDoneEvent;
				}
				set
				{
					this.m_owner.m_hasDoneEvent = value;
				}
			}

			// Token: 0x17002CA6 RID: 11430
			// (get) Token: 0x0600E5C9 RID: 58825 RVA: 0x003DB4DC File Offset: 0x003D96DC
			// (set) Token: 0x0600E5CA RID: 58826 RVA: 0x003DB4EC File Offset: 0x003D96EC
			public List<int> m_heroPerformanceIds
			{
				get
				{
					return this.m_owner.m_heroPerformanceIds;
				}
				set
				{
					this.m_owner.m_heroPerformanceIds = value;
				}
			}

			// Token: 0x17002CA7 RID: 11431
			// (get) Token: 0x0600E5CB RID: 58827 RVA: 0x003DB4FC File Offset: 0x003D96FC
			// (set) Token: 0x0600E5CC RID: 58828 RVA: 0x003DB50C File Offset: 0x003D970C
			public int m_lastCount
			{
				get
				{
					return this.m_owner.m_lastCount;
				}
				set
				{
					this.m_owner.m_lastCount = value;
				}
			}

			// Token: 0x17002CA8 RID: 11432
			// (get) Token: 0x0600E5CD RID: 58829 RVA: 0x003DB51C File Offset: 0x003D971C
			// (set) Token: 0x0600E5CE RID: 58830 RVA: 0x003DB52C File Offset: 0x003D972C
			public int m_lastHeroPerformanceId
			{
				get
				{
					return this.m_owner.m_lastHeroPerformanceId;
				}
				set
				{
					this.m_owner.m_lastHeroPerformanceId = value;
				}
			}

			// Token: 0x17002CA9 RID: 11433
			// (get) Token: 0x0600E5CF RID: 58831 RVA: 0x003DB53C File Offset: 0x003D973C
			// (set) Token: 0x0600E5D0 RID: 58832 RVA: 0x003DB54C File Offset: 0x003D974C
			public IAudioPlayback m_audioPlayback
			{
				get
				{
					return this.m_owner.m_audioPlayback;
				}
				set
				{
					this.m_owner.m_audioPlayback = value;
				}
			}

			// Token: 0x17002CAA RID: 11434
			// (get) Token: 0x0600E5D1 RID: 58833 RVA: 0x003DB55C File Offset: 0x003D975C
			// (set) Token: 0x0600E5D2 RID: 58834 RVA: 0x003DB56C File Offset: 0x003D976C
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

			// Token: 0x0600E5D3 RID: 58835 RVA: 0x003DB57C File Offset: 0x003D977C
			public void Start()
			{
				this.m_owner.Start();
			}

			// Token: 0x0600E5D4 RID: 58836 RVA: 0x003DB58C File Offset: 0x003D978C
			public IEnumerator SliderValueDown()
			{
				return this.m_owner.SliderValueDown();
			}

			// Token: 0x0600E5D5 RID: 58837 RVA: 0x003DB59C File Offset: 0x003D979C
			public void SetDragObjPostion(PointerEventData eventData)
			{
				this.m_owner.SetDragObjPostion(eventData);
			}

			// Token: 0x04008ABD RID: 35517
			private OnDragTrigger m_owner;
		}
	}
}
