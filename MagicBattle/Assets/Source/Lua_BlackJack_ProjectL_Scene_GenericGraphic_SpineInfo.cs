using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using Spine.Unity;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001347 RID: 4935
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo : LuaObject
{
	// Token: 0x0601A826 RID: 108582 RVA: 0x007DC5D0 File Offset: 0x007DA7D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo o = new GenericGraphic.SpineInfo();
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

	// Token: 0x0601A827 RID: 108583 RVA: 0x007DC618 File Offset: 0x007DA818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spine(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spineInfo.m_spine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A828 RID: 108584 RVA: 0x007DC66C File Offset: 0x007DA86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_spine(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			SkeletonAnimation spine;
			LuaObject.checkType<SkeletonAnimation>(l, 2, out spine);
			spineInfo.m_spine = spine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A829 RID: 108585 RVA: 0x007DC6C4 File Offset: 0x007DA8C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initAnimationName(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spineInfo.m_initAnimationName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A82A RID: 108586 RVA: 0x007DC718 File Offset: 0x007DA918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initAnimationName(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			string initAnimationName;
			LuaObject.checkType(l, 2, out initAnimationName);
			spineInfo.m_initAnimationName = initAnimationName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A82B RID: 108587 RVA: 0x007DC770 File Offset: 0x007DA970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAnimationLoop(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spineInfo.m_isAnimationLoop);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A82C RID: 108588 RVA: 0x007DC7C4 File Offset: 0x007DA9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAnimationLoop(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			bool isAnimationLoop;
			LuaObject.checkType(l, 2, out isAnimationLoop);
			spineInfo.m_isAnimationLoop = isAnimationLoop;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A82D RID: 108589 RVA: 0x007DC81C File Offset: 0x007DAA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boundsMin(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spineInfo.m_boundsMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A82E RID: 108590 RVA: 0x007DC870 File Offset: 0x007DAA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boundsMin(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			Vector2 boundsMin;
			LuaObject.checkType(l, 2, out boundsMin);
			spineInfo.m_boundsMin = boundsMin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A82F RID: 108591 RVA: 0x007DC8C8 File Offset: 0x007DAAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boundsMax(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spineInfo.m_boundsMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A830 RID: 108592 RVA: 0x007DC91C File Offset: 0x007DAB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boundsMax(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			Vector2 boundsMax;
			LuaObject.checkType(l, 2, out boundsMax);
			spineInfo.m_boundsMax = boundsMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A831 RID: 108593 RVA: 0x007DC974 File Offset: 0x007DAB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isCulled(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spineInfo.m_isCulled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A832 RID: 108594 RVA: 0x007DC9C8 File Offset: 0x007DABC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isCulled(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			bool isCulled;
			LuaObject.checkType(l, 2, out isCulled);
			spineInfo.m_isCulled = isCulled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A833 RID: 108595 RVA: 0x007DCA20 File Offset: 0x007DAC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_height(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spineInfo.m_height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A834 RID: 108596 RVA: 0x007DCA74 File Offset: 0x007DAC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_height(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			float height;
			LuaObject.checkType(l, 2, out height);
			spineInfo.m_height = height;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A835 RID: 108597 RVA: 0x007DCACC File Offset: 0x007DACCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_footHeight(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spineInfo.m_footHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A836 RID: 108598 RVA: 0x007DCB20 File Offset: 0x007DAD20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_footHeight(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			float footHeight;
			LuaObject.checkType(l, 2, out footHeight);
			spineInfo.m_footHeight = footHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A837 RID: 108599 RVA: 0x007DCB78 File Offset: 0x007DAD78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_replaceAnims(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, spineInfo.m_replaceAnims);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A838 RID: 108600 RVA: 0x007DCBCC File Offset: 0x007DADCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_replaceAnims(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.SpineInfo spineInfo = (GenericGraphic.SpineInfo)LuaObject.checkSelf(l);
			List<ReplaceAnim> replaceAnims;
			LuaObject.checkType<List<ReplaceAnim>>(l, 2, out replaceAnims);
			spineInfo.m_replaceAnims = replaceAnims;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A839 RID: 108601 RVA: 0x007DCC24 File Offset: 0x007DAE24
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.GenericGraphic.SpineInfo");
		string name = "m_spine";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.get_m_spine);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.set_m_spine);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache1, true);
		string name2 = "m_initAnimationName";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.get_m_initAnimationName);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.set_m_initAnimationName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache3, true);
		string name3 = "m_isAnimationLoop";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.get_m_isAnimationLoop);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.set_m_isAnimationLoop);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache5, true);
		string name4 = "m_boundsMin";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.get_m_boundsMin);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.set_m_boundsMin);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache7, true);
		string name5 = "m_boundsMax";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.get_m_boundsMax);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.set_m_boundsMax);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache9, true);
		string name6 = "m_isCulled";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.get_m_isCulled);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.set_m_isCulled);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheB, true);
		string name7 = "m_height";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.get_m_height);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.set_m_height);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheD, true);
		string name8 = "m_footHeight";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.get_m_footHeight);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.set_m_footHeight);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cacheF, true);
		string name9 = "m_replaceAnims";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.get_m_replaceAnims);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.set_m_replaceAnims);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache11, true);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic_SpineInfo.<>f__mg$cache12, typeof(GenericGraphic.SpineInfo));
	}

	// Token: 0x04010B7A RID: 68474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010B7B RID: 68475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010B7C RID: 68476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010B7D RID: 68477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010B7E RID: 68478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010B7F RID: 68479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010B80 RID: 68480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010B81 RID: 68481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010B82 RID: 68482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010B83 RID: 68483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010B84 RID: 68484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010B85 RID: 68485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010B86 RID: 68486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010B87 RID: 68487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010B88 RID: 68488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010B89 RID: 68489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010B8A RID: 68490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04010B8B RID: 68491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04010B8C RID: 68492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
