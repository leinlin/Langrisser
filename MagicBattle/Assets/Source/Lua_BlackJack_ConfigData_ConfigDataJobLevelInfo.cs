using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200115E RID: 4446
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo : LuaObject
{
	// Token: 0x06016AB1 RID: 92849 RVA: 0x00608AFC File Offset: 0x00606CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo o = new ConfigDataJobLevelInfo();
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

	// Token: 0x06016AB2 RID: 92850 RVA: 0x00608B44 File Offset: 0x00606D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobMaterialLevels(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.m_jobMaterialLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AB3 RID: 92851 RVA: 0x00608B98 File Offset: 0x00606D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobMaterialLevels(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int[] jobMaterialLevels;
			LuaObject.checkArray<int>(l, 2, out jobMaterialLevels);
			configDataJobLevelInfo.m_jobMaterialLevels = jobMaterialLevels;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AB4 RID: 92852 RVA: 0x00608BF0 File Offset: 0x00606DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gotSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.m_gotSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AB5 RID: 92853 RVA: 0x00608C44 File Offset: 0x00606E44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_gotSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo gotSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out gotSkillInfo);
			configDataJobLevelInfo.m_gotSkillInfo = gotSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AB6 RID: 92854 RVA: 0x00608C9C File Offset: 0x00606E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gotSoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.m_gotSoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AB7 RID: 92855 RVA: 0x00608CF0 File Offset: 0x00606EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gotSoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo gotSoldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out gotSoldierInfo);
			configDataJobLevelInfo.m_gotSoldierInfo = gotSoldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AB8 RID: 92856 RVA: 0x00608D48 File Offset: 0x00606F48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AB9 RID: 92857 RVA: 0x00608D9C File Offset: 0x00606F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataJobLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ABA RID: 92858 RVA: 0x00608DF4 File Offset: 0x00606FF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ABB RID: 92859 RVA: 0x00608E48 File Offset: 0x00607048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataJobLevelInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ABC RID: 92860 RVA: 0x00608EA0 File Offset: 0x006070A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ABD RID: 92861 RVA: 0x00608EF4 File Offset: 0x006070F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataJobLevelInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ABE RID: 92862 RVA: 0x00608F4C File Offset: 0x0060714C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Materials(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.Materials);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ABF RID: 92863 RVA: 0x00608FA0 File Offset: 0x006071A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobLevelUpHeroLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.JobLevelUpHeroLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AC0 RID: 92864 RVA: 0x00608FF4 File Offset: 0x006071F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_JobLevelUpHeroLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int jobLevelUpHeroLevel;
			LuaObject.checkType(l, 2, out jobLevelUpHeroLevel);
			configDataJobLevelInfo.JobLevelUpHeroLevel = jobLevelUpHeroLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AC1 RID: 92865 RVA: 0x0060904C File Offset: 0x0060724C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HP_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.HP_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AC2 RID: 92866 RVA: 0x006090A0 File Offset: 0x006072A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HP_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int hp_INI;
			LuaObject.checkType(l, 2, out hp_INI);
			configDataJobLevelInfo.HP_INI = hp_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AC3 RID: 92867 RVA: 0x006090F8 File Offset: 0x006072F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HP_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.HP_UP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AC4 RID: 92868 RVA: 0x0060914C File Offset: 0x0060734C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HP_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int hp_UP;
			LuaObject.checkType(l, 2, out hp_UP);
			configDataJobLevelInfo.HP_UP = hp_UP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AC5 RID: 92869 RVA: 0x006091A4 File Offset: 0x006073A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AT_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.AT_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AC6 RID: 92870 RVA: 0x006091F8 File Offset: 0x006073F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AT_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int at_INI;
			LuaObject.checkType(l, 2, out at_INI);
			configDataJobLevelInfo.AT_INI = at_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AC7 RID: 92871 RVA: 0x00609250 File Offset: 0x00607450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AT_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.AT_UP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AC8 RID: 92872 RVA: 0x006092A4 File Offset: 0x006074A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AT_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int at_UP;
			LuaObject.checkType(l, 2, out at_UP);
			configDataJobLevelInfo.AT_UP = at_UP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AC9 RID: 92873 RVA: 0x006092FC File Offset: 0x006074FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Magic_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.Magic_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ACA RID: 92874 RVA: 0x00609350 File Offset: 0x00607550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Magic_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int magic_INI;
			LuaObject.checkType(l, 2, out magic_INI);
			configDataJobLevelInfo.Magic_INI = magic_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ACB RID: 92875 RVA: 0x006093A8 File Offset: 0x006075A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Magic_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.Magic_UP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ACC RID: 92876 RVA: 0x006093FC File Offset: 0x006075FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Magic_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int magic_UP;
			LuaObject.checkType(l, 2, out magic_UP);
			configDataJobLevelInfo.Magic_UP = magic_UP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ACD RID: 92877 RVA: 0x00609454 File Offset: 0x00607654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DF_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.DF_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ACE RID: 92878 RVA: 0x006094A8 File Offset: 0x006076A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DF_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int df_INI;
			LuaObject.checkType(l, 2, out df_INI);
			configDataJobLevelInfo.DF_INI = df_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ACF RID: 92879 RVA: 0x00609500 File Offset: 0x00607700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DF_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.DF_UP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AD0 RID: 92880 RVA: 0x00609554 File Offset: 0x00607754
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DF_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int df_UP;
			LuaObject.checkType(l, 2, out df_UP);
			configDataJobLevelInfo.DF_UP = df_UP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AD1 RID: 92881 RVA: 0x006095AC File Offset: 0x006077AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MagicDF_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.MagicDF_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AD2 RID: 92882 RVA: 0x00609600 File Offset: 0x00607800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MagicDF_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int magicDF_INI;
			LuaObject.checkType(l, 2, out magicDF_INI);
			configDataJobLevelInfo.MagicDF_INI = magicDF_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AD3 RID: 92883 RVA: 0x00609658 File Offset: 0x00607858
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MagicDF_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.MagicDF_UP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AD4 RID: 92884 RVA: 0x006096AC File Offset: 0x006078AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MagicDF_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int magicDF_UP;
			LuaObject.checkType(l, 2, out magicDF_UP);
			configDataJobLevelInfo.MagicDF_UP = magicDF_UP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AD5 RID: 92885 RVA: 0x00609704 File Offset: 0x00607904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DEX_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.DEX_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AD6 RID: 92886 RVA: 0x00609758 File Offset: 0x00607958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DEX_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int dex_INI;
			LuaObject.checkType(l, 2, out dex_INI);
			configDataJobLevelInfo.DEX_INI = dex_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AD7 RID: 92887 RVA: 0x006097B0 File Offset: 0x006079B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DEX_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.DEX_UP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AD8 RID: 92888 RVA: 0x00609804 File Offset: 0x00607A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DEX_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int dex_UP;
			LuaObject.checkType(l, 2, out dex_UP);
			configDataJobLevelInfo.DEX_UP = dex_UP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AD9 RID: 92889 RVA: 0x0060985C File Offset: 0x00607A5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GotSkill_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.GotSkill_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ADA RID: 92890 RVA: 0x006098B0 File Offset: 0x00607AB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GotSkill_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int gotSkill_ID;
			LuaObject.checkType(l, 2, out gotSkill_ID);
			configDataJobLevelInfo.GotSkill_ID = gotSkill_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ADB RID: 92891 RVA: 0x00609908 File Offset: 0x00607B08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GotSoldier_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobLevelInfo.GotSoldier_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ADC RID: 92892 RVA: 0x0060995C File Offset: 0x00607B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GotSoldier_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobLevelInfo configDataJobLevelInfo = (ConfigDataJobLevelInfo)LuaObject.checkSelf(l);
			int gotSoldier_ID;
			LuaObject.checkType(l, 2, out gotSoldier_ID);
			configDataJobLevelInfo.GotSoldier_ID = gotSoldier_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ADD RID: 92893 RVA: 0x006099B4 File Offset: 0x00607BB4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataJobLevelInfo");
		string name = "m_jobMaterialLevels";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_m_jobMaterialLevels);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_m_jobMaterialLevels);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_gotSkillInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_m_gotSkillInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_m_gotSkillInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache3, true);
		string name3 = "m_gotSoldierInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_m_gotSoldierInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_m_gotSoldierInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache7, true);
		string name5 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_Desc);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_Desc);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache9, true);
		string name6 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_DescStrKey);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheB, true);
		string name7 = "Materials";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_Materials);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheC, null, true);
		string name8 = "JobLevelUpHeroLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_JobLevelUpHeroLevel);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_JobLevelUpHeroLevel);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheE, true);
		string name9 = "HP_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_HP_INI);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_HP_INI);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache10, true);
		string name10 = "HP_UP";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_HP_UP);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache11;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_HP_UP);
		}
		LuaObject.addMember(l, name10, get9, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache12, true);
		string name11 = "AT_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_AT_INI);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_AT_INI);
		}
		LuaObject.addMember(l, name11, get10, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache14, true);
		string name12 = "AT_UP";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_AT_UP);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_AT_UP);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache16, true);
		string name13 = "Magic_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_Magic_INI);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_Magic_INI);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache18, true);
		string name14 = "Magic_UP";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_Magic_UP);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_Magic_UP);
		}
		LuaObject.addMember(l, name14, get13, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1A, true);
		string name15 = "DF_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_DF_INI);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1B;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_DF_INI);
		}
		LuaObject.addMember(l, name15, get14, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1C, true);
		string name16 = "DF_UP";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_DF_UP);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1D;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_DF_UP);
		}
		LuaObject.addMember(l, name16, get15, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1E, true);
		string name17 = "MagicDF_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_MagicDF_INI);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache1F;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_MagicDF_INI);
		}
		LuaObject.addMember(l, name17, get16, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache20, true);
		string name18 = "MagicDF_UP";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_MagicDF_UP);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache21;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_MagicDF_UP);
		}
		LuaObject.addMember(l, name18, get17, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache22, true);
		string name19 = "DEX_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_DEX_INI);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache23;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_DEX_INI);
		}
		LuaObject.addMember(l, name19, get18, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache24, true);
		string name20 = "DEX_UP";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_DEX_UP);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache25;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_DEX_UP);
		}
		LuaObject.addMember(l, name20, get19, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache26, true);
		string name21 = "GotSkill_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_GotSkill_ID);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_GotSkill_ID);
		}
		LuaObject.addMember(l, name21, get20, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache28, true);
		string name22 = "GotSoldier_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.get_GotSoldier_ID);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.set_GotSoldier_ID);
		}
		LuaObject.addMember(l, name22, get21, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache2A, true);
		if (Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataJobLevelInfo.<>f__mg$cache2B, typeof(ConfigDataJobLevelInfo));
	}

	// Token: 0x0400D1D7 RID: 53719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D1D8 RID: 53720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D1D9 RID: 53721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D1DA RID: 53722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D1DB RID: 53723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D1DC RID: 53724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D1DD RID: 53725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D1DE RID: 53726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D1DF RID: 53727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D1E0 RID: 53728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D1E1 RID: 53729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D1E2 RID: 53730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D1E3 RID: 53731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D1E4 RID: 53732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D1E5 RID: 53733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D1E6 RID: 53734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D1E7 RID: 53735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D1E8 RID: 53736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D1E9 RID: 53737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D1EA RID: 53738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D1EB RID: 53739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D1EC RID: 53740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D1ED RID: 53741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D1EE RID: 53742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D1EF RID: 53743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D1F0 RID: 53744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D1F1 RID: 53745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D1F2 RID: 53746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D1F3 RID: 53747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D1F4 RID: 53748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D1F5 RID: 53749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D1F6 RID: 53750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D1F7 RID: 53751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D1F8 RID: 53752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D1F9 RID: 53753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D1FA RID: 53754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D1FB RID: 53755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D1FC RID: 53756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D1FD RID: 53757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D1FE RID: 53758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D1FF RID: 53759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D200 RID: 53760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D201 RID: 53761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D202 RID: 53762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
