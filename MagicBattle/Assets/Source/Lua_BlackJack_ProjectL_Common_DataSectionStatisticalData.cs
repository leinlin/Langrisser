using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001212 RID: 4626
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData : LuaObject
{
	// Token: 0x06018054 RID: 98388 RVA: 0x006A94A8 File Offset: 0x006A76A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionStatisticalData o = new DataSectionStatisticalData();
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

	// Token: 0x06018055 RID: 98389 RVA: 0x006A94F0 File Offset: 0x006A76F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsExistStatisticalData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionStatisticalData dataSectionStatisticalData = (DataSectionStatisticalData)LuaObject.checkSelf(l);
			int typeId;
			LuaObject.checkType(l, 2, out typeId);
			bool b = dataSectionStatisticalData.IsExistStatisticalData(typeId);
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

	// Token: 0x06018056 RID: 98390 RVA: 0x006A9554 File Offset: 0x006A7754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddStatisticalData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionStatisticalData dataSectionStatisticalData = (DataSectionStatisticalData)LuaObject.checkSelf(l);
			int typeId;
			LuaObject.checkType(l, 2, out typeId);
			long nums;
			LuaObject.checkType(l, 3, out nums);
			dataSectionStatisticalData.AddStatisticalData(typeId, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018057 RID: 98391 RVA: 0x006A95B8 File Offset: 0x006A77B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddNewStatisticalData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionStatisticalData dataSectionStatisticalData = (DataSectionStatisticalData)LuaObject.checkSelf(l);
			int typeId;
			LuaObject.checkType(l, 2, out typeId);
			long nums;
			LuaObject.checkType(l, 3, out nums);
			dataSectionStatisticalData.AddNewStatisticalData(typeId, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018058 RID: 98392 RVA: 0x006A961C File Offset: 0x006A781C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStatisticalDataByTypeId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionStatisticalData dataSectionStatisticalData = (DataSectionStatisticalData)LuaObject.checkSelf(l);
			int typeId;
			LuaObject.checkType(l, 2, out typeId);
			long statisticalDataByTypeId = dataSectionStatisticalData.GetStatisticalDataByTypeId(typeId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, statisticalDataByTypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018059 RID: 98393 RVA: 0x006A9680 File Offset: 0x006A7880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitStatisticalData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionStatisticalData dataSectionStatisticalData = (DataSectionStatisticalData)LuaObject.checkSelf(l);
			Dictionary<int, long> dataDict;
			LuaObject.checkType<Dictionary<int, long>>(l, 2, out dataDict);
			dataSectionStatisticalData.InitStatisticalData(dataDict);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601805A RID: 98394 RVA: 0x006A96D8 File Offset: 0x006A78D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StatisticalData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionStatisticalData dataSectionStatisticalData = (DataSectionStatisticalData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionStatisticalData.StatisticalData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601805B RID: 98395 RVA: 0x006A972C File Offset: 0x006A792C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StatisticalData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionStatisticalData dataSectionStatisticalData = (DataSectionStatisticalData)LuaObject.checkSelf(l);
			Dictionary<int, long> statisticalData;
			LuaObject.checkType<Dictionary<int, long>>(l, 2, out statisticalData);
			dataSectionStatisticalData.StatisticalData = statisticalData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601805C RID: 98396 RVA: 0x006A9784 File Offset: 0x006A7984
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionStatisticalData");
		if (Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.IsExistStatisticalData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.AddStatisticalData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.AddNewStatisticalData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.GetStatisticalDataByTypeId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.InitStatisticalData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache4);
		string name = "StatisticalData";
		if (Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.get_StatisticalData);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.set_StatisticalData);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionStatisticalData.<>f__mg$cache7, typeof(DataSectionStatisticalData), typeof(DataSection));
	}

	// Token: 0x0400E612 RID: 58898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E613 RID: 58899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E614 RID: 58900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E615 RID: 58901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E616 RID: 58902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E617 RID: 58903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E618 RID: 58904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E619 RID: 58905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
