using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015B5 RID: 5557
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController : LuaObject
{
	// Token: 0x06021C2C RID: 138284 RVA: 0x00B77940 File Offset: 0x00B75B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDifficultItem(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			int unlockPlayerLevel;
			LuaObject.checkType(l, 2, out unlockPlayerLevel);
			int difficult;
			LuaObject.checkType(l, 3, out difficult);
			trainingDifficultItemUIController.InitDifficultItem(unlockPlayerLevel, difficult);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C2D RID: 138285 RVA: 0x00B779A4 File Offset: 0x00B75BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectFrame(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			trainingDifficultItemUIController.ShowSelectFrame(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C2E RID: 138286 RVA: 0x00B779FC File Offset: 0x00B75BFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			trainingDifficultItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C2F RID: 138287 RVA: 0x00B77A50 File Offset: 0x00B75C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			trainingDifficultItemUIController.m_luaExportHelper.OnItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C30 RID: 138288 RVA: 0x00B77AA4 File Offset: 0x00B75CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			trainingDifficultItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C31 RID: 138289 RVA: 0x00B77B10 File Offset: 0x00B75D10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			trainingDifficultItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C32 RID: 138290 RVA: 0x00B77B64 File Offset: 0x00B75D64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			trainingDifficultItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C33 RID: 138291 RVA: 0x00B77BB8 File Offset: 0x00B75DB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = trainingDifficultItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021C34 RID: 138292 RVA: 0x00B77C60 File Offset: 0x00B75E60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			trainingDifficultItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C35 RID: 138293 RVA: 0x00B77CB4 File Offset: 0x00B75EB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			trainingDifficultItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C36 RID: 138294 RVA: 0x00B77D20 File Offset: 0x00B75F20
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
				TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				trainingDifficultItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TrainingDifficultItemUIController trainingDifficultItemUIController2 = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				trainingDifficultItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021C37 RID: 138295 RVA: 0x00B77E30 File Offset: 0x00B76030
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingDifficultItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C38 RID: 138296 RVA: 0x00B77E9C File Offset: 0x00B7609C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingDifficultItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C39 RID: 138297 RVA: 0x00B77F08 File Offset: 0x00B76108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingDifficultItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C3A RID: 138298 RVA: 0x00B77F74 File Offset: 0x00B76174
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingDifficultItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C3B RID: 138299 RVA: 0x00B77FE0 File Offset: 0x00B761E0
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
				TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				trainingDifficultItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TrainingDifficultItemUIController trainingDifficultItemUIController2 = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				trainingDifficultItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021C3C RID: 138300 RVA: 0x00B780F0 File Offset: 0x00B762F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			string s = trainingDifficultItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021C3D RID: 138301 RVA: 0x00B7814C File Offset: 0x00B7634C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			TrainingDifficultItemUIController obj;
			LuaObject.checkType<TrainingDifficultItemUIController>(l, 2, out obj);
			trainingDifficultItemUIController.m_luaExportHelper.__callDele_EventOnItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C3E RID: 138302 RVA: 0x00B781A8 File Offset: 0x00B763A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			TrainingDifficultItemUIController obj;
			LuaObject.checkType<TrainingDifficultItemUIController>(l, 2, out obj);
			trainingDifficultItemUIController.m_luaExportHelper.__clearDele_EventOnItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C3F RID: 138303 RVA: 0x00B78204 File Offset: 0x00B76404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			Action<TrainingDifficultItemUIController> value;
			int num = LuaObject.checkDelegate<Action<TrainingDifficultItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					trainingDifficultItemUIController.EventOnItemClick += value;
				}
				else if (num == 2)
				{
					trainingDifficultItemUIController.EventOnItemClick -= value;
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

	// Token: 0x06021C40 RID: 138304 RVA: 0x00B78284 File Offset: 0x00B76484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingDifficultItemUIController.m_luaExportHelper.m_uiStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C41 RID: 138305 RVA: 0x00B782DC File Offset: 0x00B764DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateCtrl);
			trainingDifficultItemUIController.m_luaExportHelper.m_uiStateCtrl = uiStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C42 RID: 138306 RVA: 0x00B78338 File Offset: 0x00B76538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unLockText(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingDifficultItemUIController.m_luaExportHelper.m_unLockText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C43 RID: 138307 RVA: 0x00B78390 File Offset: 0x00B76590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unLockText(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			Text unLockText;
			LuaObject.checkType<Text>(l, 2, out unLockText);
			trainingDifficultItemUIController.m_luaExportHelper.m_unLockText = unLockText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C44 RID: 138308 RVA: 0x00B783EC File Offset: 0x00B765EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_newImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingDifficultItemUIController.m_luaExportHelper.m_newImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C45 RID: 138309 RVA: 0x00B78444 File Offset: 0x00B76644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_newImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			GameObject newImage;
			LuaObject.checkType<GameObject>(l, 2, out newImage);
			trainingDifficultItemUIController.m_luaExportHelper.m_newImage = newImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C46 RID: 138310 RVA: 0x00B784A0 File Offset: 0x00B766A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingDifficultItemUIController.m_luaExportHelper.m_selectImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C47 RID: 138311 RVA: 0x00B784F8 File Offset: 0x00B766F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			GameObject selectImage;
			LuaObject.checkType<GameObject>(l, 2, out selectImage);
			trainingDifficultItemUIController.m_luaExportHelper.m_selectImage = selectImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C48 RID: 138312 RVA: 0x00B78554 File Offset: 0x00B76754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLock(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingDifficultItemUIController.m_luaExportHelper.m_isLock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C49 RID: 138313 RVA: 0x00B785AC File Offset: 0x00B767AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isLock(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			bool isLock;
			LuaObject.checkType(l, 2, out isLock);
			trainingDifficultItemUIController.m_luaExportHelper.m_isLock = isLock;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C4A RID: 138314 RVA: 0x00B78608 File Offset: 0x00B76808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNew(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingDifficultItemUIController.m_luaExportHelper.m_isNew);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C4B RID: 138315 RVA: 0x00B78660 File Offset: 0x00B76860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNew(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			bool isNew;
			LuaObject.checkType(l, 2, out isNew);
			trainingDifficultItemUIController.m_luaExportHelper.m_isNew = isNew;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C4C RID: 138316 RVA: 0x00B786BC File Offset: 0x00B768BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DifficultLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingDifficultItemUIController.DifficultLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C4D RID: 138317 RVA: 0x00B78710 File Offset: 0x00B76910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DifficultLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			int difficultLevel;
			LuaObject.checkType(l, 2, out difficultLevel);
			trainingDifficultItemUIController.DifficultLevel = difficultLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C4E RID: 138318 RVA: 0x00B78768 File Offset: 0x00B76968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingDifficultItemUIController.m_luaExportHelper.m_unlockPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C4F RID: 138319 RVA: 0x00B787C0 File Offset: 0x00B769C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			TrainingDifficultItemUIController trainingDifficultItemUIController = (TrainingDifficultItemUIController)LuaObject.checkSelf(l);
			int unlockPlayerLevel;
			LuaObject.checkType(l, 2, out unlockPlayerLevel);
			trainingDifficultItemUIController.m_luaExportHelper.m_unlockPlayerLevel = unlockPlayerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C50 RID: 138320 RVA: 0x00B7881C File Offset: 0x00B76A1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TrainingDifficultItemUIController");
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.InitDifficultItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.ShowSelectFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.OnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__callDele_EventOnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.__clearDele_EventOnItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache12);
		string name = "EventOnItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.set_EventOnItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache13, true);
		string name2 = "m_uiStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.get_m_uiStateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.set_m_uiStateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache15, true);
		string name3 = "m_unLockText";
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.get_m_unLockText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.set_m_unLockText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache17, true);
		string name4 = "m_newImage";
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.get_m_newImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.set_m_newImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache19, true);
		string name5 = "m_selectImage";
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.get_m_selectImage);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.set_m_selectImage);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1B, true);
		string name6 = "m_isLock";
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.get_m_isLock);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.set_m_isLock);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1D, true);
		string name7 = "m_isNew";
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.get_m_isNew);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.set_m_isNew);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache1F, true);
		string name8 = "DifficultLevel";
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.get_DifficultLevel);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.set_DifficultLevel);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache21, true);
		string name9 = "m_unlockPlayerLevel";
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.get_m_unlockPlayerLevel);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.set_m_unlockPlayerLevel);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TrainingDifficultItemUIController.<>f__mg$cache23, true);
		LuaObject.createTypeMetatable(l, null, typeof(TrainingDifficultItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017AA4 RID: 96932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017AA5 RID: 96933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017AA6 RID: 96934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017AA7 RID: 96935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017AA8 RID: 96936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017AA9 RID: 96937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017AAA RID: 96938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017AAB RID: 96939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017AAC RID: 96940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017AAD RID: 96941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017AAE RID: 96942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017AAF RID: 96943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017AB0 RID: 96944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017AB1 RID: 96945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017AB2 RID: 96946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017AB3 RID: 96947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017AB4 RID: 96948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017AB5 RID: 96949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017AB6 RID: 96950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017AB7 RID: 96951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017AB8 RID: 96952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017AB9 RID: 96953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017ABA RID: 96954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017ABB RID: 96955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017ABC RID: 96956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017ABD RID: 96957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017ABE RID: 96958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017ABF RID: 96959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017AC0 RID: 96960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017AC1 RID: 96961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017AC2 RID: 96962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017AC3 RID: 96963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017AC4 RID: 96964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017AC5 RID: 96965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017AC6 RID: 96966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017AC7 RID: 96967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
