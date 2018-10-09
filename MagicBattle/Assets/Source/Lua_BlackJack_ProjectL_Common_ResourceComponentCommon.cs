using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001274 RID: 4724
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ResourceComponentCommon : LuaObject
{
	// Token: 0x060189D3 RID: 100819 RVA: 0x006F0260 File Offset: 0x006EE460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon o = new ResourceComponentCommon();
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

	// Token: 0x060189D4 RID: 100820 RVA: 0x006F02A8 File Offset: 0x006EE4A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			string name = resourceComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189D5 RID: 100821 RVA: 0x006F02FC File Offset: 0x006EE4FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			resourceComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189D6 RID: 100822 RVA: 0x006F0348 File Offset: 0x006EE548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			resourceComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189D7 RID: 100823 RVA: 0x006F0394 File Offset: 0x006EE594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			resourceComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189D8 RID: 100824 RVA: 0x006F03E0 File Offset: 0x006EE5E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			resourceComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189D9 RID: 100825 RVA: 0x006F0438 File Offset: 0x006EE638
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			resourceComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189DA RID: 100826 RVA: 0x006F0484 File Offset: 0x006EE684
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllValidMonthCards(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			List<MonthCard> allValidMonthCards = resourceComponentCommon.GetAllValidMonthCards();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allValidMonthCards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189DB RID: 100827 RVA: 0x006F04D8 File Offset: 0x006EE6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMonthCard(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int monthCardId;
			LuaObject.checkType(l, 2, out monthCardId);
			DateTime expiredTime;
			LuaObject.checkValueType<DateTime>(l, 3, out expiredTime);
			string goodsId;
			LuaObject.checkType(l, 4, out goodsId);
			resourceComponentCommon.AddMonthCard(monthCardId, expiredTime, goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189DC RID: 100828 RVA: 0x006F054C File Offset: 0x006EE74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveMonthCard(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int monthCardId;
			LuaObject.checkType(l, 2, out monthCardId);
			bool b = resourceComponentCommon.RemoveMonthCard(monthCardId);
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

	// Token: 0x060189DD RID: 100829 RVA: 0x006F05B0 File Offset: 0x006EE7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindMonthCardById(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			MonthCard o = resourceComponentCommon.FindMonthCardById(cardId);
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

	// Token: 0x060189DE RID: 100830 RVA: 0x006F0614 File Offset: 0x006EE814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsMonthCardVaild(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int cardId;
			LuaObject.checkType(l, 2, out cardId);
			bool b = resourceComponentCommon.IsMonthCardVaild(cardId);
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

	// Token: 0x060189DF RID: 100831 RVA: 0x006F0678 File Offset: 0x006EE878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasHeadFrameId(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			bool b = resourceComponentCommon.HasHeadFrameId(headFrameId);
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

	// Token: 0x060189E0 RID: 100832 RVA: 0x006F06DC File Offset: 0x006EE8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			resourceComponentCommon.AddHeadFrame(headFrameId, causeId, location);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189E1 RID: 100833 RVA: 0x006F0750 File Offset: 0x006EE950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroSkin(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int heroSkinId;
			LuaObject.checkType(l, 2, out heroSkinId);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			resourceComponentCommon.AddHeroSkin(heroSkinId, causeId, location);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189E2 RID: 100834 RVA: 0x006F07C4 File Offset: 0x006EE9C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddSoldierSkin(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int soldierSkinId;
			LuaObject.checkType(l, 2, out soldierSkinId);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out causeId);
			string location;
			LuaObject.checkType(l, 4, out location);
			resourceComponentCommon.AddSoldierSkin(soldierSkinId, causeId, location);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189E3 RID: 100835 RVA: 0x006F0838 File Offset: 0x006EEA38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasOwn(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			GoodsType goodtypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodtypeId);
			int id;
			LuaObject.checkType(l, 3, out id);
			bool b = resourceComponentCommon.HasOwn(goodtypeId, id);
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

	// Token: 0x060189E4 RID: 100836 RVA: 0x006F08A8 File Offset: 0x006EEAA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EffectValidMonthCard(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			resourceComponentCommon.m_luaExportHelper.EffectValidMonthCard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189E5 RID: 100837 RVA: 0x006F08FC File Offset: 0x006EEAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMonthCardValid(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int monthCardId;
			LuaObject.checkType(l, 2, out monthCardId);
			resourceComponentCommon.m_luaExportHelper.OnMonthCardValid(monthCardId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189E6 RID: 100838 RVA: 0x006F0958 File Offset: 0x006EEB58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnMonthCardInvalid(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int monthCardId;
			LuaObject.checkType(l, 2, out monthCardId);
			resourceComponentCommon.m_luaExportHelper.OnMonthCardInvalid(monthCardId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189E7 RID: 100839 RVA: 0x006F09B4 File Offset: 0x006EEBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCreateBagItemEventCallBack(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			resourceComponentCommon.m_luaExportHelper.OnCreateBagItemEventCallBack(bagItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189E8 RID: 100840 RVA: 0x006F0A10 File Offset: 0x006EEC10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddEquipmentId(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int equipmentId;
			LuaObject.checkType(l, 2, out equipmentId);
			resourceComponentCommon.m_luaExportHelper.AddEquipmentId(equipmentId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189E9 RID: 100841 RVA: 0x006F0A6C File Offset: 0x006EEC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_MonthCardValidEvent(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			resourceComponentCommon.m_luaExportHelper.__callDele_MonthCardValidEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189EA RID: 100842 RVA: 0x006F0AC8 File Offset: 0x006EECC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_MonthCardValidEvent(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			resourceComponentCommon.m_luaExportHelper.__clearDele_MonthCardValidEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189EB RID: 100843 RVA: 0x006F0B24 File Offset: 0x006EED24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_MonthCardInvalidEvent(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			resourceComponentCommon.m_luaExportHelper.__callDele_MonthCardInvalidEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189EC RID: 100844 RVA: 0x006F0B80 File Offset: 0x006EED80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_MonthCardInvalidEvent(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			resourceComponentCommon.m_luaExportHelper.__clearDele_MonthCardInvalidEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189ED RID: 100845 RVA: 0x006F0BDC File Offset: 0x006EEDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resourceComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189EE RID: 100846 RVA: 0x006F0C34 File Offset: 0x006EEE34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			resourceComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189EF RID: 100847 RVA: 0x006F0C90 File Offset: 0x006EEE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resourceDS(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resourceComponentCommon.m_luaExportHelper.m_resourceDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189F0 RID: 100848 RVA: 0x006F0CE8 File Offset: 0x006EEEE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_resourceDS(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			DataSectionResource resourceDS;
			LuaObject.checkType<DataSectionResource>(l, 2, out resourceDS);
			resourceComponentCommon.m_luaExportHelper.m_resourceDS = resourceDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189F1 RID: 100849 RVA: 0x006F0D44 File Offset: 0x006EEF44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resourceComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189F2 RID: 100850 RVA: 0x006F0D9C File Offset: 0x006EEF9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			resourceComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189F3 RID: 100851 RVA: 0x006F0DF8 File Offset: 0x006EEFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resourceComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189F4 RID: 100852 RVA: 0x006F0E50 File Offset: 0x006EF050
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			resourceComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189F5 RID: 100853 RVA: 0x006F0EAC File Offset: 0x006EF0AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MonthCardValidEvent(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					resourceComponentCommon.MonthCardValidEvent += value;
				}
				else if (num == 2)
				{
					resourceComponentCommon.MonthCardValidEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189F6 RID: 100854 RVA: 0x006F0F2C File Offset: 0x006EF12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MonthCardInvalidEvent(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					resourceComponentCommon.MonthCardInvalidEvent += value;
				}
				else if (num == 2)
				{
					resourceComponentCommon.MonthCardInvalidEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189F7 RID: 100855 RVA: 0x006F0FAC File Offset: 0x006EF1AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resourceComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189F8 RID: 100856 RVA: 0x006F1000 File Offset: 0x006EF200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			ResourceComponentCommon resourceComponentCommon = (ResourceComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			resourceComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189F9 RID: 100857 RVA: 0x006F1058 File Offset: 0x006EF258
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ResourceComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.GetAllValidMonthCards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.AddMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.RemoveMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.FindMonthCardById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.IsMonthCardVaild);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.HasHeadFrameId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.AddHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.AddHeroSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.AddSoldierSkin);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.HasOwn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.EffectValidMonthCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.OnMonthCardValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.OnMonthCardInvalid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.OnCreateBagItemEventCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.AddEquipmentId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.__callDele_MonthCardValidEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.__clearDele_MonthCardValidEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.__callDele_MonthCardInvalidEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.__clearDele_MonthCardInvalidEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache18);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1A, true);
		string name2 = "m_resourceDS";
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.get_m_resourceDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.set_m_resourceDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1C, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1E, true);
		string name4 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.get_m_bag);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache20, true);
		string name5 = "MonthCardValidEvent";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.set_MonthCardValidEvent);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache21, true);
		string name6 = "MonthCardInvalidEvent";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.set_MonthCardInvalidEvent);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache22, true);
		string name7 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.get_Owner);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache24, true);
		if (Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ResourceComponentCommon.<>f__mg$cache25, typeof(ResourceComponentCommon));
	}

	// Token: 0x0400EECD RID: 61133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EECE RID: 61134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EECF RID: 61135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EED0 RID: 61136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EED1 RID: 61137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EED2 RID: 61138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EED3 RID: 61139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EED4 RID: 61140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EED5 RID: 61141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EED6 RID: 61142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EED7 RID: 61143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EED8 RID: 61144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EED9 RID: 61145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EEDA RID: 61146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EEDB RID: 61147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EEDC RID: 61148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EEDD RID: 61149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EEDE RID: 61150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EEDF RID: 61151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EEE0 RID: 61152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EEE1 RID: 61153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EEE2 RID: 61154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EEE3 RID: 61155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EEE4 RID: 61156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EEE5 RID: 61157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EEE6 RID: 61158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EEE7 RID: 61159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EEE8 RID: 61160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EEE9 RID: 61161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EEEA RID: 61162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EEEB RID: 61163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EEEC RID: 61164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EEED RID: 61165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EEEE RID: 61166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EEEF RID: 61167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EEF0 RID: 61168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EEF1 RID: 61169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EEF2 RID: 61170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
