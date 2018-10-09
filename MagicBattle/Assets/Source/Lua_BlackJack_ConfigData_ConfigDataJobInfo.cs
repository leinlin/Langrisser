using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200115D RID: 4445
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataJobInfo : LuaObject
{
	// Token: 0x06016A5F RID: 92767 RVA: 0x00606500 File Offset: 0x00604700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo o = new ConfigDataJobInfo();
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

	// Token: 0x06016A60 RID: 92768 RVA: 0x00606548 File Offset: 0x00604748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.m_armyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A61 RID: 92769 RVA: 0x0060659C File Offset: 0x0060479C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_armyInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			ConfigDataArmyInfo armyInfo;
			LuaObject.checkType<ConfigDataArmyInfo>(l, 2, out armyInfo);
			configDataJobInfo.m_armyInfo = armyInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A62 RID: 92770 RVA: 0x006065F4 File Offset: 0x006047F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_meleeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.m_meleeSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A63 RID: 92771 RVA: 0x00606648 File Offset: 0x00604848
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_meleeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo meleeSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out meleeSkillInfo);
			configDataJobInfo.m_meleeSkillInfo = meleeSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A64 RID: 92772 RVA: 0x006066A0 File Offset: 0x006048A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rangeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.m_rangeSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A65 RID: 92773 RVA: 0x006066F4 File Offset: 0x006048F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rangeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo rangeSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out rangeSkillInfo);
			configDataJobInfo.m_rangeSkillInfo = rangeSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A66 RID: 92774 RVA: 0x0060674C File Offset: 0x0060494C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.m_jobSkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A67 RID: 92775 RVA: 0x006067A0 File Offset: 0x006049A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_jobSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo[] jobSkillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 2, out jobSkillInfos);
			configDataJobInfo.m_jobSkillInfos = jobSkillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A68 RID: 92776 RVA: 0x006067F8 File Offset: 0x006049F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A69 RID: 92777 RVA: 0x0060684C File Offset: 0x00604A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataJobInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A6A RID: 92778 RVA: 0x006068A4 File Offset: 0x00604AA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A6B RID: 92779 RVA: 0x006068F8 File Offset: 0x00604AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataJobInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A6C RID: 92780 RVA: 0x00606950 File Offset: 0x00604B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A6D RID: 92781 RVA: 0x006069A4 File Offset: 0x00604BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataJobInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A6E RID: 92782 RVA: 0x006069FC File Offset: 0x00604BFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A6F RID: 92783 RVA: 0x00606A50 File Offset: 0x00604C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataJobInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A70 RID: 92784 RVA: 0x00606AA8 File Offset: 0x00604CA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A71 RID: 92785 RVA: 0x00606AFC File Offset: 0x00604CFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataJobInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A72 RID: 92786 RVA: 0x00606B54 File Offset: 0x00604D54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name_Eng(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.Name_Eng);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A73 RID: 92787 RVA: 0x00606BA8 File Offset: 0x00604DA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name_Eng(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			string name_Eng;
			LuaObject.checkType(l, 2, out name_Eng);
			configDataJobInfo.Name_Eng = name_Eng;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A74 RID: 92788 RVA: 0x00606C00 File Offset: 0x00604E00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Rank(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.Rank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A75 RID: 92789 RVA: 0x00606C54 File Offset: 0x00604E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Rank(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int rank;
			LuaObject.checkType(l, 2, out rank);
			configDataJobInfo.Rank = rank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A76 RID: 92790 RVA: 0x00606CAC File Offset: 0x00604EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobLevels_ID_Old(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.JobLevels_ID_Old);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A77 RID: 92791 RVA: 0x00606D00 File Offset: 0x00604F00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChangeJobGold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.ChangeJobGold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A78 RID: 92792 RVA: 0x00606D54 File Offset: 0x00604F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChangeJobGold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int changeJobGold;
			LuaObject.checkType(l, 2, out changeJobGold);
			configDataJobInfo.ChangeJobGold = changeJobGold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A79 RID: 92793 RVA: 0x00606DAC File Offset: 0x00604FAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UnlockText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.UnlockText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A7A RID: 92794 RVA: 0x00606E00 File Offset: 0x00605000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UnlockText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			string unlockText;
			LuaObject.checkType(l, 2, out unlockText);
			configDataJobInfo.UnlockText = unlockText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A7B RID: 92795 RVA: 0x00606E58 File Offset: 0x00605058
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Army_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.Army_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A7C RID: 92796 RVA: 0x00606EAC File Offset: 0x006050AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Army_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int army_ID;
			LuaObject.checkType(l, 2, out army_ID);
			configDataJobInfo.Army_ID = army_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A7D RID: 92797 RVA: 0x00606F04 File Offset: 0x00605104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsMelee(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.IsMelee);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A7E RID: 92798 RVA: 0x00606F58 File Offset: 0x00605158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsMelee(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			bool isMelee;
			LuaObject.checkType(l, 2, out isMelee);
			configDataJobInfo.IsMelee = isMelee;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A7F RID: 92799 RVA: 0x00606FB0 File Offset: 0x006051B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MoveType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataJobInfo.MoveType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A80 RID: 92800 RVA: 0x00607004 File Offset: 0x00605204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MoveType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			MoveType moveType;
			LuaObject.checkEnum<MoveType>(l, 2, out moveType);
			configDataJobInfo.MoveType = moveType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A81 RID: 92801 RVA: 0x0060705C File Offset: 0x0060525C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BF_AttackDistance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.BF_AttackDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A82 RID: 92802 RVA: 0x006070B0 File Offset: 0x006052B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BF_AttackDistance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int bf_AttackDistance;
			LuaObject.checkType(l, 2, out bf_AttackDistance);
			configDataJobInfo.BF_AttackDistance = bf_AttackDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A83 RID: 92803 RVA: 0x00607108 File Offset: 0x00605308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MeleeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.MeleeATK_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A84 RID: 92804 RVA: 0x0060715C File Offset: 0x0060535C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MeleeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int meleeATK_ID;
			LuaObject.checkType(l, 2, out meleeATK_ID);
			configDataJobInfo.MeleeATK_ID = meleeATK_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A85 RID: 92805 RVA: 0x006071B4 File Offset: 0x006053B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RangeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.RangeATK_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A86 RID: 92806 RVA: 0x00607208 File Offset: 0x00605408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RangeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int rangeATK_ID;
			LuaObject.checkType(l, 2, out rangeATK_ID);
			configDataJobInfo.RangeATK_ID = rangeATK_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A87 RID: 92807 RVA: 0x00607260 File Offset: 0x00605460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MoveSPD_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.MoveSPD_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A88 RID: 92808 RVA: 0x006072B4 File Offset: 0x006054B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MoveSPD_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int moveSPD_INI;
			LuaObject.checkType(l, 2, out moveSPD_INI);
			configDataJobInfo.MoveSPD_INI = moveSPD_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A89 RID: 92809 RVA: 0x0060730C File Offset: 0x0060550C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BF_MovePoint(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.BF_MovePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A8A RID: 92810 RVA: 0x00607360 File Offset: 0x00605560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BF_MovePoint(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int bf_MovePoint;
			LuaObject.checkType(l, 2, out bf_MovePoint);
			configDataJobInfo.BF_MovePoint = bf_MovePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A8B RID: 92811 RVA: 0x006073B8 File Offset: 0x006055B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BF_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.BF_ActionValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A8C RID: 92812 RVA: 0x0060740C File Offset: 0x0060560C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BF_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int bf_ActionValue;
			LuaObject.checkType(l, 2, out bf_ActionValue);
			configDataJobInfo.BF_ActionValue = bf_ActionValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A8D RID: 92813 RVA: 0x00607464 File Offset: 0x00605664
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Behavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.Behavior);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A8E RID: 92814 RVA: 0x006074B8 File Offset: 0x006056B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Behavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int behavior;
			LuaObject.checkType(l, 2, out behavior);
			configDataJobInfo.Behavior = behavior;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A8F RID: 92815 RVA: 0x00607510 File Offset: 0x00605710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DieFlyDistanceMin(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.DieFlyDistanceMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A90 RID: 92816 RVA: 0x00607564 File Offset: 0x00605764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DieFlyDistanceMin(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int dieFlyDistanceMin;
			LuaObject.checkType(l, 2, out dieFlyDistanceMin);
			configDataJobInfo.DieFlyDistanceMin = dieFlyDistanceMin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A91 RID: 92817 RVA: 0x006075BC File Offset: 0x006057BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DieFlyDistanceMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.DieFlyDistanceMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A92 RID: 92818 RVA: 0x00607610 File Offset: 0x00605810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DieFlyDistanceMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int dieFlyDistanceMax;
			LuaObject.checkType(l, 2, out dieFlyDistanceMax);
			configDataJobInfo.DieFlyDistanceMax = dieFlyDistanceMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A93 RID: 92819 RVA: 0x00607668 File Offset: 0x00605868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Property1_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataJobInfo.Property1_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A94 RID: 92820 RVA: 0x006076BC File Offset: 0x006058BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property1_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			PropertyModifyType property1_ID;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out property1_ID);
			configDataJobInfo.Property1_ID = property1_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A95 RID: 92821 RVA: 0x00607714 File Offset: 0x00605914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Property1_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.Property1_Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A96 RID: 92822 RVA: 0x00607768 File Offset: 0x00605968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property1_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int property1_Value;
			LuaObject.checkType(l, 2, out property1_Value);
			configDataJobInfo.Property1_Value = property1_Value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A97 RID: 92823 RVA: 0x006077C0 File Offset: 0x006059C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Property2_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataJobInfo.Property2_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A98 RID: 92824 RVA: 0x00607814 File Offset: 0x00605A14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Property2_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			PropertyModifyType property2_ID;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out property2_ID);
			configDataJobInfo.Property2_ID = property2_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A99 RID: 92825 RVA: 0x0060786C File Offset: 0x00605A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property2_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.Property2_Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A9A RID: 92826 RVA: 0x006078C0 File Offset: 0x00605AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property2_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int property2_Value;
			LuaObject.checkType(l, 2, out property2_Value);
			configDataJobInfo.Property2_Value = property2_Value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A9B RID: 92827 RVA: 0x00607918 File Offset: 0x00605B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property3_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataJobInfo.Property3_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A9C RID: 92828 RVA: 0x0060796C File Offset: 0x00605B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property3_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			PropertyModifyType property3_ID;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out property3_ID);
			configDataJobInfo.Property3_ID = property3_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A9D RID: 92829 RVA: 0x006079C4 File Offset: 0x00605BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property3_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.Property3_Value);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A9E RID: 92830 RVA: 0x00607A18 File Offset: 0x00605C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Property3_Value(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int property3_Value;
			LuaObject.checkType(l, 2, out property3_Value);
			configDataJobInfo.Property3_Value = property3_Value;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A9F RID: 92831 RVA: 0x00607A70 File Offset: 0x00605C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AdvantagePropertyIds(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.AdvantagePropertyIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AA0 RID: 92832 RVA: 0x00607AC4 File Offset: 0x00605CC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_JobIcon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.JobIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AA1 RID: 92833 RVA: 0x00607B18 File Offset: 0x00605D18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_JobIcon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			string jobIcon;
			LuaObject.checkType(l, 2, out jobIcon);
			configDataJobInfo.JobIcon = jobIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AA2 RID: 92834 RVA: 0x00607B70 File Offset: 0x00605D70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattlePowerHP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.BattlePowerHP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AA3 RID: 92835 RVA: 0x00607BC4 File Offset: 0x00605DC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattlePowerHP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int battlePowerHP;
			LuaObject.checkType(l, 2, out battlePowerHP);
			configDataJobInfo.BattlePowerHP = battlePowerHP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AA4 RID: 92836 RVA: 0x00607C1C File Offset: 0x00605E1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattlePowerAT(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.BattlePowerAT);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AA5 RID: 92837 RVA: 0x00607C70 File Offset: 0x00605E70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattlePowerAT(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int battlePowerAT;
			LuaObject.checkType(l, 2, out battlePowerAT);
			configDataJobInfo.BattlePowerAT = battlePowerAT;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AA6 RID: 92838 RVA: 0x00607CC8 File Offset: 0x00605EC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattlePowerMagic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.BattlePowerMagic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AA7 RID: 92839 RVA: 0x00607D1C File Offset: 0x00605F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattlePowerMagic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int battlePowerMagic;
			LuaObject.checkType(l, 2, out battlePowerMagic);
			configDataJobInfo.BattlePowerMagic = battlePowerMagic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AA8 RID: 92840 RVA: 0x00607D74 File Offset: 0x00605F74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattlePowerDF(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.BattlePowerDF);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AA9 RID: 92841 RVA: 0x00607DC8 File Offset: 0x00605FC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattlePowerDF(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int battlePowerDF;
			LuaObject.checkType(l, 2, out battlePowerDF);
			configDataJobInfo.BattlePowerDF = battlePowerDF;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AAA RID: 92842 RVA: 0x00607E20 File Offset: 0x00606020
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattlePowerMagicDF(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.BattlePowerMagicDF);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AAB RID: 92843 RVA: 0x00607E74 File Offset: 0x00606074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattlePowerMagicDF(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int battlePowerMagicDF;
			LuaObject.checkType(l, 2, out battlePowerMagicDF);
			configDataJobInfo.BattlePowerMagicDF = battlePowerMagicDF;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AAC RID: 92844 RVA: 0x00607ECC File Offset: 0x006060CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePowerDEX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.BattlePowerDEX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AAD RID: 92845 RVA: 0x00607F20 File Offset: 0x00606120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattlePowerDEX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			int battlePowerDEX;
			LuaObject.checkType(l, 2, out battlePowerDEX);
			configDataJobInfo.BattlePowerDEX = battlePowerDEX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AAE RID: 92846 RVA: 0x00607F78 File Offset: 0x00606178
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Skills_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobInfo configDataJobInfo = (ConfigDataJobInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobInfo.Skills_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016AAF RID: 92847 RVA: 0x00607FCC File Offset: 0x006061CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataJobInfo");
		string name = "m_armyInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_m_armyInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_m_armyInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1, true);
		string name2 = "m_meleeSkillInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_m_meleeSkillInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_m_meleeSkillInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3, true);
		string name3 = "m_rangeSkillInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_m_rangeSkillInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_m_rangeSkillInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache5, true);
		string name4 = "m_jobSkillInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_m_jobSkillInfos);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_m_jobSkillInfos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache7, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache9, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheB, true);
		string name7 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_NameStrKey);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheD, true);
		string name8 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Desc);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Desc);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cacheF, true);
		string name9 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_DescStrKey);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache11, true);
		string name10 = "Name_Eng";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Name_Eng);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Name_Eng);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache13, true);
		string name11 = "Rank";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Rank);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Rank);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache15, true);
		string name12 = "JobLevels_ID_Old";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_JobLevels_ID_Old);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache16, null, true);
		string name13 = "ChangeJobGold";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_ChangeJobGold);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_ChangeJobGold);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache18, true);
		string name14 = "UnlockText";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_UnlockText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_UnlockText);
		}
		LuaObject.addMember(l, name14, get13, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1A, true);
		string name15 = "Army_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Army_ID);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1B;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Army_ID);
		}
		LuaObject.addMember(l, name15, get14, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1C, true);
		string name16 = "IsMelee";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_IsMelee);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1D;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_IsMelee);
		}
		LuaObject.addMember(l, name16, get15, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1E, true);
		string name17 = "MoveType";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_MoveType);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache1F;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_MoveType);
		}
		LuaObject.addMember(l, name17, get16, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache20, true);
		string name18 = "BF_AttackDistance";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_BF_AttackDistance);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache21;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_BF_AttackDistance);
		}
		LuaObject.addMember(l, name18, get17, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache22, true);
		string name19 = "MeleeATK_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_MeleeATK_ID);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache23;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_MeleeATK_ID);
		}
		LuaObject.addMember(l, name19, get18, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache24, true);
		string name20 = "RangeATK_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_RangeATK_ID);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache25;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_RangeATK_ID);
		}
		LuaObject.addMember(l, name20, get19, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache26, true);
		string name21 = "MoveSPD_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_MoveSPD_INI);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_MoveSPD_INI);
		}
		LuaObject.addMember(l, name21, get20, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache28, true);
		string name22 = "BF_MovePoint";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_BF_MovePoint);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_BF_MovePoint);
		}
		LuaObject.addMember(l, name22, get21, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2A, true);
		string name23 = "BF_ActionValue";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_BF_ActionValue);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_BF_ActionValue);
		}
		LuaObject.addMember(l, name23, get22, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2C, true);
		string name24 = "Behavior";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Behavior);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2D;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Behavior);
		}
		LuaObject.addMember(l, name24, get23, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2E, true);
		string name25 = "DieFlyDistanceMin";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_DieFlyDistanceMin);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_DieFlyDistanceMin);
		}
		LuaObject.addMember(l, name25, get24, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache30, true);
		string name26 = "DieFlyDistanceMax";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_DieFlyDistanceMax);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache31;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_DieFlyDistanceMax);
		}
		LuaObject.addMember(l, name26, get25, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache32, true);
		string name27 = "Property1_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Property1_ID);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache33;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Property1_ID);
		}
		LuaObject.addMember(l, name27, get26, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache34, true);
		string name28 = "Property1_Value";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Property1_Value);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache35;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Property1_Value);
		}
		LuaObject.addMember(l, name28, get27, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache36, true);
		string name29 = "Property2_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Property2_ID);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache37;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Property2_ID);
		}
		LuaObject.addMember(l, name29, get28, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache38, true);
		string name30 = "Property2_Value";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Property2_Value);
		}
		LuaCSFunction get29 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache39;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Property2_Value);
		}
		LuaObject.addMember(l, name30, get29, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3A, true);
		string name31 = "Property3_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Property3_ID);
		}
		LuaCSFunction get30 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3B;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Property3_ID);
		}
		LuaObject.addMember(l, name31, get30, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3C, true);
		string name32 = "Property3_Value";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Property3_Value);
		}
		LuaCSFunction get31 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3D;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_Property3_Value);
		}
		LuaObject.addMember(l, name32, get31, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3E, true);
		string name33 = "AdvantagePropertyIds";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_AdvantagePropertyIds);
		}
		LuaObject.addMember(l, name33, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache3F, null, true);
		string name34 = "JobIcon";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_JobIcon);
		}
		LuaCSFunction get32 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache40;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_JobIcon);
		}
		LuaObject.addMember(l, name34, get32, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache41, true);
		string name35 = "BattlePowerHP";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_BattlePowerHP);
		}
		LuaCSFunction get33 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache42;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_BattlePowerHP);
		}
		LuaObject.addMember(l, name35, get33, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache43, true);
		string name36 = "BattlePowerAT";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_BattlePowerAT);
		}
		LuaCSFunction get34 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache44;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_BattlePowerAT);
		}
		LuaObject.addMember(l, name36, get34, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache45, true);
		string name37 = "BattlePowerMagic";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_BattlePowerMagic);
		}
		LuaCSFunction get35 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache46;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_BattlePowerMagic);
		}
		LuaObject.addMember(l, name37, get35, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache47, true);
		string name38 = "BattlePowerDF";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_BattlePowerDF);
		}
		LuaCSFunction get36 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache48;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_BattlePowerDF);
		}
		LuaObject.addMember(l, name38, get36, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache49, true);
		string name39 = "BattlePowerMagicDF";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_BattlePowerMagicDF);
		}
		LuaCSFunction get37 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4A;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_BattlePowerMagicDF);
		}
		LuaObject.addMember(l, name39, get37, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4B, true);
		string name40 = "BattlePowerDEX";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_BattlePowerDEX);
		}
		LuaCSFunction get38 = Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4C;
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.set_BattlePowerDEX);
		}
		LuaObject.addMember(l, name40, get38, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4D, true);
		string name41 = "Skills_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.get_Skills_ID);
		}
		LuaObject.addMember(l, name41, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4E, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataJobInfo.<>f__mg$cache4F, typeof(ConfigDataJobInfo));
	}

	// Token: 0x0400D187 RID: 53639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D188 RID: 53640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D189 RID: 53641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D18A RID: 53642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D18B RID: 53643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D18C RID: 53644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D18D RID: 53645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D18E RID: 53646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D18F RID: 53647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D190 RID: 53648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D191 RID: 53649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D192 RID: 53650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D193 RID: 53651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D194 RID: 53652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D195 RID: 53653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D196 RID: 53654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D197 RID: 53655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D198 RID: 53656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D199 RID: 53657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D19A RID: 53658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D19B RID: 53659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D19C RID: 53660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D19D RID: 53661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D19E RID: 53662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D19F RID: 53663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D1A0 RID: 53664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D1A1 RID: 53665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D1A2 RID: 53666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D1A3 RID: 53667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D1A4 RID: 53668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D1A5 RID: 53669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D1A6 RID: 53670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D1A7 RID: 53671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D1A8 RID: 53672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D1A9 RID: 53673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D1AA RID: 53674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D1AB RID: 53675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D1AC RID: 53676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D1AD RID: 53677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D1AE RID: 53678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D1AF RID: 53679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D1B0 RID: 53680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D1B1 RID: 53681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D1B2 RID: 53682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D1B3 RID: 53683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D1B4 RID: 53684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D1B5 RID: 53685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D1B6 RID: 53686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D1B7 RID: 53687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D1B8 RID: 53688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D1B9 RID: 53689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D1BA RID: 53690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D1BB RID: 53691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D1BC RID: 53692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D1BD RID: 53693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D1BE RID: 53694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400D1BF RID: 53695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400D1C0 RID: 53696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400D1C1 RID: 53697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400D1C2 RID: 53698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400D1C3 RID: 53699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400D1C4 RID: 53700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400D1C5 RID: 53701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400D1C6 RID: 53702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400D1C7 RID: 53703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400D1C8 RID: 53704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400D1C9 RID: 53705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400D1CA RID: 53706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400D1CB RID: 53707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400D1CC RID: 53708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400D1CD RID: 53709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400D1CE RID: 53710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400D1CF RID: 53711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400D1D0 RID: 53712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400D1D1 RID: 53713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400D1D2 RID: 53714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400D1D3 RID: 53715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400D1D4 RID: 53716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400D1D5 RID: 53717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400D1D6 RID: 53718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;
}
