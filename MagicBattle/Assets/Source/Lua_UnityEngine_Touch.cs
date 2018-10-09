using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001801 RID: 6145
[Preserve]
public class Lua_UnityEngine_Touch : LuaObject
{
	// Token: 0x06023EF0 RID: 147184 RVA: 0x00C9B168 File Offset: 0x00C99368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Touch touch = default(Touch);
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

	// Token: 0x06023EF1 RID: 147185 RVA: 0x00C9B1B8 File Offset: 0x00C993B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fingerId(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.fingerId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EF2 RID: 147186 RVA: 0x00C9B20C File Offset: 0x00C9940C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fingerId(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			int fingerId;
			LuaObject.checkType(l, 2, out fingerId);
			touch.fingerId = fingerId;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EF3 RID: 147187 RVA: 0x00C9B270 File Offset: 0x00C99470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EF4 RID: 147188 RVA: 0x00C9B2C4 File Offset: 0x00C994C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			Vector2 position;
			LuaObject.checkType(l, 2, out position);
			touch.position = position;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EF5 RID: 147189 RVA: 0x00C9B328 File Offset: 0x00C99528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rawPosition(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.rawPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EF6 RID: 147190 RVA: 0x00C9B37C File Offset: 0x00C9957C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rawPosition(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			Vector2 rawPosition;
			LuaObject.checkType(l, 2, out rawPosition);
			touch.rawPosition = rawPosition;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EF7 RID: 147191 RVA: 0x00C9B3E0 File Offset: 0x00C995E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deltaPosition(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.deltaPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EF8 RID: 147192 RVA: 0x00C9B434 File Offset: 0x00C99634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_deltaPosition(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			Vector2 deltaPosition;
			LuaObject.checkType(l, 2, out deltaPosition);
			touch.deltaPosition = deltaPosition;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EF9 RID: 147193 RVA: 0x00C9B498 File Offset: 0x00C99698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deltaTime(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.deltaTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EFA RID: 147194 RVA: 0x00C9B4EC File Offset: 0x00C996EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_deltaTime(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			float deltaTime;
			LuaObject.checkType(l, 2, out deltaTime);
			touch.deltaTime = deltaTime;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EFB RID: 147195 RVA: 0x00C9B550 File Offset: 0x00C99750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tapCount(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.tapCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EFC RID: 147196 RVA: 0x00C9B5A4 File Offset: 0x00C997A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_tapCount(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			int tapCount;
			LuaObject.checkType(l, 2, out tapCount);
			touch.tapCount = tapCount;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EFD RID: 147197 RVA: 0x00C9B608 File Offset: 0x00C99808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_phase(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)touch.phase);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EFE RID: 147198 RVA: 0x00C9B65C File Offset: 0x00C9985C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_phase(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			TouchPhase phase;
			LuaObject.checkEnum<TouchPhase>(l, 2, out phase);
			touch.phase = phase;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EFF RID: 147199 RVA: 0x00C9B6C0 File Offset: 0x00C998C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pressure(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.pressure);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F00 RID: 147200 RVA: 0x00C9B714 File Offset: 0x00C99914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pressure(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			float pressure;
			LuaObject.checkType(l, 2, out pressure);
			touch.pressure = pressure;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F01 RID: 147201 RVA: 0x00C9B778 File Offset: 0x00C99978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maximumPossiblePressure(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.maximumPossiblePressure);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F02 RID: 147202 RVA: 0x00C9B7CC File Offset: 0x00C999CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maximumPossiblePressure(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			float maximumPossiblePressure;
			LuaObject.checkType(l, 2, out maximumPossiblePressure);
			touch.maximumPossiblePressure = maximumPossiblePressure;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F03 RID: 147203 RVA: 0x00C9B830 File Offset: 0x00C99A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_type(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)touch.type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F04 RID: 147204 RVA: 0x00C9B884 File Offset: 0x00C99A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_type(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			TouchType type;
			LuaObject.checkEnum<TouchType>(l, 2, out type);
			touch.type = type;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F05 RID: 147205 RVA: 0x00C9B8E8 File Offset: 0x00C99AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_altitudeAngle(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.altitudeAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F06 RID: 147206 RVA: 0x00C9B93C File Offset: 0x00C99B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_altitudeAngle(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			float altitudeAngle;
			LuaObject.checkType(l, 2, out altitudeAngle);
			touch.altitudeAngle = altitudeAngle;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F07 RID: 147207 RVA: 0x00C9B9A0 File Offset: 0x00C99BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_azimuthAngle(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.azimuthAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F08 RID: 147208 RVA: 0x00C9B9F4 File Offset: 0x00C99BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_azimuthAngle(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			float azimuthAngle;
			LuaObject.checkType(l, 2, out azimuthAngle);
			touch.azimuthAngle = azimuthAngle;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F09 RID: 147209 RVA: 0x00C9BA58 File Offset: 0x00C99C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_radius(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.radius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F0A RID: 147210 RVA: 0x00C9BAAC File Offset: 0x00C99CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_radius(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			float radius;
			LuaObject.checkType(l, 2, out radius);
			touch.radius = radius;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F0B RID: 147211 RVA: 0x00C9BB10 File Offset: 0x00C99D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_radiusVariance(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch.radiusVariance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F0C RID: 147212 RVA: 0x00C9BB64 File Offset: 0x00C99D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_radiusVariance(IntPtr l)
	{
		int result;
		try
		{
			Touch touch;
			LuaObject.checkValueType<Touch>(l, 1, out touch);
			float radiusVariance;
			LuaObject.checkType(l, 2, out radiusVariance);
			touch.radiusVariance = radiusVariance;
			LuaObject.setBack(l, touch);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F0D RID: 147213 RVA: 0x00C9BBC8 File Offset: 0x00C99DC8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Touch");
		string name = "fingerId";
		if (Lua_UnityEngine_Touch.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Touch.get_fingerId);
		}
		LuaCSFunction get = Lua_UnityEngine_Touch.<>f__mg$cache0;
		if (Lua_UnityEngine_Touch.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Touch.set_fingerId);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Touch.<>f__mg$cache1, true);
		string name2 = "position";
		if (Lua_UnityEngine_Touch.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Touch.get_position);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Touch.<>f__mg$cache2;
		if (Lua_UnityEngine_Touch.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Touch.set_position);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Touch.<>f__mg$cache3, true);
		string name3 = "rawPosition";
		if (Lua_UnityEngine_Touch.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Touch.get_rawPosition);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Touch.<>f__mg$cache4;
		if (Lua_UnityEngine_Touch.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Touch.set_rawPosition);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Touch.<>f__mg$cache5, true);
		string name4 = "deltaPosition";
		if (Lua_UnityEngine_Touch.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Touch.get_deltaPosition);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Touch.<>f__mg$cache6;
		if (Lua_UnityEngine_Touch.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Touch.set_deltaPosition);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Touch.<>f__mg$cache7, true);
		string name5 = "deltaTime";
		if (Lua_UnityEngine_Touch.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Touch.get_deltaTime);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Touch.<>f__mg$cache8;
		if (Lua_UnityEngine_Touch.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Touch.set_deltaTime);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Touch.<>f__mg$cache9, true);
		string name6 = "tapCount";
		if (Lua_UnityEngine_Touch.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Touch.get_tapCount);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Touch.<>f__mg$cacheA;
		if (Lua_UnityEngine_Touch.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Touch.set_tapCount);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_Touch.<>f__mg$cacheB, true);
		string name7 = "phase";
		if (Lua_UnityEngine_Touch.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Touch.get_phase);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Touch.<>f__mg$cacheC;
		if (Lua_UnityEngine_Touch.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Touch.set_phase);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_Touch.<>f__mg$cacheD, true);
		string name8 = "pressure";
		if (Lua_UnityEngine_Touch.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Touch.get_pressure);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Touch.<>f__mg$cacheE;
		if (Lua_UnityEngine_Touch.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Touch.set_pressure);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_Touch.<>f__mg$cacheF, true);
		string name9 = "maximumPossiblePressure";
		if (Lua_UnityEngine_Touch.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Touch.get_maximumPossiblePressure);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Touch.<>f__mg$cache10;
		if (Lua_UnityEngine_Touch.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Touch.set_maximumPossiblePressure);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_Touch.<>f__mg$cache11, true);
		string name10 = "type";
		if (Lua_UnityEngine_Touch.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Touch.get_type);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Touch.<>f__mg$cache12;
		if (Lua_UnityEngine_Touch.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Touch.set_type);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_Touch.<>f__mg$cache13, true);
		string name11 = "altitudeAngle";
		if (Lua_UnityEngine_Touch.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Touch.get_altitudeAngle);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Touch.<>f__mg$cache14;
		if (Lua_UnityEngine_Touch.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Touch.set_altitudeAngle);
		}
		LuaObject.addMember(l, name11, get11, Lua_UnityEngine_Touch.<>f__mg$cache15, true);
		string name12 = "azimuthAngle";
		if (Lua_UnityEngine_Touch.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Touch.get_azimuthAngle);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Touch.<>f__mg$cache16;
		if (Lua_UnityEngine_Touch.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Touch.set_azimuthAngle);
		}
		LuaObject.addMember(l, name12, get12, Lua_UnityEngine_Touch.<>f__mg$cache17, true);
		string name13 = "radius";
		if (Lua_UnityEngine_Touch.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Touch.get_radius);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Touch.<>f__mg$cache18;
		if (Lua_UnityEngine_Touch.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Touch.set_radius);
		}
		LuaObject.addMember(l, name13, get13, Lua_UnityEngine_Touch.<>f__mg$cache19, true);
		string name14 = "radiusVariance";
		if (Lua_UnityEngine_Touch.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Touch.get_radiusVariance);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Touch.<>f__mg$cache1A;
		if (Lua_UnityEngine_Touch.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Touch.set_radiusVariance);
		}
		LuaObject.addMember(l, name14, get14, Lua_UnityEngine_Touch.<>f__mg$cache1B, true);
		if (Lua_UnityEngine_Touch.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Touch.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Touch.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Touch.<>f__mg$cache1C, typeof(Touch), typeof(ValueType));
	}

	// Token: 0x04019B4C RID: 105292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019B4D RID: 105293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019B4E RID: 105294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019B4F RID: 105295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019B50 RID: 105296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019B51 RID: 105297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019B52 RID: 105298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019B53 RID: 105299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019B54 RID: 105300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019B55 RID: 105301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019B56 RID: 105302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019B57 RID: 105303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019B58 RID: 105304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019B59 RID: 105305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019B5A RID: 105306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019B5B RID: 105307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019B5C RID: 105308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019B5D RID: 105309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019B5E RID: 105310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019B5F RID: 105311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019B60 RID: 105312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019B61 RID: 105313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019B62 RID: 105314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019B63 RID: 105315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019B64 RID: 105316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019B65 RID: 105317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019B66 RID: 105318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019B67 RID: 105319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019B68 RID: 105320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
