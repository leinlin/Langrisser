using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020014DD RID: 5341
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroShowComponent : LuaObject
{
	// Token: 0x0601F703 RID: 128771 RVA: 0x00A4F8E8 File Offset: 0x00A4DAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent o = new HeroShowComponent();
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

	// Token: 0x0601F704 RID: 128772 RVA: 0x00A4F930 File Offset: 0x00A4DB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent heroShowComponent = (HeroShowComponent)LuaObject.checkSelf(l);
			GameObject root;
			LuaObject.checkType<GameObject>(l, 2, out root);
			heroShowComponent.Init(root);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F705 RID: 128773 RVA: 0x00A4F988 File Offset: 0x00A4DB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent heroShowComponent = (HeroShowComponent)LuaObject.checkSelf(l);
			heroShowComponent.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F706 RID: 128774 RVA: 0x00A4F9D4 File Offset: 0x00A4DBD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowComponent(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent heroShowComponent = (HeroShowComponent)LuaObject.checkSelf(l);
			bool isActive;
			LuaObject.checkType(l, 2, out isActive);
			heroShowComponent.ShowComponent(isActive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F707 RID: 128775 RVA: 0x00A4FA2C File Offset: 0x00A4DC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent heroShowComponent = (HeroShowComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowComponent.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F708 RID: 128776 RVA: 0x00A4FA84 File Offset: 0x00A4DC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent heroShowComponent = (HeroShowComponent)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroShowComponent.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F709 RID: 128777 RVA: 0x00A4FAE0 File Offset: 0x00A4DCE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent heroShowComponent = (HeroShowComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowComponent.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F70A RID: 128778 RVA: 0x00A4FB38 File Offset: 0x00A4DD38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent heroShowComponent = (HeroShowComponent)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroShowComponent.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F70B RID: 128779 RVA: 0x00A4FB94 File Offset: 0x00A4DD94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_root(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent heroShowComponent = (HeroShowComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowComponent.m_luaExportHelper.m_root);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F70C RID: 128780 RVA: 0x00A4FBEC File Offset: 0x00A4DDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_root(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent heroShowComponent = (HeroShowComponent)LuaObject.checkSelf(l);
			GameObject root;
			LuaObject.checkType<GameObject>(l, 2, out root);
			heroShowComponent.m_luaExportHelper.m_root = root;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F70D RID: 128781 RVA: 0x00A4FC48 File Offset: 0x00A4DE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_heroDictionary(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent heroShowComponent = (HeroShowComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowComponent.m_luaExportHelper.heroDictionary);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F70E RID: 128782 RVA: 0x00A4FCA0 File Offset: 0x00A4DEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_heroDictionary(IntPtr l)
	{
		int result;
		try
		{
			HeroShowComponent heroShowComponent = (HeroShowComponent)LuaObject.checkSelf(l);
			Dictionary<string, CommonUIStateController> heroDictionary;
			LuaObject.checkType<Dictionary<string, CommonUIStateController>>(l, 2, out heroDictionary);
			heroShowComponent.m_luaExportHelper.heroDictionary = heroDictionary;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F70F RID: 128783 RVA: 0x00A4FCFC File Offset: 0x00A4DEFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroShowComponent");
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.Dispose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.ShowComponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache2);
		string name = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.get_m_playerContext);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.set_m_playerContext);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache4, true);
		string name2 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.get_m_configDataLoader);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache6, true);
		string name3 = "m_root";
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.get_m_root);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.set_m_root);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache8, true);
		string name4 = "heroDictionary";
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.get_heroDictionary);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.set_heroDictionary);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cacheA, true);
		if (Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroShowComponent.<>f__mg$cacheB, typeof(HeroShowComponent));
	}

	// Token: 0x0401572B RID: 87851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401572C RID: 87852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401572D RID: 87853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401572E RID: 87854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401572F RID: 87855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015730 RID: 87856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015731 RID: 87857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015732 RID: 87858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015733 RID: 87859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015734 RID: 87860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015735 RID: 87861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015736 RID: 87862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
