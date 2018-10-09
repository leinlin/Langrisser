using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020000FC RID: 252
public class ThreeDTouchEventListener : MonoBehaviour, IUpdateSelectedHandler, IEventSystemHandler
{
	// Token: 0x06000A1C RID: 2588 RVA: 0x0002B3D8 File Offset: 0x000295D8
	public void OnDisable()
	{
		this.IsThreeDTouchTriggered = false;
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x0002B3E4 File Offset: 0x000295E4
	public void OnUpdateSelected(BaseEventData data)
	{
		if (Input.touchCount > 0)
		{
			if (Input.touchPressureSupported)
			{
				Touch touch = Input.GetTouch(0);
				if (touch.pressure > 5f && this.EventOnThreeDTouchTriggered != null && !this.IsThreeDTouchTriggered)
				{
					global::Debug.Log("3D touch on UI triggered!");
					this.IsThreeDTouchTriggered = true;
					this.EventOnThreeDTouchTriggered();
				}
				if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled || touch.phase == TouchPhase.Began)
				{
					global::Debug.Log("ThreeDTouchEventListener 3D touch ended" + touch.phase);
					this.IsThreeDTouchTriggered = false;
				}
			}
		}
		else
		{
			this.IsThreeDTouchTriggered = false;
		}
	}

	// Token: 0x14000028 RID: 40
	// (add) Token: 0x06000A1E RID: 2590 RVA: 0x0002B4A4 File Offset: 0x000296A4
	// (remove) Token: 0x06000A1F RID: 2591 RVA: 0x0002B4DC File Offset: 0x000296DC
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public event Action EventOnThreeDTouchTriggered;

	// Token: 0x04000611 RID: 1553
	public float ThreeDTouchThreshhold = 5f;

	// Token: 0x04000612 RID: 1554
	public bool IsThreeDTouchTriggered;
}
