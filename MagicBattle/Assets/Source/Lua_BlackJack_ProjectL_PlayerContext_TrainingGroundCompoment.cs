using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012E6 RID: 4838
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment : LuaObject
{
	// Token: 0x0601A0CC RID: 106700 RVA: 0x007A5C74 File Offset: 0x007A3E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment o = new TrainingGroundCompoment();
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

	// Token: 0x0601A0CD RID: 106701 RVA: 0x007A5CBC File Offset: 0x007A3EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			trainingGroundCompoment.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0CE RID: 106702 RVA: 0x007A5D08 File Offset: 0x007A3F08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			trainingGroundCompoment.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0CF RID: 106703 RVA: 0x007A5D54 File Offset: 0x007A3F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			trainingGroundCompoment.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0D0 RID: 106704 RVA: 0x007A5DA0 File Offset: 0x007A3FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			DSTrainingGroundNtf ntf;
			LuaObject.checkType<DSTrainingGroundNtf>(l, 2, out ntf);
			trainingGroundCompoment.DeSerialize(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0D1 RID: 106705 RVA: 0x007A5DF8 File Offset: 0x007A3FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			ushort dsversion = trainingGroundCompoment.GetDSVersion();
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

	// Token: 0x0601A0D2 RID: 106706 RVA: 0x007A5E4C File Offset: 0x007A404C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			string s = trainingGroundCompoment.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x0601A0D3 RID: 106707 RVA: 0x007A5EA8 File Offset: 0x007A40A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			trainingGroundCompoment.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0D4 RID: 106708 RVA: 0x007A5EFC File Offset: 0x007A40FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			trainingGroundCompoment.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0D5 RID: 106709 RVA: 0x007A5F50 File Offset: 0x007A4150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			trainingGroundCompoment.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0D6 RID: 106710 RVA: 0x007A5FA4 File Offset: 0x007A41A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			trainingGroundCompoment.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0D7 RID: 106711 RVA: 0x007A6000 File Offset: 0x007A4200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			trainingGroundCompoment.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0D8 RID: 106712 RVA: 0x007A6054 File Offset: 0x007A4254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetTechMaxLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int i = trainingGroundCompoment.m_luaExportHelper.__callBase_GetTechMaxLevel(techId);
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

	// Token: 0x0601A0D9 RID: 106713 RVA: 0x007A60BC File Offset: 0x007A42BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsTechLocked(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			bool b = trainingGroundCompoment.m_luaExportHelper.__callBase_IsTechLocked(techId);
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

	// Token: 0x0601A0DA RID: 106714 RVA: 0x007A6124 File Offset: 0x007A4324
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanLevelup(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int deltaLevel;
			LuaObject.checkType(l, 3, out deltaLevel);
			bool b = trainingGroundCompoment.m_luaExportHelper.__callBase_CanLevelup(techId, deltaLevel);
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

	// Token: 0x0601A0DB RID: 106715 RVA: 0x007A6198 File Offset: 0x007A4398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetResourceRequirementsByLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int level;
			LuaObject.checkType(l, 3, out level);
			TrainingTechResourceRequirements o = trainingGroundCompoment.m_luaExportHelper.__callBase_GetResourceRequirementsByLevel(techId, level);
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

	// Token: 0x0601A0DC RID: 106716 RVA: 0x007A620C File Offset: 0x007A440C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetTechLevelupResourceRequirements(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int deltaLevel;
			LuaObject.checkType(l, 3, out deltaLevel);
			TrainingTechResourceRequirements o = trainingGroundCompoment.m_luaExportHelper.__callBase_GetTechLevelupResourceRequirements(techId, deltaLevel);
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

	// Token: 0x0601A0DD RID: 106717 RVA: 0x007A6280 File Offset: 0x007A4480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CheckTechLevelup(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int deltaLevel;
			LuaObject.checkType(l, 3, out deltaLevel);
			int i = trainingGroundCompoment.m_luaExportHelper.__callBase_CheckTechLevelup(techId, deltaLevel);
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

	// Token: 0x0601A0DE RID: 106718 RVA: 0x007A62F4 File Offset: 0x007A44F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TechLevelup(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int deltaLevel;
			LuaObject.checkType(l, 3, out deltaLevel);
			int i = trainingGroundCompoment.m_luaExportHelper.__callBase_TechLevelup(techId, deltaLevel);
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

	// Token: 0x0601A0DF RID: 106719 RVA: 0x007A6368 File Offset: 0x007A4568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddTechLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int deltaLevel;
			LuaObject.checkType(l, 3, out deltaLevel);
			bool noCheckAndCost;
			LuaObject.checkType(l, 4, out noCheckAndCost);
			trainingGroundCompoment.m_luaExportHelper.__callBase_AddTechLevel(techId, deltaLevel, noCheckAndCost);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0E0 RID: 106720 RVA: 0x007A63E0 File Offset: 0x007A45E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ApplyTrainingTechToHero(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
				Hero hero;
				LuaObject.checkType<Hero>(l, 2, out hero);
				trainingGroundCompoment.m_luaExportHelper.__callBase_ApplyTrainingTechToHero(hero);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				TrainingGroundCompoment trainingGroundCompoment2 = (TrainingGroundCompoment)LuaObject.checkSelf(l);
				Hero hero2;
				LuaObject.checkType<Hero>(l, 2, out hero2);
				TrainingTech tech;
				LuaObject.checkType<TrainingTech>(l, 3, out tech);
				trainingGroundCompoment2.m_luaExportHelper.__callBase_ApplyTrainingTechToHero(hero2, tech);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_ApplyTrainingTechToHero to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0E1 RID: 106721 RVA: 0x007A64AC File Offset: 0x007A46AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OutPutTeachnologyTreeOperateLog(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int courseId;
			LuaObject.checkType(l, 2, out courseId);
			int techId;
			LuaObject.checkType(l, 3, out techId);
			int currentLvl;
			LuaObject.checkType(l, 4, out currentLvl);
			List<Goods> itemGot;
			LuaObject.checkType<List<Goods>>(l, 5, out itemGot);
			List<Goods> itemCost;
			LuaObject.checkType<List<Goods>>(l, 6, out itemCost);
			trainingGroundCompoment.m_luaExportHelper.__callBase_OutPutTeachnologyTreeOperateLog(courseId, techId, currentLvl, itemGot, itemCost);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0E2 RID: 106722 RVA: 0x007A653C File Offset: 0x007A473C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAvailableTechs(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			List<TrainingTech> o = trainingGroundCompoment.m_luaExportHelper.__callBase_GetAvailableTechs();
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

	// Token: 0x0601A0E3 RID: 106723 RVA: 0x007A6598 File Offset: 0x007A4798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IterateAvailableTechInfos(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			IEnumerable<TrainingTechInfo> o = trainingGroundCompoment.m_luaExportHelper.__callBase_IterateAvailableTechInfos();
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

	// Token: 0x0601A0E4 RID: 106724 RVA: 0x007A65F4 File Offset: 0x007A47F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IterateAvailableTechs(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			IEnumerable<TrainingTech> o = trainingGroundCompoment.m_luaExportHelper.__callBase_IterateAvailableTechs();
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

	// Token: 0x0601A0E5 RID: 106725 RVA: 0x007A6650 File Offset: 0x007A4850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetTechLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int i = trainingGroundCompoment.m_luaExportHelper.__callBase_GetTechLevel(techId);
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

	// Token: 0x0601A0E6 RID: 106726 RVA: 0x007A66B8 File Offset: 0x007A48B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetTech(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			TrainingTech o = trainingGroundCompoment.m_luaExportHelper.__callBase_GetTech(techId);
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

	// Token: 0x0601A0E7 RID: 106727 RVA: 0x007A6720 File Offset: 0x007A4920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetRoom(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			TrainingRoom o = trainingGroundCompoment.m_luaExportHelper.__callBase_GetRoom(roomId);
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

	// Token: 0x0601A0E8 RID: 106728 RVA: 0x007A6788 File Offset: 0x007A4988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetSoldierSkillLevelBySoldierId(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompoment trainingGroundCompoment = (TrainingGroundCompoment)LuaObject.checkSelf(l);
			int soldierId;
			LuaObject.checkType(l, 2, out soldierId);
			int i = trainingGroundCompoment.m_luaExportHelper.__callBase_GetSoldierSkillLevelBySoldierId(soldierId);
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

	// Token: 0x0601A0E9 RID: 106729 RVA: 0x007A67F0 File Offset: 0x007A49F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.TrainingGroundCompoment");
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_GetTechMaxLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_IsTechLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_CanLevelup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_GetResourceRequirementsByLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_GetTechLevelupResourceRequirements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_CheckTechLevelup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_TechLevelup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_AddTechLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_ApplyTrainingTechToHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_OutPutTeachnologyTreeOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_GetAvailableTechs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_IterateAvailableTechInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_IterateAvailableTechs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_GetTechLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_GetTech);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_GetRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.__callBase_GetSoldierSkillLevelBySoldierId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_TrainingGroundCompoment.<>f__mg$cache1C, typeof(TrainingGroundCompoment), typeof(TrainingGroundCompomentCommon));
	}

	// Token: 0x040104E2 RID: 66786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040104E3 RID: 66787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040104E4 RID: 66788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040104E5 RID: 66789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040104E6 RID: 66790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040104E7 RID: 66791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040104E8 RID: 66792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040104E9 RID: 66793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040104EA RID: 66794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040104EB RID: 66795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040104EC RID: 66796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040104ED RID: 66797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040104EE RID: 66798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040104EF RID: 66799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040104F0 RID: 66800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040104F1 RID: 66801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040104F2 RID: 66802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040104F3 RID: 66803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040104F4 RID: 66804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040104F5 RID: 66805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040104F6 RID: 66806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040104F7 RID: 66807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040104F8 RID: 66808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040104F9 RID: 66809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040104FA RID: 66810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040104FB RID: 66811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040104FC RID: 66812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040104FD RID: 66813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040104FE RID: 66814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
