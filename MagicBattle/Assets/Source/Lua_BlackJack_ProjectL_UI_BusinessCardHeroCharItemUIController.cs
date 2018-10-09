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

// Token: 0x020013D6 RID: 5078
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController : LuaObject
{
	// Token: 0x0601C657 RID: 116311 RVA: 0x008CC6A0 File Offset: 0x008CA8A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeroCharItem(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			BattleHero battleHero;
			LuaObject.checkType<BattleHero>(l, 2, out battleHero);
			int positionIndex;
			LuaObject.checkType(l, 3, out positionIndex);
			businessCardHeroCharItemUIController.SetHeroCharItem(battleHero, positionIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C658 RID: 116312 RVA: 0x008CC704 File Offset: 0x008CA904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNoHeroChar(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			int positionIndex;
			LuaObject.checkType(l, 2, out positionIndex);
			bool isMe;
			LuaObject.checkType(l, 3, out isMe);
			businessCardHeroCharItemUIController.SetNoHeroChar(positionIndex, isMe);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C659 RID: 116313 RVA: 0x008CC768 File Offset: 0x008CA968
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBattleHero(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			BattleHero battleHero = businessCardHeroCharItemUIController.GetBattleHero();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C65A RID: 116314 RVA: 0x008CC7BC File Offset: 0x008CA9BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPositionIndex(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			int positionIndex = businessCardHeroCharItemUIController.GetPositionIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, positionIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C65B RID: 116315 RVA: 0x008CC810 File Offset: 0x008CAA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEmpty(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			bool b = businessCardHeroCharItemUIController.IsEmpty();
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

	// Token: 0x0601C65C RID: 116316 RVA: 0x008CC864 File Offset: 0x008CAA64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			businessCardHeroCharItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C65D RID: 116317 RVA: 0x008CC8B8 File Offset: 0x008CAAB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			businessCardHeroCharItemUIController.m_luaExportHelper.OnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C65E RID: 116318 RVA: 0x008CC90C File Offset: 0x008CAB0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C65F RID: 116319 RVA: 0x008CC978 File Offset: 0x008CAB78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C660 RID: 116320 RVA: 0x008CC9CC File Offset: 0x008CABCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C661 RID: 116321 RVA: 0x008CCA20 File Offset: 0x008CAC20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601C662 RID: 116322 RVA: 0x008CCAC8 File Offset: 0x008CACC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C663 RID: 116323 RVA: 0x008CCB1C File Offset: 0x008CAD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C664 RID: 116324 RVA: 0x008CCB88 File Offset: 0x008CAD88
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
				BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController2 = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				businessCardHeroCharItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601C665 RID: 116325 RVA: 0x008CCC98 File Offset: 0x008CAE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C666 RID: 116326 RVA: 0x008CCD04 File Offset: 0x008CAF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C667 RID: 116327 RVA: 0x008CCD70 File Offset: 0x008CAF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C668 RID: 116328 RVA: 0x008CCDDC File Offset: 0x008CAFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C669 RID: 116329 RVA: 0x008CCE48 File Offset: 0x008CB048
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
				BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController2 = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				businessCardHeroCharItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601C66A RID: 116330 RVA: 0x008CCF58 File Offset: 0x008CB158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			string s = businessCardHeroCharItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601C66B RID: 116331 RVA: 0x008CCFB4 File Offset: 0x008CB1B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			BusinessCardHeroCharItemUIController obj;
			LuaObject.checkType<BusinessCardHeroCharItemUIController>(l, 2, out obj);
			businessCardHeroCharItemUIController.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C66C RID: 116332 RVA: 0x008CD010 File Offset: 0x008CB210
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			BusinessCardHeroCharItemUIController obj;
			LuaObject.checkType<BusinessCardHeroCharItemUIController>(l, 2, out obj);
			businessCardHeroCharItemUIController.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C66D RID: 116333 RVA: 0x008CD06C File Offset: 0x008CB26C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_itemButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroCharItemUIController.m_luaExportHelper.m_itemButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C66E RID: 116334 RVA: 0x008CD0C4 File Offset: 0x008CB2C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_itemButton(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			Button itemButton;
			LuaObject.checkType<Button>(l, 2, out itemButton);
			businessCardHeroCharItemUIController.m_luaExportHelper.m_itemButton = itemButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C66F RID: 116335 RVA: 0x008CD120 File Offset: 0x008CB320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_emptyGameObject(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroCharItemUIController.m_luaExportHelper.m_emptyGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C670 RID: 116336 RVA: 0x008CD178 File Offset: 0x008CB378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_emptyGameObject(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			GameObject emptyGameObject;
			LuaObject.checkType<GameObject>(l, 2, out emptyGameObject);
			businessCardHeroCharItemUIController.m_luaExportHelper.m_emptyGameObject = emptyGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C671 RID: 116337 RVA: 0x008CD1D4 File Offset: 0x008CB3D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			Action<BusinessCardHeroCharItemUIController> value;
			int num = LuaObject.checkDelegate<Action<BusinessCardHeroCharItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					businessCardHeroCharItemUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					businessCardHeroCharItemUIController.EventOnClick -= value;
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

	// Token: 0x0601C672 RID: 116338 RVA: 0x008CD254 File Offset: 0x008CB454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_positionIndex(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroCharItemUIController.m_luaExportHelper.m_positionIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C673 RID: 116339 RVA: 0x008CD2AC File Offset: 0x008CB4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_positionIndex(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			int positionIndex;
			LuaObject.checkType(l, 2, out positionIndex);
			businessCardHeroCharItemUIController.m_luaExportHelper.m_positionIndex = positionIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C674 RID: 116340 RVA: 0x008CD308 File Offset: 0x008CB508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleHero(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardHeroCharItemUIController.m_luaExportHelper.m_battleHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C675 RID: 116341 RVA: 0x008CD360 File Offset: 0x008CB560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleHero(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardHeroCharItemUIController businessCardHeroCharItemUIController = (BusinessCardHeroCharItemUIController)LuaObject.checkSelf(l);
			BattleHero battleHero;
			LuaObject.checkType<BattleHero>(l, 2, out battleHero);
			businessCardHeroCharItemUIController.m_luaExportHelper.m_battleHero = battleHero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C676 RID: 116342 RVA: 0x008CD3BC File Offset: 0x008CB5BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BusinessCardHeroCharItemUIController");
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.SetHeroCharItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.SetNoHeroChar);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.GetBattleHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.GetPositionIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.IsEmpty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache15);
		string name = "m_itemButton";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.get_m_itemButton);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.set_m_itemButton);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache17, true);
		string name2 = "m_emptyGameObject";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.get_m_emptyGameObject);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.set_m_emptyGameObject);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache19, true);
		string name3 = "EventOnClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1A, true);
		string name4 = "m_positionIndex";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.get_m_positionIndex);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.set_m_positionIndex);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1C, true);
		string name5 = "m_battleHero";
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.get_m_battleHero);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.set_m_battleHero);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BusinessCardHeroCharItemUIController.<>f__mg$cache1E, true);
		LuaObject.createTypeMetatable(l, null, typeof(BusinessCardHeroCharItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401288D RID: 75917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401288E RID: 75918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401288F RID: 75919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04012890 RID: 75920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04012891 RID: 75921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04012892 RID: 75922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04012893 RID: 75923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04012894 RID: 75924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04012895 RID: 75925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04012896 RID: 75926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04012897 RID: 75927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04012898 RID: 75928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04012899 RID: 75929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401289A RID: 75930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401289B RID: 75931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401289C RID: 75932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401289D RID: 75933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401289E RID: 75934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401289F RID: 75935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040128A0 RID: 75936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040128A1 RID: 75937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040128A2 RID: 75938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040128A3 RID: 75939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040128A4 RID: 75940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040128A5 RID: 75941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040128A6 RID: 75942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040128A7 RID: 75943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040128A8 RID: 75944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040128A9 RID: 75945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040128AA RID: 75946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040128AB RID: 75947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;
}
