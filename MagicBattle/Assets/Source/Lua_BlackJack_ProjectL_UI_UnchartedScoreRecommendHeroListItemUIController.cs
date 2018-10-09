using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015C8 RID: 5576
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController : LuaObject
{
	// Token: 0x06021F1C RID: 139036 RVA: 0x00B8EA28 File Offset: 0x00B8CC28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHero(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			int hero;
			LuaObject.checkType(l, 2, out hero);
			unchartedScoreRecommendHeroListItemUIController.SetHero(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F1D RID: 139037 RVA: 0x00B8EA80 File Offset: 0x00B8CC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F1E RID: 139038 RVA: 0x00B8EAD4 File Offset: 0x00B8CCD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F1F RID: 139039 RVA: 0x00B8EB28 File Offset: 0x00B8CD28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F20 RID: 139040 RVA: 0x00B8EB94 File Offset: 0x00B8CD94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F21 RID: 139041 RVA: 0x00B8EBE8 File Offset: 0x00B8CDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F22 RID: 139042 RVA: 0x00B8EC3C File Offset: 0x00B8CE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021F23 RID: 139043 RVA: 0x00B8ECE4 File Offset: 0x00B8CEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F24 RID: 139044 RVA: 0x00B8ED38 File Offset: 0x00B8CF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F25 RID: 139045 RVA: 0x00B8EDA4 File Offset: 0x00B8CFA4
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
				UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController2 = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				unchartedScoreRecommendHeroListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021F26 RID: 139046 RVA: 0x00B8EEB4 File Offset: 0x00B8D0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F27 RID: 139047 RVA: 0x00B8EF20 File Offset: 0x00B8D120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F28 RID: 139048 RVA: 0x00B8EF8C File Offset: 0x00B8D18C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F29 RID: 139049 RVA: 0x00B8EFF8 File Offset: 0x00B8D1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F2A RID: 139050 RVA: 0x00B8F064 File Offset: 0x00B8D264
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
				UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController2 = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				unchartedScoreRecommendHeroListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021F2B RID: 139051 RVA: 0x00B8F174 File Offset: 0x00B8D374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			string s = unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021F2C RID: 139052 RVA: 0x00B8F1D0 File Offset: 0x00B8D3D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F2D RID: 139053 RVA: 0x00B8F228 File Offset: 0x00B8D428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F2E RID: 139054 RVA: 0x00B8F284 File Offset: 0x00B8D484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.m_iconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F2F RID: 139055 RVA: 0x00B8F2DC File Offset: 0x00B8D4DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_iconImage(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			Image iconImage;
			LuaObject.checkType<Image>(l, 2, out iconImage);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.m_iconImage = iconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F30 RID: 139056 RVA: 0x00B8F338 File Offset: 0x00B8D538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.m_heroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F31 RID: 139057 RVA: 0x00B8F390 File Offset: 0x00B8D590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRecommendHeroListItemUIController unchartedScoreRecommendHeroListItemUIController = (UnchartedScoreRecommendHeroListItemUIController)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			unchartedScoreRecommendHeroListItemUIController.m_luaExportHelper.m_heroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F32 RID: 139058 RVA: 0x00B8F3EC File Offset: 0x00B8D5EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedScoreRecommendHeroListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.SetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cacheF);
		string name = "m_button";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.get_m_button);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache11, true);
		string name2 = "m_iconImage";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.get_m_iconImage);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.set_m_iconImage);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache13, true);
		string name3 = "m_heroId";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.get_m_heroId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.set_m_heroId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UnchartedScoreRecommendHeroListItemUIController.<>f__mg$cache15, true);
		LuaObject.createTypeMetatable(l, null, typeof(UnchartedScoreRecommendHeroListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017D6E RID: 97646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017D6F RID: 97647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017D70 RID: 97648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017D71 RID: 97649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017D72 RID: 97650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017D73 RID: 97651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017D74 RID: 97652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017D75 RID: 97653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017D76 RID: 97654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017D77 RID: 97655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017D78 RID: 97656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017D79 RID: 97657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017D7A RID: 97658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017D7B RID: 97659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017D7C RID: 97660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017D7D RID: 97661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017D7E RID: 97662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017D7F RID: 97663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017D80 RID: 97664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017D81 RID: 97665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017D82 RID: 97666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017D83 RID: 97667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
