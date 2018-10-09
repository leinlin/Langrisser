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

// Token: 0x0200155F RID: 5471
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftChapterButton : LuaObject
{
	// Token: 0x06020BC3 RID: 134083 RVA: 0x00AF443C File Offset: 0x00AF263C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapter;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapter);
			riftChapterButton.SetChapter(chapter);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BC4 RID: 134084 RVA: 0x00AF4494 File Offset: 0x00AF2694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIndex(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			riftChapterButton.SetIndex(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BC5 RID: 134085 RVA: 0x00AF44EC File Offset: 0x00AF26EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndex(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			int index = riftChapterButton.GetIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BC6 RID: 134086 RVA: 0x00AF4540 File Offset: 0x00AF2740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetChapter(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapter = riftChapterButton.GetChapter();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, chapter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BC7 RID: 134087 RVA: 0x00AF4594 File Offset: 0x00AF2794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStatus(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			bool isLocked;
			LuaObject.checkType(l, 2, out isLocked);
			bool isNew;
			LuaObject.checkType(l, 3, out isNew);
			bool isCenter;
			LuaObject.checkType(l, 4, out isCenter);
			riftChapterButton.SetStatus(isLocked, isNew, isCenter);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BC8 RID: 134088 RVA: 0x00AF4608 File Offset: 0x00AF2808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLocked(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			bool b = riftChapterButton.IsLocked();
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

	// Token: 0x06020BC9 RID: 134089 RVA: 0x00AF465C File Offset: 0x00AF285C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsNew(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			bool b = riftChapterButton.IsNew();
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

	// Token: 0x06020BCA RID: 134090 RVA: 0x00AF46B0 File Offset: 0x00AF28B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			riftChapterButton.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BCB RID: 134091 RVA: 0x00AF4704 File Offset: 0x00AF2904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			riftChapterButton.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BCC RID: 134092 RVA: 0x00AF4758 File Offset: 0x00AF2958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			riftChapterButton.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BCD RID: 134093 RVA: 0x00AF47C4 File Offset: 0x00AF29C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			riftChapterButton.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BCE RID: 134094 RVA: 0x00AF4818 File Offset: 0x00AF2A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			riftChapterButton.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BCF RID: 134095 RVA: 0x00AF486C File Offset: 0x00AF2A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = riftChapterButton.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020BD0 RID: 134096 RVA: 0x00AF4914 File Offset: 0x00AF2B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			riftChapterButton.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BD1 RID: 134097 RVA: 0x00AF4968 File Offset: 0x00AF2B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			riftChapterButton.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BD2 RID: 134098 RVA: 0x00AF49D4 File Offset: 0x00AF2BD4
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
				RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				riftChapterButton.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RiftChapterButton riftChapterButton2 = (RiftChapterButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				riftChapterButton2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020BD3 RID: 134099 RVA: 0x00AF4AE4 File Offset: 0x00AF2CE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterButton.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BD4 RID: 134100 RVA: 0x00AF4B50 File Offset: 0x00AF2D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterButton.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BD5 RID: 134101 RVA: 0x00AF4BBC File Offset: 0x00AF2DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterButton.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BD6 RID: 134102 RVA: 0x00AF4C28 File Offset: 0x00AF2E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			riftChapterButton.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BD7 RID: 134103 RVA: 0x00AF4C94 File Offset: 0x00AF2E94
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
				RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				riftChapterButton.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RiftChapterButton riftChapterButton2 = (RiftChapterButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				riftChapterButton2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020BD8 RID: 134104 RVA: 0x00AF4DA4 File Offset: 0x00AF2FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			string s = riftChapterButton.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020BD9 RID: 134105 RVA: 0x00AF4E00 File Offset: 0x00AF3000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			RiftChapterButton obj;
			LuaObject.checkType<RiftChapterButton>(l, 2, out obj);
			riftChapterButton.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BDA RID: 134106 RVA: 0x00AF4E5C File Offset: 0x00AF305C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			RiftChapterButton obj;
			LuaObject.checkType<RiftChapterButton>(l, 2, out obj);
			riftChapterButton.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BDB RID: 134107 RVA: 0x00AF4EB8 File Offset: 0x00AF30B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			Action<RiftChapterButton> value;
			int num = LuaObject.checkDelegate<Action<RiftChapterButton>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					riftChapterButton.EventOnClick += value;
				}
				else if (num == 2)
				{
					riftChapterButton.EventOnClick -= value;
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

	// Token: 0x06020BDC RID: 134108 RVA: 0x00AF4F38 File Offset: 0x00AF3138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_sizeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterButton.m_luaExportHelper.m_sizeUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BDD RID: 134109 RVA: 0x00AF4F90 File Offset: 0x00AF3190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_sizeUIStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			CommonUIStateController sizeUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out sizeUIStateController);
			riftChapterButton.m_luaExportHelper.m_sizeUIStateController = sizeUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BDE RID: 134110 RVA: 0x00AF4FEC File Offset: 0x00AF31EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterButton.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BDF RID: 134111 RVA: 0x00AF5044 File Offset: 0x00AF3244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			riftChapterButton.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BE0 RID: 134112 RVA: 0x00AF50A0 File Offset: 0x00AF32A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterButton.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BE1 RID: 134113 RVA: 0x00AF50F8 File Offset: 0x00AF32F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			riftChapterButton.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BE2 RID: 134114 RVA: 0x00AF5154 File Offset: 0x00AF3354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_image(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterButton.m_luaExportHelper.m_image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BE3 RID: 134115 RVA: 0x00AF51AC File Offset: 0x00AF33AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_image(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			Image image;
			LuaObject.checkType<Image>(l, 2, out image);
			riftChapterButton.m_luaExportHelper.m_image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BE4 RID: 134116 RVA: 0x00AF5208 File Offset: 0x00AF3408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_titleObj(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterButton.m_luaExportHelper.m_titleObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BE5 RID: 134117 RVA: 0x00AF5260 File Offset: 0x00AF3460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_titleObj(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			GameObject titleObj;
			LuaObject.checkType<GameObject>(l, 2, out titleObj);
			riftChapterButton.m_luaExportHelper.m_titleObj = titleObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BE6 RID: 134118 RVA: 0x00AF52BC File Offset: 0x00AF34BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chapterInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterButton.m_luaExportHelper.m_chapterInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BE7 RID: 134119 RVA: 0x00AF5314 File Offset: 0x00AF3514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_chapterInfo(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			riftChapterButton.m_luaExportHelper.m_chapterInfo = chapterInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BE8 RID: 134120 RVA: 0x00AF5370 File Offset: 0x00AF3570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_index(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterButton.m_luaExportHelper.m_index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BE9 RID: 134121 RVA: 0x00AF53C8 File Offset: 0x00AF35C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_index(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			riftChapterButton.m_luaExportHelper.m_index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BEA RID: 134122 RVA: 0x00AF5424 File Offset: 0x00AF3624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterButton.m_luaExportHelper.m_isLocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BEB RID: 134123 RVA: 0x00AF547C File Offset: 0x00AF367C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isLocked(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			bool isLocked;
			LuaObject.checkType(l, 2, out isLocked);
			riftChapterButton.m_luaExportHelper.m_isLocked = isLocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BEC RID: 134124 RVA: 0x00AF54D8 File Offset: 0x00AF36D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isNew(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapterButton.m_luaExportHelper.m_isNew);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BED RID: 134125 RVA: 0x00AF5530 File Offset: 0x00AF3730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isNew(IntPtr l)
	{
		int result;
		try
		{
			RiftChapterButton riftChapterButton = (RiftChapterButton)LuaObject.checkSelf(l);
			bool isNew;
			LuaObject.checkType(l, 2, out isNew);
			riftChapterButton.m_luaExportHelper.m_isNew = isNew;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020BEE RID: 134126 RVA: 0x00AF558C File Offset: 0x00AF378C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftChapterButton");
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.SetChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.SetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.GetIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.GetChapter);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.SetStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.IsLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.IsNew);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache17);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache18, true);
		string name2 = "m_sizeUIStateController";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.get_m_sizeUIStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.set_m_sizeUIStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1A, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1C, true);
		string name4 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.get_m_button);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.set_m_button);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1E, true);
		string name5 = "m_image";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.get_m_image);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.set_m_image);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache20, true);
		string name6 = "m_titleObj";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.get_m_titleObj);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.set_m_titleObj);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache22, true);
		string name7 = "m_chapterInfo";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.get_m_chapterInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.set_m_chapterInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache24, true);
		string name8 = "m_index";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.get_m_index);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.set_m_index);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache26, true);
		string name9 = "m_isLocked";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.get_m_isLocked);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.set_m_isLocked);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache28, true);
		string name10 = "m_isNew";
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.get_m_isNew);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftChapterButton.set_m_isNew);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RiftChapterButton.<>f__mg$cache2A, true);
		LuaObject.createTypeMetatable(l, null, typeof(RiftChapterButton), typeof(UIControllerBase));
	}

	// Token: 0x04016AE7 RID: 92903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016AE8 RID: 92904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016AE9 RID: 92905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016AEA RID: 92906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016AEB RID: 92907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016AEC RID: 92908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016AED RID: 92909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016AEE RID: 92910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016AEF RID: 92911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016AF0 RID: 92912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016AF1 RID: 92913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016AF2 RID: 92914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016AF3 RID: 92915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016AF4 RID: 92916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016AF5 RID: 92917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016AF6 RID: 92918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016AF7 RID: 92919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016AF8 RID: 92920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016AF9 RID: 92921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016AFA RID: 92922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016AFB RID: 92923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016AFC RID: 92924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016AFD RID: 92925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016AFE RID: 92926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016AFF RID: 92927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016B00 RID: 92928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016B01 RID: 92929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016B02 RID: 92930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016B03 RID: 92931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016B04 RID: 92932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016B05 RID: 92933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016B06 RID: 92934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016B07 RID: 92935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016B08 RID: 92936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016B09 RID: 92937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016B0A RID: 92938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016B0B RID: 92939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016B0C RID: 92940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016B0D RID: 92941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016B0E RID: 92942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016B0F RID: 92943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016B10 RID: 92944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016B11 RID: 92945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;
}
