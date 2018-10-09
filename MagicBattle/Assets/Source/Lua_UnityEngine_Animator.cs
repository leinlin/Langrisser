using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200161D RID: 5661
[Preserve]
public class Lua_UnityEngine_Animator : LuaObject
{
	// Token: 0x06022AD1 RID: 142033 RVA: 0x00BF4EA8 File Offset: 0x00BF30A8
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
				Animator animator = (Animator)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float @float = animator.GetFloat(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @float);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				float float2 = animator2.GetFloat(id);
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

	// Token: 0x06022AD2 RID: 142034 RVA: 0x00BF4F94 File Offset: 0x00BF3194
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
				Animator animator = (Animator)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				float value;
				LuaObject.checkType(l, 3, out value);
				animator.SetFloat(id, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				float value2;
				LuaObject.checkType(l, 3, out value2);
				animator2.SetFloat(name, value2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(float), typeof(float)))
			{
				Animator animator3 = (Animator)LuaObject.checkSelf(l);
				int id2;
				LuaObject.checkType(l, 2, out id2);
				float value3;
				LuaObject.checkType(l, 3, out value3);
				float dampTime;
				LuaObject.checkType(l, 4, out dampTime);
				float deltaTime;
				LuaObject.checkType(l, 5, out deltaTime);
				animator3.SetFloat(id2, value3, dampTime, deltaTime);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(float), typeof(float)))
			{
				Animator animator4 = (Animator)LuaObject.checkSelf(l);
				string name2;
				LuaObject.checkType(l, 2, out name2);
				float value4;
				LuaObject.checkType(l, 3, out value4);
				float dampTime2;
				LuaObject.checkType(l, 4, out dampTime2);
				float deltaTime2;
				LuaObject.checkType(l, 5, out deltaTime2);
				animator4.SetFloat(name2, value4, dampTime2, deltaTime2);
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

	// Token: 0x06022AD3 RID: 142035 RVA: 0x00BF51B8 File Offset: 0x00BF33B8
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
				Animator animator = (Animator)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				bool @bool = animator.GetBool(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, @bool);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				bool bool2 = animator2.GetBool(id);
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

	// Token: 0x06022AD4 RID: 142036 RVA: 0x00BF52A4 File Offset: 0x00BF34A4
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
				Animator animator = (Animator)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				bool value;
				LuaObject.checkType(l, 3, out value);
				animator.SetBool(id, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(bool)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				bool value2;
				LuaObject.checkType(l, 3, out value2);
				animator2.SetBool(name, value2);
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

	// Token: 0x06022AD5 RID: 142037 RVA: 0x00BF53AC File Offset: 0x00BF35AC
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
				Animator animator = (Animator)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				int integer = animator.GetInteger(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, integer);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				int integer2 = animator2.GetInteger(id);
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

	// Token: 0x06022AD6 RID: 142038 RVA: 0x00BF5498 File Offset: 0x00BF3698
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
				Animator animator = (Animator)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				int value;
				LuaObject.checkType(l, 3, out value);
				animator.SetInteger(id, value);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				int value2;
				LuaObject.checkType(l, 3, out value2);
				animator2.SetInteger(name, value2);
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

	// Token: 0x06022AD7 RID: 142039 RVA: 0x00BF55A0 File Offset: 0x00BF37A0
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
				Animator animator = (Animator)LuaObject.checkSelf(l);
				string trigger;
				LuaObject.checkType(l, 2, out trigger);
				animator.SetTrigger(trigger);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				int trigger2;
				LuaObject.checkType(l, 2, out trigger2);
				animator2.SetTrigger(trigger2);
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

	// Token: 0x06022AD8 RID: 142040 RVA: 0x00BF5678 File Offset: 0x00BF3878
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
				Animator animator = (Animator)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				animator.ResetTrigger(name);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				animator2.ResetTrigger(id);
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

	// Token: 0x06022AD9 RID: 142041 RVA: 0x00BF5750 File Offset: 0x00BF3950
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
				Animator animator = (Animator)LuaObject.checkSelf(l);
				string name;
				LuaObject.checkType(l, 2, out name);
				bool b = animator.IsParameterControlledByCurve(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				int id;
				LuaObject.checkType(l, 2, out id);
				bool b2 = animator2.IsParameterControlledByCurve(id);
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

	// Token: 0x06022ADA RID: 142042 RVA: 0x00BF583C File Offset: 0x00BF3A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIKPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKGoal goal;
			LuaObject.checkEnum<AvatarIKGoal>(l, 2, out goal);
			Vector3 ikposition = animator.GetIKPosition(goal);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ikposition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ADB RID: 142043 RVA: 0x00BF58A0 File Offset: 0x00BF3AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIKPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKGoal goal;
			LuaObject.checkEnum<AvatarIKGoal>(l, 2, out goal);
			Vector3 goalPosition;
			LuaObject.checkType(l, 3, out goalPosition);
			animator.SetIKPosition(goal, goalPosition);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ADC RID: 142044 RVA: 0x00BF5904 File Offset: 0x00BF3B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIKRotation(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKGoal goal;
			LuaObject.checkEnum<AvatarIKGoal>(l, 2, out goal);
			Quaternion ikrotation = animator.GetIKRotation(goal);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ikrotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ADD RID: 142045 RVA: 0x00BF5968 File Offset: 0x00BF3B68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetIKRotation(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKGoal goal;
			LuaObject.checkEnum<AvatarIKGoal>(l, 2, out goal);
			Quaternion goalRotation;
			LuaObject.checkType(l, 3, out goalRotation);
			animator.SetIKRotation(goal, goalRotation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ADE RID: 142046 RVA: 0x00BF59CC File Offset: 0x00BF3BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIKPositionWeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKGoal goal;
			LuaObject.checkEnum<AvatarIKGoal>(l, 2, out goal);
			float ikpositionWeight = animator.GetIKPositionWeight(goal);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ikpositionWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ADF RID: 142047 RVA: 0x00BF5A30 File Offset: 0x00BF3C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIKPositionWeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKGoal goal;
			LuaObject.checkEnum<AvatarIKGoal>(l, 2, out goal);
			float value;
			LuaObject.checkType(l, 3, out value);
			animator.SetIKPositionWeight(goal, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AE0 RID: 142048 RVA: 0x00BF5A94 File Offset: 0x00BF3C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIKRotationWeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKGoal goal;
			LuaObject.checkEnum<AvatarIKGoal>(l, 2, out goal);
			float ikrotationWeight = animator.GetIKRotationWeight(goal);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ikrotationWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AE1 RID: 142049 RVA: 0x00BF5AF8 File Offset: 0x00BF3CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIKRotationWeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKGoal goal;
			LuaObject.checkEnum<AvatarIKGoal>(l, 2, out goal);
			float value;
			LuaObject.checkType(l, 3, out value);
			animator.SetIKRotationWeight(goal, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AE2 RID: 142050 RVA: 0x00BF5B5C File Offset: 0x00BF3D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIKHintPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKHint hint;
			LuaObject.checkEnum<AvatarIKHint>(l, 2, out hint);
			Vector3 ikhintPosition = animator.GetIKHintPosition(hint);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ikhintPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AE3 RID: 142051 RVA: 0x00BF5BC0 File Offset: 0x00BF3DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIKHintPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKHint hint;
			LuaObject.checkEnum<AvatarIKHint>(l, 2, out hint);
			Vector3 hintPosition;
			LuaObject.checkType(l, 3, out hintPosition);
			animator.SetIKHintPosition(hint, hintPosition);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AE4 RID: 142052 RVA: 0x00BF5C24 File Offset: 0x00BF3E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIKHintPositionWeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKHint hint;
			LuaObject.checkEnum<AvatarIKHint>(l, 2, out hint);
			float ikhintPositionWeight = animator.GetIKHintPositionWeight(hint);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ikhintPositionWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AE5 RID: 142053 RVA: 0x00BF5C88 File Offset: 0x00BF3E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIKHintPositionWeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarIKHint hint;
			LuaObject.checkEnum<AvatarIKHint>(l, 2, out hint);
			float value;
			LuaObject.checkType(l, 3, out value);
			animator.SetIKHintPositionWeight(hint, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AE6 RID: 142054 RVA: 0x00BF5CEC File Offset: 0x00BF3EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLookAtPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			Vector3 lookAtPosition;
			LuaObject.checkType(l, 2, out lookAtPosition);
			animator.SetLookAtPosition(lookAtPosition);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AE7 RID: 142055 RVA: 0x00BF5D44 File Offset: 0x00BF3F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLookAtWeight(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Animator animator = (Animator)LuaObject.checkSelf(l);
				float lookAtWeight;
				LuaObject.checkType(l, 2, out lookAtWeight);
				animator.SetLookAtWeight(lookAtWeight);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				float weight;
				LuaObject.checkType(l, 2, out weight);
				float bodyWeight;
				LuaObject.checkType(l, 3, out bodyWeight);
				animator2.SetLookAtWeight(weight, bodyWeight);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Animator animator3 = (Animator)LuaObject.checkSelf(l);
				float weight2;
				LuaObject.checkType(l, 2, out weight2);
				float bodyWeight2;
				LuaObject.checkType(l, 3, out bodyWeight2);
				float headWeight;
				LuaObject.checkType(l, 4, out headWeight);
				animator3.SetLookAtWeight(weight2, bodyWeight2, headWeight);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Animator animator4 = (Animator)LuaObject.checkSelf(l);
				float weight3;
				LuaObject.checkType(l, 2, out weight3);
				float bodyWeight3;
				LuaObject.checkType(l, 3, out bodyWeight3);
				float headWeight2;
				LuaObject.checkType(l, 4, out headWeight2);
				float eyesWeight;
				LuaObject.checkType(l, 5, out eyesWeight);
				animator4.SetLookAtWeight(weight3, bodyWeight3, headWeight2, eyesWeight);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				Animator animator5 = (Animator)LuaObject.checkSelf(l);
				float weight4;
				LuaObject.checkType(l, 2, out weight4);
				float bodyWeight4;
				LuaObject.checkType(l, 3, out bodyWeight4);
				float headWeight3;
				LuaObject.checkType(l, 4, out headWeight3);
				float eyesWeight2;
				LuaObject.checkType(l, 5, out eyesWeight2);
				float clampWeight;
				LuaObject.checkType(l, 6, out clampWeight);
				animator5.SetLookAtWeight(weight4, bodyWeight4, headWeight3, eyesWeight2, clampWeight);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetLookAtWeight to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AE8 RID: 142056 RVA: 0x00BF5F1C File Offset: 0x00BF411C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBoneLocalRotation(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			HumanBodyBones humanBoneId;
			LuaObject.checkEnum<HumanBodyBones>(l, 2, out humanBoneId);
			Quaternion rotation;
			LuaObject.checkType(l, 3, out rotation);
			animator.SetBoneLocalRotation(humanBoneId, rotation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AE9 RID: 142057 RVA: 0x00BF5F80 File Offset: 0x00BF4180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBehaviour(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			StateMachineBehaviour behaviour = animator.GetBehaviour<StateMachineBehaviour>();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviour);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AEA RID: 142058 RVA: 0x00BF5FD4 File Offset: 0x00BF41D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBehaviours(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Animator animator = (Animator)LuaObject.checkSelf(l);
				StateMachineBehaviour[] behaviours = animator.GetBehaviours<StateMachineBehaviour>();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, behaviours);
				result = 2;
			}
			else if (num == 3)
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				int fullPathHash;
				LuaObject.checkType(l, 2, out fullPathHash);
				int layerIndex;
				LuaObject.checkType(l, 3, out layerIndex);
				StateMachineBehaviour[] behaviours2 = animator2.GetBehaviours(fullPathHash, layerIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, behaviours2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetBehaviours to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AEB RID: 142059 RVA: 0x00BF609C File Offset: 0x00BF429C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerName(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			string layerName = animator.GetLayerName(layerIndex);
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

	// Token: 0x06022AEC RID: 142060 RVA: 0x00BF6100 File Offset: 0x00BF4300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerIndex(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			string layerName;
			LuaObject.checkType(l, 2, out layerName);
			int layerIndex = animator.GetLayerIndex(layerName);
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

	// Token: 0x06022AED RID: 142061 RVA: 0x00BF6164 File Offset: 0x00BF4364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayerWeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			float layerWeight = animator.GetLayerWeight(layerIndex);
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

	// Token: 0x06022AEE RID: 142062 RVA: 0x00BF61C8 File Offset: 0x00BF43C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayerWeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			float weight;
			LuaObject.checkType(l, 3, out weight);
			animator.SetLayerWeight(layerIndex, weight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AEF RID: 142063 RVA: 0x00BF622C File Offset: 0x00BF442C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentAnimatorStateInfo(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(layerIndex);
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

	// Token: 0x06022AF0 RID: 142064 RVA: 0x00BF6294 File Offset: 0x00BF4494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNextAnimatorStateInfo(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			AnimatorStateInfo nextAnimatorStateInfo = animator.GetNextAnimatorStateInfo(layerIndex);
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

	// Token: 0x06022AF1 RID: 142065 RVA: 0x00BF62FC File Offset: 0x00BF44FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAnimatorTransitionInfo(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			AnimatorTransitionInfo animatorTransitionInfo = animator.GetAnimatorTransitionInfo(layerIndex);
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

	// Token: 0x06022AF2 RID: 142066 RVA: 0x00BF6364 File Offset: 0x00BF4564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentAnimatorClipInfoCount(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			int currentAnimatorClipInfoCount = animator.GetCurrentAnimatorClipInfoCount(layerIndex);
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

	// Token: 0x06022AF3 RID: 142067 RVA: 0x00BF63C8 File Offset: 0x00BF45C8
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
				Animator animator = (Animator)LuaObject.checkSelf(l);
				int layerIndex;
				LuaObject.checkType(l, 2, out layerIndex);
				AnimatorClipInfo[] currentAnimatorClipInfo = animator.GetCurrentAnimatorClipInfo(layerIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, currentAnimatorClipInfo);
				result = 2;
			}
			else if (num == 3)
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				int layerIndex2;
				LuaObject.checkType(l, 2, out layerIndex2);
				List<AnimatorClipInfo> clips;
				LuaObject.checkType<List<AnimatorClipInfo>>(l, 3, out clips);
				animator2.GetCurrentAnimatorClipInfo(layerIndex2, clips);
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

	// Token: 0x06022AF4 RID: 142068 RVA: 0x00BF6498 File Offset: 0x00BF4698
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNextAnimatorClipInfoCount(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			int nextAnimatorClipInfoCount = animator.GetNextAnimatorClipInfoCount(layerIndex);
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

	// Token: 0x06022AF5 RID: 142069 RVA: 0x00BF64FC File Offset: 0x00BF46FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNextAnimatorClipInfo(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Animator animator = (Animator)LuaObject.checkSelf(l);
				int layerIndex;
				LuaObject.checkType(l, 2, out layerIndex);
				AnimatorClipInfo[] nextAnimatorClipInfo = animator.GetNextAnimatorClipInfo(layerIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, nextAnimatorClipInfo);
				result = 2;
			}
			else if (num == 3)
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				int layerIndex2;
				LuaObject.checkType(l, 2, out layerIndex2);
				List<AnimatorClipInfo> clips;
				LuaObject.checkType<List<AnimatorClipInfo>>(l, 3, out clips);
				animator2.GetNextAnimatorClipInfo(layerIndex2, clips);
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

	// Token: 0x06022AF6 RID: 142070 RVA: 0x00BF65CC File Offset: 0x00BF47CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInTransition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			bool b = animator.IsInTransition(layerIndex);
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

	// Token: 0x06022AF7 RID: 142071 RVA: 0x00BF6630 File Offset: 0x00BF4830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetParameter(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			AnimatorControllerParameter parameter = animator.GetParameter(index);
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

	// Token: 0x06022AF8 RID: 142072 RVA: 0x00BF6694 File Offset: 0x00BF4894
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MatchTarget(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 6)
			{
				Animator animator = (Animator)LuaObject.checkSelf(l);
				Vector3 matchPosition;
				LuaObject.checkType(l, 2, out matchPosition);
				Quaternion matchRotation;
				LuaObject.checkType(l, 3, out matchRotation);
				AvatarTarget targetBodyPart;
				LuaObject.checkEnum<AvatarTarget>(l, 4, out targetBodyPart);
				MatchTargetWeightMask weightMask;
				LuaObject.checkValueType<MatchTargetWeightMask>(l, 5, out weightMask);
				float startNormalizedTime;
				LuaObject.checkType(l, 6, out startNormalizedTime);
				animator.MatchTarget(matchPosition, matchRotation, targetBodyPart, weightMask, startNormalizedTime);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				Vector3 matchPosition2;
				LuaObject.checkType(l, 2, out matchPosition2);
				Quaternion matchRotation2;
				LuaObject.checkType(l, 3, out matchRotation2);
				AvatarTarget targetBodyPart2;
				LuaObject.checkEnum<AvatarTarget>(l, 4, out targetBodyPart2);
				MatchTargetWeightMask weightMask2;
				LuaObject.checkValueType<MatchTargetWeightMask>(l, 5, out weightMask2);
				float startNormalizedTime2;
				LuaObject.checkType(l, 6, out startNormalizedTime2);
				float targetNormalizedTime;
				LuaObject.checkType(l, 7, out targetNormalizedTime);
				animator2.MatchTarget(matchPosition2, matchRotation2, targetBodyPart2, weightMask2, startNormalizedTime2, targetNormalizedTime);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function MatchTarget to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AF9 RID: 142073 RVA: 0x00BF67BC File Offset: 0x00BF49BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InterruptMatchTarget(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Animator animator = (Animator)LuaObject.checkSelf(l);
				bool completeMatch;
				LuaObject.checkType(l, 2, out completeMatch);
				animator.InterruptMatchTarget(completeMatch);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				animator2.InterruptMatchTarget();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function InterruptMatchTarget to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AFA RID: 142074 RVA: 0x00BF6868 File Offset: 0x00BF4A68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrossFadeInFixedTime(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				Animator animator = (Animator)LuaObject.checkSelf(l);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				float fixedTransitionDuration;
				LuaObject.checkType(l, 3, out fixedTransitionDuration);
				animator.CrossFadeInFixedTime(stateName, fixedTransitionDuration);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				int stateHashName;
				LuaObject.checkType(l, 2, out stateHashName);
				float fixedTransitionDuration2;
				LuaObject.checkType(l, 3, out fixedTransitionDuration2);
				animator2.CrossFadeInFixedTime(stateHashName, fixedTransitionDuration2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int)))
			{
				Animator animator3 = (Animator)LuaObject.checkSelf(l);
				int stateHashName2;
				LuaObject.checkType(l, 2, out stateHashName2);
				float fixedTransitionDuration3;
				LuaObject.checkType(l, 3, out fixedTransitionDuration3);
				int layer;
				LuaObject.checkType(l, 4, out layer);
				animator3.CrossFadeInFixedTime(stateHashName2, fixedTransitionDuration3, layer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int)))
			{
				Animator animator4 = (Animator)LuaObject.checkSelf(l);
				string stateName2;
				LuaObject.checkType(l, 2, out stateName2);
				float fixedTransitionDuration4;
				LuaObject.checkType(l, 3, out fixedTransitionDuration4);
				int layer2;
				LuaObject.checkType(l, 4, out layer2);
				animator4.CrossFadeInFixedTime(stateName2, fixedTransitionDuration4, layer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int), typeof(float)))
			{
				Animator animator5 = (Animator)LuaObject.checkSelf(l);
				int stateHashName3;
				LuaObject.checkType(l, 2, out stateHashName3);
				float fixedTransitionDuration5;
				LuaObject.checkType(l, 3, out fixedTransitionDuration5);
				int layer3;
				LuaObject.checkType(l, 4, out layer3);
				float fixedTimeOffset;
				LuaObject.checkType(l, 5, out fixedTimeOffset);
				animator5.CrossFadeInFixedTime(stateHashName3, fixedTransitionDuration5, layer3, fixedTimeOffset);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int), typeof(float)))
			{
				Animator animator6 = (Animator)LuaObject.checkSelf(l);
				string stateName3;
				LuaObject.checkType(l, 2, out stateName3);
				float fixedTransitionDuration6;
				LuaObject.checkType(l, 3, out fixedTransitionDuration6);
				int layer4;
				LuaObject.checkType(l, 4, out layer4);
				float fixedTimeOffset2;
				LuaObject.checkType(l, 5, out fixedTimeOffset2);
				animator6.CrossFadeInFixedTime(stateName3, fixedTransitionDuration6, layer4, fixedTimeOffset2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int), typeof(float), typeof(float)))
			{
				Animator animator7 = (Animator)LuaObject.checkSelf(l);
				string stateName4;
				LuaObject.checkType(l, 2, out stateName4);
				float fixedTransitionDuration7;
				LuaObject.checkType(l, 3, out fixedTransitionDuration7);
				int layer5;
				LuaObject.checkType(l, 4, out layer5);
				float fixedTimeOffset3;
				LuaObject.checkType(l, 5, out fixedTimeOffset3);
				float normalizedTransitionTime;
				LuaObject.checkType(l, 6, out normalizedTransitionTime);
				animator7.CrossFadeInFixedTime(stateName4, fixedTransitionDuration7, layer5, fixedTimeOffset3, normalizedTransitionTime);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int), typeof(float), typeof(float)))
			{
				Animator animator8 = (Animator)LuaObject.checkSelf(l);
				int stateHashName4;
				LuaObject.checkType(l, 2, out stateHashName4);
				float fixedTransitionDuration8;
				LuaObject.checkType(l, 3, out fixedTransitionDuration8);
				int layer6;
				LuaObject.checkType(l, 4, out layer6);
				float fixedTimeOffset4;
				LuaObject.checkType(l, 5, out fixedTimeOffset4);
				float normalizedTransitionTime2;
				LuaObject.checkType(l, 6, out normalizedTransitionTime2);
				animator8.CrossFadeInFixedTime(stateHashName4, fixedTransitionDuration8, layer6, fixedTimeOffset4, normalizedTransitionTime2);
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

	// Token: 0x06022AFB RID: 142075 RVA: 0x00BF6CAC File Offset: 0x00BF4EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CrossFade(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float)))
			{
				Animator animator = (Animator)LuaObject.checkSelf(l);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				float normalizedTransitionDuration;
				LuaObject.checkType(l, 3, out normalizedTransitionDuration);
				animator.CrossFade(stateName, normalizedTransitionDuration);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				int stateHashName;
				LuaObject.checkType(l, 2, out stateHashName);
				float normalizedTransitionDuration2;
				LuaObject.checkType(l, 3, out normalizedTransitionDuration2);
				animator2.CrossFade(stateHashName, normalizedTransitionDuration2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int)))
			{
				Animator animator3 = (Animator)LuaObject.checkSelf(l);
				int stateHashName2;
				LuaObject.checkType(l, 2, out stateHashName2);
				float normalizedTransitionDuration3;
				LuaObject.checkType(l, 3, out normalizedTransitionDuration3);
				int layer;
				LuaObject.checkType(l, 4, out layer);
				animator3.CrossFade(stateHashName2, normalizedTransitionDuration3, layer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int)))
			{
				Animator animator4 = (Animator)LuaObject.checkSelf(l);
				string stateName2;
				LuaObject.checkType(l, 2, out stateName2);
				float normalizedTransitionDuration4;
				LuaObject.checkType(l, 3, out normalizedTransitionDuration4);
				int layer2;
				LuaObject.checkType(l, 4, out layer2);
				animator4.CrossFade(stateName2, normalizedTransitionDuration4, layer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int), typeof(float)))
			{
				Animator animator5 = (Animator)LuaObject.checkSelf(l);
				int stateHashName3;
				LuaObject.checkType(l, 2, out stateHashName3);
				float normalizedTransitionDuration5;
				LuaObject.checkType(l, 3, out normalizedTransitionDuration5);
				int layer3;
				LuaObject.checkType(l, 4, out layer3);
				float normalizedTimeOffset;
				LuaObject.checkType(l, 5, out normalizedTimeOffset);
				animator5.CrossFade(stateHashName3, normalizedTransitionDuration5, layer3, normalizedTimeOffset);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int), typeof(float)))
			{
				Animator animator6 = (Animator)LuaObject.checkSelf(l);
				string stateName3;
				LuaObject.checkType(l, 2, out stateName3);
				float normalizedTransitionDuration6;
				LuaObject.checkType(l, 3, out normalizedTransitionDuration6);
				int layer4;
				LuaObject.checkType(l, 4, out layer4);
				float normalizedTimeOffset2;
				LuaObject.checkType(l, 5, out normalizedTimeOffset2);
				animator6.CrossFade(stateName3, normalizedTransitionDuration6, layer4, normalizedTimeOffset2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(float), typeof(int), typeof(float), typeof(float)))
			{
				Animator animator7 = (Animator)LuaObject.checkSelf(l);
				string stateName4;
				LuaObject.checkType(l, 2, out stateName4);
				float normalizedTransitionDuration7;
				LuaObject.checkType(l, 3, out normalizedTransitionDuration7);
				int layer5;
				LuaObject.checkType(l, 4, out layer5);
				float normalizedTimeOffset3;
				LuaObject.checkType(l, 5, out normalizedTimeOffset3);
				float normalizedTransitionTime;
				LuaObject.checkType(l, 6, out normalizedTransitionTime);
				animator7.CrossFade(stateName4, normalizedTransitionDuration7, layer5, normalizedTimeOffset3, normalizedTransitionTime);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(float), typeof(int), typeof(float), typeof(float)))
			{
				Animator animator8 = (Animator)LuaObject.checkSelf(l);
				int stateHashName4;
				LuaObject.checkType(l, 2, out stateHashName4);
				float normalizedTransitionDuration8;
				LuaObject.checkType(l, 3, out normalizedTransitionDuration8);
				int layer6;
				LuaObject.checkType(l, 4, out layer6);
				float normalizedTimeOffset4;
				LuaObject.checkType(l, 5, out normalizedTimeOffset4);
				float normalizedTransitionTime2;
				LuaObject.checkType(l, 6, out normalizedTransitionTime2);
				animator8.CrossFade(stateHashName4, normalizedTransitionDuration8, layer6, normalizedTimeOffset4, normalizedTransitionTime2);
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

	// Token: 0x06022AFC RID: 142076 RVA: 0x00BF70F0 File Offset: 0x00BF52F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayInFixedTime(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int)))
			{
				Animator animator = (Animator)LuaObject.checkSelf(l);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				int layer;
				LuaObject.checkType(l, 3, out layer);
				animator.PlayInFixedTime(stateName, layer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				string stateName2;
				LuaObject.checkType(l, 2, out stateName2);
				animator2.PlayInFixedTime(stateName2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Animator animator3 = (Animator)LuaObject.checkSelf(l);
				int stateNameHash;
				LuaObject.checkType(l, 2, out stateNameHash);
				animator3.PlayInFixedTime(stateNameHash);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int)))
			{
				Animator animator4 = (Animator)LuaObject.checkSelf(l);
				int stateNameHash2;
				LuaObject.checkType(l, 2, out stateNameHash2);
				int layer2;
				LuaObject.checkType(l, 3, out layer2);
				animator4.PlayInFixedTime(stateNameHash2, layer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int), typeof(float)))
			{
				Animator animator5 = (Animator)LuaObject.checkSelf(l);
				string stateName3;
				LuaObject.checkType(l, 2, out stateName3);
				int layer3;
				LuaObject.checkType(l, 3, out layer3);
				float fixedTime;
				LuaObject.checkType(l, 4, out fixedTime);
				animator5.PlayInFixedTime(stateName3, layer3, fixedTime);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int), typeof(float)))
			{
				Animator animator6 = (Animator)LuaObject.checkSelf(l);
				int stateNameHash3;
				LuaObject.checkType(l, 2, out stateNameHash3);
				int layer4;
				LuaObject.checkType(l, 3, out layer4);
				float fixedTime2;
				LuaObject.checkType(l, 4, out fixedTime2);
				animator6.PlayInFixedTime(stateNameHash3, layer4, fixedTime2);
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

	// Token: 0x06022AFD RID: 142077 RVA: 0x00BF7374 File Offset: 0x00BF5574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Play(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int)))
			{
				Animator animator = (Animator)LuaObject.checkSelf(l);
				string stateName;
				LuaObject.checkType(l, 2, out stateName);
				int layer;
				LuaObject.checkType(l, 3, out layer);
				animator.Play(stateName, layer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string)))
			{
				Animator animator2 = (Animator)LuaObject.checkSelf(l);
				string stateName2;
				LuaObject.checkType(l, 2, out stateName2);
				animator2.Play(stateName2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int)))
			{
				Animator animator3 = (Animator)LuaObject.checkSelf(l);
				int stateNameHash;
				LuaObject.checkType(l, 2, out stateNameHash);
				animator3.Play(stateNameHash);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int)))
			{
				Animator animator4 = (Animator)LuaObject.checkSelf(l);
				int stateNameHash2;
				LuaObject.checkType(l, 2, out stateNameHash2);
				int layer2;
				LuaObject.checkType(l, 3, out layer2);
				animator4.Play(stateNameHash2, layer2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(int), typeof(float)))
			{
				Animator animator5 = (Animator)LuaObject.checkSelf(l);
				string stateName3;
				LuaObject.checkType(l, 2, out stateName3);
				int layer3;
				LuaObject.checkType(l, 3, out layer3);
				float normalizedTime;
				LuaObject.checkType(l, 4, out normalizedTime);
				animator5.Play(stateName3, layer3, normalizedTime);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int), typeof(float)))
			{
				Animator animator6 = (Animator)LuaObject.checkSelf(l);
				int stateNameHash3;
				LuaObject.checkType(l, 2, out stateNameHash3);
				int layer4;
				LuaObject.checkType(l, 3, out layer4);
				float normalizedTime2;
				LuaObject.checkType(l, 4, out normalizedTime2);
				animator6.Play(stateNameHash3, layer4, normalizedTime2);
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

	// Token: 0x06022AFE RID: 142078 RVA: 0x00BF75F8 File Offset: 0x00BF57F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTarget(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AvatarTarget targetIndex;
			LuaObject.checkEnum<AvatarTarget>(l, 2, out targetIndex);
			float targetNormalizedTime;
			LuaObject.checkType(l, 3, out targetNormalizedTime);
			animator.SetTarget(targetIndex, targetNormalizedTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022AFF RID: 142079 RVA: 0x00BF765C File Offset: 0x00BF585C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBoneTransform(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			HumanBodyBones humanBoneId;
			LuaObject.checkEnum<HumanBodyBones>(l, 2, out humanBoneId);
			Transform boneTransform = animator.GetBoneTransform(humanBoneId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boneTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B00 RID: 142080 RVA: 0x00BF76C0 File Offset: 0x00BF58C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartPlayback(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			animator.StartPlayback();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B01 RID: 142081 RVA: 0x00BF770C File Offset: 0x00BF590C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopPlayback(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			animator.StopPlayback();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B02 RID: 142082 RVA: 0x00BF7758 File Offset: 0x00BF5958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRecording(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int frameCount;
			LuaObject.checkType(l, 2, out frameCount);
			animator.StartRecording(frameCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B03 RID: 142083 RVA: 0x00BF77B0 File Offset: 0x00BF59B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopRecording(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			animator.StopRecording();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B04 RID: 142084 RVA: 0x00BF77FC File Offset: 0x00BF59FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasState(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			int layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			int stateID;
			LuaObject.checkType(l, 3, out stateID);
			bool b = animator.HasState(layerIndex, stateID);
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

	// Token: 0x06022B05 RID: 142085 RVA: 0x00BF786C File Offset: 0x00BF5A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			float deltaTime;
			LuaObject.checkType(l, 2, out deltaTime);
			animator.Update(deltaTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B06 RID: 142086 RVA: 0x00BF78C4 File Offset: 0x00BF5AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rebind(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			animator.Rebind();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B07 RID: 142087 RVA: 0x00BF7910 File Offset: 0x00BF5B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ApplyBuiltinRootMotion(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			animator.ApplyBuiltinRootMotion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B08 RID: 142088 RVA: 0x00BF795C File Offset: 0x00BF5B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StringToHash_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			int i = Animator.StringToHash(name);
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

	// Token: 0x06022B09 RID: 142089 RVA: 0x00BF79B0 File Offset: 0x00BF5BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isOptimizable(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.isOptimizable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B0A RID: 142090 RVA: 0x00BF7A04 File Offset: 0x00BF5C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isHuman(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.isHuman);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B0B RID: 142091 RVA: 0x00BF7A58 File Offset: 0x00BF5C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasRootMotion(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.hasRootMotion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B0C RID: 142092 RVA: 0x00BF7AAC File Offset: 0x00BF5CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_humanScale(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.humanScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B0D RID: 142093 RVA: 0x00BF7B00 File Offset: 0x00BF5D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isInitialized(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.isInitialized);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B0E RID: 142094 RVA: 0x00BF7B54 File Offset: 0x00BF5D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deltaPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.deltaPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B0F RID: 142095 RVA: 0x00BF7BA8 File Offset: 0x00BF5DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deltaRotation(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.deltaRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B10 RID: 142096 RVA: 0x00BF7BFC File Offset: 0x00BF5DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_velocity(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.velocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B11 RID: 142097 RVA: 0x00BF7C50 File Offset: 0x00BF5E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularVelocity(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.angularVelocity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B12 RID: 142098 RVA: 0x00BF7CA4 File Offset: 0x00BF5EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rootPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.rootPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B13 RID: 142099 RVA: 0x00BF7CF8 File Offset: 0x00BF5EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rootPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			Vector3 rootPosition;
			LuaObject.checkType(l, 2, out rootPosition);
			animator.rootPosition = rootPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B14 RID: 142100 RVA: 0x00BF7D50 File Offset: 0x00BF5F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rootRotation(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.rootRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B15 RID: 142101 RVA: 0x00BF7DA4 File Offset: 0x00BF5FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rootRotation(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			Quaternion rootRotation;
			LuaObject.checkType(l, 2, out rootRotation);
			animator.rootRotation = rootRotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B16 RID: 142102 RVA: 0x00BF7DFC File Offset: 0x00BF5FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_applyRootMotion(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.applyRootMotion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B17 RID: 142103 RVA: 0x00BF7E50 File Offset: 0x00BF6050
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_applyRootMotion(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			bool applyRootMotion;
			LuaObject.checkType(l, 2, out applyRootMotion);
			animator.applyRootMotion = applyRootMotion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B18 RID: 142104 RVA: 0x00BF7EA8 File Offset: 0x00BF60A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_linearVelocityBlending(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.linearVelocityBlending);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B19 RID: 142105 RVA: 0x00BF7EFC File Offset: 0x00BF60FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_linearVelocityBlending(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			bool linearVelocityBlending;
			LuaObject.checkType(l, 2, out linearVelocityBlending);
			animator.linearVelocityBlending = linearVelocityBlending;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B1A RID: 142106 RVA: 0x00BF7F54 File Offset: 0x00BF6154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateMode(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animator.updateMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B1B RID: 142107 RVA: 0x00BF7FA8 File Offset: 0x00BF61A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_updateMode(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AnimatorUpdateMode updateMode;
			LuaObject.checkEnum<AnimatorUpdateMode>(l, 2, out updateMode);
			animator.updateMode = updateMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B1C RID: 142108 RVA: 0x00BF8000 File Offset: 0x00BF6200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasTransformHierarchy(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.hasTransformHierarchy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B1D RID: 142109 RVA: 0x00BF8054 File Offset: 0x00BF6254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gravityWeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.gravityWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B1E RID: 142110 RVA: 0x00BF80A8 File Offset: 0x00BF62A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bodyPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.bodyPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B1F RID: 142111 RVA: 0x00BF80FC File Offset: 0x00BF62FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bodyPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			Vector3 bodyPosition;
			LuaObject.checkType(l, 2, out bodyPosition);
			animator.bodyPosition = bodyPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B20 RID: 142112 RVA: 0x00BF8154 File Offset: 0x00BF6354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bodyRotation(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.bodyRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B21 RID: 142113 RVA: 0x00BF81A8 File Offset: 0x00BF63A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bodyRotation(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			Quaternion bodyRotation;
			LuaObject.checkType(l, 2, out bodyRotation);
			animator.bodyRotation = bodyRotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B22 RID: 142114 RVA: 0x00BF8200 File Offset: 0x00BF6400
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_stabilizeFeet(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.stabilizeFeet);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B23 RID: 142115 RVA: 0x00BF8254 File Offset: 0x00BF6454
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_stabilizeFeet(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			bool stabilizeFeet;
			LuaObject.checkType(l, 2, out stabilizeFeet);
			animator.stabilizeFeet = stabilizeFeet;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B24 RID: 142116 RVA: 0x00BF82AC File Offset: 0x00BF64AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layerCount(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.layerCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B25 RID: 142117 RVA: 0x00BF8300 File Offset: 0x00BF6500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_parameters(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.parameters);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B26 RID: 142118 RVA: 0x00BF8354 File Offset: 0x00BF6554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_parameterCount(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.parameterCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B27 RID: 142119 RVA: 0x00BF83A8 File Offset: 0x00BF65A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_feetPivotActive(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.feetPivotActive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B28 RID: 142120 RVA: 0x00BF83FC File Offset: 0x00BF65FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_feetPivotActive(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			float feetPivotActive;
			LuaObject.checkType(l, 2, out feetPivotActive);
			animator.feetPivotActive = feetPivotActive;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B29 RID: 142121 RVA: 0x00BF8454 File Offset: 0x00BF6654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pivotWeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.pivotWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B2A RID: 142122 RVA: 0x00BF84A8 File Offset: 0x00BF66A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pivotPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.pivotPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B2B RID: 142123 RVA: 0x00BF84FC File Offset: 0x00BF66FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isMatchingTarget(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.isMatchingTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B2C RID: 142124 RVA: 0x00BF8550 File Offset: 0x00BF6750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_speed(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.speed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B2D RID: 142125 RVA: 0x00BF85A4 File Offset: 0x00BF67A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_speed(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			float speed;
			LuaObject.checkType(l, 2, out speed);
			animator.speed = speed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B2E RID: 142126 RVA: 0x00BF85FC File Offset: 0x00BF67FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.targetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B2F RID: 142127 RVA: 0x00BF8650 File Offset: 0x00BF6850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetRotation(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.targetRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B30 RID: 142128 RVA: 0x00BF86A4 File Offset: 0x00BF68A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cullingMode(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animator.cullingMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B31 RID: 142129 RVA: 0x00BF86F8 File Offset: 0x00BF68F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cullingMode(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			AnimatorCullingMode cullingMode;
			LuaObject.checkEnum<AnimatorCullingMode>(l, 2, out cullingMode);
			animator.cullingMode = cullingMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B32 RID: 142130 RVA: 0x00BF8750 File Offset: 0x00BF6950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_playbackTime(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.playbackTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B33 RID: 142131 RVA: 0x00BF87A4 File Offset: 0x00BF69A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_playbackTime(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			float playbackTime;
			LuaObject.checkType(l, 2, out playbackTime);
			animator.playbackTime = playbackTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B34 RID: 142132 RVA: 0x00BF87FC File Offset: 0x00BF69FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_recorderStartTime(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.recorderStartTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B35 RID: 142133 RVA: 0x00BF8850 File Offset: 0x00BF6A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_recorderStartTime(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			float recorderStartTime;
			LuaObject.checkType(l, 2, out recorderStartTime);
			animator.recorderStartTime = recorderStartTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B36 RID: 142134 RVA: 0x00BF88A8 File Offset: 0x00BF6AA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_recorderStopTime(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.recorderStopTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B37 RID: 142135 RVA: 0x00BF88FC File Offset: 0x00BF6AFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_recorderStopTime(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			float recorderStopTime;
			LuaObject.checkType(l, 2, out recorderStopTime);
			animator.recorderStopTime = recorderStopTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B38 RID: 142136 RVA: 0x00BF8954 File Offset: 0x00BF6B54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_recorderMode(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animator.recorderMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B39 RID: 142137 RVA: 0x00BF89A8 File Offset: 0x00BF6BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_runtimeAnimatorController(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.runtimeAnimatorController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B3A RID: 142138 RVA: 0x00BF89FC File Offset: 0x00BF6BFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_runtimeAnimatorController(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			RuntimeAnimatorController runtimeAnimatorController;
			LuaObject.checkType<RuntimeAnimatorController>(l, 2, out runtimeAnimatorController);
			animator.runtimeAnimatorController = runtimeAnimatorController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B3B RID: 142139 RVA: 0x00BF8A54 File Offset: 0x00BF6C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasBoundPlayables(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.hasBoundPlayables);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B3C RID: 142140 RVA: 0x00BF8AA8 File Offset: 0x00BF6CA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_avatar(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.avatar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B3D RID: 142141 RVA: 0x00BF8AFC File Offset: 0x00BF6CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_avatar(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			Avatar avatar;
			LuaObject.checkType<Avatar>(l, 2, out avatar);
			animator.avatar = avatar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B3E RID: 142142 RVA: 0x00BF8B54 File Offset: 0x00BF6D54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_playableGraph(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.playableGraph);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B3F RID: 142143 RVA: 0x00BF8BAC File Offset: 0x00BF6DAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_layersAffectMassCenter(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.layersAffectMassCenter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B40 RID: 142144 RVA: 0x00BF8C00 File Offset: 0x00BF6E00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_layersAffectMassCenter(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			bool layersAffectMassCenter;
			LuaObject.checkType(l, 2, out layersAffectMassCenter);
			animator.layersAffectMassCenter = layersAffectMassCenter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B41 RID: 142145 RVA: 0x00BF8C58 File Offset: 0x00BF6E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_leftFeetBottomHeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.leftFeetBottomHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B42 RID: 142146 RVA: 0x00BF8CAC File Offset: 0x00BF6EAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_rightFeetBottomHeight(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.rightFeetBottomHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B43 RID: 142147 RVA: 0x00BF8D00 File Offset: 0x00BF6F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_logWarnings(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.logWarnings);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B44 RID: 142148 RVA: 0x00BF8D54 File Offset: 0x00BF6F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_logWarnings(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			bool logWarnings;
			LuaObject.checkType(l, 2, out logWarnings);
			animator.logWarnings = logWarnings;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B45 RID: 142149 RVA: 0x00BF8DAC File Offset: 0x00BF6FAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_fireEvents(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animator.fireEvents);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B46 RID: 142150 RVA: 0x00BF8E00 File Offset: 0x00BF7000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_fireEvents(IntPtr l)
	{
		int result;
		try
		{
			Animator animator = (Animator)LuaObject.checkSelf(l);
			bool fireEvents;
			LuaObject.checkType(l, 2, out fireEvents);
			animator.fireEvents = fireEvents;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022B47 RID: 142151 RVA: 0x00BF8E58 File Offset: 0x00BF7058
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Animator");
		if (Lua_UnityEngine_Animator.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Animator.GetFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache0);
		if (Lua_UnityEngine_Animator.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Animator.SetFloat);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache1);
		if (Lua_UnityEngine_Animator.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Animator.GetBool);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache2);
		if (Lua_UnityEngine_Animator.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Animator.SetBool);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache3);
		if (Lua_UnityEngine_Animator.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Animator.GetInteger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache4);
		if (Lua_UnityEngine_Animator.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Animator.SetInteger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache5);
		if (Lua_UnityEngine_Animator.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Animator.SetTrigger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache6);
		if (Lua_UnityEngine_Animator.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Animator.ResetTrigger);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache7);
		if (Lua_UnityEngine_Animator.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Animator.IsParameterControlledByCurve);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache8);
		if (Lua_UnityEngine_Animator.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Animator.GetIKPosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache9);
		if (Lua_UnityEngine_Animator.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Animator.SetIKPosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cacheA);
		if (Lua_UnityEngine_Animator.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Animator.GetIKRotation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cacheB);
		if (Lua_UnityEngine_Animator.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Animator.SetIKRotation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cacheC);
		if (Lua_UnityEngine_Animator.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Animator.GetIKPositionWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cacheD);
		if (Lua_UnityEngine_Animator.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Animator.SetIKPositionWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cacheE);
		if (Lua_UnityEngine_Animator.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Animator.GetIKRotationWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cacheF);
		if (Lua_UnityEngine_Animator.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Animator.SetIKRotationWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache10);
		if (Lua_UnityEngine_Animator.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Animator.GetIKHintPosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache11);
		if (Lua_UnityEngine_Animator.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Animator.SetIKHintPosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache12);
		if (Lua_UnityEngine_Animator.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Animator.GetIKHintPositionWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache13);
		if (Lua_UnityEngine_Animator.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Animator.SetIKHintPositionWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache14);
		if (Lua_UnityEngine_Animator.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Animator.SetLookAtPosition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache15);
		if (Lua_UnityEngine_Animator.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Animator.SetLookAtWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache16);
		if (Lua_UnityEngine_Animator.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Animator.SetBoneLocalRotation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache17);
		if (Lua_UnityEngine_Animator.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Animator.GetBehaviour);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache18);
		if (Lua_UnityEngine_Animator.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Animator.GetBehaviours);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache19);
		if (Lua_UnityEngine_Animator.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Animator.GetLayerName);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache1A);
		if (Lua_UnityEngine_Animator.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Animator.GetLayerIndex);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache1B);
		if (Lua_UnityEngine_Animator.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Animator.GetLayerWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache1C);
		if (Lua_UnityEngine_Animator.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Animator.SetLayerWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache1D);
		if (Lua_UnityEngine_Animator.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Animator.GetCurrentAnimatorStateInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache1E);
		if (Lua_UnityEngine_Animator.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Animator.GetNextAnimatorStateInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache1F);
		if (Lua_UnityEngine_Animator.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Animator.GetAnimatorTransitionInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache20);
		if (Lua_UnityEngine_Animator.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Animator.GetCurrentAnimatorClipInfoCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache21);
		if (Lua_UnityEngine_Animator.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Animator.GetCurrentAnimatorClipInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache22);
		if (Lua_UnityEngine_Animator.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Animator.GetNextAnimatorClipInfoCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache23);
		if (Lua_UnityEngine_Animator.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Animator.GetNextAnimatorClipInfo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache24);
		if (Lua_UnityEngine_Animator.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Animator.IsInTransition);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache25);
		if (Lua_UnityEngine_Animator.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Animator.GetParameter);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache26);
		if (Lua_UnityEngine_Animator.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Animator.MatchTarget);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache27);
		if (Lua_UnityEngine_Animator.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Animator.InterruptMatchTarget);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache28);
		if (Lua_UnityEngine_Animator.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Animator.CrossFadeInFixedTime);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache29);
		if (Lua_UnityEngine_Animator.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Animator.CrossFade);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache2A);
		if (Lua_UnityEngine_Animator.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Animator.PlayInFixedTime);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache2B);
		if (Lua_UnityEngine_Animator.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Animator.Play);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache2C);
		if (Lua_UnityEngine_Animator.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Animator.SetTarget);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache2D);
		if (Lua_UnityEngine_Animator.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Animator.GetBoneTransform);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache2E);
		if (Lua_UnityEngine_Animator.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Animator.StartPlayback);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache2F);
		if (Lua_UnityEngine_Animator.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Animator.StopPlayback);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache30);
		if (Lua_UnityEngine_Animator.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Animator.StartRecording);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache31);
		if (Lua_UnityEngine_Animator.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Animator.StopRecording);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache32);
		if (Lua_UnityEngine_Animator.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Animator.HasState);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache33);
		if (Lua_UnityEngine_Animator.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Animator.Update);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache34);
		if (Lua_UnityEngine_Animator.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Animator.Rebind);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache35);
		if (Lua_UnityEngine_Animator.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_Animator.ApplyBuiltinRootMotion);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache36);
		if (Lua_UnityEngine_Animator.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_Animator.StringToHash_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animator.<>f__mg$cache37);
		string name = "isOptimizable";
		if (Lua_UnityEngine_Animator.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_Animator.get_isOptimizable);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Animator.<>f__mg$cache38, null, true);
		string name2 = "isHuman";
		if (Lua_UnityEngine_Animator.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_Animator.get_isHuman);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Animator.<>f__mg$cache39, null, true);
		string name3 = "hasRootMotion";
		if (Lua_UnityEngine_Animator.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_Animator.get_hasRootMotion);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Animator.<>f__mg$cache3A, null, true);
		string name4 = "humanScale";
		if (Lua_UnityEngine_Animator.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_Animator.get_humanScale);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Animator.<>f__mg$cache3B, null, true);
		string name5 = "isInitialized";
		if (Lua_UnityEngine_Animator.<>f__mg$cache3C == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache3C = new LuaCSFunction(Lua_UnityEngine_Animator.get_isInitialized);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Animator.<>f__mg$cache3C, null, true);
		string name6 = "deltaPosition";
		if (Lua_UnityEngine_Animator.<>f__mg$cache3D == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache3D = new LuaCSFunction(Lua_UnityEngine_Animator.get_deltaPosition);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Animator.<>f__mg$cache3D, null, true);
		string name7 = "deltaRotation";
		if (Lua_UnityEngine_Animator.<>f__mg$cache3E == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache3E = new LuaCSFunction(Lua_UnityEngine_Animator.get_deltaRotation);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Animator.<>f__mg$cache3E, null, true);
		string name8 = "velocity";
		if (Lua_UnityEngine_Animator.<>f__mg$cache3F == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache3F = new LuaCSFunction(Lua_UnityEngine_Animator.get_velocity);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Animator.<>f__mg$cache3F, null, true);
		string name9 = "angularVelocity";
		if (Lua_UnityEngine_Animator.<>f__mg$cache40 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache40 = new LuaCSFunction(Lua_UnityEngine_Animator.get_angularVelocity);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Animator.<>f__mg$cache40, null, true);
		string name10 = "rootPosition";
		if (Lua_UnityEngine_Animator.<>f__mg$cache41 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache41 = new LuaCSFunction(Lua_UnityEngine_Animator.get_rootPosition);
		}
		LuaCSFunction get = Lua_UnityEngine_Animator.<>f__mg$cache41;
		if (Lua_UnityEngine_Animator.<>f__mg$cache42 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache42 = new LuaCSFunction(Lua_UnityEngine_Animator.set_rootPosition);
		}
		LuaObject.addMember(l, name10, get, Lua_UnityEngine_Animator.<>f__mg$cache42, true);
		string name11 = "rootRotation";
		if (Lua_UnityEngine_Animator.<>f__mg$cache43 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache43 = new LuaCSFunction(Lua_UnityEngine_Animator.get_rootRotation);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Animator.<>f__mg$cache43;
		if (Lua_UnityEngine_Animator.<>f__mg$cache44 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache44 = new LuaCSFunction(Lua_UnityEngine_Animator.set_rootRotation);
		}
		LuaObject.addMember(l, name11, get2, Lua_UnityEngine_Animator.<>f__mg$cache44, true);
		string name12 = "applyRootMotion";
		if (Lua_UnityEngine_Animator.<>f__mg$cache45 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache45 = new LuaCSFunction(Lua_UnityEngine_Animator.get_applyRootMotion);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Animator.<>f__mg$cache45;
		if (Lua_UnityEngine_Animator.<>f__mg$cache46 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache46 = new LuaCSFunction(Lua_UnityEngine_Animator.set_applyRootMotion);
		}
		LuaObject.addMember(l, name12, get3, Lua_UnityEngine_Animator.<>f__mg$cache46, true);
		string name13 = "linearVelocityBlending";
		if (Lua_UnityEngine_Animator.<>f__mg$cache47 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache47 = new LuaCSFunction(Lua_UnityEngine_Animator.get_linearVelocityBlending);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Animator.<>f__mg$cache47;
		if (Lua_UnityEngine_Animator.<>f__mg$cache48 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache48 = new LuaCSFunction(Lua_UnityEngine_Animator.set_linearVelocityBlending);
		}
		LuaObject.addMember(l, name13, get4, Lua_UnityEngine_Animator.<>f__mg$cache48, true);
		string name14 = "updateMode";
		if (Lua_UnityEngine_Animator.<>f__mg$cache49 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache49 = new LuaCSFunction(Lua_UnityEngine_Animator.get_updateMode);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Animator.<>f__mg$cache49;
		if (Lua_UnityEngine_Animator.<>f__mg$cache4A == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache4A = new LuaCSFunction(Lua_UnityEngine_Animator.set_updateMode);
		}
		LuaObject.addMember(l, name14, get5, Lua_UnityEngine_Animator.<>f__mg$cache4A, true);
		string name15 = "hasTransformHierarchy";
		if (Lua_UnityEngine_Animator.<>f__mg$cache4B == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache4B = new LuaCSFunction(Lua_UnityEngine_Animator.get_hasTransformHierarchy);
		}
		LuaObject.addMember(l, name15, Lua_UnityEngine_Animator.<>f__mg$cache4B, null, true);
		string name16 = "gravityWeight";
		if (Lua_UnityEngine_Animator.<>f__mg$cache4C == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache4C = new LuaCSFunction(Lua_UnityEngine_Animator.get_gravityWeight);
		}
		LuaObject.addMember(l, name16, Lua_UnityEngine_Animator.<>f__mg$cache4C, null, true);
		string name17 = "bodyPosition";
		if (Lua_UnityEngine_Animator.<>f__mg$cache4D == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache4D = new LuaCSFunction(Lua_UnityEngine_Animator.get_bodyPosition);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Animator.<>f__mg$cache4D;
		if (Lua_UnityEngine_Animator.<>f__mg$cache4E == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache4E = new LuaCSFunction(Lua_UnityEngine_Animator.set_bodyPosition);
		}
		LuaObject.addMember(l, name17, get6, Lua_UnityEngine_Animator.<>f__mg$cache4E, true);
		string name18 = "bodyRotation";
		if (Lua_UnityEngine_Animator.<>f__mg$cache4F == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache4F = new LuaCSFunction(Lua_UnityEngine_Animator.get_bodyRotation);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Animator.<>f__mg$cache4F;
		if (Lua_UnityEngine_Animator.<>f__mg$cache50 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache50 = new LuaCSFunction(Lua_UnityEngine_Animator.set_bodyRotation);
		}
		LuaObject.addMember(l, name18, get7, Lua_UnityEngine_Animator.<>f__mg$cache50, true);
		string name19 = "stabilizeFeet";
		if (Lua_UnityEngine_Animator.<>f__mg$cache51 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache51 = new LuaCSFunction(Lua_UnityEngine_Animator.get_stabilizeFeet);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Animator.<>f__mg$cache51;
		if (Lua_UnityEngine_Animator.<>f__mg$cache52 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache52 = new LuaCSFunction(Lua_UnityEngine_Animator.set_stabilizeFeet);
		}
		LuaObject.addMember(l, name19, get8, Lua_UnityEngine_Animator.<>f__mg$cache52, true);
		string name20 = "layerCount";
		if (Lua_UnityEngine_Animator.<>f__mg$cache53 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache53 = new LuaCSFunction(Lua_UnityEngine_Animator.get_layerCount);
		}
		LuaObject.addMember(l, name20, Lua_UnityEngine_Animator.<>f__mg$cache53, null, true);
		string name21 = "parameters";
		if (Lua_UnityEngine_Animator.<>f__mg$cache54 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache54 = new LuaCSFunction(Lua_UnityEngine_Animator.get_parameters);
		}
		LuaObject.addMember(l, name21, Lua_UnityEngine_Animator.<>f__mg$cache54, null, true);
		string name22 = "parameterCount";
		if (Lua_UnityEngine_Animator.<>f__mg$cache55 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache55 = new LuaCSFunction(Lua_UnityEngine_Animator.get_parameterCount);
		}
		LuaObject.addMember(l, name22, Lua_UnityEngine_Animator.<>f__mg$cache55, null, true);
		string name23 = "feetPivotActive";
		if (Lua_UnityEngine_Animator.<>f__mg$cache56 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache56 = new LuaCSFunction(Lua_UnityEngine_Animator.get_feetPivotActive);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Animator.<>f__mg$cache56;
		if (Lua_UnityEngine_Animator.<>f__mg$cache57 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache57 = new LuaCSFunction(Lua_UnityEngine_Animator.set_feetPivotActive);
		}
		LuaObject.addMember(l, name23, get9, Lua_UnityEngine_Animator.<>f__mg$cache57, true);
		string name24 = "pivotWeight";
		if (Lua_UnityEngine_Animator.<>f__mg$cache58 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache58 = new LuaCSFunction(Lua_UnityEngine_Animator.get_pivotWeight);
		}
		LuaObject.addMember(l, name24, Lua_UnityEngine_Animator.<>f__mg$cache58, null, true);
		string name25 = "pivotPosition";
		if (Lua_UnityEngine_Animator.<>f__mg$cache59 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache59 = new LuaCSFunction(Lua_UnityEngine_Animator.get_pivotPosition);
		}
		LuaObject.addMember(l, name25, Lua_UnityEngine_Animator.<>f__mg$cache59, null, true);
		string name26 = "isMatchingTarget";
		if (Lua_UnityEngine_Animator.<>f__mg$cache5A == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache5A = new LuaCSFunction(Lua_UnityEngine_Animator.get_isMatchingTarget);
		}
		LuaObject.addMember(l, name26, Lua_UnityEngine_Animator.<>f__mg$cache5A, null, true);
		string name27 = "speed";
		if (Lua_UnityEngine_Animator.<>f__mg$cache5B == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache5B = new LuaCSFunction(Lua_UnityEngine_Animator.get_speed);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Animator.<>f__mg$cache5B;
		if (Lua_UnityEngine_Animator.<>f__mg$cache5C == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache5C = new LuaCSFunction(Lua_UnityEngine_Animator.set_speed);
		}
		LuaObject.addMember(l, name27, get10, Lua_UnityEngine_Animator.<>f__mg$cache5C, true);
		string name28 = "targetPosition";
		if (Lua_UnityEngine_Animator.<>f__mg$cache5D == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache5D = new LuaCSFunction(Lua_UnityEngine_Animator.get_targetPosition);
		}
		LuaObject.addMember(l, name28, Lua_UnityEngine_Animator.<>f__mg$cache5D, null, true);
		string name29 = "targetRotation";
		if (Lua_UnityEngine_Animator.<>f__mg$cache5E == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache5E = new LuaCSFunction(Lua_UnityEngine_Animator.get_targetRotation);
		}
		LuaObject.addMember(l, name29, Lua_UnityEngine_Animator.<>f__mg$cache5E, null, true);
		string name30 = "cullingMode";
		if (Lua_UnityEngine_Animator.<>f__mg$cache5F == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache5F = new LuaCSFunction(Lua_UnityEngine_Animator.get_cullingMode);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Animator.<>f__mg$cache5F;
		if (Lua_UnityEngine_Animator.<>f__mg$cache60 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache60 = new LuaCSFunction(Lua_UnityEngine_Animator.set_cullingMode);
		}
		LuaObject.addMember(l, name30, get11, Lua_UnityEngine_Animator.<>f__mg$cache60, true);
		string name31 = "playbackTime";
		if (Lua_UnityEngine_Animator.<>f__mg$cache61 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache61 = new LuaCSFunction(Lua_UnityEngine_Animator.get_playbackTime);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Animator.<>f__mg$cache61;
		if (Lua_UnityEngine_Animator.<>f__mg$cache62 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache62 = new LuaCSFunction(Lua_UnityEngine_Animator.set_playbackTime);
		}
		LuaObject.addMember(l, name31, get12, Lua_UnityEngine_Animator.<>f__mg$cache62, true);
		string name32 = "recorderStartTime";
		if (Lua_UnityEngine_Animator.<>f__mg$cache63 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache63 = new LuaCSFunction(Lua_UnityEngine_Animator.get_recorderStartTime);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Animator.<>f__mg$cache63;
		if (Lua_UnityEngine_Animator.<>f__mg$cache64 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache64 = new LuaCSFunction(Lua_UnityEngine_Animator.set_recorderStartTime);
		}
		LuaObject.addMember(l, name32, get13, Lua_UnityEngine_Animator.<>f__mg$cache64, true);
		string name33 = "recorderStopTime";
		if (Lua_UnityEngine_Animator.<>f__mg$cache65 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache65 = new LuaCSFunction(Lua_UnityEngine_Animator.get_recorderStopTime);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Animator.<>f__mg$cache65;
		if (Lua_UnityEngine_Animator.<>f__mg$cache66 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache66 = new LuaCSFunction(Lua_UnityEngine_Animator.set_recorderStopTime);
		}
		LuaObject.addMember(l, name33, get14, Lua_UnityEngine_Animator.<>f__mg$cache66, true);
		string name34 = "recorderMode";
		if (Lua_UnityEngine_Animator.<>f__mg$cache67 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache67 = new LuaCSFunction(Lua_UnityEngine_Animator.get_recorderMode);
		}
		LuaObject.addMember(l, name34, Lua_UnityEngine_Animator.<>f__mg$cache67, null, true);
		string name35 = "runtimeAnimatorController";
		if (Lua_UnityEngine_Animator.<>f__mg$cache68 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache68 = new LuaCSFunction(Lua_UnityEngine_Animator.get_runtimeAnimatorController);
		}
		LuaCSFunction get15 = Lua_UnityEngine_Animator.<>f__mg$cache68;
		if (Lua_UnityEngine_Animator.<>f__mg$cache69 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache69 = new LuaCSFunction(Lua_UnityEngine_Animator.set_runtimeAnimatorController);
		}
		LuaObject.addMember(l, name35, get15, Lua_UnityEngine_Animator.<>f__mg$cache69, true);
		string name36 = "hasBoundPlayables";
		if (Lua_UnityEngine_Animator.<>f__mg$cache6A == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache6A = new LuaCSFunction(Lua_UnityEngine_Animator.get_hasBoundPlayables);
		}
		LuaObject.addMember(l, name36, Lua_UnityEngine_Animator.<>f__mg$cache6A, null, true);
		string name37 = "avatar";
		if (Lua_UnityEngine_Animator.<>f__mg$cache6B == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache6B = new LuaCSFunction(Lua_UnityEngine_Animator.get_avatar);
		}
		LuaCSFunction get16 = Lua_UnityEngine_Animator.<>f__mg$cache6B;
		if (Lua_UnityEngine_Animator.<>f__mg$cache6C == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache6C = new LuaCSFunction(Lua_UnityEngine_Animator.set_avatar);
		}
		LuaObject.addMember(l, name37, get16, Lua_UnityEngine_Animator.<>f__mg$cache6C, true);
		string name38 = "playableGraph";
		if (Lua_UnityEngine_Animator.<>f__mg$cache6D == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache6D = new LuaCSFunction(Lua_UnityEngine_Animator.get_playableGraph);
		}
		LuaObject.addMember(l, name38, Lua_UnityEngine_Animator.<>f__mg$cache6D, null, true);
		string name39 = "layersAffectMassCenter";
		if (Lua_UnityEngine_Animator.<>f__mg$cache6E == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache6E = new LuaCSFunction(Lua_UnityEngine_Animator.get_layersAffectMassCenter);
		}
		LuaCSFunction get17 = Lua_UnityEngine_Animator.<>f__mg$cache6E;
		if (Lua_UnityEngine_Animator.<>f__mg$cache6F == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache6F = new LuaCSFunction(Lua_UnityEngine_Animator.set_layersAffectMassCenter);
		}
		LuaObject.addMember(l, name39, get17, Lua_UnityEngine_Animator.<>f__mg$cache6F, true);
		string name40 = "leftFeetBottomHeight";
		if (Lua_UnityEngine_Animator.<>f__mg$cache70 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache70 = new LuaCSFunction(Lua_UnityEngine_Animator.get_leftFeetBottomHeight);
		}
		LuaObject.addMember(l, name40, Lua_UnityEngine_Animator.<>f__mg$cache70, null, true);
		string name41 = "rightFeetBottomHeight";
		if (Lua_UnityEngine_Animator.<>f__mg$cache71 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache71 = new LuaCSFunction(Lua_UnityEngine_Animator.get_rightFeetBottomHeight);
		}
		LuaObject.addMember(l, name41, Lua_UnityEngine_Animator.<>f__mg$cache71, null, true);
		string name42 = "logWarnings";
		if (Lua_UnityEngine_Animator.<>f__mg$cache72 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache72 = new LuaCSFunction(Lua_UnityEngine_Animator.get_logWarnings);
		}
		LuaCSFunction get18 = Lua_UnityEngine_Animator.<>f__mg$cache72;
		if (Lua_UnityEngine_Animator.<>f__mg$cache73 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache73 = new LuaCSFunction(Lua_UnityEngine_Animator.set_logWarnings);
		}
		LuaObject.addMember(l, name42, get18, Lua_UnityEngine_Animator.<>f__mg$cache73, true);
		string name43 = "fireEvents";
		if (Lua_UnityEngine_Animator.<>f__mg$cache74 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache74 = new LuaCSFunction(Lua_UnityEngine_Animator.get_fireEvents);
		}
		LuaCSFunction get19 = Lua_UnityEngine_Animator.<>f__mg$cache74;
		if (Lua_UnityEngine_Animator.<>f__mg$cache75 == null)
		{
			Lua_UnityEngine_Animator.<>f__mg$cache75 = new LuaCSFunction(Lua_UnityEngine_Animator.set_fireEvents);
		}
		LuaObject.addMember(l, name43, get19, Lua_UnityEngine_Animator.<>f__mg$cache75, true);
		LuaObject.createTypeMetatable(l, null, typeof(Animator), typeof(Behaviour));
	}

	// Token: 0x04018AF5 RID: 101109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018AF6 RID: 101110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018AF7 RID: 101111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018AF8 RID: 101112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018AF9 RID: 101113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018AFA RID: 101114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018AFB RID: 101115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018AFC RID: 101116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018AFD RID: 101117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018AFE RID: 101118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018AFF RID: 101119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018B00 RID: 101120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018B01 RID: 101121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018B02 RID: 101122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018B03 RID: 101123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018B04 RID: 101124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018B05 RID: 101125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018B06 RID: 101126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018B07 RID: 101127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018B08 RID: 101128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018B09 RID: 101129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018B0A RID: 101130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018B0B RID: 101131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018B0C RID: 101132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018B0D RID: 101133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018B0E RID: 101134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018B0F RID: 101135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018B10 RID: 101136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018B11 RID: 101137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018B12 RID: 101138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018B13 RID: 101139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018B14 RID: 101140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018B15 RID: 101141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018B16 RID: 101142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018B17 RID: 101143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018B18 RID: 101144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04018B19 RID: 101145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04018B1A RID: 101146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04018B1B RID: 101147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04018B1C RID: 101148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04018B1D RID: 101149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04018B1E RID: 101150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04018B1F RID: 101151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04018B20 RID: 101152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04018B21 RID: 101153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04018B22 RID: 101154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04018B23 RID: 101155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04018B24 RID: 101156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04018B25 RID: 101157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04018B26 RID: 101158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04018B27 RID: 101159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04018B28 RID: 101160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04018B29 RID: 101161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04018B2A RID: 101162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04018B2B RID: 101163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04018B2C RID: 101164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04018B2D RID: 101165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04018B2E RID: 101166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04018B2F RID: 101167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04018B30 RID: 101168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04018B31 RID: 101169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04018B32 RID: 101170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04018B33 RID: 101171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04018B34 RID: 101172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04018B35 RID: 101173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04018B36 RID: 101174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04018B37 RID: 101175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04018B38 RID: 101176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04018B39 RID: 101177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04018B3A RID: 101178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04018B3B RID: 101179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04018B3C RID: 101180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04018B3D RID: 101181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04018B3E RID: 101182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04018B3F RID: 101183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04018B40 RID: 101184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04018B41 RID: 101185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04018B42 RID: 101186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04018B43 RID: 101187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04018B44 RID: 101188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04018B45 RID: 101189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04018B46 RID: 101190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04018B47 RID: 101191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04018B48 RID: 101192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04018B49 RID: 101193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04018B4A RID: 101194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04018B4B RID: 101195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04018B4C RID: 101196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04018B4D RID: 101197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04018B4E RID: 101198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04018B4F RID: 101199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04018B50 RID: 101200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04018B51 RID: 101201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04018B52 RID: 101202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04018B53 RID: 101203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04018B54 RID: 101204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04018B55 RID: 101205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04018B56 RID: 101206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04018B57 RID: 101207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04018B58 RID: 101208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04018B59 RID: 101209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04018B5A RID: 101210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04018B5B RID: 101211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04018B5C RID: 101212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04018B5D RID: 101213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04018B5E RID: 101214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04018B5F RID: 101215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04018B60 RID: 101216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04018B61 RID: 101217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04018B62 RID: 101218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04018B63 RID: 101219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04018B64 RID: 101220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04018B65 RID: 101221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04018B66 RID: 101222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04018B67 RID: 101223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04018B68 RID: 101224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04018B69 RID: 101225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04018B6A RID: 101226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;
}
