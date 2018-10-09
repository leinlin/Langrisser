using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011EA RID: 4586
[Preserve]
public class Lua_BlackJack_ProjectL_Common_CooperateBattleCollections : LuaObject
{
	// Token: 0x06017C86 RID: 97414 RVA: 0x0068D7BC File Offset: 0x0068B9BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCollections o = new CooperateBattleCollections();
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

	// Token: 0x06017C87 RID: 97415 RVA: 0x0068D804 File Offset: 0x0068BA04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ReloadConfigData(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCollections cooperateBattleCollections = (CooperateBattleCollections)LuaObject.checkSelf(l);
			cooperateBattleCollections.ReloadConfigData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C88 RID: 97416 RVA: 0x0068D850 File Offset: 0x0068BA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GetLevel(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCollections cooperateBattleCollections = (CooperateBattleCollections)LuaObject.checkSelf(l);
			GetUserLevel getUserLevel;
			int num = LuaObject.checkDelegate<GetUserLevel>(l, 2, out getUserLevel);
			if (num == 0)
			{
				cooperateBattleCollections.GetLevel = getUserLevel;
			}
			else if (num == 1)
			{
				CooperateBattleCollections cooperateBattleCollections2 = cooperateBattleCollections;
				cooperateBattleCollections2.GetLevel = (GetUserLevel)Delegate.Combine(cooperateBattleCollections2.GetLevel, getUserLevel);
			}
			else if (num == 2)
			{
				CooperateBattleCollections cooperateBattleCollections3 = cooperateBattleCollections;
				cooperateBattleCollections3.GetLevel = (GetUserLevel)Delegate.Remove(cooperateBattleCollections3.GetLevel, getUserLevel);
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

	// Token: 0x06017C89 RID: 97417 RVA: 0x0068D8F8 File Offset: 0x0068BAF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Now(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCollections cooperateBattleCollections = (CooperateBattleCollections)LuaObject.checkSelf(l);
			CurrentTime currentTime;
			int num = LuaObject.checkDelegate<CurrentTime>(l, 2, out currentTime);
			if (num == 0)
			{
				cooperateBattleCollections.Now = currentTime;
			}
			else if (num == 1)
			{
				CooperateBattleCollections cooperateBattleCollections2 = cooperateBattleCollections;
				cooperateBattleCollections2.Now = (CurrentTime)Delegate.Combine(cooperateBattleCollections2.Now, currentTime);
			}
			else if (num == 2)
			{
				CooperateBattleCollections cooperateBattleCollections3 = cooperateBattleCollections;
				cooperateBattleCollections3.Now = (CurrentTime)Delegate.Remove(cooperateBattleCollections3.Now, currentTime);
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

	// Token: 0x06017C8A RID: 97418 RVA: 0x0068D9A0 File Offset: 0x0068BBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Battles(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCollections cooperateBattleCollections = (CooperateBattleCollections)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleCollections.Battles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C8B RID: 97419 RVA: 0x0068D9F4 File Offset: 0x0068BBF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Battles(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCollections cooperateBattleCollections = (CooperateBattleCollections)LuaObject.checkSelf(l);
			List<CooperateBattle> battles;
			LuaObject.checkType<List<CooperateBattle>>(l, 2, out battles);
			cooperateBattleCollections.Battles = battles;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C8C RID: 97420 RVA: 0x0068DA4C File Offset: 0x0068BC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCollections cooperateBattleCollections = (CooperateBattleCollections)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cooperateBattleCollections.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C8D RID: 97421 RVA: 0x0068DAA0 File Offset: 0x0068BCA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CooperateBattleCollections cooperateBattleCollections = (CooperateBattleCollections)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			cooperateBattleCollections.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C8E RID: 97422 RVA: 0x0068DAF8 File Offset: 0x0068BCF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.CooperateBattleCollections");
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.ReloadConfigData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache0);
		string name = "GetLevel";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.set_GetLevel);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache1, true);
		string name2 = "Now";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.set_Now);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache2, true);
		string name3 = "Battles";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.get_Battles);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.set_Battles);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache4, true);
		string name4 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.get_ConfigDataLoader);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_CooperateBattleCollections.<>f__mg$cache7, typeof(CooperateBattleCollections));
	}

	// Token: 0x0400E294 RID: 58004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E295 RID: 58005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E296 RID: 58006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E297 RID: 58007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E298 RID: 58008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E299 RID: 58009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E29A RID: 58010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E29B RID: 58011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
