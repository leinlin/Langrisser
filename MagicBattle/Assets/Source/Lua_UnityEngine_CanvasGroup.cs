using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001652 RID: 5714
[Preserve]
public class Lua_UnityEngine_CanvasGroup : LuaObject
{
	// Token: 0x06022DB5 RID: 142773 RVA: 0x00C0BC18 File Offset: 0x00C09E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRaycastLocationValid(IntPtr l)
	{
		int result;
		try
		{
			CanvasGroup canvasGroup = (CanvasGroup)LuaObject.checkSelf(l);
			Vector2 sp;
			LuaObject.checkType(l, 2, out sp);
			Camera eventCamera;
			LuaObject.checkType<Camera>(l, 3, out eventCamera);
			bool b = canvasGroup.IsRaycastLocationValid(sp, eventCamera);
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

	// Token: 0x06022DB6 RID: 142774 RVA: 0x00C0BC88 File Offset: 0x00C09E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alpha(IntPtr l)
	{
		int result;
		try
		{
			CanvasGroup canvasGroup = (CanvasGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasGroup.alpha);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DB7 RID: 142775 RVA: 0x00C0BCDC File Offset: 0x00C09EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alpha(IntPtr l)
	{
		int result;
		try
		{
			CanvasGroup canvasGroup = (CanvasGroup)LuaObject.checkSelf(l);
			float alpha;
			LuaObject.checkType(l, 2, out alpha);
			canvasGroup.alpha = alpha;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DB8 RID: 142776 RVA: 0x00C0BD34 File Offset: 0x00C09F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_interactable(IntPtr l)
	{
		int result;
		try
		{
			CanvasGroup canvasGroup = (CanvasGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasGroup.interactable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DB9 RID: 142777 RVA: 0x00C0BD88 File Offset: 0x00C09F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_interactable(IntPtr l)
	{
		int result;
		try
		{
			CanvasGroup canvasGroup = (CanvasGroup)LuaObject.checkSelf(l);
			bool interactable;
			LuaObject.checkType(l, 2, out interactable);
			canvasGroup.interactable = interactable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DBA RID: 142778 RVA: 0x00C0BDE0 File Offset: 0x00C09FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_blocksRaycasts(IntPtr l)
	{
		int result;
		try
		{
			CanvasGroup canvasGroup = (CanvasGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasGroup.blocksRaycasts);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DBB RID: 142779 RVA: 0x00C0BE34 File Offset: 0x00C0A034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_blocksRaycasts(IntPtr l)
	{
		int result;
		try
		{
			CanvasGroup canvasGroup = (CanvasGroup)LuaObject.checkSelf(l);
			bool blocksRaycasts;
			LuaObject.checkType(l, 2, out blocksRaycasts);
			canvasGroup.blocksRaycasts = blocksRaycasts;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DBC RID: 142780 RVA: 0x00C0BE8C File Offset: 0x00C0A08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ignoreParentGroups(IntPtr l)
	{
		int result;
		try
		{
			CanvasGroup canvasGroup = (CanvasGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasGroup.ignoreParentGroups);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DBD RID: 142781 RVA: 0x00C0BEE0 File Offset: 0x00C0A0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ignoreParentGroups(IntPtr l)
	{
		int result;
		try
		{
			CanvasGroup canvasGroup = (CanvasGroup)LuaObject.checkSelf(l);
			bool ignoreParentGroups;
			LuaObject.checkType(l, 2, out ignoreParentGroups);
			canvasGroup.ignoreParentGroups = ignoreParentGroups;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DBE RID: 142782 RVA: 0x00C0BF38 File Offset: 0x00C0A138
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CanvasGroup");
		if (Lua_UnityEngine_CanvasGroup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CanvasGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CanvasGroup.IsRaycastLocationValid);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasGroup.<>f__mg$cache0);
		string name = "alpha";
		if (Lua_UnityEngine_CanvasGroup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CanvasGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CanvasGroup.get_alpha);
		}
		LuaCSFunction get = Lua_UnityEngine_CanvasGroup.<>f__mg$cache1;
		if (Lua_UnityEngine_CanvasGroup.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CanvasGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CanvasGroup.set_alpha);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CanvasGroup.<>f__mg$cache2, true);
		string name2 = "interactable";
		if (Lua_UnityEngine_CanvasGroup.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CanvasGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CanvasGroup.get_interactable);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CanvasGroup.<>f__mg$cache3;
		if (Lua_UnityEngine_CanvasGroup.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CanvasGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CanvasGroup.set_interactable);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_CanvasGroup.<>f__mg$cache4, true);
		string name3 = "blocksRaycasts";
		if (Lua_UnityEngine_CanvasGroup.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CanvasGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CanvasGroup.get_blocksRaycasts);
		}
		LuaCSFunction get3 = Lua_UnityEngine_CanvasGroup.<>f__mg$cache5;
		if (Lua_UnityEngine_CanvasGroup.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CanvasGroup.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CanvasGroup.set_blocksRaycasts);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_CanvasGroup.<>f__mg$cache6, true);
		string name4 = "ignoreParentGroups";
		if (Lua_UnityEngine_CanvasGroup.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CanvasGroup.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CanvasGroup.get_ignoreParentGroups);
		}
		LuaCSFunction get4 = Lua_UnityEngine_CanvasGroup.<>f__mg$cache7;
		if (Lua_UnityEngine_CanvasGroup.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_CanvasGroup.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_CanvasGroup.set_ignoreParentGroups);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_CanvasGroup.<>f__mg$cache8, true);
		LuaObject.createTypeMetatable(l, null, typeof(CanvasGroup), typeof(Component));
	}

	// Token: 0x04018D6F RID: 101743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018D70 RID: 101744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018D71 RID: 101745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018D72 RID: 101746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018D73 RID: 101747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018D74 RID: 101748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018D75 RID: 101749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018D76 RID: 101750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018D77 RID: 101751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
