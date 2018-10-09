using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014C5 RID: 5317
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroHeadUIController : LuaObject
{
	// Token: 0x0601F197 RID: 127383 RVA: 0x00A23F7C File Offset: 0x00A2217C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeroWrap(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			HeroArchiveUIController.HeroWrap heroWrap;
			LuaObject.checkType<HeroArchiveUIController.HeroWrap>(l, 2, out heroWrap);
			heroHeadUIController.SetHeroWrap(heroWrap);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F198 RID: 127384 RVA: 0x00A23FD4 File Offset: 0x00A221D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RefreshDisplay(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			heroHeadUIController.RefreshDisplay();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F199 RID: 127385 RVA: 0x00A24020 File Offset: 0x00A22220
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHeroHeadClick(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			heroHeadUIController.OnHeroHeadClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F19A RID: 127386 RVA: 0x00A2406C File Offset: 0x00A2226C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Selected(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			bool isSelect;
			LuaObject.checkType(l, 2, out isSelect);
			heroHeadUIController.Selected(isSelect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F19B RID: 127387 RVA: 0x00A240C4 File Offset: 0x00A222C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			heroHeadUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F19C RID: 127388 RVA: 0x00A24118 File Offset: 0x00A22318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroHeadUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F19D RID: 127389 RVA: 0x00A24184 File Offset: 0x00A22384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			heroHeadUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F19E RID: 127390 RVA: 0x00A241D8 File Offset: 0x00A223D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			heroHeadUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F19F RID: 127391 RVA: 0x00A2422C File Offset: 0x00A2242C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroHeadUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F1A0 RID: 127392 RVA: 0x00A242D4 File Offset: 0x00A224D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			heroHeadUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1A1 RID: 127393 RVA: 0x00A24328 File Offset: 0x00A22528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroHeadUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1A2 RID: 127394 RVA: 0x00A24394 File Offset: 0x00A22594
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
				HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroHeadUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroHeadUIController heroHeadUIController2 = (HeroHeadUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroHeadUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F1A3 RID: 127395 RVA: 0x00A244A4 File Offset: 0x00A226A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroHeadUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1A4 RID: 127396 RVA: 0x00A24510 File Offset: 0x00A22710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroHeadUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1A5 RID: 127397 RVA: 0x00A2457C File Offset: 0x00A2277C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroHeadUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1A6 RID: 127398 RVA: 0x00A245E8 File Offset: 0x00A227E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroHeadUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1A7 RID: 127399 RVA: 0x00A24654 File Offset: 0x00A22854
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
				HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroHeadUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroHeadUIController heroHeadUIController2 = (HeroHeadUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroHeadUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F1A8 RID: 127400 RVA: 0x00A24764 File Offset: 0x00A22964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			string s = heroHeadUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F1A9 RID: 127401 RVA: 0x00A247C0 File Offset: 0x00A229C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_OnHeroHeadClickEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			HeroHeadUIController obj;
			LuaObject.checkType<HeroHeadUIController>(l, 2, out obj);
			heroHeadUIController.m_luaExportHelper.__callDele_OnHeroHeadClickEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1AA RID: 127402 RVA: 0x00A2481C File Offset: 0x00A22A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_OnHeroHeadClickEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			HeroHeadUIController obj;
			LuaObject.checkType<HeroHeadUIController>(l, 2, out obj);
			heroHeadUIController.m_luaExportHelper.__clearDele_OnHeroHeadClickEvent(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1AB RID: 127403 RVA: 0x00A24878 File Offset: 0x00A22A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OnHeroHeadClickEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			Action<HeroHeadUIController> value;
			int num = LuaObject.checkDelegate<Action<HeroHeadUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroHeadUIController.OnHeroHeadClickEvent += value;
				}
				else if (num == 2)
				{
					heroHeadUIController.OnHeroHeadClickEvent -= value;
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

	// Token: 0x0601F1AC RID: 127404 RVA: 0x00A248F8 File Offset: 0x00A22AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHeadButton(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroHeadUIController.m_luaExportHelper.m_heroHeadButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1AD RID: 127405 RVA: 0x00A24950 File Offset: 0x00A22B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHeadButton(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			Button heroHeadButton;
			LuaObject.checkType<Button>(l, 2, out heroHeadButton);
			heroHeadUIController.m_luaExportHelper.m_heroHeadButton = heroHeadButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1AE RID: 127406 RVA: 0x00A249AC File Offset: 0x00A22BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroHeadAnimation(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroHeadUIController.m_luaExportHelper.m_heroHeadAnimation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1AF RID: 127407 RVA: 0x00A24A04 File Offset: 0x00A22C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroHeadAnimation(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			CommonUIStateController heroHeadAnimation;
			LuaObject.checkType<CommonUIStateController>(l, 2, out heroHeadAnimation);
			heroHeadUIController.m_luaExportHelper.m_heroHeadAnimation = heroHeadAnimation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1B0 RID: 127408 RVA: 0x00A24A60 File Offset: 0x00A22C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroHeadUIController.m_luaExportHelper.m_selectImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1B1 RID: 127409 RVA: 0x00A24AB8 File Offset: 0x00A22CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectImage(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			Image selectImage;
			LuaObject.checkType<Image>(l, 2, out selectImage);
			heroHeadUIController.m_luaExportHelper.m_selectImage = selectImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1B2 RID: 127410 RVA: 0x00A24B14 File Offset: 0x00A22D14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_cardIamge(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroHeadUIController.m_luaExportHelper.m_cardIamge);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1B3 RID: 127411 RVA: 0x00A24B6C File Offset: 0x00A22D6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cardIamge(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			Image cardIamge;
			LuaObject.checkType<Image>(l, 2, out cardIamge);
			heroHeadUIController.m_luaExportHelper.m_cardIamge = cardIamge;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1B4 RID: 127412 RVA: 0x00A24BC8 File Offset: 0x00A22DC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroHeadUIController.m_luaExportHelper.m_heroNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1B5 RID: 127413 RVA: 0x00A24C20 File Offset: 0x00A22E20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			Text heroNameText;
			LuaObject.checkType<Text>(l, 2, out heroNameText);
			heroHeadUIController.m_luaExportHelper.m_heroNameText = heroNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1B6 RID: 127414 RVA: 0x00A24C7C File Offset: 0x00A22E7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroWrap(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroHeadUIController.m_heroWrap);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1B7 RID: 127415 RVA: 0x00A24CD0 File Offset: 0x00A22ED0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroWrap(IntPtr l)
	{
		int result;
		try
		{
			HeroHeadUIController heroHeadUIController = (HeroHeadUIController)LuaObject.checkSelf(l);
			HeroArchiveUIController.HeroWrap heroWrap;
			LuaObject.checkType<HeroArchiveUIController.HeroWrap>(l, 2, out heroWrap);
			heroHeadUIController.m_heroWrap = heroWrap;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F1B8 RID: 127416 RVA: 0x00A24D28 File Offset: 0x00A22F28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroHeadUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.SetHeroWrap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.RefreshDisplay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.OnHeroHeadClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.Selected);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__callDele_OnHeroHeadClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.__clearDele_OnHeroHeadClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache13);
		string name = "OnHeroHeadClickEvent";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.set_OnHeroHeadClickEvent);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache14, true);
		string name2 = "m_heroHeadButton";
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.get_m_heroHeadButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.set_m_heroHeadButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache16, true);
		string name3 = "m_heroHeadAnimation";
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.get_m_heroHeadAnimation);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.set_m_heroHeadAnimation);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache18, true);
		string name4 = "m_selectImage";
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.get_m_selectImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.set_m_selectImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1A, true);
		string name5 = "m_cardIamge";
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.get_m_cardIamge);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.set_m_cardIamge);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1C, true);
		string name6 = "m_heroNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.get_m_heroNameText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.set_m_heroNameText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1E, true);
		string name7 = "m_heroWrap";
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.get_m_heroWrap);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroHeadUIController.set_m_heroWrap);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroHeadUIController.<>f__mg$cache20, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroHeadUIController), typeof(UIControllerBase));
	}

	// Token: 0x040151EF RID: 86511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040151F0 RID: 86512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040151F1 RID: 86513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040151F2 RID: 86514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040151F3 RID: 86515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040151F4 RID: 86516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040151F5 RID: 86517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040151F6 RID: 86518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040151F7 RID: 86519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040151F8 RID: 86520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040151F9 RID: 86521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040151FA RID: 86522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040151FB RID: 86523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040151FC RID: 86524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040151FD RID: 86525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040151FE RID: 86526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040151FF RID: 86527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015200 RID: 86528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015201 RID: 86529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015202 RID: 86530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015203 RID: 86531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015204 RID: 86532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015205 RID: 86533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015206 RID: 86534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015207 RID: 86535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015208 RID: 86536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015209 RID: 86537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401520A RID: 86538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401520B RID: 86539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401520C RID: 86540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401520D RID: 86541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401520E RID: 86542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401520F RID: 86543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;
}
