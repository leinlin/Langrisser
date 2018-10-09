using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014D4 RID: 5332
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent : LuaObject
{
	// Token: 0x0601F5BB RID: 128443 RVA: 0x00A45268 File Offset: 0x00A43468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent o = new HeroMessageGroupUIComponent();
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

	// Token: 0x0601F5BC RID: 128444 RVA: 0x00A452B0 File Offset: 0x00A434B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			heroMessageGroupUIComponent.Init(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5BD RID: 128445 RVA: 0x00A45308 File Offset: 0x00A43508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEnglishNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			Text englishNameText;
			LuaObject.checkType<Text>(l, 2, out englishNameText);
			heroMessageGroupUIComponent.SetEnglishNameText(englishNameText);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5BE RID: 128446 RVA: 0x00A45360 File Offset: 0x00A43560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Refresh(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			heroMessageGroupUIComponent.Refresh(heroInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5BF RID: 128447 RVA: 0x00A453B8 File Offset: 0x00A435B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroMessageGroupUIComponent.m_luaExportHelper.m_ssrGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5C0 RID: 128448 RVA: 0x00A45410 File Offset: 0x00A43610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			GameObject ssrGameObject;
			LuaObject.checkType<GameObject>(l, 2, out ssrGameObject);
			heroMessageGroupUIComponent.m_luaExportHelper.m_ssrGameObject = ssrGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5C1 RID: 128449 RVA: 0x00A4546C File Offset: 0x00A4366C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_srGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroMessageGroupUIComponent.m_luaExportHelper.m_srGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5C2 RID: 128450 RVA: 0x00A454C4 File Offset: 0x00A436C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_srGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			GameObject srGameObject;
			LuaObject.checkType<GameObject>(l, 2, out srGameObject);
			heroMessageGroupUIComponent.m_luaExportHelper.m_srGameObject = srGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5C3 RID: 128451 RVA: 0x00A45520 File Offset: 0x00A43720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroMessageGroupUIComponent.m_luaExportHelper.m_rGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5C4 RID: 128452 RVA: 0x00A45578 File Offset: 0x00A43778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			GameObject rGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rGameObject);
			heroMessageGroupUIComponent.m_luaExportHelper.m_rGameObject = rGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5C5 RID: 128453 RVA: 0x00A455D4 File Offset: 0x00A437D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroMessageGroupUIComponent.m_luaExportHelper.m_heroNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5C6 RID: 128454 RVA: 0x00A4562C File Offset: 0x00A4382C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			Text heroNameText;
			LuaObject.checkType<Text>(l, 2, out heroNameText);
			heroMessageGroupUIComponent.m_luaExportHelper.m_heroNameText = heroNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5C7 RID: 128455 RVA: 0x00A45688 File Offset: 0x00A43888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroEnglishNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroMessageGroupUIComponent.m_luaExportHelper.m_heroEnglishNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5C8 RID: 128456 RVA: 0x00A456E0 File Offset: 0x00A438E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroEnglishNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			Text heroEnglishNameText;
			LuaObject.checkType<Text>(l, 2, out heroEnglishNameText);
			heroMessageGroupUIComponent.m_luaExportHelper.m_heroEnglishNameText = heroEnglishNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5C9 RID: 128457 RVA: 0x00A4573C File Offset: 0x00A4393C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_cvNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroMessageGroupUIComponent.m_luaExportHelper.m_cvNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5CA RID: 128458 RVA: 0x00A45794 File Offset: 0x00A43994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cvNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			Text cvNameText;
			LuaObject.checkType<Text>(l, 2, out cvNameText);
			heroMessageGroupUIComponent.m_luaExportHelper.m_cvNameText = cvNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5CB RID: 128459 RVA: 0x00A457F0 File Offset: 0x00A439F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_root(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroMessageGroupUIComponent.m_luaExportHelper.m_root);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5CC RID: 128460 RVA: 0x00A45848 File Offset: 0x00A43A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_root(IntPtr l)
	{
		int result;
		try
		{
			HeroMessageGroupUIComponent heroMessageGroupUIComponent = (HeroMessageGroupUIComponent)LuaObject.checkSelf(l);
			GameObject root;
			LuaObject.checkType<GameObject>(l, 2, out root);
			heroMessageGroupUIComponent.m_luaExportHelper.m_root = root;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F5CD RID: 128461 RVA: 0x00A458A4 File Offset: 0x00A43AA4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroMessageGroupUIComponent");
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.SetEnglishNameText);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.Refresh);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache2);
		string name = "m_ssrGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.get_m_ssrGameObject);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.set_m_ssrGameObject);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache4, true);
		string name2 = "m_srGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.get_m_srGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.set_m_srGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache6, true);
		string name3 = "m_rGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.get_m_rGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.set_m_rGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache8, true);
		string name4 = "m_heroNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.get_m_heroNameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.set_m_heroNameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheA, true);
		string name5 = "m_heroEnglishNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.get_m_heroEnglishNameText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.set_m_heroEnglishNameText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheC, true);
		string name6 = "m_cvNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.get_m_cvNameText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.set_m_cvNameText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheE, true);
		string name7 = "m_root";
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.get_m_root);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.set_m_root);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache10, true);
		if (Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroMessageGroupUIComponent.<>f__mg$cache11, typeof(HeroMessageGroupUIComponent));
	}

	// Token: 0x040155F5 RID: 87541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040155F6 RID: 87542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040155F7 RID: 87543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040155F8 RID: 87544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040155F9 RID: 87545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040155FA RID: 87546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040155FB RID: 87547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040155FC RID: 87548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040155FD RID: 87549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040155FE RID: 87550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040155FF RID: 87551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015600 RID: 87552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015601 RID: 87553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015602 RID: 87554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015603 RID: 87555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015604 RID: 87556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015605 RID: 87557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015606 RID: 87558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
