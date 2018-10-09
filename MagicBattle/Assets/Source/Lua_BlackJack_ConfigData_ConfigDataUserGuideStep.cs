using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001176 RID: 4470
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataUserGuideStep : LuaObject
{
	// Token: 0x06016EF7 RID: 93943 RVA: 0x00627D68 File Offset: 0x00625F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep o = new ConfigDataUserGuideStep();
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

	// Token: 0x06016EF8 RID: 93944 RVA: 0x00627DB0 File Offset: 0x00625FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextUserGuideInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.m_nextUserGuideInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EF9 RID: 93945 RVA: 0x00627E04 File Offset: 0x00626004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextUserGuideInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			ConfigDataUserGuideStep nextUserGuideInfo;
			LuaObject.checkType<ConfigDataUserGuideStep>(l, 2, out nextUserGuideInfo);
			configDataUserGuideStep.m_nextUserGuideInfo = nextUserGuideInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EFA RID: 93946 RVA: 0x00627E5C File Offset: 0x0062605C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.m_battleDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EFB RID: 93947 RVA: 0x00627EB0 File Offset: 0x006260B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo battleDialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out battleDialogInfo);
			configDataUserGuideStep.m_battleDialogInfo = battleDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EFC RID: 93948 RVA: 0x00627F08 File Offset: 0x00626108
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_userGuideDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.m_userGuideDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EFD RID: 93949 RVA: 0x00627F5C File Offset: 0x0062615C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			ConfigDataUserGuideDialogInfo userGuideDialogInfo;
			LuaObject.checkType<ConfigDataUserGuideDialogInfo>(l, 2, out userGuideDialogInfo);
			configDataUserGuideStep.m_userGuideDialogInfo = userGuideDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EFE RID: 93950 RVA: 0x00627FB4 File Offset: 0x006261B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EFF RID: 93951 RVA: 0x00628008 File Offset: 0x00626208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataUserGuideStep.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F00 RID: 93952 RVA: 0x00628060 File Offset: 0x00626260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F01 RID: 93953 RVA: 0x006280B4 File Offset: 0x006262B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataUserGuideStep.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F02 RID: 93954 RVA: 0x0062810C File Offset: 0x0062630C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextUserGuide_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.NextUserGuide_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F03 RID: 93955 RVA: 0x00628160 File Offset: 0x00626360
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NextUserGuide_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			int nextUserGuide_ID;
			LuaObject.checkType(l, 2, out nextUserGuide_ID);
			configDataUserGuideStep.NextUserGuide_ID = nextUserGuide_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F04 RID: 93956 RVA: 0x006281B8 File Offset: 0x006263B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextTrigger(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.NextTrigger);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F05 RID: 93957 RVA: 0x0062820C File Offset: 0x0062640C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NTParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.NTParam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F06 RID: 93958 RVA: 0x00628260 File Offset: 0x00626460
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UserGuideDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.UserGuideDialog_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F07 RID: 93959 RVA: 0x006282B4 File Offset: 0x006264B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserGuideDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			int userGuideDialog_ID;
			LuaObject.checkType(l, 2, out userGuideDialog_ID);
			configDataUserGuideStep.UserGuideDialog_ID = userGuideDialog_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F08 RID: 93960 RVA: 0x0062830C File Offset: 0x0062650C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.BattleDialog_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F09 RID: 93961 RVA: 0x00628360 File Offset: 0x00626560
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleDialog_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			int battleDialog_ID;
			LuaObject.checkType(l, 2, out battleDialog_ID);
			configDataUserGuideStep.BattleDialog_ID = battleDialog_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F0A RID: 93962 RVA: 0x006283B8 File Offset: 0x006265B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleMapX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.BattleMapX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F0B RID: 93963 RVA: 0x0062840C File Offset: 0x0062660C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleMapX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			int battleMapX;
			LuaObject.checkType(l, 2, out battleMapX);
			configDataUserGuideStep.BattleMapX = battleMapX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F0C RID: 93964 RVA: 0x00628464 File Offset: 0x00626664
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleMapY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.BattleMapY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F0D RID: 93965 RVA: 0x006284B8 File Offset: 0x006266B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleMapY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			int battleMapY;
			LuaObject.checkType(l, 2, out battleMapY);
			configDataUserGuideStep.BattleMapY = battleMapY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F0E RID: 93966 RVA: 0x00628510 File Offset: 0x00626710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ClickObjectPath(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.ClickObjectPath);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F0F RID: 93967 RVA: 0x00628564 File Offset: 0x00626764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ClickObjectPath(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			string clickObjectPath;
			LuaObject.checkType(l, 2, out clickObjectPath);
			configDataUserGuideStep.ClickObjectPath = clickObjectPath;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F10 RID: 93968 RVA: 0x006285BC File Offset: 0x006267BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UserGuideTips(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.UserGuideTips);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F11 RID: 93969 RVA: 0x00628610 File Offset: 0x00626810
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserGuideTips(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			string userGuideTips;
			LuaObject.checkType(l, 2, out userGuideTips);
			configDataUserGuideStep.UserGuideTips = userGuideTips;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F12 RID: 93970 RVA: 0x00628668 File Offset: 0x00626868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FunctionOpenText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.FunctionOpenText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F13 RID: 93971 RVA: 0x006286BC File Offset: 0x006268BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FunctionOpenText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			string functionOpenText;
			LuaObject.checkType(l, 2, out functionOpenText);
			configDataUserGuideStep.FunctionOpenText = functionOpenText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F14 RID: 93972 RVA: 0x00628714 File Offset: 0x00626914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FunctionOpenPrefab(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.FunctionOpenPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F15 RID: 93973 RVA: 0x00628768 File Offset: 0x00626968
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FunctionOpenPrefab(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			string functionOpenPrefab;
			LuaObject.checkType(l, 2, out functionOpenPrefab);
			configDataUserGuideStep.FunctionOpenPrefab = functionOpenPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F16 RID: 93974 RVA: 0x006287C0 File Offset: 0x006269C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PagesPrefab(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.PagesPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F17 RID: 93975 RVA: 0x00628814 File Offset: 0x00626A14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PagesPrefab(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			string pagesPrefab;
			LuaObject.checkType(l, 2, out pagesPrefab);
			configDataUserGuideStep.PagesPrefab = pagesPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F18 RID: 93976 RVA: 0x0062886C File Offset: 0x00626A6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StartAction1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataUserGuideStep.StartAction1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F19 RID: 93977 RVA: 0x006288C0 File Offset: 0x00626AC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StartAction1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			UserGuideAction startAction;
			LuaObject.checkEnum<UserGuideAction>(l, 2, out startAction);
			configDataUserGuideStep.StartAction1 = startAction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F1A RID: 93978 RVA: 0x00628918 File Offset: 0x00626B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SAParam1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.SAParam1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F1B RID: 93979 RVA: 0x0062896C File Offset: 0x00626B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SAParam1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			string saparam;
			LuaObject.checkType(l, 2, out saparam);
			configDataUserGuideStep.SAParam1 = saparam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F1C RID: 93980 RVA: 0x006289C4 File Offset: 0x00626BC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StartAction2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataUserGuideStep.StartAction2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F1D RID: 93981 RVA: 0x00628A18 File Offset: 0x00626C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StartAction2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			UserGuideAction startAction;
			LuaObject.checkEnum<UserGuideAction>(l, 2, out startAction);
			configDataUserGuideStep.StartAction2 = startAction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F1E RID: 93982 RVA: 0x00628A70 File Offset: 0x00626C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SAParam2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.SAParam2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F1F RID: 93983 RVA: 0x00628AC4 File Offset: 0x00626CC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SAParam2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			string saparam;
			LuaObject.checkType(l, 2, out saparam);
			configDataUserGuideStep.SAParam2 = saparam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F20 RID: 93984 RVA: 0x00628B1C File Offset: 0x00626D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StartAction3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataUserGuideStep.StartAction3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F21 RID: 93985 RVA: 0x00628B70 File Offset: 0x00626D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StartAction3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			UserGuideAction startAction;
			LuaObject.checkEnum<UserGuideAction>(l, 2, out startAction);
			configDataUserGuideStep.StartAction3 = startAction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F22 RID: 93986 RVA: 0x00628BC8 File Offset: 0x00626DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SAParam3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUserGuideStep.SAParam3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F23 RID: 93987 RVA: 0x00628C1C File Offset: 0x00626E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SAParam3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUserGuideStep configDataUserGuideStep = (ConfigDataUserGuideStep)LuaObject.checkSelf(l);
			string saparam;
			LuaObject.checkType(l, 2, out saparam);
			configDataUserGuideStep.SAParam3 = saparam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016F24 RID: 93988 RVA: 0x00628C74 File Offset: 0x00626E74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataUserGuideStep");
		string name = "m_nextUserGuideInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_m_nextUserGuideInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_m_nextUserGuideInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1, true);
		string name2 = "m_battleDialogInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_m_battleDialogInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_m_battleDialogInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache3, true);
		string name3 = "m_userGuideDialogInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_m_userGuideDialogInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_m_userGuideDialogInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache9, true);
		string name6 = "NextUserGuide_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_NextUserGuide_ID);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_NextUserGuide_ID);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheB, true);
		string name7 = "NextTrigger";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_NextTrigger);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheC, null, true);
		string name8 = "NTParam";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_NTParam);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheD, null, true);
		string name9 = "UserGuideDialog_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_UserGuideDialog_ID);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_UserGuideDialog_ID);
		}
		LuaObject.addMember(l, name9, get7, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cacheF, true);
		string name10 = "BattleDialog_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_BattleDialog_ID);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_BattleDialog_ID);
		}
		LuaObject.addMember(l, name10, get8, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache11, true);
		string name11 = "BattleMapX";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_BattleMapX);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_BattleMapX);
		}
		LuaObject.addMember(l, name11, get9, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache13, true);
		string name12 = "BattleMapY";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_BattleMapY);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_BattleMapY);
		}
		LuaObject.addMember(l, name12, get10, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache15, true);
		string name13 = "ClickObjectPath";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_ClickObjectPath);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_ClickObjectPath);
		}
		LuaObject.addMember(l, name13, get11, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache17, true);
		string name14 = "UserGuideTips";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_UserGuideTips);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_UserGuideTips);
		}
		LuaObject.addMember(l, name14, get12, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache19, true);
		string name15 = "FunctionOpenText";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_FunctionOpenText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_FunctionOpenText);
		}
		LuaObject.addMember(l, name15, get13, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1B, true);
		string name16 = "FunctionOpenPrefab";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_FunctionOpenPrefab);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_FunctionOpenPrefab);
		}
		LuaObject.addMember(l, name16, get14, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1D, true);
		string name17 = "PagesPrefab";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_PagesPrefab);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_PagesPrefab);
		}
		LuaObject.addMember(l, name17, get15, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache1F, true);
		string name18 = "StartAction1";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_StartAction1);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_StartAction1);
		}
		LuaObject.addMember(l, name18, get16, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache21, true);
		string name19 = "SAParam1";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_SAParam1);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_SAParam1);
		}
		LuaObject.addMember(l, name19, get17, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache23, true);
		string name20 = "StartAction2";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_StartAction2);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_StartAction2);
		}
		LuaObject.addMember(l, name20, get18, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache25, true);
		string name21 = "SAParam2";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_SAParam2);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_SAParam2);
		}
		LuaObject.addMember(l, name21, get19, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache27, true);
		string name22 = "StartAction3";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_StartAction3);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_StartAction3);
		}
		LuaObject.addMember(l, name22, get20, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache29, true);
		string name23 = "SAParam3";
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.get_SAParam3);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.set_SAParam3);
		}
		LuaObject.addMember(l, name23, get21, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2B, true);
		if (Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataUserGuideStep.<>f__mg$cache2C, typeof(ConfigDataUserGuideStep));
	}

	// Token: 0x0400D5ED RID: 54765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D5EE RID: 54766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D5EF RID: 54767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D5F0 RID: 54768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D5F1 RID: 54769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D5F2 RID: 54770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D5F3 RID: 54771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D5F4 RID: 54772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D5F5 RID: 54773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D5F6 RID: 54774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D5F7 RID: 54775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D5F8 RID: 54776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D5F9 RID: 54777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D5FA RID: 54778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D5FB RID: 54779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D5FC RID: 54780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D5FD RID: 54781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D5FE RID: 54782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D5FF RID: 54783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D600 RID: 54784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D601 RID: 54785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D602 RID: 54786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D603 RID: 54787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D604 RID: 54788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D605 RID: 54789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D606 RID: 54790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D607 RID: 54791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D608 RID: 54792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D609 RID: 54793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D60A RID: 54794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D60B RID: 54795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D60C RID: 54796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D60D RID: 54797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D60E RID: 54798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D60F RID: 54799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D610 RID: 54800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D611 RID: 54801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D612 RID: 54802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D613 RID: 54803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D614 RID: 54804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D615 RID: 54805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D616 RID: 54806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D617 RID: 54807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D618 RID: 54808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D619 RID: 54809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;
}
