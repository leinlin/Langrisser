using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016F3 RID: 5875
[Preserve]
public class Lua_UnityEngine_Input : LuaObject
{
	// Token: 0x060233A0 RID: 144288 RVA: 0x00C396E8 File Offset: 0x00C378E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Input o = new Input();
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

	// Token: 0x060233A1 RID: 144289 RVA: 0x00C39730 File Offset: 0x00C37930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAxis_s(IntPtr l)
	{
		int result;
		try
		{
			string axisName;
			LuaObject.checkType(l, 1, out axisName);
			float axis = Input.GetAxis(axisName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, axis);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233A2 RID: 144290 RVA: 0x00C39784 File Offset: 0x00C37984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAxisRaw_s(IntPtr l)
	{
		int result;
		try
		{
			string axisName;
			LuaObject.checkType(l, 1, out axisName);
			float axisRaw = Input.GetAxisRaw(axisName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, axisRaw);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233A3 RID: 144291 RVA: 0x00C397D8 File Offset: 0x00C379D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetButton_s(IntPtr l)
	{
		int result;
		try
		{
			string buttonName;
			LuaObject.checkType(l, 1, out buttonName);
			bool button = Input.GetButton(buttonName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233A4 RID: 144292 RVA: 0x00C3982C File Offset: 0x00C37A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetButtonDown_s(IntPtr l)
	{
		int result;
		try
		{
			string buttonName;
			LuaObject.checkType(l, 1, out buttonName);
			bool buttonDown = Input.GetButtonDown(buttonName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buttonDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233A5 RID: 144293 RVA: 0x00C39880 File Offset: 0x00C37A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetButtonUp_s(IntPtr l)
	{
		int result;
		try
		{
			string buttonName;
			LuaObject.checkType(l, 1, out buttonName);
			bool buttonUp = Input.GetButtonUp(buttonName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buttonUp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233A6 RID: 144294 RVA: 0x00C398D4 File Offset: 0x00C37AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetKey_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				bool key = Input.GetKey(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, key);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(KeyCode)))
			{
				KeyCode key2;
				LuaObject.checkEnum<KeyCode>(l, 1, out key2);
				bool key3 = Input.GetKey(key2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, key3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetKey to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233A7 RID: 144295 RVA: 0x00C399A0 File Offset: 0x00C37BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetKeyDown_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				bool keyDown = Input.GetKeyDown(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, keyDown);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(KeyCode)))
			{
				KeyCode key;
				LuaObject.checkEnum<KeyCode>(l, 1, out key);
				bool keyDown2 = Input.GetKeyDown(key);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, keyDown2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetKeyDown to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233A8 RID: 144296 RVA: 0x00C39A6C File Offset: 0x00C37C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetKeyUp_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 1, out name);
				bool keyUp = Input.GetKeyUp(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, keyUp);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(KeyCode)))
			{
				KeyCode key;
				LuaObject.checkEnum<KeyCode>(l, 1, out key);
				bool keyUp2 = Input.GetKeyUp(key);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, keyUp2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetKeyUp to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233A9 RID: 144297 RVA: 0x00C39B38 File Offset: 0x00C37D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetJoystickNames_s(IntPtr l)
	{
		int result;
		try
		{
			string[] joystickNames = Input.GetJoystickNames();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joystickNames);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233AA RID: 144298 RVA: 0x00C39B80 File Offset: 0x00C37D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMouseButton_s(IntPtr l)
	{
		int result;
		try
		{
			int button;
			LuaObject.checkType(l, 1, out button);
			bool mouseButton = Input.GetMouseButton(button);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mouseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233AB RID: 144299 RVA: 0x00C39BD4 File Offset: 0x00C37DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMouseButtonDown_s(IntPtr l)
	{
		int result;
		try
		{
			int button;
			LuaObject.checkType(l, 1, out button);
			bool mouseButtonDown = Input.GetMouseButtonDown(button);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mouseButtonDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233AC RID: 144300 RVA: 0x00C39C28 File Offset: 0x00C37E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMouseButtonUp_s(IntPtr l)
	{
		int result;
		try
		{
			int button;
			LuaObject.checkType(l, 1, out button);
			bool mouseButtonUp = Input.GetMouseButtonUp(button);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mouseButtonUp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233AD RID: 144301 RVA: 0x00C39C7C File Offset: 0x00C37E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetInputAxes_s(IntPtr l)
	{
		int result;
		try
		{
			Input.ResetInputAxes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233AE RID: 144302 RVA: 0x00C39CBC File Offset: 0x00C37EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAccelerationEvent_s(IntPtr l)
	{
		int result;
		try
		{
			int index;
			LuaObject.checkType(l, 1, out index);
			AccelerationEvent accelerationEvent = Input.GetAccelerationEvent(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, accelerationEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233AF RID: 144303 RVA: 0x00C39D14 File Offset: 0x00C37F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTouch_s(IntPtr l)
	{
		int result;
		try
		{
			int index;
			LuaObject.checkType(l, 1, out index);
			Touch touch = Input.GetTouch(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233B0 RID: 144304 RVA: 0x00C39D6C File Offset: 0x00C37F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_compensateSensors(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.compensateSensors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233B1 RID: 144305 RVA: 0x00C39DB4 File Offset: 0x00C37FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_compensateSensors(IntPtr l)
	{
		int result;
		try
		{
			bool compensateSensors;
			LuaObject.checkType(l, 2, out compensateSensors);
			Input.compensateSensors = compensateSensors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233B2 RID: 144306 RVA: 0x00C39E00 File Offset: 0x00C38000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gyro(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.gyro);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233B3 RID: 144307 RVA: 0x00C39E48 File Offset: 0x00C38048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mousePosition(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.mousePosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233B4 RID: 144308 RVA: 0x00C39E90 File Offset: 0x00C38090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mouseScrollDelta(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.mouseScrollDelta);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233B5 RID: 144309 RVA: 0x00C39ED8 File Offset: 0x00C380D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mousePresent(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.mousePresent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233B6 RID: 144310 RVA: 0x00C39F20 File Offset: 0x00C38120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_simulateMouseWithTouches(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.simulateMouseWithTouches);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233B7 RID: 144311 RVA: 0x00C39F68 File Offset: 0x00C38168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_simulateMouseWithTouches(IntPtr l)
	{
		int result;
		try
		{
			bool simulateMouseWithTouches;
			LuaObject.checkType(l, 2, out simulateMouseWithTouches);
			Input.simulateMouseWithTouches = simulateMouseWithTouches;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233B8 RID: 144312 RVA: 0x00C39FB4 File Offset: 0x00C381B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_anyKey(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.anyKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233B9 RID: 144313 RVA: 0x00C39FFC File Offset: 0x00C381FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_anyKeyDown(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.anyKeyDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233BA RID: 144314 RVA: 0x00C3A044 File Offset: 0x00C38244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inputString(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.inputString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233BB RID: 144315 RVA: 0x00C3A08C File Offset: 0x00C3828C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_acceleration(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.acceleration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233BC RID: 144316 RVA: 0x00C3A0D4 File Offset: 0x00C382D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_accelerationEvents(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.accelerationEvents);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233BD RID: 144317 RVA: 0x00C3A11C File Offset: 0x00C3831C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_accelerationEventCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.accelerationEventCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233BE RID: 144318 RVA: 0x00C3A164 File Offset: 0x00C38364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_touches(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.touches);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233BF RID: 144319 RVA: 0x00C3A1AC File Offset: 0x00C383AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_touchCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.touchCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233C0 RID: 144320 RVA: 0x00C3A1F4 File Offset: 0x00C383F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_touchPressureSupported(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.touchPressureSupported);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233C1 RID: 144321 RVA: 0x00C3A23C File Offset: 0x00C3843C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_stylusTouchSupported(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.stylusTouchSupported);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233C2 RID: 144322 RVA: 0x00C3A284 File Offset: 0x00C38484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_touchSupported(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.touchSupported);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233C3 RID: 144323 RVA: 0x00C3A2CC File Offset: 0x00C384CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_multiTouchEnabled(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.multiTouchEnabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233C4 RID: 144324 RVA: 0x00C3A314 File Offset: 0x00C38514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_multiTouchEnabled(IntPtr l)
	{
		int result;
		try
		{
			bool multiTouchEnabled;
			LuaObject.checkType(l, 2, out multiTouchEnabled);
			Input.multiTouchEnabled = multiTouchEnabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233C5 RID: 144325 RVA: 0x00C3A360 File Offset: 0x00C38560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_location(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.location);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233C6 RID: 144326 RVA: 0x00C3A3A8 File Offset: 0x00C385A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_compass(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.compass);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233C7 RID: 144327 RVA: 0x00C3A3F0 File Offset: 0x00C385F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deviceOrientation(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Input.deviceOrientation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233C8 RID: 144328 RVA: 0x00C3A438 File Offset: 0x00C38638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_imeCompositionMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Input.imeCompositionMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233C9 RID: 144329 RVA: 0x00C3A480 File Offset: 0x00C38680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_imeCompositionMode(IntPtr l)
	{
		int result;
		try
		{
			IMECompositionMode imeCompositionMode;
			LuaObject.checkEnum<IMECompositionMode>(l, 2, out imeCompositionMode);
			Input.imeCompositionMode = imeCompositionMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233CA RID: 144330 RVA: 0x00C3A4CC File Offset: 0x00C386CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_compositionString(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.compositionString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233CB RID: 144331 RVA: 0x00C3A514 File Offset: 0x00C38714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_imeIsSelected(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.imeIsSelected);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233CC RID: 144332 RVA: 0x00C3A55C File Offset: 0x00C3875C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_compositionCursorPos(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.compositionCursorPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233CD RID: 144333 RVA: 0x00C3A5A4 File Offset: 0x00C387A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_compositionCursorPos(IntPtr l)
	{
		int result;
		try
		{
			Vector2 compositionCursorPos;
			LuaObject.checkType(l, 2, out compositionCursorPos);
			Input.compositionCursorPos = compositionCursorPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233CE RID: 144334 RVA: 0x00C3A5F0 File Offset: 0x00C387F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_backButtonLeavesApp(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Input.backButtonLeavesApp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233CF RID: 144335 RVA: 0x00C3A638 File Offset: 0x00C38838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_backButtonLeavesApp(IntPtr l)
	{
		int result;
		try
		{
			bool backButtonLeavesApp;
			LuaObject.checkType(l, 2, out backButtonLeavesApp);
			Input.backButtonLeavesApp = backButtonLeavesApp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233D0 RID: 144336 RVA: 0x00C3A684 File Offset: 0x00C38884
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Input");
		if (Lua_UnityEngine_Input.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Input.GetAxis_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cache0);
		if (Lua_UnityEngine_Input.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Input.GetAxisRaw_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cache1);
		if (Lua_UnityEngine_Input.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Input.GetButton_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cache2);
		if (Lua_UnityEngine_Input.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Input.GetButtonDown_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cache3);
		if (Lua_UnityEngine_Input.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Input.GetButtonUp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cache4);
		if (Lua_UnityEngine_Input.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Input.GetKey_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cache5);
		if (Lua_UnityEngine_Input.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Input.GetKeyDown_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cache6);
		if (Lua_UnityEngine_Input.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Input.GetKeyUp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cache7);
		if (Lua_UnityEngine_Input.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Input.GetJoystickNames_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cache8);
		if (Lua_UnityEngine_Input.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Input.GetMouseButton_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cache9);
		if (Lua_UnityEngine_Input.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Input.GetMouseButtonDown_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cacheA);
		if (Lua_UnityEngine_Input.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Input.GetMouseButtonUp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cacheB);
		if (Lua_UnityEngine_Input.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Input.ResetInputAxes_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cacheC);
		if (Lua_UnityEngine_Input.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Input.GetAccelerationEvent_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cacheD);
		if (Lua_UnityEngine_Input.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Input.GetTouch_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Input.<>f__mg$cacheE);
		string name = "compensateSensors";
		if (Lua_UnityEngine_Input.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Input.get_compensateSensors);
		}
		LuaCSFunction get = Lua_UnityEngine_Input.<>f__mg$cacheF;
		if (Lua_UnityEngine_Input.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Input.set_compensateSensors);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Input.<>f__mg$cache10, false);
		string name2 = "gyro";
		if (Lua_UnityEngine_Input.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Input.get_gyro);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Input.<>f__mg$cache11, null, false);
		string name3 = "mousePosition";
		if (Lua_UnityEngine_Input.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Input.get_mousePosition);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Input.<>f__mg$cache12, null, false);
		string name4 = "mouseScrollDelta";
		if (Lua_UnityEngine_Input.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Input.get_mouseScrollDelta);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Input.<>f__mg$cache13, null, false);
		string name5 = "mousePresent";
		if (Lua_UnityEngine_Input.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Input.get_mousePresent);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Input.<>f__mg$cache14, null, false);
		string name6 = "simulateMouseWithTouches";
		if (Lua_UnityEngine_Input.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Input.get_simulateMouseWithTouches);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Input.<>f__mg$cache15;
		if (Lua_UnityEngine_Input.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Input.set_simulateMouseWithTouches);
		}
		LuaObject.addMember(l, name6, get2, Lua_UnityEngine_Input.<>f__mg$cache16, false);
		string name7 = "anyKey";
		if (Lua_UnityEngine_Input.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Input.get_anyKey);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Input.<>f__mg$cache17, null, false);
		string name8 = "anyKeyDown";
		if (Lua_UnityEngine_Input.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Input.get_anyKeyDown);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Input.<>f__mg$cache18, null, false);
		string name9 = "inputString";
		if (Lua_UnityEngine_Input.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Input.get_inputString);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Input.<>f__mg$cache19, null, false);
		string name10 = "acceleration";
		if (Lua_UnityEngine_Input.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Input.get_acceleration);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Input.<>f__mg$cache1A, null, false);
		string name11 = "accelerationEvents";
		if (Lua_UnityEngine_Input.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Input.get_accelerationEvents);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Input.<>f__mg$cache1B, null, false);
		string name12 = "accelerationEventCount";
		if (Lua_UnityEngine_Input.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Input.get_accelerationEventCount);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_Input.<>f__mg$cache1C, null, false);
		string name13 = "touches";
		if (Lua_UnityEngine_Input.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Input.get_touches);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_Input.<>f__mg$cache1D, null, false);
		string name14 = "touchCount";
		if (Lua_UnityEngine_Input.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Input.get_touchCount);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_Input.<>f__mg$cache1E, null, false);
		string name15 = "touchPressureSupported";
		if (Lua_UnityEngine_Input.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Input.get_touchPressureSupported);
		}
		LuaObject.addMember(l, name15, Lua_UnityEngine_Input.<>f__mg$cache1F, null, false);
		string name16 = "stylusTouchSupported";
		if (Lua_UnityEngine_Input.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Input.get_stylusTouchSupported);
		}
		LuaObject.addMember(l, name16, Lua_UnityEngine_Input.<>f__mg$cache20, null, false);
		string name17 = "touchSupported";
		if (Lua_UnityEngine_Input.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Input.get_touchSupported);
		}
		LuaObject.addMember(l, name17, Lua_UnityEngine_Input.<>f__mg$cache21, null, false);
		string name18 = "multiTouchEnabled";
		if (Lua_UnityEngine_Input.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Input.get_multiTouchEnabled);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Input.<>f__mg$cache22;
		if (Lua_UnityEngine_Input.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Input.set_multiTouchEnabled);
		}
		LuaObject.addMember(l, name18, get3, Lua_UnityEngine_Input.<>f__mg$cache23, false);
		string name19 = "location";
		if (Lua_UnityEngine_Input.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Input.get_location);
		}
		LuaObject.addMember(l, name19, Lua_UnityEngine_Input.<>f__mg$cache24, null, false);
		string name20 = "compass";
		if (Lua_UnityEngine_Input.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Input.get_compass);
		}
		LuaObject.addMember(l, name20, Lua_UnityEngine_Input.<>f__mg$cache25, null, false);
		string name21 = "deviceOrientation";
		if (Lua_UnityEngine_Input.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Input.get_deviceOrientation);
		}
		LuaObject.addMember(l, name21, Lua_UnityEngine_Input.<>f__mg$cache26, null, false);
		string name22 = "imeCompositionMode";
		if (Lua_UnityEngine_Input.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Input.get_imeCompositionMode);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Input.<>f__mg$cache27;
		if (Lua_UnityEngine_Input.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Input.set_imeCompositionMode);
		}
		LuaObject.addMember(l, name22, get4, Lua_UnityEngine_Input.<>f__mg$cache28, false);
		string name23 = "compositionString";
		if (Lua_UnityEngine_Input.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Input.get_compositionString);
		}
		LuaObject.addMember(l, name23, Lua_UnityEngine_Input.<>f__mg$cache29, null, false);
		string name24 = "imeIsSelected";
		if (Lua_UnityEngine_Input.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Input.get_imeIsSelected);
		}
		LuaObject.addMember(l, name24, Lua_UnityEngine_Input.<>f__mg$cache2A, null, false);
		string name25 = "compositionCursorPos";
		if (Lua_UnityEngine_Input.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Input.get_compositionCursorPos);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Input.<>f__mg$cache2B;
		if (Lua_UnityEngine_Input.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Input.set_compositionCursorPos);
		}
		LuaObject.addMember(l, name25, get5, Lua_UnityEngine_Input.<>f__mg$cache2C, false);
		string name26 = "backButtonLeavesApp";
		if (Lua_UnityEngine_Input.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Input.get_backButtonLeavesApp);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Input.<>f__mg$cache2D;
		if (Lua_UnityEngine_Input.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Input.set_backButtonLeavesApp);
		}
		LuaObject.addMember(l, name26, get6, Lua_UnityEngine_Input.<>f__mg$cache2E, false);
		if (Lua_UnityEngine_Input.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Input.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Input.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Input.<>f__mg$cache2F, typeof(Input));
	}

	// Token: 0x04019218 RID: 102936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019219 RID: 102937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401921A RID: 102938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401921B RID: 102939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401921C RID: 102940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401921D RID: 102941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401921E RID: 102942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401921F RID: 102943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019220 RID: 102944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019221 RID: 102945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019222 RID: 102946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019223 RID: 102947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019224 RID: 102948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019225 RID: 102949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019226 RID: 102950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019227 RID: 102951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019228 RID: 102952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019229 RID: 102953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401922A RID: 102954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401922B RID: 102955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401922C RID: 102956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401922D RID: 102957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401922E RID: 102958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401922F RID: 102959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019230 RID: 102960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019231 RID: 102961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019232 RID: 102962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019233 RID: 102963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019234 RID: 102964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019235 RID: 102965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04019236 RID: 102966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04019237 RID: 102967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04019238 RID: 102968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04019239 RID: 102969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401923A RID: 102970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401923B RID: 102971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401923C RID: 102972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401923D RID: 102973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401923E RID: 102974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401923F RID: 102975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019240 RID: 102976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019241 RID: 102977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019242 RID: 102978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019243 RID: 102979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019244 RID: 102980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019245 RID: 102981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019246 RID: 102982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019247 RID: 102983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
