using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200143E RID: 5182
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FettersInformationUIController : LuaObject
{
	// Token: 0x0601DD3A RID: 122170 RVA: 0x00982EB0 File Offset: 0x009810B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInFettersInformation(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersInformationUIController.UpdateViewInFettersInformation(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD3B RID: 122171 RVA: 0x00982F08 File Offset: 0x00981108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HaveNewInfomation_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo heroInfomationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 1, out heroInfomationInfo);
			bool b = FettersInformationUIController.HaveNewInfomation(heroInfomationInfo);
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

	// Token: 0x0601DD3C RID: 122172 RVA: 0x00982F5C File Offset: 0x0098115C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HaveNewBiography_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo heroInfomationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 1, out heroInfomationInfo);
			bool b = FettersInformationUIController.HaveNewBiography(heroInfomationInfo);
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

	// Token: 0x0601DD3D RID: 122173 RVA: 0x00982FB0 File Offset: 0x009811B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HaveNewVoice_s(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo heroInfomationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 1, out heroInfomationInfo);
			bool b = FettersInformationUIController.HaveNewVoice(heroInfomationInfo);
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

	// Token: 0x0601DD3E RID: 122174 RVA: 0x00983004 File Offset: 0x00981204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD3F RID: 122175 RVA: 0x00983058 File Offset: 0x00981258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD40 RID: 122176 RVA: 0x009830AC File Offset: 0x009812AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateHeroLifeList(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.UpdateHeroLifeList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD41 RID: 122177 RVA: 0x00983100 File Offset: 0x00981300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateHeroVoiceList(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.UpdateHeroVoiceList();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD42 RID: 122178 RVA: 0x00983154 File Offset: 0x00981354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateToggleNewTag(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.UpdateToggleNewTag();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD43 RID: 122179 RVA: 0x009831A8 File Offset: 0x009813A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPeofermanceVoiceButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			FettersInformationVoiceItemUIController ctrl;
			LuaObject.checkType<FettersInformationVoiceItemUIController>(l, 2, out ctrl);
			fettersInformationUIController.m_luaExportHelper.OnPeofermanceVoiceButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD44 RID: 122180 RVA: 0x00983204 File Offset: 0x00981404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD45 RID: 122181 RVA: 0x00983258 File Offset: 0x00981458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleLifeValueChange(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			fettersInformationUIController.m_luaExportHelper.OnToggleLifeValueChange(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD46 RID: 122182 RVA: 0x009832B4 File Offset: 0x009814B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnToggleVoiceValueChange(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			fettersInformationUIController.m_luaExportHelper.OnToggleVoiceValueChange(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD47 RID: 122183 RVA: 0x00983310 File Offset: 0x00981510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewPosition(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.ResetScrollViewPosition();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD48 RID: 122184 RVA: 0x00983364 File Offset: 0x00981564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			fettersInformationUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD49 RID: 122185 RVA: 0x009833D0 File Offset: 0x009815D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD4A RID: 122186 RVA: 0x00983424 File Offset: 0x00981624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD4B RID: 122187 RVA: 0x00983478 File Offset: 0x00981678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = fettersInformationUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DD4C RID: 122188 RVA: 0x00983520 File Offset: 0x00981720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD4D RID: 122189 RVA: 0x00983574 File Offset: 0x00981774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			fettersInformationUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD4E RID: 122190 RVA: 0x009835E0 File Offset: 0x009817E0
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
				FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				fettersInformationUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				FettersInformationUIController fettersInformationUIController2 = (FettersInformationUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				fettersInformationUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DD4F RID: 122191 RVA: 0x009836F0 File Offset: 0x009818F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD50 RID: 122192 RVA: 0x0098375C File Offset: 0x0098195C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD51 RID: 122193 RVA: 0x009837C8 File Offset: 0x009819C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD52 RID: 122194 RVA: 0x00983834 File Offset: 0x00981A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			fettersInformationUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD53 RID: 122195 RVA: 0x009838A0 File Offset: 0x00981AA0
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
				FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				fettersInformationUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				FettersInformationUIController fettersInformationUIController2 = (FettersInformationUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				fettersInformationUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DD54 RID: 122196 RVA: 0x009839B0 File Offset: 0x00981BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			string s = fettersInformationUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DD55 RID: 122197 RVA: 0x00983A0C File Offset: 0x00981C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD56 RID: 122198 RVA: 0x00983A60 File Offset: 0x00981C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			fettersInformationUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD57 RID: 122199 RVA: 0x00983AB4 File Offset: 0x00981CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnVoiceItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			fettersInformationUIController.m_luaExportHelper.__callDele_EventOnVoiceItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD58 RID: 122200 RVA: 0x00983B10 File Offset: 0x00981D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnVoiceItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			fettersInformationUIController.m_luaExportHelper.__clearDele_EventOnVoiceItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD59 RID: 122201 RVA: 0x00983B6C File Offset: 0x00981D6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersInformationUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					fettersInformationUIController.EventOnReturn -= value;
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

	// Token: 0x0601DD5A RID: 122202 RVA: 0x00983BEC File Offset: 0x00981DEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnVoiceItemClick(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					fettersInformationUIController.EventOnVoiceItemClick += value;
				}
				else if (num == 2)
				{
					fettersInformationUIController.EventOnVoiceItemClick -= value;
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

	// Token: 0x0601DD5B RID: 122203 RVA: 0x00983C6C File Offset: 0x00981E6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_commonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_commonUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD5C RID: 122204 RVA: 0x00983CC4 File Offset: 0x00981EC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_commonUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			CommonUIStateController commonUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out commonUIStateCtrl);
			fettersInformationUIController.m_luaExportHelper.m_commonUIStateCtrl = commonUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD5D RID: 122205 RVA: 0x00983D20 File Offset: 0x00981F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD5E RID: 122206 RVA: 0x00983D78 File Offset: 0x00981F78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			fettersInformationUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD5F RID: 122207 RVA: 0x00983DD4 File Offset: 0x00981FD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_toggleLife(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_toggleLife);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD60 RID: 122208 RVA: 0x00983E2C File Offset: 0x0098202C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggleLife(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			ToggleEx toggleLife;
			LuaObject.checkType<ToggleEx>(l, 2, out toggleLife);
			fettersInformationUIController.m_luaExportHelper.m_toggleLife = toggleLife;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD61 RID: 122209 RVA: 0x00983E88 File Offset: 0x00982088
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_toggleVoice(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_toggleVoice);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD62 RID: 122210 RVA: 0x00983EE0 File Offset: 0x009820E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggleVoice(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			ToggleEx toggleVoice;
			LuaObject.checkType<ToggleEx>(l, 2, out toggleVoice);
			fettersInformationUIController.m_luaExportHelper.m_toggleVoice = toggleVoice;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD63 RID: 122211 RVA: 0x00983F3C File Offset: 0x0098213C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_toggleLifeRedPoint(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_toggleLifeRedPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD64 RID: 122212 RVA: 0x00983F94 File Offset: 0x00982194
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_toggleLifeRedPoint(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			GameObject toggleLifeRedPoint;
			LuaObject.checkType<GameObject>(l, 2, out toggleLifeRedPoint);
			fettersInformationUIController.m_luaExportHelper.m_toggleLifeRedPoint = toggleLifeRedPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD65 RID: 122213 RVA: 0x00983FF0 File Offset: 0x009821F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggleVoiceRedPoint(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_toggleVoiceRedPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD66 RID: 122214 RVA: 0x00984048 File Offset: 0x00982248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_toggleVoiceRedPoint(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			GameObject toggleVoiceRedPoint;
			LuaObject.checkType<GameObject>(l, 2, out toggleVoiceRedPoint);
			fettersInformationUIController.m_luaExportHelper.m_toggleVoiceRedPoint = toggleVoiceRedPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD67 RID: 122215 RVA: 0x009840A4 File Offset: 0x009822A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lifeScrollRect(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_lifeScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD68 RID: 122216 RVA: 0x009840FC File Offset: 0x009822FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lifeScrollRect(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			ScrollRect lifeScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out lifeScrollRect);
			fettersInformationUIController.m_luaExportHelper.m_lifeScrollRect = lifeScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD69 RID: 122217 RVA: 0x00984158 File Offset: 0x00982358
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_voiceScrollRect(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_voiceScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD6A RID: 122218 RVA: 0x009841B0 File Offset: 0x009823B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_voiceScrollRect(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			ScrollRect voiceScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out voiceScrollRect);
			fettersInformationUIController.m_luaExportHelper.m_voiceScrollRect = voiceScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD6B RID: 122219 RVA: 0x0098420C File Offset: 0x0098240C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lifeContent(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_lifeContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD6C RID: 122220 RVA: 0x00984264 File Offset: 0x00982464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lifeContent(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			GameObject lifeContent;
			LuaObject.checkType<GameObject>(l, 2, out lifeContent);
			fettersInformationUIController.m_luaExportHelper.m_lifeContent = lifeContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD6D RID: 122221 RVA: 0x009842C0 File Offset: 0x009824C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceContent(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_voiceContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD6E RID: 122222 RVA: 0x00984318 File Offset: 0x00982518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceContent(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			GameObject voiceContent;
			LuaObject.checkType<GameObject>(l, 2, out voiceContent);
			fettersInformationUIController.m_luaExportHelper.m_voiceContent = voiceContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD6F RID: 122223 RVA: 0x00984374 File Offset: 0x00982574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceCVNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_voiceCVNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD70 RID: 122224 RVA: 0x009843CC File Offset: 0x009825CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceCVNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			Text voiceCVNameText;
			LuaObject.checkType<Text>(l, 2, out voiceCVNameText);
			fettersInformationUIController.m_luaExportHelper.m_voiceCVNameText = voiceCVNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD71 RID: 122225 RVA: 0x00984428 File Offset: 0x00982628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_heroNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD72 RID: 122226 RVA: 0x00984480 File Offset: 0x00982680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			Text heroNameText;
			LuaObject.checkType<Text>(l, 2, out heroNameText);
			fettersInformationUIController.m_luaExportHelper.m_heroNameText = heroNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD73 RID: 122227 RVA: 0x009844DC File Offset: 0x009826DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroEngNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_heroEngNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD74 RID: 122228 RVA: 0x00984534 File Offset: 0x00982734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroEngNameText(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			Text heroEngNameText;
			LuaObject.checkType<Text>(l, 2, out heroEngNameText);
			fettersInformationUIController.m_luaExportHelper.m_heroEngNameText = heroEngNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD75 RID: 122229 RVA: 0x00984590 File Offset: 0x00982790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroRankImage(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_heroRankImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD76 RID: 122230 RVA: 0x009845E8 File Offset: 0x009827E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroRankImage(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			Image heroRankImage;
			LuaObject.checkType<Image>(l, 2, out heroRankImage);
			fettersInformationUIController.m_luaExportHelper.m_heroRankImage = heroRankImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD77 RID: 122231 RVA: 0x00984644 File Offset: 0x00982844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD78 RID: 122232 RVA: 0x0098469C File Offset: 0x0098289C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			fettersInformationUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD79 RID: 122233 RVA: 0x009846F8 File Offset: 0x009828F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInformationInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_heroInformationInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD7A RID: 122234 RVA: 0x00984750 File Offset: 0x00982950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInformationInfo(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			ConfigDataHeroInformationInfo heroInformationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 2, out heroInformationInfo);
			fettersInformationUIController.m_luaExportHelper.m_heroInformationInfo = heroInformationInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD7B RID: 122235 RVA: 0x009847AC File Offset: 0x009829AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_biographyCtrlList(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.biographyCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD7C RID: 122236 RVA: 0x00984804 File Offset: 0x00982A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_biographyCtrlList(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			List<FettersInformationLifeItemUIController> biographyCtrlList;
			LuaObject.checkType<List<FettersInformationLifeItemUIController>>(l, 2, out biographyCtrlList);
			fettersInformationUIController.m_luaExportHelper.biographyCtrlList = biographyCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD7D RID: 122237 RVA: 0x00984860 File Offset: 0x00982A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_voiceCtrlList(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.voiceCtrlList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD7E RID: 122238 RVA: 0x009848B8 File Offset: 0x00982AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_voiceCtrlList(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			List<FettersInformationVoiceItemUIController> voiceCtrlList;
			LuaObject.checkType<List<FettersInformationVoiceItemUIController>>(l, 2, out voiceCtrlList);
			fettersInformationUIController.m_luaExportHelper.voiceCtrlList = voiceCtrlList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD7F RID: 122239 RVA: 0x00984914 File Offset: 0x00982B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fettersInformationUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD80 RID: 122240 RVA: 0x0098496C File Offset: 0x00982B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			FettersInformationUIController fettersInformationUIController = (FettersInformationUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			fettersInformationUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DD81 RID: 122241 RVA: 0x009849C8 File Offset: 0x00982BC8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FettersInformationUIController");
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.UpdateViewInFettersInformation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.HaveNewInfomation_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.HaveNewBiography_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.HaveNewVoice_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.UpdateHeroLifeList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.UpdateHeroVoiceList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.UpdateToggleNewTag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.OnPeofermanceVoiceButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.OnToggleLifeValueChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.OnToggleVoiceValueChange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.ResetScrollViewPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__callDele_EventOnVoiceItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.__clearDele_EventOnVoiceItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1E);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache1F, true);
		string name2 = "EventOnVoiceItemClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_EventOnVoiceItemClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache20, true);
		string name3 = "m_commonUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_commonUIStateCtrl);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_commonUIStateCtrl);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache22, true);
		string name4 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_returnButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache24, true);
		string name5 = "m_toggleLife";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_toggleLife);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_toggleLife);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache26, true);
		string name6 = "m_toggleVoice";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_toggleVoice);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_toggleVoice);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache28, true);
		string name7 = "m_toggleLifeRedPoint";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_toggleLifeRedPoint);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_toggleLifeRedPoint);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2A, true);
		string name8 = "m_toggleVoiceRedPoint";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_toggleVoiceRedPoint);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_toggleVoiceRedPoint);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2C, true);
		string name9 = "m_lifeScrollRect";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_lifeScrollRect);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_lifeScrollRect);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2E, true);
		string name10 = "m_voiceScrollRect";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_voiceScrollRect);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_voiceScrollRect);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache30, true);
		string name11 = "m_lifeContent";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_lifeContent);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_lifeContent);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache32, true);
		string name12 = "m_voiceContent";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_voiceContent);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_voiceContent);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache34, true);
		string name13 = "m_voiceCVNameText";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_voiceCVNameText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_voiceCVNameText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache36, true);
		string name14 = "m_heroNameText";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_heroNameText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_heroNameText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache38, true);
		string name15 = "m_heroEngNameText";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_heroEngNameText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_heroEngNameText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3A, true);
		string name16 = "m_heroRankImage";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_heroRankImage);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_heroRankImage);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3C, true);
		string name17 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_hero);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_hero);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3E, true);
		string name18 = "m_heroInformationInfo";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_heroInformationInfo);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_heroInformationInfo);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache40, true);
		string name19 = "biographyCtrlList";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_biographyCtrlList);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_biographyCtrlList);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache42, true);
		string name20 = "voiceCtrlList";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_voiceCtrlList);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_voiceCtrlList);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache44, true);
		string name21 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.get_m_configDataLoader);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FettersInformationUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_FettersInformationUIController.<>f__mg$cache46, true);
		LuaObject.createTypeMetatable(l, null, typeof(FettersInformationUIController), typeof(UIControllerBase));
	}

	// Token: 0x04013EA0 RID: 81568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013EA1 RID: 81569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013EA2 RID: 81570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013EA3 RID: 81571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013EA4 RID: 81572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013EA5 RID: 81573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013EA6 RID: 81574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013EA7 RID: 81575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013EA8 RID: 81576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013EA9 RID: 81577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013EAA RID: 81578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013EAB RID: 81579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013EAC RID: 81580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013EAD RID: 81581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013EAE RID: 81582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013EAF RID: 81583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013EB0 RID: 81584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013EB1 RID: 81585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013EB2 RID: 81586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013EB3 RID: 81587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013EB4 RID: 81588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013EB5 RID: 81589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013EB6 RID: 81590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013EB7 RID: 81591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013EB8 RID: 81592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013EB9 RID: 81593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013EBA RID: 81594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013EBB RID: 81595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013EBC RID: 81596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013EBD RID: 81597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04013EBE RID: 81598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04013EBF RID: 81599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04013EC0 RID: 81600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04013EC1 RID: 81601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04013EC2 RID: 81602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04013EC3 RID: 81603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04013EC4 RID: 81604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04013EC5 RID: 81605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04013EC6 RID: 81606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04013EC7 RID: 81607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04013EC8 RID: 81608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04013EC9 RID: 81609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04013ECA RID: 81610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04013ECB RID: 81611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04013ECC RID: 81612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04013ECD RID: 81613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04013ECE RID: 81614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04013ECF RID: 81615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04013ED0 RID: 81616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04013ED1 RID: 81617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04013ED2 RID: 81618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04013ED3 RID: 81619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04013ED4 RID: 81620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04013ED5 RID: 81621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04013ED6 RID: 81622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04013ED7 RID: 81623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04013ED8 RID: 81624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04013ED9 RID: 81625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04013EDA RID: 81626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04013EDB RID: 81627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04013EDC RID: 81628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04013EDD RID: 81629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04013EDE RID: 81630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04013EDF RID: 81631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04013EE0 RID: 81632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04013EE1 RID: 81633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04013EE2 RID: 81634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04013EE3 RID: 81635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04013EE4 RID: 81636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04013EE5 RID: 81637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04013EE6 RID: 81638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;
}
