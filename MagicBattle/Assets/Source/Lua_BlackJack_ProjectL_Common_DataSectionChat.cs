using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011F8 RID: 4600
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionChat : LuaObject
{
	// Token: 0x06017DB3 RID: 97715 RVA: 0x00696064 File Offset: 0x00694264
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat o = new DataSectionChat();
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

	// Token: 0x06017DB4 RID: 97716 RVA: 0x006960AC File Offset: 0x006942AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			object o = dataSectionChat.SerializeToClient();
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

	// Token: 0x06017DB5 RID: 97717 RVA: 0x00696100 File Offset: 0x00694300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitBannedTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			long bannedTime;
			LuaObject.checkType(l, 2, out bannedTime);
			dataSectionChat.InitBannedTime(bannedTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DB6 RID: 97718 RVA: 0x00696158 File Offset: 0x00694358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBanned(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 2, out currentTime);
			bool b = dataSectionChat.IsBanned(currentTime);
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

	// Token: 0x06017DB7 RID: 97719 RVA: 0x006961BC File Offset: 0x006943BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBannedTimeExpired(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			DateTime current;
			LuaObject.checkValueType<DateTime>(l, 2, out current);
			bool b = dataSectionChat.IsBannedTimeExpired(current);
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

	// Token: 0x06017DB8 RID: 97720 RVA: 0x00696220 File Offset: 0x00694420
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Ban(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			DateTime bannedTime;
			LuaObject.checkValueType<DateTime>(l, 2, out bannedTime);
			dataSectionChat.Ban(bannedTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DB9 RID: 97721 RVA: 0x00696278 File Offset: 0x00694478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Unban(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			dataSectionChat.Unban();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DBA RID: 97722 RVA: 0x006962C4 File Offset: 0x006944C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSilentBannedTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			long bannedTime;
			LuaObject.checkType(l, 2, out bannedTime);
			dataSectionChat.InitSilentBannedTime(bannedTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DBB RID: 97723 RVA: 0x0069631C File Offset: 0x0069451C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsSilentlyBanned(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 2, out currentTime);
			bool b = dataSectionChat.IsSilentlyBanned(currentTime);
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

	// Token: 0x06017DBC RID: 97724 RVA: 0x00696380 File Offset: 0x00694580
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsSilentBannedTimeExpired(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			DateTime current;
			LuaObject.checkValueType<DateTime>(l, 2, out current);
			bool b = dataSectionChat.IsSilentBannedTimeExpired(current);
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

	// Token: 0x06017DBD RID: 97725 RVA: 0x006963E4 File Offset: 0x006945E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SilentBan(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			DateTime bannedTime;
			LuaObject.checkValueType<DateTime>(l, 2, out bannedTime);
			dataSectionChat.SilentBan(bannedTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DBE RID: 97726 RVA: 0x0069643C File Offset: 0x0069463C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SilentUnban(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			dataSectionChat.SilentUnban();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DBF RID: 97727 RVA: 0x00696488 File Offset: 0x00694688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanSendWorldChatByTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			int intervalTime;
			LuaObject.checkType(l, 2, out intervalTime);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currentTime);
			bool b = dataSectionChat.CanSendWorldChatByTime(intervalTime, currentTime);
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

	// Token: 0x06017DC0 RID: 97728 RVA: 0x006964F8 File Offset: 0x006946F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bannedTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionChat.m_bannedTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DC1 RID: 97729 RVA: 0x00696550 File Offset: 0x00694750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_silentlyBannedTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionChat.m_silentlyBannedTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DC2 RID: 97730 RVA: 0x006965A8 File Offset: 0x006947A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastWorldChannelChatSendTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionChat.LastWorldChannelChatSendTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DC3 RID: 97731 RVA: 0x00696600 File Offset: 0x00694800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastWorldChannelChatSendTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionChat dataSectionChat = (DataSectionChat)LuaObject.checkSelf(l);
			DateTime lastWorldChannelChatSendTime;
			LuaObject.checkValueType<DateTime>(l, 2, out lastWorldChannelChatSendTime);
			dataSectionChat.LastWorldChannelChatSendTime = lastWorldChannelChatSendTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DC4 RID: 97732 RVA: 0x00696658 File Offset: 0x00694858
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionChat");
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.InitBannedTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.IsBanned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.IsBannedTimeExpired);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.Ban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.Unban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.InitSilentBannedTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.IsSilentlyBanned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.IsSilentBannedTimeExpired);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.SilentBan);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.SilentUnban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.CanSendWorldChatByTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheB);
		string name = "m_bannedTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.get_m_bannedTime);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheC, null, true);
		string name2 = "m_silentlyBannedTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.get_m_silentlyBannedTime);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheD, null, true);
		string name3 = "LastWorldChannelChatSendTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.get_LastWorldChannelChatSendTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.set_LastWorldChannelChatSendTime);
		}
		LuaObject.addMember(l, name3, get, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionChat.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionChat.<>f__mg$cache10, typeof(DataSectionChat), typeof(DataSection));
	}

	// Token: 0x0400E3A5 RID: 58277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E3A6 RID: 58278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E3A7 RID: 58279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E3A8 RID: 58280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E3A9 RID: 58281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E3AA RID: 58282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E3AB RID: 58283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E3AC RID: 58284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E3AD RID: 58285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E3AE RID: 58286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E3AF RID: 58287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E3B0 RID: 58288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E3B1 RID: 58289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E3B2 RID: 58290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E3B3 RID: 58291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E3B4 RID: 58292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E3B5 RID: 58293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
