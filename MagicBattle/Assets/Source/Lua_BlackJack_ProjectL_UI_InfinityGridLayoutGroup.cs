using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014EE RID: 5358
[Preserve]
public class Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup : LuaObject
{
	// Token: 0x0601F9EE RID: 129518 RVA: 0x00A66E0C File Offset: 0x00A6500C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAmount(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			int amount;
			LuaObject.checkType(l, 2, out amount);
			infinityGridLayoutGroup.SetAmount(amount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9EF RID: 129519 RVA: 0x00A66E64 File Offset: 0x00A65064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			infinityGridLayoutGroup.m_luaExportHelper.Start();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9F0 RID: 129520 RVA: 0x00A66EB8 File Offset: 0x00A650B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitChildren(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			IEnumerator o = infinityGridLayoutGroup.m_luaExportHelper.InitChildren();
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

	// Token: 0x0601F9F1 RID: 129521 RVA: 0x00A66F14 File Offset: 0x00A65114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScrollCallback(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			Vector2 data;
			LuaObject.checkType(l, 2, out data);
			infinityGridLayoutGroup.m_luaExportHelper.ScrollCallback(data);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9F2 RID: 129522 RVA: 0x00A66F70 File Offset: 0x00A65170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateChildren(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			infinityGridLayoutGroup.m_luaExportHelper.UpdateChildren();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9F3 RID: 129523 RVA: 0x00A66FC4 File Offset: 0x00A651C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateChildrenCallback(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Transform trans;
			LuaObject.checkType<Transform>(l, 3, out trans);
			infinityGridLayoutGroup.m_luaExportHelper.UpdateChildrenCallback(index, trans);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9F4 RID: 129524 RVA: 0x00A67030 File Offset: 0x00A65230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_minAmount(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.m_minAmount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9F5 RID: 129525 RVA: 0x00A67088 File Offset: 0x00A65288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_minAmount(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			int minAmount;
			LuaObject.checkType(l, 2, out minAmount);
			infinityGridLayoutGroup.m_luaExportHelper.m_minAmount = minAmount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9F6 RID: 129526 RVA: 0x00A670E4 File Offset: 0x00A652E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_amount(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.amount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9F7 RID: 129527 RVA: 0x00A6713C File Offset: 0x00A6533C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_amount(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			int amount;
			LuaObject.checkType(l, 2, out amount);
			infinityGridLayoutGroup.m_luaExportHelper.amount = amount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9F8 RID: 129528 RVA: 0x00A67198 File Offset: 0x00A65398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rectTransform(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.rectTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9F9 RID: 129529 RVA: 0x00A671F0 File Offset: 0x00A653F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rectTransform(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			RectTransform rectTransform;
			LuaObject.checkType<RectTransform>(l, 2, out rectTransform);
			infinityGridLayoutGroup.m_luaExportHelper.rectTransform = rectTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9FA RID: 129530 RVA: 0x00A6724C File Offset: 0x00A6544C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gridLayoutGroup(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.gridLayoutGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9FB RID: 129531 RVA: 0x00A672A4 File Offset: 0x00A654A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_gridLayoutGroup(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			GridLayoutGroup gridLayoutGroup;
			LuaObject.checkType<GridLayoutGroup>(l, 2, out gridLayoutGroup);
			infinityGridLayoutGroup.m_luaExportHelper.gridLayoutGroup = gridLayoutGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9FC RID: 129532 RVA: 0x00A67300 File Offset: 0x00A65500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_contentSizeFitter(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.contentSizeFitter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9FD RID: 129533 RVA: 0x00A67358 File Offset: 0x00A65558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_contentSizeFitter(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			ContentSizeFitter contentSizeFitter;
			LuaObject.checkType<ContentSizeFitter>(l, 2, out contentSizeFitter);
			infinityGridLayoutGroup.m_luaExportHelper.contentSizeFitter = contentSizeFitter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9FE RID: 129534 RVA: 0x00A673B4 File Offset: 0x00A655B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_scrollRect(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.scrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F9FF RID: 129535 RVA: 0x00A6740C File Offset: 0x00A6560C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_scrollRect(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			ScrollRect scrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out scrollRect);
			infinityGridLayoutGroup.m_luaExportHelper.scrollRect = scrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA00 RID: 129536 RVA: 0x00A67468 File Offset: 0x00A65668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_children(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.children);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA01 RID: 129537 RVA: 0x00A674C0 File Offset: 0x00A656C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_children(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			List<RectTransform> children;
			LuaObject.checkType<List<RectTransform>>(l, 2, out children);
			infinityGridLayoutGroup.m_luaExportHelper.children = children;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA02 RID: 129538 RVA: 0x00A6751C File Offset: 0x00A6571C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_startPosition(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.startPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA03 RID: 129539 RVA: 0x00A67574 File Offset: 0x00A65774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_startPosition(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			Vector2 startPosition;
			LuaObject.checkType(l, 2, out startPosition);
			infinityGridLayoutGroup.m_luaExportHelper.startPosition = startPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA04 RID: 129540 RVA: 0x00A675D0 File Offset: 0x00A657D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_updateChildrenCallback(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate updateChildrenCallbackDelegate;
			int num = LuaObject.checkDelegate<InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate>(l, 2, out updateChildrenCallbackDelegate);
			if (num == 0)
			{
				infinityGridLayoutGroup.updateChildrenCallback = updateChildrenCallbackDelegate;
			}
			else if (num == 1)
			{
				InfinityGridLayoutGroup infinityGridLayoutGroup2 = infinityGridLayoutGroup;
				infinityGridLayoutGroup2.updateChildrenCallback = (InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate)Delegate.Combine(infinityGridLayoutGroup2.updateChildrenCallback, updateChildrenCallbackDelegate);
			}
			else if (num == 2)
			{
				InfinityGridLayoutGroup infinityGridLayoutGroup3 = infinityGridLayoutGroup;
				infinityGridLayoutGroup3.updateChildrenCallback = (InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate)Delegate.Remove(infinityGridLayoutGroup3.updateChildrenCallback, updateChildrenCallbackDelegate);
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

	// Token: 0x0601FA05 RID: 129541 RVA: 0x00A67678 File Offset: 0x00A65878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_realIndex(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.realIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA06 RID: 129542 RVA: 0x00A676D0 File Offset: 0x00A658D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_realIndex(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			int realIndex;
			LuaObject.checkType(l, 2, out realIndex);
			infinityGridLayoutGroup.m_luaExportHelper.realIndex = realIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA07 RID: 129543 RVA: 0x00A6772C File Offset: 0x00A6592C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_realIndexUp(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.realIndexUp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA08 RID: 129544 RVA: 0x00A67784 File Offset: 0x00A65984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_realIndexUp(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			int realIndexUp;
			LuaObject.checkType(l, 2, out realIndexUp);
			infinityGridLayoutGroup.m_luaExportHelper.realIndexUp = realIndexUp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA09 RID: 129545 RVA: 0x00A677E0 File Offset: 0x00A659E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasInit(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.hasInit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA0A RID: 129546 RVA: 0x00A67838 File Offset: 0x00A65A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_hasInit(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			bool hasInit;
			LuaObject.checkType(l, 2, out hasInit);
			infinityGridLayoutGroup.m_luaExportHelper.hasInit = hasInit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA0B RID: 129547 RVA: 0x00A67894 File Offset: 0x00A65A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gridLayoutSize(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.gridLayoutSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA0C RID: 129548 RVA: 0x00A678EC File Offset: 0x00A65AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_gridLayoutSize(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			Vector2 gridLayoutSize;
			LuaObject.checkType(l, 2, out gridLayoutSize);
			infinityGridLayoutGroup.m_luaExportHelper.gridLayoutSize = gridLayoutSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA0D RID: 129549 RVA: 0x00A67948 File Offset: 0x00A65B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gridLayoutPos(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.gridLayoutPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA0E RID: 129550 RVA: 0x00A679A0 File Offset: 0x00A65BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_gridLayoutPos(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			Vector2 gridLayoutPos;
			LuaObject.checkType(l, 2, out gridLayoutPos);
			infinityGridLayoutGroup.m_luaExportHelper.gridLayoutPos = gridLayoutPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA0F RID: 129551 RVA: 0x00A679FC File Offset: 0x00A65BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_childsAnchoredPosition(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.childsAnchoredPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA10 RID: 129552 RVA: 0x00A67A54 File Offset: 0x00A65C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_childsAnchoredPosition(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			Dictionary<Transform, Vector2> childsAnchoredPosition;
			LuaObject.checkType<Dictionary<Transform, Vector2>>(l, 2, out childsAnchoredPosition);
			infinityGridLayoutGroup.m_luaExportHelper.childsAnchoredPosition = childsAnchoredPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA11 RID: 129553 RVA: 0x00A67AB0 File Offset: 0x00A65CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_childsSiblingIndex(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.m_luaExportHelper.childsSiblingIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA12 RID: 129554 RVA: 0x00A67B08 File Offset: 0x00A65D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_childsSiblingIndex(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			Dictionary<Transform, int> childsSiblingIndex;
			LuaObject.checkType<Dictionary<Transform, int>>(l, 2, out childsSiblingIndex);
			infinityGridLayoutGroup.m_luaExportHelper.childsSiblingIndex = childsSiblingIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA13 RID: 129555 RVA: 0x00A67B64 File Offset: 0x00A65D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MinAmount(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, infinityGridLayoutGroup.MinAmount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA14 RID: 129556 RVA: 0x00A67BB8 File Offset: 0x00A65DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MinAmount(IntPtr l)
	{
		int result;
		try
		{
			InfinityGridLayoutGroup infinityGridLayoutGroup = (InfinityGridLayoutGroup)LuaObject.checkSelf(l);
			int minAmount;
			LuaObject.checkType(l, 2, out minAmount);
			infinityGridLayoutGroup.MinAmount = minAmount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FA15 RID: 129557 RVA: 0x00A67C10 File Offset: 0x00A65E10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.InfinityGridLayoutGroup");
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.SetAmount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.Start);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.InitChildren);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.ScrollCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.UpdateChildren);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.UpdateChildrenCallback);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache5);
		string name = "m_minAmount";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_m_minAmount);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_m_minAmount);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache7, true);
		string name2 = "amount";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_amount);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_amount);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache9, true);
		string name3 = "rectTransform";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_rectTransform);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_rectTransform);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheB, true);
		string name4 = "gridLayoutGroup";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_gridLayoutGroup);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_gridLayoutGroup);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheD, true);
		string name5 = "contentSizeFitter";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_contentSizeFitter);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_contentSizeFitter);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cacheF, true);
		string name6 = "scrollRect";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_scrollRect);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_scrollRect);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache11, true);
		string name7 = "children";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_children);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_children);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache13, true);
		string name8 = "startPosition";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_startPosition);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_startPosition);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache15, true);
		string name9 = "updateChildrenCallback";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_updateChildrenCallback);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache16, true);
		string name10 = "realIndex";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_realIndex);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_realIndex);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache18, true);
		string name11 = "realIndexUp";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_realIndexUp);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_realIndexUp);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1A, true);
		string name12 = "hasInit";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_hasInit);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_hasInit);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1C, true);
		string name13 = "gridLayoutSize";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_gridLayoutSize);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_gridLayoutSize);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1E, true);
		string name14 = "gridLayoutPos";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_gridLayoutPos);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_gridLayoutPos);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache20, true);
		string name15 = "childsAnchoredPosition";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_childsAnchoredPosition);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_childsAnchoredPosition);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache22, true);
		string name16 = "childsSiblingIndex";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_childsSiblingIndex);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_childsSiblingIndex);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache24, true);
		string name17 = "MinAmount";
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.get_MinAmount);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.set_MinAmount);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_InfinityGridLayoutGroup.<>f__mg$cache26, true);
		LuaObject.createTypeMetatable(l, null, typeof(InfinityGridLayoutGroup), typeof(MonoBehaviour));
	}

	// Token: 0x040159F4 RID: 88564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040159F5 RID: 88565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040159F6 RID: 88566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040159F7 RID: 88567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040159F8 RID: 88568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040159F9 RID: 88569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040159FA RID: 88570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040159FB RID: 88571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040159FC RID: 88572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040159FD RID: 88573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040159FE RID: 88574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040159FF RID: 88575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015A00 RID: 88576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015A01 RID: 88577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015A02 RID: 88578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015A03 RID: 88579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015A04 RID: 88580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015A05 RID: 88581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015A06 RID: 88582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015A07 RID: 88583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015A08 RID: 88584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015A09 RID: 88585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015A0A RID: 88586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015A0B RID: 88587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015A0C RID: 88588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015A0D RID: 88589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015A0E RID: 88590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015A0F RID: 88591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015A10 RID: 88592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015A11 RID: 88593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015A12 RID: 88594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015A13 RID: 88595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015A14 RID: 88596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015A15 RID: 88597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015A16 RID: 88598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015A17 RID: 88599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015A18 RID: 88600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015A19 RID: 88601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015A1A RID: 88602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;
}
