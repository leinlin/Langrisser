using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200128C RID: 4748
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon : LuaObject
{
	// Token: 0x06018BD0 RID: 101328 RVA: 0x006FEAEC File Offset: 0x006FCCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon o = new TrainingGroundCompomentCommon();
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

	// Token: 0x06018BD1 RID: 101329 RVA: 0x006FEB34 File Offset: 0x006FCD34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			string name = trainingGroundCompomentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BD2 RID: 101330 RVA: 0x006FEB88 File Offset: 0x006FCD88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			trainingGroundCompomentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BD3 RID: 101331 RVA: 0x006FEBD4 File Offset: 0x006FCDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			trainingGroundCompomentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BD4 RID: 101332 RVA: 0x006FEC20 File Offset: 0x006FCE20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			trainingGroundCompomentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BD5 RID: 101333 RVA: 0x006FEC6C File Offset: 0x006FCE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			trainingGroundCompomentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BD6 RID: 101334 RVA: 0x006FECC4 File Offset: 0x006FCEC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			trainingGroundCompomentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BD7 RID: 101335 RVA: 0x006FED10 File Offset: 0x006FCF10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTechMaxLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int techMaxLevel = trainingGroundCompomentCommon.GetTechMaxLevel(techId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, techMaxLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BD8 RID: 101336 RVA: 0x006FED74 File Offset: 0x006FCF74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsTechLocked(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			bool b = trainingGroundCompomentCommon.IsTechLocked(techId);
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

	// Token: 0x06018BD9 RID: 101337 RVA: 0x006FEDD8 File Offset: 0x006FCFD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanLevelup(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int deltaLevel;
			LuaObject.checkType(l, 3, out deltaLevel);
			bool b = trainingGroundCompomentCommon.CanLevelup(techId, deltaLevel);
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

	// Token: 0x06018BDA RID: 101338 RVA: 0x006FEE48 File Offset: 0x006FD048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetResourceRequirementsByLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int level;
			LuaObject.checkType(l, 3, out level);
			TrainingTechResourceRequirements resourceRequirementsByLevel = trainingGroundCompomentCommon.GetResourceRequirementsByLevel(techId, level);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resourceRequirementsByLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BDB RID: 101339 RVA: 0x006FEEB8 File Offset: 0x006FD0B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTechLevelupResourceRequirements(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int deltaLevel;
			LuaObject.checkType(l, 3, out deltaLevel);
			TrainingTechResourceRequirements techLevelupResourceRequirements = trainingGroundCompomentCommon.GetTechLevelupResourceRequirements(techId, deltaLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, techLevelupResourceRequirements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BDC RID: 101340 RVA: 0x006FEF28 File Offset: 0x006FD128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckTechLevelup(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int deltaLevel;
			LuaObject.checkType(l, 3, out deltaLevel);
			int i = trainingGroundCompomentCommon.CheckTechLevelup(techId, deltaLevel);
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

	// Token: 0x06018BDD RID: 101341 RVA: 0x006FEF98 File Offset: 0x006FD198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TechLevelup(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int deltaLevel;
			LuaObject.checkType(l, 3, out deltaLevel);
			int i = trainingGroundCompomentCommon.TechLevelup(techId, deltaLevel);
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

	// Token: 0x06018BDE RID: 101342 RVA: 0x006FF008 File Offset: 0x006FD208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTechLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int deltaLevel;
			LuaObject.checkType(l, 3, out deltaLevel);
			bool noCheckAndCost;
			LuaObject.checkType(l, 4, out noCheckAndCost);
			trainingGroundCompomentCommon.AddTechLevel(techId, deltaLevel, noCheckAndCost);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BDF RID: 101343 RVA: 0x006FF07C File Offset: 0x006FD27C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ApplyTrainingTechToHero(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
				Hero hero;
				LuaObject.checkType<Hero>(l, 2, out hero);
				trainingGroundCompomentCommon.ApplyTrainingTechToHero(hero);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				TrainingGroundCompomentCommon trainingGroundCompomentCommon2 = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
				Hero hero2;
				LuaObject.checkType<Hero>(l, 2, out hero2);
				TrainingTech tech;
				LuaObject.checkType<TrainingTech>(l, 3, out tech);
				trainingGroundCompomentCommon2.ApplyTrainingTechToHero(hero2, tech);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ApplyTrainingTechToHero to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BE0 RID: 101344 RVA: 0x006FF140 File Offset: 0x006FD340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAvailableTechs(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			List<TrainingTech> availableTechs = trainingGroundCompomentCommon.GetAvailableTechs();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, availableTechs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BE1 RID: 101345 RVA: 0x006FF194 File Offset: 0x006FD394
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IterateAvailableTechInfos(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			IEnumerable<TrainingTechInfo> o = trainingGroundCompomentCommon.IterateAvailableTechInfos();
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

	// Token: 0x06018BE2 RID: 101346 RVA: 0x006FF1E8 File Offset: 0x006FD3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IterateAvailableTechs(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			IEnumerable<TrainingTech> o = trainingGroundCompomentCommon.IterateAvailableTechs();
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

	// Token: 0x06018BE3 RID: 101347 RVA: 0x006FF23C File Offset: 0x006FD43C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTechLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int techLevel = trainingGroundCompomentCommon.GetTechLevel(techId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, techLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BE4 RID: 101348 RVA: 0x006FF2A0 File Offset: 0x006FD4A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTech(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			TrainingTech tech = trainingGroundCompomentCommon.GetTech(techId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, tech);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BE5 RID: 101349 RVA: 0x006FF304 File Offset: 0x006FD504
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRoom(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			TrainingRoom room = trainingGroundCompomentCommon.GetRoom(roomId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, room);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BE6 RID: 101350 RVA: 0x006FF368 File Offset: 0x006FD568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetSoldierSkillLevelBySoldierId(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			int soldierId;
			LuaObject.checkType(l, 2, out soldierId);
			int soldierSkillLevelBySoldierId = trainingGroundCompomentCommon.GetSoldierSkillLevelBySoldierId(soldierId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierSkillLevelBySoldierId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BE7 RID: 101351 RVA: 0x006FF3CC File Offset: 0x006FD5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OutPutTeachnologyTreeOperateLog(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
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
			trainingGroundCompomentCommon.m_luaExportHelper.OutPutTeachnologyTreeOperateLog(courseId, techId, currentLvl, itemGot, itemCost);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BE8 RID: 101352 RVA: 0x006FF45C File Offset: 0x006FD65C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_TrainingTechLevelupMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			TrainingTech obj;
			LuaObject.checkType<TrainingTech>(l, 2, out obj);
			trainingGroundCompomentCommon.m_luaExportHelper.__callDele_TrainingTechLevelupMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BE9 RID: 101353 RVA: 0x006FF4B8 File Offset: 0x006FD6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_TrainingTechLevelupMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			TrainingTech obj;
			LuaObject.checkType<TrainingTech>(l, 2, out obj);
			trainingGroundCompomentCommon.m_luaExportHelper.__clearDele_TrainingTechLevelupMissionEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BEA RID: 101354 RVA: 0x006FF514 File Offset: 0x006FD714
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingGroundCompomentCommon.m_luaExportHelper._configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BEB RID: 101355 RVA: 0x006FF56C File Offset: 0x006FD76C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			trainingGroundCompomentCommon.m_luaExportHelper._configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BEC RID: 101356 RVA: 0x006FF5C8 File Offset: 0x006FD7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_trainingGroundDS(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingGroundCompomentCommon.m_trainingGroundDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BED RID: 101357 RVA: 0x006FF61C File Offset: 0x006FD81C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_trainingGroundDS(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			DataSectionTrainingGround trainingGroundDS;
			LuaObject.checkType<DataSectionTrainingGround>(l, 2, out trainingGroundDS);
			trainingGroundCompomentCommon.m_trainingGroundDS = trainingGroundDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BEE RID: 101358 RVA: 0x006FF674 File Offset: 0x006FD874
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingGroundCompomentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BEF RID: 101359 RVA: 0x006FF6CC File Offset: 0x006FD8CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			trainingGroundCompomentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BF0 RID: 101360 RVA: 0x006FF728 File Offset: 0x006FD928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingGroundCompomentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BF1 RID: 101361 RVA: 0x006FF780 File Offset: 0x006FD980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			trainingGroundCompomentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BF2 RID: 101362 RVA: 0x006FF7DC File Offset: 0x006FD9DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingGroundCompomentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BF3 RID: 101363 RVA: 0x006FF834 File Offset: 0x006FDA34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			trainingGroundCompomentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BF4 RID: 101364 RVA: 0x006FF890 File Offset: 0x006FDA90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_anikiGym(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingGroundCompomentCommon.m_luaExportHelper.m_anikiGym);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BF5 RID: 101365 RVA: 0x006FF8E8 File Offset: 0x006FDAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiGym(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			AnikiGymComponentCommon anikiGym;
			LuaObject.checkType<AnikiGymComponentCommon>(l, 2, out anikiGym);
			trainingGroundCompomentCommon.m_luaExportHelper.m_anikiGym = anikiGym;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BF6 RID: 101366 RVA: 0x006FF944 File Offset: 0x006FDB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TrainingTechLevelupMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			Action<TrainingTech> value;
			int num = LuaObject.checkDelegate<Action<TrainingTech>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					trainingGroundCompomentCommon.TrainingTechLevelupMissionEvent += value;
				}
				else if (num == 2)
				{
					trainingGroundCompomentCommon.TrainingTechLevelupMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BF7 RID: 101367 RVA: 0x006FF9C4 File Offset: 0x006FDBC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingGroundCompomentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BF8 RID: 101368 RVA: 0x006FFA18 File Offset: 0x006FDC18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			trainingGroundCompomentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BF9 RID: 101369 RVA: 0x006FFA70 File Offset: 0x006FDC70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingGroundCompomentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BFA RID: 101370 RVA: 0x006FFAC8 File Offset: 0x006FDCC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TrainingGroundCompomentCommon trainingGroundCompomentCommon = (TrainingGroundCompomentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			trainingGroundCompomentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018BFB RID: 101371 RVA: 0x006FFB24 File Offset: 0x006FDD24
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TrainingGroundCompomentCommon");
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.GetTechMaxLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.IsTechLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.CanLevelup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.GetResourceRequirementsByLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.GetTechLevelupResourceRequirements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.CheckTechLevelup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.TechLevelup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.AddTechLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.ApplyTrainingTechToHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.GetAvailableTechs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.IterateAvailableTechInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.IterateAvailableTechs);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.GetTechLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.GetTech);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.GetRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.GetSoldierSkillLevelBySoldierId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.OutPutTeachnologyTreeOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.__callDele_TrainingTechLevelupMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.__clearDele_TrainingTechLevelupMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache18);
		string name = "_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.get__configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.set__configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1A, true);
		string name2 = "m_trainingGroundDS";
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.get_m_trainingGroundDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.set_m_trainingGroundDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1C, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1E, true);
		string name4 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.get_m_bag);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache20, true);
		string name5 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.get_m_hero);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache22, true);
		string name6 = "m_anikiGym";
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.get_m_anikiGym);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.set_m_anikiGym);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache24, true);
		string name7 = "TrainingTechLevelupMissionEvent";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.set_TrainingTechLevelupMissionEvent);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache25, true);
		string name8 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.get_Owner);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.set_Owner);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache27, true);
		string name9 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache29, true);
		if (Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TrainingGroundCompomentCommon.<>f__mg$cache2A, typeof(TrainingGroundCompomentCommon));
	}

	// Token: 0x0400F09A RID: 61594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F09B RID: 61595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F09C RID: 61596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F09D RID: 61597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F09E RID: 61598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F09F RID: 61599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F0A0 RID: 61600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F0A1 RID: 61601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F0A2 RID: 61602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F0A3 RID: 61603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F0A4 RID: 61604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F0A5 RID: 61605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F0A6 RID: 61606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F0A7 RID: 61607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F0A8 RID: 61608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F0A9 RID: 61609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F0AA RID: 61610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F0AB RID: 61611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F0AC RID: 61612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F0AD RID: 61613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F0AE RID: 61614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F0AF RID: 61615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F0B0 RID: 61616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F0B1 RID: 61617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F0B2 RID: 61618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F0B3 RID: 61619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F0B4 RID: 61620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F0B5 RID: 61621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F0B6 RID: 61622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F0B7 RID: 61623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F0B8 RID: 61624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F0B9 RID: 61625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F0BA RID: 61626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F0BB RID: 61627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F0BC RID: 61628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F0BD RID: 61629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F0BE RID: 61630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F0BF RID: 61631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F0C0 RID: 61632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F0C1 RID: 61633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F0C2 RID: 61634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F0C3 RID: 61635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F0C4 RID: 61636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
