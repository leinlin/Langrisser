using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200158F RID: 5519
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController : LuaObject
{
	// Token: 0x0602160E RID: 136718 RVA: 0x00B4718C File Offset: 0x00B4538C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTagHeroIconItem(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			tagPanelHeroIconItemUIController.InitTagHeroIconItem(heroId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602160F RID: 136719 RVA: 0x00B471E4 File Offset: 0x00B453E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			tagPanelHeroIconItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021610 RID: 136720 RVA: 0x00B47238 File Offset: 0x00B45438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			tagPanelHeroIconItemUIController.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021611 RID: 136721 RVA: 0x00B4728C File Offset: 0x00B4548C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021612 RID: 136722 RVA: 0x00B472F8 File Offset: 0x00B454F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021613 RID: 136723 RVA: 0x00B4734C File Offset: 0x00B4554C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021614 RID: 136724 RVA: 0x00B473A0 File Offset: 0x00B455A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021615 RID: 136725 RVA: 0x00B47448 File Offset: 0x00B45648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021616 RID: 136726 RVA: 0x00B4749C File Offset: 0x00B4569C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021617 RID: 136727 RVA: 0x00B47508 File Offset: 0x00B45708
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
				TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController2 = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				tagPanelHeroIconItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021618 RID: 136728 RVA: 0x00B47618 File Offset: 0x00B45818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021619 RID: 136729 RVA: 0x00B47684 File Offset: 0x00B45884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602161A RID: 136730 RVA: 0x00B476F0 File Offset: 0x00B458F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602161B RID: 136731 RVA: 0x00B4775C File Offset: 0x00B4595C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602161C RID: 136732 RVA: 0x00B477C8 File Offset: 0x00B459C8
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
				TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController2 = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				tagPanelHeroIconItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602161D RID: 136733 RVA: 0x00B478D8 File Offset: 0x00B45AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			string s = tagPanelHeroIconItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602161E RID: 136734 RVA: 0x00B47934 File Offset: 0x00B45B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, tagPanelHeroIconItemUIController.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602161F RID: 136735 RVA: 0x00B4798C File Offset: 0x00B45B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			tagPanelHeroIconItemUIController.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021620 RID: 136736 RVA: 0x00B479E8 File Offset: 0x00B45BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImg(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, tagPanelHeroIconItemUIController.m_luaExportHelper.m_iconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021621 RID: 136737 RVA: 0x00B47A40 File Offset: 0x00B45C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImg(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			Image iconImg;
			LuaObject.checkType<Image>(l, 2, out iconImg);
			tagPanelHeroIconItemUIController.m_luaExportHelper.m_iconImg = iconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021622 RID: 136738 RVA: 0x00B47A9C File Offset: 0x00B45C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, tagPanelHeroIconItemUIController.m_luaExportHelper.m_heroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021623 RID: 136739 RVA: 0x00B47AF4 File Offset: 0x00B45CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroId(IntPtr l)
	{
		int result;
		try
		{
			TagPanelHeroIconItemUIController tagPanelHeroIconItemUIController = (TagPanelHeroIconItemUIController)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			tagPanelHeroIconItemUIController.m_luaExportHelper.m_heroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021624 RID: 136740 RVA: 0x00B47B50 File Offset: 0x00B45D50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TagPanelHeroIconItemUIController");
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.InitTagHeroIconItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cacheF);
		string name = "m_button";
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.get_m_button);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.set_m_button);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache11, true);
		string name2 = "m_iconImg";
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.get_m_iconImg);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.set_m_iconImg);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache13, true);
		string name3 = "m_heroId";
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.get_m_heroId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.set_m_heroId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TagPanelHeroIconItemUIController.<>f__mg$cache15, true);
		LuaObject.createTypeMetatable(l, null, typeof(TagPanelHeroIconItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x040174D2 RID: 95442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040174D3 RID: 95443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040174D4 RID: 95444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040174D5 RID: 95445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040174D6 RID: 95446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040174D7 RID: 95447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040174D8 RID: 95448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040174D9 RID: 95449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040174DA RID: 95450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040174DB RID: 95451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040174DC RID: 95452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040174DD RID: 95453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040174DE RID: 95454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040174DF RID: 95455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040174E0 RID: 95456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040174E1 RID: 95457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040174E2 RID: 95458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040174E3 RID: 95459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040174E4 RID: 95460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040174E5 RID: 95461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040174E6 RID: 95462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040174E7 RID: 95463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
