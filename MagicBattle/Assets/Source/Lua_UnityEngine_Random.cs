using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001766 RID: 5990
[Preserve]
public class Lua_UnityEngine_Random : LuaObject
{
	// Token: 0x0602392A RID: 145706 RVA: 0x00C6CF68 File Offset: 0x00C6B168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Random o = new UnityEngine.Random();
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

	// Token: 0x0602392B RID: 145707 RVA: 0x00C6CFB0 File Offset: 0x00C6B1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitState_s(IntPtr l)
	{
		int result;
		try
		{
			int seed;
			LuaObject.checkType(l, 1, out seed);
			UnityEngine.Random.InitState(seed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602392C RID: 145708 RVA: 0x00C6CFFC File Offset: 0x00C6B1FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Range_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(int), typeof(int)))
			{
				int min;
				LuaObject.checkType(l, 1, out min);
				int max;
				LuaObject.checkType(l, 2, out max);
				int i = UnityEngine.Random.Range(min, max);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(float), typeof(float)))
			{
				float min2;
				LuaObject.checkType(l, 1, out min2);
				float max2;
				LuaObject.checkType(l, 2, out max2);
				float o = UnityEngine.Random.Range(min2, max2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Range to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602392D RID: 145709 RVA: 0x00C6D0F8 File Offset: 0x00C6B2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ColorHSV_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 0)
			{
				Color o = UnityEngine.Random.ColorHSV();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				float hueMin;
				LuaObject.checkType(l, 1, out hueMin);
				float hueMax;
				LuaObject.checkType(l, 2, out hueMax);
				Color o2 = UnityEngine.Random.ColorHSV(hueMin, hueMax);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 4)
			{
				float hueMin2;
				LuaObject.checkType(l, 1, out hueMin2);
				float hueMax2;
				LuaObject.checkType(l, 2, out hueMax2);
				float saturationMin;
				LuaObject.checkType(l, 3, out saturationMin);
				float saturationMax;
				LuaObject.checkType(l, 4, out saturationMax);
				Color o3 = UnityEngine.Random.ColorHSV(hueMin2, hueMax2, saturationMin, saturationMax);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else if (num == 6)
			{
				float hueMin3;
				LuaObject.checkType(l, 1, out hueMin3);
				float hueMax3;
				LuaObject.checkType(l, 2, out hueMax3);
				float saturationMin2;
				LuaObject.checkType(l, 3, out saturationMin2);
				float saturationMax2;
				LuaObject.checkType(l, 4, out saturationMax2);
				float valueMin;
				LuaObject.checkType(l, 5, out valueMin);
				float valueMax;
				LuaObject.checkType(l, 6, out valueMax);
				Color o4 = UnityEngine.Random.ColorHSV(hueMin3, hueMax3, saturationMin2, saturationMax2, valueMin, valueMax);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				result = 2;
			}
			else if (num == 8)
			{
				float hueMin4;
				LuaObject.checkType(l, 1, out hueMin4);
				float hueMax4;
				LuaObject.checkType(l, 2, out hueMax4);
				float saturationMin3;
				LuaObject.checkType(l, 3, out saturationMin3);
				float saturationMax3;
				LuaObject.checkType(l, 4, out saturationMax3);
				float valueMin2;
				LuaObject.checkType(l, 5, out valueMin2);
				float valueMax2;
				LuaObject.checkType(l, 6, out valueMax2);
				float alphaMin;
				LuaObject.checkType(l, 7, out alphaMin);
				float alphaMax;
				LuaObject.checkType(l, 8, out alphaMax);
				Color o5 = UnityEngine.Random.ColorHSV(hueMin4, hueMax4, saturationMin3, saturationMax3, valueMin2, valueMax2, alphaMin, alphaMax);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o5);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ColorHSV to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602392E RID: 145710 RVA: 0x00C6D2F4 File Offset: 0x00C6B4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_state(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UnityEngine.Random.state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602392F RID: 145711 RVA: 0x00C6D340 File Offset: 0x00C6B540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_state(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Random.State state;
			LuaObject.checkValueType<UnityEngine.Random.State>(l, 2, out state);
			UnityEngine.Random.state = state;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023930 RID: 145712 RVA: 0x00C6D38C File Offset: 0x00C6B58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_value(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UnityEngine.Random.value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023931 RID: 145713 RVA: 0x00C6D3D4 File Offset: 0x00C6B5D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_insideUnitSphere(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UnityEngine.Random.insideUnitSphere);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023932 RID: 145714 RVA: 0x00C6D41C File Offset: 0x00C6B61C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_insideUnitCircle(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UnityEngine.Random.insideUnitCircle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023933 RID: 145715 RVA: 0x00C6D464 File Offset: 0x00C6B664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_onUnitSphere(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UnityEngine.Random.onUnitSphere);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023934 RID: 145716 RVA: 0x00C6D4AC File Offset: 0x00C6B6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotation(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UnityEngine.Random.rotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023935 RID: 145717 RVA: 0x00C6D4F4 File Offset: 0x00C6B6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotationUniform(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UnityEngine.Random.rotationUniform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023936 RID: 145718 RVA: 0x00C6D53C File Offset: 0x00C6B73C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Random");
		if (Lua_UnityEngine_Random.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Random.InitState_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Random.<>f__mg$cache0);
		if (Lua_UnityEngine_Random.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Random.Range_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Random.<>f__mg$cache1);
		if (Lua_UnityEngine_Random.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Random.ColorHSV_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Random.<>f__mg$cache2);
		string name = "state";
		if (Lua_UnityEngine_Random.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Random.get_state);
		}
		LuaCSFunction get = Lua_UnityEngine_Random.<>f__mg$cache3;
		if (Lua_UnityEngine_Random.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Random.set_state);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Random.<>f__mg$cache4, false);
		string name2 = "value";
		if (Lua_UnityEngine_Random.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Random.get_value);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Random.<>f__mg$cache5, null, false);
		string name3 = "insideUnitSphere";
		if (Lua_UnityEngine_Random.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Random.get_insideUnitSphere);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Random.<>f__mg$cache6, null, false);
		string name4 = "insideUnitCircle";
		if (Lua_UnityEngine_Random.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Random.get_insideUnitCircle);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Random.<>f__mg$cache7, null, false);
		string name5 = "onUnitSphere";
		if (Lua_UnityEngine_Random.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Random.get_onUnitSphere);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Random.<>f__mg$cache8, null, false);
		string name6 = "rotation";
		if (Lua_UnityEngine_Random.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Random.get_rotation);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Random.<>f__mg$cache9, null, false);
		string name7 = "rotationUniform";
		if (Lua_UnityEngine_Random.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Random.get_rotationUniform);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Random.<>f__mg$cacheA, null, false);
		if (Lua_UnityEngine_Random.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Random.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Random.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Random.<>f__mg$cacheB, typeof(UnityEngine.Random));
	}

	// Token: 0x040196BC RID: 104124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040196BD RID: 104125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040196BE RID: 104126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040196BF RID: 104127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040196C0 RID: 104128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040196C1 RID: 104129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040196C2 RID: 104130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040196C3 RID: 104131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040196C4 RID: 104132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040196C5 RID: 104133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040196C6 RID: 104134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040196C7 RID: 104135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
