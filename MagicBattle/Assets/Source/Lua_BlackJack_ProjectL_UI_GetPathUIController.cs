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

// Token: 0x0200145D RID: 5213
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GetPathUIController : LuaObject
{
	// Token: 0x0601E195 RID: 123285 RVA: 0x009A54AC File Offset: 0x009A36AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			getPathUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E196 RID: 123286 RVA: 0x009A54F8 File Offset: 0x009A36F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			getPathUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E197 RID: 123287 RVA: 0x009A5544 File Offset: 0x009A3744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInGetPathPanel(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsType);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			getPathUIController.UpdateViewInGetPathPanel(goodsType, goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E198 RID: 123288 RVA: 0x009A55A8 File Offset: 0x009A37A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			getPathUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E199 RID: 123289 RVA: 0x009A55FC File Offset: 0x009A37FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreatePathItemList(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			List<GetPathData> getPathList;
			LuaObject.checkType<List<GetPathData>>(l, 2, out getPathList);
			string getPathDesc;
			LuaObject.checkType(l, 3, out getPathDesc);
			getPathUIController.m_luaExportHelper.CreatePathItemList(getPathList, getPathDesc);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E19A RID: 123290 RVA: 0x009A5668 File Offset: 0x009A3868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnImgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			getPathUIController.m_luaExportHelper.OnReturnImgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E19B RID: 123291 RVA: 0x009A56BC File Offset: 0x009A38BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetPathItemGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			GetPathData getPathInfo;
			LuaObject.checkType<GetPathData>(l, 2, out getPathInfo);
			getPathUIController.m_luaExportHelper.OnGetPathItemGotoButtonClick(getPathInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E19C RID: 123292 RVA: 0x009A5718 File Offset: 0x009A3918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			getPathUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E19D RID: 123293 RVA: 0x009A5784 File Offset: 0x009A3984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			getPathUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E19E RID: 123294 RVA: 0x009A57D8 File Offset: 0x009A39D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			getPathUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E19F RID: 123295 RVA: 0x009A582C File Offset: 0x009A3A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = getPathUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E1A0 RID: 123296 RVA: 0x009A58D4 File Offset: 0x009A3AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			getPathUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1A1 RID: 123297 RVA: 0x009A5928 File Offset: 0x009A3B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			getPathUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1A2 RID: 123298 RVA: 0x009A5994 File Offset: 0x009A3B94
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
				GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				getPathUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				GetPathUIController getPathUIController2 = (GetPathUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				getPathUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E1A3 RID: 123299 RVA: 0x009A5AA4 File Offset: 0x009A3CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getPathUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1A4 RID: 123300 RVA: 0x009A5B10 File Offset: 0x009A3D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getPathUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1A5 RID: 123301 RVA: 0x009A5B7C File Offset: 0x009A3D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getPathUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1A6 RID: 123302 RVA: 0x009A5BE8 File Offset: 0x009A3DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			getPathUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1A7 RID: 123303 RVA: 0x009A5C54 File Offset: 0x009A3E54
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
				GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				getPathUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				GetPathUIController getPathUIController2 = (GetPathUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				getPathUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E1A8 RID: 123304 RVA: 0x009A5D64 File Offset: 0x009A3F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			string s = getPathUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E1A9 RID: 123305 RVA: 0x009A5DC0 File Offset: 0x009A3FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			getPathUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1AA RID: 123306 RVA: 0x009A5E14 File Offset: 0x009A4014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			getPathUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1AB RID: 123307 RVA: 0x009A5E68 File Offset: 0x009A4068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			getPathUIController.m_luaExportHelper.__callDele_EventOnGotoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1AC RID: 123308 RVA: 0x009A5EC4 File Offset: 0x009A40C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			getPathUIController.m_luaExportHelper.__clearDele_EventOnGotoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1AD RID: 123309 RVA: 0x009A5F20 File Offset: 0x009A4120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					getPathUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					getPathUIController.EventOnClose -= value;
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

	// Token: 0x0601E1AE RID: 123310 RVA: 0x009A5FA0 File Offset: 0x009A41A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			Action<GetPathData> value;
			int num = LuaObject.checkDelegate<Action<GetPathData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					getPathUIController.EventOnGotoButtonClick += value;
				}
				else if (num == 2)
				{
					getPathUIController.EventOnGotoButtonClick -= value;
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

	// Token: 0x0601E1AF RID: 123311 RVA: 0x009A6020 File Offset: 0x009A4220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUIController.m_luaExportHelper.m_commonUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1B0 RID: 123312 RVA: 0x009A6078 File Offset: 0x009A4278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_commonUIStateController(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			CommonUIStateController commonUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out commonUIStateController);
			getPathUIController.m_luaExportHelper.m_commonUIStateController = commonUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1B1 RID: 123313 RVA: 0x009A60D4 File Offset: 0x009A42D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1B2 RID: 123314 RVA: 0x009A612C File Offset: 0x009A432C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			getPathUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1B3 RID: 123315 RVA: 0x009A6188 File Offset: 0x009A4388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1B4 RID: 123316 RVA: 0x009A61E0 File Offset: 0x009A43E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			getPathUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1B5 RID: 123317 RVA: 0x009A623C File Offset: 0x009A443C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descText(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUIController.m_luaExportHelper.m_descText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1B6 RID: 123318 RVA: 0x009A6294 File Offset: 0x009A4494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descText(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			Text descText;
			LuaObject.checkType<Text>(l, 2, out descText);
			getPathUIController.m_luaExportHelper.m_descText = descText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1B7 RID: 123319 RVA: 0x009A62F0 File Offset: 0x009A44F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnImgButton(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUIController.m_luaExportHelper.m_returnImgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1B8 RID: 123320 RVA: 0x009A6348 File Offset: 0x009A4548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnImgButton(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			Button returnImgButton;
			LuaObject.checkType<Button>(l, 2, out returnImgButton);
			getPathUIController.m_luaExportHelper.m_returnImgButton = returnImgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1B9 RID: 123321 RVA: 0x009A63A4 File Offset: 0x009A45A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_contentObj(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUIController.m_luaExportHelper.m_contentObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1BA RID: 123322 RVA: 0x009A63FC File Offset: 0x009A45FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_contentObj(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			GameObject contentObj;
			LuaObject.checkType<GameObject>(l, 2, out contentObj);
			getPathUIController.m_luaExportHelper.m_contentObj = contentObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1BB RID: 123323 RVA: 0x009A6458 File Offset: 0x009A4658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tips(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUIController.m_luaExportHelper.m_tips);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1BC RID: 123324 RVA: 0x009A64B0 File Offset: 0x009A46B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tips(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			GameObject tips;
			LuaObject.checkType<GameObject>(l, 2, out tips);
			getPathUIController.m_luaExportHelper.m_tips = tips;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1BD RID: 123325 RVA: 0x009A650C File Offset: 0x009A470C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tipsText(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUIController.m_luaExportHelper.m_tipsText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1BE RID: 123326 RVA: 0x009A6564 File Offset: 0x009A4764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tipsText(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			Text tipsText;
			LuaObject.checkType<Text>(l, 2, out tipsText);
			getPathUIController.m_luaExportHelper.m_tipsText = tipsText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1BF RID: 123327 RVA: 0x009A65C0 File Offset: 0x009A47C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_itemPrefab(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, getPathUIController.m_luaExportHelper.m_itemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1C0 RID: 123328 RVA: 0x009A6618 File Offset: 0x009A4818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_itemPrefab(IntPtr l)
	{
		int result;
		try
		{
			GetPathUIController getPathUIController = (GetPathUIController)LuaObject.checkSelf(l);
			GameObject itemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out itemPrefab);
			getPathUIController.m_luaExportHelper.m_itemPrefab = itemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E1C1 RID: 123329 RVA: 0x009A6674 File Offset: 0x009A4874
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GetPathUIController");
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.UpdateViewInGetPathPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.CreatePathItemList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.OnReturnImgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.OnGetPathItemGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__callDele_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.__clearDele_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache17);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache18, true);
		string name2 = "EventOnGotoButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.set_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache19, true);
		string name3 = "m_commonUIStateController";
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.get_m_commonUIStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.set_m_commonUIStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1B, true);
		string name4 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.get_m_nameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1D, true);
		string name5 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.get_m_iconImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache1F, true);
		string name6 = "m_descText";
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.get_m_descText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.set_m_descText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache21, true);
		string name7 = "m_returnImgButton";
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.get_m_returnImgButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.set_m_returnImgButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache23, true);
		string name8 = "m_contentObj";
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.get_m_contentObj);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.set_m_contentObj);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache25, true);
		string name9 = "m_tips";
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.get_m_tips);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.set_m_tips);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache27, true);
		string name10 = "m_tipsText";
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.get_m_tipsText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.set_m_tipsText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache29, true);
		string name11 = "m_itemPrefab";
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.get_m_itemPrefab);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetPathUIController.set_m_itemPrefab);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_GetPathUIController.<>f__mg$cache2B, true);
		LuaObject.createTypeMetatable(l, null, typeof(GetPathUIController), typeof(UIControllerBase));
	}

	// Token: 0x040142BD RID: 82621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040142BE RID: 82622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040142BF RID: 82623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040142C0 RID: 82624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040142C1 RID: 82625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040142C2 RID: 82626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040142C3 RID: 82627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040142C4 RID: 82628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040142C5 RID: 82629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040142C6 RID: 82630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040142C7 RID: 82631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040142C8 RID: 82632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040142C9 RID: 82633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040142CA RID: 82634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040142CB RID: 82635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040142CC RID: 82636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040142CD RID: 82637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040142CE RID: 82638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040142CF RID: 82639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040142D0 RID: 82640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040142D1 RID: 82641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040142D2 RID: 82642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040142D3 RID: 82643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040142D4 RID: 82644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040142D5 RID: 82645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040142D6 RID: 82646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040142D7 RID: 82647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040142D8 RID: 82648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040142D9 RID: 82649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040142DA RID: 82650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040142DB RID: 82651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040142DC RID: 82652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040142DD RID: 82653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040142DE RID: 82654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040142DF RID: 82655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040142E0 RID: 82656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040142E1 RID: 82657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040142E2 RID: 82658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040142E3 RID: 82659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040142E4 RID: 82660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040142E5 RID: 82661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040142E6 RID: 82662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040142E7 RID: 82663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040142E8 RID: 82664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;
}
