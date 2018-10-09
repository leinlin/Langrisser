using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011DC RID: 4572
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ChatComponentCommon : LuaObject
{
	// Token: 0x06017B5F RID: 97119 RVA: 0x00685804 File Offset: 0x00683A04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon o = new ChatComponentCommon();
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

	// Token: 0x06017B60 RID: 97120 RVA: 0x0068584C File Offset: 0x00683A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			string name = chatComponentCommon.GetName();
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

	// Token: 0x06017B61 RID: 97121 RVA: 0x006858A0 File Offset: 0x00683AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			chatComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B62 RID: 97122 RVA: 0x006858EC File Offset: 0x00683AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			chatComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B63 RID: 97123 RVA: 0x00685938 File Offset: 0x00683B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			chatComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B64 RID: 97124 RVA: 0x00685984 File Offset: 0x00683B84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			chatComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B65 RID: 97125 RVA: 0x006859DC File Offset: 0x00683BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			chatComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B66 RID: 97126 RVA: 0x00685A28 File Offset: 0x00683C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSendChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			int channelId;
			LuaObject.checkType(l, 2, out channelId);
			int i = chatComponentCommon.CanSendChatMessage(channelId);
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

	// Token: 0x06017B67 RID: 97127 RVA: 0x00685A8C File Offset: 0x00683C8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TruncateChatMessage(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			string s = chatComponentCommon.TruncateChatMessage(content);
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

	// Token: 0x06017B68 RID: 97128 RVA: 0x00685AF0 File Offset: 0x00683CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBanned(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			bool b = chatComponentCommon.IsBanned();
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

	// Token: 0x06017B69 RID: 97129 RVA: 0x00685B44 File Offset: 0x00683D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Ban(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			DateTime bannedTime;
			LuaObject.checkValueType<DateTime>(l, 2, out bannedTime);
			chatComponentCommon.Ban(bannedTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B6A RID: 97130 RVA: 0x00685B9C File Offset: 0x00683D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBan(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			chatComponentCommon.m_luaExportHelper.OnBan();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B6B RID: 97131 RVA: 0x00685BF0 File Offset: 0x00683DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnBan(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			chatComponentCommon.m_luaExportHelper.OnUnBan();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B6C RID: 97132 RVA: 0x00685C44 File Offset: 0x00683E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatDS(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponentCommon.m_luaExportHelper.m_chatDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B6D RID: 97133 RVA: 0x00685C9C File Offset: 0x00683E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatDS(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			DataSectionChat chatDS;
			LuaObject.checkType<DataSectionChat>(l, 2, out chatDS);
			chatComponentCommon.m_luaExportHelper.m_chatDS = chatDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B6E RID: 97134 RVA: 0x00685CF8 File Offset: 0x00683EF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B6F RID: 97135 RVA: 0x00685D50 File Offset: 0x00683F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			chatComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B70 RID: 97136 RVA: 0x00685DAC File Offset: 0x00683FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B71 RID: 97137 RVA: 0x00685E04 File Offset: 0x00684004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			chatComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B72 RID: 97138 RVA: 0x00685E60 File Offset: 0x00684060
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_guild(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponentCommon.m_luaExportHelper.m_guild);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B73 RID: 97139 RVA: 0x00685EB8 File Offset: 0x006840B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_guild(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			GuildComponentCommon guild;
			LuaObject.checkType<GuildComponentCommon>(l, 2, out guild);
			chatComponentCommon.m_luaExportHelper.m_guild = guild;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B74 RID: 97140 RVA: 0x00685F14 File Offset: 0x00684114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B75 RID: 97141 RVA: 0x00685F68 File Offset: 0x00684168
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			ChatComponentCommon chatComponentCommon = (ChatComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			chatComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B76 RID: 97142 RVA: 0x00685FC0 File Offset: 0x006841C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ChatComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.CanSendChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.TruncateChatMessage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.IsBanned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.Ban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.OnBan);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.OnUnBan);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheB);
		string name = "m_chatDS";
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.get_m_chatDS);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.set_m_chatDS);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheD, true);
		string name2 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cacheF, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache11, true);
		string name4 = "m_guild";
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.get_m_guild);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.set_m_guild);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache13, true);
		string name5 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.get_Owner);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache15, true);
		if (Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ChatComponentCommon.<>f__mg$cache16, typeof(ChatComponentCommon));
	}

	// Token: 0x0400E189 RID: 57737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E18A RID: 57738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E18B RID: 57739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E18C RID: 57740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E18D RID: 57741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E18E RID: 57742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E18F RID: 57743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E190 RID: 57744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E191 RID: 57745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E192 RID: 57746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E193 RID: 57747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E194 RID: 57748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E195 RID: 57749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E196 RID: 57750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E197 RID: 57751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E198 RID: 57752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E199 RID: 57753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E19A RID: 57754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E19B RID: 57755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E19C RID: 57756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E19D RID: 57757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E19E RID: 57758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E19F RID: 57759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
