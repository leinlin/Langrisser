using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200156D RID: 5485
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ScrollSnapCenter : LuaObject
{
	// Token: 0x06020E1B RID: 134683 RVA: 0x00B07374 File Offset: 0x00B05574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetItemCount(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int itemCount;
			LuaObject.checkType(l, 2, out itemCount);
			scrollSnapCenter.SetItemCount(itemCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E1C RID: 134684 RVA: 0x00B073CC File Offset: 0x00B055CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetItemCount(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int itemCount = scrollSnapCenter.GetItemCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, itemCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E1D RID: 134685 RVA: 0x00B07420 File Offset: 0x00B05620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeItemPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			Vector2 o = scrollSnapCenter.ComputeItemPosition(idx);
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

	// Token: 0x06020E1E RID: 134686 RVA: 0x00B07484 File Offset: 0x00B05684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCenterItemIndexUnclamped(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int centerItemIndexUnclamped = scrollSnapCenter.GetCenterItemIndexUnclamped();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, centerItemIndexUnclamped);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E1F RID: 134687 RVA: 0x00B074D8 File Offset: 0x00B056D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCenterItemIndex(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int centerItemIndex = scrollSnapCenter.GetCenterItemIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, centerItemIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E20 RID: 134688 RVA: 0x00B0752C File Offset: 0x00B0572C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Snap(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			bool smooth;
			LuaObject.checkType(l, 3, out smooth);
			scrollSnapCenter.Snap(idx, smooth);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E21 RID: 134689 RVA: 0x00B07590 File Offset: 0x00B05790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollSnapCenter.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E22 RID: 134690 RVA: 0x00B075E8 File Offset: 0x00B057E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollSnapCenter.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E23 RID: 134691 RVA: 0x00B07640 File Offset: 0x00B05840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Awake(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			scrollSnapCenter.m_luaExportHelper.Awake();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E24 RID: 134692 RVA: 0x00B07694 File Offset: 0x00B05894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LateUpdate(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			scrollSnapCenter.m_luaExportHelper.LateUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E25 RID: 134693 RVA: 0x00B076E8 File Offset: 0x00B058E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetItemIndexByDragDistance(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int itemIndexByDragDistance = scrollSnapCenter.m_luaExportHelper.GetItemIndexByDragDistance();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, itemIndexByDragDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E26 RID: 134694 RVA: 0x00B07744 File Offset: 0x00B05944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSnapCenterPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			Vector2 o = scrollSnapCenter.m_luaExportHelper.ComputeSnapCenterPosition(idx);
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

	// Token: 0x06020E27 RID: 134695 RVA: 0x00B077AC File Offset: 0x00B059AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCenterItemChanged(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			scrollSnapCenter.m_luaExportHelper.__callDele_EventOnCenterItemChanged(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E28 RID: 134696 RVA: 0x00B07808 File Offset: 0x00B05A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCenterItemChanged(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			scrollSnapCenter.m_luaExportHelper.__clearDele_EventOnCenterItemChanged(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E29 RID: 134697 RVA: 0x00B07864 File Offset: 0x00B05A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			scrollSnapCenter.m_luaExportHelper.__callDele_EventOnEndDrag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E2A RID: 134698 RVA: 0x00B078B8 File Offset: 0x00B05AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			scrollSnapCenter.m_luaExportHelper.__clearDele_EventOnEndDrag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E2B RID: 134699 RVA: 0x00B0790C File Offset: 0x00B05B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemSize(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollSnapCenter.m_itemSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E2C RID: 134700 RVA: 0x00B07960 File Offset: 0x00B05B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemSize(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			float itemSize;
			LuaObject.checkType(l, 2, out itemSize);
			scrollSnapCenter.m_itemSize = itemSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E2D RID: 134701 RVA: 0x00B079B8 File Offset: 0x00B05BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollSnapDir(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)scrollSnapCenter.m_scrollSnapDir);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E2E RID: 134702 RVA: 0x00B07A0C File Offset: 0x00B05C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollSnapDir(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			ScrollSnapDirection scrollSnapDir;
			LuaObject.checkEnum<ScrollSnapDirection>(l, 2, out scrollSnapDir);
			scrollSnapCenter.m_scrollSnapDir = scrollSnapDir;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E2F RID: 134703 RVA: 0x00B07A64 File Offset: 0x00B05C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollSnapPageType(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)scrollSnapCenter.m_scrollSnapPageType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E30 RID: 134704 RVA: 0x00B07AB8 File Offset: 0x00B05CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollSnapPageType(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			ScrollSnapPageType scrollSnapPageType;
			LuaObject.checkEnum<ScrollSnapPageType>(l, 2, out scrollSnapPageType);
			scrollSnapCenter.m_scrollSnapPageType = scrollSnapPageType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E31 RID: 134705 RVA: 0x00B07B10 File Offset: 0x00B05D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dragPercentage(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollSnapCenter.m_dragPercentage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E32 RID: 134706 RVA: 0x00B07B64 File Offset: 0x00B05D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dragPercentage(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			float dragPercentage;
			LuaObject.checkType(l, 2, out dragPercentage);
			scrollSnapCenter.m_dragPercentage = dragPercentage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E33 RID: 134707 RVA: 0x00B07BBC File Offset: 0x00B05DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCenterItemChanged(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					scrollSnapCenter.EventOnCenterItemChanged += value;
				}
				else if (num == 2)
				{
					scrollSnapCenter.EventOnCenterItemChanged -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E34 RID: 134708 RVA: 0x00B07C3C File Offset: 0x00B05E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					scrollSnapCenter.EventOnEndDrag += value;
				}
				else if (num == 2)
				{
					scrollSnapCenter.EventOnEndDrag -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E35 RID: 134709 RVA: 0x00B07CBC File Offset: 0x00B05EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSnaping(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollSnapCenter.m_luaExportHelper.m_isSnaping);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E36 RID: 134710 RVA: 0x00B07D14 File Offset: 0x00B05F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSnaping(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			bool isSnaping;
			LuaObject.checkType(l, 2, out isSnaping);
			scrollSnapCenter.m_luaExportHelper.m_isSnaping = isSnaping;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E37 RID: 134711 RVA: 0x00B07D70 File Offset: 0x00B05F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_snapPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollSnapCenter.m_luaExportHelper.m_snapPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E38 RID: 134712 RVA: 0x00B07DC8 File Offset: 0x00B05FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_snapPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			Vector2 snapPosition;
			LuaObject.checkType(l, 2, out snapPosition);
			scrollSnapCenter.m_luaExportHelper.m_snapPosition = snapPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E39 RID: 134713 RVA: 0x00B07E24 File Offset: 0x00B06024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemCount(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollSnapCenter.m_luaExportHelper.m_itemCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E3A RID: 134714 RVA: 0x00B07E7C File Offset: 0x00B0607C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemCount(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int itemCount;
			LuaObject.checkType(l, 2, out itemCount);
			scrollSnapCenter.m_luaExportHelper.m_itemCount = itemCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E3B RID: 134715 RVA: 0x00B07ED8 File Offset: 0x00B060D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scrollRect(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollSnapCenter.m_luaExportHelper.m_scrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E3C RID: 134716 RVA: 0x00B07F30 File Offset: 0x00B06130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scrollRect(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			ScrollRect scrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out scrollRect);
			scrollSnapCenter.m_luaExportHelper.m_scrollRect = scrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E3D RID: 134717 RVA: 0x00B07F8C File Offset: 0x00B0618C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentCenterIndex(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollSnapCenter.m_luaExportHelper.m_currentCenterIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E3E RID: 134718 RVA: 0x00B07FE4 File Offset: 0x00B061E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentCenterIndex(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			int currentCenterIndex;
			LuaObject.checkType(l, 2, out currentCenterIndex);
			scrollSnapCenter.m_luaExportHelper.m_currentCenterIndex = currentCenterIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E3F RID: 134719 RVA: 0x00B08040 File Offset: 0x00B06240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_beginDragPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollSnapCenter.m_luaExportHelper.m_beginDragPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E40 RID: 134720 RVA: 0x00B08098 File Offset: 0x00B06298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_beginDragPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			Vector2 beginDragPosition;
			LuaObject.checkType(l, 2, out beginDragPosition);
			scrollSnapCenter.m_luaExportHelper.m_beginDragPosition = beginDragPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E41 RID: 134721 RVA: 0x00B080F4 File Offset: 0x00B062F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_endFragPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scrollSnapCenter.m_luaExportHelper.m_endFragPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E42 RID: 134722 RVA: 0x00B0814C File Offset: 0x00B0634C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_endFragPosition(IntPtr l)
	{
		int result;
		try
		{
			ScrollSnapCenter scrollSnapCenter = (ScrollSnapCenter)LuaObject.checkSelf(l);
			Vector2 endFragPosition;
			LuaObject.checkType(l, 2, out endFragPosition);
			scrollSnapCenter.m_luaExportHelper.m_endFragPosition = endFragPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020E43 RID: 134723 RVA: 0x00B081A8 File Offset: 0x00B063A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ScrollSnapCenter");
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.SetItemCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.GetItemCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.ComputeItemPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.GetCenterItemIndexUnclamped);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.GetCenterItemIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.Snap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.Awake);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.LateUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.GetItemIndexByDragDistance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.ComputeSnapCenterPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.__callDele_EventOnCenterItemChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.__clearDele_EventOnCenterItemChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.__callDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.__clearDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cacheF);
		string name = "m_itemSize";
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.get_m_itemSize);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_m_itemSize);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache11, true);
		string name2 = "m_scrollSnapDir";
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.get_m_scrollSnapDir);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_m_scrollSnapDir);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache13, true);
		string name3 = "m_scrollSnapPageType";
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.get_m_scrollSnapPageType);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_m_scrollSnapPageType);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache15, true);
		string name4 = "m_dragPercentage";
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.get_m_dragPercentage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_m_dragPercentage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache17, true);
		string name5 = "EventOnCenterItemChanged";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_EventOnCenterItemChanged);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache18, true);
		string name6 = "EventOnEndDrag";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_EventOnEndDrag);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache19, true);
		string name7 = "m_isSnaping";
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.get_m_isSnaping);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_m_isSnaping);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1B, true);
		string name8 = "m_snapPosition";
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.get_m_snapPosition);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_m_snapPosition);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1D, true);
		string name9 = "m_itemCount";
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.get_m_itemCount);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_m_itemCount);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache1F, true);
		string name10 = "m_scrollRect";
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.get_m_scrollRect);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_m_scrollRect);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache21, true);
		string name11 = "m_currentCenterIndex";
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.get_m_currentCenterIndex);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_m_currentCenterIndex);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache23, true);
		string name12 = "m_beginDragPosition";
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.get_m_beginDragPosition);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_m_beginDragPosition);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache25, true);
		string name13 = "m_endFragPosition";
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.get_m_endFragPosition);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.set_m_endFragPosition);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_ScrollSnapCenter.<>f__mg$cache27, true);
		LuaObject.createTypeMetatable(l, null, typeof(ScrollSnapCenter), typeof(MonoBehaviour));
	}

	// Token: 0x04016D23 RID: 93475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016D24 RID: 93476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016D25 RID: 93477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016D26 RID: 93478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016D27 RID: 93479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016D28 RID: 93480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016D29 RID: 93481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016D2A RID: 93482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016D2B RID: 93483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016D2C RID: 93484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016D2D RID: 93485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016D2E RID: 93486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016D2F RID: 93487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016D30 RID: 93488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016D31 RID: 93489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016D32 RID: 93490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016D33 RID: 93491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016D34 RID: 93492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016D35 RID: 93493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016D36 RID: 93494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016D37 RID: 93495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016D38 RID: 93496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016D39 RID: 93497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016D3A RID: 93498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016D3B RID: 93499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016D3C RID: 93500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016D3D RID: 93501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016D3E RID: 93502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016D3F RID: 93503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016D40 RID: 93504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016D41 RID: 93505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016D42 RID: 93506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016D43 RID: 93507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016D44 RID: 93508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016D45 RID: 93509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016D46 RID: 93510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016D47 RID: 93511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016D48 RID: 93512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016D49 RID: 93513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016D4A RID: 93514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
