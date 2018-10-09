using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200143F RID: 5183
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController : LuaObject
{
	// Token: 0x0601DD83 RID: 122243 RVA: 0x009853C8 File Offset: 0x009835C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitVoiceItem(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			int heroPerformanceId;
			LuaObject.checkType(l, 2, out heroPerformanceId);
			fettersInformationVoiceItemUIController.InitVoiceItem(heroPerformanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD84 RID: 122244 RVA: 0x00985420 File Offset: 0x00983620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateIsNewValue(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			fettersInformationVoiceItemUIController.UpdateIsNewValue();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD85 RID: 122245 RVA: 0x0098546C File Offset: 0x0098366C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNewTagActive(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			bool b = fettersInformationVoiceItemUIController.IsNewTagActive();
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

	// Token: 0x0601DD86 RID: 122246 RVA: 0x009854C0 File Offset: 0x009836C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			fettersInformationVoiceItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD87 RID: 122247 RVA: 0x00985514 File Offset: 0x00983714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPerformanceRead(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			bool b = fettersInformationVoiceItemUIController.m_luaExportHelper.IsPerformanceRead(id);
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

	// Token: 0x0601DD88 RID: 122248 RVA: 0x0098557C File Offset: 0x0098377C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnVoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			fettersInformationVoiceItemUIController.m_luaExportHelper.OnVoiceButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD89 RID: 122249 RVA: 0x009855D0 File Offset: 0x009837D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD8A RID: 122250 RVA: 0x0098563C File Offset: 0x0098383C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD8B RID: 122251 RVA: 0x00985690 File Offset: 0x00983890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD8C RID: 122252 RVA: 0x009856E4 File Offset: 0x009838E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DD8D RID: 122253 RVA: 0x0098578C File Offset: 0x0098398C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD8E RID: 122254 RVA: 0x009857E0 File Offset: 0x009839E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD8F RID: 122255 RVA: 0x0098584C File Offset: 0x00983A4C
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
				FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController2 = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				fettersInformationVoiceItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DD90 RID: 122256 RVA: 0x0098595C File Offset: 0x00983B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD91 RID: 122257 RVA: 0x009859C8 File Offset: 0x00983BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD92 RID: 122258 RVA: 0x00985A34 File Offset: 0x00983C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD93 RID: 122259 RVA: 0x00985AA0 File Offset: 0x00983CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD94 RID: 122260 RVA: 0x00985B0C File Offset: 0x00983D0C
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
				FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController2 = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				fettersInformationVoiceItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DD95 RID: 122261 RVA: 0x00985C1C File Offset: 0x00983E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			string s = fettersInformationVoiceItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DD96 RID: 122262 RVA: 0x00985C78 File Offset: 0x00983E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnVoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			FettersInformationVoiceItemUIController obj;
			LuaObject.checkType<FettersInformationVoiceItemUIController>(l, 2, out obj);
			fettersInformationVoiceItemUIController.m_luaExportHelper.__callDele_EventOnVoiceButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD97 RID: 122263 RVA: 0x00985CD4 File Offset: 0x00983ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnVoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			FettersInformationVoiceItemUIController obj;
			LuaObject.checkType<FettersInformationVoiceItemUIController>(l, 2, out obj);
			fettersInformationVoiceItemUIController.m_luaExportHelper.__clearDele_EventOnVoiceButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD98 RID: 122264 RVA: 0x00985D30 File Offset: 0x00983F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnVoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			Action<FettersInformationVoiceItemUIController> value;
			int num = LuaObject.checkDelegate<Action<FettersInformationVoiceItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersInformationVoiceItemUIController.EventOnVoiceButtonClick += value;
				}
				else if (num == 2)
				{
					fettersInformationVoiceItemUIController.EventOnVoiceButtonClick -= value;
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

	// Token: 0x0601DD99 RID: 122265 RVA: 0x00985DB0 File Offset: 0x00983FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationVoiceItemUIController.m_luaExportHelper.m_uiStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD9A RID: 122266 RVA: 0x00985E08 File Offset: 0x00984008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateCtrl);
			fettersInformationVoiceItemUIController.m_luaExportHelper.m_uiStateCtrl = uiStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD9B RID: 122267 RVA: 0x00985E64 File Offset: 0x00984064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unlockNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationVoiceItemUIController.m_luaExportHelper.m_unlockNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD9C RID: 122268 RVA: 0x00985EBC File Offset: 0x009840BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unlockNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			Text unlockNameText;
			LuaObject.checkType<Text>(l, 2, out unlockNameText);
			fettersInformationVoiceItemUIController.m_luaExportHelper.m_unlockNameText = unlockNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD9D RID: 122269 RVA: 0x00985F18 File Offset: 0x00984118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceButton(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationVoiceItemUIController.m_luaExportHelper.m_voiceButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD9E RID: 122270 RVA: 0x00985F70 File Offset: 0x00984170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceButton(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			Button voiceButton;
			LuaObject.checkType<Button>(l, 2, out voiceButton);
			fettersInformationVoiceItemUIController.m_luaExportHelper.m_voiceButton = voiceButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD9F RID: 122271 RVA: 0x00985FCC File Offset: 0x009841CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationVoiceItemUIController.m_luaExportHelper.m_lockText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDA0 RID: 122272 RVA: 0x00986024 File Offset: 0x00984224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			Text lockText;
			LuaObject.checkType<Text>(l, 2, out lockText);
			fettersInformationVoiceItemUIController.m_luaExportHelper.m_lockText = lockText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDA1 RID: 122273 RVA: 0x00986080 File Offset: 0x00984280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroPerformanceInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationVoiceItemUIController.HeroPerformanceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDA2 RID: 122274 RVA: 0x009860D4 File Offset: 0x009842D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroPerformanceInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			ConfigDataHeroPerformanceInfo heroPerformanceInfo;
			LuaObject.checkType<ConfigDataHeroPerformanceInfo>(l, 2, out heroPerformanceInfo);
			fettersInformationVoiceItemUIController.HeroPerformanceInfo = heroPerformanceInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDA3 RID: 122275 RVA: 0x0098612C File Offset: 0x0098432C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsNew(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationVoiceItemUIController.IsNew);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDA4 RID: 122276 RVA: 0x00986184 File Offset: 0x00984384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsNew(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			bool? isNew;
			LuaObject.checkNullable<bool>(l, 2, out isNew);
			fettersInformationVoiceItemUIController.IsNew = isNew;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDA5 RID: 122277 RVA: 0x009861DC File Offset: 0x009843DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLock(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationVoiceItemUIController.m_luaExportHelper.m_isLock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDA6 RID: 122278 RVA: 0x00986234 File Offset: 0x00984434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isLock(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationVoiceItemUIController fettersInformationVoiceItemUIController = (FettersInformationVoiceItemUIController)LuaObject.checkSelf(l);
			bool isLock;
			LuaObject.checkType(l, 2, out isLock);
			fettersInformationVoiceItemUIController.m_luaExportHelper.m_isLock = isLock;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DDA7 RID: 122279 RVA: 0x00986290 File Offset: 0x00984490
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersInformationVoiceItemUIController");
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.InitVoiceItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.UpdateIsNewValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.IsNewTagActive);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.IsPerformanceRead);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.OnVoiceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__callDele_EventOnVoiceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.__clearDele_EventOnVoiceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache14);
		string name = "EventOnVoiceButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.set_EventOnVoiceButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache15, true);
		string name2 = "m_uiStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.get_m_uiStateCtrl);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.set_m_uiStateCtrl);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache17, true);
		string name3 = "m_unlockNameText";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.get_m_unlockNameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.set_m_unlockNameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache19, true);
		string name4 = "m_voiceButton";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.get_m_voiceButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.set_m_voiceButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1B, true);
		string name5 = "m_lockText";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.get_m_lockText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.set_m_lockText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1D, true);
		string name6 = "HeroPerformanceInfo";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.get_HeroPerformanceInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.set_HeroPerformanceInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache1F, true);
		string name7 = "IsNew";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.get_IsNew);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.set_IsNew);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache21, true);
		string name8 = "m_isLock";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.get_m_isLock);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.set_m_isLock);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FettersInformationVoiceItemUIController.<>f__mg$cache23, true);
		LuaObject.createTypeMetatable(l, null, typeof(FettersInformationVoiceItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013EE7 RID: 81639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013EE8 RID: 81640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013EE9 RID: 81641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013EEA RID: 81642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013EEB RID: 81643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013EEC RID: 81644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013EED RID: 81645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013EEE RID: 81646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013EEF RID: 81647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013EF0 RID: 81648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013EF1 RID: 81649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013EF2 RID: 81650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013EF3 RID: 81651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013EF4 RID: 81652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013EF5 RID: 81653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013EF6 RID: 81654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013EF7 RID: 81655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013EF8 RID: 81656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013EF9 RID: 81657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013EFA RID: 81658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013EFB RID: 81659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013EFC RID: 81660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013EFD RID: 81661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013EFE RID: 81662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013EFF RID: 81663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013F00 RID: 81664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013F01 RID: 81665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013F02 RID: 81666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013F03 RID: 81667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013F04 RID: 81668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013F05 RID: 81669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013F06 RID: 81670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013F07 RID: 81671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013F08 RID: 81672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013F09 RID: 81673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013F0A RID: 81674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
