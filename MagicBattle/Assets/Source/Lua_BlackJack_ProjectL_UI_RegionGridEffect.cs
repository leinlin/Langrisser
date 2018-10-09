using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001557 RID: 5463
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RegionGridEffect : LuaObject
{
	// Token: 0x06020A76 RID: 133750 RVA: 0x00AE9CD0 File Offset: 0x00AE7ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDelay(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			float delay;
			LuaObject.checkType(l, 2, out delay);
			regionGridEffect.SetDelay(delay);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A77 RID: 133751 RVA: 0x00AE9D28 File Offset: 0x00AE7F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDuration(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			float duration;
			LuaObject.checkType(l, 2, out duration);
			regionGridEffect.SetDuration(duration);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A78 RID: 133752 RVA: 0x00AE9D80 File Offset: 0x00AE7F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFade(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			bool fade;
			LuaObject.checkType(l, 2, out fade);
			regionGridEffect.SetFade(fade);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A79 RID: 133753 RVA: 0x00AE9DD8 File Offset: 0x00AE7FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Awake(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			regionGridEffect.m_luaExportHelper.Awake();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A7A RID: 133754 RVA: 0x00AE9E2C File Offset: 0x00AE802C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			regionGridEffect.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A7B RID: 133755 RVA: 0x00AE9E80 File Offset: 0x00AE8080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_delayTime(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, regionGridEffect.m_luaExportHelper.m_delayTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A7C RID: 133756 RVA: 0x00AE9ED8 File Offset: 0x00AE80D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_delayTime(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			float delayTime;
			LuaObject.checkType(l, 2, out delayTime);
			regionGridEffect.m_luaExportHelper.m_delayTime = delayTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A7D RID: 133757 RVA: 0x00AE9F34 File Offset: 0x00AE8134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_duration(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, regionGridEffect.m_luaExportHelper.m_duration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A7E RID: 133758 RVA: 0x00AE9F8C File Offset: 0x00AE818C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_duration(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			float duration;
			LuaObject.checkType(l, 2, out duration);
			regionGridEffect.m_luaExportHelper.m_duration = duration;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A7F RID: 133759 RVA: 0x00AE9FE8 File Offset: 0x00AE81E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_time(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, regionGridEffect.m_luaExportHelper.m_time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A80 RID: 133760 RVA: 0x00AEA040 File Offset: 0x00AE8240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_time(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			regionGridEffect.m_luaExportHelper.m_time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A81 RID: 133761 RVA: 0x00AEA09C File Offset: 0x00AE829C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFadeIn(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, regionGridEffect.m_luaExportHelper.m_isFadeIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A82 RID: 133762 RVA: 0x00AEA0F4 File Offset: 0x00AE82F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFadeIn(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			bool isFadeIn;
			LuaObject.checkType(l, 2, out isFadeIn);
			regionGridEffect.m_luaExportHelper.m_isFadeIn = isFadeIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A83 RID: 133763 RVA: 0x00AEA150 File Offset: 0x00AE8350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initScale(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, regionGridEffect.m_luaExportHelper.m_initScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A84 RID: 133764 RVA: 0x00AEA1A8 File Offset: 0x00AE83A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initScale(IntPtr l)
	{
		int result;
		try
		{
			RegionGridEffect regionGridEffect = (RegionGridEffect)LuaObject.checkSelf(l);
			Vector3 initScale;
			LuaObject.checkType(l, 2, out initScale);
			regionGridEffect.m_luaExportHelper.m_initScale = initScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A85 RID: 133765 RVA: 0x00AEA204 File Offset: 0x00AE8404
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RegionGridEffect");
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.SetDelay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.SetDuration);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.SetFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.Awake);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache4);
		string name = "m_delayTime";
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.get_m_delayTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.set_m_delayTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache6, true);
		string name2 = "m_duration";
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.get_m_duration);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.set_m_duration);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache8, true);
		string name3 = "m_time";
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.get_m_time);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.set_m_time);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheA, true);
		string name4 = "m_isFadeIn";
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.get_m_isFadeIn);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.set_m_isFadeIn);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheC, true);
		string name5 = "m_initScale";
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.get_m_initScale);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RegionGridEffect.set_m_initScale);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RegionGridEffect.<>f__mg$cacheE, true);
		LuaObject.createTypeMetatable(l, null, typeof(RegionGridEffect), typeof(MonoBehaviour));
	}

	// Token: 0x040169AA RID: 92586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040169AB RID: 92587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040169AC RID: 92588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040169AD RID: 92589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040169AE RID: 92590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040169AF RID: 92591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040169B0 RID: 92592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040169B1 RID: 92593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040169B2 RID: 92594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040169B3 RID: 92595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040169B4 RID: 92596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040169B5 RID: 92597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040169B6 RID: 92598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040169B7 RID: 92599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040169B8 RID: 92600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
