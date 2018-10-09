using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200141E RID: 5150
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController : LuaObject
{
	// Token: 0x0601D510 RID: 120080 RVA: 0x00941B2C File Offset: 0x0093FD2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEnemyGameObject(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			GameObject enemyGameObject = enemyBoomToGoldUIController.GetEnemyGameObject();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, enemyGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D511 RID: 120081 RVA: 0x00941B80 File Offset: 0x0093FD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_ShowBoomAndGold(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			IEnumerator o = enemyBoomToGoldUIController.Co_ShowBoomAndGold();
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

	// Token: 0x0601D512 RID: 120082 RVA: 0x00941BD4 File Offset: 0x0093FDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEnemyGoldCount(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			int enemyGoldCount = enemyBoomToGoldUIController.GetEnemyGoldCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, enemyGoldCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D513 RID: 120083 RVA: 0x00941C28 File Offset: 0x0093FE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			enemyBoomToGoldUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D514 RID: 120084 RVA: 0x00941C94 File Offset: 0x0093FE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			enemyBoomToGoldUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D515 RID: 120085 RVA: 0x00941CE8 File Offset: 0x0093FEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			enemyBoomToGoldUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D516 RID: 120086 RVA: 0x00941D3C File Offset: 0x0093FF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = enemyBoomToGoldUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601D517 RID: 120087 RVA: 0x00941DE4 File Offset: 0x0093FFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			enemyBoomToGoldUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D518 RID: 120088 RVA: 0x00941E38 File Offset: 0x00940038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			enemyBoomToGoldUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D519 RID: 120089 RVA: 0x00941EA4 File Offset: 0x009400A4
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
				EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				enemyBoomToGoldUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				EnemyBoomToGoldUIController enemyBoomToGoldUIController2 = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				enemyBoomToGoldUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601D51A RID: 120090 RVA: 0x00941FB4 File Offset: 0x009401B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			enemyBoomToGoldUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D51B RID: 120091 RVA: 0x00942020 File Offset: 0x00940220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			enemyBoomToGoldUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D51C RID: 120092 RVA: 0x0094208C File Offset: 0x0094028C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			enemyBoomToGoldUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D51D RID: 120093 RVA: 0x009420F8 File Offset: 0x009402F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			enemyBoomToGoldUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D51E RID: 120094 RVA: 0x00942164 File Offset: 0x00940364
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
				EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				enemyBoomToGoldUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				EnemyBoomToGoldUIController enemyBoomToGoldUIController2 = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				enemyBoomToGoldUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601D51F RID: 120095 RVA: 0x00942274 File Offset: 0x00940474
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			string s = enemyBoomToGoldUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601D520 RID: 120096 RVA: 0x009422D0 File Offset: 0x009404D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, enemyBoomToGoldUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D521 RID: 120097 RVA: 0x00942328 File Offset: 0x00940528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			enemyBoomToGoldUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D522 RID: 120098 RVA: 0x00942384 File Offset: 0x00940584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_enemyGameObject(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, enemyBoomToGoldUIController.m_luaExportHelper.m_enemyGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D523 RID: 120099 RVA: 0x009423DC File Offset: 0x009405DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enemyGameObject(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			GameObject enemyGameObject;
			LuaObject.checkType<GameObject>(l, 2, out enemyGameObject);
			enemyBoomToGoldUIController.m_luaExportHelper.m_enemyGameObject = enemyGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D524 RID: 120100 RVA: 0x00942438 File Offset: 0x00940638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldGameObject(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, enemyBoomToGoldUIController.m_luaExportHelper.m_goldGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D525 RID: 120101 RVA: 0x00942490 File Offset: 0x00940690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldGameObject(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			GameObject goldGameObject;
			LuaObject.checkType<GameObject>(l, 2, out goldGameObject);
			enemyBoomToGoldUIController.m_luaExportHelper.m_goldGameObject = goldGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D526 RID: 120102 RVA: 0x009424EC File Offset: 0x009406EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, enemyBoomToGoldUIController.m_luaExportHelper.m_goldText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D527 RID: 120103 RVA: 0x00942544 File Offset: 0x00940744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_goldText(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			Text goldText;
			LuaObject.checkType<Text>(l, 2, out goldText);
			enemyBoomToGoldUIController.m_luaExportHelper.m_goldText = goldText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D528 RID: 120104 RVA: 0x009425A0 File Offset: 0x009407A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dieEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, enemyBoomToGoldUIController.m_luaExportHelper.m_dieEffectGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D529 RID: 120105 RVA: 0x009425F8 File Offset: 0x009407F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dieEffectGameObject(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			GameObject dieEffectGameObject;
			LuaObject.checkType<GameObject>(l, 2, out dieEffectGameObject);
			enemyBoomToGoldUIController.m_luaExportHelper.m_dieEffectGameObject = dieEffectGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D52A RID: 120106 RVA: 0x00942654 File Offset: 0x00940854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroID(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, enemyBoomToGoldUIController.HeroID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D52B RID: 120107 RVA: 0x009426A8 File Offset: 0x009408A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroID(IntPtr l)
	{
		int result;
		try
		{
			EnemyBoomToGoldUIController enemyBoomToGoldUIController = (EnemyBoomToGoldUIController)LuaObject.checkSelf(l);
			int heroID;
			LuaObject.checkType(l, 2, out heroID);
			enemyBoomToGoldUIController.HeroID = heroID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601D52C RID: 120108 RVA: 0x00942700 File Offset: 0x00940900
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EnemyBoomToGoldUIController");
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.GetEnemyGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.Co_ShowBoomAndGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.GetEnemyGoldCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cacheF);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache11, true);
		string name2 = "m_enemyGameObject";
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.get_m_enemyGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.set_m_enemyGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache13, true);
		string name3 = "m_goldGameObject";
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.get_m_goldGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.set_m_goldGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache15, true);
		string name4 = "m_goldText";
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.get_m_goldText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.set_m_goldText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache17, true);
		string name5 = "m_dieEffectGameObject";
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.get_m_dieEffectGameObject);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.set_m_dieEffectGameObject);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache19, true);
		string name6 = "HeroID";
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.get_HeroID);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.set_HeroID);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_EnemyBoomToGoldUIController.<>f__mg$cache1B, true);
		LuaObject.createTypeMetatable(l, null, typeof(EnemyBoomToGoldUIController), typeof(UIControllerBase));
	}

	// Token: 0x040136B6 RID: 79542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040136B7 RID: 79543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040136B8 RID: 79544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040136B9 RID: 79545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040136BA RID: 79546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040136BB RID: 79547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040136BC RID: 79548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040136BD RID: 79549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040136BE RID: 79550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040136BF RID: 79551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040136C0 RID: 79552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040136C1 RID: 79553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040136C2 RID: 79554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040136C3 RID: 79555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040136C4 RID: 79556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040136C5 RID: 79557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040136C6 RID: 79558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040136C7 RID: 79559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040136C8 RID: 79560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040136C9 RID: 79561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040136CA RID: 79562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040136CB RID: 79563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040136CC RID: 79564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040136CD RID: 79565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040136CE RID: 79566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040136CF RID: 79567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040136D0 RID: 79568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040136D1 RID: 79569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;
}
