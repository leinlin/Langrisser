using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012DE RID: 4830
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent : LuaObject
{
	// Token: 0x06019FC7 RID: 106439 RVA: 0x0079DEB4 File Offset: 0x0079C0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent o = new ResourceComponent();
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

	// Token: 0x06019FC8 RID: 106440 RVA: 0x0079DEFC File Offset: 0x0079C0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			resourceComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FC9 RID: 106441 RVA: 0x0079DF48 File Offset: 0x0079C148
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			resourceComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FCA RID: 106442 RVA: 0x0079DF94 File Offset: 0x0079C194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			resourceComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FCB RID: 106443 RVA: 0x0079DFE0 File Offset: 0x0079C1E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			DSResourceNtf msg;
			LuaObject.checkType<DSResourceNtf>(l, 2, out msg);
			resourceComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FCC RID: 106444 RVA: 0x0079E038 File Offset: 0x0079C238
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateMonthCard(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			int monthCard;
			LuaObject.checkType(l, 2, out monthCard);
			long expiredTime;
			LuaObject.checkType(l, 3, out expiredTime);
			resourceComponent.UpdateMonthCard(monthCard, expiredTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FCD RID: 106445 RVA: 0x0079E09C File Offset: 0x0079C29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			ushort dsversion = resourceComponent.GetDSVersion();
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

	// Token: 0x06019FCE RID: 106446 RVA: 0x0079E0F0 File Offset: 0x0079C2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			string s = resourceComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x06019FCF RID: 106447 RVA: 0x0079E14C File Offset: 0x0079C34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			resourceComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FD0 RID: 106448 RVA: 0x0079E1A0 File Offset: 0x0079C3A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			resourceComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FD1 RID: 106449 RVA: 0x0079E1F4 File Offset: 0x0079C3F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			resourceComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FD2 RID: 106450 RVA: 0x0079E248 File Offset: 0x0079C448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			resourceComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FD3 RID: 106451 RVA: 0x0079E2A4 File Offset: 0x0079C4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			resourceComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FD4 RID: 106452 RVA: 0x0079E2F8 File Offset: 0x0079C4F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_EffectValidMonthCard(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			resourceComponent.m_luaExportHelper.__callBase_EffectValidMonthCard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FD5 RID: 106453 RVA: 0x0079E34C File Offset: 0x0079C54C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllValidMonthCards(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			List<MonthCard> o = resourceComponent.m_luaExportHelper.__callBase_GetAllValidMonthCards();
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

	// Token: 0x06019FD6 RID: 106454 RVA: 0x0079E3A8 File Offset: 0x0079C5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddMonthCard(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			int monthCardId;
			LuaObject.checkType(l, 2, out monthCardId);
			DateTime expiredTime;
			LuaObject.checkValueType<DateTime>(l, 3, out expiredTime);
			string goodsId;
			LuaObject.checkType(l, 4, out goodsId);
			resourceComponent.m_luaExportHelper.__callBase_AddMonthCard(monthCardId, expiredTime, goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FD7 RID: 106455 RVA: 0x0079E420 File Offset: 0x0079C620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RemoveMonthCard(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			int monthCardId;
			LuaObject.checkType(l, 2, out monthCardId);
			bool b = resourceComponent.m_luaExportHelper.__callBase_RemoveMonthCard(monthCardId);
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

	// Token: 0x06019FD8 RID: 106456 RVA: 0x0079E488 File Offset: 0x0079C688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FindMonthCardById(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			MonthCard o = resourceComponent.m_luaExportHelper.__callBase_FindMonthCardById(cardId);
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

	// Token: 0x06019FD9 RID: 106457 RVA: 0x0079E4F0 File Offset: 0x0079C6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsMonthCardVaild(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			bool b = resourceComponent.m_luaExportHelper.__callBase_IsMonthCardVaild(cardId);
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

	// Token: 0x06019FDA RID: 106458 RVA: 0x0079E558 File Offset: 0x0079C758
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMonthCardValid(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			int monthCardId;
			LuaObject.checkType(l, 2, out monthCardId);
			resourceComponent.m_luaExportHelper.__callBase_OnMonthCardValid(monthCardId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FDB RID: 106459 RVA: 0x0079E5B4 File Offset: 0x0079C7B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnMonthCardInvalid(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			int monthCardId;
			LuaObject.checkType(l, 2, out monthCardId);
			resourceComponent.m_luaExportHelper.__callBase_OnMonthCardInvalid(monthCardId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FDC RID: 106460 RVA: 0x0079E610 File Offset: 0x0079C810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasHeadFrameId(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			bool b = resourceComponent.m_luaExportHelper.__callBase_HasHeadFrameId(headFrameId);
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

	// Token: 0x06019FDD RID: 106461 RVA: 0x0079E678 File Offset: 0x0079C878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			resourceComponent.m_luaExportHelper.__callBase_AddHeadFrame(headFrameId, causeId, location);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FDE RID: 106462 RVA: 0x0079E6F0 File Offset: 0x0079C8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddHeroSkin(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			int heroSkinId;
			LuaObject.checkType(l, 2, out heroSkinId);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			resourceComponent.m_luaExportHelper.__callBase_AddHeroSkin(heroSkinId, causeId, location);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FDF RID: 106463 RVA: 0x0079E768 File Offset: 0x0079C968
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			int soldierSkinId;
			LuaObject.checkType(l, 2, out soldierSkinId);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			resourceComponent.m_luaExportHelper.__callBase_AddSoldierSkin(soldierSkinId, causeId, location);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FE0 RID: 106464 RVA: 0x0079E7E0 File Offset: 0x0079C9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_HasOwn(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			GoodsType goodtypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodtypeId);
			int id;
			LuaObject.checkType(l, 3, out id);
			bool b = resourceComponent.m_luaExportHelper.__callBase_HasOwn(goodtypeId, id);
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

	// Token: 0x06019FE1 RID: 106465 RVA: 0x0079E854 File Offset: 0x0079CA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnCreateBagItemEventCallBack(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponent resourceComponent = (ResourceComponent)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			resourceComponent.m_luaExportHelper.__callBase_OnCreateBagItemEventCallBack(bagItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019FE2 RID: 106466 RVA: 0x0079E8B0 File Offset: 0x0079CAB0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.ResourceComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.UpdateMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_EffectValidMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_GetAllValidMonthCards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_AddMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_RemoveMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_FindMonthCardById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_IsMonthCardVaild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_OnMonthCardValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_OnMonthCardInvalid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_HasHeadFrameId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_AddHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_AddHeroSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_AddSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_HasOwn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.__callBase_OnCreateBagItemEventCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_ResourceComponent.<>f__mg$cache1A, typeof(ResourceComponent), typeof(ResourceComponentCommon));
	}

	// Token: 0x040103ED RID: 66541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040103EE RID: 66542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040103EF RID: 66543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040103F0 RID: 66544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040103F1 RID: 66545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040103F2 RID: 66546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040103F3 RID: 66547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040103F4 RID: 66548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040103F5 RID: 66549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040103F6 RID: 66550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040103F7 RID: 66551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040103F8 RID: 66552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040103F9 RID: 66553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040103FA RID: 66554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040103FB RID: 66555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040103FC RID: 66556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040103FD RID: 66557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040103FE RID: 66558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040103FF RID: 66559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04010400 RID: 66560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04010401 RID: 66561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04010402 RID: 66562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04010403 RID: 66563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04010404 RID: 66564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04010405 RID: 66565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04010406 RID: 66566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04010407 RID: 66567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
