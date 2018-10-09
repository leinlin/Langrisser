using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011CE RID: 4558
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo : LuaObject
{
	// Token: 0x06017A66 RID: 96870 RVA: 0x0067E9BC File Offset: 0x0067CBBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo o = new BattleHeroSetupInfo();
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

	// Token: 0x06017A67 RID: 96871 RVA: 0x0067EA04 File Offset: 0x0067CC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasFlag(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo battleHeroSetupInfo = (BattleHeroSetupInfo)LuaObject.checkSelf(l);
			SetupBattleHeroFlag flag;
			LuaObject.checkEnum<SetupBattleHeroFlag>(l, 2, out flag);
			bool b = battleHeroSetupInfo.HasFlag(flag);
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

	// Token: 0x06017A68 RID: 96872 RVA: 0x0067EA68 File Offset: 0x0067CC68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Copy(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo battleHeroSetupInfo = (BattleHeroSetupInfo)LuaObject.checkSelf(l);
			BattleHeroSetupInfo o = battleHeroSetupInfo.Copy();
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

	// Token: 0x06017A69 RID: 96873 RVA: 0x0067EABC File Offset: 0x0067CCBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleHeroSetupInfoToPbProBattleHeroSetupInfo_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo info;
			LuaObject.checkType<BattleHeroSetupInfo>(l, 1, out info);
			ProBattleHeroSetupInfo o = BattleHeroSetupInfo.BattleHeroSetupInfoToPbProBattleHeroSetupInfo(info);
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

	// Token: 0x06017A6A RID: 96874 RVA: 0x0067EB10 File Offset: 0x0067CD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PbBattleHeroSetupInfoToProBattleHeroSetupInfo_s(IntPtr l)
	{
		int result;
		try
		{
			ProBattleHeroSetupInfo pbInfo;
			LuaObject.checkType<ProBattleHeroSetupInfo>(l, 1, out pbInfo);
			BattleHeroSetupInfo o = BattleHeroSetupInfo.PbBattleHeroSetupInfoToProBattleHeroSetupInfo(pbInfo);
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

	// Token: 0x06017A6B RID: 96875 RVA: 0x0067EB64 File Offset: 0x0067CD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo battleHeroSetupInfo = (BattleHeroSetupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroSetupInfo.PlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A6C RID: 96876 RVA: 0x0067EBB8 File Offset: 0x0067CDB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo battleHeroSetupInfo = (BattleHeroSetupInfo)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			battleHeroSetupInfo.PlayerIndex = playerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A6D RID: 96877 RVA: 0x0067EC10 File Offset: 0x0067CE10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo battleHeroSetupInfo = (BattleHeroSetupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroSetupInfo.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A6E RID: 96878 RVA: 0x0067EC64 File Offset: 0x0067CE64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Position(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo battleHeroSetupInfo = (BattleHeroSetupInfo)LuaObject.checkSelf(l);
			int position;
			LuaObject.checkType(l, 2, out position);
			battleHeroSetupInfo.Position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A6F RID: 96879 RVA: 0x0067ECBC File Offset: 0x0067CEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Hero(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo battleHeroSetupInfo = (BattleHeroSetupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroSetupInfo.Hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A70 RID: 96880 RVA: 0x0067ED10 File Offset: 0x0067CF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Hero(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo battleHeroSetupInfo = (BattleHeroSetupInfo)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			battleHeroSetupInfo.Hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A71 RID: 96881 RVA: 0x0067ED68 File Offset: 0x0067CF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Flag(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo battleHeroSetupInfo = (BattleHeroSetupInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleHeroSetupInfo.Flag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A72 RID: 96882 RVA: 0x0067EDBC File Offset: 0x0067CFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Flag(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroSetupInfo battleHeroSetupInfo = (BattleHeroSetupInfo)LuaObject.checkSelf(l);
			SetupBattleHeroFlag flag;
			LuaObject.checkEnum<SetupBattleHeroFlag>(l, 2, out flag);
			battleHeroSetupInfo.Flag = flag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A73 RID: 96883 RVA: 0x0067EE14 File Offset: 0x0067D014
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleHeroSetupInfo");
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.HasFlag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.Copy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.BattleHeroSetupInfoToPbProBattleHeroSetupInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.PbBattleHeroSetupInfoToProBattleHeroSetupInfo_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache3);
		string name = "PlayerIndex";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.get_PlayerIndex);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.set_PlayerIndex);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache5, true);
		string name2 = "Position";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.get_Position);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.set_Position);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache7, true);
		string name3 = "Hero";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.get_Hero);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.set_Hero);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cache9, true);
		string name4 = "Flag";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.get_Flag);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.set_Flag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleHeroSetupInfo.<>f__mg$cacheC, typeof(BattleHeroSetupInfo));
	}

	// Token: 0x0400E0AC RID: 57516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E0AD RID: 57517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E0AE RID: 57518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E0AF RID: 57519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E0B0 RID: 57520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E0B1 RID: 57521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E0B2 RID: 57522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E0B3 RID: 57523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E0B4 RID: 57524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E0B5 RID: 57525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E0B6 RID: 57526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E0B7 RID: 57527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E0B8 RID: 57528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
