using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015D6 RID: 5590
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UserGuideUIController : LuaObject
{
	// Token: 0x06022156 RID: 139606 RVA: 0x00BA03DC File Offset: 0x00B9E5DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableInput(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			bool enable;
			LuaObject.checkType(l, 2, out enable);
			userGuideUIController.EnableInput(enable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022157 RID: 139607 RVA: 0x00BA0434 File Offset: 0x00B9E634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDisableInputObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			bool b = userGuideUIController.IsDisableInputObject(obj);
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

	// Token: 0x06022158 RID: 139608 RVA: 0x00BA0498 File Offset: 0x00B9E698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowFunctionOpen(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			string functionName;
			LuaObject.checkType(l, 2, out functionName);
			string animPrefabName;
			LuaObject.checkType(l, 3, out animPrefabName);
			Action onAnimEnd;
			LuaObject.checkDelegate<Action>(l, 4, out onAnimEnd);
			userGuideUIController.ShowFunctionOpen(functionName, animPrefabName, onAnimEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022159 RID: 139609 RVA: 0x00BA050C File Offset: 0x00B9E70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideFunctionOpen(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.HideFunctionOpen();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602215A RID: 139610 RVA: 0x00BA0558 File Offset: 0x00B9E758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowUserGuideTips(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			string tipsText;
			LuaObject.checkType(l, 2, out tipsText);
			userGuideUIController.ShowUserGuideTips(tipsText);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602215B RID: 139611 RVA: 0x00BA05B0 File Offset: 0x00B9E7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideUserGuideTips(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.HideUserGuideTips();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602215C RID: 139612 RVA: 0x00BA05FC File Offset: 0x00B9E7FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowClickMask(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Vector2 screenPos;
			LuaObject.checkType(l, 2, out screenPos);
			Vector2 screenSize;
			LuaObject.checkType(l, 3, out screenSize);
			userGuideUIController.ShowClickMask(screenPos, screenSize);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602215D RID: 139613 RVA: 0x00BA0660 File Offset: 0x00B9E860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideClickMask(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.HideClickMask();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602215E RID: 139614 RVA: 0x00BA06AC File Offset: 0x00B9E8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsBgButtonObj(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			bool b = userGuideUIController.IsBgButtonObj(obj);
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

	// Token: 0x0602215F RID: 139615 RVA: 0x00BA0710 File Offset: 0x00B9E910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayPageOpenTween(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.PlayPageOpenTween();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022160 RID: 139616 RVA: 0x00BA075C File Offset: 0x00B9E95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreatePages(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			string pagesPrefab;
			LuaObject.checkType(l, 2, out pagesPrefab);
			userGuideUIController.CreatePages(pagesPrefab);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022161 RID: 139617 RVA: 0x00BA07B4 File Offset: 0x00B9E9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPagesCount(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			int pagesCount = userGuideUIController.GetPagesCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pagesCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022162 RID: 139618 RVA: 0x00BA0808 File Offset: 0x00B9EA08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPage(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			bool hasNext;
			LuaObject.checkType(l, 3, out hasNext);
			bool hasPrev;
			LuaObject.checkType(l, 4, out hasPrev);
			userGuideUIController.ShowPage(index, hasNext, hasPrev);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022163 RID: 139619 RVA: 0x00BA087C File Offset: 0x00B9EA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HidePage(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.HidePage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022164 RID: 139620 RVA: 0x00BA08C8 File Offset: 0x00B9EAC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableSkipButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			bool bEnable;
			LuaObject.checkType(l, 2, out bEnable);
			userGuideUIController.EnableSkipButton(bEnable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022165 RID: 139621 RVA: 0x00BA0920 File Offset: 0x00B9EB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022166 RID: 139622 RVA: 0x00BA0974 File Offset: 0x00B9EB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int _ShowMask(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Vector2 pos;
			LuaObject.checkType(l, 2, out pos);
			Vector2 size;
			LuaObject.checkType(l, 3, out size);
			userGuideUIController.m_luaExportHelper._ShowMask(pos, size);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022167 RID: 139623 RVA: 0x00BA09E0 File Offset: 0x00B9EBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowIndicator(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Vector2 screenPos;
			LuaObject.checkType(l, 2, out screenPos);
			userGuideUIController.m_luaExportHelper.ShowIndicator(screenPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022168 RID: 139624 RVA: 0x00BA0A3C File Offset: 0x00B9EC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideIndicator(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.HideIndicator();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022169 RID: 139625 RVA: 0x00BA0A90 File Offset: 0x00B9EC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndicatorGameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Vector2 indicateScreenPos;
			LuaObject.checkType(l, 2, out indicateScreenPos);
			GameObject indicatorGameObject = userGuideUIController.m_luaExportHelper.GetIndicatorGameObject(indicateScreenPos);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, indicatorGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602216A RID: 139626 RVA: 0x00BA0AF8 File Offset: 0x00B9ECF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602216B RID: 139627 RVA: 0x00BA0B4C File Offset: 0x00B9ED4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNextPageButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.OnNextPageButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602216C RID: 139628 RVA: 0x00BA0BA0 File Offset: 0x00B9EDA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPrevPageButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.OnPrevPageButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602216D RID: 139629 RVA: 0x00BA0BF4 File Offset: 0x00B9EDF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClosePageButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.OnClosePageButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602216E RID: 139630 RVA: 0x00BA0C48 File Offset: 0x00B9EE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBtnSkipGuideClick(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.OnBtnSkipGuideClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602216F RID: 139631 RVA: 0x00BA0C9C File Offset: 0x00B9EE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			userGuideUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022170 RID: 139632 RVA: 0x00BA0D08 File Offset: 0x00B9EF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022171 RID: 139633 RVA: 0x00BA0D5C File Offset: 0x00B9EF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022172 RID: 139634 RVA: 0x00BA0DB0 File Offset: 0x00B9EFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = userGuideUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06022173 RID: 139635 RVA: 0x00BA0E58 File Offset: 0x00B9F058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022174 RID: 139636 RVA: 0x00BA0EAC File Offset: 0x00B9F0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			userGuideUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022175 RID: 139637 RVA: 0x00BA0F18 File Offset: 0x00B9F118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				userGuideUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				UserGuideUIController userGuideUIController2 = (UserGuideUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				userGuideUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06022176 RID: 139638 RVA: 0x00BA1028 File Offset: 0x00B9F228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022177 RID: 139639 RVA: 0x00BA1094 File Offset: 0x00B9F294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022178 RID: 139640 RVA: 0x00BA1100 File Offset: 0x00B9F300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022179 RID: 139641 RVA: 0x00BA116C File Offset: 0x00B9F36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			userGuideUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602217A RID: 139642 RVA: 0x00BA11D8 File Offset: 0x00B9F3D8
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
				UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				userGuideUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				UserGuideUIController userGuideUIController2 = (UserGuideUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				userGuideUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602217B RID: 139643 RVA: 0x00BA12E8 File Offset: 0x00B9F4E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			string s = userGuideUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602217C RID: 139644 RVA: 0x00BA1344 File Offset: 0x00B9F544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.__callDele_EventOnNext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602217D RID: 139645 RVA: 0x00BA1398 File Offset: 0x00B9F598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.__clearDele_EventOnNext();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602217E RID: 139646 RVA: 0x00BA13EC File Offset: 0x00B9F5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNextPage(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.__callDele_EventOnNextPage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602217F RID: 139647 RVA: 0x00BA1440 File Offset: 0x00B9F640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNextPage(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.__clearDele_EventOnNextPage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022180 RID: 139648 RVA: 0x00BA1494 File Offset: 0x00B9F694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPrevPage(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.__callDele_EventOnPrevPage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022181 RID: 139649 RVA: 0x00BA14E8 File Offset: 0x00B9F6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPrevPage(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.__clearDele_EventOnPrevPage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022182 RID: 139650 RVA: 0x00BA153C File Offset: 0x00B9F73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.__callDele_EventOnSkip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022183 RID: 139651 RVA: 0x00BA1590 File Offset: 0x00B9F790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			userGuideUIController.m_luaExportHelper.__clearDele_EventOnSkip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022184 RID: 139652 RVA: 0x00BA15E4 File Offset: 0x00B9F7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRectTransformWidth_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rt;
			LuaObject.checkType<RectTransform>(l, 1, out rt);
			float w;
			LuaObject.checkType(l, 2, out w);
			UserGuideUIController.LuaExportHelper.SetRectTransformWidth(rt, w);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022185 RID: 139653 RVA: 0x00BA163C File Offset: 0x00B9F83C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNext(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					userGuideUIController.EventOnNext += value;
				}
				else if (num == 2)
				{
					userGuideUIController.EventOnNext -= value;
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

	// Token: 0x06022186 RID: 139654 RVA: 0x00BA16BC File Offset: 0x00B9F8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNextPage(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					userGuideUIController.EventOnNextPage += value;
				}
				else if (num == 2)
				{
					userGuideUIController.EventOnNextPage -= value;
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

	// Token: 0x06022187 RID: 139655 RVA: 0x00BA173C File Offset: 0x00B9F93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPrevPage(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					userGuideUIController.EventOnPrevPage += value;
				}
				else if (num == 2)
				{
					userGuideUIController.EventOnPrevPage -= value;
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

	// Token: 0x06022188 RID: 139656 RVA: 0x00BA17BC File Offset: 0x00B9F9BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnSkip(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					userGuideUIController.EventOnSkip += value;
				}
				else if (num == 2)
				{
					userGuideUIController.EventOnSkip -= value;
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

	// Token: 0x06022189 RID: 139657 RVA: 0x00BA183C File Offset: 0x00B9FA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602218A RID: 139658 RVA: 0x00BA1894 File Offset: 0x00B9FA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			userGuideUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602218B RID: 139659 RVA: 0x00BA18F0 File Offset: 0x00B9FAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_disableInputObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_disableInputObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602218C RID: 139660 RVA: 0x00BA1948 File Offset: 0x00B9FB48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_disableInputObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject disableInputObject;
			LuaObject.checkType<GameObject>(l, 2, out disableInputObject);
			userGuideUIController.m_luaExportHelper.m_disableInputObject = disableInputObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602218D RID: 139661 RVA: 0x00BA19A4 File Offset: 0x00B9FBA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_maskTransform(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_maskTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602218E RID: 139662 RVA: 0x00BA19FC File Offset: 0x00B9FBFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_maskTransform(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			RectTransform maskTransform;
			LuaObject.checkType<RectTransform>(l, 2, out maskTransform);
			userGuideUIController.m_luaExportHelper.m_maskTransform = maskTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602218F RID: 139663 RVA: 0x00BA1A58 File Offset: 0x00B9FC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_maskLeftTransform(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_maskLeftTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022190 RID: 139664 RVA: 0x00BA1AB0 File Offset: 0x00B9FCB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_maskLeftTransform(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			RectTransform maskLeftTransform;
			LuaObject.checkType<RectTransform>(l, 2, out maskLeftTransform);
			userGuideUIController.m_luaExportHelper.m_maskLeftTransform = maskLeftTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022191 RID: 139665 RVA: 0x00BA1B0C File Offset: 0x00B9FD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_maskRightTransform(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_maskRightTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022192 RID: 139666 RVA: 0x00BA1B64 File Offset: 0x00B9FD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_maskRightTransform(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			RectTransform maskRightTransform;
			LuaObject.checkType<RectTransform>(l, 2, out maskRightTransform);
			userGuideUIController.m_luaExportHelper.m_maskRightTransform = maskRightTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022193 RID: 139667 RVA: 0x00BA1BC0 File Offset: 0x00B9FDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_maskTopTransform(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_maskTopTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022194 RID: 139668 RVA: 0x00BA1C18 File Offset: 0x00B9FE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_maskTopTransform(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			RectTransform maskTopTransform;
			LuaObject.checkType<RectTransform>(l, 2, out maskTopTransform);
			userGuideUIController.m_luaExportHelper.m_maskTopTransform = maskTopTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022195 RID: 139669 RVA: 0x00BA1C74 File Offset: 0x00B9FE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_maskBottomTransform(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_maskBottomTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022196 RID: 139670 RVA: 0x00BA1CCC File Offset: 0x00B9FECC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_maskBottomTransform(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			RectTransform maskBottomTransform;
			LuaObject.checkType<RectTransform>(l, 2, out maskBottomTransform);
			userGuideUIController.m_luaExportHelper.m_maskBottomTransform = maskBottomTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022197 RID: 139671 RVA: 0x00BA1D28 File Offset: 0x00B9FF28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_indicatorToLeftDown(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_indicatorToLeftDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022198 RID: 139672 RVA: 0x00BA1D80 File Offset: 0x00B9FF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_indicatorToLeftDown(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject indicatorToLeftDown;
			LuaObject.checkType<GameObject>(l, 2, out indicatorToLeftDown);
			userGuideUIController.m_luaExportHelper.m_indicatorToLeftDown = indicatorToLeftDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022199 RID: 139673 RVA: 0x00BA1DDC File Offset: 0x00B9FFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_indicatorToRightDown(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_indicatorToRightDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602219A RID: 139674 RVA: 0x00BA1E34 File Offset: 0x00BA0034
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_indicatorToRightDown(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject indicatorToRightDown;
			LuaObject.checkType<GameObject>(l, 2, out indicatorToRightDown);
			userGuideUIController.m_luaExportHelper.m_indicatorToRightDown = indicatorToRightDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602219B RID: 139675 RVA: 0x00BA1E90 File Offset: 0x00BA0090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_indicatorToLeftUp(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_indicatorToLeftUp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602219C RID: 139676 RVA: 0x00BA1EE8 File Offset: 0x00BA00E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_indicatorToLeftUp(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject indicatorToLeftUp;
			LuaObject.checkType<GameObject>(l, 2, out indicatorToLeftUp);
			userGuideUIController.m_luaExportHelper.m_indicatorToLeftUp = indicatorToLeftUp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602219D RID: 139677 RVA: 0x00BA1F44 File Offset: 0x00BA0144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_indicatorToRightUp(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_indicatorToRightUp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602219E RID: 139678 RVA: 0x00BA1F9C File Offset: 0x00BA019C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_indicatorToRightUp(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject indicatorToRightUp;
			LuaObject.checkType<GameObject>(l, 2, out indicatorToRightUp);
			userGuideUIController.m_luaExportHelper.m_indicatorToRightUp = indicatorToRightUp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602219F RID: 139679 RVA: 0x00BA1FF8 File Offset: 0x00BA01F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pagesUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_pagesUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221A0 RID: 139680 RVA: 0x00BA2050 File Offset: 0x00BA0250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pagesUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			CommonUIStateController pagesUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out pagesUIStateController);
			userGuideUIController.m_luaExportHelper.m_pagesUIStateController = pagesUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221A1 RID: 139681 RVA: 0x00BA20AC File Offset: 0x00BA02AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pagesGameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_pagesGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221A2 RID: 139682 RVA: 0x00BA2104 File Offset: 0x00BA0304
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_pagesGameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject pagesGameObject;
			LuaObject.checkType<GameObject>(l, 2, out pagesGameObject);
			userGuideUIController.m_luaExportHelper.m_pagesGameObject = pagesGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221A3 RID: 139683 RVA: 0x00BA2160 File Offset: 0x00BA0360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pageBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_pageBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221A4 RID: 139684 RVA: 0x00BA21B8 File Offset: 0x00BA03B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pageBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Button pageBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out pageBackgroundButton);
			userGuideUIController.m_luaExportHelper.m_pageBackgroundButton = pageBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221A5 RID: 139685 RVA: 0x00BA2214 File Offset: 0x00BA0414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextPageButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_nextPageButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221A6 RID: 139686 RVA: 0x00BA226C File Offset: 0x00BA046C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_nextPageButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Button nextPageButton;
			LuaObject.checkType<Button>(l, 2, out nextPageButton);
			userGuideUIController.m_luaExportHelper.m_nextPageButton = nextPageButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221A7 RID: 139687 RVA: 0x00BA22C8 File Offset: 0x00BA04C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prevPageButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_prevPageButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221A8 RID: 139688 RVA: 0x00BA2320 File Offset: 0x00BA0520
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_prevPageButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Button prevPageButton;
			LuaObject.checkType<Button>(l, 2, out prevPageButton);
			userGuideUIController.m_luaExportHelper.m_prevPageButton = prevPageButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221A9 RID: 139689 RVA: 0x00BA237C File Offset: 0x00BA057C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closePageButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_closePageButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221AA RID: 139690 RVA: 0x00BA23D4 File Offset: 0x00BA05D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_closePageButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Button closePageButton;
			LuaObject.checkType<Button>(l, 2, out closePageButton);
			userGuideUIController.m_luaExportHelper.m_closePageButton = closePageButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221AB RID: 139691 RVA: 0x00BA2430 File Offset: 0x00BA0630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_pageDummyObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_pageDummyObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221AC RID: 139692 RVA: 0x00BA2488 File Offset: 0x00BA0688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pageDummyObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject pageDummyObject;
			LuaObject.checkType<GameObject>(l, 2, out pageDummyObject);
			userGuideUIController.m_luaExportHelper.m_pageDummyObject = pageDummyObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221AD RID: 139693 RVA: 0x00BA24E4 File Offset: 0x00BA06E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_functionOpenGameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_functionOpenGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221AE RID: 139694 RVA: 0x00BA253C File Offset: 0x00BA073C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_functionOpenGameObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject functionOpenGameObject;
			LuaObject.checkType<GameObject>(l, 2, out functionOpenGameObject);
			userGuideUIController.m_luaExportHelper.m_functionOpenGameObject = functionOpenGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221AF RID: 139695 RVA: 0x00BA2598 File Offset: 0x00BA0798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userGuideTipsObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_userGuideTipsObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221B0 RID: 139696 RVA: 0x00BA25F0 File Offset: 0x00BA07F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideTipsObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject userGuideTipsObject;
			LuaObject.checkType<GameObject>(l, 2, out userGuideTipsObject);
			userGuideUIController.m_luaExportHelper.m_userGuideTipsObject = userGuideTipsObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221B1 RID: 139697 RVA: 0x00BA264C File Offset: 0x00BA084C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userGuideTipsText(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_userGuideTipsText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221B2 RID: 139698 RVA: 0x00BA26A4 File Offset: 0x00BA08A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userGuideTipsText(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Text userGuideTipsText;
			LuaObject.checkType<Text>(l, 2, out userGuideTipsText);
			userGuideUIController.m_luaExportHelper.m_userGuideTipsText = userGuideTipsText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221B3 RID: 139699 RVA: 0x00BA2700 File Offset: 0x00BA0900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_BtnSkipGuide(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_BtnSkipGuide);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221B4 RID: 139700 RVA: 0x00BA2758 File Offset: 0x00BA0958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_BtnSkipGuide(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Button btnSkipGuide;
			LuaObject.checkType<Button>(l, 2, out btnSkipGuide);
			userGuideUIController.m_luaExportHelper.m_BtnSkipGuide = btnSkipGuide;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221B5 RID: 139701 RVA: 0x00BA27B4 File Offset: 0x00BA09B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_functionOpenUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_functionOpenUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221B6 RID: 139702 RVA: 0x00BA280C File Offset: 0x00BA0A0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_functionOpenUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			CommonUIStateController functionOpenUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out functionOpenUIStateController);
			userGuideUIController.m_luaExportHelper.m_functionOpenUIStateController = functionOpenUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221B7 RID: 139703 RVA: 0x00BA2868 File Offset: 0x00BA0A68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_pagePanelObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_pagePanelObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221B8 RID: 139704 RVA: 0x00BA28C0 File Offset: 0x00BA0AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_pagePanelObject(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			GameObject pagePanelObject;
			LuaObject.checkType<GameObject>(l, 2, out pagePanelObject);
			userGuideUIController.m_luaExportHelper.m_pagePanelObject = pagePanelObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221B9 RID: 139705 RVA: 0x00BA291C File Offset: 0x00BA0B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_camera(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.m_luaExportHelper.m_camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221BA RID: 139706 RVA: 0x00BA2974 File Offset: 0x00BA0B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_camera(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			userGuideUIController.m_luaExportHelper.m_camera = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221BB RID: 139707 RVA: 0x00BA29D0 File Offset: 0x00BA0BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnableBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, userGuideUIController.EnableBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221BC RID: 139708 RVA: 0x00BA2A24 File Offset: 0x00BA0C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnableBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			UserGuideUIController userGuideUIController = (UserGuideUIController)LuaObject.checkSelf(l);
			bool enableBackgroundButton;
			LuaObject.checkType(l, 2, out enableBackgroundButton);
			userGuideUIController.EnableBackgroundButton = enableBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060221BD RID: 139709 RVA: 0x00BA2A7C File Offset: 0x00BA0C7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UserGuideUIController");
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.EnableInput);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.IsDisableInputObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.ShowFunctionOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.HideFunctionOpen);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.ShowUserGuideTips);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.HideUserGuideTips);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.ShowClickMask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.HideClickMask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.IsBgButtonObj);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.PlayPageOpenTween);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.CreatePages);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.GetPagesCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.ShowPage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.HidePage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.EnableSkipButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController._ShowMask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.ShowIndicator);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.HideIndicator);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.GetIndicatorGameObject);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.OnNextPageButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.OnPrevPageButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.OnClosePageButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.OnBtnSkipGuideClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callDele_EventOnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__clearDele_EventOnNext);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callDele_EventOnNextPage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__clearDele_EventOnNextPage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callDele_EventOnPrevPage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__clearDele_EventOnPrevPage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__callDele_EventOnSkip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.__clearDele_EventOnSkip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.SetRectTransformWidth_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2E);
		string name = "EventOnNext";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_EventOnNext);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache2F, true);
		string name2 = "EventOnNextPage";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_EventOnNextPage);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache30, true);
		string name3 = "EventOnPrevPage";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_EventOnPrevPage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache31, true);
		string name4 = "EventOnSkip";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_EventOnSkip);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache32, true);
		string name5 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_backgroundButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache34, true);
		string name6 = "m_disableInputObject";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_disableInputObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_disableInputObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache36, true);
		string name7 = "m_maskTransform";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_maskTransform);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_maskTransform);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache38, true);
		string name8 = "m_maskLeftTransform";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_maskLeftTransform);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_maskLeftTransform);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3A, true);
		string name9 = "m_maskRightTransform";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_maskRightTransform);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_maskRightTransform);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3C, true);
		string name10 = "m_maskTopTransform";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_maskTopTransform);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_maskTopTransform);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3E, true);
		string name11 = "m_maskBottomTransform";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_maskBottomTransform);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_maskBottomTransform);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache40, true);
		string name12 = "m_indicatorToLeftDown";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_indicatorToLeftDown);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_indicatorToLeftDown);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache42, true);
		string name13 = "m_indicatorToRightDown";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_indicatorToRightDown);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_indicatorToRightDown);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache44, true);
		string name14 = "m_indicatorToLeftUp";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_indicatorToLeftUp);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_indicatorToLeftUp);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache46, true);
		string name15 = "m_indicatorToRightUp";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_indicatorToRightUp);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_indicatorToRightUp);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache48, true);
		string name16 = "m_pagesUIStateController";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_pagesUIStateController);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_pagesUIStateController);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4A, true);
		string name17 = "m_pagesGameObject";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_pagesGameObject);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_pagesGameObject);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4C, true);
		string name18 = "m_pageBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_pageBackgroundButton);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_pageBackgroundButton);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4E, true);
		string name19 = "m_nextPageButton";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_nextPageButton);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_nextPageButton);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache50, true);
		string name20 = "m_prevPageButton";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_prevPageButton);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_prevPageButton);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache52, true);
		string name21 = "m_closePageButton";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_closePageButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_closePageButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache54, true);
		string name22 = "m_pageDummyObject";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_pageDummyObject);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_pageDummyObject);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache56, true);
		string name23 = "m_functionOpenGameObject";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_functionOpenGameObject);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_functionOpenGameObject);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache58, true);
		string name24 = "m_userGuideTipsObject";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_userGuideTipsObject);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_userGuideTipsObject);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5A, true);
		string name25 = "m_userGuideTipsText";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_userGuideTipsText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_userGuideTipsText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5C, true);
		string name26 = "m_BtnSkipGuide";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_BtnSkipGuide);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_BtnSkipGuide);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5E, true);
		string name27 = "m_functionOpenUIStateController";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_functionOpenUIStateController);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_functionOpenUIStateController);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache60, true);
		string name28 = "m_pagePanelObject";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_pagePanelObject);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_pagePanelObject);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache62, true);
		string name29 = "m_camera";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_m_camera);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_m_camera);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache64, true);
		string name30 = "EnableBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.get_EnableBackgroundButton);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UserGuideUIController.set_EnableBackgroundButton);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_UserGuideUIController.<>f__mg$cache66, true);
		LuaObject.createTypeMetatable(l, null, typeof(UserGuideUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017F8C RID: 98188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017F8D RID: 98189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017F8E RID: 98190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017F8F RID: 98191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017F90 RID: 98192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017F91 RID: 98193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017F92 RID: 98194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017F93 RID: 98195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017F94 RID: 98196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017F95 RID: 98197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017F96 RID: 98198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017F97 RID: 98199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017F98 RID: 98200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017F99 RID: 98201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017F9A RID: 98202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017F9B RID: 98203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017F9C RID: 98204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017F9D RID: 98205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017F9E RID: 98206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017F9F RID: 98207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017FA0 RID: 98208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017FA1 RID: 98209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017FA2 RID: 98210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017FA3 RID: 98211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017FA4 RID: 98212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017FA5 RID: 98213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017FA6 RID: 98214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017FA7 RID: 98215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017FA8 RID: 98216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017FA9 RID: 98217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017FAA RID: 98218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017FAB RID: 98219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017FAC RID: 98220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017FAD RID: 98221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017FAE RID: 98222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017FAF RID: 98223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017FB0 RID: 98224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017FB1 RID: 98225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017FB2 RID: 98226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017FB3 RID: 98227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017FB4 RID: 98228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017FB5 RID: 98229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017FB6 RID: 98230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017FB7 RID: 98231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017FB8 RID: 98232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017FB9 RID: 98233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017FBA RID: 98234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017FBB RID: 98235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017FBC RID: 98236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017FBD RID: 98237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017FBE RID: 98238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017FBF RID: 98239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017FC0 RID: 98240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017FC1 RID: 98241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017FC2 RID: 98242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017FC3 RID: 98243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017FC4 RID: 98244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017FC5 RID: 98245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017FC6 RID: 98246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017FC7 RID: 98247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017FC8 RID: 98248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017FC9 RID: 98249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017FCA RID: 98250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017FCB RID: 98251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017FCC RID: 98252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04017FCD RID: 98253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04017FCE RID: 98254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04017FCF RID: 98255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04017FD0 RID: 98256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04017FD1 RID: 98257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04017FD2 RID: 98258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04017FD3 RID: 98259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017FD4 RID: 98260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04017FD5 RID: 98261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04017FD6 RID: 98262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04017FD7 RID: 98263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04017FD8 RID: 98264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04017FD9 RID: 98265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04017FDA RID: 98266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04017FDB RID: 98267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04017FDC RID: 98268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04017FDD RID: 98269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04017FDE RID: 98270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04017FDF RID: 98271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04017FE0 RID: 98272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04017FE1 RID: 98273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04017FE2 RID: 98274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04017FE3 RID: 98275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04017FE4 RID: 98276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04017FE5 RID: 98277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04017FE6 RID: 98278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04017FE7 RID: 98279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04017FE8 RID: 98280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04017FE9 RID: 98281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04017FEA RID: 98282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04017FEB RID: 98283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04017FEC RID: 98284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04017FED RID: 98285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04017FEE RID: 98286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04017FEF RID: 98287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04017FF0 RID: 98288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04017FF1 RID: 98289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04017FF2 RID: 98290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;
}
