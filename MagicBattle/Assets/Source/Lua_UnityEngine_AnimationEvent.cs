using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001613 RID: 5651
[Preserve]
public class Lua_UnityEngine_AnimationEvent : LuaObject
{
	// Token: 0x06022A3B RID: 141883 RVA: 0x00BEF0C8 File Offset: 0x00BED2C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent o = new AnimationEvent();
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

	// Token: 0x06022A3C RID: 141884 RVA: 0x00BEF110 File Offset: 0x00BED310
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_stringParameter(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationEvent.stringParameter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A3D RID: 141885 RVA: 0x00BEF164 File Offset: 0x00BED364
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_stringParameter(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			string stringParameter;
			LuaObject.checkType(l, 2, out stringParameter);
			animationEvent.stringParameter = stringParameter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A3E RID: 141886 RVA: 0x00BEF1BC File Offset: 0x00BED3BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_floatParameter(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationEvent.floatParameter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A3F RID: 141887 RVA: 0x00BEF210 File Offset: 0x00BED410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_floatParameter(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			float floatParameter;
			LuaObject.checkType(l, 2, out floatParameter);
			animationEvent.floatParameter = floatParameter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A40 RID: 141888 RVA: 0x00BEF268 File Offset: 0x00BED468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_intParameter(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationEvent.intParameter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A41 RID: 141889 RVA: 0x00BEF2BC File Offset: 0x00BED4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_intParameter(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			int intParameter;
			LuaObject.checkType(l, 2, out intParameter);
			animationEvent.intParameter = intParameter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A42 RID: 141890 RVA: 0x00BEF314 File Offset: 0x00BED514
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_objectReferenceParameter(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationEvent.objectReferenceParameter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A43 RID: 141891 RVA: 0x00BEF368 File Offset: 0x00BED568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_objectReferenceParameter(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			UnityEngine.Object objectReferenceParameter;
			LuaObject.checkType<UnityEngine.Object>(l, 2, out objectReferenceParameter);
			animationEvent.objectReferenceParameter = objectReferenceParameter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A44 RID: 141892 RVA: 0x00BEF3C0 File Offset: 0x00BED5C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_functionName(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationEvent.functionName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A45 RID: 141893 RVA: 0x00BEF414 File Offset: 0x00BED614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_functionName(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			string functionName;
			LuaObject.checkType(l, 2, out functionName);
			animationEvent.functionName = functionName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A46 RID: 141894 RVA: 0x00BEF46C File Offset: 0x00BED66C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_time(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationEvent.time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A47 RID: 141895 RVA: 0x00BEF4C0 File Offset: 0x00BED6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_time(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			animationEvent.time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A48 RID: 141896 RVA: 0x00BEF518 File Offset: 0x00BED718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_messageOptions(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animationEvent.messageOptions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A49 RID: 141897 RVA: 0x00BEF56C File Offset: 0x00BED76C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_messageOptions(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			SendMessageOptions messageOptions;
			LuaObject.checkEnum<SendMessageOptions>(l, 2, out messageOptions);
			animationEvent.messageOptions = messageOptions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A4A RID: 141898 RVA: 0x00BEF5C4 File Offset: 0x00BED7C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isFiredByLegacy(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationEvent.isFiredByLegacy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A4B RID: 141899 RVA: 0x00BEF618 File Offset: 0x00BED818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isFiredByAnimator(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationEvent.isFiredByAnimator);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A4C RID: 141900 RVA: 0x00BEF66C File Offset: 0x00BED86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_animationState(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationEvent.animationState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A4D RID: 141901 RVA: 0x00BEF6C0 File Offset: 0x00BED8C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_animatorStateInfo(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationEvent.animatorStateInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A4E RID: 141902 RVA: 0x00BEF718 File Offset: 0x00BED918
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_animatorClipInfo(IntPtr l)
	{
		int result;
		try
		{
			AnimationEvent animationEvent = (AnimationEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationEvent.animatorClipInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A4F RID: 141903 RVA: 0x00BEF770 File Offset: 0x00BED970
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AnimationEvent");
		string name = "stringParameter";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_stringParameter);
		}
		LuaCSFunction get = Lua_UnityEngine_AnimationEvent.<>f__mg$cache0;
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.set_stringParameter);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_AnimationEvent.<>f__mg$cache1, true);
		string name2 = "floatParameter";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_floatParameter);
		}
		LuaCSFunction get2 = Lua_UnityEngine_AnimationEvent.<>f__mg$cache2;
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.set_floatParameter);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_AnimationEvent.<>f__mg$cache3, true);
		string name3 = "intParameter";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_intParameter);
		}
		LuaCSFunction get3 = Lua_UnityEngine_AnimationEvent.<>f__mg$cache4;
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.set_intParameter);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_AnimationEvent.<>f__mg$cache5, true);
		string name4 = "objectReferenceParameter";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_objectReferenceParameter);
		}
		LuaCSFunction get4 = Lua_UnityEngine_AnimationEvent.<>f__mg$cache6;
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.set_objectReferenceParameter);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_AnimationEvent.<>f__mg$cache7, true);
		string name5 = "functionName";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_functionName);
		}
		LuaCSFunction get5 = Lua_UnityEngine_AnimationEvent.<>f__mg$cache8;
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.set_functionName);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_AnimationEvent.<>f__mg$cache9, true);
		string name6 = "time";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_time);
		}
		LuaCSFunction get6 = Lua_UnityEngine_AnimationEvent.<>f__mg$cacheA;
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.set_time);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_AnimationEvent.<>f__mg$cacheB, true);
		string name7 = "messageOptions";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_messageOptions);
		}
		LuaCSFunction get7 = Lua_UnityEngine_AnimationEvent.<>f__mg$cacheC;
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.set_messageOptions);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_AnimationEvent.<>f__mg$cacheD, true);
		string name8 = "isFiredByLegacy";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_isFiredByLegacy);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_AnimationEvent.<>f__mg$cacheE, null, true);
		string name9 = "isFiredByAnimator";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_isFiredByAnimator);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_AnimationEvent.<>f__mg$cacheF, null, true);
		string name10 = "animationState";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_animationState);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_AnimationEvent.<>f__mg$cache10, null, true);
		string name11 = "animatorStateInfo";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_animatorStateInfo);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_AnimationEvent.<>f__mg$cache11, null, true);
		string name12 = "animatorClipInfo";
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.get_animatorClipInfo);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_AnimationEvent.<>f__mg$cache12, null, true);
		if (Lua_UnityEngine_AnimationEvent.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_AnimationEvent.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_AnimationEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AnimationEvent.<>f__mg$cache13, typeof(AnimationEvent));
	}

	// Token: 0x04018A73 RID: 100979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018A74 RID: 100980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018A75 RID: 100981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018A76 RID: 100982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018A77 RID: 100983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018A78 RID: 100984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018A79 RID: 100985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018A7A RID: 100986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018A7B RID: 100987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018A7C RID: 100988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018A7D RID: 100989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018A7E RID: 100990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018A7F RID: 100991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018A80 RID: 100992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018A81 RID: 100993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018A82 RID: 100994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018A83 RID: 100995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018A84 RID: 100996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018A85 RID: 100997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018A86 RID: 100998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
