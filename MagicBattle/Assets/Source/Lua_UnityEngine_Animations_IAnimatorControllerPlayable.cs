using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Scripting;

// Token: 0x0200161B RID: 5659
[Preserve]
public class Lua_UnityEngine_Animations_IAnimatorControllerPlayable : LuaObject
{
	// Token: 0x06022A97 RID: 141975 RVA: 0x00BF292C File Offset: 0x00BF0B2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetFloat(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float @float = animatorControllerPlayable.GetFloat(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @float);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022A98 RID: 141976 RVA: 0x00BF2A18 File Offset: 0x00BF0C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFloat(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				float value;
				LuaObject.checkType(l, 3, out value);
				animatorControllerPlayable.SetFloat(id, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float value2;
				LuaObject.checkType(l, 3, out value2);
				animatorControllerPlayable2.SetFloat(name, value2);
				LuaObject.pushValue(l, true);
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

	// Token: 0x06022A99 RID: 141977 RVA: 0x00BF2B20 File Offset: 0x00BF0D20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBool(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				bool @bool = animatorControllerPlayable.GetBool(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @bool);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022A9A RID: 141978 RVA: 0x00BF2C0C File Offset: 0x00BF0E0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetBool(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(bool)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				bool value;
				LuaObject.checkType(l, 3, out value);
				animatorControllerPlayable.SetBool(id, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(bool)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				bool value2;
				LuaObject.checkType(l, 3, out value2);
				animatorControllerPlayable2.SetBool(name, value2);
				LuaObject.pushValue(l, true);
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

	// Token: 0x06022A9B RID: 141979 RVA: 0x00BF2D14 File Offset: 0x00BF0F14
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
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				int integer = animatorControllerPlayable.GetInteger(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, integer);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022A9C RID: 141980 RVA: 0x00BF2E00 File Offset: 0x00BF1000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetInteger(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				int value;
				LuaObject.checkType(l, 3, out value);
				animatorControllerPlayable.SetInteger(id, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				int value2;
				LuaObject.checkType(l, 3, out value2);
				animatorControllerPlayable2.SetInteger(name, value2);
				LuaObject.pushValue(l, true);
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

	// Token: 0x06022A9D RID: 141981 RVA: 0x00BF2F08 File Offset: 0x00BF1108
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
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string trigger;
				LuaObject.checkType(l, 2, out trigger);
				animatorControllerPlayable.SetTrigger(trigger);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int trigger2;
				LuaObject.checkType(l, 2, out trigger2);
				animatorControllerPlayable2.SetTrigger(trigger2);
				LuaObject.pushValue(l, true);
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

	// Token: 0x06022A9E RID: 141982 RVA: 0x00BF2FE0 File Offset: 0x00BF11E0
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
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				animatorControllerPlayable.ResetTrigger(name);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				animatorControllerPlayable2.ResetTrigger(id);
				LuaObject.pushValue(l, true);
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

	// Token: 0x06022A9F RID: 141983 RVA: 0x00BF30B8 File Offset: 0x00BF12B8
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
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				bool b = animatorControllerPlayable.IsParameterControlledByCurve(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AA0 RID: 141984 RVA: 0x00BF31A4 File Offset: 0x00BF13A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerCount(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AA1 RID: 141985 RVA: 0x00BF31F8 File Offset: 0x00BF13F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerName(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AA2 RID: 141986 RVA: 0x00BF325C File Offset: 0x00BF145C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AA3 RID: 141987 RVA: 0x00BF32C0 File Offset: 0x00BF14C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerWeight(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AA4 RID: 141988 RVA: 0x00BF3324 File Offset: 0x00BF1524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayerWeight(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			float weight;
			LuaObject.checkType(l, 3, out weight);
			animatorControllerPlayable.SetLayerWeight(layerIndex, weight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AA5 RID: 141989 RVA: 0x00BF3388 File Offset: 0x00BF1588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentAnimatorStateInfo(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AA6 RID: 141990 RVA: 0x00BF33F0 File Offset: 0x00BF15F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNextAnimatorStateInfo(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AA7 RID: 141991 RVA: 0x00BF3458 File Offset: 0x00BF1658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnimatorTransitionInfo(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AA8 RID: 141992 RVA: 0x00BF34C0 File Offset: 0x00BF16C0
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
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int layerIndex;
				LuaObject.checkType(l, 2, out layerIndex);
				AnimatorClipInfo[] currentAnimatorClipInfo = animatorControllerPlayable.GetCurrentAnimatorClipInfo(layerIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, currentAnimatorClipInfo);
				result = 2;
			}
			else if (num == 3)
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int layerIndex2;
				LuaObject.checkType(l, 2, out layerIndex2);
				List<AnimatorClipInfo> clips;
				LuaObject.checkType<List<AnimatorClipInfo>>(l, 3, out clips);
				animatorControllerPlayable2.GetCurrentAnimatorClipInfo(layerIndex2, clips);
				LuaObject.pushValue(l, true);
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

	// Token: 0x06022AA9 RID: 141993 RVA: 0x00BF3590 File Offset: 0x00BF1790
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
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int layerIndex;
				LuaObject.checkType(l, 2, out layerIndex);
				AnimatorClipInfo[] nextAnimatorClipInfo = animatorControllerPlayable.GetNextAnimatorClipInfo(layerIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, nextAnimatorClipInfo);
				result = 2;
			}
			else if (num == 3)
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int layerIndex2;
				LuaObject.checkType(l, 2, out layerIndex2);
				List<AnimatorClipInfo> clips;
				LuaObject.checkType<List<AnimatorClipInfo>>(l, 3, out clips);
				animatorControllerPlayable2.GetNextAnimatorClipInfo(layerIndex2, clips);
				LuaObject.pushValue(l, true);
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

	// Token: 0x06022AAA RID: 141994 RVA: 0x00BF3660 File Offset: 0x00BF1860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentAnimatorClipInfoCount(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AAB RID: 141995 RVA: 0x00BF36C4 File Offset: 0x00BF18C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNextAnimatorClipInfoCount(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AAC RID: 141996 RVA: 0x00BF3728 File Offset: 0x00BF1928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInTransition(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AAD RID: 141997 RVA: 0x00BF378C File Offset: 0x00BF198C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetParameterCount(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AAE RID: 141998 RVA: 0x00BF37E0 File Offset: 0x00BF19E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetParameter(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AAF RID: 141999 RVA: 0x00BF3844 File Offset: 0x00BF1A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrossFadeInFixedTime(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int), typeof(float)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int stateNameHash;
				LuaObject.checkType(l, 2, out stateNameHash);
				float transitionDuration;
				LuaObject.checkType(l, 3, out transitionDuration);
				int layer;
				LuaObject.checkType(l, 4, out layer);
				float fixedTime;
				LuaObject.checkType(l, 5, out fixedTime);
				animatorControllerPlayable.CrossFadeInFixedTime(stateNameHash, transitionDuration, layer, fixedTime);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int), typeof(float)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				float transitionDuration2;
				LuaObject.checkType(l, 3, out transitionDuration2);
				int layer2;
				LuaObject.checkType(l, 4, out layer2);
				float fixedTime2;
				LuaObject.checkType(l, 5, out fixedTime2);
				animatorControllerPlayable2.CrossFadeInFixedTime(stateName, transitionDuration2, layer2, fixedTime2);
				LuaObject.pushValue(l, true);
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

	// Token: 0x06022AB0 RID: 142000 RVA: 0x00BF39B0 File Offset: 0x00BF1BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrossFade(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int), typeof(float)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int stateNameHash;
				LuaObject.checkType(l, 2, out stateNameHash);
				float transitionDuration;
				LuaObject.checkType(l, 3, out transitionDuration);
				int layer;
				LuaObject.checkType(l, 4, out layer);
				float normalizedTime;
				LuaObject.checkType(l, 5, out normalizedTime);
				animatorControllerPlayable.CrossFade(stateNameHash, transitionDuration, layer, normalizedTime);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int), typeof(float)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				float transitionDuration2;
				LuaObject.checkType(l, 3, out transitionDuration2);
				int layer2;
				LuaObject.checkType(l, 4, out layer2);
				float normalizedTime2;
				LuaObject.checkType(l, 5, out normalizedTime2);
				animatorControllerPlayable2.CrossFade(stateName, transitionDuration2, layer2, normalizedTime2);
				LuaObject.pushValue(l, true);
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

	// Token: 0x06022AB1 RID: 142001 RVA: 0x00BF3B1C File Offset: 0x00BF1D1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayInFixedTime(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int), typeof(float)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int stateNameHash;
				LuaObject.checkType(l, 2, out stateNameHash);
				int layer;
				LuaObject.checkType(l, 3, out layer);
				float fixedTime;
				LuaObject.checkType(l, 4, out fixedTime);
				animatorControllerPlayable.PlayInFixedTime(stateNameHash, layer, fixedTime);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int), typeof(float)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				int layer2;
				LuaObject.checkType(l, 3, out layer2);
				float fixedTime2;
				LuaObject.checkType(l, 4, out fixedTime2);
				animatorControllerPlayable2.PlayInFixedTime(stateName, layer2, fixedTime2);
				LuaObject.pushValue(l, true);
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

	// Token: 0x06022AB2 RID: 142002 RVA: 0x00BF3C5C File Offset: 0x00BF1E5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Play(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int), typeof(float)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				int stateNameHash;
				LuaObject.checkType(l, 2, out stateNameHash);
				int layer;
				LuaObject.checkType(l, 3, out layer);
				float normalizedTime;
				LuaObject.checkType(l, 4, out normalizedTime);
				animatorControllerPlayable.Play(stateNameHash, layer, normalizedTime);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int), typeof(float)))
			{
				IAnimatorControllerPlayable animatorControllerPlayable2 = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				int layer2;
				LuaObject.checkType(l, 3, out layer2);
				float normalizedTime2;
				LuaObject.checkType(l, 4, out normalizedTime2);
				animatorControllerPlayable2.Play(stateName, layer2, normalizedTime2);
				LuaObject.pushValue(l, true);
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

	// Token: 0x06022AB3 RID: 142003 RVA: 0x00BF3D9C File Offset: 0x00BF1F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasState(IntPtr l)
	{
		int result;
		try
		{
			IAnimatorControllerPlayable animatorControllerPlayable = (IAnimatorControllerPlayable)LuaObject.checkSelf(l);
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

	// Token: 0x06022AB4 RID: 142004 RVA: 0x00BF3E0C File Offset: 0x00BF200C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Animations.IAnimatorControllerPlayable");
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache0);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.SetFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetBool);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache2);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.SetBool);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache3);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetInteger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache4);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.SetInteger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache5);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.SetTrigger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache6);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.ResetTrigger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache7);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.IsParameterControlledByCurve);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache8);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetLayerCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache9);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetLayerName);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheA);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetLayerIndex);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheB);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetLayerWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheC);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.SetLayerWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheD);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetCurrentAnimatorStateInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheE);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetNextAnimatorStateInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cacheF);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetAnimatorTransitionInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache10);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetCurrentAnimatorClipInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache11);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetNextAnimatorClipInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache12);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetCurrentAnimatorClipInfoCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache13);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetNextAnimatorClipInfoCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache14);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.IsInTransition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache15);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetParameterCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache16);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.GetParameter);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache17);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.CrossFadeInFixedTime);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache18);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.CrossFade);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache19);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.PlayInFixedTime);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1A);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.Play);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1B);
		if (Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Animations_IAnimatorControllerPlayable.HasState);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_IAnimatorControllerPlayable.<>f__mg$cache1C);
		LuaObject.createTypeMetatable(l, null, typeof(IAnimatorControllerPlayable));
	}

	// Token: 0x04018ABF RID: 101055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018AC0 RID: 101056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018AC1 RID: 101057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018AC2 RID: 101058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018AC3 RID: 101059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018AC4 RID: 101060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018AC5 RID: 101061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018AC6 RID: 101062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018AC7 RID: 101063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018AC8 RID: 101064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018AC9 RID: 101065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018ACA RID: 101066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018ACB RID: 101067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018ACC RID: 101068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018ACD RID: 101069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018ACE RID: 101070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018ACF RID: 101071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018AD0 RID: 101072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018AD1 RID: 101073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018AD2 RID: 101074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018AD3 RID: 101075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018AD4 RID: 101076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018AD5 RID: 101077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018AD6 RID: 101078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018AD7 RID: 101079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018AD8 RID: 101080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018AD9 RID: 101081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018ADA RID: 101082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018ADB RID: 101083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
