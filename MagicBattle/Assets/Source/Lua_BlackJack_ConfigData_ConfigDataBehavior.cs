using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001140 RID: 4416
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBehavior : LuaObject
{
	// Token: 0x060165B0 RID: 91568 RVA: 0x005E430C File Offset: 0x005E250C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior o = new ConfigDataBehavior();
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

	// Token: 0x060165B1 RID: 91569 RVA: 0x005E4354 File Offset: 0x005E2554
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			bool b = configDataBehavior.Initialize();
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

	// Token: 0x060165B2 RID: 91570 RVA: 0x005E43A8 File Offset: 0x005E25A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitParamData_s(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 1, typeof(SelectSkill), typeof(string)))
			{
				SelectSkill s;
				LuaObject.checkEnum<SelectSkill>(l, 1, out s);
				string param;
				LuaObject.checkType(l, 2, out param);
				ConfigDataBehavior.ParamData o = ConfigDataBehavior.InitParamData(s, param);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(SelectTarget), typeof(string)))
			{
				SelectTarget t;
				LuaObject.checkEnum<SelectTarget>(l, 1, out t);
				string param2;
				LuaObject.checkType(l, 2, out param2);
				ConfigDataBehavior.ParamData o2 = ConfigDataBehavior.InitParamData(t, param2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 1, typeof(BehaviorCondition), typeof(string)))
			{
				BehaviorCondition c;
				LuaObject.checkEnum<BehaviorCondition>(l, 1, out c);
				string param3;
				LuaObject.checkType(l, 2, out param3);
				ConfigDataBehavior.ParamData o3 = ConfigDataBehavior.InitParamData(c, param3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function InitParamData to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165B3 RID: 91571 RVA: 0x005E4508 File Offset: 0x005E2708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryParseIntArray_s(IntPtr l)
	{
		int result;
		try
		{
			string s;
			LuaObject.checkType(l, 1, out s);
			int[] a;
			bool b = ConfigDataBehavior.TryParseIntArray(s, out a);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, a);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165B4 RID: 91572 RVA: 0x005E4568 File Offset: 0x005E2768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RATCParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.RATCParamData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165B5 RID: 91573 RVA: 0x005E45BC File Offset: 0x005E27BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RATCParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			ConfigDataBehavior.ParamData ratcparamData;
			LuaObject.checkType<ConfigDataBehavior.ParamData>(l, 2, out ratcparamData);
			configDataBehavior.RATCParamData = ratcparamData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165B6 RID: 91574 RVA: 0x005E4614 File Offset: 0x005E2814
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MTParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.MTParamData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165B7 RID: 91575 RVA: 0x005E4668 File Offset: 0x005E2868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MTParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			ConfigDataBehavior.ParamData mtparamData;
			LuaObject.checkType<ConfigDataBehavior.ParamData>(l, 2, out mtparamData);
			configDataBehavior.MTParamData = mtparamData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165B8 RID: 91576 RVA: 0x005E46C0 File Offset: 0x005E28C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StartACParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.StartACParamData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165B9 RID: 91577 RVA: 0x005E4714 File Offset: 0x005E2914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StartACParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			ConfigDataBehavior.ParamData startACParamData;
			LuaObject.checkType<ConfigDataBehavior.ParamData>(l, 2, out startACParamData);
			configDataBehavior.StartACParamData = startACParamData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165BA RID: 91578 RVA: 0x005E476C File Offset: 0x005E296C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StopACParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.StopACParamData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165BB RID: 91579 RVA: 0x005E47C0 File Offset: 0x005E29C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StopACParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			ConfigDataBehavior.ParamData stopACParamData;
			LuaObject.checkType<ConfigDataBehavior.ParamData>(l, 2, out stopACParamData);
			configDataBehavior.StopACParamData = stopACParamData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165BC RID: 91580 RVA: 0x005E4818 File Offset: 0x005E2A18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SATParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.SATParamData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165BD RID: 91581 RVA: 0x005E486C File Offset: 0x005E2A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SATParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			ConfigDataBehavior.ParamData satparamData;
			LuaObject.checkType<ConfigDataBehavior.ParamData>(l, 2, out satparamData);
			configDataBehavior.SATParamData = satparamData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165BE RID: 91582 RVA: 0x005E48C4 File Offset: 0x005E2AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SSParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.SSParamData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165BF RID: 91583 RVA: 0x005E4918 File Offset: 0x005E2B18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SSParamData(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			ConfigDataBehavior.ParamData ssparamData;
			LuaObject.checkType<ConfigDataBehavior.ParamData>(l, 2, out ssparamData);
			configDataBehavior.SSParamData = ssparamData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165C0 RID: 91584 RVA: 0x005E4970 File Offset: 0x005E2B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165C1 RID: 91585 RVA: 0x005E49C4 File Offset: 0x005E2BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataBehavior.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165C2 RID: 91586 RVA: 0x005E4A1C File Offset: 0x005E2C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165C3 RID: 91587 RVA: 0x005E4A70 File Offset: 0x005E2C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataBehavior.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165C4 RID: 91588 RVA: 0x005E4AC8 File Offset: 0x005E2CC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MoveTarget(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBehavior.MoveTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165C5 RID: 91589 RVA: 0x005E4B1C File Offset: 0x005E2D1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MoveTarget(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			SelectTarget moveTarget;
			LuaObject.checkEnum<SelectTarget>(l, 2, out moveTarget);
			configDataBehavior.MoveTarget = moveTarget;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165C6 RID: 91590 RVA: 0x005E4B74 File Offset: 0x005E2D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MTParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.MTParam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165C7 RID: 91591 RVA: 0x005E4BC8 File Offset: 0x005E2DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MTParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			string mtparam;
			LuaObject.checkType(l, 2, out mtparam);
			configDataBehavior.MTParam = mtparam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165C8 RID: 91592 RVA: 0x005E4C20 File Offset: 0x005E2E20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StartAttackCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBehavior.StartAttackCondition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165C9 RID: 91593 RVA: 0x005E4C74 File Offset: 0x005E2E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StartAttackCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			BehaviorCondition startAttackCondition;
			LuaObject.checkEnum<BehaviorCondition>(l, 2, out startAttackCondition);
			configDataBehavior.StartAttackCondition = startAttackCondition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165CA RID: 91594 RVA: 0x005E4CCC File Offset: 0x005E2ECC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StartACParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.StartACParam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165CB RID: 91595 RVA: 0x005E4D20 File Offset: 0x005E2F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StartACParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			string startACParam;
			LuaObject.checkType(l, 2, out startACParam);
			configDataBehavior.StartACParam = startACParam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165CC RID: 91596 RVA: 0x005E4D78 File Offset: 0x005E2F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelectAttackTarget(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBehavior.SelectAttackTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165CD RID: 91597 RVA: 0x005E4DCC File Offset: 0x005E2FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SelectAttackTarget(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			SelectTarget selectAttackTarget;
			LuaObject.checkEnum<SelectTarget>(l, 2, out selectAttackTarget);
			configDataBehavior.SelectAttackTarget = selectAttackTarget;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165CE RID: 91598 RVA: 0x005E4E24 File Offset: 0x005E3024
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SATParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.SATParam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165CF RID: 91599 RVA: 0x005E4E78 File Offset: 0x005E3078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SATParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			string satparam;
			LuaObject.checkType(l, 2, out satparam);
			configDataBehavior.SATParam = satparam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165D0 RID: 91600 RVA: 0x005E4ED0 File Offset: 0x005E30D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReselectAttackTargetCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBehavior.ReselectAttackTargetCondition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165D1 RID: 91601 RVA: 0x005E4F24 File Offset: 0x005E3124
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ReselectAttackTargetCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			BehaviorCondition reselectAttackTargetCondition;
			LuaObject.checkEnum<BehaviorCondition>(l, 2, out reselectAttackTargetCondition);
			configDataBehavior.ReselectAttackTargetCondition = reselectAttackTargetCondition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165D2 RID: 91602 RVA: 0x005E4F7C File Offset: 0x005E317C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RATCParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.RATCParam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165D3 RID: 91603 RVA: 0x005E4FD0 File Offset: 0x005E31D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RATCParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			string ratcparam;
			LuaObject.checkType(l, 2, out ratcparam);
			configDataBehavior.RATCParam = ratcparam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165D4 RID: 91604 RVA: 0x005E5028 File Offset: 0x005E3228
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SelectSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBehavior.SelectSkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165D5 RID: 91605 RVA: 0x005E507C File Offset: 0x005E327C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SelectSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			SelectSkill selectSkill;
			LuaObject.checkEnum<SelectSkill>(l, 2, out selectSkill);
			configDataBehavior.SelectSkill = selectSkill;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165D6 RID: 91606 RVA: 0x005E50D4 File Offset: 0x005E32D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SSParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.SSParam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165D7 RID: 91607 RVA: 0x005E5128 File Offset: 0x005E3328
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SSParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			string ssparam;
			LuaObject.checkType(l, 2, out ssparam);
			configDataBehavior.SSParam = ssparam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165D8 RID: 91608 RVA: 0x005E5180 File Offset: 0x005E3380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StopAttackCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBehavior.StopAttackCondition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165D9 RID: 91609 RVA: 0x005E51D4 File Offset: 0x005E33D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StopAttackCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			BehaviorCondition stopAttackCondition;
			LuaObject.checkEnum<BehaviorCondition>(l, 2, out stopAttackCondition);
			configDataBehavior.StopAttackCondition = stopAttackCondition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165DA RID: 91610 RVA: 0x005E522C File Offset: 0x005E342C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StopACParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.StopACParam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165DB RID: 91611 RVA: 0x005E5280 File Offset: 0x005E3480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StopACParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			string stopACParam;
			LuaObject.checkType(l, 2, out stopACParam);
			configDataBehavior.StopACParam = stopACParam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165DC RID: 91612 RVA: 0x005E52D8 File Offset: 0x005E34D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BehaviorChangeRules(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBehavior configDataBehavior = (ConfigDataBehavior)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBehavior.BehaviorChangeRules);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060165DD RID: 91613 RVA: 0x005E532C File Offset: 0x005E352C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBehavior");
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache0);
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.InitParamData_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1);
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.TryParseIntArray_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2);
		string name = "RATCParamData";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_RATCParamData);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache3;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_RATCParamData);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache4, true);
		string name2 = "MTParamData";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_MTParamData);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache5;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_MTParamData);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache6, true);
		string name3 = "StartACParamData";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_StartACParamData);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache7;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_StartACParamData);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache8, true);
		string name4 = "StopACParamData";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_StopACParamData);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache9;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_StopACParamData);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheA, true);
		string name5 = "SATParamData";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_SATParamData);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheB;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_SATParamData);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheC, true);
		string name6 = "SSParamData";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_SSParamData);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_SSParamData);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheE, true);
		string name7 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_ID);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_ID);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache10, true);
		string name8 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_Desc);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache11;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_Desc);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache12, true);
		string name9 = "MoveTarget";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_MoveTarget);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_MoveTarget);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache14, true);
		string name10 = "MTParam";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_MTParam);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_MTParam);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache16, true);
		string name11 = "StartAttackCondition";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_StartAttackCondition);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_StartAttackCondition);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache18, true);
		string name12 = "StartACParam";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_StartACParam);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_StartACParam);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1A, true);
		string name13 = "SelectAttackTarget";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_SelectAttackTarget);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1B;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_SelectAttackTarget);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1C, true);
		string name14 = "SATParam";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_SATParam);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1D;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_SATParam);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1E, true);
		string name15 = "ReselectAttackTargetCondition";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_ReselectAttackTargetCondition);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache1F;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_ReselectAttackTargetCondition);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache20, true);
		string name16 = "RATCParam";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_RATCParam);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache21;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_RATCParam);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache22, true);
		string name17 = "SelectSkill";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_SelectSkill);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache23;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_SelectSkill);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache24, true);
		string name18 = "SSParam";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_SSParam);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache25;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_SSParam);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache26, true);
		string name19 = "StopAttackCondition";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_StopAttackCondition);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_StopAttackCondition);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache28, true);
		string name20 = "StopACParam";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_StopACParam);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.set_StopACParam);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2A, true);
		string name21 = "BehaviorChangeRules";
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.get_BehaviorChangeRules);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2B, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBehavior.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBehavior.<>f__mg$cache2C, typeof(ConfigDataBehavior));
	}

	// Token: 0x0400CD12 RID: 52498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CD13 RID: 52499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CD14 RID: 52500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CD15 RID: 52501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CD16 RID: 52502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CD17 RID: 52503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CD18 RID: 52504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CD19 RID: 52505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CD1A RID: 52506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CD1B RID: 52507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CD1C RID: 52508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CD1D RID: 52509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CD1E RID: 52510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CD1F RID: 52511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CD20 RID: 52512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CD21 RID: 52513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CD22 RID: 52514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CD23 RID: 52515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CD24 RID: 52516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CD25 RID: 52517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CD26 RID: 52518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CD27 RID: 52519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CD28 RID: 52520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CD29 RID: 52521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CD2A RID: 52522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CD2B RID: 52523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CD2C RID: 52524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CD2D RID: 52525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CD2E RID: 52526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CD2F RID: 52527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CD30 RID: 52528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CD31 RID: 52529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CD32 RID: 52530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CD33 RID: 52531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CD34 RID: 52532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CD35 RID: 52533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CD36 RID: 52534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CD37 RID: 52535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CD38 RID: 52536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CD39 RID: 52537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CD3A RID: 52538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400CD3B RID: 52539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400CD3C RID: 52540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400CD3D RID: 52541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400CD3E RID: 52542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;
}
