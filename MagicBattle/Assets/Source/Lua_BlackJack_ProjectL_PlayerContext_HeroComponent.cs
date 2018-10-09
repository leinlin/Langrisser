using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012CB RID: 4811
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_HeroComponent : LuaObject
{
	// Token: 0x06019543 RID: 103747 RVA: 0x00744F44 File Offset: 0x00743144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent o = new HeroComponent();
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

	// Token: 0x06019544 RID: 103748 RVA: 0x00744F8C File Offset: 0x0074318C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019545 RID: 103749 RVA: 0x00744FD8 File Offset: 0x007431D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019546 RID: 103750 RVA: 0x00745024 File Offset: 0x00743224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019547 RID: 103751 RVA: 0x00745070 File Offset: 0x00743270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			DSHeroNtf msg;
			LuaObject.checkType<DSHeroNtf>(l, 2, out msg);
			heroComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019548 RID: 103752 RVA: 0x007450C8 File Offset: 0x007432C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InteractHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int addFavorabilityExp;
			LuaObject.checkType(l, 3, out addFavorabilityExp);
			heroComponent.InteractHero(heroId, addFavorabilityExp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019549 RID: 103753 RVA: 0x0074512C File Offset: 0x0074332C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroInteractionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ConfigDataHeroInteractionInfo heroInteractionInfo = heroComponent.GetHeroInteractionInfo(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroInteractionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601954A RID: 103754 RVA: 0x00745190 File Offset: 0x00743390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroInteractHeroPerformanceId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			HeroInteractionResultType resultType;
			LuaObject.checkEnum<HeroInteractionResultType>(l, 3, out resultType);
			int heroInteractHeroPerformanceId = heroComponent.GetHeroInteractHeroPerformanceId(heroId, resultType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroInteractHeroPerformanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601954B RID: 103755 RVA: 0x00745200 File Offset: 0x00743400
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanUnlockHeroPerformance(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroPerformanceId;
			LuaObject.checkType(l, 2, out heroPerformanceId);
			int i = heroComponent.CanUnlockHeroPerformance(heroPerformanceId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601954C RID: 103756 RVA: 0x00745264 File Offset: 0x00743464
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanUnlockHeroBiography(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int biographyId;
			LuaObject.checkType(l, 2, out biographyId);
			int i = heroComponent.CanUnlockHeroBiography(biographyId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601954D RID: 103757 RVA: 0x007452C8 File Offset: 0x007434C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			ushort dsversion = heroComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601954E RID: 103758 RVA: 0x0074531C File Offset: 0x0074351C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetWearedEquipmentHeroIdByEquipmentId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			ulong equipmentId;
			LuaObject.checkType(l, 2, out equipmentId);
			int wearedEquipmentHeroIdByEquipmentId = heroComponent.GetWearedEquipmentHeroIdByEquipmentId(equipmentId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, wearedEquipmentHeroIdByEquipmentId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601954F RID: 103759 RVA: 0x00745380 File Offset: 0x00743580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroInteractNums(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroInteractNums = heroComponent.GetHeroInteractNums();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroInteractNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019550 RID: 103760 RVA: 0x007453D4 File Offset: 0x007435D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHeroInteractNumsFlushTime(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			DateTime heroInteractNumsFlushTime = heroComponent.GetHeroInteractNumsFlushTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroInteractNumsFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019551 RID: 103761 RVA: 0x00745430 File Offset: 0x00743630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ImitateUseHeroFavorabilityExpItem(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int itemId;
			LuaObject.checkType(l, 3, out itemId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 5, out goodsType);
			int i = heroComponent.ImitateUseHeroFavorabilityExpItem(heroId, itemId, nums, goodsType);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019552 RID: 103762 RVA: 0x007454B8 File Offset: 0x007436B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AutoEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			List<ulong> equipmentInstanceIds;
			LuaObject.checkType<List<ulong>>(l, 3, out equipmentInstanceIds);
			int i = heroComponent.AutoEquipment(heroId, equipmentInstanceIds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019553 RID: 103763 RVA: 0x00745528 File Offset: 0x00743728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.m_luaExportHelper.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019554 RID: 103764 RVA: 0x0074557C File Offset: 0x0074377C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			string s = heroComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x06019555 RID: 103765 RVA: 0x007455D8 File Offset: 0x007437D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019556 RID: 103766 RVA: 0x0074562C File Offset: 0x0074382C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019557 RID: 103767 RVA: 0x00745680 File Offset: 0x00743880
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019558 RID: 103768 RVA: 0x007456D4 File Offset: 0x007438D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			heroComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019559 RID: 103769 RVA: 0x00745730 File Offset: 0x00743930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601955A RID: 103770 RVA: 0x00745784 File Offset: 0x00743984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetProtagonistID(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int i = heroComponent.m_luaExportHelper.__callBase_GetProtagonistID();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601955B RID: 103771 RVA: 0x007457E0 File Offset: 0x007439E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsProtagonistHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsProtagonistHero(heroId);
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

	// Token: 0x0601955C RID: 103772 RVA: 0x00745848 File Offset: 0x00743A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsProtagonistExist(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsProtagonistExist();
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

	// Token: 0x0601955D RID: 103773 RVA: 0x007458A4 File Offset: 0x00743AA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetProtagonist(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int protagonistId;
			LuaObject.checkType(l, 2, out protagonistId);
			int i = heroComponent.m_luaExportHelper.__callBase_SetProtagonist(protagonistId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601955E RID: 103774 RVA: 0x0074590C File Offset: 0x00743B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllStarLvlMaxHeroes(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			List<Hero> o = heroComponent.m_luaExportHelper.__callBase_GetAllStarLvlMaxHeroes();
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

	// Token: 0x0601955F RID: 103775 RVA: 0x00745968 File Offset: 0x00743B68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllStarLvlMaxHeroFragments(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			List<HeroFragmentBagItem> o = heroComponent.m_luaExportHelper.__callBase_GetAllStarLvlMaxHeroFragments();
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

	// Token: 0x06019560 RID: 103776 RVA: 0x007459C4 File Offset: 0x00743BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitHeroDataByCaculate(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroComponent.m_luaExportHelper.__callBase_InitHeroDataByCaculate(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019561 RID: 103777 RVA: 0x00745A20 File Offset: 0x00743C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanHeroJobEquipSkill(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int jobRelatedId;
			LuaObject.checkType(l, 2, out jobRelatedId);
			int skillId;
			LuaObject.checkType(l, 3, out skillId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanHeroJobEquipSkill(jobRelatedId, skillId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019562 RID: 103778 RVA: 0x00745A94 File Offset: 0x00743C94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanSelectSkillHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			List<int> skills;
			LuaObject.checkType<List<int>>(l, 3, out skills);
			int i = heroComponent.m_luaExportHelper.__callBase_CanSelectSkillHero(hero, skills);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019563 RID: 103779 RVA: 0x00745B08 File Offset: 0x00743D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SelectSkills(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			List<int> skills;
			LuaObject.checkType<List<int>>(l, 3, out skills);
			int i = heroComponent.m_luaExportHelper.__callBase_SelectSkills(heroId, skills);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019564 RID: 103780 RVA: 0x00745B7C File Offset: 0x00743D7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SelectSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			int i = heroComponent.m_luaExportHelper.__callBase_SelectSoldier(heroId, soldierId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019565 RID: 103781 RVA: 0x00745BF0 File Offset: 0x00743DF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanHeroSelectSolider(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int soliderId;
			LuaObject.checkType(l, 3, out soliderId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanHeroSelectSolider(hero, soliderId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019566 RID: 103782 RVA: 0x00745C64 File Offset: 0x00743E64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RemoveHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_RemoveHero(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019567 RID: 103783 RVA: 0x00745CCC File Offset: 0x00743ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RemoveAllHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			List<int> changedHeroIdList;
			LuaObject.checkType<List<int>>(l, 2, out changedHeroIdList);
			heroComponent.m_luaExportHelper.__callBase_RemoveAllHero(changedHeroIdList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019568 RID: 103784 RVA: 0x00745D28 File Offset: 0x00743F28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RemoveAllHeros(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.m_luaExportHelper.__callBase_RemoveAllHeros();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019569 RID: 103785 RVA: 0x00745D7C File Offset: 0x00743F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllHeros(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			List<Hero> o = heroComponent.m_luaExportHelper.__callBase_GetAllHeros();
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

	// Token: 0x0601956A RID: 103786 RVA: 0x00745DD8 File Offset: 0x00743FD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FindHeroJob(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(int)))
			{
				HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
				int heroId;
				LuaObject.checkType(l, 2, out heroId);
				int jobRelatedId;
				LuaObject.checkType(l, 3, out jobRelatedId);
				HeroJob o = heroComponent.m_luaExportHelper.__callBase_FindHeroJob(heroId, jobRelatedId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Hero), typeof(int)))
			{
				HeroComponent heroComponent2 = (HeroComponent)LuaObject.checkSelf(l);
				Hero hero;
				LuaObject.checkType<Hero>(l, 2, out hero);
				int jobRelatedId2;
				LuaObject.checkType(l, 3, out jobRelatedId2);
				HeroJob o2 = heroComponent2.m_luaExportHelper.__callBase_FindHeroJob(hero, jobRelatedId2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_FindHeroJob to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601956B RID: 103787 RVA: 0x00745EFC File Offset: 0x007440FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsUnlockedHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsUnlockedHeroJob(hero, jobRelatedId);
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

	// Token: 0x0601956C RID: 103788 RVA: 0x00745F70 File Offset: 0x00744170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FindHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			Hero o = heroComponent.m_luaExportHelper.__callBase_FindHero(heroId);
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

	// Token: 0x0601956D RID: 103789 RVA: 0x00745FD8 File Offset: 0x007441D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddHeroFightNums(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			int i = heroComponent.m_luaExportHelper.__callBase_AddHeroFightNums(heroId, nums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601956E RID: 103790 RVA: 0x0074604C File Offset: 0x0074424C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddHeroAllNeedJobsAchievements(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			List<int> achievements;
			LuaObject.checkType<List<int>>(l, 3, out achievements);
			int i = heroComponent.m_luaExportHelper.__callBase_AddHeroAllNeedJobsAchievements(heroId, achievements);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601956F RID: 103791 RVA: 0x007460C0 File Offset: 0x007442C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_AddHero(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019570 RID: 103792 RVA: 0x00746128 File Offset: 0x00744328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsWastefulAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int addExp;
			LuaObject.checkType(l, 3, out addExp);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsWastefulAddExp(hero, addExp);
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

	// Token: 0x06019571 RID: 103793 RVA: 0x0074619C File Offset: 0x0074439C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsCurrentLevelMaxHeroLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroLevel;
			LuaObject.checkType(l, 2, out heroLevel);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsCurrentLevelMaxHeroLevel(heroLevel);
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

	// Token: 0x06019572 RID: 103794 RVA: 0x00746204 File Offset: 0x00744404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsFullCurrentHeroExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsFullCurrentHeroExp(hero);
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

	// Token: 0x06019573 RID: 103795 RVA: 0x0074626C File Offset: 0x0074446C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddHeroesExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			int exp;
			LuaObject.checkType(l, 3, out exp);
			heroComponent.m_luaExportHelper.__callBase_AddHeroesExp(heroIds, exp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019574 RID: 103796 RVA: 0x007462D8 File Offset: 0x007444D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAddHeroExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanAddHeroExp(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019575 RID: 103797 RVA: 0x00746340 File Offset: 0x00744540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddHeroExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int exp;
			LuaObject.checkType(l, 3, out exp);
			int i = heroComponent.m_luaExportHelper.__callBase_AddHeroExp(heroId, exp);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019576 RID: 103798 RVA: 0x007463B4 File Offset: 0x007445B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OutPutHeroLevelUpOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int currentLevel;
			LuaObject.checkType(l, 3, out currentLevel);
			heroComponent.m_luaExportHelper.__callBase_OutPutHeroLevelUpOperateLog(heroId, currentLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019577 RID: 103799 RVA: 0x00746420 File Offset: 0x00744620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddHeroExpByUseableBagItem(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 3, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 4, out contentId);
			int consumeNums;
			LuaObject.checkType(l, 5, out consumeNums);
			int i = heroComponent.m_luaExportHelper.__callBase_AddHeroExpByUseableBagItem(heroId, goodsTypeId, contentId, consumeNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019578 RID: 103800 RVA: 0x007464B0 File Offset: 0x007446B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ComposeHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_ComposeHero(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019579 RID: 103801 RVA: 0x00746518 File Offset: 0x00744718
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsLvlMaxHeroStar(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsLvlMaxHeroStar(hero);
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

	// Token: 0x0601957A RID: 103802 RVA: 0x00746580 File Offset: 0x00744780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LevelUpHeroStarLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_LevelUpHeroStarLevel(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601957B RID: 103803 RVA: 0x007465E8 File Offset: 0x007447E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OutPutHeroUpgradeOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int currentStar;
			LuaObject.checkType(l, 3, out currentStar);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 4, out costItems);
			heroComponent.m_luaExportHelper.__callBase_OutPutHeroUpgradeOperateLog(heroId, currentStar, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601957C RID: 103804 RVA: 0x00746660 File Offset: 0x00744860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetGainHeroIds(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			HashSet<int> o = heroComponent.m_luaExportHelper.__callBase_GetGainHeroIds();
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

	// Token: 0x0601957D RID: 103805 RVA: 0x007466BC File Offset: 0x007448BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_HasGainHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool b = heroComponent.m_luaExportHelper.__callBase_HasGainHero(heroId);
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

	// Token: 0x0601957E RID: 103806 RVA: 0x00746724 File Offset: 0x00744924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsExistSkillId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int skillId;
			LuaObject.checkType(l, 2, out skillId);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsExistSkillId(skillId);
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

	// Token: 0x0601957F RID: 103807 RVA: 0x0074678C File Offset: 0x0074498C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsExistSoliderId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int soliderId;
			LuaObject.checkType(l, 2, out soliderId);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsExistSoliderId(soliderId);
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

	// Token: 0x06019580 RID: 103808 RVA: 0x007467F4 File Offset: 0x007449F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FindTopLevelHeroes(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int topNums;
			LuaObject.checkType(l, 2, out topNums);
			LinkedList<Hero> o = heroComponent.m_luaExportHelper.__callBase_FindTopLevelHeroes(topNums);
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

	// Token: 0x06019581 RID: 103809 RVA: 0x0074685C File Offset: 0x00744A5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetActiveHeroJobRelatedIdByHeroId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_GetActiveHeroJobRelatedIdByHeroId(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019582 RID: 103810 RVA: 0x007468C4 File Offset: 0x00744AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GmResetHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_GmResetHeroJob(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019583 RID: 103811 RVA: 0x0074692C File Offset: 0x00744B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnHeroLevelUp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int oldLevel;
			LuaObject.checkType(l, 2, out oldLevel);
			Hero hero;
			LuaObject.checkType<Hero>(l, 3, out hero);
			heroComponent.m_luaExportHelper.__callBase_OnHeroLevelUp(oldLevel, hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019584 RID: 103812 RVA: 0x00746998 File Offset: 0x00744B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAdditiveHeroAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int addExp;
			LuaObject.checkType(l, 2, out addExp);
			int i = heroComponent.m_luaExportHelper.__callBase_GetAdditiveHeroAddExp(addExp);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019585 RID: 103813 RVA: 0x00746A00 File Offset: 0x00744C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAdditiveHeroFavourabilityAddExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int addExp;
			LuaObject.checkType(l, 2, out addExp);
			int i = heroComponent.m_luaExportHelper.__callBase_GetAdditiveHeroFavourabilityAddExp(addExp);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019586 RID: 103814 RVA: 0x00746A68 File Offset: 0x00744C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddHeroJobAchievementsAfterBattleLevelEnd(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			List<int> relatedAchievements;
			LuaObject.checkType<List<int>>(l, 2, out relatedAchievements);
			List<int> fightHeroes;
			LuaObject.checkType<List<int>>(l, 3, out fightHeroes);
			heroComponent.m_luaExportHelper.__callBase_AddHeroJobAchievementsAfterBattleLevelEnd(relatedAchievements, fightHeroes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019587 RID: 103815 RVA: 0x00746AD4 File Offset: 0x00744CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsJobLevelMax(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
				HeroJob job;
				LuaObject.checkType<HeroJob>(l, 2, out job);
				bool b = heroComponent.m_luaExportHelper.__callBase_IsJobLevelMax(job);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				HeroComponent heroComponent2 = (HeroComponent)LuaObject.checkSelf(l);
				ConfigDataJobConnectionInfo jobConnectionInfo;
				LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
				int jobLevel;
				LuaObject.checkType(l, 3, out jobLevel);
				bool b2 = heroComponent2.m_luaExportHelper.__callBase_IsJobLevelMax(jobConnectionInfo, jobLevel);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_IsJobLevelMax to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019588 RID: 103816 RVA: 0x00746BB8 File Offset: 0x00744DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanLevelUpHeroJobLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanLevelUpHeroJobLevel(heroId, jobRelatedId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019589 RID: 103817 RVA: 0x00746C2C File Offset: 0x00744E2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanTransferHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanTransferHeroJob(heroId, jobRelatedId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601958A RID: 103818 RVA: 0x00746CA0 File Offset: 0x00744EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TransferHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponent.m_luaExportHelper.__callBase_TransferHeroJob(heroId, jobRelatedId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601958B RID: 103819 RVA: 0x00746D14 File Offset: 0x00744F14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OutPutHeroJobChangeOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int preJobConnectionId;
			LuaObject.checkType(l, 3, out preJobConnectionId);
			int postJobConnectionId;
			LuaObject.checkType(l, 4, out postJobConnectionId);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 5, out costItems);
			heroComponent.m_luaExportHelper.__callBase_OutPutHeroJobChangeOperateLog(heroId, preJobConnectionId, postJobConnectionId, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601958C RID: 103820 RVA: 0x00746D98 File Offset: 0x00744F98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsNeedUnlock(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsNeedUnlock(jobConnectionInfo);
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

	// Token: 0x0601958D RID: 103821 RVA: 0x00746E00 File Offset: 0x00745000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnlockedHeroJob(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponent.m_luaExportHelper.__callBase_UnlockedHeroJob(heroId, jobRelatedId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601958E RID: 103822 RVA: 0x00746E74 File Offset: 0x00745074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OutPutHeroJobUnlockOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int activeJobId;
			LuaObject.checkType(l, 3, out activeJobId);
			int unlockJobId;
			LuaObject.checkType(l, 4, out unlockJobId);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 5, out costItems);
			heroComponent.m_luaExportHelper.__callBase_OutPutHeroJobUnlockOperateLog(heroId, activeJobId, unlockJobId, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601958F RID: 103823 RVA: 0x00746EF8 File Offset: 0x007450F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LevelUpHeroJobLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponent.m_luaExportHelper.__callBase_LevelUpHeroJobLevel(heroId, jobRelatedId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019590 RID: 103824 RVA: 0x00746F6C File Offset: 0x0074516C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OutPutHeroJobLevelUpOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int activeJobId;
			LuaObject.checkType(l, 3, out activeJobId);
			int currentLevel;
			LuaObject.checkType(l, 4, out currentLevel);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 5, out costItems);
			heroComponent.m_luaExportHelper.__callBase_OutPutHeroJobLevelUpOperateLog(heroId, activeJobId, currentLevel, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019591 RID: 103825 RVA: 0x00746FF0 File Offset: 0x007451F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			bool needExchange;
			LuaObject.checkType(l, 4, out needExchange);
			heroComponent.m_luaExportHelper.__callBase_AddSoldier(hero, soldierId, needExchange);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019592 RID: 103826 RVA: 0x00747068 File Offset: 0x00745268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AutoTakeOffEquipments(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_AutoTakeOffEquipments(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019593 RID: 103827 RVA: 0x007470D0 File Offset: 0x007452D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitWearedEquipments(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.m_luaExportHelper.__callBase_InitWearedEquipments();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019594 RID: 103828 RVA: 0x00747124 File Offset: 0x00745324
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanWearEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong instanceId;
			LuaObject.checkType(l, 3, out instanceId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanWearEquipment(heroId, instanceId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019595 RID: 103829 RVA: 0x00747198 File Offset: 0x00745398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanWearEquipmentByJobAndArmy(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			BagItemBase equipment;
			LuaObject.checkType<BagItemBase>(l, 3, out equipment);
			int i = heroComponent.m_luaExportHelper.__callBase_CanWearEquipmentByJobAndArmy(hero, equipment);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019596 RID: 103830 RVA: 0x0074720C File Offset: 0x0074540C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsEquipmentWeared(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsEquipmentWeared(instanceId);
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

	// Token: 0x06019597 RID: 103831 RVA: 0x00747274 File Offset: 0x00745474
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetWearedEquipmentHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			Hero o = heroComponent.m_luaExportHelper.__callBase_GetWearedEquipmentHero(instanceId);
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

	// Token: 0x06019598 RID: 103832 RVA: 0x007472DC File Offset: 0x007454DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_WearEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong instanceId;
			LuaObject.checkType(l, 3, out instanceId);
			int i = heroComponent.m_luaExportHelper.__callBase_WearEquipment(heroId, instanceId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019599 RID: 103833 RVA: 0x00747350 File Offset: 0x00745550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_WearEquipmentBySlot(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			ulong instanceId;
			LuaObject.checkType(l, 4, out instanceId);
			heroComponent.m_luaExportHelper.__callBase_WearEquipmentBySlot(hero, slot, instanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601959A RID: 103834 RVA: 0x007473C8 File Offset: 0x007455C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanTakeOffEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			int i = heroComponent.m_luaExportHelper.__callBase_CanTakeOffEquipment(heroId, slot);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601959B RID: 103835 RVA: 0x0074743C File Offset: 0x0074563C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TakeOffEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			int i = heroComponent.m_luaExportHelper.__callBase_TakeOffEquipment(heroId, slot);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601959C RID: 103836 RVA: 0x007474B0 File Offset: 0x007456B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_HasBetterEquipmentByHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool b = heroComponent.m_luaExportHelper.__callBase_HasBetterEquipmentByHero(heroId);
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

	// Token: 0x0601959D RID: 103837 RVA: 0x00747518 File Offset: 0x00745718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasBetterEquipmentBySlotId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int slotId;
			LuaObject.checkType(l, 3, out slotId);
			bool b = heroComponent.m_luaExportHelper.__callBase_HasBetterEquipmentBySlotId(heroId, slotId);
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

	// Token: 0x0601959E RID: 103838 RVA: 0x0074758C File Offset: 0x0074578C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetWearedEquipmentBySlotId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int slotId;
			LuaObject.checkType(l, 3, out slotId);
			BagItemBase o = heroComponent.m_luaExportHelper.__callBase_GetWearedEquipmentBySlotId(hero, slotId);
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

	// Token: 0x0601959F RID: 103839 RVA: 0x00747600 File Offset: 0x00745800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsBetterEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			BagItemBase wearedEquipment;
			LuaObject.checkType<BagItemBase>(l, 2, out wearedEquipment);
			BagItemBase compareEquipment;
			LuaObject.checkType<BagItemBase>(l, 3, out compareEquipment);
			int slotId;
			LuaObject.checkType(l, 4, out slotId);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsBetterEquipment(wearedEquipment, compareEquipment, slotId);
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

	// Token: 0x060195A0 RID: 103840 RVA: 0x00747684 File Offset: 0x00745884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAutoEquipmentByClient(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanAutoEquipmentByClient(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195A1 RID: 103841 RVA: 0x007476EC File Offset: 0x007458EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAutoEquipment(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanAutoEquipment(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195A2 RID: 103842 RVA: 0x00747754 File Offset: 0x00745954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanWearCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int charSkinId;
			LuaObject.checkType(l, 3, out charSkinId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanWearCharSkin(heroId, charSkinId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195A3 RID: 103843 RVA: 0x007477C8 File Offset: 0x007459C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_WearCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int charSkinId;
			LuaObject.checkType(l, 3, out charSkinId);
			int i = heroComponent.m_luaExportHelper.__callBase_WearCharSkin(heroId, charSkinId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195A4 RID: 103844 RVA: 0x0074783C File Offset: 0x00745A3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanTakeOffCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanTakeOffCharSkin(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195A5 RID: 103845 RVA: 0x007478A4 File Offset: 0x00745AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TakeOffCharSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_TakeOffCharSkin(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195A6 RID: 103846 RVA: 0x0074790C File Offset: 0x00745B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanWearModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int modelSkinId;
			LuaObject.checkType(l, 4, out modelSkinId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanWearModelSkin(heroId, jobRelatedId, modelSkinId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195A7 RID: 103847 RVA: 0x00747990 File Offset: 0x00745B90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_WearModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int modelSkinId;
			LuaObject.checkType(l, 4, out modelSkinId);
			int i = heroComponent.m_luaExportHelper.__callBase_WearModelSkin(heroId, jobRelatedId, modelSkinId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195A8 RID: 103848 RVA: 0x00747A14 File Offset: 0x00745C14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanTakeOffModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanTakeOffModelSkin(heroId, jobRelatedId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195A9 RID: 103849 RVA: 0x00747A88 File Offset: 0x00745C88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_TakeOffModelSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int jobRelatedId;
			LuaObject.checkType(l, 3, out jobRelatedId);
			int i = heroComponent.m_luaExportHelper.__callBase_TakeOffModelSkin(heroId, jobRelatedId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195AA RID: 103850 RVA: 0x00747AFC File Offset: 0x00745CFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanWearSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			int soldierSkinId;
			LuaObject.checkType(l, 4, out soldierSkinId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanWearSoldierSkin(heroId, soldierId, soldierSkinId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195AB RID: 103851 RVA: 0x00747B80 File Offset: 0x00745D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_WearSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			int soldierSkinId;
			LuaObject.checkType(l, 4, out soldierSkinId);
			bool applyToAll;
			LuaObject.checkType(l, 5, out applyToAll);
			int i = heroComponent.m_luaExportHelper.__callBase_WearSoldierSkin(heroId, soldierId, soldierSkinId, applyToAll);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195AC RID: 103852 RVA: 0x00747C10 File Offset: 0x00745E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanTakeOffSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanTakeOffSoldierSkin(heroId, soldierId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195AD RID: 103853 RVA: 0x00747C84 File Offset: 0x00745E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TakeOffSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int soldierId;
			LuaObject.checkType(l, 3, out soldierId);
			bool applyToAll;
			LuaObject.checkType(l, 4, out applyToAll);
			int i = heroComponent.m_luaExportHelper.__callBase_TakeOffSoldierSkin(heroId, soldierId, applyToAll);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195AE RID: 103854 RVA: 0x00747D08 File Offset: 0x00745F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TakeOffSoldierSkinApplyToAll(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int soldierId;
			LuaObject.checkType(l, 2, out soldierId);
			int skinId;
			LuaObject.checkType(l, 3, out skinId);
			heroComponent.m_luaExportHelper.__callBase_TakeOffSoldierSkinApplyToAll(soldierId, skinId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195AF RID: 103855 RVA: 0x00747D74 File Offset: 0x00745F74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddHeroFavorabilityExpByUseableBagItem(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 3, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 4, out contentId);
			int consumeNums;
			LuaObject.checkType(l, 5, out consumeNums);
			int i = heroComponent.m_luaExportHelper.__callBase_AddHeroFavorabilityExpByUseableBagItem(heroId, goodsTypeId, contentId, consumeNums);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195B0 RID: 103856 RVA: 0x00747E04 File Offset: 0x00746004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddHeroFavorabilityLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int addExp;
			LuaObject.checkType(l, 3, out addExp);
			int i = heroComponent.m_luaExportHelper.__callBase_AddHeroFavorabilityLevel(heroId, addExp);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195B1 RID: 103857 RVA: 0x00747E78 File Offset: 0x00746078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OutPutHeroFavourabilityOperateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int oldLvl;
			LuaObject.checkType(l, 3, out oldLvl);
			int oldExp;
			LuaObject.checkType(l, 4, out oldExp);
			int newLvl;
			LuaObject.checkType(l, 5, out newLvl);
			int newExp;
			LuaObject.checkType(l, 6, out newExp);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 7, out rewards);
			heroComponent.m_luaExportHelper.__callBase_OutPutHeroFavourabilityOperateLog(heroId, oldLvl, oldExp, newLvl, newExp, rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195B2 RID: 103858 RVA: 0x00747F14 File Offset: 0x00746114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GenerateFavorabilityLevelUpReward(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int dropId;
			LuaObject.checkType(l, 3, out dropId);
			heroComponent.m_luaExportHelper.__callBase_GenerateFavorabilityLevelUpReward(heroId, dropId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195B3 RID: 103859 RVA: 0x00747F80 File Offset: 0x00746180
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsFullFavorabilityExp(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataHeroInformationInfo heroInformationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 3, out heroInformationInfo);
			bool b = heroComponent.m_luaExportHelper.__callBase_IsFullFavorabilityExp(hero, heroInformationInfo);
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

	// Token: 0x060195B4 RID: 103860 RVA: 0x00747FF4 File Offset: 0x007461F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UpdateProtagonistHeroFavorabilityLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.m_luaExportHelper.__callBase_UpdateProtagonistHeroFavorabilityLevel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195B5 RID: 103861 RVA: 0x00748048 File Offset: 0x00746248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanUnlockHeroFetter(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanUnlockHeroFetter(heroId, fetterId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195B6 RID: 103862 RVA: 0x007480BC File Offset: 0x007462BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanReachFetterUnlockCondition(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			HeroFetterCompletionCondition condition;
			LuaObject.checkType<HeroFetterCompletionCondition>(l, 2, out condition);
			int i = heroComponent.m_luaExportHelper.__callBase_CanReachFetterUnlockCondition(condition);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195B7 RID: 103863 RVA: 0x00748124 File Offset: 0x00746324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GmLevelUpHeroFetter2SpecificLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			int reachLevel;
			LuaObject.checkType(l, 4, out reachLevel);
			int i = heroComponent.m_luaExportHelper.__callBase_GmLevelUpHeroFetter2SpecificLevel(heroId, fetterId, reachLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195B8 RID: 103864 RVA: 0x007481A8 File Offset: 0x007463A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanLevelUpHeroFetter(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanLevelUpHeroFetter(heroId, fetterId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195B9 RID: 103865 RVA: 0x0074821C File Offset: 0x0074641C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LevelUpHeroFetter(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			int i = heroComponent.m_luaExportHelper.__callBase_LevelUpHeroFetter(heroId, fetterId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195BA RID: 103866 RVA: 0x00748290 File Offset: 0x00746490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LevelUpHeroFetterCallBack(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			heroComponent.m_luaExportHelper.__callBase_LevelUpHeroFetterCallBack(hero, fetterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195BB RID: 103867 RVA: 0x007482FC File Offset: 0x007464FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OutPutHeroFetterOpereateLog(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			int currentLvl;
			LuaObject.checkType(l, 4, out currentLvl);
			List<Goods> itemCost;
			LuaObject.checkType<List<Goods>>(l, 5, out itemCost);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 6, out rewards);
			heroComponent.m_luaExportHelper.__callBase_OutPutHeroFetterOpereateLog(heroId, fetterId, currentLvl, itemCost, rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195BC RID: 103868 RVA: 0x0074838C File Offset: 0x0074658C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UnlockHeroFetter(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			bool check;
			LuaObject.checkType(l, 4, out check);
			int i = heroComponent.m_luaExportHelper.__callBase_UnlockHeroFetter(heroId, fetterId, check);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195BD RID: 103869 RVA: 0x00748410 File Offset: 0x00746610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GenerateFetterUnlockRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int fetterId;
			LuaObject.checkType(l, 3, out fetterId);
			heroComponent.m_luaExportHelper.__callBase_GenerateFetterUnlockRewards(heroId, fetterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195BE RID: 103870 RVA: 0x0074847C File Offset: 0x0074667C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ConfessHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool check;
			LuaObject.checkType(l, 3, out check);
			int i = heroComponent.m_luaExportHelper.__callBase_ConfessHero(heroId, check);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195BF RID: 103871 RVA: 0x007484F0 File Offset: 0x007466F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GenerateConfessionRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int herId;
			LuaObject.checkType(l, 2, out herId);
			ConfigDataHeroConfessionInfo confessionInfo;
			LuaObject.checkType<ConfigDataHeroConfessionInfo>(l, 3, out confessionInfo);
			heroComponent.m_luaExportHelper.__callBase_GenerateConfessionRewards(herId, confessionInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195C0 RID: 103872 RVA: 0x0074855C File Offset: 0x0074675C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanConfessHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanConfessHero(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195C1 RID: 103873 RVA: 0x007485C4 File Offset: 0x007467C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InitHeroInteractNums(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			heroComponent.m_luaExportHelper.__callBase_InitHeroInteractNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195C2 RID: 103874 RVA: 0x00748618 File Offset: 0x00746818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddHeroInteractNums(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int addNums;
			LuaObject.checkType(l, 2, out addNums);
			bool recoveryByTime;
			LuaObject.checkType(l, 3, out recoveryByTime);
			heroComponent.m_luaExportHelper.__callBase_AddHeroInteractNums(addNums, recoveryByTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195C3 RID: 103875 RVA: 0x00748684 File Offset: 0x00746884
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanInteractHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanInteractHero(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195C4 RID: 103876 RVA: 0x007486EC File Offset: 0x007468EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetHeroFavorabilityUpLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataHeroInformationInfo heroInformationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 3, out heroInformationInfo);
			int addExp;
			LuaObject.checkType(l, 4, out addExp);
			int i = heroComponent.m_luaExportHelper.__callBase_GetHeroFavorabilityUpLevel(hero, heroInformationInfo, addExp);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195C5 RID: 103877 RVA: 0x00748770 File Offset: 0x00746970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetHeroInteractId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			ConfigDataHeroInformationInfo heroInformationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 3, out heroInformationInfo);
			int i = heroComponent.m_luaExportHelper.__callBase_GetHeroInteractId(hero, heroInformationInfo);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195C6 RID: 103878 RVA: 0x007487E4 File Offset: 0x007469E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int i = heroComponent.m_luaExportHelper.__callBase_GetAllHeroBattlePower();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195C7 RID: 103879 RVA: 0x00748840 File Offset: 0x00746A40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetLastAllHeroRank(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int i = heroComponent.m_luaExportHelper.__callBase_GetLastAllHeroRank();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195C8 RID: 103880 RVA: 0x0074889C File Offset: 0x00746A9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetTopHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int i = heroComponent.m_luaExportHelper.__callBase_GetTopHeroBattlePower();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195C9 RID: 103881 RVA: 0x007488F8 File Offset: 0x00746AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetLastTopHeroRank(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int i = heroComponent.m_luaExportHelper.__callBase_GetLastTopHeroRank();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195CA RID: 103882 RVA: 0x00748954 File Offset: 0x00746B54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetChampionHeroBattlePower(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int i = heroComponent.m_luaExportHelper.__callBase_GetChampionHeroBattlePower();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195CB RID: 103883 RVA: 0x007489B0 File Offset: 0x00746BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetChampionHeroId(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int i = heroComponent.m_luaExportHelper.__callBase_GetChampionHeroId();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195CC RID: 103884 RVA: 0x00748A0C File Offset: 0x00746C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetLastChampionHeroRank(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int i = heroComponent.m_luaExportHelper.__callBase_GetLastChampionHeroRank();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195CD RID: 103885 RVA: 0x00748A68 File Offset: 0x00746C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ComputeBattlePower(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			bool b = heroComponent.m_luaExportHelper.__callBase_ComputeBattlePower(hero);
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

	// Token: 0x060195CE RID: 103886 RVA: 0x00748AD0 File Offset: 0x00746CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnHeroBattlePowerChange(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroComponent.m_luaExportHelper.__callBase_OnHeroBattlePowerChange(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195CF RID: 103887 RVA: 0x00748B2C File Offset: 0x00746D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanComposeHero(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanComposeHero(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195D0 RID: 103888 RVA: 0x00748B94 File Offset: 0x00746D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanLevelUpHeroStarLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = heroComponent.m_luaExportHelper.__callBase_CanLevelUpHeroStarLevel(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195D1 RID: 103889 RVA: 0x00748BFC File Offset: 0x00746DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetEquipedEquipments(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			List<ulong> o = heroComponent.m_luaExportHelper.__callBase_GetEquipedEquipments();
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

	// Token: 0x060195D2 RID: 103890 RVA: 0x00748C58 File Offset: 0x00746E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetSkillEnergyFromConfig(IntPtr l)
	{
		int result;
		try
		{
			HeroComponent heroComponent = (HeroComponent)LuaObject.checkSelf(l);
			int heroLevel;
			LuaObject.checkType(l, 2, out heroLevel);
			int i = heroComponent.m_luaExportHelper.__callBase_GetSkillEnergyFromConfig(heroLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060195D3 RID: 103891 RVA: 0x00748CC0 File Offset: 0x00746EC0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.HeroComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.InteractHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.GetHeroInteractionInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.GetHeroInteractHeroPerformanceId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.CanUnlockHeroPerformance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.CanUnlockHeroBiography);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.GetWearedEquipmentHeroIdByEquipmentId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.GetHeroInteractNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.GetHeroInteractNumsFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.ImitateUseHeroFavorabilityExpItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.AutoEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetProtagonistID);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsProtagonistHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsProtagonistExist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_SetProtagonist);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetAllStarLvlMaxHeroes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetAllStarLvlMaxHeroFragments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_InitHeroDataByCaculate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanHeroJobEquipSkill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanSelectSkillHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_SelectSkills);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_SelectSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanHeroSelectSolider);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_RemoveHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_RemoveAllHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_RemoveAllHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetAllHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_FindHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsUnlockedHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_FindHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AddHeroFightNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AddHeroAllNeedJobsAchievements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AddHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsWastefulAddExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsCurrentLevelMaxHeroLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsFullCurrentHeroExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AddHeroesExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanAddHeroExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AddHeroExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_OutPutHeroLevelUpOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AddHeroExpByUseableBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_ComposeHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsLvlMaxHeroStar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_LevelUpHeroStarLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_OutPutHeroUpgradeOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetGainHeroIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_HasGainHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsExistSkillId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsExistSoliderId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_FindTopLevelHeroes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetActiveHeroJobRelatedIdByHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GmResetHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_OnHeroLevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetAdditiveHeroAddExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetAdditiveHeroFavourabilityAddExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AddHeroJobAchievementsAfterBattleLevelEnd);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsJobLevelMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanLevelUpHeroJobLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanTransferHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_TransferHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_OutPutHeroJobChangeOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsNeedUnlock);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_UnlockedHeroJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_OutPutHeroJobUnlockOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_LevelUpHeroJobLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_OutPutHeroJobLevelUpOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AddSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AutoTakeOffEquipments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4E);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_InitWearedEquipments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache4F);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanWearEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache50);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanWearEquipmentByJobAndArmy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache51);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsEquipmentWeared);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache52);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetWearedEquipmentHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache53);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_WearEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache54);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_WearEquipmentBySlot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache55);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanTakeOffEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache56);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_TakeOffEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache57);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_HasBetterEquipmentByHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache58);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_HasBetterEquipmentBySlotId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache59);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetWearedEquipmentBySlotId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5A);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsBetterEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5B);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanAutoEquipmentByClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5C);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanAutoEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5D);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanWearCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5E);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_WearCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache5F);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanTakeOffCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache60);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_TakeOffCharSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache61);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanWearModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache62);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_WearModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache63);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanTakeOffModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache64);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_TakeOffModelSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache65);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanWearSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache66);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_WearSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache67);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanTakeOffSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache68);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_TakeOffSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache69);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_TakeOffSoldierSkinApplyToAll);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6A);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AddHeroFavorabilityExpByUseableBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6B);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AddHeroFavorabilityLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6C);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_OutPutHeroFavourabilityOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6D);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GenerateFavorabilityLevelUpReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6E);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_IsFullFavorabilityExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache6F);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_UpdateProtagonistHeroFavorabilityLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache70);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanUnlockHeroFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache71);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanReachFetterUnlockCondition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache72);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GmLevelUpHeroFetter2SpecificLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache73);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanLevelUpHeroFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache74);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_LevelUpHeroFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache75);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_LevelUpHeroFetterCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache76);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_OutPutHeroFetterOpereateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache77);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_UnlockHeroFetter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache78);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GenerateFetterUnlockRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache79);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_ConfessHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7A);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GenerateConfessionRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7B);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanConfessHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7C);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_InitHeroInteractNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7D);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_AddHeroInteractNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7E);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanInteractHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache7F);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetHeroFavorabilityUpLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache80);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetHeroInteractId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache81);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetAllHeroBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache82);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetLastAllHeroRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache83);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetTopHeroBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache84);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetLastTopHeroRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache85);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetChampionHeroBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache86);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetChampionHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache87);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetLastChampionHeroRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache88);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_ComputeBattlePower);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache89);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_OnHeroBattlePowerChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8A);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanComposeHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8B);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_CanLevelUpHeroStarLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8C);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetEquipedEquipments);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8D);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.__callBase_GetSkillEnergyFromConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8E);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_HeroComponent.<>f__mg$cache8F, typeof(HeroComponent), typeof(HeroComponentCommon));
	}

	// Token: 0x0400F98F RID: 63887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F990 RID: 63888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F991 RID: 63889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F992 RID: 63890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F993 RID: 63891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F994 RID: 63892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F995 RID: 63893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F996 RID: 63894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F997 RID: 63895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F998 RID: 63896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F999 RID: 63897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F99A RID: 63898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F99B RID: 63899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F99C RID: 63900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F99D RID: 63901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F99E RID: 63902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F99F RID: 63903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F9A0 RID: 63904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F9A1 RID: 63905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F9A2 RID: 63906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F9A3 RID: 63907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F9A4 RID: 63908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F9A5 RID: 63909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F9A6 RID: 63910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F9A7 RID: 63911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F9A8 RID: 63912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F9A9 RID: 63913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F9AA RID: 63914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F9AB RID: 63915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F9AC RID: 63916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F9AD RID: 63917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F9AE RID: 63918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F9AF RID: 63919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F9B0 RID: 63920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F9B1 RID: 63921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F9B2 RID: 63922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F9B3 RID: 63923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F9B4 RID: 63924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F9B5 RID: 63925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F9B6 RID: 63926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F9B7 RID: 63927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F9B8 RID: 63928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F9B9 RID: 63929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F9BA RID: 63930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F9BB RID: 63931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F9BC RID: 63932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F9BD RID: 63933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F9BE RID: 63934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F9BF RID: 63935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F9C0 RID: 63936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F9C1 RID: 63937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F9C2 RID: 63938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F9C3 RID: 63939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400F9C4 RID: 63940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400F9C5 RID: 63941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400F9C6 RID: 63942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400F9C7 RID: 63943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400F9C8 RID: 63944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400F9C9 RID: 63945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400F9CA RID: 63946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400F9CB RID: 63947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400F9CC RID: 63948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400F9CD RID: 63949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400F9CE RID: 63950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400F9CF RID: 63951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400F9D0 RID: 63952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400F9D1 RID: 63953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400F9D2 RID: 63954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400F9D3 RID: 63955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400F9D4 RID: 63956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400F9D5 RID: 63957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400F9D6 RID: 63958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400F9D7 RID: 63959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400F9D8 RID: 63960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400F9D9 RID: 63961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400F9DA RID: 63962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400F9DB RID: 63963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400F9DC RID: 63964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400F9DD RID: 63965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400F9DE RID: 63966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400F9DF RID: 63967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400F9E0 RID: 63968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400F9E1 RID: 63969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400F9E2 RID: 63970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400F9E3 RID: 63971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400F9E4 RID: 63972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400F9E5 RID: 63973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400F9E6 RID: 63974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400F9E7 RID: 63975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400F9E8 RID: 63976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400F9E9 RID: 63977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400F9EA RID: 63978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400F9EB RID: 63979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400F9EC RID: 63980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400F9ED RID: 63981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400F9EE RID: 63982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400F9EF RID: 63983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400F9F0 RID: 63984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400F9F1 RID: 63985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400F9F2 RID: 63986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400F9F3 RID: 63987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400F9F4 RID: 63988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400F9F5 RID: 63989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400F9F6 RID: 63990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400F9F7 RID: 63991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400F9F8 RID: 63992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400F9F9 RID: 63993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400F9FA RID: 63994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400F9FB RID: 63995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400F9FC RID: 63996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400F9FD RID: 63997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400F9FE RID: 63998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400F9FF RID: 63999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400FA00 RID: 64000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400FA01 RID: 64001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400FA02 RID: 64002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400FA03 RID: 64003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400FA04 RID: 64004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400FA05 RID: 64005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0400FA06 RID: 64006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0400FA07 RID: 64007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0400FA08 RID: 64008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x0400FA09 RID: 64009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x0400FA0A RID: 64010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x0400FA0B RID: 64011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x0400FA0C RID: 64012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x0400FA0D RID: 64013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x0400FA0E RID: 64014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x0400FA0F RID: 64015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x0400FA10 RID: 64016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x0400FA11 RID: 64017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x0400FA12 RID: 64018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x0400FA13 RID: 64019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x0400FA14 RID: 64020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x0400FA15 RID: 64021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x0400FA16 RID: 64022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x0400FA17 RID: 64023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x0400FA18 RID: 64024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x0400FA19 RID: 64025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x0400FA1A RID: 64026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0400FA1B RID: 64027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0400FA1C RID: 64028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0400FA1D RID: 64029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0400FA1E RID: 64030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;
}
