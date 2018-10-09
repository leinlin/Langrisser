using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200116A RID: 4458
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataSkillInfo : LuaObject
{
	// Token: 0x06016CDF RID: 93407 RVA: 0x00618978 File Offset: 0x00616B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo o = new ConfigDataSkillInfo();
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

	// Token: 0x06016CE0 RID: 93408 RVA: 0x006189C0 File Offset: 0x00616BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNormalAttack(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool b = configDataSkillInfo.IsNormalAttack();
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

	// Token: 0x06016CE1 RID: 93409 RVA: 0x00618A14 File Offset: 0x00616C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBattlefieldSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool b = configDataSkillInfo.IsBattlefieldSkill();
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

	// Token: 0x06016CE2 RID: 93410 RVA: 0x00618A68 File Offset: 0x00616C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDamageSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool b = configDataSkillInfo.IsDamageSkill();
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

	// Token: 0x06016CE3 RID: 93411 RVA: 0x00618ABC File Offset: 0x00616CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPhysicalDamageSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool b = configDataSkillInfo.IsPhysicalDamageSkill();
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

	// Token: 0x06016CE4 RID: 93412 RVA: 0x00618B10 File Offset: 0x00616D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsMagicDamageSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool b = configDataSkillInfo.IsMagicDamageSkill();
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

	// Token: 0x06016CE5 RID: 93413 RVA: 0x00618B64 File Offset: 0x00616D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsHealSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool b = configDataSkillInfo.IsHealSkill();
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

	// Token: 0x06016CE6 RID: 93414 RVA: 0x00618BB8 File Offset: 0x00616DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBuffSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool b = configDataSkillInfo.IsBuffSkill();
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

	// Token: 0x06016CE7 RID: 93415 RVA: 0x00618C0C File Offset: 0x00616E0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsSummonSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool b = configDataSkillInfo.IsSummonSkill();
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

	// Token: 0x06016CE8 RID: 93416 RVA: 0x00618C60 File Offset: 0x00616E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTeleportSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool b = configDataSkillInfo.IsTeleportSkill();
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

	// Token: 0x06016CE9 RID: 93417 RVA: 0x00618CB4 File Offset: 0x00616EB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPassiveSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool b = configDataSkillInfo.IsPassiveSkill();
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

	// Token: 0x06016CEA RID: 93418 RVA: 0x00618D08 File Offset: 0x00616F08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_buffInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.m_buffInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CEB RID: 93419 RVA: 0x00618D5C File Offset: 0x00616F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buffInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			ConfigDataBuffInfo[] buffInfos;
			LuaObject.checkArray<ConfigDataBuffInfo>(l, 2, out buffInfos);
			configDataSkillInfo.m_buffInfos = buffInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CEC RID: 93420 RVA: 0x00618DB4 File Offset: 0x00616FB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_passiveBuffInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.m_passiveBuffInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CED RID: 93421 RVA: 0x00618E08 File Offset: 0x00617008
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_passiveBuffInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			ConfigDataBuffInfo[] passiveBuffInfos;
			LuaObject.checkArray<ConfigDataBuffInfo>(l, 2, out passiveBuffInfos);
			configDataSkillInfo.m_passiveBuffInfos = passiveBuffInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CEE RID: 93422 RVA: 0x00618E60 File Offset: 0x00617060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selfBuffInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.m_selfBuffInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CEF RID: 93423 RVA: 0x00618EB4 File Offset: 0x006170B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_selfBuffInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			ConfigDataBuffInfo[] selfBuffInfos;
			LuaObject.checkArray<ConfigDataBuffInfo>(l, 2, out selfBuffInfos);
			configDataSkillInfo.m_selfBuffInfos = selfBuffInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CF0 RID: 93424 RVA: 0x00618F0C File Offset: 0x0061710C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isNormalAttack(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.m_isNormalAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CF1 RID: 93425 RVA: 0x00618F60 File Offset: 0x00617160
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isNormalAttack(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool isNormalAttack;
			LuaObject.checkType(l, 2, out isNormalAttack);
			configDataSkillInfo.m_isNormalAttack = isNormalAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CF2 RID: 93426 RVA: 0x00618FB8 File Offset: 0x006171B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CF3 RID: 93427 RVA: 0x0061900C File Offset: 0x0061720C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataSkillInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CF4 RID: 93428 RVA: 0x00619064 File Offset: 0x00617264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CF5 RID: 93429 RVA: 0x006190B8 File Offset: 0x006172B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataSkillInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CF6 RID: 93430 RVA: 0x00619110 File Offset: 0x00617310
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CF7 RID: 93431 RVA: 0x00619164 File Offset: 0x00617364
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataSkillInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CF8 RID: 93432 RVA: 0x006191BC File Offset: 0x006173BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CF9 RID: 93433 RVA: 0x00619210 File Offset: 0x00617410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataSkillInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CFA RID: 93434 RVA: 0x00619268 File Offset: 0x00617468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CFB RID: 93435 RVA: 0x006192BC File Offset: 0x006174BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataSkillInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CFC RID: 93436 RVA: 0x00619314 File Offset: 0x00617514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsMagic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.IsMagic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CFD RID: 93437 RVA: 0x00619368 File Offset: 0x00617568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsMagic(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool isMagic;
			LuaObject.checkType(l, 2, out isMagic);
			configDataSkillInfo.IsMagic = isMagic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CFE RID: 93438 RVA: 0x006193C0 File Offset: 0x006175C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsActiveSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.IsActiveSkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CFF RID: 93439 RVA: 0x00619414 File Offset: 0x00617614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsActiveSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool isActiveSkill;
			LuaObject.checkType(l, 2, out isActiveSkill);
			configDataSkillInfo.IsActiveSkill = isActiveSkill;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D00 RID: 93440 RVA: 0x0061946C File Offset: 0x0061766C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsRangeSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.IsRangeSkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D01 RID: 93441 RVA: 0x006194C0 File Offset: 0x006176C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsRangeSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool isRangeSkill;
			LuaObject.checkType(l, 2, out isRangeSkill);
			configDataSkillInfo.IsRangeSkill = isRangeSkill;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D02 RID: 93442 RVA: 0x00619518 File Offset: 0x00617718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AIIsRangeSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.AIIsRangeSkill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D03 RID: 93443 RVA: 0x0061956C File Offset: 0x0061776C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AIIsRangeSkill(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool aiisRangeSkill;
			LuaObject.checkType(l, 2, out aiisRangeSkill);
			configDataSkillInfo.AIIsRangeSkill = aiisRangeSkill;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D04 RID: 93444 RVA: 0x006195C4 File Offset: 0x006177C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsNewTurn(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.IsNewTurn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D05 RID: 93445 RVA: 0x00619618 File Offset: 0x00617818
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsNewTurn(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			bool isNewTurn;
			LuaObject.checkType(l, 2, out isNewTurn);
			configDataSkillInfo.IsNewTurn = isNewTurn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D06 RID: 93446 RVA: 0x00619670 File Offset: 0x00617870
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LimitArmys_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.LimitArmys_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D07 RID: 93447 RVA: 0x006196C4 File Offset: 0x006178C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PassiveBuffs_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.PassiveBuffs_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D08 RID: 93448 RVA: 0x00619718 File Offset: 0x00617918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelfBuffs_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.SelfBuffs_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D09 RID: 93449 RVA: 0x0061976C File Offset: 0x0061796C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillAIType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataSkillInfo.SkillAIType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D0A RID: 93450 RVA: 0x006197C0 File Offset: 0x006179C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SkillAIType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			SkillAIType skillAIType;
			LuaObject.checkEnum<SkillAIType>(l, 2, out skillAIType);
			configDataSkillInfo.SkillAIType = skillAIType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D0B RID: 93451 RVA: 0x00619818 File Offset: 0x00617A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataSkillInfo.SkillType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D0C RID: 93452 RVA: 0x0061986C File Offset: 0x00617A6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SkillType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			SkillType skillType;
			LuaObject.checkEnum<SkillType>(l, 2, out skillType);
			configDataSkillInfo.SkillType = skillType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D0D RID: 93453 RVA: 0x006198C4 File Offset: 0x00617AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillTypeParam1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.SkillTypeParam1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D0E RID: 93454 RVA: 0x00619918 File Offset: 0x00617B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SkillTypeParam1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int skillTypeParam;
			LuaObject.checkType(l, 2, out skillTypeParam);
			configDataSkillInfo.SkillTypeParam1 = skillTypeParam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D0F RID: 93455 RVA: 0x00619970 File Offset: 0x00617B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillTypeParam2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.SkillTypeParam2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D10 RID: 93456 RVA: 0x006199C4 File Offset: 0x00617BC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SkillTypeParam2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int skillTypeParam;
			LuaObject.checkType(l, 2, out skillTypeParam);
			configDataSkillInfo.SkillTypeParam2 = skillTypeParam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D11 RID: 93457 RVA: 0x00619A1C File Offset: 0x00617C1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SkillTypeParam3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.SkillTypeParam3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D12 RID: 93458 RVA: 0x00619A70 File Offset: 0x00617C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SkillTypeParam3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int skillTypeParam;
			LuaObject.checkType(l, 2, out skillTypeParam);
			configDataSkillInfo.SkillTypeParam3 = skillTypeParam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D13 RID: 93459 RVA: 0x00619AC8 File Offset: 0x00617CC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Time_Sing(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Time_Sing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D14 RID: 93460 RVA: 0x00619B1C File Offset: 0x00617D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Time_Sing(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int time_Sing;
			LuaObject.checkType(l, 2, out time_Sing);
			configDataSkillInfo.Time_Sing = time_Sing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D15 RID: 93461 RVA: 0x00619B74 File Offset: 0x00617D74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Power(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Power);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D16 RID: 93462 RVA: 0x00619BC8 File Offset: 0x00617DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Power(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int power;
			LuaObject.checkType(l, 2, out power);
			configDataSkillInfo.Power = power;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D17 RID: 93463 RVA: 0x00619C20 File Offset: 0x00617E20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackDistance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.AttackDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D18 RID: 93464 RVA: 0x00619C74 File Offset: 0x00617E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AttackDistance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int attackDistance;
			LuaObject.checkType(l, 2, out attackDistance);
			configDataSkillInfo.AttackDistance = attackDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D19 RID: 93465 RVA: 0x00619CCC File Offset: 0x00617ECC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HitCountMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.HitCountMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D1A RID: 93466 RVA: 0x00619D20 File Offset: 0x00617F20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HitCountMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int hitCountMax;
			LuaObject.checkType(l, 2, out hitCountMax);
			configDataSkillInfo.HitCountMax = hitCountMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D1B RID: 93467 RVA: 0x00619D78 File Offset: 0x00617F78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.AttackCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D1C RID: 93468 RVA: 0x00619DCC File Offset: 0x00617FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AttackCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int attackCount;
			LuaObject.checkType(l, 2, out attackCount);
			configDataSkillInfo.AttackCount = attackCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D1D RID: 93469 RVA: 0x00619E24 File Offset: 0x00618024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Time_NextAttack(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Time_NextAttack);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D1E RID: 93470 RVA: 0x00619E78 File Offset: 0x00618078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Time_NextAttack(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int time_NextAttack;
			LuaObject.checkType(l, 2, out time_NextAttack);
			configDataSkillInfo.Time_NextAttack = time_NextAttack;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D1F RID: 93471 RVA: 0x00619ED0 File Offset: 0x006180D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Buffs_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Buffs_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D20 RID: 93472 RVA: 0x00619F24 File Offset: 0x00618124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BuffRate(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.BuffRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D21 RID: 93473 RVA: 0x00619F78 File Offset: 0x00618178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BuffRate(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int buffRate;
			LuaObject.checkType(l, 2, out buffRate);
			configDataSkillInfo.BuffRate = buffRate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D22 RID: 93474 RVA: 0x00619FD0 File Offset: 0x006181D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BuffNum(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.BuffNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D23 RID: 93475 RVA: 0x0061A024 File Offset: 0x00618224
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BuffNum(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int buffNum;
			LuaObject.checkType(l, 2, out buffNum);
			configDataSkillInfo.BuffNum = buffNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D24 RID: 93476 RVA: 0x0061A07C File Offset: 0x0061827C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroMoveDelay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.HeroMoveDelay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D25 RID: 93477 RVA: 0x0061A0D0 File Offset: 0x006182D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroMoveDelay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int heroMoveDelay;
			LuaObject.checkType(l, 2, out heroMoveDelay);
			configDataSkillInfo.HeroMoveDelay = heroMoveDelay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D26 RID: 93478 RVA: 0x0061A128 File Offset: 0x00618328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Time_EffCast1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Time_EffCast1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D27 RID: 93479 RVA: 0x0061A17C File Offset: 0x0061837C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Time_EffCast1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int time_EffCast;
			LuaObject.checkType(l, 2, out time_EffCast);
			configDataSkillInfo.Time_EffCast1 = time_EffCast;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D28 RID: 93480 RVA: 0x0061A1D4 File Offset: 0x006183D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Time_EffCast2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Time_EffCast2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D29 RID: 93481 RVA: 0x0061A228 File Offset: 0x00618428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Time_EffCast2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int time_EffCast;
			LuaObject.checkType(l, 2, out time_EffCast);
			configDataSkillInfo.Time_EffCast2 = time_EffCast;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D2A RID: 93482 RVA: 0x0061A280 File Offset: 0x00618480
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Time_EffMagic1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Time_EffMagic1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D2B RID: 93483 RVA: 0x0061A2D4 File Offset: 0x006184D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Time_EffMagic1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int time_EffMagic;
			LuaObject.checkType(l, 2, out time_EffMagic);
			configDataSkillInfo.Time_EffMagic1 = time_EffMagic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D2C RID: 93484 RVA: 0x0061A32C File Offset: 0x0061852C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Time_EffMagic2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Time_EffMagic2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D2D RID: 93485 RVA: 0x0061A380 File Offset: 0x00618580
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Time_EffMagic2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int time_EffMagic;
			LuaObject.checkType(l, 2, out time_EffMagic);
			configDataSkillInfo.Time_EffMagic2 = time_EffMagic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D2E RID: 93486 RVA: 0x0061A3D8 File Offset: 0x006185D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Time_Hit(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Time_Hit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D2F RID: 93487 RVA: 0x0061A42C File Offset: 0x0061862C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Time_Hit(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int time_Hit;
			LuaObject.checkType(l, 2, out time_Hit);
			configDataSkillInfo.Time_Hit = time_Hit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D30 RID: 93488 RVA: 0x0061A484 File Offset: 0x00618684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Time_End(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Time_End);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D31 RID: 93489 RVA: 0x0061A4D8 File Offset: 0x006186D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Time_End(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int time_End;
			LuaObject.checkType(l, 2, out time_End);
			configDataSkillInfo.Time_End = time_End;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D32 RID: 93490 RVA: 0x0061A530 File Offset: 0x00618730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Time_MultiHit(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Time_MultiHit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D33 RID: 93491 RVA: 0x0061A584 File Offset: 0x00618784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Anim_Cast(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Anim_Cast);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D34 RID: 93492 RVA: 0x0061A5D8 File Offset: 0x006187D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Anim_Cast(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string anim_Cast;
			LuaObject.checkType(l, 2, out anim_Cast);
			configDataSkillInfo.Anim_Cast = anim_Cast;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D35 RID: 93493 RVA: 0x0061A630 File Offset: 0x00618830
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Effect_Sing(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Effect_Sing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D36 RID: 93494 RVA: 0x0061A684 File Offset: 0x00618884
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Effect_Sing(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string effect_Sing;
			LuaObject.checkType(l, 2, out effect_Sing);
			configDataSkillInfo.Effect_Sing = effect_Sing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D37 RID: 93495 RVA: 0x0061A6DC File Offset: 0x006188DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Effect_Cast1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Effect_Cast1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D38 RID: 93496 RVA: 0x0061A730 File Offset: 0x00618930
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Effect_Cast1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string effect_Cast;
			LuaObject.checkType(l, 2, out effect_Cast);
			configDataSkillInfo.Effect_Cast1 = effect_Cast;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D39 RID: 93497 RVA: 0x0061A788 File Offset: 0x00618988
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Effect_Cast1_Far(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Effect_Cast1_Far);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D3A RID: 93498 RVA: 0x0061A7DC File Offset: 0x006189DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Effect_Cast1_Far(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string effect_Cast1_Far;
			LuaObject.checkType(l, 2, out effect_Cast1_Far);
			configDataSkillInfo.Effect_Cast1_Far = effect_Cast1_Far;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D3B RID: 93499 RVA: 0x0061A834 File Offset: 0x00618A34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Effect_Cast2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Effect_Cast2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D3C RID: 93500 RVA: 0x0061A888 File Offset: 0x00618A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Effect_Cast2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string effect_Cast;
			LuaObject.checkType(l, 2, out effect_Cast);
			configDataSkillInfo.Effect_Cast2 = effect_Cast;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D3D RID: 93501 RVA: 0x0061A8E0 File Offset: 0x00618AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Effect_Cast2_Far(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Effect_Cast2_Far);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D3E RID: 93502 RVA: 0x0061A934 File Offset: 0x00618B34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Effect_Cast2_Far(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string effect_Cast2_Far;
			LuaObject.checkType(l, 2, out effect_Cast2_Far);
			configDataSkillInfo.Effect_Cast2_Far = effect_Cast2_Far;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D3F RID: 93503 RVA: 0x0061A98C File Offset: 0x00618B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Effect_Magic1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Effect_Magic1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D40 RID: 93504 RVA: 0x0061A9E0 File Offset: 0x00618BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Effect_Magic1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string effect_Magic;
			LuaObject.checkType(l, 2, out effect_Magic);
			configDataSkillInfo.Effect_Magic1 = effect_Magic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D41 RID: 93505 RVA: 0x0061AA38 File Offset: 0x00618C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Effect_Magic1_Far(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Effect_Magic1_Far);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D42 RID: 93506 RVA: 0x0061AA8C File Offset: 0x00618C8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Effect_Magic1_Far(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string effect_Magic1_Far;
			LuaObject.checkType(l, 2, out effect_Magic1_Far);
			configDataSkillInfo.Effect_Magic1_Far = effect_Magic1_Far;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D43 RID: 93507 RVA: 0x0061AAE4 File Offset: 0x00618CE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Effect_Magic2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Effect_Magic2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D44 RID: 93508 RVA: 0x0061AB38 File Offset: 0x00618D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Effect_Magic2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string effect_Magic;
			LuaObject.checkType(l, 2, out effect_Magic);
			configDataSkillInfo.Effect_Magic2 = effect_Magic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D45 RID: 93509 RVA: 0x0061AB90 File Offset: 0x00618D90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Effect_Magic2_Far(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Effect_Magic2_Far);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D46 RID: 93510 RVA: 0x0061ABE4 File Offset: 0x00618DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Effect_Magic2_Far(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string effect_Magic2_Far;
			LuaObject.checkType(l, 2, out effect_Magic2_Far);
			configDataSkillInfo.Effect_Magic2_Far = effect_Magic2_Far;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D47 RID: 93511 RVA: 0x0061AC3C File Offset: 0x00618E3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Effect_Hit(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Effect_Hit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D48 RID: 93512 RVA: 0x0061AC90 File Offset: 0x00618E90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Effect_Hit(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string effect_Hit;
			LuaObject.checkType(l, 2, out effect_Hit);
			configDataSkillInfo.Effect_Hit = effect_Hit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D49 RID: 93513 RVA: 0x0061ACE8 File Offset: 0x00618EE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Effect_PreCast(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Effect_PreCast);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D4A RID: 93514 RVA: 0x0061AD3C File Offset: 0x00618F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Effect_PreCast(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string effect_PreCast;
			LuaObject.checkType(l, 2, out effect_PreCast);
			configDataSkillInfo.Effect_PreCast = effect_PreCast;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D4B RID: 93515 RVA: 0x0061AD94 File Offset: 0x00618F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CutsceneType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.CutsceneType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D4C RID: 93516 RVA: 0x0061ADE8 File Offset: 0x00618FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CutsceneType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int cutsceneType;
			LuaObject.checkType(l, 2, out cutsceneType);
			configDataSkillInfo.CutsceneType = cutsceneType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D4D RID: 93517 RVA: 0x0061AE40 File Offset: 0x00619040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DeadAnimType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.DeadAnimType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D4E RID: 93518 RVA: 0x0061AE94 File Offset: 0x00619094
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DeadAnimType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int deadAnimType;
			LuaObject.checkType(l, 2, out deadAnimType);
			configDataSkillInfo.DeadAnimType = deadAnimType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D4F RID: 93519 RVA: 0x0061AEEC File Offset: 0x006190EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BF_InitCooldown(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.BF_InitCooldown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D50 RID: 93520 RVA: 0x0061AF40 File Offset: 0x00619140
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BF_InitCooldown(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int bf_InitCooldown;
			LuaObject.checkType(l, 2, out bf_InitCooldown);
			configDataSkillInfo.BF_InitCooldown = bf_InitCooldown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D51 RID: 93521 RVA: 0x0061AF98 File Offset: 0x00619198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BF_Cooldown(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.BF_Cooldown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D52 RID: 93522 RVA: 0x0061AFEC File Offset: 0x006191EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BF_Cooldown(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int bf_Cooldown;
			LuaObject.checkType(l, 2, out bf_Cooldown);
			configDataSkillInfo.BF_Cooldown = bf_Cooldown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D53 RID: 93523 RVA: 0x0061B044 File Offset: 0x00619244
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BF_Distance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.BF_Distance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D54 RID: 93524 RVA: 0x0061B098 File Offset: 0x00619298
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BF_Distance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int bf_Distance;
			LuaObject.checkType(l, 2, out bf_Distance);
			configDataSkillInfo.BF_Distance = bf_Distance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D55 RID: 93525 RVA: 0x0061B0F0 File Offset: 0x006192F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BF_Range(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.BF_Range);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D56 RID: 93526 RVA: 0x0061B144 File Offset: 0x00619344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BF_Range(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int bf_Range;
			LuaObject.checkType(l, 2, out bf_Range);
			configDataSkillInfo.BF_Range = bf_Range;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D57 RID: 93527 RVA: 0x0061B19C File Offset: 0x0061939C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BF_RangeShape(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.BF_RangeShape);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D58 RID: 93528 RVA: 0x0061B1F0 File Offset: 0x006193F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BF_RangeShape(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int bf_RangeShape;
			LuaObject.checkType(l, 2, out bf_RangeShape);
			configDataSkillInfo.BF_RangeShape = bf_RangeShape;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D59 RID: 93529 RVA: 0x0061B248 File Offset: 0x00619448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BF_TargetFaction(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataSkillInfo.BF_TargetFaction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D5A RID: 93530 RVA: 0x0061B29C File Offset: 0x0061949C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BF_TargetFaction(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			SkillTargetType bf_TargetFaction;
			LuaObject.checkEnum<SkillTargetType>(l, 2, out bf_TargetFaction);
			configDataSkillInfo.BF_TargetFaction = bf_TargetFaction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D5B RID: 93531 RVA: 0x0061B2F4 File Offset: 0x006194F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BF_TargetType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataSkillInfo.BF_TargetType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D5C RID: 93532 RVA: 0x0061B348 File Offset: 0x00619548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BF_TargetType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			SkillTargetType bf_TargetType;
			LuaObject.checkEnum<SkillTargetType>(l, 2, out bf_TargetType);
			configDataSkillInfo.BF_TargetType = bf_TargetType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D5D RID: 93533 RVA: 0x0061B3A0 File Offset: 0x006195A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CastSkillShape(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.CastSkillShape);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D5E RID: 93534 RVA: 0x0061B3F4 File Offset: 0x006195F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CastSkillShape(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int castSkillShape;
			LuaObject.checkType(l, 2, out castSkillShape);
			configDataSkillInfo.CastSkillShape = castSkillShape;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D5F RID: 93535 RVA: 0x0061B44C File Offset: 0x0061964C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D60 RID: 93536 RVA: 0x0061B4A0 File Offset: 0x006196A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataSkillInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D61 RID: 93537 RVA: 0x0061B4F8 File Offset: 0x006196F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SkillCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.SkillCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D62 RID: 93538 RVA: 0x0061B54C File Offset: 0x0061974C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SkillCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int skillCost;
			LuaObject.checkType(l, 2, out skillCost);
			configDataSkillInfo.SkillCost = skillCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D63 RID: 93539 RVA: 0x0061B5A4 File Offset: 0x006197A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TypeText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.TypeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D64 RID: 93540 RVA: 0x0061B5F8 File Offset: 0x006197F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TypeText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string typeText;
			LuaObject.checkType(l, 2, out typeText);
			configDataSkillInfo.TypeText = typeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D65 RID: 93541 RVA: 0x0061B650 File Offset: 0x00619850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CDText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.CDText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D66 RID: 93542 RVA: 0x0061B6A4 File Offset: 0x006198A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CDText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string cdtext;
			LuaObject.checkType(l, 2, out cdtext);
			configDataSkillInfo.CDText = cdtext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D67 RID: 93543 RVA: 0x0061B6FC File Offset: 0x006198FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DistanceText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.DistanceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D68 RID: 93544 RVA: 0x0061B750 File Offset: 0x00619950
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DistanceText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string distanceText;
			LuaObject.checkType(l, 2, out distanceText);
			configDataSkillInfo.DistanceText = distanceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D69 RID: 93545 RVA: 0x0061B7A8 File Offset: 0x006199A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RangeText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.RangeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D6A RID: 93546 RVA: 0x0061B7FC File Offset: 0x006199FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RangeText(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			string rangeText;
			LuaObject.checkType(l, 2, out rangeText);
			configDataSkillInfo.RangeText = rangeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D6B RID: 93547 RVA: 0x0061B854 File Offset: 0x00619A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePower(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSkillInfo.BattlePower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D6C RID: 93548 RVA: 0x0061B8A8 File Offset: 0x00619AA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattlePower(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSkillInfo configDataSkillInfo = (ConfigDataSkillInfo)LuaObject.checkSelf(l);
			int battlePower;
			LuaObject.checkType(l, 2, out battlePower);
			configDataSkillInfo.BattlePower = battlePower;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D6D RID: 93549 RVA: 0x0061B900 File Offset: 0x00619B00
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataSkillInfo");
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.IsNormalAttack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.IsBattlefieldSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1);
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.IsDamageSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2);
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.IsPhysicalDamageSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3);
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.IsMagicDamageSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4);
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.IsHealSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5);
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.IsBuffSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6);
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.IsSummonSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7);
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.IsTeleportSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8);
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.IsPassiveSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache9);
		string name = "m_buffInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_m_buffInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_m_buffInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheB, true);
		string name2 = "m_passiveBuffInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_m_passiveBuffInfos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_m_passiveBuffInfos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheD, true);
		string name3 = "m_selfBuffInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_m_selfBuffInfos);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_m_selfBuffInfos);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cacheF, true);
		string name4 = "m_isNormalAttack";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_m_isNormalAttack);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_m_isNormalAttack);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache11, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache13, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache15, true);
		string name7 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_NameStrKey);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache17, true);
		string name8 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Desc);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Desc);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache19, true);
		string name9 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_DescStrKey);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1B, true);
		string name10 = "IsMagic";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_IsMagic);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_IsMagic);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1D, true);
		string name11 = "IsActiveSkill";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_IsActiveSkill);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_IsActiveSkill);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache1F, true);
		string name12 = "IsRangeSkill";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_IsRangeSkill);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_IsRangeSkill);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache21, true);
		string name13 = "AIIsRangeSkill";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_AIIsRangeSkill);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_AIIsRangeSkill);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache23, true);
		string name14 = "IsNewTurn";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_IsNewTurn);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_IsNewTurn);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache25, true);
		string name15 = "LimitArmys_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_LimitArmys_ID);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache26, null, true);
		string name16 = "PassiveBuffs_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_PassiveBuffs_ID);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache27, null, true);
		string name17 = "SelfBuffs_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_SelfBuffs_ID);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache28, null, true);
		string name18 = "SkillAIType";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_SkillAIType);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_SkillAIType);
		}
		LuaObject.addMember(l, name18, get15, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2A, true);
		string name19 = "SkillType";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_SkillType);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_SkillType);
		}
		LuaObject.addMember(l, name19, get16, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2C, true);
		string name20 = "SkillTypeParam1";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_SkillTypeParam1);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2D;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_SkillTypeParam1);
		}
		LuaObject.addMember(l, name20, get17, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2E, true);
		string name21 = "SkillTypeParam2";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_SkillTypeParam2);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_SkillTypeParam2);
		}
		LuaObject.addMember(l, name21, get18, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache30, true);
		string name22 = "SkillTypeParam3";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_SkillTypeParam3);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache31;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_SkillTypeParam3);
		}
		LuaObject.addMember(l, name22, get19, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache32, true);
		string name23 = "Time_Sing";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Time_Sing);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache33;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Time_Sing);
		}
		LuaObject.addMember(l, name23, get20, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache34, true);
		string name24 = "Power";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Power);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache35;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Power);
		}
		LuaObject.addMember(l, name24, get21, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache36, true);
		string name25 = "AttackDistance";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_AttackDistance);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache37;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_AttackDistance);
		}
		LuaObject.addMember(l, name25, get22, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache38, true);
		string name26 = "HitCountMax";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_HitCountMax);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache39;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_HitCountMax);
		}
		LuaObject.addMember(l, name26, get23, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3A, true);
		string name27 = "AttackCount";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_AttackCount);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3B;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_AttackCount);
		}
		LuaObject.addMember(l, name27, get24, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3C, true);
		string name28 = "Time_NextAttack";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Time_NextAttack);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3D;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Time_NextAttack);
		}
		LuaObject.addMember(l, name28, get25, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3E, true);
		string name29 = "Buffs_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Buffs_ID);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache3F, null, true);
		string name30 = "BuffRate";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_BuffRate);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache40;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_BuffRate);
		}
		LuaObject.addMember(l, name30, get26, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache41, true);
		string name31 = "BuffNum";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_BuffNum);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache42;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_BuffNum);
		}
		LuaObject.addMember(l, name31, get27, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache43, true);
		string name32 = "HeroMoveDelay";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_HeroMoveDelay);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache44;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_HeroMoveDelay);
		}
		LuaObject.addMember(l, name32, get28, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache45, true);
		string name33 = "Time_EffCast1";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Time_EffCast1);
		}
		LuaCSFunction get29 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache46;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Time_EffCast1);
		}
		LuaObject.addMember(l, name33, get29, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache47, true);
		string name34 = "Time_EffCast2";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Time_EffCast2);
		}
		LuaCSFunction get30 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache48;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Time_EffCast2);
		}
		LuaObject.addMember(l, name34, get30, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache49, true);
		string name35 = "Time_EffMagic1";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Time_EffMagic1);
		}
		LuaCSFunction get31 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4A;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Time_EffMagic1);
		}
		LuaObject.addMember(l, name35, get31, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4B, true);
		string name36 = "Time_EffMagic2";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Time_EffMagic2);
		}
		LuaCSFunction get32 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4C;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Time_EffMagic2);
		}
		LuaObject.addMember(l, name36, get32, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4D, true);
		string name37 = "Time_Hit";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Time_Hit);
		}
		LuaCSFunction get33 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4E;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Time_Hit);
		}
		LuaObject.addMember(l, name37, get33, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache4F, true);
		string name38 = "Time_End";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Time_End);
		}
		LuaCSFunction get34 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache50;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Time_End);
		}
		LuaObject.addMember(l, name38, get34, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache51, true);
		string name39 = "Time_MultiHit";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Time_MultiHit);
		}
		LuaObject.addMember(l, name39, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache52, null, true);
		string name40 = "Anim_Cast";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Anim_Cast);
		}
		LuaCSFunction get35 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache53;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Anim_Cast);
		}
		LuaObject.addMember(l, name40, get35, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache54, true);
		string name41 = "Effect_Sing";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Effect_Sing);
		}
		LuaCSFunction get36 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache55;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Effect_Sing);
		}
		LuaObject.addMember(l, name41, get36, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache56, true);
		string name42 = "Effect_Cast1";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Effect_Cast1);
		}
		LuaCSFunction get37 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache57;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Effect_Cast1);
		}
		LuaObject.addMember(l, name42, get37, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache58, true);
		string name43 = "Effect_Cast1_Far";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Effect_Cast1_Far);
		}
		LuaCSFunction get38 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache59;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Effect_Cast1_Far);
		}
		LuaObject.addMember(l, name43, get38, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5A, true);
		string name44 = "Effect_Cast2";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Effect_Cast2);
		}
		LuaCSFunction get39 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5B;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Effect_Cast2);
		}
		LuaObject.addMember(l, name44, get39, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5C, true);
		string name45 = "Effect_Cast2_Far";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Effect_Cast2_Far);
		}
		LuaCSFunction get40 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5D;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Effect_Cast2_Far);
		}
		LuaObject.addMember(l, name45, get40, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5E, true);
		string name46 = "Effect_Magic1";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Effect_Magic1);
		}
		LuaCSFunction get41 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache5F;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Effect_Magic1);
		}
		LuaObject.addMember(l, name46, get41, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache60, true);
		string name47 = "Effect_Magic1_Far";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Effect_Magic1_Far);
		}
		LuaCSFunction get42 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache61;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Effect_Magic1_Far);
		}
		LuaObject.addMember(l, name47, get42, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache62, true);
		string name48 = "Effect_Magic2";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Effect_Magic2);
		}
		LuaCSFunction get43 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache63;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Effect_Magic2);
		}
		LuaObject.addMember(l, name48, get43, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache64, true);
		string name49 = "Effect_Magic2_Far";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Effect_Magic2_Far);
		}
		LuaCSFunction get44 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache65;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Effect_Magic2_Far);
		}
		LuaObject.addMember(l, name49, get44, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache66, true);
		string name50 = "Effect_Hit";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Effect_Hit);
		}
		LuaCSFunction get45 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache67;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Effect_Hit);
		}
		LuaObject.addMember(l, name50, get45, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache68, true);
		string name51 = "Effect_PreCast";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Effect_PreCast);
		}
		LuaCSFunction get46 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache69;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Effect_PreCast);
		}
		LuaObject.addMember(l, name51, get46, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6A, true);
		string name52 = "CutsceneType";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_CutsceneType);
		}
		LuaCSFunction get47 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6B;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_CutsceneType);
		}
		LuaObject.addMember(l, name52, get47, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6C, true);
		string name53 = "DeadAnimType";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_DeadAnimType);
		}
		LuaCSFunction get48 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6D;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_DeadAnimType);
		}
		LuaObject.addMember(l, name53, get48, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6E, true);
		string name54 = "BF_InitCooldown";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_BF_InitCooldown);
		}
		LuaCSFunction get49 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache6F;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_BF_InitCooldown);
		}
		LuaObject.addMember(l, name54, get49, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache70, true);
		string name55 = "BF_Cooldown";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_BF_Cooldown);
		}
		LuaCSFunction get50 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache71;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_BF_Cooldown);
		}
		LuaObject.addMember(l, name55, get50, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache72, true);
		string name56 = "BF_Distance";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_BF_Distance);
		}
		LuaCSFunction get51 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache73;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_BF_Distance);
		}
		LuaObject.addMember(l, name56, get51, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache74, true);
		string name57 = "BF_Range";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_BF_Range);
		}
		LuaCSFunction get52 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache75;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_BF_Range);
		}
		LuaObject.addMember(l, name57, get52, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache76, true);
		string name58 = "BF_RangeShape";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_BF_RangeShape);
		}
		LuaCSFunction get53 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache77;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_BF_RangeShape);
		}
		LuaObject.addMember(l, name58, get53, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache78, true);
		string name59 = "BF_TargetFaction";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_BF_TargetFaction);
		}
		LuaCSFunction get54 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache79;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_BF_TargetFaction);
		}
		LuaObject.addMember(l, name59, get54, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7A, true);
		string name60 = "BF_TargetType";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_BF_TargetType);
		}
		LuaCSFunction get55 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7B;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_BF_TargetType);
		}
		LuaObject.addMember(l, name60, get55, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7C, true);
		string name61 = "CastSkillShape";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_CastSkillShape);
		}
		LuaCSFunction get56 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7D;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_CastSkillShape);
		}
		LuaObject.addMember(l, name61, get56, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7E, true);
		string name62 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_Icon);
		}
		LuaCSFunction get57 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache7F;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_Icon);
		}
		LuaObject.addMember(l, name62, get57, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache80, true);
		string name63 = "SkillCost";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_SkillCost);
		}
		LuaCSFunction get58 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache81;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_SkillCost);
		}
		LuaObject.addMember(l, name63, get58, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache82, true);
		string name64 = "TypeText";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_TypeText);
		}
		LuaCSFunction get59 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache83;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_TypeText);
		}
		LuaObject.addMember(l, name64, get59, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache84, true);
		string name65 = "CDText";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_CDText);
		}
		LuaCSFunction get60 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache85;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_CDText);
		}
		LuaObject.addMember(l, name65, get60, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache86, true);
		string name66 = "DistanceText";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_DistanceText);
		}
		LuaCSFunction get61 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache87;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_DistanceText);
		}
		LuaObject.addMember(l, name66, get61, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache88, true);
		string name67 = "RangeText";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_RangeText);
		}
		LuaCSFunction get62 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache89;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_RangeText);
		}
		LuaObject.addMember(l, name67, get62, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8A, true);
		string name68 = "BattlePower";
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.get_BattlePower);
		}
		LuaCSFunction get63 = Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8B;
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.set_BattlePower);
		}
		LuaObject.addMember(l, name68, get63, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8C, true);
		if (Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSkillInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataSkillInfo.<>f__mg$cache8D, typeof(ConfigDataSkillInfo));
	}

	// Token: 0x0400D3ED RID: 54253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D3EE RID: 54254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D3EF RID: 54255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D3F0 RID: 54256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D3F1 RID: 54257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D3F2 RID: 54258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D3F3 RID: 54259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D3F4 RID: 54260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D3F5 RID: 54261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D3F6 RID: 54262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D3F7 RID: 54263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D3F8 RID: 54264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D3F9 RID: 54265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D3FA RID: 54266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D3FB RID: 54267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D3FC RID: 54268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D3FD RID: 54269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D3FE RID: 54270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D3FF RID: 54271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D400 RID: 54272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D401 RID: 54273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D402 RID: 54274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D403 RID: 54275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D404 RID: 54276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D405 RID: 54277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D406 RID: 54278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D407 RID: 54279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D408 RID: 54280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D409 RID: 54281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D40A RID: 54282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D40B RID: 54283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D40C RID: 54284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D40D RID: 54285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D40E RID: 54286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D40F RID: 54287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D410 RID: 54288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D411 RID: 54289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D412 RID: 54290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D413 RID: 54291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D414 RID: 54292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D415 RID: 54293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D416 RID: 54294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D417 RID: 54295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D418 RID: 54296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D419 RID: 54297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D41A RID: 54298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D41B RID: 54299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D41C RID: 54300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D41D RID: 54301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D41E RID: 54302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D41F RID: 54303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D420 RID: 54304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D421 RID: 54305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D422 RID: 54306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D423 RID: 54307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D424 RID: 54308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400D425 RID: 54309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400D426 RID: 54310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400D427 RID: 54311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400D428 RID: 54312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400D429 RID: 54313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400D42A RID: 54314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400D42B RID: 54315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400D42C RID: 54316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400D42D RID: 54317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400D42E RID: 54318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400D42F RID: 54319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400D430 RID: 54320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400D431 RID: 54321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400D432 RID: 54322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400D433 RID: 54323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400D434 RID: 54324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400D435 RID: 54325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400D436 RID: 54326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400D437 RID: 54327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400D438 RID: 54328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400D439 RID: 54329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400D43A RID: 54330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400D43B RID: 54331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400D43C RID: 54332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400D43D RID: 54333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400D43E RID: 54334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400D43F RID: 54335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400D440 RID: 54336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400D441 RID: 54337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400D442 RID: 54338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400D443 RID: 54339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400D444 RID: 54340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400D445 RID: 54341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400D446 RID: 54342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400D447 RID: 54343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400D448 RID: 54344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400D449 RID: 54345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400D44A RID: 54346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400D44B RID: 54347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400D44C RID: 54348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400D44D RID: 54349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400D44E RID: 54350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400D44F RID: 54351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400D450 RID: 54352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400D451 RID: 54353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400D452 RID: 54354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400D453 RID: 54355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400D454 RID: 54356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400D455 RID: 54357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400D456 RID: 54358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400D457 RID: 54359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400D458 RID: 54360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400D459 RID: 54361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400D45A RID: 54362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400D45B RID: 54363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400D45C RID: 54364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400D45D RID: 54365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400D45E RID: 54366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400D45F RID: 54367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400D460 RID: 54368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400D461 RID: 54369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400D462 RID: 54370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400D463 RID: 54371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0400D464 RID: 54372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0400D465 RID: 54373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0400D466 RID: 54374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0400D467 RID: 54375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0400D468 RID: 54376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0400D469 RID: 54377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0400D46A RID: 54378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0400D46B RID: 54379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0400D46C RID: 54380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0400D46D RID: 54381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0400D46E RID: 54382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0400D46F RID: 54383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0400D470 RID: 54384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0400D471 RID: 54385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0400D472 RID: 54386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0400D473 RID: 54387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0400D474 RID: 54388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0400D475 RID: 54389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0400D476 RID: 54390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0400D477 RID: 54391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0400D478 RID: 54392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0400D479 RID: 54393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0400D47A RID: 54394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;
}
