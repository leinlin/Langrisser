using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011D7 RID: 4567
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet : LuaObject
{
	// Token: 0x06017B23 RID: 97059 RVA: 0x00683F78 File Offset: 0x00682178
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardInfoSet o = new BusinessCardInfoSet();
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

	// Token: 0x06017B24 RID: 97060 RVA: 0x00683FC0 File Offset: 0x006821C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToProtocol_s(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardInfoSet set;
			LuaObject.checkType<BusinessCardInfoSet>(l, 1, out set);
			ProBusinessCardInfoSet o = BusinessCardInfoSet.ToProtocol(set);
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

	// Token: 0x06017B25 RID: 97061 RVA: 0x00684014 File Offset: 0x00682214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromProtocol_s(IntPtr l)
	{
		int result;
		try
		{
			ProBusinessCardInfoSet pbSet;
			LuaObject.checkType<ProBusinessCardInfoSet>(l, 1, out pbSet);
			BusinessCardInfoSet o = BusinessCardInfoSet.FromProtocol(pbSet);
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

	// Token: 0x06017B26 RID: 97062 RVA: 0x00684068 File Offset: 0x00682268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Heroes(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardInfoSet businessCardInfoSet = (BusinessCardInfoSet)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardInfoSet.Heroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B27 RID: 97063 RVA: 0x006840BC File Offset: 0x006822BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Heroes(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardInfoSet businessCardInfoSet = (BusinessCardInfoSet)LuaObject.checkSelf(l);
			List<BusinessCardHeroSet> heroes;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 2, out heroes);
			businessCardInfoSet.Heroes = heroes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B28 RID: 97064 RVA: 0x00684114 File Offset: 0x00682314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardInfoSet businessCardInfoSet = (BusinessCardInfoSet)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardInfoSet.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B29 RID: 97065 RVA: 0x00684168 File Offset: 0x00682368
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardInfoSet businessCardInfoSet = (BusinessCardInfoSet)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			businessCardInfoSet.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B2A RID: 97066 RVA: 0x006841C0 File Offset: 0x006823C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsActionRandom(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardInfoSet businessCardInfoSet = (BusinessCardInfoSet)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardInfoSet.IsActionRandom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B2B RID: 97067 RVA: 0x00684214 File Offset: 0x00682414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsActionRandom(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardInfoSet businessCardInfoSet = (BusinessCardInfoSet)LuaObject.checkSelf(l);
			bool isActionRandom;
			LuaObject.checkType(l, 2, out isActionRandom);
			businessCardInfoSet.IsActionRandom = isActionRandom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B2C RID: 97068 RVA: 0x0068426C File Offset: 0x0068246C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BusinessCardInfoSet");
		if (Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.ToProtocol_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.FromProtocol_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache1);
		string name = "Heroes";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.get_Heroes);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.set_Heroes);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache3, true);
		string name2 = "Desc";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.get_Desc);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.set_Desc);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache5, true);
		string name3 = "IsActionRandom";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.get_IsActionRandom);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.set_IsActionRandom);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BusinessCardInfoSet.<>f__mg$cache8, typeof(BusinessCardInfoSet));
	}

	// Token: 0x0400E157 RID: 57687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E158 RID: 57688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E159 RID: 57689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E15A RID: 57690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E15B RID: 57691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E15C RID: 57692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E15D RID: 57693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E15E RID: 57694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E15F RID: 57695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
