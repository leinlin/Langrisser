using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020015AC RID: 5548
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TestUI : LuaObject
{
	// Token: 0x060219F2 RID: 137714 RVA: 0x00B65E3C File Offset: 0x00B6403C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitializeBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			testUI.InitializeBattle(clientBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219F3 RID: 137715 RVA: 0x00B65E94 File Offset: 0x00B64094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitializeBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.UninitializeBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219F4 RID: 137716 RVA: 0x00B65EE0 File Offset: 0x00B640E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitializeWorld(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			ClientWorld clientWorld;
			LuaObject.checkType<ClientWorld>(l, 2, out clientWorld);
			testUI.InitializeWorld(clientWorld);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219F5 RID: 137717 RVA: 0x00B65F38 File Offset: 0x00B64138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UninitializeWorld(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.UninitializeWorld();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219F6 RID: 137718 RVA: 0x00B65F84 File Offset: 0x00B64184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SendGMCommand_s(IntPtr l)
	{
		int result;
		try
		{
			string cmd;
			LuaObject.checkType(l, 1, out cmd);
			TestUI.SendGMCommand(cmd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219F7 RID: 137719 RVA: 0x00B65FD0 File Offset: 0x00B641D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Awake(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.Awake();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219F8 RID: 137720 RVA: 0x00B66024 File Offset: 0x00B64224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTimeScale(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			float timeScale;
			LuaObject.checkType(l, 2, out timeScale);
			testUI.m_luaExportHelper.SetTimeScale(timeScale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219F9 RID: 137721 RVA: 0x00B66080 File Offset: 0x00B64280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToolButton(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			float size;
			LuaObject.checkType(l, 4, out size);
			string text;
			LuaObject.checkType(l, 5, out text);
			bool b = testUI.m_luaExportHelper.ToolButton(ref i, ref i2, size, text);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 4;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219FA RID: 137722 RVA: 0x00B66120 File Offset: 0x00B64320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToolToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			float size;
			LuaObject.checkType(l, 4, out size);
			string text;
			LuaObject.checkType(l, 5, out text);
			bool oldValue;
			LuaObject.checkType(l, 6, out oldValue);
			bool b = testUI.m_luaExportHelper.ToolToggle(ref i, ref i2, size, text, oldValue);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 4;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219FB RID: 137723 RVA: 0x00B661CC File Offset: 0x00B643CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TextLine(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int x;
			LuaObject.checkType(l, 2, out x);
			int i;
			LuaObject.checkType(l, 3, out i);
			string text;
			LuaObject.checkType(l, 4, out text);
			testUI.m_luaExportHelper.TextLine(x, ref i, text);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219FC RID: 137724 RVA: 0x00B6624C File Offset: 0x00B6444C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GUIBattleTestTools(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.GUIBattleTestTools();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219FD RID: 137725 RVA: 0x00B662A0 File Offset: 0x00B644A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GUIWorldTestTools(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.GUIWorldTestTools();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219FE RID: 137726 RVA: 0x00B662F4 File Offset: 0x00B644F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GUIGMReloginButton(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUIGMReloginButton(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060219FF RID: 137727 RVA: 0x00B66370 File Offset: 0x00B64570
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GUIToolToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUIToolToggle(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A00 RID: 137728 RVA: 0x00B663EC File Offset: 0x00B645EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUISpeedToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUISpeedToggle(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A01 RID: 137729 RVA: 0x00B66468 File Offset: 0x00B64668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUIAudioToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUIAudioToggle(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A02 RID: 137730 RVA: 0x00B664E4 File Offset: 0x00B646E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GUITouchToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUITouchToggle(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A03 RID: 137731 RVA: 0x00B66560 File Offset: 0x00B64760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUIMultiTouchToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUIMultiTouchToggle(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A04 RID: 137732 RVA: 0x00B665DC File Offset: 0x00B647DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUIResolutionToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUIResolutionToggle(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A05 RID: 137733 RVA: 0x00B66658 File Offset: 0x00B64858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUIFrameRateToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUIFrameRateToggle(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A06 RID: 137734 RVA: 0x00B666D4 File Offset: 0x00B648D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUITimeToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUITimeToggle(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A07 RID: 137735 RVA: 0x00B66750 File Offset: 0x00B64950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUIMemoryToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUIMemoryToggle(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A08 RID: 137736 RVA: 0x00B667CC File Offset: 0x00B649CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUILowMemoryTest(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUILowMemoryTest(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A09 RID: 137737 RVA: 0x00B66848 File Offset: 0x00B64A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUIGMCommandToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUIGMCommandToggle(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A0A RID: 137738 RVA: 0x00B668C4 File Offset: 0x00B64AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUIGMCommand(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int i;
			LuaObject.checkType(l, 2, out i);
			int i2;
			LuaObject.checkType(l, 3, out i2);
			testUI.m_luaExportHelper.GUIGMCommand(ref i, ref i2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			LuaObject.pushValue(l, i2);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A0B RID: 137739 RVA: 0x00B66940 File Offset: 0x00B64B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LogResources(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.LogResources();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A0C RID: 137740 RVA: 0x00B66994 File Offset: 0x00B64B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GridPositionToScreenPosition(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			Vector3 o = testUI.m_luaExportHelper.GridPositionToScreenPosition(p);
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

	// Token: 0x06021A0D RID: 137741 RVA: 0x00B669FC File Offset: 0x00B64BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUIBattleActor(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			BattleActor actor;
			LuaObject.checkType<BattleActor>(l, 2, out actor);
			testUI.m_luaExportHelper.GUIBattleActor(actor);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A0E RID: 137742 RVA: 0x00B66A58 File Offset: 0x00B64C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUIBattleActors(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.GUIBattleActors();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A0F RID: 137743 RVA: 0x00B66AAC File Offset: 0x00B64CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUIBattleMap(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.GUIBattleMap();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A10 RID: 137744 RVA: 0x00B66B00 File Offset: 0x00B64D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUITouch(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.GUITouch();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A11 RID: 137745 RVA: 0x00B66B54 File Offset: 0x00B64D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CombatPositionToScreenPosition(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			Vector2i p;
			LuaObject.checkValueType<Vector2i>(l, 2, out p);
			Vector3 o = testUI.m_luaExportHelper.CombatPositionToScreenPosition(p);
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

	// Token: 0x06021A12 RID: 137746 RVA: 0x00B66BBC File Offset: 0x00B64DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUICombatActor(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			CombatActor a;
			LuaObject.checkType<CombatActor>(l, 2, out a);
			testUI.m_luaExportHelper.GUICombatActor(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A13 RID: 137747 RVA: 0x00B66C18 File Offset: 0x00B64E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GUICombatActors(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.GUICombatActors();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A14 RID: 137748 RVA: 0x00B66C6C File Offset: 0x00B64E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A15 RID: 137749 RVA: 0x00B66CC0 File Offset: 0x00B64EC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int TestMemoryWarnning(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.TestMemoryWarnning();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A16 RID: 137750 RVA: 0x00B66D14 File Offset: 0x00B64F14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ComputeFps(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.ComputeFps();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A17 RID: 137751 RVA: 0x00B66D68 File Offset: 0x00B64F68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateTestUIBackground(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.UpdateTestUIBackground();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A18 RID: 137752 RVA: 0x00B66DBC File Offset: 0x00B64FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGUI(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.OnGUI();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A19 RID: 137753 RVA: 0x00B66E10 File Offset: 0x00B65010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnExitBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.__callDele_EventOnExitBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A1A RID: 137754 RVA: 0x00B66E64 File Offset: 0x00B65064
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnExitBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.__clearDele_EventOnExitBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A1B RID: 137755 RVA: 0x00B66EB8 File Offset: 0x00B650B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRestartBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.__callDele_EventOnRestartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A1C RID: 137756 RVA: 0x00B66F0C File Offset: 0x00B6510C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRestartBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.__clearDele_EventOnRestartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A1D RID: 137757 RVA: 0x00B66F60 File Offset: 0x00B65160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReplayBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.__callDele_EventOnReplayBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A1E RID: 137758 RVA: 0x00B66FB4 File Offset: 0x00B651B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnReplayBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			testUI.m_luaExportHelper.__clearDele_EventOnReplayBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A1F RID: 137759 RVA: 0x00B67008 File Offset: 0x00B65208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStopBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			testUI.m_luaExportHelper.__callDele_EventOnStopBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A20 RID: 137760 RVA: 0x00B67064 File Offset: 0x00B65264
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnStopBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			testUI.m_luaExportHelper.__clearDele_EventOnStopBattle(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A21 RID: 137761 RVA: 0x00B670C0 File Offset: 0x00B652C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CompareObjectRuntimeMemroySize_s(IntPtr l)
	{
		int result;
		try
		{
			TestUI.ObjectAndSize os;
			LuaObject.checkValueType<TestUI.ObjectAndSize>(l, 1, out os);
			TestUI.ObjectAndSize os2;
			LuaObject.checkValueType<TestUI.ObjectAndSize>(l, 2, out os2);
			int i = TestUI.LuaExportHelper.CompareObjectRuntimeMemroySize(os, os2);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A22 RID: 137762 RVA: 0x00B67120 File Offset: 0x00B65320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PreProcessGMCommand_s(IntPtr l)
	{
		int result;
		try
		{
			string cmd;
			LuaObject.checkType(l, 1, out cmd);
			bool b = TestUI.LuaExportHelper.PreProcessGMCommand(cmd);
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

	// Token: 0x06021A23 RID: 137763 RVA: 0x00B67174 File Offset: 0x00B65374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnExitBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUI.EventOnExitBattle += value;
				}
				else if (num == 2)
				{
					testUI.EventOnExitBattle -= value;
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

	// Token: 0x06021A24 RID: 137764 RVA: 0x00B671F4 File Offset: 0x00B653F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnRestartBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUI.EventOnRestartBattle += value;
				}
				else if (num == 2)
				{
					testUI.EventOnRestartBattle -= value;
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

	// Token: 0x06021A25 RID: 137765 RVA: 0x00B67274 File Offset: 0x00B65474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReplayBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUI.EventOnReplayBattle += value;
				}
				else if (num == 2)
				{
					testUI.EventOnReplayBattle -= value;
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

	// Token: 0x06021A26 RID: 137766 RVA: 0x00B672F4 File Offset: 0x00B654F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnStopBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					testUI.EventOnStopBattle += value;
				}
				else if (num == 2)
				{
					testUI.EventOnStopBattle -= value;
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

	// Token: 0x06021A27 RID: 137767 RVA: 0x00B67374 File Offset: 0x00B65574
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_clientBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A28 RID: 137768 RVA: 0x00B673CC File Offset: 0x00B655CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			testUI.m_luaExportHelper.m_clientBattle = clientBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A29 RID: 137769 RVA: 0x00B67428 File Offset: 0x00B65628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientWorld(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_clientWorld);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A2A RID: 137770 RVA: 0x00B67480 File Offset: 0x00B65680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientWorld(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			ClientWorld clientWorld;
			LuaObject.checkType<ClientWorld>(l, 2, out clientWorld);
			testUI.m_luaExportHelper.m_clientWorld = clientWorld;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A2B RID: 137771 RVA: 0x00B674DC File Offset: 0x00B656DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_updateCount(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_updateCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A2C RID: 137772 RVA: 0x00B67534 File Offset: 0x00B65734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_updateCount(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int updateCount;
			LuaObject.checkType(l, 2, out updateCount);
			testUI.m_luaExportHelper.m_updateCount = updateCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A2D RID: 137773 RVA: 0x00B67590 File Offset: 0x00B65790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fps(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_fps);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A2E RID: 137774 RVA: 0x00B675E8 File Offset: 0x00B657E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fps(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			float fps;
			LuaObject.checkType(l, 2, out fps);
			testUI.m_luaExportHelper.m_fps = fps;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A2F RID: 137775 RVA: 0x00B67644 File Offset: 0x00B65844
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_lastFpsResetTime(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_lastFpsResetTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A30 RID: 137776 RVA: 0x00B6769C File Offset: 0x00B6589C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_lastFpsResetTime(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			float lastFpsResetTime;
			LuaObject.checkType(l, 2, out lastFpsResetTime);
			testUI.m_luaExportHelper.m_lastFpsResetTime = lastFpsResetTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A31 RID: 137777 RVA: 0x00B676F8 File Offset: 0x00B658F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lastMemoryWarningTime(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_lastMemoryWarningTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A32 RID: 137778 RVA: 0x00B67750 File Offset: 0x00B65950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lastMemoryWarningTime(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			float lastMemoryWarningTime;
			LuaObject.checkType(l, 2, out lastMemoryWarningTime);
			testUI.m_luaExportHelper.m_lastMemoryWarningTime = lastMemoryWarningTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A33 RID: 137779 RVA: 0x00B677AC File Offset: 0x00B659AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_timeScale(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_timeScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A34 RID: 137780 RVA: 0x00B67804 File Offset: 0x00B65A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_timeScale(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			float timeScale;
			LuaObject.checkType(l, 2, out timeScale);
			testUI.m_luaExportHelper.m_timeScale = timeScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A35 RID: 137781 RVA: 0x00B67860 File Offset: 0x00B65A60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isTimePaused(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_isTimePaused);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A36 RID: 137782 RVA: 0x00B678B8 File Offset: 0x00B65AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isTimePaused(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			bool isTimePaused;
			LuaObject.checkType(l, 2, out isTimePaused);
			testUI.m_luaExportHelper.m_isTimePaused = isTimePaused;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A37 RID: 137783 RVA: 0x00B67914 File Offset: 0x00B65B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShowTestToolToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_isShowTestToolToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A38 RID: 137784 RVA: 0x00B6796C File Offset: 0x00B65B6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isShowTestToolToggle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			bool isShowTestToolToggle;
			LuaObject.checkType(l, 2, out isShowTestToolToggle);
			testUI.m_luaExportHelper.m_isShowTestToolToggle = isShowTestToolToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A39 RID: 137785 RVA: 0x00B679C8 File Offset: 0x00B65BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShowTestToolBar(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_isShowTestToolBar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A3A RID: 137786 RVA: 0x00B67A20 File Offset: 0x00B65C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isShowTestToolBar(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			bool isShowTestToolBar;
			LuaObject.checkType(l, 2, out isShowTestToolBar);
			testUI.m_luaExportHelper.m_isShowTestToolBar = isShowTestToolBar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A3B RID: 137787 RVA: 0x00B67A7C File Offset: 0x00B65C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShowTouches(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_isShowTouches);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A3C RID: 137788 RVA: 0x00B67AD4 File Offset: 0x00B65CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isShowTouches(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			bool isShowTouches;
			LuaObject.checkType(l, 2, out isShowTouches);
			testUI.m_luaExportHelper.m_isShowTouches = isShowTouches;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A3D RID: 137789 RVA: 0x00B67B30 File Offset: 0x00B65D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isLowResolution(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_isLowResolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A3E RID: 137790 RVA: 0x00B67B88 File Offset: 0x00B65D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isLowResolution(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			bool isLowResolution;
			LuaObject.checkType(l, 2, out isLowResolution);
			testUI.m_luaExportHelper.m_isLowResolution = isLowResolution;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A3F RID: 137791 RVA: 0x00B67BE4 File Offset: 0x00B65DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFrameRateLimit(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_isFrameRateLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A40 RID: 137792 RVA: 0x00B67C3C File Offset: 0x00B65E3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isFrameRateLimit(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			bool isFrameRateLimit;
			LuaObject.checkType(l, 2, out isFrameRateLimit);
			testUI.m_luaExportHelper.m_isFrameRateLimit = isFrameRateLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A41 RID: 137793 RVA: 0x00B67C98 File Offset: 0x00B65E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShowTime(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_isShowTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A42 RID: 137794 RVA: 0x00B67CF0 File Offset: 0x00B65EF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isShowTime(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			bool isShowTime;
			LuaObject.checkType(l, 2, out isShowTime);
			testUI.m_luaExportHelper.m_isShowTime = isShowTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A43 RID: 137795 RVA: 0x00B67D4C File Offset: 0x00B65F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isShowMemory(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_isShowMemory);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A44 RID: 137796 RVA: 0x00B67DA4 File Offset: 0x00B65FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isShowMemory(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			bool isShowMemory;
			LuaObject.checkType(l, 2, out isShowMemory);
			testUI.m_luaExportHelper.m_isShowMemory = isShowMemory;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A45 RID: 137797 RVA: 0x00B67E00 File Offset: 0x00B66000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_isShowGMCommand(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_isShowGMCommand);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A46 RID: 137798 RVA: 0x00B67E58 File Offset: 0x00B66058
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_isShowGMCommand(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			bool isShowGMCommand;
			LuaObject.checkType(l, 2, out isShowGMCommand);
			testUI.m_luaExportHelper.m_isShowGMCommand = isShowGMCommand;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A47 RID: 137799 RVA: 0x00B67EB4 File Offset: 0x00B660B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initScreenWidth(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_initScreenWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A48 RID: 137800 RVA: 0x00B67F0C File Offset: 0x00B6610C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initScreenWidth(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int initScreenWidth;
			LuaObject.checkType(l, 2, out initScreenWidth);
			testUI.m_luaExportHelper.m_initScreenWidth = initScreenWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A49 RID: 137801 RVA: 0x00B67F68 File Offset: 0x00B66168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_initScreenHeight(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_initScreenHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A4A RID: 137802 RVA: 0x00B67FC0 File Offset: 0x00B661C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_initScreenHeight(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int initScreenHeight;
			LuaObject.checkType(l, 2, out initScreenHeight);
			testUI.m_luaExportHelper.m_initScreenHeight = initScreenHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A4B RID: 137803 RVA: 0x00B6801C File Offset: 0x00B6621C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_GMCommandStr(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_GMCommandStr);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A4C RID: 137804 RVA: 0x00B68074 File Offset: 0x00B66274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_GMCommandStr(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			string gmcommandStr;
			LuaObject.checkType(l, 2, out gmcommandStr);
			testUI.m_luaExportHelper.m_GMCommandStr = gmcommandStr;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A4D RID: 137805 RVA: 0x00B680D0 File Offset: 0x00B662D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unit(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_unit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A4E RID: 137806 RVA: 0x00B68128 File Offset: 0x00B66328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unit(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			int unit;
			LuaObject.checkType(l, 2, out unit);
			testUI.m_luaExportHelper.m_unit = unit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A4F RID: 137807 RVA: 0x00B68184 File Offset: 0x00B66384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_buttonStyle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_buttonStyle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A50 RID: 137808 RVA: 0x00B681DC File Offset: 0x00B663DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_buttonStyle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			GUIStyle buttonStyle;
			LuaObject.checkType<GUIStyle>(l, 2, out buttonStyle);
			testUI.m_luaExportHelper.m_buttonStyle = buttonStyle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A51 RID: 137809 RVA: 0x00B68238 File Offset: 0x00B66438
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_textFieldStyle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_textFieldStyle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A52 RID: 137810 RVA: 0x00B68290 File Offset: 0x00B66490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_textFieldStyle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			GUIStyle textFieldStyle;
			LuaObject.checkType<GUIStyle>(l, 2, out textFieldStyle);
			testUI.m_luaExportHelper.m_textFieldStyle = textFieldStyle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A53 RID: 137811 RVA: 0x00B682EC File Offset: 0x00B664EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_textStyle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_textStyle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A54 RID: 137812 RVA: 0x00B68344 File Offset: 0x00B66544
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_textStyle(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			GUIStyle textStyle;
			LuaObject.checkType<GUIStyle>(l, 2, out textStyle);
			testUI.m_luaExportHelper.m_textStyle = textStyle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A55 RID: 137813 RVA: 0x00B683A0 File Offset: 0x00B665A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_textStyleSmall(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, testUI.m_luaExportHelper.m_textStyleSmall);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A56 RID: 137814 RVA: 0x00B683F8 File Offset: 0x00B665F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_textStyleSmall(IntPtr l)
	{
		int result;
		try
		{
			TestUI testUI = (TestUI)LuaObject.checkSelf(l);
			GUIStyle textStyleSmall;
			LuaObject.checkType<GUIStyle>(l, 2, out textStyleSmall);
			testUI.m_luaExportHelper.m_textStyleSmall = textStyleSmall;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021A57 RID: 137815 RVA: 0x00B68454 File Offset: 0x00B66654
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TestUI");
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.InitializeBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.UninitializeBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.InitializeWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.UninitializeWorld);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.SendGMCommand_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.Awake);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.SetTimeScale);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.ToolButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.ToolToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.TextLine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIBattleTestTools);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIWorldTestTools);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIGMReloginButton);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIToolToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUISpeedToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIAudioToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUITouchToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIMultiTouchToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIResolutionToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIFrameRateToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUITimeToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIMemoryToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUILowMemoryTest);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIGMCommandToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIGMCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.LogResources);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GridPositionToScreenPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIBattleActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIBattleActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUIBattleMap);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUITouch);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.CombatPositionToScreenPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUICombatActor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.GUICombatActors);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.TestMemoryWarnning);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.ComputeFps);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.UpdateTestUIBackground);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.OnGUI);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.__callDele_EventOnExitBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.__clearDele_EventOnExitBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.__callDele_EventOnRestartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.__clearDele_EventOnRestartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.__callDele_EventOnReplayBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.__clearDele_EventOnReplayBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.__callDele_EventOnStopBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.__clearDele_EventOnStopBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.CompareObjectRuntimeMemroySize_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.PreProcessGMCommand_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache30);
		string name = "EventOnExitBattle";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_EventOnExitBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache31, true);
		string name2 = "EventOnRestartBattle";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_EventOnRestartBattle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache32, true);
		string name3 = "EventOnReplayBattle";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_EventOnReplayBattle);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache33, true);
		string name4 = "EventOnStopBattle";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_EventOnStopBattle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache34, true);
		string name5 = "m_clientBattle";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_clientBattle);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_clientBattle);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache36, true);
		string name6 = "m_clientWorld";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_clientWorld);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_clientWorld);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache38, true);
		string name7 = "m_updateCount";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_updateCount);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_updateCount);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3A, true);
		string name8 = "m_fps";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_fps);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_fps);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3C, true);
		string name9 = "m_lastFpsResetTime";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_lastFpsResetTime);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_lastFpsResetTime);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3E, true);
		string name10 = "m_lastMemoryWarningTime";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_lastMemoryWarningTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_lastMemoryWarningTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache40, true);
		string name11 = "m_timeScale";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_timeScale);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_timeScale);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache42, true);
		string name12 = "m_isTimePaused";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_isTimePaused);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_isTimePaused);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache44, true);
		string name13 = "m_isShowTestToolToggle";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_isShowTestToolToggle);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_isShowTestToolToggle);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache46, true);
		string name14 = "m_isShowTestToolBar";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_isShowTestToolBar);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_isShowTestToolBar);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache48, true);
		string name15 = "m_isShowTouches";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_isShowTouches);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_isShowTouches);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4A, true);
		string name16 = "m_isLowResolution";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_isLowResolution);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_isLowResolution);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4C, true);
		string name17 = "m_isFrameRateLimit";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_isFrameRateLimit);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_isFrameRateLimit);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4E, true);
		string name18 = "m_isShowTime";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_isShowTime);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_isShowTime);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache50, true);
		string name19 = "m_isShowMemory";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_isShowMemory);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_isShowMemory);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache52, true);
		string name20 = "m_isShowGMCommand";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_isShowGMCommand);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_isShowGMCommand);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache54, true);
		string name21 = "m_initScreenWidth";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_initScreenWidth);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_initScreenWidth);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache56, true);
		string name22 = "m_initScreenHeight";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_initScreenHeight);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_initScreenHeight);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache58, true);
		string name23 = "m_GMCommandStr";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_GMCommandStr);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_GMCommandStr);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5A, true);
		string name24 = "m_unit";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_unit);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_unit);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5C, true);
		string name25 = "m_buttonStyle";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_buttonStyle);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_buttonStyle);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5E, true);
		string name26 = "m_textFieldStyle";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_textFieldStyle);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_textFieldStyle);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache60, true);
		string name27 = "m_textStyle";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_textStyle);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_textStyle);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache62, true);
		string name28 = "m_textStyleSmall";
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.get_m_textStyleSmall);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TestUI.set_m_textStyleSmall);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_TestUI.<>f__mg$cache64, true);
		LuaObject.createTypeMetatable(l, null, typeof(TestUI), typeof(MonoBehaviour));
	}

	// Token: 0x0401787C RID: 96380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401787D RID: 96381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401787E RID: 96382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401787F RID: 96383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017880 RID: 96384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017881 RID: 96385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017882 RID: 96386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017883 RID: 96387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017884 RID: 96388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017885 RID: 96389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017886 RID: 96390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017887 RID: 96391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017888 RID: 96392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017889 RID: 96393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401788A RID: 96394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401788B RID: 96395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401788C RID: 96396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401788D RID: 96397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401788E RID: 96398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401788F RID: 96399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017890 RID: 96400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017891 RID: 96401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017892 RID: 96402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017893 RID: 96403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017894 RID: 96404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017895 RID: 96405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017896 RID: 96406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017897 RID: 96407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017898 RID: 96408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017899 RID: 96409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401789A RID: 96410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401789B RID: 96411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401789C RID: 96412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401789D RID: 96413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401789E RID: 96414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401789F RID: 96415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040178A0 RID: 96416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040178A1 RID: 96417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040178A2 RID: 96418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040178A3 RID: 96419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040178A4 RID: 96420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040178A5 RID: 96421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040178A6 RID: 96422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040178A7 RID: 96423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040178A8 RID: 96424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040178A9 RID: 96425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040178AA RID: 96426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040178AB RID: 96427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040178AC RID: 96428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040178AD RID: 96429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040178AE RID: 96430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040178AF RID: 96431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040178B0 RID: 96432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040178B1 RID: 96433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040178B2 RID: 96434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040178B3 RID: 96435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040178B4 RID: 96436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040178B5 RID: 96437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040178B6 RID: 96438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040178B7 RID: 96439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040178B8 RID: 96440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040178B9 RID: 96441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040178BA RID: 96442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040178BB RID: 96443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040178BC RID: 96444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040178BD RID: 96445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040178BE RID: 96446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040178BF RID: 96447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040178C0 RID: 96448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040178C1 RID: 96449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040178C2 RID: 96450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040178C3 RID: 96451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040178C4 RID: 96452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040178C5 RID: 96453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040178C6 RID: 96454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040178C7 RID: 96455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040178C8 RID: 96456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040178C9 RID: 96457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040178CA RID: 96458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040178CB RID: 96459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040178CC RID: 96460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040178CD RID: 96461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040178CE RID: 96462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040178CF RID: 96463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040178D0 RID: 96464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040178D1 RID: 96465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040178D2 RID: 96466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040178D3 RID: 96467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040178D4 RID: 96468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040178D5 RID: 96469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040178D6 RID: 96470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040178D7 RID: 96471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040178D8 RID: 96472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040178D9 RID: 96473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040178DA RID: 96474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040178DB RID: 96475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040178DC RID: 96476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040178DD RID: 96477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040178DE RID: 96478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040178DF RID: 96479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040178E0 RID: 96480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;
}
