using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014B8 RID: 5304
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDetailUIController : LuaObject
{
	// Token: 0x0601EF64 RID: 126820 RVA: 0x00A1259C File Offset: 0x00A1079C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PassHeroInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			List<Hero> hList;
			LuaObject.checkType<List<Hero>>(l, 2, out hList);
			int num;
			LuaObject.checkType(l, 3, out num);
			heroDetailUIController.PassHeroInfo(hList, num);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF65 RID: 126821 RVA: 0x00A12600 File Offset: 0x00A10800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInHeroDetail(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.UpdateViewInHeroDetail();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF66 RID: 126822 RVA: 0x00A1264C File Offset: 0x00A1084C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroInfoToogleIsOn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			bool b = heroDetailUIController.HeroInfoToogleIsOn();
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

	// Token: 0x0601EF67 RID: 126823 RVA: 0x00A126A0 File Offset: 0x00A108A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroJobToggleIsOn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			bool b = heroDetailUIController.HeroJobToggleIsOn();
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

	// Token: 0x0601EF68 RID: 126824 RVA: 0x00A126F4 File Offset: 0x00A108F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroEquipToggleIsOn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			bool b = heroDetailUIController.HeroEquipToggleIsOn();
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

	// Token: 0x0601EF69 RID: 126825 RVA: 0x00A12748 File Offset: 0x00A10948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToggleToInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.SetToggleToInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF6A RID: 126826 RVA: 0x00A12794 File Offset: 0x00A10994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToggleToJob(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.SetToggleToJob();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF6B RID: 126827 RVA: 0x00A127E0 File Offset: 0x00A109E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToggleToSoldier(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.SetToggleToSoldier();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF6C RID: 126828 RVA: 0x00A1282C File Offset: 0x00A10A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToggleToEquip(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.SetToggleToEquip();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF6D RID: 126829 RVA: 0x00A12878 File Offset: 0x00A10A78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetToggleToLife(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.SetToggleToLife();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF6E RID: 126830 RVA: 0x00A128C4 File Offset: 0x00A10AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic_s(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic o;
			LuaObject.checkType<UISpineGraphic>(l, 1, out o);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 3, out parent);
			int direction;
			LuaObject.checkType(l, 4, out direction);
			Vector2 offset;
			LuaObject.checkType(l, 5, out offset);
			float scale;
			LuaObject.checkType(l, 6, out scale);
			List<ReplaceAnim> anims;
			LuaObject.checkType<List<ReplaceAnim>>(l, 7, out anims);
			HeroDetailUIController.CreateSpineGraphic(ref o, assetName, parent, direction, offset, scale, anims);
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

	// Token: 0x0601EF6F RID: 126831 RVA: 0x00A12960 File Offset: 0x00A10B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic_s(IntPtr l)
	{
		int result;
		try
		{
			UISpineGraphic o;
			LuaObject.checkType<UISpineGraphic>(l, 1, out o);
			HeroDetailUIController.DestroySpineGraphic(ref o);
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

	// Token: 0x0601EF70 RID: 126832 RVA: 0x00A129B4 File Offset: 0x00A10BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF71 RID: 126833 RVA: 0x00A12A08 File Offset: 0x00A10C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF72 RID: 126834 RVA: 0x00A12A5C File Offset: 0x00A10C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLeftButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.OnLeftButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF73 RID: 126835 RVA: 0x00A12AB0 File Offset: 0x00A10CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRightButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.OnRightButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF74 RID: 126836 RVA: 0x00A12B04 File Offset: 0x00A10D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobTransferButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.OnJobTransferButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF75 RID: 126837 RVA: 0x00A12B58 File Offset: 0x00A10D58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobTransferButtonClickEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			IEnumerator o = heroDetailUIController.m_luaExportHelper.OnJobTransferButtonClickEffect();
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

	// Token: 0x0601EF76 RID: 126838 RVA: 0x00A12BB4 File Offset: 0x00A10DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMaskButtonForUserGuideClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.OnMaskButtonForUserGuideClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF77 RID: 126839 RVA: 0x00A12C08 File Offset: 0x00A10E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInfoToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			heroDetailUIController.m_luaExportHelper.OnInfoToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF78 RID: 126840 RVA: 0x00A12C64 File Offset: 0x00A10E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			heroDetailUIController.m_luaExportHelper.OnJobToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF79 RID: 126841 RVA: 0x00A12CC0 File Offset: 0x00A10EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoldierToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			heroDetailUIController.m_luaExportHelper.OnSoldierToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF7A RID: 126842 RVA: 0x00A12D1C File Offset: 0x00A10F1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEquipToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			heroDetailUIController.m_luaExportHelper.OnEquipToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF7B RID: 126843 RVA: 0x00A12D78 File Offset: 0x00A10F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLifeToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			bool on;
			LuaObject.checkType(l, 2, out on);
			heroDetailUIController.m_luaExportHelper.OnLifeToggleValueChanged(on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF7C RID: 126844 RVA: 0x00A12DD4 File Offset: 0x00A10FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroDetailUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF7D RID: 126845 RVA: 0x00A12E40 File Offset: 0x00A11040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF7E RID: 126846 RVA: 0x00A12E94 File Offset: 0x00A11094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF7F RID: 126847 RVA: 0x00A12EE8 File Offset: 0x00A110E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroDetailUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601EF80 RID: 126848 RVA: 0x00A12F90 File Offset: 0x00A11190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF81 RID: 126849 RVA: 0x00A12FE4 File Offset: 0x00A111E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroDetailUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF82 RID: 126850 RVA: 0x00A13050 File Offset: 0x00A11250
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
				HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroDetailUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroDetailUIController heroDetailUIController2 = (HeroDetailUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroDetailUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601EF83 RID: 126851 RVA: 0x00A13160 File Offset: 0x00A11360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF84 RID: 126852 RVA: 0x00A131CC File Offset: 0x00A113CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF85 RID: 126853 RVA: 0x00A13238 File Offset: 0x00A11438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF86 RID: 126854 RVA: 0x00A132A4 File Offset: 0x00A114A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF87 RID: 126855 RVA: 0x00A13310 File Offset: 0x00A11510
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
				HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroDetailUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDetailUIController heroDetailUIController2 = (HeroDetailUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroDetailUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601EF88 RID: 126856 RVA: 0x00A13420 File Offset: 0x00A11620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			string s = heroDetailUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601EF89 RID: 126857 RVA: 0x00A1347C File Offset: 0x00A1167C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF8A RID: 126858 RVA: 0x00A134D0 File Offset: 0x00A116D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF8B RID: 126859 RVA: 0x00A13524 File Offset: 0x00A11724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.__callDele_EventOnJobTransfer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF8C RID: 126860 RVA: 0x00A13578 File Offset: 0x00A11778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			heroDetailUIController.m_luaExportHelper.__clearDele_EventOnJobTransfer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF8D RID: 126861 RVA: 0x00A135CC File Offset: 0x00A117CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSetDetailState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			heroDetailUIController.m_luaExportHelper.__callDele_EventOnSetDetailState(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF8E RID: 126862 RVA: 0x00A13628 File Offset: 0x00A11828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSetDetailState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			heroDetailUIController.m_luaExportHelper.__clearDele_EventOnSetDetailState(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF8F RID: 126863 RVA: 0x00A13684 File Offset: 0x00A11884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnUpdateViewInListAndDetail(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			bool arg3;
			LuaObject.checkType(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			heroDetailUIController.m_luaExportHelper.__callDele_EventOnUpdateViewInListAndDetail(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF90 RID: 126864 RVA: 0x00A13708 File Offset: 0x00A11908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnUpdateViewInListAndDetail(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			bool arg2;
			LuaObject.checkType(l, 3, out arg2);
			bool arg3;
			LuaObject.checkType(l, 4, out arg3);
			int arg4;
			LuaObject.checkType(l, 5, out arg4);
			heroDetailUIController.m_luaExportHelper.__clearDele_EventOnUpdateViewInListAndDetail(arg, arg2, arg3, arg4);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF91 RID: 126865 RVA: 0x00A1378C File Offset: 0x00A1198C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF92 RID: 126866 RVA: 0x00A137E4 File Offset: 0x00A119E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			heroDetailUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF93 RID: 126867 RVA: 0x00A13840 File Offset: 0x00A11A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF94 RID: 126868 RVA: 0x00A13898 File Offset: 0x00A11A98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			heroDetailUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF95 RID: 126869 RVA: 0x00A138F4 File Offset: 0x00A11AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_leftButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_leftButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF96 RID: 126870 RVA: 0x00A1394C File Offset: 0x00A11B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_leftButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Button leftButton;
			LuaObject.checkType<Button>(l, 2, out leftButton);
			heroDetailUIController.m_luaExportHelper.m_leftButton = leftButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF97 RID: 126871 RVA: 0x00A139A8 File Offset: 0x00A11BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rightButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_rightButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF98 RID: 126872 RVA: 0x00A13A00 File Offset: 0x00A11C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rightButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Button rightButton;
			LuaObject.checkType<Button>(l, 2, out rightButton);
			heroDetailUIController.m_luaExportHelper.m_rightButton = rightButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF99 RID: 126873 RVA: 0x00A13A5C File Offset: 0x00A11C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_infoToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF9A RID: 126874 RVA: 0x00A13AB4 File Offset: 0x00A11CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Toggle infoToggle;
			LuaObject.checkType<Toggle>(l, 2, out infoToggle);
			heroDetailUIController.m_luaExportHelper.m_infoToggle = infoToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF9B RID: 126875 RVA: 0x00A13B10 File Offset: 0x00A11D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_jobToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF9C RID: 126876 RVA: 0x00A13B68 File Offset: 0x00A11D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Toggle jobToggle;
			LuaObject.checkType<Toggle>(l, 2, out jobToggle);
			heroDetailUIController.m_luaExportHelper.m_jobToggle = jobToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF9D RID: 126877 RVA: 0x00A13BC4 File Offset: 0x00A11DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobToggleClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_jobToggleClickRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF9E RID: 126878 RVA: 0x00A13C1C File Offset: 0x00A11E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobToggleClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			GameObject jobToggleClickRedMark;
			LuaObject.checkType<GameObject>(l, 2, out jobToggleClickRedMark);
			heroDetailUIController.m_luaExportHelper.m_jobToggleClickRedMark = jobToggleClickRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EF9F RID: 126879 RVA: 0x00A13C78 File Offset: 0x00A11E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobToggleUnClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_jobToggleUnClickRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFA0 RID: 126880 RVA: 0x00A13CD0 File Offset: 0x00A11ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobToggleUnClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			GameObject jobToggleUnClickRedMark;
			LuaObject.checkType<GameObject>(l, 2, out jobToggleUnClickRedMark);
			heroDetailUIController.m_luaExportHelper.m_jobToggleUnClickRedMark = jobToggleUnClickRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFA1 RID: 126881 RVA: 0x00A13D2C File Offset: 0x00A11F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobUpTip(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_jobUpTip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFA2 RID: 126882 RVA: 0x00A13D84 File Offset: 0x00A11F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobUpTip(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			GameObject jobUpTip;
			LuaObject.checkType<GameObject>(l, 2, out jobUpTip);
			heroDetailUIController.m_luaExportHelper.m_jobUpTip = jobUpTip;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFA3 RID: 126883 RVA: 0x00A13DE0 File Offset: 0x00A11FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_soldierToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFA4 RID: 126884 RVA: 0x00A13E38 File Offset: 0x00A12038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Toggle soldierToggle;
			LuaObject.checkType<Toggle>(l, 2, out soldierToggle);
			heroDetailUIController.m_luaExportHelper.m_soldierToggle = soldierToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFA5 RID: 126885 RVA: 0x00A13E94 File Offset: 0x00A12094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_equipToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFA6 RID: 126886 RVA: 0x00A13EEC File Offset: 0x00A120EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Toggle equipToggle;
			LuaObject.checkType<Toggle>(l, 2, out equipToggle);
			heroDetailUIController.m_luaExportHelper.m_equipToggle = equipToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFA7 RID: 126887 RVA: 0x00A13F48 File Offset: 0x00A12148
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_equipToggleClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_equipToggleClickRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFA8 RID: 126888 RVA: 0x00A13FA0 File Offset: 0x00A121A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipToggleClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			GameObject equipToggleClickRedMark;
			LuaObject.checkType<GameObject>(l, 2, out equipToggleClickRedMark);
			heroDetailUIController.m_luaExportHelper.m_equipToggleClickRedMark = equipToggleClickRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFA9 RID: 126889 RVA: 0x00A13FFC File Offset: 0x00A121FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipToggleUnClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_equipToggleUnClickRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFAA RID: 126890 RVA: 0x00A14054 File Offset: 0x00A12254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipToggleUnClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			GameObject equipToggleUnClickRedMark;
			LuaObject.checkType<GameObject>(l, 2, out equipToggleUnClickRedMark);
			heroDetailUIController.m_luaExportHelper.m_equipToggleUnClickRedMark = equipToggleUnClickRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFAB RID: 126891 RVA: 0x00A140B0 File Offset: 0x00A122B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lifeToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_lifeToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFAC RID: 126892 RVA: 0x00A14108 File Offset: 0x00A12308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lifeToggle(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Toggle lifeToggle;
			LuaObject.checkType<Toggle>(l, 2, out lifeToggle);
			heroDetailUIController.m_luaExportHelper.m_lifeToggle = lifeToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFAD RID: 126893 RVA: 0x00A14164 File Offset: 0x00A12364
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lifeToggleClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_lifeToggleClickRedMark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFAE RID: 126894 RVA: 0x00A141BC File Offset: 0x00A123BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lifeToggleClickRedMark(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			GameObject lifeToggleClickRedMark;
			LuaObject.checkType<GameObject>(l, 2, out lifeToggleClickRedMark);
			heroDetailUIController.m_luaExportHelper.m_lifeToggleClickRedMark = lifeToggleClickRedMark;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFAF RID: 126895 RVA: 0x00A14218 File Offset: 0x00A12418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_equipMaskButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_equipMaskButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFB0 RID: 126896 RVA: 0x00A14270 File Offset: 0x00A12470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_equipMaskButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Button equipMaskButton;
			LuaObject.checkType<Button>(l, 2, out equipMaskButton);
			heroDetailUIController.m_luaExportHelper.m_equipMaskButton = equipMaskButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFB1 RID: 126897 RVA: 0x00A142CC File Offset: 0x00A124CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransferButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_jobTransferButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFB2 RID: 126898 RVA: 0x00A14324 File Offset: 0x00A12524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransferButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Button jobTransferButton;
			LuaObject.checkType<Button>(l, 2, out jobTransferButton);
			heroDetailUIController.m_luaExportHelper.m_jobTransferButton = jobTransferButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFB3 RID: 126899 RVA: 0x00A14380 File Offset: 0x00A12580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransferButtonRedIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_jobTransferButtonRedIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFB4 RID: 126900 RVA: 0x00A143D8 File Offset: 0x00A125D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransferButtonRedIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			GameObject jobTransferButtonRedIcon;
			LuaObject.checkType<GameObject>(l, 2, out jobTransferButtonRedIcon);
			heroDetailUIController.m_luaExportHelper.m_jobTransferButtonRedIcon = jobTransferButtonRedIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFB5 RID: 126901 RVA: 0x00A14434 File Offset: 0x00A12634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransferButtonPressEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_jobTransferButtonPressEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFB6 RID: 126902 RVA: 0x00A1448C File Offset: 0x00A1268C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransferButtonPressEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			GameObject jobTransferButtonPressEffect;
			LuaObject.checkType<GameObject>(l, 2, out jobTransferButtonPressEffect);
			heroDetailUIController.m_luaExportHelper.m_jobTransferButtonPressEffect = jobTransferButtonPressEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFB7 RID: 126903 RVA: 0x00A144E8 File Offset: 0x00A126E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobTransferButtonReadyEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_jobTransferButtonReadyEffect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFB8 RID: 126904 RVA: 0x00A14540 File Offset: 0x00A12740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobTransferButtonReadyEffect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			GameObject jobTransferButtonReadyEffect;
			LuaObject.checkType<GameObject>(l, 2, out jobTransferButtonReadyEffect);
			heroDetailUIController.m_luaExportHelper.m_jobTransferButtonReadyEffect = jobTransferButtonReadyEffect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFB9 RID: 126905 RVA: 0x00A1459C File Offset: 0x00A1279C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroDetailUIController.EventOnReturn -= value;
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

	// Token: 0x0601EFBA RID: 126906 RVA: 0x00A1461C File Offset: 0x00A1281C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnJobTransfer(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailUIController.EventOnJobTransfer += value;
				}
				else if (num == 2)
				{
					heroDetailUIController.EventOnJobTransfer -= value;
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

	// Token: 0x0601EFBB RID: 126907 RVA: 0x00A1469C File Offset: 0x00A1289C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSetDetailState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailUIController.EventOnSetDetailState += value;
				}
				else if (num == 2)
				{
					heroDetailUIController.EventOnSetDetailState -= value;
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

	// Token: 0x0601EFBC RID: 126908 RVA: 0x00A1471C File Offset: 0x00A1291C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnUpdateViewInListAndDetail(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Action<int, bool, bool, int> value;
			int num = LuaObject.checkDelegate<Action<int, bool, bool, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailUIController.EventOnUpdateViewInListAndDetail += value;
				}
				else if (num == 2)
				{
					heroDetailUIController.EventOnUpdateViewInListAndDetail -= value;
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

	// Token: 0x0601EFBD RID: 126909 RVA: 0x00A1479C File Offset: 0x00A1299C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFBE RID: 126910 RVA: 0x00A147F4 File Offset: 0x00A129F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFBF RID: 126911 RVA: 0x00A14850 File Offset: 0x00A12A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curHeroNum(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_curHeroNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFC0 RID: 126912 RVA: 0x00A148A4 File Offset: 0x00A12AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curHeroNum(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			int curHeroNum;
			LuaObject.checkType(l, 2, out curHeroNum);
			heroDetailUIController.m_curHeroNum = curHeroNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFC1 RID: 126913 RVA: 0x00A148FC File Offset: 0x00A12AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_curHeroList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFC2 RID: 126914 RVA: 0x00A14950 File Offset: 0x00A12B50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curHeroList(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			List<Hero> curHeroList;
			LuaObject.checkType<List<Hero>>(l, 2, out curHeroList);
			heroDetailUIController.m_curHeroList = curHeroList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFC3 RID: 126915 RVA: 0x00A149A8 File Offset: 0x00A12BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFC4 RID: 126916 RVA: 0x00A14A00 File Offset: 0x00A12C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroDetailUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFC5 RID: 126917 RVA: 0x00A14A5C File Offset: 0x00A12C5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFC6 RID: 126918 RVA: 0x00A14AB4 File Offset: 0x00A12CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailUIController heroDetailUIController = (HeroDetailUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDetailUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601EFC7 RID: 126919 RVA: 0x00A14B10 File Offset: 0x00A12D10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDetailUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.PassHeroInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.UpdateViewInHeroDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.HeroInfoToogleIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.HeroJobToggleIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.HeroEquipToggleIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.SetToggleToInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.SetToggleToJob);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.SetToggleToSoldier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.SetToggleToEquip);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.SetToggleToLife);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.CreateSpineGraphic_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.DestroySpineGraphic_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnLeftButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnRightButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnJobTransferButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnJobTransferButtonClickEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnMaskButtonForUserGuideClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnInfoToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnJobToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnSoldierToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnEquipToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.OnLifeToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callDele_EventOnJobTransfer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__clearDele_EventOnJobTransfer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callDele_EventOnSetDetailState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__clearDele_EventOnSetDetailState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__callDele_EventOnUpdateViewInListAndDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.__clearDele_EventOnUpdateViewInListAndDetail);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2C);
		string name = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_marginTransform);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2E, true);
		string name2 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_returnButton);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache30, true);
		string name3 = "m_leftButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_leftButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_leftButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache32, true);
		string name4 = "m_rightButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_rightButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_rightButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache34, true);
		string name5 = "m_infoToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_infoToggle);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_infoToggle);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache36, true);
		string name6 = "m_jobToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_jobToggle);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_jobToggle);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache38, true);
		string name7 = "m_jobToggleClickRedMark";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_jobToggleClickRedMark);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_jobToggleClickRedMark);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3A, true);
		string name8 = "m_jobToggleUnClickRedMark";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_jobToggleUnClickRedMark);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_jobToggleUnClickRedMark);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3C, true);
		string name9 = "m_jobUpTip";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_jobUpTip);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_jobUpTip);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3E, true);
		string name10 = "m_soldierToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_soldierToggle);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_soldierToggle);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache40, true);
		string name11 = "m_equipToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_equipToggle);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_equipToggle);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache42, true);
		string name12 = "m_equipToggleClickRedMark";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_equipToggleClickRedMark);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_equipToggleClickRedMark);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache44, true);
		string name13 = "m_equipToggleUnClickRedMark";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_equipToggleUnClickRedMark);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_equipToggleUnClickRedMark);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache46, true);
		string name14 = "m_lifeToggle";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_lifeToggle);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_lifeToggle);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache48, true);
		string name15 = "m_lifeToggleClickRedMark";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_lifeToggleClickRedMark);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_lifeToggleClickRedMark);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4A, true);
		string name16 = "m_equipMaskButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_equipMaskButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_equipMaskButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4C, true);
		string name17 = "m_jobTransferButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_jobTransferButton);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_jobTransferButton);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4E, true);
		string name18 = "m_jobTransferButtonRedIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_jobTransferButtonRedIcon);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_jobTransferButtonRedIcon);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache50, true);
		string name19 = "m_jobTransferButtonPressEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_jobTransferButtonPressEffect);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_jobTransferButtonPressEffect);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache52, true);
		string name20 = "m_jobTransferButtonReadyEffect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_jobTransferButtonReadyEffect);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_jobTransferButtonReadyEffect);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache54, true);
		string name21 = "EventOnReturn";
		LuaCSFunction get21 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache55, true);
		string name22 = "EventOnJobTransfer";
		LuaCSFunction get22 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_EventOnJobTransfer);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache56, true);
		string name23 = "EventOnSetDetailState";
		LuaCSFunction get23 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_EventOnSetDetailState);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache57, true);
		string name24 = "EventOnUpdateViewInListAndDetail";
		LuaCSFunction get24 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_EventOnUpdateViewInListAndDetail);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache58, true);
		string name25 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_hero);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_hero);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5A, true);
		string name26 = "m_curHeroNum";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_curHeroNum);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_curHeroNum);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5C, true);
		string name27 = "m_curHeroList";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_curHeroList);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_curHeroList);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5E, true);
		string name28 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_playerContext);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache60, true);
		string name29 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.get_m_configDataLoader);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroDetailUIController.<>f__mg$cache62, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroDetailUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014FD6 RID: 85974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014FD7 RID: 85975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014FD8 RID: 85976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014FD9 RID: 85977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014FDA RID: 85978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014FDB RID: 85979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014FDC RID: 85980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014FDD RID: 85981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014FDE RID: 85982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014FDF RID: 85983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014FE0 RID: 85984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014FE1 RID: 85985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014FE2 RID: 85986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014FE3 RID: 85987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014FE4 RID: 85988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014FE5 RID: 85989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014FE6 RID: 85990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014FE7 RID: 85991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014FE8 RID: 85992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014FE9 RID: 85993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014FEA RID: 85994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014FEB RID: 85995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014FEC RID: 85996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014FED RID: 85997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014FEE RID: 85998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014FEF RID: 85999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014FF0 RID: 86000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014FF1 RID: 86001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014FF2 RID: 86002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014FF3 RID: 86003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014FF4 RID: 86004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014FF5 RID: 86005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014FF6 RID: 86006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014FF7 RID: 86007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014FF8 RID: 86008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014FF9 RID: 86009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014FFA RID: 86010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014FFB RID: 86011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014FFC RID: 86012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014FFD RID: 86013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014FFE RID: 86014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014FFF RID: 86015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015000 RID: 86016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015001 RID: 86017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015002 RID: 86018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015003 RID: 86019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04015004 RID: 86020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04015005 RID: 86021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04015006 RID: 86022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04015007 RID: 86023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04015008 RID: 86024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04015009 RID: 86025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401500A RID: 86026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401500B RID: 86027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401500C RID: 86028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401500D RID: 86029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401500E RID: 86030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401500F RID: 86031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04015010 RID: 86032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04015011 RID: 86033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04015012 RID: 86034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04015013 RID: 86035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04015014 RID: 86036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04015015 RID: 86037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04015016 RID: 86038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04015017 RID: 86039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04015018 RID: 86040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04015019 RID: 86041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401501A RID: 86042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401501B RID: 86043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401501C RID: 86044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401501D RID: 86045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401501E RID: 86046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401501F RID: 86047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04015020 RID: 86048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04015021 RID: 86049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04015022 RID: 86050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04015023 RID: 86051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04015024 RID: 86052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04015025 RID: 86053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04015026 RID: 86054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04015027 RID: 86055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04015028 RID: 86056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04015029 RID: 86057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401502A RID: 86058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401502B RID: 86059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401502C RID: 86060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401502D RID: 86061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401502E RID: 86062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401502F RID: 86063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04015030 RID: 86064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04015031 RID: 86065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04015032 RID: 86066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04015033 RID: 86067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04015034 RID: 86068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04015035 RID: 86069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04015036 RID: 86070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04015037 RID: 86071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04015038 RID: 86072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;
}
