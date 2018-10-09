using System;
using UnityEngine;

// Token: 0x02001083 RID: 4227
public class LeftMouseButtonTapCount
{
	// Token: 0x17003E61 RID: 15969
	// (set) Token: 0x0601561B RID: 87579 RVA: 0x0056C8FC File Offset: 0x0056AAFC
	public static float TabInterval
	{
		set
		{
			LeftMouseButtonTapCount._tabInterval = value;
		}
	}

	// Token: 0x17003E62 RID: 15970
	// (get) Token: 0x0601561C RID: 87580 RVA: 0x0056C904 File Offset: 0x0056AB04
	public static int Count
	{
		get
		{
			return (LeftMouseButtonTapCount._leftMouseButtonDownCount <= LeftMouseButtonTapCount._lastFrameLeftMouseButtonDownCount) ? 0 : LeftMouseButtonTapCount._leftMouseButtonDownCount;
		}
	}

	// Token: 0x0601561D RID: 87581 RVA: 0x0056C920 File Offset: 0x0056AB20
	public static void Update()
	{
		if (Time.time - LeftMouseButtonTapCount._leftMouseButtonDownTime > LeftMouseButtonTapCount._tabInterval)
		{
			LeftMouseButtonTapCount._leftMouseButtonDownCount = 0;
		}
		LeftMouseButtonTapCount._lastFrameLeftMouseButtonDownCount = LeftMouseButtonTapCount._leftMouseButtonDownCount;
		if (Time.time > LeftMouseButtonTapCount._leftMouseButtonDownTime && Input.GetMouseButtonDown(0))
		{
			LeftMouseButtonTapCount._leftMouseButtonDownCount++;
			LeftMouseButtonTapCount._leftMouseButtonDownTime = Time.time;
		}
	}

	// Token: 0x0400BA78 RID: 47736
	private static int _leftMouseButtonDownCount;

	// Token: 0x0400BA79 RID: 47737
	private static float _leftMouseButtonDownTime;

	// Token: 0x0400BA7A RID: 47738
	private static int _lastFrameLeftMouseButtonDownCount;

	// Token: 0x0400BA7B RID: 47739
	private static float _tabInterval = 0.35f;
}
