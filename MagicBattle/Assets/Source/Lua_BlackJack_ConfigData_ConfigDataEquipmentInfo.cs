using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200114C RID: 4428
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo : LuaObject
{
	// Token: 0x0601679B RID: 92059 RVA: 0x005F22D4 File Offset: 0x005F04D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo o = new ConfigDataEquipmentInfo();
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

	// Token: 0x0601679C RID: 92060 RVA: 0x005F231C File Offset: 0x005F051C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetActiveSkillId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int equipmentLevel;
			LuaObject.checkType(l, 2, out equipmentLevel);
			int activeSkillId = configDataEquipmentInfo.GetActiveSkillId(equipmentLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, activeSkillId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601679D RID: 92061 RVA: 0x005F2380 File Offset: 0x005F0580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601679E RID: 92062 RVA: 0x005F23D4 File Offset: 0x005F05D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataEquipmentInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601679F RID: 92063 RVA: 0x005F242C File Offset: 0x005F062C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167A0 RID: 92064 RVA: 0x005F2480 File Offset: 0x005F0680
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataEquipmentInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167A1 RID: 92065 RVA: 0x005F24D8 File Offset: 0x005F06D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EquipmentType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataEquipmentInfo.EquipmentType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167A2 RID: 92066 RVA: 0x005F252C File Offset: 0x005F072C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EquipmentType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			EquipmentType equipmentType;
			LuaObject.checkEnum<EquipmentType>(l, 2, out equipmentType);
			configDataEquipmentInfo.EquipmentType = equipmentType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167A3 RID: 92067 RVA: 0x005F2584 File Offset: 0x005F0784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArmyIds(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.ArmyIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167A4 RID: 92068 RVA: 0x005F25D8 File Offset: 0x005F07D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167A5 RID: 92069 RVA: 0x005F262C File Offset: 0x005F082C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataEquipmentInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167A6 RID: 92070 RVA: 0x005F2684 File Offset: 0x005F0884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobIds(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.JobIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167A7 RID: 92071 RVA: 0x005F26D8 File Offset: 0x005F08D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rank(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.Rank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167A8 RID: 92072 RVA: 0x005F272C File Offset: 0x005F092C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Rank(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int rank;
			LuaObject.checkType(l, 2, out rank);
			configDataEquipmentInfo.Rank = rank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167A9 RID: 92073 RVA: 0x005F2784 File Offset: 0x005F0984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BornStarLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.BornStarLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167AA RID: 92074 RVA: 0x005F27D8 File Offset: 0x005F09D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BornStarLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int bornStarLevel;
			LuaObject.checkType(l, 2, out bornStarLevel);
			configDataEquipmentInfo.BornStarLevel = bornStarLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167AB RID: 92075 RVA: 0x005F2830 File Offset: 0x005F0A30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Property1_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataEquipmentInfo.Property1_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167AC RID: 92076 RVA: 0x005F2884 File Offset: 0x005F0A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property1_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			PropertyModifyType property1_ID;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out property1_ID);
			configDataEquipmentInfo.Property1_ID = property1_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167AD RID: 92077 RVA: 0x005F28DC File Offset: 0x005F0ADC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Property1_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.Property1_Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167AE RID: 92078 RVA: 0x005F2930 File Offset: 0x005F0B30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Property1_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int property1_Value;
			LuaObject.checkType(l, 2, out property1_Value);
			configDataEquipmentInfo.Property1_Value = property1_Value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167AF RID: 92079 RVA: 0x005F2988 File Offset: 0x005F0B88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property1_LevelUpValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.Property1_LevelUpValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167B0 RID: 92080 RVA: 0x005F29DC File Offset: 0x005F0BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property1_LevelUpValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int property1_LevelUpValue;
			LuaObject.checkType(l, 2, out property1_LevelUpValue);
			configDataEquipmentInfo.Property1_LevelUpValue = property1_LevelUpValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167B1 RID: 92081 RVA: 0x005F2A34 File Offset: 0x005F0C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property2_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataEquipmentInfo.Property2_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167B2 RID: 92082 RVA: 0x005F2A88 File Offset: 0x005F0C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property2_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			PropertyModifyType property2_ID;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out property2_ID);
			configDataEquipmentInfo.Property2_ID = property2_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167B3 RID: 92083 RVA: 0x005F2AE0 File Offset: 0x005F0CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property2_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.Property2_Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167B4 RID: 92084 RVA: 0x005F2B34 File Offset: 0x005F0D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property2_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int property2_Value;
			LuaObject.checkType(l, 2, out property2_Value);
			configDataEquipmentInfo.Property2_Value = property2_Value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167B5 RID: 92085 RVA: 0x005F2B8C File Offset: 0x005F0D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property2_LevelUpValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.Property2_LevelUpValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167B6 RID: 92086 RVA: 0x005F2BE0 File Offset: 0x005F0DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property2_LevelUpValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int property2_LevelUpValue;
			LuaObject.checkType(l, 2, out property2_LevelUpValue);
			configDataEquipmentInfo.Property2_LevelUpValue = property2_LevelUpValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167B7 RID: 92087 RVA: 0x005F2C38 File Offset: 0x005F0E38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Exp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.Exp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167B8 RID: 92088 RVA: 0x005F2C8C File Offset: 0x005F0E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Exp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			configDataEquipmentInfo.Exp = exp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167B9 RID: 92089 RVA: 0x005F2CE4 File Offset: 0x005F0EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167BA RID: 92090 RVA: 0x005F2D38 File Offset: 0x005F0F38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataEquipmentInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167BB RID: 92091 RVA: 0x005F2D90 File Offset: 0x005F0F90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SkillIds(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.SkillIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167BC RID: 92092 RVA: 0x005F2DE4 File Offset: 0x005F0FE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SkillLevels(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.SkillLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167BD RID: 92093 RVA: 0x005F2E38 File Offset: 0x005F1038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SkillHero(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.SkillHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167BE RID: 92094 RVA: 0x005F2E8C File Offset: 0x005F108C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SkillHero(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int skillHero;
			LuaObject.checkType(l, 2, out skillHero);
			configDataEquipmentInfo.SkillHero = skillHero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167BF RID: 92095 RVA: 0x005F2EE4 File Offset: 0x005F10E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SortIndex(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.SortIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167C0 RID: 92096 RVA: 0x005F2F38 File Offset: 0x005F1138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SortIndex(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int sortIndex;
			LuaObject.checkType(l, 2, out sortIndex);
			configDataEquipmentInfo.SortIndex = sortIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167C1 RID: 92097 RVA: 0x005F2F90 File Offset: 0x005F1190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelUpGoods1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.LevelUpGoods1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167C2 RID: 92098 RVA: 0x005F2FE4 File Offset: 0x005F11E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelUpGoods2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.LevelUpGoods2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167C3 RID: 92099 RVA: 0x005F3038 File Offset: 0x005F1238
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LevelUpGoods3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.LevelUpGoods3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167C4 RID: 92100 RVA: 0x005F308C File Offset: 0x005F128C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelUpGoods4(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.LevelUpGoods4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167C5 RID: 92101 RVA: 0x005F30E0 File Offset: 0x005F12E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelUpGoods5(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.LevelUpGoods5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167C6 RID: 92102 RVA: 0x005F3134 File Offset: 0x005F1334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GetPathList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.GetPathList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167C7 RID: 92103 RVA: 0x005F3188 File Offset: 0x005F1388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GetPathDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.GetPathDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167C8 RID: 92104 RVA: 0x005F31DC File Offset: 0x005F13DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GetPathDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			string getPathDesc;
			LuaObject.checkType(l, 2, out getPathDesc);
			configDataEquipmentInfo.GetPathDesc = getPathDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167C9 RID: 92105 RVA: 0x005F3234 File Offset: 0x005F1434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AlchemyGold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.AlchemyGold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167CA RID: 92106 RVA: 0x005F3288 File Offset: 0x005F1488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AlchemyGold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int alchemyGold;
			LuaObject.checkType(l, 2, out alchemyGold);
			configDataEquipmentInfo.AlchemyGold = alchemyGold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167CB RID: 92107 RVA: 0x005F32E0 File Offset: 0x005F14E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RandomDropRewardID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.RandomDropRewardID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167CC RID: 92108 RVA: 0x005F3334 File Offset: 0x005F1534
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RandomDropRewardID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int randomDropRewardID;
			LuaObject.checkType(l, 2, out randomDropRewardID);
			configDataEquipmentInfo.RandomDropRewardID = randomDropRewardID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167CD RID: 92109 RVA: 0x005F338C File Offset: 0x005F158C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.DisplayRewardCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167CE RID: 92110 RVA: 0x005F33E0 File Offset: 0x005F15E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			int displayRewardCount;
			LuaObject.checkType(l, 2, out displayRewardCount);
			configDataEquipmentInfo.DisplayRewardCount = displayRewardCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167CF RID: 92111 RVA: 0x005F3438 File Offset: 0x005F1638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArchiveDisplay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.ArchiveDisplay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167D0 RID: 92112 RVA: 0x005F348C File Offset: 0x005F168C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ArchiveDisplay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			bool archiveDisplay;
			LuaObject.checkType(l, 2, out archiveDisplay);
			configDataEquipmentInfo.ArchiveDisplay = archiveDisplay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167D1 RID: 92113 RVA: 0x005F34E4 File Offset: 0x005F16E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnchantTemplateIds(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.EnchantTemplateIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167D2 RID: 92114 RVA: 0x005F3538 File Offset: 0x005F1738
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EquipCoditionDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEquipmentInfo.EquipCoditionDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167D3 RID: 92115 RVA: 0x005F358C File Offset: 0x005F178C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EquipCoditionDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEquipmentInfo configDataEquipmentInfo = (ConfigDataEquipmentInfo)LuaObject.checkSelf(l);
			string equipCoditionDesc;
			LuaObject.checkType(l, 2, out equipCoditionDesc);
			configDataEquipmentInfo.EquipCoditionDesc = equipCoditionDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167D4 RID: 92116 RVA: 0x005F35E4 File Offset: 0x005F17E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataEquipmentInfo");
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.GetActiveSkillId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache0);
		string name = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_ID);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_ID);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2, true);
		string name2 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_Name);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache3;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_Name);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache4, true);
		string name3 = "EquipmentType";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_EquipmentType);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache5;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_EquipmentType);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache6, true);
		string name4 = "ArmyIds";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_ArmyIds);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache7, null, true);
		string name5 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_Desc);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_Desc);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache9, true);
		string name6 = "JobIds";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_JobIds);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheA, null, true);
		string name7 = "Rank";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_Rank);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheB;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_Rank);
		}
		LuaObject.addMember(l, name7, get5, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheC, true);
		string name8 = "BornStarLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_BornStarLevel);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_BornStarLevel);
		}
		LuaObject.addMember(l, name8, get6, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheE, true);
		string name9 = "Property1_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_Property1_ID);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_Property1_ID);
		}
		LuaObject.addMember(l, name9, get7, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache10, true);
		string name10 = "Property1_Value";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_Property1_Value);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache11;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_Property1_Value);
		}
		LuaObject.addMember(l, name10, get8, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache12, true);
		string name11 = "Property1_LevelUpValue";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_Property1_LevelUpValue);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_Property1_LevelUpValue);
		}
		LuaObject.addMember(l, name11, get9, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache14, true);
		string name12 = "Property2_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_Property2_ID);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_Property2_ID);
		}
		LuaObject.addMember(l, name12, get10, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache16, true);
		string name13 = "Property2_Value";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_Property2_Value);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_Property2_Value);
		}
		LuaObject.addMember(l, name13, get11, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache18, true);
		string name14 = "Property2_LevelUpValue";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_Property2_LevelUpValue);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_Property2_LevelUpValue);
		}
		LuaObject.addMember(l, name14, get12, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1A, true);
		string name15 = "Exp";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_Exp);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1B;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_Exp);
		}
		LuaObject.addMember(l, name15, get13, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1C, true);
		string name16 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_Icon);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1D;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_Icon);
		}
		LuaObject.addMember(l, name16, get14, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1E, true);
		string name17 = "SkillIds";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_SkillIds);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache1F, null, true);
		string name18 = "SkillLevels";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_SkillLevels);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache20, null, true);
		string name19 = "SkillHero";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_SkillHero);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache21;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_SkillHero);
		}
		LuaObject.addMember(l, name19, get15, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache22, true);
		string name20 = "SortIndex";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_SortIndex);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache23;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_SortIndex);
		}
		LuaObject.addMember(l, name20, get16, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache24, true);
		string name21 = "LevelUpGoods1";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_LevelUpGoods1);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache25, null, true);
		string name22 = "LevelUpGoods2";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_LevelUpGoods2);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache26, null, true);
		string name23 = "LevelUpGoods3";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_LevelUpGoods3);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache27, null, true);
		string name24 = "LevelUpGoods4";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_LevelUpGoods4);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache28, null, true);
		string name25 = "LevelUpGoods5";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_LevelUpGoods5);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache29, null, true);
		string name26 = "GetPathList";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_GetPathList);
		}
		LuaObject.addMember(l, name26, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2A, null, true);
		string name27 = "GetPathDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_GetPathDesc);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_GetPathDesc);
		}
		LuaObject.addMember(l, name27, get17, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2C, true);
		string name28 = "AlchemyGold";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_AlchemyGold);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2D;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_AlchemyGold);
		}
		LuaObject.addMember(l, name28, get18, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2E, true);
		string name29 = "RandomDropRewardID";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_RandomDropRewardID);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_RandomDropRewardID);
		}
		LuaObject.addMember(l, name29, get19, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache30, true);
		string name30 = "DisplayRewardCount";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_DisplayRewardCount);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache31;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_DisplayRewardCount);
		}
		LuaObject.addMember(l, name30, get20, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache32, true);
		string name31 = "ArchiveDisplay";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_ArchiveDisplay);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache33;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_ArchiveDisplay);
		}
		LuaObject.addMember(l, name31, get21, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache34, true);
		string name32 = "EnchantTemplateIds";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_EnchantTemplateIds);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache35, null, true);
		string name33 = "EquipCoditionDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.get_EquipCoditionDesc);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache36;
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.set_EquipCoditionDesc);
		}
		LuaObject.addMember(l, name33, get22, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache37, true);
		if (Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataEquipmentInfo.<>f__mg$cache38, typeof(ConfigDataEquipmentInfo));
	}

	// Token: 0x0400CEE5 RID: 52965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CEE6 RID: 52966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CEE7 RID: 52967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CEE8 RID: 52968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CEE9 RID: 52969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CEEA RID: 52970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CEEB RID: 52971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CEEC RID: 52972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CEED RID: 52973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CEEE RID: 52974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CEEF RID: 52975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CEF0 RID: 52976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CEF1 RID: 52977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CEF2 RID: 52978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CEF3 RID: 52979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CEF4 RID: 52980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CEF5 RID: 52981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CEF6 RID: 52982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CEF7 RID: 52983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CEF8 RID: 52984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CEF9 RID: 52985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CEFA RID: 52986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CEFB RID: 52987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CEFC RID: 52988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CEFD RID: 52989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CEFE RID: 52990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CEFF RID: 52991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CF00 RID: 52992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CF01 RID: 52993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CF02 RID: 52994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CF03 RID: 52995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CF04 RID: 52996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CF05 RID: 52997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CF06 RID: 52998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CF07 RID: 52999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CF08 RID: 53000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CF09 RID: 53001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CF0A RID: 53002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CF0B RID: 53003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CF0C RID: 53004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CF0D RID: 53005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400CF0E RID: 53006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400CF0F RID: 53007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400CF10 RID: 53008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400CF11 RID: 53009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400CF12 RID: 53010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400CF13 RID: 53011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400CF14 RID: 53012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400CF15 RID: 53013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400CF16 RID: 53014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400CF17 RID: 53015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400CF18 RID: 53016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400CF19 RID: 53017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400CF1A RID: 53018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400CF1B RID: 53019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400CF1C RID: 53020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400CF1D RID: 53021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;
}
