using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014DE RID: 5342
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroShowUIController : LuaObject
{
	// Token: 0x0601F711 RID: 128785 RVA: 0x00A4FECC File Offset: 0x00A4E0CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTask(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			ArchiveUITask task;
			LuaObject.checkType<ArchiveUITask>(l, 2, out task);
			heroShowUIController.SetTask(task);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F712 RID: 128786 RVA: 0x00A4FF24 File Offset: 0x00A4E124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SwitchShowRankHero(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			int rank;
			LuaObject.checkType(l, 2, out rank);
			heroShowUIController.SwitchShowRankHero(rank);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F713 RID: 128787 RVA: 0x00A4FF7C File Offset: 0x00A4E17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadHeroTeam(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			int rank;
			LuaObject.checkType(l, 2, out rank);
			heroShowUIController.LoadHeroTeam(rank);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F714 RID: 128788 RVA: 0x00A4FFD4 File Offset: 0x00A4E1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyHeroShowComponent(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			heroShowUIController.DestroyHeroShowComponent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F715 RID: 128789 RVA: 0x00A50020 File Offset: 0x00A4E220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			heroShowUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F716 RID: 128790 RVA: 0x00A50074 File Offset: 0x00A4E274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWeiBoClick(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			heroShowUIController.m_luaExportHelper.OnWeiBoClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F717 RID: 128791 RVA: 0x00A500C8 File Offset: 0x00A4E2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWeChatClick(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			heroShowUIController.m_luaExportHelper.OnWeChatClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F718 RID: 128792 RVA: 0x00A5011C File Offset: 0x00A4E31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnClick(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			heroShowUIController.m_luaExportHelper.OnReturnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F719 RID: 128793 RVA: 0x00A50170 File Offset: 0x00A4E370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SwitchRankShowClick(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			GameObject obj;
			LuaObject.checkType<GameObject>(l, 2, out obj);
			heroShowUIController.m_luaExportHelper.SwitchRankShowClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F71A RID: 128794 RVA: 0x00A501CC File Offset: 0x00A4E3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WeiBoShare(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroShowUIController.m_luaExportHelper.WeiBoShare();
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

	// Token: 0x0601F71B RID: 128795 RVA: 0x00A50228 File Offset: 0x00A4E428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int WeChatShare(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroShowUIController.m_luaExportHelper.WeChatShare();
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

	// Token: 0x0601F71C RID: 128796 RVA: 0x00A50284 File Offset: 0x00A4E484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CaptureFrame(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroShowUIController.m_luaExportHelper.CaptureFrame();
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

	// Token: 0x0601F71D RID: 128797 RVA: 0x00A502E0 File Offset: 0x00A4E4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroShowUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F71E RID: 128798 RVA: 0x00A5034C File Offset: 0x00A4E54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			heroShowUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F71F RID: 128799 RVA: 0x00A503A0 File Offset: 0x00A4E5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			heroShowUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F720 RID: 128800 RVA: 0x00A503F4 File Offset: 0x00A4E5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroShowUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F721 RID: 128801 RVA: 0x00A5049C File Offset: 0x00A4E69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			heroShowUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F722 RID: 128802 RVA: 0x00A504F0 File Offset: 0x00A4E6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroShowUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F723 RID: 128803 RVA: 0x00A5055C File Offset: 0x00A4E75C
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
				HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroShowUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroShowUIController heroShowUIController2 = (HeroShowUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroShowUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F724 RID: 128804 RVA: 0x00A5066C File Offset: 0x00A4E86C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroShowUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F725 RID: 128805 RVA: 0x00A506D8 File Offset: 0x00A4E8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroShowUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F726 RID: 128806 RVA: 0x00A50744 File Offset: 0x00A4E944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroShowUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F727 RID: 128807 RVA: 0x00A507B0 File Offset: 0x00A4E9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroShowUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F728 RID: 128808 RVA: 0x00A5081C File Offset: 0x00A4EA1C
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
				HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroShowUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroShowUIController heroShowUIController2 = (HeroShowUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroShowUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F729 RID: 128809 RVA: 0x00A5092C File Offset: 0x00A4EB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			string s = heroShowUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F72A RID: 128810 RVA: 0x00A50988 File Offset: 0x00A4EB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_resourceContainer(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_resourceContainer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F72B RID: 128811 RVA: 0x00A509E0 File Offset: 0x00A4EBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_resourceContainer(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			PrefabResourceContainer resourceContainer;
			LuaObject.checkType<PrefabResourceContainer>(l, 2, out resourceContainer);
			heroShowUIController.m_luaExportHelper.m_resourceContainer = resourceContainer;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F72C RID: 128812 RVA: 0x00A50A3C File Offset: 0x00A4EC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_herosRGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_herosRGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F72D RID: 128813 RVA: 0x00A50A94 File Offset: 0x00A4EC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_herosRGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			GameObject herosRGameObject;
			LuaObject.checkType<GameObject>(l, 2, out herosRGameObject);
			heroShowUIController.m_luaExportHelper.m_herosRGameObject = herosRGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F72E RID: 128814 RVA: 0x00A50AF0 File Offset: 0x00A4ECF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_herosSRGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_herosSRGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F72F RID: 128815 RVA: 0x00A50B48 File Offset: 0x00A4ED48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_herosSRGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			GameObject herosSRGameObject;
			LuaObject.checkType<GameObject>(l, 2, out herosSRGameObject);
			heroShowUIController.m_luaExportHelper.m_herosSRGameObject = herosSRGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F730 RID: 128816 RVA: 0x00A50BA4 File Offset: 0x00A4EDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_herosSSRGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_herosSSRGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F731 RID: 128817 RVA: 0x00A50BFC File Offset: 0x00A4EDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_herosSSRGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			GameObject herosSSRGameObject;
			LuaObject.checkType<GameObject>(l, 2, out herosSSRGameObject);
			heroShowUIController.m_luaExportHelper.m_herosSSRGameObject = herosSSRGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F732 RID: 128818 RVA: 0x00A50C58 File Offset: 0x00A4EE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_shareButtonDummy(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_shareButtonDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F733 RID: 128819 RVA: 0x00A50CB0 File Offset: 0x00A4EEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_shareButtonDummy(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			GameObject shareButtonDummy;
			LuaObject.checkType<GameObject>(l, 2, out shareButtonDummy);
			heroShowUIController.m_luaExportHelper.m_shareButtonDummy = shareButtonDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F734 RID: 128820 RVA: 0x00A50D0C File Offset: 0x00A4EF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sharePhotoDummy(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_sharePhotoDummy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F735 RID: 128821 RVA: 0x00A50D64 File Offset: 0x00A4EF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sharePhotoDummy(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			GameObject sharePhotoDummy;
			LuaObject.checkType<GameObject>(l, 2, out sharePhotoDummy);
			heroShowUIController.m_luaExportHelper.m_sharePhotoDummy = sharePhotoDummy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F736 RID: 128822 RVA: 0x00A50DC0 File Offset: 0x00A4EFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F737 RID: 128823 RVA: 0x00A50E18 File Offset: 0x00A4F018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			heroShowUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F738 RID: 128824 RVA: 0x00A50E74 File Offset: 0x00A4F074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggleGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_toggleGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F739 RID: 128825 RVA: 0x00A50ECC File Offset: 0x00A4F0CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggleGroup(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			GameObject toggleGroup;
			LuaObject.checkType<GameObject>(l, 2, out toggleGroup);
			heroShowUIController.m_luaExportHelper.m_toggleGroup = toggleGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F73A RID: 128826 RVA: 0x00A50F28 File Offset: 0x00A4F128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_ssrToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_ssrToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F73B RID: 128827 RVA: 0x00A50F80 File Offset: 0x00A4F180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_ssrToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			Toggle ssrToggle;
			LuaObject.checkType<Toggle>(l, 2, out ssrToggle);
			heroShowUIController.m_luaExportHelper.m_ssrToggle = ssrToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F73C RID: 128828 RVA: 0x00A50FDC File Offset: 0x00A4F1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_srToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_srToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F73D RID: 128829 RVA: 0x00A51034 File Offset: 0x00A4F234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_srToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			Toggle srToggle;
			LuaObject.checkType<Toggle>(l, 2, out srToggle);
			heroShowUIController.m_luaExportHelper.m_srToggle = srToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F73E RID: 128830 RVA: 0x00A51090 File Offset: 0x00A4F290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_rToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F73F RID: 128831 RVA: 0x00A510E8 File Offset: 0x00A4F2E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			Toggle rToggle;
			LuaObject.checkType<Toggle>(l, 2, out rToggle);
			heroShowUIController.m_luaExportHelper.m_rToggle = rToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F740 RID: 128832 RVA: 0x00A51144 File Offset: 0x00A4F344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_weiBoButton(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_weiBoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F741 RID: 128833 RVA: 0x00A5119C File Offset: 0x00A4F39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_weiBoButton(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			Button weiBoButton;
			LuaObject.checkType<Button>(l, 2, out weiBoButton);
			heroShowUIController.m_luaExportHelper.m_weiBoButton = weiBoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F742 RID: 128834 RVA: 0x00A511F8 File Offset: 0x00A4F3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_weChatButton(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_weChatButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F743 RID: 128835 RVA: 0x00A51250 File Offset: 0x00A4F450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_weChatButton(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			Button weChatButton;
			LuaObject.checkType<Button>(l, 2, out weChatButton);
			heroShowUIController.m_luaExportHelper.m_weChatButton = weChatButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F744 RID: 128836 RVA: 0x00A512AC File Offset: 0x00A4F4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F745 RID: 128837 RVA: 0x00A51304 File Offset: 0x00A4F504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			heroShowUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F746 RID: 128838 RVA: 0x00A51360 File Offset: 0x00A4F560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lvText(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_lvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F747 RID: 128839 RVA: 0x00A513B8 File Offset: 0x00A4F5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lvText(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			Text lvText;
			LuaObject.checkType<Text>(l, 2, out lvText);
			heroShowUIController.m_luaExportHelper.m_lvText = lvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F748 RID: 128840 RVA: 0x00A51414 File Offset: 0x00A4F614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_serverNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F749 RID: 128841 RVA: 0x00A5146C File Offset: 0x00A4F66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			Text serverNameText;
			LuaObject.checkType<Text>(l, 2, out serverNameText);
			heroShowUIController.m_luaExportHelper.m_serverNameText = serverNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F74A RID: 128842 RVA: 0x00A514C8 File Offset: 0x00A4F6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroShowComponent(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_heroShowComponent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F74B RID: 128843 RVA: 0x00A51520 File Offset: 0x00A4F720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroShowComponent(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			HeroShowComponent heroShowComponent;
			LuaObject.checkType<HeroShowComponent>(l, 2, out heroShowComponent);
			heroShowUIController.m_luaExportHelper.m_heroShowComponent = heroShowComponent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F74C RID: 128844 RVA: 0x00A5157C File Offset: 0x00A4F77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_task(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_task);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F74D RID: 128845 RVA: 0x00A515D4 File Offset: 0x00A4F7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_task(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			ArchiveUITask task;
			LuaObject.checkType<ArchiveUITask>(l, 2, out task);
			heroShowUIController.m_luaExportHelper.m_task = task;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F74E RID: 128846 RVA: 0x00A51630 File Offset: 0x00A4F830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroShowUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F74F RID: 128847 RVA: 0x00A51688 File Offset: 0x00A4F888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroShowUIController heroShowUIController = (HeroShowUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroShowUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F750 RID: 128848 RVA: 0x00A516E4 File Offset: 0x00A4F8E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroShowUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.SetTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.SwitchShowRankHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.LoadHeroTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.DestroyHeroShowComponent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.OnWeiBoClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.OnWeChatClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.OnReturnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.SwitchRankShowClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.WeiBoShare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.WeChatShare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.CaptureFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache18);
		string name = "m_resourceContainer";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_resourceContainer);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_resourceContainer);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1A, true);
		string name2 = "m_herosRGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_herosRGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_herosRGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1C, true);
		string name3 = "m_herosSRGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_herosSRGameObject);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_herosSRGameObject);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1E, true);
		string name4 = "m_herosSSRGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_herosSSRGameObject);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_herosSSRGameObject);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache20, true);
		string name5 = "m_shareButtonDummy";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_shareButtonDummy);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_shareButtonDummy);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache22, true);
		string name6 = "m_sharePhotoDummy";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_sharePhotoDummy);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_sharePhotoDummy);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache24, true);
		string name7 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_returnButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache26, true);
		string name8 = "m_toggleGroup";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_toggleGroup);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_toggleGroup);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache28, true);
		string name9 = "m_ssrToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_ssrToggle);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_ssrToggle);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2A, true);
		string name10 = "m_srToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_srToggle);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_srToggle);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2C, true);
		string name11 = "m_rToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_rToggle);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_rToggle);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2E, true);
		string name12 = "m_weiBoButton";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_weiBoButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_weiBoButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache30, true);
		string name13 = "m_weChatButton";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_weChatButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_weChatButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache32, true);
		string name14 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_nameText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache34, true);
		string name15 = "m_lvText";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_lvText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_lvText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache36, true);
		string name16 = "m_serverNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_serverNameText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_serverNameText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache38, true);
		string name17 = "m_heroShowComponent";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_heroShowComponent);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_heroShowComponent);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3A, true);
		string name18 = "m_task";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_task);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_task);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3C, true);
		string name19 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.get_m_playerContext);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroShowUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroShowUIController.<>f__mg$cache3E, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroShowUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015737 RID: 87863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015738 RID: 87864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015739 RID: 87865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401573A RID: 87866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401573B RID: 87867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401573C RID: 87868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401573D RID: 87869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401573E RID: 87870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401573F RID: 87871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015740 RID: 87872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015741 RID: 87873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015742 RID: 87874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015743 RID: 87875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015744 RID: 87876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015745 RID: 87877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015746 RID: 87878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015747 RID: 87879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015748 RID: 87880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015749 RID: 87881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401574A RID: 87882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401574B RID: 87883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401574C RID: 87884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401574D RID: 87885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401574E RID: 87886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401574F RID: 87887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015750 RID: 87888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015751 RID: 87889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015752 RID: 87890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015753 RID: 87891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015754 RID: 87892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015755 RID: 87893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015756 RID: 87894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015757 RID: 87895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015758 RID: 87896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015759 RID: 87897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401575A RID: 87898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401575B RID: 87899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401575C RID: 87900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401575D RID: 87901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401575E RID: 87902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401575F RID: 87903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015760 RID: 87904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015761 RID: 87905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015762 RID: 87906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015763 RID: 87907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015764 RID: 87908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015765 RID: 87909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015766 RID: 87910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015767 RID: 87911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015768 RID: 87912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015769 RID: 87913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401576A RID: 87914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401576B RID: 87915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401576C RID: 87916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401576D RID: 87917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401576E RID: 87918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401576F RID: 87919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04015770 RID: 87920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015771 RID: 87921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015772 RID: 87922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015773 RID: 87923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04015774 RID: 87924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04015775 RID: 87925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;
}
