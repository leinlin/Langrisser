using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001536 RID: 5430
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket : LuaObject
{
	// Token: 0x06020602 RID: 132610 RVA: 0x00AC68CC File Offset: 0x00AC4ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread.VoicePacket o = new PlayerVoiceHandleThread.VoicePacket();
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

	// Token: 0x06020603 RID: 132611 RVA: 0x00AC6914 File Offset: 0x00AC4B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_srcData(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread.VoicePacket voicePacket = (PlayerVoiceHandleThread.VoicePacket)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voicePacket.m_srcData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020604 RID: 132612 RVA: 0x00AC6968 File Offset: 0x00AC4B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_srcData(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread.VoicePacket voicePacket = (PlayerVoiceHandleThread.VoicePacket)LuaObject.checkSelf(l);
			float[] srcData;
			LuaObject.checkArray<float>(l, 2, out srcData);
			voicePacket.m_srcData = srcData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020605 RID: 132613 RVA: 0x00AC69C0 File Offset: 0x00AC4BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chatInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread.VoicePacket voicePacket = (PlayerVoiceHandleThread.VoicePacket)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voicePacket.m_chatInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020606 RID: 132614 RVA: 0x00AC6A14 File Offset: 0x00AC4C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chatInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread.VoicePacket voicePacket = (PlayerVoiceHandleThread.VoicePacket)LuaObject.checkSelf(l);
			ChatVoiceInfo chatInfo;
			LuaObject.checkType<ChatVoiceInfo>(l, 2, out chatInfo);
			voicePacket.m_chatInfo = chatInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020607 RID: 132615 RVA: 0x00AC6A6C File Offset: 0x00AC4C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isCompressed(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread.VoicePacket voicePacket = (PlayerVoiceHandleThread.VoicePacket)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voicePacket.m_isCompressed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020608 RID: 132616 RVA: 0x00AC6AC0 File Offset: 0x00AC4CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isCompressed(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread.VoicePacket voicePacket = (PlayerVoiceHandleThread.VoicePacket)LuaObject.checkSelf(l);
			bool isCompressed;
			LuaObject.checkType(l, 2, out isCompressed);
			voicePacket.m_isCompressed = isCompressed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020609 RID: 132617 RVA: 0x00AC6B18 File Offset: 0x00AC4D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_type(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread.VoicePacket voicePacket = (PlayerVoiceHandleThread.VoicePacket)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)voicePacket.m_type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602060A RID: 132618 RVA: 0x00AC6B6C File Offset: 0x00AC4D6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_type(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread.VoicePacket voicePacket = (PlayerVoiceHandleThread.VoicePacket)LuaObject.checkSelf(l);
			DataType type;
			LuaObject.checkEnum<DataType>(l, 2, out type);
			voicePacket.m_type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602060B RID: 132619 RVA: 0x00AC6BC4 File Offset: 0x00AC4DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isValid(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread.VoicePacket voicePacket = (PlayerVoiceHandleThread.VoicePacket)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, voicePacket.m_isValid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602060C RID: 132620 RVA: 0x00AC6C18 File Offset: 0x00AC4E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isValid(IntPtr l)
	{
		int result;
		try
		{
			PlayerVoiceHandleThread.VoicePacket voicePacket = (PlayerVoiceHandleThread.VoicePacket)LuaObject.checkSelf(l);
			bool isValid;
			LuaObject.checkType(l, 2, out isValid);
			voicePacket.m_isValid = isValid;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602060D RID: 132621 RVA: 0x00AC6C70 File Offset: 0x00AC4E70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerVoiceHandleThread.VoicePacket");
		string name = "m_srcData";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.get_m_srcData);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.set_m_srcData);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache1, true);
		string name2 = "m_chatInfo";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.get_m_chatInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.set_m_chatInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache3, true);
		string name3 = "m_isCompressed";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.get_m_isCompressed);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.set_m_isCompressed);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache5, true);
		string name4 = "m_type";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.get_m_type);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.set_m_type);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache7, true);
		string name5 = "m_isValid";
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.get_m_isValid);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.set_m_isValid);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_PlayerVoiceHandleThread_VoicePacket.<>f__mg$cacheA, typeof(PlayerVoiceHandleThread.VoicePacket));
	}

	// Token: 0x04016578 RID: 91512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016579 RID: 91513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401657A RID: 91514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401657B RID: 91515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401657C RID: 91516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401657D RID: 91517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401657E RID: 91518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401657F RID: 91519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016580 RID: 91520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016581 RID: 91521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016582 RID: 91522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
