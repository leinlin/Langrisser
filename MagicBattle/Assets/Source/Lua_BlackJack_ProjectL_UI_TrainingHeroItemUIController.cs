using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015B6 RID: 5558
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController : LuaObject
{
	// Token: 0x06021C52 RID: 138322 RVA: 0x00B78D4C File Offset: 0x00B76F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTrainingHeroItem(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			bool isAchivementUp;
			LuaObject.checkType(l, 3, out isAchivementUp);
			trainingHeroItemUIController.InitTrainingHeroItem(hero, isAchivementUp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C53 RID: 138323 RVA: 0x00B78DB0 File Offset: 0x00B76FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowSelectFrameImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			trainingHeroItemUIController.ShowSelectFrameImage(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C54 RID: 138324 RVA: 0x00B78E08 File Offset: 0x00B77008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			trainingHeroItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C55 RID: 138325 RVA: 0x00B78E5C File Offset: 0x00B7705C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			trainingHeroItemUIController.m_luaExportHelper.OnHeroItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C56 RID: 138326 RVA: 0x00B78EB0 File Offset: 0x00B770B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			trainingHeroItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C57 RID: 138327 RVA: 0x00B78F1C File Offset: 0x00B7711C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			trainingHeroItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C58 RID: 138328 RVA: 0x00B78F70 File Offset: 0x00B77170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			trainingHeroItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C59 RID: 138329 RVA: 0x00B78FC4 File Offset: 0x00B771C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = trainingHeroItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021C5A RID: 138330 RVA: 0x00B7906C File Offset: 0x00B7726C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			trainingHeroItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C5B RID: 138331 RVA: 0x00B790C0 File Offset: 0x00B772C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			trainingHeroItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C5C RID: 138332 RVA: 0x00B7912C File Offset: 0x00B7732C
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
				TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				trainingHeroItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TrainingHeroItemUIController trainingHeroItemUIController2 = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				trainingHeroItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021C5D RID: 138333 RVA: 0x00B7923C File Offset: 0x00B7743C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingHeroItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C5E RID: 138334 RVA: 0x00B792A8 File Offset: 0x00B774A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingHeroItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C5F RID: 138335 RVA: 0x00B79314 File Offset: 0x00B77514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingHeroItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C60 RID: 138336 RVA: 0x00B79380 File Offset: 0x00B77580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			trainingHeroItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C61 RID: 138337 RVA: 0x00B793EC File Offset: 0x00B775EC
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
				TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				trainingHeroItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TrainingHeroItemUIController trainingHeroItemUIController2 = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				trainingHeroItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021C62 RID: 138338 RVA: 0x00B794FC File Offset: 0x00B776FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			string s = trainingHeroItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021C63 RID: 138339 RVA: 0x00B79558 File Offset: 0x00B77758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			TrainingHeroItemUIController obj;
			LuaObject.checkType<TrainingHeroItemUIController>(l, 2, out obj);
			trainingHeroItemUIController.m_luaExportHelper.__callDele_EventOnHeroItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C64 RID: 138340 RVA: 0x00B795B4 File Offset: 0x00B777B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			TrainingHeroItemUIController obj;
			LuaObject.checkType<TrainingHeroItemUIController>(l, 2, out obj);
			trainingHeroItemUIController.m_luaExportHelper.__clearDele_EventOnHeroItemClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C65 RID: 138341 RVA: 0x00B79610 File Offset: 0x00B77810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHeroItemClick(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			Action<TrainingHeroItemUIController> value;
			int num = LuaObject.checkDelegate<Action<TrainingHeroItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					trainingHeroItemUIController.EventOnHeroItemClick += value;
				}
				else if (num == 2)
				{
					trainingHeroItemUIController.EventOnHeroItemClick -= value;
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

	// Token: 0x06021C66 RID: 138342 RVA: 0x00B79690 File Offset: 0x00B77890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectFrameImg(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingHeroItemUIController.m_luaExportHelper.m_selectFrameImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C67 RID: 138343 RVA: 0x00B796E8 File Offset: 0x00B778E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectFrameImg(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			GameObject selectFrameImg;
			LuaObject.checkType<GameObject>(l, 2, out selectFrameImg);
			trainingHeroItemUIController.m_luaExportHelper.m_selectFrameImg = selectFrameImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C68 RID: 138344 RVA: 0x00B79744 File Offset: 0x00B77944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingHeroItemUIController.m_luaExportHelper.m_heroStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C69 RID: 138345 RVA: 0x00B7979C File Offset: 0x00B7799C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroStar(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			GameObject heroStar;
			LuaObject.checkType<GameObject>(l, 2, out heroStar);
			trainingHeroItemUIController.m_luaExportHelper.m_heroStar = heroStar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C6A RID: 138346 RVA: 0x00B797F8 File Offset: 0x00B779F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTypeImg(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingHeroItemUIController.m_luaExportHelper.m_heroTypeImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C6B RID: 138347 RVA: 0x00B79850 File Offset: 0x00B77A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTypeImg(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			Image heroTypeImg;
			LuaObject.checkType<Image>(l, 2, out heroTypeImg);
			trainingHeroItemUIController.m_luaExportHelper.m_heroTypeImg = heroTypeImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C6C RID: 138348 RVA: 0x00B798AC File Offset: 0x00B77AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroLvText(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingHeroItemUIController.m_luaExportHelper.m_heroLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C6D RID: 138349 RVA: 0x00B79904 File Offset: 0x00B77B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroLvText(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			Text heroLvText;
			LuaObject.checkType<Text>(l, 2, out heroLvText);
			trainingHeroItemUIController.m_luaExportHelper.m_heroLvText = heroLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C6E RID: 138350 RVA: 0x00B79960 File Offset: 0x00B77B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingHeroItemUIController.m_luaExportHelper.m_ssrFrameEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C6F RID: 138351 RVA: 0x00B799B8 File Offset: 0x00B77BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrFrameEffect(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			GameObject ssrFrameEffect;
			LuaObject.checkType<GameObject>(l, 2, out ssrFrameEffect);
			trainingHeroItemUIController.m_luaExportHelper.m_ssrFrameEffect = ssrFrameEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C70 RID: 138352 RVA: 0x00B79A14 File Offset: 0x00B77C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_frameImg(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingHeroItemUIController.m_luaExportHelper.m_frameImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C71 RID: 138353 RVA: 0x00B79A6C File Offset: 0x00B77C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_frameImg(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			Image frameImg;
			LuaObject.checkType<Image>(l, 2, out frameImg);
			trainingHeroItemUIController.m_luaExportHelper.m_frameImg = frameImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C72 RID: 138354 RVA: 0x00B79AC8 File Offset: 0x00B77CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroIconImg(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingHeroItemUIController.m_luaExportHelper.m_heroIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C73 RID: 138355 RVA: 0x00B79B20 File Offset: 0x00B77D20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroIconImg(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			Image heroIconImg;
			LuaObject.checkType<Image>(l, 2, out heroIconImg);
			trainingHeroItemUIController.m_luaExportHelper.m_heroIconImg = heroIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C74 RID: 138356 RVA: 0x00B79B7C File Offset: 0x00B77D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingHeroItemUIController.m_luaExportHelper.m_uiStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C75 RID: 138357 RVA: 0x00B79BD4 File Offset: 0x00B77DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateCtrl);
			trainingHeroItemUIController.m_luaExportHelper.m_uiStateCtrl = uiStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C76 RID: 138358 RVA: 0x00B79C30 File Offset: 0x00B77E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achivementUpImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingHeroItemUIController.m_luaExportHelper.m_achivementUpImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C77 RID: 138359 RVA: 0x00B79C88 File Offset: 0x00B77E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achivementUpImage(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			GameObject achivementUpImage;
			LuaObject.checkType<GameObject>(l, 2, out achivementUpImage);
			trainingHeroItemUIController.m_luaExportHelper.m_achivementUpImage = achivementUpImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C78 RID: 138360 RVA: 0x00B79CE4 File Offset: 0x00B77EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, trainingHeroItemUIController.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C79 RID: 138361 RVA: 0x00B79D38 File Offset: 0x00B77F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			TrainingHeroItemUIController trainingHeroItemUIController = (TrainingHeroItemUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			trainingHeroItemUIController.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021C7A RID: 138362 RVA: 0x00B79D90 File Offset: 0x00B77F90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TrainingHeroItemUIController");
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.InitTrainingHeroItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.ShowSelectFrameImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.OnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__callDele_EventOnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.__clearDele_EventOnHeroItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache12);
		string name = "EventOnHeroItemClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.set_EventOnHeroItemClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache13, true);
		string name2 = "m_selectFrameImg";
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.get_m_selectFrameImg);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.set_m_selectFrameImg);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache15, true);
		string name3 = "m_heroStar";
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.get_m_heroStar);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.set_m_heroStar);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache17, true);
		string name4 = "m_heroTypeImg";
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.get_m_heroTypeImg);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.set_m_heroTypeImg);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache19, true);
		string name5 = "m_heroLvText";
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.get_m_heroLvText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.set_m_heroLvText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1B, true);
		string name6 = "m_ssrFrameEffect";
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.get_m_ssrFrameEffect);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.set_m_ssrFrameEffect);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1D, true);
		string name7 = "m_frameImg";
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.get_m_frameImg);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.set_m_frameImg);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache1F, true);
		string name8 = "m_heroIconImg";
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.get_m_heroIconImg);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.set_m_heroIconImg);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache21, true);
		string name9 = "m_uiStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.get_m_uiStateCtrl);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.set_m_uiStateCtrl);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache23, true);
		string name10 = "m_achivementUpImage";
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.get_m_achivementUpImage);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.set_m_achivementUpImage);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache25, true);
		string name11 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.get_m_hero);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.set_m_hero);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_TrainingHeroItemUIController.<>f__mg$cache27, true);
		LuaObject.createTypeMetatable(l, null, typeof(TrainingHeroItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017AC8 RID: 96968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017AC9 RID: 96969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017ACA RID: 96970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017ACB RID: 96971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017ACC RID: 96972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017ACD RID: 96973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017ACE RID: 96974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017ACF RID: 96975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017AD0 RID: 96976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017AD1 RID: 96977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017AD2 RID: 96978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017AD3 RID: 96979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017AD4 RID: 96980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017AD5 RID: 96981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017AD6 RID: 96982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017AD7 RID: 96983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017AD8 RID: 96984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017AD9 RID: 96985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017ADA RID: 96986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017ADB RID: 96987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017ADC RID: 96988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017ADD RID: 96989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017ADE RID: 96990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017ADF RID: 96991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017AE0 RID: 96992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017AE1 RID: 96993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017AE2 RID: 96994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017AE3 RID: 96995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017AE4 RID: 96996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017AE5 RID: 96997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017AE6 RID: 96998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017AE7 RID: 96999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017AE8 RID: 97000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017AE9 RID: 97001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017AEA RID: 97002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017AEB RID: 97003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017AEC RID: 97004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017AED RID: 97005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017AEE RID: 97006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017AEF RID: 97007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
