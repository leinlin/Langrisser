using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012B2 RID: 4786
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_BagComponent : LuaObject
{
	// Token: 0x060191A9 RID: 102825 RVA: 0x00729308 File Offset: 0x00727508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BagComponent o = new BagComponent();
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

	// Token: 0x060191AA RID: 102826 RVA: 0x00729350 File Offset: 0x00727550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			bagComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191AB RID: 102827 RVA: 0x0072939C File Offset: 0x0072759C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			bagComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191AC RID: 102828 RVA: 0x007293E8 File Offset: 0x007275E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			bagComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191AD RID: 102829 RVA: 0x00729434 File Offset: 0x00727634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(DSBagNtf)))
			{
				BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
				DSBagNtf msg;
				LuaObject.checkType<DSBagNtf>(l, 2, out msg);
				bagComponent.DeSerialize(msg);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(DSBagExtraNtf)))
			{
				BagComponent bagComponent2 = (BagComponent)LuaObject.checkSelf(l);
				DSBagExtraNtf msg2;
				LuaObject.checkType<DSBagExtraNtf>(l, 2, out msg2);
				bagComponent2.DeSerialize(msg2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function DeSerialize to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191AE RID: 102830 RVA: 0x0072950C File Offset: 0x0072770C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ushort dsversion = bagComponent.GetDSVersion();
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

	// Token: 0x060191AF RID: 102831 RVA: 0x00729560 File Offset: 0x00727760
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChangeBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ProGoods goods;
			LuaObject.checkType<ProGoods>(l, 2, out goods);
			bagComponent.ChangeBagItem(goods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191B0 RID: 102832 RVA: 0x007295B8 File Offset: 0x007277B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsExistBagItemIgnoreInstanceDifference(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			bool b = bagComponent.IsExistBagItemIgnoreInstanceDifference(goodsTypeId, contentId);
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

	// Token: 0x060191B1 RID: 102833 RVA: 0x00729628 File Offset: 0x00727828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBagItemNums(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int bagItemNums = bagComponent.GetBagItemNums(goodsTypeId, contentId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191B2 RID: 102834 RVA: 0x00729698 File Offset: 0x00727898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInstanceBagItemInstanceIdsByContentId(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			int contentId;
			LuaObject.checkType(l, 2, out contentId);
			List<ulong> instanceBagItemInstanceIdsByContentId = bagComponent.GetInstanceBagItemInstanceIdsByContentId(contentId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, instanceBagItemInstanceIdsByContentId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191B3 RID: 102835 RVA: 0x007296FC File Offset: 0x007278FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddInstanceBagItemDirectly(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ProGoods goods;
			LuaObject.checkType<ProGoods>(l, 2, out goods);
			BagItemBase o = bagComponent.AddInstanceBagItemDirectly(goods);
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

	// Token: 0x060191B4 RID: 102836 RVA: 0x00729760 File Offset: 0x00727960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTypeBagItemDirectly(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int currentNums;
			LuaObject.checkType(l, 4, out currentNums);
			BagItemBase o = bagComponent.AddTypeBagItemDirectly(goodsTypeId, contentId, currentNums);
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

	// Token: 0x060191B5 RID: 102837 RVA: 0x007297DC File Offset: 0x007279DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DecomposeBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			List<ProGoods> goods;
			LuaObject.checkType<List<ProGoods>>(l, 2, out goods);
			int i = bagComponent.DecomposeBagItems(goods);
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

	// Token: 0x060191B6 RID: 102838 RVA: 0x00729840 File Offset: 0x00727A40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EnchantEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 2, out equipmentInstanceId);
			ulong enchantStoneInstanceId;
			LuaObject.checkType(l, 3, out enchantStoneInstanceId);
			int i = bagComponent.EnchantEquipment(equipmentInstanceId, enchantStoneInstanceId);
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

	// Token: 0x060191B7 RID: 102839 RVA: 0x007298B0 File Offset: 0x00727AB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetEquipmentResonanceNums(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 2, out equipmentInstanceId);
			int equipmentResonanceNums = bagComponent.GetEquipmentResonanceNums(equipmentInstanceId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentResonanceNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191B8 RID: 102840 RVA: 0x00729914 File Offset: 0x00727B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEquipmentResonanceNumsByHeroId(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 2, out equipmentInstanceId);
			int heroId;
			LuaObject.checkType(l, 3, out heroId);
			int equipmentResonanceNumsByHeroId = bagComponent.GetEquipmentResonanceNumsByHeroId(equipmentInstanceId, heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentResonanceNumsByHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191B9 RID: 102841 RVA: 0x00729984 File Offset: 0x00727B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanUseEnergyMedicine(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			int itemId;
			LuaObject.checkType(l, 2, out itemId);
			int useCount;
			LuaObject.checkType(l, 3, out useCount);
			int i = bagComponent.CanUseEnergyMedicine(itemId, useCount);
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

	// Token: 0x060191BA RID: 102842 RVA: 0x007299F4 File Offset: 0x00727BF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HasOwn(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int id;
			LuaObject.checkType(l, 3, out id);
			bool b = bagComponent.HasOwn(goodsType, id);
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

	// Token: 0x060191BB RID: 102843 RVA: 0x00729A64 File Offset: 0x00727C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEquipmentResonanceNumsByHero(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 2, out equipmentInstanceId);
			Hero hero;
			LuaObject.checkType<Hero>(l, 3, out hero);
			int equipmentResonanceNumsByHero = bagComponent.m_luaExportHelper.GetEquipmentResonanceNumsByHero(equipmentInstanceId, hero);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentResonanceNumsByHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191BC RID: 102844 RVA: 0x00729AD8 File Offset: 0x00727CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			string s = bagComponent.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x060191BD RID: 102845 RVA: 0x00729B34 File Offset: 0x00727D34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			bagComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191BE RID: 102846 RVA: 0x00729B88 File Offset: 0x00727D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			bagComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191BF RID: 102847 RVA: 0x00729BDC File Offset: 0x00727DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			bagComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191C0 RID: 102848 RVA: 0x00729C30 File Offset: 0x00727E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			bagComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191C1 RID: 102849 RVA: 0x00729C8C File Offset: 0x00727E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			bagComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191C2 RID: 102850 RVA: 0x00729CE0 File Offset: 0x00727EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsGoodsEnough(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			List<Goods> conditions;
			LuaObject.checkType<List<Goods>>(l, 2, out conditions);
			List<BagItemBase> o;
			int i = bagComponent.m_luaExportHelper.__callBase_IsGoodsEnough(conditions, out o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191C3 RID: 102851 RVA: 0x00729D54 File Offset: 0x00727F54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ConsumeGoods(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			List<Goods> needToConsumeGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out needToConsumeGoods);
			List<BagItemBase> bagItemsInBag;
			LuaObject.checkType<List<BagItemBase>>(l, 3, out bagItemsInBag);
			List<BagItemBase> changedGoods;
			LuaObject.checkType<List<BagItemBase>>(l, 4, out changedGoods);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 5, out causeId);
			string location;
			LuaObject.checkType(l, 6, out location);
			bagComponent.m_luaExportHelper.__callBase_ConsumeGoods(needToConsumeGoods, bagItemsInBag, changedGoods, causeId, location);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191C4 RID: 102852 RVA: 0x00729DE4 File Offset: 0x00727FE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsBagFullByRandomGoods(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			int addRandomRewardExpectSize;
			LuaObject.checkType(l, 2, out addRandomRewardExpectSize);
			List<Goods> addGoods;
			LuaObject.checkType<List<Goods>>(l, 3, out addGoods);
			List<Goods> deleteGoods;
			LuaObject.checkType<List<Goods>>(l, 4, out deleteGoods);
			bool b = bagComponent.m_luaExportHelper.__callBase_IsBagFullByRandomGoods(addRandomRewardExpectSize, addGoods, deleteGoods);
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

	// Token: 0x060191C5 RID: 102853 RVA: 0x00729E68 File Offset: 0x00728068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsBagFullByGoods(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			List<Goods> addGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out addGoods);
			List<Goods> deleteGoods;
			LuaObject.checkType<List<Goods>>(l, 3, out deleteGoods);
			bool b = bagComponent.m_luaExportHelper.__callBase_IsBagFullByGoods(addGoods, deleteGoods);
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

	// Token: 0x060191C6 RID: 102854 RVA: 0x00729EDC File Offset: 0x007280DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsBagFull(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			int expectSize;
			LuaObject.checkType(l, 2, out expectSize);
			bool b = bagComponent.m_luaExportHelper.__callBase_IsBagFull(expectSize);
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

	// Token: 0x060191C7 RID: 102855 RVA: 0x00729F44 File Offset: 0x00728144
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetBagSize(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			int i = bagComponent.m_luaExportHelper.__callBase_GetBagSize();
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

	// Token: 0x060191C8 RID: 102856 RVA: 0x00729FA0 File Offset: 0x007281A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsBagFullByCurrentSize(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			bool b = bagComponent.m_luaExportHelper.__callBase_IsBagFullByCurrentSize();
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

	// Token: 0x060191C9 RID: 102857 RVA: 0x00729FFC File Offset: 0x007281FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_TransformHeroGoods(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			List<Goods> o = bagComponent.m_luaExportHelper.__callBase_TransformHeroGoods(heroId, nums);
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

	// Token: 0x060191CA RID: 102858 RVA: 0x0072A070 File Offset: 0x00728270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsBagItemContentIdInConfig(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int i = bagComponent.m_luaExportHelper.__callBase_IsBagItemContentIdInConfig(goodsTypeId, contentId);
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

	// Token: 0x060191CB RID: 102859 RVA: 0x0072A0E4 File Offset: 0x007282E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RemoveAllBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			List<BagItemBase> changedBagItems;
			LuaObject.checkType<List<BagItemBase>>(l, 2, out changedBagItems);
			int removeItemMaxNums;
			LuaObject.checkType(l, 3, out removeItemMaxNums);
			bagComponent.m_luaExportHelper.__callBase_RemoveAllBagItems(changedBagItems, removeItemMaxNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191CC RID: 102860 RVA: 0x0072A150 File Offset: 0x00728350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RemoveBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int consumeNums;
			LuaObject.checkType(l, 4, out consumeNums);
			ulong instanceId;
			LuaObject.checkType(l, 5, out instanceId);
			GameFunctionType caseId;
			LuaObject.checkEnum<GameFunctionType>(l, 6, out caseId);
			string location;
			LuaObject.checkType(l, 7, out location);
			int i = bagComponent.m_luaExportHelper.__callBase_RemoveBagItem(goodsTypeId, contentId, consumeNums, instanceId, caseId, location);
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

	// Token: 0x060191CD RID: 102861 RVA: 0x0072A1F8 File Offset: 0x007283F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RemoveBagItemByType(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int consumeNums;
			LuaObject.checkType(l, 4, out consumeNums);
			GameFunctionType caseId;
			LuaObject.checkEnum<GameFunctionType>(l, 5, out caseId);
			string location;
			LuaObject.checkType(l, 6, out location);
			int i = bagComponent.m_luaExportHelper.__callBase_RemoveBagItemByType(goodsTypeId, contentId, consumeNums, caseId, location);
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

	// Token: 0x060191CE RID: 102862 RVA: 0x0072A294 File Offset: 0x00728494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RemoveBagItemByInstanceId(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			GameFunctionType caseId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out caseId);
			string location;
			LuaObject.checkType(l, 4, out location);
			int i = bagComponent.m_luaExportHelper.__callBase_RemoveBagItemByInstanceId(instanceId, caseId, location);
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

	// Token: 0x060191CF RID: 102863 RVA: 0x0072A318 File Offset: 0x00728518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RemoveBagItemDirectly(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			int consumeNums;
			LuaObject.checkType(l, 3, out consumeNums);
			GameFunctionType caseId;
			LuaObject.checkEnum<GameFunctionType>(l, 4, out caseId);
			string location;
			LuaObject.checkType(l, 5, out location);
			BagItemBase o = bagComponent.m_luaExportHelper.__callBase_RemoveBagItemDirectly(bagItem, consumeNums, caseId, location);
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

	// Token: 0x060191D0 RID: 102864 RVA: 0x0072A3A8 File Offset: 0x007285A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FindBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			ulong instanceId;
			LuaObject.checkType(l, 4, out instanceId);
			BagItemBase o = bagComponent.m_luaExportHelper.__callBase_FindBagItem(goodsTypeId, contentId, instanceId);
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

	// Token: 0x060191D1 RID: 102865 RVA: 0x0072A42C File Offset: 0x0072862C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FindBagItemByInstanceId(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			BagItemBase o = bagComponent.m_luaExportHelper.__callBase_FindBagItemByInstanceId(instanceId);
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

	// Token: 0x060191D2 RID: 102866 RVA: 0x0072A494 File Offset: 0x00728694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FindBagItemByType(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			BagItemBase o = bagComponent.m_luaExportHelper.__callBase_FindBagItemByType(goodsTypeId, contentId);
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

	// Token: 0x060191D3 RID: 102867 RVA: 0x0072A508 File Offset: 0x00728708
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FindUseableBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			UseableBagItem o = bagComponent.m_luaExportHelper.__callBase_FindUseableBagItem(goodsTypeId, contentId);
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

	// Token: 0x060191D4 RID: 102868 RVA: 0x0072A57C File Offset: 0x0072877C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			List<BagItemBase> o = bagComponent.m_luaExportHelper.__callBase_GetAllBagItems();
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

	// Token: 0x060191D5 RID: 102869 RVA: 0x0072A5D8 File Offset: 0x007287D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IterateAllBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			IEnumerable<BagItemBase> o = bagComponent.m_luaExportHelper.__callBase_IterateAllBagItems();
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

	// Token: 0x060191D6 RID: 102870 RVA: 0x0072A634 File Offset: 0x00728834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FindEnoughBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			List<Goods> conditions;
			LuaObject.checkType<List<Goods>>(l, 2, out conditions);
			List<BagItemBase> o = bagComponent.m_luaExportHelper.__callBase_FindEnoughBagItems(conditions);
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

	// Token: 0x060191D7 RID: 102871 RVA: 0x0072A69C File Offset: 0x0072889C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UseBagItem(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
				UseableBagItem useableBagItem;
				LuaObject.checkType<UseableBagItem>(l, 2, out useableBagItem);
				int consumeNums;
				LuaObject.checkType(l, 3, out consumeNums);
				object[] param;
				LuaObject.checkArray<object>(l, 4, out param);
				int i = bagComponent.m_luaExportHelper.__callBase_UseBagItem(useableBagItem, consumeNums, param);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 5)
			{
				BagComponent bagComponent2 = (BagComponent)LuaObject.checkSelf(l);
				GoodsType goodsTypeId;
				LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
				int contentId;
				LuaObject.checkType(l, 3, out contentId);
				int consumeNums2;
				LuaObject.checkType(l, 4, out consumeNums2);
				object[] param2;
				LuaObject.checkArray<object>(l, 5, out param2);
				int i2 = bagComponent2.m_luaExportHelper.__callBase_UseBagItem(goodsTypeId, contentId, consumeNums2, param2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_UseBagItem to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191D8 RID: 102872 RVA: 0x0072A7B0 File Offset: 0x007289B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_UseBagItemDirectly(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			UseableBagItem useableBagItem;
			LuaObject.checkType<UseableBagItem>(l, 2, out useableBagItem);
			int consumeNums;
			LuaObject.checkType(l, 3, out consumeNums);
			object[] param;
			LuaObject.checkArray<object>(l, 4, out param);
			int i = bagComponent.m_luaExportHelper.__callBase_UseBagItemDirectly(useableBagItem, consumeNums, param);
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

	// Token: 0x060191D9 RID: 102873 RVA: 0x0072A834 File Offset: 0x00728A34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_HasEnoughBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			int consumeNums;
			LuaObject.checkType(l, 3, out consumeNums);
			int i = bagComponent.m_luaExportHelper.__callBase_HasEnoughBagItem(bagItem, consumeNums);
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

	// Token: 0x060191DA RID: 102874 RVA: 0x0072A8A8 File Offset: 0x00728AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsBagItemEnough(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
				BagItemBase bagItem;
				LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
				int consumeNums;
				LuaObject.checkType(l, 3, out consumeNums);
				bool b = bagComponent.m_luaExportHelper.__callBase_IsBagItemEnough(bagItem, consumeNums);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 4)
			{
				BagComponent bagComponent2 = (BagComponent)LuaObject.checkSelf(l);
				GoodsType bagItemType;
				LuaObject.checkEnum<GoodsType>(l, 2, out bagItemType);
				int bagItemId;
				LuaObject.checkType(l, 3, out bagItemId);
				int nums;
				LuaObject.checkType(l, 4, out nums);
				bool b2 = bagComponent2.m_luaExportHelper.__callBase_IsBagItemEnough(bagItemType, bagItemId, nums);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_IsBagItemEnough to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191DB RID: 102875 RVA: 0x0072A9A4 File Offset: 0x00728BA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetTicketId(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out causeId);
			int i = bagComponent.m_luaExportHelper.__callBase_GetTicketId(causeId);
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

	// Token: 0x060191DC RID: 102876 RVA: 0x0072AA0C File Offset: 0x00728C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLevelTicketsMaxByUI(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out causeId);
			GoodsType goodTypeId;
			LuaObject.checkEnum<GoodsType>(l, 3, out goodTypeId);
			int contentId;
			LuaObject.checkType(l, 4, out contentId);
			int nums;
			LuaObject.checkType(l, 5, out nums);
			bool b = bagComponent.m_luaExportHelper.__callBase_IsLevelTicketsMaxByUI(causeId, goodTypeId, contentId, nums);
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

	// Token: 0x060191DD RID: 102877 RVA: 0x0072AA9C File Offset: 0x00728C9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SellBagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			int i = bagComponent.m_luaExportHelper.__callBase_SellBagItem(instanceId, nums);
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

	// Token: 0x060191DE RID: 102878 RVA: 0x0072AB10 File Offset: 0x00728D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CombineSameGoodsAndReplaceExistHeroToFragment(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			List<Goods> goodsList;
			LuaObject.checkType<List<Goods>>(l, 2, out goodsList);
			bagComponent.m_luaExportHelper.__callBase_CombineSameGoodsAndReplaceExistHeroToFragment(goodsList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191DF RID: 102879 RVA: 0x0072AB6C File Offset: 0x00728D6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanDecomposeBagItems(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			List<ProGoods> goods;
			LuaObject.checkType<List<ProGoods>>(l, 2, out goods);
			int i = bagComponent.m_luaExportHelper.__callBase_CanDecomposeBagItems(goods);
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

	// Token: 0x060191E0 RID: 102880 RVA: 0x0072ABD4 File Offset: 0x00728DD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanDecomposeABagItem(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			ulong instanceId;
			LuaObject.checkType(l, 5, out instanceId);
			int i = bagComponent.m_luaExportHelper.__callBase_CanDecomposeABagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x060191E1 RID: 102881 RVA: 0x0072AC64 File Offset: 0x00728E64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetBagItemDirty(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			bagComponent.m_luaExportHelper.__callBase_SetBagItemDirty(bagItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191E2 RID: 102882 RVA: 0x0072ACC0 File Offset: 0x00728EC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsPercentBaseBattleProperty(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			PropertyModifyType id;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out id);
			bool b = bagComponent.m_luaExportHelper.__callBase_IsPercentBaseBattleProperty(id);
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

	// Token: 0x060191E3 RID: 102883 RVA: 0x0072AD28 File Offset: 0x00728F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanLockAndUnLockEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int i = bagComponent.m_luaExportHelper.__callBase_CanLockAndUnLockEquipment(instanceId);
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

	// Token: 0x060191E4 RID: 102884 RVA: 0x0072AD90 File Offset: 0x00728F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LockAndUnLockEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int i = bagComponent.m_luaExportHelper.__callBase_LockAndUnLockEquipment(instanceId);
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

	// Token: 0x060191E5 RID: 102885 RVA: 0x0072ADF8 File Offset: 0x00728FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanEnhanceEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			List<ulong> materialIds;
			LuaObject.checkType<List<ulong>>(l, 3, out materialIds);
			int i = bagComponent.m_luaExportHelper.__callBase_CanEnhanceEquipment(instanceId, materialIds);
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

	// Token: 0x060191E6 RID: 102886 RVA: 0x0072AE6C File Offset: 0x0072906C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanWearEquipmentByEquipmentType(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			BagItemBase equipment;
			LuaObject.checkType<BagItemBase>(l, 2, out equipment);
			bool b = bagComponent.m_luaExportHelper.__callBase_CanWearEquipmentByEquipmentType(equipment);
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

	// Token: 0x060191E7 RID: 102887 RVA: 0x0072AED4 File Offset: 0x007290D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CalculateEnhanceEquipmentExp(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			List<BagItemBase> materials;
			LuaObject.checkType<List<BagItemBase>>(l, 2, out materials);
			int i = bagComponent.m_luaExportHelper.__callBase_CalculateEnhanceEquipmentExp(materials);
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

	// Token: 0x060191E8 RID: 102888 RVA: 0x0072AF3C File Offset: 0x0072913C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CalculateEnhanceEquipmentGold(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			int i = bagComponent.m_luaExportHelper.__callBase_CalculateEnhanceEquipmentGold(exp);
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

	// Token: 0x060191E9 RID: 102889 RVA: 0x0072AFA4 File Offset: 0x007291A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnhanceEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			List<ulong> materialIds;
			LuaObject.checkType<List<ulong>>(l, 3, out materialIds);
			int i = bagComponent.m_luaExportHelper.__callBase_EnhanceEquipment(instanceId, materialIds);
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

	// Token: 0x060191EA RID: 102890 RVA: 0x0072B018 File Offset: 0x00729218
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanEnchantEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 2, out equipmentInstanceId);
			ulong enchantStoneInstanceId;
			LuaObject.checkType(l, 3, out enchantStoneInstanceId);
			int i = bagComponent.m_luaExportHelper.__callBase_CanEnchantEquipment(equipmentInstanceId, enchantStoneInstanceId);
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

	// Token: 0x060191EB RID: 102891 RVA: 0x0072B08C File Offset: 0x0072928C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OutPutEqipmentEnhanceOperateLog(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int preLevel;
			LuaObject.checkType(l, 3, out preLevel);
			int preExp;
			LuaObject.checkType(l, 4, out preExp);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 5, out costItems);
			bagComponent.m_luaExportHelper.__callBase_OutPutEqipmentEnhanceOperateLog(equipment, preLevel, preExp, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191EC RID: 102892 RVA: 0x0072B110 File Offset: 0x00729310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OutPutEquipmentUpgrageOperateLog(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			EquipmentBagItem material;
			LuaObject.checkType<EquipmentBagItem>(l, 3, out material);
			int preLvlLimit;
			LuaObject.checkType(l, 4, out preLvlLimit);
			int postLvlLimit;
			LuaObject.checkType(l, 5, out postLvlLimit);
			List<Goods> costItems;
			LuaObject.checkType<List<Goods>>(l, 6, out costItems);
			bagComponent.m_luaExportHelper.__callBase_OutPutEquipmentUpgrageOperateLog(equipment, material, preLvlLimit, postLvlLimit, costItems);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191ED RID: 102893 RVA: 0x0072B1A0 File Offset: 0x007293A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LevelUpEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			bagComponent.m_luaExportHelper.__callBase_LevelUpEquipment(equipment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191EE RID: 102894 RVA: 0x0072B1FC File Offset: 0x007293FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CaculateEquipmentNextLevelExp(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			int equipmentContentId;
			LuaObject.checkType(l, 2, out equipmentContentId);
			int equipmentLevel;
			LuaObject.checkType(l, 3, out equipmentLevel);
			int i = bagComponent.m_luaExportHelper.__callBase_CaculateEquipmentNextLevelExp(equipmentContentId, equipmentLevel);
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

	// Token: 0x060191EF RID: 102895 RVA: 0x0072B270 File Offset: 0x00729470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanLevelUpEquipmentStar(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			ulong materialId;
			LuaObject.checkType(l, 3, out materialId);
			int i = bagComponent.m_luaExportHelper.__callBase_CanLevelUpEquipmentStar(instanceId, materialId);
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

	// Token: 0x060191F0 RID: 102896 RVA: 0x0072B2E4 File Offset: 0x007294E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CalculateLevelUpEquipmentStarGold(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int i = bagComponent.m_luaExportHelper.__callBase_CalculateLevelUpEquipmentStarGold(equipment);
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

	// Token: 0x060191F1 RID: 102897 RVA: 0x0072B34C File Offset: 0x0072954C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_LevelUpEquipmentStar(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			ulong materialId;
			LuaObject.checkType(l, 3, out materialId);
			int i = bagComponent.m_luaExportHelper.__callBase_LevelUpEquipmentStar(instanceId, materialId);
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

	// Token: 0x060191F2 RID: 102898 RVA: 0x0072B3C0 File Offset: 0x007295C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CalculateEquipmentTotalExp(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int i = bagComponent.m_luaExportHelper.__callBase_CalculateEquipmentTotalExp(equipment);
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

	// Token: 0x060191F3 RID: 102899 RVA: 0x0072B428 File Offset: 0x00729628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CalculateDecomposeEquipmentBackGold(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			int i = bagComponent.m_luaExportHelper.__callBase_CalculateDecomposeEquipmentBackGold(equipment);
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

	// Token: 0x060191F4 RID: 102900 RVA: 0x0072B490 File Offset: 0x00729690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OutPutItemOperationLog(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			GoodsType itemTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out itemTypeId);
			int itemId;
			LuaObject.checkType(l, 3, out itemId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			GameFunctionType causeId;
			LuaObject.checkEnum<GameFunctionType>(l, 5, out causeId);
			string location;
			LuaObject.checkType(l, 6, out location);
			bagComponent.m_luaExportHelper.__callBase_OutPutItemOperationLog(itemTypeId, itemId, nums, causeId, location);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191F5 RID: 102901 RVA: 0x0072B520 File Offset: 0x00729720
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnSaveEnchantSaveMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			bagComponent.m_luaExportHelper.__callBase_OnSaveEnchantSaveMissionEvent(equipment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191F6 RID: 102902 RVA: 0x0072B57C File Offset: 0x0072977C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnEnchantMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			EquipmentBagItem equipment;
			LuaObject.checkType<EquipmentBagItem>(l, 2, out equipment);
			bagComponent.m_luaExportHelper.__callBase_OnEnchantMissionEvent(equipment);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191F7 RID: 102903 RVA: 0x0072B5D8 File Offset: 0x007297D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnCreateBagItemEvent(IntPtr l)
	{
		int result;
		try
		{
			BagComponent bagComponent = (BagComponent)LuaObject.checkSelf(l);
			BagItemBase bagItem;
			LuaObject.checkType<BagItemBase>(l, 2, out bagItem);
			bagComponent.m_luaExportHelper.__callBase_OnCreateBagItemEvent(bagItem);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060191F8 RID: 102904 RVA: 0x0072B634 File Offset: 0x00729834
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.BagComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.ChangeBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.IsExistBagItemIgnoreInstanceDifference);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.GetBagItemNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.GetInstanceBagItemInstanceIdsByContentId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.AddInstanceBagItemDirectly);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.AddTypeBagItemDirectly);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.DecomposeBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.EnchantEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.GetEquipmentResonanceNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.GetEquipmentResonanceNumsByHeroId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.CanUseEnergyMedicine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.HasOwn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.GetEquipmentResonanceNumsByHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_IsGoodsEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_ConsumeGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_IsBagFullByRandomGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_IsBagFullByGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_IsBagFull);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_GetBagSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_IsBagFullByCurrentSize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_TransformHeroGoods);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_IsBagItemContentIdInConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_RemoveAllBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_RemoveBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_RemoveBagItemByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_RemoveBagItemByInstanceId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_RemoveBagItemDirectly);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_FindBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_FindBagItemByInstanceId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_FindBagItemByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_FindUseableBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_GetAllBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_IterateAllBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_FindEnoughBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_UseBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_UseBagItemDirectly);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_HasEnoughBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_IsBagItemEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_GetTicketId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_IsLevelTicketsMaxByUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_SellBagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CombineSameGoodsAndReplaceExistHeroToFragment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CanDecomposeBagItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CanDecomposeABagItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_SetBagItemDirty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_IsPercentBaseBattleProperty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CanLockAndUnLockEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_LockAndUnLockEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3A);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CanEnhanceEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3B);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CanWearEquipmentByEquipmentType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3C);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CalculateEnhanceEquipmentExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3D);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CalculateEnhanceEquipmentGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3E);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_EnhanceEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache3F);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CanEnchantEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache40);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_OutPutEqipmentEnhanceOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache41);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_OutPutEquipmentUpgrageOperateLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache42);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_LevelUpEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache43);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CaculateEquipmentNextLevelExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache44);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CanLevelUpEquipmentStar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache45);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CalculateLevelUpEquipmentStarGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache46);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_LevelUpEquipmentStar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache47);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CalculateEquipmentTotalExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache48);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_CalculateDecomposeEquipmentBackGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache49);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_OutPutItemOperationLog);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4A);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_OnSaveEnchantSaveMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4B);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_OnEnchantMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4C);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.__callBase_OnCreateBagItemEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4D);
		if (Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BagComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_BagComponent.<>f__mg$cache4E, typeof(BagComponent), typeof(BagComponentCommon));
	}

	// Token: 0x0400F627 RID: 63015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F628 RID: 63016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F629 RID: 63017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F62A RID: 63018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F62B RID: 63019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F62C RID: 63020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F62D RID: 63021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F62E RID: 63022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F62F RID: 63023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F630 RID: 63024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F631 RID: 63025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F632 RID: 63026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F633 RID: 63027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F634 RID: 63028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F635 RID: 63029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F636 RID: 63030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F637 RID: 63031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F638 RID: 63032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F639 RID: 63033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F63A RID: 63034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F63B RID: 63035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F63C RID: 63036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F63D RID: 63037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F63E RID: 63038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F63F RID: 63039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F640 RID: 63040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F641 RID: 63041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F642 RID: 63042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F643 RID: 63043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F644 RID: 63044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F645 RID: 63045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F646 RID: 63046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F647 RID: 63047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F648 RID: 63048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F649 RID: 63049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F64A RID: 63050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F64B RID: 63051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F64C RID: 63052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F64D RID: 63053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F64E RID: 63054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F64F RID: 63055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F650 RID: 63056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F651 RID: 63057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F652 RID: 63058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F653 RID: 63059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F654 RID: 63060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F655 RID: 63061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F656 RID: 63062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F657 RID: 63063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F658 RID: 63064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F659 RID: 63065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F65A RID: 63066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F65B RID: 63067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400F65C RID: 63068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400F65D RID: 63069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400F65E RID: 63070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400F65F RID: 63071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400F660 RID: 63072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400F661 RID: 63073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400F662 RID: 63074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400F663 RID: 63075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400F664 RID: 63076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400F665 RID: 63077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400F666 RID: 63078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400F667 RID: 63079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400F668 RID: 63080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400F669 RID: 63081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400F66A RID: 63082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400F66B RID: 63083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400F66C RID: 63084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400F66D RID: 63085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400F66E RID: 63086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400F66F RID: 63087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400F670 RID: 63088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400F671 RID: 63089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400F672 RID: 63090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400F673 RID: 63091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400F674 RID: 63092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400F675 RID: 63093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;
}
