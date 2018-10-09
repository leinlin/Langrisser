using System;
using System.Collections;
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

// Token: 0x020014A3 RID: 5283
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController : LuaObject
{
	// Token: 0x0601E931 RID: 125233 RVA: 0x009E0A14 File Offset: 0x009DEC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroBreakEffectUpdateView(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			heroBreakEffectUIController.HeroBreakEffectUpdateView(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E932 RID: 125234 RVA: 0x009E0A6C File Offset: 0x009DEC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			heroBreakEffectUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E933 RID: 125235 RVA: 0x009E0AB8 File Offset: 0x009DECB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			heroBreakEffectUIController.Close();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E934 RID: 125236 RVA: 0x009E0B04 File Offset: 0x009DED04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			heroBreakEffectUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E935 RID: 125237 RVA: 0x009E0B58 File Offset: 0x009DED58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBreakHeroInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			heroBreakEffectUIController.m_luaExportHelper.SetBreakHeroInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E936 RID: 125238 RVA: 0x009E0BAC File Offset: 0x009DEDAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowStarEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroBreakEffectUIController.m_luaExportHelper.ShowStarEffect();
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

	// Token: 0x0601E937 RID: 125239 RVA: 0x009E0C08 File Offset: 0x009DEE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			heroBreakEffectUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E938 RID: 125240 RVA: 0x009E0C5C File Offset: 0x009DEE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroBreakEffectUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E939 RID: 125241 RVA: 0x009E0CC8 File Offset: 0x009DEEC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			heroBreakEffectUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E93A RID: 125242 RVA: 0x009E0D1C File Offset: 0x009DEF1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			heroBreakEffectUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E93B RID: 125243 RVA: 0x009E0D70 File Offset: 0x009DEF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroBreakEffectUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601E93C RID: 125244 RVA: 0x009E0E18 File Offset: 0x009DF018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			heroBreakEffectUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E93D RID: 125245 RVA: 0x009E0E6C File Offset: 0x009DF06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroBreakEffectUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E93E RID: 125246 RVA: 0x009E0ED8 File Offset: 0x009DF0D8
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
				HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroBreakEffectUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroBreakEffectUIController heroBreakEffectUIController2 = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroBreakEffectUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601E93F RID: 125247 RVA: 0x009E0FE8 File Offset: 0x009DF1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroBreakEffectUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E940 RID: 125248 RVA: 0x009E1054 File Offset: 0x009DF254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroBreakEffectUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E941 RID: 125249 RVA: 0x009E10C0 File Offset: 0x009DF2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroBreakEffectUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E942 RID: 125250 RVA: 0x009E112C File Offset: 0x009DF32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroBreakEffectUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E943 RID: 125251 RVA: 0x009E1198 File Offset: 0x009DF398
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
				HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroBreakEffectUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroBreakEffectUIController heroBreakEffectUIController2 = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroBreakEffectUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601E944 RID: 125252 RVA: 0x009E12A8 File Offset: 0x009DF4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			string s = heroBreakEffectUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601E945 RID: 125253 RVA: 0x009E1304 File Offset: 0x009DF504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			heroBreakEffectUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E946 RID: 125254 RVA: 0x009E1358 File Offset: 0x009DF558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			heroBreakEffectUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E947 RID: 125255 RVA: 0x009E13AC File Offset: 0x009DF5AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_stateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E948 RID: 125256 RVA: 0x009E1404 File Offset: 0x009DF604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			CommonUIStateController stateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out stateCtrl);
			heroBreakEffectUIController.m_luaExportHelper.m_stateCtrl = stateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E949 RID: 125257 RVA: 0x009E1460 File Offset: 0x009DF660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroCharGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E94A RID: 125258 RVA: 0x009E14B8 File Offset: 0x009DF6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			GameObject heroCharGameObject;
			LuaObject.checkType<GameObject>(l, 2, out heroCharGameObject);
			heroBreakEffectUIController.m_luaExportHelper.m_heroCharGameObject = heroCharGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E94B RID: 125259 RVA: 0x009E1514 File Offset: 0x009DF714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharBreakSuccessEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroCharBreakSuccessEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E94C RID: 125260 RVA: 0x009E156C File Offset: 0x009DF76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharBreakSuccessEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			GameObject heroCharBreakSuccessEffect;
			LuaObject.checkType<GameObject>(l, 2, out heroCharBreakSuccessEffect);
			heroBreakEffectUIController.m_luaExportHelper.m_heroCharBreakSuccessEffect = heroCharBreakSuccessEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E94D RID: 125261 RVA: 0x009E15C8 File Offset: 0x009DF7C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakEffectReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakEffectReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E94E RID: 125262 RVA: 0x009E1620 File Offset: 0x009DF820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroBreakEffectReturnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Button heroBreakEffectReturnButton;
			LuaObject.checkType<Button>(l, 2, out heroBreakEffectReturnButton);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakEffectReturnButton = heroBreakEffectReturnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E94F RID: 125263 RVA: 0x009E167C File Offset: 0x009DF87C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakSuccessInfoHpText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoHpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E950 RID: 125264 RVA: 0x009E16D4 File Offset: 0x009DF8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroBreakSuccessInfoHpText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoHpText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoHpText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoHpText = heroBreakSuccessInfoHpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E951 RID: 125265 RVA: 0x009E1730 File Offset: 0x009DF930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakSuccessInfoHpAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoHpAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E952 RID: 125266 RVA: 0x009E1788 File Offset: 0x009DF988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroBreakSuccessInfoHpAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoHpAddText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoHpAddText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoHpAddText = heroBreakSuccessInfoHpAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E953 RID: 125267 RVA: 0x009E17E4 File Offset: 0x009DF9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakSuccessInfoATText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoATText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E954 RID: 125268 RVA: 0x009E183C File Offset: 0x009DFA3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroBreakSuccessInfoATText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoATText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoATText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoATText = heroBreakSuccessInfoATText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E955 RID: 125269 RVA: 0x009E1898 File Offset: 0x009DFA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakSuccessInfoATAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoATAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E956 RID: 125270 RVA: 0x009E18F0 File Offset: 0x009DFAF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroBreakSuccessInfoATAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoATAddText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoATAddText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoATAddText = heroBreakSuccessInfoATAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E957 RID: 125271 RVA: 0x009E194C File Offset: 0x009DFB4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakSuccessInfoMagicText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoMagicText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E958 RID: 125272 RVA: 0x009E19A4 File Offset: 0x009DFBA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroBreakSuccessInfoMagicText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoMagicText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoMagicText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoMagicText = heroBreakSuccessInfoMagicText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E959 RID: 125273 RVA: 0x009E1A00 File Offset: 0x009DFC00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroBreakSuccessInfoMagicAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoMagicAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E95A RID: 125274 RVA: 0x009E1A58 File Offset: 0x009DFC58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroBreakSuccessInfoMagicAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoMagicAddText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoMagicAddText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoMagicAddText = heroBreakSuccessInfoMagicAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E95B RID: 125275 RVA: 0x009E1AB4 File Offset: 0x009DFCB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroBreakSuccessInfoDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E95C RID: 125276 RVA: 0x009E1B0C File Offset: 0x009DFD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroBreakSuccessInfoDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoDFText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoDFText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoDFText = heroBreakSuccessInfoDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E95D RID: 125277 RVA: 0x009E1B68 File Offset: 0x009DFD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakSuccessInfoDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E95E RID: 125278 RVA: 0x009E1BC0 File Offset: 0x009DFDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroBreakSuccessInfoDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoDFAddText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoDFAddText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoDFAddText = heroBreakSuccessInfoDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E95F RID: 125279 RVA: 0x009E1C1C File Offset: 0x009DFE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakSuccessInfoMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoMagicDFText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E960 RID: 125280 RVA: 0x009E1C74 File Offset: 0x009DFE74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroBreakSuccessInfoMagicDFText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoMagicDFText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoMagicDFText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoMagicDFText = heroBreakSuccessInfoMagicDFText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E961 RID: 125281 RVA: 0x009E1CD0 File Offset: 0x009DFED0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroBreakSuccessInfoMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoMagicDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E962 RID: 125282 RVA: 0x009E1D28 File Offset: 0x009DFF28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroBreakSuccessInfoMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoMagicDFAddText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoMagicDFAddText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoMagicDFAddText = heroBreakSuccessInfoMagicDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E963 RID: 125283 RVA: 0x009E1D84 File Offset: 0x009DFF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroBreakSuccessInfoDexText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoDexText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E964 RID: 125284 RVA: 0x009E1DDC File Offset: 0x009DFFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroBreakSuccessInfoDexText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoDexText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoDexText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoDexText = heroBreakSuccessInfoDexText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E965 RID: 125285 RVA: 0x009E1E38 File Offset: 0x009E0038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroBreakSuccessInfoDexAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoDexAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E966 RID: 125286 RVA: 0x009E1E90 File Offset: 0x009E0090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroBreakSuccessInfoDexAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text heroBreakSuccessInfoDexAddText;
			LuaObject.checkType<Text>(l, 2, out heroBreakSuccessInfoDexAddText);
			heroBreakEffectUIController.m_luaExportHelper.m_heroBreakSuccessInfoDexAddText = heroBreakSuccessInfoDexAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E967 RID: 125287 RVA: 0x009E1EEC File Offset: 0x009E00EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroStarGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroStarGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E968 RID: 125288 RVA: 0x009E1F44 File Offset: 0x009E0144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroStarGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			GameObject heroStarGroup;
			LuaObject.checkType<GameObject>(l, 2, out heroStarGroup);
			heroBreakEffectUIController.m_luaExportHelper.m_heroStarGroup = heroStarGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E969 RID: 125289 RVA: 0x009E1FA0 File Offset: 0x009E01A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bigStarEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_bigStarEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E96A RID: 125290 RVA: 0x009E1FF8 File Offset: 0x009E01F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bigStarEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			GameObject bigStarEffect;
			LuaObject.checkType<GameObject>(l, 2, out bigStarEffect);
			heroBreakEffectUIController.m_luaExportHelper.m_bigStarEffect = bigStarEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E96B RID: 125291 RVA: 0x009E2054 File Offset: 0x009E0254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bigStarTrailEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_bigStarTrailEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E96C RID: 125292 RVA: 0x009E20AC File Offset: 0x009E02AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bigStarTrailEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			GameObject bigStarTrailEffect;
			LuaObject.checkType<GameObject>(l, 2, out bigStarTrailEffect);
			heroBreakEffectUIController.m_luaExportHelper.m_bigStarTrailEffect = bigStarTrailEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E96D RID: 125293 RVA: 0x009E2108 File Offset: 0x009E0308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_talent1Icon(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_talent1Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E96E RID: 125294 RVA: 0x009E2160 File Offset: 0x009E0360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_talent1Icon(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Image talent1Icon;
			LuaObject.checkType<Image>(l, 2, out talent1Icon);
			heroBreakEffectUIController.m_luaExportHelper.m_talent1Icon = talent1Icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E96F RID: 125295 RVA: 0x009E21BC File Offset: 0x009E03BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_talent1NameText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_talent1NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E970 RID: 125296 RVA: 0x009E2214 File Offset: 0x009E0414
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_talent1NameText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text talent1NameText;
			LuaObject.checkType<Text>(l, 2, out talent1NameText);
			heroBreakEffectUIController.m_luaExportHelper.m_talent1NameText = talent1NameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E971 RID: 125297 RVA: 0x009E2270 File Offset: 0x009E0470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_talent1DescText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_talent1DescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E972 RID: 125298 RVA: 0x009E22C8 File Offset: 0x009E04C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_talent1DescText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text talent1DescText;
			LuaObject.checkType<Text>(l, 2, out talent1DescText);
			heroBreakEffectUIController.m_luaExportHelper.m_talent1DescText = talent1DescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E973 RID: 125299 RVA: 0x009E2324 File Offset: 0x009E0524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_talent2Icon(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_talent2Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E974 RID: 125300 RVA: 0x009E237C File Offset: 0x009E057C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_talent2Icon(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Image talent2Icon;
			LuaObject.checkType<Image>(l, 2, out talent2Icon);
			heroBreakEffectUIController.m_luaExportHelper.m_talent2Icon = talent2Icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E975 RID: 125301 RVA: 0x009E23D8 File Offset: 0x009E05D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_talent2NameText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_talent2NameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E976 RID: 125302 RVA: 0x009E2430 File Offset: 0x009E0630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_talent2NameText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text talent2NameText;
			LuaObject.checkType<Text>(l, 2, out talent2NameText);
			heroBreakEffectUIController.m_luaExportHelper.m_talent2NameText = talent2NameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E977 RID: 125303 RVA: 0x009E248C File Offset: 0x009E068C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_talent2DescText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_talent2DescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E978 RID: 125304 RVA: 0x009E24E4 File Offset: 0x009E06E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_talent2DescText(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Text talent2DescText;
			LuaObject.checkType<Text>(l, 2, out talent2DescText);
			heroBreakEffectUIController.m_luaExportHelper.m_talent2DescText = talent2DescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E979 RID: 125305 RVA: 0x009E2540 File Offset: 0x009E0740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroBreakEffectUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroBreakEffectUIController.EventOnReturn -= value;
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

	// Token: 0x0601E97A RID: 125306 RVA: 0x009E25C0 File Offset: 0x009E07C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E97B RID: 125307 RVA: 0x009E2618 File Offset: 0x009E0818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroBreakEffectUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E97C RID: 125308 RVA: 0x009E2674 File Offset: 0x009E0874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_heroCharUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E97D RID: 125309 RVA: 0x009E26CC File Offset: 0x009E08CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroCharUIController(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			HeroCharUIController heroCharUIController;
			LuaObject.checkType<HeroCharUIController>(l, 2, out heroCharUIController);
			heroBreakEffectUIController.m_luaExportHelper.m_heroCharUIController = heroCharUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E97E RID: 125310 RVA: 0x009E2728 File Offset: 0x009E0928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E97F RID: 125311 RVA: 0x009E2780 File Offset: 0x009E0980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroBreakEffectUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E980 RID: 125312 RVA: 0x009E27DC File Offset: 0x009E09DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroBreakEffectUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E981 RID: 125313 RVA: 0x009E2834 File Offset: 0x009E0A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroBreakEffectUIController heroBreakEffectUIController = (HeroBreakEffectUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroBreakEffectUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E982 RID: 125314 RVA: 0x009E2890 File Offset: 0x009E0A90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroBreakEffectUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.HeroBreakEffectUpdateView);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.SetBreakHeroInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.ShowStarEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache15);
		string name = "m_stateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_stateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_stateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache17, true);
		string name2 = "m_heroCharGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroCharGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroCharGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache19, true);
		string name3 = "m_heroCharBreakSuccessEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroCharBreakSuccessEffect);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroCharBreakSuccessEffect);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1B, true);
		string name4 = "m_heroBreakEffectReturnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakEffectReturnButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakEffectReturnButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1D, true);
		string name5 = "m_heroBreakSuccessInfoHpText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoHpText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoHpText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache1F, true);
		string name6 = "m_heroBreakSuccessInfoHpAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoHpAddText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoHpAddText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache21, true);
		string name7 = "m_heroBreakSuccessInfoATText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoATText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoATText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache23, true);
		string name8 = "m_heroBreakSuccessInfoATAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoATAddText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoATAddText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache25, true);
		string name9 = "m_heroBreakSuccessInfoMagicText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoMagicText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoMagicText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache27, true);
		string name10 = "m_heroBreakSuccessInfoMagicAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoMagicAddText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoMagicAddText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache29, true);
		string name11 = "m_heroBreakSuccessInfoDFText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoDFText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoDFText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2B, true);
		string name12 = "m_heroBreakSuccessInfoDFAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoDFAddText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoDFAddText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2D, true);
		string name13 = "m_heroBreakSuccessInfoMagicDFText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoMagicDFText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoMagicDFText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache2F, true);
		string name14 = "m_heroBreakSuccessInfoMagicDFAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoMagicDFAddText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoMagicDFAddText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache31, true);
		string name15 = "m_heroBreakSuccessInfoDexText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoDexText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoDexText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache33, true);
		string name16 = "m_heroBreakSuccessInfoDexAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroBreakSuccessInfoDexAddText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroBreakSuccessInfoDexAddText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache35, true);
		string name17 = "m_heroStarGroup";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroStarGroup);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroStarGroup);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache37, true);
		string name18 = "m_bigStarEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_bigStarEffect);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_bigStarEffect);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache39, true);
		string name19 = "m_bigStarTrailEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_bigStarTrailEffect);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_bigStarTrailEffect);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3B, true);
		string name20 = "m_talent1Icon";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_talent1Icon);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_talent1Icon);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3D, true);
		string name21 = "m_talent1NameText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_talent1NameText);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_talent1NameText);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache3F, true);
		string name22 = "m_talent1DescText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_talent1DescText);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_talent1DescText);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache41, true);
		string name23 = "m_talent2Icon";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_talent2Icon);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_talent2Icon);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache43, true);
		string name24 = "m_talent2NameText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_talent2NameText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_talent2NameText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache45, true);
		string name25 = "m_talent2DescText";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_talent2DescText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_talent2DescText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache47, true);
		string name26 = "EventOnReturn";
		LuaCSFunction get26 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache48, true);
		string name27 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_hero);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_hero);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4A, true);
		string name28 = "m_heroCharUIController";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_heroCharUIController);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_heroCharUIController);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4C, true);
		string name29 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_playerContext);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4E, true);
		string name30 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.get_m_configDataLoader);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_HeroBreakEffectUIController.<>f__mg$cache50, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroBreakEffectUIController), typeof(UIControllerBase));
	}

	// Token: 0x040149CD RID: 84429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040149CE RID: 84430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040149CF RID: 84431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040149D0 RID: 84432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040149D1 RID: 84433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040149D2 RID: 84434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040149D3 RID: 84435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040149D4 RID: 84436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040149D5 RID: 84437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040149D6 RID: 84438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040149D7 RID: 84439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040149D8 RID: 84440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040149D9 RID: 84441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040149DA RID: 84442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040149DB RID: 84443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040149DC RID: 84444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040149DD RID: 84445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040149DE RID: 84446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040149DF RID: 84447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040149E0 RID: 84448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040149E1 RID: 84449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040149E2 RID: 84450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040149E3 RID: 84451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040149E4 RID: 84452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040149E5 RID: 84453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040149E6 RID: 84454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040149E7 RID: 84455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040149E8 RID: 84456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040149E9 RID: 84457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040149EA RID: 84458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040149EB RID: 84459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040149EC RID: 84460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040149ED RID: 84461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040149EE RID: 84462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040149EF RID: 84463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040149F0 RID: 84464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040149F1 RID: 84465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040149F2 RID: 84466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040149F3 RID: 84467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040149F4 RID: 84468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040149F5 RID: 84469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040149F6 RID: 84470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040149F7 RID: 84471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040149F8 RID: 84472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040149F9 RID: 84473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040149FA RID: 84474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040149FB RID: 84475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040149FC RID: 84476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040149FD RID: 84477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040149FE RID: 84478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040149FF RID: 84479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014A00 RID: 84480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014A01 RID: 84481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014A02 RID: 84482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014A03 RID: 84483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014A04 RID: 84484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014A05 RID: 84485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014A06 RID: 84486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014A07 RID: 84487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014A08 RID: 84488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014A09 RID: 84489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04014A0A RID: 84490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04014A0B RID: 84491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04014A0C RID: 84492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014A0D RID: 84493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014A0E RID: 84494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014A0F RID: 84495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014A10 RID: 84496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014A11 RID: 84497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014A12 RID: 84498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014A13 RID: 84499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014A14 RID: 84500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014A15 RID: 84501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014A16 RID: 84502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04014A17 RID: 84503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04014A18 RID: 84504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04014A19 RID: 84505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04014A1A RID: 84506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04014A1B RID: 84507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04014A1C RID: 84508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04014A1D RID: 84509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;
}
