using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001589 RID: 5513
[Preserve]
public class Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController : LuaObject
{
	// Token: 0x060214D1 RID: 136401 RVA: 0x00B3D20C File Offset: 0x00B3B40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateSoldierSkinDetailPanelByFixedStoreItemConfigInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			ConfigDataFixedStoreItemInfo fixedStoreItemConfig;
			LuaObject.checkType<ConfigDataFixedStoreItemInfo>(l, 2, out fixedStoreItemConfig);
			bool isNeedBuy;
			LuaObject.checkType(l, 3, out isNeedBuy);
			storeSoldierSkinDetailUIController.UpdateSoldierSkinDetailPanelByFixedStoreItemConfigInfo(fixedStoreItemConfig, isNeedBuy);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214D2 RID: 136402 RVA: 0x00B3D270 File Offset: 0x00B3B470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateSoldierSkinDetailPanelBySoldierSkinConfigInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierSkinInfo skinConfigInfo;
			LuaObject.checkType<ConfigDataSoldierSkinInfo>(l, 2, out skinConfigInfo);
			bool isNeedBuy;
			LuaObject.checkType(l, 3, out isNeedBuy);
			storeSoldierSkinDetailUIController.UpdateSoldierSkinDetailPanelBySoldierSkinConfigInfo(skinConfigInfo, isNeedBuy);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214D3 RID: 136403 RVA: 0x00B3D2D4 File Offset: 0x00B3B4D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayPanelOpenAnim(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUIController.PlayPanelOpenAnim();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214D4 RID: 136404 RVA: 0x00B3D320 File Offset: 0x00B3B520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayPanelCloseAnim(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			storeSoldierSkinDetailUIController.PlayPanelCloseAnim(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214D5 RID: 136405 RVA: 0x00B3D378 File Offset: 0x00B3B578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBuyButtonToHasBuyMode(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUIController.SetBuyButtonToHasBuyMode();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214D6 RID: 136406 RVA: 0x00B3D3C4 File Offset: 0x00B3B5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214D7 RID: 136407 RVA: 0x00B3D418 File Offset: 0x00B3B618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPanelBuyButtonState(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			bool panelBuyButtonState;
			LuaObject.checkType(l, 2, out panelBuyButtonState);
			storeSoldierSkinDetailUIController.m_luaExportHelper.SetPanelBuyButtonState(panelBuyButtonState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214D8 RID: 136408 RVA: 0x00B3D474 File Offset: 0x00B3B674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierDefaultAndSkinItemInfo(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			string skinName;
			LuaObject.checkType(l, 2, out skinName);
			List<Soldier2SkinResource> soldier2SkinResList;
			LuaObject.checkType<List<Soldier2SkinResource>>(l, 3, out soldier2SkinResList);
			storeSoldierSkinDetailUIController.m_luaExportHelper.SetSoldierDefaultAndSkinItemInfo(skinName, soldier2SkinResList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214D9 RID: 136409 RVA: 0x00B3D4E0 File Offset: 0x00B3B6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSpineAnim(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			string modelPath;
			LuaObject.checkType(l, 2, out modelPath);
			UISpineGraphic o;
			LuaObject.checkType<UISpineGraphic>(l, 3, out o);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 4, out go);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 5, out soldierInfo);
			storeSoldierSkinDetailUIController.m_luaExportHelper.SetSpineAnim(modelPath, ref o, go, soldierInfo);
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

	// Token: 0x060214DA RID: 136410 RVA: 0x00B3D56C File Offset: 0x00B3B76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214DB RID: 136411 RVA: 0x00B3D5D8 File Offset: 0x00B3B7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214DC RID: 136412 RVA: 0x00B3D62C File Offset: 0x00B3B82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214DD RID: 136413 RVA: 0x00B3D680 File Offset: 0x00B3B880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060214DE RID: 136414 RVA: 0x00B3D728 File Offset: 0x00B3B928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214DF RID: 136415 RVA: 0x00B3D77C File Offset: 0x00B3B97C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214E0 RID: 136416 RVA: 0x00B3D7E8 File Offset: 0x00B3B9E8
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
				StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController2 = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				storeSoldierSkinDetailUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060214E1 RID: 136417 RVA: 0x00B3D8F8 File Offset: 0x00B3BAF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214E2 RID: 136418 RVA: 0x00B3D964 File Offset: 0x00B3BB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214E3 RID: 136419 RVA: 0x00B3D9D0 File Offset: 0x00B3BBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214E4 RID: 136420 RVA: 0x00B3DA3C File Offset: 0x00B3BC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214E5 RID: 136421 RVA: 0x00B3DAA8 File Offset: 0x00B3BCA8
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
				StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController2 = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				storeSoldierSkinDetailUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060214E6 RID: 136422 RVA: 0x00B3DBB8 File Offset: 0x00B3BDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			string s = storeSoldierSkinDetailUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060214E7 RID: 136423 RVA: 0x00B3DC14 File Offset: 0x00B3BE14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDefaultSkinItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_soldierDefaultSkinItemCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214E8 RID: 136424 RVA: 0x00B3DC68 File Offset: 0x00B3BE68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDefaultSkinItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			List<SoldierShowItemController> soldierDefaultSkinItemCtrlList;
			LuaObject.checkType<List<SoldierShowItemController>>(l, 2, out soldierDefaultSkinItemCtrlList);
			storeSoldierSkinDetailUIController.m_soldierDefaultSkinItemCtrlList = soldierDefaultSkinItemCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214E9 RID: 136425 RVA: 0x00B3DCC0 File Offset: 0x00B3BEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierBuySkinItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_soldierBuySkinItemCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214EA RID: 136426 RVA: 0x00B3DD14 File Offset: 0x00B3BF14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierBuySkinItemCtrlList(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			List<SoldierShowItemController> soldierBuySkinItemCtrlList;
			LuaObject.checkType<List<SoldierShowItemController>>(l, 2, out soldierBuySkinItemCtrlList);
			storeSoldierSkinDetailUIController.m_soldierBuySkinItemCtrlList = soldierBuySkinItemCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214EB RID: 136427 RVA: 0x00B3DD6C File Offset: 0x00B3BF6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_panelBgButton(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_panelBgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214EC RID: 136428 RVA: 0x00B3DDC0 File Offset: 0x00B3BFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_panelBgButton(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			Button panelBgButton;
			LuaObject.checkType<Button>(l, 2, out panelBgButton);
			storeSoldierSkinDetailUIController.m_panelBgButton = panelBgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214ED RID: 136429 RVA: 0x00B3DE18 File Offset: 0x00B3C018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyButton(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_buyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214EE RID: 136430 RVA: 0x00B3DE6C File Offset: 0x00B3C06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyButton(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			Button buyButton;
			LuaObject.checkType<Button>(l, 2, out buyButton);
			storeSoldierSkinDetailUIController.m_buyButton = buyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214EF RID: 136431 RVA: 0x00B3DEC4 File Offset: 0x00B3C0C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_priceText(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_priceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214F0 RID: 136432 RVA: 0x00B3DF18 File Offset: 0x00B3C118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_priceText(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			Text priceText;
			LuaObject.checkType<Text>(l, 2, out priceText);
			storeSoldierSkinDetailUIController.m_priceText = priceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214F1 RID: 136433 RVA: 0x00B3DF70 File Offset: 0x00B3C170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214F2 RID: 136434 RVA: 0x00B3DFC4 File Offset: 0x00B3C1C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			storeSoldierSkinDetailUIController.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214F3 RID: 136435 RVA: 0x00B3E01C File Offset: 0x00B3C21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buyStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_buyStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214F4 RID: 136436 RVA: 0x00B3E070 File Offset: 0x00B3C270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_buyStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			CommonUIStateController buyStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out buyStateCtrl);
			storeSoldierSkinDetailUIController.m_buyStateCtrl = buyStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214F5 RID: 136437 RVA: 0x00B3E0C8 File Offset: 0x00B3C2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_panelStateUICtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_panelStateUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214F6 RID: 136438 RVA: 0x00B3E11C File Offset: 0x00B3C31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_panelStateUICtrl(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			CommonUIStateController panelStateUICtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out panelStateUICtrl);
			storeSoldierSkinDetailUIController.m_panelStateUICtrl = panelStateUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214F7 RID: 136439 RVA: 0x00B3E174 File Offset: 0x00B3C374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDefaultSkinItem1(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_soldierDefaultSkinItem1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214F8 RID: 136440 RVA: 0x00B3E1C8 File Offset: 0x00B3C3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDefaultSkinItem1(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			GameObject soldierDefaultSkinItem;
			LuaObject.checkType<GameObject>(l, 2, out soldierDefaultSkinItem);
			storeSoldierSkinDetailUIController.m_soldierDefaultSkinItem1 = soldierDefaultSkinItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214F9 RID: 136441 RVA: 0x00B3E220 File Offset: 0x00B3C420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDefaultSkinItem2(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_soldierDefaultSkinItem2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214FA RID: 136442 RVA: 0x00B3E274 File Offset: 0x00B3C474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDefaultSkinItem2(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			GameObject soldierDefaultSkinItem;
			LuaObject.checkType<GameObject>(l, 2, out soldierDefaultSkinItem);
			storeSoldierSkinDetailUIController.m_soldierDefaultSkinItem2 = soldierDefaultSkinItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214FB RID: 136443 RVA: 0x00B3E2CC File Offset: 0x00B3C4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierBuySkinItem1(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_soldierBuySkinItem1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214FC RID: 136444 RVA: 0x00B3E320 File Offset: 0x00B3C520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierBuySkinItem1(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			GameObject soldierBuySkinItem;
			LuaObject.checkType<GameObject>(l, 2, out soldierBuySkinItem);
			storeSoldierSkinDetailUIController.m_soldierBuySkinItem1 = soldierBuySkinItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214FD RID: 136445 RVA: 0x00B3E378 File Offset: 0x00B3C578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierBuySkinItem2(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, storeSoldierSkinDetailUIController.m_soldierBuySkinItem2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214FE RID: 136446 RVA: 0x00B3E3CC File Offset: 0x00B3C5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierBuySkinItem2(IntPtr l)
	{
		int result;
		try
		{
			StoreSoldierSkinDetailUIController storeSoldierSkinDetailUIController = (StoreSoldierSkinDetailUIController)LuaObject.checkSelf(l);
			GameObject soldierBuySkinItem;
			LuaObject.checkType<GameObject>(l, 2, out soldierBuySkinItem);
			storeSoldierSkinDetailUIController.m_soldierBuySkinItem2 = soldierBuySkinItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060214FF RID: 136447 RVA: 0x00B3E424 File Offset: 0x00B3C624
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.StoreSoldierSkinDetailUIController");
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.UpdateSoldierSkinDetailPanelByFixedStoreItemConfigInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.UpdateSoldierSkinDetailPanelBySoldierSkinConfigInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.PlayPanelOpenAnim);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.PlayPanelCloseAnim);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.SetBuyButtonToHasBuyMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.SetPanelBuyButtonState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.SetSoldierDefaultAndSkinItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.SetSpineAnim);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache15);
		string name = "m_soldierDefaultSkinItemCtrlList";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_soldierDefaultSkinItemCtrlList);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_soldierDefaultSkinItemCtrlList);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache17, true);
		string name2 = "m_soldierBuySkinItemCtrlList";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_soldierBuySkinItemCtrlList);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_soldierBuySkinItemCtrlList);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache19, true);
		string name3 = "m_panelBgButton";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_panelBgButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_panelBgButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1B, true);
		string name4 = "m_buyButton";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_buyButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_buyButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1D, true);
		string name5 = "m_priceText";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_priceText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_priceText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache1F, true);
		string name6 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_nameText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache21, true);
		string name7 = "m_buyStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_buyStateCtrl);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_buyStateCtrl);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache23, true);
		string name8 = "m_panelStateUICtrl";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_panelStateUICtrl);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_panelStateUICtrl);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache25, true);
		string name9 = "m_soldierDefaultSkinItem1";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_soldierDefaultSkinItem1);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_soldierDefaultSkinItem1);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache27, true);
		string name10 = "m_soldierDefaultSkinItem2";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_soldierDefaultSkinItem2);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_soldierDefaultSkinItem2);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache29, true);
		string name11 = "m_soldierBuySkinItem1";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_soldierBuySkinItem1);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_soldierBuySkinItem1);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2B, true);
		string name12 = "m_soldierBuySkinItem2";
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.get_m_soldierBuySkinItem2);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.set_m_soldierBuySkinItem2);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_StoreSoldierSkinDetailUIController.<>f__mg$cache2D, true);
		LuaObject.createTypeMetatable(l, null, typeof(StoreSoldierSkinDetailUIController), typeof(UIControllerBase));
	}

	// Token: 0x040173A1 RID: 95137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040173A2 RID: 95138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040173A3 RID: 95139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040173A4 RID: 95140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040173A5 RID: 95141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040173A6 RID: 95142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040173A7 RID: 95143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040173A8 RID: 95144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040173A9 RID: 95145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040173AA RID: 95146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040173AB RID: 95147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040173AC RID: 95148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040173AD RID: 95149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040173AE RID: 95150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040173AF RID: 95151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040173B0 RID: 95152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040173B1 RID: 95153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040173B2 RID: 95154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040173B3 RID: 95155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040173B4 RID: 95156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040173B5 RID: 95157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040173B6 RID: 95158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040173B7 RID: 95159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040173B8 RID: 95160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040173B9 RID: 95161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040173BA RID: 95162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040173BB RID: 95163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040173BC RID: 95164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040173BD RID: 95165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040173BE RID: 95166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040173BF RID: 95167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040173C0 RID: 95168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040173C1 RID: 95169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040173C2 RID: 95170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040173C3 RID: 95171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040173C4 RID: 95172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040173C5 RID: 95173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040173C6 RID: 95174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040173C7 RID: 95175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040173C8 RID: 95176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040173C9 RID: 95177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040173CA RID: 95178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040173CB RID: 95179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040173CC RID: 95180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040173CD RID: 95181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040173CE RID: 95182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
