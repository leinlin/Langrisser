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

// Token: 0x020014F4 RID: 5364
[Preserve]
public class Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController : LuaObject
{
	// Token: 0x0601FB0A RID: 129802 RVA: 0x00A6FAE0 File Offset: 0x00A6DCE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitJobMaterial(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			Goods jobMaterialGood;
			LuaObject.checkType<Goods>(l, 2, out jobMaterialGood);
			jobMaterialEquipedUIController.InitJobMaterial(jobMaterialGood);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB0B RID: 129803 RVA: 0x00A6FB38 File Offset: 0x00A6DD38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			jobMaterialEquipedUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB0C RID: 129804 RVA: 0x00A6FB8C File Offset: 0x00A6DD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			jobMaterialEquipedUIController.m_luaExportHelper.OnJobMaterialClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB0D RID: 129805 RVA: 0x00A6FBE0 File Offset: 0x00A6DDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			jobMaterialEquipedUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB0E RID: 129806 RVA: 0x00A6FC4C File Offset: 0x00A6DE4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			jobMaterialEquipedUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB0F RID: 129807 RVA: 0x00A6FCA0 File Offset: 0x00A6DEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			jobMaterialEquipedUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB10 RID: 129808 RVA: 0x00A6FCF4 File Offset: 0x00A6DEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = jobMaterialEquipedUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FB11 RID: 129809 RVA: 0x00A6FD9C File Offset: 0x00A6DF9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			jobMaterialEquipedUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB12 RID: 129810 RVA: 0x00A6FDF0 File Offset: 0x00A6DFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			jobMaterialEquipedUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB13 RID: 129811 RVA: 0x00A6FE5C File Offset: 0x00A6E05C
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
				JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				jobMaterialEquipedUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				JobMaterialEquipedUIController jobMaterialEquipedUIController2 = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				jobMaterialEquipedUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FB14 RID: 129812 RVA: 0x00A6FF6C File Offset: 0x00A6E16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			jobMaterialEquipedUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB15 RID: 129813 RVA: 0x00A6FFD8 File Offset: 0x00A6E1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			jobMaterialEquipedUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB16 RID: 129814 RVA: 0x00A70044 File Offset: 0x00A6E244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			jobMaterialEquipedUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB17 RID: 129815 RVA: 0x00A700B0 File Offset: 0x00A6E2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			jobMaterialEquipedUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB18 RID: 129816 RVA: 0x00A7011C File Offset: 0x00A6E31C
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
				JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				jobMaterialEquipedUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				JobMaterialEquipedUIController jobMaterialEquipedUIController2 = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				jobMaterialEquipedUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FB19 RID: 129817 RVA: 0x00A7022C File Offset: 0x00A6E42C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			string s = jobMaterialEquipedUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FB1A RID: 129818 RVA: 0x00A70288 File Offset: 0x00A6E488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnJobMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			JobMaterialEquipedUIController obj;
			LuaObject.checkType<JobMaterialEquipedUIController>(l, 2, out obj);
			jobMaterialEquipedUIController.m_luaExportHelper.__callDele_EventOnJobMaterialClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB1B RID: 129819 RVA: 0x00A702E4 File Offset: 0x00A6E4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnJobMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			JobMaterialEquipedUIController obj;
			LuaObject.checkType<JobMaterialEquipedUIController>(l, 2, out obj);
			jobMaterialEquipedUIController.m_luaExportHelper.__clearDele_EventOnJobMaterialClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB1C RID: 129820 RVA: 0x00A70340 File Offset: 0x00A6E540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnJobMaterialClick(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			Action<JobMaterialEquipedUIController> value;
			int num = LuaObject.checkDelegate<Action<JobMaterialEquipedUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					jobMaterialEquipedUIController.EventOnJobMaterialClick += value;
				}
				else if (num == 2)
				{
					jobMaterialEquipedUIController.EventOnJobMaterialClick -= value;
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

	// Token: 0x0601FB1D RID: 129821 RVA: 0x00A703C0 File Offset: 0x00A6E5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_iconImg(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jobMaterialEquipedUIController.m_luaExportHelper.m_iconImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB1E RID: 129822 RVA: 0x00A70418 File Offset: 0x00A6E618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_iconImg(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			Image iconImg;
			LuaObject.checkType<Image>(l, 2, out iconImg);
			jobMaterialEquipedUIController.m_luaExportHelper.m_iconImg = iconImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB1F RID: 129823 RVA: 0x00A70474 File Offset: 0x00A6E674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgImg(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jobMaterialEquipedUIController.m_luaExportHelper.m_bgImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB20 RID: 129824 RVA: 0x00A704CC File Offset: 0x00A6E6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgImg(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			Image bgImg;
			LuaObject.checkType<Image>(l, 2, out bgImg);
			jobMaterialEquipedUIController.m_luaExportHelper.m_bgImg = bgImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB21 RID: 129825 RVA: 0x00A70528 File Offset: 0x00A6E728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_needCountText(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jobMaterialEquipedUIController.m_luaExportHelper.m_needCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB22 RID: 129826 RVA: 0x00A70580 File Offset: 0x00A6E780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_needCountText(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			Text needCountText;
			LuaObject.checkType<Text>(l, 2, out needCountText);
			jobMaterialEquipedUIController.m_luaExportHelper.m_needCountText = needCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB23 RID: 129827 RVA: 0x00A705DC File Offset: 0x00A6E7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_haveCountText(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jobMaterialEquipedUIController.m_luaExportHelper.m_haveCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB24 RID: 129828 RVA: 0x00A70634 File Offset: 0x00A6E834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_haveCountText(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			Text haveCountText;
			LuaObject.checkType<Text>(l, 2, out haveCountText);
			jobMaterialEquipedUIController.m_luaExportHelper.m_haveCountText = haveCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB25 RID: 129829 RVA: 0x00A70690 File Offset: 0x00A6E890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NeedCount(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jobMaterialEquipedUIController.NeedCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB26 RID: 129830 RVA: 0x00A706E4 File Offset: 0x00A6E8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NeedCount(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			int needCount;
			LuaObject.checkType(l, 2, out needCount);
			jobMaterialEquipedUIController.m_luaExportHelper.NeedCount = needCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB27 RID: 129831 RVA: 0x00A70740 File Offset: 0x00A6E940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HaveCount(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jobMaterialEquipedUIController.HaveCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB28 RID: 129832 RVA: 0x00A70794 File Offset: 0x00A6E994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HaveCount(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			int haveCount;
			LuaObject.checkType(l, 2, out haveCount);
			jobMaterialEquipedUIController.m_luaExportHelper.HaveCount = haveCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB29 RID: 129833 RVA: 0x00A707F0 File Offset: 0x00A6E9F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobMaterialInfo(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, jobMaterialEquipedUIController.JobMaterialInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB2A RID: 129834 RVA: 0x00A70844 File Offset: 0x00A6EA44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JobMaterialInfo(IntPtr l)
	{
		int result;
		try
		{
			JobMaterialEquipedUIController jobMaterialEquipedUIController = (JobMaterialEquipedUIController)LuaObject.checkSelf(l);
			ConfigDataJobMaterialInfo jobMaterialInfo;
			LuaObject.checkType<ConfigDataJobMaterialInfo>(l, 2, out jobMaterialInfo);
			jobMaterialEquipedUIController.m_luaExportHelper.JobMaterialInfo = jobMaterialInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FB2B RID: 129835 RVA: 0x00A708A0 File Offset: 0x00A6EAA0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.JobMaterialEquipedUIController");
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.InitJobMaterial);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.OnJobMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__callDele_EventOnJobMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.__clearDele_EventOnJobMaterialClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache11);
		string name = "EventOnJobMaterialClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.set_EventOnJobMaterialClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache12, true);
		string name2 = "m_iconImg";
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.get_m_iconImg);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.set_m_iconImg);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache14, true);
		string name3 = "m_bgImg";
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.get_m_bgImg);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.set_m_bgImg);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache16, true);
		string name4 = "m_needCountText";
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.get_m_needCountText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.set_m_needCountText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache18, true);
		string name5 = "m_haveCountText";
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.get_m_haveCountText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.set_m_haveCountText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1A, true);
		string name6 = "NeedCount";
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.get_NeedCount);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.set_NeedCount);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1C, true);
		string name7 = "HaveCount";
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.get_HaveCount);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.set_HaveCount);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1E, true);
		string name8 = "JobMaterialInfo";
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.get_JobMaterialInfo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.set_JobMaterialInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_JobMaterialEquipedUIController.<>f__mg$cache20, true);
		LuaObject.createTypeMetatable(l, null, typeof(JobMaterialEquipedUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015B04 RID: 88836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015B05 RID: 88837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015B06 RID: 88838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015B07 RID: 88839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015B08 RID: 88840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015B09 RID: 88841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015B0A RID: 88842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015B0B RID: 88843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015B0C RID: 88844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015B0D RID: 88845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015B0E RID: 88846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015B0F RID: 88847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015B10 RID: 88848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015B11 RID: 88849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015B12 RID: 88850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015B13 RID: 88851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015B14 RID: 88852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015B15 RID: 88853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015B16 RID: 88854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015B17 RID: 88855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015B18 RID: 88856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015B19 RID: 88857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015B1A RID: 88858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015B1B RID: 88859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015B1C RID: 88860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015B1D RID: 88861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015B1E RID: 88862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015B1F RID: 88863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015B20 RID: 88864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015B21 RID: 88865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015B22 RID: 88866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015B23 RID: 88867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015B24 RID: 88868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;
}
