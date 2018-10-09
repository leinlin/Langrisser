using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011E2 RID: 4578
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ChatVoiceMessage : LuaObject
{
	// Token: 0x06017BAD RID: 97197 RVA: 0x006877E0 File Offset: 0x006859E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage o = new ChatVoiceMessage();
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

	// Token: 0x06017BAE RID: 97198 RVA: 0x00687828 File Offset: 0x00685A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceMessage.InstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BAF RID: 97199 RVA: 0x0068787C File Offset: 0x00685A7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			chatVoiceMessage.InstanceId = instanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BB0 RID: 97200 RVA: 0x006878D4 File Offset: 0x00685AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_VoiceData(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceMessage.VoiceData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BB1 RID: 97201 RVA: 0x00687928 File Offset: 0x00685B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VoiceData(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			byte[] voiceData;
			LuaObject.checkArray<byte>(l, 2, out voiceData);
			chatVoiceMessage.VoiceData = voiceData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BB2 RID: 97202 RVA: 0x00687980 File Offset: 0x00685B80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_VoiceLength(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceMessage.VoiceLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BB3 RID: 97203 RVA: 0x006879D4 File Offset: 0x00685BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VoiceLength(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			int voiceLength;
			LuaObject.checkType(l, 2, out voiceLength);
			chatVoiceMessage.VoiceLength = voiceLength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BB4 RID: 97204 RVA: 0x00687A2C File Offset: 0x00685C2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AudioFrequency(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceMessage.AudioFrequency);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BB5 RID: 97205 RVA: 0x00687A80 File Offset: 0x00685C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AudioFrequency(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			int audioFrequency;
			LuaObject.checkType(l, 2, out audioFrequency);
			chatVoiceMessage.AudioFrequency = audioFrequency;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BB6 RID: 97206 RVA: 0x00687AD8 File Offset: 0x00685CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SampleLength(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceMessage.SampleLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BB7 RID: 97207 RVA: 0x00687B2C File Offset: 0x00685D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SampleLength(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			int sampleLength;
			LuaObject.checkType(l, 2, out sampleLength);
			chatVoiceMessage.SampleLength = sampleLength;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BB8 RID: 97208 RVA: 0x00687B84 File Offset: 0x00685D84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsOverdued(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceMessage.IsOverdued);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BB9 RID: 97209 RVA: 0x00687BD8 File Offset: 0x00685DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsOverdued(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			bool isOverdued;
			LuaObject.checkType(l, 2, out isOverdued);
			chatVoiceMessage.IsOverdued = isOverdued;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BBA RID: 97210 RVA: 0x00687C30 File Offset: 0x00685E30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TranslateText(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chatVoiceMessage.TranslateText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BBB RID: 97211 RVA: 0x00687C84 File Offset: 0x00685E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TranslateText(IntPtr l)
	{
		int result;
		try
		{
			ChatVoiceMessage chatVoiceMessage = (ChatVoiceMessage)LuaObject.checkSelf(l);
			string translateText;
			LuaObject.checkType(l, 2, out translateText);
			chatVoiceMessage.TranslateText = translateText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BBC RID: 97212 RVA: 0x00687CDC File Offset: 0x00685EDC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ChatVoiceMessage");
		string name = "InstanceId";
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.get_InstanceId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.set_InstanceId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache1, true);
		string name2 = "VoiceData";
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.get_VoiceData);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.set_VoiceData);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache3, true);
		string name3 = "VoiceLength";
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.get_VoiceLength);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.set_VoiceLength);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache5, true);
		string name4 = "AudioFrequency";
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.get_AudioFrequency);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.set_AudioFrequency);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache7, true);
		string name5 = "SampleLength";
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.get_SampleLength);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.set_SampleLength);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cache9, true);
		string name6 = "IsOverdued";
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.get_IsOverdued);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.set_IsOverdued);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheB, true);
		string name7 = "TranslateText";
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.get_TranslateText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.set_TranslateText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheD, true);
		if (Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ChatVoiceMessage.<>f__mg$cacheE, typeof(ChatVoiceMessage), typeof(ChatMessage));
	}

	// Token: 0x0400E1CB RID: 57803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E1CC RID: 57804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E1CD RID: 57805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E1CE RID: 57806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E1CF RID: 57807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E1D0 RID: 57808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E1D1 RID: 57809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E1D2 RID: 57810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E1D3 RID: 57811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E1D4 RID: 57812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E1D5 RID: 57813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E1D6 RID: 57814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E1D7 RID: 57815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E1D8 RID: 57816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E1D9 RID: 57817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
