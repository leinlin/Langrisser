using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001463 RID: 5219
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask : LuaObject
{
	// Token: 0x0601E257 RID: 123479 RVA: 0x009AB450 File Offset: 0x009A9650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			ulong instanceId;
			LuaObject.checkType(l, 3, out instanceId);
			GetVoiceContentNetTask o = new GetVoiceContentNetTask(channel, instanceId);
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

	// Token: 0x0601E258 RID: 123480 RVA: 0x009AB4B0 File Offset: 0x009A96B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterNetworkEvent(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			getVoiceContentNetTask.m_luaExportHelper.RegisterNetworkEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E259 RID: 123481 RVA: 0x009AB504 File Offset: 0x009A9704
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterNetworkEvent(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			getVoiceContentNetTask.m_luaExportHelper.UnregisterNetworkEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E25A RID: 123482 RVA: 0x009AB558 File Offset: 0x009A9758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartNetWorking(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			bool b = getVoiceContentNetTask.m_luaExportHelper.StartNetWorking();
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

	// Token: 0x0601E25B RID: 123483 RVA: 0x009AB5B4 File Offset: 0x009A97B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetVoiceContentAck(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			ChatVoiceMessage voiceContent;
			LuaObject.checkType<ChatVoiceMessage>(l, 2, out voiceContent);
			getVoiceContentNetTask.m_luaExportHelper.OnGetVoiceContentAck(voiceContent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E25C RID: 123484 RVA: 0x009AB610 File Offset: 0x009A9810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			object param;
			LuaObject.checkType<object>(l, 2, out param);
			bool b = getVoiceContentNetTask.m_luaExportHelper.__callBase_OnStart(param);
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

	// Token: 0x0601E25D RID: 123485 RVA: 0x009AB678 File Offset: 0x009A9878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			getVoiceContentNetTask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E25E RID: 123486 RVA: 0x009AB6CC File Offset: 0x009A98CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnTimeOut(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			getVoiceContentNetTask.m_luaExportHelper.__callBase_OnTimeOut();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E25F RID: 123487 RVA: 0x009AB720 File Offset: 0x009A9920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnReLoginSuccess(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			getVoiceContentNetTask.m_luaExportHelper.__callBase_OnReLoginSuccess();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E260 RID: 123488 RVA: 0x009AB774 File Offset: 0x009A9974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_instanceId(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getVoiceContentNetTask.m_luaExportHelper.m_instanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E261 RID: 123489 RVA: 0x009AB7CC File Offset: 0x009A99CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_instanceId(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			getVoiceContentNetTask.m_luaExportHelper.m_instanceId = instanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E262 RID: 123490 RVA: 0x009AB828 File Offset: 0x009A9A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_channel(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)getVoiceContentNetTask.m_luaExportHelper.m_channel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E263 RID: 123491 RVA: 0x009AB880 File Offset: 0x009A9A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_channel(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			ChatChannel channel;
			LuaObject.checkEnum<ChatChannel>(l, 2, out channel);
			getVoiceContentNetTask.m_luaExportHelper.m_channel = channel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E264 RID: 123492 RVA: 0x009AB8DC File Offset: 0x009A9ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceContent(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getVoiceContentNetTask.m_luaExportHelper.m_voiceContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E265 RID: 123493 RVA: 0x009AB934 File Offset: 0x009A9B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceContent(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			ChatVoiceMessage voiceContent;
			LuaObject.checkType<ChatVoiceMessage>(l, 2, out voiceContent);
			getVoiceContentNetTask.m_luaExportHelper.m_voiceContent = voiceContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E266 RID: 123494 RVA: 0x009AB990 File Offset: 0x009A9B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_VoiceContent(IntPtr l)
	{
		int result;
		try
		{
			GetVoiceContentNetTask getVoiceContentNetTask = (GetVoiceContentNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getVoiceContentNetTask.VoiceContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E267 RID: 123495 RVA: 0x009AB9E4 File Offset: 0x009A9BE4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GetVoiceContentNetTask");
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.RegisterNetworkEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.UnregisterNetworkEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.StartNetWorking);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.OnGetVoiceContentAck);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.__callBase_OnTimeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.__callBase_OnReLoginSuccess);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache7);
		string name = "m_instanceId";
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.get_m_instanceId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.set_m_instanceId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cache9, true);
		string name2 = "m_channel";
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.get_m_channel);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.set_m_channel);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheB, true);
		string name3 = "m_voiceContent";
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.get_m_voiceContent);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.set_m_voiceContent);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheD, true);
		string name4 = "VoiceContent";
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.get_VoiceContent);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheE, null, true);
		if (Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GetVoiceContentNetTask.<>f__mg$cacheF, typeof(GetVoiceContentNetTask), typeof(UINetTask));
	}

	// Token: 0x04014373 RID: 82803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014374 RID: 82804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014375 RID: 82805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014376 RID: 82806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014377 RID: 82807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014378 RID: 82808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014379 RID: 82809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401437A RID: 82810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401437B RID: 82811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401437C RID: 82812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401437D RID: 82813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401437E RID: 82814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401437F RID: 82815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014380 RID: 82816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014381 RID: 82817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014382 RID: 82818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
