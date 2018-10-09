using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011B5 RID: 4533
[Preserve]
public class Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout : LuaObject
{
	// Token: 0x0601779E RID: 96158 RVA: 0x00669BA0 File Offset: 0x00667DA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AdvertisementFlowLayout o = new AdvertisementFlowLayout();
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

	// Token: 0x0601779F RID: 96159 RVA: 0x00669BE8 File Offset: 0x00667DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPB_s(IntPtr l)
	{
		int result;
		try
		{
			AdvertisementFlowLayout layout;
			LuaObject.checkType<AdvertisementFlowLayout>(l, 1, out layout);
			ProAdvertisementFlowLayout o = AdvertisementFlowLayout.ToPB(layout);
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

	// Token: 0x060177A0 RID: 96160 RVA: 0x00669C3C File Offset: 0x00667E3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FromPB_s(IntPtr l)
	{
		int result;
		try
		{
			ProAdvertisementFlowLayout pbLayout;
			LuaObject.checkType<ProAdvertisementFlowLayout>(l, 1, out pbLayout);
			AdvertisementFlowLayout o = AdvertisementFlowLayout.FromPB(pbLayout);
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

	// Token: 0x060177A1 RID: 96161 RVA: 0x00669C90 File Offset: 0x00667E90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActivityId(IntPtr l)
	{
		int result;
		try
		{
			AdvertisementFlowLayout advertisementFlowLayout = (AdvertisementFlowLayout)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, advertisementFlowLayout.ActivityId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177A2 RID: 96162 RVA: 0x00669CE4 File Offset: 0x00667EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActivityId(IntPtr l)
	{
		int result;
		try
		{
			AdvertisementFlowLayout advertisementFlowLayout = (AdvertisementFlowLayout)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			advertisementFlowLayout.ActivityId = activityId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177A3 RID: 96163 RVA: 0x00669D3C File Offset: 0x00667F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsLarge(IntPtr l)
	{
		int result;
		try
		{
			AdvertisementFlowLayout advertisementFlowLayout = (AdvertisementFlowLayout)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, advertisementFlowLayout.IsLarge);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177A4 RID: 96164 RVA: 0x00669D90 File Offset: 0x00667F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsLarge(IntPtr l)
	{
		int result;
		try
		{
			AdvertisementFlowLayout advertisementFlowLayout = (AdvertisementFlowLayout)LuaObject.checkSelf(l);
			bool isLarge;
			LuaObject.checkType(l, 2, out isLarge);
			advertisementFlowLayout.IsLarge = isLarge;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177A5 RID: 96165 RVA: 0x00669DE8 File Offset: 0x00667FE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SortId(IntPtr l)
	{
		int result;
		try
		{
			AdvertisementFlowLayout advertisementFlowLayout = (AdvertisementFlowLayout)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, advertisementFlowLayout.SortId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177A6 RID: 96166 RVA: 0x00669E3C File Offset: 0x0066803C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SortId(IntPtr l)
	{
		int result;
		try
		{
			AdvertisementFlowLayout advertisementFlowLayout = (AdvertisementFlowLayout)LuaObject.checkSelf(l);
			int sortId;
			LuaObject.checkType(l, 2, out sortId);
			advertisementFlowLayout.SortId = sortId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060177A7 RID: 96167 RVA: 0x00669E94 File Offset: 0x00668094
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.AdvertisementFlowLayout");
		if (Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.ToPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.FromPB_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache1);
		string name = "ActivityId";
		if (Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.get_ActivityId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.set_ActivityId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache3, true);
		string name2 = "IsLarge";
		if (Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.get_IsLarge);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.set_IsLarge);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache5, true);
		string name3 = "SortId";
		if (Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.get_SortId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.set_SortId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_AdvertisementFlowLayout.<>f__mg$cache8, typeof(AdvertisementFlowLayout));
	}

	// Token: 0x0400DE16 RID: 56854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DE17 RID: 56855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DE18 RID: 56856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DE19 RID: 56857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DE1A RID: 56858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DE1B RID: 56859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DE1C RID: 56860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DE1D RID: 56861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DE1E RID: 56862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
