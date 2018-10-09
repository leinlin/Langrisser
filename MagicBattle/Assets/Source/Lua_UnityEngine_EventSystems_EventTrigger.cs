using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016A3 RID: 5795
[Preserve]
public class Lua_UnityEngine_EventSystems_EventTrigger : LuaObject
{
	// Token: 0x06023137 RID: 143671 RVA: 0x00C266A8 File Offset: 0x00C248A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerEnter(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			eventTrigger.OnPointerEnter(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023138 RID: 143672 RVA: 0x00C26700 File Offset: 0x00C24900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerExit(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			eventTrigger.OnPointerExit(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023139 RID: 143673 RVA: 0x00C26758 File Offset: 0x00C24958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			eventTrigger.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602313A RID: 143674 RVA: 0x00C267B0 File Offset: 0x00C249B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrop(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			eventTrigger.OnDrop(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602313B RID: 143675 RVA: 0x00C26808 File Offset: 0x00C24A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			eventTrigger.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602313C RID: 143676 RVA: 0x00C26860 File Offset: 0x00C24A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			eventTrigger.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602313D RID: 143677 RVA: 0x00C268B8 File Offset: 0x00C24AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			eventTrigger.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602313E RID: 143678 RVA: 0x00C26910 File Offset: 0x00C24B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelect(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			eventTrigger.OnSelect(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602313F RID: 143679 RVA: 0x00C26968 File Offset: 0x00C24B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDeselect(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			eventTrigger.OnDeselect(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023140 RID: 143680 RVA: 0x00C269C0 File Offset: 0x00C24BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScroll(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			eventTrigger.OnScroll(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023141 RID: 143681 RVA: 0x00C26A18 File Offset: 0x00C24C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMove(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			AxisEventData eventData;
			LuaObject.checkType<AxisEventData>(l, 2, out eventData);
			eventTrigger.OnMove(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023142 RID: 143682 RVA: 0x00C26A70 File Offset: 0x00C24C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUpdateSelected(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			eventTrigger.OnUpdateSelected(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023143 RID: 143683 RVA: 0x00C26AC8 File Offset: 0x00C24CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInitializePotentialDrag(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			eventTrigger.OnInitializePotentialDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023144 RID: 143684 RVA: 0x00C26B20 File Offset: 0x00C24D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			eventTrigger.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023145 RID: 143685 RVA: 0x00C26B78 File Offset: 0x00C24D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			eventTrigger.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023146 RID: 143686 RVA: 0x00C26BD0 File Offset: 0x00C24DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubmit(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			eventTrigger.OnSubmit(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023147 RID: 143687 RVA: 0x00C26C28 File Offset: 0x00C24E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancel(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			eventTrigger.OnCancel(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023148 RID: 143688 RVA: 0x00C26C80 File Offset: 0x00C24E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_triggers(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventTrigger.triggers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023149 RID: 143689 RVA: 0x00C26CD4 File Offset: 0x00C24ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_triggers(IntPtr l)
	{
		int result;
		try
		{
			EventTrigger eventTrigger = (EventTrigger)LuaObject.checkSelf(l);
			List<EventTrigger.Entry> triggers;
			LuaObject.checkType<List<EventTrigger.Entry>>(l, 2, out triggers);
			eventTrigger.triggers = triggers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602314A RID: 143690 RVA: 0x00C26D2C File Offset: 0x00C24F2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.EventTrigger");
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnPointerEnter);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache0);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnPointerExit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache1);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache2);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnDrop);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache3);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache4);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache5);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache6);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnSelect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache7);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnDeselect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache8);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnScroll);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache9);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnMove);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheA);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnUpdateSelected);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheB);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnInitializePotentialDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheC);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheD);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheE);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnSubmit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cacheF);
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.OnCancel);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache10);
		string name = "triggers";
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.get_triggers);
		}
		LuaCSFunction get = Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache11;
		if (Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventTrigger.set_triggers);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_EventSystems_EventTrigger.<>f__mg$cache12, true);
		LuaObject.createTypeMetatable(l, null, typeof(EventTrigger), typeof(MonoBehaviour));
	}

	// Token: 0x0401904F RID: 102479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019050 RID: 102480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019051 RID: 102481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019052 RID: 102482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019053 RID: 102483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019054 RID: 102484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019055 RID: 102485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019056 RID: 102486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019057 RID: 102487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019058 RID: 102488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019059 RID: 102489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401905A RID: 102490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401905B RID: 102491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401905C RID: 102492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401905D RID: 102493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401905E RID: 102494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401905F RID: 102495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019060 RID: 102496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019061 RID: 102497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
