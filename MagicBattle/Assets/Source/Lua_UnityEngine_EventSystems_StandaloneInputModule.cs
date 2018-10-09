using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016C3 RID: 5827
[Preserve]
public class Lua_UnityEngine_EventSystems_StandaloneInputModule : LuaObject
{
	// Token: 0x060231FB RID: 143867 RVA: 0x00C2AD70 File Offset: 0x00C28F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateModule(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			standaloneInputModule.UpdateModule();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231FC RID: 143868 RVA: 0x00C2ADBC File Offset: 0x00C28FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsModuleSupported(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			bool b = standaloneInputModule.IsModuleSupported();
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

	// Token: 0x060231FD RID: 143869 RVA: 0x00C2AE10 File Offset: 0x00C29010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShouldActivateModule(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			bool b = standaloneInputModule.ShouldActivateModule();
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

	// Token: 0x060231FE RID: 143870 RVA: 0x00C2AE64 File Offset: 0x00C29064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActivateModule(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			standaloneInputModule.ActivateModule();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231FF RID: 143871 RVA: 0x00C2AEB0 File Offset: 0x00C290B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeactivateModule(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			standaloneInputModule.DeactivateModule();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023200 RID: 143872 RVA: 0x00C2AEFC File Offset: 0x00C290FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Process(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			standaloneInputModule.Process();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023201 RID: 143873 RVA: 0x00C2AF48 File Offset: 0x00C29148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_forceModuleActive(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, standaloneInputModule.forceModuleActive);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023202 RID: 143874 RVA: 0x00C2AF9C File Offset: 0x00C2919C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_forceModuleActive(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			bool forceModuleActive;
			LuaObject.checkType(l, 2, out forceModuleActive);
			standaloneInputModule.forceModuleActive = forceModuleActive;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023203 RID: 143875 RVA: 0x00C2AFF4 File Offset: 0x00C291F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inputActionsPerSecond(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, standaloneInputModule.inputActionsPerSecond);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023204 RID: 143876 RVA: 0x00C2B048 File Offset: 0x00C29248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_inputActionsPerSecond(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			float inputActionsPerSecond;
			LuaObject.checkType(l, 2, out inputActionsPerSecond);
			standaloneInputModule.inputActionsPerSecond = inputActionsPerSecond;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023205 RID: 143877 RVA: 0x00C2B0A0 File Offset: 0x00C292A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_repeatDelay(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, standaloneInputModule.repeatDelay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023206 RID: 143878 RVA: 0x00C2B0F4 File Offset: 0x00C292F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_repeatDelay(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			float repeatDelay;
			LuaObject.checkType(l, 2, out repeatDelay);
			standaloneInputModule.repeatDelay = repeatDelay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023207 RID: 143879 RVA: 0x00C2B14C File Offset: 0x00C2934C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_horizontalAxis(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, standaloneInputModule.horizontalAxis);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023208 RID: 143880 RVA: 0x00C2B1A0 File Offset: 0x00C293A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_horizontalAxis(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			string horizontalAxis;
			LuaObject.checkType(l, 2, out horizontalAxis);
			standaloneInputModule.horizontalAxis = horizontalAxis;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023209 RID: 143881 RVA: 0x00C2B1F8 File Offset: 0x00C293F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_verticalAxis(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, standaloneInputModule.verticalAxis);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602320A RID: 143882 RVA: 0x00C2B24C File Offset: 0x00C2944C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_verticalAxis(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			string verticalAxis;
			LuaObject.checkType(l, 2, out verticalAxis);
			standaloneInputModule.verticalAxis = verticalAxis;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602320B RID: 143883 RVA: 0x00C2B2A4 File Offset: 0x00C294A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_submitButton(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, standaloneInputModule.submitButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602320C RID: 143884 RVA: 0x00C2B2F8 File Offset: 0x00C294F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_submitButton(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			string submitButton;
			LuaObject.checkType(l, 2, out submitButton);
			standaloneInputModule.submitButton = submitButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602320D RID: 143885 RVA: 0x00C2B350 File Offset: 0x00C29550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, standaloneInputModule.cancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602320E RID: 143886 RVA: 0x00C2B3A4 File Offset: 0x00C295A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			StandaloneInputModule standaloneInputModule = (StandaloneInputModule)LuaObject.checkSelf(l);
			string cancelButton;
			LuaObject.checkType(l, 2, out cancelButton);
			standaloneInputModule.cancelButton = cancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602320F RID: 143887 RVA: 0x00C2B3FC File Offset: 0x00C295FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.StandaloneInputModule");
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.UpdateModule);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache0);
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.IsModuleSupported);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache1);
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.ShouldActivateModule);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache2);
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.ActivateModule);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache3);
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.DeactivateModule);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache4);
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.Process);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache5);
		string name = "forceModuleActive";
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.get_forceModuleActive);
		}
		LuaCSFunction get = Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache6;
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.set_forceModuleActive);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache7, true);
		string name2 = "inputActionsPerSecond";
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.get_inputActionsPerSecond);
		}
		LuaCSFunction get2 = Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache8;
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.set_inputActionsPerSecond);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache9, true);
		string name3 = "repeatDelay";
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.get_repeatDelay);
		}
		LuaCSFunction get3 = Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheA;
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.set_repeatDelay);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheB, true);
		string name4 = "horizontalAxis";
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.get_horizontalAxis);
		}
		LuaCSFunction get4 = Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheC;
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.set_horizontalAxis);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheD, true);
		string name5 = "verticalAxis";
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.get_verticalAxis);
		}
		LuaCSFunction get5 = Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheE;
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.set_verticalAxis);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cacheF, true);
		string name6 = "submitButton";
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.get_submitButton);
		}
		LuaCSFunction get6 = Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache10;
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.set_submitButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache11, true);
		string name7 = "cancelButton";
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.get_cancelButton);
		}
		LuaCSFunction get7 = Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache12;
		if (Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_EventSystems_StandaloneInputModule.set_cancelButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_EventSystems_StandaloneInputModule.<>f__mg$cache13, true);
		LuaObject.createTypeMetatable(l, null, typeof(StandaloneInputModule), typeof(PointerInputModule));
	}

	// Token: 0x040190D3 RID: 102611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040190D4 RID: 102612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040190D5 RID: 102613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040190D6 RID: 102614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040190D7 RID: 102615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040190D8 RID: 102616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040190D9 RID: 102617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040190DA RID: 102618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040190DB RID: 102619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040190DC RID: 102620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040190DD RID: 102621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040190DE RID: 102622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040190DF RID: 102623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040190E0 RID: 102624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040190E1 RID: 102625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040190E2 RID: 102626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040190E3 RID: 102627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040190E4 RID: 102628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040190E5 RID: 102629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040190E6 RID: 102630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
