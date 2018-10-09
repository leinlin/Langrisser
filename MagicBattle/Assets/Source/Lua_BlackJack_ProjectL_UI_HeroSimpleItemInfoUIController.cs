using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014DF RID: 5343
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController : LuaObject
{
	// Token: 0x0601F752 RID: 128850 RVA: 0x00A51FBC File Offset: 0x00A501BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitHeroSimpleItemInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroSimpleItemInfoUIController.InitHeroSimpleItemInfo(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F753 RID: 128851 RVA: 0x00A52014 File Offset: 0x00A50214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			heroSimpleItemInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F754 RID: 128852 RVA: 0x00A52068 File Offset: 0x00A50268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetValues(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			heroSimpleItemInfoUIController.m_luaExportHelper.SetValues();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F755 RID: 128853 RVA: 0x00A520BC File Offset: 0x00A502BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			UISpineGraphic o;
			LuaObject.checkType<UISpineGraphic>(l, 3, out o);
			GameObject grapgicObj;
			LuaObject.checkType<GameObject>(l, 4, out grapgicObj);
			heroSimpleItemInfoUIController.m_luaExportHelper.CreateSpineGraphic(jobConnectionInfo, ref o, grapgicObj);
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

	// Token: 0x0601F756 RID: 128854 RVA: 0x00A5213C File Offset: 0x00A5033C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			UISpineGraphic o;
			LuaObject.checkType<UISpineGraphic>(l, 2, out o);
			heroSimpleItemInfoUIController.m_luaExportHelper.DestroySpineGraphic(ref o);
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

	// Token: 0x0601F757 RID: 128855 RVA: 0x00A521A0 File Offset: 0x00A503A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F758 RID: 128856 RVA: 0x00A5220C File Offset: 0x00A5040C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F759 RID: 128857 RVA: 0x00A52260 File Offset: 0x00A50460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F75A RID: 128858 RVA: 0x00A522B4 File Offset: 0x00A504B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F75B RID: 128859 RVA: 0x00A5235C File Offset: 0x00A5055C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F75C RID: 128860 RVA: 0x00A523B0 File Offset: 0x00A505B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F75D RID: 128861 RVA: 0x00A5241C File Offset: 0x00A5061C
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
				HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroSimpleItemInfoUIController heroSimpleItemInfoUIController2 = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroSimpleItemInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F75E RID: 128862 RVA: 0x00A5252C File Offset: 0x00A5072C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F75F RID: 128863 RVA: 0x00A52598 File Offset: 0x00A50798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F760 RID: 128864 RVA: 0x00A52604 File Offset: 0x00A50804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F761 RID: 128865 RVA: 0x00A52670 File Offset: 0x00A50870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F762 RID: 128866 RVA: 0x00A526DC File Offset: 0x00A508DC
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
				HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroSimpleItemInfoUIController heroSimpleItemInfoUIController2 = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroSimpleItemInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F763 RID: 128867 RVA: 0x00A527EC File Offset: 0x00A509EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			string s = heroSimpleItemInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F764 RID: 128868 RVA: 0x00A52848 File Offset: 0x00A50A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_heroNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F765 RID: 128869 RVA: 0x00A528A0 File Offset: 0x00A50AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Text heroNameText;
			LuaObject.checkType<Text>(l, 2, out heroNameText);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_heroNameText = heroNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F766 RID: 128870 RVA: 0x00A528FC File Offset: 0x00A50AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroJobText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_heroJobText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F767 RID: 128871 RVA: 0x00A52954 File Offset: 0x00A50B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroJobText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Text heroJobText;
			LuaObject.checkType<Text>(l, 2, out heroJobText);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_heroJobText = heroJobText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F768 RID: 128872 RVA: 0x00A529B0 File Offset: 0x00A50BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_armyImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F769 RID: 128873 RVA: 0x00A52A08 File Offset: 0x00A50C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Image armyImage;
			LuaObject.checkType<Image>(l, 2, out armyImage);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_armyImage = armyImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F76A RID: 128874 RVA: 0x00A52A64 File Offset: 0x00A50C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_armyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F76B RID: 128875 RVA: 0x00A52ABC File Offset: 0x00A50CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Text armyText;
			LuaObject.checkType<Text>(l, 2, out armyText);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_armyText = armyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F76C RID: 128876 RVA: 0x00A52B18 File Offset: 0x00A50D18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroStars(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_heroStars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F76D RID: 128877 RVA: 0x00A52B70 File Offset: 0x00A50D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroStars(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			GameObject heroStars;
			LuaObject.checkType<GameObject>(l, 2, out heroStars);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_heroStars = heroStars;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F76E RID: 128878 RVA: 0x00A52BCC File Offset: 0x00A50DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHPImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_heroHPImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F76F RID: 128879 RVA: 0x00A52C24 File Offset: 0x00A50E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHPImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Image heroHPImage;
			LuaObject.checkType<Image>(l, 2, out heroHPImage);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_heroHPImage = heroHPImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F770 RID: 128880 RVA: 0x00A52C80 File Offset: 0x00A50E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDFImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_heroDFImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F771 RID: 128881 RVA: 0x00A52CD8 File Offset: 0x00A50ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDFImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Image heroDFImage;
			LuaObject.checkType<Image>(l, 2, out heroDFImage);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_heroDFImage = heroDFImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F772 RID: 128882 RVA: 0x00A52D34 File Offset: 0x00A50F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroATImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_heroATImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F773 RID: 128883 RVA: 0x00A52D8C File Offset: 0x00A50F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroATImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Image heroATImage;
			LuaObject.checkType<Image>(l, 2, out heroATImage);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_heroATImage = heroATImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F774 RID: 128884 RVA: 0x00A52DE8 File Offset: 0x00A50FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroMagicDFImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_heroMagicDFImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F775 RID: 128885 RVA: 0x00A52E40 File Offset: 0x00A51040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroMagicDFImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Image heroMagicDFImage;
			LuaObject.checkType<Image>(l, 2, out heroMagicDFImage);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_heroMagicDFImage = heroMagicDFImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F776 RID: 128886 RVA: 0x00A52E9C File Offset: 0x00A5109C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroMagicImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_heroMagicImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F777 RID: 128887 RVA: 0x00A52EF4 File Offset: 0x00A510F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroMagicImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Image heroMagicImage;
			LuaObject.checkType<Image>(l, 2, out heroMagicImage);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_heroMagicImage = heroMagicImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F778 RID: 128888 RVA: 0x00A52F50 File Offset: 0x00A51150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDEXImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_heroDEXImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F779 RID: 128889 RVA: 0x00A52FA8 File Offset: 0x00A511A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDEXImage(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Image heroDEXImage;
			LuaObject.checkType<Image>(l, 2, out heroDEXImage);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_heroDEXImage = heroDEXImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F77A RID: 128890 RVA: 0x00A53004 File Offset: 0x00A51204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_talentIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_talentIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F77B RID: 128891 RVA: 0x00A5305C File Offset: 0x00A5125C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_talentIconImg(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Image talentIconImg;
			LuaObject.checkType<Image>(l, 2, out talentIconImg);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_talentIconImg = talentIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F77C RID: 128892 RVA: 0x00A530B8 File Offset: 0x00A512B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_talentNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_talentNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F77D RID: 128893 RVA: 0x00A53110 File Offset: 0x00A51310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_talentNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Text talentNameText;
			LuaObject.checkType<Text>(l, 2, out talentNameText);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_talentNameText = talentNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F77E RID: 128894 RVA: 0x00A5316C File Offset: 0x00A5136C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_talentDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_talentDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F77F RID: 128895 RVA: 0x00A531C4 File Offset: 0x00A513C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_talentDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Text talentDescText;
			LuaObject.checkType<Text>(l, 2, out talentDescText);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_talentDescText = talentDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F780 RID: 128896 RVA: 0x00A53220 File Offset: 0x00A51420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finalJob1CHNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob1CHNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F781 RID: 128897 RVA: 0x00A53278 File Offset: 0x00A51478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finalJob1CHNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Text finalJob1CHNameText;
			LuaObject.checkType<Text>(l, 2, out finalJob1CHNameText);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob1CHNameText = finalJob1CHNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F782 RID: 128898 RVA: 0x00A532D4 File Offset: 0x00A514D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finalJob1ENNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob1ENNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F783 RID: 128899 RVA: 0x00A5332C File Offset: 0x00A5152C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finalJob1ENNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Text finalJob1ENNameText;
			LuaObject.checkType<Text>(l, 2, out finalJob1ENNameText);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob1ENNameText = finalJob1ENNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F784 RID: 128900 RVA: 0x00A53388 File Offset: 0x00A51588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finalJob1GraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob1GraphicObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F785 RID: 128901 RVA: 0x00A533E0 File Offset: 0x00A515E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finalJob1GraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			GameObject finalJob1GraphicObj;
			LuaObject.checkType<GameObject>(l, 2, out finalJob1GraphicObj);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob1GraphicObj = finalJob1GraphicObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F786 RID: 128902 RVA: 0x00A5343C File Offset: 0x00A5163C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finalJob2Obj(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob2Obj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F787 RID: 128903 RVA: 0x00A53494 File Offset: 0x00A51694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finalJob2Obj(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			GameObject finalJob2Obj;
			LuaObject.checkType<GameObject>(l, 2, out finalJob2Obj);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob2Obj = finalJob2Obj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F788 RID: 128904 RVA: 0x00A534F0 File Offset: 0x00A516F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finalJob2CHNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob2CHNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F789 RID: 128905 RVA: 0x00A53548 File Offset: 0x00A51748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finalJob2CHNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Text finalJob2CHNameText;
			LuaObject.checkType<Text>(l, 2, out finalJob2CHNameText);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob2CHNameText = finalJob2CHNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F78A RID: 128906 RVA: 0x00A535A4 File Offset: 0x00A517A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finalJob2ENNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob2ENNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F78B RID: 128907 RVA: 0x00A535FC File Offset: 0x00A517FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finalJob2ENNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Text finalJob2ENNameText;
			LuaObject.checkType<Text>(l, 2, out finalJob2ENNameText);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob2ENNameText = finalJob2ENNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F78C RID: 128908 RVA: 0x00A53658 File Offset: 0x00A51858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_finalJob2GraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob2GraphicObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F78D RID: 128909 RVA: 0x00A536B0 File Offset: 0x00A518B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_finalJob2GraphicObj(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			GameObject finalJob2GraphicObj;
			LuaObject.checkType<GameObject>(l, 2, out finalJob2GraphicObj);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_finalJob2GraphicObj = finalJob2GraphicObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F78E RID: 128910 RVA: 0x00A5370C File Offset: 0x00A5190C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F78F RID: 128911 RVA: 0x00A53760 File Offset: 0x00A51960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroSimpleItemInfoUIController.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F790 RID: 128912 RVA: 0x00A537B8 File Offset: 0x00A519B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroJobGraphic1(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_heroJobGraphic1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F791 RID: 128913 RVA: 0x00A53810 File Offset: 0x00A51A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroJobGraphic1(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			UISpineGraphic heroJobGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out heroJobGraphic);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_heroJobGraphic1 = heroJobGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F792 RID: 128914 RVA: 0x00A5386C File Offset: 0x00A51A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroJobGraphic2(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroSimpleItemInfoUIController.m_luaExportHelper.m_heroJobGraphic2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F793 RID: 128915 RVA: 0x00A538C4 File Offset: 0x00A51AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroJobGraphic2(IntPtr l)
	{
		int result;
		try
		{
			HeroSimpleItemInfoUIController heroSimpleItemInfoUIController = (HeroSimpleItemInfoUIController)LuaObject.checkSelf(l);
			UISpineGraphic heroJobGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out heroJobGraphic);
			heroSimpleItemInfoUIController.m_luaExportHelper.m_heroJobGraphic2 = heroJobGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F794 RID: 128916 RVA: 0x00A53920 File Offset: 0x00A51B20
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroSimpleItemInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.InitHeroSimpleItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.SetValues);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache11);
		string name = "m_heroNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_heroNameText);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_heroNameText);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache13, true);
		string name2 = "m_heroJobText";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_heroJobText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_heroJobText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache15, true);
		string name3 = "m_armyImage";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_armyImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_armyImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache17, true);
		string name4 = "m_armyText";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_armyText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_armyText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache19, true);
		string name5 = "m_heroStars";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_heroStars);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_heroStars);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1B, true);
		string name6 = "m_heroHPImage";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_heroHPImage);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_heroHPImage);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1D, true);
		string name7 = "m_heroDFImage";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_heroDFImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_heroDFImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache1F, true);
		string name8 = "m_heroATImage";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_heroATImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_heroATImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache21, true);
		string name9 = "m_heroMagicDFImage";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_heroMagicDFImage);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_heroMagicDFImage);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache23, true);
		string name10 = "m_heroMagicImage";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_heroMagicImage);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_heroMagicImage);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache25, true);
		string name11 = "m_heroDEXImage";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_heroDEXImage);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_heroDEXImage);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache27, true);
		string name12 = "m_talentIconImg";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_talentIconImg);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_talentIconImg);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache29, true);
		string name13 = "m_talentNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_talentNameText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_talentNameText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2B, true);
		string name14 = "m_talentDescText";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_talentDescText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_talentDescText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2D, true);
		string name15 = "m_finalJob1CHNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_finalJob1CHNameText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_finalJob1CHNameText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache2F, true);
		string name16 = "m_finalJob1ENNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_finalJob1ENNameText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_finalJob1ENNameText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache31, true);
		string name17 = "m_finalJob1GraphicObj";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_finalJob1GraphicObj);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_finalJob1GraphicObj);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache33, true);
		string name18 = "m_finalJob2Obj";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_finalJob2Obj);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_finalJob2Obj);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache35, true);
		string name19 = "m_finalJob2CHNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_finalJob2CHNameText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_finalJob2CHNameText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache37, true);
		string name20 = "m_finalJob2ENNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_finalJob2ENNameText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_finalJob2ENNameText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache39, true);
		string name21 = "m_finalJob2GraphicObj";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_finalJob2GraphicObj);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_finalJob2GraphicObj);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3B, true);
		string name22 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_hero);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_hero);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3D, true);
		string name23 = "m_heroJobGraphic1";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_heroJobGraphic1);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_heroJobGraphic1);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache3F, true);
		string name24 = "m_heroJobGraphic2";
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.get_m_heroJobGraphic2);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.set_m_heroJobGraphic2);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroSimpleItemInfoUIController.<>f__mg$cache41, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroSimpleItemInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015776 RID: 87926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015777 RID: 87927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015778 RID: 87928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015779 RID: 87929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401577A RID: 87930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401577B RID: 87931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401577C RID: 87932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401577D RID: 87933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401577E RID: 87934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401577F RID: 87935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015780 RID: 87936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015781 RID: 87937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015782 RID: 87938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015783 RID: 87939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015784 RID: 87940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015785 RID: 87941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015786 RID: 87942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015787 RID: 87943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015788 RID: 87944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015789 RID: 87945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401578A RID: 87946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401578B RID: 87947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401578C RID: 87948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401578D RID: 87949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401578E RID: 87950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401578F RID: 87951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015790 RID: 87952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015791 RID: 87953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015792 RID: 87954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015793 RID: 87955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015794 RID: 87956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015795 RID: 87957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015796 RID: 87958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015797 RID: 87959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015798 RID: 87960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015799 RID: 87961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401579A RID: 87962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401579B RID: 87963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401579C RID: 87964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401579D RID: 87965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401579E RID: 87966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0401579F RID: 87967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040157A0 RID: 87968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040157A1 RID: 87969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040157A2 RID: 87970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040157A3 RID: 87971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040157A4 RID: 87972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040157A5 RID: 87973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040157A6 RID: 87974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040157A7 RID: 87975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040157A8 RID: 87976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040157A9 RID: 87977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040157AA RID: 87978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040157AB RID: 87979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040157AC RID: 87980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040157AD RID: 87981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040157AE RID: 87982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040157AF RID: 87983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040157B0 RID: 87984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040157B1 RID: 87985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040157B2 RID: 87986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040157B3 RID: 87987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040157B4 RID: 87988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040157B5 RID: 87989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040157B6 RID: 87990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040157B7 RID: 87991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;
}
