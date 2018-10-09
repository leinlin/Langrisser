using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001207 RID: 4615
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionMission : LuaObject
{
	// Token: 0x06017F08 RID: 98056 RVA: 0x0069FB54 File Offset: 0x0069DD54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission o = new DataSectionMission();
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

	// Token: 0x06017F09 RID: 98057 RVA: 0x0069FB9C File Offset: 0x0069DD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			dataSectionMission.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F0A RID: 98058 RVA: 0x0069FBE8 File Offset: 0x0069DDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			object o = dataSectionMission.SerializeToClient();
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

	// Token: 0x06017F0B RID: 98059 RVA: 0x0069FC3C File Offset: 0x0069DE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitEverydayMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			List<Mission> missions;
			LuaObject.checkType<List<Mission>>(l, 2, out missions);
			dataSectionMission.InitEverydayMissions(missions);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F0C RID: 98060 RVA: 0x0069FC94 File Offset: 0x0069DE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitOneOffMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			List<Mission> missions;
			LuaObject.checkType<List<Mission>>(l, 2, out missions);
			dataSectionMission.InitOneOffMissions(missions);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F0D RID: 98061 RVA: 0x0069FCEC File Offset: 0x0069DEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitFinishedEverydayMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			List<int> missions;
			LuaObject.checkType<List<int>>(l, 2, out missions);
			dataSectionMission.InitFinishedEverydayMissions(missions);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F0E RID: 98062 RVA: 0x0069FD44 File Offset: 0x0069DF44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitFinishedOneOffMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			List<int> missions;
			LuaObject.checkType<List<int>>(l, 2, out missions);
			dataSectionMission.InitFinishedOneOffMissions(missions);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F0F RID: 98063 RVA: 0x0069FD9C File Offset: 0x0069DF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetEverydayMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			dataSectionMission.ResetEverydayMissions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F10 RID: 98064 RVA: 0x0069FDE8 File Offset: 0x0069DFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddOneOffMission(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			dataSectionMission.AddOneOffMission(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F11 RID: 98065 RVA: 0x0069FE40 File Offset: 0x0069E040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddEverydayMission(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			dataSectionMission.AddEverydayMission(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F12 RID: 98066 RVA: 0x0069FE98 File Offset: 0x0069E098
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FinishOneOffMission(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			dataSectionMission.FinishOneOffMission(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F13 RID: 98067 RVA: 0x0069FEF0 File Offset: 0x0069E0F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FinishEverydayMission(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			dataSectionMission.FinishEverydayMission(mission);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F14 RID: 98068 RVA: 0x0069FF48 File Offset: 0x0069E148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMissionProcess(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			long count;
			LuaObject.checkType(l, 3, out count);
			dataSectionMission.AddMissionProcess(mission, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F15 RID: 98069 RVA: 0x0069FFAC File Offset: 0x0069E1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMissionProcess(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			int process;
			LuaObject.checkType(l, 3, out process);
			dataSectionMission.SetMissionProcess(mission, process);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F16 RID: 98070 RVA: 0x006A0010 File Offset: 0x0069E210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveEveryDayMission(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			dataSectionMission.RemoveEveryDayMission(missionId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F17 RID: 98071 RVA: 0x006A0068 File Offset: 0x0069E268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetExistMissionIds(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			List<int> existMissionIds = dataSectionMission.GetExistMissionIds();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, existMissionIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F18 RID: 98072 RVA: 0x006A00BC File Offset: 0x0069E2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsProcessingMission(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			int missionId;
			LuaObject.checkType(l, 2, out missionId);
			bool b = dataSectionMission.IsProcessingMission(missionId);
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

	// Token: 0x06017F19 RID: 98073 RVA: 0x006A0120 File Offset: 0x0069E320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllProcessingMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			List<Mission> allProcessingMissions = dataSectionMission.GetAllProcessingMissions();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allProcessingMissions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F1A RID: 98074 RVA: 0x006A0174 File Offset: 0x0069E374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ProcessingEverydayMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionMission.ProcessingEverydayMissions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F1B RID: 98075 RVA: 0x006A01C8 File Offset: 0x0069E3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ProcessingEverydayMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			List<Mission> processingEverydayMissions;
			LuaObject.checkType<List<Mission>>(l, 2, out processingEverydayMissions);
			dataSectionMission.ProcessingEverydayMissions = processingEverydayMissions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F1C RID: 98076 RVA: 0x006A0220 File Offset: 0x0069E420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FinishedEverydayMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionMission.FinishedEverydayMissions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F1D RID: 98077 RVA: 0x006A0274 File Offset: 0x0069E474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FinishedEverydayMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			HashSet<int> finishedEverydayMissions;
			LuaObject.checkType<HashSet<int>>(l, 2, out finishedEverydayMissions);
			dataSectionMission.FinishedEverydayMissions = finishedEverydayMissions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F1E RID: 98078 RVA: 0x006A02CC File Offset: 0x0069E4CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ProcessingOneOffMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionMission.ProcessingOneOffMissions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F1F RID: 98079 RVA: 0x006A0320 File Offset: 0x0069E520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ProcessingOneOffMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			List<Mission> processingOneOffMissions;
			LuaObject.checkType<List<Mission>>(l, 2, out processingOneOffMissions);
			dataSectionMission.ProcessingOneOffMissions = processingOneOffMissions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F20 RID: 98080 RVA: 0x006A0378 File Offset: 0x0069E578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FinishedOneOffMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionMission.FinishedOneOffMissions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F21 RID: 98081 RVA: 0x006A03CC File Offset: 0x0069E5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FinishedOneOffMissions(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMission dataSectionMission = (DataSectionMission)LuaObject.checkSelf(l);
			HashSet<int> finishedOneOffMissions;
			LuaObject.checkType<HashSet<int>>(l, 2, out finishedOneOffMissions);
			dataSectionMission.FinishedOneOffMissions = finishedOneOffMissions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F22 RID: 98082 RVA: 0x006A0424 File Offset: 0x0069E624
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionMission");
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.InitEverydayMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.InitOneOffMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.InitFinishedEverydayMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.InitFinishedOneOffMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.ResetEverydayMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.AddOneOffMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.AddEverydayMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.FinishOneOffMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.FinishEverydayMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.AddMissionProcess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.SetMissionProcess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.RemoveEveryDayMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.GetExistMissionIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.IsProcessingMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.GetAllProcessingMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache10);
		string name = "ProcessingEverydayMissions";
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.get_ProcessingEverydayMissions);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.set_ProcessingEverydayMissions);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache12, true);
		string name2 = "FinishedEverydayMissions";
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.get_FinishedEverydayMissions);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.set_FinishedEverydayMissions);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache14, true);
		string name3 = "ProcessingOneOffMissions";
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.get_ProcessingOneOffMissions);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.set_ProcessingOneOffMissions);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache16, true);
		string name4 = "FinishedOneOffMissions";
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.get_FinishedOneOffMissions);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.set_FinishedOneOffMissions);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache18, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMission.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionMission.<>f__mg$cache19, typeof(DataSectionMission), typeof(DataSection));
	}

	// Token: 0x0400E4DC RID: 58588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E4DD RID: 58589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E4DE RID: 58590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E4DF RID: 58591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E4E0 RID: 58592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E4E1 RID: 58593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E4E2 RID: 58594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E4E3 RID: 58595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E4E4 RID: 58596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E4E5 RID: 58597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E4E6 RID: 58598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E4E7 RID: 58599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E4E8 RID: 58600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E4E9 RID: 58601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E4EA RID: 58602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E4EB RID: 58603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E4EC RID: 58604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E4ED RID: 58605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E4EE RID: 58606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E4EF RID: 58607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E4F0 RID: 58608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E4F1 RID: 58609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E4F2 RID: 58610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E4F3 RID: 58611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E4F4 RID: 58612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E4F5 RID: 58613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
