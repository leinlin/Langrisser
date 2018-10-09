using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001587 RID: 5511
[Preserve]
public class Lua_BlackJack_ProjectL_UI_StoreItemUIController : LuaObject
{
	// Token: 0x06021285 RID: 135813 RVA: 0x00B2A7F0 File Offset: 0x00B289F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFixedStoreItemInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			FixedStoreItem fixedStoreItemInfo;
			LuaObject.checkType<FixedStoreItem>(l, 2, out fixedStoreItemInfo);
			storeItemUIController.SetFixedStoreItemInfo(fixedStoreItemInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021286 RID: 135814 RVA: 0x00B2A848 File Offset: 0x00B28A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomStoreItemInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			RandomStoreItem item;
			LuaObject.checkType<RandomStoreItem>(l, 2, out item);
			int itemIndex;
			LuaObject.checkType(l, 3, out itemIndex);
			storeItemUIController.SetRandomStoreItemInfo(item, itemIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021287 RID: 135815 RVA: 0x00B2A8AC File Offset: 0x00B28AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRechargeStoreItemInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			StoreType storeType;
			LuaObject.checkEnum<StoreType>(l, 3, out storeType);
			bool isGoodsBought;
			LuaObject.checkType(l, 4, out isGoodsBought);
			double goodsPrice;
			LuaObject.checkType(l, 5, out goodsPrice);
			string goodsName;
			LuaObject.checkType(l, 6, out goodsName);
			int cystalRewardNums;
			LuaObject.checkType(l, 7, out cystalRewardNums);
			string icon;
			LuaObject.checkType(l, 8, out icon);
			storeItemUIController.SetRechargeStoreItemInfo(goodsId, storeType, isGoodsBought, goodsPrice, goodsName, cystalRewardNums, icon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021288 RID: 135816 RVA: 0x00B2A950 File Offset: 0x00B28B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGiftStoreItemInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GiftStoreItem item;
			LuaObject.checkType<GiftStoreItem>(l, 2, out item);
			double price;
			LuaObject.checkType(l, 3, out price);
			PDSDKGoodType goodPDSDKType;
			LuaObject.checkEnum<PDSDKGoodType>(l, 4, out goodPDSDKType);
			storeItemUIController.SetGiftStoreItemInfo(item, price, goodPDSDKType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021289 RID: 135817 RVA: 0x00B2A9C4 File Offset: 0x00B28BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGiftStoreMothCardItemInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GiftStoreItem item;
			LuaObject.checkType<GiftStoreItem>(l, 2, out item);
			double price;
			LuaObject.checkType(l, 3, out price);
			PDSDKGoodType goodPDSDKType;
			LuaObject.checkEnum<PDSDKGoodType>(l, 4, out goodPDSDKType);
			storeItemUIController.SetGiftStoreMothCardItemInfo(item, price, goodPDSDKType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602128A RID: 135818 RVA: 0x00B2AA38 File Offset: 0x00B28C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			storeItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602128B RID: 135819 RVA: 0x00B2AA8C File Offset: 0x00B28C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStoreItemClick(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			storeItemUIController.m_luaExportHelper.OnStoreItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602128C RID: 135820 RVA: 0x00B2AAE0 File Offset: 0x00B28CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLabel(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
				ConfigDataFixedStoreItemInfo label;
				LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out label);
				storeItemUIController.m_luaExportHelper.SetLabel(label);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				StoreItemUIController storeItemUIController2 = (StoreItemUIController)LuaObject.checkSelf(l);
				storeItemUIController2.m_luaExportHelper.SetLabel();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetLabel to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602128D RID: 135821 RVA: 0x00B2AB94 File Offset: 0x00B28D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLabel_RMB_Recharge(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			bool label_RMB_Recharge;
			LuaObject.checkType(l, 2, out label_RMB_Recharge);
			storeItemUIController.m_luaExportHelper.SetLabel_RMB_Recharge(label_RMB_Recharge);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602128E RID: 135822 RVA: 0x00B2ABF0 File Offset: 0x00B28DF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPrice(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(FixedStoreItem)))
			{
				StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
				FixedStoreItem price;
				LuaObject.checkType<FixedStoreItem>(l, 2, out price);
				storeItemUIController.m_luaExportHelper.SetPrice(price);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ConfigDataRandomStoreItemInfo)))
			{
				StoreItemUIController storeItemUIController2 = (StoreItemUIController)LuaObject.checkSelf(l);
				ConfigDataRandomStoreItemInfo price2;
				LuaObject.checkType<ConfigDataRandomStoreItemInfo>(l, 2, out price2);
				storeItemUIController2.m_luaExportHelper.SetPrice(price2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetPrice to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602128F RID: 135823 RVA: 0x00B2ACD0 File Offset: 0x00B28ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPrice_RMB(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			double price_RMB;
			LuaObject.checkType(l, 2, out price_RMB);
			storeItemUIController.m_luaExportHelper.SetPrice_RMB(price_RMB);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021290 RID: 135824 RVA: 0x00B2AD2C File Offset: 0x00B28F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLimit(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
				storeItemUIController.m_luaExportHelper.SetLimit();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(GiftStoreItem), typeof(ConfigDataGiftStoreItemInfo)))
			{
				StoreItemUIController storeItemUIController2 = (StoreItemUIController)LuaObject.checkSelf(l);
				GiftStoreItem item;
				LuaObject.checkType<GiftStoreItem>(l, 2, out item);
				ConfigDataGiftStoreItemInfo giftStoreItemInfo;
				LuaObject.checkType<ConfigDataGiftStoreItemInfo>(l, 3, out giftStoreItemInfo);
				storeItemUIController2.m_luaExportHelper.SetLimit(item, giftStoreItemInfo);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(FixedStoreItem), typeof(ConfigDataFixedStoreItemInfo)))
			{
				StoreItemUIController storeItemUIController3 = (StoreItemUIController)LuaObject.checkSelf(l);
				FixedStoreItem item2;
				LuaObject.checkType<FixedStoreItem>(l, 2, out item2);
				ConfigDataFixedStoreItemInfo fixedStoreItemInfo;
				LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 3, out fixedStoreItemInfo);
				storeItemUIController3.m_luaExportHelper.SetLimit(item2, fixedStoreItemInfo);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetLimit to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021291 RID: 135825 RVA: 0x00B2AE70 File Offset: 0x00B29070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HaveFirstBuyReward(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo fixedStoreItemInfo;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out fixedStoreItemInfo);
			bool b = storeItemUIController.m_luaExportHelper.HaveFirstBuyReward(fixedStoreItemInfo);
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

	// Token: 0x06021292 RID: 135826 RVA: 0x00B2AED8 File Offset: 0x00B290D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLimit_RMB(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			bool isGoodsBought;
			LuaObject.checkType(l, 2, out isGoodsBought);
			int crystalNums;
			LuaObject.checkType(l, 3, out crystalNums);
			storeItemUIController.m_luaExportHelper.SetLimit_RMB(isGoodsBought, crystalNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021293 RID: 135827 RVA: 0x00B2AF44 File Offset: 0x00B29144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSellOut(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(FixedStoreItem)))
			{
				StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
				FixedStoreItem sellOut;
				LuaObject.checkType<FixedStoreItem>(l, 2, out sellOut);
				storeItemUIController.m_luaExportHelper.SetSellOut(sellOut);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RandomStoreItem)))
			{
				StoreItemUIController storeItemUIController2 = (StoreItemUIController)LuaObject.checkSelf(l);
				RandomStoreItem sellOut2;
				LuaObject.checkType<RandomStoreItem>(l, 2, out sellOut2);
				storeItemUIController2.m_luaExportHelper.SetSellOut(sellOut2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(GiftStoreItem)))
			{
				StoreItemUIController storeItemUIController3 = (StoreItemUIController)LuaObject.checkSelf(l);
				GiftStoreItem sellOut3;
				LuaObject.checkType<GiftStoreItem>(l, 2, out sellOut3);
				storeItemUIController3.m_luaExportHelper.SetSellOut(sellOut3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				StoreItemUIController storeItemUIController4 = (StoreItemUIController)LuaObject.checkSelf(l);
				storeItemUIController4.m_luaExportHelper.SetSellOut();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetSellOut to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021294 RID: 135828 RVA: 0x00B2B0A8 File Offset: 0x00B292A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRemoveTime(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			DateTime removeTime;
			LuaObject.checkValueType<DateTime>(l, 2, out removeTime);
			storeItemUIController.m_luaExportHelper.SetRemoveTime(removeTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021295 RID: 135829 RVA: 0x00B2B104 File Offset: 0x00B29304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateIcon(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GoodsType goodType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodType);
			int itemId;
			LuaObject.checkType(l, 3, out itemId);
			int num;
			LuaObject.checkType(l, 4, out num);
			storeItemUIController.m_luaExportHelper.UpdateIcon(goodType, itemId, num);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021296 RID: 135830 RVA: 0x00B2B17C File Offset: 0x00B2937C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateIcon_RMB(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			storeItemUIController.m_luaExportHelper.UpdateIcon_RMB(icon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021297 RID: 135831 RVA: 0x00B2B1D8 File Offset: 0x00B293D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNoFrameInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GoodsType goodType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			storeItemUIController.m_luaExportHelper.SetNoFrameInfo(goodType, goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021298 RID: 135832 RVA: 0x00B2B244 File Offset: 0x00B29444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGeneralGoodInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			int generalGoodInfo;
			LuaObject.checkType(l, 2, out generalGoodInfo);
			storeItemUIController.m_luaExportHelper.SetGeneralGoodInfo(generalGoodInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021299 RID: 135833 RVA: 0x00B2B2A0 File Offset: 0x00B294A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFrameNameAndSetSSR(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string frameNameAndSetSSR = storeItemUIController.m_luaExportHelper.GetFrameNameAndSetSSR();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameNameAndSetSSR);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602129A RID: 135834 RVA: 0x00B2B2FC File Offset: 0x00B294FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomStoreItemNotShow(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			storeItemUIController.m_luaExportHelper.SetRandomStoreItemNotShow();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602129B RID: 135835 RVA: 0x00B2B350 File Offset: 0x00B29550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLeftDays(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string leftDays;
			LuaObject.checkType(l, 2, out leftDays);
			storeItemUIController.m_luaExportHelper.SetLeftDays(leftDays);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602129C RID: 135836 RVA: 0x00B2B3AC File Offset: 0x00B295AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetItemDefaultState(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			storeItemUIController.m_luaExportHelper.SetItemDefaultState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602129D RID: 135837 RVA: 0x00B2B400 File Offset: 0x00B29600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			storeItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602129E RID: 135838 RVA: 0x00B2B46C File Offset: 0x00B2966C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			storeItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602129F RID: 135839 RVA: 0x00B2B4C0 File Offset: 0x00B296C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			storeItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212A0 RID: 135840 RVA: 0x00B2B514 File Offset: 0x00B29714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = storeItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060212A1 RID: 135841 RVA: 0x00B2B5BC File Offset: 0x00B297BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			storeItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212A2 RID: 135842 RVA: 0x00B2B610 File Offset: 0x00B29810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			storeItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212A3 RID: 135843 RVA: 0x00B2B67C File Offset: 0x00B2987C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				storeItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				StoreItemUIController storeItemUIController2 = (StoreItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				storeItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212A4 RID: 135844 RVA: 0x00B2B78C File Offset: 0x00B2998C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212A5 RID: 135845 RVA: 0x00B2B7F8 File Offset: 0x00B299F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212A6 RID: 135846 RVA: 0x00B2B864 File Offset: 0x00B29A64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212A7 RID: 135847 RVA: 0x00B2B8D0 File Offset: 0x00B29AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212A8 RID: 135848 RVA: 0x00B2B93C File Offset: 0x00B29B3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				storeItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				StoreItemUIController storeItemUIController2 = (StoreItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				storeItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212A9 RID: 135849 RVA: 0x00B2BA4C File Offset: 0x00B29C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string s = storeItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060212AA RID: 135850 RVA: 0x00B2BAA8 File Offset: 0x00B29CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			StoreItemUIController obj;
			LuaObject.checkType<StoreItemUIController>(l, 2, out obj);
			storeItemUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212AB RID: 135851 RVA: 0x00B2BB04 File Offset: 0x00B29D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			StoreItemUIController obj;
			LuaObject.checkType<StoreItemUIController>(l, 2, out obj);
			storeItemUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212AC RID: 135852 RVA: 0x00B2BB60 File Offset: 0x00B29D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodPDSDKType(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeItemUIController.m_luaExportHelper.m_goodPDSDKType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212AD RID: 135853 RVA: 0x00B2BBB8 File Offset: 0x00B29DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodPDSDKType(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			PDSDKGoodType goodPDSDKType;
			LuaObject.checkEnum<PDSDKGoodType>(l, 2, out goodPDSDKType);
			storeItemUIController.m_luaExportHelper.m_goodPDSDKType = goodPDSDKType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212AE RID: 135854 RVA: 0x00B2BC14 File Offset: 0x00B29E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Action<StoreItemUIController> value;
			int num = LuaObject.checkDelegate<Action<StoreItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					storeItemUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					storeItemUIController.EventOnClick -= value;
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

	// Token: 0x060212AF RID: 135855 RVA: 0x00B2BC94 File Offset: 0x00B29E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PriceState_OtherItem(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, StoreItemUIController.LuaExportHelper.PriceState_OtherItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212B0 RID: 135856 RVA: 0x00B2BCDC File Offset: 0x00B29EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PriceState_Crystal(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, StoreItemUIController.LuaExportHelper.PriceState_Crystal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212B1 RID: 135857 RVA: 0x00B2BD24 File Offset: 0x00B29F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PriceState_RMBIcon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, StoreItemUIController.LuaExportHelper.PriceState_RMBIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212B2 RID: 135858 RVA: 0x00B2BD6C File Offset: 0x00B29F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeItemButton(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_storeItemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212B3 RID: 135859 RVA: 0x00B2BDC4 File Offset: 0x00B29FC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeItemButton(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Button storeItemButton;
			LuaObject.checkType<Button>(l, 2, out storeItemButton);
			storeItemUIController.m_luaExportHelper.m_storeItemButton = storeItemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212B4 RID: 135860 RVA: 0x00B2BE20 File Offset: 0x00B2A020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemUIStateController(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_itemUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212B5 RID: 135861 RVA: 0x00B2BE78 File Offset: 0x00B2A078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemUIStateController(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController itemUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out itemUIStateController);
			storeItemUIController.m_luaExportHelper.m_itemUIStateController = itemUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212B6 RID: 135862 RVA: 0x00B2BED4 File Offset: 0x00B2A0D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_generalGoodObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_generalGoodObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212B7 RID: 135863 RVA: 0x00B2BF2C File Offset: 0x00B2A12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_generalGoodObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject generalGoodObj;
			LuaObject.checkType<GameObject>(l, 2, out generalGoodObj);
			storeItemUIController.m_luaExportHelper.m_generalGoodObj = generalGoodObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212B8 RID: 135864 RVA: 0x00B2BF88 File Offset: 0x00B2A188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_generalGoodIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_generalGoodIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212B9 RID: 135865 RVA: 0x00B2BFE0 File Offset: 0x00B2A1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_generalGoodIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Image generalGoodIconImage;
			LuaObject.checkType<Image>(l, 2, out generalGoodIconImage);
			storeItemUIController.m_luaExportHelper.m_generalGoodIconImage = generalGoodIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212BA RID: 135866 RVA: 0x00B2C03C File Offset: 0x00B2A23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_generalGoodFrameImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_generalGoodFrameImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212BB RID: 135867 RVA: 0x00B2C094 File Offset: 0x00B2A294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_generalGoodFrameImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Image generalGoodFrameImage;
			LuaObject.checkType<Image>(l, 2, out generalGoodFrameImage);
			storeItemUIController.m_luaExportHelper.m_generalGoodFrameImage = generalGoodFrameImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212BC RID: 135868 RVA: 0x00B2C0F0 File Offset: 0x00B2A2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrEffectImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_ssrEffectImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212BD RID: 135869 RVA: 0x00B2C148 File Offset: 0x00B2A348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrEffectImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Image ssrEffectImage;
			LuaObject.checkType<Image>(l, 2, out ssrEffectImage);
			storeItemUIController.m_luaExportHelper.m_ssrEffectImage = ssrEffectImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212BE RID: 135870 RVA: 0x00B2C1A4 File Offset: 0x00B2A3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_generalGoodCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_generalGoodCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212BF RID: 135871 RVA: 0x00B2C1FC File Offset: 0x00B2A3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_generalGoodCountText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Text generalGoodCountText;
			LuaObject.checkType<Text>(l, 2, out generalGoodCountText);
			storeItemUIController.m_luaExportHelper.m_generalGoodCountText = generalGoodCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212C0 RID: 135872 RVA: 0x00B2C258 File Offset: 0x00B2A458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spineAnimObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_spineAnimObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212C1 RID: 135873 RVA: 0x00B2C2B0 File Offset: 0x00B2A4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_spineAnimObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject spineAnimObj;
			LuaObject.checkType<GameObject>(l, 2, out spineAnimObj);
			storeItemUIController.m_luaExportHelper.m_spineAnimObj = spineAnimObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212C2 RID: 135874 RVA: 0x00B2C30C File Offset: 0x00B2A50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noFrameItemObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_noFrameItemObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212C3 RID: 135875 RVA: 0x00B2C364 File Offset: 0x00B2A564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noFrameItemObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject noFrameItemObj;
			LuaObject.checkType<GameObject>(l, 2, out noFrameItemObj);
			storeItemUIController.m_luaExportHelper.m_noFrameItemObj = noFrameItemObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212C4 RID: 135876 RVA: 0x00B2C3C0 File Offset: 0x00B2A5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_noFrameItemIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_noFrameItemIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212C5 RID: 135877 RVA: 0x00B2C418 File Offset: 0x00B2A618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_noFrameItemIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Image noFrameItemIconImage;
			LuaObject.checkType<Image>(l, 2, out noFrameItemIconImage);
			storeItemUIController.m_luaExportHelper.m_noFrameItemIconImage = noFrameItemIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212C6 RID: 135878 RVA: 0x00B2C474 File Offset: 0x00B2A674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargeItemObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_rechargeItemObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212C7 RID: 135879 RVA: 0x00B2C4CC File Offset: 0x00B2A6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargeItemObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject rechargeItemObj;
			LuaObject.checkType<GameObject>(l, 2, out rechargeItemObj);
			storeItemUIController.m_luaExportHelper.m_rechargeItemObj = rechargeItemObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212C8 RID: 135880 RVA: 0x00B2C528 File Offset: 0x00B2A728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rechargeItemIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_rechargeItemIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212C9 RID: 135881 RVA: 0x00B2C580 File Offset: 0x00B2A780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargeItemIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Image rechargeItemIconImage;
			LuaObject.checkType<Image>(l, 2, out rechargeItemIconImage);
			storeItemUIController.m_luaExportHelper.m_rechargeItemIconImage = rechargeItemIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212CA RID: 135882 RVA: 0x00B2C5DC File Offset: 0x00B2A7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_limitObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_limitObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212CB RID: 135883 RVA: 0x00B2C634 File Offset: 0x00B2A834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_limitObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject limitObj;
			LuaObject.checkType<GameObject>(l, 2, out limitObj);
			storeItemUIController.m_luaExportHelper.m_limitObj = limitObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212CC RID: 135884 RVA: 0x00B2C690 File Offset: 0x00B2A890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_limitText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_limitText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212CD RID: 135885 RVA: 0x00B2C6E8 File Offset: 0x00B2A8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_limitText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Text limitText;
			LuaObject.checkType<Text>(l, 2, out limitText);
			storeItemUIController.m_luaExportHelper.m_limitText = limitText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212CE RID: 135886 RVA: 0x00B2C744 File Offset: 0x00B2A944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_disableBuyObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_disableBuyObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212CF RID: 135887 RVA: 0x00B2C79C File Offset: 0x00B2A99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_disableBuyObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject disableBuyObj;
			LuaObject.checkType<GameObject>(l, 2, out disableBuyObj);
			storeItemUIController.m_luaExportHelper.m_disableBuyObj = disableBuyObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212D0 RID: 135888 RVA: 0x00B2C7F8 File Offset: 0x00B2A9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_disableBuyRefreshObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_disableBuyRefreshObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212D1 RID: 135889 RVA: 0x00B2C850 File Offset: 0x00B2AA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_disableBuyRefreshObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject disableBuyRefreshObj;
			LuaObject.checkType<GameObject>(l, 2, out disableBuyRefreshObj);
			storeItemUIController.m_luaExportHelper.m_disableBuyRefreshObj = disableBuyRefreshObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212D2 RID: 135890 RVA: 0x00B2C8AC File Offset: 0x00B2AAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_refreshOrRemoveTimeText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_refreshOrRemoveTimeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212D3 RID: 135891 RVA: 0x00B2C904 File Offset: 0x00B2AB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_refreshOrRemoveTimeText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Text refreshOrRemoveTimeText;
			LuaObject.checkType<Text>(l, 2, out refreshOrRemoveTimeText);
			storeItemUIController.m_luaExportHelper.m_refreshOrRemoveTimeText = refreshOrRemoveTimeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212D4 RID: 135892 RVA: 0x00B2C960 File Offset: 0x00B2AB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_disableBuyOnlyObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_disableBuyOnlyObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212D5 RID: 135893 RVA: 0x00B2C9B8 File Offset: 0x00B2ABB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_disableBuyOnlyObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject disableBuyOnlyObj;
			LuaObject.checkType<GameObject>(l, 2, out disableBuyOnlyObj);
			storeItemUIController.m_luaExportHelper.m_disableBuyOnlyObj = disableBuyOnlyObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212D6 RID: 135894 RVA: 0x00B2CA14 File Offset: 0x00B2AC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extraPresentGameObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_extraPresentGameObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212D7 RID: 135895 RVA: 0x00B2CA6C File Offset: 0x00B2AC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extraPresentGameObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject extraPresentGameObj;
			LuaObject.checkType<GameObject>(l, 2, out extraPresentGameObj);
			storeItemUIController.m_luaExportHelper.m_extraPresentGameObj = extraPresentGameObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212D8 RID: 135896 RVA: 0x00B2CAC8 File Offset: 0x00B2ACC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extraPresentText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_extraPresentText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212D9 RID: 135897 RVA: 0x00B2CB20 File Offset: 0x00B2AD20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extraPresentText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Text extraPresentText;
			LuaObject.checkType<Text>(l, 2, out extraPresentText);
			storeItemUIController.m_luaExportHelper.m_extraPresentText = extraPresentText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212DA RID: 135898 RVA: 0x00B2CB7C File Offset: 0x00B2AD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_itemNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212DB RID: 135899 RVA: 0x00B2CBD4 File Offset: 0x00B2ADD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Text itemNameText;
			LuaObject.checkType<Text>(l, 2, out itemNameText);
			storeItemUIController.m_luaExportHelper.m_itemNameText = itemNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212DC RID: 135900 RVA: 0x00B2CC30 File Offset: 0x00B2AE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentedPanelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_presentedPanelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212DD RID: 135901 RVA: 0x00B2CC88 File Offset: 0x00B2AE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentedPanelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject presentedPanelObj;
			LuaObject.checkType<GameObject>(l, 2, out presentedPanelObj);
			storeItemUIController.m_luaExportHelper.m_presentedPanelObj = presentedPanelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212DE RID: 135902 RVA: 0x00B2CCE4 File Offset: 0x00B2AEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_presentedText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_presentedText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212DF RID: 135903 RVA: 0x00B2CD3C File Offset: 0x00B2AF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_presentedText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Text presentedText;
			LuaObject.checkType<Text>(l, 2, out presentedText);
			storeItemUIController.m_luaExportHelper.m_presentedText = presentedText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212E0 RID: 135904 RVA: 0x00B2CD98 File Offset: 0x00B2AF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_priceIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_priceIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212E1 RID: 135905 RVA: 0x00B2CDF0 File Offset: 0x00B2AFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_priceIconImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Image priceIconImage;
			LuaObject.checkType<Image>(l, 2, out priceIconImage);
			storeItemUIController.m_luaExportHelper.m_priceIconImage = priceIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212E2 RID: 135906 RVA: 0x00B2CE4C File Offset: 0x00B2B04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_priceCrystalImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_priceCrystalImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212E3 RID: 135907 RVA: 0x00B2CEA4 File Offset: 0x00B2B0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_priceCrystalImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Image priceCrystalImage;
			LuaObject.checkType<Image>(l, 2, out priceCrystalImage);
			storeItemUIController.m_luaExportHelper.m_priceCrystalImage = priceCrystalImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212E4 RID: 135908 RVA: 0x00B2CF00 File Offset: 0x00B2B100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_priceRMBImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_priceRMBImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212E5 RID: 135909 RVA: 0x00B2CF58 File Offset: 0x00B2B158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_priceRMBImage(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Image priceRMBImage;
			LuaObject.checkType<Image>(l, 2, out priceRMBImage);
			storeItemUIController.m_luaExportHelper.m_priceRMBImage = priceRMBImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212E6 RID: 135910 RVA: 0x00B2CFB4 File Offset: 0x00B2B1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_priceText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_priceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212E7 RID: 135911 RVA: 0x00B2D00C File Offset: 0x00B2B20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_priceText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Text priceText;
			LuaObject.checkType<Text>(l, 2, out priceText);
			storeItemUIController.m_luaExportHelper.m_priceText = priceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212E8 RID: 135912 RVA: 0x00B2D068 File Offset: 0x00B2B268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pricePanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_pricePanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212E9 RID: 135913 RVA: 0x00B2D0C0 File Offset: 0x00B2B2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pricePanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController pricePanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out pricePanelStateCtrl);
			storeItemUIController.m_luaExportHelper.m_pricePanelStateCtrl = pricePanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212EA RID: 135914 RVA: 0x00B2D11C File Offset: 0x00B2B31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_labelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_labelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212EB RID: 135915 RVA: 0x00B2D174 File Offset: 0x00B2B374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_labelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject labelObj;
			LuaObject.checkType<GameObject>(l, 2, out labelObj);
			storeItemUIController.m_luaExportHelper.m_labelObj = labelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212EC RID: 135916 RVA: 0x00B2D1D0 File Offset: 0x00B2B3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commendLabelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_commendLabelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212ED RID: 135917 RVA: 0x00B2D228 File Offset: 0x00B2B428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commendLabelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject commendLabelObj;
			LuaObject.checkType<GameObject>(l, 2, out commendLabelObj);
			storeItemUIController.m_luaExportHelper.m_commendLabelObj = commendLabelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212EE RID: 135918 RVA: 0x00B2D284 File Offset: 0x00B2B484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_discountLabelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_discountLabelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212EF RID: 135919 RVA: 0x00B2D2DC File Offset: 0x00B2B4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_discountLabelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject discountLabelObj;
			LuaObject.checkType<GameObject>(l, 2, out discountLabelObj);
			storeItemUIController.m_luaExportHelper.m_discountLabelObj = discountLabelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212F0 RID: 135920 RVA: 0x00B2D338 File Offset: 0x00B2B538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_firstDiscountLabelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_firstDiscountLabelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212F1 RID: 135921 RVA: 0x00B2D390 File Offset: 0x00B2B590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_firstDiscountLabelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject firstDiscountLabelObj;
			LuaObject.checkType<GameObject>(l, 2, out firstDiscountLabelObj);
			storeItemUIController.m_luaExportHelper.m_firstDiscountLabelObj = firstDiscountLabelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212F2 RID: 135922 RVA: 0x00B2D3EC File Offset: 0x00B2B5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_limitTimeLabelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_limitTimeLabelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212F3 RID: 135923 RVA: 0x00B2D444 File Offset: 0x00B2B644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_limitTimeLabelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject limitTimeLabelObj;
			LuaObject.checkType<GameObject>(l, 2, out limitTimeLabelObj);
			storeItemUIController.m_luaExportHelper.m_limitTimeLabelObj = limitTimeLabelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212F4 RID: 135924 RVA: 0x00B2D4A0 File Offset: 0x00B2B6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_firstLabelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_firstLabelObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212F5 RID: 135925 RVA: 0x00B2D4F8 File Offset: 0x00B2B6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_firstLabelObj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject firstLabelObj;
			LuaObject.checkType<GameObject>(l, 2, out firstLabelObj);
			storeItemUIController.m_luaExportHelper.m_firstLabelObj = firstLabelObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212F6 RID: 135926 RVA: 0x00B2D554 File Offset: 0x00B2B754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_LeftDayGameobj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_LeftDayGameobj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212F7 RID: 135927 RVA: 0x00B2D5AC File Offset: 0x00B2B7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_LeftDayGameobj(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GameObject leftDayGameobj;
			LuaObject.checkType<GameObject>(l, 2, out leftDayGameobj);
			storeItemUIController.m_luaExportHelper.m_LeftDayGameobj = leftDayGameobj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212F8 RID: 135928 RVA: 0x00B2D608 File Offset: 0x00B2B808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_LeftDayText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_LeftDayText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212F9 RID: 135929 RVA: 0x00B2D660 File Offset: 0x00B2B860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_LeftDayText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Text leftDayText;
			LuaObject.checkType<Text>(l, 2, out leftDayText);
			storeItemUIController.m_luaExportHelper.m_LeftDayText = leftDayText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212FA RID: 135930 RVA: 0x00B2D6BC File Offset: 0x00B2B8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countString(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_countString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212FB RID: 135931 RVA: 0x00B2D714 File Offset: 0x00B2B914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countString(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string countString;
			LuaObject.checkType(l, 2, out countString);
			storeItemUIController.m_luaExportHelper.m_countString = countString;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212FC RID: 135932 RVA: 0x00B2D770 File Offset: 0x00B2B970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSSR(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_isSSR);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212FD RID: 135933 RVA: 0x00B2D7C8 File Offset: 0x00B2B9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSSR(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			bool isSSR;
			LuaObject.checkType(l, 2, out isSSR);
			storeItemUIController.m_luaExportHelper.m_isSSR = isSSR;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212FE RID: 135934 RVA: 0x00B2D824 File Offset: 0x00B2BA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeType(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeItemUIController.m_storeType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060212FF RID: 135935 RVA: 0x00B2D878 File Offset: 0x00B2BA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeType(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			StoreType storeType;
			LuaObject.checkEnum<StoreType>(l, 2, out storeType);
			storeItemUIController.m_storeType = storeType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021300 RID: 135936 RVA: 0x00B2D8D0 File Offset: 0x00B2BAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeItemUIController.m_goodsType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021301 RID: 135937 RVA: 0x00B2D924 File Offset: 0x00B2BB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			storeItemUIController.m_goodsType = goodsType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021302 RID: 135938 RVA: 0x00B2D97C File Offset: 0x00B2BB7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fixedStoreItemGoodsID(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_fixedStoreItemGoodsID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021303 RID: 135939 RVA: 0x00B2D9D0 File Offset: 0x00B2BBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fixedStoreItemGoodsID(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			int fixedStoreItemGoodsID;
			LuaObject.checkType(l, 2, out fixedStoreItemGoodsID);
			storeItemUIController.m_fixedStoreItemGoodsID = fixedStoreItemGoodsID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021304 RID: 135940 RVA: 0x00B2DA28 File Offset: 0x00B2BC28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsID(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_goodsID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021305 RID: 135941 RVA: 0x00B2DA7C File Offset: 0x00B2BC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsID(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			int goodsID;
			LuaObject.checkType(l, 2, out goodsID);
			storeItemUIController.m_goodsID = goodsID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021306 RID: 135942 RVA: 0x00B2DAD4 File Offset: 0x00B2BCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021307 RID: 135943 RVA: 0x00B2DB28 File Offset: 0x00B2BD28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			storeItemUIController.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021308 RID: 135944 RVA: 0x00B2DB80 File Offset: 0x00B2BD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_haveFirstBuyReward(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_haveFirstBuyReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021309 RID: 135945 RVA: 0x00B2DBD4 File Offset: 0x00B2BDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_haveFirstBuyReward(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			bool haveFirstBuyReward;
			LuaObject.checkType(l, 2, out haveFirstBuyReward);
			storeItemUIController.m_haveFirstBuyReward = haveFirstBuyReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602130A RID: 135946 RVA: 0x00B2DC2C File Offset: 0x00B2BE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extraCurrencyType(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeItemUIController.m_extraCurrencyType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602130B RID: 135947 RVA: 0x00B2DC80 File Offset: 0x00B2BE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extraCurrencyType(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GoodsType extraCurrencyType;
			LuaObject.checkEnum<GoodsType>(l, 2, out extraCurrencyType);
			storeItemUIController.m_extraCurrencyType = extraCurrencyType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602130C RID: 135948 RVA: 0x00B2DCD8 File Offset: 0x00B2BED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currentGoodCurrencyType(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeItemUIController.m_currentGoodCurrencyType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602130D RID: 135949 RVA: 0x00B2DD2C File Offset: 0x00B2BF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currentGoodCurrencyType(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GoodsType currentGoodCurrencyType;
			LuaObject.checkEnum<GoodsType>(l, 2, out currentGoodCurrencyType);
			storeItemUIController.m_currentGoodCurrencyType = currentGoodCurrencyType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602130E RID: 135950 RVA: 0x00B2DD84 File Offset: 0x00B2BF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extraCurrencyTypeIconString(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_extraCurrencyTypeIconString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602130F RID: 135951 RVA: 0x00B2DDD8 File Offset: 0x00B2BFD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extraCurrencyTypeIconString(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string extraCurrencyTypeIconString;
			LuaObject.checkType(l, 2, out extraCurrencyTypeIconString);
			storeItemUIController.m_extraCurrencyTypeIconString = extraCurrencyTypeIconString;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021310 RID: 135952 RVA: 0x00B2DE30 File Offset: 0x00B2C030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_extraCurrencyCount(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_extraCurrencyCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021311 RID: 135953 RVA: 0x00B2DE84 File Offset: 0x00B2C084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_extraCurrencyCount(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			int extraCurrencyCount;
			LuaObject.checkType(l, 2, out extraCurrencyCount);
			storeItemUIController.m_extraCurrencyCount = extraCurrencyCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021312 RID: 135954 RVA: 0x00B2DEDC File Offset: 0x00B2C0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_giftStoreItem(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_giftStoreItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021313 RID: 135955 RVA: 0x00B2DF30 File Offset: 0x00B2C130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_giftStoreItem(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			GiftStoreItem giftStoreItem;
			LuaObject.checkType<GiftStoreItem>(l, 2, out giftStoreItem);
			storeItemUIController.m_giftStoreItem = giftStoreItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021314 RID: 135956 RVA: 0x00B2DF88 File Offset: 0x00B2C188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021315 RID: 135957 RVA: 0x00B2DFE0 File Offset: 0x00B2C1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			storeItemUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021316 RID: 135958 RVA: 0x00B2E03C File Offset: 0x00B2C23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021317 RID: 135959 RVA: 0x00B2E094 File Offset: 0x00B2C294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			storeItemUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021318 RID: 135960 RVA: 0x00B2E0F0 File Offset: 0x00B2C2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.m_luaExportHelper.m_clientConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021319 RID: 135961 RVA: 0x00B2E148 File Offset: 0x00B2C348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			ClientConfigDataLoader clientConfigDataLoader;
			LuaObject.checkType<ClientConfigDataLoader>(l, 2, out clientConfigDataLoader);
			storeItemUIController.m_luaExportHelper.m_clientConfigDataLoader = clientConfigDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602131A RID: 135962 RVA: 0x00B2E1A4 File Offset: 0x00B2C3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Count(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.Count);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602131B RID: 135963 RVA: 0x00B2E1F8 File Offset: 0x00B2C3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Count(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			string count;
			LuaObject.checkType(l, 2, out count);
			storeItemUIController.m_luaExportHelper.Count = count;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602131C RID: 135964 RVA: 0x00B2E254 File Offset: 0x00B2C454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PriceIcon(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.PriceIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602131D RID: 135965 RVA: 0x00B2E2A8 File Offset: 0x00B2C4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PriceIcon(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Image priceIcon;
			LuaObject.checkType<Image>(l, 2, out priceIcon);
			storeItemUIController.m_luaExportHelper.PriceIcon = priceIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602131E RID: 135966 RVA: 0x00B2E304 File Offset: 0x00B2C504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PriceText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.PriceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602131F RID: 135967 RVA: 0x00B2E358 File Offset: 0x00B2C558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PriceText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Text priceText;
			LuaObject.checkType<Text>(l, 2, out priceText);
			storeItemUIController.m_luaExportHelper.PriceText = priceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021320 RID: 135968 RVA: 0x00B2E3B4 File Offset: 0x00B2C5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.ItemNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021321 RID: 135969 RVA: 0x00B2E408 File Offset: 0x00B2C608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ItemNameText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Text itemNameText;
			LuaObject.checkType<Text>(l, 2, out itemNameText);
			storeItemUIController.m_luaExportHelper.ItemNameText = itemNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021322 RID: 135970 RVA: 0x00B2E464 File Offset: 0x00B2C664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LimitText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeItemUIController.LimitText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021323 RID: 135971 RVA: 0x00B2E4B8 File Offset: 0x00B2C6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LimitText(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			Text limitText;
			LuaObject.checkType<Text>(l, 2, out limitText);
			storeItemUIController.m_luaExportHelper.LimitText = limitText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021324 RID: 135972 RVA: 0x00B2E514 File Offset: 0x00B2C714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoodPDSDKType(IntPtr l)
	{
		int result;
		try
		{
			StoreItemUIController storeItemUIController = (StoreItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)storeItemUIController.GoodPDSDKType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021325 RID: 135973 RVA: 0x00B2E568 File Offset: 0x00B2C768
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.StoreItemUIController");
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetFixedStoreItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetRandomStoreItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetRechargeStoreItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetGiftStoreItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetGiftStoreMothCardItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.OnStoreItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetLabel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetLabel_RMB_Recharge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetPrice);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetPrice_RMB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetLimit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.HaveFirstBuyReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetLimit_RMB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetSellOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetRemoveTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.UpdateIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.UpdateIcon_RMB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetNoFrameInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetGeneralGoodInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.GetFrameNameAndSetSSR);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetRandomStoreItemNotShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetLeftDays);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.SetItemDefaultState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache26);
		string name = "m_goodPDSDKType";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_goodPDSDKType);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_goodPDSDKType);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache28, true);
		string name2 = "EventOnClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache29, true);
		string name3 = "PriceState_OtherItem";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_PriceState_OtherItem);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2A, null, false);
		string name4 = "PriceState_Crystal";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_PriceState_Crystal);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2B, null, false);
		string name5 = "PriceState_RMBIcon";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_PriceState_RMBIcon);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2C, null, false);
		string name6 = "m_storeItemButton";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_storeItemButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_storeItemButton);
		}
		LuaObject.addMember(l, name6, get3, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2E, true);
		string name7 = "m_itemUIStateController";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_itemUIStateController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_itemUIStateController);
		}
		LuaObject.addMember(l, name7, get4, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache30, true);
		string name8 = "m_generalGoodObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_generalGoodObj);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_generalGoodObj);
		}
		LuaObject.addMember(l, name8, get5, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache32, true);
		string name9 = "m_generalGoodIconImage";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_generalGoodIconImage);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_generalGoodIconImage);
		}
		LuaObject.addMember(l, name9, get6, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache34, true);
		string name10 = "m_generalGoodFrameImage";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_generalGoodFrameImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_generalGoodFrameImage);
		}
		LuaObject.addMember(l, name10, get7, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache36, true);
		string name11 = "m_ssrEffectImage";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_ssrEffectImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_ssrEffectImage);
		}
		LuaObject.addMember(l, name11, get8, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache38, true);
		string name12 = "m_generalGoodCountText";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_generalGoodCountText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_generalGoodCountText);
		}
		LuaObject.addMember(l, name12, get9, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3A, true);
		string name13 = "m_spineAnimObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_spineAnimObj);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_spineAnimObj);
		}
		LuaObject.addMember(l, name13, get10, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3C, true);
		string name14 = "m_noFrameItemObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_noFrameItemObj);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_noFrameItemObj);
		}
		LuaObject.addMember(l, name14, get11, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3E, true);
		string name15 = "m_noFrameItemIconImage";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_noFrameItemIconImage);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_noFrameItemIconImage);
		}
		LuaObject.addMember(l, name15, get12, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache40, true);
		string name16 = "m_rechargeItemObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_rechargeItemObj);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_rechargeItemObj);
		}
		LuaObject.addMember(l, name16, get13, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache42, true);
		string name17 = "m_rechargeItemIconImage";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_rechargeItemIconImage);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_rechargeItemIconImage);
		}
		LuaObject.addMember(l, name17, get14, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache44, true);
		string name18 = "m_limitObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_limitObj);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_limitObj);
		}
		LuaObject.addMember(l, name18, get15, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache46, true);
		string name19 = "m_limitText";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_limitText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_limitText);
		}
		LuaObject.addMember(l, name19, get16, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache48, true);
		string name20 = "m_disableBuyObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_disableBuyObj);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_disableBuyObj);
		}
		LuaObject.addMember(l, name20, get17, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4A, true);
		string name21 = "m_disableBuyRefreshObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_disableBuyRefreshObj);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_disableBuyRefreshObj);
		}
		LuaObject.addMember(l, name21, get18, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4C, true);
		string name22 = "m_refreshOrRemoveTimeText";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_refreshOrRemoveTimeText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_refreshOrRemoveTimeText);
		}
		LuaObject.addMember(l, name22, get19, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4E, true);
		string name23 = "m_disableBuyOnlyObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_disableBuyOnlyObj);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_disableBuyOnlyObj);
		}
		LuaObject.addMember(l, name23, get20, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache50, true);
		string name24 = "m_extraPresentGameObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_extraPresentGameObj);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_extraPresentGameObj);
		}
		LuaObject.addMember(l, name24, get21, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache52, true);
		string name25 = "m_extraPresentText";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_extraPresentText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_extraPresentText);
		}
		LuaObject.addMember(l, name25, get22, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache54, true);
		string name26 = "m_itemNameText";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_itemNameText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_itemNameText);
		}
		LuaObject.addMember(l, name26, get23, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache56, true);
		string name27 = "m_presentedPanelObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_presentedPanelObj);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_presentedPanelObj);
		}
		LuaObject.addMember(l, name27, get24, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache58, true);
		string name28 = "m_presentedText";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_presentedText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_presentedText);
		}
		LuaObject.addMember(l, name28, get25, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5A, true);
		string name29 = "m_priceIconImage";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_priceIconImage);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_priceIconImage);
		}
		LuaObject.addMember(l, name29, get26, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5C, true);
		string name30 = "m_priceCrystalImage";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_priceCrystalImage);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_priceCrystalImage);
		}
		LuaObject.addMember(l, name30, get27, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5E, true);
		string name31 = "m_priceRMBImage";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_priceRMBImage);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_priceRMBImage);
		}
		LuaObject.addMember(l, name31, get28, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache60, true);
		string name32 = "m_priceText";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_priceText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_priceText);
		}
		LuaObject.addMember(l, name32, get29, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache62, true);
		string name33 = "m_pricePanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_pricePanelStateCtrl);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_pricePanelStateCtrl);
		}
		LuaObject.addMember(l, name33, get30, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache64, true);
		string name34 = "m_labelObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_labelObj);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_labelObj);
		}
		LuaObject.addMember(l, name34, get31, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache66, true);
		string name35 = "m_commendLabelObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_commendLabelObj);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_commendLabelObj);
		}
		LuaObject.addMember(l, name35, get32, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache68, true);
		string name36 = "m_discountLabelObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_discountLabelObj);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_discountLabelObj);
		}
		LuaObject.addMember(l, name36, get33, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6A, true);
		string name37 = "m_firstDiscountLabelObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_firstDiscountLabelObj);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_firstDiscountLabelObj);
		}
		LuaObject.addMember(l, name37, get34, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6C, true);
		string name38 = "m_limitTimeLabelObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_limitTimeLabelObj);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_limitTimeLabelObj);
		}
		LuaObject.addMember(l, name38, get35, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6E, true);
		string name39 = "m_firstLabelObj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_firstLabelObj);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_firstLabelObj);
		}
		LuaObject.addMember(l, name39, get36, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache70, true);
		string name40 = "m_LeftDayGameobj";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_LeftDayGameobj);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_LeftDayGameobj);
		}
		LuaObject.addMember(l, name40, get37, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache72, true);
		string name41 = "m_LeftDayText";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_LeftDayText);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_LeftDayText);
		}
		LuaObject.addMember(l, name41, get38, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache74, true);
		string name42 = "m_countString";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_countString);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_countString);
		}
		LuaObject.addMember(l, name42, get39, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache76, true);
		string name43 = "m_isSSR";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_isSSR);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_isSSR);
		}
		LuaObject.addMember(l, name43, get40, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache78, true);
		string name44 = "m_storeType";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_storeType);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_storeType);
		}
		LuaObject.addMember(l, name44, get41, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7A, true);
		string name45 = "m_goodsType";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_goodsType);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_goodsType);
		}
		LuaObject.addMember(l, name45, get42, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7C, true);
		string name46 = "m_fixedStoreItemGoodsID";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_fixedStoreItemGoodsID);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_fixedStoreItemGoodsID);
		}
		LuaObject.addMember(l, name46, get43, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7E, true);
		string name47 = "m_goodsID";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_goodsID);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_goodsID);
		}
		LuaObject.addMember(l, name47, get44, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache80, true);
		string name48 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_index);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_index);
		}
		LuaObject.addMember(l, name48, get45, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache82, true);
		string name49 = "m_haveFirstBuyReward";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_haveFirstBuyReward);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_haveFirstBuyReward);
		}
		LuaObject.addMember(l, name49, get46, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache84, true);
		string name50 = "m_extraCurrencyType";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_extraCurrencyType);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_extraCurrencyType);
		}
		LuaObject.addMember(l, name50, get47, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache86, true);
		string name51 = "m_currentGoodCurrencyType";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_currentGoodCurrencyType);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_currentGoodCurrencyType);
		}
		LuaObject.addMember(l, name51, get48, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache88, true);
		string name52 = "m_extraCurrencyTypeIconString";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_extraCurrencyTypeIconString);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_extraCurrencyTypeIconString);
		}
		LuaObject.addMember(l, name52, get49, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8A, true);
		string name53 = "m_extraCurrencyCount";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_extraCurrencyCount);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_extraCurrencyCount);
		}
		LuaObject.addMember(l, name53, get50, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8C, true);
		string name54 = "m_giftStoreItem";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_giftStoreItem);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_giftStoreItem);
		}
		LuaObject.addMember(l, name54, get51, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8E, true);
		string name55 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_playerContext);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name55, get52, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache90, true);
		string name56 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_configDataLoader);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name56, get53, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache92, true);
		string name57 = "m_clientConfigDataLoader";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_m_clientConfigDataLoader);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_m_clientConfigDataLoader);
		}
		LuaObject.addMember(l, name57, get54, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache94, true);
		string name58 = "Count";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_Count);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_Count);
		}
		LuaObject.addMember(l, name58, get55, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache96, true);
		string name59 = "PriceIcon";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_PriceIcon);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_PriceIcon);
		}
		LuaObject.addMember(l, name59, get56, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache98, true);
		string name60 = "PriceText";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_PriceText);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_PriceText);
		}
		LuaObject.addMember(l, name60, get57, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9A, true);
		string name61 = "ItemNameText";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_ItemNameText);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_ItemNameText);
		}
		LuaObject.addMember(l, name61, get58, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9C, true);
		string name62 = "LimitText";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_LimitText);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.set_LimitText);
		}
		LuaObject.addMember(l, name62, get59, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9E, true);
		string name63 = "GoodPDSDKType";
		if (Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreItemUIController.get_GoodPDSDKType);
		}
		LuaObject.addMember(l, name63, Lua_BlackJack_ProjectL_UI_StoreItemUIController.<>f__mg$cache9F, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(StoreItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017159 RID: 94553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401715A RID: 94554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401715B RID: 94555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401715C RID: 94556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401715D RID: 94557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401715E RID: 94558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401715F RID: 94559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017160 RID: 94560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017161 RID: 94561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017162 RID: 94562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017163 RID: 94563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017164 RID: 94564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017165 RID: 94565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017166 RID: 94566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017167 RID: 94567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017168 RID: 94568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017169 RID: 94569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401716A RID: 94570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401716B RID: 94571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401716C RID: 94572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401716D RID: 94573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401716E RID: 94574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401716F RID: 94575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017170 RID: 94576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017171 RID: 94577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017172 RID: 94578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017173 RID: 94579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017174 RID: 94580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017175 RID: 94581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017176 RID: 94582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017177 RID: 94583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017178 RID: 94584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017179 RID: 94585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401717A RID: 94586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401717B RID: 94587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401717C RID: 94588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401717D RID: 94589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401717E RID: 94590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401717F RID: 94591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017180 RID: 94592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017181 RID: 94593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017182 RID: 94594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017183 RID: 94595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017184 RID: 94596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017185 RID: 94597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017186 RID: 94598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017187 RID: 94599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017188 RID: 94600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017189 RID: 94601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401718A RID: 94602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401718B RID: 94603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401718C RID: 94604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401718D RID: 94605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401718E RID: 94606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401718F RID: 94607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017190 RID: 94608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017191 RID: 94609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017192 RID: 94610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017193 RID: 94611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017194 RID: 94612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017195 RID: 94613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017196 RID: 94614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017197 RID: 94615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017198 RID: 94616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017199 RID: 94617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401719A RID: 94618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401719B RID: 94619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401719C RID: 94620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401719D RID: 94621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401719E RID: 94622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401719F RID: 94623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040171A0 RID: 94624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040171A1 RID: 94625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040171A2 RID: 94626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040171A3 RID: 94627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040171A4 RID: 94628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040171A5 RID: 94629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040171A6 RID: 94630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040171A7 RID: 94631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040171A8 RID: 94632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040171A9 RID: 94633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040171AA RID: 94634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040171AB RID: 94635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040171AC RID: 94636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040171AD RID: 94637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040171AE RID: 94638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040171AF RID: 94639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040171B0 RID: 94640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040171B1 RID: 94641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040171B2 RID: 94642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040171B3 RID: 94643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040171B4 RID: 94644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040171B5 RID: 94645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040171B6 RID: 94646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040171B7 RID: 94647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040171B8 RID: 94648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040171B9 RID: 94649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040171BA RID: 94650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040171BB RID: 94651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040171BC RID: 94652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040171BD RID: 94653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040171BE RID: 94654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040171BF RID: 94655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040171C0 RID: 94656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040171C1 RID: 94657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040171C2 RID: 94658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040171C3 RID: 94659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040171C4 RID: 94660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040171C5 RID: 94661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040171C6 RID: 94662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040171C7 RID: 94663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040171C8 RID: 94664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040171C9 RID: 94665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040171CA RID: 94666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040171CB RID: 94667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040171CC RID: 94668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040171CD RID: 94669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040171CE RID: 94670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040171CF RID: 94671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040171D0 RID: 94672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040171D1 RID: 94673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040171D2 RID: 94674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040171D3 RID: 94675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040171D4 RID: 94676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040171D5 RID: 94677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040171D6 RID: 94678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040171D7 RID: 94679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040171D8 RID: 94680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040171D9 RID: 94681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040171DA RID: 94682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x040171DB RID: 94683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x040171DC RID: 94684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x040171DD RID: 94685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x040171DE RID: 94686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x040171DF RID: 94687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x040171E0 RID: 94688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x040171E1 RID: 94689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x040171E2 RID: 94690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x040171E3 RID: 94691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x040171E4 RID: 94692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x040171E5 RID: 94693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x040171E6 RID: 94694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x040171E7 RID: 94695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x040171E8 RID: 94696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x040171E9 RID: 94697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x040171EA RID: 94698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x040171EB RID: 94699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x040171EC RID: 94700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x040171ED RID: 94701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x040171EE RID: 94702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x040171EF RID: 94703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x040171F0 RID: 94704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x040171F1 RID: 94705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x040171F2 RID: 94706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x040171F3 RID: 94707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x040171F4 RID: 94708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x040171F5 RID: 94709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x040171F6 RID: 94710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x040171F7 RID: 94711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x040171F8 RID: 94712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;
}
