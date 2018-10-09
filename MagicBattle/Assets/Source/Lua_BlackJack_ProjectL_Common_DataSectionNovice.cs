using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001208 RID: 4616
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionNovice : LuaObject
{
	// Token: 0x06017F24 RID: 98084 RVA: 0x006A07E8 File Offset: 0x0069E9E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionNovice o = new DataSectionNovice();
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

	// Token: 0x06017F25 RID: 98085 RVA: 0x006A0830 File Offset: 0x0069EA30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionNovice dataSectionNovice = (DataSectionNovice)LuaObject.checkSelf(l);
			dataSectionNovice.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F26 RID: 98086 RVA: 0x006A087C File Offset: 0x0069EA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionNovice dataSectionNovice = (DataSectionNovice)LuaObject.checkSelf(l);
			object o = dataSectionNovice.SerializeToClient();
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

	// Token: 0x06017F27 RID: 98087 RVA: 0x006A08D0 File Offset: 0x0069EAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMissionPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionNovice dataSectionNovice = (DataSectionNovice)LuaObject.checkSelf(l);
			int delta;
			LuaObject.checkType(l, 2, out delta);
			dataSectionNovice.AddMissionPoints(delta);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F28 RID: 98088 RVA: 0x006A0928 File Offset: 0x0069EB28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRewardClaimSlot(IntPtr l)
	{
		int result;
		try
		{
			DataSectionNovice dataSectionNovice = (DataSectionNovice)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			dataSectionNovice.AddRewardClaimSlot(slot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F29 RID: 98089 RVA: 0x006A0980 File Offset: 0x0069EB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RewardClaimedSlots(IntPtr l)
	{
		int result;
		try
		{
			DataSectionNovice dataSectionNovice = (DataSectionNovice)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionNovice.RewardClaimedSlots);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F2A RID: 98090 RVA: 0x006A09D4 File Offset: 0x0069EBD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RewardClaimedSlots(IntPtr l)
	{
		int result;
		try
		{
			DataSectionNovice dataSectionNovice = (DataSectionNovice)LuaObject.checkSelf(l);
			List<int> rewardClaimedSlots;
			LuaObject.checkType<List<int>>(l, 2, out rewardClaimedSlots);
			dataSectionNovice.RewardClaimedSlots = rewardClaimedSlots;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F2B RID: 98091 RVA: 0x006A0A2C File Offset: 0x0069EC2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MissionPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionNovice dataSectionNovice = (DataSectionNovice)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionNovice.MissionPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F2C RID: 98092 RVA: 0x006A0A80 File Offset: 0x0069EC80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MissionPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionNovice dataSectionNovice = (DataSectionNovice)LuaObject.checkSelf(l);
			int missionPoints;
			LuaObject.checkType(l, 2, out missionPoints);
			dataSectionNovice.MissionPoints = missionPoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F2D RID: 98093 RVA: 0x006A0AD8 File Offset: 0x0069ECD8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionNovice");
		if (Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionNovice.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionNovice.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionNovice.AddMissionPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionNovice.AddRewardClaimSlot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache3);
		string name = "RewardClaimedSlots";
		if (Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionNovice.get_RewardClaimedSlots);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionNovice.set_RewardClaimedSlots);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache5, true);
		string name2 = "MissionPoints";
		if (Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionNovice.get_MissionPoints);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionNovice.set_MissionPoints);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionNovice.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionNovice.<>f__mg$cache8, typeof(DataSectionNovice), typeof(DataSection));
	}

	// Token: 0x0400E4F6 RID: 58614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E4F7 RID: 58615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E4F8 RID: 58616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E4F9 RID: 58617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E4FA RID: 58618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E4FB RID: 58619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E4FC RID: 58620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E4FD RID: 58621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E4FE RID: 58622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
