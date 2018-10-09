using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200112D RID: 4397
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc : LuaObject
{
	// Token: 0x06015EB5 RID: 89781 RVA: 0x005AF230 File Offset: 0x005AD430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc o = new UITaskBase.LayerDesc();
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

	// Token: 0x06015EB6 RID: 89782 RVA: 0x005AF278 File Offset: 0x005AD478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerDesc.m_layerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EB7 RID: 89783 RVA: 0x005AF2CC File Offset: 0x005AD4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerName(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			string layerName;
			LuaObject.checkType(l, 2, out layerName);
			layerDesc.m_layerName = layerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EB8 RID: 89784 RVA: 0x005AF324 File Offset: 0x005AD524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerResPath(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerDesc.m_layerResPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EB9 RID: 89785 RVA: 0x005AF378 File Offset: 0x005AD578
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_layerResPath(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			string layerResPath;
			LuaObject.checkType(l, 2, out layerResPath);
			layerDesc.m_layerResPath = layerResPath;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EBA RID: 89786 RVA: 0x005AF3D0 File Offset: 0x005AD5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isUILayer(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerDesc.m_isUILayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EBB RID: 89787 RVA: 0x005AF424 File Offset: 0x005AD624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isUILayer(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			bool isUILayer;
			LuaObject.checkType(l, 2, out isUILayer);
			layerDesc.m_isUILayer = isUILayer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EBC RID: 89788 RVA: 0x005AF47C File Offset: 0x005AD67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLazyLoad(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerDesc.m_isLazyLoad);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EBD RID: 89789 RVA: 0x005AF4D0 File Offset: 0x005AD6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isLazyLoad(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			bool isLazyLoad;
			LuaObject.checkType(l, 2, out isLazyLoad);
			layerDesc.m_isLazyLoad = isLazyLoad;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EBE RID: 89790 RVA: 0x005AF528 File Offset: 0x005AD728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerDesc.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EBF RID: 89791 RVA: 0x005AF57C File Offset: 0x005AD77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			layerDesc.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EC0 RID: 89792 RVA: 0x005AF5D4 File Offset: 0x005AD7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isReserve(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layerDesc.m_isReserve);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EC1 RID: 89793 RVA: 0x005AF628 File Offset: 0x005AD828
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isReserve(IntPtr l)
	{
		int result;
		try
		{
			UITaskBase.LayerDesc layerDesc = (UITaskBase.LayerDesc)LuaObject.checkSelf(l);
			bool isReserve;
			LuaObject.checkType(l, 2, out isReserve);
			layerDesc.m_isReserve = isReserve;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015EC2 RID: 89794 RVA: 0x005AF680 File Offset: 0x005AD880
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.UI.UITaskBase.LayerDesc");
		string name = "m_layerName";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.get_m_layerName);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache0;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.set_m_layerName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache1, true);
		string name2 = "m_layerResPath";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.get_m_layerResPath);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache2;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.set_m_layerResPath);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache3, true);
		string name3 = "m_isUILayer";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.get_m_isUILayer);
		}
		LuaCSFunction get3 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache4;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.set_m_isUILayer);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache5, true);
		string name4 = "m_isLazyLoad";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.get_m_isLazyLoad);
		}
		LuaCSFunction get4 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache6;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.set_m_isLazyLoad);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache7, true);
		string name5 = "m_index";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.get_m_index);
		}
		LuaCSFunction get5 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache8;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.set_m_index);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cache9, true);
		string name6 = "m_isReserve";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.get_m_isReserve);
		}
		LuaCSFunction get6 = Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cacheA;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.set_m_isReserve);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cacheB, true);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_UI_UITaskBase_LayerDesc.<>f__mg$cacheC, typeof(UITaskBase.LayerDesc));
	}

	// Token: 0x0400C63D RID: 50749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C63E RID: 50750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C63F RID: 50751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C640 RID: 50752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C641 RID: 50753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400C642 RID: 50754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400C643 RID: 50755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400C644 RID: 50756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400C645 RID: 50757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400C646 RID: 50758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400C647 RID: 50759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400C648 RID: 50760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400C649 RID: 50761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
