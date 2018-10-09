using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011FB RID: 4603
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionDanmaku : LuaObject
{
	// Token: 0x06017DE1 RID: 97761 RVA: 0x00697498 File Offset: 0x00695698
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionDanmaku o = new DataSectionDanmaku();
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

	// Token: 0x06017DE2 RID: 97762 RVA: 0x006974E0 File Offset: 0x006956E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionDanmaku dataSectionDanmaku = (DataSectionDanmaku)LuaObject.checkSelf(l);
			dataSectionDanmaku.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DE3 RID: 97763 RVA: 0x0069752C File Offset: 0x0069572C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBanned(IntPtr l)
	{
		int result;
		try
		{
			DataSectionDanmaku dataSectionDanmaku = (DataSectionDanmaku)LuaObject.checkSelf(l);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 2, out currentTime);
			bool b = dataSectionDanmaku.IsBanned(currentTime);
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

	// Token: 0x06017DE4 RID: 97764 RVA: 0x00697590 File Offset: 0x00695790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsBannedTimeExpired(IntPtr l)
	{
		int result;
		try
		{
			DataSectionDanmaku dataSectionDanmaku = (DataSectionDanmaku)LuaObject.checkSelf(l);
			DateTime current;
			LuaObject.checkValueType<DateTime>(l, 2, out current);
			bool b = dataSectionDanmaku.IsBannedTimeExpired(current);
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

	// Token: 0x06017DE5 RID: 97765 RVA: 0x006975F4 File Offset: 0x006957F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Ban(IntPtr l)
	{
		int result;
		try
		{
			DataSectionDanmaku dataSectionDanmaku = (DataSectionDanmaku)LuaObject.checkSelf(l);
			DateTime bannedTime;
			LuaObject.checkValueType<DateTime>(l, 2, out bannedTime);
			dataSectionDanmaku.Ban(bannedTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DE6 RID: 97766 RVA: 0x0069764C File Offset: 0x0069584C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Unban(IntPtr l)
	{
		int result;
		try
		{
			DataSectionDanmaku dataSectionDanmaku = (DataSectionDanmaku)LuaObject.checkSelf(l);
			dataSectionDanmaku.Unban();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DE7 RID: 97767 RVA: 0x00697698 File Offset: 0x00695898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bannedTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionDanmaku dataSectionDanmaku = (DataSectionDanmaku)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionDanmaku.m_bannedTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DE8 RID: 97768 RVA: 0x006976F0 File Offset: 0x006958F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bannedTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionDanmaku dataSectionDanmaku = (DataSectionDanmaku)LuaObject.checkSelf(l);
			DateTime bannedTime;
			LuaObject.checkValueType<DateTime>(l, 2, out bannedTime);
			dataSectionDanmaku.m_bannedTime = bannedTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017DE9 RID: 97769 RVA: 0x00697748 File Offset: 0x00695948
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionDanmaku");
		if (Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.IsBanned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.IsBannedTimeExpired);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.Ban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.Unban);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache4);
		string name = "m_bannedTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.get_m_bannedTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.set_m_bannedTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionDanmaku.<>f__mg$cache7, typeof(DataSectionDanmaku), typeof(DataSection));
	}

	// Token: 0x0400E3CD RID: 58317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E3CE RID: 58318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E3CF RID: 58319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E3D0 RID: 58320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E3D1 RID: 58321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E3D2 RID: 58322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E3D3 RID: 58323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E3D4 RID: 58324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
