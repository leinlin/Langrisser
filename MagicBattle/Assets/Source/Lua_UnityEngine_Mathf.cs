using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001726 RID: 5926
[Preserve]
public class Lua_UnityEngine_Mathf : LuaObject
{
	// Token: 0x060235C0 RID: 144832 RVA: 0x00C4B904 File Offset: 0x00C49B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Mathf mathf = default(Mathf);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mathf);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235C1 RID: 144833 RVA: 0x00C4B954 File Offset: 0x00C49B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosestPowerOfTwo_s(IntPtr l)
	{
		int result;
		try
		{
			int value;
			LuaObject.checkType(l, 1, out value);
			int i = Mathf.ClosestPowerOfTwo(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235C2 RID: 144834 RVA: 0x00C4B9A8 File Offset: 0x00C49BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GammaToLinearSpace_s(IntPtr l)
	{
		int result;
		try
		{
			float value;
			LuaObject.checkType(l, 1, out value);
			float o = Mathf.GammaToLinearSpace(value);
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

	// Token: 0x060235C3 RID: 144835 RVA: 0x00C4B9FC File Offset: 0x00C49BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LinearToGammaSpace_s(IntPtr l)
	{
		int result;
		try
		{
			float value;
			LuaObject.checkType(l, 1, out value);
			float o = Mathf.LinearToGammaSpace(value);
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

	// Token: 0x060235C4 RID: 144836 RVA: 0x00C4BA50 File Offset: 0x00C49C50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CorrelatedColorTemperatureToRGB_s(IntPtr l)
	{
		int result;
		try
		{
			float kelvin;
			LuaObject.checkType(l, 1, out kelvin);
			Color o = Mathf.CorrelatedColorTemperatureToRGB(kelvin);
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

	// Token: 0x060235C5 RID: 144837 RVA: 0x00C4BAA4 File Offset: 0x00C49CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPowerOfTwo_s(IntPtr l)
	{
		int result;
		try
		{
			int value;
			LuaObject.checkType(l, 1, out value);
			bool b = Mathf.IsPowerOfTwo(value);
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

	// Token: 0x060235C6 RID: 144838 RVA: 0x00C4BAF8 File Offset: 0x00C49CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NextPowerOfTwo_s(IntPtr l)
	{
		int result;
		try
		{
			int value;
			LuaObject.checkType(l, 1, out value);
			int i = Mathf.NextPowerOfTwo(value);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235C7 RID: 144839 RVA: 0x00C4BB4C File Offset: 0x00C49D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PerlinNoise_s(IntPtr l)
	{
		int result;
		try
		{
			float x;
			LuaObject.checkType(l, 1, out x);
			float y;
			LuaObject.checkType(l, 2, out y);
			float o = Mathf.PerlinNoise(x, y);
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

	// Token: 0x060235C8 RID: 144840 RVA: 0x00C4BBAC File Offset: 0x00C49DAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FloatToHalf_s(IntPtr l)
	{
		int result;
		try
		{
			float val;
			LuaObject.checkType(l, 1, out val);
			ushort v = Mathf.FloatToHalf(val);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, v);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235C9 RID: 144841 RVA: 0x00C4BC00 File Offset: 0x00C49E00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HalfToFloat_s(IntPtr l)
	{
		int result;
		try
		{
			ushort val;
			LuaObject.checkType(l, 1, out val);
			float o = Mathf.HalfToFloat(val);
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

	// Token: 0x060235CA RID: 144842 RVA: 0x00C4BC54 File Offset: 0x00C49E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Sin_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Sin(f);
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

	// Token: 0x060235CB RID: 144843 RVA: 0x00C4BCA8 File Offset: 0x00C49EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Cos_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Cos(f);
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

	// Token: 0x060235CC RID: 144844 RVA: 0x00C4BCFC File Offset: 0x00C49EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tan_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Tan(f);
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

	// Token: 0x060235CD RID: 144845 RVA: 0x00C4BD50 File Offset: 0x00C49F50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Asin_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Asin(f);
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

	// Token: 0x060235CE RID: 144846 RVA: 0x00C4BDA4 File Offset: 0x00C49FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Acos_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Acos(f);
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

	// Token: 0x060235CF RID: 144847 RVA: 0x00C4BDF8 File Offset: 0x00C49FF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Atan_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Atan(f);
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

	// Token: 0x060235D0 RID: 144848 RVA: 0x00C4BE4C File Offset: 0x00C4A04C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Atan2_s(IntPtr l)
	{
		int result;
		try
		{
			float y;
			LuaObject.checkType(l, 1, out y);
			float x;
			LuaObject.checkType(l, 2, out x);
			float o = Mathf.Atan2(y, x);
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

	// Token: 0x060235D1 RID: 144849 RVA: 0x00C4BEAC File Offset: 0x00C4A0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Sqrt_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Sqrt(f);
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

	// Token: 0x060235D2 RID: 144850 RVA: 0x00C4BF00 File Offset: 0x00C4A100
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Abs_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(float)))
			{
				float f;
				LuaObject.checkType(l, 1, out f);
				float o = Mathf.Abs(f);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int)))
			{
				int value;
				LuaObject.checkType(l, 1, out value);
				int i = Mathf.Abs(value);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Abs to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235D3 RID: 144851 RVA: 0x00C4BFCC File Offset: 0x00C4A1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Min_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(float), typeof(float)))
			{
				float a;
				LuaObject.checkType(l, 1, out a);
				float b;
				LuaObject.checkType(l, 2, out b);
				float o = Mathf.Min(a, b);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(float[])))
			{
				float[] values;
				LuaObject.checkParams(l, 1, out values);
				float o2 = Mathf.Min(values);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int[])))
			{
				int[] values2;
				LuaObject.checkParams(l, 1, out values2);
				int i = Mathf.Min(values2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(int)))
			{
				int a2;
				LuaObject.checkType(l, 1, out a2);
				int b2;
				LuaObject.checkType(l, 2, out b2);
				int i2 = Mathf.Min(a2, b2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Min to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235D4 RID: 144852 RVA: 0x00C4C158 File Offset: 0x00C4A358
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Max_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(float), typeof(float)))
			{
				float a;
				LuaObject.checkType(l, 1, out a);
				float b;
				LuaObject.checkType(l, 2, out b);
				float o = Mathf.Max(a, b);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(float[])))
			{
				float[] values;
				LuaObject.checkParams(l, 1, out values);
				float o2 = Mathf.Max(values);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int[])))
			{
				int[] values2;
				LuaObject.checkParams(l, 1, out values2);
				int i = Mathf.Max(values2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(int), typeof(int)))
			{
				int a2;
				LuaObject.checkType(l, 1, out a2);
				int b2;
				LuaObject.checkType(l, 2, out b2);
				int i2 = Mathf.Max(a2, b2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Max to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235D5 RID: 144853 RVA: 0x00C4C2E4 File Offset: 0x00C4A4E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Pow_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float p;
			LuaObject.checkType(l, 2, out p);
			float o = Mathf.Pow(f, p);
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

	// Token: 0x060235D6 RID: 144854 RVA: 0x00C4C344 File Offset: 0x00C4A544
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Exp_s(IntPtr l)
	{
		int result;
		try
		{
			float power;
			LuaObject.checkType(l, 1, out power);
			float o = Mathf.Exp(power);
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

	// Token: 0x060235D7 RID: 144855 RVA: 0x00C4C398 File Offset: 0x00C4A598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Log_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				float f;
				LuaObject.checkType(l, 1, out f);
				float o = Mathf.Log(f);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				float f2;
				LuaObject.checkType(l, 1, out f2);
				float p;
				LuaObject.checkType(l, 2, out p);
				float o2 = Mathf.Log(f2, p);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Log to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235D8 RID: 144856 RVA: 0x00C4C450 File Offset: 0x00C4A650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Log10_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Log10(f);
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

	// Token: 0x060235D9 RID: 144857 RVA: 0x00C4C4A4 File Offset: 0x00C4A6A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Ceil_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Ceil(f);
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

	// Token: 0x060235DA RID: 144858 RVA: 0x00C4C4F8 File Offset: 0x00C4A6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Floor_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Floor(f);
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

	// Token: 0x060235DB RID: 144859 RVA: 0x00C4C54C File Offset: 0x00C4A74C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Round_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Round(f);
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

	// Token: 0x060235DC RID: 144860 RVA: 0x00C4C5A0 File Offset: 0x00C4A7A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CeilToInt_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			int i = Mathf.CeilToInt(f);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235DD RID: 144861 RVA: 0x00C4C5F4 File Offset: 0x00C4A7F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FloorToInt_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			int i = Mathf.FloorToInt(f);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235DE RID: 144862 RVA: 0x00C4C648 File Offset: 0x00C4A848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RoundToInt_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			int i = Mathf.RoundToInt(f);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235DF RID: 144863 RVA: 0x00C4C69C File Offset: 0x00C4A89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Sign_s(IntPtr l)
	{
		int result;
		try
		{
			float f;
			LuaObject.checkType(l, 1, out f);
			float o = Mathf.Sign(f);
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

	// Token: 0x060235E0 RID: 144864 RVA: 0x00C4C6F0 File Offset: 0x00C4A8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clamp_s(IntPtr l)
	{
		int result;
		try
		{
			float value;
			LuaObject.checkType(l, 1, out value);
			float min;
			LuaObject.checkType(l, 2, out min);
			float max;
			LuaObject.checkType(l, 3, out max);
			float o = Mathf.Clamp(value, min, max);
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

	// Token: 0x060235E1 RID: 144865 RVA: 0x00C4C760 File Offset: 0x00C4A960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clamp01_s(IntPtr l)
	{
		int result;
		try
		{
			float value;
			LuaObject.checkType(l, 1, out value);
			float o = Mathf.Clamp01(value);
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

	// Token: 0x060235E2 RID: 144866 RVA: 0x00C4C7B4 File Offset: 0x00C4A9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Lerp_s(IntPtr l)
	{
		int result;
		try
		{
			float a;
			LuaObject.checkType(l, 1, out a);
			float b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			float o = Mathf.Lerp(a, b, t);
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

	// Token: 0x060235E3 RID: 144867 RVA: 0x00C4C824 File Offset: 0x00C4AA24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LerpUnclamped_s(IntPtr l)
	{
		int result;
		try
		{
			float a;
			LuaObject.checkType(l, 1, out a);
			float b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			float o = Mathf.LerpUnclamped(a, b, t);
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

	// Token: 0x060235E4 RID: 144868 RVA: 0x00C4C894 File Offset: 0x00C4AA94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int LerpAngle_s(IntPtr l)
	{
		int result;
		try
		{
			float a;
			LuaObject.checkType(l, 1, out a);
			float b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			float o = Mathf.LerpAngle(a, b, t);
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

	// Token: 0x060235E5 RID: 144869 RVA: 0x00C4C904 File Offset: 0x00C4AB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveTowards_s(IntPtr l)
	{
		int result;
		try
		{
			float current;
			LuaObject.checkType(l, 1, out current);
			float target;
			LuaObject.checkType(l, 2, out target);
			float maxDelta;
			LuaObject.checkType(l, 3, out maxDelta);
			float o = Mathf.MoveTowards(current, target, maxDelta);
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

	// Token: 0x060235E6 RID: 144870 RVA: 0x00C4C974 File Offset: 0x00C4AB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveTowardsAngle_s(IntPtr l)
	{
		int result;
		try
		{
			float current;
			LuaObject.checkType(l, 1, out current);
			float target;
			LuaObject.checkType(l, 2, out target);
			float maxDelta;
			LuaObject.checkType(l, 3, out maxDelta);
			float o = Mathf.MoveTowardsAngle(current, target, maxDelta);
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

	// Token: 0x060235E7 RID: 144871 RVA: 0x00C4C9E4 File Offset: 0x00C4ABE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SmoothStep_s(IntPtr l)
	{
		int result;
		try
		{
			float from;
			LuaObject.checkType(l, 1, out from);
			float to;
			LuaObject.checkType(l, 2, out to);
			float t;
			LuaObject.checkType(l, 3, out t);
			float o = Mathf.SmoothStep(from, to, t);
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

	// Token: 0x060235E8 RID: 144872 RVA: 0x00C4CA54 File Offset: 0x00C4AC54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Gamma_s(IntPtr l)
	{
		int result;
		try
		{
			float value;
			LuaObject.checkType(l, 1, out value);
			float absmax;
			LuaObject.checkType(l, 2, out absmax);
			float gamma;
			LuaObject.checkType(l, 3, out gamma);
			float o = Mathf.Gamma(value, absmax, gamma);
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

	// Token: 0x060235E9 RID: 144873 RVA: 0x00C4CAC4 File Offset: 0x00C4ACC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Approximately_s(IntPtr l)
	{
		int result;
		try
		{
			float a;
			LuaObject.checkType(l, 1, out a);
			float b;
			LuaObject.checkType(l, 2, out b);
			bool b2 = Mathf.Approximately(a, b);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235EA RID: 144874 RVA: 0x00C4CB24 File Offset: 0x00C4AD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SmoothDamp_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				float current;
				LuaObject.checkType(l, 1, out current);
				float target;
				LuaObject.checkType(l, 2, out target);
				float o;
				LuaObject.checkType(l, 3, out o);
				float smoothTime;
				LuaObject.checkType(l, 4, out smoothTime);
				float o2 = Mathf.SmoothDamp(current, target, ref o, smoothTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				LuaObject.pushValue(l, o);
				result = 3;
			}
			else if (num == 5)
			{
				float current2;
				LuaObject.checkType(l, 1, out current2);
				float target2;
				LuaObject.checkType(l, 2, out target2);
				float o3;
				LuaObject.checkType(l, 3, out o3);
				float smoothTime2;
				LuaObject.checkType(l, 4, out smoothTime2);
				float maxSpeed;
				LuaObject.checkType(l, 5, out maxSpeed);
				float o4 = Mathf.SmoothDamp(current2, target2, ref o3, smoothTime2, maxSpeed);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				LuaObject.pushValue(l, o3);
				result = 3;
			}
			else if (num == 6)
			{
				float current3;
				LuaObject.checkType(l, 1, out current3);
				float target3;
				LuaObject.checkType(l, 2, out target3);
				float o5;
				LuaObject.checkType(l, 3, out o5);
				float smoothTime3;
				LuaObject.checkType(l, 4, out smoothTime3);
				float maxSpeed2;
				LuaObject.checkType(l, 5, out maxSpeed2);
				float deltaTime;
				LuaObject.checkType(l, 6, out deltaTime);
				float o6 = Mathf.SmoothDamp(current3, target3, ref o5, smoothTime3, maxSpeed2, deltaTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o6);
				LuaObject.pushValue(l, o5);
				result = 3;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SmoothDamp to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235EB RID: 144875 RVA: 0x00C4CCBC File Offset: 0x00C4AEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SmoothDampAngle_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				float current;
				LuaObject.checkType(l, 1, out current);
				float target;
				LuaObject.checkType(l, 2, out target);
				float o;
				LuaObject.checkType(l, 3, out o);
				float smoothTime;
				LuaObject.checkType(l, 4, out smoothTime);
				float o2 = Mathf.SmoothDampAngle(current, target, ref o, smoothTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				LuaObject.pushValue(l, o);
				result = 3;
			}
			else if (num == 5)
			{
				float current2;
				LuaObject.checkType(l, 1, out current2);
				float target2;
				LuaObject.checkType(l, 2, out target2);
				float o3;
				LuaObject.checkType(l, 3, out o3);
				float smoothTime2;
				LuaObject.checkType(l, 4, out smoothTime2);
				float maxSpeed;
				LuaObject.checkType(l, 5, out maxSpeed);
				float o4 = Mathf.SmoothDampAngle(current2, target2, ref o3, smoothTime2, maxSpeed);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				LuaObject.pushValue(l, o3);
				result = 3;
			}
			else if (num == 6)
			{
				float current3;
				LuaObject.checkType(l, 1, out current3);
				float target3;
				LuaObject.checkType(l, 2, out target3);
				float o5;
				LuaObject.checkType(l, 3, out o5);
				float smoothTime3;
				LuaObject.checkType(l, 4, out smoothTime3);
				float maxSpeed2;
				LuaObject.checkType(l, 5, out maxSpeed2);
				float deltaTime;
				LuaObject.checkType(l, 6, out deltaTime);
				float o6 = Mathf.SmoothDampAngle(current3, target3, ref o5, smoothTime3, maxSpeed2, deltaTime);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o6);
				LuaObject.pushValue(l, o5);
				result = 3;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SmoothDampAngle to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235EC RID: 144876 RVA: 0x00C4CE54 File Offset: 0x00C4B054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Repeat_s(IntPtr l)
	{
		int result;
		try
		{
			float t;
			LuaObject.checkType(l, 1, out t);
			float length;
			LuaObject.checkType(l, 2, out length);
			float o = Mathf.Repeat(t, length);
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

	// Token: 0x060235ED RID: 144877 RVA: 0x00C4CEB4 File Offset: 0x00C4B0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PingPong_s(IntPtr l)
	{
		int result;
		try
		{
			float t;
			LuaObject.checkType(l, 1, out t);
			float length;
			LuaObject.checkType(l, 2, out length);
			float o = Mathf.PingPong(t, length);
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

	// Token: 0x060235EE RID: 144878 RVA: 0x00C4CF14 File Offset: 0x00C4B114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InverseLerp_s(IntPtr l)
	{
		int result;
		try
		{
			float a;
			LuaObject.checkType(l, 1, out a);
			float b;
			LuaObject.checkType(l, 2, out b);
			float value;
			LuaObject.checkType(l, 3, out value);
			float o = Mathf.InverseLerp(a, b, value);
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

	// Token: 0x060235EF RID: 144879 RVA: 0x00C4CF84 File Offset: 0x00C4B184
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeltaAngle_s(IntPtr l)
	{
		int result;
		try
		{
			float current;
			LuaObject.checkType(l, 1, out current);
			float target;
			LuaObject.checkType(l, 2, out target);
			float o = Mathf.DeltaAngle(current, target);
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

	// Token: 0x060235F0 RID: 144880 RVA: 0x00C4CFE4 File Offset: 0x00C4B1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PI(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3.14159274f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235F1 RID: 144881 RVA: 0x00C4D02C File Offset: 0x00C4B22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Infinity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, float.PositiveInfinity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235F2 RID: 144882 RVA: 0x00C4D074 File Offset: 0x00C4B274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NegativeInfinity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, float.NegativeInfinity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235F3 RID: 144883 RVA: 0x00C4D0BC File Offset: 0x00C4B2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Deg2Rad(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.0174532924f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235F4 RID: 144884 RVA: 0x00C4D104 File Offset: 0x00C4B304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rad2Deg(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 57.29578f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235F5 RID: 144885 RVA: 0x00C4D14C File Offset: 0x00C4B34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Epsilon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Mathf.Epsilon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060235F6 RID: 144886 RVA: 0x00C4D194 File Offset: 0x00C4B394
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Mathf");
		if (Lua_UnityEngine_Mathf.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Mathf.ClosestPowerOfTwo_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache0);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Mathf.GammaToLinearSpace_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache1);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Mathf.LinearToGammaSpace_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache2);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Mathf.CorrelatedColorTemperatureToRGB_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache3);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Mathf.IsPowerOfTwo_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache4);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Mathf.NextPowerOfTwo_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache5);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Mathf.PerlinNoise_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache6);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Mathf.FloatToHalf_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache7);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Mathf.HalfToFloat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache8);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Mathf.Sin_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache9);
		if (Lua_UnityEngine_Mathf.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Mathf.Cos_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cacheA);
		if (Lua_UnityEngine_Mathf.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Mathf.Tan_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cacheB);
		if (Lua_UnityEngine_Mathf.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Mathf.Asin_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cacheC);
		if (Lua_UnityEngine_Mathf.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Mathf.Acos_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cacheD);
		if (Lua_UnityEngine_Mathf.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Mathf.Atan_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cacheE);
		if (Lua_UnityEngine_Mathf.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Mathf.Atan2_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cacheF);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Mathf.Sqrt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache10);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Mathf.Abs_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache11);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Mathf.Min_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache12);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Mathf.Max_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache13);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Mathf.Pow_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache14);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Mathf.Exp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache15);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Mathf.Log_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache16);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Mathf.Log10_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache17);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Mathf.Ceil_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache18);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Mathf.Floor_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache19);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Mathf.Round_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache1A);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Mathf.CeilToInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache1B);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Mathf.FloorToInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache1C);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Mathf.RoundToInt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache1D);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Mathf.Sign_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache1E);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Mathf.Clamp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache1F);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Mathf.Clamp01_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache20);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Mathf.Lerp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache21);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Mathf.LerpUnclamped_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache22);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Mathf.LerpAngle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache23);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Mathf.MoveTowards_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache24);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Mathf.MoveTowardsAngle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache25);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Mathf.SmoothStep_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache26);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Mathf.Gamma_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache27);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Mathf.Approximately_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache28);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Mathf.SmoothDamp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache29);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Mathf.SmoothDampAngle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache2A);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Mathf.Repeat_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache2B);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Mathf.PingPong_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache2C);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Mathf.InverseLerp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache2D);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Mathf.DeltaAngle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mathf.<>f__mg$cache2E);
		string name = "PI";
		if (Lua_UnityEngine_Mathf.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Mathf.get_PI);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Mathf.<>f__mg$cache2F, null, false);
		string name2 = "Infinity";
		if (Lua_UnityEngine_Mathf.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Mathf.get_Infinity);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Mathf.<>f__mg$cache30, null, false);
		string name3 = "NegativeInfinity";
		if (Lua_UnityEngine_Mathf.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Mathf.get_NegativeInfinity);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Mathf.<>f__mg$cache31, null, false);
		string name4 = "Deg2Rad";
		if (Lua_UnityEngine_Mathf.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Mathf.get_Deg2Rad);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Mathf.<>f__mg$cache32, null, false);
		string name5 = "Rad2Deg";
		if (Lua_UnityEngine_Mathf.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Mathf.get_Rad2Deg);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Mathf.<>f__mg$cache33, null, false);
		string name6 = "Epsilon";
		if (Lua_UnityEngine_Mathf.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Mathf.get_Epsilon);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Mathf.<>f__mg$cache34, null, false);
		if (Lua_UnityEngine_Mathf.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Mathf.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Mathf.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Mathf.<>f__mg$cache35, typeof(Mathf), typeof(ValueType));
	}

	// Token: 0x040193D2 RID: 103378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040193D3 RID: 103379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040193D4 RID: 103380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040193D5 RID: 103381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040193D6 RID: 103382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040193D7 RID: 103383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040193D8 RID: 103384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040193D9 RID: 103385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040193DA RID: 103386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040193DB RID: 103387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040193DC RID: 103388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040193DD RID: 103389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040193DE RID: 103390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040193DF RID: 103391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040193E0 RID: 103392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040193E1 RID: 103393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040193E2 RID: 103394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040193E3 RID: 103395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040193E4 RID: 103396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040193E5 RID: 103397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040193E6 RID: 103398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040193E7 RID: 103399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040193E8 RID: 103400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040193E9 RID: 103401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040193EA RID: 103402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040193EB RID: 103403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040193EC RID: 103404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040193ED RID: 103405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040193EE RID: 103406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040193EF RID: 103407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040193F0 RID: 103408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040193F1 RID: 103409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040193F2 RID: 103410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040193F3 RID: 103411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040193F4 RID: 103412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040193F5 RID: 103413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040193F6 RID: 103414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040193F7 RID: 103415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040193F8 RID: 103416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040193F9 RID: 103417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040193FA RID: 103418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040193FB RID: 103419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040193FC RID: 103420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040193FD RID: 103421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040193FE RID: 103422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040193FF RID: 103423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04019400 RID: 103424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04019401 RID: 103425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04019402 RID: 103426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04019403 RID: 103427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04019404 RID: 103428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04019405 RID: 103429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04019406 RID: 103430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04019407 RID: 103431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;
}
