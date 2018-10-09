using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001344 RID: 4932
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo : LuaObject
{
	// Token: 0x0601A7E7 RID: 108519 RVA: 0x007DAA80 File Offset: 0x007D8C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo o = new GenericGraphic.EffectInfo();
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

	// Token: 0x0601A7E8 RID: 108520 RVA: 0x007DAAC8 File Offset: 0x007D8CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_color(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, effectInfo.m_color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7E9 RID: 108521 RVA: 0x007DAB20 File Offset: 0x007D8D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_color(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			Colori color;
			LuaObject.checkValueType<Colori>(l, 2, out color);
			effectInfo.m_color = color;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7EA RID: 108522 RVA: 0x007DAB78 File Offset: 0x007D8D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_intensity(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, effectInfo.m_intensity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7EB RID: 108523 RVA: 0x007DABCC File Offset: 0x007D8DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_intensity(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			float intensity;
			LuaObject.checkType(l, 2, out intensity);
			effectInfo.m_intensity = intensity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7EC RID: 108524 RVA: 0x007DAC24 File Offset: 0x007D8E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_totalTime(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, effectInfo.m_totalTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7ED RID: 108525 RVA: 0x007DAC78 File Offset: 0x007D8E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_totalTime(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			float totalTime;
			LuaObject.checkType(l, 2, out totalTime);
			effectInfo.m_totalTime = totalTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7EE RID: 108526 RVA: 0x007DACD0 File Offset: 0x007D8ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curTime(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, effectInfo.m_curTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7EF RID: 108527 RVA: 0x007DAD24 File Offset: 0x007D8F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curTime(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			float curTime;
			LuaObject.checkType(l, 2, out curTime);
			effectInfo.m_curTime = curTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7F0 RID: 108528 RVA: 0x007DAD7C File Offset: 0x007D8F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_repeatCount(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, effectInfo.m_repeatCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7F1 RID: 108529 RVA: 0x007DADD0 File Offset: 0x007D8FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_repeatCount(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			int repeatCount;
			LuaObject.checkType(l, 2, out repeatCount);
			effectInfo.m_repeatCount = repeatCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7F2 RID: 108530 RVA: 0x007DAE28 File Offset: 0x007D9028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_type(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)effectInfo.m_type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7F3 RID: 108531 RVA: 0x007DAE7C File Offset: 0x007D907C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_type(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			GraphicEffect type;
			LuaObject.checkEnum<GraphicEffect>(l, 2, out type);
			effectInfo.m_type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7F4 RID: 108532 RVA: 0x007DAED4 File Offset: 0x007D90D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ghostDistance(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, effectInfo.m_ghostDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7F5 RID: 108533 RVA: 0x007DAF28 File Offset: 0x007D9128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ghostDistance(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			float ghostDistance;
			LuaObject.checkType(l, 2, out ghostDistance);
			effectInfo.m_ghostDistance = ghostDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7F6 RID: 108534 RVA: 0x007DAF80 File Offset: 0x007D9180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ghosts(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, effectInfo.m_ghosts);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7F7 RID: 108535 RVA: 0x007DAFD4 File Offset: 0x007D91D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ghosts(IntPtr l)
	{
		int result;
		try
		{
			GenericGraphic.EffectInfo effectInfo = (GenericGraphic.EffectInfo)LuaObject.checkSelf(l);
			List<GenericGraphic.Ghost> ghosts;
			LuaObject.checkType<List<GenericGraphic.Ghost>>(l, 2, out ghosts);
			effectInfo.m_ghosts = ghosts;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A7F8 RID: 108536 RVA: 0x007DB02C File Offset: 0x007D922C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.GenericGraphic.EffectInfo");
		string name = "m_color";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.get_m_color);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.set_m_color);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache1, true);
		string name2 = "m_intensity";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.get_m_intensity);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.set_m_intensity);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache3, true);
		string name3 = "m_totalTime";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.get_m_totalTime);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.set_m_totalTime);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache5, true);
		string name4 = "m_curTime";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.get_m_curTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.set_m_curTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache7, true);
		string name5 = "m_repeatCount";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.get_m_repeatCount);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.set_m_repeatCount);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache9, true);
		string name6 = "m_type";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.get_m_type);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.set_m_type);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheB, true);
		string name7 = "m_ghostDistance";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.get_m_ghostDistance);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.set_m_ghostDistance);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheD, true);
		string name8 = "m_ghosts";
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.get_m_ghosts);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.set_m_ghosts);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_GenericGraphic_EffectInfo.<>f__mg$cache10, typeof(GenericGraphic.EffectInfo));
	}

	// Token: 0x04010B41 RID: 68417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010B42 RID: 68418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010B43 RID: 68419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010B44 RID: 68420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010B45 RID: 68421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010B46 RID: 68422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010B47 RID: 68423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010B48 RID: 68424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010B49 RID: 68425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010B4A RID: 68426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010B4B RID: 68427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010B4C RID: 68428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010B4D RID: 68429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04010B4E RID: 68430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04010B4F RID: 68431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04010B50 RID: 68432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04010B51 RID: 68433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
