using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001665 RID: 5733
[Preserve]
public class Lua_UnityEngine_Color : LuaObject
{
	// Token: 0x06022EA0 RID: 143008 RVA: 0x00C12D64 File Offset: 0x00C10F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				float r;
				LuaObject.checkType(l, 2, out r);
				float g;
				LuaObject.checkType(l, 3, out g);
				float b;
				LuaObject.checkType(l, 4, out b);
				float a;
				LuaObject.checkType(l, 5, out a);
				Color color = new Color(r, g, b, a);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, color);
				result = 2;
			}
			else if (num == 4)
			{
				float r2;
				LuaObject.checkType(l, 2, out r2);
				float g2;
				LuaObject.checkType(l, 3, out g2);
				float b2;
				LuaObject.checkType(l, 4, out b2);
				Color color = new Color(r2, g2, b2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, color);
				result = 2;
			}
			else if (num == 0)
			{
				Color color = default(Color);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, color);
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

	// Token: 0x06022EA1 RID: 143009 RVA: 0x00C12E70 File Offset: 0x00C11070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Addition(IntPtr l)
	{
		int result;
		try
		{
			Color a;
			LuaObject.checkType(l, 1, out a);
			Color b;
			LuaObject.checkType(l, 2, out b);
			Color o = a + b;
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

	// Token: 0x06022EA2 RID: 143010 RVA: 0x00C12ED0 File Offset: 0x00C110D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Subtraction(IntPtr l)
	{
		int result;
		try
		{
			Color a;
			LuaObject.checkType(l, 1, out a);
			Color b;
			LuaObject.checkType(l, 2, out b);
			Color o = a - b;
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

	// Token: 0x06022EA3 RID: 143011 RVA: 0x00C12F30 File Offset: 0x00C11130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Multiply(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(float), typeof(Color)))
			{
				float b;
				LuaObject.checkType(l, 1, out b);
				Color a;
				LuaObject.checkType(l, 2, out a);
				Color o = b * a;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Color), typeof(float)))
			{
				Color a2;
				LuaObject.checkType(l, 1, out a2);
				float b2;
				LuaObject.checkType(l, 2, out b2);
				Color o2 = a2 * b2;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(Color), typeof(Color)))
			{
				Color a3;
				LuaObject.checkType(l, 1, out a3);
				Color b3;
				LuaObject.checkType(l, 2, out b3);
				Color o3 = a3 * b3;
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function op_Multiply to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EA4 RID: 143012 RVA: 0x00C13090 File Offset: 0x00C11290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Division(IntPtr l)
	{
		int result;
		try
		{
			Color a;
			LuaObject.checkType(l, 1, out a);
			float b;
			LuaObject.checkType(l, 2, out b);
			Color o = a / b;
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

	// Token: 0x06022EA5 RID: 143013 RVA: 0x00C130F0 File Offset: 0x00C112F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			Color lhs;
			LuaObject.checkType(l, 1, out lhs);
			Color rhs;
			LuaObject.checkType(l, 2, out rhs);
			bool b = lhs == rhs;
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

	// Token: 0x06022EA6 RID: 143014 RVA: 0x00C13150 File Offset: 0x00C11350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			Color lhs;
			LuaObject.checkType(l, 1, out lhs);
			Color rhs;
			LuaObject.checkType(l, 2, out rhs);
			bool b = lhs != rhs;
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

	// Token: 0x06022EA7 RID: 143015 RVA: 0x00C131B0 File Offset: 0x00C113B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Lerp_s(IntPtr l)
	{
		int result;
		try
		{
			Color a;
			LuaObject.checkType(l, 1, out a);
			Color b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Color o = Color.Lerp(a, b, t);
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

	// Token: 0x06022EA8 RID: 143016 RVA: 0x00C13220 File Offset: 0x00C11420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LerpUnclamped_s(IntPtr l)
	{
		int result;
		try
		{
			Color a;
			LuaObject.checkType(l, 1, out a);
			Color b;
			LuaObject.checkType(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Color o = Color.LerpUnclamped(a, b, t);
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

	// Token: 0x06022EA9 RID: 143017 RVA: 0x00C13290 File Offset: 0x00C11490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RGBToHSV_s(IntPtr l)
	{
		int result;
		try
		{
			Color rgbColor;
			LuaObject.checkType(l, 1, out rgbColor);
			float o;
			float o2;
			float o3;
			Color.RGBToHSV(rgbColor, out o, out o2, out o3);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			LuaObject.pushValue(l, o2);
			LuaObject.pushValue(l, o3);
			result = 4;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EAA RID: 143018 RVA: 0x00C132FC File Offset: 0x00C114FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HSVToRGB_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				float h;
				LuaObject.checkType(l, 1, out h);
				float s;
				LuaObject.checkType(l, 2, out s);
				float v;
				LuaObject.checkType(l, 3, out v);
				Color o = Color.HSVToRGB(h, s, v);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				float h2;
				LuaObject.checkType(l, 1, out h2);
				float s2;
				LuaObject.checkType(l, 2, out s2);
				float v2;
				LuaObject.checkType(l, 3, out v2);
				bool hdr;
				LuaObject.checkType(l, 4, out hdr);
				Color o2 = Color.HSVToRGB(h2, s2, v2, hdr);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function HSVToRGB to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EAB RID: 143019 RVA: 0x00C133E8 File Offset: 0x00C115E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_r(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.r);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EAC RID: 143020 RVA: 0x00C1343C File Offset: 0x00C1163C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_r(IntPtr l)
	{
		int result;
		try
		{
			Color v;
			LuaObject.checkType(l, 1, out v);
			float r;
			LuaObject.checkType(l, 2, out r);
			v.r = r;
			LuaObject.setBack(l, v);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EAD RID: 143021 RVA: 0x00C1349C File Offset: 0x00C1169C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_g(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.g);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EAE RID: 143022 RVA: 0x00C134F0 File Offset: 0x00C116F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_g(IntPtr l)
	{
		int result;
		try
		{
			Color v;
			LuaObject.checkType(l, 1, out v);
			float g;
			LuaObject.checkType(l, 2, out g);
			v.g = g;
			LuaObject.setBack(l, v);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EAF RID: 143023 RVA: 0x00C13550 File Offset: 0x00C11750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_b(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EB0 RID: 143024 RVA: 0x00C135A4 File Offset: 0x00C117A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_b(IntPtr l)
	{
		int result;
		try
		{
			Color v;
			LuaObject.checkType(l, 1, out v);
			float b;
			LuaObject.checkType(l, 2, out b);
			v.b = b;
			LuaObject.setBack(l, v);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EB1 RID: 143025 RVA: 0x00C13604 File Offset: 0x00C11804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_a(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.a);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EB2 RID: 143026 RVA: 0x00C13658 File Offset: 0x00C11858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_a(IntPtr l)
	{
		int result;
		try
		{
			Color v;
			LuaObject.checkType(l, 1, out v);
			float a;
			LuaObject.checkType(l, 2, out a);
			v.a = a;
			LuaObject.setBack(l, v);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EB3 RID: 143027 RVA: 0x00C136B8 File Offset: 0x00C118B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_red(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Color.red);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EB4 RID: 143028 RVA: 0x00C13700 File Offset: 0x00C11900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_green(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Color.green);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EB5 RID: 143029 RVA: 0x00C13748 File Offset: 0x00C11948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_blue(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Color.blue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EB6 RID: 143030 RVA: 0x00C13790 File Offset: 0x00C11990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_white(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Color.white);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EB7 RID: 143031 RVA: 0x00C137D8 File Offset: 0x00C119D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_black(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Color.black);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EB8 RID: 143032 RVA: 0x00C13820 File Offset: 0x00C11A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_yellow(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Color.yellow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EB9 RID: 143033 RVA: 0x00C13868 File Offset: 0x00C11A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cyan(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Color.cyan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EBA RID: 143034 RVA: 0x00C138B0 File Offset: 0x00C11AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_magenta(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Color.magenta);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EBB RID: 143035 RVA: 0x00C138F8 File Offset: 0x00C11AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gray(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Color.gray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EBC RID: 143036 RVA: 0x00C13940 File Offset: 0x00C11B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_grey(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Color.grey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EBD RID: 143037 RVA: 0x00C13988 File Offset: 0x00C11B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_clear(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Color.clear);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EBE RID: 143038 RVA: 0x00C139D0 File Offset: 0x00C11BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_grayscale(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.grayscale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EBF RID: 143039 RVA: 0x00C13A24 File Offset: 0x00C11C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_linear(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.linear);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EC0 RID: 143040 RVA: 0x00C13A78 File Offset: 0x00C11C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gamma(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.gamma);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EC1 RID: 143041 RVA: 0x00C13ACC File Offset: 0x00C11CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxColorComponent(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.maxColorComponent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EC2 RID: 143042 RVA: 0x00C13B20 File Offset: 0x00C11D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			int index;
			LuaObject.checkType(l, 2, out index);
			float o = color[index];
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

	// Token: 0x06022EC3 RID: 143043 RVA: 0x00C13B80 File Offset: 0x00C11D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int setItem(IntPtr l)
	{
		int result;
		try
		{
			Color color;
			LuaObject.checkType(l, 1, out color);
			int index;
			LuaObject.checkType(l, 2, out index);
			float value;
			LuaObject.checkType(l, 3, out value);
			color[index] = value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EC4 RID: 143044 RVA: 0x00C13BE4 File Offset: 0x00C11DE4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Color");
		if (Lua_UnityEngine_Color.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Color.op_Addition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cache0);
		if (Lua_UnityEngine_Color.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Color.op_Subtraction);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cache1);
		if (Lua_UnityEngine_Color.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Color.op_Multiply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cache2);
		if (Lua_UnityEngine_Color.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Color.op_Division);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cache3);
		if (Lua_UnityEngine_Color.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Color.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cache4);
		if (Lua_UnityEngine_Color.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Color.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cache5);
		if (Lua_UnityEngine_Color.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Color.Lerp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cache6);
		if (Lua_UnityEngine_Color.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Color.LerpUnclamped_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cache7);
		if (Lua_UnityEngine_Color.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Color.RGBToHSV_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cache8);
		if (Lua_UnityEngine_Color.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Color.HSVToRGB_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cache9);
		if (Lua_UnityEngine_Color.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Color.getItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cacheA);
		if (Lua_UnityEngine_Color.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Color.setItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color.<>f__mg$cacheB);
		string name = "r";
		if (Lua_UnityEngine_Color.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Color.get_r);
		}
		LuaCSFunction get = Lua_UnityEngine_Color.<>f__mg$cacheC;
		if (Lua_UnityEngine_Color.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Color.set_r);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Color.<>f__mg$cacheD, true);
		string name2 = "g";
		if (Lua_UnityEngine_Color.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Color.get_g);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Color.<>f__mg$cacheE;
		if (Lua_UnityEngine_Color.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Color.set_g);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Color.<>f__mg$cacheF, true);
		string name3 = "b";
		if (Lua_UnityEngine_Color.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Color.get_b);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Color.<>f__mg$cache10;
		if (Lua_UnityEngine_Color.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Color.set_b);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Color.<>f__mg$cache11, true);
		string name4 = "a";
		if (Lua_UnityEngine_Color.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Color.get_a);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Color.<>f__mg$cache12;
		if (Lua_UnityEngine_Color.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Color.set_a);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Color.<>f__mg$cache13, true);
		string name5 = "red";
		if (Lua_UnityEngine_Color.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Color.get_red);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Color.<>f__mg$cache14, null, false);
		string name6 = "green";
		if (Lua_UnityEngine_Color.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Color.get_green);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Color.<>f__mg$cache15, null, false);
		string name7 = "blue";
		if (Lua_UnityEngine_Color.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Color.get_blue);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Color.<>f__mg$cache16, null, false);
		string name8 = "white";
		if (Lua_UnityEngine_Color.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Color.get_white);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Color.<>f__mg$cache17, null, false);
		string name9 = "black";
		if (Lua_UnityEngine_Color.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Color.get_black);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Color.<>f__mg$cache18, null, false);
		string name10 = "yellow";
		if (Lua_UnityEngine_Color.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Color.get_yellow);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Color.<>f__mg$cache19, null, false);
		string name11 = "cyan";
		if (Lua_UnityEngine_Color.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Color.get_cyan);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Color.<>f__mg$cache1A, null, false);
		string name12 = "magenta";
		if (Lua_UnityEngine_Color.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Color.get_magenta);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_Color.<>f__mg$cache1B, null, false);
		string name13 = "gray";
		if (Lua_UnityEngine_Color.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Color.get_gray);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_Color.<>f__mg$cache1C, null, false);
		string name14 = "grey";
		if (Lua_UnityEngine_Color.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Color.get_grey);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_Color.<>f__mg$cache1D, null, false);
		string name15 = "clear";
		if (Lua_UnityEngine_Color.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Color.get_clear);
		}
		LuaObject.addMember(l, name15, Lua_UnityEngine_Color.<>f__mg$cache1E, null, false);
		string name16 = "grayscale";
		if (Lua_UnityEngine_Color.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Color.get_grayscale);
		}
		LuaObject.addMember(l, name16, Lua_UnityEngine_Color.<>f__mg$cache1F, null, true);
		string name17 = "linear";
		if (Lua_UnityEngine_Color.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Color.get_linear);
		}
		LuaObject.addMember(l, name17, Lua_UnityEngine_Color.<>f__mg$cache20, null, true);
		string name18 = "gamma";
		if (Lua_UnityEngine_Color.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Color.get_gamma);
		}
		LuaObject.addMember(l, name18, Lua_UnityEngine_Color.<>f__mg$cache21, null, true);
		string name19 = "maxColorComponent";
		if (Lua_UnityEngine_Color.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Color.get_maxColorComponent);
		}
		LuaObject.addMember(l, name19, Lua_UnityEngine_Color.<>f__mg$cache22, null, true);
		if (Lua_UnityEngine_Color.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Color.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Color.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Color.<>f__mg$cache23, typeof(Color), typeof(ValueType));
	}

	// Token: 0x04018E34 RID: 101940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018E35 RID: 101941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018E36 RID: 101942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018E37 RID: 101943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018E38 RID: 101944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018E39 RID: 101945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018E3A RID: 101946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018E3B RID: 101947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018E3C RID: 101948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018E3D RID: 101949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018E3E RID: 101950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018E3F RID: 101951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018E40 RID: 101952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018E41 RID: 101953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018E42 RID: 101954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018E43 RID: 101955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018E44 RID: 101956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018E45 RID: 101957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018E46 RID: 101958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018E47 RID: 101959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018E48 RID: 101960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018E49 RID: 101961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018E4A RID: 101962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018E4B RID: 101963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018E4C RID: 101964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018E4D RID: 101965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018E4E RID: 101966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018E4F RID: 101967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018E50 RID: 101968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018E51 RID: 101969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018E52 RID: 101970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018E53 RID: 101971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018E54 RID: 101972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018E55 RID: 101973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018E56 RID: 101974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018E57 RID: 101975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
