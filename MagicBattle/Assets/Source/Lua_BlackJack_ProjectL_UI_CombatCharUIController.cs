using System;
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

// Token: 0x020013FF RID: 5119
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CombatCharUIController : LuaObject
{
	// Token: 0x0601CCF9 RID: 118009 RVA: 0x00900A18 File Offset: 0x008FEC18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateGraphic(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			ConfigDataCharImageSkinResourceInfo skinResInfo;
			LuaObject.checkType<ConfigDataCharImageSkinResourceInfo>(l, 3, out skinResInfo);
			combatCharUIController.CreateGraphic(charImageInfo, skinResInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCFA RID: 118010 RVA: 0x00900A7C File Offset: 0x008FEC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyGraphic(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			combatCharUIController.DestroyGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCFB RID: 118011 RVA: 0x00900AC8 File Offset: 0x008FECC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDirection(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			combatCharUIController.SetDirection(direction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCFC RID: 118012 RVA: 0x00900B20 File Offset: 0x008FED20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimation(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			string animation;
			LuaObject.checkType(l, 2, out animation);
			bool loop;
			LuaObject.checkType(l, 3, out loop);
			combatCharUIController.PlayAnimation(animation, loop);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCFD RID: 118013 RVA: 0x00900B84 File Offset: 0x008FED84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HasAnimation(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			bool b = combatCharUIController.HasAnimation(name);
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

	// Token: 0x0601CCFE RID: 118014 RVA: 0x00900BE8 File Offset: 0x008FEDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnimationName(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			string animationName = combatCharUIController.GetAnimationName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CCFF RID: 118015 RVA: 0x00900C3C File Offset: 0x008FEE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForceUpdate(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			combatCharUIController.ForceUpdate();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD00 RID: 118016 RVA: 0x00900C88 File Offset: 0x008FEE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			combatCharUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD01 RID: 118017 RVA: 0x00900CDC File Offset: 0x008FEEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			combatCharUIController.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD02 RID: 118018 RVA: 0x00900D30 File Offset: 0x008FEF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			combatCharUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD03 RID: 118019 RVA: 0x00900D84 File Offset: 0x008FEF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			combatCharUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD04 RID: 118020 RVA: 0x00900DF0 File Offset: 0x008FEFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			combatCharUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD05 RID: 118021 RVA: 0x00900E44 File Offset: 0x008FF044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			combatCharUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD06 RID: 118022 RVA: 0x00900E98 File Offset: 0x008FF098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = combatCharUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601CD07 RID: 118023 RVA: 0x00900F40 File Offset: 0x008FF140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			combatCharUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD08 RID: 118024 RVA: 0x00900F94 File Offset: 0x008FF194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			combatCharUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD09 RID: 118025 RVA: 0x00901000 File Offset: 0x008FF200
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
				CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				combatCharUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				CombatCharUIController combatCharUIController2 = (CombatCharUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				combatCharUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601CD0A RID: 118026 RVA: 0x00901110 File Offset: 0x008FF310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatCharUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD0B RID: 118027 RVA: 0x0090117C File Offset: 0x008FF37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatCharUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD0C RID: 118028 RVA: 0x009011E8 File Offset: 0x008FF3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatCharUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD0D RID: 118029 RVA: 0x00901254 File Offset: 0x008FF454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			combatCharUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD0E RID: 118030 RVA: 0x009012C0 File Offset: 0x008FF4C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				combatCharUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				CombatCharUIController combatCharUIController2 = (CombatCharUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				combatCharUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601CD0F RID: 118031 RVA: 0x009013D0 File Offset: 0x008FF5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			string s = combatCharUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601CD10 RID: 118032 RVA: 0x0090142C File Offset: 0x008FF62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatCharUIController.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD11 RID: 118033 RVA: 0x00901484 File Offset: 0x008FF684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			combatCharUIController.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD12 RID: 118034 RVA: 0x009014E0 File Offset: 0x008FF6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatCharUIController.m_luaExportHelper.m_spineGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD13 RID: 118035 RVA: 0x00901538 File Offset: 0x008FF738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			UISpineGraphic spineGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out spineGraphic);
			combatCharUIController.m_luaExportHelper.m_spineGraphic = spineGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD14 RID: 118036 RVA: 0x00901594 File Offset: 0x008FF794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_animationName(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatCharUIController.m_luaExportHelper.m_animationName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD15 RID: 118037 RVA: 0x009015EC File Offset: 0x008FF7EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_animationName(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			string animationName;
			LuaObject.checkType(l, 2, out animationName);
			combatCharUIController.m_luaExportHelper.m_animationName = animationName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD16 RID: 118038 RVA: 0x00901648 File Offset: 0x008FF848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loopAnimationName(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combatCharUIController.m_luaExportHelper.m_loopAnimationName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD17 RID: 118039 RVA: 0x009016A0 File Offset: 0x008FF8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loopAnimationName(IntPtr l)
	{
		int result;
		try
		{
			CombatCharUIController combatCharUIController = (CombatCharUIController)LuaObject.checkSelf(l);
			string loopAnimationName;
			LuaObject.checkType(l, 2, out loopAnimationName);
			combatCharUIController.m_luaExportHelper.m_loopAnimationName = loopAnimationName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601CD18 RID: 118040 RVA: 0x009016FC File Offset: 0x008FF8FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CombatCharUIController");
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.CreateGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.DestroyGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.SetDirection);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.PlayAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.HasAnimation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.GetAnimationName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.ForceUpdate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache16);
		string name = "m_image";
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.get_m_image);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.set_m_image);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache18, true);
		string name2 = "m_spineGraphic";
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.get_m_spineGraphic);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.set_m_spineGraphic);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1A, true);
		string name3 = "m_animationName";
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.get_m_animationName);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.set_m_animationName);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1C, true);
		string name4 = "m_loopAnimationName";
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.get_m_loopAnimationName);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CombatCharUIController.set_m_loopAnimationName);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_CombatCharUIController.<>f__mg$cache1E, true);
		LuaObject.createTypeMetatable(l, null, typeof(CombatCharUIController), typeof(UIControllerBase));
	}

	// Token: 0x04012EDD RID: 77533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012EDE RID: 77534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04012EDF RID: 77535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012EE0 RID: 77536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012EE1 RID: 77537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012EE2 RID: 77538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012EE3 RID: 77539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012EE4 RID: 77540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012EE5 RID: 77541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012EE6 RID: 77542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012EE7 RID: 77543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012EE8 RID: 77544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012EE9 RID: 77545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04012EEA RID: 77546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04012EEB RID: 77547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04012EEC RID: 77548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04012EED RID: 77549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04012EEE RID: 77550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04012EEF RID: 77551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04012EF0 RID: 77552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04012EF1 RID: 77553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04012EF2 RID: 77554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04012EF3 RID: 77555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04012EF4 RID: 77556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04012EF5 RID: 77557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04012EF6 RID: 77558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04012EF7 RID: 77559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04012EF8 RID: 77560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04012EF9 RID: 77561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04012EFA RID: 77562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04012EFB RID: 77563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;
}
