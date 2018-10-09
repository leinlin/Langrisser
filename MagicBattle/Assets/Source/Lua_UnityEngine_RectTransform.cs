using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001770 RID: 6000
[Preserve]
public class Lua_UnityEngine_RectTransform : LuaObject
{
	// Token: 0x060239CB RID: 145867 RVA: 0x00C71CD4 File Offset: 0x00C6FED4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLocalCorners(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			Vector3[] fourCornersArray;
			LuaObject.checkArray<Vector3>(l, 2, out fourCornersArray);
			rectTransform.GetLocalCorners(fourCornersArray);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239CC RID: 145868 RVA: 0x00C71D2C File Offset: 0x00C6FF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWorldCorners(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			Vector3[] fourCornersArray;
			LuaObject.checkArray<Vector3>(l, 2, out fourCornersArray);
			rectTransform.GetWorldCorners(fourCornersArray);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239CD RID: 145869 RVA: 0x00C71D84 File Offset: 0x00C6FF84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetInsetAndSizeFromParentEdge(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			RectTransform.Edge edge;
			LuaObject.checkEnum<RectTransform.Edge>(l, 2, out edge);
			float inset;
			LuaObject.checkType(l, 3, out inset);
			float size;
			LuaObject.checkType(l, 4, out size);
			rectTransform.SetInsetAndSizeFromParentEdge(edge, inset, size);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239CE RID: 145870 RVA: 0x00C71DF8 File Offset: 0x00C6FFF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSizeWithCurrentAnchors(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			RectTransform.Axis axis;
			LuaObject.checkEnum<RectTransform.Axis>(l, 2, out axis);
			float size;
			LuaObject.checkType(l, 3, out size);
			rectTransform.SetSizeWithCurrentAnchors(axis, size);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239CF RID: 145871 RVA: 0x00C71E5C File Offset: 0x00C7005C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ForceUpdateRectTransforms(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			rectTransform.ForceUpdateRectTransforms();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239D0 RID: 145872 RVA: 0x00C71EA8 File Offset: 0x00C700A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_rect(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectTransform.rect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239D1 RID: 145873 RVA: 0x00C71F00 File Offset: 0x00C70100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_anchorMin(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectTransform.anchorMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239D2 RID: 145874 RVA: 0x00C71F54 File Offset: 0x00C70154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_anchorMin(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			Vector2 anchorMin;
			LuaObject.checkType(l, 2, out anchorMin);
			rectTransform.anchorMin = anchorMin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239D3 RID: 145875 RVA: 0x00C71FAC File Offset: 0x00C701AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_anchorMax(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectTransform.anchorMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239D4 RID: 145876 RVA: 0x00C72000 File Offset: 0x00C70200
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_anchorMax(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			Vector2 anchorMax;
			LuaObject.checkType(l, 2, out anchorMax);
			rectTransform.anchorMax = anchorMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239D5 RID: 145877 RVA: 0x00C72058 File Offset: 0x00C70258
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_anchoredPosition3D(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectTransform.anchoredPosition3D);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239D6 RID: 145878 RVA: 0x00C720AC File Offset: 0x00C702AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_anchoredPosition3D(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			Vector3 anchoredPosition3D;
			LuaObject.checkType(l, 2, out anchoredPosition3D);
			rectTransform.anchoredPosition3D = anchoredPosition3D;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239D7 RID: 145879 RVA: 0x00C72104 File Offset: 0x00C70304
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_anchoredPosition(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectTransform.anchoredPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239D8 RID: 145880 RVA: 0x00C72158 File Offset: 0x00C70358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_anchoredPosition(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			Vector2 anchoredPosition;
			LuaObject.checkType(l, 2, out anchoredPosition);
			rectTransform.anchoredPosition = anchoredPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239D9 RID: 145881 RVA: 0x00C721B0 File Offset: 0x00C703B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sizeDelta(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectTransform.sizeDelta);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239DA RID: 145882 RVA: 0x00C72204 File Offset: 0x00C70404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sizeDelta(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			Vector2 sizeDelta;
			LuaObject.checkType(l, 2, out sizeDelta);
			rectTransform.sizeDelta = sizeDelta;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239DB RID: 145883 RVA: 0x00C7225C File Offset: 0x00C7045C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_pivot(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectTransform.pivot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239DC RID: 145884 RVA: 0x00C722B0 File Offset: 0x00C704B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_pivot(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			Vector2 pivot;
			LuaObject.checkType(l, 2, out pivot);
			rectTransform.pivot = pivot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239DD RID: 145885 RVA: 0x00C72308 File Offset: 0x00C70508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_offsetMin(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectTransform.offsetMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239DE RID: 145886 RVA: 0x00C7235C File Offset: 0x00C7055C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_offsetMin(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			Vector2 offsetMin;
			LuaObject.checkType(l, 2, out offsetMin);
			rectTransform.offsetMin = offsetMin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239DF RID: 145887 RVA: 0x00C723B4 File Offset: 0x00C705B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_offsetMax(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectTransform.offsetMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239E0 RID: 145888 RVA: 0x00C72408 File Offset: 0x00C70608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_offsetMax(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform = (RectTransform)LuaObject.checkSelf(l);
			Vector2 offsetMax;
			LuaObject.checkType(l, 2, out offsetMax);
			rectTransform.offsetMax = offsetMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239E1 RID: 145889 RVA: 0x00C72460 File Offset: 0x00C70660
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RectTransform");
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RectTransform.GetLocalCorners);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransform.<>f__mg$cache0);
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RectTransform.GetWorldCorners);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransform.<>f__mg$cache1);
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RectTransform.SetInsetAndSizeFromParentEdge);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransform.<>f__mg$cache2);
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RectTransform.SetSizeWithCurrentAnchors);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransform.<>f__mg$cache3);
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RectTransform.ForceUpdateRectTransforms);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransform.<>f__mg$cache4);
		string name = "rect";
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RectTransform.get_rect);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_RectTransform.<>f__mg$cache5, null, true);
		string name2 = "anchorMin";
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_RectTransform.get_anchorMin);
		}
		LuaCSFunction get = Lua_UnityEngine_RectTransform.<>f__mg$cache6;
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_RectTransform.set_anchorMin);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_RectTransform.<>f__mg$cache7, true);
		string name3 = "anchorMax";
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_RectTransform.get_anchorMax);
		}
		LuaCSFunction get2 = Lua_UnityEngine_RectTransform.<>f__mg$cache8;
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_RectTransform.set_anchorMax);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_RectTransform.<>f__mg$cache9, true);
		string name4 = "anchoredPosition3D";
		if (Lua_UnityEngine_RectTransform.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_RectTransform.get_anchoredPosition3D);
		}
		LuaCSFunction get3 = Lua_UnityEngine_RectTransform.<>f__mg$cacheA;
		if (Lua_UnityEngine_RectTransform.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_RectTransform.set_anchoredPosition3D);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_RectTransform.<>f__mg$cacheB, true);
		string name5 = "anchoredPosition";
		if (Lua_UnityEngine_RectTransform.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_RectTransform.get_anchoredPosition);
		}
		LuaCSFunction get4 = Lua_UnityEngine_RectTransform.<>f__mg$cacheC;
		if (Lua_UnityEngine_RectTransform.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_RectTransform.set_anchoredPosition);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_RectTransform.<>f__mg$cacheD, true);
		string name6 = "sizeDelta";
		if (Lua_UnityEngine_RectTransform.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_RectTransform.get_sizeDelta);
		}
		LuaCSFunction get5 = Lua_UnityEngine_RectTransform.<>f__mg$cacheE;
		if (Lua_UnityEngine_RectTransform.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_RectTransform.set_sizeDelta);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_RectTransform.<>f__mg$cacheF, true);
		string name7 = "pivot";
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_RectTransform.get_pivot);
		}
		LuaCSFunction get6 = Lua_UnityEngine_RectTransform.<>f__mg$cache10;
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_RectTransform.set_pivot);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_RectTransform.<>f__mg$cache11, true);
		string name8 = "offsetMin";
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_RectTransform.get_offsetMin);
		}
		LuaCSFunction get7 = Lua_UnityEngine_RectTransform.<>f__mg$cache12;
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_RectTransform.set_offsetMin);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_RectTransform.<>f__mg$cache13, true);
		string name9 = "offsetMax";
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_RectTransform.get_offsetMax);
		}
		LuaCSFunction get8 = Lua_UnityEngine_RectTransform.<>f__mg$cache14;
		if (Lua_UnityEngine_RectTransform.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_RectTransform.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_RectTransform.set_offsetMax);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_RectTransform.<>f__mg$cache15, true);
		LuaObject.createTypeMetatable(l, null, typeof(RectTransform), typeof(Transform));
	}

	// Token: 0x04019749 RID: 104265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401974A RID: 104266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401974B RID: 104267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401974C RID: 104268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401974D RID: 104269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401974E RID: 104270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401974F RID: 104271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019750 RID: 104272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019751 RID: 104273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019752 RID: 104274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019753 RID: 104275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019754 RID: 104276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019755 RID: 104277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019756 RID: 104278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019757 RID: 104279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019758 RID: 104280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019759 RID: 104281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401975A RID: 104282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401975B RID: 104283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401975C RID: 104284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401975D RID: 104285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401975E RID: 104286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
