using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001826 RID: 6182
[Preserve]
public class Lua_UnityEngine_UI_GridLayoutGroup : LuaObject
{
	// Token: 0x06024084 RID: 147588 RVA: 0x00CA6408 File Offset: 0x00CA4608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputHorizontal(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			gridLayoutGroup.CalculateLayoutInputHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024085 RID: 147589 RVA: 0x00CA6454 File Offset: 0x00CA4654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputVertical(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			gridLayoutGroup.CalculateLayoutInputVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024086 RID: 147590 RVA: 0x00CA64A0 File Offset: 0x00CA46A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutHorizontal(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			gridLayoutGroup.SetLayoutHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024087 RID: 147591 RVA: 0x00CA64EC File Offset: 0x00CA46EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutVertical(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			gridLayoutGroup.SetLayoutVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024088 RID: 147592 RVA: 0x00CA6538 File Offset: 0x00CA4738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_startCorner(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)gridLayoutGroup.startCorner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024089 RID: 147593 RVA: 0x00CA658C File Offset: 0x00CA478C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_startCorner(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			GridLayoutGroup.Corner startCorner;
			LuaObject.checkEnum<GridLayoutGroup.Corner>(l, 2, out startCorner);
			gridLayoutGroup.startCorner = startCorner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602408A RID: 147594 RVA: 0x00CA65E4 File Offset: 0x00CA47E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_startAxis(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)gridLayoutGroup.startAxis);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602408B RID: 147595 RVA: 0x00CA6638 File Offset: 0x00CA4838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_startAxis(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			GridLayoutGroup.Axis startAxis;
			LuaObject.checkEnum<GridLayoutGroup.Axis>(l, 2, out startAxis);
			gridLayoutGroup.startAxis = startAxis;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602408C RID: 147596 RVA: 0x00CA6690 File Offset: 0x00CA4890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cellSize(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridLayoutGroup.cellSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602408D RID: 147597 RVA: 0x00CA66E4 File Offset: 0x00CA48E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cellSize(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			Vector2 cellSize;
			LuaObject.checkType(l, 2, out cellSize);
			gridLayoutGroup.cellSize = cellSize;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602408E RID: 147598 RVA: 0x00CA673C File Offset: 0x00CA493C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_spacing(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridLayoutGroup.spacing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602408F RID: 147599 RVA: 0x00CA6790 File Offset: 0x00CA4990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_spacing(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			Vector2 spacing;
			LuaObject.checkType(l, 2, out spacing);
			gridLayoutGroup.spacing = spacing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024090 RID: 147600 RVA: 0x00CA67E8 File Offset: 0x00CA49E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_constraint(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)gridLayoutGroup.constraint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024091 RID: 147601 RVA: 0x00CA683C File Offset: 0x00CA4A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_constraint(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			GridLayoutGroup.Constraint constraint;
			LuaObject.checkEnum<GridLayoutGroup.Constraint>(l, 2, out constraint);
			gridLayoutGroup.constraint = constraint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024092 RID: 147602 RVA: 0x00CA6894 File Offset: 0x00CA4A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_constraintCount(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridLayoutGroup.constraintCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024093 RID: 147603 RVA: 0x00CA68E8 File Offset: 0x00CA4AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_constraintCount(IntPtr l)
	{
		int result;
		try
		{
			GridLayoutGroup gridLayoutGroup = (GridLayoutGroup)LuaObject.checkSelf(l);
			int constraintCount;
			LuaObject.checkType(l, 2, out constraintCount);
			gridLayoutGroup.constraintCount = constraintCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024094 RID: 147604 RVA: 0x00CA6940 File Offset: 0x00CA4B40
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.GridLayoutGroup");
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.CalculateLayoutInputHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.CalculateLayoutInputVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.SetLayoutHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.SetLayoutVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache3);
		string name = "startCorner";
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.get_startCorner);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.set_startCorner);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache5, true);
		string name2 = "startAxis";
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.get_startAxis);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache6;
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.set_startAxis);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache7, true);
		string name3 = "cellSize";
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.get_cellSize);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache8;
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.set_cellSize);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cache9, true);
		string name4 = "spacing";
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.get_spacing);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheA;
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.set_spacing);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheB, true);
		string name5 = "constraint";
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.get_constraint);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheC;
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.set_constraint);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheD, true);
		string name6 = "constraintCount";
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.get_constraintCount);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheE;
		if (Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_GridLayoutGroup.set_constraintCount);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_UI_GridLayoutGroup.<>f__mg$cacheF, true);
		LuaObject.createTypeMetatable(l, null, typeof(GridLayoutGroup), typeof(LayoutGroup));
	}

	// Token: 0x04019C96 RID: 105622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C97 RID: 105623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019C98 RID: 105624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019C99 RID: 105625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019C9A RID: 105626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019C9B RID: 105627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019C9C RID: 105628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019C9D RID: 105629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019C9E RID: 105630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019C9F RID: 105631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019CA0 RID: 105632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019CA1 RID: 105633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019CA2 RID: 105634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019CA3 RID: 105635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019CA4 RID: 105636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019CA5 RID: 105637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
