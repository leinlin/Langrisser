using System;
using BlackJack.BJFramework.Runtime.UI;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020000DC RID: 220
public class EventTriggerListener : EventTrigger
{
	// Token: 0x06000860 RID: 2144 RVA: 0x00024E3C File Offset: 0x0002303C
	public static EventTriggerListener Get(GameObject go)
	{
		EventTriggerListener eventTriggerListener = go.GetComponent<EventTriggerListener>();
		if (eventTriggerListener == null)
		{
			eventTriggerListener = go.AddComponent<EventTriggerListener>();
		}
		return eventTriggerListener;
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00024E64 File Offset: 0x00023064
	public static EventTriggerListener Get(Transform transform)
	{
		EventTriggerListener eventTriggerListener = transform.GetComponent<EventTriggerListener>();
		if (eventTriggerListener == null)
		{
			eventTriggerListener = transform.gameObject.AddComponent<EventTriggerListener>();
		}
		return eventTriggerListener;
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00024E94 File Offset: 0x00023094
	public override void OnPointerClick(PointerEventData eventData)
	{
		if (!UIControllerBase.CheckAndUpdateCurrFrameButtonClickStateInfo())
		{
			return;
		}
		if (this.onClick != null)
		{
			this.onClick(base.gameObject);
		}
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00024EC0 File Offset: 0x000230C0
	public override void OnPointerUp(PointerEventData eventData)
	{
		if (this.onUp != null)
		{
			this.onUp(base.gameObject);
		}
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00024EE0 File Offset: 0x000230E0
	public override void OnPointerDown(PointerEventData eventData)
	{
		if (this.onDown != null)
		{
			this.onDown(base.gameObject);
		}
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x00024F00 File Offset: 0x00023100
	public override void OnPointerEnter(PointerEventData eventData)
	{
		if (this.onEnter != null)
		{
			this.onEnter(base.gameObject);
		}
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x00024F20 File Offset: 0x00023120
	public override void OnPointerExit(PointerEventData eventData)
	{
		if (this.onExit != null)
		{
			this.onExit(base.gameObject);
		}
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x00024F40 File Offset: 0x00023140
	public override void OnSelect(BaseEventData eventData)
	{
		if (this.onSelect != null)
		{
			this.onSelect(base.gameObject);
		}
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x00024F60 File Offset: 0x00023160
	public override void OnDeselect(BaseEventData eventData)
	{
		if (this.onDeselect != null)
		{
			this.onDeselect(base.gameObject);
		}
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x00024F80 File Offset: 0x00023180
	public override void OnBeginDrag(PointerEventData eventData)
	{
		if (this.onBeginDrag != null)
		{
			this.onBeginDrag(base.gameObject);
		}
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x00024FA0 File Offset: 0x000231A0
	public override void OnEndDrag(PointerEventData eventData)
	{
		if (this.onEndDrag != null)
		{
			this.onEndDrag(base.gameObject);
		}
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x00024FC0 File Offset: 0x000231C0
	public override void OnUpdateSelected(BaseEventData eventData)
	{
		if (this.onUpdateSelect != null)
		{
			this.onUpdateSelect(base.gameObject);
		}
	}

	// Token: 0x0400053F RID: 1343
	public EventTriggerListener.VoidDelegate onClick;

	// Token: 0x04000540 RID: 1344
	public EventTriggerListener.VoidDelegate onDown;

	// Token: 0x04000541 RID: 1345
	public EventTriggerListener.VoidDelegate onUp;

	// Token: 0x04000542 RID: 1346
	public EventTriggerListener.VoidDelegate onEnter;

	// Token: 0x04000543 RID: 1347
	public EventTriggerListener.VoidDelegate onExit;

	// Token: 0x04000544 RID: 1348
	public EventTriggerListener.VoidDelegate onSelect;

	// Token: 0x04000545 RID: 1349
	public EventTriggerListener.VoidDelegate onDeselect;

	// Token: 0x04000546 RID: 1350
	public EventTriggerListener.VoidDelegate onUpdateSelect;

	// Token: 0x04000547 RID: 1351
	public EventTriggerListener.VoidDelegate onBeginDrag;

	// Token: 0x04000548 RID: 1352
	public EventTriggerListener.VoidDelegate onEndDrag;

	// Token: 0x020000DD RID: 221
	// (Invoke) Token: 0x0600086D RID: 2157
	public delegate void VoidDelegate(GameObject go);
}
