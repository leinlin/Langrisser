using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001760 RID: 5984
[Preserve]
public class Lua_UnityEngine_Projector : LuaObject
{
	// Token: 0x060238AB RID: 145579 RVA: 0x00C69530 File Offset: 0x00C67730
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_nearClipPlane(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, projector.nearClipPlane);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238AC RID: 145580 RVA: 0x00C69584 File Offset: 0x00C67784
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_nearClipPlane(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			float nearClipPlane;
			LuaObject.checkType(l, 2, out nearClipPlane);
			projector.nearClipPlane = nearClipPlane;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238AD RID: 145581 RVA: 0x00C695DC File Offset: 0x00C677DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_farClipPlane(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, projector.farClipPlane);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238AE RID: 145582 RVA: 0x00C69630 File Offset: 0x00C67830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_farClipPlane(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			float farClipPlane;
			LuaObject.checkType(l, 2, out farClipPlane);
			projector.farClipPlane = farClipPlane;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238AF RID: 145583 RVA: 0x00C69688 File Offset: 0x00C67888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fieldOfView(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, projector.fieldOfView);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238B0 RID: 145584 RVA: 0x00C696DC File Offset: 0x00C678DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fieldOfView(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			float fieldOfView;
			LuaObject.checkType(l, 2, out fieldOfView);
			projector.fieldOfView = fieldOfView;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238B1 RID: 145585 RVA: 0x00C69734 File Offset: 0x00C67934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_aspectRatio(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, projector.aspectRatio);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238B2 RID: 145586 RVA: 0x00C69788 File Offset: 0x00C67988
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_aspectRatio(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			float aspectRatio;
			LuaObject.checkType(l, 2, out aspectRatio);
			projector.aspectRatio = aspectRatio;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238B3 RID: 145587 RVA: 0x00C697E0 File Offset: 0x00C679E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_orthographic(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, projector.orthographic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238B4 RID: 145588 RVA: 0x00C69834 File Offset: 0x00C67A34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_orthographic(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			bool orthographic;
			LuaObject.checkType(l, 2, out orthographic);
			projector.orthographic = orthographic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238B5 RID: 145589 RVA: 0x00C6988C File Offset: 0x00C67A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_orthographicSize(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, projector.orthographicSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238B6 RID: 145590 RVA: 0x00C698E0 File Offset: 0x00C67AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_orthographicSize(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			float orthographicSize;
			LuaObject.checkType(l, 2, out orthographicSize);
			projector.orthographicSize = orthographicSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238B7 RID: 145591 RVA: 0x00C69938 File Offset: 0x00C67B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ignoreLayers(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, projector.ignoreLayers);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238B8 RID: 145592 RVA: 0x00C6998C File Offset: 0x00C67B8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ignoreLayers(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			int ignoreLayers;
			LuaObject.checkType(l, 2, out ignoreLayers);
			projector.ignoreLayers = ignoreLayers;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238B9 RID: 145593 RVA: 0x00C699E4 File Offset: 0x00C67BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_material(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, projector.material);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238BA RID: 145594 RVA: 0x00C69A38 File Offset: 0x00C67C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_material(IntPtr l)
	{
		int result;
		try
		{
			Projector projector = (Projector)LuaObject.checkSelf(l);
			Material material;
			LuaObject.checkType<Material>(l, 2, out material);
			projector.material = material;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238BB RID: 145595 RVA: 0x00C69A90 File Offset: 0x00C67C90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Projector");
		string name = "nearClipPlane";
		if (Lua_UnityEngine_Projector.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Projector.get_nearClipPlane);
		}
		LuaCSFunction get = Lua_UnityEngine_Projector.<>f__mg$cache0;
		if (Lua_UnityEngine_Projector.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Projector.set_nearClipPlane);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Projector.<>f__mg$cache1, true);
		string name2 = "farClipPlane";
		if (Lua_UnityEngine_Projector.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Projector.get_farClipPlane);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Projector.<>f__mg$cache2;
		if (Lua_UnityEngine_Projector.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Projector.set_farClipPlane);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Projector.<>f__mg$cache3, true);
		string name3 = "fieldOfView";
		if (Lua_UnityEngine_Projector.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Projector.get_fieldOfView);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Projector.<>f__mg$cache4;
		if (Lua_UnityEngine_Projector.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Projector.set_fieldOfView);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Projector.<>f__mg$cache5, true);
		string name4 = "aspectRatio";
		if (Lua_UnityEngine_Projector.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Projector.get_aspectRatio);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Projector.<>f__mg$cache6;
		if (Lua_UnityEngine_Projector.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Projector.set_aspectRatio);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Projector.<>f__mg$cache7, true);
		string name5 = "orthographic";
		if (Lua_UnityEngine_Projector.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Projector.get_orthographic);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Projector.<>f__mg$cache8;
		if (Lua_UnityEngine_Projector.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Projector.set_orthographic);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Projector.<>f__mg$cache9, true);
		string name6 = "orthographicSize";
		if (Lua_UnityEngine_Projector.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Projector.get_orthographicSize);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Projector.<>f__mg$cacheA;
		if (Lua_UnityEngine_Projector.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Projector.set_orthographicSize);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_Projector.<>f__mg$cacheB, true);
		string name7 = "ignoreLayers";
		if (Lua_UnityEngine_Projector.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Projector.get_ignoreLayers);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Projector.<>f__mg$cacheC;
		if (Lua_UnityEngine_Projector.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Projector.set_ignoreLayers);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_Projector.<>f__mg$cacheD, true);
		string name8 = "material";
		if (Lua_UnityEngine_Projector.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Projector.get_material);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Projector.<>f__mg$cacheE;
		if (Lua_UnityEngine_Projector.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Projector.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Projector.set_material);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_Projector.<>f__mg$cacheF, true);
		LuaObject.createTypeMetatable(l, null, typeof(Projector), typeof(Behaviour));
	}

	// Token: 0x04019649 RID: 104009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401964A RID: 104010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401964B RID: 104011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401964C RID: 104012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401964D RID: 104013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401964E RID: 104014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401964F RID: 104015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019650 RID: 104016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019651 RID: 104017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019652 RID: 104018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019653 RID: 104019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019654 RID: 104020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019655 RID: 104021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019656 RID: 104022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019657 RID: 104023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019658 RID: 104024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
