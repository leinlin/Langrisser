using System;
using System.Collections.Generic;
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

// Token: 0x0200157E RID: 5502
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SoldierDescUIController : LuaObject
{
	// Token: 0x0602118A RID: 135562 RVA: 0x00B22B08 File Offset: 0x00B20D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSoldierDesc(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
				ConfigDataSoldierInfo soldierInfo;
				LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
				Hero hero;
				LuaObject.checkType<Hero>(l, 3, out hero);
				soldierDescUIController.InitSoldierDesc(soldierInfo, hero);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				SoldierDescUIController soldierDescUIController2 = (SoldierDescUIController)LuaObject.checkSelf(l);
				ConfigDataSoldierInfo soldierInfo2;
				LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo2);
				BattleHero hero2;
				LuaObject.checkType<BattleHero>(l, 3, out hero2);
				List<TrainingTech> techs;
				LuaObject.checkType<List<TrainingTech>>(l, 4, out techs);
				ConfigDataModelSkinResourceInfo soldierSkinResInfo;
				LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 5, out soldierSkinResInfo);
				soldierDescUIController2.InitSoldierDesc(soldierInfo2, hero2, techs, soldierSkinResInfo);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function InitSoldierDesc to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602118B RID: 135563 RVA: 0x00B22BF4 File Offset: 0x00B20DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			soldierDescUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602118C RID: 135564 RVA: 0x00B22C48 File Offset: 0x00B20E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSoldierDetailPanel(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			HeroPropertyComputer computer;
			LuaObject.checkType<HeroPropertyComputer>(l, 3, out computer);
			string assetName;
			LuaObject.checkType(l, 4, out assetName);
			soldierDescUIController.m_luaExportHelper.SetSoldierDetailPanel(soldierInfo, computer, assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602118D RID: 135565 RVA: 0x00B22CC0 File Offset: 0x00B20EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalcPropValue(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			int v;
			LuaObject.checkType(l, 2, out v);
			int v2;
			LuaObject.checkType(l, 3, out v2);
			bool isAdd;
			LuaObject.checkType(l, 4, out isAdd);
			string s = soldierDescUIController.m_luaExportHelper.CalcPropValue(v, v2, isAdd);
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

	// Token: 0x0602118E RID: 135566 RVA: 0x00B22D44 File Offset: 0x00B20F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPanel(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			soldierDescUIController.m_luaExportHelper.ShowPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602118F RID: 135567 RVA: 0x00B22D98 File Offset: 0x00B20F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosePanel(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			soldierDescUIController.m_luaExportHelper.ClosePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021190 RID: 135568 RVA: 0x00B22DEC File Offset: 0x00B20FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			float scale;
			LuaObject.checkType(l, 3, out scale);
			Vector2 offset;
			LuaObject.checkType(l, 4, out offset);
			int team;
			LuaObject.checkType(l, 5, out team);
			GameObject parent;
			LuaObject.checkType<GameObject>(l, 6, out parent);
			List<ReplaceAnim> replaceAnims;
			LuaObject.checkType<List<ReplaceAnim>>(l, 7, out replaceAnims);
			UISpineGraphic o = soldierDescUIController.m_luaExportHelper.CreateSpineGraphic(assetName, scale, offset, team, parent, replaceAnims);
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

	// Token: 0x06021191 RID: 135569 RVA: 0x00B22E94 File Offset: 0x00B21094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			UISpineGraphic g;
			LuaObject.checkType<UISpineGraphic>(l, 2, out g);
			soldierDescUIController.m_luaExportHelper.DestroySpineGraphic(g);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021192 RID: 135570 RVA: 0x00B22EF0 File Offset: 0x00B210F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			soldierDescUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021193 RID: 135571 RVA: 0x00B22F5C File Offset: 0x00B2115C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			soldierDescUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021194 RID: 135572 RVA: 0x00B22FB0 File Offset: 0x00B211B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			soldierDescUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021195 RID: 135573 RVA: 0x00B23004 File Offset: 0x00B21204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = soldierDescUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021196 RID: 135574 RVA: 0x00B230AC File Offset: 0x00B212AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			soldierDescUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021197 RID: 135575 RVA: 0x00B23100 File Offset: 0x00B21300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			soldierDescUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021198 RID: 135576 RVA: 0x00B2316C File Offset: 0x00B2136C
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
				SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				soldierDescUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SoldierDescUIController soldierDescUIController2 = (SoldierDescUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				soldierDescUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021199 RID: 135577 RVA: 0x00B2327C File Offset: 0x00B2147C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierDescUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602119A RID: 135578 RVA: 0x00B232E8 File Offset: 0x00B214E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierDescUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602119B RID: 135579 RVA: 0x00B23354 File Offset: 0x00B21554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierDescUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602119C RID: 135580 RVA: 0x00B233C0 File Offset: 0x00B215C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			soldierDescUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602119D RID: 135581 RVA: 0x00B2342C File Offset: 0x00B2162C
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
				SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				soldierDescUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SoldierDescUIController soldierDescUIController2 = (SoldierDescUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				soldierDescUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602119E RID: 135582 RVA: 0x00B2353C File Offset: 0x00B2173C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			string s = soldierDescUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602119F RID: 135583 RVA: 0x00B23598 File Offset: 0x00B21798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			soldierDescUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211A0 RID: 135584 RVA: 0x00B235EC File Offset: 0x00B217EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			soldierDescUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211A1 RID: 135585 RVA: 0x00B23640 File Offset: 0x00B21840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					soldierDescUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					soldierDescUIController.EventOnClose -= value;
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

	// Token: 0x060211A2 RID: 135586 RVA: 0x00B236C0 File Offset: 0x00B218C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierIconImg(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierIconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211A3 RID: 135587 RVA: 0x00B23718 File Offset: 0x00B21918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierIconImg(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Image soldierIconImg;
			LuaObject.checkType<Image>(l, 2, out soldierIconImg);
			soldierDescUIController.m_luaExportHelper.m_soldierIconImg = soldierIconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211A4 RID: 135588 RVA: 0x00B23774 File Offset: 0x00B21974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDetailGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierDetailGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211A5 RID: 135589 RVA: 0x00B237CC File Offset: 0x00B219CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDetailGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			GameObject soldierDetailGraphic;
			LuaObject.checkType<GameObject>(l, 2, out soldierDetailGraphic);
			soldierDescUIController.m_luaExportHelper.m_soldierDetailGraphic = soldierDetailGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211A6 RID: 135590 RVA: 0x00B23828 File Offset: 0x00B21A28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierRangeText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierRangeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211A7 RID: 135591 RVA: 0x00B23880 File Offset: 0x00B21A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierRangeText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierRangeText;
			LuaObject.checkType<Text>(l, 2, out soldierRangeText);
			soldierDescUIController.m_luaExportHelper.m_soldierRangeText = soldierRangeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211A8 RID: 135592 RVA: 0x00B238DC File Offset: 0x00B21ADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierMoveText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierMoveText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211A9 RID: 135593 RVA: 0x00B23934 File Offset: 0x00B21B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierMoveText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierMoveText;
			LuaObject.checkType<Text>(l, 2, out soldierMoveText);
			soldierDescUIController.m_luaExportHelper.m_soldierMoveText = soldierMoveText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211AA RID: 135594 RVA: 0x00B23990 File Offset: 0x00B21B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_typeBgImg(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_typeBgImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211AB RID: 135595 RVA: 0x00B239E8 File Offset: 0x00B21BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_typeBgImg(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Image typeBgImg;
			LuaObject.checkType<Image>(l, 2, out typeBgImg);
			soldierDescUIController.m_luaExportHelper.m_typeBgImg = typeBgImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211AC RID: 135596 RVA: 0x00B23A44 File Offset: 0x00B21C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_typeBgImg2(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_typeBgImg2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211AD RID: 135597 RVA: 0x00B23A9C File Offset: 0x00B21C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_typeBgImg2(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Image typeBgImg;
			LuaObject.checkType<Image>(l, 2, out typeBgImg);
			soldierDescUIController.m_luaExportHelper.m_typeBgImg2 = typeBgImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211AE RID: 135598 RVA: 0x00B23AF8 File Offset: 0x00B21CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierTitleText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211AF RID: 135599 RVA: 0x00B23B50 File Offset: 0x00B21D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierTitleText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierTitleText;
			LuaObject.checkType<Text>(l, 2, out soldierTitleText);
			soldierDescUIController.m_luaExportHelper.m_soldierTitleText = soldierTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211B0 RID: 135600 RVA: 0x00B23BAC File Offset: 0x00B21DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierDescText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211B1 RID: 135601 RVA: 0x00B23C04 File Offset: 0x00B21E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierDescText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierDescText;
			LuaObject.checkType<Text>(l, 2, out soldierDescText);
			soldierDescUIController.m_luaExportHelper.m_soldierDescText = soldierDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211B2 RID: 135602 RVA: 0x00B23C60 File Offset: 0x00B21E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierWeakText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierWeakText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211B3 RID: 135603 RVA: 0x00B23CB8 File Offset: 0x00B21EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierWeakText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierWeakText;
			LuaObject.checkType<Text>(l, 2, out soldierWeakText);
			soldierDescUIController.m_luaExportHelper.m_soldierWeakText = soldierWeakText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211B4 RID: 135604 RVA: 0x00B23D14 File Offset: 0x00B21F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierStrongText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierStrongText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211B5 RID: 135605 RVA: 0x00B23D6C File Offset: 0x00B21F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierStrongText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierStrongText;
			LuaObject.checkType<Text>(l, 2, out soldierStrongText);
			soldierDescUIController.m_luaExportHelper.m_soldierStrongText = soldierStrongText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211B6 RID: 135606 RVA: 0x00B23DC8 File Offset: 0x00B21FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierPropHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211B7 RID: 135607 RVA: 0x00B23E20 File Offset: 0x00B22020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierPropHPValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropHPValueText);
			soldierDescUIController.m_luaExportHelper.m_soldierPropHPValueText = soldierPropHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211B8 RID: 135608 RVA: 0x00B23E7C File Offset: 0x00B2207C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierPropDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211B9 RID: 135609 RVA: 0x00B23ED4 File Offset: 0x00B220D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierPropDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropDFValueText);
			soldierDescUIController.m_luaExportHelper.m_soldierPropDFValueText = soldierPropDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211BA RID: 135610 RVA: 0x00B23F30 File Offset: 0x00B22130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierPropATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211BB RID: 135611 RVA: 0x00B23F88 File Offset: 0x00B22188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierPropATValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropATValueText);
			soldierDescUIController.m_luaExportHelper.m_soldierPropATValueText = soldierPropATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211BC RID: 135612 RVA: 0x00B23FE4 File Offset: 0x00B221E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierPropMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211BD RID: 135613 RVA: 0x00B2403C File Offset: 0x00B2223C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierPropMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out soldierPropMagicDFValueText);
			soldierDescUIController.m_luaExportHelper.m_soldierPropMagicDFValueText = soldierPropMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211BE RID: 135614 RVA: 0x00B24098 File Offset: 0x00B22298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropHPAddText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierPropHPAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211BF RID: 135615 RVA: 0x00B240F0 File Offset: 0x00B222F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropHPAddText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierPropHPAddText;
			LuaObject.checkType<Text>(l, 2, out soldierPropHPAddText);
			soldierDescUIController.m_luaExportHelper.m_soldierPropHPAddText = soldierPropHPAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211C0 RID: 135616 RVA: 0x00B2414C File Offset: 0x00B2234C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropDFAddText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierPropDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211C1 RID: 135617 RVA: 0x00B241A4 File Offset: 0x00B223A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropDFAddText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierPropDFAddText;
			LuaObject.checkType<Text>(l, 2, out soldierPropDFAddText);
			soldierDescUIController.m_luaExportHelper.m_soldierPropDFAddText = soldierPropDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211C2 RID: 135618 RVA: 0x00B24200 File Offset: 0x00B22400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropATAddText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierPropATAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211C3 RID: 135619 RVA: 0x00B24258 File Offset: 0x00B22458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropATAddText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierPropATAddText;
			LuaObject.checkType<Text>(l, 2, out soldierPropATAddText);
			soldierDescUIController.m_luaExportHelper.m_soldierPropATAddText = soldierPropATAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211C4 RID: 135620 RVA: 0x00B242B4 File Offset: 0x00B224B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierPropMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierPropMagicDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211C5 RID: 135621 RVA: 0x00B2430C File Offset: 0x00B2250C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierPropMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			Text soldierPropMagicDFAddText;
			LuaObject.checkType<Text>(l, 2, out soldierPropMagicDFAddText);
			soldierDescUIController.m_luaExportHelper.m_soldierPropMagicDFAddText = soldierPropMagicDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211C6 RID: 135622 RVA: 0x00B24368 File Offset: 0x00B22568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, soldierDescUIController.m_luaExportHelper.m_soldierGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211C7 RID: 135623 RVA: 0x00B243C0 File Offset: 0x00B225C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soldierGraphic(IntPtr l)
	{
		int result;
		try
		{
			SoldierDescUIController soldierDescUIController = (SoldierDescUIController)LuaObject.checkSelf(l);
			UISpineGraphic soldierGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out soldierGraphic);
			soldierDescUIController.m_luaExportHelper.m_soldierGraphic = soldierGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060211C8 RID: 135624 RVA: 0x00B2441C File Offset: 0x00B2261C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SoldierDescUIController");
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.InitSoldierDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.SetSoldierDetailPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.CalcPropValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.ShowPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.ClosePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache16);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache17, true);
		string name2 = "m_soldierIconImg";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierIconImg);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierIconImg);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache19, true);
		string name3 = "m_soldierDetailGraphic";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierDetailGraphic);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierDetailGraphic);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1B, true);
		string name4 = "m_soldierRangeText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierRangeText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierRangeText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1D, true);
		string name5 = "m_soldierMoveText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierMoveText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierMoveText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache1F, true);
		string name6 = "m_typeBgImg";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_typeBgImg);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_typeBgImg);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache21, true);
		string name7 = "m_typeBgImg2";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_typeBgImg2);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_typeBgImg2);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache23, true);
		string name8 = "m_soldierTitleText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierTitleText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierTitleText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache25, true);
		string name9 = "m_soldierDescText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierDescText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierDescText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache27, true);
		string name10 = "m_soldierWeakText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierWeakText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierWeakText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache29, true);
		string name11 = "m_soldierStrongText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierStrongText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierStrongText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2B, true);
		string name12 = "m_soldierPropHPValueText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierPropHPValueText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierPropHPValueText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2D, true);
		string name13 = "m_soldierPropDFValueText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierPropDFValueText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierPropDFValueText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache2F, true);
		string name14 = "m_soldierPropATValueText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierPropATValueText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierPropATValueText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache31, true);
		string name15 = "m_soldierPropMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierPropMagicDFValueText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierPropMagicDFValueText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache33, true);
		string name16 = "m_soldierPropHPAddText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierPropHPAddText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierPropHPAddText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache35, true);
		string name17 = "m_soldierPropDFAddText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierPropDFAddText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierPropDFAddText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache37, true);
		string name18 = "m_soldierPropATAddText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierPropATAddText);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierPropATAddText);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache39, true);
		string name19 = "m_soldierPropMagicDFAddText";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierPropMagicDFAddText);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierPropMagicDFAddText);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3B, true);
		string name20 = "m_soldierGraphic";
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.get_m_soldierGraphic);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SoldierDescUIController.set_m_soldierGraphic);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_SoldierDescUIController.<>f__mg$cache3D, true);
		LuaObject.createTypeMetatable(l, null, typeof(SoldierDescUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017070 RID: 94320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017071 RID: 94321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017072 RID: 94322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017073 RID: 94323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017074 RID: 94324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017075 RID: 94325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017076 RID: 94326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017077 RID: 94327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017078 RID: 94328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017079 RID: 94329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401707A RID: 94330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401707B RID: 94331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401707C RID: 94332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401707D RID: 94333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401707E RID: 94334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401707F RID: 94335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017080 RID: 94336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017081 RID: 94337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017082 RID: 94338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017083 RID: 94339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017084 RID: 94340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017085 RID: 94341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017086 RID: 94342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017087 RID: 94343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017088 RID: 94344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017089 RID: 94345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401708A RID: 94346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0401708B RID: 94347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401708C RID: 94348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401708D RID: 94349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401708E RID: 94350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401708F RID: 94351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017090 RID: 94352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017091 RID: 94353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017092 RID: 94354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017093 RID: 94355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017094 RID: 94356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017095 RID: 94357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017096 RID: 94358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017097 RID: 94359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017098 RID: 94360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017099 RID: 94361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0401709A RID: 94362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0401709B RID: 94363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401709C RID: 94364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401709D RID: 94365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401709E RID: 94366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401709F RID: 94367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040170A0 RID: 94368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040170A1 RID: 94369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040170A2 RID: 94370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040170A3 RID: 94371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040170A4 RID: 94372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040170A5 RID: 94373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040170A6 RID: 94374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040170A7 RID: 94375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040170A8 RID: 94376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040170A9 RID: 94377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040170AA RID: 94378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040170AB RID: 94379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040170AC RID: 94380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040170AD RID: 94381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;
}
