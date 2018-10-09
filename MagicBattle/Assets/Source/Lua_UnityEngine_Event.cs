using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001696 RID: 5782
[Preserve]
public class Lua_UnityEngine_Event : LuaObject
{
	// Token: 0x060230AC RID: 143532 RVA: 0x00C22C48 File Offset: 0x00C20E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Event o = new Event();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int)))
			{
				int displayIndex;
				LuaObject.checkType(l, 2, out displayIndex);
				Event o = new Event(displayIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Event)))
			{
				Event other;
				LuaObject.checkType<Event>(l, 2, out other);
				Event o = new Event(other);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230AD RID: 143533 RVA: 0x00C22D2C File Offset: 0x00C20F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTypeForControl(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			int controlID;
			LuaObject.checkType(l, 2, out controlID);
			EventType typeForControl = @event.GetTypeForControl(controlID);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)typeForControl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230AE RID: 143534 RVA: 0x00C22D90 File Offset: 0x00C20F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Use(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			@event.Use();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230AF RID: 143535 RVA: 0x00C22DDC File Offset: 0x00C20FDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PopEvent_s(IntPtr l)
	{
		int result;
		try
		{
			Event outEvent;
			LuaObject.checkType<Event>(l, 1, out outEvent);
			bool b = Event.PopEvent(outEvent);
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

	// Token: 0x060230B0 RID: 143536 RVA: 0x00C22E30 File Offset: 0x00C21030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEventCount_s(IntPtr l)
	{
		int result;
		try
		{
			int eventCount = Event.GetEventCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230B1 RID: 143537 RVA: 0x00C22E78 File Offset: 0x00C21078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int KeyboardEvent_s(IntPtr l)
	{
		int result;
		try
		{
			string key;
			LuaObject.checkType(l, 1, out key);
			Event o = Event.KeyboardEvent(key);
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

	// Token: 0x060230B2 RID: 143538 RVA: 0x00C22ECC File Offset: 0x00C210CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rawType(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)@event.rawType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230B3 RID: 143539 RVA: 0x00C22F20 File Offset: 0x00C21120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_type(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)@event.type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230B4 RID: 143540 RVA: 0x00C22F74 File Offset: 0x00C21174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_type(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			EventType type;
			LuaObject.checkEnum<EventType>(l, 2, out type);
			@event.type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230B5 RID: 143541 RVA: 0x00C22FCC File Offset: 0x00C211CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_button(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230B6 RID: 143542 RVA: 0x00C23020 File Offset: 0x00C21220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_button(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			int button;
			LuaObject.checkType(l, 2, out button);
			@event.button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230B7 RID: 143543 RVA: 0x00C23078 File Offset: 0x00C21278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_modifiers(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)@event.modifiers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230B8 RID: 143544 RVA: 0x00C230CC File Offset: 0x00C212CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_modifiers(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			EventModifiers modifiers;
			LuaObject.checkEnum<EventModifiers>(l, 2, out modifiers);
			@event.modifiers = modifiers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230B9 RID: 143545 RVA: 0x00C23124 File Offset: 0x00C21324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pressure(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.pressure);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230BA RID: 143546 RVA: 0x00C23178 File Offset: 0x00C21378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pressure(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			float pressure;
			LuaObject.checkType(l, 2, out pressure);
			@event.pressure = pressure;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230BB RID: 143547 RVA: 0x00C231D0 File Offset: 0x00C213D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clickCount(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.clickCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230BC RID: 143548 RVA: 0x00C23224 File Offset: 0x00C21424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_clickCount(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			int clickCount;
			LuaObject.checkType(l, 2, out clickCount);
			@event.clickCount = clickCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230BD RID: 143549 RVA: 0x00C2327C File Offset: 0x00C2147C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_character(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.character);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230BE RID: 143550 RVA: 0x00C232D0 File Offset: 0x00C214D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_character(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			char character;
			LuaObject.checkType(l, 2, out character);
			@event.character = character;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230BF RID: 143551 RVA: 0x00C23328 File Offset: 0x00C21528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_commandName(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.commandName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230C0 RID: 143552 RVA: 0x00C2337C File Offset: 0x00C2157C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_commandName(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			string commandName;
			LuaObject.checkType(l, 2, out commandName);
			@event.commandName = commandName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230C1 RID: 143553 RVA: 0x00C233D4 File Offset: 0x00C215D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_keyCode(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)@event.keyCode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230C2 RID: 143554 RVA: 0x00C23428 File Offset: 0x00C21628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_keyCode(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			KeyCode keyCode;
			LuaObject.checkEnum<KeyCode>(l, 2, out keyCode);
			@event.keyCode = keyCode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230C3 RID: 143555 RVA: 0x00C23480 File Offset: 0x00C21680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_displayIndex(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.displayIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230C4 RID: 143556 RVA: 0x00C234D4 File Offset: 0x00C216D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_displayIndex(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			int displayIndex;
			LuaObject.checkType(l, 2, out displayIndex);
			@event.displayIndex = displayIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230C5 RID: 143557 RVA: 0x00C2352C File Offset: 0x00C2172C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mousePosition(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.mousePosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230C6 RID: 143558 RVA: 0x00C23580 File Offset: 0x00C21780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_mousePosition(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			Vector2 mousePosition;
			LuaObject.checkType(l, 2, out mousePosition);
			@event.mousePosition = mousePosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230C7 RID: 143559 RVA: 0x00C235D8 File Offset: 0x00C217D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_delta(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.delta);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230C8 RID: 143560 RVA: 0x00C2362C File Offset: 0x00C2182C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_delta(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			Vector2 delta;
			LuaObject.checkType(l, 2, out delta);
			@event.delta = delta;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230C9 RID: 143561 RVA: 0x00C23684 File Offset: 0x00C21884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_shift(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.shift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230CA RID: 143562 RVA: 0x00C236D8 File Offset: 0x00C218D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_shift(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			bool shift;
			LuaObject.checkType(l, 2, out shift);
			@event.shift = shift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230CB RID: 143563 RVA: 0x00C23730 File Offset: 0x00C21930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_control(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.control);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230CC RID: 143564 RVA: 0x00C23784 File Offset: 0x00C21984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_control(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			bool control;
			LuaObject.checkType(l, 2, out control);
			@event.control = control;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230CD RID: 143565 RVA: 0x00C237DC File Offset: 0x00C219DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alt(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.alt);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230CE RID: 143566 RVA: 0x00C23830 File Offset: 0x00C21A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alt(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			bool alt;
			LuaObject.checkType(l, 2, out alt);
			@event.alt = alt;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230CF RID: 143567 RVA: 0x00C23888 File Offset: 0x00C21A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_command(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.command);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230D0 RID: 143568 RVA: 0x00C238DC File Offset: 0x00C21ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_command(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			bool command;
			LuaObject.checkType(l, 2, out command);
			@event.command = command;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230D1 RID: 143569 RVA: 0x00C23934 File Offset: 0x00C21B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_capsLock(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.capsLock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230D2 RID: 143570 RVA: 0x00C23988 File Offset: 0x00C21B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_capsLock(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			bool capsLock;
			LuaObject.checkType(l, 2, out capsLock);
			@event.capsLock = capsLock;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230D3 RID: 143571 RVA: 0x00C239E0 File Offset: 0x00C21BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_numeric(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.numeric);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230D4 RID: 143572 RVA: 0x00C23A34 File Offset: 0x00C21C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_numeric(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			bool numeric;
			LuaObject.checkType(l, 2, out numeric);
			@event.numeric = numeric;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230D5 RID: 143573 RVA: 0x00C23A8C File Offset: 0x00C21C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_functionKey(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.functionKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230D6 RID: 143574 RVA: 0x00C23AE0 File Offset: 0x00C21CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_current(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Event.current);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230D7 RID: 143575 RVA: 0x00C23B28 File Offset: 0x00C21D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_current(IntPtr l)
	{
		int result;
		try
		{
			Event current;
			LuaObject.checkType<Event>(l, 2, out current);
			Event.current = current;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230D8 RID: 143576 RVA: 0x00C23B74 File Offset: 0x00C21D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isKey(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.isKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230D9 RID: 143577 RVA: 0x00C23BC8 File Offset: 0x00C21DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isMouse(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.isMouse);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230DA RID: 143578 RVA: 0x00C23C1C File Offset: 0x00C21E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isScrollWheel(IntPtr l)
	{
		int result;
		try
		{
			Event @event = (Event)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, @event.isScrollWheel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230DB RID: 143579 RVA: 0x00C23C70 File Offset: 0x00C21E70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Event");
		if (Lua_UnityEngine_Event.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Event.GetTypeForControl);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Event.<>f__mg$cache0);
		if (Lua_UnityEngine_Event.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Event.Use);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Event.<>f__mg$cache1);
		if (Lua_UnityEngine_Event.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Event.PopEvent_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Event.<>f__mg$cache2);
		if (Lua_UnityEngine_Event.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Event.GetEventCount_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Event.<>f__mg$cache3);
		if (Lua_UnityEngine_Event.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Event.KeyboardEvent_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Event.<>f__mg$cache4);
		string name = "rawType";
		if (Lua_UnityEngine_Event.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Event.get_rawType);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Event.<>f__mg$cache5, null, true);
		string name2 = "type";
		if (Lua_UnityEngine_Event.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Event.get_type);
		}
		LuaCSFunction get = Lua_UnityEngine_Event.<>f__mg$cache6;
		if (Lua_UnityEngine_Event.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Event.set_type);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_Event.<>f__mg$cache7, true);
		string name3 = "button";
		if (Lua_UnityEngine_Event.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Event.get_button);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Event.<>f__mg$cache8;
		if (Lua_UnityEngine_Event.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Event.set_button);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_Event.<>f__mg$cache9, true);
		string name4 = "modifiers";
		if (Lua_UnityEngine_Event.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Event.get_modifiers);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Event.<>f__mg$cacheA;
		if (Lua_UnityEngine_Event.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Event.set_modifiers);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_Event.<>f__mg$cacheB, true);
		string name5 = "pressure";
		if (Lua_UnityEngine_Event.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Event.get_pressure);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Event.<>f__mg$cacheC;
		if (Lua_UnityEngine_Event.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Event.set_pressure);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_Event.<>f__mg$cacheD, true);
		string name6 = "clickCount";
		if (Lua_UnityEngine_Event.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Event.get_clickCount);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Event.<>f__mg$cacheE;
		if (Lua_UnityEngine_Event.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Event.set_clickCount);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_Event.<>f__mg$cacheF, true);
		string name7 = "character";
		if (Lua_UnityEngine_Event.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Event.get_character);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Event.<>f__mg$cache10;
		if (Lua_UnityEngine_Event.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Event.set_character);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_Event.<>f__mg$cache11, true);
		string name8 = "commandName";
		if (Lua_UnityEngine_Event.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Event.get_commandName);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Event.<>f__mg$cache12;
		if (Lua_UnityEngine_Event.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Event.set_commandName);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_Event.<>f__mg$cache13, true);
		string name9 = "keyCode";
		if (Lua_UnityEngine_Event.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Event.get_keyCode);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Event.<>f__mg$cache14;
		if (Lua_UnityEngine_Event.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Event.set_keyCode);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_Event.<>f__mg$cache15, true);
		string name10 = "displayIndex";
		if (Lua_UnityEngine_Event.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Event.get_displayIndex);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Event.<>f__mg$cache16;
		if (Lua_UnityEngine_Event.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Event.set_displayIndex);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_Event.<>f__mg$cache17, true);
		string name11 = "mousePosition";
		if (Lua_UnityEngine_Event.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Event.get_mousePosition);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Event.<>f__mg$cache18;
		if (Lua_UnityEngine_Event.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Event.set_mousePosition);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_Event.<>f__mg$cache19, true);
		string name12 = "delta";
		if (Lua_UnityEngine_Event.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Event.get_delta);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Event.<>f__mg$cache1A;
		if (Lua_UnityEngine_Event.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Event.set_delta);
		}
		LuaObject.addMember(l, name12, get11, Lua_UnityEngine_Event.<>f__mg$cache1B, true);
		string name13 = "shift";
		if (Lua_UnityEngine_Event.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Event.get_shift);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Event.<>f__mg$cache1C;
		if (Lua_UnityEngine_Event.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Event.set_shift);
		}
		LuaObject.addMember(l, name13, get12, Lua_UnityEngine_Event.<>f__mg$cache1D, true);
		string name14 = "control";
		if (Lua_UnityEngine_Event.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Event.get_control);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Event.<>f__mg$cache1E;
		if (Lua_UnityEngine_Event.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Event.set_control);
		}
		LuaObject.addMember(l, name14, get13, Lua_UnityEngine_Event.<>f__mg$cache1F, true);
		string name15 = "alt";
		if (Lua_UnityEngine_Event.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Event.get_alt);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Event.<>f__mg$cache20;
		if (Lua_UnityEngine_Event.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Event.set_alt);
		}
		LuaObject.addMember(l, name15, get14, Lua_UnityEngine_Event.<>f__mg$cache21, true);
		string name16 = "command";
		if (Lua_UnityEngine_Event.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Event.get_command);
		}
		LuaCSFunction get15 = Lua_UnityEngine_Event.<>f__mg$cache22;
		if (Lua_UnityEngine_Event.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Event.set_command);
		}
		LuaObject.addMember(l, name16, get15, Lua_UnityEngine_Event.<>f__mg$cache23, true);
		string name17 = "capsLock";
		if (Lua_UnityEngine_Event.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Event.get_capsLock);
		}
		LuaCSFunction get16 = Lua_UnityEngine_Event.<>f__mg$cache24;
		if (Lua_UnityEngine_Event.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Event.set_capsLock);
		}
		LuaObject.addMember(l, name17, get16, Lua_UnityEngine_Event.<>f__mg$cache25, true);
		string name18 = "numeric";
		if (Lua_UnityEngine_Event.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Event.get_numeric);
		}
		LuaCSFunction get17 = Lua_UnityEngine_Event.<>f__mg$cache26;
		if (Lua_UnityEngine_Event.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Event.set_numeric);
		}
		LuaObject.addMember(l, name18, get17, Lua_UnityEngine_Event.<>f__mg$cache27, true);
		string name19 = "functionKey";
		if (Lua_UnityEngine_Event.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Event.get_functionKey);
		}
		LuaObject.addMember(l, name19, Lua_UnityEngine_Event.<>f__mg$cache28, null, true);
		string name20 = "current";
		if (Lua_UnityEngine_Event.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Event.get_current);
		}
		LuaCSFunction get18 = Lua_UnityEngine_Event.<>f__mg$cache29;
		if (Lua_UnityEngine_Event.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Event.set_current);
		}
		LuaObject.addMember(l, name20, get18, Lua_UnityEngine_Event.<>f__mg$cache2A, false);
		string name21 = "isKey";
		if (Lua_UnityEngine_Event.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Event.get_isKey);
		}
		LuaObject.addMember(l, name21, Lua_UnityEngine_Event.<>f__mg$cache2B, null, true);
		string name22 = "isMouse";
		if (Lua_UnityEngine_Event.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Event.get_isMouse);
		}
		LuaObject.addMember(l, name22, Lua_UnityEngine_Event.<>f__mg$cache2C, null, true);
		string name23 = "isScrollWheel";
		if (Lua_UnityEngine_Event.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Event.get_isScrollWheel);
		}
		LuaObject.addMember(l, name23, Lua_UnityEngine_Event.<>f__mg$cache2D, null, true);
		if (Lua_UnityEngine_Event.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Event.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Event.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Event.<>f__mg$cache2E, typeof(Event));
	}

	// Token: 0x04018FDE RID: 102366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018FDF RID: 102367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018FE0 RID: 102368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018FE1 RID: 102369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018FE2 RID: 102370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018FE3 RID: 102371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018FE4 RID: 102372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018FE5 RID: 102373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018FE6 RID: 102374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018FE7 RID: 102375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018FE8 RID: 102376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018FE9 RID: 102377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018FEA RID: 102378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018FEB RID: 102379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018FEC RID: 102380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018FED RID: 102381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018FEE RID: 102382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018FEF RID: 102383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018FF0 RID: 102384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018FF1 RID: 102385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018FF2 RID: 102386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018FF3 RID: 102387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018FF4 RID: 102388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018FF5 RID: 102389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018FF6 RID: 102390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018FF7 RID: 102391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018FF8 RID: 102392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018FF9 RID: 102393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018FFA RID: 102394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018FFB RID: 102395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018FFC RID: 102396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018FFD RID: 102397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018FFE RID: 102398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018FFF RID: 102399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04019000 RID: 102400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04019001 RID: 102401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019002 RID: 102402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019003 RID: 102403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019004 RID: 102404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019005 RID: 102405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019006 RID: 102406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019007 RID: 102407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019008 RID: 102408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019009 RID: 102409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401900A RID: 102410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401900B RID: 102411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401900C RID: 102412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
