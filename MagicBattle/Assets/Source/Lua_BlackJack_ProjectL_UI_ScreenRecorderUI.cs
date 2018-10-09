using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200156B RID: 5483
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ScreenRecorderUI : LuaObject
{
	// Token: 0x06020DDA RID: 134618 RVA: 0x00B051B0 File Offset: 0x00B033B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScreenRecordToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			screenRecorderUI.OnScreenRecordToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DDB RID: 134619 RVA: 0x00B05208 File Offset: 0x00B03408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			screenRecorderUI.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DDC RID: 134620 RVA: 0x00B05260 File Offset: 0x00B03460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			screenRecorderUI.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DDD RID: 134621 RVA: 0x00B052B8 File Offset: 0x00B034B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			screenRecorderUI.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DDE RID: 134622 RVA: 0x00B05310 File Offset: 0x00B03510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDisable(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			screenRecorderUI.m_luaExportHelper.OnDisable();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DDF RID: 134623 RVA: 0x00B05364 File Offset: 0x00B03564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Awake(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			screenRecorderUI.m_luaExportHelper.Awake();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DE0 RID: 134624 RVA: 0x00B053B8 File Offset: 0x00B035B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToggleScreenRecord(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			screenRecorderUI.m_luaExportHelper.ToggleScreenRecord(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DE1 RID: 134625 RVA: 0x00B05414 File Offset: 0x00B03614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FormatRecordTimeString(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			string s = screenRecorderUI.m_luaExportHelper.FormatRecordTimeString(time);
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

	// Token: 0x06020DE2 RID: 134626 RVA: 0x00B0547C File Offset: 0x00B0367C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			screenRecorderUI.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DE3 RID: 134627 RVA: 0x00B054D0 File Offset: 0x00B036D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDraggedPosition(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			PointerEventData draggedPosition;
			LuaObject.checkType<PointerEventData>(l, 2, out draggedPosition);
			screenRecorderUI.m_luaExportHelper.SetDraggedPosition(draggedPosition);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DE4 RID: 134628 RVA: 0x00B0552C File Offset: 0x00B0372C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartRecord(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			screenRecorderUI.m_luaExportHelper.StartRecord();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DE5 RID: 134629 RVA: 0x00B05580 File Offset: 0x00B03780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopRecord(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			screenRecorderUI.m_luaExportHelper.StopRecord();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DE6 RID: 134630 RVA: 0x00B055D4 File Offset: 0x00B037D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateScreenRecord(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			screenRecorderUI.m_luaExportHelper.UpdateScreenRecord();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DE7 RID: 134631 RVA: 0x00B05628 File Offset: 0x00B03828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			screenRecorderUI.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DE8 RID: 134632 RVA: 0x00B05694 File Offset: 0x00B03894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAssetInContainer(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			string resName;
			LuaObject.checkType(l, 2, out resName);
			UnityEngine.Object o = screenRecorderUI.m_luaExportHelper.__callBase_GetAssetInContainer(resName);
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

	// Token: 0x06020DE9 RID: 134633 RVA: 0x00B056FC File Offset: 0x00B038FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindResContainer(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			screenRecorderUI.m_luaExportHelper.__callBase_BindResContainer();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DEA RID: 134634 RVA: 0x00B05750 File Offset: 0x00B03950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			screenRecorderUI.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DEB RID: 134635 RVA: 0x00B057A4 File Offset: 0x00B039A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetNextUpdateExecutor(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			PrefabControllerNextUpdateExecutor o = screenRecorderUI.m_luaExportHelper.__callBase_GetNextUpdateExecutor();
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

	// Token: 0x06020DEC RID: 134636 RVA: 0x00B05800 File Offset: 0x00B03A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			screenRecorderUI.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DED RID: 134637 RVA: 0x00B05854 File Offset: 0x00B03A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = screenRecorderUI.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020DEE RID: 134638 RVA: 0x00B058FC File Offset: 0x00B03AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetChildByPath(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			string path;
			LuaObject.checkType(l, 2, out path);
			GameObject o = screenRecorderUI.m_luaExportHelper.__callBase_GetChildByPath(path);
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

	// Token: 0x06020DEF RID: 134639 RVA: 0x00B05964 File Offset: 0x00B03B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_screenRecordToggle(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenRecorderUI.m_luaExportHelper.m_screenRecordToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DF0 RID: 134640 RVA: 0x00B059BC File Offset: 0x00B03BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_screenRecordToggle(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			Toggle screenRecordToggle;
			LuaObject.checkType<Toggle>(l, 2, out screenRecordToggle);
			screenRecorderUI.m_luaExportHelper.m_screenRecordToggle = screenRecordToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DF1 RID: 134641 RVA: 0x00B05A18 File Offset: 0x00B03C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recordIndicator(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenRecorderUI.m_luaExportHelper.m_recordIndicator);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DF2 RID: 134642 RVA: 0x00B05A70 File Offset: 0x00B03C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recordIndicator(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			GameObject recordIndicator;
			LuaObject.checkType<GameObject>(l, 2, out recordIndicator);
			screenRecorderUI.m_luaExportHelper.m_recordIndicator = recordIndicator;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DF3 RID: 134643 RVA: 0x00B05ACC File Offset: 0x00B03CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recordTimerText(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenRecorderUI.m_luaExportHelper.m_recordTimerText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DF4 RID: 134644 RVA: 0x00B05B24 File Offset: 0x00B03D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recordTimerText(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			Text recordTimerText;
			LuaObject.checkType<Text>(l, 2, out recordTimerText);
			screenRecorderUI.m_luaExportHelper.m_recordTimerText = recordTimerText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DF5 RID: 134645 RVA: 0x00B05B80 File Offset: 0x00B03D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recordTime(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenRecorderUI.m_luaExportHelper.m_recordTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DF6 RID: 134646 RVA: 0x00B05BD8 File Offset: 0x00B03DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recordTime(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			float recordTime;
			LuaObject.checkType(l, 2, out recordTime);
			screenRecorderUI.m_luaExportHelper.m_recordTime = recordTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DF7 RID: 134647 RVA: 0x00B05C34 File Offset: 0x00B03E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isPreviewing(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, screenRecorderUI.m_luaExportHelper.m_isPreviewing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DF8 RID: 134648 RVA: 0x00B05C8C File Offset: 0x00B03E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isPreviewing(IntPtr l)
	{
		int result;
		try
		{
			ScreenRecorderUI screenRecorderUI = (ScreenRecorderUI)LuaObject.checkSelf(l);
			bool isPreviewing;
			LuaObject.checkType(l, 2, out isPreviewing);
			screenRecorderUI.m_luaExportHelper.m_isPreviewing = isPreviewing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020DF9 RID: 134649 RVA: 0x00B05CE8 File Offset: 0x00B03EE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ScreenRecorderUI");
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.OnScreenRecordToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.OnDisable);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.Awake);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.ToggleScreenRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.FormatRecordTimeString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.SetDraggedPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.StartRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.StopRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.UpdateScreenRecord);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.__callBase_GetAssetInContainer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.__callBase_BindResContainer);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.__callBase_GetNextUpdateExecutor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.__callBase_GetChildByPath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache14);
		string name = "m_screenRecordToggle";
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.get_m_screenRecordToggle);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.set_m_screenRecordToggle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache16, true);
		string name2 = "m_recordIndicator";
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.get_m_recordIndicator);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.set_m_recordIndicator);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache18, true);
		string name3 = "m_recordTimerText";
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.get_m_recordTimerText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.set_m_recordTimerText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1A, true);
		string name4 = "m_recordTime";
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.get_m_recordTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.set_m_recordTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1C, true);
		string name5 = "m_isPreviewing";
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.get_m_isPreviewing);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.set_m_isPreviewing);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ScreenRecorderUI.<>f__mg$cache1E, true);
		LuaObject.createTypeMetatable(l, null, typeof(ScreenRecorderUI), typeof(PrefabControllerBase));
	}

	// Token: 0x04016CE6 RID: 93414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016CE7 RID: 93415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016CE8 RID: 93416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016CE9 RID: 93417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016CEA RID: 93418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016CEB RID: 93419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016CEC RID: 93420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016CED RID: 93421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016CEE RID: 93422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016CEF RID: 93423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016CF0 RID: 93424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016CF1 RID: 93425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016CF2 RID: 93426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016CF3 RID: 93427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016CF4 RID: 93428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016CF5 RID: 93429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016CF6 RID: 93430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016CF7 RID: 93431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016CF8 RID: 93432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016CF9 RID: 93433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016CFA RID: 93434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016CFB RID: 93435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016CFC RID: 93436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016CFD RID: 93437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016CFE RID: 93438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016CFF RID: 93439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016D00 RID: 93440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016D01 RID: 93441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016D02 RID: 93442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016D03 RID: 93443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016D04 RID: 93444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;
}
