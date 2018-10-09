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

// Token: 0x020014CD RID: 5325
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController : LuaObject
{
	// Token: 0x0601F277 RID: 127607 RVA: 0x00A2B218 File Offset: 0x00A29418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSkillItem(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			GameObject descParent;
			LuaObject.checkType<GameObject>(l, 3, out descParent);
			heroJobTransferSkillItemUIController.InitSkillItem(skillInfo, descParent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F278 RID: 127608 RVA: 0x00A2B27C File Offset: 0x00A2947C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			heroJobTransferSkillItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F279 RID: 127609 RVA: 0x00A2B2D0 File Offset: 0x00A294D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			heroJobTransferSkillItemUIController.m_luaExportHelper.OnSkillItemClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F27A RID: 127610 RVA: 0x00A2B324 File Offset: 0x00A29524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F27B RID: 127611 RVA: 0x00A2B390 File Offset: 0x00A29590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F27C RID: 127612 RVA: 0x00A2B3E4 File Offset: 0x00A295E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F27D RID: 127613 RVA: 0x00A2B438 File Offset: 0x00A29638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F27E RID: 127614 RVA: 0x00A2B4E0 File Offset: 0x00A296E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F27F RID: 127615 RVA: 0x00A2B534 File Offset: 0x00A29734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F280 RID: 127616 RVA: 0x00A2B5A0 File Offset: 0x00A297A0
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
				HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController2 = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroJobTransferSkillItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F281 RID: 127617 RVA: 0x00A2B6B0 File Offset: 0x00A298B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F282 RID: 127618 RVA: 0x00A2B71C File Offset: 0x00A2991C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F283 RID: 127619 RVA: 0x00A2B788 File Offset: 0x00A29988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F284 RID: 127620 RVA: 0x00A2B7F4 File Offset: 0x00A299F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F285 RID: 127621 RVA: 0x00A2B860 File Offset: 0x00A29A60
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
				HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController2 = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroJobTransferSkillItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F286 RID: 127622 RVA: 0x00A2B970 File Offset: 0x00A29B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			string s = heroJobTransferSkillItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F287 RID: 127623 RVA: 0x00A2B9CC File Offset: 0x00A29BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferSkillItemUIController.m_luaExportHelper.m_skillIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F288 RID: 127624 RVA: 0x00A2BA24 File Offset: 0x00A29C24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_skillIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			Image skillIconImg;
			LuaObject.checkType<Image>(l, 2, out skillIconImg);
			heroJobTransferSkillItemUIController.m_luaExportHelper.m_skillIconImg = skillIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F289 RID: 127625 RVA: 0x00A2BA80 File Offset: 0x00A29C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_passiveSkillIconObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferSkillItemUIController.m_luaExportHelper.m_passiveSkillIconObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F28A RID: 127626 RVA: 0x00A2BAD8 File Offset: 0x00A29CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_passiveSkillIconObj(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			GameObject passiveSkillIconObj;
			LuaObject.checkType<GameObject>(l, 2, out passiveSkillIconObj);
			heroJobTransferSkillItemUIController.m_luaExportHelper.m_passiveSkillIconObj = passiveSkillIconObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F28B RID: 127627 RVA: 0x00A2BB34 File Offset: 0x00A29D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descParent(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferSkillItemUIController.m_luaExportHelper.m_descParent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F28C RID: 127628 RVA: 0x00A2BB8C File Offset: 0x00A29D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descParent(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			GameObject descParent;
			LuaObject.checkType<GameObject>(l, 2, out descParent);
			heroJobTransferSkillItemUIController.m_luaExportHelper.m_descParent = descParent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F28D RID: 127629 RVA: 0x00A2BBE8 File Offset: 0x00A29DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJobTransferSkillItemUIController.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F28E RID: 127630 RVA: 0x00A2BC3C File Offset: 0x00A29E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJobTransferSkillItemUIController heroJobTransferSkillItemUIController = (HeroJobTransferSkillItemUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			heroJobTransferSkillItemUIController.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F28F RID: 127631 RVA: 0x00A2BC94 File Offset: 0x00A29E94
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroJobTransferSkillItemUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.InitSkillItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.OnSkillItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cacheF);
		string name = "m_skillIconImg";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.get_m_skillIconImg);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.set_m_skillIconImg);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache11, true);
		string name2 = "m_passiveSkillIconObj";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.get_m_passiveSkillIconObj);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.set_m_passiveSkillIconObj);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache13, true);
		string name3 = "m_descParent";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.get_m_descParent);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.set_m_descParent);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache15, true);
		string name4 = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.get_m_skillInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.set_m_skillInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroJobTransferSkillItemUIController.<>f__mg$cache17, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroJobTransferSkillItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040152BF RID: 86719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040152C0 RID: 86720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040152C1 RID: 86721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040152C2 RID: 86722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040152C3 RID: 86723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040152C4 RID: 86724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040152C5 RID: 86725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040152C6 RID: 86726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040152C7 RID: 86727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040152C8 RID: 86728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040152C9 RID: 86729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040152CA RID: 86730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040152CB RID: 86731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040152CC RID: 86732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040152CD RID: 86733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040152CE RID: 86734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040152CF RID: 86735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040152D0 RID: 86736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040152D1 RID: 86737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040152D2 RID: 86738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040152D3 RID: 86739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040152D4 RID: 86740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040152D5 RID: 86741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040152D6 RID: 86742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
