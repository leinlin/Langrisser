using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020013A6 RID: 5030
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BattleMapUIController : LuaObject
{
	// Token: 0x0601B990 RID: 113040 RVA: 0x00866B5C File Offset: 0x00864D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			battleMapUIController.Initialize(clientBattle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B991 RID: 113041 RVA: 0x00866BB4 File Offset: 0x00864DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.PrepareBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B992 RID: 113042 RVA: 0x00866C00 File Offset: 0x00864E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.StartBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B993 RID: 113043 RVA: 0x00866C4C File Offset: 0x00864E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StopBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.StopBattle();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B994 RID: 113044 RVA: 0x00866C98 File Offset: 0x00864E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GridPosition startPos;
			LuaObject.checkValueType<GridPosition>(l, 2, out startPos);
			battleMapUIController.ShowRegion(startPos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B995 RID: 113045 RVA: 0x00866CF0 File Offset: 0x00864EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.HideRegion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B996 RID: 113046 RVA: 0x00866D3C File Offset: 0x00864F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowDangerRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			HashSet<GridPosition> region;
			LuaObject.checkType<HashSet<GridPosition>>(l, 2, out region);
			battleMapUIController.ShowDangerRegion(region);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B997 RID: 113047 RVA: 0x00866D94 File Offset: 0x00864F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideDangerRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.HideDangerRegion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B998 RID: 113048 RVA: 0x00866DE0 File Offset: 0x00864FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowReachRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			List<GridPosition> region;
			LuaObject.checkType<List<GridPosition>>(l, 2, out region);
			battleMapUIController.ShowReachRegion(region);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B999 RID: 113049 RVA: 0x00866E38 File Offset: 0x00865038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideReachRegion(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.HideReachRegion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B99A RID: 113050 RVA: 0x00866E84 File Offset: 0x00865084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowMovePath(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			List<GridPosition> path;
			LuaObject.checkType<List<GridPosition>>(l, 2, out path);
			battleMapUIController.ShowMovePath(path);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B99B RID: 113051 RVA: 0x00866EDC File Offset: 0x008650DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideMovePath(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.HideMovePath();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B99C RID: 113052 RVA: 0x00866F28 File Offset: 0x00865128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowStagePosition(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			StagePositionType posType;
			LuaObject.checkEnum<StagePositionType>(l, 2, out posType);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 3, out pos);
			bool on;
			LuaObject.checkType(l, 4, out on);
			battleMapUIController.ShowStagePosition(posType, pos, on);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B99D RID: 113053 RVA: 0x00866F9C File Offset: 0x0086519C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideStagePositions(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.HideStagePositions();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B99E RID: 113054 RVA: 0x00866FE8 File Offset: 0x008651E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayOnStageFx(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			StagePositionType posType;
			LuaObject.checkEnum<StagePositionType>(l, 2, out posType);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 3, out pos);
			battleMapUIController.PlayOnStageFx(posType, pos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B99F RID: 113055 RVA: 0x0086704C File Offset: 0x0086524C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkillFadeIn(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			float alpha;
			LuaObject.checkType(l, 3, out alpha);
			battleMapUIController.SkillFadeIn(time, alpha);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9A0 RID: 113056 RVA: 0x008670B0 File Offset: 0x008652B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SkillFadeOut(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			battleMapUIController.SkillFadeOut(time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9A1 RID: 113057 RVA: 0x00867108 File Offset: 0x00865308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowZoomFade(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GridPosition startPos;
			LuaObject.checkValueType<GridPosition>(l, 2, out startPos);
			float fadeDuration;
			LuaObject.checkType(l, 3, out fadeDuration);
			bool fadeIn;
			LuaObject.checkType(l, 4, out fadeIn);
			battleMapUIController.ShowZoomFade(startPos, fadeDuration, fadeIn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9A2 RID: 113058 RVA: 0x0086717C File Offset: 0x0086537C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsShowZoomFade(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			bool b = battleMapUIController.IsShowZoomFade();
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

	// Token: 0x0601B9A3 RID: 113059 RVA: 0x008671D0 File Offset: 0x008653D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.m_luaExportHelper.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9A4 RID: 113060 RVA: 0x00867224 File Offset: 0x00865424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateZoomFade(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			battleMapUIController.m_luaExportHelper.UpdateZoomFade(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9A5 RID: 113061 RVA: 0x00867280 File Offset: 0x00865480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideFade(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.m_luaExportHelper.HideFade();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9A6 RID: 113062 RVA: 0x008672D4 File Offset: 0x008654D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetFade(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			float fade;
			LuaObject.checkType(l, 2, out fade);
			battleMapUIController.m_luaExportHelper.SetFade(fade);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9A7 RID: 113063 RVA: 0x00867330 File Offset: 0x00865530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateFade(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			float dt;
			LuaObject.checkType(l, 2, out dt);
			battleMapUIController.m_luaExportHelper.UpdateFade(dt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9A8 RID: 113064 RVA: 0x0086738C File Offset: 0x0086558C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FullZoomFade(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.m_luaExportHelper.FullZoomFade();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9A9 RID: 113065 RVA: 0x008673E0 File Offset: 0x008655E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideZoomFade(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.m_luaExportHelper.HideZoomFade();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9AA RID: 113066 RVA: 0x00867434 File Offset: 0x00865634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StagePositionToWorldPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 2, out pos);
			Vector3 o = battleMapUIController.m_luaExportHelper.StagePositionToWorldPosition(pos);
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

	// Token: 0x0601B9AB RID: 113067 RVA: 0x0086749C File Offset: 0x0086569C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GridPositionToWorldPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GridPosition p;
			LuaObject.checkValueType<GridPosition>(l, 2, out p);
			float z;
			LuaObject.checkType(l, 3, out z);
			Vector3 o = battleMapUIController.m_luaExportHelper.GridPositionToWorldPosition(p, z);
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

	// Token: 0x0601B9AC RID: 113068 RVA: 0x00867510 File Offset: 0x00865710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			battleMapUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9AD RID: 113069 RVA: 0x0086757C File Offset: 0x0086577C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9AE RID: 113070 RVA: 0x008675D0 File Offset: 0x008657D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9AF RID: 113071 RVA: 0x00867624 File Offset: 0x00865824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = battleMapUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B9B0 RID: 113072 RVA: 0x008676CC File Offset: 0x008658CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			battleMapUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9B1 RID: 113073 RVA: 0x00867720 File Offset: 0x00865920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			battleMapUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9B2 RID: 113074 RVA: 0x0086778C File Offset: 0x0086598C
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
				BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				battleMapUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				BattleMapUIController battleMapUIController2 = (BattleMapUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				battleMapUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B9B3 RID: 113075 RVA: 0x0086789C File Offset: 0x00865A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleMapUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9B4 RID: 113076 RVA: 0x00867908 File Offset: 0x00865B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9B5 RID: 113077 RVA: 0x00867974 File Offset: 0x00865B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9B6 RID: 113078 RVA: 0x008679E0 File Offset: 0x00865BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			battleMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9B7 RID: 113079 RVA: 0x00867A4C File Offset: 0x00865C4C
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
				BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				battleMapUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				BattleMapUIController battleMapUIController2 = (BattleMapUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				battleMapUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B9B8 RID: 113080 RVA: 0x00867B5C File Offset: 0x00865D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			string s = battleMapUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B9B9 RID: 113081 RVA: 0x00867BB8 File Offset: 0x00865DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddChildPrefab_s(IntPtr l)
	{
		int result;
		try
		{
			GameObject go;
			LuaObject.checkType<GameObject>(l, 1, out go);
			string assetName;
			LuaObject.checkType(l, 2, out assetName);
			BattleMapUIController.LuaExportHelper.AddChildPrefab(go, assetName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9BA RID: 113082 RVA: 0x00867C10 File Offset: 0x00865E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInRegion_s(IntPtr l)
	{
		int result;
		try
		{
			int x;
			LuaObject.checkType(l, 1, out x);
			int y;
			LuaObject.checkType(l, 2, out y);
			HashSet<GridPosition> region;
			LuaObject.checkType<HashSet<GridPosition>>(l, 3, out region);
			bool b = BattleMapUIController.LuaExportHelper.IsInRegion(x, y, region);
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

	// Token: 0x0601B9BB RID: 113083 RVA: 0x00867C80 File Offset: 0x00865E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_clientBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9BC RID: 113084 RVA: 0x00867CD8 File Offset: 0x00865ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clientBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			ClientBattle clientBattle;
			LuaObject.checkType<ClientBattle>(l, 2, out clientBattle);
			battleMapUIController.m_luaExportHelper.m_clientBattle = clientBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9BD RID: 113085 RVA: 0x00867D34 File Offset: 0x00865F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_moveGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_moveGridPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9BE RID: 113086 RVA: 0x00867D8C File Offset: 0x00865F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_moveGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool<RegionGridEffect> moveGridPool;
			LuaObject.checkType<GameObjectPool<RegionGridEffect>>(l, 2, out moveGridPool);
			battleMapUIController.m_luaExportHelper.m_moveGridPool = moveGridPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9BF RID: 113087 RVA: 0x00867DE8 File Offset: 0x00865FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_attackGridPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9C0 RID: 113088 RVA: 0x00867E40 File Offset: 0x00866040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool<RegionGridEffect> attackGridPool;
			LuaObject.checkType<GameObjectPool<RegionGridEffect>>(l, 2, out attackGridPool);
			battleMapUIController.m_luaExportHelper.m_attackGridPool = attackGridPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9C1 RID: 113089 RVA: 0x00867E9C File Offset: 0x0086609C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_skillGridPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9C2 RID: 113090 RVA: 0x00867EF4 File Offset: 0x008660F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool<RegionGridEffect> skillGridPool;
			LuaObject.checkType<GameObjectPool<RegionGridEffect>>(l, 2, out skillGridPool);
			battleMapUIController.m_luaExportHelper.m_skillGridPool = skillGridPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9C3 RID: 113091 RVA: 0x00867F50 File Offset: 0x00866150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teleportGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_teleportGridPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9C4 RID: 113092 RVA: 0x00867FA8 File Offset: 0x008661A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teleportGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool<RegionGridEffect> teleportGridPool;
			LuaObject.checkType<GameObjectPool<RegionGridEffect>>(l, 2, out teleportGridPool);
			battleMapUIController.m_luaExportHelper.m_teleportGridPool = teleportGridPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9C5 RID: 113093 RVA: 0x00868004 File Offset: 0x00866204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_fadeGridPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9C6 RID: 113094 RVA: 0x0086805C File Offset: 0x0086625C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fadeGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool<RegionGridEffect> fadeGridPool;
			LuaObject.checkType<GameObjectPool<RegionGridEffect>>(l, 2, out fadeGridPool);
			battleMapUIController.m_luaExportHelper.m_fadeGridPool = fadeGridPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9C7 RID: 113095 RVA: 0x008680B8 File Offset: 0x008662B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid0Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid0Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9C8 RID: 113096 RVA: 0x00868110 File Offset: 0x00866310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid0Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerEdgeGrid0Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerEdgeGrid0Pool);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid0Pool = dangerEdgeGrid0Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9C9 RID: 113097 RVA: 0x0086816C File Offset: 0x0086636C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid1Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9CA RID: 113098 RVA: 0x008681C4 File Offset: 0x008663C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid1Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerEdgeGrid1Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerEdgeGrid1Pool);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1Pool = dangerEdgeGrid1Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9CB RID: 113099 RVA: 0x00868220 File Offset: 0x00866420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid1_1Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_1Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9CC RID: 113100 RVA: 0x00868278 File Offset: 0x00866478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid1_1Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerEdgeGrid1_1Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerEdgeGrid1_1Pool);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_1Pool = dangerEdgeGrid1_1Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9CD RID: 113101 RVA: 0x008682D4 File Offset: 0x008664D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid1_2Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_2Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9CE RID: 113102 RVA: 0x0086832C File Offset: 0x0086652C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid1_2Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerEdgeGrid1_2Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerEdgeGrid1_2Pool);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_2Pool = dangerEdgeGrid1_2Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9CF RID: 113103 RVA: 0x00868388 File Offset: 0x00866588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid1_3Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_3Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9D0 RID: 113104 RVA: 0x008683E0 File Offset: 0x008665E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid1_3Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerEdgeGrid1_3Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerEdgeGrid1_3Pool);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_3Pool = dangerEdgeGrid1_3Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9D1 RID: 113105 RVA: 0x0086843C File Offset: 0x0086663C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid2Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid2Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9D2 RID: 113106 RVA: 0x00868494 File Offset: 0x00866694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid2Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerEdgeGrid2Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerEdgeGrid2Pool);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid2Pool = dangerEdgeGrid2Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9D3 RID: 113107 RVA: 0x008684F0 File Offset: 0x008666F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid2_1Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid2_1Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9D4 RID: 113108 RVA: 0x00868548 File Offset: 0x00866748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid2_1Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerEdgeGrid2_1Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerEdgeGrid2_1Pool);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid2_1Pool = dangerEdgeGrid2_1Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9D5 RID: 113109 RVA: 0x008685A4 File Offset: 0x008667A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid3Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid3Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9D6 RID: 113110 RVA: 0x008685FC File Offset: 0x008667FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid3Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerEdgeGrid3Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerEdgeGrid3Pool);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid3Pool = dangerEdgeGrid3Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9D7 RID: 113111 RVA: 0x00868658 File Offset: 0x00866858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid4Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid4Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9D8 RID: 113112 RVA: 0x008686B0 File Offset: 0x008668B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid4Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerEdgeGrid4Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerEdgeGrid4Pool);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid4Pool = dangerEdgeGrid4Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9D9 RID: 113113 RVA: 0x0086870C File Offset: 0x0086690C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid5Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid5Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9DA RID: 113114 RVA: 0x00868764 File Offset: 0x00866964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid5Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerEdgeGrid5Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerEdgeGrid5Pool);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid5Pool = dangerEdgeGrid5Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9DB RID: 113115 RVA: 0x008687C0 File Offset: 0x008669C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerCornerGrid1Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerCornerGrid1Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9DC RID: 113116 RVA: 0x00868818 File Offset: 0x00866A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerCornerGrid1Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerCornerGrid1Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerCornerGrid1Pool);
			battleMapUIController.m_luaExportHelper.m_dangerCornerGrid1Pool = dangerCornerGrid1Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9DD RID: 113117 RVA: 0x00868874 File Offset: 0x00866A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerCornerGrid2Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerCornerGrid2Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9DE RID: 113118 RVA: 0x008688CC File Offset: 0x00866ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerCornerGrid2Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerCornerGrid2Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerCornerGrid2Pool);
			battleMapUIController.m_luaExportHelper.m_dangerCornerGrid2Pool = dangerCornerGrid2Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9DF RID: 113119 RVA: 0x00868928 File Offset: 0x00866B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerCornerGrid3Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerCornerGrid3Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9E0 RID: 113120 RVA: 0x00868980 File Offset: 0x00866B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerCornerGrid3Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerCornerGrid3Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerCornerGrid3Pool);
			battleMapUIController.m_luaExportHelper.m_dangerCornerGrid3Pool = dangerCornerGrid3Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9E1 RID: 113121 RVA: 0x008689DC File Offset: 0x00866BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerCornerGrid4Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerCornerGrid4Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9E2 RID: 113122 RVA: 0x00868A34 File Offset: 0x00866C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerCornerGrid4Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerCornerGrid4Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerCornerGrid4Pool);
			battleMapUIController.m_luaExportHelper.m_dangerCornerGrid4Pool = dangerCornerGrid4Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9E3 RID: 113123 RVA: 0x00868A90 File Offset: 0x00866C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerCornerGrid5Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerCornerGrid5Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9E4 RID: 113124 RVA: 0x00868AE8 File Offset: 0x00866CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerCornerGrid5Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool dangerCornerGrid5Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out dangerCornerGrid5Pool);
			battleMapUIController.m_luaExportHelper.m_dangerCornerGrid5Pool = dangerCornerGrid5Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9E5 RID: 113125 RVA: 0x00868B44 File Offset: 0x00866D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_reachGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_reachGridPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9E6 RID: 113126 RVA: 0x00868B9C File Offset: 0x00866D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_reachGridPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool reachGridPool;
			LuaObject.checkType<GameObjectPool>(l, 2, out reachGridPool);
			battleMapUIController.m_luaExportHelper.m_reachGridPool = reachGridPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9E7 RID: 113127 RVA: 0x00868BF8 File Offset: 0x00866DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stagePosition0Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_stagePosition0Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9E8 RID: 113128 RVA: 0x00868C50 File Offset: 0x00866E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stagePosition0Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool stagePosition0Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out stagePosition0Pool);
			battleMapUIController.m_luaExportHelper.m_stagePosition0Pool = stagePosition0Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9E9 RID: 113129 RVA: 0x00868CAC File Offset: 0x00866EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stagePosition1Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_stagePosition1Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9EA RID: 113130 RVA: 0x00868D04 File Offset: 0x00866F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stagePosition1Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool stagePosition1Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out stagePosition1Pool);
			battleMapUIController.m_luaExportHelper.m_stagePosition1Pool = stagePosition1Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9EB RID: 113131 RVA: 0x00868D60 File Offset: 0x00866F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_stagePosition2Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_stagePosition2Pool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9EC RID: 113132 RVA: 0x00868DB8 File Offset: 0x00866FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_stagePosition2Pool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool stagePosition2Pool;
			LuaObject.checkType<GameObjectPool>(l, 2, out stagePosition2Pool);
			battleMapUIController.m_luaExportHelper.m_stagePosition2Pool = stagePosition2Pool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9ED RID: 113133 RVA: 0x00868E14 File Offset: 0x00867014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arrowHeadPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_arrowHeadPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9EE RID: 113134 RVA: 0x00868E6C File Offset: 0x0086706C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arrowHeadPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool arrowHeadPool;
			LuaObject.checkType<GameObjectPool>(l, 2, out arrowHeadPool);
			battleMapUIController.m_luaExportHelper.m_arrowHeadPool = arrowHeadPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9EF RID: 113135 RVA: 0x00868EC8 File Offset: 0x008670C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arrowEndPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_arrowEndPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9F0 RID: 113136 RVA: 0x00868F20 File Offset: 0x00867120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arrowEndPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool arrowEndPool;
			LuaObject.checkType<GameObjectPool>(l, 2, out arrowEndPool);
			battleMapUIController.m_luaExportHelper.m_arrowEndPool = arrowEndPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9F1 RID: 113137 RVA: 0x00868F7C File Offset: 0x0086717C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arrowCornerPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_arrowCornerPool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9F2 RID: 113138 RVA: 0x00868FD4 File Offset: 0x008671D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arrowCornerPool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool arrowCornerPool;
			LuaObject.checkType<GameObjectPool>(l, 2, out arrowCornerPool);
			battleMapUIController.m_luaExportHelper.m_arrowCornerPool = arrowCornerPool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9F3 RID: 113139 RVA: 0x00869030 File Offset: 0x00867230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arrowLinePool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_arrowLinePool);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9F4 RID: 113140 RVA: 0x00869088 File Offset: 0x00867288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arrowLinePool(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObjectPool arrowLinePool;
			LuaObject.checkType<GameObjectPool>(l, 2, out arrowLinePool);
			battleMapUIController.m_luaExportHelper.m_arrowLinePool = arrowLinePool;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9F5 RID: 113141 RVA: 0x008690E4 File Offset: 0x008672E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isFadeIn(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_isFadeIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9F6 RID: 113142 RVA: 0x0086913C File Offset: 0x0086733C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isFadeIn(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			bool isFadeIn;
			LuaObject.checkType(l, 2, out isFadeIn);
			battleMapUIController.m_luaExportHelper.m_isFadeIn = isFadeIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9F7 RID: 113143 RVA: 0x00869198 File Offset: 0x00867398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeCurTime(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_fadeCurTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9F8 RID: 113144 RVA: 0x008691F0 File Offset: 0x008673F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fadeCurTime(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			float fadeCurTime;
			LuaObject.checkType(l, 2, out fadeCurTime);
			battleMapUIController.m_luaExportHelper.m_fadeCurTime = fadeCurTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9F9 RID: 113145 RVA: 0x0086924C File Offset: 0x0086744C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeDuration(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_fadeDuration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9FA RID: 113146 RVA: 0x008692A4 File Offset: 0x008674A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fadeDuration(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			float fadeDuration;
			LuaObject.checkType(l, 2, out fadeDuration);
			battleMapUIController.m_luaExportHelper.m_fadeDuration = fadeDuration;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9FB RID: 113147 RVA: 0x00869300 File Offset: 0x00867500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeMaterial(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_fadeMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9FC RID: 113148 RVA: 0x00869358 File Offset: 0x00867558
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fadeMaterial(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			Material fadeMaterial;
			LuaObject.checkType<Material>(l, 2, out fadeMaterial);
			battleMapUIController.m_luaExportHelper.m_fadeMaterial = fadeMaterial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9FD RID: 113149 RVA: 0x008693B4 File Offset: 0x008675B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeColor(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_fadeColor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9FE RID: 113150 RVA: 0x0086940C File Offset: 0x0086760C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fadeColor(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			Color fadeColor;
			LuaObject.checkType(l, 2, out fadeColor);
			battleMapUIController.m_luaExportHelper.m_fadeColor = fadeColor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B9FF RID: 113151 RVA: 0x00869468 File Offset: 0x00867668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isZoomFadeIn(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_isZoomFadeIn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA00 RID: 113152 RVA: 0x008694C0 File Offset: 0x008676C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isZoomFadeIn(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			bool isZoomFadeIn;
			LuaObject.checkType(l, 2, out isZoomFadeIn);
			battleMapUIController.m_luaExportHelper.m_isZoomFadeIn = isZoomFadeIn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA01 RID: 113153 RVA: 0x0086951C File Offset: 0x0086771C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_zoomFadeCurTime(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_zoomFadeCurTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA02 RID: 113154 RVA: 0x00869574 File Offset: 0x00867774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_zoomFadeCurTime(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			float zoomFadeCurTime;
			LuaObject.checkType(l, 2, out zoomFadeCurTime);
			battleMapUIController.m_luaExportHelper.m_zoomFadeCurTime = zoomFadeCurTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA03 RID: 113155 RVA: 0x008695D0 File Offset: 0x008677D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_zoomFadeDuration(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_zoomFadeDuration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA04 RID: 113156 RVA: 0x00869628 File Offset: 0x00867828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_zoomFadeDuration(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			float zoomFadeDuration;
			LuaObject.checkType(l, 2, out zoomFadeDuration);
			battleMapUIController.m_luaExportHelper.m_zoomFadeDuration = zoomFadeDuration;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA05 RID: 113157 RVA: 0x00869684 File Offset: 0x00867884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_gridGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_gridGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA06 RID: 113158 RVA: 0x008696DC File Offset: 0x008678DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_gridGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject gridGameObject;
			LuaObject.checkType<GameObject>(l, 2, out gridGameObject);
			battleMapUIController.m_luaExportHelper.m_gridGameObject = gridGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA07 RID: 113159 RVA: 0x00869738 File Offset: 0x00867938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_fadeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA08 RID: 113160 RVA: 0x00869790 File Offset: 0x00867990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fadeGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject fadeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out fadeGameObject);
			battleMapUIController.m_luaExportHelper.m_fadeGameObject = fadeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA09 RID: 113161 RVA: 0x008697EC File Offset: 0x008679EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_zoomFadeGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_zoomFadeGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA0A RID: 113162 RVA: 0x00869844 File Offset: 0x00867A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_zoomFadeGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject zoomFadeGameObject;
			LuaObject.checkType<GameObject>(l, 2, out zoomFadeGameObject);
			battleMapUIController.m_luaExportHelper.m_zoomFadeGameObject = zoomFadeGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA0B RID: 113163 RVA: 0x008698A0 File Offset: 0x00867AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_zoomFadeFullGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_zoomFadeFullGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA0C RID: 113164 RVA: 0x008698F8 File Offset: 0x00867AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_zoomFadeFullGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject zoomFadeFullGameObject;
			LuaObject.checkType<GameObject>(l, 2, out zoomFadeFullGameObject);
			battleMapUIController.m_luaExportHelper.m_zoomFadeFullGameObject = zoomFadeFullGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA0D RID: 113165 RVA: 0x00869954 File Offset: 0x00867B54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA0E RID: 113166 RVA: 0x008699AC File Offset: 0x00867BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			battleMapUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA0F RID: 113167 RVA: 0x00869A08 File Offset: 0x00867C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_moveGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_moveGridPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA10 RID: 113168 RVA: 0x00869A60 File Offset: 0x00867C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_moveGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject moveGridPrefab;
			LuaObject.checkType<GameObject>(l, 2, out moveGridPrefab);
			battleMapUIController.m_luaExportHelper.m_moveGridPrefab = moveGridPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA11 RID: 113169 RVA: 0x00869ABC File Offset: 0x00867CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_attackGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_attackGridPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA12 RID: 113170 RVA: 0x00869B14 File Offset: 0x00867D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_attackGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject attackGridPrefab;
			LuaObject.checkType<GameObject>(l, 2, out attackGridPrefab);
			battleMapUIController.m_luaExportHelper.m_attackGridPrefab = attackGridPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA13 RID: 113171 RVA: 0x00869B70 File Offset: 0x00867D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_skillGridPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA14 RID: 113172 RVA: 0x00869BC8 File Offset: 0x00867DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject skillGridPrefab;
			LuaObject.checkType<GameObject>(l, 2, out skillGridPrefab);
			battleMapUIController.m_luaExportHelper.m_skillGridPrefab = skillGridPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA15 RID: 113173 RVA: 0x00869C24 File Offset: 0x00867E24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teleportGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_teleportGridPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA16 RID: 113174 RVA: 0x00869C7C File Offset: 0x00867E7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teleportGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject teleportGridPrefab;
			LuaObject.checkType<GameObject>(l, 2, out teleportGridPrefab);
			battleMapUIController.m_luaExportHelper.m_teleportGridPrefab = teleportGridPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA17 RID: 113175 RVA: 0x00869CD8 File Offset: 0x00867ED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fadeGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_fadeGridPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA18 RID: 113176 RVA: 0x00869D30 File Offset: 0x00867F30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fadeGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject fadeGridPrefab;
			LuaObject.checkType<GameObject>(l, 2, out fadeGridPrefab);
			battleMapUIController.m_luaExportHelper.m_fadeGridPrefab = fadeGridPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA19 RID: 113177 RVA: 0x00869D8C File Offset: 0x00867F8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_reachGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_reachGridPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA1A RID: 113178 RVA: 0x00869DE4 File Offset: 0x00867FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_reachGridPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject reachGridPrefab;
			LuaObject.checkType<GameObject>(l, 2, out reachGridPrefab);
			battleMapUIController.m_luaExportHelper.m_reachGridPrefab = reachGridPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA1B RID: 113179 RVA: 0x00869E40 File Offset: 0x00868040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arrowHeadPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_arrowHeadPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA1C RID: 113180 RVA: 0x00869E98 File Offset: 0x00868098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arrowHeadPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject arrowHeadPrefab;
			LuaObject.checkType<GameObject>(l, 2, out arrowHeadPrefab);
			battleMapUIController.m_luaExportHelper.m_arrowHeadPrefab = arrowHeadPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA1D RID: 113181 RVA: 0x00869EF4 File Offset: 0x008680F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arrowEndPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_arrowEndPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA1E RID: 113182 RVA: 0x00869F4C File Offset: 0x0086814C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arrowEndPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject arrowEndPrefab;
			LuaObject.checkType<GameObject>(l, 2, out arrowEndPrefab);
			battleMapUIController.m_luaExportHelper.m_arrowEndPrefab = arrowEndPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA1F RID: 113183 RVA: 0x00869FA8 File Offset: 0x008681A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arrowCornerPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_arrowCornerPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA20 RID: 113184 RVA: 0x0086A000 File Offset: 0x00868200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arrowCornerPrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject arrowCornerPrefab;
			LuaObject.checkType<GameObject>(l, 2, out arrowCornerPrefab);
			battleMapUIController.m_luaExportHelper.m_arrowCornerPrefab = arrowCornerPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA21 RID: 113185 RVA: 0x0086A05C File Offset: 0x0086825C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arrowLinePrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_arrowLinePrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA22 RID: 113186 RVA: 0x0086A0B4 File Offset: 0x008682B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arrowLinePrefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject arrowLinePrefab;
			LuaObject.checkType<GameObject>(l, 2, out arrowLinePrefab);
			battleMapUIController.m_luaExportHelper.m_arrowLinePrefab = arrowLinePrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA23 RID: 113187 RVA: 0x0086A110 File Offset: 0x00868310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid0Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid0Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA24 RID: 113188 RVA: 0x0086A168 File Offset: 0x00868368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid0Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerEdgeGrid0Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerEdgeGrid0Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid0Prefab = dangerEdgeGrid0Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA25 RID: 113189 RVA: 0x0086A1C4 File Offset: 0x008683C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA26 RID: 113190 RVA: 0x0086A21C File Offset: 0x0086841C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerEdgeGrid1Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerEdgeGrid1Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1Prefab = dangerEdgeGrid1Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA27 RID: 113191 RVA: 0x0086A278 File Offset: 0x00868478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid1_1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_1Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA28 RID: 113192 RVA: 0x0086A2D0 File Offset: 0x008684D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid1_1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerEdgeGrid1_1Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerEdgeGrid1_1Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_1Prefab = dangerEdgeGrid1_1Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA29 RID: 113193 RVA: 0x0086A32C File Offset: 0x0086852C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid1_2Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_2Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA2A RID: 113194 RVA: 0x0086A384 File Offset: 0x00868584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid1_2Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerEdgeGrid1_2Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerEdgeGrid1_2Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_2Prefab = dangerEdgeGrid1_2Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA2B RID: 113195 RVA: 0x0086A3E0 File Offset: 0x008685E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid1_3Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_3Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA2C RID: 113196 RVA: 0x0086A438 File Offset: 0x00868638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid1_3Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerEdgeGrid1_3Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerEdgeGrid1_3Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid1_3Prefab = dangerEdgeGrid1_3Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA2D RID: 113197 RVA: 0x0086A494 File Offset: 0x00868694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid2Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid2Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA2E RID: 113198 RVA: 0x0086A4EC File Offset: 0x008686EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid2Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerEdgeGrid2Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerEdgeGrid2Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid2Prefab = dangerEdgeGrid2Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA2F RID: 113199 RVA: 0x0086A548 File Offset: 0x00868748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid2_1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid2_1Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA30 RID: 113200 RVA: 0x0086A5A0 File Offset: 0x008687A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid2_1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerEdgeGrid2_1Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerEdgeGrid2_1Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid2_1Prefab = dangerEdgeGrid2_1Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA31 RID: 113201 RVA: 0x0086A5FC File Offset: 0x008687FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid3Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid3Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA32 RID: 113202 RVA: 0x0086A654 File Offset: 0x00868854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid3Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerEdgeGrid3Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerEdgeGrid3Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid3Prefab = dangerEdgeGrid3Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA33 RID: 113203 RVA: 0x0086A6B0 File Offset: 0x008688B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid4Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid4Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA34 RID: 113204 RVA: 0x0086A708 File Offset: 0x00868908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid4Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerEdgeGrid4Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerEdgeGrid4Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid4Prefab = dangerEdgeGrid4Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA35 RID: 113205 RVA: 0x0086A764 File Offset: 0x00868964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerEdgeGrid5Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid5Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA36 RID: 113206 RVA: 0x0086A7BC File Offset: 0x008689BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerEdgeGrid5Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerEdgeGrid5Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerEdgeGrid5Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerEdgeGrid5Prefab = dangerEdgeGrid5Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA37 RID: 113207 RVA: 0x0086A818 File Offset: 0x00868A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerCornerGrid1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerCornerGrid1Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA38 RID: 113208 RVA: 0x0086A870 File Offset: 0x00868A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerCornerGrid1Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerCornerGrid1Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerCornerGrid1Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerCornerGrid1Prefab = dangerCornerGrid1Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA39 RID: 113209 RVA: 0x0086A8CC File Offset: 0x00868ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerCornerGrid2Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerCornerGrid2Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA3A RID: 113210 RVA: 0x0086A924 File Offset: 0x00868B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerCornerGrid2Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerCornerGrid2Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerCornerGrid2Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerCornerGrid2Prefab = dangerCornerGrid2Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA3B RID: 113211 RVA: 0x0086A980 File Offset: 0x00868B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerCornerGrid3Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerCornerGrid3Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA3C RID: 113212 RVA: 0x0086A9D8 File Offset: 0x00868BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerCornerGrid3Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerCornerGrid3Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerCornerGrid3Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerCornerGrid3Prefab = dangerCornerGrid3Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA3D RID: 113213 RVA: 0x0086AA34 File Offset: 0x00868C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerCornerGrid4Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerCornerGrid4Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA3E RID: 113214 RVA: 0x0086AA8C File Offset: 0x00868C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerCornerGrid4Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerCornerGrid4Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerCornerGrid4Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerCornerGrid4Prefab = dangerCornerGrid4Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA3F RID: 113215 RVA: 0x0086AAE8 File Offset: 0x00868CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dangerCornerGrid5Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleMapUIController.m_luaExportHelper.m_dangerCornerGrid5Prefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA40 RID: 113216 RVA: 0x0086AB40 File Offset: 0x00868D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dangerCornerGrid5Prefab(IntPtr l)
	{
		int result;
		try
		{
			BattleMapUIController battleMapUIController = (BattleMapUIController)LuaObject.checkSelf(l);
			GameObject dangerCornerGrid5Prefab;
			LuaObject.checkType<GameObject>(l, 2, out dangerCornerGrid5Prefab);
			battleMapUIController.m_luaExportHelper.m_dangerCornerGrid5Prefab = dangerCornerGrid5Prefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601BA41 RID: 113217 RVA: 0x0086AB9C File Offset: 0x00868D9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BattleMapUIController");
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.PrepareBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.StartBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.StopBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.ShowRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.HideRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.ShowDangerRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.HideDangerRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.ShowReachRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.HideReachRegion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.ShowMovePath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.HideMovePath);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.ShowStagePosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.HideStagePositions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.PlayOnStageFx);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.SkillFadeIn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.SkillFadeOut);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.ShowZoomFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.IsShowZoomFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.UpdateZoomFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.HideFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.SetFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.UpdateFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.FullZoomFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.HideZoomFade);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.StagePositionToWorldPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.GridPositionToWorldPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.AddChildPrefab_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.IsInRegion_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2A);
		string name = "m_clientBattle";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_clientBattle);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_clientBattle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2C, true);
		string name2 = "m_moveGridPool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_moveGridPool);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_moveGridPool);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2E, true);
		string name3 = "m_attackGridPool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_attackGridPool);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_attackGridPool);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache30, true);
		string name4 = "m_skillGridPool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_skillGridPool);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_skillGridPool);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache32, true);
		string name5 = "m_teleportGridPool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_teleportGridPool);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_teleportGridPool);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache34, true);
		string name6 = "m_fadeGridPool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_fadeGridPool);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_fadeGridPool);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache36, true);
		string name7 = "m_dangerEdgeGrid0Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid0Pool);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid0Pool);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache38, true);
		string name8 = "m_dangerEdgeGrid1Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid1Pool);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid1Pool);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3A, true);
		string name9 = "m_dangerEdgeGrid1_1Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid1_1Pool);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid1_1Pool);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3C, true);
		string name10 = "m_dangerEdgeGrid1_2Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid1_2Pool);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid1_2Pool);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3E, true);
		string name11 = "m_dangerEdgeGrid1_3Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid1_3Pool);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid1_3Pool);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache40, true);
		string name12 = "m_dangerEdgeGrid2Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid2Pool);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid2Pool);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache42, true);
		string name13 = "m_dangerEdgeGrid2_1Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid2_1Pool);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid2_1Pool);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache44, true);
		string name14 = "m_dangerEdgeGrid3Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid3Pool);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid3Pool);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache46, true);
		string name15 = "m_dangerEdgeGrid4Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid4Pool);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid4Pool);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache48, true);
		string name16 = "m_dangerEdgeGrid5Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid5Pool);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid5Pool);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4A, true);
		string name17 = "m_dangerCornerGrid1Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerCornerGrid1Pool);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerCornerGrid1Pool);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4C, true);
		string name18 = "m_dangerCornerGrid2Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerCornerGrid2Pool);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerCornerGrid2Pool);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4E, true);
		string name19 = "m_dangerCornerGrid3Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerCornerGrid3Pool);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerCornerGrid3Pool);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache50, true);
		string name20 = "m_dangerCornerGrid4Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerCornerGrid4Pool);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerCornerGrid4Pool);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache52, true);
		string name21 = "m_dangerCornerGrid5Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerCornerGrid5Pool);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerCornerGrid5Pool);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache54, true);
		string name22 = "m_reachGridPool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_reachGridPool);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_reachGridPool);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache56, true);
		string name23 = "m_stagePosition0Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_stagePosition0Pool);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_stagePosition0Pool);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache58, true);
		string name24 = "m_stagePosition1Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_stagePosition1Pool);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_stagePosition1Pool);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5A, true);
		string name25 = "m_stagePosition2Pool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_stagePosition2Pool);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_stagePosition2Pool);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5C, true);
		string name26 = "m_arrowHeadPool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_arrowHeadPool);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_arrowHeadPool);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5E, true);
		string name27 = "m_arrowEndPool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_arrowEndPool);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_arrowEndPool);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache60, true);
		string name28 = "m_arrowCornerPool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_arrowCornerPool);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_arrowCornerPool);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache62, true);
		string name29 = "m_arrowLinePool";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_arrowLinePool);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_arrowLinePool);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache64, true);
		string name30 = "m_isFadeIn";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_isFadeIn);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_isFadeIn);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache66, true);
		string name31 = "m_fadeCurTime";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_fadeCurTime);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_fadeCurTime);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache68, true);
		string name32 = "m_fadeDuration";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_fadeDuration);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_fadeDuration);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6A, true);
		string name33 = "m_fadeMaterial";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_fadeMaterial);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_fadeMaterial);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6C, true);
		string name34 = "m_fadeColor";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_fadeColor);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_fadeColor);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6E, true);
		string name35 = "m_isZoomFadeIn";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_isZoomFadeIn);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_isZoomFadeIn);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache70, true);
		string name36 = "m_zoomFadeCurTime";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_zoomFadeCurTime);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_zoomFadeCurTime);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache72, true);
		string name37 = "m_zoomFadeDuration";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_zoomFadeDuration);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_zoomFadeDuration);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache74, true);
		string name38 = "m_gridGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_gridGameObject);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_gridGameObject);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache76, true);
		string name39 = "m_fadeGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_fadeGameObject);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_fadeGameObject);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache78, true);
		string name40 = "m_zoomFadeGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_zoomFadeGameObject);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_zoomFadeGameObject);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7A, true);
		string name41 = "m_zoomFadeFullGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_zoomFadeFullGameObject);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_zoomFadeFullGameObject);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7C, true);
		string name42 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7E, true);
		string name43 = "m_moveGridPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_moveGridPrefab);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_moveGridPrefab);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache80, true);
		string name44 = "m_attackGridPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_attackGridPrefab);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_attackGridPrefab);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache82, true);
		string name45 = "m_skillGridPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_skillGridPrefab);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_skillGridPrefab);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache84, true);
		string name46 = "m_teleportGridPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_teleportGridPrefab);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_teleportGridPrefab);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache86, true);
		string name47 = "m_fadeGridPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_fadeGridPrefab);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_fadeGridPrefab);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache88, true);
		string name48 = "m_reachGridPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_reachGridPrefab);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_reachGridPrefab);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8A, true);
		string name49 = "m_arrowHeadPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_arrowHeadPrefab);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_arrowHeadPrefab);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8C, true);
		string name50 = "m_arrowEndPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_arrowEndPrefab);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_arrowEndPrefab);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8E, true);
		string name51 = "m_arrowCornerPrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_arrowCornerPrefab);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_arrowCornerPrefab);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache90, true);
		string name52 = "m_arrowLinePrefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_arrowLinePrefab);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_arrowLinePrefab);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache92, true);
		string name53 = "m_dangerEdgeGrid0Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid0Prefab);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid0Prefab);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache94, true);
		string name54 = "m_dangerEdgeGrid1Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid1Prefab);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid1Prefab);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache96, true);
		string name55 = "m_dangerEdgeGrid1_1Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid1_1Prefab);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid1_1Prefab);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache98, true);
		string name56 = "m_dangerEdgeGrid1_2Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache99 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache99 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid1_2Prefab);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache99;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9A == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid1_2Prefab);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9A, true);
		string name57 = "m_dangerEdgeGrid1_3Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9B == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid1_3Prefab);
		}
		LuaCSFunction get57 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9B;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9C == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid1_3Prefab);
		}
		LuaObject.addMember(l, name57, get57, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9C, true);
		string name58 = "m_dangerEdgeGrid2Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9D == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid2Prefab);
		}
		LuaCSFunction get58 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9D;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9E == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid2Prefab);
		}
		LuaObject.addMember(l, name58, get58, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9E, true);
		string name59 = "m_dangerEdgeGrid2_1Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9F == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid2_1Prefab);
		}
		LuaCSFunction get59 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cache9F;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid2_1Prefab);
		}
		LuaObject.addMember(l, name59, get59, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA0, true);
		string name60 = "m_dangerEdgeGrid3Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid3Prefab);
		}
		LuaCSFunction get60 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA1;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA2 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid3Prefab);
		}
		LuaObject.addMember(l, name60, get60, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA2, true);
		string name61 = "m_dangerEdgeGrid4Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA3 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid4Prefab);
		}
		LuaCSFunction get61 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA3;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA4 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid4Prefab);
		}
		LuaObject.addMember(l, name61, get61, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA4, true);
		string name62 = "m_dangerEdgeGrid5Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA5 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerEdgeGrid5Prefab);
		}
		LuaCSFunction get62 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA5;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA6 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerEdgeGrid5Prefab);
		}
		LuaObject.addMember(l, name62, get62, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA6, true);
		string name63 = "m_dangerCornerGrid1Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA7 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerCornerGrid1Prefab);
		}
		LuaCSFunction get63 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA7;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA8 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerCornerGrid1Prefab);
		}
		LuaObject.addMember(l, name63, get63, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA8, true);
		string name64 = "m_dangerCornerGrid2Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA9 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerCornerGrid2Prefab);
		}
		LuaCSFunction get64 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheA9;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAA == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerCornerGrid2Prefab);
		}
		LuaObject.addMember(l, name64, get64, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAA, true);
		string name65 = "m_dangerCornerGrid3Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAB == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerCornerGrid3Prefab);
		}
		LuaCSFunction get65 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAB;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAC == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerCornerGrid3Prefab);
		}
		LuaObject.addMember(l, name65, get65, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAC, true);
		string name66 = "m_dangerCornerGrid4Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAD == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerCornerGrid4Prefab);
		}
		LuaCSFunction get66 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAD;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAE == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerCornerGrid4Prefab);
		}
		LuaObject.addMember(l, name66, get66, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAE, true);
		string name67 = "m_dangerCornerGrid5Prefab";
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAF == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.get_m_dangerCornerGrid5Prefab);
		}
		LuaCSFunction get67 = Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheAF;
		if (Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheB0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheB0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BattleMapUIController.set_m_dangerCornerGrid5Prefab);
		}
		LuaObject.addMember(l, name67, get67, Lua_BlackJack_ProjectL_UI_BattleMapUIController.<>f__mg$cacheB0, true);
		LuaObject.createTypeMetatable(l, null, typeof(BattleMapUIController), typeof(UIControllerBase));
	}

	// Token: 0x04011C26 RID: 72742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04011C27 RID: 72743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04011C28 RID: 72744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04011C29 RID: 72745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04011C2A RID: 72746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011C2B RID: 72747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011C2C RID: 72748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011C2D RID: 72749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011C2E RID: 72750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011C2F RID: 72751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011C30 RID: 72752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011C31 RID: 72753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011C32 RID: 72754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011C33 RID: 72755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011C34 RID: 72756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04011C35 RID: 72757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04011C36 RID: 72758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04011C37 RID: 72759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04011C38 RID: 72760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04011C39 RID: 72761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04011C3A RID: 72762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011C3B RID: 72763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011C3C RID: 72764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011C3D RID: 72765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011C3E RID: 72766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011C3F RID: 72767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011C40 RID: 72768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011C41 RID: 72769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011C42 RID: 72770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011C43 RID: 72771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011C44 RID: 72772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011C45 RID: 72773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04011C46 RID: 72774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04011C47 RID: 72775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04011C48 RID: 72776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04011C49 RID: 72777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04011C4A RID: 72778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04011C4B RID: 72779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011C4C RID: 72780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011C4D RID: 72781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011C4E RID: 72782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011C4F RID: 72783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011C50 RID: 72784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011C51 RID: 72785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011C52 RID: 72786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04011C53 RID: 72787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04011C54 RID: 72788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04011C55 RID: 72789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04011C56 RID: 72790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04011C57 RID: 72791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04011C58 RID: 72792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04011C59 RID: 72793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04011C5A RID: 72794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04011C5B RID: 72795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04011C5C RID: 72796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04011C5D RID: 72797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04011C5E RID: 72798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04011C5F RID: 72799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04011C60 RID: 72800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04011C61 RID: 72801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04011C62 RID: 72802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04011C63 RID: 72803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04011C64 RID: 72804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04011C65 RID: 72805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04011C66 RID: 72806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04011C67 RID: 72807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04011C68 RID: 72808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04011C69 RID: 72809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04011C6A RID: 72810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04011C6B RID: 72811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04011C6C RID: 72812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04011C6D RID: 72813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04011C6E RID: 72814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04011C6F RID: 72815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04011C70 RID: 72816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04011C71 RID: 72817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04011C72 RID: 72818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04011C73 RID: 72819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04011C74 RID: 72820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04011C75 RID: 72821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04011C76 RID: 72822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04011C77 RID: 72823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04011C78 RID: 72824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04011C79 RID: 72825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04011C7A RID: 72826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04011C7B RID: 72827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04011C7C RID: 72828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04011C7D RID: 72829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04011C7E RID: 72830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04011C7F RID: 72831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04011C80 RID: 72832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04011C81 RID: 72833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04011C82 RID: 72834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04011C83 RID: 72835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04011C84 RID: 72836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04011C85 RID: 72837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04011C86 RID: 72838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04011C87 RID: 72839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04011C88 RID: 72840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04011C89 RID: 72841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04011C8A RID: 72842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04011C8B RID: 72843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04011C8C RID: 72844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04011C8D RID: 72845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04011C8E RID: 72846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04011C8F RID: 72847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04011C90 RID: 72848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04011C91 RID: 72849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04011C92 RID: 72850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04011C93 RID: 72851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04011C94 RID: 72852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04011C95 RID: 72853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04011C96 RID: 72854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04011C97 RID: 72855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04011C98 RID: 72856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04011C99 RID: 72857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04011C9A RID: 72858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04011C9B RID: 72859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04011C9C RID: 72860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04011C9D RID: 72861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04011C9E RID: 72862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04011C9F RID: 72863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04011CA0 RID: 72864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04011CA1 RID: 72865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04011CA2 RID: 72866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04011CA3 RID: 72867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04011CA4 RID: 72868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04011CA5 RID: 72869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04011CA6 RID: 72870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04011CA7 RID: 72871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04011CA8 RID: 72872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04011CA9 RID: 72873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04011CAA RID: 72874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04011CAB RID: 72875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04011CAC RID: 72876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04011CAD RID: 72877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04011CAE RID: 72878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04011CAF RID: 72879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04011CB0 RID: 72880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04011CB1 RID: 72881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04011CB2 RID: 72882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04011CB3 RID: 72883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04011CB4 RID: 72884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04011CB5 RID: 72885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04011CB6 RID: 72886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04011CB7 RID: 72887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04011CB8 RID: 72888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04011CB9 RID: 72889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04011CBA RID: 72890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04011CBB RID: 72891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04011CBC RID: 72892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04011CBD RID: 72893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04011CBE RID: 72894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;

	// Token: 0x04011CBF RID: 72895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache99;

	// Token: 0x04011CC0 RID: 72896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9A;

	// Token: 0x04011CC1 RID: 72897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9B;

	// Token: 0x04011CC2 RID: 72898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9C;

	// Token: 0x04011CC3 RID: 72899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9D;

	// Token: 0x04011CC4 RID: 72900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9E;

	// Token: 0x04011CC5 RID: 72901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9F;

	// Token: 0x04011CC6 RID: 72902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA0;

	// Token: 0x04011CC7 RID: 72903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA1;

	// Token: 0x04011CC8 RID: 72904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA2;

	// Token: 0x04011CC9 RID: 72905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA3;

	// Token: 0x04011CCA RID: 72906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA4;

	// Token: 0x04011CCB RID: 72907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA5;

	// Token: 0x04011CCC RID: 72908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA6;

	// Token: 0x04011CCD RID: 72909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA7;

	// Token: 0x04011CCE RID: 72910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA8;

	// Token: 0x04011CCF RID: 72911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA9;

	// Token: 0x04011CD0 RID: 72912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAA;

	// Token: 0x04011CD1 RID: 72913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAB;

	// Token: 0x04011CD2 RID: 72914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAC;

	// Token: 0x04011CD3 RID: 72915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAD;

	// Token: 0x04011CD4 RID: 72916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAE;

	// Token: 0x04011CD5 RID: 72917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheAF;

	// Token: 0x04011CD6 RID: 72918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB0;
}
