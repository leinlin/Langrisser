using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200155C RID: 5468
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RewardGoodsUIController : LuaObject
{
	// Token: 0x06020B52 RID: 133970 RVA: 0x00AF08C0 File Offset: 0x00AEEAC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetReward(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			Goods r;
			LuaObject.checkType<Goods>(l, 2, out r);
			int alignType;
			LuaObject.checkType(l, 3, out alignType);
			bool isNeedAutoClose;
			LuaObject.checkType(l, 4, out isNeedAutoClose);
			rewardGoodsUIController.SetReward(r, alignType, isNeedAutoClose);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B53 RID: 133971 RVA: 0x00AF0934 File Offset: 0x00AEEB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowCount(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			bool show;
			LuaObject.checkType(l, 2, out show);
			rewardGoodsUIController.ShowCount(show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B54 RID: 133972 RVA: 0x00AF098C File Offset: 0x00AEEB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowTag(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			string tagName;
			LuaObject.checkType(l, 2, out tagName);
			bool show;
			LuaObject.checkType(l, 3, out show);
			rewardGoodsUIController.ShowTag(tagName, show);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B55 RID: 133973 RVA: 0x00AF09F0 File Offset: 0x00AEEBF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowHaveGot(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			bool isGot;
			LuaObject.checkType(l, 2, out isGot);
			rewardGoodsUIController.ShowHaveGot(isGot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B56 RID: 133974 RVA: 0x00AF0A48 File Offset: 0x00AEEC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateRewardGoods_s(IntPtr l)
	{
		int result;
		try
		{
			Goods g;
			LuaObject.checkType<Goods>(l, 1, out g);
			Transform parent;
			LuaObject.checkType<Transform>(l, 2, out parent);
			GameObject prefab;
			LuaObject.checkType<GameObject>(l, 3, out prefab);
			bool showCount;
			LuaObject.checkType(l, 4, out showCount);
			int alignType;
			LuaObject.checkType(l, 5, out alignType);
			RewardGoodsUIController o = RewardGoodsUIController.CreateRewardGoods(g, parent, prefab, showCount, alignType);
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

	// Token: 0x06020B57 RID: 133975 RVA: 0x00AF0AD0 File Offset: 0x00AEECD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateRewardGoodsList_s(IntPtr l)
	{
		int result;
		try
		{
			List<Goods> goods;
			LuaObject.checkType<List<Goods>>(l, 1, out goods);
			Transform parent;
			LuaObject.checkType<Transform>(l, 2, out parent);
			GameObject prefab;
			LuaObject.checkType<GameObject>(l, 3, out prefab);
			List<RewardGoodsUIController> ctrlList;
			LuaObject.checkType<List<RewardGoodsUIController>>(l, 4, out ctrlList);
			bool showCount;
			LuaObject.checkType(l, 5, out showCount);
			int alignType;
			LuaObject.checkType(l, 6, out alignType);
			bool isNeedAutoClose;
			LuaObject.checkType(l, 7, out isNeedAutoClose);
			RewardGoodsUIController.CreateRewardGoodsList(goods, parent, prefab, ctrlList, showCount, alignType, isNeedAutoClose);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B58 RID: 133976 RVA: 0x00AF0B64 File Offset: 0x00AEED64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			rewardGoodsUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B59 RID: 133977 RVA: 0x00AF0BB8 File Offset: 0x00AEEDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			rewardGoodsUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B5A RID: 133978 RVA: 0x00AF0C0C File Offset: 0x00AEEE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			rewardGoodsUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B5B RID: 133979 RVA: 0x00AF0C78 File Offset: 0x00AEEE78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			rewardGoodsUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B5C RID: 133980 RVA: 0x00AF0CCC File Offset: 0x00AEEECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			rewardGoodsUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B5D RID: 133981 RVA: 0x00AF0D20 File Offset: 0x00AEEF20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = rewardGoodsUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020B5E RID: 133982 RVA: 0x00AF0DC8 File Offset: 0x00AEEFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			rewardGoodsUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B5F RID: 133983 RVA: 0x00AF0E1C File Offset: 0x00AEF01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			rewardGoodsUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B60 RID: 133984 RVA: 0x00AF0E88 File Offset: 0x00AEF088
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
				RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				rewardGoodsUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RewardGoodsUIController rewardGoodsUIController2 = (RewardGoodsUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				rewardGoodsUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020B61 RID: 133985 RVA: 0x00AF0F98 File Offset: 0x00AEF198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardGoodsUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B62 RID: 133986 RVA: 0x00AF1004 File Offset: 0x00AEF204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardGoodsUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B63 RID: 133987 RVA: 0x00AF1070 File Offset: 0x00AEF270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardGoodsUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B64 RID: 133988 RVA: 0x00AF10DC File Offset: 0x00AEF2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rewardGoodsUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B65 RID: 133989 RVA: 0x00AF1148 File Offset: 0x00AEF348
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
				RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				rewardGoodsUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RewardGoodsUIController rewardGoodsUIController2 = (RewardGoodsUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				rewardGoodsUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020B66 RID: 133990 RVA: 0x00AF1258 File Offset: 0x00AEF458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			string s = rewardGoodsUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020B67 RID: 133991 RVA: 0x00AF12B4 File Offset: 0x00AEF4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rewardGoodsUIController.m_luaExportHelper.m_goodsType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B68 RID: 133992 RVA: 0x00AF130C File Offset: 0x00AEF50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsType(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			rewardGoodsUIController.m_luaExportHelper.m_goodsType = goodsType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B69 RID: 133993 RVA: 0x00AF1368 File Offset: 0x00AEF568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_goodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B6A RID: 133994 RVA: 0x00AF13C0 File Offset: 0x00AEF5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsId(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			int goodsId;
			LuaObject.checkType(l, 2, out goodsId);
			rewardGoodsUIController.m_luaExportHelper.m_goodsId = goodsId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B6B RID: 133995 RVA: 0x00AF141C File Offset: 0x00AEF61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goodsCount(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_goodsCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B6C RID: 133996 RVA: 0x00AF1474 File Offset: 0x00AEF674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goodsCount(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			int goodsCount;
			LuaObject.checkType(l, 2, out goodsCount);
			rewardGoodsUIController.m_luaExportHelper.m_goodsCount = goodsCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B6D RID: 133997 RVA: 0x00AF14D0 File Offset: 0x00AEF6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_alignType(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_alignType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B6E RID: 133998 RVA: 0x00AF1528 File Offset: 0x00AEF728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_alignType(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			int alignType;
			LuaObject.checkType(l, 2, out alignType);
			rewardGoodsUIController.m_luaExportHelper.m_alignType = alignType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B6F RID: 133999 RVA: 0x00AF1584 File Offset: 0x00AEF784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNeedAutoClose(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, RewardGoodsUIController.LuaExportHelper.m_isNeedAutoClose);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B70 RID: 134000 RVA: 0x00AF15CC File Offset: 0x00AEF7CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNeedAutoClose(IntPtr l)
	{
		int result;
		try
		{
			bool isNeedAutoClose;
			LuaObject.checkType(l, 2, out isNeedAutoClose);
			RewardGoodsUIController.LuaExportHelper.m_isNeedAutoClose = isNeedAutoClose;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B71 RID: 134001 RVA: 0x00AF1618 File Offset: 0x00AEF818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B72 RID: 134002 RVA: 0x00AF1670 File Offset: 0x00AEF870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			rewardGoodsUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B73 RID: 134003 RVA: 0x00AF16CC File Offset: 0x00AEF8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B74 RID: 134004 RVA: 0x00AF1724 File Offset: 0x00AEF924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			rewardGoodsUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B75 RID: 134005 RVA: 0x00AF1780 File Offset: 0x00AEF980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frameImage(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_frameImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B76 RID: 134006 RVA: 0x00AF17D8 File Offset: 0x00AEF9D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameImage(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			Image frameImage;
			LuaObject.checkType<Image>(l, 2, out frameImage);
			rewardGoodsUIController.m_luaExportHelper.m_frameImage = frameImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B77 RID: 134007 RVA: 0x00AF1834 File Offset: 0x00AEFA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_haveGetGroupRoot(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_haveGetGroupRoot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B78 RID: 134008 RVA: 0x00AF188C File Offset: 0x00AEFA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_haveGetGroupRoot(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			GameObject haveGetGroupRoot;
			LuaObject.checkType<GameObject>(l, 2, out haveGetGroupRoot);
			rewardGoodsUIController.m_luaExportHelper.m_haveGetGroupRoot = haveGetGroupRoot;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B79 RID: 134009 RVA: 0x00AF18E8 File Offset: 0x00AEFAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B7A RID: 134010 RVA: 0x00AF1940 File Offset: 0x00AEFB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			rewardGoodsUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B7B RID: 134011 RVA: 0x00AF199C File Offset: 0x00AEFB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_countText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B7C RID: 134012 RVA: 0x00AF19F4 File Offset: 0x00AEFBF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countText(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			Text countText;
			LuaObject.checkType<Text>(l, 2, out countText);
			rewardGoodsUIController.m_luaExportHelper.m_countText = countText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B7D RID: 134013 RVA: 0x00AF1A50 File Offset: 0x00AEFC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_crystalEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_crystalEffectGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B7E RID: 134014 RVA: 0x00AF1AA8 File Offset: 0x00AEFCA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_crystalEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			GameObject crystalEffectGameObject;
			LuaObject.checkType<GameObject>(l, 2, out crystalEffectGameObject);
			rewardGoodsUIController.m_luaExportHelper.m_crystalEffectGameObject = crystalEffectGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B7F RID: 134015 RVA: 0x00AF1B04 File Offset: 0x00AEFD04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_ssrEffectGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B80 RID: 134016 RVA: 0x00AF1B5C File Offset: 0x00AEFD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			GameObject ssrEffectGameObject;
			LuaObject.checkType<GameObject>(l, 2, out ssrEffectGameObject);
			rewardGoodsUIController.m_luaExportHelper.m_ssrEffectGameObject = ssrEffectGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B81 RID: 134017 RVA: 0x00AF1BB8 File Offset: 0x00AEFDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrPieceEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rewardGoodsUIController.m_luaExportHelper.m_ssrPieceEffectGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B82 RID: 134018 RVA: 0x00AF1C10 File Offset: 0x00AEFE10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrPieceEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			RewardGoodsUIController rewardGoodsUIController = (RewardGoodsUIController)LuaObject.checkSelf(l);
			GameObject ssrPieceEffectGameObject;
			LuaObject.checkType<GameObject>(l, 2, out ssrPieceEffectGameObject);
			rewardGoodsUIController.m_luaExportHelper.m_ssrPieceEffectGameObject = ssrPieceEffectGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020B83 RID: 134019 RVA: 0x00AF1C6C File Offset: 0x00AEFE6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RewardGoodsUIController");
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.SetReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.ShowCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.ShowTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.ShowHaveGot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.CreateRewardGoods_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.CreateRewardGoodsList_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache14);
		string name = "m_goodsType";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_goodsType);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_goodsType);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache16, true);
		string name2 = "m_goodsId";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_goodsId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_goodsId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache18, true);
		string name3 = "m_goodsCount";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_goodsCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_goodsCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1A, true);
		string name4 = "m_alignType";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_alignType);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_alignType);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1C, true);
		string name5 = "m_isNeedAutoClose";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_isNeedAutoClose);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_isNeedAutoClose);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1E, false);
		string name6 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_button);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_button);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache20, true);
		string name7 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_iconImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache22, true);
		string name8 = "m_frameImage";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_frameImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_frameImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache24, true);
		string name9 = "m_haveGetGroupRoot";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_haveGetGroupRoot);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_haveGetGroupRoot);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache26, true);
		string name10 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_nameText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache28, true);
		string name11 = "m_countText";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_countText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_countText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2A, true);
		string name12 = "m_crystalEffectGameObject";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_crystalEffectGameObject);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_crystalEffectGameObject);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2C, true);
		string name13 = "m_ssrEffectGameObject";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_ssrEffectGameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_ssrEffectGameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2E, true);
		string name14 = "m_ssrPieceEffectGameObject";
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.get_m_ssrPieceEffectGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.set_m_ssrPieceEffectGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_RewardGoodsUIController.<>f__mg$cache30, true);
		LuaObject.createTypeMetatable(l, null, typeof(RewardGoodsUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016A7C RID: 92796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016A7D RID: 92797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016A7E RID: 92798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016A7F RID: 92799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016A80 RID: 92800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016A81 RID: 92801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016A82 RID: 92802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016A83 RID: 92803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016A84 RID: 92804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016A85 RID: 92805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016A86 RID: 92806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016A87 RID: 92807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016A88 RID: 92808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016A89 RID: 92809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016A8A RID: 92810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016A8B RID: 92811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016A8C RID: 92812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016A8D RID: 92813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016A8E RID: 92814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016A8F RID: 92815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016A90 RID: 92816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016A91 RID: 92817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016A92 RID: 92818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016A93 RID: 92819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016A94 RID: 92820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016A95 RID: 92821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016A96 RID: 92822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016A97 RID: 92823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016A98 RID: 92824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016A99 RID: 92825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016A9A RID: 92826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016A9B RID: 92827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016A9C RID: 92828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016A9D RID: 92829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016A9E RID: 92830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016A9F RID: 92831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016AA0 RID: 92832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016AA1 RID: 92833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016AA2 RID: 92834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016AA3 RID: 92835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016AA4 RID: 92836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016AA5 RID: 92837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016AA6 RID: 92838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016AA7 RID: 92839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016AA8 RID: 92840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016AA9 RID: 92841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016AAA RID: 92842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016AAB RID: 92843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016AAC RID: 92844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;
}
