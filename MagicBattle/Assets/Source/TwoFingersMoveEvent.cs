using System;
using UnityEngine;

// Token: 0x02001084 RID: 4228
public class TwoFingersMoveEvent
{
	// Token: 0x17003E63 RID: 15971
	// (get) Token: 0x06015620 RID: 87584 RVA: 0x0056C998 File Offset: 0x0056AB98
	public static bool Up
	{
		get
		{
			return TwoFingersMoveEvent._isUp;
		}
	}

	// Token: 0x17003E64 RID: 15972
	// (get) Token: 0x06015621 RID: 87585 RVA: 0x0056C9A0 File Offset: 0x0056ABA0
	public static bool Down
	{
		get
		{
			return TwoFingersMoveEvent._isDown;
		}
	}

	// Token: 0x17003E65 RID: 15973
	// (get) Token: 0x06015622 RID: 87586 RVA: 0x0056C9A8 File Offset: 0x0056ABA8
	public static bool Left
	{
		get
		{
			return TwoFingersMoveEvent._isLeft;
		}
	}

	// Token: 0x17003E66 RID: 15974
	// (get) Token: 0x06015623 RID: 87587 RVA: 0x0056C9B0 File Offset: 0x0056ABB0
	public static bool Right
	{
		get
		{
			return TwoFingersMoveEvent._isRight;
		}
	}

	// Token: 0x06015624 RID: 87588 RVA: 0x0056C9B8 File Offset: 0x0056ABB8
	public static void Update()
	{
		if (Input.touchCount != 2)
		{
			TwoFingersMoveEvent.Reset();
		}
		else
		{
			if (TwoFingersMoveEvent._lastTouchCount != 2)
			{
				TwoFingersMoveEvent._touchDownPos = Input.touches[0].position;
			}
			TwoFingersMoveEvent._lastTouchPos = TwoFingersMoveEvent._curTouchPos;
			TwoFingersMoveEvent._curTouchPos = Input.touches[0].position;
			TwoFingersMoveEvent._isUp = (Time.time != TwoFingersMoveEvent._lastUpdateTime && TwoFingersMoveEvent._touchDownPos.y != 0f && TwoFingersMoveEvent._curTouchPos.y - TwoFingersMoveEvent._touchDownPos.y > TwoFingersMoveEvent._createEventDist && TwoFingersMoveEvent._lastTouchPos.y - TwoFingersMoveEvent._touchDownPos.y < TwoFingersMoveEvent._createEventDist);
			TwoFingersMoveEvent._isDown = (Time.time != TwoFingersMoveEvent._lastUpdateTime && TwoFingersMoveEvent._touchDownPos.y != 0f && TwoFingersMoveEvent._touchDownPos.y - TwoFingersMoveEvent._curTouchPos.y > TwoFingersMoveEvent._createEventDist && TwoFingersMoveEvent._touchDownPos.y - TwoFingersMoveEvent._lastTouchPos.y < TwoFingersMoveEvent._createEventDist);
			if (TwoFingersMoveEvent._isUp || TwoFingersMoveEvent._isDown)
			{
				TwoFingersMoveEvent._touchDownPos.y = TwoFingersMoveEvent._curTouchPos.y;
			}
			TwoFingersMoveEvent._isRight = (Time.time != TwoFingersMoveEvent._lastUpdateTime && TwoFingersMoveEvent._touchDownPos.x != 0f && TwoFingersMoveEvent._curTouchPos.x - TwoFingersMoveEvent._touchDownPos.x > TwoFingersMoveEvent._createEventDist && TwoFingersMoveEvent._lastTouchPos.x - TwoFingersMoveEvent._touchDownPos.x < TwoFingersMoveEvent._createEventDist);
			TwoFingersMoveEvent._isLeft = (Time.time != TwoFingersMoveEvent._lastUpdateTime && TwoFingersMoveEvent._touchDownPos.x != 0f && TwoFingersMoveEvent._touchDownPos.x - TwoFingersMoveEvent._curTouchPos.x > TwoFingersMoveEvent._createEventDist && TwoFingersMoveEvent._touchDownPos.x - TwoFingersMoveEvent._lastTouchPos.x < TwoFingersMoveEvent._createEventDist);
			if (TwoFingersMoveEvent._isRight || TwoFingersMoveEvent._isLeft)
			{
				TwoFingersMoveEvent._touchDownPos.x = TwoFingersMoveEvent._curTouchPos.x;
			}
		}
		TwoFingersMoveEvent._lastTouchCount = Input.touchCount;
		TwoFingersMoveEvent._lastUpdateTime = Time.time;
	}

	// Token: 0x06015625 RID: 87589 RVA: 0x0056CC18 File Offset: 0x0056AE18
	private static void Reset()
	{
		TwoFingersMoveEvent._lastTouchPos = Vector2.zero;
		TwoFingersMoveEvent._curTouchPos = Vector2.zero;
		TwoFingersMoveEvent._touchDownPos = Vector2.zero;
		TwoFingersMoveEvent._lastTouchCount = 0;
		TwoFingersMoveEvent._isUp = (TwoFingersMoveEvent._isDown = (TwoFingersMoveEvent._isLeft = (TwoFingersMoveEvent._isRight = false)));
	}

	// Token: 0x0400BA7C RID: 47740
	private static Vector2 _lastTouchPos = Vector2.zero;

	// Token: 0x0400BA7D RID: 47741
	private static Vector2 _curTouchPos = Vector2.zero;

	// Token: 0x0400BA7E RID: 47742
	private static Vector2 _touchDownPos = Vector2.zero;

	// Token: 0x0400BA7F RID: 47743
	private static int _lastTouchCount = 0;

	// Token: 0x0400BA80 RID: 47744
	private static bool _isUp = false;

	// Token: 0x0400BA81 RID: 47745
	private static bool _isDown = false;

	// Token: 0x0400BA82 RID: 47746
	private static bool _isLeft = false;

	// Token: 0x0400BA83 RID: 47747
	private static bool _isRight = false;

	// Token: 0x0400BA84 RID: 47748
	private static float _createEventDist = 150f;

	// Token: 0x0400BA85 RID: 47749
	private static float _lastUpdateTime = 0f;
}
