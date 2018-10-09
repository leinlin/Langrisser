using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001397 RID: 5015
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BagListUITask : LuaObject
{
	// Token: 0x0601B663 RID: 112227 RVA: 0x0084D3B8 File Offset: 0x0084B5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 2, out name);
			BagListUITask o = new BagListUITask(name);
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

	// Token: 0x0601B664 RID: 112228 RVA: 0x0084D40C File Offset: 0x0084B60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStart(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = bagListUITask.m_luaExportHelper.OnStart(intent);
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

	// Token: 0x0601B665 RID: 112229 RVA: 0x0084D474 File Offset: 0x0084B674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStop(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B666 RID: 112230 RVA: 0x0084D4C8 File Offset: 0x0084B6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveUIStateToIntent(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.SaveUIStateToIntent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B667 RID: 112231 RVA: 0x0084D51C File Offset: 0x0084B71C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUIStateFromIntent(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			UIIntent uiIntent;
			LuaObject.checkType<UIIntent>(l, 2, out uiIntent);
			bagListUITask.m_luaExportHelper.GetUIStateFromIntent(uiIntent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B668 RID: 112232 RVA: 0x0084D578 File Offset: 0x0084B778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNeedLoadStaticRes(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bool b = bagListUITask.m_luaExportHelper.IsNeedLoadStaticRes();
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

	// Token: 0x0601B669 RID: 112233 RVA: 0x0084D5D4 File Offset: 0x0084B7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectAllStaticResDescForLoad(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			List<UITaskBase.LayerDesc> o = bagListUITask.m_luaExportHelper.CollectAllStaticResDescForLoad();
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

	// Token: 0x0601B66A RID: 112234 RVA: 0x0084D630 File Offset: 0x0084B830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAllUIControllers(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.InitAllUIControllers();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B66B RID: 112235 RVA: 0x0084D684 File Offset: 0x0084B884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAllContextAndRes(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.ClearAllContextAndRes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B66C RID: 112236 RVA: 0x0084D6D8 File Offset: 0x0084B8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateView(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.UpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B66D RID: 112237 RVA: 0x0084D72C File Offset: 0x0084B92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PushAndPopLayerByState(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.PushAndPopLayerByState();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B66E RID: 112238 RVA: 0x0084D780 File Offset: 0x0084B980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagListUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.BagListUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B66F RID: 112239 RVA: 0x0084D7D4 File Offset: 0x0084B9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagListUIController_OnAddAllItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.BagListUIController_OnAddAllItem();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B670 RID: 112240 RVA: 0x0084D828 File Offset: 0x0084BA28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagListUIController_OnSpeedUp(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 3, out equipmentInstanceId);
			BagListUIController.DisplayType displayType;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 4, out displayType);
			bagListUITask.m_luaExportHelper.BagListUIController_OnSpeedUp(slot, equipmentInstanceId, displayType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B671 RID: 112241 RVA: 0x0084D8A0 File Offset: 0x0084BAA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagListUIController_OnAddAllEquipment(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.BagListUIController_OnAddAllEquipment();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B672 RID: 112242 RVA: 0x0084D8F4 File Offset: 0x0084BAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagListUIController_OnAddItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			string str;
			LuaObject.checkType(l, 2, out str);
			bagListUITask.m_luaExportHelper.BagListUIController_OnAddItem(str);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B673 RID: 112243 RVA: 0x0084D950 File Offset: 0x0084BB50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagListUIController_OnClearBag(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.BagListUIController_OnClearBag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B674 RID: 112244 RVA: 0x0084D9A4 File Offset: 0x0084BBA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagListUIController_OnUseItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			GoodsType type;
			LuaObject.checkEnum<GoodsType>(l, 2, out type);
			int id;
			LuaObject.checkType(l, 3, out id);
			int count;
			LuaObject.checkType(l, 4, out count);
			BagListUIController.DisplayType displayType;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 5, out displayType);
			bagListUITask.m_luaExportHelper.BagListUIController_OnUseItem(type, id, count, displayType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B675 RID: 112245 RVA: 0x0084DA28 File Offset: 0x0084BC28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRewardGoodsUITask(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			int itemId;
			LuaObject.checkType(l, 2, out itemId);
			int count;
			LuaObject.checkType(l, 3, out count);
			List<Goods> goods;
			LuaObject.checkType<List<Goods>>(l, 4, out goods);
			bagListUITask.m_luaExportHelper.ShowRewardGoodsUITask(itemId, count, goods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B676 RID: 112246 RVA: 0x0084DAA0 File Offset: 0x0084BCA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagListUIController_OnSellItem(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int count;
			LuaObject.checkType(l, 3, out count);
			bagListUITask.m_luaExportHelper.BagListUIController_OnSellItem(instanceId, count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B677 RID: 112247 RVA: 0x0084DB0C File Offset: 0x0084BD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagListUIController_OnGotoEquipmentForge(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			ulong equipmentInstanceId;
			LuaObject.checkType(l, 3, out equipmentInstanceId);
			BagListUIController.DisplayType displayType;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 4, out displayType);
			bagListUITask.m_luaExportHelper.BagListUIController_OnGotoEquipmentForge(slot, equipmentInstanceId, displayType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B678 RID: 112248 RVA: 0x0084DB84 File Offset: 0x0084BD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EquipmentForgeUITask_OnLoadAllResCompleted(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.EquipmentForgeUITask_OnLoadAllResCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B679 RID: 112249 RVA: 0x0084DBD8 File Offset: 0x0084BDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BagListUIController_OnAlchemyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.BagListUIController_OnAlchemyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B67A RID: 112250 RVA: 0x0084DC2C File Offset: 0x0084BE2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Bag_OnShowGetPath(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			BagItemBase goods;
			LuaObject.checkType<BagItemBase>(l, 2, out goods);
			BagListUIController.DisplayType displayType;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 3, out displayType);
			bagListUITask.m_luaExportHelper.Bag_OnShowGetPath(goods, displayType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B67B RID: 112251 RVA: 0x0084DC98 File Offset: 0x0084BE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Bag_OnGotoGetPath(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			GetPathData getPath;
			LuaObject.checkType<GetPathData>(l, 2, out getPath);
			NeedGoods needGoods;
			LuaObject.checkType<NeedGoods>(l, 3, out needGoods);
			bagListUITask.m_luaExportHelper.Bag_OnGotoGetPath(getPath, needGoods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B67C RID: 112252 RVA: 0x0084DD04 File Offset: 0x0084BF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AlchemyUIController_OnReturn(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.AlchemyUIController_OnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B67D RID: 112253 RVA: 0x0084DD58 File Offset: 0x0084BF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AlchemyUIController_OnShowHelp(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.AlchemyUIController_OnShowHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B67E RID: 112254 RVA: 0x0084DDAC File Offset: 0x0084BFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AlchemyUIController_OnAlchemyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			List<ProGoods> proGoods;
			LuaObject.checkType<List<ProGoods>>(l, 2, out proGoods);
			Action<List<Goods>> onSucceed;
			LuaObject.checkDelegate<Action<List<Goods>>>(l, 3, out onSucceed);
			bagListUITask.m_luaExportHelper.AlchemyUIController_OnAlchemyButtonClick(proGoods, onSucceed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B67F RID: 112255 RVA: 0x0084DE18 File Offset: 0x0084C018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStart(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = bagListUITask.m_luaExportHelper.__callBase_OnStart(intent);
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

	// Token: 0x0601B680 RID: 112256 RVA: 0x0084DE80 File Offset: 0x0084C080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnStop(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.__callBase_OnStop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B681 RID: 112257 RVA: 0x0084DED4 File Offset: 0x0084C0D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPause(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.__callBase_OnPause();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B682 RID: 112258 RVA: 0x0084DF28 File Offset: 0x0084C128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnResume(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = bagListUITask.m_luaExportHelper.__callBase_OnResume(intent);
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

	// Token: 0x0601B683 RID: 112259 RVA: 0x0084DF90 File Offset: 0x0084C190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnNewIntent(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			UIIntent intent;
			LuaObject.checkType<UIIntent>(l, 2, out intent);
			bool b = bagListUITask.m_luaExportHelper.__callBase_OnNewIntent(intent);
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

	// Token: 0x0601B684 RID: 112260 RVA: 0x0084DFF8 File Offset: 0x0084C1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EnableUIInput(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bool isEnable;
			LuaObject.checkType(l, 2, out isEnable);
			bool? isGlobalEnable;
			LuaObject.checkNullable<bool>(l, 3, out isGlobalEnable);
			bagListUITask.m_luaExportHelper.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B685 RID: 112261 RVA: 0x0084E064 File Offset: 0x0084C264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsNeedLoadDynamicRes(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bool b = bagListUITask.m_luaExportHelper.__callBase_IsNeedLoadDynamicRes();
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

	// Token: 0x0601B686 RID: 112262 RVA: 0x0084E0C0 File Offset: 0x0084C2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAllDynamicResForLoad(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			List<string> o = bagListUITask.m_luaExportHelper.__callBase_CollectAllDynamicResForLoad();
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

	// Token: 0x0601B687 RID: 112263 RVA: 0x0084E11C File Offset: 0x0084C31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.__callBase_RegisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B688 RID: 112264 RVA: 0x0084E170 File Offset: 0x0084C370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UnregisterPlayerContextEvents(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.__callBase_UnregisterPlayerContextEvents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B689 RID: 112265 RVA: 0x0084E1C4 File Offset: 0x0084C3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostUpdateView(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.__callBase_PostUpdateView();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B68A RID: 112266 RVA: 0x0084E218 File Offset: 0x0084C418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectPreloadResourceList(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.__callBase_CollectPreloadResourceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B68B RID: 112267 RVA: 0x0084E26C File Offset: 0x0084C46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAssetList(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.__callBase_ClearAssetList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B68C RID: 112268 RVA: 0x0084E2C0 File Offset: 0x0084C4C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectAsset(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			bagListUITask.m_luaExportHelper.__callBase_CollectAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B68D RID: 112269 RVA: 0x0084E31C File Offset: 0x0084C51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectSpriteAsset(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			bagListUITask.m_luaExportHelper.__callBase_CollectSpriteAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B68E RID: 112270 RVA: 0x0084E378 File Offset: 0x0084C578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CollectFxAsset(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			bagListUITask.m_luaExportHelper.__callBase_CollectFxAsset(assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B68F RID: 112271 RVA: 0x0084E3D4 File Offset: 0x0084C5D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_StartLoadCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			Action onLoadCompleted;
			LuaObject.checkDelegate<Action>(l, 2, out onLoadCompleted);
			bagListUITask.m_luaExportHelper.__callBase_StartLoadCustomAssets(onLoadCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B690 RID: 112272 RVA: 0x0084E430 File Offset: 0x0084C630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLoadingCustomAssets(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bool b = bagListUITask.m_luaExportHelper.__callBase_IsLoadingCustomAssets();
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

	// Token: 0x0601B691 RID: 112273 RVA: 0x0084E48C File Offset: 0x0084C68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsPipeLineRunning(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bool b = bagListUITask.m_luaExportHelper.__callBase_IsPipeLineRunning();
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

	// Token: 0x0601B692 RID: 112274 RVA: 0x0084E4E8 File Offset: 0x0084C6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsOpeningUI(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bool b = bagListUITask.m_luaExportHelper.__callBase_IsOpeningUI();
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

	// Token: 0x0601B693 RID: 112275 RVA: 0x0084E544 File Offset: 0x0084C744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ReturnPrevUITask(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			UITaskBase o = bagListUITask.m_luaExportHelper.__callBase_ReturnPrevUITask();
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

	// Token: 0x0601B694 RID: 112276 RVA: 0x0084E5A0 File Offset: 0x0084C7A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearUnusedDynamicResourceCache(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.__callBase_ClearUnusedDynamicResourceCache();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B695 RID: 112277 RVA: 0x0084E5F4 File Offset: 0x0084C7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnMemoryWarning(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bagListUITask.m_luaExportHelper.__callBase_OnMemoryWarning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B696 RID: 112278 RVA: 0x0084E648 File Offset: 0x0084C848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.m_luaExportHelper.m_layerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B697 RID: 112279 RVA: 0x0084E6A0 File Offset: 0x0084C8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_layerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			UITaskBase.LayerDesc[] layerDescArray;
			LuaObject.checkArray<UITaskBase.LayerDesc>(l, 2, out layerDescArray);
			bagListUITask.m_luaExportHelper.m_layerDescArray = layerDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B698 RID: 112280 RVA: 0x0084E6FC File Offset: 0x0084C8FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.m_luaExportHelper.m_uiCtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B699 RID: 112281 RVA: 0x0084E754 File Offset: 0x0084C954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiCtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			UITaskBase.UIControllerDesc[] uiCtrlDescArray;
			LuaObject.checkArray<UITaskBase.UIControllerDesc>(l, 2, out uiCtrlDescArray);
			bagListUITask.m_luaExportHelper.m_uiCtrlDescArray = uiCtrlDescArray;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B69A RID: 112282 RVA: 0x0084E7B0 File Offset: 0x0084C9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BagMode(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.BagMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B69B RID: 112283 RVA: 0x0084E804 File Offset: 0x0084CA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BagMode(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			string bagMode;
			LuaObject.checkType(l, 2, out bagMode);
			bagListUITask.BagMode = bagMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B69C RID: 112284 RVA: 0x0084E85C File Offset: 0x0084CA5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AlchemyMode(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.AlchemyMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B69D RID: 112285 RVA: 0x0084E8B0 File Offset: 0x0084CAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AlchemyMode(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			string alchemyMode;
			LuaObject.checkType(l, 2, out alchemyMode);
			bagListUITask.AlchemyMode = alchemyMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B69E RID: 112286 RVA: 0x0084E908 File Offset: 0x0084CB08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curMode(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.m_luaExportHelper.m_curMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B69F RID: 112287 RVA: 0x0084E960 File Offset: 0x0084CB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curMode(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			string curMode;
			LuaObject.checkType(l, 2, out curMode);
			bagListUITask.m_luaExportHelper.m_curMode = curMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6A0 RID: 112288 RVA: 0x0084E9BC File Offset: 0x0084CBBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bagListUIController(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.m_luaExportHelper.m_bagListUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6A1 RID: 112289 RVA: 0x0084EA14 File Offset: 0x0084CC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bagListUIController(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			BagListUIController bagListUIController;
			LuaObject.checkType<BagListUIController>(l, 2, out bagListUIController);
			bagListUITask.m_luaExportHelper.m_bagListUIController = bagListUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6A2 RID: 112290 RVA: 0x0084EA70 File Offset: 0x0084CC70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_alchemyUIController(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.m_luaExportHelper.m_alchemyUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6A3 RID: 112291 RVA: 0x0084EAC8 File Offset: 0x0084CCC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_alchemyUIController(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			AlchemyUIController alchemyUIController;
			LuaObject.checkType<AlchemyUIController>(l, 2, out alchemyUIController);
			bagListUITask.m_luaExportHelper.m_alchemyUIController = alchemyUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6A4 RID: 112292 RVA: 0x0084EB24 File Offset: 0x0084CD24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curLayerDescIndex(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.m_luaExportHelper.m_curLayerDescIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6A5 RID: 112293 RVA: 0x0084EB7C File Offset: 0x0084CD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curLayerDescIndex(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			int curLayerDescIndex;
			LuaObject.checkType(l, 2, out curLayerDescIndex);
			bagListUITask.m_luaExportHelper.m_curLayerDescIndex = curLayerDescIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6A6 RID: 112294 RVA: 0x0084EBD8 File Offset: 0x0084CDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNeedShowFadeIn(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.m_luaExportHelper.m_isNeedShowFadeIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6A7 RID: 112295 RVA: 0x0084EC30 File Offset: 0x0084CE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNeedShowFadeIn(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			bool isNeedShowFadeIn;
			LuaObject.checkType(l, 2, out isNeedShowFadeIn);
			bagListUITask.m_luaExportHelper.m_isNeedShowFadeIn = isNeedShowFadeIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6A8 RID: 112296 RVA: 0x0084EC8C File Offset: 0x0084CE8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_displayType(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)bagListUITask.m_luaExportHelper.m_displayType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6A9 RID: 112297 RVA: 0x0084ECE4 File Offset: 0x0084CEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_displayType(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			BagListUIController.DisplayType displayType;
			LuaObject.checkEnum<BagListUIController.DisplayType>(l, 2, out displayType);
			bagListUITask.m_luaExportHelper.m_displayType = displayType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6AA RID: 112298 RVA: 0x0084ED40 File Offset: 0x0084CF40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clickBagItemInstanceId(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.m_luaExportHelper.m_clickBagItemInstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6AB RID: 112299 RVA: 0x0084ED98 File Offset: 0x0084CF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clickBagItemInstanceId(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			ulong clickBagItemInstanceId;
			LuaObject.checkType(l, 2, out clickBagItemInstanceId);
			bagListUITask.m_luaExportHelper.m_clickBagItemInstanceId = clickBagItemInstanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6AC RID: 112300 RVA: 0x0084EDF4 File Offset: 0x0084CFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LayerDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.m_luaExportHelper.LayerDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6AD RID: 112301 RVA: 0x0084EE4C File Offset: 0x0084D04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UICtrlDescArray(IntPtr l)
	{
		int result;
		try
		{
			BagListUITask bagListUITask = (BagListUITask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagListUITask.m_luaExportHelper.UICtrlDescArray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B6AE RID: 112302 RVA: 0x0084EEA4 File Offset: 0x0084D0A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BagListUITask");
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.SaveUIStateToIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.GetUIStateFromIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.IsNeedLoadStaticRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.CollectAllStaticResDescForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.InitAllUIControllers);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.ClearAllContextAndRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.UpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.PushAndPopLayerByState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.BagListUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.BagListUIController_OnAddAllItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.BagListUIController_OnSpeedUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.BagListUIController_OnAddAllEquipment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.BagListUIController_OnAddItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.BagListUIController_OnClearBag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.BagListUIController_OnUseItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.ShowRewardGoodsUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.BagListUIController_OnSellItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.BagListUIController_OnGotoEquipmentForge);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.EquipmentForgeUITask_OnLoadAllResCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.BagListUIController_OnAlchemyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.Bag_OnShowGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.Bag_OnGotoGetPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.AlchemyUIController_OnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.AlchemyUIController_OnShowHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.AlchemyUIController_OnAlchemyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_OnStart);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_OnStop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_OnPause);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_OnResume);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_OnNewIntent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_EnableUIInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_IsNeedLoadDynamicRes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_CollectAllDynamicResForLoad);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_RegisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_UnregisterPlayerContextEvents);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_PostUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_CollectPreloadResourceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_ClearAssetList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_CollectAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_CollectSpriteAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_CollectFxAsset);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_StartLoadCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_IsLoadingCustomAssets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_IsPipeLineRunning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_IsOpeningUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_ReturnPrevUITask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_ClearUnusedDynamicResourceCache);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.__callBase_OnMemoryWarning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache31);
		string name = "m_layerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_m_layerDescArray);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.set_m_layerDescArray);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache33, true);
		string name2 = "m_uiCtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_m_uiCtrlDescArray);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.set_m_uiCtrlDescArray);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache35, true);
		string name3 = "BagMode";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_BagMode);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.set_BagMode);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache37, true);
		string name4 = "AlchemyMode";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_AlchemyMode);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.set_AlchemyMode);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache39, true);
		string name5 = "m_curMode";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_m_curMode);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.set_m_curMode);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3B, true);
		string name6 = "m_bagListUIController";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_m_bagListUIController);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.set_m_bagListUIController);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3D, true);
		string name7 = "m_alchemyUIController";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_m_alchemyUIController);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.set_m_alchemyUIController);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache3F, true);
		string name8 = "m_curLayerDescIndex";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_m_curLayerDescIndex);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.set_m_curLayerDescIndex);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache41, true);
		string name9 = "m_isNeedShowFadeIn";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_m_isNeedShowFadeIn);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.set_m_isNeedShowFadeIn);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache43, true);
		string name10 = "m_displayType";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_m_displayType);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.set_m_displayType);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache45, true);
		string name11 = "m_clickBagItemInstanceId";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_m_clickBagItemInstanceId);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.set_m_clickBagItemInstanceId);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache47, true);
		string name12 = "LayerDescArray";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_LayerDescArray);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache48, null, true);
		string name13 = "UICtrlDescArray";
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.get_UICtrlDescArray);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache49, null, true);
		if (Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagListUITask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BagListUITask.<>f__mg$cache4A, typeof(BagListUITask), typeof(UITask));
	}

	// Token: 0x04011917 RID: 71959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011918 RID: 71960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011919 RID: 71961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401191A RID: 71962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401191B RID: 71963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401191C RID: 71964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401191D RID: 71965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401191E RID: 71966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401191F RID: 71967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011920 RID: 71968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011921 RID: 71969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011922 RID: 71970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011923 RID: 71971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011924 RID: 71972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011925 RID: 71973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011926 RID: 71974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011927 RID: 71975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011928 RID: 71976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011929 RID: 71977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401192A RID: 71978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401192B RID: 71979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401192C RID: 71980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401192D RID: 71981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401192E RID: 71982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401192F RID: 71983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011930 RID: 71984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011931 RID: 71985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011932 RID: 71986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011933 RID: 71987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011934 RID: 71988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011935 RID: 71989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011936 RID: 71990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011937 RID: 71991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011938 RID: 71992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011939 RID: 71993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401193A RID: 71994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401193B RID: 71995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401193C RID: 71996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401193D RID: 71997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401193E RID: 71998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401193F RID: 71999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011940 RID: 72000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011941 RID: 72001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011942 RID: 72002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011943 RID: 72003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011944 RID: 72004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011945 RID: 72005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011946 RID: 72006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011947 RID: 72007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011948 RID: 72008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011949 RID: 72009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401194A RID: 72010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401194B RID: 72011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401194C RID: 72012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401194D RID: 72013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401194E RID: 72014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401194F RID: 72015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04011950 RID: 72016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04011951 RID: 72017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04011952 RID: 72018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04011953 RID: 72019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04011954 RID: 72020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011955 RID: 72021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04011956 RID: 72022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04011957 RID: 72023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04011958 RID: 72024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04011959 RID: 72025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401195A RID: 72026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401195B RID: 72027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401195C RID: 72028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401195D RID: 72029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401195E RID: 72030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401195F RID: 72031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04011960 RID: 72032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04011961 RID: 72033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;
}
