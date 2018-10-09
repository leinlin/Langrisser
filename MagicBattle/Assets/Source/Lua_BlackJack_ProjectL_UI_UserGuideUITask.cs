using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020015D7 RID: 5591
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UserGuideUITask : LuaObject
{
	// Token: 0x060221BF RID: 139711 RVA: 0x00BA38E8 File Offset: 0x00BA1AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			UserGuideUITask o = new UserGuideUITask(name);
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

	// Token: 0x060221C0 RID: 139712 RVA: 0x00BA393C File Offset: 0x00BA1B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize_s(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask.Initialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221C1 RID: 139713 RVA: 0x00BA397C File Offset: 0x00BA1B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveUserGuideProgress_s(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask.SaveUserGuideProgress();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221C2 RID: 139714 RVA: 0x00BA39BC File Offset: 0x00BA1BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUserGuideBattle_s(IntPtr l)
	{
		int result;
		try
		{
			int battleID;
			LuaObject.checkType(l, 1, out battleID);
			bool b = UserGuideUITask.IsUserGuideBattle(battleID);
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

	// Token: 0x060221C3 RID: 139715 RVA: 0x00BA3A10 File Offset: 0x00BA1C10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NeedSkipBattlePrepareForUserGuide_s(IntPtr l)
	{
		int result;
		try
		{
			int battleID;
			LuaObject.checkType(l, 1, out battleID);
			bool b = UserGuideUITask.NeedSkipBattlePrepareForUserGuide(battleID);
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

	// Token: 0x060221C4 RID: 139716 RVA: 0x00BA3A64 File Offset: 0x00BA1C64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetEnforceHeros_s(IntPtr l)
	{
		int result;
		try
		{
			int battleID;
			LuaObject.checkType(l, 1, out battleID);
			List<int> enforceHeros = UserGuideUITask.GetEnforceHeros(battleID);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, enforceHeros);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221C5 RID: 139717 RVA: 0x00BA3AB8 File Offset: 0x00BA1CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnShowObject_s(IntPtr l)
	{
		int result;
		try
		{
			string objectPath;
			LuaObject.checkType(l, 1, out objectPath);
			UserGuideUITask.OnShowObject(objectPath);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221C6 RID: 139718 RVA: 0x00BA3B04 File Offset: 0x00BA1D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHideObject_s(IntPtr l)
	{
		int result;
		try
		{
			string objectPath;
			LuaObject.checkType(l, 1, out objectPath);
			UserGuideUITask.OnHideObject(objectPath);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221C7 RID: 139719 RVA: 0x00BA3B50 File Offset: 0x00BA1D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUIStateEnd_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 1, out obj);
			string stateName;
			LuaObject.checkType(l, 2, out stateName);
			UserGuideUITask.OnUIStateEnd(obj, stateName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221C8 RID: 139720 RVA: 0x00BA3BA8 File Offset: 0x00BA1DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectBattleActor_s(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 1, out a);
			UserGuideUITask.OnSelectBattleActor(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221C9 RID: 139721 RVA: 0x00BA3BF4 File Offset: 0x00BA1DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWorldUIGetReady_s(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask.OnWorldUIGetReady();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221CA RID: 139722 RVA: 0x00BA3C34 File Offset: 0x00BA1E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnServerFinishUserGuide_s(IntPtr l)
	{
		int result;
		try
		{
			int guideID;
			LuaObject.checkType(l, 1, out guideID);
			UserGuideUITask.OnServerFinishUserGuide(guideID);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221CB RID: 139723 RVA: 0x00BA3C80 File Offset: 0x00BA1E80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDeselectBattleActor_s(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleActor a;
			LuaObject.checkType<ClientBattleActor>(l, 1, out a);
			UserGuideUITask.OnDeselectBattleActor(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221CC RID: 139724 RVA: 0x00BA3CCC File Offset: 0x00BA1ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGiftStoreGoodsBuy_s(IntPtr l)
	{
		int result;
		try
		{
			int goodsId;
			LuaObject.checkType(l, 1, out goodsId);
			UserGuideUITask.OnGiftStoreGoodsBuy(goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221CD RID: 139725 RVA: 0x00BA3D18 File Offset: 0x00BA1F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUITaskShow_s(IntPtr l)
	{
		int result;
		try
		{
			string taskName;
			LuaObject.checkType(l, 1, out taskName);
			UserGuideUITask.OnUITaskShow(taskName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221CE RID: 139726 RVA: 0x00BA3D64 File Offset: 0x00BA1F64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnReturnToLoginUI_s(IntPtr l)
	{
		int result;
		try
		{
			bool obj;
			LuaObject.checkType(l, 1, out obj);
			UserGuideUITask.OnReturnToLoginUI(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221CF RID: 139727 RVA: 0x00BA3DB0 File Offset: 0x00BA1FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPrefabAwake_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject awakeObj;
			LuaObject.checkType<GameObject>(l, 1, out awakeObj);
			UserGuideUITask.OnPrefabAwake(awakeObj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221D0 RID: 139728 RVA: 0x00BA3DFC File Offset: 0x00BA1FFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CheckCondition_s(IntPtr l)
	{
		int result;
		try
		{
			UserGuideCondition c;
			LuaObject.checkEnum<UserGuideCondition>(l, 1, out c);
			string param;
			LuaObject.checkType(l, 2, out param);
			bool b = UserGuideUITask.CheckCondition(c, param);
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

	// Token: 0x060221D1 RID: 139729 RVA: 0x00BA3E5C File Offset: 0x00BA205C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartStep_s(IntPtr l)
	{
		int result;
		try
		{
			int userGuideId;
			LuaObject.checkType(l, 1, out userGuideId);
			int userGuideStepId;
			LuaObject.checkType(l, 2, out userGuideStepId);
			bool bSkipEnable;
			LuaObject.checkType(l, 3, out bSkipEnable);
			UserGuideUITask.StartStep(userGuideId, userGuideStepId, bSkipEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221D2 RID: 139730 RVA: 0x00BA3EC0 File Offset: 0x00BA20C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChildTransform_s(IntPtr l)
	{
		int result;
		try
		{
			Transform parent;
			LuaObject.checkType<Transform>(l, 1, out parent);
			Transform child;
			LuaObject.checkType<Transform>(l, 2, out child);
			bool b = UserGuideUITask.IsChildTransform(parent, child);
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

	// Token: 0x060221D3 RID: 139731 RVA: 0x00BA3F20 File Offset: 0x00BA2120
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TriggerUserGuide(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UserGuideTrigger trigger;
			LuaObject.checkEnum<UserGuideTrigger>(l, 2, out trigger);
			string param;
			LuaObject.checkType(l, 3, out param);
			bool b = userGuideUITask.m_luaExportHelper.TriggerUserGuide(trigger, param);
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

	// Token: 0x060221D4 RID: 139732 RVA: 0x00BA3F94 File Offset: 0x00BA2194
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = userGuideUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x060221D5 RID: 139733 RVA: 0x00BA3FFC File Offset: 0x00BA21FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForceStop(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.ForceStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221D6 RID: 139734 RVA: 0x00BA4050 File Offset: 0x00BA2250
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnResume(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = userGuideUITask.m_luaExportHelper.OnResume(intent);
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

	// Token: 0x060221D7 RID: 139735 RVA: 0x00BA40B8 File Offset: 0x00BA22B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDataFromUIIntent(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			userGuideUITask.m_luaExportHelper.InitDataFromUIIntent(intent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221D8 RID: 139736 RVA: 0x00BA4114 File Offset: 0x00BA2314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool b = userGuideUITask.m_luaExportHelper.IsNeedLoadDynamicRes();
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

	// Token: 0x060221D9 RID: 139737 RVA: 0x00BA4170 File Offset: 0x00BA2370
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221DA RID: 139738 RVA: 0x00BA41C4 File Offset: 0x00BA23C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221DB RID: 139739 RVA: 0x00BA4218 File Offset: 0x00BA2418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221DC RID: 139740 RVA: 0x00BA426C File Offset: 0x00BA246C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddShowHideEventForUserGuideStep(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.AddShowHideEventForUserGuideStep();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221DD RID: 139741 RVA: 0x00BA42C0 File Offset: 0x00BA24C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.DoUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221DE RID: 139742 RVA: 0x00BA4314 File Offset: 0x00BA2514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableInputLately(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			IEnumerator o = userGuideUITask.m_luaExportHelper.EnableInputLately(time);
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

	// Token: 0x060221DF RID: 139743 RVA: 0x00BA437C File Offset: 0x00BA257C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoUpdateViewAsync(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			IEnumerator o = userGuideUITask.m_luaExportHelper.DoUpdateViewAsync();
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

	// Token: 0x060221E0 RID: 139744 RVA: 0x00BA43D8 File Offset: 0x00BA25D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFunctionOpenAnimEnd(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.OnFunctionOpenAnimEnd();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221E1 RID: 139745 RVA: 0x00BA442C File Offset: 0x00BA262C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsClickable(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			bool b = userGuideUITask.m_luaExportHelper.IsClickable(obj);
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

	// Token: 0x060221E2 RID: 139746 RVA: 0x00BA4494 File Offset: 0x00BA2694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareForGetUIPosition(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			GameObject uiObj;
			LuaObject.checkType<GameObject>(l, 2, out uiObj);
			userGuideUITask.m_luaExportHelper.PrepareForGetUIPosition(uiObj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221E3 RID: 139747 RVA: 0x00BA44F0 File Offset: 0x00BA26F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClickObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			string[] objPath;
			LuaObject.checkArray<string>(l, 2, out objPath);
			userGuideUITask.m_luaExportHelper.ClickObject(objPath);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221E4 RID: 139748 RVA: 0x00BA454C File Offset: 0x00BA274C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Click(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			GameObject o;
			LuaObject.checkType<GameObject>(l, 2, out o);
			bool b = userGuideUITask.m_luaExportHelper.Click(o);
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

	// Token: 0x060221E5 RID: 139749 RVA: 0x00BA45B4 File Offset: 0x00BA27B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ArrayToPathString(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			string[] path;
			LuaObject.checkArray<string>(l, 2, out path);
			string s = userGuideUITask.m_luaExportHelper.ArrayToPathString(path);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221E6 RID: 139750 RVA: 0x00BA461C File Offset: 0x00BA281C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DoAction(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UserGuideAction action;
			LuaObject.checkEnum<UserGuideAction>(l, 2, out action);
			string param;
			LuaObject.checkType(l, 3, out param);
			IEnumerator o = userGuideUITask.m_luaExportHelper.DoAction(action, param);
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

	// Token: 0x060221E7 RID: 139751 RVA: 0x00BA4690 File Offset: 0x00BA2890
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EnableBattleCameraTouchMove(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			userGuideUITask.m_luaExportHelper.EnableBattleCameraTouchMove(isEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221E8 RID: 139752 RVA: 0x00BA46EC File Offset: 0x00BA28EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FinishCurrentUserGuide(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.FinishCurrentUserGuide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221E9 RID: 139753 RVA: 0x00BA4740 File Offset: 0x00BA2940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WaitForObjectReady(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			string objPath;
			LuaObject.checkType(l, 2, out objPath);
			IEnumerator o = userGuideUITask.m_luaExportHelper.WaitForObjectReady(objPath);
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

	// Token: 0x060221EA RID: 139754 RVA: 0x00BA47A8 File Offset: 0x00BA29A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScrollToItem(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			string scrollObjPath;
			LuaObject.checkType(l, 2, out scrollObjPath);
			string itemObjPath;
			LuaObject.checkType(l, 3, out itemObjPath);
			IEnumerator o = userGuideUITask.m_luaExportHelper.ScrollToItem(scrollObjPath, itemObjPath);
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

	// Token: 0x060221EB RID: 139755 RVA: 0x00BA481C File Offset: 0x00BA2A1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EnableObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			bool isEnable;
			LuaObject.checkType(l, 3, out isEnable);
			userGuideUITask.m_luaExportHelper.EnableObject(obj, isEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221EC RID: 139756 RVA: 0x00BA4888 File Offset: 0x00BA2A88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClickBattleGrid(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			int x;
			LuaObject.checkType(l, 2, out x);
			int y;
			LuaObject.checkType(l, 3, out y);
			userGuideUITask.m_luaExportHelper.ClickBattleGrid(x, y);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221ED RID: 139757 RVA: 0x00BA48F4 File Offset: 0x00BA2AF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowCurrentPage(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.ShowCurrentPage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221EE RID: 139758 RVA: 0x00BA4948 File Offset: 0x00BA2B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitUserGuideUIController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.InitUserGuideUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221EF RID: 139759 RVA: 0x00BA499C File Offset: 0x00BA2B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitUserGuideUIController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.UninitUserGuideUIController();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221F0 RID: 139760 RVA: 0x00BA49F0 File Offset: 0x00BA2BF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartBattleDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out dialogInfo);
			userGuideUITask.m_luaExportHelper.StartBattleDialogUITask(dialogInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221F1 RID: 139761 RVA: 0x00BA4A4C File Offset: 0x00BA2C4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleDialogUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.BattleDialogUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221F2 RID: 139762 RVA: 0x00BA4AA0 File Offset: 0x00BA2CA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartUserGuideDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			ConfigDataUserGuideDialogInfo dialogInfo;
			LuaObject.checkType<ConfigDataUserGuideDialogInfo>(l, 2, out dialogInfo);
			IEnumerator o = userGuideUITask.m_luaExportHelper.StartUserGuideDialogUITask(dialogInfo);
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

	// Token: 0x060221F3 RID: 139763 RVA: 0x00BA4B08 File Offset: 0x00BA2D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UserGuideDialogUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.UserGuideDialogUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221F4 RID: 139764 RVA: 0x00BA4B5C File Offset: 0x00BA2D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNextButtonClicked(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.OnNextButtonClicked();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221F5 RID: 139765 RVA: 0x00BA4BB0 File Offset: 0x00BA2DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkipUserGuide(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.OnSkipUserGuide();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221F6 RID: 139766 RVA: 0x00BA4C04 File Offset: 0x00BA2E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Finish(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool isClick;
			LuaObject.checkType(l, 2, out isClick);
			bool bForce;
			LuaObject.checkType(l, 3, out bForce);
			userGuideUITask.m_luaExportHelper.Finish(isClick, bForce);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221F7 RID: 139767 RVA: 0x00BA4C70 File Offset: 0x00BA2E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Next(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.Next();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221F8 RID: 139768 RVA: 0x00BA4CC4 File Offset: 0x00BA2EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UserGuideUIController_OnNextPage(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.UserGuideUIController_OnNextPage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221F9 RID: 139769 RVA: 0x00BA4D18 File Offset: 0x00BA2F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UserGuideUIController_OnPrevPage(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.UserGuideUIController_OnPrevPage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221FA RID: 139770 RVA: 0x00BA4D6C File Offset: 0x00BA2F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleDialogUITask_OnUserGuideClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.BattleDialogUITask_OnUserGuideClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221FB RID: 139771 RVA: 0x00BA4DC0 File Offset: 0x00BA2FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UserGuideDialogUITask_OnUserGuideClose(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.UserGuideDialogUITask_OnUserGuideClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221FC RID: 139772 RVA: 0x00BA4E14 File Offset: 0x00BA3014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = userGuideUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x060221FD RID: 139773 RVA: 0x00BA4E7C File Offset: 0x00BA307C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221FE RID: 139774 RVA: 0x00BA4ED0 File Offset: 0x00BA30D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221FF RID: 139775 RVA: 0x00BA4F24 File Offset: 0x00BA3124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = userGuideUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x06022200 RID: 139776 RVA: 0x00BA4F8C File Offset: 0x00BA318C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = userGuideUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x06022201 RID: 139777 RVA: 0x00BA4FF4 File Offset: 0x00BA31F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			userGuideUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022202 RID: 139778 RVA: 0x00BA5060 File Offset: 0x00BA3260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool b = userGuideUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x06022203 RID: 139779 RVA: 0x00BA50BC File Offset: 0x00BA32BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			List<string> o = userGuideUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x06022204 RID: 139780 RVA: 0x00BA5118 File Offset: 0x00BA3318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022205 RID: 139781 RVA: 0x00BA516C File Offset: 0x00BA336C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022206 RID: 139782 RVA: 0x00BA51C0 File Offset: 0x00BA33C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022207 RID: 139783 RVA: 0x00BA5214 File Offset: 0x00BA3414
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022208 RID: 139784 RVA: 0x00BA5268 File Offset: 0x00BA3468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022209 RID: 139785 RVA: 0x00BA52BC File Offset: 0x00BA34BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			userGuideUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602220A RID: 139786 RVA: 0x00BA5318 File Offset: 0x00BA3518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			userGuideUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602220B RID: 139787 RVA: 0x00BA5374 File Offset: 0x00BA3574
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			userGuideUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602220C RID: 139788 RVA: 0x00BA53D0 File Offset: 0x00BA35D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			userGuideUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602220D RID: 139789 RVA: 0x00BA542C File Offset: 0x00BA362C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool b = userGuideUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0602220E RID: 139790 RVA: 0x00BA5488 File Offset: 0x00BA3688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool b = userGuideUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0602220F RID: 139791 RVA: 0x00BA54E4 File Offset: 0x00BA36E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool b = userGuideUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x06022210 RID: 139792 RVA: 0x00BA5540 File Offset: 0x00BA3740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UITaskBase o = userGuideUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x06022211 RID: 139793 RVA: 0x00BA559C File Offset: 0x00BA379C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022212 RID: 139794 RVA: 0x00BA55F0 File Offset: 0x00BA37F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			userGuideUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022213 RID: 139795 RVA: 0x00BA5644 File Offset: 0x00BA3844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddUserGuideTriggerCount_s(IntPtr l)
	{
		int result;
		try
		{
			int userGuideId;
			LuaObject.checkType(l, 1, out userGuideId);
			UserGuideUITask.LuaExportHelper.AddUserGuideTriggerCount(userGuideId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022214 RID: 139796 RVA: 0x00BA5690 File Offset: 0x00BA3890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUserGuideTriggerCount_s(IntPtr l)
	{
		int result;
		try
		{
			int userGuideId;
			LuaObject.checkType(l, 1, out userGuideId);
			int userGuideTriggerCount = UserGuideUITask.LuaExportHelper.GetUserGuideTriggerCount(userGuideId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideTriggerCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022215 RID: 139797 RVA: 0x00BA56E4 File Offset: 0x00BA38E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadUserGuideProgress_s(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask.LuaExportHelper.LoadUserGuideProgress();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022216 RID: 139798 RVA: 0x00BA5724 File Offset: 0x00BA3924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectUserGuideShowHideEventObjectPaths_s(IntPtr l)
	{
		int result;
		try
		{
			List<string[]> paths;
			LuaObject.checkType<List<string[]>>(l, 1, out paths);
			UserGuideUITask.LuaExportHelper.CollectUserGuideShowHideEventObjectPaths(paths);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022217 RID: 139799 RVA: 0x00BA5770 File Offset: 0x00BA3970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddShowHideEventForUserGuide_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 1, out obj);
			UserGuideUITask.LuaExportHelper.AddShowHideEventForUserGuide(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022218 RID: 139800 RVA: 0x00BA57BC File Offset: 0x00BA39BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUserGuideTriggerObject_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 1, out obj);
			bool b = UserGuideUITask.LuaExportHelper.IsUserGuideTriggerObject(obj);
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

	// Token: 0x06022219 RID: 139801 RVA: 0x00BA5810 File Offset: 0x00BA3A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Trigger_s(IntPtr l)
	{
		int result;
		try
		{
			UserGuideTrigger trigger;
			LuaObject.checkEnum<UserGuideTrigger>(l, 1, out trigger);
			string param;
			LuaObject.checkType(l, 2, out param);
			bool b = UserGuideUITask.LuaExportHelper.Trigger(trigger, param);
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

	// Token: 0x0602221A RID: 139802 RVA: 0x00BA5870 File Offset: 0x00BA3A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MatchTrigger_s(IntPtr l)
	{
		int result;
		try
		{
			UserGuideTrigger trigger;
			LuaObject.checkEnum<UserGuideTrigger>(l, 1, out trigger);
			string param;
			LuaObject.checkType(l, 2, out param);
			UserGuideTrigger trigger2;
			LuaObject.checkEnum<UserGuideTrigger>(l, 3, out trigger2);
			string param2;
			LuaObject.checkType(l, 4, out param2);
			bool b = UserGuideUITask.LuaExportHelper.MatchTrigger(trigger, param, trigger2, param2);
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

	// Token: 0x0602221B RID: 139803 RVA: 0x00BA58EC File Offset: 0x00BA3AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCenterScreenPosition_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rt;
			LuaObject.checkType<RectTransform>(l, 1, out rt);
			Vector2 o;
			LuaObject.checkType(l, 2, out o);
			bool centerScreenPosition = UserGuideUITask.LuaExportHelper.GetCenterScreenPosition(rt, ref o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, centerScreenPosition);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602221C RID: 139804 RVA: 0x00BA5954 File Offset: 0x00BA3B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInsideScreen_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 pos;
			LuaObject.checkType(l, 1, out pos);
			bool b = UserGuideUITask.LuaExportHelper.IsInsideScreen(pos);
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

	// Token: 0x0602221D RID: 139805 RVA: 0x00BA59A8 File Offset: 0x00BA3BA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602221E RID: 139806 RVA: 0x00BA5A00 File Offset: 0x00BA3C00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			userGuideUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602221F RID: 139807 RVA: 0x00BA5A5C File Offset: 0x00BA3C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022220 RID: 139808 RVA: 0x00BA5AB4 File Offset: 0x00BA3CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			userGuideUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022221 RID: 139809 RVA: 0x00BA5B10 File Offset: 0x00BA3D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initCoroutine(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_initCoroutine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022222 RID: 139810 RVA: 0x00BA5B68 File Offset: 0x00BA3D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initCoroutine(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			Coroutine initCoroutine;
			LuaObject.checkType<Coroutine>(l, 2, out initCoroutine);
			userGuideUITask.m_luaExportHelper.m_initCoroutine = initCoroutine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022223 RID: 139811 RVA: 0x00BA5BC4 File Offset: 0x00BA3DC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_userGuideUIController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_userGuideUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022224 RID: 139812 RVA: 0x00BA5C1C File Offset: 0x00BA3E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideUIController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UserGuideUIController userGuideUIController;
			LuaObject.checkType<UserGuideUIController>(l, 2, out userGuideUIController);
			userGuideUITask.m_luaExportHelper.m_userGuideUIController = userGuideUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022225 RID: 139813 RVA: 0x00BA5C78 File Offset: 0x00BA3E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userGuideStepInfo(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_userGuideStepInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022226 RID: 139814 RVA: 0x00BA5CD0 File Offset: 0x00BA3ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideStepInfo(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			ConfigDataUserGuideStep userGuideStepInfo;
			LuaObject.checkType<ConfigDataUserGuideStep>(l, 2, out userGuideStepInfo);
			userGuideUITask.m_luaExportHelper.m_userGuideStepInfo = userGuideStepInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022227 RID: 139815 RVA: 0x00BA5D2C File Offset: 0x00BA3F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_waitForClickObjectTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UserGuideUITask.LuaExportHelper.m_waitForClickObjectTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022228 RID: 139816 RVA: 0x00BA5D74 File Offset: 0x00BA3F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_maxWaitObjectTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UserGuideUITask.LuaExportHelper.m_maxWaitObjectTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022229 RID: 139817 RVA: 0x00BA5DBC File Offset: 0x00BA3FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_battleDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602222A RID: 139818 RVA: 0x00BA5E14 File Offset: 0x00BA4014
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo battleDialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out battleDialogInfo);
			userGuideUITask.m_luaExportHelper.m_battleDialogInfo = battleDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602222B RID: 139819 RVA: 0x00BA5E70 File Offset: 0x00BA4070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_battleDialogUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602222C RID: 139820 RVA: 0x00BA5EC8 File Offset: 0x00BA40C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			BattleDialogUITask battleDialogUITask;
			LuaObject.checkType<BattleDialogUITask>(l, 2, out battleDialogUITask);
			userGuideUITask.m_luaExportHelper.m_battleDialogUITask = battleDialogUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602222D RID: 139821 RVA: 0x00BA5F24 File Offset: 0x00BA4124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userGuideDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_userGuideDialogUITask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602222E RID: 139822 RVA: 0x00BA5F7C File Offset: 0x00BA417C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideDialogUITask(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			UserGuideDialogUITask userGuideDialogUITask;
			LuaObject.checkType<UserGuideDialogUITask>(l, 2, out userGuideDialogUITask);
			userGuideUITask.m_luaExportHelper.m_userGuideDialogUITask = userGuideDialogUITask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602222F RID: 139823 RVA: 0x00BA5FD8 File Offset: 0x00BA41D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pageIndex(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_pageIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022230 RID: 139824 RVA: 0x00BA6030 File Offset: 0x00BA4230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pageIndex(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			int pageIndex;
			LuaObject.checkType(l, 2, out pageIndex);
			userGuideUITask.m_luaExportHelper.m_pageIndex = pageIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022231 RID: 139825 RVA: 0x00BA608C File Offset: 0x00BA428C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nUserGuideId(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_nUserGuideId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022232 RID: 139826 RVA: 0x00BA60E4 File Offset: 0x00BA42E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nUserGuideId(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			int nUserGuideId;
			LuaObject.checkType(l, 2, out nUserGuideId);
			userGuideUITask.m_luaExportHelper.m_nUserGuideId = nUserGuideId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022233 RID: 139827 RVA: 0x00BA6140 File Offset: 0x00BA4340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDoingUpdateViewAsync(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_isDoingUpdateViewAsync);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022234 RID: 139828 RVA: 0x00BA6198 File Offset: 0x00BA4398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDoingUpdateViewAsync(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool isDoingUpdateViewAsync;
			LuaObject.checkType(l, 2, out isDoingUpdateViewAsync);
			userGuideUITask.m_luaExportHelper.m_isDoingUpdateViewAsync = isDoingUpdateViewAsync;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022235 RID: 139829 RVA: 0x00BA61F4 File Offset: 0x00BA43F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_temporaryDisableObjects(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_temporaryDisableObjects);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022236 RID: 139830 RVA: 0x00BA624C File Offset: 0x00BA444C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_temporaryDisableObjects(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			List<GameObject> temporaryDisableObjects;
			LuaObject.checkType<List<GameObject>>(l, 2, out temporaryDisableObjects);
			userGuideUITask.m_luaExportHelper.m_temporaryDisableObjects = temporaryDisableObjects;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022237 RID: 139831 RVA: 0x00BA62A8 File Offset: 0x00BA44A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_temporaryDeactiveObjects(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_temporaryDeactiveObjects);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022238 RID: 139832 RVA: 0x00BA6300 File Offset: 0x00BA4500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_temporaryDeactiveObjects(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			List<GameObject> temporaryDeactiveObjects;
			LuaObject.checkType<List<GameObject>>(l, 2, out temporaryDeactiveObjects);
			userGuideUITask.m_luaExportHelper.m_temporaryDeactiveObjects = temporaryDeactiveObjects;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022239 RID: 139833 RVA: 0x00BA635C File Offset: 0x00BA455C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFinished(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_isFinished);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602223A RID: 139834 RVA: 0x00BA63B4 File Offset: 0x00BA45B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFinished(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool isFinished;
			LuaObject.checkType(l, 2, out isFinished);
			userGuideUITask.m_luaExportHelper.m_isFinished = isFinished;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602223B RID: 139835 RVA: 0x00BA6410 File Offset: 0x00BA4610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isTemporaryDisableMoveBattleCamera(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_isTemporaryDisableMoveBattleCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602223C RID: 139836 RVA: 0x00BA6468 File Offset: 0x00BA4668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isTemporaryDisableMoveBattleCamera(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool isTemporaryDisableMoveBattleCamera;
			LuaObject.checkType(l, 2, out isTemporaryDisableMoveBattleCamera);
			userGuideUITask.m_luaExportHelper.m_isTemporaryDisableMoveBattleCamera = isTemporaryDisableMoveBattleCamera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602223D RID: 139837 RVA: 0x00BA64C4 File Offset: 0x00BA46C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isEnableSkip(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.m_isEnableSkip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602223E RID: 139838 RVA: 0x00BA651C File Offset: 0x00BA471C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isEnableSkip(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			bool isEnableSkip;
			LuaObject.checkType(l, 2, out isEnableSkip);
			userGuideUITask.m_luaExportHelper.m_isEnableSkip = isEnableSkip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602223F RID: 139839 RVA: 0x00BA6578 File Offset: 0x00BA4778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_triggerUserGuideCounts(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UserGuideUITask.LuaExportHelper.m_triggerUserGuideCounts);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022240 RID: 139840 RVA: 0x00BA65C0 File Offset: 0x00BA47C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_triggerUserGuideCounts(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, int> triggerUserGuideCounts;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out triggerUserGuideCounts);
			UserGuideUITask.LuaExportHelper.m_triggerUserGuideCounts = triggerUserGuideCounts;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022241 RID: 139841 RVA: 0x00BA660C File Offset: 0x00BA480C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userGuideConfigs(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UserGuideUITask.LuaExportHelper.m_userGuideConfigs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022242 RID: 139842 RVA: 0x00BA6654 File Offset: 0x00BA4854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideConfigs(IntPtr l)
	{
		int result;
		try
		{
			Dictionary<int, ConfigDataUserGuide> userGuideConfigs;
			LuaObject.checkType<Dictionary<int, ConfigDataUserGuide>>(l, 2, out userGuideConfigs);
			UserGuideUITask.LuaExportHelper.m_userGuideConfigs = userGuideConfigs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022243 RID: 139843 RVA: 0x00BA66A0 File Offset: 0x00BA48A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userGuideShowHideEventObjectPaths(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UserGuideUITask.LuaExportHelper.m_userGuideShowHideEventObjectPaths);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022244 RID: 139844 RVA: 0x00BA66E8 File Offset: 0x00BA48E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideShowHideEventObjectPaths(IntPtr l)
	{
		int result;
		try
		{
			List<string[]> userGuideShowHideEventObjectPaths;
			LuaObject.checkType<List<string[]>>(l, 2, out userGuideShowHideEventObjectPaths);
			UserGuideUITask.LuaExportHelper.m_userGuideShowHideEventObjectPaths = userGuideShowHideEventObjectPaths;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022245 RID: 139845 RVA: 0x00BA6734 File Offset: 0x00BA4934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isEnable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UserGuideUITask.LuaExportHelper.m_isEnable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022246 RID: 139846 RVA: 0x00BA677C File Offset: 0x00BA497C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isEnable(IntPtr l)
	{
		int result;
		try
		{
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			UserGuideUITask.LuaExportHelper.m_isEnable = isEnable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022247 RID: 139847 RVA: 0x00BA67C8 File Offset: 0x00BA49C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dragHeroToBattleUserGuideID(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UserGuideUITask.LuaExportHelper.m_dragHeroToBattleUserGuideID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022248 RID: 139848 RVA: 0x00BA6810 File Offset: 0x00BA4A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dragHeroToBattleUserGuideID(IntPtr l)
	{
		int result;
		try
		{
			int dragHeroToBattleUserGuideID;
			LuaObject.checkType(l, 2, out dragHeroToBattleUserGuideID);
			UserGuideUITask.LuaExportHelper.m_dragHeroToBattleUserGuideID = dragHeroToBattleUserGuideID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022249 RID: 139849 RVA: 0x00BA685C File Offset: 0x00BA4A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserGuideProgressFileName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UserGuideUITask.LuaExportHelper.UserGuideProgressFileName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602224A RID: 139850 RVA: 0x00BA68A4 File Offset: 0x00BA4AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602224B RID: 139851 RVA: 0x00BA68FC File Offset: 0x00BA4AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Enable(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, UserGuideUITask.Enable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602224C RID: 139852 RVA: 0x00BA6944 File Offset: 0x00BA4B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Enable(IntPtr l)
	{
		int result;
		try
		{
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			UserGuideUITask.Enable = enable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602224D RID: 139853 RVA: 0x00BA6990 File Offset: 0x00BA4B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUITask userGuideUITask = (UserGuideUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602224E RID: 139854 RVA: 0x00BA69E8 File Offset: 0x00BA4BE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UserGuideUITask");
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.Initialize_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.SaveUserGuideProgress_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.IsUserGuideBattle_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.NeedSkipBattlePrepareForUserGuide_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.GetEnforceHeros_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnShowObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnHideObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnUIStateEnd_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnSelectBattleActor_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnWorldUIGetReady_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnServerFinishUserGuide_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnDeselectBattleActor_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnGiftStoreGoodsBuy_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnUITaskShow_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnReturnToLoginUI_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnPrefabAwake_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.CheckCondition_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.StartStep_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.IsChildTransform_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.TriggerUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.ForceStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.InitDataFromUIIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.AddShowHideEventForUserGuideStep);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.DoUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.EnableInputLately);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.DoUpdateViewAsync);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnFunctionOpenAnimEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.IsClickable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.PrepareForGetUIPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.ClickObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.Click);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.ArrayToPathString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.DoAction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.EnableBattleCameraTouchMove);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.FinishCurrentUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.WaitForObjectReady);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.ScrollToItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.EnableObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.ClickBattleGrid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.ShowCurrentPage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.InitUserGuideUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.UninitUserGuideUIController);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.StartBattleDialogUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.BattleDialogUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.StartUserGuideDialogUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.UserGuideDialogUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnNextButtonClicked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.OnSkipUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.Finish);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.Next);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.UserGuideUIController_OnNextPage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.UserGuideUIController_OnPrevPage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.BattleDialogUITask_OnUserGuideClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.UserGuideDialogUITask_OnUserGuideClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.AddUserGuideTriggerCount_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.GetUserGuideTriggerCount_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.LoadUserGuideProgress_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.CollectUserGuideShowHideEventObjectPaths_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.AddShowHideEventForUserGuide_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.IsUserGuideTriggerObject_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.Trigger_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.MatchTrigger_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.GetCenterScreenPosition_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.IsInsideScreen_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5C);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5E, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache60, true);
		string name3 = "m_initCoroutine";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_initCoroutine);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_initCoroutine);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache62, true);
		string name4 = "m_userGuideUIController";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_userGuideUIController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_userGuideUIController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache64, true);
		string name5 = "m_userGuideStepInfo";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_userGuideStepInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_userGuideStepInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache66, true);
		string name6 = "m_waitForClickObjectTime";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_waitForClickObjectTime);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache67, null, false);
		string name7 = "m_maxWaitObjectTime";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_maxWaitObjectTime);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache68, null, false);
		string name8 = "m_battleDialogInfo";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_battleDialogInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_battleDialogInfo);
		}
		LuaObject.addMember(l, name8, get6, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6A, true);
		string name9 = "m_battleDialogUITask";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_battleDialogUITask);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_battleDialogUITask);
		}
		LuaObject.addMember(l, name9, get7, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6C, true);
		string name10 = "m_userGuideDialogUITask";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_userGuideDialogUITask);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_userGuideDialogUITask);
		}
		LuaObject.addMember(l, name10, get8, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6E, true);
		string name11 = "m_pageIndex";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_pageIndex);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_pageIndex);
		}
		LuaObject.addMember(l, name11, get9, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache70, true);
		string name12 = "m_nUserGuideId";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_nUserGuideId);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_nUserGuideId);
		}
		LuaObject.addMember(l, name12, get10, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache72, true);
		string name13 = "m_isDoingUpdateViewAsync";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_isDoingUpdateViewAsync);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_isDoingUpdateViewAsync);
		}
		LuaObject.addMember(l, name13, get11, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache74, true);
		string name14 = "m_temporaryDisableObjects";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_temporaryDisableObjects);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_temporaryDisableObjects);
		}
		LuaObject.addMember(l, name14, get12, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache76, true);
		string name15 = "m_temporaryDeactiveObjects";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_temporaryDeactiveObjects);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_temporaryDeactiveObjects);
		}
		LuaObject.addMember(l, name15, get13, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache78, true);
		string name16 = "m_isFinished";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_isFinished);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_isFinished);
		}
		LuaObject.addMember(l, name16, get14, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7A, true);
		string name17 = "m_isTemporaryDisableMoveBattleCamera";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_isTemporaryDisableMoveBattleCamera);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_isTemporaryDisableMoveBattleCamera);
		}
		LuaObject.addMember(l, name17, get15, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7C, true);
		string name18 = "m_isEnableSkip";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_isEnableSkip);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_isEnableSkip);
		}
		LuaObject.addMember(l, name18, get16, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7E, true);
		string name19 = "m_triggerUserGuideCounts";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_triggerUserGuideCounts);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_triggerUserGuideCounts);
		}
		LuaObject.addMember(l, name19, get17, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache80, false);
		string name20 = "m_userGuideConfigs";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_userGuideConfigs);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_userGuideConfigs);
		}
		LuaObject.addMember(l, name20, get18, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache82, false);
		string name21 = "m_userGuideShowHideEventObjectPaths";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_userGuideShowHideEventObjectPaths);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_userGuideShowHideEventObjectPaths);
		}
		LuaObject.addMember(l, name21, get19, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache84, false);
		string name22 = "m_isEnable";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_isEnable);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_isEnable);
		}
		LuaObject.addMember(l, name22, get20, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache86, false);
		string name23 = "m_dragHeroToBattleUserGuideID";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_m_dragHeroToBattleUserGuideID);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_m_dragHeroToBattleUserGuideID);
		}
		LuaObject.addMember(l, name23, get21, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache88, false);
		string name24 = "UserGuideProgressFileName";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_UserGuideProgressFileName);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache89, null, false);
		string name25 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8A, null, true);
		string name26 = "Enable";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_Enable);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.set_Enable);
		}
		LuaObject.addMember(l, name26, get22, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8C, false);
		string name27 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8D, null, true);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UserGuideUITask.<>f__mg$cache8E, typeof(UserGuideUITask), typeof(UITask));
	}

	// Token: 0x04017FF3 RID: 98291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017FF4 RID: 98292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017FF5 RID: 98293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017FF6 RID: 98294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017FF7 RID: 98295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017FF8 RID: 98296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017FF9 RID: 98297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017FFA RID: 98298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017FFB RID: 98299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017FFC RID: 98300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017FFD RID: 98301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017FFE RID: 98302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017FFF RID: 98303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018000 RID: 98304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018001 RID: 98305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018002 RID: 98306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018003 RID: 98307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018004 RID: 98308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018005 RID: 98309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018006 RID: 98310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018007 RID: 98311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018008 RID: 98312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018009 RID: 98313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401800A RID: 98314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401800B RID: 98315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401800C RID: 98316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401800D RID: 98317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401800E RID: 98318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401800F RID: 98319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04018010 RID: 98320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04018011 RID: 98321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04018012 RID: 98322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04018013 RID: 98323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04018014 RID: 98324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018015 RID: 98325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018016 RID: 98326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04018017 RID: 98327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04018018 RID: 98328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04018019 RID: 98329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401801A RID: 98330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401801B RID: 98331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401801C RID: 98332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401801D RID: 98333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401801E RID: 98334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401801F RID: 98335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04018020 RID: 98336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04018021 RID: 98337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04018022 RID: 98338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04018023 RID: 98339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04018024 RID: 98340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04018025 RID: 98341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04018026 RID: 98342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04018027 RID: 98343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04018028 RID: 98344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04018029 RID: 98345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401802A RID: 98346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401802B RID: 98347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401802C RID: 98348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401802D RID: 98349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401802E RID: 98350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401802F RID: 98351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04018030 RID: 98352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04018031 RID: 98353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04018032 RID: 98354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04018033 RID: 98355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04018034 RID: 98356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04018035 RID: 98357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04018036 RID: 98358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04018037 RID: 98359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04018038 RID: 98360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04018039 RID: 98361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401803A RID: 98362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401803B RID: 98363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401803C RID: 98364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401803D RID: 98365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401803E RID: 98366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401803F RID: 98367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04018040 RID: 98368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04018041 RID: 98369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04018042 RID: 98370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04018043 RID: 98371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04018044 RID: 98372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04018045 RID: 98373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04018046 RID: 98374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04018047 RID: 98375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04018048 RID: 98376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04018049 RID: 98377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401804A RID: 98378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401804B RID: 98379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401804C RID: 98380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401804D RID: 98381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401804E RID: 98382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401804F RID: 98383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04018050 RID: 98384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04018051 RID: 98385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04018052 RID: 98386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04018053 RID: 98387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04018054 RID: 98388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04018055 RID: 98389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04018056 RID: 98390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04018057 RID: 98391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04018058 RID: 98392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04018059 RID: 98393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0401805A RID: 98394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401805B RID: 98395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401805C RID: 98396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401805D RID: 98397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401805E RID: 98398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401805F RID: 98399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04018060 RID: 98400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04018061 RID: 98401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04018062 RID: 98402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04018063 RID: 98403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04018064 RID: 98404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04018065 RID: 98405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04018066 RID: 98406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04018067 RID: 98407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04018068 RID: 98408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04018069 RID: 98409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0401806A RID: 98410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401806B RID: 98411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401806C RID: 98412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0401806D RID: 98413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0401806E RID: 98414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0401806F RID: 98415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04018070 RID: 98416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04018071 RID: 98417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04018072 RID: 98418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04018073 RID: 98419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04018074 RID: 98420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04018075 RID: 98421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04018076 RID: 98422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04018077 RID: 98423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04018078 RID: 98424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04018079 RID: 98425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0401807A RID: 98426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0401807B RID: 98427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0401807C RID: 98428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0401807D RID: 98429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0401807E RID: 98430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401807F RID: 98431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04018080 RID: 98432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04018081 RID: 98433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;
}
