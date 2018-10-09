using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014E3 RID: 5347
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask : LuaObject
{
	// Token: 0x0601F835 RID: 129077 RVA: 0x00A59330 File Offset: 0x00A57530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			HeroSkinChangeUITask o = new HeroSkinChangeUITask(name);
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

	// Token: 0x0601F836 RID: 129078 RVA: 0x00A59384 File Offset: 0x00A57584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSkinChangeUITask.OnNewIntent(intent);
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

	// Token: 0x0601F837 RID: 129079 RVA: 0x00A593E8 File Offset: 0x00A575E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearUIControllerData(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.ClearUIControllerData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F838 RID: 129080 RVA: 0x00A59434 File Offset: 0x00A57634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseHeroSkinChangePanelWithAnim(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			heroSkinChangeUITask.CloseHeroSkinChangePanelWithAnim(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F839 RID: 129081 RVA: 0x00A5948C File Offset: 0x00A5768C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartUITask_s(IntPtr l)
	{
		int result;
		try
		{
			string mode;
			LuaObject.checkType(l, 1, out mode);
			int heroSkinInfoId;
			LuaObject.checkType(l, 2, out heroSkinInfoId);
			Hero hero;
			LuaObject.checkType<Hero>(l, 3, out hero);
			UIIntent preUIIntent;
			LuaObject.checkType<UIIntent>(l, 4, out preUIIntent);
			HeroSkinChangeUITask o = HeroSkinChangeUITask.StartUITask(mode, heroSkinInfoId, hero, preUIIntent);
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

	// Token: 0x0601F83A RID: 129082 RVA: 0x00A59508 File Offset: 0x00A57708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSkinChangeUITask_OnLoadAllResCompleted_s(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask.HeroSkinChangeUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F83B RID: 129083 RVA: 0x00A59548 File Offset: 0x00A57748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			bool b = heroSkinChangeUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x0601F83C RID: 129084 RVA: 0x00A595A4 File Offset: 0x00A577A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F83D RID: 129085 RVA: 0x00A595F8 File Offset: 0x00A577F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F83E RID: 129086 RVA: 0x00A5964C File Offset: 0x00A5784C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSkinChangeUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601F83F RID: 129087 RVA: 0x00A596B4 File Offset: 0x00A578B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSkinChangeUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x0601F840 RID: 129088 RVA: 0x00A5971C File Offset: 0x00A5791C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F841 RID: 129089 RVA: 0x00A59770 File Offset: 0x00A57970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			heroSkinChangeUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F842 RID: 129090 RVA: 0x00A597CC File Offset: 0x00A579CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F843 RID: 129091 RVA: 0x00A59820 File Offset: 0x00A57A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F844 RID: 129092 RVA: 0x00A59874 File Offset: 0x00A57A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCharSkinChangeUIController_OnClose(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.HeroCharSkinChangeUIController_OnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F845 RID: 129093 RVA: 0x00A598C8 File Offset: 0x00A57AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCharSkinChangeUIController_OnBuySkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			int skinId;
			LuaObject.checkType(l, 2, out skinId);
			heroSkinChangeUITask.m_luaExportHelper.HeroCharSkinChangeUIController_OnBuySkin(skinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F846 RID: 129094 RVA: 0x00A59924 File Offset: 0x00A57B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCharSkinChangeUIController_OnTakeOffCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			heroSkinChangeUITask.m_luaExportHelper.HeroCharSkinChangeUIController_OnTakeOffCharSkin(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F847 RID: 129095 RVA: 0x00A59980 File Offset: 0x00A57B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroCharSkinChangeUIController_OnWearCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int charSkinId;
			LuaObject.checkType(l, 3, out charSkinId);
			heroSkinChangeUITask.m_luaExportHelper.HeroCharSkinChangeUIController_OnWearCharSkin(heroId, charSkinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F848 RID: 129096 RVA: 0x00A599EC File Offset: 0x00A57BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSkinChangeUIController_OnSkinChangedPreview(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			string spinePath;
			LuaObject.checkType(l, 2, out spinePath);
			int heroSkinId;
			LuaObject.checkType(l, 3, out heroSkinId);
			heroSkinChangeUITask.m_luaExportHelper.HeroSkinChangeUIController_OnSkinChangedPreview(spinePath, heroSkinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F849 RID: 129097 RVA: 0x00A59A58 File Offset: 0x00A57C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroSkinChangeUIController_OnSkinTicketBuy(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.HeroSkinChangeUIController_OnSkinTicketBuy();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F84A RID: 129098 RVA: 0x00A59AAC File Offset: 0x00A57CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSkinChangeUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601F84B RID: 129099 RVA: 0x00A59B14 File Offset: 0x00A57D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F84C RID: 129100 RVA: 0x00A59B68 File Offset: 0x00A57D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F84D RID: 129101 RVA: 0x00A59BBC File Offset: 0x00A57DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSkinChangeUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601F84E RID: 129102 RVA: 0x00A59C24 File Offset: 0x00A57E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = heroSkinChangeUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601F84F RID: 129103 RVA: 0x00A59C8C File Offset: 0x00A57E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F850 RID: 129104 RVA: 0x00A59CF8 File Offset: 0x00A57EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			bool b = heroSkinChangeUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601F851 RID: 129105 RVA: 0x00A59D54 File Offset: 0x00A57F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			List<string> o = heroSkinChangeUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601F852 RID: 129106 RVA: 0x00A59DB0 File Offset: 0x00A57FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F853 RID: 129107 RVA: 0x00A59E04 File Offset: 0x00A58004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F854 RID: 129108 RVA: 0x00A59E58 File Offset: 0x00A58058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F855 RID: 129109 RVA: 0x00A59EAC File Offset: 0x00A580AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F856 RID: 129110 RVA: 0x00A59F00 File Offset: 0x00A58100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F857 RID: 129111 RVA: 0x00A59F54 File Offset: 0x00A58154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F858 RID: 129112 RVA: 0x00A59FB0 File Offset: 0x00A581B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F859 RID: 129113 RVA: 0x00A5A00C File Offset: 0x00A5820C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F85A RID: 129114 RVA: 0x00A5A068 File Offset: 0x00A58268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F85B RID: 129115 RVA: 0x00A5A0C4 File Offset: 0x00A582C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			bool b = heroSkinChangeUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601F85C RID: 129116 RVA: 0x00A5A120 File Offset: 0x00A58320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			bool b = heroSkinChangeUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601F85D RID: 129117 RVA: 0x00A5A17C File Offset: 0x00A5837C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			bool b = heroSkinChangeUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601F85E RID: 129118 RVA: 0x00A5A1D8 File Offset: 0x00A583D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			UITaskBase o = heroSkinChangeUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601F85F RID: 129119 RVA: 0x00A5A234 File Offset: 0x00A58434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F860 RID: 129120 RVA: 0x00A5A288 File Offset: 0x00A58488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F861 RID: 129121 RVA: 0x00A5A2DC File Offset: 0x00A584DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F862 RID: 129122 RVA: 0x00A5A330 File Offset: 0x00A58530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F863 RID: 129123 RVA: 0x00A5A384 File Offset: 0x00A58584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBuySkinSucceed(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroSkinChangeUITask.m_luaExportHelper.__callDele_EventOnBuySkinSucceed(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F864 RID: 129124 RVA: 0x00A5A3E0 File Offset: 0x00A585E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBuySkinSucceed(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			heroSkinChangeUITask.m_luaExportHelper.__clearDele_EventOnBuySkinSucceed(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F865 RID: 129125 RVA: 0x00A5A43C File Offset: 0x00A5863C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkinChangedPreview(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroSkinChangeUITask.m_luaExportHelper.__callDele_EventOnSkinChangedPreview(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F866 RID: 129126 RVA: 0x00A5A4A8 File Offset: 0x00A586A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkinChangedPreview(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			heroSkinChangeUITask.m_luaExportHelper.__clearDele_EventOnSkinChangedPreview(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F867 RID: 129127 RVA: 0x00A5A514 File Offset: 0x00A58714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnAddSkinTicket(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__callDele_EventOnAddSkinTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F868 RID: 129128 RVA: 0x00A5A568 File Offset: 0x00A58768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnAddSkinTicket(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			heroSkinChangeUITask.m_luaExportHelper.__clearDele_EventOnAddSkinTicket();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F869 RID: 129129 RVA: 0x00A5A5BC File Offset: 0x00A587BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSkinChangeUITask.EventOnClose += value;
				}
				else if (num == 2)
				{
					heroSkinChangeUITask.EventOnClose -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F86A RID: 129130 RVA: 0x00A5A63C File Offset: 0x00A5883C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBuySkinSucceed(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSkinChangeUITask.EventOnBuySkinSucceed += value;
				}
				else if (num == 2)
				{
					heroSkinChangeUITask.EventOnBuySkinSucceed -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F86B RID: 129131 RVA: 0x00A5A6BC File Offset: 0x00A588BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkinChangedPreview(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			Action<string, int> value;
			int num = LuaObject.checkDelegate<Action<string, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSkinChangeUITask.EventOnSkinChangedPreview += value;
				}
				else if (num == 2)
				{
					heroSkinChangeUITask.EventOnSkinChangedPreview -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F86C RID: 129132 RVA: 0x00A5A73C File Offset: 0x00A5893C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnAddSkinTicket(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroSkinChangeUITask.EventOnAddSkinTicket += value;
				}
				else if (num == 2)
				{
					heroSkinChangeUITask.EventOnAddSkinTicket -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F86D RID: 129133 RVA: 0x00A5A7BC File Offset: 0x00A589BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F86E RID: 129134 RVA: 0x00A5A814 File Offset: 0x00A58A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			heroSkinChangeUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F86F RID: 129135 RVA: 0x00A5A870 File Offset: 0x00A58A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F870 RID: 129136 RVA: 0x00A5A8C8 File Offset: 0x00A58AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			heroSkinChangeUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F871 RID: 129137 RVA: 0x00A5A924 File Offset: 0x00A58B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Mode_SkinBuy(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "SkinBuyMode");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F872 RID: 129138 RVA: 0x00A5A96C File Offset: 0x00A58B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Mode_ShowSkinDetail(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "ShowSkinDetailMode");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F873 RID: 129139 RVA: 0x00A5A9B4 File Offset: 0x00A58BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Mode_ShowOneSkin(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "ShowOneSkin");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F874 RID: 129140 RVA: 0x00A5A9FC File Offset: 0x00A58BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_HeroSkinInfoId(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroSkinChangeUITask.LuaExportHelper.ParamKey_HeroSkinInfoId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F875 RID: 129141 RVA: 0x00A5AA44 File Offset: 0x00A58C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_HeroSkinMode(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroSkinChangeUITask.LuaExportHelper.ParamKey_HeroSkinMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F876 RID: 129142 RVA: 0x00A5AA8C File Offset: 0x00A58C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ParamKey_HeroObj(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HeroSkinChangeUITask.LuaExportHelper.ParamKey_HeroObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F877 RID: 129143 RVA: 0x00A5AAD4 File Offset: 0x00A58CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSkinInfoId(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUITask.m_luaExportHelper.m_heroSkinInfoId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F878 RID: 129144 RVA: 0x00A5AB2C File Offset: 0x00A58D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSkinInfoId(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			int heroSkinInfoId;
			LuaObject.checkType(l, 2, out heroSkinInfoId);
			heroSkinChangeUITask.m_luaExportHelper.m_heroSkinInfoId = heroSkinInfoId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F879 RID: 129145 RVA: 0x00A5AB88 File Offset: 0x00A58D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skinMode(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUITask.m_luaExportHelper.m_skinMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F87A RID: 129146 RVA: 0x00A5ABE0 File Offset: 0x00A58DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinMode(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			string skinMode;
			LuaObject.checkType(l, 2, out skinMode);
			heroSkinChangeUITask.m_luaExportHelper.m_skinMode = skinMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F87B RID: 129147 RVA: 0x00A5AC3C File Offset: 0x00A58E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUITask.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F87C RID: 129148 RVA: 0x00A5AC94 File Offset: 0x00A58E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroSkinChangeUITask.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F87D RID: 129149 RVA: 0x00A5ACF0 File Offset: 0x00A58EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroSkinChangeUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUITask.m_luaExportHelper.m_heroSkinChangeUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F87E RID: 129150 RVA: 0x00A5AD48 File Offset: 0x00A58F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroSkinChangeUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			HeroSkinChangeUIController heroSkinChangeUIController;
			LuaObject.checkType<HeroSkinChangeUIController>(l, 2, out heroSkinChangeUIController);
			heroSkinChangeUITask.m_luaExportHelper.m_heroSkinChangeUIController = heroSkinChangeUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F87F RID: 129151 RVA: 0x00A5ADA4 File Offset: 0x00A58FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F880 RID: 129152 RVA: 0x00A5ADFC File Offset: 0x00A58FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			HeroSkinChangeUITask heroSkinChangeUITask = (HeroSkinChangeUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSkinChangeUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F881 RID: 129153 RVA: 0x00A5AE54 File Offset: 0x00A59054
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroSkinChangeUITask");
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.ClearUIControllerData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.CloseHeroSkinChangePanelWithAnim);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.StartUITask_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.HeroSkinChangeUITask_OnLoadAllResCompleted_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.HeroCharSkinChangeUIController_OnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.HeroCharSkinChangeUIController_OnBuySkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.HeroCharSkinChangeUIController_OnTakeOffCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.HeroCharSkinChangeUIController_OnWearCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.HeroSkinChangeUIController_OnSkinChangedPreview);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.HeroSkinChangeUIController_OnSkinTicketBuy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callDele_EventOnBuySkinSucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__clearDele_EventOnBuySkinSucceed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callDele_EventOnSkinChangedPreview);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__clearDele_EventOnSkinChangedPreview);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__callDele_EventOnAddSkinTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.__clearDele_EventOnAddSkinTicket);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache32);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache33, true);
		string name2 = "EventOnBuySkinSucceed";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.set_EventOnBuySkinSucceed);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache34, true);
		string name3 = "EventOnSkinChangedPreview";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.set_EventOnSkinChangedPreview);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache35, true);
		string name4 = "EventOnAddSkinTicket";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.set_EventOnAddSkinTicket);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache36, true);
		string name5 = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_m_layerDescArray);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache38, true);
		string name6 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3A, true);
		string name7 = "Mode_SkinBuy";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_Mode_SkinBuy);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3B, null, false);
		string name8 = "Mode_ShowSkinDetail";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_Mode_ShowSkinDetail);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3C, null, false);
		string name9 = "Mode_ShowOneSkin";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_Mode_ShowOneSkin);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3D, null, false);
		string name10 = "ParamKey_HeroSkinInfoId";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_ParamKey_HeroSkinInfoId);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3E, null, false);
		string name11 = "ParamKey_HeroSkinMode";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_ParamKey_HeroSkinMode);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache3F, null, false);
		string name12 = "ParamKey_HeroObj";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_ParamKey_HeroObj);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache40, null, false);
		string name13 = "m_heroSkinInfoId";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_m_heroSkinInfoId);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.set_m_heroSkinInfoId);
		}
		LuaObject.addMember(l, name13, get7, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache42, true);
		string name14 = "m_skinMode";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_m_skinMode);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.set_m_skinMode);
		}
		LuaObject.addMember(l, name14, get8, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache44, true);
		string name15 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_m_hero);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.set_m_hero);
		}
		LuaObject.addMember(l, name15, get9, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache46, true);
		string name16 = "m_heroSkinChangeUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_m_heroSkinChangeUIController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.set_m_heroSkinChangeUIController);
		}
		LuaObject.addMember(l, name16, get10, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache48, true);
		string name17 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache49, null, true);
		string name18 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache4A, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroSkinChangeUITask.<>f__mg$cache4B, typeof(HeroSkinChangeUITask), typeof(UITask));
	}

	// Token: 0x04015851 RID: 88145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015852 RID: 88146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015853 RID: 88147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015854 RID: 88148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015855 RID: 88149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015856 RID: 88150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015857 RID: 88151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015858 RID: 88152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015859 RID: 88153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401585A RID: 88154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401585B RID: 88155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401585C RID: 88156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401585D RID: 88157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401585E RID: 88158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401585F RID: 88159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015860 RID: 88160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015861 RID: 88161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015862 RID: 88162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015863 RID: 88163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015864 RID: 88164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015865 RID: 88165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015866 RID: 88166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015867 RID: 88167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015868 RID: 88168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015869 RID: 88169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401586A RID: 88170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401586B RID: 88171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401586C RID: 88172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401586D RID: 88173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401586E RID: 88174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401586F RID: 88175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015870 RID: 88176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015871 RID: 88177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015872 RID: 88178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015873 RID: 88179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015874 RID: 88180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015875 RID: 88181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015876 RID: 88182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015877 RID: 88183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015878 RID: 88184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015879 RID: 88185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401587A RID: 88186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401587B RID: 88187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401587C RID: 88188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401587D RID: 88189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401587E RID: 88190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401587F RID: 88191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015880 RID: 88192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015881 RID: 88193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015882 RID: 88194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015883 RID: 88195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015884 RID: 88196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04015885 RID: 88197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04015886 RID: 88198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04015887 RID: 88199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04015888 RID: 88200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04015889 RID: 88201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401588A RID: 88202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401588B RID: 88203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401588C RID: 88204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401588D RID: 88205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401588E RID: 88206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401588F RID: 88207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04015890 RID: 88208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04015891 RID: 88209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04015892 RID: 88210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04015893 RID: 88211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04015894 RID: 88212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04015895 RID: 88213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04015896 RID: 88214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04015897 RID: 88215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04015898 RID: 88216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04015899 RID: 88217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401589A RID: 88218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401589B RID: 88219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401589C RID: 88220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;
}
