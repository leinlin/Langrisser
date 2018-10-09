using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012BA RID: 4794
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent : LuaObject
{
	// Token: 0x06019354 RID: 103252 RVA: 0x0073659C File Offset: 0x0073479C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent o = new ChatGroupComponent();
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

	// Token: 0x06019355 RID: 103253 RVA: 0x007365E4 File Offset: 0x007347E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			chatGroupComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019356 RID: 103254 RVA: 0x00736630 File Offset: 0x00734830
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetChatGroupSimpleInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			string groupId;
			LuaObject.checkType(l, 2, out groupId);
			ChatGroupCompactInfo chatGroupSimpleInfo = chatGroupComponent.GetChatGroupSimpleInfo(groupId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupSimpleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019357 RID: 103255 RVA: 0x00736694 File Offset: 0x00734894
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NotifyChatGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			List<ProChatGroupCompactInfo> chatGroupInfoList;
			LuaObject.checkType<List<ProChatGroupCompactInfo>>(l, 2, out chatGroupInfoList);
			DateTime nowServerTime;
			LuaObject.checkValueType<DateTime>(l, 3, out nowServerTime);
			chatGroupComponent.NotifyChatGroupInfo(chatGroupInfoList, nowServerTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019358 RID: 103256 RVA: 0x007366F8 File Offset: 0x007348F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChatGroupStateChangedNtf(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			ProChatGroupInfo groupInfo;
			LuaObject.checkType<ProChatGroupInfo>(l, 2, out groupInfo);
			chatGroupComponent.ChatGroupStateChangedNtf(groupInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019359 RID: 103257 RVA: 0x00736750 File Offset: 0x00734950
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			string s = chatGroupComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x0601935A RID: 103258 RVA: 0x007367AC File Offset: 0x007349AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			chatGroupComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601935B RID: 103259 RVA: 0x00736800 File Offset: 0x00734A00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			chatGroupComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601935C RID: 103260 RVA: 0x00736854 File Offset: 0x00734A54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			chatGroupComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601935D RID: 103261 RVA: 0x007368A8 File Offset: 0x00734AA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			chatGroupComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601935E RID: 103262 RVA: 0x00736904 File Offset: 0x00734B04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			chatGroupComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601935F RID: 103263 RVA: 0x00736958 File Offset: 0x00734B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dataLastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupComponent.m_dataLastUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019360 RID: 103264 RVA: 0x007369B0 File Offset: 0x00734BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dataLastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			DateTime dataLastUpdateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out dataLastUpdateTime);
			chatGroupComponent.m_dataLastUpdateTime = dataLastUpdateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019361 RID: 103265 RVA: 0x00736A08 File Offset: 0x00734C08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_currChatGroupDict(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupComponent.m_luaExportHelper.m_currChatGroupDict);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019362 RID: 103266 RVA: 0x00736A60 File Offset: 0x00734C60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_currChatGroupDict(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			Dictionary<string, ChatGroupCompactInfo> currChatGroupDict;
			LuaObject.checkType<Dictionary<string, ChatGroupCompactInfo>>(l, 2, out currChatGroupDict);
			chatGroupComponent.m_luaExportHelper.m_currChatGroupDict = currChatGroupDict;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019363 RID: 103267 RVA: 0x00736ABC File Offset: 0x00734CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupComponent.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019364 RID: 103268 RVA: 0x00736B14 File Offset: 0x00734D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			chatGroupComponent.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019365 RID: 103269 RVA: 0x00736B70 File Offset: 0x00734D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatComponent(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupComponent.m_luaExportHelper.m_chatComponent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019366 RID: 103270 RVA: 0x00736BC8 File Offset: 0x00734DC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_chatComponent(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			ChatComponent chatComponent;
			LuaObject.checkType<ChatComponent>(l, 2, out chatComponent);
			chatGroupComponent.m_luaExportHelper.m_chatComponent = chatComponent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019367 RID: 103271 RVA: 0x00736C24 File Offset: 0x00734E24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DataLastUpdateTime(IntPtr l)
	{
		int result;
		try
		{
			ChatGroupComponent chatGroupComponent = (ChatGroupComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatGroupComponent.DataLastUpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019368 RID: 103272 RVA: 0x00736C7C File Offset: 0x00734E7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.ChatGroupComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.GetChatGroupSimpleInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.NotifyChatGroupInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.ChatGroupStateChangedNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache9);
		string name = "m_dataLastUpdateTime";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.get_m_dataLastUpdateTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.set_m_dataLastUpdateTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheB, true);
		string name2 = "m_currChatGroupDict";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.get_m_currChatGroupDict);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.set_m_currChatGroupDict);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheD, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cacheF, true);
		string name4 = "m_chatComponent";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.get_m_chatComponent);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.set_m_chatComponent);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache11, true);
		string name5 = "DataLastUpdateTime";
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.get_DataLastUpdateTime);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache12, null, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_ChatGroupComponent.<>f__mg$cache13, typeof(ChatGroupComponent), typeof(ChatGroupComponentCommon));
	}

	// Token: 0x0400F7C2 RID: 63426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F7C3 RID: 63427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F7C4 RID: 63428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F7C5 RID: 63429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F7C6 RID: 63430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F7C7 RID: 63431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F7C8 RID: 63432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F7C9 RID: 63433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F7CA RID: 63434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F7CB RID: 63435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F7CC RID: 63436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F7CD RID: 63437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F7CE RID: 63438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F7CF RID: 63439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F7D0 RID: 63440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F7D1 RID: 63441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F7D2 RID: 63442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F7D3 RID: 63443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F7D4 RID: 63444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F7D5 RID: 63445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
