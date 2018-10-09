using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012DD RID: 4829
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent : LuaObject
{
	// Token: 0x06019FB1 RID: 106417 RVA: 0x0079D4C4 File Offset: 0x0079B6C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent o = new RechargeStoreComponent();
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

	// Token: 0x06019FB2 RID: 106418 RVA: 0x0079D50C File Offset: 0x0079B70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			rechargeStoreComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FB3 RID: 106419 RVA: 0x0079D558 File Offset: 0x0079B758
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			rechargeStoreComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FB4 RID: 106420 RVA: 0x0079D5A4 File Offset: 0x0079B7A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			rechargeStoreComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FB5 RID: 106421 RVA: 0x0079D5F0 File Offset: 0x0079B7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			DSRechargeStoreNtf msg;
			LuaObject.checkType<DSRechargeStoreNtf>(l, 2, out msg);
			rechargeStoreComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FB6 RID: 106422 RVA: 0x0079D648 File Offset: 0x0079B848
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			ushort dsversion = rechargeStoreComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FB7 RID: 106423 RVA: 0x0079D69C File Offset: 0x0079B89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BuyGoods(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int addRechargeCrystal;
			LuaObject.checkType(l, 3, out addRechargeCrystal);
			rechargeStoreComponent.BuyGoods(goodsId, addRechargeCrystal);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FB8 RID: 106424 RVA: 0x0079D700 File Offset: 0x0079B900
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCrystalOriginalNums(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int crystalOriginalNums = rechargeStoreComponent.GetCrystalOriginalNums(goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, crystalOriginalNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FB9 RID: 106425 RVA: 0x0079D764 File Offset: 0x0079B964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCrystalFirstBoughtRewardNums(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int crystalFirstBoughtRewardNums = rechargeStoreComponent.GetCrystalFirstBoughtRewardNums(goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, crystalFirstBoughtRewardNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FBA RID: 106426 RVA: 0x0079D7C8 File Offset: 0x0079B9C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCrystalRepeatlyBoughtRewardNums(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int crystalRepeatlyBoughtRewardNums = rechargeStoreComponent.GetCrystalRepeatlyBoughtRewardNums(goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, crystalRepeatlyBoughtRewardNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FBB RID: 106427 RVA: 0x0079D82C File Offset: 0x0079BA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGoodsIcon(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			string goodsIcon = rechargeStoreComponent.GetGoodsIcon(goodsId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, goodsIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FBC RID: 106428 RVA: 0x0079D890 File Offset: 0x0079BA90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			string s = rechargeStoreComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x06019FBD RID: 106429 RVA: 0x0079D8EC File Offset: 0x0079BAEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			rechargeStoreComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FBE RID: 106430 RVA: 0x0079D940 File Offset: 0x0079BB40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			rechargeStoreComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FBF RID: 106431 RVA: 0x0079D994 File Offset: 0x0079BB94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			rechargeStoreComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FC0 RID: 106432 RVA: 0x0079D9E8 File Offset: 0x0079BBE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			rechargeStoreComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FC1 RID: 106433 RVA: 0x0079DA44 File Offset: 0x0079BC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			rechargeStoreComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FC2 RID: 106434 RVA: 0x0079DA98 File Offset: 0x0079BC98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsGoodsBought(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			bool b = rechargeStoreComponent.m_luaExportHelper.__callBase_IsGoodsBought(goodsId);
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

	// Token: 0x06019FC3 RID: 106435 RVA: 0x0079DB00 File Offset: 0x0079BD00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CaculateGotCrystalNums(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			int i = rechargeStoreComponent.m_luaExportHelper.__callBase_CaculateGotCrystalNums(goodsId);
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

	// Token: 0x06019FC4 RID: 106436 RVA: 0x0079DB68 File Offset: 0x0079BD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BuyGoods(IntPtr l)
	{
		int result;
		try
		{
			RechargeStoreComponent rechargeStoreComponent = (RechargeStoreComponent)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			rechargeStoreComponent.m_luaExportHelper.__callBase_BuyGoods(goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FC5 RID: 106437 RVA: 0x0079DBC4 File Offset: 0x0079BDC4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.RechargeStoreComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.BuyGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.GetCrystalOriginalNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.GetCrystalFirstBoughtRewardNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.GetCrystalRepeatlyBoughtRewardNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.GetGoodsIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.__callBase_IsGoodsBought);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.__callBase_CaculateGotCrystalNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.__callBase_BuyGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_RechargeStoreComponent.<>f__mg$cache13, typeof(RechargeStoreComponent), typeof(RechargeStoreComponentCommon));
	}

	// Token: 0x040103D9 RID: 66521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040103DA RID: 66522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040103DB RID: 66523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040103DC RID: 66524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040103DD RID: 66525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040103DE RID: 66526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040103DF RID: 66527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040103E0 RID: 66528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040103E1 RID: 66529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040103E2 RID: 66530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040103E3 RID: 66531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040103E4 RID: 66532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040103E5 RID: 66533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040103E6 RID: 66534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040103E7 RID: 66535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040103E8 RID: 66536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040103E9 RID: 66537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040103EA RID: 66538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040103EB RID: 66539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040103EC RID: 66540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
