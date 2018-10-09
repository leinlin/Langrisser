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

// Token: 0x020014CA RID: 5322
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController : LuaObject
{
	// Token: 0x0601F22B RID: 127531 RVA: 0x00A28AF4 File Offset: 0x00A26CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitJobMasterItem(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			ConfigDataJobInfo jobInfo;
			LuaObject.checkType<ConfigDataJobInfo>(l, 2, out jobInfo);
			bool isMaster;
			LuaObject.checkType(l, 3, out isMaster);
			heroJobMasterJobItemUIController.InitJobMasterItem(jobInfo, isMaster);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F22C RID: 127532 RVA: 0x00A28B58 File Offset: 0x00A26D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			heroJobMasterJobItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F22D RID: 127533 RVA: 0x00A28BAC File Offset: 0x00A26DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMasterRewardProperty(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			PropertyModifyType type;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out type);
			int value;
			LuaObject.checkType(l, 3, out value);
			heroJobMasterJobItemUIController.m_luaExportHelper.SetMasterRewardProperty(type, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F22E RID: 127534 RVA: 0x00A28C18 File Offset: 0x00A26E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F22F RID: 127535 RVA: 0x00A28C84 File Offset: 0x00A26E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F230 RID: 127536 RVA: 0x00A28CD8 File Offset: 0x00A26ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F231 RID: 127537 RVA: 0x00A28D2C File Offset: 0x00A26F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F232 RID: 127538 RVA: 0x00A28DD4 File Offset: 0x00A26FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F233 RID: 127539 RVA: 0x00A28E28 File Offset: 0x00A27028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F234 RID: 127540 RVA: 0x00A28E94 File Offset: 0x00A27094
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
				HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroJobMasterJobItemUIController heroJobMasterJobItemUIController2 = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroJobMasterJobItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F235 RID: 127541 RVA: 0x00A28FA4 File Offset: 0x00A271A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F236 RID: 127542 RVA: 0x00A29010 File Offset: 0x00A27210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F237 RID: 127543 RVA: 0x00A2907C File Offset: 0x00A2727C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F238 RID: 127544 RVA: 0x00A290E8 File Offset: 0x00A272E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F239 RID: 127545 RVA: 0x00A29154 File Offset: 0x00A27354
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
				HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroJobMasterJobItemUIController heroJobMasterJobItemUIController2 = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroJobMasterJobItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F23A RID: 127546 RVA: 0x00A29264 File Offset: 0x00A27464
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			string s = heroJobMasterJobItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F23B RID: 127547 RVA: 0x00A292C0 File Offset: 0x00A274C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F23C RID: 127548 RVA: 0x00A29318 File Offset: 0x00A27518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F23D RID: 127549 RVA: 0x00A29374 File Offset: 0x00A27574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_icon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F23E RID: 127550 RVA: 0x00A293CC File Offset: 0x00A275CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_icon(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			Image icon;
			LuaObject.checkType<Image>(l, 2, out icon);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F23F RID: 127551 RVA: 0x00A29428 File Offset: 0x00A27628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F240 RID: 127552 RVA: 0x00A29480 File Offset: 0x00A27680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F241 RID: 127553 RVA: 0x00A294DC File Offset: 0x00A276DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyContent(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F242 RID: 127554 RVA: 0x00A29534 File Offset: 0x00A27734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyContent(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			GameObject propertyContent;
			LuaObject.checkType<GameObject>(l, 2, out propertyContent);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyContent = propertyContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F243 RID: 127555 RVA: 0x00A29590 File Offset: 0x00A27790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyHP(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyHP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F244 RID: 127556 RVA: 0x00A295E8 File Offset: 0x00A277E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyHP(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			GameObject propertyHP;
			LuaObject.checkType<GameObject>(l, 2, out propertyHP);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyHP = propertyHP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F245 RID: 127557 RVA: 0x00A29644 File Offset: 0x00A27844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F246 RID: 127558 RVA: 0x00A2969C File Offset: 0x00A2789C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			Text propertyHPValueText;
			LuaObject.checkType<Text>(l, 2, out propertyHPValueText);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyHPValueText = propertyHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F247 RID: 127559 RVA: 0x00A296F8 File Offset: 0x00A278F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyAT(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyAT);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F248 RID: 127560 RVA: 0x00A29750 File Offset: 0x00A27950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyAT(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			GameObject propertyAT;
			LuaObject.checkType<GameObject>(l, 2, out propertyAT);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyAT = propertyAT;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F249 RID: 127561 RVA: 0x00A297AC File Offset: 0x00A279AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F24A RID: 127562 RVA: 0x00A29804 File Offset: 0x00A27A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			Text propertyATValueText;
			LuaObject.checkType<Text>(l, 2, out propertyATValueText);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyATValueText = propertyATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F24B RID: 127563 RVA: 0x00A29860 File Offset: 0x00A27A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyDF(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyDF);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F24C RID: 127564 RVA: 0x00A298B8 File Offset: 0x00A27AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyDF(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			GameObject propertyDF;
			LuaObject.checkType<GameObject>(l, 2, out propertyDF);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyDF = propertyDF;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F24D RID: 127565 RVA: 0x00A29914 File Offset: 0x00A27B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F24E RID: 127566 RVA: 0x00A2996C File Offset: 0x00A27B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			Text propertyDFValueText;
			LuaObject.checkType<Text>(l, 2, out propertyDFValueText);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyDFValueText = propertyDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F24F RID: 127567 RVA: 0x00A299C8 File Offset: 0x00A27BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyDEX(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyDEX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F250 RID: 127568 RVA: 0x00A29A20 File Offset: 0x00A27C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyDEX(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			GameObject propertyDEX;
			LuaObject.checkType<GameObject>(l, 2, out propertyDEX);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyDEX = propertyDEX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F251 RID: 127569 RVA: 0x00A29A7C File Offset: 0x00A27C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyDEXValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyDEXValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F252 RID: 127570 RVA: 0x00A29AD4 File Offset: 0x00A27CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyDEXValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			Text propertyDEXValueText;
			LuaObject.checkType<Text>(l, 2, out propertyDEXValueText);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyDEXValueText = propertyDEXValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F253 RID: 127571 RVA: 0x00A29B30 File Offset: 0x00A27D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyMagicDF(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyMagicDF);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F254 RID: 127572 RVA: 0x00A29B88 File Offset: 0x00A27D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyMagicDF(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			GameObject propertyMagicDF;
			LuaObject.checkType<GameObject>(l, 2, out propertyMagicDF);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyMagicDF = propertyMagicDF;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F255 RID: 127573 RVA: 0x00A29BE4 File Offset: 0x00A27DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F256 RID: 127574 RVA: 0x00A29C3C File Offset: 0x00A27E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			Text propertyMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out propertyMagicDFValueText);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyMagicDFValueText = propertyMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F257 RID: 127575 RVA: 0x00A29C98 File Offset: 0x00A27E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyMagic(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyMagic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F258 RID: 127576 RVA: 0x00A29CF0 File Offset: 0x00A27EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyMagic(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			GameObject propertyMagic;
			LuaObject.checkType<GameObject>(l, 2, out propertyMagic);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyMagic = propertyMagic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F259 RID: 127577 RVA: 0x00A29D4C File Offset: 0x00A27F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyMagicValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F25A RID: 127578 RVA: 0x00A29DA4 File Offset: 0x00A27FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroJobMasterJobItemUIController heroJobMasterJobItemUIController = (HeroJobMasterJobItemUIController)LuaObject.checkSelf(l);
			Text propertyMagicValueText;
			LuaObject.checkType<Text>(l, 2, out propertyMagicValueText);
			heroJobMasterJobItemUIController.m_luaExportHelper.m_propertyMagicValueText = propertyMagicValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F25B RID: 127579 RVA: 0x00A29E00 File Offset: 0x00A28000
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroJobMasterJobItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.InitJobMasterItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.SetMasterRewardProperty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cacheF);
		string name = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_stateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache11, true);
		string name2 = "m_icon";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_icon);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_icon);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache13, true);
		string name3 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_nameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache15, true);
		string name4 = "m_propertyContent";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyContent);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyContent);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache17, true);
		string name5 = "m_propertyHP";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyHP);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyHP);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache19, true);
		string name6 = "m_propertyHPValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyHPValueText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyHPValueText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1B, true);
		string name7 = "m_propertyAT";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyAT);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyAT);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1D, true);
		string name8 = "m_propertyATValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyATValueText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyATValueText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache1F, true);
		string name9 = "m_propertyDF";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyDF);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyDF);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache21, true);
		string name10 = "m_propertyDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyDFValueText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyDFValueText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache23, true);
		string name11 = "m_propertyDEX";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyDEX);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyDEX);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache25, true);
		string name12 = "m_propertyDEXValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyDEXValueText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyDEXValueText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache27, true);
		string name13 = "m_propertyMagicDF";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyMagicDF);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyMagicDF);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache29, true);
		string name14 = "m_propertyMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyMagicDFValueText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyMagicDFValueText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2B, true);
		string name15 = "m_propertyMagic";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyMagic);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyMagic);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2D, true);
		string name16 = "m_propertyMagicValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.get_m_propertyMagicValueText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.set_m_propertyMagicValueText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroJobMasterJobItemUIController.<>f__mg$cache2F, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroJobMasterJobItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015279 RID: 86649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401527A RID: 86650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401527B RID: 86651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401527C RID: 86652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401527D RID: 86653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401527E RID: 86654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401527F RID: 86655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015280 RID: 86656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015281 RID: 86657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015282 RID: 86658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015283 RID: 86659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015284 RID: 86660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015285 RID: 86661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015286 RID: 86662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015287 RID: 86663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015288 RID: 86664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015289 RID: 86665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401528A RID: 86666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401528B RID: 86667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401528C RID: 86668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401528D RID: 86669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401528E RID: 86670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401528F RID: 86671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015290 RID: 86672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015291 RID: 86673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015292 RID: 86674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015293 RID: 86675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015294 RID: 86676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015295 RID: 86677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015296 RID: 86678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015297 RID: 86679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015298 RID: 86680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015299 RID: 86681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401529A RID: 86682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401529B RID: 86683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401529C RID: 86684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401529D RID: 86685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401529E RID: 86686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401529F RID: 86687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040152A0 RID: 86688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040152A1 RID: 86689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040152A2 RID: 86690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040152A3 RID: 86691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040152A4 RID: 86692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040152A5 RID: 86693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040152A6 RID: 86694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040152A7 RID: 86695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040152A8 RID: 86696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
