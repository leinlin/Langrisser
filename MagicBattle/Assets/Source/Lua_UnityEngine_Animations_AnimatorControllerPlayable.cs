using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x0200161A RID: 5658
[Preserve]
public class Lua_UnityEngine_Animations_AnimatorControllerPlayable : LuaObject
{
	// Token: 0x06022A73 RID: 141939 RVA: 0x00BF06B8 File Offset: 0x00BEE8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable = default(AnimatorControllerPlayable);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorControllerPlayable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A74 RID: 141940 RVA: 0x00BF0708 File Offset: 0x00BEE908
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHandle(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			PlayableHandle handle = animatorControllerPlayable.GetHandle();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, handle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A75 RID: 141941 RVA: 0x00BF0760 File Offset: 0x00BEE960
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHandle(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			PlayableHandle handle;
			LuaObject.checkValueType<PlayableHandle>(l, 2, out handle);
			animatorControllerPlayable.SetHandle(handle);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, animatorControllerPlayable);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A76 RID: 141942 RVA: 0x00BF07C4 File Offset: 0x00BEE9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFloat(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				string name;
				LuaObject.checkType(l, 2, out name);
				float @float = animatorControllerPlayable.GetFloat(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @float);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				int id;
				LuaObject.checkType(l, 2, out id);
				float float2 = animatorControllerPlayable2.GetFloat(id);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, float2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetFloat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A77 RID: 141943 RVA: 0x00BF08AC File Offset: 0x00BEEAAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetFloat(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				int id;
				LuaObject.checkType(l, 2, out id);
				float value;
				LuaObject.checkType(l, 3, out value);
				animatorControllerPlayable.SetFloat(id, value);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				string name;
				LuaObject.checkType(l, 2, out name);
				float value2;
				LuaObject.checkType(l, 3, out value2);
				animatorControllerPlayable2.SetFloat(name, value2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetFloat to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A78 RID: 141944 RVA: 0x00BF09C8 File Offset: 0x00BEEBC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBool(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				string name;
				LuaObject.checkType(l, 2, out name);
				bool @bool = animatorControllerPlayable.GetBool(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @bool);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				int id;
				LuaObject.checkType(l, 2, out id);
				bool bool2 = animatorControllerPlayable2.GetBool(id);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, bool2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetBool to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A79 RID: 141945 RVA: 0x00BF0AB0 File Offset: 0x00BEECB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBool(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(bool)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				int id;
				LuaObject.checkType(l, 2, out id);
				bool value;
				LuaObject.checkType(l, 3, out value);
				animatorControllerPlayable.SetBool(id, value);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(bool)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				string name;
				LuaObject.checkType(l, 2, out name);
				bool value2;
				LuaObject.checkType(l, 3, out value2);
				animatorControllerPlayable2.SetBool(name, value2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetBool to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A7A RID: 141946 RVA: 0x00BF0BCC File Offset: 0x00BEEDCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInteger(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				string name;
				LuaObject.checkType(l, 2, out name);
				int integer = animatorControllerPlayable.GetInteger(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, integer);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				int id;
				LuaObject.checkType(l, 2, out id);
				int integer2 = animatorControllerPlayable2.GetInteger(id);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, integer2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetInteger to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A7B RID: 141947 RVA: 0x00BF0CB4 File Offset: 0x00BEEEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetInteger(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				int id;
				LuaObject.checkType(l, 2, out id);
				int value;
				LuaObject.checkType(l, 3, out value);
				animatorControllerPlayable.SetInteger(id, value);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				string name;
				LuaObject.checkType(l, 2, out name);
				int value2;
				LuaObject.checkType(l, 3, out value2);
				animatorControllerPlayable2.SetInteger(name, value2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetInteger to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A7C RID: 141948 RVA: 0x00BF0DD0 File Offset: 0x00BEEFD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTrigger(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				string trigger;
				LuaObject.checkType(l, 2, out trigger);
				animatorControllerPlayable.SetTrigger(trigger);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				int trigger2;
				LuaObject.checkType(l, 2, out trigger2);
				animatorControllerPlayable2.SetTrigger(trigger2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetTrigger to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A7D RID: 141949 RVA: 0x00BF0EBC File Offset: 0x00BEF0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetTrigger(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				string name;
				LuaObject.checkType(l, 2, out name);
				animatorControllerPlayable.ResetTrigger(name);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				int id;
				LuaObject.checkType(l, 2, out id);
				animatorControllerPlayable2.ResetTrigger(id);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ResetTrigger to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A7E RID: 141950 RVA: 0x00BF0FA8 File Offset: 0x00BEF1A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsParameterControlledByCurve(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				string name;
				LuaObject.checkType(l, 2, out name);
				bool b = animatorControllerPlayable.IsParameterControlledByCurve(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				int id;
				LuaObject.checkType(l, 2, out id);
				bool b2 = animatorControllerPlayable2.IsParameterControlledByCurve(id);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsParameterControlledByCurve to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A7F RID: 141951 RVA: 0x00BF1090 File Offset: 0x00BEF290
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLayerCount(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int layerCount = animatorControllerPlayable.GetLayerCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A80 RID: 141952 RVA: 0x00BF10E4 File Offset: 0x00BEF2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerName(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			string layerName = animatorControllerPlayable.GetLayerName(layerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A81 RID: 141953 RVA: 0x00BF1144 File Offset: 0x00BEF344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			string layerName;
			LuaObject.checkType(l, 2, out layerName);
			int layerIndex = animatorControllerPlayable.GetLayerIndex(layerName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A82 RID: 141954 RVA: 0x00BF11A4 File Offset: 0x00BEF3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerWeight(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			float layerWeight = animatorControllerPlayable.GetLayerWeight(layerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A83 RID: 141955 RVA: 0x00BF1204 File Offset: 0x00BEF404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayerWeight(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			float weight;
			LuaObject.checkType(l, 3, out weight);
			animatorControllerPlayable.SetLayerWeight(layerIndex, weight);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, animatorControllerPlayable);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A84 RID: 141956 RVA: 0x00BF1274 File Offset: 0x00BEF474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentAnimatorStateInfo(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			AnimatorStateInfo currentAnimatorStateInfo = animatorControllerPlayable.GetCurrentAnimatorStateInfo(layerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentAnimatorStateInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A85 RID: 141957 RVA: 0x00BF12DC File Offset: 0x00BEF4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNextAnimatorStateInfo(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			AnimatorStateInfo nextAnimatorStateInfo = animatorControllerPlayable.GetNextAnimatorStateInfo(layerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextAnimatorStateInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A86 RID: 141958 RVA: 0x00BF1344 File Offset: 0x00BEF544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnimatorTransitionInfo(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			AnimatorTransitionInfo animatorTransitionInfo = animatorControllerPlayable.GetAnimatorTransitionInfo(layerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorTransitionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A87 RID: 141959 RVA: 0x00BF13AC File Offset: 0x00BEF5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentAnimatorClipInfo(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				int layerIndex;
				LuaObject.checkType(l, 2, out layerIndex);
				AnimatorClipInfo[] currentAnimatorClipInfo = animatorControllerPlayable.GetCurrentAnimatorClipInfo(layerIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, currentAnimatorClipInfo);
				result = 2;
			}
			else if (num == 3)
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				int layerIndex2;
				LuaObject.checkType(l, 2, out layerIndex2);
				List<AnimatorClipInfo> clips;
				LuaObject.checkType<List<AnimatorClipInfo>>(l, 3, out clips);
				animatorControllerPlayable2.GetCurrentAnimatorClipInfo(layerIndex2, clips);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetCurrentAnimatorClipInfo to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A88 RID: 141960 RVA: 0x00BF1484 File Offset: 0x00BEF684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNextAnimatorClipInfo(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				int layerIndex;
				LuaObject.checkType(l, 2, out layerIndex);
				AnimatorClipInfo[] nextAnimatorClipInfo = animatorControllerPlayable.GetNextAnimatorClipInfo(layerIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, nextAnimatorClipInfo);
				result = 2;
			}
			else if (num == 3)
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				int layerIndex2;
				LuaObject.checkType(l, 2, out layerIndex2);
				List<AnimatorClipInfo> clips;
				LuaObject.checkType<List<AnimatorClipInfo>>(l, 3, out clips);
				animatorControllerPlayable2.GetNextAnimatorClipInfo(layerIndex2, clips);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetNextAnimatorClipInfo to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A89 RID: 141961 RVA: 0x00BF155C File Offset: 0x00BEF75C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCurrentAnimatorClipInfoCount(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			int currentAnimatorClipInfoCount = animatorControllerPlayable.GetCurrentAnimatorClipInfoCount(layerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentAnimatorClipInfoCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A8A RID: 141962 RVA: 0x00BF15BC File Offset: 0x00BEF7BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNextAnimatorClipInfoCount(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			int nextAnimatorClipInfoCount = animatorControllerPlayable.GetNextAnimatorClipInfoCount(layerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nextAnimatorClipInfoCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A8B RID: 141963 RVA: 0x00BF161C File Offset: 0x00BEF81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInTransition(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			bool b = animatorControllerPlayable.IsInTransition(layerIndex);
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

	// Token: 0x06022A8C RID: 141964 RVA: 0x00BF167C File Offset: 0x00BEF87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetParameterCount(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int parameterCount = animatorControllerPlayable.GetParameterCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, parameterCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A8D RID: 141965 RVA: 0x00BF16D0 File Offset: 0x00BEF8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetParameter(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int index;
			LuaObject.checkType(l, 2, out index);
			AnimatorControllerParameter parameter = animatorControllerPlayable.GetParameter(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, parameter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A8E RID: 141966 RVA: 0x00BF1730 File Offset: 0x00BEF930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrossFadeInFixedTime(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				int stateNameHash;
				LuaObject.checkType(l, 2, out stateNameHash);
				float transitionDuration;
				LuaObject.checkType(l, 3, out transitionDuration);
				animatorControllerPlayable.CrossFadeInFixedTime(stateNameHash, transitionDuration);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				float transitionDuration2;
				LuaObject.checkType(l, 3, out transitionDuration2);
				animatorControllerPlayable2.CrossFadeInFixedTime(stateName, transitionDuration2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable2);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable3;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable3);
				int stateNameHash2;
				LuaObject.checkType(l, 2, out stateNameHash2);
				float transitionDuration3;
				LuaObject.checkType(l, 3, out transitionDuration3);
				int layer;
				LuaObject.checkType(l, 4, out layer);
				animatorControllerPlayable3.CrossFadeInFixedTime(stateNameHash2, transitionDuration3, layer);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable3);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable4;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable4);
				string stateName2;
				LuaObject.checkType(l, 2, out stateName2);
				float transitionDuration4;
				LuaObject.checkType(l, 3, out transitionDuration4);
				int layer2;
				LuaObject.checkType(l, 4, out layer2);
				animatorControllerPlayable4.CrossFadeInFixedTime(stateName2, transitionDuration4, layer2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable4);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable5;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable5);
				int stateNameHash3;
				LuaObject.checkType(l, 2, out stateNameHash3);
				float transitionDuration5;
				LuaObject.checkType(l, 3, out transitionDuration5);
				int layer3;
				LuaObject.checkType(l, 4, out layer3);
				float fixedTime;
				LuaObject.checkType(l, 5, out fixedTime);
				animatorControllerPlayable5.CrossFadeInFixedTime(stateNameHash3, transitionDuration5, layer3, fixedTime);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable5);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable6;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable6);
				string stateName3;
				LuaObject.checkType(l, 2, out stateName3);
				float transitionDuration6;
				LuaObject.checkType(l, 3, out transitionDuration6);
				int layer4;
				LuaObject.checkType(l, 4, out layer4);
				float fixedTime2;
				LuaObject.checkType(l, 5, out fixedTime2);
				animatorControllerPlayable6.CrossFadeInFixedTime(stateName3, transitionDuration6, layer4, fixedTime2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable6);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CrossFadeInFixedTime to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A8F RID: 141967 RVA: 0x00BF1A74 File Offset: 0x00BEFC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrossFade(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				int stateNameHash;
				LuaObject.checkType(l, 2, out stateNameHash);
				float transitionDuration;
				LuaObject.checkType(l, 3, out transitionDuration);
				animatorControllerPlayable.CrossFade(stateNameHash, transitionDuration);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				float transitionDuration2;
				LuaObject.checkType(l, 3, out transitionDuration2);
				animatorControllerPlayable2.CrossFade(stateName, transitionDuration2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable2);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable3;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable3);
				int stateNameHash2;
				LuaObject.checkType(l, 2, out stateNameHash2);
				float transitionDuration3;
				LuaObject.checkType(l, 3, out transitionDuration3);
				int layer;
				LuaObject.checkType(l, 4, out layer);
				animatorControllerPlayable3.CrossFade(stateNameHash2, transitionDuration3, layer);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable3);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable4;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable4);
				string stateName2;
				LuaObject.checkType(l, 2, out stateName2);
				float transitionDuration4;
				LuaObject.checkType(l, 3, out transitionDuration4);
				int layer2;
				LuaObject.checkType(l, 4, out layer2);
				animatorControllerPlayable4.CrossFade(stateName2, transitionDuration4, layer2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable4);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable5;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable5);
				int stateNameHash3;
				LuaObject.checkType(l, 2, out stateNameHash3);
				float transitionDuration5;
				LuaObject.checkType(l, 3, out transitionDuration5);
				int layer3;
				LuaObject.checkType(l, 4, out layer3);
				float normalizedTime;
				LuaObject.checkType(l, 5, out normalizedTime);
				animatorControllerPlayable5.CrossFade(stateNameHash3, transitionDuration5, layer3, normalizedTime);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable5);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable6;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable6);
				string stateName3;
				LuaObject.checkType(l, 2, out stateName3);
				float transitionDuration6;
				LuaObject.checkType(l, 3, out transitionDuration6);
				int layer4;
				LuaObject.checkType(l, 4, out layer4);
				float normalizedTime2;
				LuaObject.checkType(l, 5, out normalizedTime2);
				animatorControllerPlayable6.CrossFade(stateName3, transitionDuration6, layer4, normalizedTime2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable6);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CrossFade to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A90 RID: 141968 RVA: 0x00BF1DB8 File Offset: 0x00BEFFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayInFixedTime(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				animatorControllerPlayable.PlayInFixedTime(stateName);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				int stateNameHash;
				LuaObject.checkType(l, 2, out stateNameHash);
				animatorControllerPlayable2.PlayInFixedTime(stateNameHash);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable2);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable3;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable3);
				int stateNameHash2;
				LuaObject.checkType(l, 2, out stateNameHash2);
				int layer;
				LuaObject.checkType(l, 3, out layer);
				animatorControllerPlayable3.PlayInFixedTime(stateNameHash2, layer);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable3);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable4;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable4);
				string stateName2;
				LuaObject.checkType(l, 2, out stateName2);
				int layer2;
				LuaObject.checkType(l, 3, out layer2);
				animatorControllerPlayable4.PlayInFixedTime(stateName2, layer2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable4);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable5;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable5);
				int stateNameHash3;
				LuaObject.checkType(l, 2, out stateNameHash3);
				int layer3;
				LuaObject.checkType(l, 3, out layer3);
				float fixedTime;
				LuaObject.checkType(l, 4, out fixedTime);
				animatorControllerPlayable5.PlayInFixedTime(stateNameHash3, layer3, fixedTime);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable5);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable6;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable6);
				string stateName3;
				LuaObject.checkType(l, 2, out stateName3);
				int layer4;
				LuaObject.checkType(l, 3, out layer4);
				float fixedTime2;
				LuaObject.checkType(l, 4, out fixedTime2);
				animatorControllerPlayable6.PlayInFixedTime(stateName3, layer4, fixedTime2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable6);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PlayInFixedTime to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A91 RID: 141969 RVA: 0x00BF2070 File Offset: 0x00BF0270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Play(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				AnimatorControllerPlayable animatorControllerPlayable;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				animatorControllerPlayable.Play(stateName);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable2;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable2);
				int stateNameHash;
				LuaObject.checkType(l, 2, out stateNameHash);
				animatorControllerPlayable2.Play(stateNameHash);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable2);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable3;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable3);
				int stateNameHash2;
				LuaObject.checkType(l, 2, out stateNameHash2);
				int layer;
				LuaObject.checkType(l, 3, out layer);
				animatorControllerPlayable3.Play(stateNameHash2, layer);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable3);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int)))
			{
				AnimatorControllerPlayable animatorControllerPlayable4;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable4);
				string stateName2;
				LuaObject.checkType(l, 2, out stateName2);
				int layer2;
				LuaObject.checkType(l, 3, out layer2);
				animatorControllerPlayable4.Play(stateName2, layer2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable4);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable5;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable5);
				int stateNameHash3;
				LuaObject.checkType(l, 2, out stateNameHash3);
				int layer3;
				LuaObject.checkType(l, 3, out layer3);
				float normalizedTime;
				LuaObject.checkType(l, 4, out normalizedTime);
				animatorControllerPlayable5.Play(stateNameHash3, layer3, normalizedTime);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable5);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int), typeof(float)))
			{
				AnimatorControllerPlayable animatorControllerPlayable6;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable6);
				string stateName3;
				LuaObject.checkType(l, 2, out stateName3);
				int layer4;
				LuaObject.checkType(l, 3, out layer4);
				float normalizedTime2;
				LuaObject.checkType(l, 4, out normalizedTime2);
				animatorControllerPlayable6.Play(stateName3, layer4, normalizedTime2);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, animatorControllerPlayable6);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Play to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A92 RID: 141970 RVA: 0x00BF2328 File Offset: 0x00BF0528
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasState(IntPtr l)
	{
		int result;
		try
		{
			AnimatorControllerPlayable animatorControllerPlayable;
			LuaObject.checkValueType<AnimatorControllerPlayable>(l, 1, out animatorControllerPlayable);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			int stateID;
			LuaObject.checkType(l, 3, out stateID);
			bool b = animatorControllerPlayable.HasState(layerIndex, stateID);
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

	// Token: 0x06022A93 RID: 141971 RVA: 0x00BF2398 File Offset: 0x00BF0598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Create_s(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph graph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out graph);
			RuntimeAnimatorController controller;
			LuaObject.checkType<RuntimeAnimatorController>(l, 2, out controller);
			AnimatorControllerPlayable animatorControllerPlayable = AnimatorControllerPlayable.Create(graph, controller);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorControllerPlayable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A94 RID: 141972 RVA: 0x00BF23FC File Offset: 0x00BF05FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Null(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AnimatorControllerPlayable.Null);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A95 RID: 141973 RVA: 0x00BF2448 File Offset: 0x00BF0648
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Animations.AnimatorControllerPlayable");
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetHandle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache0);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.SetHandle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache2);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.SetFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache3);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetBool);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache4);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.SetBool);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache5);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetInteger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache6);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.SetInteger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache7);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.SetTrigger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache8);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.ResetTrigger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache9);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.IsParameterControlledByCurve);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheA);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetLayerCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheB);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetLayerName);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheC);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetLayerIndex);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheD);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetLayerWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheE);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.SetLayerWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cacheF);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetCurrentAnimatorStateInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache10);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetNextAnimatorStateInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache11);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetAnimatorTransitionInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache12);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetCurrentAnimatorClipInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache13);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetNextAnimatorClipInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache14);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetCurrentAnimatorClipInfoCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache15);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetNextAnimatorClipInfoCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache16);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.IsInTransition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache17);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetParameterCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache18);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.GetParameter);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache19);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.CrossFadeInFixedTime);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1A);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.CrossFade);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1B);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.PlayInFixedTime);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1C);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.Play);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1D);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.HasState);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1E);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.Create_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache1F);
		string name = "Null";
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.get_Null);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache20, null, false);
		if (Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimatorControllerPlayable.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Animations_AnimatorControllerPlayable.<>f__mg$cache21, typeof(AnimatorControllerPlayable), typeof(ValueType));
	}

	// Token: 0x04018A9D RID: 101021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018A9E RID: 101022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018A9F RID: 101023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018AA0 RID: 101024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018AA1 RID: 101025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018AA2 RID: 101026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018AA3 RID: 101027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018AA4 RID: 101028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018AA5 RID: 101029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018AA6 RID: 101030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018AA7 RID: 101031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018AA8 RID: 101032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018AA9 RID: 101033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018AAA RID: 101034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018AAB RID: 101035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018AAC RID: 101036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018AAD RID: 101037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018AAE RID: 101038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018AAF RID: 101039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018AB0 RID: 101040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018AB1 RID: 101041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018AB2 RID: 101042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018AB3 RID: 101043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018AB4 RID: 101044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018AB5 RID: 101045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018AB6 RID: 101046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018AB7 RID: 101047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018AB8 RID: 101048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018AB9 RID: 101049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018ABA RID: 101050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018ABB RID: 101051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018ABC RID: 101052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018ABD RID: 101053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018ABE RID: 101054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;
}
