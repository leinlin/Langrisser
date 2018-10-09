using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001143 RID: 4419
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBuffInfo : LuaObject
{
	// Token: 0x060165FC RID: 91644 RVA: 0x005E658C File Offset: 0x005E478C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo o = new ConfigDataBuffInfo();
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

	// Token: 0x060165FD RID: 91645 RVA: 0x005E65D4 File Offset: 0x005E47D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsAuraBuff(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			bool b = configDataBuffInfo.IsAuraBuff();
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

	// Token: 0x060165FE RID: 91646 RVA: 0x005E6628 File Offset: 0x005E4828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInfiniteTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			bool b = configDataBuffInfo.IsInfiniteTime();
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

	// Token: 0x060165FF RID: 91647 RVA: 0x005E667C File Offset: 0x005E487C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cdBuffInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.m_cdBuffInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016600 RID: 91648 RVA: 0x005E66D0 File Offset: 0x005E48D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cdBuffInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			ConfigDataBuffInfo cdBuffInfo;
			LuaObject.checkType<ConfigDataBuffInfo>(l, 2, out cdBuffInfo);
			configDataBuffInfo.m_cdBuffInfo = cdBuffInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016601 RID: 91649 RVA: 0x005E6728 File Offset: 0x005E4928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016602 RID: 91650 RVA: 0x005E677C File Offset: 0x005E497C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataBuffInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016603 RID: 91651 RVA: 0x005E67D4 File Offset: 0x005E49D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016604 RID: 91652 RVA: 0x005E6828 File Offset: 0x005E4A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataBuffInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016605 RID: 91653 RVA: 0x005E6880 File Offset: 0x005E4A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016606 RID: 91654 RVA: 0x005E68D4 File Offset: 0x005E4AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataBuffInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016607 RID: 91655 RVA: 0x005E692C File Offset: 0x005E4B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsDebuff(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.IsDebuff);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016608 RID: 91656 RVA: 0x005E6980 File Offset: 0x005E4B80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsDebuff(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			bool isDebuff;
			LuaObject.checkType(l, 2, out isDebuff);
			configDataBuffInfo.IsDebuff = isDebuff;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016609 RID: 91657 RVA: 0x005E69D8 File Offset: 0x005E4BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsEnhance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.IsEnhance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601660A RID: 91658 RVA: 0x005E6A2C File Offset: 0x005E4C2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsEnhance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			bool isEnhance;
			LuaObject.checkType(l, 2, out isEnhance);
			configDataBuffInfo.IsEnhance = isEnhance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601660B RID: 91659 RVA: 0x005E6A84 File Offset: 0x005E4C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Time(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601660C RID: 91660 RVA: 0x005E6AD8 File Offset: 0x005E4CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Time(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int time;
			LuaObject.checkType(l, 2, out time);
			configDataBuffInfo.Time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601660D RID: 91661 RVA: 0x005E6B30 File Offset: 0x005E4D30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Cond_HP_Target(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Cond_HP_Target);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601660E RID: 91662 RVA: 0x005E6B84 File Offset: 0x005E4D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Cond_HP_Target(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int cond_HP_Target;
			LuaObject.checkType(l, 2, out cond_HP_Target);
			configDataBuffInfo.Cond_HP_Target = cond_HP_Target;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601660F RID: 91663 RVA: 0x005E6BDC File Offset: 0x005E4DDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Cond_HP_Operator(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Cond_HP_Operator);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016610 RID: 91664 RVA: 0x005E6C30 File Offset: 0x005E4E30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Cond_HP_Operator(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int cond_HP_Operator;
			LuaObject.checkType(l, 2, out cond_HP_Operator);
			configDataBuffInfo.Cond_HP_Operator = cond_HP_Operator;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016611 RID: 91665 RVA: 0x005E6C88 File Offset: 0x005E4E88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Cond_HP_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Cond_HP_Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016612 RID: 91666 RVA: 0x005E6CDC File Offset: 0x005E4EDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Cond_HP_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int cond_HP_Value;
			LuaObject.checkType(l, 2, out cond_HP_Value);
			configDataBuffInfo.Cond_HP_Value = cond_HP_Value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016613 RID: 91667 RVA: 0x005E6D34 File Offset: 0x005E4F34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConditionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBuffInfo.ConditionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016614 RID: 91668 RVA: 0x005E6D88 File Offset: 0x005E4F88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ConditionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			BuffConditionType conditionType;
			LuaObject.checkEnum<BuffConditionType>(l, 2, out conditionType);
			configDataBuffInfo.ConditionType = conditionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016615 RID: 91669 RVA: 0x005E6DE0 File Offset: 0x005E4FE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConditionParam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.ConditionParam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016616 RID: 91670 RVA: 0x005E6E34 File Offset: 0x005E5034
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BuffType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBuffInfo.BuffType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016617 RID: 91671 RVA: 0x005E6E88 File Offset: 0x005E5088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BuffType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			BuffType buffType;
			LuaObject.checkEnum<BuffType>(l, 2, out buffType);
			configDataBuffInfo.BuffType = buffType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016618 RID: 91672 RVA: 0x005E6EE0 File Offset: 0x005E50E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BuffTypeParam1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.BuffTypeParam1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016619 RID: 91673 RVA: 0x005E6F34 File Offset: 0x005E5134
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BuffTypeParam1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int buffTypeParam;
			LuaObject.checkType(l, 2, out buffTypeParam);
			configDataBuffInfo.BuffTypeParam1 = buffTypeParam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601661A RID: 91674 RVA: 0x005E6F8C File Offset: 0x005E518C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BuffTypeParam2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.BuffTypeParam2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601661B RID: 91675 RVA: 0x005E6FE0 File Offset: 0x005E51E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BuffTypeParam2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int buffTypeParam;
			LuaObject.checkType(l, 2, out buffTypeParam);
			configDataBuffInfo.BuffTypeParam2 = buffTypeParam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601661C RID: 91676 RVA: 0x005E7038 File Offset: 0x005E5238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BuffTypeParam3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.BuffTypeParam3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601661D RID: 91677 RVA: 0x005E708C File Offset: 0x005E528C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BuffTypeParam3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int buffTypeParam;
			LuaObject.checkType(l, 2, out buffTypeParam);
			configDataBuffInfo.BuffTypeParam3 = buffTypeParam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601661E RID: 91678 RVA: 0x005E70E4 File Offset: 0x005E52E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BuffTypeParam4(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.BuffTypeParam4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601661F RID: 91679 RVA: 0x005E7138 File Offset: 0x005E5338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BuffTypeParam5(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBuffInfo.BuffTypeParam5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016620 RID: 91680 RVA: 0x005E718C File Offset: 0x005E538C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BuffTypeParam5(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			PropertyModifyType buffTypeParam;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out buffTypeParam);
			configDataBuffInfo.BuffTypeParam5 = buffTypeParam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016621 RID: 91681 RVA: 0x005E71E4 File Offset: 0x005E53E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BuffTypeParam6(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.BuffTypeParam6);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016622 RID: 91682 RVA: 0x005E7238 File Offset: 0x005E5438
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SelfNoExtraTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.SelfNoExtraTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016623 RID: 91683 RVA: 0x005E728C File Offset: 0x005E548C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SelfNoExtraTime(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			bool selfNoExtraTime;
			LuaObject.checkType(l, 2, out selfNoExtraTime);
			configDataBuffInfo.SelfNoExtraTime = selfNoExtraTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016624 RID: 91684 RVA: 0x005E72E4 File Offset: 0x005E54E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.SubType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016625 RID: 91685 RVA: 0x005E7338 File Offset: 0x005E5538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int subType;
			LuaObject.checkType(l, 2, out subType);
			configDataBuffInfo.SubType = subType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016626 RID: 91686 RVA: 0x005E7390 File Offset: 0x005E5590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReplaceRule(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.ReplaceRule);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016627 RID: 91687 RVA: 0x005E73E4 File Offset: 0x005E55E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ReplaceRule(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int replaceRule;
			LuaObject.checkType(l, 2, out replaceRule);
			configDataBuffInfo.ReplaceRule = replaceRule;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016628 RID: 91688 RVA: 0x005E743C File Offset: 0x005E563C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReplacePriority(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.ReplacePriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016629 RID: 91689 RVA: 0x005E7490 File Offset: 0x005E5690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ReplacePriority(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int replacePriority;
			LuaObject.checkType(l, 2, out replacePriority);
			configDataBuffInfo.ReplacePriority = replacePriority;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601662A RID: 91690 RVA: 0x005E74E8 File Offset: 0x005E56E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FightTags(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.FightTags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601662B RID: 91691 RVA: 0x005E753C File Offset: 0x005E573C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property1_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBuffInfo.Property1_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601662C RID: 91692 RVA: 0x005E7590 File Offset: 0x005E5790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Property1_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			PropertyModifyType property1_ID;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out property1_ID);
			configDataBuffInfo.Property1_ID = property1_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601662D RID: 91693 RVA: 0x005E75E8 File Offset: 0x005E57E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Property1_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Property1_Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601662E RID: 91694 RVA: 0x005E763C File Offset: 0x005E583C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property1_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int property1_Value;
			LuaObject.checkType(l, 2, out property1_Value);
			configDataBuffInfo.Property1_Value = property1_Value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601662F RID: 91695 RVA: 0x005E7694 File Offset: 0x005E5894
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Property2_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBuffInfo.Property2_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016630 RID: 91696 RVA: 0x005E76E8 File Offset: 0x005E58E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property2_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			PropertyModifyType property2_ID;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out property2_ID);
			configDataBuffInfo.Property2_ID = property2_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016631 RID: 91697 RVA: 0x005E7740 File Offset: 0x005E5940
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Property2_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Property2_Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016632 RID: 91698 RVA: 0x005E7794 File Offset: 0x005E5994
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Property2_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int property2_Value;
			LuaObject.checkType(l, 2, out property2_Value);
			configDataBuffInfo.Property2_Value = property2_Value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016633 RID: 91699 RVA: 0x005E77EC File Offset: 0x005E59EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Property3_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBuffInfo.Property3_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016634 RID: 91700 RVA: 0x005E7840 File Offset: 0x005E5A40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Property3_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			PropertyModifyType property3_ID;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out property3_ID);
			configDataBuffInfo.Property3_ID = property3_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016635 RID: 91701 RVA: 0x005E7898 File Offset: 0x005E5A98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Property3_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Property3_Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016636 RID: 91702 RVA: 0x005E78EC File Offset: 0x005E5AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property3_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int property3_Value;
			LuaObject.checkType(l, 2, out property3_Value);
			configDataBuffInfo.Property3_Value = property3_Value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016637 RID: 91703 RVA: 0x005E7944 File Offset: 0x005E5B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property4_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBuffInfo.Property4_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016638 RID: 91704 RVA: 0x005E7998 File Offset: 0x005E5B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property4_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			PropertyModifyType property4_ID;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out property4_ID);
			configDataBuffInfo.Property4_ID = property4_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016639 RID: 91705 RVA: 0x005E79F0 File Offset: 0x005E5BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property4_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Property4_Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601663A RID: 91706 RVA: 0x005E7A44 File Offset: 0x005E5C44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Property4_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int property4_Value;
			LuaObject.checkType(l, 2, out property4_Value);
			configDataBuffInfo.Property4_Value = property4_Value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601663B RID: 91707 RVA: 0x005E7A9C File Offset: 0x005E5C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CDBuff_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.CDBuff_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601663C RID: 91708 RVA: 0x005E7AF0 File Offset: 0x005E5CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CDBuff_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			int cdbuff_ID;
			LuaObject.checkType(l, 2, out cdbuff_ID);
			configDataBuffInfo.CDBuff_ID = cdbuff_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601663D RID: 91709 RVA: 0x005E7B48 File Offset: 0x005E5D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Effect_Attach(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Effect_Attach);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601663E RID: 91710 RVA: 0x005E7B9C File Offset: 0x005E5D9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Effect_Attach(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			string effect_Attach;
			LuaObject.checkType(l, 2, out effect_Attach);
			configDataBuffInfo.Effect_Attach = effect_Attach;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601663F RID: 91711 RVA: 0x005E7BF4 File Offset: 0x005E5DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Effect_Process(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Effect_Process);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016640 RID: 91712 RVA: 0x005E7C48 File Offset: 0x005E5E48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Effect_Process(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			string effect_Process;
			LuaObject.checkType(l, 2, out effect_Process);
			configDataBuffInfo.Effect_Process = effect_Process;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016641 RID: 91713 RVA: 0x005E7CA0 File Offset: 0x005E5EA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Effect_Acting(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Effect_Acting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016642 RID: 91714 RVA: 0x005E7CF4 File Offset: 0x005E5EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Effect_Acting(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			string effect_Acting;
			LuaObject.checkType(l, 2, out effect_Acting);
			configDataBuffInfo.Effect_Acting = effect_Acting;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016643 RID: 91715 RVA: 0x005E7D4C File Offset: 0x005E5F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Effect_ActingTarget(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Effect_ActingTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016644 RID: 91716 RVA: 0x005E7DA0 File Offset: 0x005E5FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Effect_ActingTarget(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			string effect_ActingTarget;
			LuaObject.checkType(l, 2, out effect_ActingTarget);
			configDataBuffInfo.Effect_ActingTarget = effect_ActingTarget;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016645 RID: 91717 RVA: 0x005E7DF8 File Offset: 0x005E5FF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016646 RID: 91718 RVA: 0x005E7E4C File Offset: 0x005E604C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataBuffInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016647 RID: 91719 RVA: 0x005E7EA4 File Offset: 0x005E60A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IconDisplay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBuffInfo.IconDisplay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016648 RID: 91720 RVA: 0x005E7EF8 File Offset: 0x005E60F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IconDisplay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBuffInfo configDataBuffInfo = (ConfigDataBuffInfo)LuaObject.checkSelf(l);
			bool iconDisplay;
			LuaObject.checkType(l, 2, out iconDisplay);
			configDataBuffInfo.IconDisplay = iconDisplay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016649 RID: 91721 RVA: 0x005E7F50 File Offset: 0x005E6150
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBuffInfo");
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.IsAuraBuff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.IsInfiniteTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1);
		string name = "m_cdBuffInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_m_cdBuffInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_m_cdBuffInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache5, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache7, true);
		string name4 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Desc);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Desc);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache9, true);
		string name5 = "IsDebuff";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_IsDebuff);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_IsDebuff);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheB, true);
		string name6 = "IsEnhance";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_IsEnhance);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_IsEnhance);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheD, true);
		string name7 = "Time";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Time);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Time);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cacheF, true);
		string name8 = "Cond_HP_Target";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Cond_HP_Target);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Cond_HP_Target);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache11, true);
		string name9 = "Cond_HP_Operator";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Cond_HP_Operator);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Cond_HP_Operator);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache13, true);
		string name10 = "Cond_HP_Value";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Cond_HP_Value);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Cond_HP_Value);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache15, true);
		string name11 = "ConditionType";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_ConditionType);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_ConditionType);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache17, true);
		string name12 = "ConditionParam";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_ConditionParam);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache18, null, true);
		string name13 = "BuffType";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_BuffType);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_BuffType);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1A, true);
		string name14 = "BuffTypeParam1";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_BuffTypeParam1);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1B;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_BuffTypeParam1);
		}
		LuaObject.addMember(l, name14, get13, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1C, true);
		string name15 = "BuffTypeParam2";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_BuffTypeParam2);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1D;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_BuffTypeParam2);
		}
		LuaObject.addMember(l, name15, get14, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1E, true);
		string name16 = "BuffTypeParam3";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_BuffTypeParam3);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache1F;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_BuffTypeParam3);
		}
		LuaObject.addMember(l, name16, get15, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache20, true);
		string name17 = "BuffTypeParam4";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_BuffTypeParam4);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache21, null, true);
		string name18 = "BuffTypeParam5";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_BuffTypeParam5);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_BuffTypeParam5);
		}
		LuaObject.addMember(l, name18, get16, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache23, true);
		string name19 = "BuffTypeParam6";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_BuffTypeParam6);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache24, null, true);
		string name20 = "SelfNoExtraTime";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_SelfNoExtraTime);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache25;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_SelfNoExtraTime);
		}
		LuaObject.addMember(l, name20, get17, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache26, true);
		string name21 = "SubType";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_SubType);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_SubType);
		}
		LuaObject.addMember(l, name21, get18, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache28, true);
		string name22 = "ReplaceRule";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_ReplaceRule);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_ReplaceRule);
		}
		LuaObject.addMember(l, name22, get19, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2A, true);
		string name23 = "ReplacePriority";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_ReplacePriority);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_ReplacePriority);
		}
		LuaObject.addMember(l, name23, get20, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2C, true);
		string name24 = "FightTags";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_FightTags);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2D, null, true);
		string name25 = "Property1_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Property1_ID);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2E;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Property1_ID);
		}
		LuaObject.addMember(l, name25, get21, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache2F, true);
		string name26 = "Property1_Value";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Property1_Value);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache30;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Property1_Value);
		}
		LuaObject.addMember(l, name26, get22, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache31, true);
		string name27 = "Property2_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Property2_ID);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache32;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Property2_ID);
		}
		LuaObject.addMember(l, name27, get23, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache33, true);
		string name28 = "Property2_Value";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Property2_Value);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache34;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Property2_Value);
		}
		LuaObject.addMember(l, name28, get24, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache35, true);
		string name29 = "Property3_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Property3_ID);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache36;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Property3_ID);
		}
		LuaObject.addMember(l, name29, get25, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache37, true);
		string name30 = "Property3_Value";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Property3_Value);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache38;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Property3_Value);
		}
		LuaObject.addMember(l, name30, get26, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache39, true);
		string name31 = "Property4_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Property4_ID);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3A;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Property4_ID);
		}
		LuaObject.addMember(l, name31, get27, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3B, true);
		string name32 = "Property4_Value";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Property4_Value);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3C;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Property4_Value);
		}
		LuaObject.addMember(l, name32, get28, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3D, true);
		string name33 = "CDBuff_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_CDBuff_ID);
		}
		LuaCSFunction get29 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3E;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_CDBuff_ID);
		}
		LuaObject.addMember(l, name33, get29, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache3F, true);
		string name34 = "Effect_Attach";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Effect_Attach);
		}
		LuaCSFunction get30 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache40;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Effect_Attach);
		}
		LuaObject.addMember(l, name34, get30, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache41, true);
		string name35 = "Effect_Process";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Effect_Process);
		}
		LuaCSFunction get31 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache42;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Effect_Process);
		}
		LuaObject.addMember(l, name35, get31, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache43, true);
		string name36 = "Effect_Acting";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Effect_Acting);
		}
		LuaCSFunction get32 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache44;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Effect_Acting);
		}
		LuaObject.addMember(l, name36, get32, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache45, true);
		string name37 = "Effect_ActingTarget";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Effect_ActingTarget);
		}
		LuaCSFunction get33 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache46;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Effect_ActingTarget);
		}
		LuaObject.addMember(l, name37, get33, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache47, true);
		string name38 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_Icon);
		}
		LuaCSFunction get34 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache48;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_Icon);
		}
		LuaObject.addMember(l, name38, get34, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache49, true);
		string name39 = "IconDisplay";
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.get_IconDisplay);
		}
		LuaCSFunction get35 = Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4A;
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.set_IconDisplay);
		}
		LuaObject.addMember(l, name39, get35, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4B, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBuffInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBuffInfo.<>f__mg$cache4C, typeof(ConfigDataBuffInfo));
	}

	// Token: 0x0400CD58 RID: 52568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CD59 RID: 52569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CD5A RID: 52570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CD5B RID: 52571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CD5C RID: 52572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CD5D RID: 52573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CD5E RID: 52574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CD5F RID: 52575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CD60 RID: 52576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CD61 RID: 52577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CD62 RID: 52578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CD63 RID: 52579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CD64 RID: 52580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CD65 RID: 52581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CD66 RID: 52582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CD67 RID: 52583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CD68 RID: 52584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CD69 RID: 52585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CD6A RID: 52586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CD6B RID: 52587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CD6C RID: 52588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CD6D RID: 52589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CD6E RID: 52590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CD6F RID: 52591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CD70 RID: 52592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CD71 RID: 52593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CD72 RID: 52594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CD73 RID: 52595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CD74 RID: 52596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CD75 RID: 52597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CD76 RID: 52598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CD77 RID: 52599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CD78 RID: 52600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CD79 RID: 52601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CD7A RID: 52602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CD7B RID: 52603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CD7C RID: 52604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CD7D RID: 52605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CD7E RID: 52606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CD7F RID: 52607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CD80 RID: 52608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400CD81 RID: 52609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400CD82 RID: 52610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400CD83 RID: 52611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400CD84 RID: 52612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400CD85 RID: 52613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400CD86 RID: 52614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400CD87 RID: 52615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400CD88 RID: 52616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400CD89 RID: 52617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400CD8A RID: 52618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400CD8B RID: 52619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400CD8C RID: 52620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400CD8D RID: 52621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400CD8E RID: 52622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400CD8F RID: 52623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400CD90 RID: 52624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400CD91 RID: 52625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400CD92 RID: 52626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400CD93 RID: 52627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400CD94 RID: 52628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400CD95 RID: 52629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400CD96 RID: 52630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400CD97 RID: 52631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400CD98 RID: 52632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400CD99 RID: 52633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400CD9A RID: 52634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400CD9B RID: 52635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400CD9C RID: 52636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400CD9D RID: 52637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400CD9E RID: 52638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400CD9F RID: 52639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400CDA0 RID: 52640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400CDA1 RID: 52641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400CDA2 RID: 52642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400CDA3 RID: 52643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400CDA4 RID: 52644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;
}
