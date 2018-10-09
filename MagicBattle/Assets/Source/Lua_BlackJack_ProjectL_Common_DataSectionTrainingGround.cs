using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001216 RID: 4630
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround : LuaObject
{
	// Token: 0x0601808B RID: 98443 RVA: 0x006AABDC File Offset: 0x006A8DDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTrainingGround o = new DataSectionTrainingGround();
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

	// Token: 0x0601808C RID: 98444 RVA: 0x006AAC24 File Offset: 0x006A8E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTrainingGround dataSectionTrainingGround = (DataSectionTrainingGround)LuaObject.checkSelf(l);
			dataSectionTrainingGround.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601808D RID: 98445 RVA: 0x006AAC70 File Offset: 0x006A8E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTrainingGround dataSectionTrainingGround = (DataSectionTrainingGround)LuaObject.checkSelf(l);
			object o = dataSectionTrainingGround.SerializeToClient();
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

	// Token: 0x0601808E RID: 98446 RVA: 0x006AACC4 File Offset: 0x006A8EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateInstantiatedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTrainingGround dataSectionTrainingGround = (DataSectionTrainingGround)LuaObject.checkSelf(l);
			DSTrainingGroundNtf ds;
			LuaObject.checkType<DSTrainingGroundNtf>(l, 2, out ds);
			dataSectionTrainingGround.UpdateInstantiatedData(ds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601808F RID: 98447 RVA: 0x006AAD1C File Offset: 0x006A8F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRoom(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTrainingGround dataSectionTrainingGround = (DataSectionTrainingGround)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			TrainingRoom room = dataSectionTrainingGround.GetRoom(roomId);
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

	// Token: 0x06018090 RID: 98448 RVA: 0x006AAD80 File Offset: 0x006A8F80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTech(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTrainingGround dataSectionTrainingGround = (DataSectionTrainingGround)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			TrainingTech tech = dataSectionTrainingGround.GetTech(techId);
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

	// Token: 0x06018091 RID: 98449 RVA: 0x006AADE4 File Offset: 0x006A8FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTechLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTrainingGround dataSectionTrainingGround = (DataSectionTrainingGround)LuaObject.checkSelf(l);
			int techId;
			LuaObject.checkType(l, 2, out techId);
			int level;
			LuaObject.checkType(l, 3, out level);
			dataSectionTrainingGround.UpdateTechLevel(techId, level);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018092 RID: 98450 RVA: 0x006AAE48 File Offset: 0x006A9048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TrainingGround(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTrainingGround dataSectionTrainingGround = (DataSectionTrainingGround)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionTrainingGround.TrainingGround);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018093 RID: 98451 RVA: 0x006AAE9C File Offset: 0x006A909C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TrainingGround(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTrainingGround dataSectionTrainingGround = (DataSectionTrainingGround)LuaObject.checkSelf(l);
			TrainingGround trainingGround;
			LuaObject.checkType<TrainingGround>(l, 2, out trainingGround);
			dataSectionTrainingGround.TrainingGround = trainingGround;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018094 RID: 98452 RVA: 0x006AAEF4 File Offset: 0x006A90F4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionTrainingGround");
		if (Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.UpdateInstantiatedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.GetRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.GetTech);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.UpdateTechLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache5);
		string name = "TrainingGround";
		if (Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.get_TrainingGround);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.set_TrainingGround);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionTrainingGround.<>f__mg$cache8, typeof(DataSectionTrainingGround), typeof(DataSection));
	}

	// Token: 0x0400E641 RID: 58945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E642 RID: 58946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E643 RID: 58947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E644 RID: 58948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E645 RID: 58949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E646 RID: 58950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E647 RID: 58951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E648 RID: 58952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E649 RID: 58953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
