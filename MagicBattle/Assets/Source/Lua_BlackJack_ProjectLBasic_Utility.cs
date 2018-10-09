using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectLBasic;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020015F0 RID: 5616
[Preserve]
public class Lua_BlackJack_ProjectLBasic_Utility : LuaObject
{
	// Token: 0x060227BF RID: 141247 RVA: 0x00BD305C File Offset: 0x00BD125C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Utility o = new Utility();
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

	// Token: 0x060227C0 RID: 141248 RVA: 0x00BD30A4 File Offset: 0x00BD12A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogMemorySize_s(IntPtr l)
	{
		int result;
		try
		{
			string prefix;
			LuaObject.checkType(l, 1, out prefix);
			Utility.LogMemorySize(prefix);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227C1 RID: 141249 RVA: 0x00BD30F0 File Offset: 0x00BD12F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUpdateClientURL_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject parentObj;
			LuaObject.checkType<GameObject>(l, 1, out parentObj);
			IEnumerator updateClientURL = Utility.GetUpdateClientURL(parentObj);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, updateClientURL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227C2 RID: 141250 RVA: 0x00BD3144 File Offset: 0x00BD1344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRuntimeMemorySize_s(IntPtr l)
	{
		int result;
		try
		{
			long runtimeMemorySize = Utility.GetRuntimeMemorySize();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, runtimeMemorySize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227C3 RID: 141251 RVA: 0x00BD318C File Offset: 0x00BD138C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResizeTexture_s(IntPtr l)
	{
		int result;
		try
		{
			Texture2D pSource;
			LuaObject.checkType<Texture2D>(l, 1, out pSource);
			ImageFilterMode pFilterMode;
			LuaObject.checkEnum<ImageFilterMode>(l, 2, out pFilterMode);
			float pScale;
			LuaObject.checkType(l, 3, out pScale);
			Texture2D o = Utility.ResizeTexture(pSource, pFilterMode, pScale);
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

	// Token: 0x060227C4 RID: 141252 RVA: 0x00BD31FC File Offset: 0x00BD13FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateOpen_s(IntPtr l)
	{
		int result;
		try
		{
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 1, out ctrl);
			string stateName;
			LuaObject.checkType(l, 2, out stateName);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			Action<bool> enableInput;
			LuaObject.checkDelegate<Action<bool>>(l, 4, out enableInput);
			bool allowToRefreshSameState;
			LuaObject.checkType(l, 5, out allowToRefreshSameState);
			Utility.SetUIStateOpen(ctrl, stateName, onEnd, enableInput, allowToRefreshSameState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227C5 RID: 141253 RVA: 0x00BD3278 File Offset: 0x00BD1478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIStateClose_s(IntPtr l)
	{
		int result;
		try
		{
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 1, out ctrl);
			string stateName;
			LuaObject.checkType(l, 2, out stateName);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 3, out onEnd);
			Action<bool> enableInput;
			LuaObject.checkDelegate<Action<bool>>(l, 4, out enableInput);
			bool allowToRefreshSameState;
			LuaObject.checkType(l, 5, out allowToRefreshSameState);
			Utility.SetUIStateClose(ctrl, stateName, onEnd, enableInput, allowToRefreshSameState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227C6 RID: 141254 RVA: 0x00BD32F4 File Offset: 0x00BD14F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindChildComponent_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool warning;
			LuaObject.checkType(l, 3, out warning);
			Component o = Utility.FindChildComponent<Component>(go, name, warning);
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

	// Token: 0x060227C7 RID: 141255 RVA: 0x00BD3364 File Offset: 0x00BD1564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindChildGameObject_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool warning;
			LuaObject.checkType(l, 3, out warning);
			GameObject o = Utility.FindChildGameObject(go, name, warning);
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

	// Token: 0x060227C8 RID: 141256 RVA: 0x00BD33D4 File Offset: 0x00BD15D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectLBasic.Utility");
		if (Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_Utility.LogMemorySize_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_Utility.GetUpdateClientURL_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_Utility.GetRuntimeMemorySize_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_Utility.ResizeTexture_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_Utility.SetUIStateOpen_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_Utility.SetUIStateClose_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_Utility.FindChildComponent_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_Utility.FindChildGameObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectLBasic_Utility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectLBasic_Utility.<>f__mg$cache8, typeof(Utility));
	}

	// Token: 0x040185C1 RID: 99777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185C2 RID: 99778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185C3 RID: 99779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040185C4 RID: 99780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040185C5 RID: 99781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040185C6 RID: 99782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040185C7 RID: 99783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040185C8 RID: 99784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040185C9 RID: 99785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
