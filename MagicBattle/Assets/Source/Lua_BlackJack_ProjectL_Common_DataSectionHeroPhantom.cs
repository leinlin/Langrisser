using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001202 RID: 4610
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom : LuaObject
{
	// Token: 0x06017EAA RID: 97962 RVA: 0x0069D200 File Offset: 0x0069B400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroPhantom o = new DataSectionHeroPhantom();
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

	// Token: 0x06017EAB RID: 97963 RVA: 0x0069D248 File Offset: 0x0069B448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroPhantom dataSectionHeroPhantom = (DataSectionHeroPhantom)LuaObject.checkSelf(l);
			dataSectionHeroPhantom.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EAC RID: 97964 RVA: 0x0069D294 File Offset: 0x0069B494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroPhantom dataSectionHeroPhantom = (DataSectionHeroPhantom)LuaObject.checkSelf(l);
			object o = dataSectionHeroPhantom.SerializeToClient();
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

	// Token: 0x06017EAD RID: 97965 RVA: 0x0069D2E8 File Offset: 0x0069B4E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateInstantiatedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroPhantom dataSectionHeroPhantom = (DataSectionHeroPhantom)LuaObject.checkSelf(l);
			DSHeroPhantomNtf ds;
			LuaObject.checkType<DSHeroPhantomNtf>(l, 2, out ds);
			dataSectionHeroPhantom.UpdateInstantiatedData(ds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EAE RID: 97966 RVA: 0x0069D340 File Offset: 0x0069B540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroPhantom(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroPhantom dataSectionHeroPhantom = (DataSectionHeroPhantom)LuaObject.checkSelf(l);
			int heroPhantomId;
			LuaObject.checkType(l, 2, out heroPhantomId);
			HeroPhantom heroPhantom = dataSectionHeroPhantom.GetHeroPhantom(heroPhantomId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EAF RID: 97967 RVA: 0x0069D3A4 File Offset: 0x0069B5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroPhantom dataSectionHeroPhantom = (DataSectionHeroPhantom)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			HeroPhantomLevel heroPhantomLevel = dataSectionHeroPhantom.GetHeroPhantomLevel(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EB0 RID: 97968 RVA: 0x0069D408 File Offset: 0x0069B608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PhantomCollections(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroPhantom dataSectionHeroPhantom = (DataSectionHeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHeroPhantom.PhantomCollections);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EB1 RID: 97969 RVA: 0x0069D45C File Offset: 0x0069B65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PhantomCollections(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroPhantom dataSectionHeroPhantom = (DataSectionHeroPhantom)LuaObject.checkSelf(l);
			HeroPhantomCollections phantomCollections;
			LuaObject.checkType<HeroPhantomCollections>(l, 2, out phantomCollections);
			dataSectionHeroPhantom.PhantomCollections = phantomCollections;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EB2 RID: 97970 RVA: 0x0069D4B4 File Offset: 0x0069B6B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionHeroPhantom");
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.UpdateInstantiatedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.GetHeroPhantom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.GetHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache4);
		string name = "PhantomCollections";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.get_PhantomCollections);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.set_PhantomCollections);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroPhantom.<>f__mg$cache7, typeof(DataSectionHeroPhantom), typeof(DataSection));
	}

	// Token: 0x0400E488 RID: 58504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E489 RID: 58505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E48A RID: 58506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E48B RID: 58507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E48C RID: 58508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E48D RID: 58509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E48E RID: 58510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E48F RID: 58511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
