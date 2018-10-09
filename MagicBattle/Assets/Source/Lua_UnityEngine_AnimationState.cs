using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200161C RID: 5660
[Preserve]
public class Lua_UnityEngine_AnimationState : LuaObject
{
	// Token: 0x06022AB6 RID: 142006 RVA: 0x00BF4234 File Offset: 0x00BF2434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimationState o = new AnimationState();
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

	// Token: 0x06022AB7 RID: 142007 RVA: 0x00BF427C File Offset: 0x00BF247C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMixingTransform(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
				Transform mix;
				LuaObject.checkType<Transform>(l, 2, out mix);
				animationState.AddMixingTransform(mix);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				AnimationState animationState2 = (AnimationState)LuaObject.checkSelf(l);
				Transform mix2;
				LuaObject.checkType<Transform>(l, 2, out mix2);
				bool recursive;
				LuaObject.checkType(l, 3, out recursive);
				animationState2.AddMixingTransform(mix2, recursive);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddMixingTransform to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AB8 RID: 142008 RVA: 0x00BF4340 File Offset: 0x00BF2540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveMixingTransform(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			Transform mix;
			LuaObject.checkType<Transform>(l, 2, out mix);
			animationState.RemoveMixingTransform(mix);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AB9 RID: 142009 RVA: 0x00BF4398 File Offset: 0x00BF2598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationState.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ABA RID: 142010 RVA: 0x00BF43EC File Offset: 0x00BF25EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enabled(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			bool enabled;
			LuaObject.checkType(l, 2, out enabled);
			animationState.enabled = enabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ABB RID: 142011 RVA: 0x00BF4444 File Offset: 0x00BF2644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_weight(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationState.weight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ABC RID: 142012 RVA: 0x00BF4498 File Offset: 0x00BF2698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_weight(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			float weight;
			LuaObject.checkType(l, 2, out weight);
			animationState.weight = weight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ABD RID: 142013 RVA: 0x00BF44F0 File Offset: 0x00BF26F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_wrapMode(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animationState.wrapMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ABE RID: 142014 RVA: 0x00BF4544 File Offset: 0x00BF2744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_wrapMode(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			WrapMode wrapMode;
			LuaObject.checkEnum<WrapMode>(l, 2, out wrapMode);
			animationState.wrapMode = wrapMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ABF RID: 142015 RVA: 0x00BF459C File Offset: 0x00BF279C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_time(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationState.time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AC0 RID: 142016 RVA: 0x00BF45F0 File Offset: 0x00BF27F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_time(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			animationState.time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AC1 RID: 142017 RVA: 0x00BF4648 File Offset: 0x00BF2848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalizedTime(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationState.normalizedTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AC2 RID: 142018 RVA: 0x00BF469C File Offset: 0x00BF289C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_normalizedTime(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			float normalizedTime;
			LuaObject.checkType(l, 2, out normalizedTime);
			animationState.normalizedTime = normalizedTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AC3 RID: 142019 RVA: 0x00BF46F4 File Offset: 0x00BF28F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_speed(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationState.speed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AC4 RID: 142020 RVA: 0x00BF4748 File Offset: 0x00BF2948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_speed(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			float speed;
			LuaObject.checkType(l, 2, out speed);
			animationState.speed = speed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AC5 RID: 142021 RVA: 0x00BF47A0 File Offset: 0x00BF29A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normalizedSpeed(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationState.normalizedSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AC6 RID: 142022 RVA: 0x00BF47F4 File Offset: 0x00BF29F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_normalizedSpeed(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			float normalizedSpeed;
			LuaObject.checkType(l, 2, out normalizedSpeed);
			animationState.normalizedSpeed = normalizedSpeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AC7 RID: 142023 RVA: 0x00BF484C File Offset: 0x00BF2A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_length(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationState.length);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AC8 RID: 142024 RVA: 0x00BF48A0 File Offset: 0x00BF2AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layer(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationState.layer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AC9 RID: 142025 RVA: 0x00BF48F4 File Offset: 0x00BF2AF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_layer(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			int layer;
			LuaObject.checkType(l, 2, out layer);
			animationState.layer = layer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ACA RID: 142026 RVA: 0x00BF494C File Offset: 0x00BF2B4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_clip(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationState.clip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ACB RID: 142027 RVA: 0x00BF49A0 File Offset: 0x00BF2BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_name(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationState.name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ACC RID: 142028 RVA: 0x00BF49F4 File Offset: 0x00BF2BF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_name(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			animationState.name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ACD RID: 142029 RVA: 0x00BF4A4C File Offset: 0x00BF2C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_blendMode(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animationState.blendMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ACE RID: 142030 RVA: 0x00BF4AA0 File Offset: 0x00BF2CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_blendMode(IntPtr l)
	{
		int result;
		try
		{
			AnimationState animationState = (AnimationState)LuaObject.checkSelf(l);
			AnimationBlendMode blendMode;
			LuaObject.checkEnum<AnimationBlendMode>(l, 2, out blendMode);
			animationState.blendMode = blendMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ACF RID: 142031 RVA: 0x00BF4AF8 File Offset: 0x00BF2CF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AnimationState");
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AnimationState.AddMixingTransform);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationState.<>f__mg$cache0);
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AnimationState.RemoveMixingTransform);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationState.<>f__mg$cache1);
		string name = "enabled";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_enabled);
		}
		LuaCSFunction get = Lua_UnityEngine_AnimationState.<>f__mg$cache2;
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AnimationState.set_enabled);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_AnimationState.<>f__mg$cache3, true);
		string name2 = "weight";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_weight);
		}
		LuaCSFunction get2 = Lua_UnityEngine_AnimationState.<>f__mg$cache4;
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AnimationState.set_weight);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_AnimationState.<>f__mg$cache5, true);
		string name3 = "wrapMode";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_wrapMode);
		}
		LuaCSFunction get3 = Lua_UnityEngine_AnimationState.<>f__mg$cache6;
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_AnimationState.set_wrapMode);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_AnimationState.<>f__mg$cache7, true);
		string name4 = "time";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_time);
		}
		LuaCSFunction get4 = Lua_UnityEngine_AnimationState.<>f__mg$cache8;
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_AnimationState.set_time);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_AnimationState.<>f__mg$cache9, true);
		string name5 = "normalizedTime";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_normalizedTime);
		}
		LuaCSFunction get5 = Lua_UnityEngine_AnimationState.<>f__mg$cacheA;
		if (Lua_UnityEngine_AnimationState.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_AnimationState.set_normalizedTime);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_AnimationState.<>f__mg$cacheB, true);
		string name6 = "speed";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_speed);
		}
		LuaCSFunction get6 = Lua_UnityEngine_AnimationState.<>f__mg$cacheC;
		if (Lua_UnityEngine_AnimationState.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_AnimationState.set_speed);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_AnimationState.<>f__mg$cacheD, true);
		string name7 = "normalizedSpeed";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_normalizedSpeed);
		}
		LuaCSFunction get7 = Lua_UnityEngine_AnimationState.<>f__mg$cacheE;
		if (Lua_UnityEngine_AnimationState.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_AnimationState.set_normalizedSpeed);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_AnimationState.<>f__mg$cacheF, true);
		string name8 = "length";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_length);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_AnimationState.<>f__mg$cache10, null, true);
		string name9 = "layer";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_layer);
		}
		LuaCSFunction get8 = Lua_UnityEngine_AnimationState.<>f__mg$cache11;
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_AnimationState.set_layer);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_AnimationState.<>f__mg$cache12, true);
		string name10 = "clip";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_clip);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_AnimationState.<>f__mg$cache13, null, true);
		string name11 = "name";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_name);
		}
		LuaCSFunction get9 = Lua_UnityEngine_AnimationState.<>f__mg$cache14;
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_AnimationState.set_name);
		}
		LuaObject.addMember(l, name11, get9, Lua_UnityEngine_AnimationState.<>f__mg$cache15, true);
		string name12 = "blendMode";
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_AnimationState.get_blendMode);
		}
		LuaCSFunction get10 = Lua_UnityEngine_AnimationState.<>f__mg$cache16;
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_AnimationState.set_blendMode);
		}
		LuaObject.addMember(l, name12, get10, Lua_UnityEngine_AnimationState.<>f__mg$cache17, true);
		if (Lua_UnityEngine_AnimationState.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_AnimationState.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_AnimationState.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AnimationState.<>f__mg$cache18, typeof(AnimationState), typeof(TrackedReference));
	}

	// Token: 0x04018ADC RID: 101084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018ADD RID: 101085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018ADE RID: 101086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018ADF RID: 101087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018AE0 RID: 101088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018AE1 RID: 101089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018AE2 RID: 101090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018AE3 RID: 101091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018AE4 RID: 101092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018AE5 RID: 101093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018AE6 RID: 101094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018AE7 RID: 101095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018AE8 RID: 101096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018AE9 RID: 101097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018AEA RID: 101098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018AEB RID: 101099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018AEC RID: 101100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018AED RID: 101101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018AEE RID: 101102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018AEF RID: 101103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018AF0 RID: 101104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018AF1 RID: 101105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018AF2 RID: 101106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018AF3 RID: 101107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018AF4 RID: 101108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
