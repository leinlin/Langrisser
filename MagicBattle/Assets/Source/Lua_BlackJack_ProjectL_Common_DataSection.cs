using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011F1 RID: 4593
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSection : LuaObject
{
	// Token: 0x06017D1F RID: 97567 RVA: 0x00691EA4 File Offset: 0x006900A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSection o = new DataSection();
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

	// Token: 0x06017D20 RID: 97568 RVA: 0x00691EEC File Offset: 0x006900EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitVersion(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			ushort dbVersion;
			LuaObject.checkType(l, 2, out dbVersion);
			ushort clientVersion;
			LuaObject.checkType(l, 3, out clientVersion);
			dataSection.InitVersion(dbVersion, clientVersion);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D21 RID: 97569 RVA: 0x00691F50 File Offset: 0x00690150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDirty(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			bool dirty;
			LuaObject.checkType(l, 2, out dirty);
			dataSection.SetDirty(dirty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D22 RID: 97570 RVA: 0x00691FA8 File Offset: 0x006901A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NeedSyncToDB(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			bool b = dataSection.NeedSyncToDB();
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

	// Token: 0x06017D23 RID: 97571 RVA: 0x00691FFC File Offset: 0x006901FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnDBSynced(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			dataSection.OnDBSynced();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D24 RID: 97572 RVA: 0x00692048 File Offset: 0x00690248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetClientCommitedVersion(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			ushort clientCommitedVersion;
			LuaObject.checkType(l, 2, out clientCommitedVersion);
			dataSection.SetClientCommitedVersion(clientCommitedVersion);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D25 RID: 97573 RVA: 0x006920A0 File Offset: 0x006902A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NeedSyncToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			bool b = dataSection.NeedSyncToClient();
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

	// Token: 0x06017D26 RID: 97574 RVA: 0x006920F4 File Offset: 0x006902F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClientSynced(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			dataSection.OnClientSynced();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D27 RID: 97575 RVA: 0x00692140 File Offset: 0x00690340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			object o = dataSection.SerializeToClient();
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

	// Token: 0x06017D28 RID: 97576 RVA: 0x00692194 File Offset: 0x00690394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			dataSection.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D29 RID: 97577 RVA: 0x006921E0 File Offset: 0x006903E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Version(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSection.Version);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D2A RID: 97578 RVA: 0x00692234 File Offset: 0x00690434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ClientVersion(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSection.ClientVersion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D2B RID: 97579 RVA: 0x00692288 File Offset: 0x00690488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ClientCommitedVersion(IntPtr l)
	{
		int result;
		try
		{
			DataSection dataSection = (DataSection)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSection.ClientCommitedVersion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D2C RID: 97580 RVA: 0x006922DC File Offset: 0x006904DC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSection");
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.InitVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.SetDirty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.NeedSyncToDB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.OnDBSynced);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.SetClientCommitedVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.NeedSyncToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.OnClientSynced);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache8);
		string name = "Version";
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.get_Version);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cache9, null, true);
		string name2 = "ClientVersion";
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.get_ClientVersion);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cacheA, null, true);
		string name3 = "ClientCommitedVersion";
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.get_ClientCommitedVersion);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cacheB, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSection.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSection.<>f__mg$cacheC, typeof(DataSection));
	}

	// Token: 0x0400E31F RID: 58143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E320 RID: 58144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E321 RID: 58145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E322 RID: 58146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E323 RID: 58147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E324 RID: 58148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E325 RID: 58149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E326 RID: 58150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E327 RID: 58151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E328 RID: 58152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E329 RID: 58153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E32A RID: 58154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E32B RID: 58155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
