using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Scripting;

// Token: 0x020017EC RID: 6124
[Preserve]
public class Lua_UnityEngine_StateMachineBehaviour : LuaObject
{
	// Token: 0x06023DD5 RID: 146901 RVA: 0x00C922BC File Offset: 0x00C904BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStateEnter(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				StateMachineBehaviour stateMachineBehaviour = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator;
				LuaObject.checkType<Animator>(l, 2, out animator);
				AnimatorStateInfo stateInfo;
				LuaObject.checkValueType<AnimatorStateInfo>(l, 3, out stateInfo);
				int layerIndex;
				LuaObject.checkType(l, 4, out layerIndex);
				stateMachineBehaviour.OnStateEnter(animator, stateInfo, layerIndex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				StateMachineBehaviour stateMachineBehaviour2 = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator2;
				LuaObject.checkType<Animator>(l, 2, out animator2);
				AnimatorStateInfo stateInfo2;
				LuaObject.checkValueType<AnimatorStateInfo>(l, 3, out stateInfo2);
				int layerIndex2;
				LuaObject.checkType(l, 4, out layerIndex2);
				AnimatorControllerPlayable controller;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 5, out controller);
				stateMachineBehaviour2.OnStateEnter(animator2, stateInfo2, layerIndex2, controller);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnStateEnter to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DD6 RID: 146902 RVA: 0x00C923B4 File Offset: 0x00C905B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStateUpdate(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				StateMachineBehaviour stateMachineBehaviour = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator;
				LuaObject.checkType<Animator>(l, 2, out animator);
				AnimatorStateInfo stateInfo;
				LuaObject.checkValueType<AnimatorStateInfo>(l, 3, out stateInfo);
				int layerIndex;
				LuaObject.checkType(l, 4, out layerIndex);
				stateMachineBehaviour.OnStateUpdate(animator, stateInfo, layerIndex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				StateMachineBehaviour stateMachineBehaviour2 = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator2;
				LuaObject.checkType<Animator>(l, 2, out animator2);
				AnimatorStateInfo stateInfo2;
				LuaObject.checkValueType<AnimatorStateInfo>(l, 3, out stateInfo2);
				int layerIndex2;
				LuaObject.checkType(l, 4, out layerIndex2);
				AnimatorControllerPlayable controller;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 5, out controller);
				stateMachineBehaviour2.OnStateUpdate(animator2, stateInfo2, layerIndex2, controller);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnStateUpdate to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DD7 RID: 146903 RVA: 0x00C924AC File Offset: 0x00C906AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStateExit(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				StateMachineBehaviour stateMachineBehaviour = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator;
				LuaObject.checkType<Animator>(l, 2, out animator);
				AnimatorStateInfo stateInfo;
				LuaObject.checkValueType<AnimatorStateInfo>(l, 3, out stateInfo);
				int layerIndex;
				LuaObject.checkType(l, 4, out layerIndex);
				stateMachineBehaviour.OnStateExit(animator, stateInfo, layerIndex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				StateMachineBehaviour stateMachineBehaviour2 = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator2;
				LuaObject.checkType<Animator>(l, 2, out animator2);
				AnimatorStateInfo stateInfo2;
				LuaObject.checkValueType<AnimatorStateInfo>(l, 3, out stateInfo2);
				int layerIndex2;
				LuaObject.checkType(l, 4, out layerIndex2);
				AnimatorControllerPlayable controller;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 5, out controller);
				stateMachineBehaviour2.OnStateExit(animator2, stateInfo2, layerIndex2, controller);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnStateExit to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DD8 RID: 146904 RVA: 0x00C925A4 File Offset: 0x00C907A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStateMove(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				StateMachineBehaviour stateMachineBehaviour = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator;
				LuaObject.checkType<Animator>(l, 2, out animator);
				AnimatorStateInfo stateInfo;
				LuaObject.checkValueType<AnimatorStateInfo>(l, 3, out stateInfo);
				int layerIndex;
				LuaObject.checkType(l, 4, out layerIndex);
				stateMachineBehaviour.OnStateMove(animator, stateInfo, layerIndex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				StateMachineBehaviour stateMachineBehaviour2 = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator2;
				LuaObject.checkType<Animator>(l, 2, out animator2);
				AnimatorStateInfo stateInfo2;
				LuaObject.checkValueType<AnimatorStateInfo>(l, 3, out stateInfo2);
				int layerIndex2;
				LuaObject.checkType(l, 4, out layerIndex2);
				AnimatorControllerPlayable controller;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 5, out controller);
				stateMachineBehaviour2.OnStateMove(animator2, stateInfo2, layerIndex2, controller);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnStateMove to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DD9 RID: 146905 RVA: 0x00C9269C File Offset: 0x00C9089C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStateIK(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				StateMachineBehaviour stateMachineBehaviour = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator;
				LuaObject.checkType<Animator>(l, 2, out animator);
				AnimatorStateInfo stateInfo;
				LuaObject.checkValueType<AnimatorStateInfo>(l, 3, out stateInfo);
				int layerIndex;
				LuaObject.checkType(l, 4, out layerIndex);
				stateMachineBehaviour.OnStateIK(animator, stateInfo, layerIndex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				StateMachineBehaviour stateMachineBehaviour2 = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator2;
				LuaObject.checkType<Animator>(l, 2, out animator2);
				AnimatorStateInfo stateInfo2;
				LuaObject.checkValueType<AnimatorStateInfo>(l, 3, out stateInfo2);
				int layerIndex2;
				LuaObject.checkType(l, 4, out layerIndex2);
				AnimatorControllerPlayable controller;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 5, out controller);
				stateMachineBehaviour2.OnStateIK(animator2, stateInfo2, layerIndex2, controller);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnStateIK to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DDA RID: 146906 RVA: 0x00C92794 File Offset: 0x00C90994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStateMachineEnter(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				StateMachineBehaviour stateMachineBehaviour = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator;
				LuaObject.checkType<Animator>(l, 2, out animator);
				int stateMachinePathHash;
				LuaObject.checkType(l, 3, out stateMachinePathHash);
				stateMachineBehaviour.OnStateMachineEnter(animator, stateMachinePathHash);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				StateMachineBehaviour stateMachineBehaviour2 = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator2;
				LuaObject.checkType<Animator>(l, 2, out animator2);
				int stateMachinePathHash2;
				LuaObject.checkType(l, 3, out stateMachinePathHash2);
				AnimatorControllerPlayable controller;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 4, out controller);
				stateMachineBehaviour2.OnStateMachineEnter(animator2, stateMachinePathHash2, controller);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnStateMachineEnter to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DDB RID: 146907 RVA: 0x00C92874 File Offset: 0x00C90A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStateMachineExit(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				StateMachineBehaviour stateMachineBehaviour = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator;
				LuaObject.checkType<Animator>(l, 2, out animator);
				int stateMachinePathHash;
				LuaObject.checkType(l, 3, out stateMachinePathHash);
				stateMachineBehaviour.OnStateMachineExit(animator, stateMachinePathHash);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				StateMachineBehaviour stateMachineBehaviour2 = (StateMachineBehaviour)LuaObject.checkSelf(l);
				Animator animator2;
				LuaObject.checkType<Animator>(l, 2, out animator2);
				int stateMachinePathHash2;
				LuaObject.checkType(l, 3, out stateMachinePathHash2);
				AnimatorControllerPlayable controller;
				LuaObject.checkValueType<AnimatorControllerPlayable>(l, 4, out controller);
				stateMachineBehaviour2.OnStateMachineExit(animator2, stateMachinePathHash2, controller);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function OnStateMachineExit to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DDC RID: 146908 RVA: 0x00C92954 File Offset: 0x00C90B54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.StateMachineBehaviour");
		if (Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_StateMachineBehaviour.OnStateEnter);
		}
		LuaObject.addMember(l, Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache0);
		if (Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_StateMachineBehaviour.OnStateUpdate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache1);
		if (Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_StateMachineBehaviour.OnStateExit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache2);
		if (Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_StateMachineBehaviour.OnStateMove);
		}
		LuaObject.addMember(l, Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache3);
		if (Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_StateMachineBehaviour.OnStateIK);
		}
		LuaObject.addMember(l, Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache4);
		if (Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_StateMachineBehaviour.OnStateMachineEnter);
		}
		LuaObject.addMember(l, Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache5);
		if (Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_StateMachineBehaviour.OnStateMachineExit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_StateMachineBehaviour.<>f__mg$cache6);
		LuaObject.createTypeMetatable(l, null, typeof(StateMachineBehaviour), typeof(ScriptableObject));
	}

	// Token: 0x04019A5B RID: 105051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A5C RID: 105052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A5D RID: 105053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A5E RID: 105054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019A5F RID: 105055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019A60 RID: 105056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019A61 RID: 105057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
