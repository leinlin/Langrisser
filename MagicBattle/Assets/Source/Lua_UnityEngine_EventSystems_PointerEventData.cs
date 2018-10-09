using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016BD RID: 5821
[Preserve]
public class Lua_UnityEngine_EventSystems_PointerEventData : LuaObject
{
	// Token: 0x060231A2 RID: 143778 RVA: 0x00C28748 File Offset: 0x00C26948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem;
			LuaObject.checkType<EventSystem>(l, 2, out eventSystem);
			PointerEventData o = new PointerEventData(eventSystem);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231A3 RID: 143779 RVA: 0x00C2879C File Offset: 0x00C2699C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPointerMoving(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			bool b = pointerEventData.IsPointerMoving();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231A4 RID: 143780 RVA: 0x00C287F0 File Offset: 0x00C269F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsScrolling(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			bool b = pointerEventData.IsScrolling();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231A5 RID: 143781 RVA: 0x00C28844 File Offset: 0x00C26A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hovered(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.hovered);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231A6 RID: 143782 RVA: 0x00C28898 File Offset: 0x00C26A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_hovered(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			List<GameObject> hovered;
			LuaObject.checkType<List<GameObject>>(l, 2, out hovered);
			pointerEventData.hovered = hovered;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231A7 RID: 143783 RVA: 0x00C288F0 File Offset: 0x00C26AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pointerEnter(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.pointerEnter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231A8 RID: 143784 RVA: 0x00C28944 File Offset: 0x00C26B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pointerEnter(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			GameObject pointerEnter;
			LuaObject.checkType<GameObject>(l, 2, out pointerEnter);
			pointerEventData.pointerEnter = pointerEnter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231A9 RID: 143785 RVA: 0x00C2899C File Offset: 0x00C26B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lastPress(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.lastPress);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231AA RID: 143786 RVA: 0x00C289F0 File Offset: 0x00C26BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rawPointerPress(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.rawPointerPress);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231AB RID: 143787 RVA: 0x00C28A44 File Offset: 0x00C26C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rawPointerPress(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			GameObject rawPointerPress;
			LuaObject.checkType<GameObject>(l, 2, out rawPointerPress);
			pointerEventData.rawPointerPress = rawPointerPress;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231AC RID: 143788 RVA: 0x00C28A9C File Offset: 0x00C26C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pointerDrag(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.pointerDrag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231AD RID: 143789 RVA: 0x00C28AF0 File Offset: 0x00C26CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pointerDrag(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			GameObject pointerDrag;
			LuaObject.checkType<GameObject>(l, 2, out pointerDrag);
			pointerEventData.pointerDrag = pointerDrag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231AE RID: 143790 RVA: 0x00C28B48 File Offset: 0x00C26D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pointerCurrentRaycast(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.pointerCurrentRaycast);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231AF RID: 143791 RVA: 0x00C28BA0 File Offset: 0x00C26DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pointerCurrentRaycast(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			RaycastResult pointerCurrentRaycast;
			LuaObject.checkValueType<RaycastResult>(l, 2, out pointerCurrentRaycast);
			pointerEventData.pointerCurrentRaycast = pointerCurrentRaycast;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231B0 RID: 143792 RVA: 0x00C28BF8 File Offset: 0x00C26DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pointerPressRaycast(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.pointerPressRaycast);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231B1 RID: 143793 RVA: 0x00C28C50 File Offset: 0x00C26E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pointerPressRaycast(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			RaycastResult pointerPressRaycast;
			LuaObject.checkValueType<RaycastResult>(l, 2, out pointerPressRaycast);
			pointerEventData.pointerPressRaycast = pointerPressRaycast;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231B2 RID: 143794 RVA: 0x00C28CA8 File Offset: 0x00C26EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_eligibleForClick(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.eligibleForClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231B3 RID: 143795 RVA: 0x00C28CFC File Offset: 0x00C26EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_eligibleForClick(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			bool eligibleForClick;
			LuaObject.checkType(l, 2, out eligibleForClick);
			pointerEventData.eligibleForClick = eligibleForClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231B4 RID: 143796 RVA: 0x00C28D54 File Offset: 0x00C26F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pointerId(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.pointerId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231B5 RID: 143797 RVA: 0x00C28DA8 File Offset: 0x00C26FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pointerId(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			int pointerId;
			LuaObject.checkType(l, 2, out pointerId);
			pointerEventData.pointerId = pointerId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231B6 RID: 143798 RVA: 0x00C28E00 File Offset: 0x00C27000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231B7 RID: 143799 RVA: 0x00C28E54 File Offset: 0x00C27054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			pointerEventData.position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231B8 RID: 143800 RVA: 0x00C28EAC File Offset: 0x00C270AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_delta(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.delta);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231B9 RID: 143801 RVA: 0x00C28F00 File Offset: 0x00C27100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_delta(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			Vector2 delta;
			LuaObject.checkType(l, 2, out delta);
			pointerEventData.delta = delta;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231BA RID: 143802 RVA: 0x00C28F58 File Offset: 0x00C27158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pressPosition(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.pressPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231BB RID: 143803 RVA: 0x00C28FAC File Offset: 0x00C271AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pressPosition(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			Vector2 pressPosition;
			LuaObject.checkType(l, 2, out pressPosition);
			pointerEventData.pressPosition = pressPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231BC RID: 143804 RVA: 0x00C29004 File Offset: 0x00C27204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clickTime(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.clickTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231BD RID: 143805 RVA: 0x00C29058 File Offset: 0x00C27258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_clickTime(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			float clickTime;
			LuaObject.checkType(l, 2, out clickTime);
			pointerEventData.clickTime = clickTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231BE RID: 143806 RVA: 0x00C290B0 File Offset: 0x00C272B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clickCount(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.clickCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231BF RID: 143807 RVA: 0x00C29104 File Offset: 0x00C27304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_clickCount(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			int clickCount;
			LuaObject.checkType(l, 2, out clickCount);
			pointerEventData.clickCount = clickCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231C0 RID: 143808 RVA: 0x00C2915C File Offset: 0x00C2735C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_scrollDelta(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.scrollDelta);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231C1 RID: 143809 RVA: 0x00C291B0 File Offset: 0x00C273B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_scrollDelta(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			Vector2 scrollDelta;
			LuaObject.checkType(l, 2, out scrollDelta);
			pointerEventData.scrollDelta = scrollDelta;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231C2 RID: 143810 RVA: 0x00C29208 File Offset: 0x00C27408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useDragThreshold(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.useDragThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231C3 RID: 143811 RVA: 0x00C2925C File Offset: 0x00C2745C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useDragThreshold(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			bool useDragThreshold;
			LuaObject.checkType(l, 2, out useDragThreshold);
			pointerEventData.useDragThreshold = useDragThreshold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231C4 RID: 143812 RVA: 0x00C292B4 File Offset: 0x00C274B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dragging(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.dragging);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231C5 RID: 143813 RVA: 0x00C29308 File Offset: 0x00C27508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_dragging(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			bool dragging;
			LuaObject.checkType(l, 2, out dragging);
			pointerEventData.dragging = dragging;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231C6 RID: 143814 RVA: 0x00C29360 File Offset: 0x00C27560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_button(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)pointerEventData.button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231C7 RID: 143815 RVA: 0x00C293B4 File Offset: 0x00C275B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_button(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			PointerEventData.InputButton button;
			LuaObject.checkEnum<PointerEventData.InputButton>(l, 2, out button);
			pointerEventData.button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231C8 RID: 143816 RVA: 0x00C2940C File Offset: 0x00C2760C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enterEventCamera(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.enterEventCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231C9 RID: 143817 RVA: 0x00C29460 File Offset: 0x00C27660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pressEventCamera(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.pressEventCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231CA RID: 143818 RVA: 0x00C294B4 File Offset: 0x00C276B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_pointerPress(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointerEventData.pointerPress);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231CB RID: 143819 RVA: 0x00C29508 File Offset: 0x00C27708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pointerPress(IntPtr l)
	{
		int result;
		try
		{
			PointerEventData pointerEventData = (PointerEventData)LuaObject.checkSelf(l);
			GameObject pointerPress;
			LuaObject.checkType<GameObject>(l, 2, out pointerPress);
			pointerEventData.pointerPress = pointerPress;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231CC RID: 143820 RVA: 0x00C29560 File Offset: 0x00C27760
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.PointerEventData");
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.IsPointerMoving);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache0);
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.IsScrolling);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1);
		string name = "hovered";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_hovered);
		}
		LuaCSFunction get = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache2;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_hovered);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache3, true);
		string name2 = "pointerEnter";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_pointerEnter);
		}
		LuaCSFunction get2 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache4;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_pointerEnter);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache5, true);
		string name3 = "lastPress";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_lastPress);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache6, null, true);
		string name4 = "rawPointerPress";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_rawPointerPress);
		}
		LuaCSFunction get3 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache7;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_rawPointerPress);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache8, true);
		string name5 = "pointerDrag";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_pointerDrag);
		}
		LuaCSFunction get4 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache9;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_pointerDrag);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheA, true);
		string name6 = "pointerCurrentRaycast";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_pointerCurrentRaycast);
		}
		LuaCSFunction get5 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheB;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_pointerCurrentRaycast);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheC, true);
		string name7 = "pointerPressRaycast";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_pointerPressRaycast);
		}
		LuaCSFunction get6 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheD;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_pointerPressRaycast);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheE, true);
		string name8 = "eligibleForClick";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_eligibleForClick);
		}
		LuaCSFunction get7 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cacheF;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_eligibleForClick);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache10, true);
		string name9 = "pointerId";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_pointerId);
		}
		LuaCSFunction get8 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache11;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_pointerId);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache12, true);
		string name10 = "position";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_position);
		}
		LuaCSFunction get9 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache13;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_position);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache14, true);
		string name11 = "delta";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_delta);
		}
		LuaCSFunction get10 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache15;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_delta);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache16, true);
		string name12 = "pressPosition";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_pressPosition);
		}
		LuaCSFunction get11 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache17;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_pressPosition);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache18, true);
		string name13 = "clickTime";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_clickTime);
		}
		LuaCSFunction get12 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache19;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_clickTime);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1A, true);
		string name14 = "clickCount";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_clickCount);
		}
		LuaCSFunction get13 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1B;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_clickCount);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1C, true);
		string name15 = "scrollDelta";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_scrollDelta);
		}
		LuaCSFunction get14 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1D;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_scrollDelta);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1E, true);
		string name16 = "useDragThreshold";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_useDragThreshold);
		}
		LuaCSFunction get15 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache1F;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_useDragThreshold);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache20, true);
		string name17 = "dragging";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_dragging);
		}
		LuaCSFunction get16 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache21;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_dragging);
		}
		LuaObject.addMember(l, name17, get16, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache22, true);
		string name18 = "button";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_button);
		}
		LuaCSFunction get17 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache23;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_button);
		}
		LuaObject.addMember(l, name18, get17, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache24, true);
		string name19 = "enterEventCamera";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_enterEventCamera);
		}
		LuaObject.addMember(l, name19, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache25, null, true);
		string name20 = "pressEventCamera";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_pressEventCamera);
		}
		LuaObject.addMember(l, name20, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache26, null, true);
		string name21 = "pointerPress";
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.get_pointerPress);
		}
		LuaCSFunction get18 = Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache27;
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.set_pointerPress);
		}
		LuaObject.addMember(l, name21, get18, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache28, true);
		if (Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerEventData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_EventSystems_PointerEventData.<>f__mg$cache29, typeof(PointerEventData), typeof(BaseEventData));
	}

	// Token: 0x04019086 RID: 102534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019087 RID: 102535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019088 RID: 102536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019089 RID: 102537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401908A RID: 102538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401908B RID: 102539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401908C RID: 102540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401908D RID: 102541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401908E RID: 102542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401908F RID: 102543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019090 RID: 102544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019091 RID: 102545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019092 RID: 102546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019093 RID: 102547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019094 RID: 102548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019095 RID: 102549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019096 RID: 102550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019097 RID: 102551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019098 RID: 102552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019099 RID: 102553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401909A RID: 102554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401909B RID: 102555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401909C RID: 102556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401909D RID: 102557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401909E RID: 102558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401909F RID: 102559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040190A0 RID: 102560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040190A1 RID: 102561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040190A2 RID: 102562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040190A3 RID: 102563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040190A4 RID: 102564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040190A5 RID: 102565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040190A6 RID: 102566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040190A7 RID: 102567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040190A8 RID: 102568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040190A9 RID: 102569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040190AA RID: 102570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040190AB RID: 102571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040190AC RID: 102572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040190AD RID: 102573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040190AE RID: 102574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040190AF RID: 102575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;
}
