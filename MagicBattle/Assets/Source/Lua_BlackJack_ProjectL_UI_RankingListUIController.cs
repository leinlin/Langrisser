using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using MarchingBytes;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200154A RID: 5450
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RankingListUIController : LuaObject
{
	// Token: 0x06020980 RID: 133504 RVA: 0x00AE2904 File Offset: 0x00AE0B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateItemListPool(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			int poolSize;
			LuaObject.checkType(l, 2, out poolSize);
			rankingListUIController.CreateItemListPool(poolSize);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020981 RID: 133505 RVA: 0x00AE295C File Offset: 0x00AE0B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRankingListInfo(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			RankingListInfo rankList;
			LuaObject.checkType<RankingListInfo>(l, 2, out rankList);
			rankingListUIController.UpdateRankingListInfo(rankList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020982 RID: 133506 RVA: 0x00AE29B4 File Offset: 0x00AE0BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			rankingListUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020983 RID: 133507 RVA: 0x00AE2A08 File Offset: 0x00AE0C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateSelfRankInfo(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			rankingListUIController.m_luaExportHelper.UpdateSelfRankInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020984 RID: 133508 RVA: 0x00AE2A5C File Offset: 0x00AE0C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRankItemFill(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 2, out itemCtrl);
			rankingListUIController.m_luaExportHelper.OnRankItemFill(itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020985 RID: 133509 RVA: 0x00AE2AB8 File Offset: 0x00AE0CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			rankingListUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020986 RID: 133510 RVA: 0x00AE2B24 File Offset: 0x00AE0D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			rankingListUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020987 RID: 133511 RVA: 0x00AE2B78 File Offset: 0x00AE0D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			rankingListUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020988 RID: 133512 RVA: 0x00AE2BCC File Offset: 0x00AE0DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = rankingListUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020989 RID: 133513 RVA: 0x00AE2C74 File Offset: 0x00AE0E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			rankingListUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602098A RID: 133514 RVA: 0x00AE2CC8 File Offset: 0x00AE0EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			rankingListUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602098B RID: 133515 RVA: 0x00AE2D34 File Offset: 0x00AE0F34
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
				RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				rankingListUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RankingListUIController rankingListUIController2 = (RankingListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				rankingListUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602098C RID: 133516 RVA: 0x00AE2E44 File Offset: 0x00AE1044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingListUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602098D RID: 133517 RVA: 0x00AE2EB0 File Offset: 0x00AE10B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingListUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602098E RID: 133518 RVA: 0x00AE2F1C File Offset: 0x00AE111C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingListUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602098F RID: 133519 RVA: 0x00AE2F88 File Offset: 0x00AE1188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingListUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020990 RID: 133520 RVA: 0x00AE2FF4 File Offset: 0x00AE11F4
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
				RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				rankingListUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RankingListUIController rankingListUIController2 = (RankingListUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				rankingListUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020991 RID: 133521 RVA: 0x00AE3104 File Offset: 0x00AE1304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			string s = rankingListUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020992 RID: 133522 RVA: 0x00AE3160 File Offset: 0x00AE1360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemTemplete(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListUIController.m_luaExportHelper.m_itemTemplete);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020993 RID: 133523 RVA: 0x00AE31B8 File Offset: 0x00AE13B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemTemplete(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			GameObject itemTemplete;
			LuaObject.checkType<GameObject>(l, 2, out itemTemplete);
			rankingListUIController.m_luaExportHelper.m_itemTemplete = itemTemplete;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020994 RID: 133524 RVA: 0x00AE3214 File Offset: 0x00AE1414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cachedRankList(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListUIController.m_luaExportHelper.m_cachedRankList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020995 RID: 133525 RVA: 0x00AE326C File Offset: 0x00AE146C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cachedRankList(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			RankingListInfo cachedRankList;
			LuaObject.checkType<RankingListInfo>(l, 2, out cachedRankList);
			rankingListUIController.m_luaExportHelper.m_cachedRankList = cachedRankList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020996 RID: 133526 RVA: 0x00AE32C8 File Offset: 0x00AE14C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankListItemPrefabName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RankingListUIController.LuaExportHelper.RankListItemPrefabName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020997 RID: 133527 RVA: 0x00AE3310 File Offset: 0x00AE1510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemRoot(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListUIController.ItemRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020998 RID: 133528 RVA: 0x00AE3364 File Offset: 0x00AE1564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ItemRoot(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			Transform itemRoot;
			LuaObject.checkType<Transform>(l, 2, out itemRoot);
			rankingListUIController.ItemRoot = itemRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020999 RID: 133529 RVA: 0x00AE33BC File Offset: 0x00AE15BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankListItemPool(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListUIController.RankListItemPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602099A RID: 133530 RVA: 0x00AE3410 File Offset: 0x00AE1610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RankListItemPool(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			EasyObjectPool rankListItemPool;
			LuaObject.checkType<EasyObjectPool>(l, 2, out rankListItemPool);
			rankingListUIController.RankListItemPool = rankListItemPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602099B RID: 133531 RVA: 0x00AE3468 File Offset: 0x00AE1668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelfRankItemUICtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListUIController.SelfRankItemUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602099C RID: 133532 RVA: 0x00AE34BC File Offset: 0x00AE16BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SelfRankItemUICtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			SelfRankingListItemUIController selfRankItemUICtrl;
			LuaObject.checkType<SelfRankingListItemUIController>(l, 2, out selfRankItemUICtrl);
			rankingListUIController.SelfRankItemUICtrl = selfRankItemUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602099D RID: 133533 RVA: 0x00AE3514 File Offset: 0x00AE1714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListUIController.RankListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602099E RID: 133534 RVA: 0x00AE3568 File Offset: 0x00AE1768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RankListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			LoopVerticalScrollRect rankListScrollRect;
			LuaObject.checkType<LoopVerticalScrollRect>(l, 2, out rankListScrollRect);
			rankingListUIController.RankListScrollRect = rankListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602099F RID: 133535 RVA: 0x00AE35C0 File Offset: 0x00AE17C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankListStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListUIController.RankListStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209A0 RID: 133536 RVA: 0x00AE3614 File Offset: 0x00AE1814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RankListStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingListUIController rankingListUIController = (RankingListUIController)LuaObject.checkSelf(l);
			CommonUIStateController rankListStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out rankListStateCtrl);
			rankingListUIController.RankListStateCtrl = rankListStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209A1 RID: 133537 RVA: 0x00AE366C File Offset: 0x00AE186C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RankingListUIController");
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.CreateItemListPool);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.UpdateRankingListInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.UpdateSelfRankInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.OnRankItemFill);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache11);
		string name = "m_itemTemplete";
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.get_m_itemTemplete);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.set_m_itemTemplete);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache13, true);
		string name2 = "m_cachedRankList";
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.get_m_cachedRankList);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.set_m_cachedRankList);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache15, true);
		string name3 = "RankListItemPrefabName";
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.get_RankListItemPrefabName);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache16, null, false);
		string name4 = "ItemRoot";
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.get_ItemRoot);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.set_ItemRoot);
		}
		LuaObject.addMember(l, name4, get3, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache18, true);
		string name5 = "RankListItemPool";
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.get_RankListItemPool);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.set_RankListItemPool);
		}
		LuaObject.addMember(l, name5, get4, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1A, true);
		string name6 = "SelfRankItemUICtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.get_SelfRankItemUICtrl);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.set_SelfRankItemUICtrl);
		}
		LuaObject.addMember(l, name6, get5, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1C, true);
		string name7 = "RankListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.get_RankListScrollRect);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.set_RankListScrollRect);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1E, true);
		string name8 = "RankListStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.get_RankListStateCtrl);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListUIController.set_RankListStateCtrl);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ProjectL_UI_RankingListUIController.<>f__mg$cache20, true);
		LuaObject.createTypeMetatable(l, null, typeof(RankingListUIController), typeof(UIControllerBase));
	}

	// Token: 0x040168CE RID: 92366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040168CF RID: 92367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040168D0 RID: 92368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040168D1 RID: 92369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040168D2 RID: 92370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040168D3 RID: 92371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040168D4 RID: 92372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040168D5 RID: 92373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040168D6 RID: 92374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040168D7 RID: 92375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040168D8 RID: 92376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040168D9 RID: 92377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040168DA RID: 92378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040168DB RID: 92379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040168DC RID: 92380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040168DD RID: 92381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040168DE RID: 92382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040168DF RID: 92383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040168E0 RID: 92384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040168E1 RID: 92385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040168E2 RID: 92386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040168E3 RID: 92387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040168E4 RID: 92388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040168E5 RID: 92389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040168E6 RID: 92390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040168E7 RID: 92391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040168E8 RID: 92392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040168E9 RID: 92393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040168EA RID: 92394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040168EB RID: 92395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040168EC RID: 92396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040168ED RID: 92397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040168EE RID: 92398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;
}
