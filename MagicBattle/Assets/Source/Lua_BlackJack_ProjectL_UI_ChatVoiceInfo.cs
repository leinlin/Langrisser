using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013EF RID: 5103
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChatVoiceInfo : LuaObject
{
	// Token: 0x0601CA9F RID: 117407 RVA: 0x008EE100 File Offset: 0x008EC300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo o = new ChatVoiceInfo();
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

	// Token: 0x0601CAA0 RID: 117408 RVA: 0x008EE148 File Offset: 0x008EC348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceRecordId(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceInfo.m_voiceRecordId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAA1 RID: 117409 RVA: 0x008EE19C File Offset: 0x008EC39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceRecordId(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			int voiceRecordId;
			LuaObject.checkType(l, 2, out voiceRecordId);
			chatVoiceInfo.m_voiceRecordId = voiceRecordId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAA2 RID: 117410 RVA: 0x008EE1F4 File Offset: 0x008EC3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceBytes(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceInfo.m_voiceBytes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAA3 RID: 117411 RVA: 0x008EE248 File Offset: 0x008EC448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceBytes(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			byte[] voiceBytes;
			LuaObject.checkArray<byte>(l, 2, out voiceBytes);
			chatVoiceInfo.m_voiceBytes = voiceBytes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAA4 RID: 117412 RVA: 0x008EE2A0 File Offset: 0x008EC4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceLength(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceInfo.m_voiceLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAA5 RID: 117413 RVA: 0x008EE2F4 File Offset: 0x008EC4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceLength(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			float voiceLength;
			LuaObject.checkType(l, 2, out voiceLength);
			chatVoiceInfo.m_voiceLength = voiceLength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAA6 RID: 117414 RVA: 0x008EE34C File Offset: 0x008EC54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceSendChannel(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceInfo.m_voiceSendChannel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAA7 RID: 117415 RVA: 0x008EE3A0 File Offset: 0x008EC5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceSendChannel(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			int voiceSendChannel;
			LuaObject.checkType(l, 2, out voiceSendChannel);
			chatVoiceInfo.m_voiceSendChannel = voiceSendChannel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAA8 RID: 117416 RVA: 0x008EE3F8 File Offset: 0x008EC5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceFrequency(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceInfo.m_voiceFrequency);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAA9 RID: 117417 RVA: 0x008EE44C File Offset: 0x008EC64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceFrequency(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			int voiceFrequency;
			LuaObject.checkType(l, 2, out voiceFrequency);
			chatVoiceInfo.m_voiceFrequency = voiceFrequency;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAAA RID: 117418 RVA: 0x008EE4A4 File Offset: 0x008EC6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sampleLength(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceInfo.m_sampleLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAAB RID: 117419 RVA: 0x008EE4F8 File Offset: 0x008EC6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sampleLength(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceInfo chatVoiceInfo = (ChatVoiceInfo)LuaObject.checkSelf(l);
			int sampleLength;
			LuaObject.checkType(l, 2, out sampleLength);
			chatVoiceInfo.m_sampleLength = sampleLength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CAAC RID: 117420 RVA: 0x008EE550 File Offset: 0x008EC750
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChatVoiceInfo");
		string name = "m_voiceRecordId";
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.get_m_voiceRecordId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.set_m_voiceRecordId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache1, true);
		string name2 = "m_voiceBytes";
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.get_m_voiceBytes);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.set_m_voiceBytes);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache3, true);
		string name3 = "m_voiceLength";
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.get_m_voiceLength);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.set_m_voiceLength);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache5, true);
		string name4 = "m_voiceSendChannel";
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.get_m_voiceSendChannel);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.set_m_voiceSendChannel);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache7, true);
		string name5 = "m_voiceFrequency";
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.get_m_voiceFrequency);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.set_m_voiceFrequency);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cache9, true);
		string name6 = "m_sampleLength";
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.get_m_sampleLength);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.set_m_sampleLength);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ChatVoiceInfo.<>f__mg$cacheC, typeof(ChatVoiceInfo));
	}

	// Token: 0x04012CA3 RID: 76963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012CA4 RID: 76964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012CA5 RID: 76965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012CA6 RID: 76966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012CA7 RID: 76967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012CA8 RID: 76968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012CA9 RID: 76969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012CAA RID: 76970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012CAB RID: 76971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012CAC RID: 76972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012CAD RID: 76973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012CAE RID: 76974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012CAF RID: 76975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
